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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x6965130", Offset = "0x6963B30", VA = "0x186965130")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
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
	public class LogRegistrationIndex : DEDNPPDJFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x695DDC0", Offset = "0x695C7C0", VA = "0x18695DDC0", Slot = "4")]
		public override void JIGIEBIDGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JOGGFBLGOBB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x695C500", Offset = "0x695AF00", VA = "0x18695C500")]
	public JOGGFBLGOBB(string CPPFNMDMGHI, Exception BGHIPOHPBJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class GMLJHIJGMLE : IHBPFOCAICA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct INFFPLADPOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<NCDAEICGONM>> <>t__builder;

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
		private TaskAwaiter<NGNMLJNCLAI<NCDAEICGONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6955F80", Offset = "0x6954980", VA = "0x186955F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69561C0", Offset = "0x6954BC0", VA = "0x1869561C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LOMLJCCPMFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<KCDLGIMJHPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<KCDLGIMJHPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x695DB40", Offset = "0x695C540", VA = "0x18695DB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x695DD50", Offset = "0x695C750", VA = "0x18695DD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	[UnityEngine.Scripting.Preserve]
	public GMLJHIJGMLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6953FE0", Offset = "0x69529E0", VA = "0x186953FE0", Slot = "4")]
	[AsyncStateMachine(typeof(INFFPLADPOG))]
	public Task<IReadOnlyList<NCDAEICGONM>> GKFCDGEOPAP(long ECEDKLNOLLD, long ADPGIJLEEII, [Optional] CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6953ED0", Offset = "0x69528D0", VA = "0x186953ED0", Slot = "5")]
	[AsyncStateMachine(typeof(LOMLJCCPMFO))]
	public Task<IReadOnlyList<KCDLGIMJHPG>> BMEMFKMMOLL(IReadOnlyList<int> FFJIBBDDBPL, [Optional] CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FCDFEKOFBDO : IEquatable<FCDFEKOFBDO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int LHLBDIGACIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	KCDLGIMJHPG HJCGPAGJAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime HGFOCMABCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OLJNBBMOJJM? DFJJJDCHCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NMLGGLIFMJC? CKCEJEJJFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	JDNHPMKFBHI LJKEOAILPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<OEGBNAHMNGM> HODBCHLBOOF();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum JDNHPMKFBHI
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IHBPFOCAICA
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<NCDAEICGONM>> GKFCDGEOPAP(long ECEDKLNOLLD, long ADPGIJLEEII, [Optional] CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<KCDLGIMJHPG>> BMEMFKMMOLL(IReadOnlyList<int> FFJIBBDDBPL, [Optional] CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CIDHIFCEDDG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class NNGKEODGKEE : FCDFEKOFBDO, IEquatable<FCDFEKOFBDO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct NKOIPKMLNCI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<OEGBNAHMNGM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public NNGKEODGKEE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IOEHFMEGOFB <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<ECLKAFGMDKO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<OEGBNAHMNGM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x69606E0", Offset = "0x695F0E0", VA = "0x1869606E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6960B80", Offset = "0x695F580", VA = "0x186960B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly NCDAEICGONM JIELJANNEHC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int LHLBDIGACIH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7CBFB0", Offset = "0x7CA9B0", VA = "0x1807CBFB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public KCDLGIMJHPG HJCGPAGJAIC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime OHPLEHLILNE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x55C0150", Offset = "0x55BEB50", VA = "0x1855C0150", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OLJNBBMOJJM? DFJJJDCHCCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1A9F890", Offset = "0x1A9E290", VA = "0x181A9F890", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NMLGGLIFMJC? CKCEJEJJFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x55C0230", Offset = "0x55BEC30", VA = "0x1855C0230", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JDNHPMKFBHI LJKEOAILPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x882190", Offset = "0x880B90", VA = "0x180882190", Slot = "10")]
			get
			{
				return default(JDNHPMKFBHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69614D0", Offset = "0x695FED0", VA = "0x1869614D0", Slot = "9")]
		[AsyncStateMachine(typeof(NKOIPKMLNCI))]
		public Task<OEGBNAHMNGM> HODBCHLBOOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69615D0", Offset = "0x695FFD0", VA = "0x1869615D0")]
		public NNGKEODGKEE(int EFBJALLHEOK, KCDLGIMJHPG LKPCLHMABJE, NCDAEICGONM JIELJANNEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6961380", Offset = "0x695FD80", VA = "0x186961380", Slot = "11")]
		public bool Equals(FCDFEKOFBDO HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x69612E0", Offset = "0x695FCE0", VA = "0x1869612E0", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6961410", Offset = "0x695FE10", VA = "0x186961410")]
		private bool GHGGBGAGMGG(NNGKEODGKEE HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6961450", Offset = "0x695FE50", VA = "0x186961450", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class FKIPILCEFAN : FCDFEKOFBDO, IEquatable<FCDFEKOFBDO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct EEAJPAPKCNM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<OEGBNAHMNGM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public FKIPILCEFAN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<OEGBNAHMNGM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x694FCC0", Offset = "0x694E6C0", VA = "0x18694FCC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x694FEF0", Offset = "0x694E8F0", VA = "0x18694FEF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly JDLHDFPPGKG PEMLJPMBGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly OLJNBBMOJJM IIEAJANCAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly NMLGGLIFMJC OHCDNELHKDF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int LHLBDIGACIH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6952990", Offset = "0x6951390", VA = "0x186952990", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public KCDLGIMJHPG HJCGPAGJAIC
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6952A20", Offset = "0x6951420", VA = "0x186952A20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime OHPLEHLILNE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6952800", Offset = "0x6951200", VA = "0x186952800", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OLJNBBMOJJM? DFJJJDCHCCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x69529D0", Offset = "0x69513D0", VA = "0x1869529D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NMLGGLIFMJC? CKCEJEJJFCD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6952940", Offset = "0x6951340", VA = "0x186952940", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JDNHPMKFBHI LJKEOAILPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9206E0", Offset = "0x91F0E0", VA = "0x1809206E0", Slot = "10")]
			get
			{
				return default(JDNHPMKFBHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xEF10B0", Offset = "0xEEFAB0", VA = "0x180EF10B0")]
		public FKIPILCEFAN(JDLHDFPPGKG AJKANDNNPCH, OLJNBBMOJJM IALLFKFCCOO, NMLGGLIFMJC FIKNHHLOFEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6952850", Offset = "0x6951250", VA = "0x186952850", Slot = "9")]
		[AsyncStateMachine(typeof(EEAJPAPKCNM))]
		public Task<OEGBNAHMNGM> HODBCHLBOOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6952680", Offset = "0x6951080", VA = "0x186952680", Slot = "11")]
		public bool Equals(FCDFEKOFBDO HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x69525D0", Offset = "0x6950FD0", VA = "0x1869525D0", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6952720", Offset = "0x6951120", VA = "0x186952720")]
		private bool GHGGBGAGMGG(FKIPILCEFAN HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6952780", Offset = "0x6951180", VA = "0x186952780", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class DCMLACEAKPH : FCDFEKOFBDO, IEquatable<FCDFEKOFBDO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct PDNMAMECNEO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<OEGBNAHMNGM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<OEGBNAHMNGM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6967610", Offset = "0x6966010", VA = "0x186967610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6967850", Offset = "0x6966250", VA = "0x186967850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly KCDLGIMJHPG IOJCJKLIJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly OLJNBBMOJJM IIEAJANCAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly NMLGGLIFMJC OHCDNELHKDF;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int LHLBDIGACIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x694EE70", Offset = "0x694D870", VA = "0x18694EE70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public KCDLGIMJHPG HJCGPAGJAIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime OHPLEHLILNE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public OLJNBBMOJJM? DFJJJDCHCCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x694EE90", Offset = "0x694D890", VA = "0x18694EE90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NMLGGLIFMJC? CKCEJEJJFCD
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x694EE20", Offset = "0x694D820", VA = "0x18694EE20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JDNHPMKFBHI LJKEOAILPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "10")]
			get
			{
				return default(JDNHPMKFBHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xEF10B0", Offset = "0xEEFAB0", VA = "0x180EF10B0")]
		public DCMLACEAKPH(KCDLGIMJHPG LKPCLHMABJE, OLJNBBMOJJM IALLFKFCCOO, NMLGGLIFMJC FIKNHHLOFEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x694ED50", Offset = "0x694D750", VA = "0x18694ED50", Slot = "9")]
		[AsyncStateMachine(typeof(PDNMAMECNEO))]
		public Task<OEGBNAHMNGM> HODBCHLBOOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x694EAD0", Offset = "0x694D4D0", VA = "0x18694EAD0", Slot = "11")]
		public bool Equals(FCDFEKOFBDO HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x694E9B0", Offset = "0x694D3B0", VA = "0x18694E9B0", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x694ECC0", Offset = "0x694D6C0", VA = "0x18694ECC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x694EBE0", Offset = "0x694D5E0", VA = "0x18694EBE0")]
		private bool GHGGBGAGMGG(DCMLACEAKPH HKMMPHJFKEA)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct KONBMDLKEBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<FCDFEKOFBDO>> <>t__builder;

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
		public CIDHIFCEDDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<NCDAEICGONM> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<NCDAEICGONM>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, KCDLGIMJHPG account, NCDAEICGONM roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x695C570", Offset = "0x695AF70", VA = "0x18695C570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x695D420", Offset = "0x695BE20", VA = "0x18695D420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FMMIMLJPBKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, KCDLGIMJHPG account, NCDAEICGONM roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<NCDAEICGONM> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CIDHIFCEDDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<KCDLGIMJHPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6952AB0", Offset = "0x69514B0", VA = "0x186952AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6953490", Offset = "0x6951E90", VA = "0x186953490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GCAGKJNMIEN OKOIPGCECOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IHBPFOCAICA CNEOGEABHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly LAKPEJNKEPP LEJGKLMPAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly EHAFBHAOEDE<(long, long), IReadOnlyList<NCDAEICGONM>> DGEGBJPJJFL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x694E690", Offset = "0x694D090", VA = "0x18694E690")]
	[UnityEngine.Scripting.Preserve]
	public CIDHIFCEDDG([JDJLHBHAJCP(null)] IHBPFOCAICA JDGJLFBKBFI, [JDJLHBHAJCP(null)] LAKPEJNKEPP IBDJKHCFGKA, [JDJLHBHAJCP(null)] GCAGKJNMIEN DHJBGAIGEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x694E540", Offset = "0x694CF40", VA = "0x18694E540")]
	[AsyncStateMachine(typeof(KONBMDLKEBJ))]
	public Task<IList<FCDFEKOFBDO>> NMGMCDFPEAJ(long ECEDKLNOLLD, long AJIFLLNCAHB, bool ANFGAIAADGP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x694E3A0", Offset = "0x694CDA0", VA = "0x18694E3A0")]
	private bool LMEMEGPEHGC(DateTime? DCBNFLJOMJK, long ECEDKLNOLLD, long AJIFLLNCAHB, [Out] JDLHDFPPGKG CAKGNCPACEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x694E290", Offset = "0x694CC90", VA = "0x18694E290")]
	[AsyncStateMachine(typeof(FMMIMLJPBKM))]
	private Task<IReadOnlyList<(int, KCDLGIMJHPG, NCDAEICGONM)>> EBIIMONBJGM(IReadOnlyList<NCDAEICGONM> CCKLLFHJGMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LAKPEJNKEPP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JDLHDFPPGKG> HIIAMBBCHME;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EFGLHHKMJFK(long ECEDKLNOLLD, long AJIFLLNCAHB, NIPEHLMICJG BADNOCAELMA, OONOEGKKCEB LAGEFEKOMON);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MJHPDPLLOGM(long ECEDKLNOLLD, long AJIFLLNCAHB, [Out] JDLHDFPPGKG CAKGNCPACEH);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GFIAMFKBAHD(long ECEDKLNOLLD, long AJIFLLNCAHB, OONOEGKKCEB LAGEFEKOMON, [Out] JDLHDFPPGKG CAKGNCPACEH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OFEAHIJFJDG(long ECEDKLNOLLD, long AJIFLLNCAHB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface MIGIELKEKKG : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DJJJCDNBOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task NOEKGMHOKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCOEIGDDFHM(Task KPCFMNKKKMJ, string KNFFHCCGONA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface GKMNFCBMKNB : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OEGBNAHMNGM> PCPGKGCIPPH(JDLHDFPPGKG CAKGNCPACEH);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KJLBNJFADBL(CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface GLLACCLJKBN : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CGLEINIGDMO BCEBDBHLIDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPDIPHDPLOH();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POBIEGABLNM();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface AGBFFJHKJLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface GBCIGNIOONC
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan MBCEKOFPDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan DFILPENANCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan FKBLIAJNBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan JCAGLOKPPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool AMJNGFHOBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GKIOCGIIIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool ANFEEGGOEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int CPCOPMBHCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JBMFLIFMKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool OKACNCPHPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum OMBPFIKEGJO
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum MEONJBAFIMN
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
public struct BONPCGFBDHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long KFKBGLGDOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long ADPGIJLEEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly OMBPFIKEGJO CGEOAHHPHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception NMPJACMNNBN;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x694DAB0", Offset = "0x694C4B0", VA = "0x18694DAB0")]
	public BONPCGFBDHP(long KFKBGLGDOAB, long ADPGIJLEEII, OMBPFIKEGJO CGEOAHHPHHK, [CanBeNull] Exception NMPJACMNNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x694DA60", Offset = "0x694C460", VA = "0x18694DA60")]
	public static BONPCGFBDHP LNFAGJAFBAP(MAHIACGDFOP CMNPLCGICAL, OMBPFIKEGJO CGEOAHHPHHK, [Optional] Exception NMPJACMNNBN)
	{
		return default(BONPCGFBDHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void CJBDDEBCMOB(BONPCGFBDHP CGKFKLNGHMI);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface IFMIMGIKGIJ : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NPOJAJGBLNE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CJBDDEBCMOB EIPDEENCGLD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CJBDDEBCMOB MFEGIFGGDNF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CJBDDEBCMOB DBFGHKOFGKJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<MEONJBAFIMN, bool> MADDHLELLNL;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IDBIHAHJDHC();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BDPNOJEFBCA(BONPCGFBDHP CGKFKLNGHMI);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HIPOHBFLNII(BONPCGFBDHP CGKFKLNGHMI);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JJBHEIOHDHG(BONPCGFBDHP CGKFKLNGHMI);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GPALDHPDKHF(MEONJBAFIMN NKLEJPMJNHG, bool ODHGHOOKBIP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface BAJCMGCAKKA : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MLGGMMEEEOI();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMGPHHLKCLP();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface DLDHADAOENG : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus EMLELPPAGFG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HJLLNMHDGOG(MAHIACGDFOP CKOBKCKDHJE, HPMGAEEGDBP KAMAEGACMCK, CancellationToken GKJHCAJJFHD);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class HMMLHEAMAKL
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x69545D0", Offset = "0x6952FD0", VA = "0x1869545D0")]
	public static bool BFOJLGICMHF(this DLDHADAOENG HPODGLAMDJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task AMNFGMMIBKI(GCGKJJGGALM GOGGOGGMFEP, CancellationToken AIDIDMJCFEK);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface IAKLJLPCOPP : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBAODIHPLEE(AMNFGMMIBKI OEFJPABOJMB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface JAPLGPCNONK : IOEHFMEGOFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken EMFAKBMEHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	ICKBMMGCCPN BKLGPGPAEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	IOMAPACFCCK NFJKKJBLDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	POGNPHAFADJ FEGDOAKLFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	KLGILBCOHEN KHOMGDACNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	MPLKMCGCGNJ JONFKHHFPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ONBMKGDFMKN LIEBJDHAEIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	ABNKKKHFDML DKEJEFEOAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BPMFCGNIGPG KAGGHFCFGDN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	MIGIELKEKKG IAFIJEKPMND
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	GKMNFCBMKNB NGMNLOFGKMO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	IFMIMGIKGIJ BCMCGCKDPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	BAJCMGCAKKA CIHKIALKPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	DLDHADAOENG GMGMLNHNPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IAKLJLPCOPP NPOLAEKIBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KOLOJFFMEKM LLMDAJAMFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CJDJAOFHDOA JKADBBBHJDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MAPOPECPHFA FNOBMPJINDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IMCCECFKKHD AIKMCKNKKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GCBIOEBLHPD HHHMJPPFMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	FNBGDPLDFNK JMFGHBNPAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	OHKNPDCDGPO MCPFBDCDKFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FPKEDFFNAIL ALCEFGIAOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	IFHLIOAEPHH FIPICBMAKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	LEBCHGAEFNO PLGCNDJPAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	GLLACCLJKBN IAACFPJEBKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	GBCIGNIOONC IBOCJOCHCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	MMJNMPOMFBE DFLDBFHFECC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	LAKPEJNKEPP COACANCLGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	PCGPBKPEHGB ABEPKBECEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	BNGOFEFEHPO BJALIABIMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	NNHMMGMJOPG GNHIPCHGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HDMMHCKBMHJ(HPMGAEEGDBP LMFOHJDEDAO);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface KOLOJFFMEKM : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBPOBKJJAGP BIPEDCDHLGG(Guid ALJDBMFHGKI);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MDELFCPLFEE(Guid ALJDBMFHGKI);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FLHOKBCLKLE(Guid ALJDBMFHGKI, Task EBONHAFHIIJ);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GGOONBDPLMF(Guid ALJDBMFHGKI, OEGBNAHMNGM DKKNLPDGJIB);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(OEGBNAHMNGM, Task)> EMDLBNBFIAN(Guid ALJDBMFHGKI);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface MAFNFMHIBPB : AGBFFJHKJLE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface CJDJAOFHDOA : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALBONAKIIBC(MGKFLOLLHJM CPPFNMDMGHI);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAOLPBAOJGO(MGKFLOLLHJM CPPFNMDMGHI);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<BALIOJOPJGB> KHJOOIKELEH(CancellationToken PNEMGKHGPHL);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface MAPOPECPHFA : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBPOBKJJAGP FHJOILMMHIM(MGKFLOLLHJM HMMKMPAJDJI);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAKGDMBDNNF(Guid ALJDBMFHGKI, Task EBONHAFHIIJ);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface IMCCECFKKHD : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OEGBNAHMNGM> AIKMCKNKKOG(MGKFLOLLHJM LFBGOIPNMIA);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface GCBIOEBLHPD : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EOCBFNOLIGO> DDENBNCJKGI(MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, MAHIACGDFOP CKOBKCKDHJE, CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface OHKNPDCDGPO : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEGBNAHMNGM AJONMIOJECB(HOPBKANDJCK IOIKPEDHBNF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DDGBGEABGDB(string NBJNGHHJOKO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface FNBGDPLDFNK : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MGKFLOLLHJM> MAKMDENODJE(MGKFLOLLHJM ELBMMMMNOAO, EGMIDFNMIDN NNNJKJBABFH, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MGKFLOLLHJM> FDMEIKHMDEN(CancellationToken CFAFANOFDNJ, EGMIDFNMIDN NNNJKJBABFH);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FBDPEEPOBOM LHDLPOBKJHM(EIPPLJBOIII PKPDAIEELNI, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FBDPEEPOBOM AFLMJIKJGPP(EIPPLJBOIII PKPDAIEELNI, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface FPKEDFFNAIL : AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEGBNAHMNGM KBKPGGIOHMD(HOPBKANDJCK IOIKPEDHBNF, BALIOJOPJGB OMAMGNFAJIN);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OEGBNAHMNGM OEDOHGLFNPB(HOPBKANDJCK PCKPENJDOOE);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface IFHLIOAEPHH
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPHJKFGEIOI(JKGGCDOHFAN HKGBIJNCFJG);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELHGMNIMIFM(JKGGCDOHFAN HKGBIJNCFJG);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCMCEICMAFF(JKGGCDOHFAN HKGBIJNCFJG);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPBJKMLCBGI(JKGGCDOHFAN HKGBIJNCFJG);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class JKGGCDOHFAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly MAHIACGDFOP BKCBJPEMNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> NODKFCHAOAD;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public MJHALEONFCB<string> HPOGNNEKCIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AB0", Offset = "0x7C34B0", VA = "0x1807C4AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public JKGGCDOHFAN(MAHIACGDFOP GEGNACPKGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x69571B0", Offset = "0x6955BB0", VA = "0x1869571B0")]
	public JKGGCDOHFAN KLGHDJEKAIB(string KLDFLAABJKH, string AEJBOLFACJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6957280", Offset = "0x6955C80", VA = "0x186957280")]
	public bool NHBLGHNPMJN([Out] IEnumerable<KeyValuePair<string, string>> FICACAJHCJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5C60A30", Offset = "0x5C5F430", VA = "0x185C60A30")]
	public JKGGCDOHFAN KLIAJKFNFOB(MJHALEONFCB<string> MDGFMJGBLAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MMJNMPOMFBE
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool IGLBMFGHELI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string BHHJMIFCDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool DKABBGMAMJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBBOHCCPNFC();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NNLENFFGLDP BEJGOODKEEL(long LPGMBLOCNFN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FGJDKPICNHD<JAPDNPEKOGE, NHPAEOGMHIC> MDDIIBOMJDE(long LPGMBLOCNFN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FGJDKPICNHD<JAPDNPEKOGE, KDPHGEEOLAK> GFCDEKKAPIE(long LPGMBLOCNFN);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FGJDKPICNHD<long, JDCCNMIHMFO> KKJINACDHFA();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KHHFPACNHHF(long LPGMBLOCNFN, [Out] bool LLOBAGAAIAG);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> EPNGKBLKEEB(byte[] AOFALACDKEP, byte[] GPDJPBDMFGA, CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface IOEHFMEGOFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool BFOJLGICMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool HPGBLBAAGKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	HPMGAEEGDBP PLIJGMGFHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action NPOJAJGBLNE;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CJBDDEBCMOB EIPDEENCGLD;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event CJBDDEBCMOB MFEGIFGGDNF;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CJBDDEBCMOB DBFGHKOFGKJ;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MEONJBAFIMN, bool> MADDHLELLNL;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PMGPHHLKCLP();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OGBLJDCIPEO AMDNECLIIIA();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EDEGKJMPPHO FHIOLAGCJOD();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<OEGBNAHMNGM> PCPGKGCIPPH(JDLHDFPPGKG AJKANDNNPCH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task KJLBNJFADBL(CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MPLKMCGCGNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool BGBAMJNMPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string NABCGIHCAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGDLKHKIJFK(Scene CBJFOEKMKBC);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task GGCGGGKPMIL(GFJPKGGMHGH OAEBODGFGJD, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task GABJEEJCIOC();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface KLGILBCOHEN
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	GLMLMHBFNJA BEHNCOLJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool GOEBFPINNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool HDNHNFIOEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool CKLFPLMNIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool ALLGIDKKBBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int JHGCOBDOPDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool HFCJCHEKCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool HHJBBCJGEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool PNGEGJODJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float JPOHBNCHBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> GOJAJDHIKGA;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ICKBMMGCCPN PAOCLPOHKMF(ICKBMMGCCPN BILADBMKLJB);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMMKCNIANDE(ICKBMMGCCPN NFHEIBLLDGM);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGGHCAMCKKM();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task KOPEPLCACNH(MJHALEONFCB<string>.KDBHCAJIBOE DLMHPHNAACJ, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EDEBNPIFOFI(float BICDHPDCJLI);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FKIDJGBIBEK(string ECJOJOJJMHE);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<CLHNECDKFDA> JGPOIIKGBCI();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable DHNDMLPAFOO(object JGGBEOJAHKH, CLHNECDKFDA GFPBCIDAAJJ);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NHPAEOGMHIC MPMEIEEDJGA(IEnumerable<FDEHGBEEAOL> GCHIFBBPLCJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ONDJIMFCONI(int PEJCBFELECM);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task HGGHPHCMJDH();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HPENKOFJFDG();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool JOHCOCLKFGD();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task IDDBMLAPPGM(CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task NLBCOICDEKN(CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<GCDMMOKIENH> NINFIKCGEND(DateTime PBBEEFHNKAI, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> EJDMDCDHCED(CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GECFELBDBCD(string CPPFNMDMGHI = "", float OFHNGFGJDFD = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	JKOBHJMJPAM BNBGOEDIFGN(MKGDDLJDIFL DHGKOEPPPHJ, ICOEHIAPCIG MJEFFKJFELK, KDPHGEEOLAK BFMOIEBGPOC, IEnumerable<PersistenceView> LGEPIAIAADL, NANAAMEDNBI OKIGHOOKCMM);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void BADJJLPIHMN(KDPHGEEOLAK BFMOIEBGPOC);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HDANGEPLMBL(FDEHGBEEAOL FLLKCMLDGED, [In] JKOBHJMJPAM NCCBOPOFNBM);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task BALLGAAJPJN(KDPHGEEOLAK DPKLBICFCOA, bool LCMIOKEADDO, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task FFBIANBCJCP(CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FDLGHCNDGNP(long ECEDKLNOLLD, long ADPGIJLEEII, ECLKAFGMDKO CCHMHHHHDAL, NCDAEICGONM HLOHENCEKEO, NIPEHLMICJG BADNOCAELMA, NDGDGDKEFLE? BGJPIGKNAII, LICAEKIJOKL? PMFOHNPJOKD);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KHONAIPGHFN(long ECEDKLNOLLD, long ADPGIJLEEII, LICAEKIJOKL? PMFOHNPJOKD);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void NFNPBCFCNEB(PersistenceView IICHOPHNELA);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool BGAMHGGBPGM(PersistenceView DHIMBMLHLMD);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool BDLPFEFLKCC(FDEHGBEEAOL FLLKCMLDGED, HGKEIGHFNGL EPDNODJAAHE, [Out] CGAOGEOADJD AFPBGKCEIAM);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task AKFAIJKFNAO(CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void FJEEKBLLCGG();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable FOLECCNNLOK();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void FMLOLNCHJDH(KDPHGEEOLAK DPKLBICFCOA, HGKEIGHFNGL EPDNODJAAHE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> GLOLCAKHKMO(IOMAPACFCCK LKKONKMIDFE, CancellationToken CFAFANOFDNJ, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void HLAMNKJOJJL(CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<GAGPEDFBJMI> BFNFPOELCAB(FCLHOFABEKJ ELBMMMMNOAO);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<ECLKAFGMDKO> AJPPFAAOHIM(long ECEDKLNOLLD, bool DEHJJCPOFBG, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<NCDAEICGONM> FMPOEEKPJBD(long ECEDKLNOLLD, long ADPGIJLEEII, long BFEHPMILDEK, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<GLADOECGKEJ> CJEDEHMMLCP(string AJFKAGKBLBA, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<GLADOECGKEJ> BPINLPKOFIL(string AJFKAGKBLBA, long ECEDKLNOLLD, long ADPGIJLEEII, string BJOJEPMOEAN, FOBJMBBFLPL.FCHLCGPHOBO GOGGOGGMFEP, FOBJMBBFLPL.FCHLCGPHOBO GPDJPBDMFGA, int PGELEHPHLNL);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool OGBODFKAOKB();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool LGJBKGMAOLL();

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool FEOBEBDNHPN(IEnumerable<CGAOGEOADJD> POCHFGLPKBB);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CCBAHIIJCGJ(List<GameObject> PFBKOHEEBBJ);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float CMDDCAFNBLN();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task<Scene> COKMGMEABND(string IFLAEGGFFAG, LoadSceneMode DHILFLAHDEI, bool OMGBODGDKGE, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void KNOFPDLPHJI();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void LPGDNMOOJDN(bool IHFMNOOBPFC);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void BIEPNNFGHEM(MAHIACGDFOP NLMHGBDJOEJ);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task KDBHMBDHOAO(MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task MALABMMABGN(MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "62")]
	Task PBIMJAOLCFB(MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "63")]
	IDisposable EDDJPIJMMCN();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "64")]
	AKNHJFEHBBJ BKHDLDOPHED();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "65")]
	Task PONIACLFPKF(CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface AKNHJFEHBBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CBLBCLDMKAE(CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NINKMEGKNCG(CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct JKOBHJMJPAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> FCDOCFFFICB;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum GCDMMOKIENH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct MKGDDLJDIFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string PIIECDDEKPE;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface GLMLMHBFNJA
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	MAHIACGDFOP EFPMEHOFNMG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	ECLKAFGMDKO NHCDNOAMMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	LIDLODHMGJG DEFKFFEFHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool OAPJJHALLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool KMCFINOCPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	int FJCLAFJNNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action FJCEGANDIDK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> BFKPEFDLGKM;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LDIBFJAODBC();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.JOGKOCOAIIO> NJMCLEOCJMI(long LPGMBLOCNFN, [Optional] CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<HGCFKHAEPKO> CIIGGMNOFOF();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task OBBNFJDBLAO();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(MAHIACGDFOP, HPMGAEEGDBP) MEEFGMMKEAN();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GABCKPOPJNO PBPFFEECIBK();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PDCOKDGHLDD(long LPGMBLOCNFN);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface LEBCHGAEFNO
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDANBCDEDBF([Out] IEnumerable<int> AJBEEIPFKJF);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIKLHKGBOCC(JIIANIOJCIN AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJOGBOKPCED(JIIANIOJCIN AIDIDMJCFEK);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface ICHPHKAHMBL
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FIHJHBDKCHB(OEGBNAHMNGM IGLBDPPIJLH);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface AOCEHHDJPBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJOKGPOABLC(NLMLFBHFNPG.MDJOPAOFDEN LMDMIPCOLGI);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHLKJELFNEL(NLMLFBHFNPG.MDJOPAOFDEN LMDMIPCOLGI);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface ONBMKGDFMKN : AOCEHHDJPBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEGBNAHMNGM LCOBMGAINDP(HOPBKANDJCK PCKPENJDOOE);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface ABNKKKHFDML : AOCEHHDJPBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEGBNAHMNGM AJONMIOJECB(HOPBKANDJCK JJDFAIKPBCK);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface NNLENFFGLDP
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LGGHGMLBJFM<GFJPKGGMHGH, LJNADPDGEHJ>> PKJEIJCMNFB(string BJOJEPMOEAN, long LPGMBLOCNFN, long? ECEDKLNOLLD, long? ADPGIJLEEII, CLKLNCPJFIK.IDMCFGPNMIA HHGDHAOMDNJ, CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface FGJDKPICNHD<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LGGHGMLBJFM<LICINJCGCBN<TData>, LJNADPDGEHJ>> EGIIMHHKAMC(TGetDataArg CMMMKFHDFNK, CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class PJLBGJMOKCI : JAPLGPCNONK, IOEHFMEGOFB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct MODOCHCAPDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<OEGBNAHMNGM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public PJLBGJMOKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public JDLHDFPPGKG autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<OEGBNAHMNGM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x695FB00", Offset = "0x695E500", VA = "0x18695FB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x695FD80", Offset = "0x695E780", VA = "0x18695FD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct AMECCPAFGJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public PJLBGJMOKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x694C290", Offset = "0x694AC90", VA = "0x18694C290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x694C4C0", Offset = "0x694AEC0", VA = "0x18694C4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class EFMOJKJJAPL : IEnumerable<AGBFFJHKJLE>, IEnumerable, IEnumerator<AGBFFJHKJLE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private AGBFFJHKJLE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public PJLBGJMOKCI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private AGBFFJHKJLE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x820E60", Offset = "0x81F860", VA = "0x180820E60")]
		[DebuggerHidden]
		public EFMOJKJJAPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x694FF60", Offset = "0x694E960", VA = "0x18694FF60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x69503C0", Offset = "0x694EDC0", VA = "0x1869503C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6950310", Offset = "0x694ED10", VA = "0x186950310", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AGBFFJHKJLE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6950310", Offset = "0x694ED10", VA = "0x186950310", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource ANMDBMHDJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly ICKBMMGCCPN NFHEIBLLDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool ODKMMAOGKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private KHDPCHHMIDM IBMNAIIBOBO;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public IOMAPACFCCK NFJKKJBLDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C10", Offset = "0x7C8610", VA = "0x1807C9C10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C9AE0", Offset = "0x7C84E0", VA = "0x1807C9AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public POGNPHAFADJ FEGDOAKLFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7C6940", Offset = "0x7C5340", VA = "0x1807C6940", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7C6950", Offset = "0x7C5350", VA = "0x1807C6950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public KLGILBCOHEN KHOMGDACNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7C6930", Offset = "0x7C5330", VA = "0x1807C6930", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7C6910", Offset = "0x7C5310", VA = "0x1807C6910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public MPLKMCGCGNJ JONFKHHFPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7C6960", Offset = "0x7C5360", VA = "0x1807C6960", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7C68E0", Offset = "0x7C52E0", VA = "0x1807C68E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public ONBMKGDFMKN LIEBJDHAEIF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7C6920", Offset = "0x7C5320", VA = "0x1807C6920", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7C68F0", Offset = "0x7C52F0", VA = "0x1807C68F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public ABNKKKHFDML DKEJEFEOAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7C68D0", Offset = "0x7C52D0", VA = "0x1807C68D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7C6900", Offset = "0x7C5300", VA = "0x1807C6900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public BPMFCGNIGPG KAGGHFCFGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7CF990", Offset = "0x7CE390", VA = "0x1807CF990", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA00", Offset = "0x7CE400", VA = "0x1807CFA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public MIGIELKEKKG IAFIJEKPMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7CF950", Offset = "0x7CE350", VA = "0x1807CF950", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA20", Offset = "0x7CE420", VA = "0x1807CFA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public GKMNFCBMKNB NGMNLOFGKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA10", Offset = "0x7CE410", VA = "0x1807CFA10", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7CF970", Offset = "0x7CE370", VA = "0x1807CF970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public IFMIMGIKGIJ BCMCGCKDPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x91E190", Offset = "0x91CB90", VA = "0x18091E190", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5A0", Offset = "0x9ADFA0", VA = "0x1809AF5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public BAJCMGCAKKA CIHKIALKPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8B0", Offset = "0x7CE2B0", VA = "0x1807CF8B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9A0", Offset = "0x7CE3A0", VA = "0x1807CF9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public DLDHADAOENG GMGMLNHNPLO
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE850", Offset = "0x8AD250", VA = "0x1808AE850", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x88B860", Offset = "0x88A260", VA = "0x18088B860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public IAKLJLPCOPP NPOLAEKIBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7CD490", Offset = "0x7CBE90", VA = "0x1807CD490", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3E0", Offset = "0x7CBDE0", VA = "0x1807CD3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public KOLOJFFMEKM LLMDAJAMFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA39B50", Offset = "0xA38550", VA = "0x180A39B50", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA41A80", Offset = "0xA40480", VA = "0x180A41A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public MAFNFMHIBPB EODMJCMHPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x99E820", Offset = "0x99D220", VA = "0x18099E820", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x99E830", Offset = "0x99D230", VA = "0x18099E830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public CJDJAOFHDOA JKADBBBHJDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9C5690", Offset = "0x9C4090", VA = "0x1809C5690", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA41A20", Offset = "0xA40420", VA = "0x180A41A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public MAPOPECPHFA FNOBMPJINDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8F13A0", Offset = "0x8EFDA0", VA = "0x1808F13A0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA41AC0", Offset = "0xA404C0", VA = "0x180A41AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public IMCCECFKKHD AIKMCKNKKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x985BC0", Offset = "0x9845C0", VA = "0x180985BC0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x985D30", Offset = "0x984730", VA = "0x180985D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public GCBIOEBLHPD HHHMJPPFMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7CD440", Offset = "0x7CBE40", VA = "0x1807CD440", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7CD400", Offset = "0x7CBE00", VA = "0x1807CD400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public FNBGDPLDFNK JMFGHBNPAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x88CDF0", Offset = "0x88B7F0", VA = "0x18088CDF0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x889F70", Offset = "0x888970", VA = "0x180889F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public OHKNPDCDGPO MCPFBDCDKFN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8F6C00", Offset = "0x8F5600", VA = "0x1808F6C00", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8F6C10", Offset = "0x8F5610", VA = "0x1808F6C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FPKEDFFNAIL ALCEFGIAOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9C59F0", Offset = "0x9C43F0", VA = "0x1809C59F0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA41AA0", Offset = "0xA404A0", VA = "0x180A41AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public IFHLIOAEPHH FIPICBMAKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x88CEA0", Offset = "0x88B8A0", VA = "0x18088CEA0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x88A220", Offset = "0x888C20", VA = "0x18088A220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public LEBCHGAEFNO PLGCNDJPAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9C4780", Offset = "0x9C3180", VA = "0x1809C4780", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA41A60", Offset = "0xA40460", VA = "0x180A41A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GLLACCLJKBN IAACFPJEBKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9C4790", Offset = "0x9C3190", VA = "0x1809C4790", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA41C40", Offset = "0xA40640", VA = "0x180A41C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public GBCIGNIOONC IBOCJOCHCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x90D7E0", Offset = "0x90C1E0", VA = "0x18090D7E0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA41C20", Offset = "0xA40620", VA = "0x180A41C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public MMJNMPOMFBE DFLDBFHFECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x891580", Offset = "0x88FF80", VA = "0x180891580", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA41B80", Offset = "0xA40580", VA = "0x180A41B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public LAKPEJNKEPP COACANCLGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x985C00", Offset = "0x984600", VA = "0x180985C00", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public PCGPBKPEHGB ABEPKBECEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x90D800", Offset = "0x90C200", VA = "0x18090D800", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public BNGOFEFEHPO BJALIABIMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x90D7F0", Offset = "0x90C1F0", VA = "0x18090D7F0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public NNHMMGMJOPG GNHIPCHGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9C4380", Offset = "0x9C2D80", VA = "0x1809C4380", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public HPMGAEEGDBP PLIJGMGFHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9C48A0", Offset = "0x9C32A0", VA = "0x1809C48A0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9BAAE0", Offset = "0x9B94E0", VA = "0x1809BAAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private bool DLAGMALBHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x69684C0", Offset = "0x6966EC0", VA = "0x1869684C0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private bool KNJADNHABHD
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6968640", Offset = "0x6967040", VA = "0x186968640", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private CancellationToken IPMJGFKHFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x69686C0", Offset = "0x69670C0", VA = "0x1869686C0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private ICKBMMGCCPN JKOGDABMMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action GJOMHIKLAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x69685E0", Offset = "0x6966FE0", VA = "0x1869685E0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6968520", Offset = "0x6966F20", VA = "0x186968520", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event CJBDDEBCMOB KFHHHBEJBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6968960", Offset = "0x6967360", VA = "0x186968960", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6968790", Offset = "0x6967190", VA = "0x186968790", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event CJBDDEBCMOB HFLFACAGLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6967F50", Offset = "0x6966950", VA = "0x186967F50", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6968010", Offset = "0x6966A10", VA = "0x186968010", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event CJBDDEBCMOB HJEKCGFLBPB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6968900", Offset = "0x6967300", VA = "0x186968900", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x69681D0", Offset = "0x6966BD0", VA = "0x1869681D0", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<MEONJBAFIMN, bool> HDHODLDPGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x69683D0", Offset = "0x6966DD0", VA = "0x1869683D0", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6967FB0", Offset = "0x69669B0", VA = "0x186967FB0", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x9BAAE0", Offset = "0x9B94E0", VA = "0x1809BAAE0", Slot = "36")]
	public void HDMMHCKBMHJ(HPMGAEEGDBP LMFOHJDEDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x69689C0", Offset = "0x69673C0", VA = "0x1869689C0")]
	[UnityEngine.Scripting.Preserve]
	internal PJLBGJMOKCI([JDJLHBHAJCP(null)] ICKBMMGCCPN NFHEIBLLDGM, [JDJLHBHAJCP(null)] IOMAPACFCCK LKKONKMIDFE, [JDJLHBHAJCP(null)] POGNPHAFADJ FCHOOACIBJA, [JDJLHBHAJCP(null)] KLGILBCOHEN NJALJHMFPEI, [JDJLHBHAJCP(null)] MPLKMCGCGNJ HMJAKINEGCM, [JDJLHBHAJCP(null)] ONBMKGDFMKN HGKKHHJFMOK, [JDJLHBHAJCP(null)] ABNKKKHFDML EIBGOHABNCD, [JDJLHBHAJCP(null)] BPMFCGNIGPG HJBINPJGJEE, [JDJLHBHAJCP(null)] MIGIELKEKKG HHAPLFHDKON, [JDJLHBHAJCP(null)] GKMNFCBMKNB BEGEDIAJGJC, [JDJLHBHAJCP(null)] IFMIMGIKGIJ GFKFCFMECNF, [JDJLHBHAJCP(null)] BAJCMGCAKKA NDNKFHOBGFH, [JDJLHBHAJCP(null)] DLDHADAOENG HPODGLAMDJA, [JDJLHBHAJCP(null)] IAKLJLPCOPP COIIPBLBCCE, [JDJLHBHAJCP(null)] KOLOJFFMEKM BMGHGJOEFCL, [JDJLHBHAJCP(null)] MAFNFMHIBPB AMKBMALNFOB, [JDJLHBHAJCP(null)] CJDJAOFHDOA MMBEODDLFAE, [JDJLHBHAJCP(null)] MAPOPECPHFA JLONPFKBPFK, [JDJLHBHAJCP(null)] IMCCECFKKHD DIGLPPAOJEC, [JDJLHBHAJCP(null)] GCBIOEBLHPD EFLDGKHDHAK, [JDJLHBHAJCP(null)] OHKNPDCDGPO NPLNDALCBED, [JDJLHBHAJCP(null)] FNBGDPLDFNK FPBOAHDDPOA, [JDJLHBHAJCP(null)] FPKEDFFNAIL IEOKJMBPJFB, [JDJLHBHAJCP(null)] IFHLIOAEPHH ECEGOCNJHNO, [JDJLHBHAJCP(null)] LEBCHGAEFNO PHNFMPFOBJH, [JDJLHBHAJCP(null)] GBCIGNIOONC FAKHGNGCNKM, [JDJLHBHAJCP(null)] MMJNMPOMFBE PNKAICMGCIH, [JDJLHBHAJCP(null)] LAKPEJNKEPP CEKOOIGICFE, [JDJLHBHAJCP(null)] PCGPBKPEHGB CCDBNHHLCIJ, [JDJLHBHAJCP(null)] BNGOFEFEHPO OINDEMFPBME, [JDJLHBHAJCP(null)] NNHMMGMJOPG PEHEGKKHHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x69686E0", Offset = "0x69670E0", VA = "0x1869686E0")]
	private void MPOMBMILLLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6968230", Offset = "0x6966C30", VA = "0x186968230", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6968180", Offset = "0x6966B80", VA = "0x186968180", Slot = "49")]
	private void DGLMFLEPHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6968070", Offset = "0x6966A70", VA = "0x186968070", Slot = "50")]
	private OGBLJDCIPEO CIAKECPOAHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6968430", Offset = "0x6966E30", VA = "0x186968430", Slot = "51")]
	private EDEGKJMPPHO FFAPPFILIKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x69687F0", Offset = "0x69671F0", VA = "0x1869687F0", Slot = "52")]
	[AsyncStateMachine(typeof(MODOCHCAPDL))]
	private Task<OEGBNAHMNGM> PGLHOHOJGAF(JDLHDFPPGKG CAKGNCPACEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6967E60", Offset = "0x6966860", VA = "0x186967E60", Slot = "53")]
	[AsyncStateMachine(typeof(AMECCPAFGJD))]
	private Task ANBLFLOMNNH(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6968100", Offset = "0x6966B00", VA = "0x186968100")]
	[IteratorStateMachine(typeof(EFMOJKJJAPL))]
	private IEnumerable<AGBFFJHKJLE> CKBEILAKCGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6968580", Offset = "0x6966F80", VA = "0x186968580")]
	[CompilerGenerated]
	private void KDHINOCGABO(AGBFFJHKJLE KLKCJLEHBJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DGJKGLLGBKE : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0xDCA990", Offset = "0xDC9390", VA = "0x180DCA990")]
	public DGJKGLLGBKE(string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class PHDAJPLKNEJ : FIFKCHFEOPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct BMPNHOKCBFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public PHDAJPLKNEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x694D5A0", Offset = "0x694BFA0", VA = "0x18694D5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x694D8E0", Offset = "0x694C2E0", VA = "0x18694D8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly KLGILBCOHEN NJALJHMFPEI;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D18F0", Offset = "0x7D02F0", VA = "0x1807D18F0")]
	public PHDAJPLKNEJ(JAPLGPCNONK JKFKIODGCMA, KLGILBCOHEN NJALJHMFPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6967B10", Offset = "0x6966510", VA = "0x186967B10", Slot = "4")]
	[AsyncStateMachine(typeof(BMPNHOKCBFD))]
	public Task<bool> INFNMKEGECE(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6967A30", Offset = "0x6966430", VA = "0x186967A30")]
	[CompilerGenerated]
	private object AIIGLDKICGO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class PIFDDDOJKHM : FIFKCHFEOPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct OLDAEPNMMOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public PIFDDDOJKHM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6965CF0", Offset = "0x69646F0", VA = "0x186965CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6966400", Offset = "0x6964E00", VA = "0x186966400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly KLGILBCOHEN NJALJHMFPEI;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private GLMLMHBFNJA BEHNCOLJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6967E10", Offset = "0x6966810", VA = "0x186967E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D18F0", Offset = "0x7D02F0", VA = "0x1807D18F0")]
	public PIFDDDOJKHM(JAPLGPCNONK JKFKIODGCMA, KLGILBCOHEN NJALJHMFPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6967CE0", Offset = "0x69666E0", VA = "0x186967CE0", Slot = "4")]
	[AsyncStateMachine(typeof(OLDAEPNMMOE))]
	public Task<bool> INFNMKEGECE(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6967C00", Offset = "0x6966600", VA = "0x186967C00")]
	[CompilerGenerated]
	private object GGPMLNFGKEO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class PELHKODJKJL : FIFKCHFEOPL
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class DDONICOAPJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public PELHKODJKJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public HGCFKHAEPKO result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public MAHIACGDFOP newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public DDONICOAPJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x694EEE0", Offset = "0x694D8E0", VA = "0x18694EEE0")]
		internal object ANCMMIDEDLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x694EFD0", Offset = "0x694D9D0", VA = "0x18694EFD0")]
		internal object DKGEPHLAGIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694DA40", VA = "0x18694F040")]
		internal object PJMHKDKJCMD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct GEPBKECDJHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public PELHKODJKJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private DDONICOAPJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<HGCFKHAEPKO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6953530", Offset = "0x6951F30", VA = "0x186953530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6953E60", Offset = "0x6952860", VA = "0x186953E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly KLGILBCOHEN NJALJHMFPEI;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private GLMLMHBFNJA BEHNCOLJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x69679E0", Offset = "0x69663E0", VA = "0x1869679E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D18F0", Offset = "0x7D02F0", VA = "0x1807D18F0")]
	public PELHKODJKJL(JAPLGPCNONK JKFKIODGCMA, KLGILBCOHEN NJALJHMFPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x69678C0", Offset = "0x69662C0", VA = "0x1869678C0", Slot = "4")]
	[AsyncStateMachine(typeof(GEPBKECDJHO))]
	public Task<bool> INFNMKEGECE(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface FIFKCHFEOPL
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> INFNMKEGECE(CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct ACIPPFDEMNF
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class BCLIJPEBCMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public JAPLGPCNONK manager;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BCLIJPEBCMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x694D550", Offset = "0x694BF50", VA = "0x18694D550")]
		internal Task DDINOJPKKFC(GCGKJJGGALM data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct AEAKPOEEBLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public ACIPPFDEMNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private JDLHDFPPGKG <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<GCDMMOKIENH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<OEGBNAHMNGM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x694BC90", Offset = "0x694A690", VA = "0x18694BC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x694C220", Offset = "0x694AC20", VA = "0x18694C220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct PKPGMMCOCOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public ACIPPFDEMNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6968E20", Offset = "0x6967820", VA = "0x186968E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6969140", Offset = "0x6967B40", VA = "0x186969140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CancellationToken CFAFANOFDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly JAPLGPCNONK KEKOHNJFKFJ;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private IOMAPACFCCK NFJKKJBLDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x694B5A0", Offset = "0x6949FA0", VA = "0x18694B5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private KLGILBCOHEN KHOMGDACNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x694B550", Offset = "0x6949F50", VA = "0x18694B550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private GLMLMHBFNJA BEHNCOLJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x694BC10", Offset = "0x694A610", VA = "0x18694BC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private GKMNFCBMKNB NGMNLOFGKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x694BBC0", Offset = "0x694A5C0", VA = "0x18694BBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E7C870", Offset = "0x1E7B270", VA = "0x181E7C870")]
	public ACIPPFDEMNF(CancellationToken CFAFANOFDNJ, JAPLGPCNONK KEKOHNJFKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x694B7F0", Offset = "0x694A1F0", VA = "0x18694B7F0")]
	public static AMNFGMMIBKI INFCGCGOLEB(JAPLGPCNONK KEKOHNJFKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x694B8A0", Offset = "0x694A2A0", VA = "0x18694B8A0")]
	[AsyncStateMachine(typeof(AEAKPOEEBLN))]
	public Task<bool> JGEDHJJKDOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x694B9B0", Offset = "0x694A3B0", VA = "0x18694B9B0")]
	private bool KCCNILPMPMH([Out] JDLHDFPPGKG CAKGNCPACEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x694B720", Offset = "0x694A120", VA = "0x18694B720")]
	[AsyncStateMachine(typeof(PKPGMMCOCOM))]
	private Task HPCMEGFBGPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x694B5F0", Offset = "0x6949FF0", VA = "0x18694B5F0")]
	private Task<GCDMMOKIENH> FEPDBKPEBHD(JDLHDFPPGKG GEEOLFGPPGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct DBPOBKJJAGP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly KOLOJFFMEKM BMGHGJOEFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Guid ALJDBMFHGKI;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private Task<(OEGBNAHMNGM, Task)> JNOGGHFAPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x694E7C0", Offset = "0x694D1C0", VA = "0x18694E7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3E02350", Offset = "0x3E00D50", VA = "0x183E02350")]
	public DBPOBKJJAGP(KOLOJFFMEKM BMGHGJOEFCL, Guid ALJDBMFHGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x694E960", Offset = "0x694D360", VA = "0x18694E960")]
	public TaskAwaiter<(OEGBNAHMNGM, Task)> MKCIAKANKGF()
	{
		return default(TaskAwaiter<(OEGBNAHMNGM, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x694E890", Offset = "0x694D290", VA = "0x18694E890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct MHANNGNFCLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly TaskCompletionSource<(OEGBNAHMNGM, Task)> KFEFIPLAEGA;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Task<(OEGBNAHMNGM, Task)> JNOGGHFAPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x695E0D0", Offset = "0x695CAD0", VA = "0x18695E0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x695E2D0", Offset = "0x695CCD0", VA = "0x18695E2D0")]
	public MHANNGNFCLK(TimeSpan CBKBNMKLFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x695E1A0", Offset = "0x695CBA0", VA = "0x18695E1A0")]
	public void GDMMPIDHNFH(Task EBONHAFHIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x695E110", Offset = "0x695CB10", VA = "0x18695E110")]
	public void GAKHOEDFJMB(OEGBNAHMNGM IGLBDPPIJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x695E080", Offset = "0x695CA80", VA = "0x18695E080")]
	public void BOMHEOBDFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x695E240", Offset = "0x695CC40", VA = "0x18695E240")]
	internal void KAPCMPEPHMD(string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class ICBCDFFJMCC
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class FOAHEFKFAJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public NCDAEICGONM subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public FOAHEFKFAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6953500", Offset = "0x6951F00", VA = "0x186953500")]
		internal bool FDIKEICNGAD(LIDLODHMGJG s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6954AA0", Offset = "0x69534A0", VA = "0x186954AA0")]
	public static EOCBFNOLIGO HGOBECNKDLP(long KFKBGLGDOAB, long ADPGIJLEEII, string AJFKAGKBLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6954850", Offset = "0x6953250", VA = "0x186954850")]
	public static EOCBFNOLIGO HGOBECNKDLP(long KFKBGLGDOAB, long ADPGIJLEEII, JAPDNPEKOGE AOFALACDKEP, long BFEHPMILDEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6954910", Offset = "0x6953310", VA = "0x186954910")]
	public static EOCBFNOLIGO HGOBECNKDLP(GAGPEDFBJMI FIMJBIPHPDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6954620", Offset = "0x6953020", VA = "0x186954620")]
	public static EOCBFNOLIGO HGOBECNKDLP(ECLKAFGMDKO EAAAIFJJCKL, NCDAEICGONM HOFIFIGFGCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6954B30", Offset = "0x6953530", VA = "0x186954B30")]
	public static EOCBFNOLIGO KIDICAPLOFP(this EOCBFNOLIGO PEFGDLBLMMP, ECLKAFGMDKO LGLKAIMMPGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6954C20", Offset = "0x6953620", VA = "0x186954C20")]
	public static EOCBFNOLIGO KMNLADOHPIG(this EOCBFNOLIGO PEFGDLBLMMP, NCDAEICGONM GONNNIMHEPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class EIBANEIHKJI : MIGIELKEKKG, AGBFFJHKJLE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct NLKEADFMCHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public EIBANEIHKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6960BF0", Offset = "0x695F5F0", VA = "0x186960BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6961280", Offset = "0x695FC80", VA = "0x186961280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly JIIANIOJCIN MMACGPLBKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private string PICBGCGAGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Task CENNDMGHAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool DJJJCDNBOAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6950600", Offset = "0x694F000", VA = "0x186950600", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Task NOEKGMHOKCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6950570", Offset = "0x694EF70", VA = "0x186950570", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C58F0", Offset = "0x7C42F0", VA = "0x1807C58F0", Slot = "7")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6950410", Offset = "0x694EE10", VA = "0x186950410", Slot = "6")]
	public void CCOEIGDDFHM(Task KPCFMNKKKMJ, string KNFFHCCGONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6950630", Offset = "0x694F030", VA = "0x186950630")]
	[AsyncStateMachine(typeof(NLKEADFMCHJ))]
	private Task JMGKFOJCBAJ(Task OEMCPELFPCO, string KNFFHCCGONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6950750", Offset = "0x694F150", VA = "0x186950750")]
	public EIBANEIHKJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class IGLFLDHBKOF : GLLACCLJKBN, AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool PEFFHNFOELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private CGLEINIGDMO DMFFJMOKGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IOMAPACFCCK LKKONKMIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private GBCIGNIOONC FAKHGNGCNKM;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CGLEINIGDMO BCEBDBHLIDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6954E70", Offset = "0x6953870", VA = "0x186954E70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x69550D0", Offset = "0x6953AD0", VA = "0x1869550D0", Slot = "7")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6954F20", Offset = "0x6953920", VA = "0x186954F20", Slot = "5")]
	public void IPDIPHDPLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6954EE0", Offset = "0x69538E0", VA = "0x186954EE0", Slot = "6")]
	public void POBIEGABLNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6954DB0", Offset = "0x69537B0", VA = "0x186954DB0")]
	private Task CDCJNOIKFCN(IGOFNHPAKMC GCGDEDCNCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6954EE0", Offset = "0x69538E0", VA = "0x186954EE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public IGLFLDHBKOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class MOEHMHFFNDI : GBCIGNIOONC
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class NDGMOHAOKMD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly OBDBJEGPDPJ IHNPOAEFLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly string KLDFLAABJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly T LFANPJOLHJB;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public T DPMGLPAKGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x838CD0", Offset = "0x8376D0", VA = "0x180838CD0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x8AA620", Offset = "0x8A9020", VA = "0x1808AA620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x40C9AA0", Offset = "0x40C84A0", VA = "0x1840C9AA0")]
		public NDGMOHAOKMD(OBDBJEGPDPJ IHNPOAEFLAI, string KLDFLAABJKH, T LFANPJOLHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x40C94B0", Offset = "0x40C7EB0", VA = "0x1840C94B0")]
		private void BDCFLIGADKD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly OBDBJEGPDPJ IHNPOAEFLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly NDGMOHAOKMD<TimeSpan> LFKHIMDHLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly NDGMOHAOKMD<TimeSpan> BCKHKACJDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly NDGMOHAOKMD<TimeSpan> CGFIKLAFFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly NDGMOHAOKMD<TimeSpan> DPMCAAFMHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly NDGMOHAOKMD<bool> BIEEHFEHHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly NDGMOHAOKMD<bool> EPONANPHCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly NDGMOHAOKMD<bool> GBMKBOPPPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly NDGMOHAOKMD<int> GLIKCDKNKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly NDGMOHAOKMD<bool> JDBCGNCHOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly NDGMOHAOKMD<bool> GNFBKNIBOMG;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public TimeSpan MBCEKOFPDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x695FF30", Offset = "0x695E930", VA = "0x18695FF30", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public TimeSpan DFILPENANCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x695FDF0", Offset = "0x695E7F0", VA = "0x18695FDF0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public TimeSpan FKBLIAJNBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6960030", Offset = "0x695EA30", VA = "0x186960030", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TimeSpan JCAGLOKPPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x695FFB0", Offset = "0x695E9B0", VA = "0x18695FFB0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool AMJNGFHOBFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x695FE30", Offset = "0x695E830", VA = "0x18695FE30", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool GKIOCGIIIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x695FEB0", Offset = "0x695E8B0", VA = "0x18695FEB0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool ANFEEGGOEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x695FE70", Offset = "0x695E870", VA = "0x18695FE70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int CPCOPMBHCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x695FF70", Offset = "0x695E970", VA = "0x18695FF70", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool JBMFLIFMKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x695FEF0", Offset = "0x695E8F0", VA = "0x18695FEF0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool OKACNCPHPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x695FFF0", Offset = "0x695E9F0", VA = "0x18695FFF0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6960070", Offset = "0x695EA70", VA = "0x186960070")]
	[UnityEngine.Scripting.Preserve]
	public MOEHMHFFNDI([JDJLHBHAJCP(null)] OBDBJEGPDPJ IHNPOAEFLAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class EJCBCHAOFCC : IFMIMGIKGIJ, AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class MGLPLGJOEHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public BONPCGFBDHP roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public MGLPLGJOEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x695DFA0", Offset = "0x695C9A0", VA = "0x18695DFA0")]
		internal object LFEBCMEAMLB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action NPOJAJGBLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6950D20", Offset = "0x694F720", VA = "0x186950D20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6951110", Offset = "0x694FB10", VA = "0x186951110", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event CJBDDEBCMOB EIPDEENCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x69511B0", Offset = "0x694FBB0", VA = "0x1869511B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6951250", Offset = "0x694FC50", VA = "0x186951250", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event CJBDDEBCMOB MFEGIFGGDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6950E40", Offset = "0x694F840", VA = "0x186950E40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6950A80", Offset = "0x694F480", VA = "0x186950A80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event CJBDDEBCMOB DBFGHKOFGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6950C80", Offset = "0x694F680", VA = "0x186950C80", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x69509E0", Offset = "0x694F3E0", VA = "0x1869509E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<MEONJBAFIMN, bool> MADDHLELLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6950BD0", Offset = "0x694F5D0", VA = "0x186950BD0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6950B20", Offset = "0x694F520", VA = "0x186950B20", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "19")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6950EE0", Offset = "0x694F8E0", VA = "0x186950EE0", Slot = "14")]
	public void IDBIHAHJDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x69509B0", Offset = "0x694F3B0", VA = "0x1869509B0", Slot = "15")]
	public void BDPNOJEFBCA(BONPCGFBDHP CGKFKLNGHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6950E10", Offset = "0x694F810", VA = "0x186950E10", Slot = "16")]
	public void HIPOHBFLNII(BONPCGFBDHP CGKFKLNGHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x69510E0", Offset = "0x694FAE0", VA = "0x1869510E0", Slot = "17")]
	public void JJBHEIOHDHG(BONPCGFBDHP CGKFKLNGHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6950DC0", Offset = "0x694F7C0", VA = "0x186950DC0", Slot = "18")]
	public void GPALDHPDKHF(MEONJBAFIMN NKLEJPMJNHG, bool ODHGHOOKBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x69507E0", Offset = "0x694F1E0", VA = "0x1869507E0")]
	private void BCLHLDBBMGO(CJBDDEBCMOB GFPBCIDAAJJ, BONPCGFBDHP CGKFKLNGHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public EJCBCHAOFCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class IMINCPDMMGN : BAJCMGCAKKA, AGBFFJHKJLE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct LJMLLOPKPJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public IMINCPDMMGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x695D500", Offset = "0x695BF00", VA = "0x18695D500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x695D9E0", Offset = "0x695C3E0", VA = "0x18695D9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct FCMMKOEDLPK : IAsyncStateMachine
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
		public IMINCPDMMGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6951F10", Offset = "0x6950910", VA = "0x186951F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6952570", Offset = "0x6950F70", VA = "0x186952570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class BNGLKLGAECE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BNGLKLGAECE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x694D950", Offset = "0x694C350", VA = "0x18694D950")]
		internal object INGKOPKOLAG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct CIAFGHABIJH : IAsyncStateMachine
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
		public IMINCPDMMGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private BNGLKLGAECE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x694DAD0", Offset = "0x694C4D0", VA = "0x18694DAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x694E220", Offset = "0x694CC20", VA = "0x18694E220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class LANEPDKJGML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public LANEPDKJGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x695D490", Offset = "0x695BE90", VA = "0x18695D490")]
		internal object JPACDGAFMLE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private KLGILBCOHEN NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private FIFKCHFEOPL[] KFLNOMAOIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private CancellationTokenSource NCPJPNOCKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int LHCJHCDOODE;

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6955C70", Offset = "0x6954670", VA = "0x186955C70", Slot = "6")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6955480", Offset = "0x6953E80", VA = "0x186955480", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6955AA0", Offset = "0x69544A0", VA = "0x186955AA0", Slot = "8")]
	public void JPLEEFEBOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6955E20", Offset = "0x6954820", VA = "0x186955E20", Slot = "5")]
	public void PMGPHHLKCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6955BA0", Offset = "0x69545A0", VA = "0x186955BA0", Slot = "4")]
	[AsyncStateMachine(typeof(LJMLLOPKPJG))]
	public Task MLGGMMEEEOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6955790", Offset = "0x6954190", VA = "0x186955790")]
	private void JAOPLGIJCNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6955380", Offset = "0x6953D80", VA = "0x186955380")]
	[AsyncStateMachine(typeof(FCMMKOEDLPK))]
	private Task DLDCHBILDBC(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6955650", Offset = "0x6954050", VA = "0x186955650")]
	[AsyncStateMachine(typeof(CIAFGHABIJH))]
	private Task<bool> GONIPEMFLCB(int ABBNIPHGMGH, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6955490", Offset = "0x6953E90", VA = "0x186955490")]
	private void EMLNMIGKOFP(int ABBNIPHGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6955570", Offset = "0x6953F70", VA = "0x186955570")]
	private void EONJBNEAJIF(int ABBNIPHGMGH, bool ODHGHOOKBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6955CF0", Offset = "0x69546F0", VA = "0x186955CF0")]
	private void NCCPNPKCDEB(int ABBNIPHGMGH, Exception PBPEDJNJMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6955250", Offset = "0x6953C50", VA = "0x186955250")]
	private void CGOCOLAHBCH(CancellationToken CFAFANOFDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public IMINCPDMMGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class NPMDDPNHBKC : DLDHADAOENG, AGBFFJHKJLE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct PMCAPHJAICC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public MAHIACGDFOP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public NPMDDPNHBKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public HPMGAEEGDBP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x69691A0", Offset = "0x6967BA0", VA = "0x1869691A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6969B00", Offset = "0x6968500", VA = "0x186969B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct FBBFNPDCBIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public NPMDDPNHBKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public MAHIACGDFOP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public HPMGAEEGDBP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private MJHALEONFCB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private OCHDPFMCIOG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private EGMIDFNMIDN <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private JKGGCDOHFAN <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x69512F0", Offset = "0x694FCF0", VA = "0x1869512F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6951EB0", Offset = "0x69508B0", VA = "0x186951EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class DKIIBFLLPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Matchmaking.PKHNIKPBGNJ result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public MEEBKELCKCC errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public DKIIBFLLPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x694F0E0", Offset = "0x694DAE0", VA = "0x18694F0E0")]
		internal object LNFJKFIDPHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class JJGCDIMIECJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Task<EOCBFNOLIGO> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public JJGCDIMIECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		internal Task<EOCBFNOLIGO> PKBMNBBDJOA(MJHALEONFCB<string>.KDBHCAJIBOE _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct JKGGDELMICC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public NPMDDPNHBKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public MAHIACGDFOP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public HPMGAEEGDBP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public EGMIDFNMIDN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private JJGCDIMIECJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private BHPFCKOAEJC <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private OCHDPFMCIOG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private PMHGABOONOO <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Task<Matchmaking.JOGKOCOAIIO> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private LNDOEAGFLFJ <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.JOGKOCOAIIO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<EOCBFNOLIGO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6957310", Offset = "0x6955D10", VA = "0x186957310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x695C4A0", Offset = "0x695AEA0", VA = "0x18695C4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct EBEGJFHGKJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public NPMDDPNHBKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <disconnectTimerScope>5__3;

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
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x694F210", Offset = "0x694DC10", VA = "0x18694F210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x694FC60", Offset = "0x694E660", VA = "0x18694FC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct HCMMPFMPAMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public NPMDDPNHBKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private ICKBMMGCCPN <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6954100", Offset = "0x6952B00", VA = "0x186954100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6954570", Offset = "0x6952F70", VA = "0x186954570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct PCEMIKCNNAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder<Matchmaking.JOGKOCOAIIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public MAHIACGDFOP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public NPMDDPNHBKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<Matchmaking.JOGKOCOAIIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6966470", Offset = "0x6964E70", VA = "0x186966470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6966970", Offset = "0x6965370", VA = "0x186966970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct IPEKPMBHNIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Matchmaking.JOGKOCOAIIO serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public NPMDDPNHBKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public EGMIDFNMIDN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<HFKIGNEKHDK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6956230", Offset = "0x6954C30", VA = "0x186956230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6956930", Offset = "0x6955330", VA = "0x186956930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class NEJDKEBIHJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public MAHIACGDFOP targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public NEJDKEBIHJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x69605E0", Offset = "0x695EFE0", VA = "0x1869605E0")]
		internal object MAAIBOFDNAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x69604E0", Offset = "0x695EEE0", VA = "0x1869604E0")]
		internal string EHHMBICKNJJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct PCJFEFDDLCE : IAsyncStateMachine
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
		public MAHIACGDFOP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public NPMDDPNHBKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private NEJDKEBIHJA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private OCHDPFMCIOG <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x69669E0", Offset = "0x69653E0", VA = "0x1869669E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x69675B0", Offset = "0x6965FB0", VA = "0x1869675B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct OKKJEHHCPEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public NPMDDPNHBKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public EGMIDFNMIDN joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public EOCBFNOLIGO initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public MAHIACGDFOP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public BHPFCKOAEJC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6965380", Offset = "0x6963D80", VA = "0x186965380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6965C90", Offset = "0x6964690", VA = "0x186965C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct MNBIJHLMICG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public NPMDDPNHBKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private OCHDPFMCIOG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap3;

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
		[Cpp2IlInjected.Address(RVA = "0x695E460", Offset = "0x695CE60", VA = "0x18695E460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x695FAA0", Offset = "0x695E4A0", VA = "0x18695FAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct JEKFKIIMAIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public NPMDDPNHBKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<OEGBNAHMNGM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6956990", Offset = "0x6955390", VA = "0x186956990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6957150", Offset = "0x6955B50", VA = "0x186957150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class OBBPJGGIHHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public MAHIACGDFOP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public OBBPJGGIHHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x69651B0", Offset = "0x6963BB0", VA = "0x1869651B0")]
		internal object HFDHPMELOMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class BOHMOGMNBOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BOHMOGMNBOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x694D9C0", Offset = "0x694C3C0", VA = "0x18694D9C0")]
		internal void FJFBIDONPON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class DOLPPNJDKJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public MAHIACGDFOP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public DOLPPNJDKJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x694F190", Offset = "0x694DB90", VA = "0x18694F190")]
		internal object EINENLOPFPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class LJNOCCPFCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public MAHIACGDFOP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public LJNOCCPFCHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x695DA40", Offset = "0x695C440", VA = "0x18695DA40")]
		internal string IBJNHKHOFCD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly LBNENDFDEJK HCFIECNCCJJ;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly LBNENDFDEJK POLEKCIHOJA;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly LBNENDFDEJK EKEENAIECEN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string PMAEHMBBNHJ;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string NLLLOGOIDJB;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string BPKKNOMMOKI;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static readonly Guid JPEDEAFAOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private BPMFCGNIGPG HJBINPJGJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private POGNPHAFADJ FCHOOACIBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private IOMAPACFCCK LKKONKMIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private KLGILBCOHEN NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private BAJCMGCAKKA NDNKFHOBGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private MIGIELKEKKG HHAPLFHDKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private IFMIMGIKGIJ GFKFCFMECNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private BNGOFEFEHPO OINDEMFPBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private PCGPBKPEHGB CCDBNHHLCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private IDisposable DDBOCODNPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly JIIANIOJCIN GPIAGLFKBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly JIIANIOJCIN BGFOIBGNMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private LNDOEAGFLFJ ICODGJFJBIH;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TaskStatus EMLELPPAGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xB019F0", Offset = "0xB003F0", VA = "0x180B019F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xB4FF50", Offset = "0xB4E950", VA = "0x180B4FF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private GLMLMHBFNJA BEHNCOLJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x69639C0", Offset = "0x69623C0", VA = "0x1869639C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6964100", Offset = "0x6962B00", VA = "0x186964100", Slot = "6")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x69628B0", Offset = "0x69612B0", VA = "0x1869628B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6962AE0", Offset = "0x69614E0", VA = "0x186962AE0", Slot = "5")]
	[AsyncStateMachine(typeof(PMCAPHJAICC))]
	public Task HJLLNMHDGOG(MAHIACGDFOP CKOBKCKDHJE, HPMGAEEGDBP KAMAEGACMCK, CancellationToken GKJHCAJJFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6963D40", Offset = "0x6962740", VA = "0x186963D40")]
	[AsyncStateMachine(typeof(FBBFNPDCBIM))]
	private Task LFMONPFCOGJ(MAHIACGDFOP CKOBKCKDHJE, HPMGAEEGDBP KAMAEGACMCK, CancellationToken GKJHCAJJFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6963600", Offset = "0x6962000", VA = "0x186963600")]
	private static void KHADONPMFON(BNGOFEFEHPO OINDEMFPBME, MAHIACGDFOP CKOBKCKDHJE, Exception PBPEDJNJMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6961760", Offset = "0x6960160", VA = "0x186961760")]
	private static void AMJHNOMPIDB(JKGGCDOHFAN FNGFJOKJDIF, Exception PBPEDJNJMOI, [Optional] List<int> FBFNAEKDENP, int LHCJHCDOODE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6963090", Offset = "0x6961A90", VA = "0x186963090")]
	[AsyncStateMachine(typeof(JKGGDELMICC))]
	private Task JEHDLDFGIOP(MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, MAHIACGDFOP CKOBKCKDHJE, HPMGAEEGDBP KAMAEGACMCK, EGMIDFNMIDN ODDNCOBMBEM, CancellationToken GKJHCAJJFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6964720", Offset = "0x6963120", VA = "0x186964720")]
	private void NOBEACADDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x69633C0", Offset = "0x6961DC0", VA = "0x1869633C0")]
	[AsyncStateMachine(typeof(EBEGJFHGKJN))]
	private Task KBNICDHPOFG(MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6963A10", Offset = "0x6962410", VA = "0x186963A10")]
	private void LDALJPDIEPG(MAHIACGDFOP CKOBKCKDHJE, CancellationToken GKJHCAJJFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x69621A0", Offset = "0x6960BA0", VA = "0x1869621A0")]
	private void CDHJNPCPMHM(MAHIACGDFOP CKOBKCKDHJE, EGMIDFNMIDN ODDNCOBMBEM, OperationCanceledException IJKCEEHHFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6964C10", Offset = "0x6963610", VA = "0x186964C10")]
	private void POLDPAHFFHO(MAHIACGDFOP CKOBKCKDHJE, EGMIDFNMIDN ODDNCOBMBEM, Exception PBPEDJNJMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6962510", Offset = "0x6960F10", VA = "0x186962510")]
	private void CNOEDCGHMCC(MAHIACGDFOP CKOBKCKDHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x69631F0", Offset = "0x6961BF0", VA = "0x1869631F0")]
	private static BONPCGFBDHP JMIPOOHELCH(MAHIACGDFOP CKOBKCKDHJE)
	{
		return default(BONPCGFBDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6962C20", Offset = "0x6961620", VA = "0x186962C20")]
	[AsyncStateMachine(typeof(HCMMPFMPAMD))]
	private Task HKDDFFLCNDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x69645C0", Offset = "0x6962FC0", VA = "0x1869645C0")]
	[AsyncStateMachine(typeof(PCEMIKCNNAO))]
	private Task<Matchmaking.JOGKOCOAIIO> NJMCLEOCJMI(MAHIACGDFOP CKOBKCKDHJE, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x69634F0", Offset = "0x6961EF0", VA = "0x1869634F0")]
	private static HFKIGNEKHDK KCAOGHMBABO(Matchmaking.JOGKOCOAIIO OIOGPELBGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6962900", Offset = "0x6961300", VA = "0x186962900")]
	[AsyncStateMachine(typeof(IPEKPMBHNIN))]
	private Task EHMGIDIJDFP(Matchmaking.JOGKOCOAIIO OIOGPELBGHG, EGMIDFNMIDN ODDNCOBMBEM, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken FAIDMJAEDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x69623D0", Offset = "0x6960DD0", VA = "0x1869623D0")]
	[AsyncStateMachine(typeof(PCJFEFDDLCE))]
	private Task CIICJMGOEAE(MAHIACGDFOP CKOBKCKDHJE, CancellationTokenSource NHCBOPNFHHK, Task HDEKFNGKMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6962CF0", Offset = "0x69616F0", VA = "0x186962CF0")]
	[AsyncStateMachine(typeof(OKKJEHHCPEE))]
	private Task ICPKPNLHOHG(EOCBFNOLIGO CEDHAAHJMGO, BHPFCKOAEJC OMHHEPBDKPN, MAHIACGDFOP CNLBJEFJHKP, EGMIDFNMIDN CCINGMDAJIC, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken LNGOOBCFJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6964870", Offset = "0x6963270", VA = "0x186964870")]
	private EGMIDFNMIDN OFPIDLDNBOG(EGMIDFNMIDN CCINGMDAJIC, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6961630", Offset = "0x6960030", VA = "0x186961630")]
	[AsyncStateMachine(typeof(MNBIJHLMICG))]
	private Task ACBLCCBJFCD(MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6962080", Offset = "0x6960A80", VA = "0x186962080")]
	[AsyncStateMachine(typeof(JEKFKIIMAIL))]
	private Task CBDHMBBGHNB(GCGKJJGGALM ABDLEBPKDKC, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6963F80", Offset = "0x6962980", VA = "0x186963F80")]
	private static void MJCMCFNMAPI(MAHIACGDFOP CKOBKCKDHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6962E60", Offset = "0x6961860", VA = "0x186962E60")]
	private void IEHMBIKKNPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6962720", Offset = "0x6961120", VA = "0x186962720")]
	private void DALJMGAAJAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6961FF0", Offset = "0x69609F0", VA = "0x186961FF0")]
	private void BCFLLNKELHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6962A50", Offset = "0x6961450", VA = "0x186962A50")]
	private void GIGEPHLMOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6963E90", Offset = "0x6962890", VA = "0x186963E90")]
	private static void MBHNCLEFGAD(MAHIACGDFOP CKOBKCKDHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x69632B0", Offset = "0x6961CB0", VA = "0x1869632B0")]
	private static CancellationTokenRegistration KBDOLONFOAN(MAHIACGDFOP CKOBKCKDHJE, CancellationToken FAIDMJAEDOK)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x69627B0", Offset = "0x69611B0", VA = "0x1869627B0")]
	private static void DMNOJFLIOEM(MAHIACGDFOP CKOBKCKDHJE, Exception PBPEDJNJMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6964A60", Offset = "0x6963460", VA = "0x186964A60")]
	private void PNJFKJONDGH(MAHIACGDFOP CKOBKCKDHJE, Task HDEKFNGKMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6963030", Offset = "0x6961A30", VA = "0x186963030")]
	private static void IGGHFJOIHIE(Func<string> DJDDEFKOPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6965060", Offset = "0x6963A60", VA = "0x186965060")]
	public NPMDDPNHBKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6963250", Offset = "0x6961C50", VA = "0x186963250")]
	[CompilerGenerated]
	internal static (int, int?) JPCHHOPPDNE(MEEBKELCKCC DBHLKMLCOPG)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class BABPFIFKEEJ : IAKLJLPCOPP, AGBFFJHKJLE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct GCGGNJFJPFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public BABPFIFKEEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public GCGKJJGGALM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6976840", Offset = "0x6975240", VA = "0x186976840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6976C00", Offset = "0x6975600", VA = "0x186976C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class CFOIKFOPLNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public BABPFIFKEEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public GCGKJJGGALM roomData;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public CFOIKFOPLNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x696E340", Offset = "0x696CD40", VA = "0x18696E340")]
		internal List<Task> LHLBNFCOKPP(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct MNFBOMOMLAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public AMNFGMMIBKI taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6984350", Offset = "0x6982D50", VA = "0x186984350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x69846E0", Offset = "0x69830E0", VA = "0x1869846E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct CHIPKIPCPLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public BABPFIFKEEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x696EBC0", Offset = "0x696D5C0", VA = "0x18696EBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x696EE80", Offset = "0x696D880", VA = "0x18696EE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly HashSet<AMNFGMMIBKI> EMOHBIMNHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private POGNPHAFADJ FCHOOACIBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private CLHNECDKFDA KFKPJFCDEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GFKNBKJELFK BJKPNKHBPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private IDisposable DDBOCODNPOE;

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x694D120", Offset = "0x694BB20", VA = "0x18694D120", Slot = "5")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x694C7F0", Offset = "0x694B1F0", VA = "0x18694C7F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x694CBA0", Offset = "0x694B5A0", VA = "0x18694CBA0", Slot = "4")]
	public bool KBAODIHPLEE(AMNFGMMIBKI OEFJPABOJMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x694C9F0", Offset = "0x694B3F0", VA = "0x18694C9F0")]
	private void IJIGBPMMGKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x694C610", Offset = "0x694B010", VA = "0x18694C610")]
	private void AHOLEDKNNCB(GCGKJJGGALM GOGGOGGMFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x694C520", Offset = "0x694AF20", VA = "0x18694C520")]
	[AsyncStateMachine(typeof(GCGGNJFJPFC))]
	private Task AFFLAFNBPHA(GCGKJJGGALM GOGGOGGMFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x694C850", Offset = "0x694B250", VA = "0x18694C850")]
	private Func<CancellationToken, List<Task>> HAACIGKBJDM(GCGKJJGGALM GOGGOGGMFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x694CC00", Offset = "0x694B600", VA = "0x18694CC00")]
	private List<Task> MOELHFKMBEC(GCGKJJGGALM GOGGOGGMFEP, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x694D3A0", Offset = "0x694BDA0", VA = "0x18694D3A0")]
	[AsyncStateMachine(typeof(MNFBOMOMLAM))]
	private Task PNHENDACFOG(AMNFGMMIBKI AIHLNHANNCP, GCGKJJGGALM ABDLEBPKDKC, CancellationToken AIDIDMJCFEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x694C920", Offset = "0x694B320", VA = "0x18694C920")]
	[AsyncStateMachine(typeof(CHIPKIPCPLJ))]
	private Task HLBJMKOALID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x694CB20", Offset = "0x694B520", VA = "0x18694CB20")]
	private void JPLEEFEBOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x694D4C0", Offset = "0x694BEC0", VA = "0x18694D4C0")]
	public BABPFIFKEEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class PJOPGPEBEJO : KOLOJFFMEKM, AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class DMLIPCFCFMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public DMLIPCFCFMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6970050", Offset = "0x696EA50", VA = "0x186970050")]
		internal object DNOOFCKMKJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class IAGDJHNEKHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public IAGDJHNEKHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x697A620", Offset = "0x6979020", VA = "0x18697A620")]
		internal object JCPMAHHJEOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class CAIHOCIIBKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public CAIHOCIIBKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class FMEOIBCNJCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public FMEOIBCNJCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6975430", Offset = "0x6973E30", VA = "0x186975430")]
		internal object JEFOHDAFDJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class OPIJEPIKPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public OPIJEPIKPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6987BA0", Offset = "0x69865A0", VA = "0x186987BA0")]
		internal object DKAGMLPGGFA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly Dictionary<Guid, MHANNGNFCLK> BMGHGJOEFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly TimeSpan HPFDNBNMPCO;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "9")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6987E20", Offset = "0x6986820", VA = "0x186987E20", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6987C00", Offset = "0x6986600", VA = "0x186987C00", Slot = "4")]
	public DBPOBKJJAGP BIPEDCDHLGG(Guid ALJDBMFHGKI)
	{
		return default(DBPOBKJJAGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x69885E0", Offset = "0x6986FE0", VA = "0x1869885E0", Slot = "5")]
	public bool MDELFCPLFEE(Guid ALJDBMFHGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6987EA0", Offset = "0x69868A0", VA = "0x186987EA0", Slot = "6")]
	public bool FLHOKBCLKLE(Guid ALJDBMFHGKI, Task EBONHAFHIIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x69881D0", Offset = "0x6986BD0", VA = "0x1869881D0", Slot = "7")]
	public bool GGOONBDPLMF(Guid ALJDBMFHGKI, OEGBNAHMNGM IGLBDPPIJLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6987E30", Offset = "0x6986830", VA = "0x186987E30", Slot = "8")]
	public Task<(OEGBNAHMNGM, Task)> EMDLBNBFIAN(Guid ALJDBMFHGKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x69883B0", Offset = "0x6986DB0", VA = "0x1869883B0")]
	private void LCBFCBKADAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x69887F0", Offset = "0x69871F0", VA = "0x1869887F0")]
	public PJOPGPEBEJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class KMIKJOPNACA : MAFNFMHIBPB, AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class FHFEDJMEAML : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly MAHIACGDFOP NLMHGBDJOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly CancellationTokenSource NCPJPNOCKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public readonly CancellationToken AFLNKCOGPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool CLBBGFFBNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private bool OGOJAHMCHNJ;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6974850", Offset = "0x6973250", VA = "0x186974850")]
		public FHFEDJMEAML(MAHIACGDFOP NLMHGBDJOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6974700", Offset = "0x6973100", VA = "0x186974700")]
		public void JPLEEFEBOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x69746D0", Offset = "0x69730D0", VA = "0x1869746D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class JLGCCMBGOMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public IGOFNHPAKMC disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public JLGCCMBGOMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x697EBE0", Offset = "0x697D5E0", VA = "0x18697EBE0")]
		internal object BDOCFHKNAEA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct JEAIKEEBLDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public IGOFNHPAKMC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public KMIKJOPNACA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x697E7D0", Offset = "0x697D1D0", VA = "0x18697E7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x697EB80", Offset = "0x697D580", VA = "0x18697EB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class PPEGABLJAPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public PPEGABLJAPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6988AB0", Offset = "0x69874B0", VA = "0x186988AB0")]
		internal object FJDMLDGALIA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct DOJNAJAMGJE : IAsyncStateMachine
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
		public KMIKJOPNACA <>4__this;

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
		private OCHDPFMCIOG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6970640", Offset = "0x696F040", VA = "0x186970640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B2120", Offset = "0x8B0B20", VA = "0x1808B2120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class OLLENAMLOKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public MAHIACGDFOP newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public OLLENAMLOKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6986E50", Offset = "0x6985850", VA = "0x186986E50")]
		internal object DALKJPLNHIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6986F30", Offset = "0x6985930", VA = "0x186986F30")]
		internal object KJDFHJLFNIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6986EF0", Offset = "0x69858F0", VA = "0x186986EF0")]
		internal object IOLKOADKCGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class DGLPDMMNBPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public DGLPDMMNBPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x696F960", Offset = "0x696E360", VA = "0x18696F960")]
		internal void POPCBEHEJCE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct IGDFMEIJMAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public MAHIACGDFOP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public KMIKJOPNACA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public HPMGAEEGDBP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private OLLENAMLOKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private OCHDPFMCIOG <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x697B6A0", Offset = "0x697A0A0", VA = "0x18697B6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x697C620", Offset = "0x697B020", VA = "0x18697C620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly BGCAGIJKNEE.BEOKFCIAOOB IJHCCAJCABP;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly GJELFAODKNL LGFMFMOGHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private POGNPHAFADJ FCHOOACIBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private BAJCMGCAKKA NDNKFHOBGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private KLGILBCOHEN NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private GBCIGNIOONC FAKHGNGCNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private DLDHADAOENG HPODGLAMDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private long CFEIBHLJFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private FHFEDJMEAML LPKCKCBBNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool NGGLKNJKNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private Task MDCLOJAIJJL;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private GLMLMHBFNJA BEHNCOLJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6980530", Offset = "0x697EF30", VA = "0x186980530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool AALNHILDKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x10C16A0", Offset = "0x10C00A0", VA = "0x1810C16A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6980950", Offset = "0x697F350", VA = "0x186980950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x69806B0", Offset = "0x697F0B0", VA = "0x1869806B0", Slot = "4")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x697FC10", Offset = "0x697E610", VA = "0x18697FC10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x697FD80", Offset = "0x697E780", VA = "0x18697FD80")]
	[AsyncStateMachine(typeof(JEAIKEEBLDJ))]
	private Task EFEHNGDNIKO(IGOFNHPAKMC OKGJAGKFLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x697FE70", Offset = "0x697E870", VA = "0x18697FE70")]
	private void FJCEGANDIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6980010", Offset = "0x697EA10", VA = "0x186980010")]
	private void GMIGGLADKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x697FA90", Offset = "0x697E490", VA = "0x18697FA90")]
	private void BJOPMIPOEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x697F950", Offset = "0x697E350", VA = "0x18697F950")]
	private bool AMCMHLJHKHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x697F9C0", Offset = "0x697E3C0", VA = "0x18697F9C0")]
	[AsyncStateMachine(typeof(DOJNAJAMGJE))]
	private void BFKPEFDLGKM(int INOGMJCLNPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x69801A0", Offset = "0x697EBA0", VA = "0x1869801A0")]
	private void HEPFFDIIPPG([Out] IDisposable BIOIJEFIGCD, [Out] IDisposable DKJCCGFINHN, [Out] IDisposable NKAHAOGIPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6980430", Offset = "0x697EE30", VA = "0x186980430")]
	private bool JIKENGCPDJM(MAHIACGDFOP NLMHGBDJOEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6980960", Offset = "0x697F360", VA = "0x186980960")]
	private void PDHDELAJGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6980580", Offset = "0x697EF80", VA = "0x186980580")]
	[AsyncStateMachine(typeof(IGDFMEIJMAD))]
	private Task LFMONPFCOGJ(MAHIACGDFOP NLMHGBDJOEJ, HPMGAEEGDBP KAMAEGACMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6980D80", Offset = "0x697F780", VA = "0x186980D80")]
	public KMIKJOPNACA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class GAAJDENOJHO : CJDJAOFHDOA, AGBFFJHKJLE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct MIEEHAIAEOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder<BALIOJOPJGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public GAAJDENOJHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<BALIOJOPJGB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x69827A0", Offset = "0x69811A0", VA = "0x1869827A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6982A30", Offset = "0x6981430", VA = "0x186982A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class LALOKEGIDLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public MGKFLOLLHJM message;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public LALOKEGIDLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x6980DF0", Offset = "0x697F7F0", VA = "0x186980DF0")]
		internal object FLBCMHFINIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class DBMNHDCCEGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public MGKFLOLLHJM messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public DBMNHDCCEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x696F900", Offset = "0x696E300", VA = "0x18696F900")]
		internal object CFHFAOAIKAK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class HPALFKMICHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public MGKFLOLLHJM request;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HPALFKMICHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x697A5C0", Offset = "0x6978FC0", VA = "0x18697A5C0")]
		internal object MFDOLEPGGBO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct HBDJPFOIFBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public MGKFLOLLHJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public GAAJDENOJHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<EIPPLJBOIII> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6977200", Offset = "0x6975C00", VA = "0x186977200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6977AC0", Offset = "0x69764C0", VA = "0x186977AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class BKKIAFLOAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public MGKFLOLLHJM operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BKKIAFLOAKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x696B9B0", Offset = "0x696A3B0", VA = "0x18696B9B0")]
		internal object CKOAKOIKNMI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct OMEKINFJOIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public MGKFLOLLHJM operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public GAAJDENOJHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private EGMIDFNMIDN <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<MGKFLOLLHJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6986F70", Offset = "0x6985970", VA = "0x186986F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6987AE0", Offset = "0x69864E0", VA = "0x186987AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct DOGHLLAHFFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder<EIPPLJBOIII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public GAAJDENOJHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public MGKFLOLLHJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private DGOHEOEFJOJ.CCBMFHLEDPK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private EGMIDFNMIDN <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<MGKFLOLLHJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x69700B0", Offset = "0x696EAB0", VA = "0x1869700B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x69705D0", Offset = "0x696EFD0", VA = "0x1869705D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class NMJCGAOADFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public EIPPLJBOIII operation;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public NMJCGAOADFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6985F90", Offset = "0x6984990", VA = "0x186985F90")]
		internal object DCCCIKDDKPD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct OAPNAGFOIOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public EIPPLJBOIII operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public GAAJDENOJHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private MJHALEONFCB<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6986010", Offset = "0x6984A10", VA = "0x186986010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6986640", Offset = "0x6985040", VA = "0x186986640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class KGJLKBKNAGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public MGKFLOLLHJM request;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public KGJLKBKNAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x697F8F0", Offset = "0x697E2F0", VA = "0x18697F8F0")]
		internal object KBKCLBIPGDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class APMNLBEDFIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public MGKFLOLLHJM request;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public APMNLBEDFIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x696AC60", Offset = "0x6969660", VA = "0x18696AC60")]
		internal object LIBBKOCLJDA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private MIGIELKEKKG HHAPLFHDKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private MAPOPECPHFA JLONPFKBPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private FNBGDPLDFNK FPBOAHDDPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private IOMAPACFCCK LKKONKMIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private TaskCompletionSource<BALIOJOPJGB> AFLEEIFJNBG;

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x69763C0", Offset = "0x6974DC0", VA = "0x1869763C0", Slot = "7")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x69760A0", Offset = "0x6974AA0", VA = "0x1869760A0", Slot = "6")]
	[AsyncStateMachine(typeof(MIEEHAIAEOI))]
	public Task<BALIOJOPJGB> KHJOOIKELEH(CancellationToken PNEMGKHGPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6975490", Offset = "0x6973E90", VA = "0x186975490", Slot = "4")]
	public void ALBONAKIIBC(MGKFLOLLHJM CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6975CB0", Offset = "0x69746B0", VA = "0x186975CB0", Slot = "5")]
	public void KAOLPBAOJGO(MGKFLOLLHJM HKEEKFAFJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6975820", Offset = "0x6974220", VA = "0x186975820")]
	[AsyncStateMachine(typeof(HBDJPFOIFBC))]
	private Task CKPKALLGHKG(MGKFLOLLHJM ELBMMMMNOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6975930", Offset = "0x6974330", VA = "0x186975930")]
	[AsyncStateMachine(typeof(OMEKINFJOIK))]
	private Task FLEEOPPAJMG(MGKFLOLLHJM NNLGKIFHNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6975A40", Offset = "0x6974440", VA = "0x186975A40")]
	[AsyncStateMachine(typeof(DOGHLLAHFFP))]
	private Task<EIPPLJBOIII> HNNOLOONHHJ(MGKFLOLLHJM ELBMMMMNOAO, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6976010", Offset = "0x6974A10", VA = "0x186976010")]
	private EGMIDFNMIDN KBHLKFFHCKO(MGKFLOLLHJM LFBGOIPNMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6975B90", Offset = "0x6974590", VA = "0x186975B90")]
	[AsyncStateMachine(typeof(OAPNAGFOIOK))]
	private Task IBKDAEFPGJG(EIPPLJBOIII EHNGFDOGIGP, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x69761B0", Offset = "0x6974BB0", VA = "0x1869761B0")]
	private EIPPLJBOIII MNAFAHIDCGB(MGKFLOLLHJM ELBMMMMNOAO, EGMIDFNMIDN NNNJKJBABFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2949730", Offset = "0x2948130", VA = "0x182949730")]
	private T FFIHNIPJGEI<T>(T AEJBOLFACJC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x69764B0", Offset = "0x6974EB0", VA = "0x1869764B0")]
	private EIPPLJBOIII PONEJLKKOCC(MGKFLOLLHJM ELBMMMMNOAO, EGMIDFNMIDN NNNJKJBABFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public GAAJDENOJHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class HGBNMCJMGPI : MAPOPECPHFA, AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class CLOLLDDBAOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public CLOLLDDBAOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x696F690", Offset = "0x696E090", VA = "0x18696F690")]
		internal object AOHAOMNDNLF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class IOIGFDPPBBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public IOIGFDPPBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x697DDC0", Offset = "0x697C7C0", VA = "0x18697DDC0")]
		internal object HDLNONFELHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private IOMAPACFCCK LKKONKMIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private FPKEDFFNAIL IEOKJMBPJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private CJDJAOFHDOA MMBEODDLFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private KOLOJFFMEKM BMGHGJOEFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private LEBCHGAEFNO PHNFMPFOBJH;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6979CA0", Offset = "0x69786A0", VA = "0x186979CA0", Slot = "6")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6978C30", Offset = "0x6977630", VA = "0x186978C30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x69791A0", Offset = "0x6977BA0", VA = "0x1869791A0", Slot = "4")]
	public DBPOBKJJAGP FHJOILMMHIM(MGKFLOLLHJM HMMKMPAJDJI)
	{
		return default(DBPOBKJJAGP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x69795D0", Offset = "0x6977FD0", VA = "0x1869795D0", Slot = "5")]
	public void HAKGDMBDNNF(Guid ALJDBMFHGKI, Task EBONHAFHIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6978340", Offset = "0x6976D40", VA = "0x186978340")]
	private void BHBIIEKAEJK(byte OBGKBMJJGNA, int HJCOBICJDBA, object GCJMIDFMNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x69786A0", Offset = "0x69770A0", VA = "0x1869786A0")]
	private void DLGENHCMDLC(BEKDNIPNCMA MOCDKEGGLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6978040", Offset = "0x6976A40", VA = "0x186978040")]
	private void BEBHHPJPNEB(BEKDNIPNCMA MOCDKEGGLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6979E10", Offset = "0x6978810", VA = "0x186979E10")]
	private void NNBMIOPCAEK(BEKDNIPNCMA MOCDKEGGLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x69797E0", Offset = "0x69781E0", VA = "0x1869797E0")]
	private OEGBNAHMNGM JFKNMEOPFLP(MGKFLOLLHJM LFBGOIPNMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6978CE0", Offset = "0x69776E0", VA = "0x186978CE0")]
	private void EEPECKEICCJ(MGKFLOLLHJM NNLGKIFHNME, OEGBNAHMNGM IGLBDPPIJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6978EF0", Offset = "0x69778F0", VA = "0x186978EF0")]
	private bool FDHIHMPCFCO(MGKFLOLLHJM NNLGKIFHNME, OEGBNAHMNGM IGLBDPPIJLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6979A20", Offset = "0x6978420", VA = "0x186979A20")]
	private bool MCJBOKGBGKJ(MGKFLOLLHJM BKKGBCIJDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6978410", Offset = "0x6976E10", VA = "0x186978410")]
	private bool DDLEJABJCPP(byte OBGKBMJJGNA, ExitGames.Client.Photon.Hashtable MOCDKEGGLLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public HGBNMCJMGPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class HOEKMKKOACB : IMCCECFKKHD, AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class GEDJFCFNFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public BALIOJOPJGB operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public HOEKMKKOACB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public MGKFLOLLHJM roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public GEDJFCFNFFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6976D90", Offset = "0x6975790", VA = "0x186976D90")]
		internal object EONLEGBJOGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6976C60", Offset = "0x6975660", VA = "0x186976C60")]
		internal object BNDGFLGEKCN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct IBMIBFNMLCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<OEGBNAHMNGM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public HOEKMKKOACB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public MGKFLOLLHJM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<OEGBNAHMNGM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x697AFA0", Offset = "0x69799A0", VA = "0x18697AFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x697B630", Offset = "0x697A030", VA = "0x18697B630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class HOJIDBOFGPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public BALIOJOPJGB operationType;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HOJIDBOFGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x697A550", Offset = "0x6978F50", VA = "0x18697A550")]
		internal object HHDNPBJLNHB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class PKLIMIJDGKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public MGKFLOLLHJM request;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public PKLIMIJDGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6988920", Offset = "0x6987320", VA = "0x186988920")]
		internal object KGAILKFLJNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x69888B0", Offset = "0x69872B0", VA = "0x1869888B0")]
		internal object ANGJLFEFMAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6988990", Offset = "0x6987390", VA = "0x186988990")]
		internal object PCPBPKLLNJN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct IAJECBBKNKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<OEGBNAHMNGM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public MGKFLOLLHJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public HOEKMKKOACB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private PKLIMIJDGKD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private DBPOBKJJAGP <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private OEGBNAHMNGM <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter<(OEGBNAHMNGM validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x697A680", Offset = "0x6979080", VA = "0x18697A680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x697AF30", Offset = "0x6979930", VA = "0x18697AF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private IOMAPACFCCK LKKONKMIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private FPKEDFFNAIL IEOKJMBPJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private MAPOPECPHFA JLONPFKBPFK;

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x697A170", Offset = "0x6978B70", VA = "0x18697A170", Slot = "5")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x697A050", Offset = "0x6978A50", VA = "0x18697A050", Slot = "4")]
	[AsyncStateMachine(typeof(IBMIBFNMLCL))]
	private Task<OEGBNAHMNGM> FMJKACIDJFA(MGKFLOLLHJM LFBGOIPNMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x697A220", Offset = "0x6978C20", VA = "0x18697A220")]
	private bool OIOJICBBKLF(BALIOJOPJGB NKLEJPMJNHG, [Out] OEGBNAHMNGM LKBGEIGOHEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x697A410", Offset = "0x6978E10", VA = "0x18697A410")]
	[AsyncStateMachine(typeof(IAJECBBKNKF))]
	private Task<OEGBNAHMNGM> OKMAMDHIKJP(MGKFLOLLHJM ELBMMMMNOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public HOEKMKKOACB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class CGBEEPDAEME : GCBIOEBLHPD, AGBFFJHKJLE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct HEHPLOMAJFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<EOCBFNOLIGO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public MAHIACGDFOP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CGBEEPDAEME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private TaskAwaiter<ECLKAFGMDKO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6977B20", Offset = "0x6976520", VA = "0x186977B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6977FD0", Offset = "0x69769D0", VA = "0x186977FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class PLCALEDGKCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public PLCALEDGKCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6988A00", Offset = "0x6987400", VA = "0x186988A00")]
		internal object NMJAEEDKFOK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct DPNKAOLHJKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public AsyncTaskMethodBuilder<ECLKAFGMDKO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CGBEEPDAEME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public MAHIACGDFOP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private PLCALEDGKCM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<ECLKAFGMDKO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x69717D0", Offset = "0x69701D0", VA = "0x1869717D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6971DC0", Offset = "0x69707C0", VA = "0x186971DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class ONFGLDHMAPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public ONFGLDHMAPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1519140", Offset = "0x1517B40", VA = "0x181519140")]
		internal bool INMCOFLPDKH(LIDLODHMGJG sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private KLGILBCOHEN NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private NNHMMGMJOPG PEHEGKKHHKH;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly (JAPDNPEKOGE superRoomData, long subRoomDataSaveId) MPFKFLHCMJK;

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x696EA60", Offset = "0x696D460", VA = "0x18696EA60", Slot = "5")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x696E7C0", Offset = "0x696D1C0", VA = "0x18696E7C0", Slot = "4")]
	[AsyncStateMachine(typeof(HEHPLOMAJFL))]
	public Task<EOCBFNOLIGO> DDENBNCJKGI(MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, MAHIACGDFOP CKOBKCKDHJE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x696E660", Offset = "0x696D060", VA = "0x18696E660")]
	[AsyncStateMachine(typeof(DPNKAOLHJKP))]
	private Task<ECLKAFGMDKO> DCMGJBANMGA(MAHIACGDFOP CKOBKCKDHJE, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x696E920", Offset = "0x696D320", VA = "0x18696E920")]
	private EOCBFNOLIGO MGKEPENMPGF(MAHIACGDFOP CKOBKCKDHJE, ECLKAFGMDKO FGFOLAOIHAC, long AJIFLLNCAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x696E370", Offset = "0x696CD70", VA = "0x18696E370")]
	private (JAPDNPEKOGE, long) CGPDMIMFDLC(MAHIACGDFOP CKOBKCKDHJE, ECLKAFGMDKO FGFOLAOIHAC, long AJIFLLNCAHB)
	{
		return default((JAPDNPEKOGE, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public CGBEEPDAEME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal sealed class JDOHJIFIDBE : FNBGDPLDFNK, AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class KAJIBMHINLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public MGKFLOLLHJM request;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public KAJIBMHINLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x697F830", Offset = "0x697E230", VA = "0x18697F830")]
		internal object MEOIPIJLFIF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct EPKHLKOHPAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder<MGKFLOLLHJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public MGKFLOLLHJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public JDOHJIFIDBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public EGMIDFNMIDN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<MGKFLOLLHJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x69725B0", Offset = "0x6970FB0", VA = "0x1869725B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6972BC0", Offset = "0x69715C0", VA = "0x186972BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct MHHLKKFJKOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder<MGKFLOLLHJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public JDOHJIFIDBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public EGMIDFNMIDN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter<NFKPPMHEDGE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6981E10", Offset = "0x6980810", VA = "0x186981E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6982410", Offset = "0x6980E10", VA = "0x186982410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class KALBBLJOKBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public MGKFLOLLHJM request;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public KALBBLJOKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x697F890", Offset = "0x697E290", VA = "0x18697F890")]
		internal object LKKLGFMJLNM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct MMLDOEOCEBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder<MGKFLOLLHJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public MGKFLOLLHJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public JDOHJIFIDBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public EGMIDFNMIDN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private NGLCPKINBJL <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private BKOHLFCAOOJ <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter<NFKPPMHEDGE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x69836F0", Offset = "0x69820F0", VA = "0x1869836F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x69842E0", Offset = "0x6982CE0", VA = "0x1869842E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private IOMAPACFCCK LKKONKMIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private GLLACCLJKBN IOKEKCGECGE;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private CGLEINIGDMO BCEBDBHLIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x697E060", Offset = "0x697CA60", VA = "0x18697E060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x697E740", Offset = "0x697D140", VA = "0x18697E740", Slot = "8")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x697E5E0", Offset = "0x697CFE0", VA = "0x18697E5E0", Slot = "4")]
	[AsyncStateMachine(typeof(EPKHLKOHPAM))]
	public Task<MGKFLOLLHJM> MAKMDENODJE(MGKFLOLLHJM ELBMMMMNOAO, EGMIDFNMIDN NNNJKJBABFH, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x697E120", Offset = "0x697CB20", VA = "0x18697E120", Slot = "5")]
	[AsyncStateMachine(typeof(MHHLKKFJKOH))]
	public Task<MGKFLOLLHJM> FDMEIKHMDEN(CancellationToken CFAFANOFDNJ, EGMIDFNMIDN NNNJKJBABFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x697E3D0", Offset = "0x697CDD0", VA = "0x18697E3D0", Slot = "6")]
	public FBDPEEPOBOM LHDLPOBKJHM(EIPPLJBOIII PKPDAIEELNI, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x697DE30", Offset = "0x697C830", VA = "0x18697DE30", Slot = "7")]
	public FBDPEEPOBOM AFLMJIKJGPP(EIPPLJBOIII PKPDAIEELNI, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x697E270", Offset = "0x697CC70", VA = "0x18697E270")]
	[AsyncStateMachine(typeof(MMLDOEOCEBE))]
	private Task<MGKFLOLLHJM> GCBPLBLPFNJ(MGKFLOLLHJM ELBMMMMNOAO, EGMIDFNMIDN NNNJKJBABFH, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2931A00", Offset = "0x2930400", VA = "0x182931A00")]
	private static byte[] BOKAPOHEHNP(MGKFLOLLHJM CPPFNMDMGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public JDOHJIFIDBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class JMHJMLJCPEF : FPKEDFFNAIL, AGBFFJHKJLE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private ONBMKGDFMKN HGKKHHJFMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private IOMAPACFCCK LKKONKMIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private MIGIELKEKKG HHAPLFHDKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private OHKNPDCDGPO NPLNDALCBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private KLGILBCOHEN NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private DLDHADAOENG HPODGLAMDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private IAKLJLPCOPP COIIPBLBCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private GBCIGNIOONC FAKHGNGCNKM;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private GLMLMHBFNJA BEHNCOLJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x697F310", Offset = "0x697DD10", VA = "0x18697F310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private static OEGBNAHMNGM NNFKECALBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x697F140", Offset = "0x697DB40", VA = "0x18697F140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x697F360", Offset = "0x697DD60", VA = "0x18697F360", Slot = "6")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x697F1A0", Offset = "0x697DBA0", VA = "0x18697F1A0", Slot = "4")]
	public OEGBNAHMNGM KBKPGGIOHMD(HOPBKANDJCK IOIKPEDHBNF, BALIOJOPJGB OMAMGNFAJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x697F530", Offset = "0x697DF30", VA = "0x18697F530", Slot = "5")]
	public OEGBNAHMNGM OEDOHGLFNPB(HOPBKANDJCK PCKPENJDOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x697F4D0", Offset = "0x697DED0", VA = "0x18697F4D0")]
	private static OEGBNAHMNGM NFEOOHPKPLK(EMHNINNJELF FKOGKDPANPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public JMHJMLJCPEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class DKIJCOCBCEN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x696FA70", Offset = "0x696E470", VA = "0x18696FA70")]
	public DKIJCOCBCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5E9BD20", Offset = "0x5E9A720", VA = "0x185E9BD20")]
	public DKIJCOCBCEN(string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class BMOFBFKIFML : GKMNFCBMKNB, AGBFFJHKJLE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct MKCPDILMFJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<OEGBNAHMNGM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public BMOFBFKIFML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public JDLHDFPPGKG autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private MJHALEONFCB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private PIFGBDPLPJI <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private TaskAwaiter<OEGBNAHMNGM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6982AA0", Offset = "0x69814A0", VA = "0x186982AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6983620", Offset = "0x6982020", VA = "0x186983620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct NKCKIIBCOOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public BMOFBFKIFML <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6984BA0", Offset = "0x69835A0", VA = "0x186984BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x69852F0", Offset = "0x6983CF0", VA = "0x1869852F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct OJEKBMHHNJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public BMOFBFKIFML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x69868E0", Offset = "0x69852E0", VA = "0x1869868E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6986DF0", Offset = "0x69857F0", VA = "0x186986DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct CLEMDCCJJAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public BMOFBFKIFML <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x696EEE0", Offset = "0x696D8E0", VA = "0x18696EEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x696F630", Offset = "0x696E030", VA = "0x18696F630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct COPABIGLGIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public BMOFBFKIFML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x696F700", Offset = "0x696E100", VA = "0x18696F700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x696F8A0", Offset = "0x696E2A0", VA = "0x18696F8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct EKFBBCBKKMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public BMOFBFKIFML <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6971E30", Offset = "0x6970830", VA = "0x186971E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6972550", Offset = "0x6970F50", VA = "0x186972550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct JLHJLILIOEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public BMOFBFKIFML <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x697EC70", Offset = "0x697D670", VA = "0x18697EC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x697F0E0", Offset = "0x697DAE0", VA = "0x18697F0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct FJMODICDDAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public BMOFBFKIFML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public OONOEGKKCEB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private MJHALEONFCB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6974900", Offset = "0x6973300", VA = "0x186974900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6974E60", Offset = "0x6973860", VA = "0x186974E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private IOMAPACFCCK LKKONKMIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private KLGILBCOHEN NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private FNBGDPLDFNK FPBOAHDDPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private MIGIELKEKKG HHAPLFHDKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private IAKLJLPCOPP COIIPBLBCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private CancellationTokenSource JCKCNJEHOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private Task DDPGKNODBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private TaskCompletionSource<int> FIJLEEIGLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private int DFDJBOEPNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private int MIHLKBNADOF;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x696C620", Offset = "0x696B020", VA = "0x18696C620", Slot = "6")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x923FE0", Offset = "0x9229E0", VA = "0x180923FE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x696BE60", Offset = "0x696A860", VA = "0x18696BE60")]
	private void DCJCGDNONDN(float BPEKDOOBJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x696C8D0", Offset = "0x696B2D0", VA = "0x18696C8D0", Slot = "4")]
	[AsyncStateMachine(typeof(MKCPDILMFJN))]
	public Task<OEGBNAHMNGM> PCPGKGCIPPH(JDLHDFPPGKG CAKGNCPACEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x696C3C0", Offset = "0x696ADC0", VA = "0x18696C3C0", Slot = "5")]
	[AsyncStateMachine(typeof(NKCKIIBCOOM))]
	public Task KJLBNJFADBL([Optional] CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x923FE0", Offset = "0x9229E0", VA = "0x180923FE0")]
	public void FAMFKFLMAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x696C4B0", Offset = "0x696AEB0", VA = "0x18696C4B0")]
	private PIFGBDPLPJI LGMMKEKHEJH(JDLHDFPPGKG CAKGNCPACEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x696BB10", Offset = "0x696A510", VA = "0x18696BB10")]
	[AsyncStateMachine(typeof(OJEKBMHHNJI))]
	private Task AJMLDNMPPJL(GCGKJJGGALM GCGDEDCNCCJ, CancellationToken GKJHCAJJFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x696C7D0", Offset = "0x696B1D0", VA = "0x18696C7D0")]
	[AsyncStateMachine(typeof(CLEMDCCJJAH))]
	private Task OBHNBMNCFIM(CancellationToken GKJHCAJJFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x696C2D0", Offset = "0x696ACD0", VA = "0x18696C2D0")]
	[AsyncStateMachine(typeof(COPABIGLGIG))]
	private Task KCOMILFIEDG([Optional] CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x696BF40", Offset = "0x696A940", VA = "0x18696BF40")]
	[AsyncStateMachine(typeof(EKFBBCBKKMB))]
	private Task DMNCNAJEBPG(CancellationToken GKJHCAJJFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x696BA10", Offset = "0x696A410", VA = "0x18696BA10")]
	[AsyncStateMachine(typeof(JLHJLILIOEP))]
	private Task AFKHINPAIOC(CancellationToken BPDGMGLBMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x696C140", Offset = "0x696AB40", VA = "0x18696C140")]
	private Task FBJGCDKKBPI(OONOEGKKCEB LAGEFEKOMON, CancellationToken GKJHCAJJFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x696C030", Offset = "0x696AA30", VA = "0x18696C030")]
	[AsyncStateMachine(typeof(FJMODICDDAI))]
	private Task FANFOHPBFKC(OONOEGKKCEB LAGEFEKOMON, CancellationToken GKJHCAJJFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x696BC00", Offset = "0x696A600", VA = "0x18696BC00")]
	private bool AJONMIOJECB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public BMOFBFKIFML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[UnityEngine.Scripting.Preserve]
internal class MDFGDHNLCML : OHKNPDCDGPO, AGBFFJHKJLE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct AJMINFJLMDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public MDFGDHNLCML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private MJHALEONFCB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x696A6A0", Offset = "0x69690A0", VA = "0x18696A6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x696AC00", Offset = "0x6969600", VA = "0x18696AC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private ABNKKKHFDML EIBGOHABNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private FPKEDFFNAIL IEOKJMBPJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private FNBGDPLDFNK FPBOAHDDPOA;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6981390", Offset = "0x697FD90", VA = "0x186981390", Slot = "6")]
	public void MPOMBMILLLK(JAPLGPCNONK JKFKIODGCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6981250", Offset = "0x697FC50", VA = "0x186981250", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6981150", Offset = "0x697FB50", VA = "0x186981150", Slot = "5")]
	[AsyncStateMachine(typeof(AJMINFJLMDC))]
	public Task DDGBGEABGDB(string NBJNGHHJOKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x69810F0", Offset = "0x697FAF0", VA = "0x1869810F0", Slot = "4")]
	public OEGBNAHMNGM AJONMIOJECB(HOPBKANDJCK IOIKPEDHBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x69812A0", Offset = "0x697FCA0", VA = "0x1869812A0")]
	private NHLCCPAMGCJ JIDJHELDGPD(string NBJNGHHJOKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public MDFGDHNLCML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class CEMEOFIAPJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x696DF40", Offset = "0x696C940", VA = "0x18696DF40")]
	public static void GLMJOLLMDLK(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x696DDE0", Offset = "0x696C7E0", VA = "0x18696DDE0")]
	internal static void GJDAKHJDCCD(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x696E180", Offset = "0x696CB80", VA = "0x18696E180")]
	internal static void NJHHDEKKPNF(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x696D990", Offset = "0x696C390", VA = "0x18696D990")]
	internal static void DMJINGEHNLN(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class BCJEEDJBAMC : GFMLPDDNDBB<MGKFLOLLHJM>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class NILNMHJNHGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public MGKFLOLLHJM message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public NILNMHJNHGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6984850", Offset = "0x6983250", VA = "0x186984850")]
		internal object HJIMNJBAIMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly BCJEEDJBAMC AINFBDJPIJL;

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x696AF60", Offset = "0x6969960", VA = "0x18696AF60")]
	public ExitGames.Client.Photon.Hashtable BOALAEMEPIG(MGKFLOLLHJM CPPFNMDMGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x696B330", Offset = "0x6969D30", VA = "0x18696B330", Slot = "5")]
	protected override void NKBNMEDEOOE(MGKFLOLLHJM CPPFNMDMGHI, IDictionary<object, object> ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x696AFF0", Offset = "0x69699F0", VA = "0x18696AFF0", Slot = "6")]
	public override MGKFLOLLHJM HIBHLHEFCGJ(IDictionary<object, object> ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x696B220", Offset = "0x6969C20", VA = "0x18696B220")]
	private static void IGGHFJOIHIE(string CAELIEOCIDF, MGKFLOLLHJM CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x696B500", Offset = "0x6969F00", VA = "0x18696B500")]
	public BCJEEDJBAMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x696ACC0", Offset = "0x69696C0", VA = "0x18696ACC0")]
	[CompilerGenerated]
	internal static string BBJKGFGGGGI(EOCBFNOLIGO PEFGDLBLMMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class MFCOAONINJA
{
	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public static OEGBNAHMNGM NNFKECALBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x697F140", Offset = "0x697DB40", VA = "0x18697F140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6981BB0", Offset = "0x69805B0", VA = "0x186981BB0")]
	public static bool OKGBDODADPD(this OEGBNAHMNGM IGLBDPPIJLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x697F4D0", Offset = "0x697DED0", VA = "0x18697F4D0")]
	public static OEGBNAHMNGM NFEOOHPKPLK(EMHNINNJELF PHCMJNOBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x69819B0", Offset = "0x69803B0", VA = "0x1869819B0")]
	public static OEGBNAHMNGM GOPFHMNCCCI(IEnumerable<OEGBNAHMNGM> DCDFIGBJNEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6981750", Offset = "0x6980150", VA = "0x186981750")]
	public static string EDFOAJBALPD(this OEGBNAHMNGM LKBGEIGOHEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class NLMLFBHFNPG : AOCEHHDJPBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate OEGBNAHMNGM MDJOPAOFDEN([NotNull] HOPBKANDJCK JIBKEFIHFDE);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class GDNKGFIKPHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public HOPBKANDJCK photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public GDNKGFIKPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x609F7F0", Offset = "0x609E1F0", VA = "0x18609F7F0")]
		internal OEGBNAHMNGM EFKAJHGMJBK(MDJOPAOFDEN v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private bool ODKMMAOGKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	protected readonly HashSet<MDJOPAOFDEN> DGHAHFHNPFM;

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6985E40", Offset = "0x6984840", VA = "0x186985E40", Slot = "4")]
	public void MJOKGPOABLC(MDJOPAOFDEN LMDMIPCOLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6985EA0", Offset = "0x69848A0", VA = "0x186985EA0", Slot = "5")]
	public void PHLKJELFNEL(MDJOPAOFDEN LMDMIPCOLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6985B50", Offset = "0x6984550", VA = "0x186985B50", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6985BA0", Offset = "0x69845A0", VA = "0x186985BA0")]
	protected OEGBNAHMNGM FCFOGHJMPFL(HOPBKANDJCK PCKPENJDOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6985F00", Offset = "0x6984900", VA = "0x186985F00")]
	protected NLMLFBHFNPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class NGLFHPABNOL : NLMLFBHFNPG, ONBMKGDFMKN, AOCEHHDJPBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class BDCJDELOMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public OEGBNAHMNGM result;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BDCJDELOMDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x696B540", Offset = "0x6969F40", VA = "0x18696B540")]
		internal object HCANGCHPOHE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x696CB10", Offset = "0x696B510", VA = "0x18696CB10")]
	[UnityEngine.Scripting.Preserve]
	public NGLFHPABNOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6984740", Offset = "0x6983140", VA = "0x186984740", Slot = "8")]
	public OEGBNAHMNGM LCOBMGAINDP(HOPBKANDJCK PCKPENJDOOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class BOAPIKODHMN : NLMLFBHFNPG, ABNKKKHFDML, AOCEHHDJPBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class MLLBNIPKOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public OEGBNAHMNGM result;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public MLLBNIPKOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x6983690", Offset = "0x6982090", VA = "0x186983690")]
		internal object CGKPHGHNEIA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x696CB10", Offset = "0x696B510", VA = "0x18696CB10")]
	[UnityEngine.Scripting.Preserve]
	public BOAPIKODHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x696CA00", Offset = "0x696B400", VA = "0x18696CA00", Slot = "8")]
	public OEGBNAHMNGM AJONMIOJECB(HOPBKANDJCK JJDFAIKPBCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class MHIJMELJJMP
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class LFIPCELIHDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public MJHALEONFCB<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public LFIPCELIHDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x6981070", Offset = "0x697FA70", VA = "0x186981070")]
		internal object CDPGFCJFEFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6982480", Offset = "0x6980E80", VA = "0x186982480")]
	public static MJHALEONFCB<string> AFAONEOLEBA(LBNENDFDEJK EMEAPIGMNBK, [Optional] string ELACGEDDHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6982560", Offset = "0x6980F60", VA = "0x186982560")]
	public static void CBKICNJHIGD(MJHALEONFCB<string> MDGFMJGBLAI, LBNENDFDEJK EMEAPIGMNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6982620", Offset = "0x6981020", VA = "0x186982620")]
	public static string MFOJFONNAOB(MGKFLOLLHJM LFBGOIPNMIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class GNBEGPEDKJH
{
	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x69771F0", Offset = "0x6975BF0", VA = "0x1869771F0")]
	public static void PDHMIIECMAG(this IOMAPACFCCK LKKONKMIDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x69771E0", Offset = "0x6975BE0", VA = "0x1869771E0")]
	public static void OPFGJFDIALC(this IOMAPACFCCK LKKONKMIDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x69770C0", Offset = "0x6975AC0", VA = "0x1869770C0")]
	private static void EMBGGAJODGL(this IOMAPACFCCK LKKONKMIDFE, bool IBCPHDFFMLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class FLNCBHPGIME : KOLGPFCOPBC, JDMJIPMHAHF, FGHLKIMCOFO, LCPOHDBDLPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly JDMJIPMHAHF JBOPDNHBNCI;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public HOPBKANDJCK IEMCFKMHIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x6975390", Offset = "0x6973D90", VA = "0x186975390", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public int BAAJGDGEIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6974F60", Offset = "0x6973960", VA = "0x186974F60", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int ONLNMKIBPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x69753E0", Offset = "0x6973DE0", VA = "0x1869753E0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool DMPMMNCDIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int JAEJJGGCFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x882190", Offset = "0x880B90", VA = "0x180882190", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event JBBELNGABEE.LIHDGCOIJLO FGNMPDBMLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event GHLAPDBEFDC HMJDLNAKBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x69750B0", Offset = "0x6973AB0", VA = "0x1869750B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x6975200", Offset = "0x6973C00", VA = "0x186975200", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> IPOKCJAPIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<HOPBKANDJCK> NOAJOFAEIKM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action OKKMAEEKCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x69752A0", Offset = "0x6973CA0", VA = "0x1869752A0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x6974EC0", Offset = "0x69738C0", VA = "0x186974EC0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0xDCC6A0", Offset = "0xDCB0A0", VA = "0x180DCC6A0")]
	public FLNCBHPGIME(JDMJIPMHAHF JBOPDNHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6975150", Offset = "0x6973B50", VA = "0x186975150", Slot = "8")]
	public bool IKANHMKGABO(byte OBGKBMJJGNA, ExitGames.Client.Photon.Hashtable OELLDEMNLKN, HIBLMJNCGEP HOABOGJHKPE, SendOptions NEJBICKLHJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6974FB0", Offset = "0x69739B0", VA = "0x186974FB0", Slot = "16")]
	public HOPBKANDJCK GHHGHPNDBGJ(int PAOMPGNMDBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "19")]
	public void BIJJJGIPENM(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "20")]
	public void GMKCKLFKEGE(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "21")]
	public void PMGGFLMNINH(object AIDIDMJCFEK, bool KGKCFPOOODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6975340", Offset = "0x6973D40", VA = "0x186975340", Slot = "22")]
	public IDisposable MIAEMKHCAHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "23")]
	private bool AKKMBJBPCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "24")]
	public void HCHOFBGDHPC(StringBuilder NFOLCBONCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6975090", Offset = "0x6973A90", VA = "0x186975090", Slot = "25")]
	public bool GLHGBMFFBAG(bool LPJKCJHBGCK, [Out] string MBGOEMJAPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x848860", Offset = "0x847260", VA = "0x180848860", Slot = "28")]
	public void GOCOOGHMMFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct BEKDNIPNCMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private readonly IDictionary<object, object> MOCDKEGGLLK;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
	public BEKDNIPNCMA(IDictionary<object, object> MOCDKEGGLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x696B5A0", Offset = "0x6969FA0", VA = "0x18696B5A0")]
	public bool DNNPOAGGMDK([Out] MGKFLOLLHJM CPPFNMDMGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x696B880", Offset = "0x696A280", VA = "0x18696B880")]
	public Guid LAOLOEEGGFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x696B740", Offset = "0x696A140", VA = "0x18696B740")]
	public OEGBNAHMNGM IIILCBLCHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x696B650", Offset = "0x696A050", VA = "0x18696B650")]
	public static ExitGames.Client.Photon.Hashtable HGOBECNKDLP(MGKFLOLLHJM CPPFNMDMGHI, OEGBNAHMNGM IGLBDPPIJLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class BIMJDGALDDF
{
	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x696B930", Offset = "0x696A330", VA = "0x18696B930")]
	public static bool OEFLELDJBHJ(this MAHIACGDFOP GEGNACPKGBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct GFKNBKJELFK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct ODKFHLKIDNO : IAsyncStateMachine
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
		public GFKNBKJELFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x69866A0", Offset = "0x69850A0", VA = "0x1869866A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x6986880", Offset = "0x6985280", VA = "0x186986880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private readonly CancellationTokenSource NCPJPNOCKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private bool ODKMMAOGKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private Task KPCFMNKKKMJ;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool PCOPBBJPOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x6976F60", Offset = "0x6975960", VA = "0x186976F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6976F90", Offset = "0x6975990", VA = "0x186976F90")]
	public GFKNBKJELFK(CancellationToken CFAFANOFDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6976E50", Offset = "0x6975850", VA = "0x186976E50")]
	[AsyncStateMachine(typeof(ODKFHLKIDNO))]
	public Task JJAIODBOCKJ(Func<CancellationToken, List<Task>> OBIKEJOPOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6976E00", Offset = "0x6975800", VA = "0x186976E00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct MKABEAPCMEL<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct EHDBBGGINKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<LICINJCGCBN<TData>, LJNADPDGEHJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public MKABEAPCMEL<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<LGGHGMLBJFM<LICINJCGCBN<TData>, LJNADPDGEHJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x34FB5B0", Offset = "0x34F9FB0", VA = "0x1834FB5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x34FC700", Offset = "0x34FB100", VA = "0x1834FC700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly FGJDKPICNHD<TGetDataArg, TData> GOGJLAAIIKE;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
	internal MKABEAPCMEL(FGJDKPICNHD<TGetDataArg, TData> COBDDACEALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4046970", Offset = "0x4045370", VA = "0x184046970")]
	[AsyncStateMachine(typeof(MKABEAPCMEL<, >.EHDBBGGINKG))]
	public Task<LGGHGMLBJFM<LICINJCGCBN<TData>, LJNADPDGEHJ>> NPDLBMNEDCP(TGetDataArg CMMMKFHDFNK, string DAOOMKABOGD, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class NCDLELBCHOB
{
	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x28C6120", Offset = "0x28C4B20", VA = "0x1828C6120")]
	public static MKABEAPCMEL<TGetDataArg, TData> OLCPJHCMOKI<TGetDataArg, TData>(FGJDKPICNHD<TGetDataArg, TData> COBDDACEALE)
	{
		return default(MKABEAPCMEL<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct MEEBKELCKCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public readonly int PKPHDKLJAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public readonly int? GAHGFOPMLMB;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x3E026F0", Offset = "0x3E010F0", VA = "0x183E026F0")]
	public MEEBKELCKCC(int PEJCBFELECM, [Optional] int? MNGHLCGAIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6981670", Offset = "0x6980070", VA = "0x186981670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface KCIEKIKOHBA<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHLEJPNLJIM();

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KCIEKIKOHBA<T> BCNNAMNICJC(string ILKDLNCOGIL);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KCIEKIKOHBA<T> AJCJPPNBJGK(KIDPKDDBMBF<T> MBKMGNAEPLP);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KCIEKIKOHBA<T> MCIBFCINIGJ(int DBHLKMLCOPG);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KCIEKIKOHBA<T> EPAOLNMDDAG(int DBHLKMLCOPG, DIFAOBFMFIB<T> KKKDKDDJMCO);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface BNGOFEFEHPO
{
	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KCIEKIKOHBA<T> IKAINDOKKJF<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MHNJKLKGIOH HBMFJKMJBAM(Exception PBPEDJNJMOI);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MEEBKELCKCC PBDILKOEBEG(Exception PBPEDJNJMOI);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate string KIDPKDDBMBF<in T>(T PBPEDJNJMOI) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public delegate int DIFAOBFMFIB<in T>(T PBPEDJNJMOI) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class IGIOBHHMDPH : BNGOFEFEHPO
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate string CJFFLOHEJCP(Exception PBPEDJNJMOI);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private delegate int OKFKMNCDAKA(Exception PBPEDJNJMOI);

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class NLEAFNELKJG<T> : KCIEKIKOHBA<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class KGLCPHAIOPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public KGLCPHAIOPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
			internal string GCJIJCHMNIM(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class GFPOPCAOKAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public KIDPKDDBMBF<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public GFPOPCAOKAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x39629A0", Offset = "0x39613A0", VA = "0x1839629A0")]
			internal string BDEBHNDJJFM(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class INIJPHKJPBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public DIFAOBFMFIB<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public INIJPHKJPBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x39629A0", Offset = "0x39613A0", VA = "0x1839629A0")]
			internal int NKAODGKGEIO(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly IGIOBHHMDPH OINDEMFPBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private readonly Type AMJPOLJGBOI;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x40E3930", Offset = "0x40E2330", VA = "0x1840E3930")]
		internal NLEAFNELKJG(IGIOBHHMDPH OINDEMFPBME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x40E3900", Offset = "0x40E2300", VA = "0x1840E3900", Slot = "4")]
		public void MHLEJPNLJIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x40E36A0", Offset = "0x40E20A0", VA = "0x1840E36A0", Slot = "5")]
		public KCIEKIKOHBA<T> BCNNAMNICJC(string ILKDLNCOGIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x40E35A0", Offset = "0x40E1FA0", VA = "0x1840E35A0", Slot = "6")]
		public KCIEKIKOHBA<T> AJCJPPNBJGK(KIDPKDDBMBF<T> MBKMGNAEPLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x40E38C0", Offset = "0x40E22C0", VA = "0x1840E38C0", Slot = "7")]
		public KCIEKIKOHBA<T> MCIBFCINIGJ(int DBHLKMLCOPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x40E37A0", Offset = "0x40E21A0", VA = "0x1840E37A0", Slot = "8")]
		public KCIEKIKOHBA<T> EPAOLNMDDAG(int DBHLKMLCOPG, DIFAOBFMFIB<T> KKKDKDDJMCO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class DNNNNENJMKC<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private bool JBMBODDHKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly List<Type> JOJAMKFNLII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private readonly Dictionary<Type, TVal> HFKIIPKKGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private readonly Dictionary<Type, int> EJJCBKLPOND;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public IReadOnlyList<Type> JHIIKJEEKKA
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x5277B50", Offset = "0x5276550", VA = "0x185277B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5277CB0", Offset = "0x52766B0", VA = "0x185277CB0")]
		public DNNNNENJMKC(Dictionary<Type, int> EJJCBKLPOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x5277860", Offset = "0x5276260", VA = "0x185277860")]
		public void BIPEDCDHLGG(Type KLDFLAABJKH, TVal OONFDHNBOBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x5277AD0", Offset = "0x52764D0", VA = "0x185277AD0")]
		public bool HFMAAJPKNKE(Type AMJPOLJGBOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5277A90", Offset = "0x5276490", VA = "0x185277A90")]
		public bool DEKGIPHGOOI(TVal AEJBOLFACJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x5277B10", Offset = "0x5276510", VA = "0x185277B10")]
		public TVal OIFPBAJNOAG(Type CGEOAHHPHHK)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5277950", Offset = "0x5276350", VA = "0x185277950")]
		[CompilerGenerated]
		private int CMKMFNBNGDN(Type AMPHDJGEIDG, Type EALIOIJKLGK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class NLLGLDDOLGG : IEnumerable<MEEBKELCKCC>, IEnumerable, IEnumerator<MEEBKELCKCC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private MEEBKELCKCC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public IGIOBHHMDPH <>4__this;

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
		private IEnumerator<MEEBKELCKCC> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		private MEEBKELCKCC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x357F180", Offset = "0x357DB80", VA = "0x18357F180", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MEEBKELCKCC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x69859B0", Offset = "0x69843B0", VA = "0x1869859B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x820E60", Offset = "0x81F860", VA = "0x180820E60")]
		[DebuggerHidden]
		public NLLGLDDOLGG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6985A00", Offset = "0x6984400", VA = "0x186985A00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x69853F0", Offset = "0x6983DF0", VA = "0x1869853F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x69853A0", Offset = "0x6983DA0", VA = "0x1869853A0")]
		private void AOIIEBMEGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x6985350", Offset = "0x6983D50", VA = "0x186985350")]
		private void AFFHFGLBOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x6985960", Offset = "0x6984360", VA = "0x186985960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x69858A0", Offset = "0x69842A0", VA = "0x1869858A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MEEBKELCKCC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x69858A0", Offset = "0x69842A0", VA = "0x1869858A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private static readonly MEEBKELCKCC KKEFHGKEICI;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private static readonly Dictionary<Type, int> OIIIIBAHPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly HashSet<Type> PCJLOIDAFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly DNNNNENJMKC<int> MHICHBIBCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly DNNNNENJMKC<OKFKMNCDAKA> GKJNHGEOMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private readonly DNNNNENJMKC<CJFFLOHEJCP> GEFFMKOONFJ;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x697D180", Offset = "0x697BB80", VA = "0x18697D180")]
	[JCOMPLNHMEG(AOHDMBIABEL.GameOnly)]
	private static void GHEMDLAGGBM(ICKBMMGCCPN AIGNNHACHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x697DA80", Offset = "0x697C480", VA = "0x18697DA80")]
	[RecRoom.NoEngine.Common.Preserve]
	public IGIOBHHMDPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x271BA70", Offset = "0x271A470", VA = "0x18271BA70", Slot = "4")]
	public KCIEKIKOHBA<T> IKAINDOKKJF<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x697D1F0", Offset = "0x697BBF0", VA = "0x18697D1F0", Slot = "5")]
	public MHNJKLKGIOH HBMFJKMJBAM(Exception PBPEDJNJMOI)
	{
		return default(MHNJKLKGIOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x697D630", Offset = "0x697C030", VA = "0x18697D630", Slot = "6")]
	public MEEBKELCKCC PBDILKOEBEG(Exception? PBPEDJNJMOI)
	{
		return default(MEEBKELCKCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x697CA20", Offset = "0x697B420", VA = "0x18697CA20", Slot = "7")]
	[IteratorStateMachine(typeof(NLLGLDDOLGG))]
	public IEnumerable<MEEBKELCKCC> DAPEHHCKCBF(Exception PBPEDJNJMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x697C8D0", Offset = "0x697B2D0", VA = "0x18697C8D0", Slot = "8")]
	public string DAKNDBGHMDF(Exception? PBPEDJNJMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x697CAC0", Offset = "0x697B4C0", VA = "0x18697CAC0")]
	private string DDKHKPIPMJD(AggregateException JEGGNEPIALN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x697CDD0", Offset = "0x697B7D0", VA = "0x18697CDD0")]
	private void FKDHFHIKLDG(Type AMJPOLJGBOI, int DBHLKMLCOPG, OKFKMNCDAKA? GFOJNNBOEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x697C680", Offset = "0x697B080", VA = "0x18697C680")]
	private void CLKKCKGACKC(Type AMJPOLJGBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x697D280", Offset = "0x697BC80", VA = "0x18697D280")]
	private void LNLGMAOALEO(Type AMJPOLJGBOI, CJFFLOHEJCP FJOHINIEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x697D830", Offset = "0x697C230", VA = "0x18697D830")]
	private static int PNGLAHJEDHE(Type AMJPOLJGBOI, Dictionary<Type, int> EJJCBKLPOND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x297D9A0", Offset = "0x297C3A0", VA = "0x18297D9A0")]
	private static bool ILNHOGPPMHK<TVal>(DNNNNENJMKC<TVal> KCNHIGOABNO, Type AMJPOLJGBOI, [Out] TVal AEJBOLFACJC) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x697D550", Offset = "0x697BF50", VA = "0x18697D550")]
	[CompilerGenerated]
	internal static int OJODBOBOJCN(Type AFBNKDBFENL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct MHNJKLKGIOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public readonly MEEBKELCKCC DCDHHICJMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public readonly string HFDNPIJDPGN;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x6982780", Offset = "0x6981180", VA = "0x186982780")]
	public MHNJKLKGIOH(string GMBHLLOLCAH, MEEBKELCKCC DBHLKMLCOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x69826E0", Offset = "0x69810E0", VA = "0x1869826E0")]
	public string GGMFPOMNLDM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class BPMFCGNIGPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private readonly IDGHBMDOALG GLDFGEHKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private string FDHFNBEMBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? JBEMNMLENBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private long? AAPKKDDLMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private long? OJILCPLDBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private string AHCJHEJCJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private OCJMNEDPIJP OIJNGKJOCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private long? LAELOFCLNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private bool FMOHBPAHHAJ;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string IINIGBGAKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public long JBKFKNMMNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x696D190", Offset = "0x696BB90", VA = "0x18696D190")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long FFNAGKKEKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x696D010", Offset = "0x696BA10", VA = "0x18696D010")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public long NCOJAFJIDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x696CB20", Offset = "0x696B520", VA = "0x18696CB20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public string AHPOHEFAPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x696D150", Offset = "0x696BB50", VA = "0x18696D150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public OCJMNEDPIJP JKFANOLDAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xDE4200", Offset = "0xDE2C00", VA = "0x180DE4200")]
		get
		{
			return default(OCJMNEDPIJP);
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x696D860", Offset = "0x696C260", VA = "0x18696D860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public long OOKMJGGMLBA
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x696D0F0", Offset = "0x696BAF0", VA = "0x18696D0F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x696D950", Offset = "0x696C350", VA = "0x18696D950")]
	[UnityEngine.Scripting.Preserve]
	public BPMFCGNIGPG([JDJLHBHAJCP(null)] IDGHBMDOALG GLDFGEHKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x696D610", Offset = "0x696C010", VA = "0x18696D610")]
	private void PKIPGHOPEGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x696CB80", Offset = "0x696B580", VA = "0x18696CB80")]
	public void CJKHOLBONML(long ECEDKLNOLLD, long AJIFLLNCAHB, [Optional] long? LPGMBLOCNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x696D1F0", Offset = "0x696BBF0", VA = "0x18696D1F0")]
	public void MCLODFDGGOP(long LPGMBLOCNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x696D070", Offset = "0x696BA70", VA = "0x18696D070")]
	public void DPBEBOKNGOH(string ADBLBKANJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x696D290", Offset = "0x696BC90", VA = "0x18696D290")]
	public void NFIBJJGNMEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class FBDPEEPOBOM : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct DKLJOFKGCGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public AsyncTaskMethodBuilder<MGKFLOLLHJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public MGKFLOLLHJM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public FBDPEEPOBOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private TaskAwaiter<CGLEINIGDMO.HFAJKCCHKCD<MGKFLOLLHJM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x696FAB0", Offset = "0x696E4B0", VA = "0x18696FAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x696FFE0", Offset = "0x696E9E0", VA = "0x18696FFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct KHECOMMLKGH<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class CENJDBLMLEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public MGKFLOLLHJM roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public CENJDBLMLEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x696E260", Offset = "0x696CC60", VA = "0x18696E260")]
		internal MGKFLOLLHJM EGEDIHDCEAL(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct FGMEGPEOMEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public AsyncTaskMethodBuilder<CGLEINIGDMO.HFAJKCCHKCD<MGKFLOLLHJM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public MGKFLOLLHJM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public FBDPEEPOBOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private NGLCPKINBJL <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private TaskAwaiter<CGLEINIGDMO.HFAJKCCHKCD<MGKFLOLLHJM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x6974050", Offset = "0x6972A50", VA = "0x186974050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6974660", Offset = "0x6973060", VA = "0x186974660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct OMNIBJDGODG<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public FBDPEEPOBOM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x42242B0", Offset = "0x4222CB0", VA = "0x1842242B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x35113D0", Offset = "0x350FDD0", VA = "0x1835113D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct LCKLFGALILE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public FBDPEEPOBOM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6980E50", Offset = "0x697F850", VA = "0x186980E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x6981010", Offset = "0x697FA10", VA = "0x186981010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class FBCJAGADELD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public FBCJAGADELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x6972C30", Offset = "0x6971630", VA = "0x186972C30")]
		internal object HIJEKJHNPGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x6972C90", Offset = "0x6971690", VA = "0x186972C90")]
		internal bool KINAECJPEOE(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class ONHMMEAFHII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public ONHMMEAFHII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x6987B40", Offset = "0x6986540", VA = "0x186987B40")]
		internal object IOLNBFAGMOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class DKGDDLFAIKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public DKGDDLFAIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x696FA00", Offset = "0x696E400", VA = "0x18696FA00")]
		internal object KOBBJIGMJGC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class ABEIGDMCOGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public ABEIGDMCOGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x696A630", Offset = "0x6969030", VA = "0x18696A630")]
		internal object AKFBEPCDOMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class MFIEJHBDFAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public FBDPEEPOBOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public MFIEJHBDFAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x6981BD0", Offset = "0x69805D0", VA = "0x186981BD0")]
		internal object HJIMNJBAIMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Guid KKJGHLLDENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public readonly EIPPLJBOIII KCNGPFNLELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly CGLEINIGDMO GEFGNINHDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly FGHLKIMCOFO LKKONKMIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly LCPOHDBDLPL FNDGKICFDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private bool LOILKEMNFBP;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6973E20", Offset = "0x6972820", VA = "0x186973E20")]
	public FBDPEEPOBOM(EIPPLJBOIII EHNGFDOGIGP, CGLEINIGDMO GEFGNINHDGE, FGHLKIMCOFO LKKONKMIDFE, LCPOHDBDLPL FNDGKICFDCB, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6973010", Offset = "0x6971A10", VA = "0x186973010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x6973010", Offset = "0x6971A10", VA = "0x186973010")]
	public void DMANFLIALDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6973A30", Offset = "0x6972430", VA = "0x186973A30")]
	public void JPMOFGDGKHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6973130", Offset = "0x6971B30", VA = "0x186973130")]
	public void DOCNEFNJBJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6972D50", Offset = "0x6971750", VA = "0x186972D50")]
	[AsyncStateMachine(typeof(DKLJOFKGCGA))]
	internal Task<MGKFLOLLHJM> APGELMOALEF(MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, MGKFLOLLHJM LFBGOIPNMIA, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2931A00", Offset = "0x2930400", VA = "0x182931A00")]
	private static byte[] BLKMDMLAAOJ<T>(T CPPFNMDMGHI) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2931A10", Offset = "0x2930410", VA = "0x182931A10")]
	private static T DEFFODFFNAB<T>(MessageParser<T> ABPGJMFGBPB, byte[] CPPFNMDMGHI, T MMBMIJCDMIO) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x69733D0", Offset = "0x6971DD0", VA = "0x1869733D0")]
	[AsyncStateMachine(typeof(FGMEGPEOMEJ))]
	private Task<CGLEINIGDMO.HFAJKCCHKCD<MGKFLOLLHJM>> GNJDPFPNJAD(MGKFLOLLHJM LFBGOIPNMIA, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2931F00", Offset = "0x2930900", VA = "0x182931F00")]
	[AsyncStateMachine(typeof(OMNIBJDGODG<>))]
	internal Task<T> NBOFOLACDKH<T>(CancellationToken GKJHCAJJFHD, Func<CancellationToken, Task<T>> DGGCFLANAJD, int EKJOGLFOGCK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6973C00", Offset = "0x6972600", VA = "0x186973C00")]
	[AsyncStateMachine(typeof(LCKLFGALILE))]
	internal Task NBOFOLACDKH(CancellationToken GKJHCAJJFHD, Func<CancellationToken, Task> DGGCFLANAJD, int EKJOGLFOGCK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6973D30", Offset = "0x6972730", VA = "0x186973D30")]
	public OGPHKDBMFMF PHBHEGNJDEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x69731F0", Offset = "0x6971BF0", VA = "0x1869731F0")]
	public KBJGCMGNIDH GEDDNEEDOCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x69737D0", Offset = "0x69721D0", VA = "0x1869737D0")]
	public OIBIAMJHLID HKBOMAJGMMD([Optional] LBNENDFDEJK? EMEAPIGMNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6973270", Offset = "0x6971C70", VA = "0x186973270")]
	public void GKBLBNMOGDI(Func<Guid, bool> MBKHHABBNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6973AF0", Offset = "0x69724F0", VA = "0x186973AF0")]
	public void LHLIJEHDLGE(Func<Guid, bool> OMMDPHOBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6973650", Offset = "0x6972050", VA = "0x186973650")]
	public Guid HFGFHJGHDEJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6972F00", Offset = "0x6971900", VA = "0x186972F00")]
	public void CHBBALCPJHN(Guid AEDJFHIHLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6973510", Offset = "0x6971F10", VA = "0x186973510")]
	public void GPNCMNNAONM(MGKFLOLLHJM OKHNPKJFPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6973920", Offset = "0x6972320", VA = "0x186973920")]
	public void IGGHFJOIHIE(string PMHCMOKOMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2931E10", Offset = "0x2930810", VA = "0x182931E10")]
	private T FFIHNIPJGEI<T>(T AEJBOLFACJC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6972EB0", Offset = "0x69718B0", VA = "0x186972EB0")]
	public void BGIBIINIFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2931B60", Offset = "0x2930560", VA = "0x182931B60")]
	[CompilerGenerated]
	internal static string DJEHNHKPJNM<T>(byte[] OIKPPLLAJOB, int AFOAGHLPAEE, KHECOMMLKGH<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal sealed class DMKHLNLEIGE : EIPPLJBOIII
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class AFNGLOLOFEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public AFNGLOLOFEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x6989F20", Offset = "0x6988920", VA = "0x186989F20")]
		internal object HEGCCNDNBKB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct KJPPGIOKHFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public DMKHLNLEIGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public FBDPEEPOBOM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private GABCKPOPJNO <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private KBJGCMGNIDH <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x6999A50", Offset = "0x6998450", VA = "0x186999A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x699A320", Offset = "0x6998D20", VA = "0x18699A320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct FGANEFLJKIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public DMKHLNLEIGE <>4__this;

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
		private TaskAwaiter<ECLKAFGMDKO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x69901A0", Offset = "0x698EBA0", VA = "0x1869901A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x6990950", Offset = "0x698F350", VA = "0x186990950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct JJHNFIDPHNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public DMKHLNLEIGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter<NCDAEICGONM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x6994100", Offset = "0x6992B00", VA = "0x186994100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x6994410", Offset = "0x6992E10", VA = "0x186994410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class HHNIFKFEADN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public GABCKPOPJNO presence;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HHNIFKFEADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6991A60", Offset = "0x6990460", VA = "0x186991A60")]
		internal object ALAMBBHLFAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly LBNENDFDEJK EAMANJFKCMK;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly LBNENDFDEJK MOJGOOCCMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly EOCBFNOLIGO CEDHAAHJMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly MAHIACGDFOP FHMAHLBPECD;

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x698E1E0", Offset = "0x698CBE0", VA = "0x18698E1E0")]
	public DMKHLNLEIGE(EOCBFNOLIGO CEDHAAHJMGO, MAHIACGDFOP FHMAHLBPECD, Guid ALJDBMFHGKI, JAPLGPCNONK JKFKIODGCMA, EGMIDFNMIDN DFDPMGKFIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x698DBD0", Offset = "0x698C5D0", VA = "0x18698DBD0", Slot = "7")]
	[AsyncStateMachine(typeof(KJPPGIOKHFO))]
	protected override Task LBKIIJLNEDE(FBDPEEPOBOM HENFFFIHANH, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x698DD10", Offset = "0x698C710", VA = "0x18698DD10")]
	[AsyncStateMachine(typeof(FGANEFLJKIK))]
	private Task LPGDNMOOJDN(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x698DFF0", Offset = "0x698C9F0", VA = "0x18698DFF0")]
	[AsyncStateMachine(typeof(JJHNFIDPHNK))]
	private Task<byte> PHJBMBHHHKI(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x698DE10", Offset = "0x698C810", VA = "0x18698DE10")]
	private GABCKPOPJNO PBPFFEECIBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class PIFGBDPLPJI : EIPPLJBOIII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct CMELGMEPNFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public PIFGBDPLPJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public FBDPEEPOBOM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private TaskAwaiter<GAGPEDFBJMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x698D1F0", Offset = "0x698BBF0", VA = "0x18698D1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x698DB70", Offset = "0x698C570", VA = "0x18698DB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private readonly int GLPBFMMOLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private readonly JDLHDFPPGKG AJKANDNNPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public readonly long FIADJEADKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public readonly long LBEOICMINFH;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public GAGPEDFBJMI PBNKNINDGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA10", Offset = "0x7CE410", VA = "0x1807CFA10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x7CF970", Offset = "0x7CE370", VA = "0x1807CF970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x699F630", Offset = "0x699E030", VA = "0x18699F630")]
	public PIFGBDPLPJI(Guid ALJDBMFHGKI, JAPLGPCNONK JKFKIODGCMA, EGMIDFNMIDN DFDPMGKFIPM, int GLPBFMMOLGF, JDLHDFPPGKG AJKANDNNPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x699F510", Offset = "0x699DF10", VA = "0x18699F510", Slot = "7")]
	[AsyncStateMachine(typeof(CMELGMEPNFO))]
	protected override Task LBKIIJLNEDE(FBDPEEPOBOM HENFFFIHANH, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal abstract class ENIGBBBALPM : EIPPLJBOIII
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class MMBCPJEMKFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public ENIGBBBALPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AKNHJFEHBBJ playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public MMBCPJEMKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x699D870", Offset = "0x699C270", VA = "0x18699D870")]
		internal Task GKMDJKNFINC(MJHALEONFCB<string>.KDBHCAJIBOE postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x699D8B0", Offset = "0x699C2B0", VA = "0x18699D8B0")]
		internal object LJKIIMMFOFL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct JPKBFFCAANO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public ENIGBBBALPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public FBDPEEPOBOM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private MMBCPJEMKFI <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x69956E0", Offset = "0x69940E0", VA = "0x1869956E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6995EA0", Offset = "0x69948A0", VA = "0x186995EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct LINLLOOCEHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public AKNHJFEHBBJ playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public ENIGBBBALPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x699C0E0", Offset = "0x699AAE0", VA = "0x18699C0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x699C670", Offset = "0x699B070", VA = "0x18699C670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x69900D0", Offset = "0x698EAD0", VA = "0x1869900D0")]
	public ENIGBBBALPM(Guid ALJDBMFHGKI, JAPLGPCNONK JKFKIODGCMA, EGMIDFNMIDN DFDPMGKFIPM, string FJEMEKDDPLN, MEONJBAFIMN NKLEJPMJNHG, bool EHOEKGCODCO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x698FE50", Offset = "0x698E850", VA = "0x18698FE50", Slot = "7")]
	[AsyncStateMachine(typeof(JPKBFFCAANO))]
	protected override Task LBKIIJLNEDE(FBDPEEPOBOM HENFFFIHANH, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task KGKFDGDDIMD(FBDPEEPOBOM HENFFFIHANH, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x698FF90", Offset = "0x698E990", VA = "0x18698FF90")]
	[AsyncStateMachine(typeof(LINLLOOCEHJ))]
	private Task LPCJOPPNLME(IDisposable FJDAAPLFDLO, AKNHJFEHBBJ NMENDNIIKNH, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class PMAEFPJHBGB : EIPPLJBOIII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct CMECLLICEBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public PMAEFPJHBGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public FBDPEEPOBOM operationContext;

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
		private TaskAwaiter<NIPEHLMICJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x698CC20", Offset = "0x698B620", VA = "0x18698CC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x698D190", Offset = "0x698BB90", VA = "0x18698D190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private readonly OONOEGKKCEB LAGEFEKOMON;

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x699F960", Offset = "0x699E360", VA = "0x18699F960")]
	public PMAEFPJHBGB(Guid ALJDBMFHGKI, JAPLGPCNONK JKFKIODGCMA, EGMIDFNMIDN DFDPMGKFIPM, OONOEGKKCEB LAGEFEKOMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x699F760", Offset = "0x699E160", VA = "0x18699F760", Slot = "6")]
	protected override string AINKIANEPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x699F840", Offset = "0x699E240", VA = "0x18699F840", Slot = "7")]
	[AsyncStateMachine(typeof(CMECLLICEBP))]
	protected override Task LBKIIJLNEDE(FBDPEEPOBOM HENFFFIHANH, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal abstract class EIPPLJBOIII : ODHBDMIJJEC
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public delegate Task CAOGIMIPAHL(MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class MMGJPGLOCNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public MJHALEONFCB<string>.KDBHCAJIBOE operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public EIPPLJBOIII <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public MMGJPGLOCNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x699D940", Offset = "0x699C340", VA = "0x18699D940")]
		internal Task NJEELAMFJMM(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class OCHNCOLLGFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public MMGJPGLOCNM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public OCHNCOLLGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x699E860", Offset = "0x699D260", VA = "0x18699E860")]
		internal object LAINCJCGLFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x699E920", Offset = "0x699D320", VA = "0x18699E920")]
		internal object LMBIEPFKLDK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct JMEFJIAEEBF : IAsyncStateMachine
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
		public EIPPLJBOIII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public Func<EIPPLJBOIII, MJHALEONFCB<string>.KDBHCAJIBOE, FBDPEEPOBOM> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private MMGJPGLOCNM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private FBDPEEPOBOM <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter<MGKFLOLLHJM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6994480", Offset = "0x6992E80", VA = "0x186994480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6995680", Offset = "0x6994080", VA = "0x186995680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct HKMGHEKKCGN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6992110", Offset = "0x6990B10", VA = "0x186992110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6992B90", Offset = "0x6991590", VA = "0x186992B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct MHHLMNGMKCN : IAsyncStateMachine
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
		public EIPPLJBOIII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x699D4B0", Offset = "0x699BEB0", VA = "0x18699D4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x699D810", Offset = "0x699C210", VA = "0x18699D810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly Guid OKBMHFPHNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public readonly ByteString NKNGHCEKCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public readonly EGMIDFNMIDN DOOLLPKIJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	protected readonly string ICOELFMMEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly bool EHOEKGCODCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly Queue<CAOGIMIPAHL> KKDINMOPDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly PMHGABOONOO BJDNKPMMAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly MEONJBAFIMN NKLEJPMJNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private bool JIHPMHCHMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public OCJMNEDPIJP KJFKCAEOFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public OCJMNEDPIJP OAIIGMAHJOO;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public JAPLGPCNONK MOOGKMKFKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public KLGILBCOHEN KHOMGDACNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x698F3C0", Offset = "0x698DDC0", VA = "0x18698F3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public MPLKMCGCGNJ JONFKHHFPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x698FCA0", Offset = "0x698E6A0", VA = "0x18698FCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public GLMLMHBFNJA BEHNCOLJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x698FAD0", Offset = "0x698E4D0", VA = "0x18698FAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event BPFENBAHPOO HJBHKMOKJJG
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x698F530", Offset = "0x698DF30", VA = "0x18698F530", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x698F810", Offset = "0x698E210", VA = "0x18698F810", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x698FCF0", Offset = "0x698E6F0", VA = "0x18698FCF0")]
	protected EIPPLJBOIII(Guid ALJDBMFHGKI, JAPLGPCNONK JKFKIODGCMA, EGMIDFNMIDN DFDPMGKFIPM, string FJEMEKDDPLN, MEONJBAFIMN NKLEJPMJNHG, bool EHOEKGCODCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x698F380", Offset = "0x698DD80", VA = "0x18698F380", Slot = "6")]
	protected virtual string AINKIANEPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x698FC40", Offset = "0x698E640", VA = "0x18698FC40")]
	public void PIIBPJGOBKE(CAOGIMIPAHL AIHLNHANNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x698F7F0", Offset = "0x698E1F0", VA = "0x18698F7F0")]
	protected void GDABANLCALA(float KDAABOPFDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x698F980", Offset = "0x698E380", VA = "0x18698F980")]
	[AsyncStateMachine(typeof(JMEFJIAEEBF))]
	public Task JGEDHJJKDOM(CancellationToken CFAFANOFDNJ, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, [Optional] Func<EIPPLJBOIII, MJHALEONFCB<string>.KDBHCAJIBOE, FBDPEEPOBOM> IIDJEOEOOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x698F6C0", Offset = "0x698E0C0", VA = "0x18698F6C0")]
	[AsyncStateMachine(typeof(HKMGHEKKCGN))]
	private static Task GCBMGDIFGPD(Func<CancellationToken, Task> EJMFFBLFOGL, Func<CancellationToken, Task> EBHHJAIKKGK, CancellationToken GKJHCAJJFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x698F830", Offset = "0x698E230", VA = "0x18698F830")]
	private void IMHCPHHAOMN(bool ODHGHOOKBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x698FB50", Offset = "0x698E550", VA = "0x18698FB50")]
	private void LPHKJPDEBCA(FBDPEEPOBOM HENFFFIHANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task LBKIIJLNEDE(FBDPEEPOBOM HENFFFIHANH, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x698F410", Offset = "0x698DE10", VA = "0x18698F410")]
	[AsyncStateMachine(typeof(MHHLMNGMKCN))]
	private Task DIOOILCMCPB(MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x698F640", Offset = "0x698E040", VA = "0x18698F640")]
	public MGKFLOLLHJM EGHEBPBEEDA(NGLCPKINBJL HGHBNCPODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x698F550", Offset = "0x698DF50", VA = "0x18698F550")]
	[CompilerGenerated]
	private Task EFNGKBKODIE(CancellationToken BIKAIHEBIHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal sealed class LMLAMACNNIB : ENIGBBBALPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct CKICLGJAMEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public LMLAMACNNIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public FBDPEEPOBOM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private BONPCGFBDHP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private KBJGCMGNIDH <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x698C450", Offset = "0x698AE50", VA = "0x18698C450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x698CBC0", Offset = "0x698B5C0", VA = "0x18698CBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly EOCBFNOLIGO JMCCABMEAAF;

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x699CFF0", Offset = "0x699B9F0", VA = "0x18699CFF0")]
	public LMLAMACNNIB(Guid ALJDBMFHGKI, JAPLGPCNONK JKFKIODGCMA, EOCBFNOLIGO JMCCABMEAAF, EGMIDFNMIDN DFDPMGKFIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x699CEA0", Offset = "0x699B8A0", VA = "0x18699CEA0", Slot = "8")]
	[AsyncStateMachine(typeof(CKICLGJAMEJ))]
	protected override Task KGKFDGDDIMD(FBDPEEPOBOM HENFFFIHANH, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class NHLCCPAMGCJ : EIPPLJBOIII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct MELBIILJNCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public NHLCCPAMGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public FBDPEEPOBOM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter<NIPEHLMICJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x699D0A0", Offset = "0x699BAA0", VA = "0x18699D0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x699D450", Offset = "0x699BE50", VA = "0x18699D450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private readonly string MDFNAKKODPN;

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x699E7B0", Offset = "0x699D1B0", VA = "0x18699E7B0")]
	public NHLCCPAMGCJ(Guid ALJDBMFHGKI, JAPLGPCNONK JKFKIODGCMA, EGMIDFNMIDN DFDPMGKFIPM, string MDFNAKKODPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x699E6A0", Offset = "0x699D0A0", VA = "0x18699E6A0", Slot = "7")]
	[AsyncStateMachine(typeof(MELBIILJNCE))]
	protected override Task LBKIIJLNEDE(FBDPEEPOBOM HENFFFIHANH, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class BCBGLIPDMPJ : ENIGBBBALPM
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class BMNAEFOJEEC
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
			public AsyncTaskMethodBuilder<MGKFLOLLHJM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public BMNAEFOJEEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private TaskAwaiter<NIPEHLMICJG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<MGKFLOLLHJM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x69A2A50", Offset = "0x69A1450", VA = "0x1869A2A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x69A2F10", Offset = "0x69A1910", VA = "0x1869A2F10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public BCBGLIPDMPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public OIBIAMJHLID serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public MKGDDLJDIFL roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public OGPHKDBMFMF uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public LICAEKIJOKL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BMNAEFOJEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x698BE90", Offset = "0x698A890", VA = "0x18698BE90")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<MGKFLOLLHJM> EPAADDKHJHC(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct KDCKDIOOFKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public BCBGLIPDMPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public FBDPEEPOBOM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private BMNAEFOJEEC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private BONPCGFBDHP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private KBJGCMGNIDH <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private MGKFLOLLHJM <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter<MGKFLOLLHJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x6997AA0", Offset = "0x69964A0", VA = "0x186997AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x6998A00", Offset = "0x6997400", VA = "0x186998A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly LBNENDFDEJK EAMANJFKCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private readonly int PGELEHPHLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	[CanBeNull]
	private readonly NDGDGDKEFLE BGJPIGKNAII;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x698B640", Offset = "0x698A040", VA = "0x18698B640")]
	public BCBGLIPDMPJ(Guid ALJDBMFHGKI, JAPLGPCNONK JKFKIODGCMA, int PGELEHPHLNL, NDGDGDKEFLE BGJPIGKNAII, EGMIDFNMIDN DFDPMGKFIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x698B450", Offset = "0x6989E50", VA = "0x18698B450", Slot = "8")]
	[AsyncStateMachine(typeof(KDCKDIOOFKB))]
	protected override Task KGKFDGDDIMD(FBDPEEPOBOM HENFFFIHANH, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x698B180", Offset = "0x6989B80", VA = "0x18698B180")]
	private void BPBHBLHNPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x698B280", Offset = "0x6989C80", VA = "0x18698B280")]
	private void IMFDEAEKGAN(MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, BONPCGFBDHP CGKFKLNGHMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal abstract class JBEKAIAHCDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly EIPPLJBOIII KCNGPFNLELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly FBDPEEPOBOM LEAPGLDBFBJ;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public KLGILBCOHEN KHOMGDACNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x6993800", Offset = "0x6992200", VA = "0x186993800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GLMLMHBFNJA BEHNCOLJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x6993870", Offset = "0x6992270", VA = "0x186993870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6993900", Offset = "0x6992300", VA = "0x186993900")]
	protected JBEKAIAHCDO(FBDPEEPOBOM HENFFFIHANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6993850", Offset = "0x6992250", VA = "0x186993850")]
	protected void IGGHFJOIHIE(string PMHCMOKOMPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct BIDBCNECBHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public Dictionary<Guid, List<HEJNOLGJKNH>> DKDOCHNCGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public Dictionary<Guid, List<HEJNOLGJKNH>> DOFLLOLCBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public Dictionary<Guid, List<HEJNOLGJKNH>> MLJAJJMJLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public List<Guid> MHBHOJOOJCG;

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x698B6F0", Offset = "0x698A0F0", VA = "0x18698B6F0")]
	public static BIDBCNECBHL OIFPBAJNOAG(KLGILBCOHEN NJALJHMFPEI, OCJMNEDPIJP JJECPPOKNCG, GCGKJJGGALM MNINLOIAGHJ)
	{
		return default(BIDBCNECBHL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct KPFAGDINFGL
{
	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0")]
	public static KPFAGDINFGL HGOBECNKDLP()
	{
		return default(KPFAGDINFGL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct EOECGNFFFNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly ECLKAFGMDKO CCHMHHHHDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly LIDLODHMGJG KPBHDENHEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly string BJOJEPMOEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly JAPDNPEKOGE AOFALACDKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public readonly JAPDNPEKOGE GPDJPBDMFGA;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6990120", Offset = "0x698EB20", VA = "0x186990120")]
	public EOECGNFFFNA(ECLKAFGMDKO CCHMHHHHDAL, LIDLODHMGJG KPBHDENHEED, string BJOJEPMOEAN, JAPDNPEKOGE AOFALACDKEP, JAPDNPEKOGE GPDJPBDMFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct KJBDGIDENHI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly FBDPEEPOBOM HENFFFIHANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly Guid AEDJFHIHLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private bool ODHGHOOKBIP;

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x69999A0", Offset = "0x69983A0", VA = "0x1869999A0")]
	public static KJBDGIDENHI HFGFHJGHDEJ(FBDPEEPOBOM HENFFFIHANH)
	{
		return default(KJBDGIDENHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x862590", Offset = "0x860F90", VA = "0x180862590")]
	public void GJNCILCCFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x6999940", Offset = "0x6998340", VA = "0x186999940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x6999A00", Offset = "0x6998400", VA = "0x186999A00")]
	private KJBDGIDENHI(FBDPEEPOBOM HENFFFIHANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x6999940", Offset = "0x6998340", VA = "0x186999940")]
	private void CHBBALCPJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x69998A0", Offset = "0x69982A0", VA = "0x1869998A0")]
	private Func<Guid, bool> ADPBJAEHIDI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class KBJGCMGNIDH : JBEKAIAHCDO, ODHBDMIJJEC
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public delegate Task<OCJMNEDPIJP> NDEIAHHMNML(GCGKJJGGALM ABDLEBPKDKC, JCHCBFBFGLO EMLIEIGDOEJ, PMHGABOONOO OMHHEPBDKPN, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct LMDNNNNIMPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public EOCBFNOLIGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private KJBDGIDENHI <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private TaskAwaiter<MGKFLOLLHJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x699C6D0", Offset = "0x699B0D0", VA = "0x18699C6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x699CE40", Offset = "0x699B840", VA = "0x18699CE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct KEMACILJCML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public AsyncTaskMethodBuilder<MGKFLOLLHJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public EOCBFNOLIGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<MGKFLOLLHJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x6998A60", Offset = "0x6997460", VA = "0x186998A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x6998E70", Offset = "0x6997870", VA = "0x186998E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct JEDBPMMLIKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public EOCBFNOLIGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x6993960", Offset = "0x6992360", VA = "0x186993960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x6993DF0", Offset = "0x69927F0", VA = "0x186993DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class KOOGHPHELNM
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
			public AsyncTaskMethodBuilder<EOECGNFFFNA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public KOOGHPHELNM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			private EOECGNFFFNA <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			private TaskAwaiter<OCJMNEDPIJP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			private TaskAwaiter<EOECGNFFFNA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x69A1110", Offset = "0x699FB10", VA = "0x1869A1110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x69A18A0", Offset = "0x69A02A0", VA = "0x1869A18A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<GCGKJJGGALM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public KOOGHPHELNM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			private GCGKJJGGALM <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			private TaskAwaiter<OCJMNEDPIJP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<GCGKJJGGALM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x69A1910", Offset = "0x69A0310", VA = "0x1869A1910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x69A1F60", Offset = "0x69A0960", VA = "0x1869A1F60", Slot = "5")]
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
			public KOOGHPHELNM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private TaskAwaiter<OCJMNEDPIJP> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private JCHCBFBFGLO <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0x699FD70", Offset = "0x699E770", VA = "0x18699FD70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x69A10B0", Offset = "0x699FAB0", VA = "0x1869A10B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public EOCBFNOLIGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public PMHGABOONOO preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public PMHGABOONOO downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public EOECGNFFFNA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public PMHGABOONOO postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public GCGKJJGGALM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public CLKLNCPJFIK.IDMCFGPNMIA <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public KOOGHPHELNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x699B7B0", Offset = "0x699A1B0", VA = "0x18699B7B0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<EOECGNFFFNA> GPJIOACMKKM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x699BA30", Offset = "0x699A430", VA = "0x18699BA30")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<GCGKJJGGALM> PGNCJNJDIKE(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x699B9F0", Offset = "0x699A3F0", VA = "0x18699B9F0")]
		internal void LGEFMPFEKKF(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x699B8F0", Offset = "0x699A2F0", VA = "0x18699B8F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task KLOIFIDJNIO(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct FONCPEIHCIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EOCBFNOLIGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private KOOGHPHELNM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter<EOECGNFFFNA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private TaskAwaiter<GCGKJJGGALM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x69909B0", Offset = "0x698F3B0", VA = "0x1869909B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x69915C0", Offset = "0x698FFC0", VA = "0x1869915C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct NFHIKOJGHOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x699DF00", Offset = "0x699C900", VA = "0x18699DF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x699E640", Offset = "0x699D040", VA = "0x18699E640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct KFCKHOLGILM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public PMHGABOONOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private TaskAwaiter<OCJMNEDPIJP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6998EE0", Offset = "0x69978E0", VA = "0x186998EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x6999840", Offset = "0x6998240", VA = "0x186999840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct ANABCJKFBNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public AsyncTaskMethodBuilder<OCJMNEDPIJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public PMHGABOONOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter<OCJMNEDPIJP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6989F90", Offset = "0x6988990", VA = "0x186989F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x698B110", Offset = "0x6989B10", VA = "0x18698B110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct KOLGIHPLJCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public AsyncTaskMethodBuilder<OCJMNEDPIJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public PMHGABOONOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public JCHCBFBFGLO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private TaskAwaiter<OCJMNEDPIJP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x699A380", Offset = "0x6998D80", VA = "0x18699A380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x699B740", Offset = "0x699A140", VA = "0x18699B740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct GHKOHOLHDKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public AsyncTaskMethodBuilder<OCJMNEDPIJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public OCJMNEDPIJP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public PMHGABOONOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public GCGKJJGGALM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private TaskAwaiter<OCJMNEDPIJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6991620", Offset = "0x6990020", VA = "0x186991620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x69918B0", Offset = "0x69902B0", VA = "0x1869918B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class MMKIHAMDPMD
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
			public AsyncTaskMethodBuilder<OCJMNEDPIJP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public MMKIHAMDPMD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private OCHDPFMCIOG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			private TaskAwaiter<OCJMNEDPIJP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x69A1FD0", Offset = "0x69A09D0", VA = "0x1869A1FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x69A25F0", Offset = "0x69A0FF0", VA = "0x1869A25F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public PMHGABOONOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public NDEIAHHMNML masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public JCHCBFBFGLO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public OCJMNEDPIJP originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public MMKIHAMDPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x699DA70", Offset = "0x699C470", VA = "0x18699DA70")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<OCJMNEDPIJP> MMCJKAGHEMH(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct HIHACMGODPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AsyncTaskMethodBuilder<OCJMNEDPIJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public PMHGABOONOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public NDEIAHHMNML masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public JCHCBFBFGLO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter<OCJMNEDPIJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x6991BA0", Offset = "0x69905A0", VA = "0x186991BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x69920A0", Offset = "0x6990AA0", VA = "0x1869920A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct LILFGNPINKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public PMHGABOONOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private OCJMNEDPIJP <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private IEnumerator<OCJMNEDPIJP> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private TaskAwaiter<OCJMNEDPIJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x699BB50", Offset = "0x699A550", VA = "0x18699BB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x699C080", Offset = "0x699AA80", VA = "0x18699C080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct PMDHOMCLHCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x699FA00", Offset = "0x699E400", VA = "0x18699FA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x699FD10", Offset = "0x699E710", VA = "0x18699FD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct JEMMOAFIHBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public KBJGCMGNIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x6993E50", Offset = "0x6992850", VA = "0x186993E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x69940A0", Offset = "0x6992AA0", VA = "0x1869940A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly JIIANIOJCIN LLGAGFKGAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly JIIANIOJCIN LPDKEOFAMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly BPMFCGNIGPG HJBINPJGJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly CAABEPNDDGA JOGGPOJPBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly NAIGDLEDCGH EFHIBNFNMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly BHPFCKOAEJC BHDINCNCFKC;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private JAPLGPCNONK MOOGKMKFKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x69966F0", Offset = "0x69950F0", VA = "0x1869966F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event BPFENBAHPOO HJBHKMOKJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x69968A0", Offset = "0x69952A0", VA = "0x1869968A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x6996A30", Offset = "0x6995430", VA = "0x186996A30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x6997800", Offset = "0x6996200", VA = "0x186997800")]
	public KBJGCMGNIDH(FBDPEEPOBOM HENFFFIHANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x69968C0", Offset = "0x69952C0", VA = "0x1869968C0")]
	[AsyncStateMachine(typeof(LMDNNNNIMPF))]
	public Task DMBPKFDAGGH(EOCBFNOLIGO ELBMMMMNOAO, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6996050", Offset = "0x6994A50", VA = "0x186996050")]
	[AsyncStateMachine(typeof(KEMACILJCML))]
	private Task<MGKFLOLLHJM> ADKGAENNKGB(EOCBFNOLIGO ELBMMMMNOAO, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x69972C0", Offset = "0x6995CC0", VA = "0x1869972C0")]
	[AsyncStateMachine(typeof(JEDBPMMLIKF))]
	private Task OBBOHMAOHEI(EOCBFNOLIGO ELBMMMMNOAO, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6996470", Offset = "0x6994E70", VA = "0x186996470")]
	[AsyncStateMachine(typeof(FONCPEIHCIH))]
	private Task BBILBOABGNI(EOCBFNOLIGO ELBMMMMNOAO, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken JGIEHENNNDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6996D20", Offset = "0x6995720", VA = "0x186996D20")]
	[AsyncStateMachine(typeof(NFHIKOJGHOF))]
	private Task KDBHMBDHOAO(MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x6996320", Offset = "0x6994D20", VA = "0x186996320")]
	[AsyncStateMachine(typeof(KFCKHOLGILM))]
	private Task ALIKPICHFJB(GCGKJJGGALM ABDLEBPKDKC, PMHGABOONOO OMHHEPBDKPN, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x6996740", Offset = "0x6995140", VA = "0x186996740")]
	[AsyncStateMachine(typeof(ANABCJKFBNI))]
	private Task<OCJMNEDPIJP> DJHPIOCKAOO(GCGKJJGGALM ABDLEBPKDKC, JCHCBFBFGLO LBHKMHAFDLC, PMHGABOONOO OMHHEPBDKPN, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6997400", Offset = "0x6995E00", VA = "0x186997400")]
	[AsyncStateMachine(typeof(KOLGIHPLJCJ))]
	private Task<OCJMNEDPIJP> OCNKEPCHMGD(GCGKJJGGALM ABDLEBPKDKC, JCHCBFBFGLO LBHKMHAFDLC, PMHGABOONOO OMHHEPBDKPN, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6996FC0", Offset = "0x69959C0", VA = "0x186996FC0")]
	[AsyncStateMachine(typeof(GHKOHOLHDKI))]
	private Task<OCJMNEDPIJP> KJDLHGOLAMF(OCJMNEDPIJP JJECPPOKNCG, GCGKJJGGALM MNINLOIAGHJ, PMHGABOONOO OMHHEPBDKPN, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ, bool PBIIJAIMHNM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6996600", Offset = "0x6995000", VA = "0x186996600")]
	private bool CHDPJPFGKIE(GCGKJJGGALM MOANBMBECDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6996B90", Offset = "0x6995590", VA = "0x186996B90")]
	[AsyncStateMachine(typeof(HIHACMGODPF))]
	protected Task<OCJMNEDPIJP> HKENGAGCMLM(GCGKJJGGALM ABDLEBPKDKC, JCHCBFBFGLO LBHKMHAFDLC, PMHGABOONOO OMHHEPBDKPN, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ, NDEIAHHMNML FMAAOJCEFAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6995F00", Offset = "0x6994900", VA = "0x186995F00")]
	[AsyncStateMachine(typeof(LILFGNPINKL))]
	private Task ACCMENKOOGC(GCGKJJGGALM ABDLEBPKDKC, PMHGABOONOO OMHHEPBDKPN, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x69977B0", Offset = "0x69961B0", VA = "0x1869977B0")]
	private void PLIFJDFLFFO(OCJMNEDPIJP LOOGIMNCANO, PMHGABOONOO OMHHEPBDKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6996E30", Offset = "0x6995830", VA = "0x186996E30")]
	private void KDEBOICPENK(OCJMNEDPIJP GFECKGCOHOM, [Out] OCJMNEDPIJP HICFJKMABPJ, [Out] OCJMNEDPIJP ANJBHABNBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x69971A0", Offset = "0x6995BA0", VA = "0x1869971A0")]
	private Task<EOECGNFFFNA> NKPJLOPGFLG(EOCBFNOLIGO ELBMMMMNOAO, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6997140", Offset = "0x6995B40", VA = "0x186997140")]
	private Task<GCGKJJGGALM> KMCDAFIEJGI(EOECGNFFFNA ABDLEBPKDKC, CLKLNCPJFIK.IDMCFGPNMIA HHGDHAOMDNJ, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x69961B0", Offset = "0x6994BB0", VA = "0x1869961B0")]
	[AsyncStateMachine(typeof(PMDHOMCLHCD))]
	private Task AGFMFHDPCOH(GCGKJJGGALM ABDLEBPKDKC, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ, bool HHBBKMNAAHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6997580", Offset = "0x6995F80", VA = "0x186997580")]
	[AsyncStateMachine(typeof(JEMMOAFIHBK))]
	private Task OFENJLPGCCO(GCGKJJGGALM ABDLEBPKDKC, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6996A50", Offset = "0x6995450", VA = "0x186996A50")]
	private Task HHIMCMLJMKL(GCGKJJGGALM ABDLEBPKDKC, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6997180", Offset = "0x6995B80", VA = "0x186997180")]
	private Task MDHHMMMFIIG(GCGKJJGGALM ABDLEBPKDKC, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6996720", Offset = "0x6995120", VA = "0x186996720")]
	private Task CPBIIAFBHDG(GCGKJJGGALM ABDLEBPKDKC, JCHCBFBFGLO LBHKMHAFDLC, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6996E70", Offset = "0x6995870", VA = "0x186996E70")]
	private Task KECFDMFLKAH(GCGKJJGGALM ABDLEBPKDKC, JCHCBFBFGLO LBHKMHAFDLC, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x69971E0", Offset = "0x6995BE0", VA = "0x1869971E0")]
	private static Task NOFHOHNEBLD(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6996300", Offset = "0x6994D00", VA = "0x186996300")]
	private Task AGHOEMILNKA(GCGKJJGGALM ABDLEBPKDKC, JCHCBFBFGLO LBHKMHAFDLC, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6997670", Offset = "0x6996070", VA = "0x186997670")]
	private Task OKJABDGBMKL(GCGKJJGGALM ABDLEBPKDKC, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x69965B0", Offset = "0x6994FB0", VA = "0x1869965B0")]
	private void BGPAMMDKKGJ(EOCBFNOLIGO ELBMMMMNOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x6996A10", Offset = "0x6995410", VA = "0x186996A10")]
	public void FAPNENDJGMJ(long LPGMBLOCNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	private static void NNOKCCAJEKL(ECLKAFGMDKO CCHMHHHHDAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct CFACALMADJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private GCGKJJGGALM ABDLEBPKDKC;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private KLGILBCOHEN KHOMGDACNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x698C100", Offset = "0x698AB00", VA = "0x18698C100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x698C370", Offset = "0x698AD70", VA = "0x18698C370")]
	public static Task JGEDHJJKDOM(JAPLGPCNONK JKFKIODGCMA, GCGKJJGGALM ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x698C150", Offset = "0x698AB50", VA = "0x18698C150")]
	private void JGEDHJJKDOM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct NBKGGACEJPA
{
	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x69971E0", Offset = "0x6995BE0", VA = "0x1869971E0")]
	public static Task JGEDHJJKDOM(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct GLCGPALDICD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct OFJOIEOPIBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public FBDPEEPOBOM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x699E9E0", Offset = "0x699D3E0", VA = "0x18699E9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x699EF00", Offset = "0x699D900", VA = "0x18699EF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x6991920", Offset = "0x6990320", VA = "0x186991920")]
	[AsyncStateMachine(typeof(OFJOIEOPIBH))]
	public static Task JGEDHJJKDOM(FBDPEEPOBOM HENFFFIHANH, GCGKJJGGALM ABDLEBPKDKC, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct EEAPDFCCELD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct DNBINNCIKGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public FBDPEEPOBOM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public JCHCBFBFGLO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private OCJMNEDPIJP <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private JAPLGPCNONK <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private KLGILBCOHEN <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private OCHDPFMCIOG <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private List<(PersistenceView, FDEHGBEEAOL)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private FDEHGBEEAOL <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x698E370", Offset = "0x698CD70", VA = "0x18698E370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x698EFD0", Offset = "0x698D9D0", VA = "0x18698EFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x698F230", Offset = "0x698DC30", VA = "0x18698F230")]
	[AsyncStateMachine(typeof(DNBINNCIKGN))]
	public static Task JGEDHJJKDOM(FBDPEEPOBOM HENFFFIHANH, GCGKJJGGALM ABDLEBPKDKC, JCHCBFBFGLO LBHKMHAFDLC, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x698F030", Offset = "0x698DA30", VA = "0x18698F030")]
	private static void GKCLKHIBALK(PersistenceView DHIMBMLHLMD, FDEHGBEEAOL FLLKCMLDGED, GCGKJJGGALM ABDLEBPKDKC, OCJMNEDPIJP JJECPPOKNCG, bool LCMIOKEADDO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct PDMFFNPFEPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct PIAAGIGDLCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public JAPLGPCNONK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x699F070", Offset = "0x699DA70", VA = "0x18699F070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x699F4B0", Offset = "0x699DEB0", VA = "0x18699F4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x699EF60", Offset = "0x699D960", VA = "0x18699EF60")]
	[AsyncStateMachine(typeof(PIAAGIGDLCB))]
	public static Task JGEDHJJKDOM(JAPLGPCNONK JKFKIODGCMA, GCGKJJGGALM ABDLEBPKDKC, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct IFPNAGMKGFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct MOCNDOFMFOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public JAPLGPCNONK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public FBDPEEPOBOM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x699DB90", Offset = "0x699C590", VA = "0x18699DB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x699DDA0", Offset = "0x699C7A0", VA = "0x18699DDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class IDEOBOIOGEN
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
			public MJHALEONFCB<string>.KDBHCAJIBOE timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public IDEOBOIOGEN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0x69A2660", Offset = "0x69A1060", VA = "0x1869A2660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x69A29F0", Offset = "0x69A13F0", VA = "0x1869A29F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public IDEOBOIOGEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6992BF0", Offset = "0x69915F0", VA = "0x186992BF0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task MEHBBCDEBJF(MJHALEONFCB<string>.KDBHCAJIBOE timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct AAHJNNNKPKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public IFPNAGMKGFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private TaskAwaiter<MGKFLOLLHJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6989560", Offset = "0x6987F60", VA = "0x186989560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x6989EC0", Offset = "0x69888C0", VA = "0x186989EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class BJECMJHAJHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public HGKEIGHFNGL version;

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
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BJECMJHAJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x698BDB0", Offset = "0x698A7B0", VA = "0x18698BDB0")]
		internal object PMMIMKDFBOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x698BD00", Offset = "0x698A700", VA = "0x18698BD00")]
		internal object CFPAMLNDLOG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private GCGKJJGGALM ABDLEBPKDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private FBDPEEPOBOM HENFFFIHANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private bool HHBBKMNAAHA;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private static readonly ByteString IKNMMALEIEJ;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private KLGILBCOHEN KHOMGDACNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x6992D10", Offset = "0x6991710", VA = "0x186992D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private GLMLMHBFNJA BEHNCOLJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x6993030", Offset = "0x6991A30", VA = "0x186993030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6992DA0", Offset = "0x69917A0", VA = "0x186992DA0")]
	[AsyncStateMachine(typeof(MOCNDOFMFOI))]
	public static Task JGEDHJJKDOM(JAPLGPCNONK JKFKIODGCMA, GCGKJJGGALM ABDLEBPKDKC, FBDPEEPOBOM HENFFFIHANH, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ, bool HHBBKMNAAHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x6992EF0", Offset = "0x69918F0", VA = "0x186992EF0")]
	[AsyncStateMachine(typeof(AAHJNNNKPKD))]
	private Task JGEDHJJKDOM(MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x69930D0", Offset = "0x6991AD0", VA = "0x1869930D0")]
	private void NJGAGLJKOFP([NotNull] KDPHGEEOLAK DPKLBICFCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x6992D60", Offset = "0x6991760", VA = "0x186992D60")]
	private bool DGDAALNDFGF(HGKEIGHFNGL LHMJGBJEDAH, KDPHGEEOLAK DPKLBICFCOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct DKCJIIIFDNA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct CHCLDPOAJHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public AsyncTaskMethodBuilder<GCGKJJGGALM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public DKCJIIIFDNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public CLKLNCPJFIK.IDMCFGPNMIA downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter<(LGGHGMLBJFM<GFJPKGGMHGH, LJNADPDGEHJ>, LGGHGMLBJFM<LICINJCGCBN<KDPHGEEOLAK>, LJNADPDGEHJ>, LGGHGMLBJFM<LICINJCGCBN<NHPAEOGMHIC>, LJNADPDGEHJ>, LGGHGMLBJFM<LICINJCGCBN<JDCCNMIHMFO>, LJNADPDGEHJ>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x69A8180", Offset = "0x69A6B80", VA = "0x1869A8180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x69A8C30", Offset = "0x69A7630", VA = "0x1869A8C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct FCFAMMDIIDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<GFJPKGGMHGH, LJNADPDGEHJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public MJHALEONFCB<string>.KDBHCAJIBOE downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public DKCJIIIFDNA <>4__this;

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
		public CLKLNCPJFIK.IDMCFGPNMIA downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter<LGGHGMLBJFM<GFJPKGGMHGH, LJNADPDGEHJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x69ADC10", Offset = "0x69AC610", VA = "0x1869ADC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x69AE220", Offset = "0x69ACC20", VA = "0x1869AE220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private MKABEAPCMEL<JAPDNPEKOGE, NHPAEOGMHIC> JLEIDICFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private MKABEAPCMEL<JAPDNPEKOGE, KDPHGEEOLAK> CNDPHKLFLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private MKABEAPCMEL<long, JDCCNMIHMFO> IPKCOHDCAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private NNLENFFGLDP GOEJDGDPDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private ECLKAFGMDKO CCHMHHHHDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private LIDLODHMGJG KPBHDENHEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private string BJOJEPMOEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private JAPDNPEKOGE AOFALACDKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private JAPDNPEKOGE GPDJPBDMFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private long LPGMBLOCNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x69AA280", Offset = "0x69A8C80", VA = "0x1869AA280")]
	public static Task<GCGKJJGGALM> MDMGGGBIPHA(JAPLGPCNONK JKFKIODGCMA, [In] EOECGNFFFNA ABDLEBPKDKC, CLKLNCPJFIK.IDMCFGPNMIA HHGDHAOMDNJ, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x69A9F30", Offset = "0x69A8930", VA = "0x1869A9F30")]
	[AsyncStateMachine(typeof(CHCLDPOAJHO))]
	private Task<GCGKJJGGALM> JGEDHJJKDOM(CLKLNCPJFIK.IDMCFGPNMIA HHGDHAOMDNJ, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x69AA0C0", Offset = "0x69A8AC0", VA = "0x1869AA0C0")]
	[AsyncStateMachine(typeof(FCFAMMDIIDF))]
	private Task<LGGHGMLBJFM<GFJPKGGMHGH, LJNADPDGEHJ>> LDBKDDHFEGO(string BJOJEPMOEAN, long LPGMBLOCNFN, long? ECEDKLNOLLD, long? ADPGIJLEEII, CLKLNCPJFIK.IDMCFGPNMIA HHGDHAOMDNJ, MJHALEONFCB<string>.KDBHCAJIBOE LEGFHJLOLGN, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct LIJCGGBBKAA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct GJBIDLOFIJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public AsyncTaskMethodBuilder<EOECGNFFFNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public LIJCGGBBKAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<EOECGNFFFNA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x69AEF20", Offset = "0x69AD920", VA = "0x1869AEF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x69AF320", Offset = "0x69ADD20", VA = "0x1869AF320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct KLIEIOBGMCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public AsyncTaskMethodBuilder<EOECGNFFFNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public LIJCGGBBKAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<EOECGNFFFNA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x69B3F60", Offset = "0x69B2960", VA = "0x1869B3F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x69B4390", Offset = "0x69B2D90", VA = "0x1869B4390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class HHCMEKJKODC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HHCMEKJKODC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x1519140", Offset = "0x1517B40", VA = "0x181519140")]
		internal bool OFLDFBHANAL(LIDLODHMGJG sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct CGDDFJGALMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder<EOECGNFFFNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public JAPDNPEKOGE superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public KLGILBCOHEN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private HHCMEKJKODC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public MMJNMPOMFBE roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private ECLKAFGMDKO <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private LIDLODHMGJG <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private JAPDNPEKOGE <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private JAPDNPEKOGE <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<ECLKAFGMDKO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter<GLADOECGKEJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private TaskAwaiter<NCDAEICGONM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x69A6FE0", Offset = "0x69A59E0", VA = "0x1869A6FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x69A8110", Offset = "0x69A6B10", VA = "0x1869A8110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private KLGILBCOHEN NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private BPMFCGNIGPG HJBINPJGJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private MMJNMPOMFBE PNKAICMGCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private long ECEDKLNOLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private long AJIFLLNCAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private long BFEHPMILDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private string AJFKAGKBLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private JAPDNPEKOGE LCELIHOACFP;

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x69B5890", Offset = "0x69B4290", VA = "0x1869B5890")]
	public static Task<EOECGNFFFNA> MDMGGGBIPHA(JAPLGPCNONK JKFKIODGCMA, EOCBFNOLIGO ELBMMMMNOAO, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x69B5740", Offset = "0x69B4140", VA = "0x1869B5740")]
	[AsyncStateMachine(typeof(GJBIDLOFIJP))]
	private Task<EOECGNFFFNA> JGEDHJJKDOM(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x69B5B10", Offset = "0x69B4510", VA = "0x1869B5B10")]
	[AsyncStateMachine(typeof(KLIEIOBGMCE))]
	private Task<EOECGNFFFNA> NKPJLOPGFLG(MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x69B5C70", Offset = "0x69B4670", VA = "0x1869B5C70")]
	[AsyncStateMachine(typeof(CGDDFJGALMO))]
	private static Task<EOECGNFFFNA> NKPJLOPGFLG(KLGILBCOHEN NJALJHMFPEI, MMJNMPOMFBE PNKAICMGCIH, long ECEDKLNOLLD, long AJIFLLNCAHB, long BFEHPMILDEK, string AJFKAGKBLBA, JAPDNPEKOGE LCELIHOACFP, CancellationToken CFAFANOFDNJ, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x69B5710", Offset = "0x69B4110", VA = "0x1869B5710")]
	private void IOMAHJPMDPN(ECLKAFGMDKO CCHMHHHHDAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct IOMKJPFGHFE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct EODPOCKFOPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public IOMKJPFGHFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x69ACD50", Offset = "0x69AB750", VA = "0x1869ACD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x69AD2E0", Offset = "0x69ABCE0", VA = "0x1869AD2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	private KLGILBCOHEN NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private GCGKJJGGALM ABDLEBPKDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private float ODADPPDOBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private float PNOOLADOGAJ;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x69B22D0", Offset = "0x69B0CD0", VA = "0x1869B22D0")]
	public static Task HLNCDCAGNNO(JAPLGPCNONK JKFKIODGCMA, GCGKJJGGALM ABDLEBPKDKC, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x69B2690", Offset = "0x69B1090", VA = "0x1869B2690")]
	[AsyncStateMachine(typeof(EODPOCKFOPL))]
	public Task JGEDHJJKDOM(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x69B2170", Offset = "0x69B0B70", VA = "0x1869B2170")]
	private static void BBBFHJAIHBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x69B2470", Offset = "0x69B0E70", VA = "0x1869B2470")]
	private void IDIPPELADDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x69B25D0", Offset = "0x69B0FD0", VA = "0x1869B25D0")]
	private static float JCHGEPICMEK(KLGILBCOHEN NJALJHMFPEI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x69B22B0", Offset = "0x69B0CB0", VA = "0x1869B22B0")]
	private static float ENJCIOLIKIJ()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal struct PKHCPOOKEGD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct KDECKAIIOFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public FBDPEEPOBOM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private EIPPLJBOIII <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private JAPLGPCNONK <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private PEBLKCFHODB.EOHABOBLDMF <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter<MGKFLOLLHJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x69B3380", Offset = "0x69B1D80", VA = "0x1869B3380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x69B3D20", Offset = "0x69B2720", VA = "0x1869B3D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct LMPJPLBENAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x69B5E10", Offset = "0x69B4810", VA = "0x1869B5E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x69B6100", Offset = "0x69B4B00", VA = "0x1869B6100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x69BC470", Offset = "0x69BAE70", VA = "0x1869BC470")]
	[AsyncStateMachine(typeof(KDECKAIIOFG))]
	public static Task JGEDHJJKDOM(FBDPEEPOBOM HENFFFIHANH, GCGKJJGGALM ABDLEBPKDKC, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x69BC400", Offset = "0x69BAE00", VA = "0x1869BC400")]
	private static Task<MGKFLOLLHJM> JELBAAANNGN(FBDPEEPOBOM HENFFFIHANH, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x69BC340", Offset = "0x69BAD40", VA = "0x1869BC340")]
	[AsyncStateMachine(typeof(LMPJPLBENAJ))]
	private static Task BJLAIOOCCOG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct LBDKDNPPHEP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct ECMFPKEENLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public LBDKDNPPHEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x69AA940", Offset = "0x69A9340", VA = "0x1869AA940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x69AAFF0", Offset = "0x69A99F0", VA = "0x1869AAFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class NLGDJDLMLEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public NLGDJDLMLEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x69B7E50", Offset = "0x69B6850", VA = "0x1869B7E50")]
		internal object MIODFJDBIGE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct GJOIMJBCNNF : IAsyncStateMachine
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
		public LBDKDNPPHEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private PCADOEOHAMB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x69AF390", Offset = "0x69ADD90", VA = "0x1869AF390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x69AF950", Offset = "0x69AE350", VA = "0x1869AF950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private bool FGPFACNOGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private CancellationToken CFAFANOFDNJ;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x69B4E60", Offset = "0x69B3860", VA = "0x1869B4E60")]
	public static Task ALFOJIEOFEC(JAPLGPCNONK JKFKIODGCMA, bool FGPFACNOGGJ, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken FAIDMJAEDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x69B5000", Offset = "0x69B3A00", VA = "0x1869B5000")]
	[AsyncStateMachine(typeof(ECMFPKEENLI))]
	private Task JGEDHJJKDOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x69B4ED0", Offset = "0x69B38D0", VA = "0x1869B4ED0")]
	[AsyncStateMachine(typeof(GJOIMJBCNNF))]
	private Task BAKLNGEPCIN(bool OMGBODGDKGE, string IFLAEGGFFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0")]
	private bool OJFPIIMPILH(bool FGPFACNOGGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct ADJJOALFOLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct NBKHKEDFBEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public ADJJOALFOLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x69B72B0", Offset = "0x69B5CB0", VA = "0x1869B72B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x69B7820", Offset = "0x69B6220", VA = "0x1869B7820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class PJIEOHGAAMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public PJIEOHGAAMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x69BC2F0", Offset = "0x69BACF0", VA = "0x1869BC2F0")]
		internal object MIODFJDBIGE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct IAGBEJPFGKL : IAsyncStateMachine
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
		public ADJJOALFOLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private PCADOEOHAMB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x69B1460", Offset = "0x69AFE60", VA = "0x1869B1460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x69B1A20", Offset = "0x69B0420", VA = "0x1869B1A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private LAMHEAMBFBP JBMCDCPGFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private bool LIBKKONGFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	private GCGKJJGGALM ABDLEBPKDKC;

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x69A4580", Offset = "0x69A2F80", VA = "0x1869A4580")]
	public static Task<Scene> JNEMJCEJNMG(JAPLGPCNONK JKFKIODGCMA, LAMHEAMBFBP LAJPABMBHIO, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x69A4460", Offset = "0x69A2E60", VA = "0x1869A4460")]
	[AsyncStateMachine(typeof(NBKHKEDFBEM))]
	private Task<Scene> JGEDHJJKDOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x69A4430", Offset = "0x69A2E30", VA = "0x1869A4430")]
	private bool IPGFBFGGONL(GCGKJJGGALM ABDLEBPKDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x69A4600", Offset = "0x69A3000", VA = "0x1869A4600")]
	private void KNOFPDLPHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x69A42E0", Offset = "0x69A2CE0", VA = "0x1869A42E0")]
	[AsyncStateMachine(typeof(IAGBEJPFGKL))]
	private Task<Scene> BAKLNGEPCIN(string IFLAEGGFFAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct NAIGDLEDCGH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct DGPKEEOKIGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public AsyncTaskMethodBuilder<OCJMNEDPIJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public NAIGDLEDCGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public OCJMNEDPIJP nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public GCGKJJGGALM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private TaskAwaiter<OCJMNEDPIJP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x69A8CF0", Offset = "0x69A76F0", VA = "0x1869A8CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x69A97D0", Offset = "0x69A81D0", VA = "0x1869A97D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct EBMBLAIKKIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder<OCJMNEDPIJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public NAIGDLEDCGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public OCJMNEDPIJP state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter<MGKFLOLLHJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x69AA5F0", Offset = "0x69A8FF0", VA = "0x1869AA5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x69AA8D0", Offset = "0x69A92D0", VA = "0x1869AA8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private readonly FBDPEEPOBOM HENFFFIHANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private readonly BPMFCGNIGPG HJBINPJGJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private readonly CAABEPNDDGA JOGGPOJPBEE;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private EIPPLJBOIII KCNGPFNLELA
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x51E6260", Offset = "0x51E4C60", VA = "0x1851E6260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x69B7250", Offset = "0x69B5C50", VA = "0x1869B7250")]
	public NAIGDLEDCGH(FBDPEEPOBOM HENFFFIHANH, BPMFCGNIGPG HJBINPJGJEE, CAABEPNDDGA JOGGPOJPBEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x69B7080", Offset = "0x69B5A80", VA = "0x1869B7080")]
	[AsyncStateMachine(typeof(DGPKEEOKIGM))]
	public Task<OCJMNEDPIJP> FNLBJOIEDMC(OCJMNEDPIJP ADMBBKKADDG, GCGKJJGGALM MNINLOIAGHJ, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ, bool PBIIJAIMHNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x69B6F20", Offset = "0x69B5920", VA = "0x1869B6F20")]
	[AsyncStateMachine(typeof(EBMBLAIKKIB))]
	private Task<OCJMNEDPIJP> FDENAHILDPH(MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, OCJMNEDPIJP MLJADEFEEPB, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x69B7200", Offset = "0x69B5C00", VA = "0x1869B7200")]
	private bool HCGJNPBDEAP(OCJMNEDPIJP MPECKHGPNCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x69B7230", Offset = "0x69B5C30", VA = "0x1869B7230")]
	private void IGGHFJOIHIE(string DJDDEFKOPOE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct OENOLNCNIAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct MBNEHKBCLKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public EIPPLJBOIII operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public JCHCBFBFGLO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private OCHDPFMCIOG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private List<(PersistenceView, FDEHGBEEAOL)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private (PersistenceView, FDEHGBEEAOL) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x69B6160", Offset = "0x69B4B60", VA = "0x1869B6160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x69B6770", Offset = "0x69B5170", VA = "0x1869B6770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x69B8E00", Offset = "0x69B7800", VA = "0x1869B8E00")]
	[AsyncStateMachine(typeof(MBNEHKBCLKB))]
	public static Task JGEDHJJKDOM(EIPPLJBOIII EHNGFDOGIGP, GCGKJJGGALM ABDLEBPKDKC, JCHCBFBFGLO LBHKMHAFDLC, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct KJLKJFICHFI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct ODHJHJCECLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public EIPPLJBOIII operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public JCHCBFBFGLO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private HGKEIGHFNGL <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private OCHDPFMCIOG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private List<(PersistenceView, FDEHGBEEAOL)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private FDEHGBEEAOL <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x69B8550", Offset = "0x69B6F50", VA = "0x1869B8550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x69B8DA0", Offset = "0x69B77A0", VA = "0x1869B8DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x69B3E20", Offset = "0x69B2820", VA = "0x1869B3E20")]
	[AsyncStateMachine(typeof(ODHJHJCECLA))]
	public static Task JGEDHJJKDOM(EIPPLJBOIII EHNGFDOGIGP, GCGKJJGGALM ABDLEBPKDKC, JCHCBFBFGLO LBHKMHAFDLC, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct PEBLKCFHODB
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct EOHABOBLDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public List<CGAOGEOADJD> PJIIBDKLHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public List<FDEHGBEEAOL> JKONHBDMHIB;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x95C330", Offset = "0x95AD30", VA = "0x18095C330")]
		public EOHABOBLDMF(List<CGAOGEOADJD> PJIIBDKLHDD, List<FDEHGBEEAOL> JKONHBDMHIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class HHMKOMJLGME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public IEnumerable<CGAOGEOADJD> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HHMKOMJLGME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x69B0400", Offset = "0x69AEE00", VA = "0x1869B0400")]
		internal object CMAJBJFFEOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private JAPLGPCNONK JKFKIODGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private GCGKJJGGALM ABDLEBPKDKC;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private KLGILBCOHEN KHOMGDACNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x69BB1D0", Offset = "0x69B9BD0", VA = "0x1869BB1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x69BB650", Offset = "0x69BA050", VA = "0x1869BB650")]
	public static EOHABOBLDMF JGEDHJJKDOM(JAPLGPCNONK JKFKIODGCMA, GCGKJJGGALM ABDLEBPKDKC)
	{
		return default(EOHABOBLDMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x69BB3F0", Offset = "0x69B9DF0", VA = "0x1869BB3F0")]
	private EOHABOBLDMF JGEDHJJKDOM()
	{
		return default(EOHABOBLDMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x69BB6B0", Offset = "0x69BA0B0", VA = "0x1869BB6B0")]
	private EOHABOBLDMF OPAJKDHIFLD(KDPHGEEOLAK DPKLBICFCOA, HGKEIGHFNGL EPDNODJAAHE)
	{
		return default(EOHABOBLDMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x69BB220", Offset = "0x69B9C20", VA = "0x1869BB220")]
	private bool EKKLMEECBKM(IEnumerable<CGAOGEOADJD> PJIIBDKLHDD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct HGDDJHHLHMM
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class KMBIDNJFIHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public PEBLKCFHODB.EOHABOBLDMF instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public KMBIDNJFIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x69B4400", Offset = "0x69B2E00", VA = "0x1869B4400")]
		internal object MEHBBCDEBJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class EMHJADEJBKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public EMHJADEJBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x69ACCC0", Offset = "0x69AB6C0", VA = "0x1869ACCC0")]
		internal object NJEELAMFJMM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x69AFE50", Offset = "0x69AE850", VA = "0x1869AFE50")]
	public static void JGEDHJJKDOM(EIPPLJBOIII EHNGFDOGIGP, GCGKJJGGALM ABDLEBPKDKC, PEBLKCFHODB.EOHABOBLDMF AABANDPALFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal class CAABEPNDDGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct BJANBLOLHCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public CAABEPNDDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public OCJMNEDPIJP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public GCGKJJGGALM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x69A5840", Offset = "0x69A4240", VA = "0x1869A5840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x69A5FB0", Offset = "0x69A49B0", VA = "0x1869A5FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class KPFCMEPGMJG
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
			public KPFCMEPGMJG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DF")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005E0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x69BCD40", Offset = "0x69BB740", VA = "0x1869BCD40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x69BD000", Offset = "0x69BBA00", VA = "0x1869BD000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CAABEPNDDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public MJHALEONFCB<string>.KDBHCAJIBOE handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public KPFCMEPGMJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x69B44B0", Offset = "0x69B2EB0", VA = "0x1869B44B0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task GBBFAJMPHJM(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct PMFCLMHGBJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public CAABEPNDDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private KPFCMEPGMJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x69BC5B0", Offset = "0x69BAFB0", VA = "0x1869BC5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x69BCAE0", Offset = "0x69BB4E0", VA = "0x1869BCAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct NNGIKDDKCIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public CAABEPNDDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private Dictionary<Guid, List<HEJNOLGJKNH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x69B7ED0", Offset = "0x69B68D0", VA = "0x1869B7ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x69B8480", Offset = "0x69B6E80", VA = "0x1869B8480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct IAGHIIEGEBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public CAABEPNDDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private MJHALEONFCB<string>.KDBHCAJIBOE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private Dictionary<Guid, List<HEJNOLGJKNH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x69B1A90", Offset = "0x69B0490", VA = "0x1869B1A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x69B2110", Offset = "0x69B0B10", VA = "0x1869B2110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class HEKECIOHLAJ
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
			public HEJNOLGJKNH handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			public HEKECIOHLAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x69BCB40", Offset = "0x69BB540", VA = "0x1869BCB40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x69BCCE0", Offset = "0x69BB6E0", VA = "0x1869BCCE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public FEDHLBGMEDI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public List<HEJNOLGJKNH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HEKECIOHLAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x69AFD60", Offset = "0x69AE760", VA = "0x1869AFD60")]
		internal object HEEMAMCELAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x69AFB80", Offset = "0x69AE580", VA = "0x1869AFB80")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task BHKEPLDLNLI(HEJNOLGJKNH handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x69AFC70", Offset = "0x69AE670", VA = "0x1869AFC70")]
		internal object GECEDNCGDOM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct AJOGMKEMGFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public FEDHLBGMEDI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public List<HEJNOLGJKNH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private HEKECIOHLAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x69A4B30", Offset = "0x69A3530", VA = "0x1869A4B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x69A5000", Offset = "0x69A3A00", VA = "0x1869A5000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct LHNIFOANAMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public CAABEPNDDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public MJHALEONFCB<string>.KDBHCAJIBOE timer;

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
		[Cpp2IlInjected.Address(RVA = "0x69B50F0", Offset = "0x69B3AF0", VA = "0x1869B50F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x69B56B0", Offset = "0x69B40B0", VA = "0x1869B56B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class FKAEMHINLOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public FKAEMHINLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x69AEEB0", Offset = "0x69AD8B0", VA = "0x1869AEEB0")]
		internal object JCBACKIAHJB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct PBNBDFHMFIG : IAsyncStateMachine
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
		public CAABEPNDDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public GCGKJJGGALM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x69BACB0", Offset = "0x69B96B0", VA = "0x1869BACB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x69BB170", Offset = "0x69B9B70", VA = "0x1869BB170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class BMHBADLFAFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BMHBADLFAFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x69A6010", Offset = "0x69A4A10", VA = "0x1869A6010")]
		internal object LLBCBOJONAB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct PEKAFNLLFPP : IAsyncStateMachine
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
		public CAABEPNDDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private TaskAwaiter<MGKFLOLLHJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x69BBC50", Offset = "0x69BA650", VA = "0x1869BBC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x69BC290", Offset = "0x69BAC90", VA = "0x1869BC290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class MCLHBIKKEKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public MCLHBIKKEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x69B6EB0", Offset = "0x69B58B0", VA = "0x1869B6EB0")]
		internal object DBCLOJMCDEN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private readonly FBDPEEPOBOM HENFFFIHANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private BIDBCNECBHL JOGGPOJPBEE;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private EIPPLJBOIII KCNGPFNLELA
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x10E4CC0", Offset = "0x10E36C0", VA = "0x1810E4CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public CAABEPNDDGA(FBDPEEPOBOM HENFFFIHANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x69A6AD0", Offset = "0x69A54D0", VA = "0x1869A6AD0")]
	[AsyncStateMachine(typeof(BJANBLOLHCO))]
	public Task JGEDHJJKDOM(OCJMNEDPIJP JJECPPOKNCG, GCGKJJGGALM MNINLOIAGHJ, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x69A6670", Offset = "0x69A5070", VA = "0x1869A6670")]
	[AsyncStateMachine(typeof(PMFCLMHGBJO))]
	private Task GJKMODLPIAE(GCGKJJGGALM ABDLEBPKDKC, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x69A6EA0", Offset = "0x69A58A0", VA = "0x1869A6EA0")]
	[AsyncStateMachine(typeof(NNGIKDDKCIL))]
	private Task PAMNDNGAAME(GCGKJJGGALM ABDLEBPKDKC, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x69A6080", Offset = "0x69A4A80", VA = "0x1869A6080")]
	[AsyncStateMachine(typeof(IAGHIIEGEBE))]
	private Task ACBBBKCANPE(GCGKJJGGALM ABDLEBPKDKC, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x69A6980", Offset = "0x69A5380", VA = "0x1869A6980")]
	[AsyncStateMachine(typeof(AJOGMKEMGFH))]
	private Task HKGOMCBHGGJ(Guid LLNODDOODGH, List<HEJNOLGJKNH> MMCFCGFANGL, FEDHLBGMEDI KOHKHMPCIDP, GCGKJJGGALM ABDLEBPKDKC, CancellationToken AIDIDMJCFEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x69A6C20", Offset = "0x69A5620", VA = "0x1869A6C20")]
	[AsyncStateMachine(typeof(LHNIFOANAMM))]
	private Task LFMGBFHGLDO(GCGKJJGGALM ABDLEBPKDKC, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x69A6D60", Offset = "0x69A5760", VA = "0x1869A6D60")]
	[AsyncStateMachine(typeof(PBNBDFHMFIG))]
	private Task PAGBIPILLCD(Guid CNFOLPOKODI, GCGKJJGGALM ABDLEBPKDKC, MJHALEONFCB<string>.KDBHCAJIBOE MDGFMJGBLAI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x69A6530", Offset = "0x69A4F30", VA = "0x1869A6530")]
	[AsyncStateMachine(typeof(PEKAFNLLFPP))]
	private Task EIHLNGFEJGP(Guid CNFOLPOKODI, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x69A67B0", Offset = "0x69A51B0", VA = "0x1869A67B0")]
	private void GMCMJFEEMJK(Guid CNFOLPOKODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x69A68D0", Offset = "0x69A52D0", VA = "0x1869A68D0")]
	private void GPOAACKLJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x69A63A0", Offset = "0x69A4DA0", VA = "0x1869A63A0")]
	public Guid DLACLOBPEKP(OCJMNEDPIJP LOOGIMNCANO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x69A61C0", Offset = "0x69A4BC0", VA = "0x1869A61C0")]
	[CompilerGenerated]
	private object BDNDOFADGLG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public readonly struct LICAEKIJOKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	public readonly bool BDFPGGFDBAH;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0xCE6180", Offset = "0xCE4B80", VA = "0x180CE6180")]
	public LICAEKIJOKL(bool IFMAADEPCOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
public readonly struct NIPEHLMICJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	public readonly KDPHGEEOLAK? LIPJJAJINHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	public readonly CIAPJDNGACL MHDFJFLMOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	public readonly string? PIIECDDEKPE;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IReadOnlyCollection<string> MBBCCNEBKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x69B7D30", Offset = "0x69B6730", VA = "0x1869B7D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public IReadOnlyDictionary<long, int> EGGDEELDBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x69B7D10", Offset = "0x69B6710", VA = "0x1869B7D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x69B7D50", Offset = "0x69B6750", VA = "0x1869B7D50")]
	public NIPEHLMICJG(KDPHGEEOLAK? GOGGOGGMFEP, CIAPJDNGACL CJEDOOOHGHA, string? BJOJEPMOEAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal class OIBIAMJHLID : JBEKAIAHCDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct MCFJLGFIMIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public AsyncTaskMethodBuilder<NIPEHLMICJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public OIBIAMJHLID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public ICOEHIAPCIG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public MKGDDLJDIFL roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private OCHDPFMCIOG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x69B67D0", Offset = "0x69B51D0", VA = "0x1869B67D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x69B6E40", Offset = "0x69B5840", VA = "0x1869B6E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class JEPIADPAEBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public ICOEHIAPCIG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public OIBIAMJHLID <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public JEPIADPAEBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x69B27B0", Offset = "0x69B11B0", VA = "0x1869B27B0")]
		internal Task IDDDKKMHKKH(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x69B29D0", Offset = "0x69B13D0", VA = "0x1869B29D0")]
		internal Task JDFLJIIDCCN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class EHHJIEAKHLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public JEPIADPAEBF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public EHHJIEAKHLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x69AC080", Offset = "0x69AAA80", VA = "0x1869AC080")]
		internal object PKMJPDEODJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class BDIPMJINGPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public JEPIADPAEBF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BDIPMJINGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x69A54E0", Offset = "0x69A3EE0", VA = "0x1869A54E0")]
		internal Task DNAKPGGOECN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct EOPEJPKBGEL : IAsyncStateMachine
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
		public ICOEHIAPCIG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public OIBIAMJHLID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private EHHJIEAKHLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		private OCHDPFMCIOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x69AD340", Offset = "0x69ABD40", VA = "0x1869AD340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x69ADBB0", Offset = "0x69AC5B0", VA = "0x1869ADBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private static readonly TimeSpan OGDGMBAAEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private readonly AJCCEDPLGKH AGPLINHKIJB;

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x69BAC60", Offset = "0x69B9660", VA = "0x1869BAC60")]
	public OIBIAMJHLID(FBDPEEPOBOM HENFFFIHANH, AJCCEDPLGKH AGPLINHKIJB, LBNENDFDEJK EMEAPIGMNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x69B9DA0", Offset = "0x69B87A0", VA = "0x1869B9DA0")]
	[AsyncStateMachine(typeof(MCFJLGFIMIM))]
	public Task<NIPEHLMICJG> BOALAEMEPIG(long AJIFLLNCAHB, MKGDDLJDIFL DHGKOEPPPHJ, ICOEHIAPCIG MJEFFKJFELK, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x69BA500", Offset = "0x69B8F00", VA = "0x1869BA500")]
	[AsyncStateMachine(typeof(EOPEJPKBGEL))]
	private Task MAPLMGLLAJG(ICOEHIAPCIG MJEFFKJFELK, IEnumerable<PersistenceView> LGEPIAIAADL, StringBuilder NGPNEGHCHAP, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x69BA640", Offset = "0x69B9040", VA = "0x1869BA640")]
	private NIPEHLMICJG PGKKMFAJBKC(long AJIFLLNCAHB, MKGDDLJDIFL DHGKOEPPPHJ, ICOEHIAPCIG MJEFFKJFELK, IEnumerable<PersistenceView> LGEPIAIAADL, StringBuilder NGPNEGHCHAP)
	{
		return default(NIPEHLMICJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x69BA3A0", Offset = "0x69B8DA0", VA = "0x1869BA3A0")]
	private KDPHGEEOLAK KBCEJFIMBAG(long AJIFLLNCAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x69B9B50", Offset = "0x69B8550", VA = "0x1869B9B50")]
	private void ALHHEDCOMAD(KDPHGEEOLAK BFMOIEBGPOC, StringBuilder NGPNEGHCHAP, IEnumerable<PersistenceView> LGEPIAIAADL, [In] JKOBHJMJPAM NCCBOPOFNBM, NANAAMEDNBI OKIGHOOKCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x69B9F00", Offset = "0x69B8900", VA = "0x1869B9F00")]
	private void CDFPMHMIAJE(KDPHGEEOLAK BFMOIEBGPOC, StringBuilder NGPNEGHCHAP, PersistenceView DHIMBMLHLMD, NANAAMEDNBI OKIGHOOKCMM, [In] JKOBHJMJPAM NCCBOPOFNBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class OGPHKDBMFMF : JBEKAIAHCDO
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class CHIAPKACPAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public FOBJMBBFLPL.FCHLCGPHOBO roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public CHIAPKACPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x69A8CA0", Offset = "0x69A76A0", VA = "0x1869A8CA0")]
		internal object JDPIHLLBMKE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct LAIABIHACNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public AsyncTaskMethodBuilder<(FOBJMBBFLPL.FCHLCGPHOBO roomDataUpload, FOBJMBBFLPL.FCHLCGPHOBO subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public NIPEHLMICJG roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public OGPHKDBMFMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private CHIAPKACPAN <>8__1;

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
		private TaskAwaiter<FOBJMBBFLPL.FCHLCGPHOBO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x69B45A0", Offset = "0x69B2FA0", VA = "0x1869B45A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x69B4DF0", Offset = "0x69B37F0", VA = "0x1869B4DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct AAMAEOMOOEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public AsyncTaskMethodBuilder<GAGPEDFBJMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public OGPHKDBMFMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public NIPEHLMICJG roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public NDGDGDKEFLE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private TaskAwaiter<(FOBJMBBFLPL.FCHLCGPHOBO roomDataUpload, FOBJMBBFLPL.FCHLCGPHOBO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private TaskAwaiter<GAGPEDFBJMI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x69A3380", Offset = "0x69A1D80", VA = "0x1869A3380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x69A39A0", Offset = "0x69A23A0", VA = "0x1869A39A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct ANBHHEBNEOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public AsyncTaskMethodBuilder<GLADOECGKEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public OGPHKDBMFMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public NIPEHLMICJG roomSerializedData;

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
		private TaskAwaiter<(FOBJMBBFLPL.FCHLCGPHOBO roomDataUpload, FOBJMBBFLPL.FCHLCGPHOBO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private TaskAwaiter<GLADOECGKEJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x69A5060", Offset = "0x69A3A60", VA = "0x1869A5060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x69A5470", Offset = "0x69A3E70", VA = "0x1869A5470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class EKIBGLEJHBJ
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
			public AsyncTaskMethodBuilder<MGKFLOLLHJM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			public EKIBGLEJHBJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			private MGKFLOLLHJM <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000684")]
			private TaskAwaiter<GLADOECGKEJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000685")]
			private TaskAwaiter<GAGPEDFBJMI> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000686")]
			private TaskAwaiter<MGKFLOLLHJM> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x69BD060", Offset = "0x69BBA60", VA = "0x1869BD060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x69BDFE0", Offset = "0x69BC9E0", VA = "0x1869BDFE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public OGPHKDBMFMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public NIPEHLMICJG roomSerializedData;

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
		public NDGDGDKEFLE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public LICAEKIJOKL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public EKIBGLEJHBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x69ACB90", Offset = "0x69AB590", VA = "0x1869ACB90")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<MGKFLOLLHJM> KEHMGLMNJDE(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct OHMOLGHMJLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public AsyncTaskMethodBuilder<MGKFLOLLHJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public OGPHKDBMFMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public NIPEHLMICJG roomSerializedData;

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
		public NDGDGDKEFLE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public LICAEKIJOKL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public MJHALEONFCB<string>.KDBHCAJIBOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private TaskAwaiter<MGKFLOLLHJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x69B97D0", Offset = "0x69B81D0", VA = "0x1869B97D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x69B9AE0", Offset = "0x69B84E0", VA = "0x1869B9AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private static readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private static readonly LBNENDFDEJK EAMANJFKCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private readonly GCBIOEBLHPD EFLDGKHDHAK;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private JAPLGPCNONK MOOGKMKFKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x69966F0", Offset = "0x69950F0", VA = "0x1869966F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x69B9740", Offset = "0x69B8140", VA = "0x1869B9740")]
	public OGPHKDBMFMF(FBDPEEPOBOM HENFFFIHANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x69B9250", Offset = "0x69B7C50", VA = "0x1869B9250")]
	[AsyncStateMachine(typeof(LAIABIHACNF))]
	private Task<(FOBJMBBFLPL.FCHLCGPHOBO, FOBJMBBFLPL.FCHLCGPHOBO)> IJOEBDBNAOB(NIPEHLMICJG BADNOCAELMA, long ECEDKLNOLLD, long ADPGIJLEEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x69B9530", Offset = "0x69B7F30", VA = "0x1869B9530")]
	[AsyncStateMachine(typeof(AAMAEOMOOEK))]
	public Task<GAGPEDFBJMI> MGKBOEDJOLE(int PGELEHPHLNL, [CanBeNull] NDGDGDKEFLE BGJPIGKNAII, NIPEHLMICJG BADNOCAELMA, long ECEDKLNOLLD, long ADPGIJLEEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x69B90E0", Offset = "0x69B7AE0", VA = "0x1869B90E0")]
	[AsyncStateMachine(typeof(ANBHHEBNEOM))]
	private Task<GLADOECGKEJ> HIKFOBIOMEP(string AJFKAGKBLBA, int PGELEHPHLNL, NIPEHLMICJG BADNOCAELMA, long ECEDKLNOLLD, long ADPGIJLEEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x69B9390", Offset = "0x69B7D90", VA = "0x1869B9390")]
	[AsyncStateMachine(typeof(OHMOLGHMJLB))]
	public Task<MGKFLOLLHJM> MEJECKIHGPJ(int PGELEHPHLNL, NDGDGDKEFLE? BGJPIGKNAII, NIPEHLMICJG BADNOCAELMA, long ECEDKLNOLLD, long ADPGIJLEEII, LICAEKIJOKL PMFOHNPJOKD, MJHALEONFCB<string>.KDBHCAJIBOE EAKBKCCNGHE, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public abstract class HIJKJMPDLGN<T> where T : HIJKJMPDLGN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	internal readonly JAPLGPCNONK PADHAOJEHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private int? FOHINMEKAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	protected readonly Guid OKBMHFPHNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	protected readonly BALIOJOPJGB NJAFMIIMIJB;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	protected T KGCLHOJKCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x39F6BC0", Offset = "0x39F55C0", VA = "0x1839F6BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x39F6EA0", Offset = "0x39F58A0", VA = "0x1839F6EA0")]
	internal HIJKJMPDLGN(JAPLGPCNONK MKHCHNBNHHN, BALIOJOPJGB OMAMGNFAJIN, [Optional] Guid? ALJDBMFHGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x39F6CB0", Offset = "0x39F56B0", VA = "0x1839F6CB0")]
	private MGKFLOLLHJM KKPIKFMCKKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "4")]
	protected virtual void NDCOLAEDBEM(MGKFLOLLHJM CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x39F6C20", Offset = "0x39F5620", VA = "0x1839F6C20")]
	public T JPLHMPNFCBE(HOPBKANDJCK JJDFAIKPBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x39F6B30", Offset = "0x39F5530", VA = "0x1839F6B30")]
	public T CCBLFKNOHKI(int LFDKPJKOIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x39F6D90", Offset = "0x39F5790", VA = "0x1839F6D90", Slot = "5")]
	public virtual Task<OEGBNAHMNGM> NJBOLHEFPFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class OGBLJDCIPEO : HIJKJMPDLGN<OGBLJDCIPEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private EOCBFNOLIGO PEFGDLBLMMP;

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x69B9010", Offset = "0x69B7A10", VA = "0x1869B9010")]
	internal OGBLJDCIPEO(JAPLGPCNONK MKHCHNBNHHN, BALIOJOPJGB OMAMGNFAJIN, [Optional] Guid? ALJDBMFHGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x5F71FD0", Offset = "0x5F709D0", VA = "0x185F71FD0")]
	public OGBLJDCIPEO IHFMGIDBFDC(EOCBFNOLIGO PEFGDLBLMMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x69B8F40", Offset = "0x69B7940", VA = "0x1869B8F40", Slot = "4")]
	protected override void NDCOLAEDBEM(MGKFLOLLHJM CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public class EDEGKJMPPHO : HIJKJMPDLGN<EDEGKJMPPHO>
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	internal enum ABHBMANAILJ
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
	private struct JOAGHDNMEPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public AsyncTaskMethodBuilder<OEGBNAHMNGM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public EDEGKJMPPHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private TaskAwaiter<OEGBNAHMNGM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x69B2F70", Offset = "0x69B1970", VA = "0x1869B2F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x69B3310", Offset = "0x69B1D10", VA = "0x1869B3310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private ABHBMANAILJ KJEIFKGIDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private string AJEPCAPDBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private NDGDGDKEFLE PEFGDLBLMMP;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x69AB370", Offset = "0x69A9D70", VA = "0x1869AB370")]
	internal EDEGKJMPPHO(JAPLGPCNONK MKHCHNBNHHN, BALIOJOPJGB OMAMGNFAJIN, [Optional] Guid? ALJDBMFHGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x69AB080", Offset = "0x69A9A80", VA = "0x1869AB080")]
	public EDEGKJMPPHO GIINKLNGHLB(string PIHIABBFEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x69AB350", Offset = "0x69A9D50", VA = "0x1869AB350")]
	public EDEGKJMPPHO NLJDLBAGGAJ(bool PKCDKLKIOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x69AB050", Offset = "0x69A9A50", VA = "0x1869AB050")]
	public EDEGKJMPPHO FEIPGBBNBGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x69AB0F0", Offset = "0x69A9AF0", VA = "0x1869AB0F0", Slot = "4")]
	protected override void NDCOLAEDBEM(MGKFLOLLHJM CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x69AB260", Offset = "0x69A9C60", VA = "0x1869AB260", Slot = "5")]
	[AsyncStateMachine(typeof(JOAGHDNMEPG))]
	public override Task<OEGBNAHMNGM> NJBOLHEFPFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x69AB0B0", Offset = "0x69A9AB0", VA = "0x1869AB0B0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<OEGBNAHMNGM> KOODOGFBIGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal static class GPKAJLLCJIE
{
	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x69AF9B0", Offset = "0x69AE3B0", VA = "0x1869AF9B0")]
	public static void FLGHDAFDING(this GABCKPOPJNO EAKONBFJKMC, MAHIACGDFOP FHMAHLBPECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x69AFB00", Offset = "0x69AE500", VA = "0x1869AFB00")]
	public static void MJCMCFNMAPI(this MAHIACGDFOP GEGNACPKGBO, [Optional] string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public static class NGLMPCAHBCO
{
	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x69B7940", Offset = "0x69B6340", VA = "0x1869B7940")]
	public static JAPDNPEKOGE HFFIKBLPIPP(this NMMILGKGDPN IHGJCNEPIGL)
	{
		return default(JAPDNPEKOGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x69B7890", Offset = "0x69B6290", VA = "0x1869B7890")]
	public static NMMILGKGDPN EAAIGHECPJL(this JAPDNPEKOGE OKFDOJMMFLJ)
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
			public EMHNINNJELF ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A9")]
			public EMHNINNJELF HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private static EMHNINNJELF[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private Dictionary<EMHNINNJELF, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x69BE6E0", Offset = "0x69BD0E0", VA = "0x1869BE6E0")]
		public bool LBHFMLCLHCB(EMHNINNJELF PHCMJNOBHAG, [Out] ResultConfig FAKHGNGCNKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x69BEF00", Offset = "0x69BD900", VA = "0x1869BEF00")]
		public ResultConfig PGLLCPNMNCO(EMHNINNJELF FKOGKDPANPE, [Optional] HashSet<EMHNINNJELF> FOFKGINAJCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x69BED10", Offset = "0x69BD710", VA = "0x1869BED10", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x69BE750", Offset = "0x69BD150", VA = "0x1869BE750", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x8AAA60", Offset = "0x8A9460", VA = "0x1808AAA60")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public static class JKCPKLBJJGC
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x69B2AB0", Offset = "0x69B14B0", VA = "0x1869B2AB0")]
	[JCOMPLNHMEG(AOHDMBIABEL.GameOnly)]
	private static void EBMPOMEGCDH(ICKBMMGCCPN AIGNNHACHNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public interface JDLHDFPPGKG : IEquatable<JDLHDFPPGKG>
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	DateTime HDHFKKMPBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GJFKIOLGGAD();

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FMAKHNPKJNN(long ECEDKLNOLLD, long AJIFLLNCAHB, [Out] NIPEHLMICJG BADNOCAELMA);
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal class EEFMBCHBFFA : LAKPEJNKEPP
{
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class OBMPEIAPODO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public OONOEGKKCEB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public OBMPEIAPODO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x69B84E0", Offset = "0x69B6EE0", VA = "0x1869B84E0")]
		internal object LIKGJFGGJDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private readonly HAHEGLEMIGA FDNEKPDNPFB;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<JDLHDFPPGKG> HIIAMBBCHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x69ABD40", Offset = "0x69AA740", VA = "0x1869ABD40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x69ABBE0", Offset = "0x69AA5E0", VA = "0x1869ABBE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	[UnityEngine.Scripting.Preserve]
	public EEFMBCHBFFA([JDJLHBHAJCP(null)] HAHEGLEMIGA FDNEKPDNPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x69AB4E0", Offset = "0x69A9EE0", VA = "0x1869AB4E0", Slot = "6")]
	public bool EFGLHHKMJFK(long ECEDKLNOLLD, long AJIFLLNCAHB, NIPEHLMICJG BADNOCAELMA, OONOEGKKCEB LAGEFEKOMON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x1AA8EB0", Offset = "0x1AA78B0", VA = "0x181AA8EB0")]
	private void DJHOLALCHMF(JDLHDFPPGKG AJKANDNNPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x69ABDF0", Offset = "0x69AA7F0", VA = "0x1869ABDF0", Slot = "7")]
	public bool MJHPDPLLOGM(long ECEDKLNOLLD, long AJIFLLNCAHB, [Out] JDLHDFPPGKG CAKGNCPACEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x69ABC90", Offset = "0x69AA690", VA = "0x1869ABC90", Slot = "8")]
	public bool GFIAMFKBAHD(long ECEDKLNOLLD, long AJIFLLNCAHB, OONOEGKKCEB LAGEFEKOMON, [Out] JDLHDFPPGKG CAKGNCPACEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x69AB7C0", Offset = "0x69AA1C0", VA = "0x1869AB7C0")]
	private void EIKIHCCDBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x69ABF60", Offset = "0x69AA960", VA = "0x1869ABF60", Slot = "9")]
	public void OFEAHIJFJDG(long ECEDKLNOLLD, long AJIFLLNCAHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal abstract class EIJAMDFIIJO : HAHEGLEMIGA
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	protected enum HLJDBILBFLP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class NIEHBBNCPDK : IEnumerable<JDLHDFPPGKG>, IEnumerable, IEnumerator<JDLHDFPPGKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private JDLHDFPPGKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public EIJAMDFIIJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private OONOEGKKCEB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public OONOEGKKCEB <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		private JDLHDFPPGKG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x820E60", Offset = "0x81F860", VA = "0x180820E60")]
		[DebuggerHidden]
		public NIEHBBNCPDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x69B79E0", Offset = "0x69B63E0", VA = "0x1869B79E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x69B7CC0", Offset = "0x69B66C0", VA = "0x1869B7CC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x69B7C10", Offset = "0x69B6610", VA = "0x1869B7C10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JDLHDFPPGKG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x69B7C10", Offset = "0x69B6610", VA = "0x1869B7C10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class KFNFNHFJEFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public OONOEGKKCEB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public KFNFNHFJEFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x69B3D80", Offset = "0x69B2780", VA = "0x1869B3D80")]
		internal object HAJLIFOFOOK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class DIMOECMKBBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public EIJAMDFIIJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public DIMOECMKBBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x69A9840", Offset = "0x69A8240", VA = "0x1869A9840")]
		internal void ABLJELGDHFL(CEOCPEGBKJC.JMBNEPKFIHI ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	protected readonly string AACFIOEFDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private readonly object DMMEAMNGJHF;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract GMEIHDJILIP JMBODOFJKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x69ACAF0", Offset = "0x69AB4F0", VA = "0x1869ACAF0")]
	protected EIJAMDFIIJO([CanBeNull] string LINOOIOFMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x69AC900", Offset = "0x69AB300", VA = "0x1869AC900", Slot = "5")]
	public bool LOCKGKICACB(long ECEDKLNOLLD, long AJIFLLNCAHB, OONOEGKKCEB LAGEFEKOMON, [Out] JDLHDFPPGKG AJKANDNNPCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x69AC0F0", Offset = "0x69AAAF0", VA = "0x1869AC0F0", Slot = "6")]
	[IteratorStateMachine(typeof(NIEHBBNCPDK))]
	public IEnumerable<JDLHDFPPGKG> FDDLOKIFPMH(OONOEGKKCEB LAGEFEKOMON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void LJPFOPEFBHF(Stream LABBCNMHJAI, long ECEDKLNOLLD, long AJIFLLNCAHB, NIPEHLMICJG BADNOCAELMA);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool ADHCHIECAKB(Stream HGEMPFAGNHF, long ECEDKLNOLLD, long AJIFLLNCAHB, IHCLKBKNDPB HJAMLHKJHFD, [Out] NIPEHLMICJG BADNOCAELMA);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x69AC180", Offset = "0x69AAB80", VA = "0x1869AC180", Slot = "7")]
	public JDLHDFPPGKG GPKNGLGKNPI(long ECEDKLNOLLD, long AJIFLLNCAHB, NIPEHLMICJG BADNOCAELMA, OONOEGKKCEB LAGEFEKOMON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo KHKGAJEOPGK(long ECEDKLNOLLD, long AJIFLLNCAHB, OONOEGKKCEB LAGEFEKOMON, HLJDBILBFLP CDAJBLCDKMP);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo OINJHOEMGEM(OONOEGKKCEB LAGEFEKOMON, HLJDBILBFLP CDAJBLCDKMP);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x69AC500", Offset = "0x69AAF00", VA = "0x1869AC500")]
	protected void IOMIGOKDKAF(CEOCPEGBKJC.JMBNEPKFIHI FLGBKBFDCOD, string DJDDEFKOPOE, FileInfo LMLNPLFFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x69AC570", Offset = "0x69AAF70", VA = "0x1869AC570")]
	internal bool JAGLLJMILLK(FileInfo JHDFBKGNBCI, long ECEDKLNOLLD, long AJIFLLNCAHB, [Out] NIPEHLMICJG BADNOCAELMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	private void PKJOGMIIPJC(Exception KABNEKBCJNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class FFBBAOGMCEL : EIJAMDFIIJO
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public override GMEIHDJILIP JMBODOFJKBH
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xC130D0", Offset = "0xC11AD0", VA = "0x180C130D0", Slot = "8")]
		get
		{
			return default(GMEIHDJILIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x69AEDF0", Offset = "0x69AD7F0", VA = "0x1869AEDF0")]
	public FFBBAOGMCEL([Optional] string LINOOIOFMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x69AE8E0", Offset = "0x69AD2E0", VA = "0x1869AE8E0")]
	private void INJAIEOMEGD(OONOEGKKCEB LAGEFEKOMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x69AEA50", Offset = "0x69AD450", VA = "0x1869AEA50", Slot = "9")]
	internal override void LJPFOPEFBHF(Stream LABBCNMHJAI, long ECEDKLNOLLD, long AJIFLLNCAHB, NIPEHLMICJG BADNOCAELMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x69AE290", Offset = "0x69ACC90", VA = "0x1869AE290", Slot = "10")]
	internal override bool ADHCHIECAKB(Stream HGEMPFAGNHF, long ECEDKLNOLLD, long AJIFLLNCAHB, IHCLKBKNDPB HJAMLHKJHFD, [Out] NIPEHLMICJG BADNOCAELMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x69AE960", Offset = "0x69AD360", VA = "0x1869AE960", Slot = "11")]
	protected override FileInfo KHKGAJEOPGK(long ECEDKLNOLLD, long AJIFLLNCAHB, OONOEGKKCEB LAGEFEKOMON, HLJDBILBFLP CDAJBLCDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x69AECE0", Offset = "0x69AD6E0", VA = "0x1869AECE0", Slot = "12")]
	protected override DirectoryInfo OINJHOEMGEM(OONOEGKKCEB LAGEFEKOMON, HLJDBILBFLP CDAJBLCDKMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal sealed class HOKHKEBIBCM : EIJAMDFIIJO
{
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private static readonly byte[] KLDFLAABJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private readonly byte[] GNKHDOFELOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private readonly byte[] DKEBFFOFMJI;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public override GMEIHDJILIP JMBODOFJKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x5832A30", Offset = "0x5831430", VA = "0x185832A30", Slot = "8")]
		get
		{
			return default(GMEIHDJILIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x69B1300", Offset = "0x69AFD00", VA = "0x1869B1300")]
	public HOKHKEBIBCM([Optional] string LINOOIOFMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x69B0EA0", Offset = "0x69AF8A0", VA = "0x1869B0EA0", Slot = "9")]
	internal override void LJPFOPEFBHF(Stream LABBCNMHJAI, long ECEDKLNOLLD, long AJIFLLNCAHB, NIPEHLMICJG BADNOCAELMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x69B0480", Offset = "0x69AEE80", VA = "0x1869B0480", Slot = "10")]
	internal override bool ADHCHIECAKB(Stream HGEMPFAGNHF, long ECEDKLNOLLD, long AJIFLLNCAHB, IHCLKBKNDPB HJAMLHKJHFD, [Out] NIPEHLMICJG BADNOCAELMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x69B0DE0", Offset = "0x69AF7E0", VA = "0x1869B0DE0")]
	private void LJMIJIPHAHC(byte[] OIKPPLLAJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x69B0CB0", Offset = "0x69AF6B0", VA = "0x1869B0CB0", Slot = "11")]
	protected override FileInfo KHKGAJEOPGK(long ECEDKLNOLLD, long AJIFLLNCAHB, OONOEGKKCEB LAGEFEKOMON, HLJDBILBFLP CDAJBLCDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x69B1160", Offset = "0x69AFB60", VA = "0x1869B1160", Slot = "12")]
	protected override DirectoryInfo OINJHOEMGEM(OONOEGKKCEB LAGEFEKOMON, HLJDBILBFLP CDAJBLCDKMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public enum GMEIHDJILIP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal class ABKJLBFLOME : HAHEGLEMIGA
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class AGMODIAPBJA : IEnumerable<JDLHDFPPGKG>, IEnumerable, IEnumerator<JDLHDFPPGKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private JDLHDFPPGKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public ABKJLBFLOME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private OONOEGKKCEB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public OONOEGKKCEB <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private GMEIHDJILIP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		private IEnumerator<JDLHDFPPGKG> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		private JDLHDFPPGKG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x820E60", Offset = "0x81F860", VA = "0x180820E60")]
		[DebuggerHidden]
		public AGMODIAPBJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x69A4AA0", Offset = "0x69A34A0", VA = "0x1869A4AA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x69A46C0", Offset = "0x69A30C0", VA = "0x1869A46C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x69A4670", Offset = "0x69A3070", VA = "0x1869A4670")]
		private void AOIIEBMEGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x69A4A50", Offset = "0x69A3450", VA = "0x1869A4A50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x69A49A0", Offset = "0x69A33A0", VA = "0x1869A49A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JDLHDFPPGKG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x69A49A0", Offset = "0x69A33A0", VA = "0x1869A49A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private readonly GMEIHDJILIP[] ABDOLHMDFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private readonly Dictionary<GMEIHDJILIP, HAHEGLEMIGA> LEDNDFBNDBF;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public GMEIHDJILIP JMBODOFJKBH
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x69A3F60", Offset = "0x69A2960", VA = "0x1869A3F60", Slot = "4")]
		get
		{
			return default(GMEIHDJILIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x69A3F90", Offset = "0x69A2990", VA = "0x1869A3F90")]
	[UnityEngine.Scripting.Preserve]
	public ABKJLBFLOME(params HAHEGLEMIGA[] IEBECEPHCKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x69A3E10", Offset = "0x69A2810", VA = "0x1869A3E10", Slot = "5")]
	public bool LOCKGKICACB(long ECEDKLNOLLD, long AJIFLLNCAHB, OONOEGKKCEB LAGEFEKOMON, [Out] JDLHDFPPGKG AJKANDNNPCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x69A3A10", Offset = "0x69A2410", VA = "0x1869A3A10")]
	private void BLDFMFFNNPI(int CIPLJLGEHPB, long ECEDKLNOLLD, long AJIFLLNCAHB, OONOEGKKCEB LAGEFEKOMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x69A3C30", Offset = "0x69A2630", VA = "0x1869A3C30", Slot = "6")]
	[IteratorStateMachine(typeof(AGMODIAPBJA))]
	public IEnumerable<JDLHDFPPGKG> FDDLOKIFPMH(OONOEGKKCEB LAGEFEKOMON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A26C0", VA = "0x1869A3CC0", Slot = "7")]
	public JDLHDFPPGKG GPKNGLGKNPI(long ECEDKLNOLLD, long AJIFLLNCAHB, NIPEHLMICJG BADNOCAELMA, OONOEGKKCEB LAGEFEKOMON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal static class BHPFNAJJAHE
{
	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x69A5700", Offset = "0x69A4100", VA = "0x1869A5700")]
	internal static byte[] OHCEONIOAFM(byte[] OIKPPLLAJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x69A57C0", Offset = "0x69A41C0", VA = "0x1869A57C0")]
	public static void PMHIHEDNFLI(Stream GHKIPMIFOCA, byte[] ENFPMANFPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x69A5520", Offset = "0x69A3F20", VA = "0x1869A5520")]
	public static bool KJNOGCDBBNF(Stream GHKIPMIFOCA, long OGEPEKHOEJL, IHCLKBKNDPB PADJJGOKAJF, [Out] byte[] JAMKPNJJPHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal sealed class DKACMNACIGC : JDLHDFPPGKG, IEquatable<JDLHDFPPGKG>, IEquatable<DKACMNACIGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private readonly EIJAMDFIIJO PGCEMLJLHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	public readonly FileInfo EDGKGMIAMFG;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public GMEIHDJILIP JMBODOFJKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x63E7280", Offset = "0x63E5C80", VA = "0x1863E7280", Slot = "9")]
		get
		{
			return default(GMEIHDJILIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public DateTime HDHFKKMPBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x69A9CE0", Offset = "0x69A86E0", VA = "0x1869A9CE0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x69A9E20", Offset = "0x69A8820", VA = "0x1869A9E20")]
	public DKACMNACIGC(EIJAMDFIIJO FAMPCLIKGHA, FileInfo JHDFBKGNBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x69A9D70", Offset = "0x69A8770", VA = "0x1869A9D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x69A9B90", Offset = "0x69A8590", VA = "0x1869A9B90", Slot = "5")]
	public void GJFKIOLGGAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x69A9B50", Offset = "0x69A8550", VA = "0x1869A9B50", Slot = "6")]
	public bool FMAKHNPKJNN(long ECEDKLNOLLD, long AJIFLLNCAHB, [Out] NIPEHLMICJG BADNOCAELMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x69A9A70", Offset = "0x69A8470", VA = "0x1869A9A70", Slot = "7")]
	public bool Equals(JDLHDFPPGKG HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x69A99B0", Offset = "0x69A83B0", VA = "0x1869A99B0", Slot = "8")]
	public bool Equals(DKACMNACIGC HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x69A98C0", Offset = "0x69A82C0", VA = "0x1869A98C0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x69A9C50", Offset = "0x69A8650", VA = "0x1869A9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public delegate void IHCLKBKNDPB(CEOCPEGBKJC.JMBNEPKFIHI CCFMFPGLCGK, string CPPFNMDMGHI);
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal interface HAHEGLEMIGA
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	GMEIHDJILIP JMBODOFJKBH
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LOCKGKICACB(long ECEDKLNOLLD, long AJIFLLNCAHB, OONOEGKKCEB LAGEFEKOMON, [Out] JDLHDFPPGKG AJKANDNNPCH);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<JDLHDFPPGKG> FDDLOKIFPMH(OONOEGKKCEB LAGEFEKOMON);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JDLHDFPPGKG GPKNGLGKNPI(long ECEDKLNOLLD, long AJIFLLNCAHB, NIPEHLMICJG BADNOCAELMA, OONOEGKKCEB LAGEFEKOMON);
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
