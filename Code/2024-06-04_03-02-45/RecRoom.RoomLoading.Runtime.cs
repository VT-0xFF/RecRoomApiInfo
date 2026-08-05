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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EE1460", Offset = "0x6EDFC60", VA = "0x186EE1460")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
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
	public class LogRegistrationIndex : IFEEDCBNDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE1D0", Offset = "0x6EDC9D0", VA = "0x186EDE1D0", Slot = "4")]
		public override void MPPLGFJBDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OPFFKGLHEHA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EE21C0", Offset = "0x6EE09C0", VA = "0x186EE21C0")]
	public OPFFKGLHEHA(string CLBGCJICGJG, Exception JFLEAGGNHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class AOMBOJBCJJE : NPAKILOOEAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GHFIJOLPOBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<KEKIJLKKLCL>> <>t__builder;

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
		private TaskAwaiter<IOMDGCJBFDF<KEKIJLKKLCL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1F10", Offset = "0x6ED0710", VA = "0x186ED1F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2150", Offset = "0x6ED0950", VA = "0x186ED2150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct PODGFPOHDGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<HDDPBGJKOCD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<HDDPBGJKOCD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE35E0", Offset = "0x6EE1DE0", VA = "0x186EE35E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE37F0", Offset = "0x6EE1FF0", VA = "0x186EE37F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	[UnityEngine.Scripting.Preserve]
	public AOMBOJBCJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC2E0", Offset = "0x6ECAAE0", VA = "0x186ECC2E0", Slot = "4")]
	[AsyncStateMachine(typeof(GHFIJOLPOBN))]
	public Task<IReadOnlyList<KEKIJLKKLCL>> FONLOALGODA(long LNOJCNCBDMF, long EIPINGDKEKJ, [Optional] CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC1D0", Offset = "0x6ECA9D0", VA = "0x186ECC1D0", Slot = "5")]
	[AsyncStateMachine(typeof(PODGFPOHDGJ))]
	public Task<IReadOnlyList<HDDPBGJKOCD>> DCGBNOHNDBE(IReadOnlyList<int> PIGAPIJNGDC, [Optional] CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EHJDONCDPFI : IEquatable<EHJDONCDPFI>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int IEJIIAABECI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	HDDPBGJKOCD OGBMAODKMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime OEGGIHKBEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	PLEPGDECPNI? ECINGCOCGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BAGCGCEDMOM? LJCOCOBAPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	ALNGNHJBDCE FCLAPLKCKMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<AICFBPACFMB> JPAKNIGFJBB();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum ALNGNHJBDCE
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NPAKILOOEAO
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<KEKIJLKKLCL>> FONLOALGODA(long LNOJCNCBDMF, long EIPINGDKEKJ, [Optional] CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<HDDPBGJKOCD>> DCGBNOHNDBE(IReadOnlyList<int> PIGAPIJNGDC, [Optional] CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JDPBMNHLOBM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class CLPAAOBNFHG : EHJDONCDPFI, IEquatable<EHJDONCDPFI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct AHDECCHJLNE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<AICFBPACFMB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public CLPAAOBNFHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private BEBKPMCLLNB <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<APGABJIFLDK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<AICFBPACFMB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6ECB080", Offset = "0x6EC9880", VA = "0x186ECB080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6ECB520", Offset = "0x6EC9D20", VA = "0x186ECB520", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly KEKIJLKKLCL JAPCPIMMAMG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int IEJIIAABECI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x84F0B0", Offset = "0x84D8B0", VA = "0x18084F0B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HDDPBGJKOCD OGBMAODKMHP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime MNGFFHLGNME
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5AE7C80", Offset = "0x5AE6480", VA = "0x185AE7C80", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PLEPGDECPNI? ECINGCOCGNO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1B9ED00", Offset = "0x1B9D500", VA = "0x181B9ED00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BAGCGCEDMOM? LJCOCOBAPDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5AE7D60", Offset = "0x5AE6560", VA = "0x185AE7D60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ALNGNHJBDCE FCLAPLKCKMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8C4CA0", Offset = "0x8C34A0", VA = "0x1808C4CA0", Slot = "10")]
			get
			{
				return default(ALNGNHJBDCE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6ECEF00", Offset = "0x6ECD700", VA = "0x186ECEF00", Slot = "9")]
		[AsyncStateMachine(typeof(AHDECCHJLNE))]
		public Task<AICFBPACFMB> JPAKNIGFJBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6ECF040", Offset = "0x6ECD840", VA = "0x186ECF040")]
		public CLPAAOBNFHG(int GCFNCHDGKDG, HDDPBGJKOCD ALLIAODGBIN, KEKIJLKKLCL JAPCPIMMAMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6ECED50", Offset = "0x6ECD550", VA = "0x186ECED50", Slot = "11")]
		public bool Equals(EHJDONCDPFI OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6ECEDE0", Offset = "0x6ECD5E0", VA = "0x186ECEDE0", Slot = "0")]
		public override bool Equals(object GHDJADLHPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6ECF000", Offset = "0x6ECD800", VA = "0x186ECF000")]
		private bool PEGCIFJLAPC(CLPAAOBNFHG OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6ECEE80", Offset = "0x6ECD680", VA = "0x186ECEE80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class LJBOIAKANAK : EHJDONCDPFI, IEquatable<EHJDONCDPFI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct BIDALNDNAKB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<AICFBPACFMB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public LJBOIAKANAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<AICFBPACFMB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC400", Offset = "0x6ECAC00", VA = "0x186ECC400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC630", Offset = "0x6ECAE30", VA = "0x186ECC630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly GJKNKHPAHGK FPBMKEHNGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly PLEPGDECPNI BJJJFHNPPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly BAGCGCEDMOM LGFIEJIHDJE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int IEJIIAABECI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD280", Offset = "0x6EDBA80", VA = "0x186EDD280", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public HDDPBGJKOCD OGBMAODKMHP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD000", Offset = "0x6EDB800", VA = "0x186EDD000", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime MNGFFHLGNME
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD090", Offset = "0x6EDB890", VA = "0x186EDD090", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PLEPGDECPNI? ECINGCOCGNO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD430", Offset = "0x6EDBC30", VA = "0x186EDD430", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BAGCGCEDMOM? LJCOCOBAPDO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD0E0", Offset = "0x6EDB8E0", VA = "0x186EDD0E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ALNGNHJBDCE FCLAPLKCKMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8BEAF0", Offset = "0x8BD2F0", VA = "0x1808BEAF0", Slot = "10")]
			get
			{
				return default(ALNGNHJBDCE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x10C6F40", Offset = "0x10C5740", VA = "0x1810C6F40")]
		public LJBOIAKANAK(GJKNKHPAHGK JIBBHHKPIII, PLEPGDECPNI DILIPJPHHKK, BAGCGCEDMOM OBJJOHPLHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD340", Offset = "0x6EDBB40", VA = "0x186EDD340", Slot = "9")]
		[AsyncStateMachine(typeof(BIDALNDNAKB))]
		public Task<AICFBPACFMB> JPAKNIGFJBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD130", Offset = "0x6EDB930", VA = "0x186EDD130", Slot = "11")]
		public bool Equals(EHJDONCDPFI OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD1D0", Offset = "0x6EDB9D0", VA = "0x186EDD1D0", Slot = "0")]
		public override bool Equals(object GHDJADLHPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD480", Offset = "0x6EDBC80", VA = "0x186EDD480")]
		private bool PEGCIFJLAPC(LJBOIAKANAK OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD2C0", Offset = "0x6EDBAC0", VA = "0x186EDD2C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class AJCPHLCILGO : EHJDONCDPFI, IEquatable<EHJDONCDPFI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct GLJLIINKPID : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<AICFBPACFMB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<AICFBPACFMB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6ED21C0", Offset = "0x6ED09C0", VA = "0x186ED21C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6ED2400", Offset = "0x6ED0C00", VA = "0x186ED2400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HDDPBGJKOCD DDPDNOLAOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly PLEPGDECPNI BJJJFHNPPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly BAGCGCEDMOM LGFIEJIHDJE;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int IEJIIAABECI
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6ECB810", Offset = "0x6ECA010", VA = "0x186ECB810", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public HDDPBGJKOCD OGBMAODKMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime MNGFFHLGNME
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PLEPGDECPNI? ECINGCOCGNO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6ECB990", Offset = "0x6ECA190", VA = "0x186ECB990", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BAGCGCEDMOM? LJCOCOBAPDO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6ECB590", Offset = "0x6EC9D90", VA = "0x186ECB590", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ALNGNHJBDCE FCLAPLKCKMG
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "10")]
			get
			{
				return default(ALNGNHJBDCE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x10C6F40", Offset = "0x10C5740", VA = "0x1810C6F40")]
		public AJCPHLCILGO(HDDPBGJKOCD ALLIAODGBIN, PLEPGDECPNI DILIPJPHHKK, BAGCGCEDMOM OBJJOHPLHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB8C0", Offset = "0x6ECA0C0", VA = "0x186ECB8C0", Slot = "9")]
		[AsyncStateMachine(typeof(GLJLIINKPID))]
		public Task<AICFBPACFMB> JPAKNIGFJBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB700", Offset = "0x6EC9F00", VA = "0x186ECB700", Slot = "11")]
		public bool Equals(EHJDONCDPFI OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB5E0", Offset = "0x6EC9DE0", VA = "0x186ECB5E0", Slot = "0")]
		public override bool Equals(object GHDJADLHPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB830", Offset = "0x6ECA030", VA = "0x186ECB830", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB9E0", Offset = "0x6ECA1E0", VA = "0x186ECB9E0")]
		private bool PEGCIFJLAPC(AJCPHLCILGO OGFCKBADKBE)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct KLFDAPKBPCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<EHJDONCDPFI>> <>t__builder;

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
		public JDPBMNHLOBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<KEKIJLKKLCL> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<KEKIJLKKLCL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, HDDPBGJKOCD account, KEKIJLKKLCL roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC1C0", Offset = "0x6EDA9C0", VA = "0x186EDC1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6EDCF90", Offset = "0x6EDB790", VA = "0x186EDCF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct ONPEINPPPHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, HDDPBGJKOCD account, KEKIJLKKLCL roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<KEKIJLKKLCL> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public JDPBMNHLOBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<HDDPBGJKOCD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE1790", Offset = "0x6EDFF90", VA = "0x186EE1790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2150", Offset = "0x6EE0950", VA = "0x186EE2150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KFHDFNJIFDI BPMOHBAHJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly NPAKILOOEAO JJHFPCFPHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JLBKHEFKEBK JGFPEIHMCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CBPJIEKGGMD<(long, long), IReadOnlyList<KEKIJLKKLCL>> BILLDCHKEOB;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB0B0", Offset = "0x6ED98B0", VA = "0x186EDB0B0")]
	[UnityEngine.Scripting.Preserve]
	public JDPBMNHLOBM([GNKLNMHODGG(null)] NPAKILOOEAO LIEIBPGKJBB, [GNKLNMHODGG(null)] JLBKHEFKEBK PIGPOEKKLDI, [GNKLNMHODGG(null)] KFHDFNJIFDI NCODGGKHPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6EDACB0", Offset = "0x6ED94B0", VA = "0x186EDACB0")]
	[AsyncStateMachine(typeof(KLFDAPKBPCD))]
	public Task<IList<EHJDONCDPFI>> BAAPBGHFIGP(long LNOJCNCBDMF, long PMNPMGPNLGO, bool GHIOMOIEDLF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAE00", Offset = "0x6ED9600", VA = "0x186EDAE00")]
	private bool BCKNBGHNAFO(DateTime? IGPEDBDIBDJ, long LNOJCNCBDMF, long PMNPMGPNLGO, [Out] GJKNKHPAHGK OGANCPGOCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAFA0", Offset = "0x6ED97A0", VA = "0x186EDAFA0")]
	[AsyncStateMachine(typeof(ONPEINPPPHF))]
	private Task<IReadOnlyList<(int, HDDPBGJKOCD, KEKIJLKKLCL)>> BKGJGBAJLAE(IReadOnlyList<KEKIJLKKLCL> KLNJNBFFLBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JLBKHEFKEBK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GJKNKHPAHGK> CHOKGJDBJGH;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DHKEFIIAMHM(long LNOJCNCBDMF, long PMNPMGPNLGO, KPAJDCMJFPK EJOKDLGPDNO, JBEOMJBFOMC PFIHPPKOFGJ);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FEGFCMKGMMC(long LNOJCNCBDMF, long PMNPMGPNLGO, [Out] GJKNKHPAHGK OGANCPGOCOB);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EAJGKDABIFA(long LNOJCNCBDMF, long PMNPMGPNLGO, JBEOMJBFOMC PFIHPPKOFGJ, [Out] GJKNKHPAHGK OGANCPGOCOB);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFIDEEPODDB(long LNOJCNCBDMF, long PMNPMGPNLGO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface LEJKMKADKGF : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LJODNKJMGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task BPBMKGEFDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPCBKMKAOEL(Task GECIOHOBBCH, string NDDOPFEBMMA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface MAAKEPCALKG : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AICFBPACFMB> OOCLDJNBCAA(GJKNKHPAHGK OGANCPGOCOB);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FIOILNADMDN(CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface MHNAGLGBMGG : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	OFJKNPELLGL BPNMACEFAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDJOOJFLCLL();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JICLJKNCDCA();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface INOFAJMOCKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface OGGIGJNKKIM
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan OPCDIBNDJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan LFAHABKILKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan EPDMNNFBIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan LNIFIGHPLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NNBCCBLEJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GOGFPBECEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool GEHKEDEHDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int FMBMAHPKPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NKBLIFDILFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool AEIGENKCLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum OLBCBIAAGLD
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum EIAFBOOKIAK
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
public struct CCJHKKFLBHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long DOFPCMDCFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long EIPINGDKEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly OLBCBIAAGLD HKAKMPIMEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception DFEKHJONMHN;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECDB90", Offset = "0x6ECC390", VA = "0x186ECDB90")]
	public CCJHKKFLBHC(long DOFPCMDCFEO, long EIPINGDKEKJ, OLBCBIAAGLD HKAKMPIMEOA, [CanBeNull] Exception DFEKHJONMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECDB40", Offset = "0x6ECC340", VA = "0x186ECDB40")]
	public static CCJHKKFLBHC CGJPOCGNPIB(PCHMOHFEPBH OKJJICCFJFM, OLBCBIAAGLD HKAKMPIMEOA, [Optional] Exception DFEKHJONMHN)
	{
		return default(CCJHKKFLBHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void LCDOLADEOEO(CCJHKKFLBHC NNKKCIJJLCH);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface NGJHANPPHCL : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ACJKCIAFHJC;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LCDOLADEOEO LDICCCIGDMC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event LCDOLADEOEO GDHPGECHOCE;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event LCDOLADEOEO JAJJPJEOOPD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<EIAFBOOKIAK, bool> GIONKCHDCOF;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PPNOLKIBKJH();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HMCOJFPIGFO(CCJHKKFLBHC NNKKCIJJLCH);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LIKECEPKIDG(CCJHKKFLBHC NNKKCIJJLCH);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BNAHGLPCENM(CCJHKKFLBHC NNKKCIJJLCH);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IPJPNCCLNEP(EIAFBOOKIAK LOFAINCFOJE, bool FEJOFHOJCCF);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface CCHENENFKJI : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DDOAFCGOHCE();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENCIEDKEOKG();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface BBBCMAMIAKL : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus PFCMFEBINBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EAFGJNNDHKH(PCHMOHFEPBH KNAECKPPIKB, HDDMNHNKALC GPEBMMOCBOM, CancellationToken OKNLKNIHJFM);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class KEPFIANJOBF
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBF10", Offset = "0x6EDA710", VA = "0x186EDBF10")]
	public static bool DBKGCOEGLBJ(this BBBCMAMIAKL LLFOEDEEOGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task PDNHODGFBMB(KHFFEHOCMIP OLHDNFLDIIE, CancellationToken OECMOOGGOOF);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface GEEBECHPOFO : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLDGMGKIAJG(PDNHODGFBMB KEHGEFKDDIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface KBOGPEMMJMI : BEBKPMCLLNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken CIDJGHMOHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	AANDDJDEEFL DLDDDBNCBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	OPBLEBEBLOF PGBGDFKJOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CDEOBFFIKEB JCJFJAOILBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LJKKFDADBJA BHIHJNCNCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	AJOGJHEJMJF CCAAHHODMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	GIDMKHKFBNB PLGJABPJCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	LIECJJGNCKP MJOFAEHMPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	FFFKLPHHKKG EMNOKFJFIGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	LEJKMKADKGF HKAIFHJFKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	MAAKEPCALKG JJFLPBAFPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	NGJHANPPHCL PENPJHPBNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CCHENENFKJI JPBKPCEKPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	BBBCMAMIAKL OKFHCABFHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GEEBECHPOFO IGBLOOMICOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	BAJCKDCCLBN LLJONICFKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BGMHKJCBOEJ OGEKCJHCLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JHEPMHAOIPM MDMBCFFDDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	NADPPMHPNAO BLPNKCANNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HLMIDPDLNEO JOKDPAGBGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	JDDBKHMCBOJ LJBMMADLBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	OLHPPHFILMA HGKFKOGAGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KFINKBEBLKO FDPGCAEIKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	IHKILCJEHHN ILIJDNFJAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	HBPICLEGDCB PPGJBDDIPOE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	MHNAGLGBMGG PDPJDJHFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	OGGIGJNKKIM ENJEJBLMCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NKANBBPKJBF GLKNJJMNKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	JLBKHEFKEBK APHKJGMCGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	HCNAAKFNJNN GBPMOGEDJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	IGDJMNLBKKF LAOKPDIAEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	MHEKKGCANGA IHHMMDNOMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void NPAGIBDCPDD(HDDMNHNKALC HLCGCAMBKDL);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface BAJCKDCCLBN : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LLIIIKGFJLE CNLMKNIMMKA(Guid KPJLKKPOEPH);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GALPDKBCKMP(Guid KPJLKKPOEPH);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IAABGOMCEFA(Guid KPJLKKPOEPH, Task FJFHBJJIDDB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ONGOEIDJOPI(Guid KPJLKKPOEPH, AICFBPACFMB FFENCBBAPDD);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(AICFBPACFMB, Task)> IJJPHDLCDEE(Guid KPJLKKPOEPH);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface OPDGNECGMMI : INOFAJMOCKL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface BGMHKJCBOEJ : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNKLFEFGGCO(EMALNGGNKEF CLBGCJICGJG);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FACEAFFENKN(EMALNGGNKEF CLBGCJICGJG);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<NJNAHKGLFBJ> FKEGBKFNOMH(CancellationToken LMLBNDBALCE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface JHEPMHAOIPM : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LLIIIKGFJLE MOIHEAIBBGC(EMALNGGNKEF PBEEFAHGGAJ);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFGNMGFHOCM(Guid KPJLKKPOEPH, Task FJFHBJJIDDB);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface NADPPMHPNAO : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AICFBPACFMB> BLPNKCANNDJ(EMALNGGNKEF MIKKGLIBJID);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface HLMIDPDLNEO : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JKENAGDJKCF> AJLIOGGJFBN(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, PCHMOHFEPBH KNAECKPPIKB, CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface OLHPPHFILMA : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AICFBPACFMB JOPEKHFGFFN(KCMOAPDBFGB EPAILNGPKNK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LFCKOFEDNIM(string FKOPBOJEAII);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface JDDBKHMCBOJ : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EMALNGGNKEF> EMDMPELMEJC(EMALNGGNKEF LOGLBHMJLPF, HPGKKJFFMPO AEADNMNGGPI, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<EMALNGGNKEF> JEBGOCDBGPI(CancellationToken ODNHMAMKFFP, HPGKKJFFMPO AEADNMNGGPI);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGOFJPDDCML PIMJEEEMCKP(CIDAEBAGAJA GALLALMLOPN, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FGOFJPDDCML POHHIGAKKKD(CIDAEBAGAJA GALLALMLOPN, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface KFINKBEBLKO : INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AICFBPACFMB KAHNFPOMCJL(KCMOAPDBFGB EPAILNGPKNK, NJNAHKGLFBJ IOKNHBBOAPK);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AICFBPACFMB LDOCKFALECA(KCMOAPDBFGB JODLIPLAEMM);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface IHKILCJEHHN
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCDEOGOIJNB(EOOHLHLAACD KECIAHKHCPC);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJJGGGDNFDO(EOOHLHLAACD KECIAHKHCPC);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKNLEPIIIMB(EOOHLHLAACD KECIAHKHCPC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNHGIAIMCDM(EOOHLHLAACD KECIAHKHCPC);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class EOOHLHLAACD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly PCHMOHFEPBH DAMJFKLCOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> ADKPAAEAMKK;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NLBODGALKPJ<string> FNCJCKCOJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x844F30", Offset = "0x843730", VA = "0x180844F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public EOOHLHLAACD(PCHMOHFEPBH OHIPFKMIAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0F90", Offset = "0x6ECF790", VA = "0x186ED0F90")]
	public EOOHLHLAACD BGLKIMEDGFA(string JOEHGGMHBAA, string IPHHABIKCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1060", Offset = "0x6ECF860", VA = "0x186ED1060")]
	public bool IAGOGOCALOI([Out] IEnumerable<KeyValuePair<string, string>> BIFHIDHCJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x617CAE0", Offset = "0x617B2E0", VA = "0x18617CAE0")]
	public EOOHLHLAACD MJKFHFGMCGP(NLBODGALKPJ<string> JPMGDEGBMJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface NKANBBPKJBF
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool HPLCFNGKJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string NDCDPDDEGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool MEACFJCJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDEGKLCDIOD();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HBPCIOBAOHE COOPNKFKKBK(long EGBMFKCBLOA);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IOMJMIBGPGC<KGMNHEONACL, GMFGEGDFAPN> AEKKMAIOIDN(long EGBMFKCBLOA);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IOMJMIBGPGC<KGMNHEONACL, JGEEHKGDOJK> FEDCDOLNHDB(long EGBMFKCBLOA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IOMJMIBGPGC<long, EJNOBLPAPNM> JPGNGEIONLE();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CMDNAAMFPOO(long EGBMFKCBLOA, [Out] bool BKMCOCNDLIN);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> PBMEFNPBIAM(byte[] KIPPBODDGFF, byte[] GPKEPHGOFMK, CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface BEBKPMCLLNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool DBKGCOEGLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool NLPKHBJIFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	HDDMNHNKALC OKDBFOLMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action ACJKCIAFHJC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event LCDOLADEOEO LDICCCIGDMC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event LCDOLADEOEO GDHPGECHOCE;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event LCDOLADEOEO JAJJPJEOOPD;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<EIAFBOOKIAK, bool> GIONKCHDCOF;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ENCIEDKEOKG();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ICGMBNNGMKC LAEKFEFAOBN();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CPDLBCJHLMO AMDHDDBNCHJ();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<AICFBPACFMB> OOCLDJNBCAA(GJKNKHPAHGK JIBBHHKPIII);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task FIOILNADMDN(CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface AJOGJHEJMJF
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool FILJIPNCAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string KOJGMILGDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPJIKKIKENN(Scene GEHFEIDIMIE);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task GJILBNJOBBB(EKDOJHDBDDL BMINGOCCBDG, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task GKPCKBFFGGL();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface LJKKFDADBJA
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	HNGEIEMJFIB MJBBJFLCPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool OMMLJEEHCDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool JCBEGCEEMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool GKDOPNHKMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool ENFKPFCNGJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int AONCOKBFBMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool OIBGCEEINKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool JHHPDOINAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	byte HJGBLNGFCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	byte FGGFPEIALFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool KNENLABMBKE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool KBLLJDICPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool IDHDDOKLDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float HCOGEFFDDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> AJKCLGPOHDF;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AANDDJDEEFL AKKFEEGIAGI(AANDDJDEEFL MBIIHOBBHFA);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNLMCPPAKKE(AANDDJDEEFL KDCLBHAMNHO);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HBLJEKFGKKC();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task GDKIDNEPLDD(NLBODGALKPJ<string>.EICLBAKIMEK ECDNFILPDGF, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KJAHFBJDCKE(float NIKAAMMCFGG);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HKEEAFGAGEL(string KABMICCBEJG);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<GONNKLCGJKF> EHIKPGCNAEA();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable LHIONGADHEG(object BHFMOMNKABO, GONNKLCGJKF ELLNEPPNPEA);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GMFGEGDFAPN LCKNAKGGONA(IEnumerable<FHCGEGKCGMN> FOLKBANEJNA);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OFHNDIEMIKP(int OHCBIMJNIPL);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task ONKFEMAICIA();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EKAPACNHFAH();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool ABKKBJFJGDG();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task HEDNLGAEMFB(CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task FALDGNLHFAI(CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<LFBPJJHHAPC> DFNIKKLHPDJ(DateTime GHMHCJLDJPE, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> KIANBFNHAIB(CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void PKLLFCLFPFO(string CLBGCJICGJG = "", float EKBDOJGAIJB = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	DANNFOFKDLN JNFLHFHMMCG(GIJNHOOAAEG BAMBEPDLBHC, OHMHKMILLGD DHBHJIFMIBE, JGEEHKGDOJK MDMJECBCDGJ, IEnumerable<PersistenceView> DGAKCPEAFFL, GJBBDEAEAPJ OIAEMJGIGHM);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void AJHAIHGJOED(JGEEHKGDOJK MDMJECBCDGJ);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KPGLIMCCMDH(FHCGEGKCGMN FJLLLIBFOLI, [In] DANNFOFKDLN AGLCLDHAGLK);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task HOAGLGIJNJI(JGEEHKGDOJK DMPJEPMEMOH, bool GJBFNJCELCP, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task AHLDKFOPIPN(CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void NFALAOKOMJA(long LNOJCNCBDMF, long EIPINGDKEKJ, APGABJIFLDK BOEODKCGNCM, KEKIJLKKLCL NJCJCMIBGMH, KPAJDCMJFPK EJOKDLGPDNO, OJJLNGELKEB? ACMFDOFDJLP, KDGOOCIPGIF? JLEBKFLGLKJ);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void AFFCMJEOAKA(long LNOJCNCBDMF, long EIPINGDKEKJ, KDGOOCIPGIF? JLEBKFLGLKJ);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void FAEDPOILCIB(PersistenceView FHCBOMDPOJF);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool EJLBHMKDGON(PersistenceView HLNNELMBBHN);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool ADDINMFOLDC(FHCGEGKCGMN FJLLLIBFOLI, NLENJFNFFEI DKLFOAIPHBI, [Out] PNIHDGLOHMA JHDFAAHLMKH);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task OJACGNOIGEG(CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void CNIBJDKJPAE();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable GNIOGFBLHLH();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void BEBCGKKPAKE(JGEEHKGDOJK DMPJEPMEMOH, NLENJFNFFEI DKLFOAIPHBI);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> EFLHHEEODHI(OPBLEBEBLOF NEMGCIKNBKO, CancellationToken ODNHMAMKFFP, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void KOLDCKBPNPC(CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<OKHBKNIGNEJ> HEJHGMCLEFI(CHHAIPNDPLC LOGLBHMJLPF);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<APGABJIFLDK> GINKEFFDGOJ(long LNOJCNCBDMF, bool GLCCJMGHALP, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<KEKIJLKKLCL> BHMNBEOMOEM(long LNOJCNCBDMF, long EIPINGDKEKJ, long DNIAFEHFFIM, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<GEINPJEOBAO> KFAHIKDHGPF(string BIENKHHLBJK, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<GEINPJEOBAO> AEDDIPONMBA(string BIENKHHLBJK, long LNOJCNCBDMF, long EIPINGDKEKJ, string DPABDEMPNNE, CAHHGBNICMP.NOBHANHCCGH OLHDNFLDIIE, CAHHGBNICMP.NOBHANHCCGH GPKEPHGOFMK, int FFJNJOPCPOE);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool CHMBAMHOGPJ();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool IBCNIFCDMOE();

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool PIOGAJGAGDF(IEnumerable<PNIHDGLOHMA> NHLKIABNPOF);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void EMFKJCMACND(List<GameObject> BBCJHBIHGGO);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float CDBBJKHDPKK();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task<Scene> IHNKCAJHBFE(string PNDDKBGNFCM, LoadSceneMode OMOFFPBAGMB, bool NIPFJCKOIMK, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void IALKFBLHIAP();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void MHEAMNMGABH(bool JKFJGFGHFNB);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void PJCODFMCMAJ();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void CPOOJKIABDP();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void FIFHLKOHPBD(PCHMOHFEPBH CJFEKFFMGDK);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "66")]
	Task HOIBMNKLHJO(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "67")]
	Task EAHEOENBOJB(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task EECDFLACFOK(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task JPJEAKFCIOI(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "70")]
	IDisposable NBFCLHAFNDB();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "71")]
	HAOCDFMHKMB NFKNEPOCMKL();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task ODAJHOKHMPF(CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface HAOCDFMHKMB
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PMPKPEFKPKG(CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DDNBKCKBJFI(CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct DANNFOFKDLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> MEHFFJEKEOB;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum LFBPJJHHAPC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct GIJNHOOAAEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string PGEOPBOCOEE;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface HNGEIEMJFIB
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	PCHMOHFEPBH NFOIJFLPELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	APGABJIFLDK BOCKMGLILID
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	FCAFGPLEBDB GLPEDHOGIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool LHHOAPEAFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool OHGCKHJPEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	int EBFJBNEOHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action AJLMEGOFEOA;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> IEEHOLCHOON;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CIGGFGFNPLE();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.OIANNBOEFDC> KFIMNFJBJFP(long EGBMFKCBLOA, [Optional] CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<LOPBOJLDNLF> AEIHDKLILIC();

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task JKEKDNBLAKO();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(PCHMOHFEPBH, HDDMNHNKALC) BDMGLANKBBH();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CBGJLBKPGCG HDMGDHPMBNL();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KDPMLDNGHFI(long EGBMFKCBLOA);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HBPICLEGDCB
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADIGEEBHLJD([Out] IEnumerable<int> APBHLNJBLEJ);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKCKFJODELA(PHMCAOLOCAA OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JDDFIOBMFBK(PHMCAOLOCAA OECMOOGGOOF);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IEPMKCACNIA
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LKBKIPDPDOG(AICFBPACFMB MHNMFEIEGIJ);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MIJBFFDLOIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMGJIHKLLBM(MPLJMPEKCNK.ALNCHMAONKP ABAGGMBAAKL);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLMAKABMHOB(MPLJMPEKCNK.ALNCHMAONKP ABAGGMBAAKL);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GIDMKHKFBNB : MIJBFFDLOIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AICFBPACFMB HECKJAINMBC(KCMOAPDBFGB JODLIPLAEMM);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface LIECJJGNCKP : MIJBFFDLOIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AICFBPACFMB JOPEKHFGFFN(KCMOAPDBFGB GBDHHGKEDDM);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface HBPCIOBAOHE
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MEKCEIEFNPI<EKDOJHDBDDL, PLHOCJDFICM>> NMDKELDHMIH(string DPABDEMPNNE, long EGBMFKCBLOA, long? LNOJCNCBDMF, long? EIPINGDKEKJ, OHLOCNHPDAG.EPOGBEKBEGL PMDPFHIEGFC, CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface IOMJMIBGPGC<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MEKCEIEFNPI<FBNAOJOLFEH<TData>, PLHOCJDFICM>> GIDJMHFCGCC(TGetDataArg NIFGNHBNLFL, CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class MBEGBGICLPM : KBOGPEMMJMI, BEBKPMCLLNB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct DEAEAOOLCJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<AICFBPACFMB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MBEGBGICLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GJKNKHPAHGK autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<AICFBPACFMB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6ECF780", Offset = "0x6ECDF80", VA = "0x186ECF780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6ECFA00", Offset = "0x6ECE200", VA = "0x186ECFA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct GOCFOGOIJOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public MBEGBGICLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8070", Offset = "0x6ED6870", VA = "0x186ED8070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6ED82A0", Offset = "0x6ED6AA0", VA = "0x186ED82A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class CIGNMJLLAHI : IEnumerable<INOFAJMOCKL>, IEnumerable, IEnumerator<INOFAJMOCKL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private INOFAJMOCKL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public MBEGBGICLPM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		private INOFAJMOCKL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x898540", Offset = "0x896D40", VA = "0x180898540")]
		[DebuggerHidden]
		public CIGNMJLLAHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6ECE730", Offset = "0x6ECCF30", VA = "0x186ECE730", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6ECEB90", Offset = "0x6ECD390", VA = "0x186ECEB90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6ECEAE0", Offset = "0x6ECD2E0", VA = "0x186ECEAE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<INOFAJMOCKL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6ECEAE0", Offset = "0x6ECD2E0", VA = "0x186ECEAE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource BNBNPFHABEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AANDDJDEEFL KDCLBHAMNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool HOBFAPAFPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private OJEMAEEFOMF DCPGHHPBDGG;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public OPBLEBEBLOF PGBGDFKJOFC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8473D0", Offset = "0x845BD0", VA = "0x1808473D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8472D0", Offset = "0x845AD0", VA = "0x1808472D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public CDEOBFFIKEB JCJFJAOILBP
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x844010", Offset = "0x842810", VA = "0x180844010", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x844020", Offset = "0x842820", VA = "0x180844020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public LJKKFDADBJA BHIHJNCNCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x843FA0", Offset = "0x8427A0", VA = "0x180843FA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x843FC0", Offset = "0x8427C0", VA = "0x180843FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public AJOGJHEJMJF CCAAHHODMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x843FE0", Offset = "0x8427E0", VA = "0x180843FE0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x843FB0", Offset = "0x8427B0", VA = "0x180843FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public GIDMKHKFBNB PLGJABPJCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x843FF0", Offset = "0x8427F0", VA = "0x180843FF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x844000", Offset = "0x842800", VA = "0x180844000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public LIECJJGNCKP MJOFAEHMPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x843F90", Offset = "0x842790", VA = "0x180843F90", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x843FD0", Offset = "0x8427D0", VA = "0x180843FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public FFFKLPHHKKG EMNOKFJFIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8513B0", Offset = "0x84FBB0", VA = "0x1808513B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x851370", Offset = "0x84FB70", VA = "0x180851370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public LEJKMKADKGF HKAIFHJFKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x851300", Offset = "0x84FB00", VA = "0x180851300", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x851360", Offset = "0x84FB60", VA = "0x180851360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public MAAKEPCALKG JJFLPBAFPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8512E0", Offset = "0x84FAE0", VA = "0x1808512E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x851380", Offset = "0x84FB80", VA = "0x180851380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public NGJHANPPHCL PENPJHPBNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA2E350", Offset = "0xA2CB50", VA = "0x180A2E350", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xAA1A60", Offset = "0xAA0260", VA = "0x180AA1A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public CCHENENFKJI JPBKPCEKPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8513F0", Offset = "0x84FBF0", VA = "0x1808513F0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x851340", Offset = "0x84FB40", VA = "0x180851340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public BBBCMAMIAKL OKFHCABFHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x991990", Offset = "0x990190", VA = "0x180991990", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x991AB0", Offset = "0x9902B0", VA = "0x180991AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public GEEBECHPOFO IGBLOOMICOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x849990", Offset = "0x848190", VA = "0x180849990", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x849900", Offset = "0x848100", VA = "0x180849900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public BAJCKDCCLBN LLJONICFKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xB2CC50", Offset = "0xB2B450", VA = "0x180B2CC50", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xB34BC0", Offset = "0xB333C0", VA = "0x180B34BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public OPDGNECGMMI OPCMKOCOGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x90BEF0", Offset = "0x90A6F0", VA = "0x18090BEF0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x906470", Offset = "0x904C70", VA = "0x180906470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BGMHKJCBOEJ OGEKCJHCLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x90B690", Offset = "0x909E90", VA = "0x18090B690", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x90CC30", Offset = "0x90B430", VA = "0x18090CC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public JHEPMHAOIPM MDMBCFFDDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8B3D90", Offset = "0x8B2590", VA = "0x1808B3D90", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xB34C00", Offset = "0xB33400", VA = "0x180B34C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public NADPPMHPNAO BLPNKCANNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8B2190", Offset = "0x8B0990", VA = "0x1808B2190", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1EB70", VA = "0x180A20370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public HLMIDPDLNEO JOKDPAGBGBC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x849960", Offset = "0x848160", VA = "0x180849960", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8498E0", Offset = "0x8480E0", VA = "0x1808498E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public JDDBKHMCBOJ LJBMMADLBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8B1F00", Offset = "0x8B0700", VA = "0x1808B1F00", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x994B50", Offset = "0x993350", VA = "0x180994B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public OLHPPHFILMA HGKFKOGAGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9F4020", Offset = "0x9F2820", VA = "0x1809F4020", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9F4030", Offset = "0x9F2830", VA = "0x1809F4030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public KFINKBEBLKO FDPGCAEIKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8B21B0", Offset = "0x8B09B0", VA = "0x1808B21B0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xB34BE0", Offset = "0xB333E0", VA = "0x180B34BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public IHKILCJEHHN ILIJDNFJAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8B21C0", Offset = "0x8B09C0", VA = "0x1808B21C0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9971A0", Offset = "0x9959A0", VA = "0x1809971A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public HBPICLEGDCB PPGJBDDIPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8B2110", Offset = "0x8B0910", VA = "0x1808B2110", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xB34BA0", Offset = "0xB333A0", VA = "0x180B34BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public MHNAGLGBMGG PDPJDJHFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8B2120", Offset = "0x8B0920", VA = "0x1808B2120", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xB34DE0", Offset = "0xB335E0", VA = "0x180B34DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public OGGIGJNKKIM ENJEJBLMCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8B1FF0", Offset = "0x8B07F0", VA = "0x1808B1FF0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xB34DA0", Offset = "0xB335A0", VA = "0x180B34DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public NKANBBPKJBF GLKNJJMNKAB
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8B1FC0", Offset = "0x8B07C0", VA = "0x1808B1FC0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xB34D20", Offset = "0xB33520", VA = "0x180B34D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public JLBKHEFKEBK APHKJGMCGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8B1F20", Offset = "0x8B0720", VA = "0x1808B1F20", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public HCNAAKFNJNN GBPMOGEDJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xAB9390", Offset = "0xAB7B90", VA = "0x180AB9390", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public IGDJMNLBKKF LAOKPDIAEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8B21A0", Offset = "0x8B09A0", VA = "0x1808B21A0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public MHEKKGCANGA IHHMMDNOMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA03890", Offset = "0xA02090", VA = "0x180A03890", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public HDDMNHNKALC OKDBFOLMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xAB7870", Offset = "0xAB6070", VA = "0x180AB7870", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xB34D40", Offset = "0xB33540", VA = "0x180B34D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private bool JOENMLHMHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEC50", Offset = "0x6EDD450", VA = "0x186EDEC50", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private bool EMMCBCDGGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEB70", Offset = "0x6EDD370", VA = "0x186EDEB70", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private CancellationToken EDGPKDOKKKD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6EDED10", Offset = "0x6EDD510", VA = "0x186EDED10", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private AANDDJDEEFL NPFOLLIKFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action PLOIFDIKEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6EDECB0", Offset = "0x6EDD4B0", VA = "0x186EDECB0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6EDED90", Offset = "0x6EDD590", VA = "0x186EDED90", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event LCDOLADEOEO OIBIALPIMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE940", Offset = "0x6EDD140", VA = "0x186EDE940", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE790", Offset = "0x6EDCF90", VA = "0x186EDE790", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event LCDOLADEOEO DEEMOFDPBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE5A0", Offset = "0x6EDCDA0", VA = "0x186EDE5A0", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6EDED30", Offset = "0x6EDD530", VA = "0x186EDED30", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event LCDOLADEOEO CPLIJPNCDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEA30", Offset = "0x6EDD230", VA = "0x186EDEA30", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEA90", Offset = "0x6EDD290", VA = "0x186EDEA90", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<EIAFBOOKIAK, bool> EGELCCBBEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEBF0", Offset = "0x6EDD3F0", VA = "0x186EDEBF0", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE850", Offset = "0x6EDD050", VA = "0x186EDE850", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xB34D40", Offset = "0xB33540", VA = "0x180B34D40", Slot = "36")]
	public void NPAGIBDCPDD(HDDMNHNKALC HLCGCAMBKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6EDEF00", Offset = "0x6EDD700", VA = "0x186EDEF00")]
	[UnityEngine.Scripting.Preserve]
	internal MBEGBGICLPM([GNKLNMHODGG(null)] AANDDJDEEFL KDCLBHAMNHO, [GNKLNMHODGG(null)] OPBLEBEBLOF NEMGCIKNBKO, [GNKLNMHODGG(null)] CDEOBFFIKEB ECJNOKELCBF, [GNKLNMHODGG(null)] LJKKFDADBJA NALLEMLECHL, [GNKLNMHODGG(null)] AJOGJHEJMJF NPNLIEBGEAP, [GNKLNMHODGG(null)] GIDMKHKFBNB EJACLDLDJLH, [GNKLNMHODGG(null)] LIECJJGNCKP EJPPNLGHPEC, [GNKLNMHODGG(null)] FFFKLPHHKKG DEHGGEGCGCG, [GNKLNMHODGG(null)] LEJKMKADKGF OFJFCBLAIDI, [GNKLNMHODGG(null)] MAAKEPCALKG PHNBHPMNBLI, [GNKLNMHODGG(null)] NGJHANPPHCL NDMBDPLCDJB, [GNKLNMHODGG(null)] CCHENENFKJI HHDKHILHGIG, [GNKLNMHODGG(null)] BBBCMAMIAKL LLFOEDEEOGC, [GNKLNMHODGG(null)] GEEBECHPOFO IJFOBADJGFJ, [GNKLNMHODGG(null)] BAJCKDCCLBN CIELLLOBMME, [GNKLNMHODGG(null)] OPDGNECGMMI FHCLAOKAALL, [GNKLNMHODGG(null)] BGMHKJCBOEJ INBCLKPDHAN, [GNKLNMHODGG(null)] JHEPMHAOIPM CAKDMCBBAMO, [GNKLNMHODGG(null)] NADPPMHPNAO ALKENFHONBA, [GNKLNMHODGG(null)] HLMIDPDLNEO MLLNBMKAIJL, [GNKLNMHODGG(null)] OLHPPHFILMA ADMMLGOCKPG, [GNKLNMHODGG(null)] JDDBKHMCBOJ POBLDEGHOGL, [GNKLNMHODGG(null)] KFINKBEBLKO IJKIKHNMEDJ, [GNKLNMHODGG(null)] IHKILCJEHHN LKLINGNMMPK, [GNKLNMHODGG(null)] HBPICLEGDCB MFHHKFAAFGH, [GNKLNMHODGG(null)] OGGIGJNKKIM LNOEPHEPJGF, [GNKLNMHODGG(null)] NKANBBPKJBF MHJKEDBILCJ, [GNKLNMHODGG(null)] JLBKHEFKEBK HPNHALJKBNA, [GNKLNMHODGG(null)] HCNAAKFNJNN PLMJMIGLDDA, [GNKLNMHODGG(null)] IGDJMNLBKKF FBEABGOJOMF, [GNKLNMHODGG(null)] MHEKKGCANGA EKHDLCMHFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE4F0", Offset = "0x6EDCCF0", VA = "0x186EDE4F0")]
	private void DIHNAABPOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE600", Offset = "0x6EDCE00", VA = "0x186EDE600", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE3B0", Offset = "0x6EDCBB0", VA = "0x186EDE3B0", Slot = "49")]
	private void BAPELNLKCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE9A0", Offset = "0x6EDD1A0", VA = "0x186EDE9A0", Slot = "50")]
	private ICGMBNNGMKC FPANJHENPDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE8B0", Offset = "0x6EDD0B0", VA = "0x186EDE8B0", Slot = "51")]
	private CPDLBCJHLMO ENPHDCOGALN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDEDF0", Offset = "0x6EDD5F0", VA = "0x186EDEDF0", Slot = "52")]
	[AsyncStateMachine(typeof(DEAEAOOLCJE))]
	private Task<AICFBPACFMB> PJFFCNJFEIH(GJKNKHPAHGK OGANCPGOCOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE400", Offset = "0x6EDCC00", VA = "0x186EDE400", Slot = "53")]
	[AsyncStateMachine(typeof(GOCFOGOIJOH))]
	private Task DEGELOABAGB(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6EDEAF0", Offset = "0x6EDD2F0", VA = "0x186EDEAF0")]
	[IteratorStateMachine(typeof(CIGNMJLLAHI))]
	private IEnumerable<INOFAJMOCKL> GLNDIIPJBGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE7F0", Offset = "0x6EDCFF0", VA = "0x186EDE7F0")]
	[CompilerGenerated]
	private void EKKIEOEHEJK(INOFAJMOCKL KFMACDKHBNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class PIJGABHDGDF : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0xEA8630", Offset = "0xEA6E30", VA = "0x180EA8630")]
	public PIJGABHDGDF(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class AJGOCJEAIMN : GBLBBOBMIGM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct LJFOLKHDMFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AJGOCJEAIMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD4E0", Offset = "0x6EDBCE0", VA = "0x186EDD4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD820", Offset = "0x6EDC020", VA = "0x186EDD820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly LJKKFDADBJA NALLEMLECHL;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x84B520", Offset = "0x849D20", VA = "0x18084B520")]
	public AJGOCJEAIMN(KBOGPEMMJMI JFHCNNPIMGD, LJKKFDADBJA NALLEMLECHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6ECBAC0", Offset = "0x6ECA2C0", VA = "0x186ECBAC0", Slot = "4")]
	[AsyncStateMachine(typeof(LJFOLKHDMFD))]
	public Task<bool> CMLHHLIIDAA(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6ECBBB0", Offset = "0x6ECA3B0", VA = "0x186ECBBB0")]
	[CompilerGenerated]
	private object OLLANBCFBJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class KGNBLGFHCIC : GBLBBOBMIGM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct PIIJPMEKGFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public KGNBLGFHCIC <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2860", Offset = "0x6EE1060", VA = "0x186EE2860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2F70", Offset = "0x6EE1770", VA = "0x186EE2F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly LJKKFDADBJA NALLEMLECHL;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private HNGEIEMJFIB MJBBJFLCPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC170", Offset = "0x6EDA970", VA = "0x186EDC170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x84B520", Offset = "0x849D20", VA = "0x18084B520")]
	public KGNBLGFHCIC(KBOGPEMMJMI JFHCNNPIMGD, LJKKFDADBJA NALLEMLECHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6EDC040", Offset = "0x6EDA840", VA = "0x186EDC040", Slot = "4")]
	[AsyncStateMachine(typeof(PIIJPMEKGFB))]
	public Task<bool> CMLHHLIIDAA(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBF60", Offset = "0x6EDA760", VA = "0x186EDBF60")]
	[CompilerGenerated]
	private object BGEEJEJGJAI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class CLGPHPKLJBC : GBLBBOBMIGM
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OKLBAANBMJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CLGPHPKLJBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public LOPBOJLDNLF result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public PCHMOHFEPBH newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OKLBAANBMJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6EE1630", Offset = "0x6EDFE30", VA = "0x186EE1630")]
		internal object DFAMEFGNIBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE1720", Offset = "0x6EDFF20", VA = "0x186EE1720")]
		internal object GLALEPPGCJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE1590", Offset = "0x6EDFD90", VA = "0x186EE1590")]
		internal object ANDDDDNANLP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct AFGIMJBMCEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CLGPHPKLJBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private OKLBAANBMJL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<LOPBOJLDNLF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6EC54D0", Offset = "0x6EC3CD0", VA = "0x186EC54D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5DF0", Offset = "0x6EC45F0", VA = "0x186EC5DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly LJKKFDADBJA NALLEMLECHL;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private HNGEIEMJFIB MJBBJFLCPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6ECED00", Offset = "0x6ECD500", VA = "0x186ECED00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x84B520", Offset = "0x849D20", VA = "0x18084B520")]
	public CLGPHPKLJBC(KBOGPEMMJMI JFHCNNPIMGD, LJKKFDADBJA NALLEMLECHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6ECEBE0", Offset = "0x6ECD3E0", VA = "0x186ECEBE0", Slot = "4")]
	[AsyncStateMachine(typeof(AFGIMJBMCEC))]
	public Task<bool> CMLHHLIIDAA(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface GBLBBOBMIGM
{
	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CMLHHLIIDAA(CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct MCNFEMNJJHD
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class PABFKKOMIEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public KBOGPEMMJMI manager;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public PABFKKOMIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2230", Offset = "0x6EE0A30", VA = "0x186EE2230")]
		internal Task LCOMEHJCKEF(KHFFEHOCMIP data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct PKKMDNKEAJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public MCNFEMNJJHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private GJKNKHPAHGK <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<LFBPJJHHAPC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<AICFBPACFMB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2FE0", Offset = "0x6EE17E0", VA = "0x186EE2FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3570", Offset = "0x6EE1D70", VA = "0x186EE3570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct EJAJFOIEKNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public MCNFEMNJJHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0A10", Offset = "0x6ECF210", VA = "0x186ED0A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0D30", Offset = "0x6ECF530", VA = "0x186ED0D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CancellationToken ODNHMAMKFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly KBOGPEMMJMI KOFDOJONBID;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private OPBLEBEBLOF PGBGDFKJOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF510", Offset = "0x6EDDD10", VA = "0x186EDF510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private LJKKFDADBJA BHIHJNCNCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF8A0", Offset = "0x6EDE0A0", VA = "0x186EDF8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private HNGEIEMJFIB MJBBJFLCPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF490", Offset = "0x6EDDC90", VA = "0x186EDF490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private MAAKEPCALKG JJFLPBAFPGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF440", Offset = "0x6EDDC40", VA = "0x186EDF440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F41880", Offset = "0x1F40080", VA = "0x181F41880")]
	public MCNFEMNJJHD(CancellationToken ODNHMAMKFFP, KBOGPEMMJMI KOFDOJONBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF8F0", Offset = "0x6EDE0F0", VA = "0x186EDF8F0")]
	public static PDNHODGFBMB OHCJJNFJEMD(KBOGPEMMJMI KOFDOJONBID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF9A0", Offset = "0x6EDE1A0", VA = "0x186EDF9A0")]
	[AsyncStateMachine(typeof(PKKMDNKEAJB))]
	public Task<bool> OHLHHBJPLCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF560", Offset = "0x6EDDD60", VA = "0x186EDF560")]
	private bool KKKPJDPGMFN([Out] GJKNKHPAHGK OGANCPGOCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFAB0", Offset = "0x6EDE2B0", VA = "0x186EDFAB0")]
	[AsyncStateMachine(typeof(EJAJFOIEKNB))]
	private Task PKFNNLKMCGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF770", Offset = "0x6EDDF70", VA = "0x186EDF770")]
	private Task<LFBPJJHHAPC> LEMGEGGEOFN(GJKNKHPAHGK PBKLECAGPEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct LLIIIKGFJLE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly BAJCKDCCLBN CIELLLOBMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Guid KPJLKKPOEPH;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Task<(AICFBPACFMB, Task)> FCHPNCEPPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD890", Offset = "0x6EDC090", VA = "0x186EDD890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4133FB0", Offset = "0x41327B0", VA = "0x184133FB0")]
	public LLIIIKGFJLE(BAJCKDCCLBN CIELLLOBMME, Guid KPJLKKPOEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDA30", Offset = "0x6EDC230", VA = "0x186EDDA30")]
	public TaskAwaiter<(AICFBPACFMB, Task)> GBAOEGHLCNE()
	{
		return default(TaskAwaiter<(AICFBPACFMB, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6EDD960", Offset = "0x6EDC160", VA = "0x186EDD960", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct CEFIBHELCAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly TaskCompletionSource<(AICFBPACFMB, Task)> KMBENGLIHJK;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Task<(AICFBPACFMB, Task)> FCHPNCEPPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6ECE400", Offset = "0x6ECCC00", VA = "0x186ECE400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE5B0", Offset = "0x6ECCDB0", VA = "0x186ECE5B0")]
	public CEFIBHELCAI(TimeSpan GIGKLDABMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE360", Offset = "0x6ECCB60", VA = "0x186ECE360")]
	public void AJBAKOMCDHE(Task FJFHBJJIDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE520", Offset = "0x6ECCD20", VA = "0x186ECE520")]
	public void MKIFCHGLGDH(AICFBPACFMB MHNMFEIEGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE440", Offset = "0x6ECCC40", VA = "0x186ECE440")]
	public void FICEEMBFLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE490", Offset = "0x6ECCC90", VA = "0x186ECE490")]
	internal void JAGFGGHJFBM(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class DHKCMFNPBCB
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class HIJILAKPIJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public KEKIJLKKLCL subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HIJILAKPIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6ED90D0", Offset = "0x6ED78D0", VA = "0x186ED90D0")]
		internal bool PENKBCPFGJD(FCAFGPLEBDB s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFEF0", Offset = "0x6ECE6F0", VA = "0x186ECFEF0")]
	public static JKENAGDJKCF DLNFHNOLCMJ(long DOFPCMDCFEO, long EIPINGDKEKJ, string BIENKHHLBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFE30", Offset = "0x6ECE630", VA = "0x186ECFE30")]
	public static JKENAGDJKCF DLNFHNOLCMJ(long DOFPCMDCFEO, long EIPINGDKEKJ, KGMNHEONACL KIPPBODDGFF, long DNIAFEHFFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFCA0", Offset = "0x6ECE4A0", VA = "0x186ECFCA0")]
	public static JKENAGDJKCF DLNFHNOLCMJ(OKHBKNIGNEJ PGPGPOAPJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFA70", Offset = "0x6ECE270", VA = "0x186ECFA70")]
	public static JKENAGDJKCF DLNFHNOLCMJ(APGABJIFLDK HHCKHKOBLGN, KEKIJLKKLCL DBPIOHPDKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0110", Offset = "0x6ECE910", VA = "0x186ED0110")]
	public static JKENAGDJKCF OCAAELJOFIC(this JKENAGDJKCF EMIMPCIEFOP, APGABJIFLDK GJGCIJDONOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFF80", Offset = "0x6ECE780", VA = "0x186ECFF80")]
	public static JKENAGDJKCF KJHJFKLMIOC(this JKENAGDJKCF EMIMPCIEFOP, KEKIJLKKLCL GDLPJLGKDNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class IECCPCDFKAE : LEJKMKADKGF, INOFAJMOCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct CPEDIAGHJBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public IECCPCDFKAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6ECF0A0", Offset = "0x6ECD8A0", VA = "0x186ECF0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6ECF720", Offset = "0x6ECDF20", VA = "0x186ECF720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly PHMCAOLOCAA KNOEGOFFMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private string FMECHJMOKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Task LKJEHBAFPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool LJODNKJMGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6ED9550", Offset = "0x6ED7D50", VA = "0x186ED9550", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task BPBMKGEFDCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6ED9580", Offset = "0x6ED7D80", VA = "0x186ED9580", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x84A250", Offset = "0x848A50", VA = "0x18084A250", Slot = "7")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6ED93F0", Offset = "0x6ED7BF0", VA = "0x186ED93F0", Slot = "6")]
	public void KPCBKMKAOEL(Task GECIOHOBBCH, string NDDOPFEBMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6ED92D0", Offset = "0x6ED7AD0", VA = "0x186ED92D0")]
	[AsyncStateMachine(typeof(CPEDIAGHJBJ))]
	private Task KCPEDOJOEGP(Task FNDAOKMDEGK, string NDDOPFEBMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9610", Offset = "0x6ED7E10", VA = "0x186ED9610")]
	public IECCPCDFKAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class NMJGBLMBPIO : MHNAGLGBMGG, INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool IFDDOMBDPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private OFJKNPELLGL GDHIDGDCPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private OPBLEBEBLOF NEMGCIKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private OGGIGJNKKIM LNOEPHEPJGF;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public OFJKNPELLGL BPNMACEFAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE13F0", Offset = "0x6EDFBF0", VA = "0x186EE13F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0FC0", Offset = "0x6EDF7C0", VA = "0x186EE0FC0", Slot = "7")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1240", Offset = "0x6EDFA40", VA = "0x186EE1240", Slot = "5")]
	public void JDJOOJFLCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1200", Offset = "0x6EDFA00", VA = "0x186EE1200", Slot = "6")]
	public void JICLJKNCDCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1140", Offset = "0x6EDF940", VA = "0x186EE1140")]
	private Task DJHHBKGPMMF(BKBMNDGIKLD NOFEINPOGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1200", Offset = "0x6EDFA00", VA = "0x186EE1200", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public NMJGBLMBPIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class EPJFLJAIPCA : OGGIGJNKKIM
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class KDNIKAMNKEK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly LKKABOLKPGL BLEJNPBMOMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly string JOEHGGMHBAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly T HLCNDDGKJJF;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public T JDDKPJKLOJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x895EE0", Offset = "0x8946E0", VA = "0x180895EE0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x981410", Offset = "0x97FC10", VA = "0x180981410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x4086AA0", Offset = "0x40852A0", VA = "0x184086AA0")]
		public KDNIKAMNKEK(LKKABOLKPGL BLEJNPBMOMP, string JOEHGGMHBAA, T HLCNDDGKJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x4086600", Offset = "0x4084E00", VA = "0x184086600")]
		private void EKBBAECKJLP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly LKKABOLKPGL BLEJNPBMOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly KDNIKAMNKEK<TimeSpan> CLCOMEBKBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly KDNIKAMNKEK<TimeSpan> JEGKAHBAHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly KDNIKAMNKEK<TimeSpan> FGAGLIEKJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly KDNIKAMNKEK<TimeSpan> ADDCNPCOFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly KDNIKAMNKEK<bool> KCJIDPJPBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly KDNIKAMNKEK<bool> KEOFCFMPPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly KDNIKAMNKEK<bool> DJJLDECHGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly KDNIKAMNKEK<int> EBCMGAAOHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly KDNIKAMNKEK<bool> HBAFDKBHCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly KDNIKAMNKEK<bool> GHHNCOCLNPN;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public TimeSpan OPCDIBNDJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1870", Offset = "0x6ED0070", VA = "0x186ED1870", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public TimeSpan LFAHABKILKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1930", Offset = "0x6ED0130", VA = "0x186ED1930", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TimeSpan EPDMNNFBIAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1970", Offset = "0x6ED0170", VA = "0x186ED1970", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TimeSpan LNIFIGHPLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6ED19F0", Offset = "0x6ED01F0", VA = "0x186ED19F0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool NNBCCBLEJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1830", Offset = "0x6ED0030", VA = "0x186ED1830", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool GOGFPBECEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6ED19B0", Offset = "0x6ED01B0", VA = "0x186ED19B0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool GEHKEDEHDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6ED18F0", Offset = "0x6ED00F0", VA = "0x186ED18F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public int FMBMAHPKPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6ED17F0", Offset = "0x6ECFFF0", VA = "0x186ED17F0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool NKBLIFDILFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6ED17B0", Offset = "0x6ECFFB0", VA = "0x186ED17B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool AEIGENKCLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6ED18B0", Offset = "0x6ED00B0", VA = "0x186ED18B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1A30", Offset = "0x6ED0230", VA = "0x186ED1A30")]
	[UnityEngine.Scripting.Preserve]
	public EPJFLJAIPCA([GNKLNMHODGG(null)] LKKABOLKPGL BLEJNPBMOMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class BKDBNLFOGBF : NGJHANPPHCL, INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class MBNKAJFAIIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public CCJHKKFLBHC roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public MBNKAJFAIIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF360", Offset = "0x6EDDB60", VA = "0x186EDF360")]
		internal object LIPPKANNKDJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action ACJKCIAFHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCF00", Offset = "0x6ECB700", VA = "0x186ECCF00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC930", Offset = "0x6ECB130", VA = "0x186ECC930", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event LCDOLADEOEO LDICCCIGDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCB20", Offset = "0x6ECB320", VA = "0x186ECCB20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCC70", Offset = "0x6ECB470", VA = "0x186ECCC70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event LCDOLADEOEO GDHPGECHOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCA50", Offset = "0x6ECB250", VA = "0x186ECCA50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD10", Offset = "0x6ECB510", VA = "0x186ECCD10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event LCDOLADEOEO JAJJPJEOOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC6A0", Offset = "0x6ECAEA0", VA = "0x186ECC6A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCDB0", Offset = "0x6ECB5B0", VA = "0x186ECCDB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<EIAFBOOKIAK, bool> GIONKCHDCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCBC0", Offset = "0x6ECB3C0", VA = "0x186ECCBC0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCE50", Offset = "0x6ECB650", VA = "0x186ECCE50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "19")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCFA0", Offset = "0x6ECB7A0", VA = "0x186ECCFA0", Slot = "14")]
	public void PPNOLKIBKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC9D0", Offset = "0x6ECB1D0", VA = "0x186ECC9D0", Slot = "15")]
	public void HMCOJFPIGFO(CCJHKKFLBHC NNKKCIJJLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCAF0", Offset = "0x6ECB2F0", VA = "0x186ECCAF0", Slot = "16")]
	public void LIKECEPKIDG(CCJHKKFLBHC NNKKCIJJLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC740", Offset = "0x6ECAF40", VA = "0x186ECC740", Slot = "17")]
	public void BNAHGLPCENM(CCJHKKFLBHC NNKKCIJJLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCA00", Offset = "0x6ECB200", VA = "0x186ECCA00", Slot = "18")]
	public void IPJPNCCLNEP(EIAFBOOKIAK LOFAINCFOJE, bool FEJOFHOJCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC770", Offset = "0x6ECAF70", VA = "0x186ECC770")]
	private void EHHNDHAPNMD(LCDOLADEOEO ELLNEPPNPEA, CCJHKKFLBHC NNKKCIJJLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public BKDBNLFOGBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class HANGBPIHGPH : CCHENENFKJI, INOFAJMOCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct AOFPGPOPILO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public HANGBPIHGPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBC90", Offset = "0x6ECA490", VA = "0x186ECBC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC170", Offset = "0x6ECA970", VA = "0x186ECC170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct EOPLCNCFJMD : IAsyncStateMachine
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
		public HANGBPIHGPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6ED10F0", Offset = "0x6ECF8F0", VA = "0x186ED10F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1750", Offset = "0x6ECFF50", VA = "0x186ED1750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class FCMFIBBFOKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public FCMFIBBFOKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1EA0", Offset = "0x6ED06A0", VA = "0x186ED1EA0")]
		internal object AGFFEGOFHME()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct CEBIHABJKNN : IAsyncStateMachine
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
		public HANGBPIHGPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private FCMFIBBFOKH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDBB0", Offset = "0x6ECC3B0", VA = "0x186ECDBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6ECE2F0", Offset = "0x6ECCAF0", VA = "0x186ECE2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class PCEAOAJJNLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public PCEAOAJJNLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2280", Offset = "0x6EE0A80", VA = "0x186EE2280")]
		internal object HGBGNHKLMOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private LJKKFDADBJA NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private GBLBBOBMIGM[] OCICKDIKAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private CancellationTokenSource NPNHNCBGLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int ELNABDICAOD;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8730", Offset = "0x6ED6F30", VA = "0x186ED8730", Slot = "6")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6ED87B0", Offset = "0x6ED6FB0", VA = "0x186ED87B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8300", Offset = "0x6ED6B00", VA = "0x186ED8300", Slot = "8")]
	public void AKDFKADPALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6ED87C0", Offset = "0x6ED6FC0", VA = "0x186ED87C0", Slot = "5")]
	public void ENCIEDKEOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8660", Offset = "0x6ED6E60", VA = "0x186ED8660", Slot = "4")]
	[AsyncStateMachine(typeof(AOFPGPOPILO))]
	public Task DDOAFCGOHCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8890", Offset = "0x6ED7090", VA = "0x186ED8890")]
	private void HGCCGAHKHNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8BB0", Offset = "0x6ED73B0", VA = "0x186ED8BB0")]
	[AsyncStateMachine(typeof(EOPLCNCFJMD))]
	private Task HHLGNFCGKFO(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8E70", Offset = "0x6ED7670", VA = "0x186ED8E70")]
	[AsyncStateMachine(typeof(CEBIHABJKNN))]
	private Task<bool> MOBAKFEDPAF(int JBDLDJOINOF, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8D90", Offset = "0x6ED7590", VA = "0x186ED8D90")]
	private void MDENJMBDNFC(int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8CB0", Offset = "0x6ED74B0", VA = "0x186ED8CB0")]
	private void LILJJBPOKIN(int JBDLDJOINOF, bool FEJOFHOJCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8400", Offset = "0x6ED6C00", VA = "0x186ED8400")]
	private void BLMCIBJPJNI(int JBDLDJOINOF, Exception BCGGAGLBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8530", Offset = "0x6ED6D30", VA = "0x186ED8530")]
	private void CLCCANFDAJB(CancellationToken ODNHMAMKFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public HANGBPIHGPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class GLLKKDKKOLP : BBBCMAMIAKL, INOFAJMOCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct BNEBHNBOCKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public PCHMOHFEPBH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public GLLKKDKKOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public HDDMNHNKALC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD190", Offset = "0x6ECB990", VA = "0x186ECD190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDAE0", Offset = "0x6ECC2E0", VA = "0x186ECDAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct JBNNNGAAPON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public GLLKKDKKOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public PCHMOHFEPBH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public HDDMNHNKALC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private NLBODGALKPJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private OHNDHAGHNHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private HPGKKJFFMPO <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private EOOHLHLAACD <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA090", Offset = "0x6ED8890", VA = "0x186EDA090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6EDAC50", Offset = "0x6ED9450", VA = "0x186EDAC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class OKEGGONMCGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Matchmaking.KHKLDHFIBML result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public HKPKAELHFCG errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OKEGGONMCGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6EE14E0", Offset = "0x6EDFCE0", VA = "0x186EE14E0")]
		internal object MFEMOHKHFON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class FFFGDLINJEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Task<JKENAGDJKCF> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public FFFGDLINJEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		internal Task<JKENAGDJKCF> JLHDNLPEBOI(NLBODGALKPJ<string>.EICLBAKIMEK _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct AGLOBIHDCBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public GLLKKDKKOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public PCHMOHFEPBH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public HDDMNHNKALC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public HPGKKJFFMPO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private FFFGDLINJEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private NAGOHFBEGAG <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private OHNDHAGHNHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private JJOBFPIAHKI <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Task<Matchmaking.OIANNBOEFDC> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private IMOLEOJEIKE <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.OIANNBOEFDC> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<JKENAGDJKCF> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5E60", Offset = "0x6EC4660", VA = "0x186EC5E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB020", Offset = "0x6EC9820", VA = "0x186ECB020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct GMNLJADKLOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public GLLKKDKKOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <disconnectTimerScope>5__3;

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
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5F40", Offset = "0x6ED4740", VA = "0x186ED5F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6980", Offset = "0x6ED5180", VA = "0x186ED6980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct NIEPGLMGBPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public GLLKKDKKOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private AANDDJDEEFL <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0AE0", Offset = "0x6EDF2E0", VA = "0x186EE0AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0F60", Offset = "0x6EDF760", VA = "0x186EE0F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct PEHOAJMGJOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder<Matchmaking.OIANNBOEFDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public PCHMOHFEPBH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public GLLKKDKKOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<Matchmaking.OIANNBOEFDC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6EE22F0", Offset = "0x6EE0AF0", VA = "0x186EE22F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6EE27F0", Offset = "0x6EE0FF0", VA = "0x186EE27F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct LOFBPAPFOGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Matchmaking.OIANNBOEFDC serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public GLLKKDKKOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public HPGKKJFFMPO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<JHCIFBPFOPA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6EDDA80", Offset = "0x6EDC280", VA = "0x186EDDA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE170", Offset = "0x6EDC970", VA = "0x186EDE170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class ENEDAAIOKND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public PCHMOHFEPBH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public ENEDAAIOKND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0E90", Offset = "0x6ECF690", VA = "0x186ED0E90")]
		internal object NNHIAEANCLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0D90", Offset = "0x6ECF590", VA = "0x186ED0D90")]
		internal string CDMHPBGOELJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct JLAPCBFMFHG : IAsyncStateMachine
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
		public PCHMOHFEPBH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public GLLKKDKKOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private ENEDAAIOKND <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private OHNDHAGHNHL <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB2E0", Offset = "0x6ED9AE0", VA = "0x186EDB2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6EDBEB0", Offset = "0x6EDA6B0", VA = "0x186EDBEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct IFBIEENDDEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public GLLKKDKKOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public HPGKKJFFMPO joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public JKENAGDJKCF initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public PCHMOHFEPBH targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public NAGOHFBEGAG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED96A0", Offset = "0x6ED7EA0", VA = "0x186ED96A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED9FB0", Offset = "0x6ED87B0", VA = "0x186ED9FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct GNFOFPJFENC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public GLLKKDKKOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private OHNDHAGHNHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap3;

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

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6ED69E0", Offset = "0x6ED51E0", VA = "0x186ED69E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8010", Offset = "0x6ED6810", VA = "0x186ED8010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct DLGHHFFEPFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public GLLKKDKKOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<AICFBPACFMB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0200", Offset = "0x6ECEA00", VA = "0x186ED0200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6ED09B0", Offset = "0x6ECF1B0", VA = "0x186ED09B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class HNEJDKGMOPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public PCHMOHFEPBH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HNEJDKGMOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6ED9100", Offset = "0x6ED7900", VA = "0x186ED9100")]
		internal object GGKLBBGDJFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class HCENPINLDDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HCENPINLDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6ED9030", Offset = "0x6ED7830", VA = "0x186ED9030")]
		internal void DMFGNEAGPII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class ILLDLJFPKGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public PCHMOHFEPBH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public ILLDLJFPKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA010", Offset = "0x6ED8810", VA = "0x186EDA010")]
		internal object FCCFNOMCDLM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class JHIDHMLJIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public PCHMOHFEPBH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public JHIDHMLJIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB1E0", Offset = "0x6ED99E0", VA = "0x186EDB1E0")]
		internal string DEDOMKJANOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly MMJHHDEPGMK KOOGMNHAEBH;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly MMJHHDEPGMK AGGHACLKHEG;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly MMJHHDEPGMK GBBFDFKMJKI;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string JDJEMEPGALM;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string EFIJMJDHADM;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string NFDOJJJOHMM;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static readonly Guid MPKPDKNCHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private FFFKLPHHKKG DEHGGEGCGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private CDEOBFFIKEB ECJNOKELCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private OPBLEBEBLOF NEMGCIKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private LJKKFDADBJA NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private CCHENENFKJI HHDKHILHGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private LEJKMKADKGF OFJFCBLAIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NGJHANPPHCL NDMBDPLCDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private IGDJMNLBKKF FBEABGOJOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private HCNAAKFNJNN PLMJMIGLDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private IDisposable BKEGCBCLCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly PHMCAOLOCAA JCIOJBEADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly PHMCAOLOCAA JEOPLNHNIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private IMOLEOJEIKE GPAKOBJEIPF;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public TaskStatus PFCMFEBINBD
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8B20A0", Offset = "0x8B08A0", VA = "0x1808B20A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xC42E30", Offset = "0xC41630", VA = "0x180C42E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private HNGEIEMJFIB MJBBJFLCPLK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4B20", Offset = "0x6ED3320", VA = "0x186ED4B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED32E0", Offset = "0x6ED1AE0", VA = "0x186ED32E0", Slot = "6")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6ED37A0", Offset = "0x6ED1FA0", VA = "0x186ED37A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6ED37F0", Offset = "0x6ED1FF0", VA = "0x186ED37F0", Slot = "5")]
	[AsyncStateMachine(typeof(BNEBHNBOCKK))]
	public Task EAFGJNNDHKH(PCHMOHFEPBH KNAECKPPIKB, HDDMNHNKALC GPEBMMOCBOM, CancellationToken OKNLKNIHJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5B20", Offset = "0x6ED4320", VA = "0x186ED5B20")]
	[AsyncStateMachine(typeof(JBNNNGAAPON))]
	private Task PBOBICDOPEI(PCHMOHFEPBH KNAECKPPIKB, HDDMNHNKALC GPEBMMOCBOM, CancellationToken OKNLKNIHJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2910", Offset = "0x6ED1110", VA = "0x186ED2910")]
	private static void CGFLCFJGEIJ(IGDJMNLBKKF FBEABGOJOMF, PCHMOHFEPBH KNAECKPPIKB, Exception BCGGAGLBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6ED41B0", Offset = "0x6ED29B0", VA = "0x186ED41B0")]
	private static void EPKGPBJCKEF(EOOHLHLAACD EEKECBCELKC, Exception BCGGAGLBPHE, [Optional] List<int> HPBADKGHBGM, int ELNABDICAOD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5550", Offset = "0x6ED3D50", VA = "0x186ED5550")]
	[AsyncStateMachine(typeof(AGLOBIHDCBB))]
	private Task KHELCLIHGDB(NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, PCHMOHFEPBH KNAECKPPIKB, HDDMNHNKALC GPEBMMOCBOM, HPGKKJFFMPO HHJMDEIALOP, CancellationToken OKNLKNIHJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6ED56B0", Offset = "0x6ED3EB0", VA = "0x186ED56B0")]
	private void LBONLCGNFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3D50", Offset = "0x6ED2550", VA = "0x186ED3D50")]
	[AsyncStateMachine(typeof(GMNLJADKLOH))]
	private Task EMILGKMMOPI(NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3A20", Offset = "0x6ED2220", VA = "0x186ED3A20")]
	private void EJPHAEPKNOI(PCHMOHFEPBH KNAECKPPIKB, CancellationToken OKNLKNIHJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6ED30C0", Offset = "0x6ED18C0", VA = "0x186ED30C0")]
	private void DDKECHGEDMM(PCHMOHFEPBH KNAECKPPIKB, HPGKKJFFMPO HHJMDEIALOP, OperationCanceledException AGEHOHHNFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3F90", Offset = "0x6ED2790", VA = "0x186ED3F90")]
	private void EOACBLBBJCP(PCHMOHFEPBH KNAECKPPIKB, HPGKKJFFMPO HHJMDEIALOP, Exception BCGGAGLBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5800", Offset = "0x6ED4000", VA = "0x186ED5800")]
	private void NOJCJEGAKAC(PCHMOHFEPBH KNAECKPPIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4CB0", Offset = "0x6ED34B0", VA = "0x186ED4CB0")]
	private static CCJHKKFLBHC HGAKNAAOKHD(PCHMOHFEPBH KNAECKPPIKB)
	{
		return default(CCJHKKFLBHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4A50", Offset = "0x6ED3250", VA = "0x186ED4A50")]
	[AsyncStateMachine(typeof(NIEPGLMGBPH))]
	private Task FFFKOMAHIBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED53F0", Offset = "0x6ED3BF0", VA = "0x186ED53F0")]
	[AsyncStateMachine(typeof(PEHOAJMGJOH))]
	private Task<Matchmaking.OIANNBOEFDC> KFIMNFJBJFP(PCHMOHFEPBH KNAECKPPIKB, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5A10", Offset = "0x6ED4210", VA = "0x186ED5A10")]
	private static JHCIFBPFOPA OEMMDPBIJLM(Matchmaking.OIANNBOEFDC KOFBOEHLMOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2CD0", Offset = "0x6ED14D0", VA = "0x186ED2CD0")]
	[AsyncStateMachine(typeof(LOFBPAPFOGN))]
	private Task CHPHGHMMPEF(Matchmaking.OIANNBOEFDC KOFBOEHLMOE, HPGKKJFFMPO HHJMDEIALOP, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken DKMGEPECIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4B70", Offset = "0x6ED3370", VA = "0x186ED4B70")]
	[AsyncStateMachine(typeof(JLAPCBFMFHG))]
	private Task GJKDAKAGICD(PCHMOHFEPBH KNAECKPPIKB, CancellationTokenSource CAKANLIPAFC, Task LPIIGJCPEJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6ED50B0", Offset = "0x6ED38B0", VA = "0x186ED50B0")]
	[AsyncStateMachine(typeof(IFBIEENDDEE))]
	private Task JHIMCKDAJPO(JKENAGDJKCF OEIPBLFDOGM, NAGOHFBEGAG LCBDCPCAIOJ, PCHMOHFEPBH FICDDCAHGBN, HPGKKJFFMPO ICMJKJMLLOA, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken LKBKJHMFNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2470", Offset = "0x6ED0C70", VA = "0x186ED2470")]
	private HPGKKJFFMPO AEILMMDEGGG(HPGKKJFFMPO ICMJKJMLLOA, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6ED27E0", Offset = "0x6ED0FE0", VA = "0x186ED27E0")]
	[AsyncStateMachine(typeof(GNFOFPJFENC))]
	private Task CBJACOINAMJ(NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2660", Offset = "0x6ED0E60", VA = "0x186ED2660")]
	[AsyncStateMachine(typeof(DLGHHFFEPFO))]
	private Task AIANJPKGKCA(KHFFEHOCMIP MLKNGAFFKGE, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4EA0", Offset = "0x6ED36A0", VA = "0x186ED4EA0")]
	private static void IJIEBFDKFHF(PCHMOHFEPBH KNAECKPPIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5220", Offset = "0x6ED3A20", VA = "0x186ED5220")]
	private void KABFIFHAEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2E20", Offset = "0x6ED1620", VA = "0x186ED2E20")]
	private void CLCOCJDPEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5020", Offset = "0x6ED3820", VA = "0x186ED5020")]
	private void IMDALNBEOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4D10", Offset = "0x6ED3510", VA = "0x186ED4D10")]
	private void HHAJGLMKEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3930", Offset = "0x6ED2130", VA = "0x186ED3930")]
	private static void EGLOONIBKAG(PCHMOHFEPBH KNAECKPPIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3E80", Offset = "0x6ED2680", VA = "0x186ED3E80")]
	private static CancellationTokenRegistration ENILEOJICEK(PCHMOHFEPBH KNAECKPPIKB, CancellationToken DKMGEPECIBN)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4DA0", Offset = "0x6ED35A0", VA = "0x186ED4DA0")]
	private static void IIONDMFNIFO(PCHMOHFEPBH KNAECKPPIKB, Exception BCGGAGLBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2F10", Offset = "0x6ED1710", VA = "0x186ED2F10")]
	private void DCEDLCCBCGC(PCHMOHFEPBH KNAECKPPIKB, Task LPIIGJCPEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2EB0", Offset = "0x6ED16B0", VA = "0x186ED2EB0")]
	private static void CPICANFMBIK(Func<string> IOFIKOEHDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5E70", Offset = "0x6ED4670", VA = "0x186ED5E70")]
	public GLLKKDKKOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2780", Offset = "0x6ED0F80", VA = "0x186ED2780")]
	[CompilerGenerated]
	internal static (int, int?) CAPBCHCGJKP(HKPKAELHFCG FOBCBIEDHCL)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class MLKHKBHENJO : GEEBECHPOFO, INOFAJMOCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct PODPDAPNEGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public MLKHKBHENJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public KHFFEHOCMIP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6F01D50", Offset = "0x6F00550", VA = "0x186F01D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6F02110", Offset = "0x6F00910", VA = "0x186F02110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class LAEAFJAACBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public MLKHKBHENJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public KHFFEHOCMIP roomData;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public LAEAFJAACBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9E50", Offset = "0x6EF8650", VA = "0x186EF9E50")]
		internal List<Task> NJPHAHEHEDB(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct HBMLADAIFMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public PDNHODGFBMB taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4170", Offset = "0x6EF2970", VA = "0x186EF4170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF44F0", Offset = "0x6EF2CF0", VA = "0x186EF44F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct FAONILGKBAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public MLKHKBHENJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC9F0", Offset = "0x6EEB1F0", VA = "0x186EEC9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6EECCB0", Offset = "0x6EEB4B0", VA = "0x186EECCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly HashSet<PDNHODGFBMB> LJCLHDFCCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private CDEOBFFIKEB ECJNOKELCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private GONNKLCGJKF AFAFCEFLEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private JLMLNIGFFCB DONLIBBJKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private IDisposable BKEGCBCLCNB;

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFE70", Offset = "0x6EDE670", VA = "0x186EDFE70", Slot = "5")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE00F0", Offset = "0x6EDE8F0", VA = "0x186EE00F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFD20", Offset = "0x6EDE520", VA = "0x186EDFD20", Slot = "4")]
	public bool CLDGMGKIAJG(PDNHODGFBMB KEHGEFKDDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0220", Offset = "0x6EDEA20", VA = "0x186EE0220")]
	private void IEMANNPMBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0350", Offset = "0x6EDEB50", VA = "0x186EE0350")]
	private void JGFEBHLMCOA(KHFFEHOCMIP OLHDNFLDIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFD80", Offset = "0x6EDE580", VA = "0x186EDFD80")]
	[AsyncStateMachine(typeof(PODPDAPNEGG))]
	private Task DGMBNGNMNCG(KHFFEHOCMIP OLHDNFLDIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0530", Offset = "0x6EDED30", VA = "0x186EE0530")]
	private Func<CancellationToken, List<Task>> LDNALEAFIPL(KHFFEHOCMIP OLHDNFLDIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0600", Offset = "0x6EDEE00", VA = "0x186EE0600")]
	private List<Task> PLFHGLPMCFF(KHFFEHOCMIP OLHDNFLDIIE, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFB80", Offset = "0x6EDE380", VA = "0x186EDFB80")]
	[AsyncStateMachine(typeof(HBMLADAIFMP))]
	private Task AGHMIMPMBJK(PDNHODGFBMB OMPIGNKBJLB, KHFFEHOCMIP MLKNGAFFKGE, CancellationToken OECMOOGGOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0150", Offset = "0x6EDE950", VA = "0x186EE0150")]
	[AsyncStateMachine(typeof(FAONILGKBAM))]
	private Task FBOPKADMGGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFCA0", Offset = "0x6EDE4A0", VA = "0x186EDFCA0")]
	private void AKDFKADPALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0A50", Offset = "0x6EDF250", VA = "0x186EE0A50")]
	public MLKHKBHENJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class CCNNAICEIMI : BAJCKDCCLBN, INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class HKKAKLMMHCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HKKAKLMMHCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4680", Offset = "0x6EF2E80", VA = "0x186EF4680")]
		internal object NDIAKNGJIAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class FEMINHBDOFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public FEMINHBDOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6EED370", Offset = "0x6EEBB70", VA = "0x186EED370")]
		internal object NAHGCMNILAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class IPOEPCKJIBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public IPOEPCKJIBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class DDFOCGBCCBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DDFOCGBCCBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6EEAA50", Offset = "0x6EE9250", VA = "0x186EEAA50")]
		internal object DOIFHAELCAM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class JBEGABCBHAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public JBEGABCBHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6EF75E0", Offset = "0x6EF5DE0", VA = "0x186EF75E0")]
		internal object HKCIEDFCBHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly Dictionary<Guid, CEFIBHELCAI> CIELLLOBMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly TimeSpan AFPLBIAELPH;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "9")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6580", Offset = "0x6EE4D80", VA = "0x186EE6580", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6360", Offset = "0x6EE4B60", VA = "0x186EE6360", Slot = "4")]
	public LLIIIKGFJLE CNLMKNIMMKA(Guid KPJLKKPOEPH)
	{
		return default(LLIIIKGFJLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6EE67C0", Offset = "0x6EE4FC0", VA = "0x186EE67C0", Slot = "5")]
	public bool GALPDKBCKMP(Guid KPJLKKPOEPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6EE69D0", Offset = "0x6EE51D0", VA = "0x186EE69D0", Slot = "6")]
	public bool IAABGOMCEFA(Guid KPJLKKPOEPH, Task FJFHBJJIDDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6D70", Offset = "0x6EE5570", VA = "0x186EE6D70", Slot = "7")]
	public bool ONGOEIDJOPI(Guid KPJLKKPOEPH, AICFBPACFMB MHNMFEIEGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6D00", Offset = "0x6EE5500", VA = "0x186EE6D00", Slot = "8")]
	public Task<(AICFBPACFMB, Task)> IJJPHDLCDEE(Guid KPJLKKPOEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6590", Offset = "0x6EE4D90", VA = "0x186EE6590")]
	private void EMDEDHHODDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6F50", Offset = "0x6EE5750", VA = "0x186EE6F50")]
	public CCNNAICEIMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class FFLNMKKLBFI : OPDGNECGMMI, INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class POEANAEFFOD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly PCHMOHFEPBH CJFEKFFMGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly CancellationTokenSource NPNHNCBGLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public readonly CancellationToken KMHMOFNNKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool FHOEDPHECAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private bool NIKEPOPPBPF;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F022F0", Offset = "0x6F00AF0", VA = "0x186F022F0")]
		public POEANAEFFOD(PCHMOHFEPBH CJFEKFFMGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F02170", Offset = "0x6F00970", VA = "0x186F02170")]
		public void AKDFKADPALL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F022C0", Offset = "0x6F00AC0", VA = "0x186F022C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class CAGFPHKHBGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public BKBMNDGIKLD disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public CAGFPHKHBGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6EE62D0", Offset = "0x6EE4AD0", VA = "0x186EE62D0")]
		internal object IEIJEFECFBL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct EELNBLAMACA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public BKBMNDGIKLD disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public FFLNMKKLBFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBB30", Offset = "0x6EEA330", VA = "0x186EEBB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBEE0", Offset = "0x6EEA6E0", VA = "0x186EEBEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class JLOPGKHGGAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public JLOPGKHGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6EF96B0", Offset = "0x6EF7EB0", VA = "0x186EF96B0")]
		internal object OKPAGGJLIDN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct NDDNAPJDJCD : IAsyncStateMachine
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
		public FFLNMKKLBFI <>4__this;

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
		private OHNDHAGHNHL <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC890", Offset = "0x6EFB090", VA = "0x186EFC890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9A4BE0", Offset = "0x9A33E0", VA = "0x1809A4BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class BPNAIINBEFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public PCHMOHFEPBH newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public BPNAIINBEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6050", Offset = "0x6EE4850", VA = "0x186EE6050")]
		internal object FIBLIINHHMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6010", Offset = "0x6EE4810", VA = "0x186EE6010")]
		internal object BMDENKGCLDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE60F0", Offset = "0x6EE48F0", VA = "0x186EE60F0")]
		internal object MGIEDNCNJDF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class OBMNEGDBMJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OBMNEGDBMJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF410", Offset = "0x6EFDC10", VA = "0x186EFF410")]
		internal void AFMNMKBHJIG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct HNKDODMJPCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public PCHMOHFEPBH newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public FFLNMKKLBFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public HDDMNHNKALC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private BPNAIINBEFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private OHNDHAGHNHL <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6EF47C0", Offset = "0x6EF2FC0", VA = "0x186EF47C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5740", Offset = "0x6EF3F40", VA = "0x186EF5740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly DEHOKMBMAPC.NDNOPPOJCJD DNGBPOGBINP;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly BBMBLGJIAIE KIJEFNAOACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private CDEOBFFIKEB ECJNOKELCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private CCHENENFKJI HHDKHILHGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private LJKKFDADBJA NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private OGGIGJNKKIM LNOEPHEPJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private BBBCMAMIAKL LLFOEDEEOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private long JILFCJFLGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private POEANAEFFOD IBHDIDKLHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool IMLJGKPDCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private Task KCLCLBMKOKH;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private HNGEIEMJFIB MJBBJFLCPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE8D0", Offset = "0x6EED0D0", VA = "0x186EEE8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool AFBJPPNLDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8E2370", Offset = "0x8E0B70", VA = "0x1808E2370")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE920", Offset = "0x6EED120", VA = "0x186EEE920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE4C0", Offset = "0x6EECCC0", VA = "0x186EEE4C0", Slot = "4")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE760", Offset = "0x6EECF60", VA = "0x186EEE760", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE240", Offset = "0x6EECA40", VA = "0x186EEE240")]
	[AsyncStateMachine(typeof(EELNBLAMACA))]
	private Task AJBONMCIAPJ(BKBMNDGIKLD LLKJKMMKBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE330", Offset = "0x6EECB30", VA = "0x186EEE330")]
	private void AJLMEGOFEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF0F0", Offset = "0x6EED8F0", VA = "0x186EEF0F0")]
	private void PLJJJEOCFLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB00", Offset = "0x6EED300", VA = "0x186EEEB00")]
	private void MJHBLLLLDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEC80", Offset = "0x6EED480", VA = "0x186EEEC80")]
	private bool NEAFIGMIDKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE930", Offset = "0x6EED130", VA = "0x186EEE930")]
	[AsyncStateMachine(typeof(NDDNAPJDJCD))]
	private void IEEHOLCHOON(int MALOKOEKACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEE70", Offset = "0x6EED670", VA = "0x186EEEE70")]
	private void PGPHPBNIMLN([Out] IDisposable KOLJJGLKDBN, [Out] IDisposable OGOANKMBOJP, [Out] IDisposable KKPFIFKJMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEA00", Offset = "0x6EED200", VA = "0x186EEEA00")]
	private bool KLBIBAGENJD(PCHMOHFEPBH CJFEKFFMGDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEE20", Offset = "0x6EED620", VA = "0x186EEEE20")]
	private void PCHCINPDOKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6EEECF0", Offset = "0x6EED4F0", VA = "0x186EEECF0")]
	[AsyncStateMachine(typeof(HNKDODMJPCK))]
	private Task PBOBICDOPEI(PCHMOHFEPBH CJFEKFFMGDK, HDDMNHNKALC GPEBMMOCBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF620", Offset = "0x6EEDE20", VA = "0x186EEF620")]
	public FFLNMKKLBFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class GPPHOKLGKKK : BGMHKJCBOEJ, INOFAJMOCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct LDHHNLAPMIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder<NJNAHKGLFBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public GPPHOKLGKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<NJNAHKGLFBJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9E80", Offset = "0x6EF8680", VA = "0x186EF9E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA110", Offset = "0x6EF8910", VA = "0x186EFA110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class APEDBOJFBDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public EMALNGGNKEF message;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public APEDBOJFBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4520", Offset = "0x6EE2D20", VA = "0x186EE4520")]
		internal object NHJNLNKBMLK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class AIEIGADLEBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public EMALNGGNKEF messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public AIEIGADLEBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE42E0", Offset = "0x6EE2AE0", VA = "0x186EE42E0")]
		internal object IGIKHKKEMME()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class DNLIFJAMGOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public EMALNGGNKEF request;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DNLIFJAMGOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB610", Offset = "0x6EE9E10", VA = "0x186EEB610")]
		internal object EOMJGPAABFC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct NMBLPGKIFIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public EMALNGGNKEF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public GPPHOKLGKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<CIDAEBAGAJA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6EFE360", Offset = "0x6EFCB60", VA = "0x186EFE360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6EFEC20", Offset = "0x6EFD420", VA = "0x186EFEC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class CPFAMDJKAIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public EMALNGGNKEF operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public CPFAMDJKAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9C00", Offset = "0x6EE8400", VA = "0x186EE9C00")]
		internal object KAFLAMLPIPJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct GAKPJCIBLNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public EMALNGGNKEF operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public GPPHOKLGKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private HPGKKJFFMPO <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<EMALNGGNKEF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0EB0", Offset = "0x6EEF6B0", VA = "0x186EF0EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1A10", Offset = "0x6EF0210", VA = "0x186EF1A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct EGAHNDDLJCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder<CIDAEBAGAJA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public GPPHOKLGKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public EMALNGGNKEF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private DOKLABOADCC.KOPOPHIOECK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private HPGKKJFFMPO <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<EMALNGGNKEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBF40", Offset = "0x6EEA740", VA = "0x186EEBF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC460", Offset = "0x6EEAC60", VA = "0x186EEC460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class OJACPCHECDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public CIDAEBAGAJA operation;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OJACPCHECDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF530", Offset = "0x6EFDD30", VA = "0x186EFF530")]
		internal object NKNNGCGDIEK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct IIFADCIEMIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CIDAEBAGAJA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public GPPHOKLGKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private NLBODGALKPJ<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6EF60B0", Offset = "0x6EF48B0", VA = "0x186EF60B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6EF66F0", Offset = "0x6EF4EF0", VA = "0x186EF66F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class ANIOBNGGDNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public EMALNGGNKEF request;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public ANIOBNGGDNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4340", Offset = "0x6EE2B40", VA = "0x186EE4340")]
		internal object JFDEJCJIKHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class NGIFBAPMKIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public EMALNGGNKEF request;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public NGIFBAPMKIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6EFDA10", Offset = "0x6EFC210", VA = "0x186EFDA10")]
		internal object NBMGAFHJHMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private LEJKMKADKGF OFJFCBLAIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private JHEPMHAOIPM CAKDMCBBAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private JDDBKHMCBOJ POBLDEGHOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private OPBLEBEBLOF NEMGCIKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private TaskCompletionSource<NJNAHKGLFBJ> OKHKKHOMDMJ;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2DC0", Offset = "0x6EF15C0", VA = "0x186EF2DC0", Slot = "7")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3210", Offset = "0x6EF1A10", VA = "0x186EF3210", Slot = "6")]
	[AsyncStateMachine(typeof(LDHHNLAPMIM))]
	public Task<NJNAHKGLFBJ> FKEGBKFNOMH(CancellationToken LMLBNDBALCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3650", Offset = "0x6EF1E50", VA = "0x186EF3650", Slot = "4")]
	public void LNKLFEFGGCO(EMALNGGNKEF CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2EB0", Offset = "0x6EF16B0", VA = "0x186EF2EB0", Slot = "5")]
	public void FACEAFFENKN(EMALNGGNKEF IIFIKBGEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3F10", Offset = "0x6EF2710", VA = "0x186EF3F10")]
	[AsyncStateMachine(typeof(NMBLPGKIFIN))]
	private Task NKNCKMJILOI(EMALNGGNKEF LOGLBHMJLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3A70", Offset = "0x6EF2270", VA = "0x186EF3A70")]
	[AsyncStateMachine(typeof(GAKPJCIBLNF))]
	private Task MMMEKGODLFL(EMALNGGNKEF BBKDEAIKGOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4020", Offset = "0x6EF2820", VA = "0x186EF4020")]
	[AsyncStateMachine(typeof(EGAHNDDLJCD))]
	private Task<CIDAEBAGAJA> OJFLONNMKLF(EMALNGGNKEF LOGLBHMJLPF, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6EF39E0", Offset = "0x6EF21E0", VA = "0x186EF39E0")]
	private HPGKKJFFMPO MCOMLECFCNF(EMALNGGNKEF MIKKGLIBJID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3320", Offset = "0x6EF1B20", VA = "0x186EF3320")]
	[AsyncStateMachine(typeof(IIFADCIEMIC))]
	private Task GBGBLKOBGBB(CIDAEBAGAJA HPMMBJCHINM, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3440", Offset = "0x6EF1C40", VA = "0x186EF3440")]
	private CIDAEBAGAJA ICMPONFEPGL(EMALNGGNKEF LOGLBHMJLPF, HPGKKJFFMPO AEADNMNGGPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DA20", Offset = "0x2A9C220", VA = "0x182A9DA20")]
	private T HKICGNLPLJM<T>(T IPHHABIKCHD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3B80", Offset = "0x6EF2380", VA = "0x186EF3B80")]
	private CIDAEBAGAJA MPJPMFEBPML(EMALNGGNKEF LOGLBHMJLPF, HPGKKJFFMPO AEADNMNGGPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public GPPHOKLGKKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class CFDJPBDPOLL : JHEPMHAOIPM, INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class MCHIOMDOHNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public MCHIOMDOHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA9D0", Offset = "0x6EF91D0", VA = "0x186EFA9D0")]
		internal object OGIIEADEBOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class BCLMPAEOEMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public BCLMPAEOEMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4EA0", Offset = "0x6EE36A0", VA = "0x186EE4EA0")]
		internal object BKHOOPJIKLN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private OPBLEBEBLOF NEMGCIKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private KFINKBEBLKO IJKIKHNMEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private BGMHKJCBOEJ INBCLKPDHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private BAJCKDCCLBN CIELLLOBMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private HBPICLEGDCB MFHHKFAAFGH;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7290", Offset = "0x6EE5A90", VA = "0x186EE7290", Slot = "6")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7400", Offset = "0x6EE5C00", VA = "0x186EE7400", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8950", Offset = "0x6EE7150", VA = "0x186EE8950", Slot = "4")]
	public LLIIIKGFJLE MOIHEAIBBGC(EMALNGGNKEF PBEEFAHGGAJ)
	{
		return default(LLIIIKGFJLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6EE74B0", Offset = "0x6EE5CB0", VA = "0x186EE74B0", Slot = "5")]
	public void FFGNMGFHOCM(Guid KPJLKKPOEPH, Task FJFHBJJIDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8380", Offset = "0x6EE6B80", VA = "0x186EE8380")]
	private void LIKINHNKPIE(byte GMIAECOLMDL, int DEDFBLKFGCL, object CAPOHLNMDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7960", Offset = "0x6EE6160", VA = "0x186EE7960")]
	private void JBCMBMKNJIJ(EDBJOGACFMB BNEKFHGOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8450", Offset = "0x6EE6C50", VA = "0x186EE8450")]
	private void LMCJFLKDNJK(EDBJOGACFMB BNEKFHGOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7ED0", Offset = "0x6EE66D0", VA = "0x186EE7ED0")]
	private void KIHLHPLKDAK(EDBJOGACFMB BNEKFHGOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8D70", Offset = "0x6EE7570", VA = "0x186EE8D70")]
	private AICFBPACFMB OALDPEDGGCO(EMALNGGNKEF MIKKGLIBJID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8750", Offset = "0x6EE6F50", VA = "0x186EE8750")]
	private void MGJKIGNMEJF(EMALNGGNKEF BBKDEAIKGOC, AICFBPACFMB MHNMFEIEGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6EE76C0", Offset = "0x6EE5EC0", VA = "0x186EE76C0")]
	private bool GBAEGKBGKGF(EMALNGGNKEF BBKDEAIKGOC, AICFBPACFMB MHNMFEIEGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8110", Offset = "0x6EE6910", VA = "0x186EE8110")]
	private bool LAIPIHKCELP(EMALNGGNKEF KADKHAJKKNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7010", Offset = "0x6EE5810", VA = "0x186EE7010")]
	private bool APDODIPMAEF(byte GMIAECOLMDL, ExitGames.Client.Photon.Hashtable BNEKFHGOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public CFDJPBDPOLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class PJNNGIGMKPI : NADPPMHPNAO, INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class CADIAGJJMOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public NJNAHKGLFBJ operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public PJNNGIGMKPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public EMALNGGNKEF roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public CADIAGJJMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6130", Offset = "0x6EE4930", VA = "0x186EE6130")]
		internal object DIJMKAFEHPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6EE61A0", Offset = "0x6EE49A0", VA = "0x186EE61A0")]
		internal object OPOJIEBGGLE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct IKPAEOJGAAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<AICFBPACFMB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public PJNNGIGMKPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public EMALNGGNKEF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<AICFBPACFMB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6750", Offset = "0x6EF4F50", VA = "0x186EF6750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6DD0", Offset = "0x6EF55D0", VA = "0x186EF6DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class JNBADOGHJOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public NJNAHKGLFBJ operationType;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public JNBADOGHJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9720", Offset = "0x6EF7F20", VA = "0x186EF9720")]
		internal object FDFEGBJBDJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class NLGGPIFGOEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public EMALNGGNKEF request;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public NLGGPIFGOEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6EFDA70", Offset = "0x6EFC270", VA = "0x186EFDA70")]
		internal object AMELFJMNJKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6EFDAE0", Offset = "0x6EFC2E0", VA = "0x186EFDAE0")]
		internal object NONKGECMMHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6EFDB50", Offset = "0x6EFC350", VA = "0x186EFDB50")]
		internal object OLCDLJFPNIA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct BAEKGAAFAEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<AICFBPACFMB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public EMALNGGNKEF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public PJNNGIGMKPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private NLGGPIFGOEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private LLIIIKGFJLE <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private AICFBPACFMB <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter<(AICFBPACFMB validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4580", Offset = "0x6EE2D80", VA = "0x186EE4580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4E30", Offset = "0x6EE3630", VA = "0x186EE4E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private OPBLEBEBLOF NEMGCIKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private KFINKBEBLKO IJKIKHNMEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private JHEPMHAOIPM CAKDMCBBAMO;

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6F01810", Offset = "0x6F00010", VA = "0x186F01810", Slot = "5")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6F01A00", Offset = "0x6F00200", VA = "0x186F01A00", Slot = "4")]
	[AsyncStateMachine(typeof(IKPAEOJGAAJ))]
	private Task<AICFBPACFMB> JPEDKGHHKJF(EMALNGGNKEF MIKKGLIBJID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6F01B20", Offset = "0x6F00320", VA = "0x186F01B20")]
	private bool MGKHCDHAFLF(NJNAHKGLFBJ LOFAINCFOJE, [Out] AICFBPACFMB KKBKNCNBBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6F018C0", Offset = "0x6F000C0", VA = "0x186F018C0")]
	[AsyncStateMachine(typeof(BAEKGAAFAEP))]
	private Task<AICFBPACFMB> IECLAPICFKB(EMALNGGNKEF LOGLBHMJLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public PJNNGIGMKPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class PILBHBKBHKC : HLMIDPDLNEO, INOFAJMOCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct ELDKKGJABJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<JKENAGDJKCF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public PCHMOHFEPBH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public PILBHBKBHKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private TaskAwaiter<APGABJIFLDK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC4D0", Offset = "0x6EEACD0", VA = "0x186EEC4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC980", Offset = "0x6EEB180", VA = "0x186EEC980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class ONPOAPIOCDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public ONPOAPIOCDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF7F0", Offset = "0x6EFDFF0", VA = "0x186EFF7F0")]
		internal object BDENDJAGOPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct KOKABPBDOHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public AsyncTaskMethodBuilder<APGABJIFLDK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public PILBHBKBHKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public PCHMOHFEPBH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private ONPOAPIOCDJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<APGABJIFLDK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6EF97F0", Offset = "0x6EF7FF0", VA = "0x186EF97F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9DE0", Offset = "0x6EF85E0", VA = "0x186EF9DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class BCKPGJPLEDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public BCKPGJPLEDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8ED470", Offset = "0x8EBC70", VA = "0x1808ED470")]
		internal bool BIBONNCNACA(FCAFGPLEBDB sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private LJKKFDADBJA NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private MHEKKGCANGA EKHDLCMHFGB;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly (KGMNHEONACL superRoomData, long subRoomDataSaveId) ECDPPIAKFND;

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6F00250", Offset = "0x6EFEA50", VA = "0x186F00250", Slot = "5")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFFB0", Offset = "0x6EFE7B0", VA = "0x186EFFFB0", Slot = "4")]
	[AsyncStateMachine(typeof(ELDKKGJABJB))]
	public Task<JKENAGDJKCF> AJLIOGGJFBN(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, PCHMOHFEPBH KNAECKPPIKB, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6F002E0", Offset = "0x6EFEAE0", VA = "0x186F002E0")]
	[AsyncStateMachine(typeof(KOKABPBDOHN))]
	private Task<APGABJIFLDK> GPOPENBLCOE(PCHMOHFEPBH KNAECKPPIKB, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6F00110", Offset = "0x6EFE910", VA = "0x186F00110")]
	private JKENAGDJKCF CLBBFLAKPJH(PCHMOHFEPBH KNAECKPPIKB, APGABJIFLDK HHIDENNENFF, long PMNPMGPNLGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6F00440", Offset = "0x6EFEC40", VA = "0x186F00440")]
	private (KGMNHEONACL, long) KOKBADJAMCH(PCHMOHFEPBH KNAECKPPIKB, APGABJIFLDK HHIDENNENFF, long PMNPMGPNLGO)
	{
		return default((KGMNHEONACL, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public PILBHBKBHKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal sealed class PJIAHIAFNPJ : JDDBKHMCBOJ, INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class AOLCFMFMBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public EMALNGGNKEF request;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public AOLCFMFMBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6EE44C0", Offset = "0x6EE2CC0", VA = "0x186EE44C0")]
		internal object EEEODCGOMCE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct PJBBJLFBFBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder<EMALNGGNKEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public EMALNGGNKEF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public PJIAHIAFNPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public HPGKKJFFMPO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<EMALNGGNKEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x6F007F0", Offset = "0x6EFEFF0", VA = "0x186F007F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6F00E00", Offset = "0x6EFF600", VA = "0x186F00E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct FBIHDEJOPJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder<EMALNGGNKEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public PJIAHIAFNPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public HPGKKJFFMPO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter<NHLOFAEBHHM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6EECD10", Offset = "0x6EEB510", VA = "0x186EECD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6EED300", Offset = "0x6EEBB00", VA = "0x186EED300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class MBCFNLLMIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public EMALNGGNKEF request;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public MBCFNLLMIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA970", Offset = "0x6EF9170", VA = "0x186EFA970")]
		internal object PJMPLGDLNCF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct CJHEGPEDDME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder<EMALNGGNKEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public EMALNGGNKEF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public PJIAHIAFNPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public HPGKKJFFMPO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private LDOJPCGBHFK <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private MKKJIJLDEHJ <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter<NHLOFAEBHHM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8FA0", Offset = "0x6EE77A0", VA = "0x186EE8FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9B90", Offset = "0x6EE8390", VA = "0x186EE9B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private OPBLEBEBLOF NEMGCIKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private MHNAGLGBMGG GIFDPKFLDOC;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private OFJKNPELLGL BPNMACEFAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x6F01310", Offset = "0x6EFFB10", VA = "0x186F01310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6F00E70", Offset = "0x6EFF670", VA = "0x186F00E70", Slot = "8")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x6F00F00", Offset = "0x6EFF700", VA = "0x186F00F00", Slot = "4")]
	[AsyncStateMachine(typeof(PJBBJLFBFBO))]
	public Task<EMALNGGNKEF> EMDMPELMEJC(EMALNGGNKEF LOGLBHMJLPF, HPGKKJFFMPO AEADNMNGGPI, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x6F01060", Offset = "0x6EFF860", VA = "0x186F01060", Slot = "5")]
	[AsyncStateMachine(typeof(FBIHDEJOPJN))]
	public Task<EMALNGGNKEF> JEBGOCDBGPI(CancellationToken ODNHMAMKFFP, HPGKKJFFMPO AEADNMNGGPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x6F013D0", Offset = "0x6EFFBD0", VA = "0x186F013D0", Slot = "6")]
	public FGOFJPDDCML PIMJEEEMCKP(CIDAEBAGAJA GALLALMLOPN, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6F015E0", Offset = "0x6EFFDE0", VA = "0x186F015E0", Slot = "7")]
	public FGOFJPDDCML POHHIGAKKKD(CIDAEBAGAJA GALLALMLOPN, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x6F011B0", Offset = "0x6EFF9B0", VA = "0x186F011B0")]
	[AsyncStateMachine(typeof(CJHEGPEDDME))]
	private Task<EMALNGGNKEF> KCFFCPGDOEN(EMALNGGNKEF LOGLBHMJLPF, HPGKKJFFMPO AEADNMNGGPI, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F190", Offset = "0x2A6D990", VA = "0x182A6F190")]
	private static byte[] APCHCKGLFKL(EMALNGGNKEF CLBGCJICGJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public PJIAHIAFNPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class PGGJOPJDIBB : KFINKBEBLKO, INOFAJMOCKL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private GIDMKHKFBNB EJACLDLDJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private OPBLEBEBLOF NEMGCIKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private LEJKMKADKGF OFJFCBLAIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private OLHPPHFILMA ADMMLGOCKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private LJKKFDADBJA NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private BBBCMAMIAKL LLFOEDEEOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private GEEBECHPOFO IJFOBADJGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private OGGIGJNKKIM LNOEPHEPJGF;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private HNGEIEMJFIB MJBBJFLCPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6EFFAF0", Offset = "0x6EFE2F0", VA = "0x186EFFAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private static AICFBPACFMB DPDLFINIBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA530", Offset = "0x6EE8D30", VA = "0x186EEA530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF980", Offset = "0x6EFE180", VA = "0x186EFF980", Slot = "6")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFB40", Offset = "0x6EFE340", VA = "0x186EFFB40", Slot = "4")]
	public AICFBPACFMB KAHNFPOMCJL(KCMOAPDBFGB EPAILNGPKNK, NJNAHKGLFBJ IOKNHBBOAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFCB0", Offset = "0x6EFE4B0", VA = "0x186EFFCB0", Slot = "5")]
	public AICFBPACFMB LDOCKFALECA(KCMOAPDBFGB JODLIPLAEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA9F0", Offset = "0x6EE91F0", VA = "0x186EEA9F0")]
	private static AICFBPACFMB PEAFAMHNDHO(JKAICPKMEEA DAGAMHLIEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public PGGJOPJDIBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class PKEIOMLAFPA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x6F01D10", Offset = "0x6F00510", VA = "0x186F01D10")]
	public PKEIOMLAFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x63C42D0", Offset = "0x63C2AD0", VA = "0x1863C42D0")]
	public PKEIOMLAFPA(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class GGAMECJGPIK : MAAKEPCALKG, INOFAJMOCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct JIMMEPCHLFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<AICFBPACFMB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public GGAMECJGPIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public GJKNKHPAHGK autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private NLBODGALKPJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private LGFBEDKDLGK <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private TaskAwaiter<AICFBPACFMB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7BB0", Offset = "0x6EF63B0", VA = "0x186EF7BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8740", Offset = "0x6EF6F40", VA = "0x186EF8740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct NPDKHIJCIHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public GGAMECJGPIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6EFEC80", Offset = "0x6EFD480", VA = "0x186EFEC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF3B0", Offset = "0x6EFDBB0", VA = "0x186EFF3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct JFJAKICENLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public GGAMECJGPIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7640", Offset = "0x6EF5E40", VA = "0x186EF7640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7B50", Offset = "0x6EF6350", VA = "0x186EF7B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct INEHGCGFFLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public GGAMECJGPIK <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6E40", Offset = "0x6EF5640", VA = "0x186EF6E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7580", Offset = "0x6EF5D80", VA = "0x186EF7580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct LFONIJNKDMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public GGAMECJGPIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA200", Offset = "0x6EF8A00", VA = "0x186EFA200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA3A0", Offset = "0x6EF8BA0", VA = "0x186EFA3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct BEJPCDGDGIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public GGAMECJGPIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4F10", Offset = "0x6EE3710", VA = "0x186EE4F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5620", Offset = "0x6EE3E20", VA = "0x186EE5620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct FPJBJFMDJEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public GGAMECJGPIK <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF09E0", Offset = "0x6EEF1E0", VA = "0x186EF09E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0E50", Offset = "0x6EEF650", VA = "0x186EF0E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct JJIJMJFCDGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public GGAMECJGPIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public JBEOMJBFOMC autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private NLBODGALKPJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6EF87B0", Offset = "0x6EF6FB0", VA = "0x186EF87B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8D10", Offset = "0x6EF7510", VA = "0x186EF8D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private OPBLEBEBLOF NEMGCIKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private LJKKFDADBJA NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private JDDBKHMCBOJ POBLDEGHOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private LEJKMKADKGF OFJFCBLAIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private GEEBECHPOFO IJFOBADJGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private CancellationTokenSource MDFKIBJFFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private Task JGGJCBIBBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private TaskCompletionSource<int> ADFNIIKIAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private int CPEGECJJDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private int PFFJHNMAAIN;

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1D40", Offset = "0x6EF0540", VA = "0x186EF1D40", Slot = "6")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0xA32B60", Offset = "0xA31360", VA = "0x180A32B60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1FE0", Offset = "0x6EF07E0", VA = "0x186EF1FE0")]
	private void FLIENCANNPL(float KMNIPFDKIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2930", Offset = "0x6EF1130", VA = "0x186EF2930", Slot = "4")]
	[AsyncStateMachine(typeof(JIMMEPCHLFP))]
	public Task<AICFBPACFMB> OOCLDJNBCAA(GJKNKHPAHGK OGANCPGOCOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1EF0", Offset = "0x6EF06F0", VA = "0x186EF1EF0", Slot = "5")]
	[AsyncStateMachine(typeof(NPDKHIJCIHL))]
	public Task FIOILNADMDN([Optional] CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0xA32B60", Offset = "0xA31360", VA = "0x180A32B60")]
	public void MCAAEJOHBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x6EF27C0", Offset = "0x6EF0FC0", VA = "0x186EF27C0")]
	private LGFBEDKDLGK NHFLMBLIEOG(GJKNKHPAHGK OGANCPGOCOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1A70", Offset = "0x6EF0270", VA = "0x186EF1A70")]
	[AsyncStateMachine(typeof(JFJAKICENLD))]
	private Task AOFJOCIPDIO(KHFFEHOCMIP NOFEINPOGPG, CancellationToken OKNLKNIHJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x6EF22D0", Offset = "0x6EF0AD0", VA = "0x186EF22D0")]
	[AsyncStateMachine(typeof(INEHGCGFFLO))]
	private Task JHIGBEHPHDG(CancellationToken OKNLKNIHJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1B60", Offset = "0x6EF0360", VA = "0x186EF1B60")]
	[AsyncStateMachine(typeof(LFONIJNKDMC))]
	private Task BHIKPFFELAN([Optional] CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1C50", Offset = "0x6EF0450", VA = "0x186EF1C50")]
	[AsyncStateMachine(typeof(BEJPCDGDGIE))]
	private Task DGBPJJPHNBD(CancellationToken OKNLKNIHJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6EF20C0", Offset = "0x6EF08C0", VA = "0x186EF20C0")]
	[AsyncStateMachine(typeof(FPJBJFMDJEF))]
	private Task GDBGDOKPBND(CancellationToken AGHPPIEPDJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2630", Offset = "0x6EF0E30", VA = "0x186EF2630")]
	private Task LBDBBACHGII(JBEOMJBFOMC PFIHPPKOFGJ, CancellationToken OKNLKNIHJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6EF21C0", Offset = "0x6EF09C0", VA = "0x186EF21C0")]
	[AsyncStateMachine(typeof(JJIJMJFCDGJ))]
	private Task IBIAIGNBCFK(JBEOMJBFOMC PFIHPPKOFGJ, CancellationToken OKNLKNIHJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF23D0", Offset = "0x6EF0BD0", VA = "0x186EF23D0")]
	private bool JOPEKHFGFFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public GGAMECJGPIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[UnityEngine.Scripting.Preserve]
internal class NLJMCCDONJB : OLHPPHFILMA, INOFAJMOCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct DGMFOBLIOGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public NLJMCCDONJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private NLBODGALKPJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB050", Offset = "0x6EE9850", VA = "0x186EEB050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB5B0", Offset = "0x6EE9DB0", VA = "0x186EEB5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private LIECJJGNCKP EJPPNLGHPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private KFINKBEBLKO IJKIKHNMEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private JDDBKHMCBOJ POBLDEGHOGL;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6EFDBC0", Offset = "0x6EFC3C0", VA = "0x186EFDBC0", Slot = "6")]
	public void DIHNAABPOCM(KBOGPEMMJMI JFHCNNPIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6EFDEA0", Offset = "0x6EFC6A0", VA = "0x186EFDEA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE040", Offset = "0x6EFC840", VA = "0x186EFE040", Slot = "5")]
	[AsyncStateMachine(typeof(DGMFOBLIOGK))]
	public Task LFCKOFEDNIM(string FKOPBOJEAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6EFDFE0", Offset = "0x6EFC7E0", VA = "0x186EFDFE0", Slot = "4")]
	public AICFBPACFMB JOPEKHFGFFN(KCMOAPDBFGB EPAILNGPKNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6EFDEF0", Offset = "0x6EFC6F0", VA = "0x186EFDEF0")]
	private EPKNKBHKMHE IKMKKGHNEGK(string FKOPBOJEAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public NLJMCCDONJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class DAAPCDNEOHB
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA2F0", Offset = "0x6EE8AF0", VA = "0x186EEA2F0")]
	public static void MMFILPENNGK(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9C60", Offset = "0x6EE8460", VA = "0x186EE9C60")]
	internal static void DJJEMHMFMCJ(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9DC0", Offset = "0x6EE85C0", VA = "0x186EE9DC0")]
	internal static void EAOEFJLANKF(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9EA0", Offset = "0x6EE86A0", VA = "0x186EE9EA0")]
	internal static void FAHGKGGFCIO(AANDDJDEEFL KDCLBHAMNHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class BMCNKNKIEKB : HPEOKMEGANF<EMALNGGNKEF>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class GOBHFJMFMGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public EMALNGGNKEF message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public GOBHFJMFMGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2A60", Offset = "0x6EF1260", VA = "0x186EF2A60")]
		internal object PHKNELHKJCL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly BMCNKNKIEKB DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5B50", Offset = "0x6EE4350", VA = "0x186EE5B50")]
	public ExitGames.Client.Photon.Hashtable HNAIEAEAFJH(EMALNGGNKEF CLBGCJICGJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5BE0", Offset = "0x6EE43E0", VA = "0x186EE5BE0", Slot = "5")]
	protected override void OCPCNPGNIIG(EMALNGGNKEF CLBGCJICGJG, IDictionary<object, object> MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5D10", Offset = "0x6EE4510", VA = "0x186EE5D10", Slot = "6")]
	public override EMALNGGNKEF PKPMANIAHDL(IDictionary<object, object> MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5790", Offset = "0x6EE3F90", VA = "0x186EE5790")]
	private static void CPICANFMBIK(string DPMBLPDIHKF, EMALNGGNKEF CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5FD0", Offset = "0x6EE47D0", VA = "0x186EE5FD0")]
	public BMCNKNKIEKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6EE58A0", Offset = "0x6EE40A0", VA = "0x186EE58A0")]
	[CompilerGenerated]
	internal static string DGLBLHELLIL(JKENAGDJKCF EMIMPCIEFOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class DCJBCPJKLEA
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public static AICFBPACFMB DPDLFINIBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA530", Offset = "0x6EE8D30", VA = "0x186EEA530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA590", Offset = "0x6EE8D90", VA = "0x186EEA590")]
	public static bool FJJCLFHGPNA(this AICFBPACFMB MHNMFEIEGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA9F0", Offset = "0x6EE91F0", VA = "0x186EEA9F0")]
	public static AICFBPACFMB PEAFAMHNDHO(JKAICPKMEEA MNHEGHFCLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA800", Offset = "0x6EE9000", VA = "0x186EEA800")]
	public static AICFBPACFMB MLAOBKKPMLB(IEnumerable<AICFBPACFMB> LMAMPAPLMBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA5B0", Offset = "0x6EE8DB0", VA = "0x186EEA5B0")]
	public static string GDIDBGPIJEG(this AICFBPACFMB KKBKNCNBBJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class MPLJMPEKCNK : MIJBFFDLOIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate AICFBPACFMB ALNCHMAONKP([NotNull] KCMOAPDBFGB GHHPLOEHBGA);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class ANAHNFCAINA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public KCMOAPDBFGB photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public ANAHNFCAINA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x65B4910", Offset = "0x65B3110", VA = "0x1865B4910")]
		internal AICFBPACFMB HECOEEPMHPH(ALNCHMAONKP v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private bool HOBFAPAFPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	protected readonly HashSet<ALNCHMAONKP> MFPCDBAGDJC;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB090", Offset = "0x6EF9890", VA = "0x186EFB090", Slot = "4")]
	public void MMGJIHKLLBM(ALNCHMAONKP ABAGGMBAAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6EFADA0", Offset = "0x6EF95A0", VA = "0x186EFADA0", Slot = "5")]
	public void JLMAKABMHOB(ALNCHMAONKP ABAGGMBAAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6EFAD50", Offset = "0x6EF9550", VA = "0x186EFAD50", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6EFAE00", Offset = "0x6EF9600", VA = "0x186EFAE00")]
	protected AICFBPACFMB MICLABCPLBE(KCMOAPDBFGB JODLIPLAEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB0F0", Offset = "0x6EF98F0", VA = "0x186EFB0F0")]
	protected MPLJMPEKCNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class AOKNLLPJDEM : MPLJMPEKCNK, GIDMKHKFBNB, MIJBFFDLOIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class KLDLJDDAILM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public AICFBPACFMB result;

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KLDLJDDAILM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9790", Offset = "0x6EF7F90", VA = "0x186EF9790")]
		internal object KGGPMCJOCDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6EE44B0", Offset = "0x6EE2CB0", VA = "0x186EE44B0")]
	[UnityEngine.Scripting.Preserve]
	public AOKNLLPJDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6EE43A0", Offset = "0x6EE2BA0", VA = "0x186EE43A0", Slot = "8")]
	public AICFBPACFMB HECKJAINMBC(KCMOAPDBFGB JODLIPLAEMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class BJOFEEKPADA : MPLJMPEKCNK, LIECJJGNCKP, MIJBFFDLOIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class HHFFENJFMOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AICFBPACFMB result;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HHFFENJFMOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4620", Offset = "0x6EF2E20", VA = "0x186EF4620")]
		internal object LLNHBHPLAMM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6EE44B0", Offset = "0x6EE2CB0", VA = "0x186EE44B0")]
	[UnityEngine.Scripting.Preserve]
	public BJOFEEKPADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5680", Offset = "0x6EE3E80", VA = "0x186EE5680", Slot = "8")]
	public AICFBPACFMB JOPEKHFGFFN(KCMOAPDBFGB GBDHHGKEDDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class POEDIILBMAO
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class LDHJMHIGIBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public NLBODGALKPJ<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public LDHJMHIGIBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA180", Offset = "0x6EF8980", VA = "0x186EFA180")]
		internal object NNHODHEIBAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F02520", Offset = "0x6F00D20", VA = "0x186F02520")]
	public static NLBODGALKPJ<string> LJEOGHFOCHN(MMJHHDEPGMK LPJFGGMIIEB, [Optional] string LOOAEBPKNEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F023A0", Offset = "0x6F00BA0", VA = "0x186F023A0")]
	public static void BGGCKIJFAPK(NLBODGALKPJ<string> JPMGDEGBMJK, MMJHHDEPGMK LPJFGGMIIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F02460", Offset = "0x6F00C60", VA = "0x186F02460")]
	public static string EIKAIHHABAH(EMALNGGNKEF MIKKGLIBJID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class EABHKINELJG
{
	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB7A0", Offset = "0x6EE9FA0", VA = "0x186EEB7A0")]
	public static void PMJPCLHEKBD(this OPBLEBEBLOF NEMGCIKNBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB790", Offset = "0x6EE9F90", VA = "0x186EEB790")]
	public static void DGKLLHOIFOB(this OPBLEBEBLOF NEMGCIKNBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB670", Offset = "0x6EE9E70", VA = "0x186EEB670")]
	private static void APFNFAJBIOM(this OPBLEBEBLOF NEMGCIKNBKO, bool AOMCAKPDGKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class MAHMJJMEFOD : GJKIACEPPEK, HHCLAIEGLCF, ACPOBDOBPIG, NCONDMFDFCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly HHCLAIEGLCF FAJKHLMJCCJ;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public KCMOAPDBFGB JHOIDJKOAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA7C0", Offset = "0x6EF8FC0", VA = "0x186EFA7C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public int IMDFGGADIGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA860", Offset = "0x6EF9060", VA = "0x186EFA860", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int FEPNMGGNFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA5F0", Offset = "0x6EF8DF0", VA = "0x186EFA5F0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool PNENFEEBKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int DCLFOKAJCOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CA0", Offset = "0x8C34A0", VA = "0x1808C4CA0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event CHPIGCHHMNK.NINGGDLFKHN DBIAEMJKLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event EAIGGCIEDEM FJENPNBOPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA400", Offset = "0x6EF8C00", VA = "0x186EFA400", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA550", Offset = "0x6EF8D50", VA = "0x186EFA550", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> OEHKBFKOEGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<KCMOAPDBFGB> HHFOJNKFMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action HDFCHKNDACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA720", Offset = "0x6EF8F20", VA = "0x186EFA720", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA8D0", Offset = "0x6EF90D0", VA = "0x186EFA8D0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xCAB9C0", Offset = "0xCAA1C0", VA = "0x180CAB9C0")]
	public MAHMJJMEFOD(HHCLAIEGLCF FAJKHLMJCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA4A0", Offset = "0x6EF8CA0", VA = "0x186EFA4A0", Slot = "8")]
	public bool FDAMEAKPLCD(byte GMIAECOLMDL, ExitGames.Client.Photon.Hashtable MEPMIHAMDIC, OCGJNBHCFKF MIOIIAEPFAJ, SendOptions EFJILCJNAEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA640", Offset = "0x6EF8E40", VA = "0x186EFA640", Slot = "16")]
	public KCMOAPDBFGB HLAKEIOGOLO(int AFPGBMLCIPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "19")]
	public void DNIFHFDPABD(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "20")]
	public void OAFNFCDENJH(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "21")]
	public void GPDMDBMADFK(object OECMOOGGOOF, bool BIFBPGMONNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA810", Offset = "0x6EF9010", VA = "0x186EFA810", Slot = "22")]
	public IDisposable KAGNBJFHDDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "23")]
	private bool NFKLOIMPJPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "24")]
	public void HHPBAJLKIAI(StringBuilder BOCHJLCNGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA8B0", Offset = "0x6EF90B0", VA = "0x186EFA8B0", Slot = "25")]
	public bool NDPCDGNJHMK(bool MGCJOPGMLCB, [Out] string EBFMCGAMIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x944E60", Offset = "0x943660", VA = "0x180944E60", Slot = "28")]
	public void DMEMCBELNCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct EDBJOGACFMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private readonly IDictionary<object, object> BNEKFHGOPID;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
	public EDBJOGACFMB(IDictionary<object, object> BNEKFHGOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB8E0", Offset = "0x6EEA0E0", VA = "0x186EEB8E0")]
	public bool DHACPCEFMKE([Out] EMALNGGNKEF CLBGCJICGJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6EEBA80", Offset = "0x6EEA280", VA = "0x186EEBA80")]
	public Guid FLLBOMFGHLK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB7B0", Offset = "0x6EE9FB0", VA = "0x186EEB7B0")]
	public AICFBPACFMB DEMAHKIGLOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB990", Offset = "0x6EEA190", VA = "0x186EEB990")]
	public static ExitGames.Client.Photon.Hashtable DLNFHNOLCMJ(EMALNGGNKEF CLBGCJICGJG, AICFBPACFMB MHNMFEIEGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class ODIDLJLEKKE
{
	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF4B0", Offset = "0x6EFDCB0", VA = "0x186EFF4B0")]
	public static bool GJMAFGHMFME(this PCHMOHFEPBH OHIPFKMIAAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct JLMLNIGFFCB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct OLNGGLKHGHP : IAsyncStateMachine
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
		public JLMLNIGFFCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF5B0", Offset = "0x6EFDDB0", VA = "0x186EFF5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF790", Offset = "0x6EFDF90", VA = "0x186EFF790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private readonly CancellationTokenSource NPNHNCBGLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private bool HOBFAPAFPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private Task GECIOHOBBCH;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool CPEGFNCLDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9550", Offset = "0x6EF7D50", VA = "0x186EF9550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9580", Offset = "0x6EF7D80", VA = "0x186EF9580")]
	public JLMLNIGFFCB(CancellationToken ODNHMAMKFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x6EF93F0", Offset = "0x6EF7BF0", VA = "0x186EF93F0")]
	[AsyncStateMachine(typeof(OLNGGLKHGHP))]
	public Task BPCKBPLJHMD(Func<CancellationToken, List<Task>> NDPAMBHJAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9500", Offset = "0x6EF7D00", VA = "0x186EF9500", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct PGLFAMIAGPB<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct AMHMFEKOAFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<FBNAOJOLFEH<TData>, PLHOCJDFICM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public PGLFAMIAGPB<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<MEKCEIEFNPI<FBNAOJOLFEH<TData>, PLHOCJDFICM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x3C53390", Offset = "0x3C51B90", VA = "0x183C53390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x3B92100", Offset = "0x3B90900", VA = "0x183B92100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly IOMJMIBGPGC<TGetDataArg, TData> KKHHCBLJJJL;

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
	internal PGLFAMIAGPB(IOMJMIBGPGC<TGetDataArg, TData> DNJOEPEBEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x46576D0", Offset = "0x4655ED0", VA = "0x1846576D0")]
	[AsyncStateMachine(typeof(PGLFAMIAGPB<, >.AMHMFEKOAFK))]
	public Task<MEKCEIEFNPI<FBNAOJOLFEH<TData>, PLHOCJDFICM>> AFPNPIALEIL(TGetDataArg NIFGNHBNLFL, string FJHLGOLNCNL, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class PBBEJECFDCI
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2831260", Offset = "0x282FA60", VA = "0x182831260")]
	public static PGLFAMIAGPB<TGetDataArg, TData> OJFFIHPLODM<TGetDataArg, TData>(IOMJMIBGPGC<TGetDataArg, TData> DNJOEPEBEMJ)
	{
		return default(PGLFAMIAGPB<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct HKPKAELHFCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public readonly int IIFKGOGGDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public readonly int? PKPKOFPCIJI;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x41342F0", Offset = "0x4132AF0", VA = "0x1841342F0")]
	public HKPKAELHFCG(int OHCBIMJNIPL, [Optional] int? DADBNPMKLLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x6EF46E0", Offset = "0x6EF2EE0", VA = "0x186EF46E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface BOKINDNHMGP<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHMHJMFJDEI();

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BOKINDNHMGP<T> BPCLAPBOKHL(string COBPFHINIBC);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BOKINDNHMGP<T> LAFLLBKGGAC(EOFFIDPFLDL<T> BDADPLLPCBP);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BOKINDNHMGP<T> GFNBIFMFCBM(int FOBCBIEDHCL);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BOKINDNHMGP<T> FPGCGPAGIDO(int FOBCBIEDHCL, LPIICIKAJGN<T> GPODFJMMBEM);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface IGDJMNLBKKF
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BOKINDNHMGP<T> KIGCCLDCCHN<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MKFDMGLAODJ PBIDNLEGDNG(Exception BCGGAGLBPHE);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HKPKAELHFCG DFJHHKAJLII(Exception BCGGAGLBPHE);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate string EOFFIDPFLDL<in T>(T BCGGAGLBPHE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public delegate int LPIICIKAJGN<in T>(T BCGGAGLBPHE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class NCCHMLPEKJC : IGDJMNLBKKF
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate string LEDFFPJBHKG(Exception BCGGAGLBPHE);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private delegate int LLPDGLHICMH(Exception BCGGAGLBPHE);

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class EJPNEGHJPPH<T> : BOKINDNHMGP<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class MDMCMCFEHMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public MDMCMCFEHMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			internal string GOFJIOKAICE(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class GIBNDGLEODJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public EOFFIDPFLDL<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public GIBNDGLEODJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x3BDD7B0", Offset = "0x3BDBFB0", VA = "0x183BDD7B0")]
			internal string FDFOGDJEMJP(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class NNFMIAMDHFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public LPIICIKAJGN<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public NNFMIAMDHFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x3BDD7B0", Offset = "0x3BDBFB0", VA = "0x183BDD7B0")]
			internal int OEOLNADFEHJ(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly NCCHMLPEKJC FBEABGOJOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private readonly Type FIOEDCJMOEC;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x375D3D0", Offset = "0x375BBD0", VA = "0x18375D3D0")]
		internal EJPNEGHJPPH(NCCHMLPEKJC FBEABGOJOMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x375D100", Offset = "0x375B900", VA = "0x18375D100", Slot = "4")]
		public void EHMHJMFJDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x375CFE0", Offset = "0x375B7E0", VA = "0x18375CFE0", Slot = "5")]
		public BOKINDNHMGP<T> BPCLAPBOKHL(string COBPFHINIBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x375D2B0", Offset = "0x375BAB0", VA = "0x18375D2B0", Slot = "6")]
		public BOKINDNHMGP<T> LAFLLBKGGAC(EOFFIDPFLDL<T> BDADPLLPCBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x375D270", Offset = "0x375BA70", VA = "0x18375D270", Slot = "7")]
		public BOKINDNHMGP<T> GFNBIFMFCBM(int FOBCBIEDHCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x375D130", Offset = "0x375B930", VA = "0x18375D130", Slot = "8")]
		public BOKINDNHMGP<T> FPGCGPAGIDO(int FOBCBIEDHCL, LPIICIKAJGN<T> GPODFJMMBEM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class OBOBALHIJJA<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private bool MDFEIGLDMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly List<Type> HJONHKMHNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private readonly Dictionary<Type, TVal> EKEENHKGNHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private readonly Dictionary<Type, int> JBCJMEBPCOF;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public IReadOnlyList<Type> GJCEJAHECKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x453FB20", Offset = "0x453E320", VA = "0x18453FB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x453FDC0", Offset = "0x453E5C0", VA = "0x18453FDC0")]
		public OBOBALHIJJA(Dictionary<Type, int> JBCJMEBPCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x453F800", Offset = "0x453E000", VA = "0x18453F800")]
		public void CNLMKNIMMKA(Type JOEHGGMHBAA, TVal FCGMGAOCKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x453F7A0", Offset = "0x453DFA0", VA = "0x18453F7A0")]
		public bool BGNHGOCCCLI(Type FIOEDCJMOEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x453FAC0", Offset = "0x453E2C0", VA = "0x18453FAC0")]
		public bool KHKEGLAOLPO(TVal IPHHABIKCHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2AC0", Offset = "0x3AF12C0", VA = "0x183AF2AC0")]
		public TVal NBGKOOJKKKA(Type HKAKMPIMEOA)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x453F980", Offset = "0x453E180", VA = "0x18453F980")]
		[CompilerGenerated]
		private int GGLBKLPGBFN(Type ABAADANNPIF, Type NGMFGCCINOJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class IDJEOGFBOHI : IEnumerable<HKPKAELHFCG>, IEnumerable, IEnumerator<HKPKAELHFCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private HKPKAELHFCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public NCCHMLPEKJC <>4__this;

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
		private IEnumerator<HKPKAELHFCG> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		private HKPKAELHFCG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x37D01B0", Offset = "0x37CE9B0", VA = "0x1837D01B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HKPKAELHFCG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x6EF5DF0", Offset = "0x6EF45F0", VA = "0x186EF5DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x898540", Offset = "0x896D40", VA = "0x180898540")]
		[DebuggerHidden]
		public IDJEOGFBOHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5E40", Offset = "0x6EF4640", VA = "0x186EF5E40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF57F0", Offset = "0x6EF3FF0", VA = "0x186EF57F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5C90", Offset = "0x6EF4490", VA = "0x186EF5C90")]
		private void OLLLOCKLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF57A0", Offset = "0x6EF3FA0", VA = "0x186EF57A0")]
		private void LBICBBCOFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5DA0", Offset = "0x6EF45A0", VA = "0x186EF5DA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5CE0", Offset = "0x6EF44E0", VA = "0x186EF5CE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HKPKAELHFCG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5CE0", Offset = "0x6EF44E0", VA = "0x186EF5CE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private static readonly HKPKAELHFCG KANHFHEMPDC;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private static readonly Dictionary<Type, int> LPNBIIECOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly HashSet<Type> HKNPDHAJKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly OBOBALHIJJA<int> GHDIKCKMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly OBOBALHIJJA<LLPDGLHICMH> MNAAACBKHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private readonly OBOBALHIJJA<LEDFFPJBHKG> LAHNOKLMPAN;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB550", Offset = "0x6EF9D50", VA = "0x186EFB550")]
	[ANLGLDAOJJE(ELBANFBEGNE.GameOnly)]
	private static void DCCJADFNLLG(AANDDJDEEFL JBFKAEMANEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC560", Offset = "0x6EFAD60", VA = "0x186EFC560")]
	[RecRoom.NoEngine.Common.Preserve]
	public NCCHMLPEKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x28A7A00", Offset = "0x28A6200", VA = "0x1828A7A00", Slot = "4")]
	public BOKINDNHMGP<T> KIGCCLDCCHN<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC410", Offset = "0x6EFAC10", VA = "0x186EFC410", Slot = "5")]
	public MKFDMGLAODJ PBIDNLEGDNG(Exception BCGGAGLBPHE)
	{
		return default(MKFDMGLAODJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB5C0", Offset = "0x6EF9DC0", VA = "0x186EFB5C0", Slot = "6")]
	public HKPKAELHFCG DFJHHKAJLII(Exception? BCGGAGLBPHE)
	{
		return default(HKPKAELHFCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB8A0", Offset = "0x6EFA0A0", VA = "0x186EFB8A0", Slot = "7")]
	[IteratorStateMachine(typeof(IDJEOGFBOHI))]
	public IEnumerable<HKPKAELHFCG> GNKLODBFHEM(Exception BCGGAGLBPHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC2C0", Offset = "0x6EFAAC0", VA = "0x186EFC2C0", Slot = "8")]
	public string MLFPHKIGEHK(Exception? BCGGAGLBPHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB940", Offset = "0x6EFA140", VA = "0x186EFB940")]
	private string IBEIOFFNKJC(AggregateException EPBMPDMEGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBF10", Offset = "0x6EFA710", VA = "0x186EFBF10")]
	private void LKFAHEJAMNG(Type FIOEDCJMOEC, int FOBCBIEDHCL, LLPDGLHICMH? BGLAIEENNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB180", Offset = "0x6EF9980", VA = "0x186EFB180")]
	private void AGMIONCBIHC(Type FIOEDCJMOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBC40", Offset = "0x6EFA440", VA = "0x186EFBC40")]
	private void KOIJBHKIIMG(Type FIOEDCJMOEC, LEDFFPJBHKG IEPIEIFHHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB3D0", Offset = "0x6EF9BD0", VA = "0x186EFB3D0")]
	private static int BIDJGAOOADA(Type FIOEDCJMOEC, Dictionary<Type, int> JBCJMEBPCOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2BD51F0", Offset = "0x2BD39F0", VA = "0x182BD51F0")]
	private static bool HAEODMCBGHF<TVal>(OBOBALHIJJA<TVal> AHHBLMGMEGC, Type FIOEDCJMOEC, [Out] TVal IPHHABIKCHD) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB7C0", Offset = "0x6EF9FC0", VA = "0x186EFB7C0")]
	[CompilerGenerated]
	internal static int GBIGKCGJLPD(Type FELCMMJMFIE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct MKFDMGLAODJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public readonly HKPKAELHFCG JBDCGEMOCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public readonly string KPFPIPJHMBF;

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6EFAD30", Offset = "0x6EF9530", VA = "0x186EFAD30")]
	public MKFDMGLAODJ(string DHCDMHNHDPJ, HKPKAELHFCG FOBCBIEDHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x6EFAC90", Offset = "0x6EF9490", VA = "0x186EFAC90")]
	public string KFGABHCEAED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class FFFKLPHHKKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private readonly BACPELMAHOD CFDKBNGFBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private string OPKPLJKKPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? EMFAFLIFPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private long? NFAGDFFMAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private long? EEKJKDNMGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private string PKBIMBKGJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private DHPOOOBGFKB MBPOFCBNGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private long? PKOAPKDOHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private bool HJFDAGLAMFL;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public string LEDDPLEEHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public long BJGGEGAICHK
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x6EEDEB0", Offset = "0x6EEC6B0", VA = "0x186EEDEB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public long HOGCJDGFMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6EED580", Offset = "0x6EEBD80", VA = "0x186EED580")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long KGOMJHPPHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x6EED430", Offset = "0x6EEBC30", VA = "0x186EED430")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string DOEDGCMOJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6EED5E0", Offset = "0x6EEBDE0", VA = "0x186EED5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public DHPOOOBGFKB APJOCNDGDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xEC5E40", Offset = "0xEC4640", VA = "0x180EC5E40")]
		get
		{
			return default(DHPOOOBGFKB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x6EED490", Offset = "0x6EEBC90", VA = "0x186EED490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public long PADGJBFFDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x6EED3D0", Offset = "0x6EEBBD0", VA = "0x186EED3D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE200", Offset = "0x6EECA00", VA = "0x186EEE200")]
	[UnityEngine.Scripting.Preserve]
	public FFFKLPHHKKG([GNKLNMHODGG(null)] BACPELMAHOD CFDKBNGFBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x6EEDFB0", Offset = "0x6EEC7B0", VA = "0x186EEDFB0")]
	private void OICEKLELIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6EED6A0", Offset = "0x6EEBEA0", VA = "0x186EED6A0")]
	public void GHMCKGCJDFJ(long LNOJCNCBDMF, long PMNPMGPNLGO, [Optional] long? EGBMFKCBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6EEDF10", Offset = "0x6EEC710", VA = "0x186EEDF10")]
	public void NBMPAJMKJID(long EGBMFKCBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6EED620", Offset = "0x6EEBE20", VA = "0x186EED620")]
	public void GGJOKCCLBAK(string EDOCIOODCNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6EEDB30", Offset = "0x6EEC330", VA = "0x186EEDB30")]
	public void JKOEMEFJIKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class FGOFJPDDCML : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct DGCOAFLAEHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public AsyncTaskMethodBuilder<EMALNGGNKEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public EMALNGGNKEF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public FGOFJPDDCML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private TaskAwaiter<OFJKNPELLGL.AICDFICGJJM<EMALNGGNKEF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x6EEAAB0", Offset = "0x6EE92B0", VA = "0x186EEAAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6EEAFE0", Offset = "0x6EE97E0", VA = "0x186EEAFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct OOCIFKNFOGF<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class PAIFHMNOBEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public EMALNGGNKEF roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public PAIFHMNOBEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF8A0", Offset = "0x6EFE0A0", VA = "0x186EFF8A0")]
		internal EMALNGGNKEF CJIOOKPCIIF(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct JJJBEGMBHFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public AsyncTaskMethodBuilder<OFJKNPELLGL.AICDFICGJJM<EMALNGGNKEF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public EMALNGGNKEF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public FGOFJPDDCML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private LDOJPCGBHFK <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private TaskAwaiter<OFJKNPELLGL.AICDFICGJJM<EMALNGGNKEF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8D70", Offset = "0x6EF7570", VA = "0x186EF8D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9380", Offset = "0x6EF7B80", VA = "0x186EF9380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct LEGODKPBNOE<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public FGOFJPDDCML <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x4144120", Offset = "0x4142920", VA = "0x184144120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x34AE390", Offset = "0x34ACB90", VA = "0x1834AE390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct NLNOPPGCNGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public FGOFJPDDCML <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x6EFE140", Offset = "0x6EFC940", VA = "0x186EFE140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x6EFE300", Offset = "0x6EFCB00", VA = "0x186EFE300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class IEKPAHHNJPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public IEKPAHHNJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5F90", Offset = "0x6EF4790", VA = "0x186EF5F90")]
		internal object HKACJNCGLEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5FF0", Offset = "0x6EF47F0", VA = "0x186EF5FF0")]
		internal bool NGBGCFNHJOE(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class HCIEKJGFFAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HCIEKJGFFAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4550", Offset = "0x6EF2D50", VA = "0x186EF4550")]
		internal object CJKEDNHBMAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class HDAHDAANPNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HDAHDAANPNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x6EF45B0", Offset = "0x6EF2DB0", VA = "0x186EF45B0")]
		internal object LHEFDAPLHNG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class FGAFFIAHPCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public FGAFFIAHPCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF690", Offset = "0x6EEDE90", VA = "0x186EEF690")]
		internal object JIFOBIIOIHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class MDOBDKDHAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public FGOFJPDDCML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public MDOBDKDHAOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAA40", Offset = "0x6EF9240", VA = "0x186EFAA40")]
		internal object PHKNELHKJCL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Guid OJPKGNGOOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public readonly CIDAEBAGAJA EPAPOAIHPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly OFJKNPELLGL OHODCGFKFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly ACPOBDOBPIG NEMGCIKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly NCONDMFDFCF ENFOAFMNDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private bool FKEJPLHAPPB;

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6EF07B0", Offset = "0x6EEEFB0", VA = "0x186EF07B0")]
	public FGOFJPDDCML(CIDAEBAGAJA HPMMBJCHINM, OFJKNPELLGL OHODCGFKFOO, ACPOBDOBPIG NEMGCIKNBKO, NCONDMFDFCF ENFOAFMNDBO, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFAE0", Offset = "0x6EEE2E0", VA = "0x186EEFAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFAE0", Offset = "0x6EEE2E0", VA = "0x186EEFAE0")]
	public void FNIKOBHHFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFE40", Offset = "0x6EEE640", VA = "0x186EEFE40")]
	public void FMCPGECKLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFF00", Offset = "0x6EEE700", VA = "0x186EEFF00")]
	public void GPIJEIKANIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF05F0", Offset = "0x6EEEDF0", VA = "0x186EF05F0")]
	[AsyncStateMachine(typeof(DGCOAFLAEHN))]
	internal Task<EMALNGGNKEF> NONABHHFHPK(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, EMALNGGNKEF MIKKGLIBJID, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F190", Offset = "0x2A6D990", VA = "0x182A6F190")]
	private static byte[] HPDOIHIBENL<T>(T CLBGCJICGJG) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EF50", Offset = "0x2A6D750", VA = "0x182A6EF50")]
	private static T GKPKPEOBEPC<T>(MessageParser<T> NHEIDGJDKBG, byte[] CLBGCJICGJG, T DKMMFHMIHHK) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0040", Offset = "0x6EEE840", VA = "0x186EF0040")]
	[AsyncStateMachine(typeof(JJJBEGMBHFG))]
	private Task<OFJKNPELLGL.AICDFICGJJM<EMALNGGNKEF>> HKFPHKGDGDI(EMALNGGNKEF MIKKGLIBJID, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2A6ECB0", Offset = "0x2A6D4B0", VA = "0x182A6ECB0")]
	[AsyncStateMachine(typeof(LEGODKPBNOE<>))]
	internal Task<T> ECOOGLOABBG<T>(CancellationToken OKNLKNIHJFM, Func<CancellationToken, Task<T>> GNAFJALNEGO, int DEOPBJLAJEN = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFC00", Offset = "0x6EEE400", VA = "0x186EEFC00")]
	[AsyncStateMachine(typeof(NLNOPPGCNGK))]
	internal Task ECOOGLOABBG(CancellationToken OKNLKNIHJFM, Func<CancellationToken, Task> GNAFJALNEGO, int DEOPBJLAJEN = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFFC0", Offset = "0x6EEE7C0", VA = "0x186EEFFC0")]
	public KPHOLKKPDOD HFEDILAFGLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0180", Offset = "0x6EEE980", VA = "0x186EF0180")]
	public HAFJJPCHFDN KOHMOBINKJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF700", Offset = "0x6EEDF00", VA = "0x186EEF700")]
	public MBIGIDGHAFP ALEEIFACJNA([Optional] MMJHHDEPGMK? LPJFGGMIIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0380", Offset = "0x6EEEB80", VA = "0x186EF0380")]
	public void LNEHDDBKEFH(Func<Guid, bool> GMNPBPOHLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6EF04E0", Offset = "0x6EEECE0", VA = "0x186EF04E0")]
	public void NBBKCAFIAEC(Func<Guid, bool> GPKILEOFHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0200", Offset = "0x6EEEA00", VA = "0x186EF0200")]
	public Guid LLEKGJADOPF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFD30", Offset = "0x6EEE530", VA = "0x186EEFD30")]
	public void EJEOELBBMGK(Guid IFLMFLNHOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF850", Offset = "0x6EEE050", VA = "0x186EEF850")]
	public void BOOGLELEPNI(EMALNGGNKEF BOLHIDAOEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF9D0", Offset = "0x6EEE1D0", VA = "0x186EEF9D0")]
	public void CPICANFMBIK(string PPNCNKPKPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F0A0", Offset = "0x2A6D8A0", VA = "0x182A6F0A0")]
	private T HKICGNLPLJM<T>(T IPHHABIKCHD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF980", Offset = "0x6EEE180", VA = "0x186EEF980")]
	public void CJMAMCJALIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EA10", Offset = "0x2A6D210", VA = "0x182A6EA10")]
	[CompilerGenerated]
	internal static string AODGEJJIBHO<T>(byte[] GHFEJDPMJDG, int JBKJHFHKKLA, OOCIFKNFOGF<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal sealed class NDLHLMIPLFP : CIDAEBAGAJA
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class OLIJINFHFBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OLIJINFHFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x6F17750", Offset = "0x6F15F50", VA = "0x186F17750")]
		internal object GNBKHIKCGNL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct BNKIBHHBIKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public NDLHLMIPLFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public FGOFJPDDCML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private CBGJLBKPGCG <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private HAFJJPCHFDN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6F06900", Offset = "0x6F05100", VA = "0x186F06900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x6F071D0", Offset = "0x6F059D0", VA = "0x186F071D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct DNBLJNCICMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public NDLHLMIPLFP <>4__this;

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
		private TaskAwaiter<APGABJIFLDK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x6F09A90", Offset = "0x6F08290", VA = "0x186F09A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A240", Offset = "0x6F08A40", VA = "0x186F0A240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct DPELGGLLJIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public NDLHLMIPLFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter<KEKIJLKKLCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A3C0", Offset = "0x6F08BC0", VA = "0x186F0A3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A6E0", Offset = "0x6F08EE0", VA = "0x186F0A6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class KENDNEEHFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public CBGJLBKPGCG presence;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KENDNEEHFJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x6F13480", Offset = "0x6F11C80", VA = "0x186F13480")]
		internal object KBOEHKNKFEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly MMJHHDEPGMK PJNAJEEBPNK;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly MMJHHDEPGMK IIOMHJJIPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly JKENAGDJKCF OEIPBLFDOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly PCHMOHFEPBH KKHOAEMONDK;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6F15580", Offset = "0x6F13D80", VA = "0x186F15580")]
	public NDLHLMIPLFP(JKENAGDJKCF OEIPBLFDOGM, PCHMOHFEPBH KKHOAEMONDK, Guid KPJLKKPOEPH, KBOGPEMMJMI JFHCNNPIMGD, HPGKKJFFMPO KCAKIGCLHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6F14F80", Offset = "0x6F13780", VA = "0x186F14F80", Slot = "7")]
	[AsyncStateMachine(typeof(BNKIBHHBIKK))]
	protected override Task CMDJHEKOEGK(FGOFJPDDCML DHPNIFDOAJO, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6F153B0", Offset = "0x6F13BB0", VA = "0x186F153B0")]
	[AsyncStateMachine(typeof(DNBLJNCICMC))]
	private Task MHEAMNMGABH(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6F152A0", Offset = "0x6F13AA0", VA = "0x186F152A0")]
	[AsyncStateMachine(typeof(DPELGGLLJIA))]
	private Task<byte> KCLOIHEKDMA(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6F150C0", Offset = "0x6F138C0", VA = "0x186F150C0")]
	private CBGJLBKPGCG HDMGDHPMBNL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class LGFBEDKDLGK : CIDAEBAGAJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct BLINGMMKFHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public LGFBEDKDLGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public FGOFJPDDCML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private TaskAwaiter<OKHBKNIGNEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6F05F30", Offset = "0x6F04730", VA = "0x186F05F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x6F068A0", Offset = "0x6F050A0", VA = "0x186F068A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private readonly int PPNLAHKHBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private readonly GJKNKHPAHGK JIBBHHKPIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public readonly long IJAAFLOGCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public readonly long BJPODLOFHDM;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public OKHBKNIGNEJ OIBAJIGHNJP
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8512E0", Offset = "0x84FAE0", VA = "0x1808512E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x851380", Offset = "0x84FB80", VA = "0x180851380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6F14470", Offset = "0x6F12C70", VA = "0x186F14470")]
	public LGFBEDKDLGK(Guid KPJLKKPOEPH, KBOGPEMMJMI JFHCNNPIMGD, HPGKKJFFMPO KCAKIGCLHMP, int PPNLAHKHBML, GJKNKHPAHGK JIBBHHKPIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6F14350", Offset = "0x6F12B50", VA = "0x186F14350", Slot = "7")]
	[AsyncStateMachine(typeof(BLINGMMKFHJ))]
	protected override Task CMDJHEKOEGK(FGOFJPDDCML DHPNIFDOAJO, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal abstract class ACKCEHHBBJI : CIDAEBAGAJA
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class MEEOCFNBKGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public ACKCEHHBBJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public HAOCDFMHKMB playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public MEEOCFNBKGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6F14DB0", Offset = "0x6F135B0", VA = "0x186F14DB0")]
		internal Task HHBLNCFGAJD(NLBODGALKPJ<string>.EICLBAKIMEK postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6F14DF0", Offset = "0x6F135F0", VA = "0x186F14DF0")]
		internal object NNNHAEDJCNM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct AMPLMCCJOGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public ACKCEHHBBJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public FGOFJPDDCML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private MEEOCFNBKGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6F04FB0", Offset = "0x6F037B0", VA = "0x186F04FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x6F05770", Offset = "0x6F03F70", VA = "0x186F05770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct HPEDLCCGDOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public HAOCDFMHKMB playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public ACKCEHHBBJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x6F11470", Offset = "0x6F0FC70", VA = "0x186F11470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x6F11A00", Offset = "0x6F10200", VA = "0x186F11A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6F03250", Offset = "0x6F01A50", VA = "0x186F03250")]
	public ACKCEHHBBJI(Guid KPJLKKPOEPH, KBOGPEMMJMI JFHCNNPIMGD, HPGKKJFFMPO KCAKIGCLHMP, string OIMNMJNKGEI, EIAFBOOKIAK LOFAINCFOJE, bool HHDNPABILPJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6F03110", Offset = "0x6F01910", VA = "0x186F03110", Slot = "7")]
	[AsyncStateMachine(typeof(AMPLMCCJOGL))]
	protected override Task CMDJHEKOEGK(FGOFJPDDCML DHPNIFDOAJO, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task GIGNOJLCJIG(FGOFJPDDCML DHPNIFDOAJO, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6F02FD0", Offset = "0x6F017D0", VA = "0x186F02FD0")]
	[AsyncStateMachine(typeof(HPEDLCCGDOG))]
	private Task CIKCADPKGLC(IDisposable OBPDBENOMLJ, HAOCDFMHKMB CPFDLBCNCHN, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class LDBEIBMINGM : CIDAEBAGAJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct OIFFENOPIOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public LDBEIBMINGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public FGOFJPDDCML operationContext;

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
		private TaskAwaiter<KPAJDCMJFPK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x6F16C20", Offset = "0x6F15420", VA = "0x186F16C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x6F17180", Offset = "0x6F15980", VA = "0x186F17180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private readonly JBEOMJBFOMC PFIHPPKOFGJ;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6F137C0", Offset = "0x6F11FC0", VA = "0x186F137C0")]
	public LDBEIBMINGM(Guid KPJLKKPOEPH, KBOGPEMMJMI JFHCNNPIMGD, HPGKKJFFMPO KCAKIGCLHMP, JBEOMJBFOMC PFIHPPKOFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6F136E0", Offset = "0x6F11EE0", VA = "0x186F136E0", Slot = "6")]
	protected override string NJBPFPPIPII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6F135C0", Offset = "0x6F11DC0", VA = "0x186F135C0", Slot = "7")]
	[AsyncStateMachine(typeof(OIFFENOPIOP))]
	protected override Task CMDJHEKOEGK(FGOFJPDDCML DHPNIFDOAJO, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal abstract class CIDAEBAGAJA : CJKBLONCKAL
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public delegate Task NNIJHDKKLNH(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class GMADPBJMMBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public NLBODGALKPJ<string>.EICLBAKIMEK operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public CIDAEBAGAJA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public GMADPBJMMBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F0DE30", Offset = "0x6F0C630", VA = "0x186F0DE30")]
		internal Task LNNFHBMDCIJ(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class GIAKGPLIABK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public GMADPBJMMBH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public GIAKGPLIABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C870", Offset = "0x6F0B070", VA = "0x186F0C870")]
		internal object CFBKNHELGHA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct DHHJMPGFMOC : IAsyncStateMachine
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
		public CIDAEBAGAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public Func<CIDAEBAGAJA, NLBODGALKPJ<string>.EICLBAKIMEK, FGOFJPDDCML> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private GMADPBJMMBH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private FGOFJPDDCML <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter<EMALNGGNKEF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F08930", Offset = "0x6F07130", VA = "0x186F08930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F09A30", Offset = "0x6F08230", VA = "0x186F09A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct LFOKCFEMILN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F13860", Offset = "0x6F12060", VA = "0x186F13860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F142F0", Offset = "0x6F12AF0", VA = "0x186F142F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct GCAFFLAFMDK : IAsyncStateMachine
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
		public CIDAEBAGAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BB20", Offset = "0x6F0A320", VA = "0x186F0BB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BE80", Offset = "0x6F0A680", VA = "0x186F0BE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly Guid FEJJNELNJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public readonly ByteString IFKHJBDBPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public readonly HPGKKJFFMPO MOOLHFHBHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	protected readonly string BFNMEKMHGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly bool HHDNPABILPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly Queue<NNIJHDKKLNH> HOMGCCDJLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly JJOBFPIAHKI JBLJBIBFBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly EIAFBOOKIAK LOFAINCFOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private bool LIDJBLLKBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public DHPOOOBGFKB MADCMLODCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public DHPOOOBGFKB PEFJEGPFPNN;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public KBOGPEMMJMI MDENMFBJAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x8474A0", Offset = "0x845CA0", VA = "0x1808474A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public LJKKFDADBJA BHIHJNCNCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x6F07D40", Offset = "0x6F06540", VA = "0x186F07D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public AJOGJHEJMJF CCAAHHODMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x6F07A80", Offset = "0x6F06280", VA = "0x186F07A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public HNGEIEMJFIB MJBBJFLCPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x6F07700", Offset = "0x6F05F00", VA = "0x186F07700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event EEBGOAJJAHA ECOEECLFMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6F078F0", Offset = "0x6F060F0", VA = "0x186F078F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x6F07D20", Offset = "0x6F06520", VA = "0x186F07D20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x6F08000", Offset = "0x6F06800", VA = "0x186F08000")]
	protected CIDAEBAGAJA(Guid KPJLKKPOEPH, KBOGPEMMJMI JFHCNNPIMGD, HPGKKJFFMPO KCAKIGCLHMP, string OIMNMJNKGEI, EIAFBOOKIAK LOFAINCFOJE, bool HHDNPABILPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x6F07D90", Offset = "0x6F06590", VA = "0x186F07D90", Slot = "6")]
	protected virtual string NJBPFPPIPII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x6F07F20", Offset = "0x6F06720", VA = "0x186F07F20")]
	public void PGFEFNGBKCC(NNIJHDKKLNH OMPIGNKBJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x6F075D0", Offset = "0x6F05DD0", VA = "0x186F075D0")]
	protected void CPJBOMDKBIJ(float IGEIIMLGHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6F07DD0", Offset = "0x6F065D0", VA = "0x186F07DD0")]
	[AsyncStateMachine(typeof(DHHJMPGFMOC))]
	public Task OHLHHBJPLCP(CancellationToken ODNHMAMKFFP, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, [Optional] Func<CIDAEBAGAJA, NLBODGALKPJ<string>.EICLBAKIMEK, FGOFJPDDCML> LKODOLMDBFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6F07AD0", Offset = "0x6F062D0", VA = "0x186F07AD0")]
	[AsyncStateMachine(typeof(LFOKCFEMILN))]
	private static Task LEDIAAIKABJ(Func<CancellationToken, Task> JNBKKGGKPIM, Func<CancellationToken, Task> JBHMPEPLGEE, CancellationToken OKNLKNIHJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x6F07780", Offset = "0x6F05F80", VA = "0x186F07780")]
	private void GELNHIHCMBH(bool FEJOFHOJCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6F075F0", Offset = "0x6F05DF0", VA = "0x186F075F0")]
	private void EANIPOIBAFM(FGOFJPDDCML DHPNIFDOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task CMDJHEKOEGK(FGOFJPDDCML DHPNIFDOAJO, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F07C00", Offset = "0x6F06400", VA = "0x186F07C00")]
	[AsyncStateMachine(typeof(GCAFFLAFMDK))]
	private Task LHPBNCHAJFO(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F07F80", Offset = "0x6F06780", VA = "0x186F07F80")]
	public EMALNGGNKEF PILELDCOPJD(LDOJPCGBHFK LJNBENPDFOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F07990", Offset = "0x6F06190", VA = "0x186F07990")]
	[CompilerGenerated]
	private Task KLBLCHCINBB(CancellationToken AFCJJMLHKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F07910", Offset = "0x6F06110", VA = "0x186F07910")]
	[CompilerGenerated]
	private object IEHCPBILACI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal sealed class BHOEHDMICKI : ACKCEHHBBJI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct DEMHBDDKFME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public BHOEHDMICKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public FGOFJPDDCML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private CCJHKKFLBHC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private HAFJJPCHFDN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F08160", Offset = "0x6F06960", VA = "0x186F08160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F088D0", Offset = "0x6F070D0", VA = "0x186F088D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly JKENAGDJKCF APBAMPMLGBL;

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F05E80", Offset = "0x6F04680", VA = "0x186F05E80")]
	public BHOEHDMICKI(Guid KPJLKKPOEPH, KBOGPEMMJMI JFHCNNPIMGD, JKENAGDJKCF APBAMPMLGBL, HPGKKJFFMPO KCAKIGCLHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F05D30", Offset = "0x6F04530", VA = "0x186F05D30", Slot = "8")]
	[AsyncStateMachine(typeof(DEMHBDDKFME))]
	protected override Task GIGNOJLCJIG(FGOFJPDDCML DHPNIFDOAJO, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class EPKNKBHKMHE : CIDAEBAGAJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct GDMPPPKBIDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public EPKNKBHKMHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public FGOFJPDDCML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter<KPAJDCMJFPK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BEE0", Offset = "0x6F0A6E0", VA = "0x186F0BEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C290", Offset = "0x6F0AA90", VA = "0x186F0C290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private readonly string DHBKCBMCMLF;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AD60", Offset = "0x6F09560", VA = "0x186F0AD60")]
	public EPKNKBHKMHE(Guid KPJLKKPOEPH, KBOGPEMMJMI JFHCNNPIMGD, HPGKKJFFMPO KCAKIGCLHMP, string DHBKCBMCMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AC50", Offset = "0x6F09450", VA = "0x186F0AC50", Slot = "7")]
	[AsyncStateMachine(typeof(GDMPPPKBIDK))]
	protected override Task CMDJHEKOEGK(FGOFJPDDCML DHPNIFDOAJO, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class OJIGLININPK : ACKCEHHBBJI
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class CGAOIMEKEEB
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
			public AsyncTaskMethodBuilder<EMALNGGNKEF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public CGAOIMEKEEB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private TaskAwaiter<KPAJDCMJFPK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<EMALNGGNKEF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x6F1BBA0", Offset = "0x6F1A3A0", VA = "0x186F1BBA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x6F1C060", Offset = "0x6F1A860", VA = "0x186F1C060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public OJIGLININPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public MBIGIDGHAFP serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public GIJNHOOAAEG roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public KPHOLKKPDOD uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public KDGOOCIPGIF roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public CGAOIMEKEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F07230", Offset = "0x6F05A30", VA = "0x186F07230")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<EMALNGGNKEF> EHADODMMNHD(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct AIPIAJJHGPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public OJIGLININPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public FGOFJPDDCML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private CGAOIMEKEEB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private CCJHKKFLBHC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private HAFJJPCHFDN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private EMALNGGNKEF <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter<EMALNGGNKEF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F032A0", Offset = "0x6F01AA0", VA = "0x186F032A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F04200", Offset = "0x6F02A00", VA = "0x186F04200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly MMJHHDEPGMK PJNAJEEBPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private readonly int FFJNJOPCPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	[CanBeNull]
	private readonly OJJLNGELKEB ACMFDOFDJLP;

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F176A0", Offset = "0x6F15EA0", VA = "0x186F176A0")]
	public OJIGLININPK(Guid KPJLKKPOEPH, KBOGPEMMJMI JFHCNNPIMGD, int FFJNJOPCPOE, OJJLNGELKEB ACMFDOFDJLP, HPGKKJFFMPO KCAKIGCLHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F174B0", Offset = "0x6F15CB0", VA = "0x186F174B0", Slot = "8")]
	[AsyncStateMachine(typeof(AIPIAJJHGPO))]
	protected override Task GIGNOJLCJIG(FGOFJPDDCML DHPNIFDOAJO, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F173B0", Offset = "0x6F15BB0", VA = "0x186F173B0")]
	private void FEKHLMINIPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F171E0", Offset = "0x6F159E0", VA = "0x186F171E0")]
	private void FCLNKGEPFDJ(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CCJHKKFLBHC NNKKCIJJLCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal abstract class PIDDKKGGEPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly CIDAEBAGAJA EPAPOAIHPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly FGOFJPDDCML GHAKGENNKBI;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public LJKKFDADBJA BHIHJNCNCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F195B0", Offset = "0x6F17DB0", VA = "0x186F195B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public HNGEIEMJFIB MJBBJFLCPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F19520", Offset = "0x6F17D20", VA = "0x186F19520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F19600", Offset = "0x6F17E00", VA = "0x186F19600")]
	protected PIDDKKGGEPO(FGOFJPDDCML DHPNIFDOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F19500", Offset = "0x6F17D00", VA = "0x186F19500")]
	protected void CPICANFMBIK(string PPNCNKPKPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct FNJJFFBPOLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public Dictionary<Guid, List<CKLAGLLBGKB>> BPPICIFBGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public Dictionary<Guid, List<CKLAGLLBGKB>> GBDEMOFLNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public Dictionary<Guid, List<CKLAGLLBGKB>> IAINIGPKNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public List<Guid> LFLHNHPBGLM;

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B3E0", Offset = "0x6F09BE0", VA = "0x186F0B3E0")]
	public static FNJJFFBPOLN NBGKOOJKKKA(LJKKFDADBJA NALLEMLECHL, DHPOOOBGFKB AEDKDLJAHGC, KHFFEHOCMIP IJHAEGPEDEL)
	{
		return default(FNJJFFBPOLN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct DHNIEIMGHNM
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320")]
	public static DHNIEIMGHNM DLNFHNOLCMJ()
	{
		return default(DHNIEIMGHNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct EDPAAJONCKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly APGABJIFLDK BOEODKCGNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly FCAFGPLEBDB GFOLFKMNFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly string DPABDEMPNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly KGMNHEONACL KIPPBODDGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public readonly KGMNHEONACL GPKEPHGOFMK;

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F0ABD0", Offset = "0x6F093D0", VA = "0x186F0ABD0")]
	public EDPAAJONCKG(APGABJIFLDK BOEODKCGNCM, FCAFGPLEBDB GFOLFKMNFKH, string DPABDEMPNNE, KGMNHEONACL KIPPBODDGFF, KGMNHEONACL GPKEPHGOFMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct AMJDKHBIKKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly FGOFJPDDCML DHPNIFDOAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly Guid IFLMFLNHOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private bool FEJOFHOJCCF;

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F04F00", Offset = "0x6F03700", VA = "0x186F04F00")]
	public static AMJDKHBIKKD LLEKGJADOPF(FGOFJPDDCML DHPNIFDOAJO)
	{
		return default(AMJDKHBIKKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x9361E0", Offset = "0x9349E0", VA = "0x1809361E0")]
	public void ACPGJFOLENC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F04E00", Offset = "0x6F03600", VA = "0x186F04E00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F04F60", Offset = "0x6F03760", VA = "0x186F04F60")]
	private AMJDKHBIKKD(FGOFJPDDCML DHPNIFDOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F04E00", Offset = "0x6F03600", VA = "0x186F04E00")]
	private void EJEOELBBMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F04E60", Offset = "0x6F03660", VA = "0x186F04E60")]
	private Func<Guid, bool> JFMOPCDDCHG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class HAFJJPCHFDN : PIDDKKGGEPO, CJKBLONCKAL
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public delegate Task<DHPOOOBGFKB> NDGMNGFJPIJ(KHFFEHOCMIP MLKNGAFFKGE, ODGPPJGPEEC JPEDBOBCEDH, JJOBFPIAHKI LCBDCPCAIOJ, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct HBAFGGIOKDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public JKENAGDJKCF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private AMJDKHBIKKD <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private TaskAwaiter<EMALNGGNKEF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FD20", Offset = "0x6F0E520", VA = "0x186F0FD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F10490", Offset = "0x6F0EC90", VA = "0x186F10490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct ECIDGPIHDAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public AsyncTaskMethodBuilder<EMALNGGNKEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public JKENAGDJKCF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<EMALNGGNKEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A750", Offset = "0x6F08F50", VA = "0x186F0A750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F0AB60", Offset = "0x6F09360", VA = "0x186F0AB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct FLOHCNOACPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public JKENAGDJKCF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F0AEF0", Offset = "0x6F096F0", VA = "0x186F0AEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B380", Offset = "0x6F09B80", VA = "0x186F0B380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class BAJLJMJAEAC
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
			public AsyncTaskMethodBuilder<EDPAAJONCKG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public BAJLJMJAEAC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			private EDPAAJONCKG <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			private TaskAwaiter<DHPOOOBGFKB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			private TaskAwaiter<EDPAAJONCKG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0x6F1A660", Offset = "0x6F18E60", VA = "0x186F1A660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0x6F1ADF0", Offset = "0x6F195F0", VA = "0x186F1ADF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<KHFFEHOCMIP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public BAJLJMJAEAC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			private KHFFEHOCMIP <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			private TaskAwaiter<DHPOOOBGFKB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<KHFFEHOCMIP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0x6F1AE60", Offset = "0x6F19660", VA = "0x186F1AE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x6F1B4B0", Offset = "0x6F19CB0", VA = "0x186F1B4B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public JKENAGDJKCF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public JJOBFPIAHKI preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public JJOBFPIAHKI downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public EDPAAJONCKG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public JJOBFPIAHKI postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public KHFFEHOCMIP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public OHLOCNHPDAG.EPOGBEKBEGL <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public BAJLJMJAEAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x6F05930", Offset = "0x6F04130", VA = "0x186F05930")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<EDPAAJONCKG> NNBABGJJGHF(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x6F05C10", Offset = "0x6F04410", VA = "0x186F05C10")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<KHFFEHOCMIP> OIMLNJDPDOO(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6F05A70", Offset = "0x6F04270", VA = "0x186F05A70")]
		internal void NNINBNNNNHF(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6F057D0", Offset = "0x6F03FD0", VA = "0x186F057D0")]
		internal Task ANJILCODGAB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x6F05AB0", Offset = "0x6F042B0", VA = "0x186F05AB0")]
		internal Task NPIECIANGDB(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct OACGKDOCPBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public JKENAGDJKCF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private BAJLJMJAEAC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private TaskAwaiter<EDPAAJONCKG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private TaskAwaiter<KHFFEHOCMIP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6F15EA0", Offset = "0x6F146A0", VA = "0x186F15EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6F16BC0", Offset = "0x6F153C0", VA = "0x186F16BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct GLJDHPBOFIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public KHFFEHOCMIP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public JJOBFPIAHKI postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter<DHPOOOBGFKB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private ODGPPJGPEEC <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x6F0CEB0", Offset = "0x6F0B6B0", VA = "0x186F0CEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x6F0DDD0", Offset = "0x6F0C5D0", VA = "0x186F0DDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct PCPEJLJEMCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x6F177C0", Offset = "0x6F15FC0", VA = "0x186F177C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6F18070", Offset = "0x6F16870", VA = "0x186F18070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct JHPBIECCAHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public JJOBFPIAHKI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private TaskAwaiter<DHPOOOBGFKB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x6F11A60", Offset = "0x6F10260", VA = "0x186F11A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x6F123E0", Offset = "0x6F10BE0", VA = "0x186F123E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct JOAFPAEBBPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public AsyncTaskMethodBuilder<DHPOOOBGFKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public JJOBFPIAHKI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter<DHPOOOBGFKB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6F12440", Offset = "0x6F10C40", VA = "0x186F12440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6F13410", Offset = "0x6F11C10", VA = "0x186F13410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct PDMEGMEBLHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AsyncTaskMethodBuilder<DHPOOOBGFKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public JJOBFPIAHKI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public ODGPPJGPEEC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private TaskAwaiter<DHPOOOBGFKB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x6F180D0", Offset = "0x6F168D0", VA = "0x186F180D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6F19490", Offset = "0x6F17C90", VA = "0x186F19490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct NEKBNMDKMIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder<DHPOOOBGFKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public DHPOOOBGFKB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public JJOBFPIAHKI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public KHFFEHOCMIP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private TaskAwaiter<DHPOOOBGFKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6F15710", Offset = "0x6F13F10", VA = "0x186F15710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x6F159A0", Offset = "0x6F141A0", VA = "0x186F159A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class DOGPOAPBGFN
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
			public AsyncTaskMethodBuilder<DHPOOOBGFKB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			public DOGPOAPBGFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			private OHNDHAGHNHL <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private TaskAwaiter<DHPOOOBGFKB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x6F1B520", Offset = "0x6F19D20", VA = "0x186F1B520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x6F1BB30", Offset = "0x6F1A330", VA = "0x186F1BB30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public JJOBFPIAHKI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public NDGMNGFJPIJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public ODGPPJGPEEC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public DHPOOOBGFKB originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DOGPOAPBGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A2A0", Offset = "0x6F08AA0", VA = "0x186F0A2A0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<DHPOOOBGFKB> DBOPLAAGHJE(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct MDEACEBADCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder<DHPOOOBGFKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public JJOBFPIAHKI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public NDGMNGFJPIJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public ODGPPJGPEEC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private TaskAwaiter<DHPOOOBGFKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x6F14840", Offset = "0x6F13040", VA = "0x186F14840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6F14D40", Offset = "0x6F13540", VA = "0x186F14D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct GLFDEMGCENN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public JJOBFPIAHKI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private DHPOOOBGFKB <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private IEnumerator<DHPOOOBGFKB> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter<DHPOOOBGFKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C930", Offset = "0x6F0B130", VA = "0x186F0C930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6F0CE50", Offset = "0x6F0B650", VA = "0x186F0CE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct CGIOPFBODEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6F07350", Offset = "0x6F05B50", VA = "0x186F07350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x6F07570", Offset = "0x6F05D70", VA = "0x186F07570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct LMONJOFGJDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6F145A0", Offset = "0x6F12DA0", VA = "0x186F145A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x6F147E0", Offset = "0x6F12FE0", VA = "0x186F147E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct HJGAIIOHEGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public KHFFEHOCMIP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public JJOBFPIAHKI postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TaskAwaiter<DHPOOOBGFKB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private ODGPPJGPEEC <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6F104F0", Offset = "0x6F0ECF0", VA = "0x186F104F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x6F11410", Offset = "0x6F0FC10", VA = "0x186F11410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct AJMFBPDBEDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public AsyncTaskMethodBuilder<DHPOOOBGFKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public HAFJJPCHFDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public JJOBFPIAHKI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private TaskAwaiter<DHPOOOBGFKB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x6F04260", Offset = "0x6F02A60", VA = "0x186F04260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x6F04D90", Offset = "0x6F03590", VA = "0x186F04D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly PHMCAOLOCAA EFMFHDFPCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly PHMCAOLOCAA FCKDAMDDOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly FFFKLPHHKKG DEHGGEGCGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly JJBFEFKAMEJ DKEHEBLHNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly OPBEAGNIBGK DPIDOADLKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly NAGOHFBEGAG DPIEJBBKFAF;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private KBOGPEMMJMI MDENMFBJAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F0DF60", Offset = "0x6F0C760", VA = "0x186F0DF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event EEBGOAJJAHA ECOEECLFMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F2E0", Offset = "0x6F0DAE0", VA = "0x186F0F2E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F850", Offset = "0x6F0E050", VA = "0x186F0F850", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FA70", Offset = "0x6F0E270", VA = "0x186F0FA70")]
	public HAFJJPCHFDN(FGOFJPDDCML DHPNIFDOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E230", Offset = "0x6F0CA30", VA = "0x186F0E230")]
	[AsyncStateMachine(typeof(HBAFGGIOKDF))]
	public Task ANGNEAJMGFL(JKENAGDJKCF LOGLBHMJLPF, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E3B0", Offset = "0x6F0CBB0", VA = "0x186F0E3B0")]
	[AsyncStateMachine(typeof(ECIDGPIHDAC))]
	private Task<EMALNGGNKEF> BMLCKJLMKGG(JKENAGDJKCF LOGLBHMJLPF, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DF90", Offset = "0x6F0C790", VA = "0x186F0DF90")]
	[AsyncStateMachine(typeof(FLOHCNOACPA))]
	private Task AKKBHCLEIGF(JKENAGDJKCF LOGLBHMJLPF, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E9A0", Offset = "0x6F0D1A0", VA = "0x186F0E9A0")]
	[AsyncStateMachine(typeof(OACGKDOCPBA))]
	private Task EOLNPOLCAJE(JKENAGDJKCF LOGLBHMJLPF, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken NFNOBFFPEMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F700", Offset = "0x6F0DF00", VA = "0x186F0F700")]
	[AsyncStateMachine(typeof(GLJDHPBOFIK))]
	private Task LGOPHACAJCA(KHFFEHOCMIP GGKPHJCFKNG, JJOBFPIAHKI PAGICHACFBD, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken LHOGPKADIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F460", Offset = "0x6F0DC60", VA = "0x186F0F460")]
	[AsyncStateMachine(typeof(PCPEJLJEMCE))]
	private Task HOIBMNKLHJO(NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F570", Offset = "0x6F0DD70", VA = "0x186F0F570")]
	[AsyncStateMachine(typeof(JHPBIECCAHA))]
	private Task IEPGLLCLKNC(KHFFEHOCMIP MLKNGAFFKGE, JJOBFPIAHKI LCBDCPCAIOJ, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F300", Offset = "0x6F0DB00", VA = "0x186F0F300")]
	[AsyncStateMachine(typeof(JOAFPAEBBPB))]
	private Task<DHPOOOBGFKB> HOAFNGLBPBK(KHFFEHOCMIP MLKNGAFFKGE, ODGPPJGPEEC EEGKDDIENDG, JJOBFPIAHKI LCBDCPCAIOJ, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EDA0", Offset = "0x6F0D5A0", VA = "0x186F0EDA0")]
	[AsyncStateMachine(typeof(PDMEGMEBLHG))]
	private Task<DHPOOOBGFKB> GDABKMIHODN(KHFFEHOCMIP MLKNGAFFKGE, ODGPPJGPEEC EEGKDDIENDG, JJOBFPIAHKI LCBDCPCAIOJ, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EF20", Offset = "0x6F0D720", VA = "0x186F0EF20")]
	[AsyncStateMachine(typeof(NEKBNMDKMIA))]
	private Task<DHPOOOBGFKB> GDGFPHANJIB(DHPOOOBGFKB AEDKDLJAHGC, KHFFEHOCMIP IJHAEGPEDEL, JJOBFPIAHKI LCBDCPCAIOJ, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP, bool HAKHDHKNAEN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F0A0", Offset = "0x6F0D8A0", VA = "0x186F0F0A0")]
	private bool GILIJHFMNFB(KHFFEHOCMIP GGKPHJCFKNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E510", Offset = "0x6F0CD10", VA = "0x186F0E510")]
	[AsyncStateMachine(typeof(MDEACEBADCM))]
	protected Task<DHPOOOBGFKB> BNOGLBEOKPM(KHFFEHOCMIP MLKNGAFFKGE, ODGPPJGPEEC EEGKDDIENDG, JJOBFPIAHKI LCBDCPCAIOJ, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP, NDGMNGFJPIJ OIFBAODNJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EC30", Offset = "0x6F0D430", VA = "0x186F0EC30")]
	[AsyncStateMachine(typeof(GLFDEMGCENN))]
	private Task FPMELKMNPJO(KHFFEHOCMIP MLKNGAFFKGE, JJOBFPIAHKI LCBDCPCAIOJ, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E930", Offset = "0x6F0D130", VA = "0x186F0E930")]
	private void DPDKCPLAFIC(DHPOOOBGFKB FOMNEEODGEH, JJOBFPIAHKI LCBDCPCAIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F870", Offset = "0x6F0E070", VA = "0x186F0F870")]
	private void NHPJOCMOBLF(DHPOOOBGFKB IIIHFMLMDFE, [Out] DHPOOOBGFKB LKBFCDGOOFH, [Out] DHPOOOBGFKB MCJGPKANELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E790", Offset = "0x6F0CF90", VA = "0x186F0E790")]
	private Task<EDPAAJONCKG> COJEFHOKJEK(JKENAGDJKCF LOGLBHMJLPF, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F6C0", Offset = "0x6F0DEC0", VA = "0x186F0F6C0")]
	private Task<KHFFEHOCMIP> JOKPJIAOEIA(EDPAAJONCKG MLKNGAFFKGE, OHLOCNHPDAG.EPOGBEKBEGL PMDPFHIEGFC, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F190", Offset = "0x6F0D990", VA = "0x186F0F190")]
	[AsyncStateMachine(typeof(CGIOPFBODEL))]
	private Task GMKJPPPJNOK(KHFFEHOCMIP MLKNGAFFKGE, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP, bool DHJPEEIJLBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E6A0", Offset = "0x6F0CEA0", VA = "0x186F0E6A0")]
	[AsyncStateMachine(typeof(LMONJOFGJDJ))]
	private Task CGHJNHDOKOH(KHFFEHOCMIP MLKNGAFFKGE, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E380", Offset = "0x6F0CB80", VA = "0x186F0E380")]
	private Task BMDONKONHDL(KHFFEHOCMIP MLKNGAFFKGE, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E910", Offset = "0x6F0D110", VA = "0x186F0E910")]
	private Task DHGDLPIHHFI(KHFFEHOCMIP MLKNGAFFKGE, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F8B0", Offset = "0x6F0E0B0", VA = "0x186F0F8B0")]
	private Task NPKGAMOHOBH(KHFFEHOCMIP MLKNGAFFKGE, ODGPPJGPEEC EEGKDDIENDG, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EAE0", Offset = "0x6F0D2E0", VA = "0x186F0EAE0")]
	private Task FMBELHOJAAB(KHFFEHOCMIP MLKNGAFFKGE, ODGPPJGPEEC EEGKDDIENDG, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AE10", Offset = "0x6F09610", VA = "0x186F0AE10")]
	private static Task DHLGJGDBNDN(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E980", Offset = "0x6F0D180", VA = "0x186F0E980")]
	private Task EGDFKOJMOBB(KHFFEHOCMIP MLKNGAFFKGE, ODGPPJGPEEC EEGKDDIENDG, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E7D0", Offset = "0x6F0CFD0", VA = "0x186F0E7D0")]
	private Task DFHENNGBBDD(KHFFEHOCMIP MLKNGAFFKGE, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F8D0", Offset = "0x6F0E0D0", VA = "0x186F0F8D0")]
	private void OKONLMGKJBK(JKENAGDJKCF LOGLBHMJLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F0ED80", Offset = "0x6F0D580", VA = "0x186F0ED80")]
	public void GCFDCFAIHHJ(long EGBMFKCBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void HHGOFNKGBKJ(APGABJIFLDK BOEODKCGNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F920", Offset = "0x6F0E120", VA = "0x186F0F920")]
	[AsyncStateMachine(typeof(HJGAIIOHEGL))]
	private Task PNMGDFHOELD(KHFFEHOCMIP GGKPHJCFKNG, JJOBFPIAHKI PAGICHACFBD, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken LHOGPKADIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E0D0", Offset = "0x6F0C8D0", VA = "0x186F0E0D0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(AJMFBPDBEDP))]
	private Task<DHPOOOBGFKB> ALMOMDICKNI(KHFFEHOCMIP MLKNGAFFKGE, ODGPPJGPEEC EEGKDDIENDG, JJOBFPIAHKI LCBDCPCAIOJ, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct PKEICKMGGJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private KHFFEHOCMIP MLKNGAFFKGE;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private LJKKFDADBJA BHIHJNCNCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x6F19660", Offset = "0x6F17E60", VA = "0x186F19660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x6F198D0", Offset = "0x6F180D0", VA = "0x186F198D0")]
	public static Task OHLHHBJPLCP(KBOGPEMMJMI JFHCNNPIMGD, KHFFEHOCMIP MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6F196B0", Offset = "0x6F17EB0", VA = "0x186F196B0")]
	private void OHLHHBJPLCP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct FGFAEAPICNL
{
	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AE10", Offset = "0x6F09610", VA = "0x186F0AE10")]
	public static Task OHLHHBJPLCP(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct FNJLCBOOJKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct GELNKHIGNHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public FGOFJPDDCML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C2F0", Offset = "0x6F0AAF0", VA = "0x186F0C2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C810", Offset = "0x6F0B010", VA = "0x186F0C810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B9E0", Offset = "0x6F0A1E0", VA = "0x186F0B9E0")]
	[AsyncStateMachine(typeof(GELNKHIGNHP))]
	public static Task OHLHHBJPLCP(FGOFJPDDCML DHPNIFDOAJO, KHFFEHOCMIP MLKNGAFFKGE, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct NNHILDGLGGJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct POBBMFADOBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public FGOFJPDDCML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public ODGPPJGPEEC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private DHPOOOBGFKB <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private KBOGPEMMJMI <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private LJKKFDADBJA <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private OHNDHAGHNHL <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private List<(PersistenceView, FHCGEGKCGMN)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private FHCGEGKCGMN <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6F199B0", Offset = "0x6F181B0", VA = "0x186F199B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A600", Offset = "0x6F18E00", VA = "0x186F1A600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x6F15A10", Offset = "0x6F14210", VA = "0x186F15A10")]
	[AsyncStateMachine(typeof(POBBMFADOBE))]
	public static Task OHLHHBJPLCP(FGOFJPDDCML DHPNIFDOAJO, KHFFEHOCMIP MLKNGAFFKGE, ODGPPJGPEEC EEGKDDIENDG, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6F15B60", Offset = "0x6F14360", VA = "0x186F15B60")]
	private static void PKLDKCCBDLJ(PersistenceView HLNNELMBBHN, FHCGEGKCGMN FJLLLIBFOLI, KHFFEHOCMIP MLKNGAFFKGE, DHPOOOBGFKB AEDKDLJAHGC, bool GJBFNJCELCP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct AIFDBBJMEAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct OOPFJNGOFOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public KBOGPEMMJMI roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6F32F50", Offset = "0x6F31750", VA = "0x186F32F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x6F33380", Offset = "0x6F31B80", VA = "0x186F33380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CBE0", Offset = "0x6F1B3E0", VA = "0x186F1CBE0")]
	[AsyncStateMachine(typeof(OOPFJNGOFOA))]
	public static Task OHLHHBJPLCP(KBOGPEMMJMI JFHCNNPIMGD, KHFFEHOCMIP MLKNGAFFKGE, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct NDPJHHGDEGI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct NGDJKHOPEMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public KBOGPEMMJMI roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public FGOFJPDDCML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x6F30C20", Offset = "0x6F2F420", VA = "0x186F30C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x6F30E30", Offset = "0x6F2F630", VA = "0x186F30E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class FJOIIKJIPEA
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
			public NLBODGALKPJ<string>.EICLBAKIMEK timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public FJOIIKJIPEA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x6F35500", Offset = "0x6F33D00", VA = "0x186F35500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x6F35890", Offset = "0x6F34090", VA = "0x186F35890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public FJOIIKJIPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x6F22550", Offset = "0x6F20D50", VA = "0x186F22550")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task AKPPBJHMEMG(NLBODGALKPJ<string>.EICLBAKIMEK timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct MLINBJOFDHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public NDPJHHGDEGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private TaskAwaiter<EMALNGGNKEF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D180", Offset = "0x6F2B980", VA = "0x186F2D180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DB40", Offset = "0x6F2C340", VA = "0x186F2DB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class LGGOAFFFDKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public NLENJFNFFEI version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public LGGOAFFFDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A860", Offset = "0x6F29060", VA = "0x186F2A860")]
		internal object DDCMALPDOON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A940", Offset = "0x6F29140", VA = "0x186F2A940")]
		internal object HNBBFNJFJCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private KHFFEHOCMIP MLKNGAFFKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private FGOFJPDDCML DHPNIFDOAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private bool DHJPEEIJLBP;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private static readonly ByteString FOLFGCONFBF;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private LJKKFDADBJA BHIHJNCNCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F6E0", Offset = "0x6F2DEE0", VA = "0x186F2F6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private HNGEIEMJFIB MJBBJFLCPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F600", Offset = "0x6F2DE00", VA = "0x186F2F600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F730", Offset = "0x6F2DF30", VA = "0x186F2F730")]
	[AsyncStateMachine(typeof(NGDJKHOPEMJ))]
	public static Task OHLHHBJPLCP(KBOGPEMMJMI JFHCNNPIMGD, KHFFEHOCMIP MLKNGAFFKGE, FGOFJPDDCML DHPNIFDOAJO, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP, bool DHJPEEIJLBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F880", Offset = "0x6F2E080", VA = "0x186F2F880")]
	[AsyncStateMachine(typeof(MLINBJOFDHF))]
	private Task OHLHHBJPLCP(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F9C0", Offset = "0x6F2E1C0", VA = "0x186F2F9C0")]
	private void POJKLGPIBBM([NotNull] JGEEHKGDOJK DMPJEPMEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F6A0", Offset = "0x6F2DEA0", VA = "0x186F2F6A0")]
	private bool FLIFNGDEPDA(NLENJFNFFEI MBDJOBPGDCG, JGEEHKGDOJK DMPJEPMEMOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct IIAIIDAIKBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct KPKLMLFLLIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder<KHFFEHOCMIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public IIAIIDAIKBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public OHLOCNHPDAG.EPOGBEKBEGL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private TaskAwaiter<(MEKCEIEFNPI<EKDOJHDBDDL, PLHOCJDFICM>, MEKCEIEFNPI<FBNAOJOLFEH<JGEEHKGDOJK>, PLHOCJDFICM>, MEKCEIEFNPI<FBNAOJOLFEH<GMFGEGDFAPN>, PLHOCJDFICM>, MEKCEIEFNPI<FBNAOJOLFEH<EJNOBLPAPNM>, PLHOCJDFICM>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x6F296B0", Offset = "0x6F27EB0", VA = "0x186F296B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A160", Offset = "0x6F28960", VA = "0x186F2A160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct PCFMMOPKANC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<EKDOJHDBDDL, PLHOCJDFICM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public NLBODGALKPJ<string>.EICLBAKIMEK downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public IIAIIDAIKBK <>4__this;

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
		public OHLOCNHPDAG.EPOGBEKBEGL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter<MEKCEIEFNPI<EKDOJHDBDDL, PLHOCJDFICM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x6F339E0", Offset = "0x6F321E0", VA = "0x186F339E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x6F33FF0", Offset = "0x6F327F0", VA = "0x186F33FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private PGLFAMIAGPB<KGMNHEONACL, GMFGEGDFAPN> PJAPBDKHIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private PGLFAMIAGPB<KGMNHEONACL, JGEEHKGDOJK> JPJCFDHJBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private PGLFAMIAGPB<long, EJNOBLPAPNM> HKHPEENMJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private HBPCIOBAOHE AKINACGFGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private APGABJIFLDK BOEODKCGNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private FCAFGPLEBDB GFOLFKMNFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private string DPABDEMPNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private KGMNHEONACL KIPPBODDGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private KGMNHEONACL GPKEPHGOFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private long EGBMFKCBLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK;

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6F23FB0", Offset = "0x6F227B0", VA = "0x186F23FB0")]
	public static Task<KHFFEHOCMIP> BNIIGFDBIHO(KBOGPEMMJMI JFHCNNPIMGD, [In] EDPAAJONCKG MLKNGAFFKGE, OHLOCNHPDAG.EPOGBEKBEGL PMDPFHIEGFC, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x6F244E0", Offset = "0x6F22CE0", VA = "0x186F244E0")]
	[AsyncStateMachine(typeof(KPKLMLFLLIE))]
	private Task<KHFFEHOCMIP> OHLHHBJPLCP(OHLOCNHPDAG.EPOGBEKBEGL PMDPFHIEGFC, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6F24320", Offset = "0x6F22B20", VA = "0x186F24320")]
	[AsyncStateMachine(typeof(PCFMMOPKANC))]
	private Task<MEKCEIEFNPI<EKDOJHDBDDL, PLHOCJDFICM>> OCMMDCLCABI(string DPABDEMPNNE, long EGBMFKCBLOA, long? LNOJCNCBDMF, long? EIPINGDKEKJ, OHLOCNHPDAG.EPOGBEKBEGL PMDPFHIEGFC, NLBODGALKPJ<string>.EICLBAKIMEK JCPPGPIEMPF, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct AADKDEEHHBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct KPFKOFKOAEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public AsyncTaskMethodBuilder<EDPAAJONCKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public AADKDEEHHBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private TaskAwaiter<EDPAAJONCKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x6F28B60", Offset = "0x6F27360", VA = "0x186F28B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x6F28F60", Offset = "0x6F27760", VA = "0x186F28F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct BJICLAPLEAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public AsyncTaskMethodBuilder<EDPAAJONCKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public AADKDEEHHBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private TaskAwaiter<EDPAAJONCKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E590", Offset = "0x6F1CD90", VA = "0x186F1E590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E9C0", Offset = "0x6F1D1C0", VA = "0x186F1E9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class KCNPDBINAPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KCNPDBINAPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8ED470", Offset = "0x8EBC70", VA = "0x1808ED470")]
		internal bool GJGOBJCOEPG(FCAFGPLEBDB sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct ALKMGMGBCHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public AsyncTaskMethodBuilder<EDPAAJONCKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public KGMNHEONACL superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public LJKKFDADBJA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private KCNPDBINAPE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public NKANBBPKJBF roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private APGABJIFLDK <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private FCAFGPLEBDB <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private KGMNHEONACL <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private KGMNHEONACL <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<APGABJIFLDK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private TaskAwaiter<GEINPJEOBAO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private TaskAwaiter<KEKIJLKKLCL> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CCF0", Offset = "0x6F1B4F0", VA = "0x186F1CCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DE30", Offset = "0x6F1C630", VA = "0x186F1DE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private LJKKFDADBJA NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private FFFKLPHHKKG DEHGGEGCGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private NKANBBPKJBF MHJKEDBILCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private long LNOJCNCBDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private long PMNPMGPNLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private long DNIAFEHFFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private string BIENKHHLBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private KGMNHEONACL HNJCBKAMLMI;

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C390", Offset = "0x6F1AB90", VA = "0x186F1C390")]
	public static Task<EDPAAJONCKG> BNIIGFDBIHO(KBOGPEMMJMI JFHCNNPIMGD, JKENAGDJKCF LOGLBHMJLPF, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C940", Offset = "0x6F1B140", VA = "0x186F1C940")]
	[AsyncStateMachine(typeof(KPFKOFKOAEO))]
	private Task<EDPAAJONCKG> OHLHHBJPLCP(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C610", Offset = "0x6F1AE10", VA = "0x186F1C610")]
	[AsyncStateMachine(typeof(BJICLAPLEAK))]
	private Task<EDPAAJONCKG> COJEFHOKJEK(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C770", Offset = "0x6F1AF70", VA = "0x186F1C770")]
	[AsyncStateMachine(typeof(ALKMGMGBCHB))]
	private static Task<EDPAAJONCKG> COJEFHOKJEK(LJKKFDADBJA NALLEMLECHL, NKANBBPKJBF MHJKEDBILCJ, long LNOJCNCBDMF, long PMNPMGPNLGO, long DNIAFEHFFIM, string BIENKHHLBJK, KGMNHEONACL HNJCBKAMLMI, CancellationToken ODNHMAMKFFP, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C910", Offset = "0x6F1B110", VA = "0x186F1C910")]
	private void IFGHBAEDILL(APGABJIFLDK BOEODKCGNCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct PIJOFHBFAKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct FLCLMJIMAAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public PIJOFHBFAKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x6F22670", Offset = "0x6F20E70", VA = "0x186F22670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6F22C00", Offset = "0x6F21400", VA = "0x186F22C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private LJKKFDADBJA NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private KHFFEHOCMIP MLKNGAFFKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private float BDODNIGJKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private float JEPLDDIAHKN;

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x6F34820", Offset = "0x6F33020", VA = "0x186F34820")]
	public static Task LBNJGDFLIMJ(KBOGPEMMJMI JFHCNNPIMGD, KHFFEHOCMIP MLKNGAFFKGE, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x6F34B20", Offset = "0x6F33320", VA = "0x186F34B20")]
	[AsyncStateMachine(typeof(FLCLMJIMAAF))]
	public Task OHLHHBJPLCP(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x6F346D0", Offset = "0x6F32ED0", VA = "0x186F346D0")]
	private static void DJJJCOHJJJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6F349C0", Offset = "0x6F331C0", VA = "0x186F349C0")]
	private void NCPEMHOKMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6F34610", Offset = "0x6F32E10", VA = "0x186F34610")]
	private static float CJKOKGJIIGE(LJKKFDADBJA NALLEMLECHL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6F34800", Offset = "0x6F33000", VA = "0x186F34800")]
	private static float HICCLKADOOD()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct PCEFAMHNGLJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct IMCHKGAJAFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public FGOFJPDDCML operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private CIDAEBAGAJA <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private KBOGPEMMJMI <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private OKJOAPONINH.DECJKJLPPAB <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private TaskAwaiter<EMALNGGNKEF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x6F24D50", Offset = "0x6F23550", VA = "0x186F24D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x6F256F0", Offset = "0x6F23EF0", VA = "0x186F256F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct JPLMOBFPEON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x6F27F80", Offset = "0x6F26780", VA = "0x186F27F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x6F28270", Offset = "0x6F26A70", VA = "0x186F28270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6F338A0", Offset = "0x6F320A0", VA = "0x186F338A0")]
	[AsyncStateMachine(typeof(IMCHKGAJAFH))]
	public static Task OHLHHBJPLCP(FGOFJPDDCML DHPNIFDOAJO, KHFFEHOCMIP MLKNGAFFKGE, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6F33830", Offset = "0x6F32030", VA = "0x186F33830")]
	private static Task<EMALNGGNKEF> MLEKKCNDHKH(FGOFJPDDCML DHPNIFDOAJO, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6F33770", Offset = "0x6F31F70", VA = "0x186F33770")]
	[AsyncStateMachine(typeof(JPLMOBFPEON))]
	private static Task EJGEHJKOAEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct OAAHKNFJOHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct OBDEFIPLFFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public OAAHKNFJOHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x6F311B0", Offset = "0x6F2F9B0", VA = "0x186F311B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x6F31860", Offset = "0x6F30060", VA = "0x186F31860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class LLDJOMOMMNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public LLDJOMOMMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x6F2AB20", Offset = "0x6F29320", VA = "0x186F2AB20")]
		internal object LMAACHJMNOG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct CJNIEPBJAKK : IAsyncStateMachine
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
		public OAAHKNFJOHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private FEEJBIFCEMM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x6F204B0", Offset = "0x6F1ECB0", VA = "0x186F204B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x6F20A70", Offset = "0x6F1F270", VA = "0x186F20A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private bool BMLDBFCGLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	private CancellationToken ODNHMAMKFFP;

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x6F31050", Offset = "0x6F2F850", VA = "0x186F31050")]
	public static Task EBCNGMAJDJJ(KBOGPEMMJMI JFHCNNPIMGD, bool BMLDBFCGLOJ, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken DKMGEPECIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x6F310C0", Offset = "0x6F2F8C0", VA = "0x186F310C0")]
	[AsyncStateMachine(typeof(OBDEFIPLFFC))]
	private Task OHLHHBJPLCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x6F30F20", Offset = "0x6F2F720", VA = "0x186F30F20")]
	[AsyncStateMachine(typeof(CJNIEPBJAKK))]
	private Task CCCIIFOPADH(bool NIPFJCKOIMK, string PNDDKBGNFCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320")]
	private bool PLEFPBMPPPF(bool BMLDBFCGLOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct JEMEGHBLLEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct KAHPMLMFOFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public JEMEGHBLLEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x6F282D0", Offset = "0x6F26AD0", VA = "0x186F282D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x6F28840", Offset = "0x6F27040", VA = "0x186F28840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class POKDGMPOHEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public POKDGMPOHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x6F34C40", Offset = "0x6F33440", VA = "0x186F34C40")]
		internal object LMAACHJMNOG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct HBJBDNPOOAI : IAsyncStateMachine
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
		public JEMEGHBLLEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private FEEJBIFCEMM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x6F236A0", Offset = "0x6F21EA0", VA = "0x186F236A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x6F23C60", Offset = "0x6F22460", VA = "0x186F23C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	private PMCPOOCLOAB HFADKODCNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	private bool NMJKOCKPBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	private KHFFEHOCMIP MLKNGAFFKGE;

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x6F25E30", Offset = "0x6F24630", VA = "0x186F25E30")]
	public static Task<Scene> KIJMNECCBNM(KBOGPEMMJMI JFHCNNPIMGD, PMCPOOCLOAB MCCIKMGGKFM, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x6F25EE0", Offset = "0x6F246E0", VA = "0x186F25EE0")]
	[AsyncStateMachine(typeof(KAHPMLMFOFI))]
	private Task<Scene> OHLHHBJPLCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x6F25EB0", Offset = "0x6F246B0", VA = "0x186F25EB0")]
	private bool MGNFGBJAFFP(KHFFEHOCMIP MLKNGAFFKGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x6F25DC0", Offset = "0x6F245C0", VA = "0x186F25DC0")]
	private void IALKFBLHIAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x6F25C70", Offset = "0x6F24470", VA = "0x186F25C70")]
	[AsyncStateMachine(typeof(HBJBDNPOOAI))]
	private Task<Scene> CCCIIFOPADH(string PNDDKBGNFCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct OPBEAGNIBGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct NEEOPFONAAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public AsyncTaskMethodBuilder<DHPOOOBGFKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public OPBEAGNIBGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public DHPOOOBGFKB nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public KHFFEHOCMIP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private TaskAwaiter<DHPOOOBGFKB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6F300D0", Offset = "0x6F2E8D0", VA = "0x186F300D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x6F30BB0", Offset = "0x6F2F3B0", VA = "0x186F30BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct PPAOHHJBGCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public AsyncTaskMethodBuilder<DHPOOOBGFKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public OPBEAGNIBGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public DHPOOOBGFKB state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter<EMALNGGNKEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x6F34C90", Offset = "0x6F33490", VA = "0x186F34C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x6F34F70", Offset = "0x6F33770", VA = "0x186F34F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private readonly FGOFJPDDCML DHPNIFDOAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private readonly FFFKLPHHKKG DEHGGEGCGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	private readonly JJBFEFKAMEJ DKEHEBLHNLM;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private CIDAEBAGAJA EPAPOAIHPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x56A1E00", Offset = "0x56A0600", VA = "0x1856A1E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6F33710", Offset = "0x6F31F10", VA = "0x186F33710")]
	public OPBEAGNIBGK(FGOFJPDDCML DHPNIFDOAJO, FFFKLPHHKKG DEHGGEGCGCG, JJBFEFKAMEJ DKEHEBLHNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x6F33400", Offset = "0x6F31C00", VA = "0x186F33400")]
	[AsyncStateMachine(typeof(NEEOPFONAAL))]
	public Task<DHPOOOBGFKB> HBCNDGKNMNL(DHPOOOBGFKB IIHGAOCMDAF, KHFFEHOCMIP IJHAEGPEDEL, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP, bool HAKHDHKNAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x6F33580", Offset = "0x6F31D80", VA = "0x186F33580")]
	[AsyncStateMachine(typeof(PPAOHHJBGCC))]
	private Task<DHPOOOBGFKB> KFEBGOBEJJI(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, DHPOOOBGFKB DAGLKLOEBMA, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x6F336E0", Offset = "0x6F31EE0", VA = "0x186F336E0")]
	private bool PFNBOJFMPIH(DHPOOOBGFKB FKJEINPMMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x6F333E0", Offset = "0x6F31BE0", VA = "0x186F333E0")]
	private void CPICANFMBIK(string IOFIKOEHDBG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct ICALMONCKIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct LLEIFIELIIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public CIDAEBAGAJA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public ODGPPJGPEEC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private OHNDHAGHNHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private List<(PersistenceView, FHCGEGKCGMN)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private (PersistenceView, FHCGEGKCGMN) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x6F2ABA0", Offset = "0x6F293A0", VA = "0x186F2ABA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B1B0", Offset = "0x6F299B0", VA = "0x186F2B1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x6F23CD0", Offset = "0x6F224D0", VA = "0x186F23CD0")]
	[AsyncStateMachine(typeof(LLEIFIELIIP))]
	public static Task OHLHHBJPLCP(CIDAEBAGAJA HPMMBJCHINM, KHFFEHOCMIP MLKNGAFFKGE, ODGPPJGPEEC EEGKDDIENDG, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct MHOFEOPFMJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct BPGPLHLNEMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public CIDAEBAGAJA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public ODGPPJGPEEC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private NLENJFNFFEI <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private OHNDHAGHNHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private List<(PersistenceView, FHCGEGKCGMN)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private FHCGEGKCGMN <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F440", Offset = "0x6F1DC40", VA = "0x186F1F440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FC90", Offset = "0x6F1E490", VA = "0x186F1FC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D040", Offset = "0x6F2B840", VA = "0x186F2D040")]
	[AsyncStateMachine(typeof(BPGPLHLNEMI))]
	public static Task OHLHHBJPLCP(CIDAEBAGAJA HPMMBJCHINM, KHFFEHOCMIP MLKNGAFFKGE, ODGPPJGPEEC EEGKDDIENDG, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct OKJOAPONINH
{
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	public struct DECJKJLPPAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public List<PNIHDGLOHMA> BGFMLKJJDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public List<FHCGEGKCGMN> IKBHDEGLIEL;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xA648B0", Offset = "0xA630B0", VA = "0x180A648B0")]
		public DECJKJLPPAB(List<PNIHDGLOHMA> BGFMLKJJDFF, List<FHCGEGKCGMN> IKBHDEGLIEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class MOBBCIIIAFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public IEnumerable<PNIHDGLOHMA> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public MOBBCIIIAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E570", Offset = "0x6F2CD70", VA = "0x186F2E570")]
		internal object NPJOLJGABIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private KBOGPEMMJMI JFHCNNPIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private KHFFEHOCMIP MLKNGAFFKGE;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private LJKKFDADBJA BHIHJNCNCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x6F32C50", Offset = "0x6F31450", VA = "0x186F32C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x6F32EF0", Offset = "0x6F316F0", VA = "0x186F32EF0")]
	public static DECJKJLPPAB OHLHHBJPLCP(KBOGPEMMJMI JFHCNNPIMGD, KHFFEHOCMIP MLKNGAFFKGE)
	{
		return default(DECJKJLPPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6F32CA0", Offset = "0x6F314A0", VA = "0x186F32CA0")]
	private DECJKJLPPAB OHLHHBJPLCP()
	{
		return default(DECJKJLPPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F326A0", Offset = "0x6F30EA0", VA = "0x186F326A0")]
	private DECJKJLPPAB DGNBFOILAMO(JGEEHKGDOJK DMPJEPMEMOH, NLENJFNFFEI DKLFOAIPHBI)
	{
		return default(DECJKJLPPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F324D0", Offset = "0x6F30CD0", VA = "0x186F324D0")]
	private bool AOAHAJEENDC(IEnumerable<PNIHDGLOHMA> BGFMLKJJDFF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct PGPDICJLHKL
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class KEBHHOLDIDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public OKJOAPONINH.DECJKJLPPAB instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KEBHHOLDIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F28900", Offset = "0x6F27100", VA = "0x186F28900")]
		internal object AKPPBJHMEMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class NPKJMFDJOGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public NPKJMFDJOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F30E90", Offset = "0x6F2F690", VA = "0x186F30E90")]
		internal object LNNFHBMDCIJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F34060", Offset = "0x6F32860", VA = "0x186F34060")]
	public static void OHLHHBJPLCP(CIDAEBAGAJA HPMMBJCHINM, KHFFEHOCMIP MLKNGAFFKGE, OKJOAPONINH.DECJKJLPPAB NIKBJOFLMLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal class JJBFEFKAMEJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct GNJJLDHCJJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public JJBFEFKAMEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public DHPOOOBGFKB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public KHFFEHOCMIP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F22ED0", Offset = "0x6F216D0", VA = "0x186F22ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F23640", Offset = "0x6F21E40", VA = "0x186F23640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class DBIGAIMKLMN
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
			public DBIGAIMKLMN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x6F351E0", Offset = "0x6F339E0", VA = "0x186F351E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x6F354A0", Offset = "0x6F33CA0", VA = "0x186F354A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public JJBFEFKAMEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public NLBODGALKPJ<string>.EICLBAKIMEK handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DBIGAIMKLMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F21750", Offset = "0x6F1FF50", VA = "0x186F21750")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task INCBPDMKLAN(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct OEFIFHIFECD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public JJBFEFKAMEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private DBIGAIMKLMN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F318C0", Offset = "0x6F300C0", VA = "0x186F318C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F31DF0", Offset = "0x6F305F0", VA = "0x186F31DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct OFHDELCPCPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public JJBFEFKAMEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private Dictionary<Guid, List<CKLAGLLBGKB>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F31E50", Offset = "0x6F30650", VA = "0x186F31E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F32400", Offset = "0x6F30C00", VA = "0x186F32400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct DANMMOHFJBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public JJBFEFKAMEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private Dictionary<Guid, List<CKLAGLLBGKB>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F21070", Offset = "0x6F1F870", VA = "0x186F21070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F216F0", Offset = "0x6F1FEF0", VA = "0x186F216F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class DFAHCHMFGMD
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
			public CKLAGLLBGKB handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public DFAHCHMFGMD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x6F34FE0", Offset = "0x6F337E0", VA = "0x186F34FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x6F35180", Offset = "0x6F33980", VA = "0x186F35180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public NHJPNJDKCBP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public List<CKLAGLLBGKB> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DFAHCHMFGMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F21840", Offset = "0x6F20040", VA = "0x186F21840")]
		internal object EMCMFEPFJPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F21930", Offset = "0x6F20130", VA = "0x186F21930")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task HBMBDANCBAA(CKLAGLLBGKB handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F21A20", Offset = "0x6F20220", VA = "0x186F21A20")]
		internal object IAPBJAPICGH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct JCKJNIFEFNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public NHJPNJDKCBP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public List<CKLAGLLBGKB> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private DFAHCHMFGMD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F25750", Offset = "0x6F23F50", VA = "0x186F25750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F25C10", Offset = "0x6F24410", VA = "0x186F25C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct FHBPKEIPFAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public JJBFEFKAMEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public NLBODGALKPJ<string>.EICLBAKIMEK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F21F30", Offset = "0x6F20730", VA = "0x186F21F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F224F0", Offset = "0x6F20CF0", VA = "0x186F224F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class OJDHFKEPDAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OJDHFKEPDAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F32460", Offset = "0x6F30C60", VA = "0x186F32460")]
		internal object CGBDDJBEPEI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct BGKBOBHEPNG : IAsyncStateMachine
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
		public JJBFEFKAMEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public KHFFEHOCMIP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E070", Offset = "0x6F1C870", VA = "0x186F1E070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E530", Offset = "0x6F1CD30", VA = "0x186F1E530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class KFHAHABAMGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KFHAHABAMGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F289B0", Offset = "0x6F271B0", VA = "0x186F289B0")]
		internal object MNJDKDDBGMM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct LAFJAFKPHLK : IAsyncStateMachine
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
		public JJBFEFKAMEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private TaskAwaiter<EMALNGGNKEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A1D0", Offset = "0x6F289D0", VA = "0x186F2A1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A800", Offset = "0x6F29000", VA = "0x186F2A800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class EOMOFOICEKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public EOMOFOICEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F21B10", Offset = "0x6F20310", VA = "0x186F21B10")]
		internal object LILDFOGOKDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private readonly FGOFJPDDCML DHPNIFDOAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private FNJJFFBPOLN DKEHEBLHNLM;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private CIDAEBAGAJA EPAPOAIHPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB2B0", VA = "0x1808CCAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public JJBFEFKAMEJ(FGOFJPDDCML DHPNIFDOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F27A30", Offset = "0x6F26230", VA = "0x186F27A30")]
	[AsyncStateMachine(typeof(GNJJLDHCJJC))]
	public Task OHLHHBJPLCP(DHPOOOBGFKB AEDKDLJAHGC, KHFFEHOCMIP IJHAEGPEDEL, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F273A0", Offset = "0x6F25BA0", VA = "0x186F273A0")]
	[AsyncStateMachine(typeof(OEFIFHIFECD))]
	private Task HPCFLECNHHL(KHFFEHOCMIP MLKNGAFFKGE, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F278F0", Offset = "0x6F260F0", VA = "0x186F278F0")]
	[AsyncStateMachine(typeof(OFHDELCPCPA))]
	private Task OBAOBOAPAPI(KHFFEHOCMIP MLKNGAFFKGE, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F271B0", Offset = "0x6F259B0", VA = "0x186F271B0")]
	[AsyncStateMachine(typeof(DANMMOHFJBA))]
	private Task HBKLNAANBNJ(KHFFEHOCMIP MLKNGAFFKGE, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F26D50", Offset = "0x6F25550", VA = "0x186F26D50")]
	[AsyncStateMachine(typeof(JCKJNIFEFNM))]
	private Task AGFHCLEHHCL(Guid AJPIIGJFNNM, List<CKLAGLLBGKB> CIHEMJMDENG, NHJPNJDKCBP AONJIMBAECC, KHFFEHOCMIP MLKNGAFFKGE, CancellationToken OECMOOGGOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F274E0", Offset = "0x6F25CE0", VA = "0x186F274E0")]
	[AsyncStateMachine(typeof(FHBPKEIPFAB))]
	private Task IICLDJJAFBB(KHFFEHOCMIP MLKNGAFFKGE, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F277B0", Offset = "0x6F25FB0", VA = "0x186F277B0")]
	[AsyncStateMachine(typeof(BGKBOBHEPNG))]
	private Task MAGPBCMEKHD(Guid BPBLDPAFBDA, KHFFEHOCMIP MLKNGAFFKGE, NLBODGALKPJ<string>.EICLBAKIMEK JPMGDEGBMJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F26EA0", Offset = "0x6F256A0", VA = "0x186F26EA0")]
	[AsyncStateMachine(typeof(LAFJAFKPHLK))]
	private Task BBIEIEKAMOH(Guid BPBLDPAFBDA, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F27B80", Offset = "0x6F26380", VA = "0x186F27B80")]
	private void PJDEEIBCFGK(Guid BPBLDPAFBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F272F0", Offset = "0x6F25AF0", VA = "0x186F272F0")]
	private void HCHAFEGECEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F27620", Offset = "0x6F25E20", VA = "0x186F27620")]
	public Guid LFIOOIOEPIG(DHPOOOBGFKB FOMNEEODGEH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F26FE0", Offset = "0x6F257E0", VA = "0x186F26FE0")]
	[CompilerGenerated]
	private object DIMLIDCCOOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
public readonly struct KDGOOCIPGIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	public readonly bool NBIDLEBDJIA;

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0xDCDC00", Offset = "0xDCC400", VA = "0x180DCDC00")]
	public KDGOOCIPGIF(bool FIEJJOHDOGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public readonly struct KPAJDCMJFPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	public readonly JGEEHKGDOJK? CHOEBKCBEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000644")]
	public readonly GNHMNAFBOMC CMJCDLMIGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	public readonly string? PGEOPBOCOEE;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public IReadOnlyCollection<string> CENGKLNAHPH
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F28A40", Offset = "0x6F27240", VA = "0x186F28A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public IReadOnlyDictionary<long, int> HJKCFFNABCI
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F28A20", Offset = "0x6F27220", VA = "0x186F28A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F28A60", Offset = "0x6F27260", VA = "0x186F28A60")]
	public KPAJDCMJFPK(JGEEHKGDOJK? OLHDNFLDIIE, GNHMNAFBOMC OLOFPEOCCKC, string? DPABDEMPNNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
internal class MBIGIDGHAFP : PIDDKKGGEPO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct IJCPLKDAFAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public AsyncTaskMethodBuilder<KPAJDCMJFPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public MBIGIDGHAFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public OHMHKMILLGD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public GIJNHOOAAEG roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private OHNDHAGHNHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F24670", Offset = "0x6F22E70", VA = "0x186F24670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x6F24CE0", Offset = "0x6F234E0", VA = "0x186F24CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class JKGPHLMGIML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public OHMHKMILLGD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public MBIGIDGHAFP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public JKGPHLMGIML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F27C90", Offset = "0x6F26490", VA = "0x186F27C90")]
		internal Task ABENDILLJHD(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F27EA0", Offset = "0x6F266A0", VA = "0x186F27EA0")]
		internal Task FHBKNPGOADA(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class CMMPAHKEFKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public JKGPHLMGIML CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public CMMPAHKEFKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F20AD0", Offset = "0x6F1F2D0", VA = "0x186F20AD0")]
		internal object GDFAOBAOLJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class BPIIPLINLNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public JKGPHLMGIML CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public BPIIPLINLNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FCF0", Offset = "0x6F1E4F0", VA = "0x186F1FCF0")]
		internal Task NLGGILDBFIF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct LOMBCGDONOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public OHMHKMILLGD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public MBIGIDGHAFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private CMMPAHKEFKF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private OHNDHAGHNHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B210", Offset = "0x6F29A10", VA = "0x186F2B210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F2BA70", Offset = "0x6F2A270", VA = "0x186F2BA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000646")]
	private readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x4000647")]
	private static readonly TimeSpan FMBONMBKCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000648")]
	private readonly LGNBDLLFNPJ DBPPPECJOAF;

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F2CBD0", Offset = "0x6F2B3D0", VA = "0x186F2CBD0")]
	public MBIGIDGHAFP(FGOFJPDDCML DHPNIFDOAJO, LGNBDLLFNPJ DBPPPECJOAF, MMJHHDEPGMK LPJFGGMIIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C1C0", Offset = "0x6F2A9C0", VA = "0x186F2C1C0")]
	[AsyncStateMachine(typeof(IJCPLKDAFAB))]
	public Task<KPAJDCMJFPK> HNAIEAEAFJH(long PMNPMGPNLGO, GIJNHOOAAEG BAMBEPDLBHC, OHMHKMILLGD DHBHJIFMIBE, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C080", Offset = "0x6F2A880", VA = "0x186F2C080")]
	[AsyncStateMachine(typeof(LOMBCGDONOC))]
	private Task CNIIGLOOHHJ(OHMHKMILLGD DHBHJIFMIBE, IEnumerable<PersistenceView> DGAKCPEAFFL, StringBuilder NGKBLIKMFBF, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F2BAD0", Offset = "0x6F2A2D0", VA = "0x186F2BAD0")]
	private KPAJDCMJFPK CBCJDBEPDPN(long PMNPMGPNLGO, GIJNHOOAAEG BAMBEPDLBHC, OHMHKMILLGD DHBHJIFMIBE, IEnumerable<PersistenceView> DGAKCPEAFFL, StringBuilder NGKBLIKMFBF)
	{
		return default(KPAJDCMJFPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F2CA10", Offset = "0x6F2B210", VA = "0x186F2CA10")]
	private JGEEHKGDOJK PJFAEGJODOO(long PMNPMGPNLGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C320", Offset = "0x6F2AB20", VA = "0x186F2C320")]
	private void JBEADGMNHDK(JGEEHKGDOJK MDMJECBCDGJ, StringBuilder NGKBLIKMFBF, IEnumerable<PersistenceView> DGAKCPEAFFL, [In] DANNFOFKDLN AGLCLDHAGLK, GJBBDEAEAPJ OIAEMJGIGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C570", Offset = "0x6F2AD70", VA = "0x186F2C570")]
	private void JONOHJDAKBA(JGEEHKGDOJK MDMJECBCDGJ, StringBuilder NGKBLIKMFBF, PersistenceView HLNNELMBBHN, GJBBDEAEAPJ OIAEMJGIGHM, [In] DANNFOFKDLN AGLCLDHAGLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class KPHOLKKPDOD : PIDDKKGGEPO
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class KDOIDINMJIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public CAHHGBNICMP.NOBHANHCCGH roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KDOIDINMJIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x6F288B0", Offset = "0x6F270B0", VA = "0x186F288B0")]
		internal object JPLHAPHKJAE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct JIIHCICEIGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public AsyncTaskMethodBuilder<(CAHHGBNICMP.NOBHANHCCGH roomDataUpload, CAHHGBNICMP.NOBHANHCCGH subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public KPAJDCMJFPK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public KPHOLKKPDOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private KDOIDINMJIA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private TaskAwaiter<CAHHGBNICMP.NOBHANHCCGH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x6F26490", Offset = "0x6F24C90", VA = "0x186F26490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x6F26CE0", Offset = "0x6F254E0", VA = "0x186F26CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct CFBOMHNGDKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public AsyncTaskMethodBuilder<OKHBKNIGNEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public KPHOLKKPDOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public KPAJDCMJFPK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public OJJLNGELKEB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private TaskAwaiter<(CAHHGBNICMP.NOBHANHCCGH roomDataUpload, CAHHGBNICMP.NOBHANHCCGH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private TaskAwaiter<OKHBKNIGNEJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FDB0", Offset = "0x6F1E5B0", VA = "0x186F1FDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x6F20440", Offset = "0x6F1EC40", VA = "0x186F20440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct JFMMLBGBELH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public AsyncTaskMethodBuilder<GEINPJEOBAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public KPHOLKKPDOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public KPAJDCMJFPK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private TaskAwaiter<(CAHHGBNICMP.NOBHANHCCGH roomDataUpload, CAHHGBNICMP.NOBHANHCCGH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private TaskAwaiter<GEINPJEOBAO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x6F26000", Offset = "0x6F24800", VA = "0x186F26000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x6F26420", Offset = "0x6F24C20", VA = "0x186F26420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class LKICGNHPKCF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000186")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000694")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			public AsyncTaskMethodBuilder<EMALNGGNKEF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			public LKICGNHPKCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000697")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000698")]
			private EMALNGGNKEF <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000699")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400069A")]
			private TaskAwaiter<GEINPJEOBAO> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400069B")]
			private TaskAwaiter<OKHBKNIGNEJ> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400069C")]
			private TaskAwaiter<EMALNGGNKEF> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x6F358F0", Offset = "0x6F340F0", VA = "0x186F358F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x6F36880", Offset = "0x6F35080", VA = "0x186F36880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public KPHOLKKPDOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public KPAJDCMJFPK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public OJJLNGELKEB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public KDGOOCIPGIF roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public LKICGNHPKCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A9F0", Offset = "0x6F291F0", VA = "0x186F2A9F0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<EMALNGGNKEF> KDOBMKBBOAK(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private struct MPKBLPJKDIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public AsyncTaskMethodBuilder<EMALNGGNKEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public KPHOLKKPDOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public KPAJDCMJFPK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public OJJLNGELKEB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public KDGOOCIPGIF roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private TaskAwaiter<EMALNGGNKEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F280", Offset = "0x6F2DA80", VA = "0x186F2F280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F590", Offset = "0x6F2DD90", VA = "0x186F2F590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private static readonly MMJHHDEPGMK PJNAJEEBPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private readonly HLMIDPDLNEO MLLNBMKAIJL;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private KBOGPEMMJMI MDENMFBJAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x6F0DF60", Offset = "0x6F0C760", VA = "0x186F0DF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F29620", Offset = "0x6F27E20", VA = "0x186F29620")]
	public KPHOLKKPDOD(FGOFJPDDCML DHPNIFDOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F28FD0", Offset = "0x6F277D0", VA = "0x186F28FD0")]
	[AsyncStateMachine(typeof(JIIHCICEIGB))]
	private Task<(CAHHGBNICMP.NOBHANHCCGH, CAHHGBNICMP.NOBHANHCCGH)> CKGBHFGAJKE(KPAJDCMJFPK EJOKDLGPDNO, long LNOJCNCBDMF, long EIPINGDKEKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F29420", Offset = "0x6F27C20", VA = "0x186F29420")]
	[AsyncStateMachine(typeof(CFBOMHNGDKE))]
	public Task<OKHBKNIGNEJ> PFLJPKBMADL(int FFJNJOPCPOE, [CanBeNull] OJJLNGELKEB ACMFDOFDJLP, KPAJDCMJFPK EJOKDLGPDNO, long LNOJCNCBDMF, long EIPINGDKEKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F292B0", Offset = "0x6F27AB0", VA = "0x186F292B0")]
	[AsyncStateMachine(typeof(JFMMLBGBELH))]
	private Task<GEINPJEOBAO> HOOIFNACOGL(string BIENKHHLBJK, int FFJNJOPCPOE, KPAJDCMJFPK EJOKDLGPDNO, long LNOJCNCBDMF, long EIPINGDKEKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F29110", Offset = "0x6F27910", VA = "0x186F29110")]
	[AsyncStateMachine(typeof(MPKBLPJKDIP))]
	public Task<EMALNGGNKEF> GPEPOGPPELN(int FFJNJOPCPOE, OJJLNGELKEB? ACMFDOFDJLP, KPAJDCMJFPK EJOKDLGPDNO, long LNOJCNCBDMF, long EIPINGDKEKJ, KDGOOCIPGIF JLEBKFLGLKJ, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public abstract class EMFADFNBFEP<T> where T : EMFADFNBFEP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	internal readonly KBOGPEMMJMI BKOPDLGOFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private int? DOMHGJAKJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	protected readonly Guid FEJJNELNJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	protected readonly NJNAHKGLFBJ JLNEPDLDPHM;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	protected T EGNKHPHEHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x376A5B0", Offset = "0x3768DB0", VA = "0x18376A5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x376A8D0", Offset = "0x37690D0", VA = "0x18376A8D0")]
	internal EMFADFNBFEP(KBOGPEMMJMI KKIGFDJLMFO, NJNAHKGLFBJ IOKNHBBOAPK, [Optional] Guid? KPJLKKPOEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x376A740", Offset = "0x3768F40", VA = "0x18376A740")]
	private EMALNGGNKEF LPMALHCHCGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "4")]
	protected virtual void PILMKIJBKGN(EMALNGGNKEF CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x376A510", Offset = "0x3768D10", VA = "0x18376A510")]
	public T HAPCPJOLCFB(KCMOAPDBFGB GBDHHGKEDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x376A820", Offset = "0x3769020", VA = "0x18376A820")]
	public T NCFIDIFNLEK(int BMGFBGPBIIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x376A610", Offset = "0x3768E10", VA = "0x18376A610", Slot = "5")]
	public virtual Task<AICFBPACFMB> JEDAHJHMJJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
public class ICGMBNNGMKC : EMFADFNBFEP<ICGMBNNGMKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private JKENAGDJKCF EMIMPCIEFOP;

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x6F23EE0", Offset = "0x6F226E0", VA = "0x186F23EE0")]
	internal ICGMBNNGMKC(KBOGPEMMJMI KKIGFDJLMFO, NJNAHKGLFBJ IOKNHBBOAPK, [Optional] Guid? KPJLKKPOEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x64967C0", Offset = "0x6494FC0", VA = "0x1864967C0")]
	public ICGMBNNGMKC DFFICDKBPJF(JKENAGDJKCF EMIMPCIEFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x6F23E10", Offset = "0x6F22610", VA = "0x186F23E10", Slot = "4")]
	protected override void PILMKIJBKGN(EMALNGGNKEF CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public class CPDLBCJHLMO : EMFADFNBFEP<CPDLBCJHLMO>
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	internal enum KEKMLHFPAHN
	{
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private struct MENHDEDLDPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public AsyncTaskMethodBuilder<AICFBPACFMB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public CPDLBCJHLMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private TaskAwaiter<AICFBPACFMB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x6F2CC20", Offset = "0x6F2B420", VA = "0x186F2CC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x6F2CFD0", Offset = "0x6F2B7D0", VA = "0x186F2CFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	private KEKMLHFPAHN FIAADNFIGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006AF")]
	private string OHGHOCOCMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	private OJJLNGELKEB EMIMPCIEFOP;

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x6F20E60", Offset = "0x6F1F660", VA = "0x186F20E60")]
	internal CPDLBCJHLMO(KBOGPEMMJMI KKIGFDJLMFO, NJNAHKGLFBJ IOKNHBBOAPK, [Optional] Guid? KPJLKKPOEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x6F20B40", Offset = "0x6F1F340", VA = "0x186F20B40")]
	public CPDLBCJHLMO ADDGDCACJNJ(string LGOHHLIODIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x6F20B70", Offset = "0x6F1F370", VA = "0x186F20B70")]
	public CPDLBCJHLMO AMBDNGCHCAA(bool ADCGHPGGBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x6F20BD0", Offset = "0x6F1F3D0", VA = "0x186F20BD0")]
	public CPDLBCJHLMO HPJMFMBCANB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x6F20CF0", Offset = "0x6F1F4F0", VA = "0x186F20CF0", Slot = "4")]
	protected override void PILMKIJBKGN(EMALNGGNKEF CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x6F20C00", Offset = "0x6F1F400", VA = "0x186F20C00", Slot = "5")]
	[AsyncStateMachine(typeof(MENHDEDLDPH))]
	public override Task<AICFBPACFMB> JEDAHJHMJJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x6F20B90", Offset = "0x6F1F390", VA = "0x186F20B90")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<AICFBPACFMB> CANOJMJGJJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
internal static class BBCCCBBILKE
{
	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DF20", Offset = "0x6F1C720", VA = "0x186F1DF20")]
	public static void NHLMIHBGGLO(this CBGJLBKPGCG NIDDAGMFGFH, PCHMOHFEPBH KKHOAEMONDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DEA0", Offset = "0x6F1C6A0", VA = "0x186F1DEA0")]
	public static void IJIEBFDKFHF(this PCHMOHFEPBH OHIPFKMIAAH, [Optional] string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class AHDCHCAEFFH
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CB40", Offset = "0x6F1B340", VA = "0x186F1CB40")]
	public static KGMNHEONACL NBJPDBKKGCI(this BOMGHJIBOOJ OEIMOCDIGIK)
	{
		return default(KGMNHEONACL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CA90", Offset = "0x6F1B290", VA = "0x186F1CA90")]
	public static BOMGHJIBOOJ AGFLFCLKKKN(this KGMNHEONACL NPIHJBLMBOK)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006BD")]
			public JKAICPKMEEA ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006BE")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006BF")]
			public JKAICPKMEEA HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private static JKAICPKMEEA[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private Dictionary<JKAICPKMEEA, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x6F36FD0", Offset = "0x6F357D0", VA = "0x186F36FD0")]
		public bool IIFNKPLHFPI(JKAICPKMEEA MNHEGHFCLDD, [Out] ResultConfig LNOEPHEPJGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x6F36E90", Offset = "0x6F35690", VA = "0x186F36E90")]
		public ResultConfig AABLFHLCEHP(JKAICPKMEEA DAGAMHLIEBK, [Optional] HashSet<JKAICPKMEEA> ONBLIOLHAGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x6F37570", Offset = "0x6F35D70", VA = "0x186F37570", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x6F37040", Offset = "0x6F35840", VA = "0x186F37040", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x8B1970", Offset = "0x8B0170", VA = "0x1808B1970")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
public static class FGANAFLGMDA
{
	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x6F21B80", Offset = "0x6F20380", VA = "0x186F21B80")]
	[ANLGLDAOJJE(ELBANFBEGNE.GameOnly)]
	private static void KLKHAMFMIOA(AANDDJDEEFL JBFKAEMANEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
public interface GJKNKHPAHGK : IEquatable<GJKNKHPAHGK>
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	DateTime NOGELBAJLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCFABCJNDDO();

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PMLLDALMAOC(long LNOJCNCBDMF, long PMNPMGPNLGO, [Out] KPAJDCMJFPK EJOKDLGPDNO);
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal class MOPJKOKIKCC : JLBKHEFKEBK
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class MNPODIGFBJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public JBEOMJBFOMC autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public MNPODIGFBJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DBA0", Offset = "0x6F2C3A0", VA = "0x186F2DBA0")]
		internal object FDFHNJFJAHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private readonly PKNLHIBIJPK NKAMECPNKBH;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<GJKNKHPAHGK> CHOKGJDBJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E5F0", Offset = "0x6F2CDF0", VA = "0x186F2E5F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E9E0", Offset = "0x6F2D1E0", VA = "0x186F2E9E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	[UnityEngine.Scripting.Preserve]
	public MOPJKOKIKCC([GNKLNMHODGG(null)] PKNLHIBIJPK NKAMECPNKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E6A0", Offset = "0x6F2CEA0", VA = "0x186F2E6A0", Slot = "6")]
	public bool DHKEFIIAMHM(long LNOJCNCBDMF, long PMNPMGPNLGO, KPAJDCMJFPK EJOKDLGPDNO, JBEOMJBFOMC PFIHPPKOFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x1BBDD20", Offset = "0x1BBC520", VA = "0x181BBDD20")]
	private void LEJFFPFAKJN(GJKNKHPAHGK JIBBHHKPIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EB40", Offset = "0x6F2D340", VA = "0x186F2EB40", Slot = "7")]
	public bool FEGFCMKGMMC(long LNOJCNCBDMF, long PMNPMGPNLGO, [Out] GJKNKHPAHGK OGANCPGOCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EA90", Offset = "0x6F2D290", VA = "0x186F2EA90", Slot = "8")]
	public bool EAJGKDABIFA(long LNOJCNCBDMF, long PMNPMGPNLGO, JBEOMJBFOMC PFIHPPKOFGJ, [Out] GJKNKHPAHGK OGANCPGOCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EDE0", Offset = "0x6F2D5E0", VA = "0x186F2EDE0")]
	private void PJJKMBIDMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x6F2ECB0", Offset = "0x6F2D4B0", VA = "0x186F2ECB0", Slot = "9")]
	public void IFIDEEPODDB(long LNOJCNCBDMF, long PMNPMGPNLGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
internal abstract class MOAJEAOEBHI : PKNLHIBIJPK
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	protected enum HENBAJIKKKP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class FLEKOCCHOLM : IEnumerable<GJKNKHPAHGK>, IEnumerable, IEnumerator<GJKNKHPAHGK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private GJKNKHPAHGK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public MOAJEAOEBHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private JBEOMJBFOMC autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public JBEOMJBFOMC <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		private GJKNKHPAHGK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x898540", Offset = "0x896D40", VA = "0x180898540")]
		[DebuggerHidden]
		public FLEKOCCHOLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x6F22C60", Offset = "0x6F21460", VA = "0x186F22C60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x6F22E80", Offset = "0x6F21680", VA = "0x186F22E80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x6F22DD0", Offset = "0x6F215D0", VA = "0x186F22DD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GJKNKHPAHGK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x6F22DD0", Offset = "0x6F215D0", VA = "0x186F22DD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class CPPLMCOMJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public JBEOMJBFOMC autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public CPPLMCOMJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x6F20FD0", Offset = "0x6F1F7D0", VA = "0x186F20FD0")]
		internal object INLCJFKGJMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class CAAANKDPMOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public MOAJEAOEBHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public CAAANKDPMOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FD30", Offset = "0x6F1E530", VA = "0x186F1FD30")]
		internal void HHCKPBEOKKO(IMKHJKNDKKH.PPEOHELPGKG ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private readonly object OKILPMDKCLJ;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	protected string EMDPELKMCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DF80", Offset = "0x6F2C780", VA = "0x186F2DF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public abstract OBNEGHJBEMC LFMDGCNPAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E4F0", Offset = "0x6F2CCF0", VA = "0x186F2E4F0")]
	protected MOAJEAOEBHI([CanBeNull] string LGPGHDNJDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DF90", Offset = "0x6F2C790", VA = "0x186F2DF90", Slot = "5")]
	public bool LIJFCFDFAGE(long LNOJCNCBDMF, long PMNPMGPNLGO, JBEOMJBFOMC PFIHPPKOFGJ, [Out] GJKNKHPAHGK JIBBHHKPIII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E460", Offset = "0x6F2CC60", VA = "0x186F2E460", Slot = "6")]
	[IteratorStateMachine(typeof(FLEKOCCHOLM))]
	public IEnumerable<GJKNKHPAHGK> OKIDCEIKFBL(JBEOMJBFOMC PFIHPPKOFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void PHELKBCFCAB(Stream BELIFDJMMMM, long LNOJCNCBDMF, long PMNPMGPNLGO, KPAJDCMJFPK EJOKDLGPDNO);

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool LMMBNAOEAED(Stream ANFMFOBFOGB, long LNOJCNCBDMF, long PMNPMGPNLGO, NDLFLKPHCDL AKONPFJKFPB, [Out] KPAJDCMJFPK EJOKDLGPDNO);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DC10", Offset = "0x6F2C410", VA = "0x186F2DC10", Slot = "7")]
	public GJKNKHPAHGK CJOHOEJPGDK(long LNOJCNCBDMF, long PMNPMGPNLGO, KPAJDCMJFPK EJOKDLGPDNO, JBEOMJBFOMC PFIHPPKOFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo KMFGIACBFNL(long LNOJCNCBDMF, long PMNPMGPNLGO, JBEOMJBFOMC PFIHPPKOFGJ, HENBAJIKKKP IMCJCMBDCMA);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo NCGCNOFCEPD(JBEOMJBFOMC PFIHPPKOFGJ, HENBAJIKKKP IMCJCMBDCMA);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DF10", Offset = "0x6F2C710", VA = "0x186F2DF10")]
	protected void ECPKEIGDCCK(IMKHJKNDKKH.PPEOHELPGKG KIIDOFBJKGL, string IOFIKOEHDBG, FileInfo MMNGGFMEEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E160", Offset = "0x6F2C960", VA = "0x186F2E160")]
	internal bool LKNCFIGCPOJ(FileInfo EMIFKHCKMJI, long LNOJCNCBDMF, long PMNPMGPNLGO, [Out] KPAJDCMJFPK EJOKDLGPDNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private void JNJNFIJBCFP(Exception KAGEPDCJNNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
internal class BOIGMHAGBEE : MOAJEAOEBHI
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public override OBNEGHJBEMC LFMDGCNPAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xCAD520", Offset = "0xCABD20", VA = "0x180CAD520", Slot = "8")]
		get
		{
			return default(OBNEGHJBEMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F3B0", Offset = "0x6F1DBB0", VA = "0x186F1F3B0")]
	public BOIGMHAGBEE([Optional] string LGPGHDNJDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EA30", Offset = "0x6F1D230", VA = "0x186F1EA30")]
	private void HIEMIJOIOFJ(JBEOMJBFOMC PFIHPPKOFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F190", Offset = "0x6F1D990", VA = "0x186F1F190", Slot = "9")]
	internal override void PHELKBCFCAB(Stream BELIFDJMMMM, long LNOJCNCBDMF, long PMNPMGPNLGO, KPAJDCMJFPK EJOKDLGPDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EBA0", Offset = "0x6F1D3A0", VA = "0x186F1EBA0", Slot = "10")]
	internal override bool LMMBNAOEAED(Stream ANFMFOBFOGB, long LNOJCNCBDMF, long PMNPMGPNLGO, NDLFLKPHCDL AKONPFJKFPB, [Out] KPAJDCMJFPK EJOKDLGPDNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EAB0", Offset = "0x6F1D2B0", VA = "0x186F1EAB0", Slot = "11")]
	protected override FileInfo KMFGIACBFNL(long LNOJCNCBDMF, long PMNPMGPNLGO, JBEOMJBFOMC PFIHPPKOFGJ, HENBAJIKKKP IMCJCMBDCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F090", Offset = "0x6F1D890", VA = "0x186F1F090", Slot = "12")]
	protected override DirectoryInfo NCGCNOFCEPD(JBEOMJBFOMC PFIHPPKOFGJ, HENBAJIKKKP IMCJCMBDCMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal sealed class FMDELCHOOLL : MOAJEAOEBHI
{
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private static readonly byte[] JOEHGGMHBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private readonly byte[] DIBBIMDPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private readonly byte[] CBBAODJGODC;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public override OBNEGHJBEMC LFMDGCNPAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x5D59370", Offset = "0x5D57B70", VA = "0x185D59370", Slot = "8")]
		get
		{
			return default(OBNEGHJBEMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x6F38A20", Offset = "0x6F37220", VA = "0x186F38A20")]
	public FMDELCHOOLL([Optional] string LGPGHDNJDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x6F386E0", Offset = "0x6F36EE0", VA = "0x186F386E0", Slot = "9")]
	internal override void PHELKBCFCAB(Stream BELIFDJMMMM, long LNOJCNCBDMF, long PMNPMGPNLGO, KPAJDCMJFPK EJOKDLGPDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x6F37D40", Offset = "0x6F36540", VA = "0x186F37D40", Slot = "10")]
	internal override bool LMMBNAOEAED(Stream ANFMFOBFOGB, long LNOJCNCBDMF, long PMNPMGPNLGO, NDLFLKPHCDL AKONPFJKFPB, [Out] KPAJDCMJFPK EJOKDLGPDNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x6F38500", Offset = "0x6F36D00", VA = "0x186F38500")]
	private void MHKLPMEILII(byte[] GHFEJDPMJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x6F37C10", Offset = "0x6F36410", VA = "0x186F37C10", Slot = "11")]
	protected override FileInfo KMFGIACBFNL(long LNOJCNCBDMF, long PMNPMGPNLGO, JBEOMJBFOMC PFIHPPKOFGJ, HENBAJIKKKP IMCJCMBDCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x6F385C0", Offset = "0x6F36DC0", VA = "0x186F385C0", Slot = "12")]
	protected override DirectoryInfo NCGCNOFCEPD(JBEOMJBFOMC PFIHPPKOFGJ, HENBAJIKKKP IMCJCMBDCMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public enum OBNEGHJBEMC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006E2")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006E4")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal class PHPBOCMCDNB : PKNLHIBIJPK
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class OOBEPGCCBHH : IEnumerable<GJKNKHPAHGK>, IEnumerable, IEnumerator<GJKNKHPAHGK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private GJKNKHPAHGK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public PHPBOCMCDNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private JBEOMJBFOMC autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public JBEOMJBFOMC <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private OBNEGHJBEMC[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private IEnumerator<GJKNKHPAHGK> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private GJKNKHPAHGK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x898540", Offset = "0x896D40", VA = "0x180898540")]
		[DebuggerHidden]
		public OOBEPGCCBHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x6F39010", Offset = "0x6F37810", VA = "0x186F39010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x6F38B10", Offset = "0x6F37310", VA = "0x186F38B10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x6F38EC0", Offset = "0x6F376C0", VA = "0x186F38EC0")]
		private void OLLLOCKLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x6F38FC0", Offset = "0x6F377C0", VA = "0x186F38FC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x6F38F10", Offset = "0x6F37710", VA = "0x186F38F10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GJKNKHPAHGK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x6F38F10", Offset = "0x6F37710", VA = "0x186F38F10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006E5")]
	private readonly OBNEGHJBEMC[] CIEEFMANHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006E6")]
	private readonly Dictionary<OBNEGHJBEMC, PKNLHIBIJPK> CDEPJNOPJIB;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public OBNEGHJBEMC LFMDGCNPAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x6F39BD0", Offset = "0x6F383D0", VA = "0x186F39BD0", Slot = "4")]
		get
		{
			return default(OBNEGHJBEMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x6F39C90", Offset = "0x6F38490", VA = "0x186F39C90")]
	[UnityEngine.Scripting.Preserve]
	public PHPBOCMCDNB(params PKNLHIBIJPK[] GACADJBNOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x6F39A80", Offset = "0x6F38280", VA = "0x186F39A80", Slot = "5")]
	public bool LIJFCFDFAGE(long LNOJCNCBDMF, long PMNPMGPNLGO, JBEOMJBFOMC PFIHPPKOFGJ, [Out] GJKNKHPAHGK JIBBHHKPIII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x6F39860", Offset = "0x6F38060", VA = "0x186F39860")]
	private void GLJGICPFGCP(int HGCIIKCJEJK, long LNOJCNCBDMF, long PMNPMGPNLGO, JBEOMJBFOMC PFIHPPKOFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x6F39C00", Offset = "0x6F38400", VA = "0x186F39C00", Slot = "6")]
	[IteratorStateMachine(typeof(OOBEPGCCBHH))]
	public IEnumerable<GJKNKHPAHGK> OKIDCEIKFBL(JBEOMJBFOMC PFIHPPKOFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x6F39710", Offset = "0x6F37F10", VA = "0x186F39710", Slot = "7")]
	public GJKNKHPAHGK CJOHOEJPGDK(long LNOJCNCBDMF, long PMNPMGPNLGO, KPAJDCMJFPK EJOKDLGPDNO, JBEOMJBFOMC PFIHPPKOFGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal static class EGJDKIDJGGA
{
	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x6F37B50", Offset = "0x6F36350", VA = "0x186F37B50")]
	internal static byte[] MLOCFMCCJMF(byte[] GHFEJDPMJDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x6F378F0", Offset = "0x6F360F0", VA = "0x186F378F0")]
	public static void ADAOCIMEKJA(Stream JMDMENEIBHM, byte[] LPHJONCAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x6F37970", Offset = "0x6F36170", VA = "0x186F37970")]
	public static bool FJJDMEHLFFJ(Stream JMDMENEIBHM, long FFLEDGGLKIP, NDLFLKPHCDL EFKJGMJHGOD, [Out] byte[] HANFLLHBENO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal sealed class OPGAANLFPEA : GJKNKHPAHGK, IEquatable<GJKNKHPAHGK>, IEquatable<OPGAANLFPEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private readonly MOAJEAOEBHI OGCIMINBBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	public readonly FileInfo LNCMBGIPBBK;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public OBNEGHJBEMC LFMDGCNPAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x6916C80", Offset = "0x6915480", VA = "0x186916C80", Slot = "9")]
		get
		{
			return default(OBNEGHJBEMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DateTime NOGELBAJLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x6F393C0", Offset = "0x6F37BC0", VA = "0x186F393C0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x6F39600", Offset = "0x6F37E00", VA = "0x186F39600")]
	public OPGAANLFPEA(MOAJEAOEBHI ADDBNEJDGLI, FileInfo EMIFKHCKMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x6F39550", Offset = "0x6F37D50", VA = "0x186F39550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x6F39450", Offset = "0x6F37C50", VA = "0x186F39450", Slot = "5")]
	public void NCFABCJNDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x6F39510", Offset = "0x6F37D10", VA = "0x186F39510", Slot = "6")]
	public bool PMLLDALMAOC(long LNOJCNCBDMF, long PMNPMGPNLGO, [Out] KPAJDCMJFPK EJOKDLGPDNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x6F390A0", Offset = "0x6F378A0", VA = "0x186F390A0", Slot = "7")]
	public bool Equals(GJKNKHPAHGK OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x6F39180", Offset = "0x6F37980", VA = "0x186F39180", Slot = "8")]
	public bool Equals(OPGAANLFPEA OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x6F39240", Offset = "0x6F37A40", VA = "0x186F39240", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x6F39330", Offset = "0x6F37B30", VA = "0x186F39330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
public delegate void NDLFLKPHCDL(IMKHJKNDKKH.PPEOHELPGKG PEJJCHAKOMP, string CLBGCJICGJG);
[Cpp2IlInjected.Token(Token = "0x20001A5")]
internal interface PKNLHIBIJPK
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	OBNEGHJBEMC LFMDGCNPAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIJFCFDFAGE(long LNOJCNCBDMF, long PMNPMGPNLGO, JBEOMJBFOMC PFIHPPKOFGJ, [Out] GJKNKHPAHGK JIBBHHKPIII);

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<GJKNKHPAHGK> OKIDCEIKFBL(JBEOMJBFOMC PFIHPPKOFGJ);

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GJKNKHPAHGK CJOHOEJPGDK(long LNOJCNCBDMF, long PMNPMGPNLGO, KPAJDCMJFPK EJOKDLGPDNO, JBEOMJBFOMC PFIHPPKOFGJ);
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
