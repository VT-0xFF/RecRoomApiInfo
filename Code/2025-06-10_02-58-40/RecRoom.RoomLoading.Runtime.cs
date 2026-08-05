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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8499B60", Offset = "0x8498D60", VA = "0x188499B60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class EIAPKNHOKAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<CAGKJJGCDMM> CAIPIEANMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task BJABDJEFFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal PMNACDPOEAJ LGAOHNMPBKK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public EIAPKNHOKAL()
	{
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8495060", Offset = "0x8494260", VA = "0x188495060", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x849D030", Offset = "0x849C230", VA = "0x18849D030", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DOOGNKOGBON : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8486030", Offset = "0x8485230", VA = "0x188486030")]
	public DOOGNKOGBON(string NPEJLHCJPAI, Exception LANNDIJMBDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class LLCJCOFKJDI : CHCLCNOAJHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KALBGEPPNGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<IReadOnlyList<ALGKPHFBIHO>> <>t__builder;

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
		private TaskAwaiter<NEIGFBIJPCO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8492360", Offset = "0x8491560", VA = "0x188492360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84925A0", Offset = "0x84917A0", VA = "0x1884925A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OPNMPLDPCDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<FEHGIEDLMGC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<List<FEHGIEDLMGC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x849A5A0", Offset = "0x84997A0", VA = "0x18849A5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x849A7B0", Offset = "0x84999B0", VA = "0x18849A7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	[UnityEngine.Scripting.Preserve]
	public LLCJCOFKJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8493CF0", Offset = "0x8492EF0", VA = "0x188493CF0", Slot = "4")]
	[AsyncStateMachine(typeof(KALBGEPPNGM))]
	public Task<IReadOnlyList<ALGKPHFBIHO>> PFAPLBDFGMH(long LADMAADOIBG, long JAFHDCNJHEA, [Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8493BE0", Offset = "0x8492DE0", VA = "0x188493BE0", Slot = "5")]
	[AsyncStateMachine(typeof(OPNMPLDPCDH))]
	public Task<IReadOnlyList<FEHGIEDLMGC>> LGCEMGPIICK(IReadOnlyList<int> LOIDJBHKABC, [Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MKEHEPHAECB : IEquatable<MKEHEPHAECB>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int MEAJPPECHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	FEHGIEDLMGC NCEEBBEJEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime MFLHMFPGLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KJKECKPLHDC? BLNGHAKMEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MAOOEOBLIGO? CADPDJAHKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	IKJLNNCNLFK ENMKEJOGCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<ONOANLDBBEM> EPLNIJPAJBG();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum IKJLNNCNLFK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CHCLCNOAJHB
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<ALGKPHFBIHO>> PFAPLBDFGMH(long LADMAADOIBG, long JAFHDCNJHEA, [Optional] CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<FEHGIEDLMGC>> LGCEMGPIICK(IReadOnlyList<int> LOIDJBHKABC, [Optional] CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GKICJJKJCLL
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class EABNBJIDALJ : MKEHEPHAECB, IEquatable<MKEHEPHAECB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct NIGHMDJHKGF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<ONOANLDBBEM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public EABNBJIDALJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private GAPAGLFJNJK <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<EAAMLCEDMMD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<ONOANLDBBEM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8498330", Offset = "0x8497530", VA = "0x188498330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x84988C0", Offset = "0x8497AC0", VA = "0x1884988C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly ALGKPHFBIHO KPGIOKGBJNM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int MEAJPPECHGL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FEHGIEDLMGC NCEEBBEJEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime CFEMGBGMAPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x84860E0", Offset = "0x84852E0", VA = "0x1884860E0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KJKECKPLHDC? BLNGHAKMEFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2B16BA0", Offset = "0x2B15DA0", VA = "0x182B16BA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MAOOEOBLIGO? CADPDJAHKKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x84863B0", Offset = "0x84855B0", VA = "0x1884863B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IKJLNNCNLFK ENMKEJOGCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA4FC30", Offset = "0xA4EE30", VA = "0x180A4FC30", Slot = "10")]
			get
			{
				return default(IKJLNNCNLFK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8486100", Offset = "0x8485300", VA = "0x188486100", Slot = "9")]
		[AsyncStateMachine(typeof(NIGHMDJHKGF))]
		public Task<ONOANLDBBEM> EPLNIJPAJBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84863D0", Offset = "0x84855D0", VA = "0x1884863D0")]
		public EABNBJIDALJ(int CMPNGECHJIE, FEHGIEDLMGC MFCFPMLMJKF, ALGKPHFBIHO KPGIOKGBJNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84862A0", Offset = "0x84854A0", VA = "0x1884862A0", Slot = "11")]
		public bool Equals(MKEHEPHAECB CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8486200", Offset = "0x8485400", VA = "0x188486200", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84860A0", Offset = "0x84852A0", VA = "0x1884860A0")]
		private bool DBAFAMINPFJ(EABNBJIDALJ CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8486330", Offset = "0x8485530", VA = "0x188486330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class MAGOINBPOHP : MKEHEPHAECB, IEquatable<MKEHEPHAECB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct INOHMOOEDKN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<ONOANLDBBEM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public MAGOINBPOHP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<ONOANLDBBEM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84919C0", Offset = "0x8490BC0", VA = "0x1884919C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8491C10", Offset = "0x8490E10", VA = "0x188491C10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly CBBEGLFAAKE POPLGLPAHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly KJKECKPLHDC PLILFAOAHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly MAOOEOBLIGO GMGMGJONHOL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int MEAJPPECHGL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x84953E0", Offset = "0x84945E0", VA = "0x1884953E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FEHGIEDLMGC NCEEBBEJEMN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x84957E0", Offset = "0x84949E0", VA = "0x1884957E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime CFEMGBGMAPL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8495480", Offset = "0x8494680", VA = "0x188495480", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KJKECKPLHDC? BLNGHAKMEFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8495870", Offset = "0x8494A70", VA = "0x188495870", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MAOOEOBLIGO? CADPDJAHKKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8495790", Offset = "0x8494990", VA = "0x188495790", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IKJLNNCNLFK ENMKEJOGCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xC38130", Offset = "0xC37330", VA = "0x180C38130", Slot = "10")]
			get
			{
				return default(IKJLNNCNLFK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1F58E10", Offset = "0x1F58010", VA = "0x181F58E10")]
		public MAGOINBPOHP(CBBEGLFAAKE MFAEBMNCOGP, KJKECKPLHDC JKPBGMJLNKL, MAOOEOBLIGO PKDJKACEGIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84954D0", Offset = "0x84946D0", VA = "0x1884954D0", Slot = "9")]
		[AsyncStateMachine(typeof(INOHMOOEDKN))]
		public Task<ONOANLDBBEM> EPLNIJPAJBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8495670", Offset = "0x8494870", VA = "0x188495670", Slot = "11")]
		public bool Equals(MKEHEPHAECB CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84955C0", Offset = "0x84947C0", VA = "0x1884955C0", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8495420", Offset = "0x8494620", VA = "0x188495420")]
		private bool DBAFAMINPFJ(MAGOINBPOHP CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8495710", Offset = "0x8494910", VA = "0x188495710", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private sealed class LEDDEKANCIK : MKEHEPHAECB, IEquatable<MKEHEPHAECB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct JIGIKENHLDK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<ONOANLDBBEM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<ONOANLDBBEM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8491CC0", Offset = "0x8490EC0", VA = "0x188491CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8491F20", Offset = "0x8491120", VA = "0x188491F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly FEHGIEDLMGC CKBHAFPMHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly KJKECKPLHDC PLILFAOAHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly MAOOEOBLIGO GMGMGJONHOL;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int MEAJPPECHGL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84937F0", Offset = "0x84929F0", VA = "0x1884937F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public FEHGIEDLMGC NCEEBBEJEMN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime CFEMGBGMAPL
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KJKECKPLHDC? BLNGHAKMEFF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8493B90", Offset = "0x8492D90", VA = "0x188493B90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public MAOOEOBLIGO? CADPDJAHKKC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8493B40", Offset = "0x8492D40", VA = "0x188493B40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IKJLNNCNLFK ENMKEJOGCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "10")]
			get
			{
				return default(IKJLNNCNLFK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F58E10", Offset = "0x1F58010", VA = "0x181F58E10")]
		public LEDDEKANCIK(FEHGIEDLMGC MFCFPMLMJKF, KJKECKPLHDC JKPBGMJLNKL, MAOOEOBLIGO PKDJKACEGIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84938F0", Offset = "0x8492AF0", VA = "0x1884938F0", Slot = "9")]
		[AsyncStateMachine(typeof(JIGIKENHLDK))]
		public Task<ONOANLDBBEM> EPLNIJPAJBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84939C0", Offset = "0x8492BC0", VA = "0x1884939C0", Slot = "11")]
		public bool Equals(MKEHEPHAECB CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8493A30", Offset = "0x8492C30", VA = "0x188493A30", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8493AB0", Offset = "0x8492CB0", VA = "0x188493AB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8493810", Offset = "0x8492A10", VA = "0x188493810")]
		private bool DBAFAMINPFJ(LEDDEKANCIK CMOCFNBHPLJ)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct DAADNEOMBGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<IList<MKEHEPHAECB>> <>t__builder;

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
		public GKICJJKJCLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IReadOnlyList<ALGKPHFBIHO> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<IReadOnlyList<ALGKPHFBIHO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<(int accountId, FEHGIEDLMGC account, ALGKPHFBIHO roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84848C0", Offset = "0x8483AC0", VA = "0x1884848C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8485760", Offset = "0x8484960", VA = "0x188485760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BKFJDKJDLPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, FEHGIEDLMGC account, ALGKPHFBIHO roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<ALGKPHFBIHO> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GKICJJKJCLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<IReadOnlyList<FEHGIEDLMGC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84832F0", Offset = "0x84824F0", VA = "0x1884832F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8483CD0", Offset = "0x8482ED0", VA = "0x188483CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HPHKHJIDLCI EFCDKNILMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly CHCLCNOAJHB GAIJCKEOLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MCCCLJHHDGE HPKCHADMINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly EIDHCHLOOHL<(long, long), IReadOnlyList<ALGKPHFBIHO>> KCGNFOBPKPD;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x848AC10", Offset = "0x8489E10", VA = "0x18848AC10")]
	[UnityEngine.Scripting.Preserve]
	public GKICJJKJCLL([NGLIAOPBMFM(null)] CHCLCNOAJHB NDHBGONAIMA, [NGLIAOPBMFM(null)] MCCCLJHHDGE JIOHCEJNLFN, [NGLIAOPBMFM(null)] HPHKHJIDLCI KEFIBJJBLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x848A920", Offset = "0x8489B20", VA = "0x18848A920")]
	[AsyncStateMachine(typeof(DAADNEOMBGC))]
	public Task<IList<MKEHEPHAECB>> CMHNOLCBKGC(long LADMAADOIBG, long OPILFBADOKA, bool MMJHAGODCHC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x848AA70", Offset = "0x8489C70", VA = "0x18848AA70")]
	private bool ONJGHGFAHMP(DateTime? JIALJOIECIP, long LADMAADOIBG, long OPILFBADOKA, [Out] CBBEGLFAAKE AABAAIKLAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x848A810", Offset = "0x8489A10", VA = "0x18848A810")]
	[AsyncStateMachine(typeof(BKFJDKJDLPN))]
	private Task<IReadOnlyList<(int, FEHGIEDLMGC, ALGKPHFBIHO)>> BAABIFBBJLO(IReadOnlyList<ALGKPHFBIHO> ANIKEMDAOAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MCCCLJHHDGE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<CBBEGLFAAKE> KKGFAOEFJLC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ILNOKIINNAH(long LADMAADOIBG, long OPILFBADOKA, PEPAFJMLFCF FKIIFAIOCNB, IDBHCDKMGJP LOAICONOLLD);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GCNMGMCKHJH(long LADMAADOIBG, long OPILFBADOKA, [Out] CBBEGLFAAKE AABAAIKLAIJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NFKAEKJONDJ(long LADMAADOIBG, long OPILFBADOKA, IDBHCDKMGJP LOAICONOLLD, [Out] CBBEGLFAAKE AABAAIKLAIJ);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDPDGDBLPDN(long LADMAADOIBG, long OPILFBADOKA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface NNCKDMIFPLA : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ELJKMADLDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task GAGOFKCHABM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILDPHJFGHHP(Task MKOPIIJMBLM, string EDIDKAFMHAH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface CKCEILMKLLA : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ONOANLDBBEM> MBDDMNOONEN(CBBEGLFAAKE AABAAIKLAIJ);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CHPJLLLNAOD(CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface MKFMFBPOMOL : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	GDABOMEIBEI JNCHMGDNJMI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLNFGJIJFLN();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKFGCEPKGFE();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface KEEEPPHJJDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface KMMADBMONKE
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan BHPONNLHOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan IJAMKOGJEOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan NALHOAAKAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan ILHCEIJHIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NBOFFKJKAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool NFGDGBCHCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool PKIHELAKBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int EGCMKNJHKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JNDEEGDEBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool KMEFMHEELGA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool JLJODKALAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum HCNKIHAMBIA
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum AIMFMPJJMCG
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
public struct BAILLPCCAKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly long GIMOIIPALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly long JAFHDCNJHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly HCNKIHAMBIA GDHKDBJPDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[CanBeNull]
	public readonly Exception IFHGJPOPNEO;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x847CE40", Offset = "0x847C040", VA = "0x18847CE40")]
	public BAILLPCCAKA(long GIMOIIPALOE, long JAFHDCNJHEA, HCNKIHAMBIA GDHKDBJPDLG, [CanBeNull] Exception IFHGJPOPNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x847CDF0", Offset = "0x847BFF0", VA = "0x18847CDF0")]
	public static BAILLPCCAKA DELEFIJNGAA(HPLNAENGEIP OPIKJGAGOLF, HCNKIHAMBIA GDHKDBJPDLG, [Optional] Exception IFHGJPOPNEO)
	{
		return default(BAILLPCCAKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void JMMNJNDCHLI(BAILLPCCAKA KABJBFJMJJL);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface JFLENANMJPK : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event JMMNJNDCHLI HADMCDEGFJI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JMMNJNDCHLI JPCCNOFLJOA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JMMNJNDCHLI NBGBPAABLBO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<AIMFMPJJMCG, bool> IDHNEDBEFLG;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IKHIDHOKMHN(BAILLPCCAKA KABJBFJMJJL);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IMIKEFIKAEC(BAILLPCCAKA KABJBFJMJJL);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ALJMPLNKAJD(BAILLPCCAKA KABJBFJMJJL);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MOOMOLIIFLD(AIMFMPJJMCG JEMHLLLEHAD, bool LPBBIEGNCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface FEFPCGFOOFE : KEEEPPHJJDK, IDisposable, JIPAPDGIIFO
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool HEFILFJACDF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHKOJBEDOPK();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface CCIPIEMODMF : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus BLKMLPHLOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GAOOAKDEECF(HPLNAENGEIP CKKPLENLEPO, FPDNILICPEG HODBGMFAIPK, CancellationToken CDMFGCJPANH);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class CPBCEFEMCAG
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8484870", Offset = "0x8483A70", VA = "0x188484870")]
	public static bool CBFOKBGAKAM(this CCIPIEMODMF IKJEPHDAABI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task BBJKJLONOHC(CancellationToken CCLFNPCGNED, int CBCJLPKKBGM, OHDGGAAKGEM PFPIBCCLABA);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface FAGAHDOLLOE : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBOMIDCFLED(BBJKJLONOHC KLOAFLDIHNA);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface AEHEGPIEOCE : GAPAGLFJNJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken MEHGBGNNEHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	FJCFOKJAKFO MNODBJDILJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AGONIDGIFFK OPHNBOFENLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	JLEGCCMAOMJ CLFDCJFFPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	FANFNGDGAHN ONPPLLOGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	FGBIFPHEHIH JHFEFNFLGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	CHEBGOMCOHH AMMFJLDBAND
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	FMJDBDONLDC NPPALPKKBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	GFDGEADJOLK HHDGBIMPLCN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	NNCKDMIFPLA MDEAJNHLKFB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CKCEILMKLLA GODOPOAABMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	JFLENANMJPK JANAJGHIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	FEFPCGFOOFE CFFPIAHCAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CCIPIEMODMF FIOMLBFEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FAGAHDOLLOE PCNNNNNJBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CGKOCCLEAOB CLDIAEOFKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KEEIKOODEHM FEMANJIBPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	KEIAIDMOLNO IMCFOEMFLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	JCPLNKMCPEJ CCIKKOFAEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	KKKHODIMONB HFAGNKCJFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ABCFEBOMBEM LOGHGGFHAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	AKIOIOJPPLM MMAMKHAELBB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	OKIBBCNJEOI GJOIOKBOPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	PNLJANENADH MIPMMHDOAJG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	BIFKLCBEFHK PDBOGPLMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	MKFMFBPOMOL IEJDDFLAJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	KMMADBMONKE DGOIGJBIBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	DHDJMPADGJE PEMHABNNPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	MCCCLJHHDGE AKMILGDNEFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	OKEDMDENPIA EEPEOPILFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	GMOGLPEOKFM NDHGKELFDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	MCCNADEBFLC CIPICBHCDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	KPIOGOKHAGB ABCIBFEEMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool OPMJAGPJBGG
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
	void EOPOJLMIHGD(FPDNILICPEG JFJDBHCAABL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface CGKOCCLEAOB : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MEMHEIOCIPD LHOMNBOIMGH(Guid GHIHMOONOIF);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKCJOLGDFLO(Guid GHIHMOONOIF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JGBCKMGEBAC(Guid GHIHMOONOIF, Task GEOEFKJEPHN);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HDGJKGBOFFH(Guid GHIHMOONOIF, ONOANLDBBEM JBFCFAPDKMM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(ONOANLDBBEM, Task)> KEMJNOHEJEL(Guid GHIHMOONOIF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface CCDDHJNDGNF : KEEEPPHJJDK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface KEEIKOODEHM : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGJHDOLENJG(FBDLPCDKOKJ NPEJLHCJPAI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLDFCMNHFFN(FBDLPCDKOKJ NPEJLHCJPAI);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<AFDJAMFDOCD> DJGDOOJKCKO(CancellationToken BMOAGFJLNLN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface KEIAIDMOLNO : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MEMHEIOCIPD GKENOIKGCEG(FBDLPCDKOKJ FNMMMDGJBLG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNHAAFJAHLE(Guid GHIHMOONOIF, Task GEOEFKJEPHN);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface JCPLNKMCPEJ : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ONOANLDBBEM> CCIKKOFAEIO(FBDLPCDKOKJ OIKJJICAEAA);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface KKKHODIMONB : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LBIKBDECECI> IDAHIHOOCEC(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, HPLNAENGEIP CKKPLENLEPO, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface AKIOIOJPPLM : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONOANLDBBEM IIKEOLDLKPG(BNFABCHNBCL DGJDBPKMOOE);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OOFPOHGMENN(string BLOCNHOFANF);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface ABCFEBOMBEM : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FBDLPCDKOKJ> GAHNMJHIMIJ(FBDLPCDKOKJ IKFDGIFGHKP, CGBDEFKMHHI KPCEMBLFBDD, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FBDLPCDKOKJ> PNMIDAIOPDN(CancellationToken FHBCOAHILMJ, CGBDEFKMHHI KPCEMBLFBDD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FBDJJJEGEAF JDHELBKPLMN(LAHJPJCGMDC PMBJAEFPMGN, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FBDJJJEGEAF FAOGLAONOBM(LAHJPJCGMDC PMBJAEFPMGN, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface OKIBBCNJEOI : KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONOANLDBBEM FJNAAJFPBNA(BNFABCHNBCL DGJDBPKMOOE, AFDJAMFDOCD FNNHHHKCEEP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ONOANLDBBEM OCMIGJJIJDI(BNFABCHNBCL MCHIEDFKOJI);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface NCEPPMBFOIF
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	const int GGKFJKMFONC = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, ACILDGALMOA> NFDNIKMDGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action AFDFFKJMHKA
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
	IReadOnlyList<Guid> NIKBECFPEAJ();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task ECPKNMGEHBO([Optional] CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task CBGBGNMMMOC([Optional] CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface PNLJANENADH
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPIEMEIGHNJ(IDCFDGBFOML MIKGBOMEDCE);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKLECILCJLD(IDCFDGBFOML MIKGBOMEDCE);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOOKNOMMCJA(IDCFDGBFOML MIKGBOMEDCE);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KDLHBPLCBAD(IDCFDGBFOML MIKGBOMEDCE);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class IDCFDGBFOML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly HPLNAENGEIP KHGJPFNEPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Dictionary<string, string> GLOCNBHIIAF;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public BGHCJGPGCNF<string> KIMBLDOOHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public IDCFDGBFOML(HPLNAENGEIP EJHGGALBJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8490E00", Offset = "0x8490000", VA = "0x188490E00")]
	public IDCFDGBFOML IPJHOALMHGP(string MHDODBCCAJB, string KJIOHKMJAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8490D70", Offset = "0x848FF70", VA = "0x188490D70")]
	public bool EEJFEODNCJJ([Out] IEnumerable<KeyValuePair<string, string>> AJJMEBKDPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x72C4DF0", Offset = "0x72C3FF0", VA = "0x1872C4DF0")]
	public IDCFDGBFOML DECPBPKCJGO(BGHCJGPGCNF<string> LAEALHELJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface DHDJMPADGJE
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool BEDCHJGJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string OLMLEJFDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool NKDDKHGIIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEFMOAIMODE();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ODKGACJINAN AMLOBIGABMH(long DCNFHIPJBKF);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PPACNMHEMIK<JENOKPCEBIE, KLFAJJACBNI> IEAPEBPFICJ(long DCNFHIPJBKF);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PPACNMHEMIK<JENOKPCEBIE, OJIMHFCMHLE> ILHPBNCBCHN(long DCNFHIPJBKF);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PPACNMHEMIK<long, BODMDNMFLKL> IFKNOOJJEHK();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<MBKDIDMGHMN>> KMOINAMJLPK(long DCNFHIPJBKF, IReadOnlyCollection<MBKDIDMGHMN> MHMIHAJEGOI, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IEIFMNNODCG(long DCNFHIPJBKF, [Out] bool FNFHEJOPAHN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> EPGFMNBOGAA(byte[] NDINKJMLNJN, byte[] AIMLLENJKOF, IReadOnlyCollection<Guid> FJAAAGGEHFE, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface EAPMNCNAJAH
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LBIKBDECECI DBJJOAFKEPP(long GIMOIIPALOE, long JAFHDCNJHEA, string KBKFCDKCGMH);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LBIKBDECECI DBJJOAFKEPP(long GIMOIIPALOE, long JAFHDCNJHEA, JENOKPCEBIE NDINKJMLNJN, Guid? KPDMPLIMJOK, long KFBIFEHDOHB, bool LBGHMCHHKEI);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LBIKBDECECI DBJJOAFKEPP(FDACCKBMCMP AHNGJDDEGNB);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LBIKBDECECI DBJJOAFKEPP(EAAMLCEDMMD GPKMEJKNBFF, ALGKPHFBIHO GDKHIEOEBCO);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface GAPAGLFJNJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool CBFOKBGAKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool KGIPJPKEOGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool OPMJAGPJBGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	EAPMNCNAJAH CAJMKFCFLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	FPDNILICPEG ACGPBCICDHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event JMMNJNDCHLI HADMCDEGFJI;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event JMMNJNDCHLI JPCCNOFLJOA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event JMMNJNDCHLI NBGBPAABLBO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<AIMFMPJJMCG, bool> IDHNEDBEFLG;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FHKOJBEDOPK();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CABAMHBHPPN JMILAHHHNAB();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AJCJIHKIFOH KJHBALCMLGI();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task HBBGEHIPNAE(int FAJKMEHKDDK, AJOEGJCHHHM JPGGEILHFHL, Func<PEPAFJMLFCF, PEPAFJMLFCF> JKLOMGHGAEM);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<ONOANLDBBEM> MBDDMNOONEN(CBBEGLFAAKE MFAEBMNCOGP);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task CHPJLLLNAOD(CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface FGBIFPHEHIH
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool NJOBKGEHEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool GGPNCOPJFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? CLHFIDDAACG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHBEJGKKCFD(Scene IDOAEGHFOCI);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task OJCJGBHEHGA(OCHIFCLAGPH APKKJLNMIPE, IReadOnlyList<OCHIFCLAGPH> JIFCNIOHGMM, IReadOnlyList<OCHIFCLAGPH> AOHBBAFLOPN, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EJDIGHGFHHP(Guid KNDLKPHHAPO, IReadOnlyList<Guid> FJAAAGGEHFE, GAFPFHPADLO PGNNODHFNEO, [Optional] object GGBHDCNKKMM);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task EPOICDNMOKO(IReadOnlyList<Guid> NAFAKLEKFCK, CancellationToken EPEIHHIIDCL);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NFBMMPLDNBK AJHFLPCAGCC();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task GKLLLLAKBDN();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NFAAHAMOINF(GameObject DGGDMAPLALO);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task GKOJMNABOLK();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface FANFNGDGAHN
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	BPFCLMEBPNG EEJBLGPIIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool KHEEKECHIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool MMGPEMILEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool BLNJEGOJOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool HFLKKOCGGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int POAPCKCGCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool GHLCEIMPKHA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool CHFMNLKMPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int LEELIGALOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int NLPLICFOAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool DCHBAHHINEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool ACHEAIBPFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool NBAICNMFMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float EIMBKKMMJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> FPABFNKHFJA;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FJCFOKJAKFO HBECELHHANC(FJCFOKJAKFO KFHCLEDGFOD);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDKGCCAHMIG(FJCFOKJAKFO MBLPEFIMNGA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECKCIOINAHD();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task DNKDKDECCDL(BGHCJGPGCNF<string>.IPAINGKGFDM DGCLLDLGKGE, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LNBDEJGOPEC(float CMFBMIMHAIC);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GJBDGKMPIPH(string BDODAAJJOKK);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<CBFAMDHOPFE> OAOINKDHDDO();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable DDIBCCPHDHC(object BKDMJHGCDEA, CBFAMDHOPFE LNODHBGPGBD);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<JMFCLCMDBEE> PBHOMBGEGMC();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KLFAJJACBNI GHOCCNIGPKG(IEnumerable<IHCKNOKFLCP> ONJBDCAAEEC);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LMPCACAAGBB(int IEGHFABKDKJ);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task HBFHAHAHGHN();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ANAKHMPOMLO();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool PCMEMNIAICI();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task NJPAOJCFALB(CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task JDCECJLBLEL(CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<FJEIFPOFGFK> JNOCDHAPIDA(DateTime GDKJJCHCDBA, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> KIJMFGPKHKF(CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JAHLMBNENBA(string NPEJLHCJPAI = "", float PFMGKMLLMHD = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GBABIBPNNEA GPGKOFDGBAI(EDJHGEODNOP LBOHKNIKOHK, ALLJAELJMGC EJIFCBFMJHA, OJIMHFCMHLE JEJAOMOCEBC, IEnumerable<PersistenceView> FIDFLICMFGA, JECDKMJCGFK BBLAKKCCBNE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CDFBDOALEMH(OJIMHFCMHLE JEJAOMOCEBC);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MGAKJINAELE(IHCKNOKFLCP ABECEAAIGGD, [In] GBABIBPNNEA KCPCJFLCGMH);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task FCKIHLLEMPM(OJIMHFCMHLE FPHEFLPLCMP, bool DABEAMOFNJO, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task MGEBLMOAKGL(CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void FLGLPHJJKLM(long LADMAADOIBG, long JAFHDCNJHEA, EAAMLCEDMMD PCKDNOKGHKJ, ALGKPHFBIHO ICKGNPOAOPP, PEPAFJMLFCF FKIIFAIOCNB, AJOEGJCHHHM? JPGGEILHFHL, NHGPKAMOGJM? NIHLNHBHPFK);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void BHNDALFNCFE(long LADMAADOIBG, long JAFHDCNJHEA, NHGPKAMOGJM? NIHLNHBHPFK);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void FPFDJDGPKEC(PersistenceView CLCCIBPMDFA);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void DEOHJNJDPLB(string PKFBOAFCNGA, HPLNAENGEIP EJHGGALBJHE, JDHAANHFGMM PHIHHHNMFCO, [Optional] string? LDDELGPEIIC, [Optional] string? ENGBFFNFEFM, [Optional] string? NBMOGDCJMFC);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool DNMFEDKAEIL(PersistenceView PEGCLJNJBJG);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PHIGMEMAFGN(IHCKNOKFLCP ABECEAAIGGD, MGNNNNPADNA BAPPDGICHBL, [Out] GHHAIJGAMIK PDIAPJAELKO);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task NCEMDHJNAOD(CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void DPDDEJBLIKC();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable NKNMNAKOFCJ();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void JPMKBBELKJH(OJIMHFCMHLE FPHEFLPLCMP, MGNNNNPADNA BAPPDGICHBL);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> POLCEJCKKKG(AGONIDGIFFK NCFBNFPHDDJ, CancellationToken FHBCOAHILMJ, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void FFHMILNHNJD(CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<FDACCKBMCMP> IGNKKGLNJND(GGKONIHJABD IKFDGIFGHKP);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<EAAMLCEDMMD> CFLCJMPECEI(long LADMAADOIBG, bool GDGPECFMDDI, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<FLCIPAFBKAP> ILNGCINCGEN(long LADMAADOIBG, long JAFHDCNJHEA, long KFBIFEHDOHB, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<ALGKPHFBIHO> GGOCKLKFCFD(long LADMAADOIBG, long JAFHDCNJHEA, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<BIDCFCNHFIC> KGJKBIMFLFE(long LADMAADOIBG, Guid CFNMBMKBNMM, long? OPILFBADOKA, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	PPACNMHEMIK<BIDCFCNHFIC, IEnumerable<KKEGNBCFCEE>> HPEHNLFJGHH();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<OGNBBNBFGHI> CLLFDOAGHEM(string KBKFCDKCGMH, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<OGNBBNBFGHI> OEGHHKJPFNM(string KBKFCDKCGMH, long LADMAADOIBG, long JAFHDCNJHEA, Guid? KNDLKPHHAPO, JFCGPCLMOJE.AEJPFPKJIAC JCFOMPGDMKN, JFCGPCLMOJE.AEJPFPKJIAC AIMLLENJKOF, int FAJKMEHKDDK);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool OKMJMBDPGIF();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool AMEKHFFFMHP();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool KDGHHCEMCPH(IEnumerable<GHHAIJGAMIK> CAEPKBDFHLP);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void BHKKDKNCABG(List<GameObject> JGIHMOLCJCF);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float CELHMLBNKJA();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> AOMFCEDJBIM(CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> IKIMKENHMNL(string KFEKBOLMGJM, LoadSceneMode DBLDCBJEDBN, bool LPEBBANBBFG, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void KMOIIAGGODH(bool NPFLOGOKNBN);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void LGOMNKDLJLN();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void BHJLEAKLBHI();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void CMKLMBDNGGH(bool LIAAOGDOMMP);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task<JFCGPCLMOJE.AEJPFPKJIAC> MFPMNNGFFPF(byte[] CAIGHLKIDBF, JFCGPCLMOJE.JCLBJKMELNM DKAAIJMKDGM, AHLAFFPHLBD HKNFGACOENA, [Optional] IReadOnlyCollection<string>? EFAJONAFDHH, [Optional] string? IEFJAINDNJO);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void HAABBAFIBFG(HPLNAENGEIP ODCMJFJDLEN);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task EBGPPCOBGAM(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task GOJODOFKOPG(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task HOIDKCFAPCJ(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task FKMLOKHCALD(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "77")]
	IDisposable IILAPMOMFNE();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "78")]
	ABGHNPFLDKH NONMEANHLMP();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "79")]
	Task OGAODBBAKMP(CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface ABGHNPFLDKH
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PHLHCDJJBOL(CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LGNOHKONDFM(CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct GBABIBPNNEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HashSet<int> LOGKKKNLHDF;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum FJEIFPOFGFK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct EDJHGEODNOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Guid? GJJACFEFMNE;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BPFCLMEBPNG
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	HPLNAENGEIP JHAJBAIMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	EAAMLCEDMMD DJDKIBHLGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	EBAEPIOAJNM DLDOCOOGIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool OPBIAKOLHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool KOHGPLFNBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int HCIAJANKDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action KDIMKKCGFPL;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> BADKJKBJFJL;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HBAOBCAKIHD();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.FIOJJCCKODK> FBLEBGMCEDB(long DCNFHIPJBKF, [Optional] CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<ANFLHGMKNNH> HLMCHFGHLKL(HPLNAENGEIP EJHGGALBJHE, [Optional] FPDNILICPEG HODBGMFAIPK);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<ANFLHGMKNNH> APMEBLHOFFN();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task IJJGMNAPCCH();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(HPLNAENGEIP, FPDNILICPEG) ANKOMABFPOB();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	LPLCCKHEJAM OGLPAHCIAGF();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CKDBBHEBKMO(long DCNFHIPJBKF);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HHBEPGJCFNJ(HPLNAENGEIP EJHGGALBJHE, Matchmaking.HNGNBBDCAPL ACALKMLJJOL, (int Major, int? Minor)? LKKKAKAHAFI);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface BIFKLCBEFHK
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ILPAIBLHCLF([Out] IEnumerable<int> IHICKILINKJ);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBEBKBAEFKJ(JPIJMPDMIDF CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOGNOCLBFEF(JPIJMPDMIDF CCLFNPCGNED);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface NJLKHAEPCNO
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OCMCHNOJJMI(ONOANLDBBEM JGJIALJFAJA);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface COECKDNEPBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBDEIDNJAFH(CKKFMDJKMAP.PIPFFPADHOI LGDEOBFGFIE);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCBHMOPJLHF(CKKFMDJKMAP.PIPFFPADHOI LGDEOBFGFIE);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface CHEBGOMCOHH : COECKDNEPBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONOANLDBBEM FCCEMJDLMOK(BNFABCHNBCL MCHIEDFKOJI);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface FMJDBDONLDC : COECKDNEPBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONOANLDBBEM IIKEOLDLKPG(BNFABCHNBCL NKEACAOKBCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface ODKGACJINAN
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DJNAMIFBMIO<ENJOOAGPMBD, DCJPFEGHGPF>> CFJCKDPIKBK(Guid? KNDLKPHHAPO, IReadOnlyCollection<MBKDIDMGHMN> DHIDOGAMPDJ, IReadOnlyCollection<MBKDIDMGHMN> JBOPLHDOBPP, OKNHKJCFICO LMNCIPJHBIM, long? LADMAADOIBG, long? JAFHDCNJHEA, OCAMMJABECJ.DKNFOGEIBIK AEDDOKNLOFP, CancellationToken FHBCOAHILMJ, bool IDJKCBJADHI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class ENJOOAGPMBD
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public OCHIFCLAGPH PHEIBKDABME
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<OCHIFCLAGPH> KJKMNPMCOEC
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<OCHIFCLAGPH> KBFMBMIELAG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xC9C830", Offset = "0xC9BA30", VA = "0x180C9C830")]
	public ENJOOAGPMBD(OCHIFCLAGPH ECKGGGLMBBH, IReadOnlyList<OCHIFCLAGPH> PHFBLFCDGHK, IReadOnlyList<OCHIFCLAGPH> JIAIHGEOLPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface PPACNMHEMIK<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DJNAMIFBMIO<BCCCDAHDJFG<TData>, DCJPFEGHGPF>> FGIDDHOKEFK(TGetDataArg BNCBJIMFGHJ, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class MBGNOIEJDOD : AEHEGPIEOCE, GAPAGLFJNJK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct OCKCPJOIAKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<ONOANLDBBEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public MBGNOIEJDOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CBBEGLFAAKE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<ONOANLDBBEM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8499BE0", Offset = "0x8498DE0", VA = "0x188499BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8499E60", Offset = "0x8499060", VA = "0x188499E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct MBJOMJMHMBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public MBGNOIEJDOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8496C40", Offset = "0x8495E40", VA = "0x188496C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8496E70", Offset = "0x8496070", VA = "0x188496E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class PHDBEAPBABP : IEnumerable<KEEEPPHJJDK>, IEnumerable, IEnumerator<KEEEPPHJJDK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private KEEEPPHJJDK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public MBGNOIEJDOD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private KEEEPPHJJDK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public PHDBEAPBABP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x849B9D0", Offset = "0x849ABD0", VA = "0x18849B9D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x849BE30", Offset = "0x849B030", VA = "0x18849BE30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x849BD80", Offset = "0x849AF80", VA = "0x18849BD80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KEEEPPHJJDK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x849BD80", Offset = "0x849AF80", VA = "0x18849BD80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CancellationTokenSource KCDHBLEDCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly FJCFOKJAKFO MBLPEFIMNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool JDKAOICAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EAKLNIOLGPG FFPJGAFMIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool IHCNPPNMFIN;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public AGONIDGIFFK OPHNBOFENLB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA003E0", Offset = "0x9FF5E0", VA = "0x180A003E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public JLEGCCMAOMJ CLFDCJFFPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA00350", Offset = "0x9FF550", VA = "0x180A00350", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA003D0", Offset = "0x9FF5D0", VA = "0x180A003D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public FANFNGDGAHN ONPPLLOGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA00390", Offset = "0x9FF590", VA = "0x180A00390", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA003A0", Offset = "0x9FF5A0", VA = "0x180A003A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public FGBIFPHEHIH JHFEFNFLGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA00370", Offset = "0x9FF570", VA = "0x180A00370", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA00380", Offset = "0x9FF580", VA = "0x180A00380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public CHEBGOMCOHH AMMFJLDBAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA003C0", Offset = "0x9FF5C0", VA = "0x180A003C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA003B0", Offset = "0x9FF5B0", VA = "0x180A003B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FMJDBDONLDC NPPALPKKBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA0E420", Offset = "0xA0D620", VA = "0x180A0E420", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA0E4E0", Offset = "0xA0D6E0", VA = "0x180A0E4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public EAPMNCNAJAH CAJMKFCFLKA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA0E4A0", Offset = "0xA0D6A0", VA = "0x180A0E4A0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA0E3C0", Offset = "0xA0D5C0", VA = "0x180A0E3C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public GFDGEADJOLK HHDGBIMPLCN
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA0E520", Offset = "0xA0D720", VA = "0x180A0E520", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA0E400", Offset = "0xA0D600", VA = "0x180A0E400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public NNCKDMIFPLA MDEAJNHLKFB
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xC50C10", Offset = "0xC4FE10", VA = "0x180C50C10", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x13DDAA0", Offset = "0x13DCCA0", VA = "0x1813DDAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public CKCEILMKLLA GODOPOAABMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA0E550", Offset = "0xA0D750", VA = "0x180A0E550", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA0E470", Offset = "0xA0D670", VA = "0x180A0E470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public JFLENANMJPK JANAJGHIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xD54F00", Offset = "0xD54100", VA = "0x180D54F00", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xEBEEA0", Offset = "0xEBE0A0", VA = "0x180EBEEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public FEFPCGFOOFE CFFPIAHCAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA07240", Offset = "0xA06440", VA = "0x180A07240", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA071B0", Offset = "0xA063B0", VA = "0x180A071B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public CCIPIEMODMF FIOMLBFEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xDC9B70", Offset = "0xDC8D70", VA = "0x180DC9B70", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xECEDD0", Offset = "0xECDFD0", VA = "0x180ECEDD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FAGAHDOLLOE PCNNNNNJBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA90A00", Offset = "0xA8FC00", VA = "0x180A90A00", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA90A10", Offset = "0xA8FC10", VA = "0x180A90A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public CGKOCCLEAOB CLDIAEOFKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA909C0", Offset = "0xA8FBC0", VA = "0x180A909C0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA909D0", Offset = "0xA8FBD0", VA = "0x180A909D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public CCDDHJNDGNF EMEMKEANNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA90A30", Offset = "0xA8FC30", VA = "0x180A90A30", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA909A0", Offset = "0xA8FBA0", VA = "0x180A909A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public KEEIKOODEHM FEMANJIBPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA899D0", Offset = "0xA88BD0", VA = "0x180A899D0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA84D50", Offset = "0xA83F50", VA = "0x180A84D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public KEIAIDMOLNO IMCFOEMFLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA071D0", Offset = "0xA063D0", VA = "0x180A071D0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA07200", Offset = "0xA06400", VA = "0x180A07200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public JCPLNKMCPEJ CCIKKOFAEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA89CD0", Offset = "0xA88ED0", VA = "0x180A89CD0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA85DA0", Offset = "0xA84FA0", VA = "0x180A85DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public KKKHODIMONB HFAGNKCJFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xB1C0E0", Offset = "0xB1B2E0", VA = "0x180B1C0E0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xB1AC50", Offset = "0xB19E50", VA = "0x180B1AC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public ABCFEBOMBEM LOGHGGFHAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xB17C70", Offset = "0xB16E70", VA = "0x180B17C70", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB0C560", Offset = "0xB0B760", VA = "0x180B0C560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public AKIOIOJPPLM MMAMKHAELBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA89C20", Offset = "0xA88E20", VA = "0x180A89C20", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA81E00", Offset = "0xA81000", VA = "0x180A81E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public OKIBBCNJEOI GJOIOKBOPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA89E60", Offset = "0xA89060", VA = "0x180A89E60", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA858E0", Offset = "0xA84AE0", VA = "0x180A858E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public PNLJANENADH MIPMMHDOAJG
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA89D00", Offset = "0xA88F00", VA = "0x180A89D00", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA8A040", Offset = "0xA89240", VA = "0x180A8A040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public BIFKLCBEFHK PDBOGPLMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA899E0", Offset = "0xA88BE0", VA = "0x180A899E0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA89EC0", Offset = "0xA890C0", VA = "0x180A89EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public MKFMFBPOMOL IEJDDFLAJPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAC5AD0", Offset = "0xAC4CD0", VA = "0x180AC5AD0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xAC1B70", Offset = "0xAC0D70", VA = "0x180AC1B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public KMMADBMONKE DGOIGJBIBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xB14310", Offset = "0xB13510", VA = "0x180B14310", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xB082D0", Offset = "0xB074D0", VA = "0x180B082D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public DHDJMPADGJE PEMHABNNPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA89D60", Offset = "0xA88F60", VA = "0x180A89D60", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84C40", VA = "0x180A85A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public MCCCLJHHDGE AKMILGDNEFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA899C0", Offset = "0xA88BC0", VA = "0x180A899C0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public OKEDMDENPIA EEPEOPILFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xB0CEC0", Offset = "0xB0C0C0", VA = "0x180B0CEC0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public GMOGLPEOKFM NDHGKELFDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xB07AD0", Offset = "0xB06CD0", VA = "0x180B07AD0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public MCCNADEBFLC CIPICBHCDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xB067F0", Offset = "0xB059F0", VA = "0x180B067F0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public KPIOGOKHAGB ABCIBFEEMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xB20000", Offset = "0xB1F200", VA = "0x180B20000", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public FPDNILICPEG ACGPBCICDHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xB14690", Offset = "0xB13890", VA = "0x180B14690", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xC86B60", Offset = "0xC85D60", VA = "0x180C86B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool IHIFFGIHOFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8495EF0", Offset = "0x84950F0", VA = "0x188495EF0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool FOPCANLFBOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8495F50", Offset = "0x8495150", VA = "0x188495F50", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool NBBAPDCGKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1230700", Offset = "0x122F900", VA = "0x181230700", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken EIPBPAHNHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8495BD0", Offset = "0x8494DD0", VA = "0x188495BD0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private FJCFOKJAKFO GGGGPMNGJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool AFHOEADLOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1230700", Offset = "0x122F900", VA = "0x181230700", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D15440", Offset = "0x1D14640", VA = "0x181D15440", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event JMMNJNDCHLI APAILPPKMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x84964B0", Offset = "0x84956B0", VA = "0x1884964B0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8495D80", Offset = "0x8494F80", VA = "0x188495D80", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event JMMNJNDCHLI NNDBIJGGBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8495E30", Offset = "0x8495030", VA = "0x188495E30", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8495970", Offset = "0x8494B70", VA = "0x188495970", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event JMMNJNDCHLI GMOEDBKEKEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x84962E0", Offset = "0x84954E0", VA = "0x1884962E0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8496340", Offset = "0x8495540", VA = "0x188496340", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event Action<AIMFMPJJMCG, bool> CNFNJAOHPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8496600", Offset = "0x8495800", VA = "0x188496600", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8496510", Offset = "0x8495710", VA = "0x188496510", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xC86B60", Offset = "0xC85D60", VA = "0x180C86B60", Slot = "39")]
	public void EOPOJLMIHGD(FPDNILICPEG JFJDBHCAABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8496770", Offset = "0x8495970", VA = "0x188496770")]
	[UnityEngine.Scripting.Preserve]
	internal MBGNOIEJDOD([NGLIAOPBMFM(null)] FJCFOKJAKFO MBLPEFIMNGA, [NGLIAOPBMFM(null)] AGONIDGIFFK NCFBNFPHDDJ, [NGLIAOPBMFM(null)] JLEGCCMAOMJ MBKOOBJMOJE, [NGLIAOPBMFM(null)] FANFNGDGAHN PLKEMCOOOMD, [NGLIAOPBMFM(null)] FGBIFPHEHIH ICPECFDCDDL, [NGLIAOPBMFM(null)] CHEBGOMCOHH PIJGDCDLBKN, [NGLIAOPBMFM(null)] FMJDBDONLDC DJOOOBHJMCJ, [NGLIAOPBMFM(null)] GFDGEADJOLK DJAEFDPEFJK, [NGLIAOPBMFM(null)] NNCKDMIFPLA AIDICANLPAO, [NGLIAOPBMFM(null)] CKCEILMKLLA HGIHCAOEJHM, [NGLIAOPBMFM(null)] JFLENANMJPK FANIAMKJHGP, [NGLIAOPBMFM(null)] FEFPCGFOOFE LKGLKJGGLJJ, [NGLIAOPBMFM(null)] CCIPIEMODMF IKJEPHDAABI, [NGLIAOPBMFM(null)] FAGAHDOLLOE CMPLHLLDIPN, [NGLIAOPBMFM(null)] CGKOCCLEAOB AKBOLNJLJBA, [NGLIAOPBMFM(null)] CCDDHJNDGNF ICBPPGGHIOF, [NGLIAOPBMFM(null)] KEEIKOODEHM IMNFKDKDMMA, [NGLIAOPBMFM(null)] KEIAIDMOLNO HCABJLGPKJB, [NGLIAOPBMFM(null)] JCPLNKMCPEJ FMFJOEBJMEP, [NGLIAOPBMFM(null)] KKKHODIMONB DFNHDHNINMB, [NGLIAOPBMFM(null)] AKIOIOJPPLM JHIPJECKOAN, [NGLIAOPBMFM(null)] ABCFEBOMBEM KAFNDKKJBDM, [NGLIAOPBMFM(null)] OKIBBCNJEOI IFEOGNBFBPJ, [NGLIAOPBMFM(null)] PNLJANENADH POELPGGOGAG, [NGLIAOPBMFM(null)] BIFKLCBEFHK GJCCFBAKBEK, [NGLIAOPBMFM(null)] KMMADBMONKE HICOIPDJCOI, [NGLIAOPBMFM(null)] DHDJMPADGJE IKFIONIIIOP, [NGLIAOPBMFM(null)] MCCCLJHHDGE JENELNBNHNE, [NGLIAOPBMFM(null)] OKEDMDENPIA GNHCKBFGMKK, [NGLIAOPBMFM(null)] GMOGLPEOKFM PGFHJGFEGPD, [NGLIAOPBMFM(null)] MCCNADEBFLC LHPDGBFBJHN, [NGLIAOPBMFM(null)] KPIOGOKHAGB MKJPNEFAJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x84958C0", Offset = "0x8494AC0", VA = "0x1884958C0")]
	private void AFLILFPIJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8495BF0", Offset = "0x8494DF0", VA = "0x188495BF0", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8495DE0", Offset = "0x8494FE0", VA = "0x188495DE0", Slot = "51")]
	private void EBPKMNGODMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8496570", Offset = "0x8495770", VA = "0x188496570", Slot = "52")]
	private CABAMHBHPPN OEAEDEABHPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8496420", Offset = "0x8495620", VA = "0x188496420", Slot = "53")]
	private AJCJIHKIFOH KOBPPEDBBEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8495FD0", Offset = "0x84951D0", VA = "0x188495FD0", Slot = "55")]
	public Task HBBGEHIPNAE(int FAJKMEHKDDK, AJOEGJCHHHM JPGGEILHFHL, Func<PEPAFJMLFCF, PEPAFJMLFCF> JKLOMGHGAEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x8495AC0", Offset = "0x8494CC0", VA = "0x188495AC0")]
	private GHPKINLPLIH CJOKNLGOOGH(int FAJKMEHKDDK, AJOEGJCHHHM JPGGEILHFHL, Func<PEPAFJMLFCF, PEPAFJMLFCF> JKLOMGHGAEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8496660", Offset = "0x8495860", VA = "0x188496660", Slot = "56")]
	[AsyncStateMachine(typeof(OCKCPJOIAKM))]
	private Task<ONOANLDBBEM> OKGHNLKJLMO(CBBEGLFAAKE AABAAIKLAIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x84959D0", Offset = "0x8494BD0", VA = "0x1884959D0", Slot = "57")]
	[AsyncStateMachine(typeof(MBJOMJMHMBA))]
	private Task CHNPFLEAIGG(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x84963A0", Offset = "0x84955A0", VA = "0x1884963A0")]
	[IteratorStateMachine(typeof(PHDBEAPBABP))]
	private IEnumerable<KEEEPPHJJDK> KEBELLHODON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8495E90", Offset = "0x8495090", VA = "0x188495E90")]
	[CompilerGenerated]
	private void FAABPLEHGFC(KEEEPPHJJDK JCAGDPHNPIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class CEOGHFKCOKA : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x18EE870", Offset = "0x18EDA70", VA = "0x1818EE870")]
	public CEOGHFKCOKA(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class AHOHCAEKAHP : HEBBOJMKNJO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct BOAMMIALJOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<HEBBOJMKNJO.JDNNJDGPLGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HashSet<JIPAPDGIIFO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AHOHCAEKAHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8484500", Offset = "0x8483700", VA = "0x188484500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8484800", Offset = "0x8483A00", VA = "0x188484800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly FANFNGDGAHN PLKEMCOOOMD;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string IIHGIEJMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x847CCC0", Offset = "0x847BEC0", VA = "0x18847CCC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xA058E0", Offset = "0xA04AE0", VA = "0x180A058E0")]
	public AHOHCAEKAHP(AEHEGPIEOCE IKFFOMHBDLM, FANFNGDGAHN PLKEMCOOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x847CBB0", Offset = "0x847BDB0", VA = "0x18847CBB0", Slot = "5")]
	[AsyncStateMachine(typeof(BOAMMIALJOP))]
	public Task<HEBBOJMKNJO.JDNNJDGPLGK> GNAHLEBBALA(HashSet<JIPAPDGIIFO.Reason> KLDNNOEDOLA, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class NMEBFBHDJLF : FIPAACKCHBI, HEBBOJMKNJO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct HMLOAJJFCMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<HEBBOJMKNJO.JDNNJDGPLGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public NMEBFBHDJLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HashSet<JIPAPDGIIFO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private HPLNAENGEIP <localRoomInstance>5__2;

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
		private TaskAwaiter<HEBBOJMKNJO.JDNNJDGPLGK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x848F940", Offset = "0x848EB40", VA = "0x18848F940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x84902A0", Offset = "0x848F4A0", VA = "0x1884902A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string IIHGIEJMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8499AB0", Offset = "0x8498CB0", VA = "0x188499AB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0xA058E0", Offset = "0xA04AE0", VA = "0x180A058E0")]
	public NMEBFBHDJLF(AEHEGPIEOCE IKFFOMHBDLM, FANFNGDGAHN PLKEMCOOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8499960", Offset = "0x8498B60", VA = "0x188499960", Slot = "5")]
	[AsyncStateMachine(typeof(HMLOAJJFCMH))]
	public Task<HEBBOJMKNJO.JDNNJDGPLGK> GNAHLEBBALA(HashSet<JIPAPDGIIFO.Reason> KLDNNOEDOLA, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class KFDGHFFHOAI : FIPAACKCHBI, HEBBOJMKNJO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct HNBJLJDBNPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<HEBBOJMKNJO.JDNNJDGPLGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public KFDGHFFHOAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public HashSet<JIPAPDGIIFO.Reason> fallbackTriggersToIgnore;

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
		private TaskAwaiter<ANFLHGMKNNH> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<HEBBOJMKNJO.JDNNJDGPLGK> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8490310", Offset = "0x848F510", VA = "0x188490310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8490D00", Offset = "0x848FF00", VA = "0x188490D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string IIHGIEJMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8492760", Offset = "0x8491960", VA = "0x188492760", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0xA058E0", Offset = "0xA04AE0", VA = "0x180A058E0")]
	public KFDGHFFHOAI(AEHEGPIEOCE IKFFOMHBDLM, FANFNGDGAHN PLKEMCOOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8492610", Offset = "0x8491810", VA = "0x188492610", Slot = "5")]
	[AsyncStateMachine(typeof(HNBJLJDBNPB))]
	public Task<HEBBOJMKNJO.JDNNJDGPLGK> GNAHLEBBALA(HashSet<JIPAPDGIIFO.Reason> KLDNNOEDOLA, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class LCGFKCNCJKI : FIPAACKCHBI, HEBBOJMKNJO
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class EDEKHFLOGBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public ANFLHGMKNNH matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EDEKHFLOGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8486430", Offset = "0x8485630", VA = "0x188486430")]
		internal object FIPCKIJLFFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x84864B0", Offset = "0x84856B0", VA = "0x1884864B0")]
		internal object HLEOLEJFJOP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct KHJKNHCKNJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder<HEBBOJMKNJO.JDNNJDGPLGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public LCGFKCNCJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public HashSet<JIPAPDGIIFO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private EDEKHFLOGBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter<ANFLHGMKNNH> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<HEBBOJMKNJO.JDNNJDGPLGK> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8492810", Offset = "0x8491A10", VA = "0x188492810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8493430", Offset = "0x8492630", VA = "0x188493430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string IIHGIEJMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8493740", Offset = "0x8492940", VA = "0x188493740", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0xA058E0", Offset = "0xA04AE0", VA = "0x180A058E0")]
	public LCGFKCNCJKI(AEHEGPIEOCE IKFFOMHBDLM, FANFNGDGAHN PLKEMCOOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x84935F0", Offset = "0x84927F0", VA = "0x1884935F0", Slot = "5")]
	[AsyncStateMachine(typeof(KHJKNHCKNJM))]
	public Task<HEBBOJMKNJO.JDNNJDGPLGK> GNAHLEBBALA(HashSet<JIPAPDGIIFO.Reason> KLDNNOEDOLA, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class FIPAACKCHBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct LLHKCIMGAOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public KEPOMIIOHBM log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public HashSet<JIPAPDGIIFO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public FIPAACKCHBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private List<JIPAPDGIIFO.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8493E10", Offset = "0x8493010", VA = "0x188493E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8494330", Offset = "0x8493530", VA = "0x188494330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	protected readonly AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	protected readonly FANFNGDGAHN PLKEMCOOOMD;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected BPFCLMEBPNG EEJBLGPIIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x84877F0", Offset = "0x84869F0", VA = "0x1884877F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0xA058E0", Offset = "0xA04AE0", VA = "0x180A058E0")]
	public FIPAACKCHBI(AEHEGPIEOCE IKFFOMHBDLM, FANFNGDGAHN PLKEMCOOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8487840", Offset = "0x8486A40", VA = "0x188487840")]
	[AsyncStateMachine(typeof(LLHKCIMGAOJ))]
	protected Task PFENHLOPJLD(KEPOMIIOHBM EBHKLAMEJCE, HashSet<JIPAPDGIIFO.Reason> KLDNNOEDOLA, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class GMGGMBCKHDH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct NFFCAMEJOIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncTaskMethodBuilder<HEBBOJMKNJO.JDNNJDGPLGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public FANFNGDGAHN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8497F40", Offset = "0x8497140", VA = "0x188497F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x84982C0", Offset = "0x84974C0", VA = "0x1884982C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class OOJBDMHJBHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AEHEGPIEOCE roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public OOJBDMHJBHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x849A4A0", Offset = "0x84996A0", VA = "0x18849A4A0")]
		internal object JPPLFPMHPIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly float PIDDFMIKICB;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	internal static readonly HashSet<JIPAPDGIIFO.Reason> HNGMONALMJM;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x848AEC0", Offset = "0x848A0C0", VA = "0x18848AEC0")]
	[AsyncStateMachine(typeof(NFFCAMEJOIG))]
	internal static Task<HEBBOJMKNJO.JDNNJDGPLGK> CCBODMDEPCG(FANFNGDGAHN PLKEMCOOOMD, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x848AD40", Offset = "0x8489F40", VA = "0x18848AD40")]
	internal static void AFABNCOCGEJ(AEHEGPIEOCE IKFFOMHBDLM, KEPOMIIOHBM EBHKLAMEJCE, string PKFBOAFCNGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface HEBBOJMKNJO
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct JDNNJDGPLGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public bool LPBBIEGNCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public JIPAPDGIIFO.Reason GBBFGBIIOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Enum? NBMOGDCJMFC;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8491CB0", Offset = "0x8490EB0", VA = "0x188491CB0")]
		public static JDNNJDGPLGK JPDJJAKCOLP()
		{
			return default(JDNNJDGPLGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8491C80", Offset = "0x8490E80", VA = "0x188491C80")]
		public static JDNNJDGPLGK FGADBOKECBP(JIPAPDGIIFO.Reason GBBFGBIIOBJ, [Optional] Enum? NBMOGDCJMFC)
		{
			return default(JDNNJDGPLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string FGECEAAHDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JDNNJDGPLGK> GNAHLEBBALA(HashSet<JIPAPDGIIFO.Reason> KLDNNOEDOLA, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct GFPDCJAOHJL
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class IJLBPEEGHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public AEHEGPIEOCE manager;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public IJLBPEEGHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x84914D0", Offset = "0x84906D0", VA = "0x1884914D0")]
		internal Task APJBJOBJJHC(CancellationToken cancellationToken, int roomTotalVersion, OHDGGAAKGEM localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct IFJHHGDIDHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public GFPDCJAOHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private CBBEGLFAAKE <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter<FJEIFPOFGFK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter<ONOANLDBBEM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8490ED0", Offset = "0x84900D0", VA = "0x188490ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8491460", Offset = "0x8490660", VA = "0x188491460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct AAHDEOKDANJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public GFPDCJAOHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x847C830", Offset = "0x847BA30", VA = "0x18847C830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x847CB50", Offset = "0x847BD50", VA = "0x18847CB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly CancellationToken FHBCOAHILMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly AEHEGPIEOCE OBHJPIMFHEM;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private AGONIDGIFFK OPHNBOFENLB
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8489D00", Offset = "0x8488F00", VA = "0x188489D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private FANFNGDGAHN ONPPLLOGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8489CB0", Offset = "0x8488EB0", VA = "0x188489CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private BPFCLMEBPNG EEJBLGPIIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x84897E0", Offset = "0x84889E0", VA = "0x1884897E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private CKCEILMKLLA GODOPOAABMM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8489790", Offset = "0x8488990", VA = "0x188489790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x28A3560", Offset = "0x28A2760", VA = "0x1828A3560")]
	public GFPDCJAOHJL(CancellationToken FHBCOAHILMJ, AEHEGPIEOCE OBHJPIMFHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8489610", Offset = "0x8488810", VA = "0x188489610")]
	public static BBJKJLONOHC AHLPFOKBIPC(AEHEGPIEOCE OBHJPIMFHEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8489990", Offset = "0x8488B90", VA = "0x188489990")]
	[AsyncStateMachine(typeof(IFJHHGDIDHB))]
	public Task<bool> JGHBEDNJLDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8489AA0", Offset = "0x8488CA0", VA = "0x188489AA0")]
	private bool KABGDAOEMFN([Out] CBBEGLFAAKE AABAAIKLAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x84896C0", Offset = "0x84888C0", VA = "0x1884896C0")]
	[AsyncStateMachine(typeof(AAHDEOKDANJ))]
	private Task CCAIEDOFMCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8489860", Offset = "0x8488A60", VA = "0x188489860")]
	private Task<FJEIFPOFGFK> JEFJKKPLNPG(CBBEGLFAAKE DIILFPPCBKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct MEMHEIOCIPD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly CGKOCCLEAOB AKBOLNJLJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Guid GHIHMOONOIF;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(ONOANLDBBEM, Task)> IHKALMFJGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8496FA0", Offset = "0x84961A0", VA = "0x188496FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x51D4750", Offset = "0x51D3950", VA = "0x1851D4750")]
	public MEMHEIOCIPD(CGKOCCLEAOB AKBOLNJLJBA, Guid GHIHMOONOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8497070", Offset = "0x8496270", VA = "0x188497070")]
	public TaskAwaiter<(ONOANLDBBEM, Task)> IFHDNGBNMHF()
	{
		return default(TaskAwaiter<(ONOANLDBBEM, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8496ED0", Offset = "0x84960D0", VA = "0x188496ED0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct JJNJDECOOAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly TaskCompletionSource<(ONOANLDBBEM, Task)> JHMBGNBHAIG;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(ONOANLDBBEM, Task)> IHKALMFJGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8492110", Offset = "0x8491310", VA = "0x188492110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x84921E0", Offset = "0x84913E0", VA = "0x1884921E0")]
	public JJNJDECOOAA(TimeSpan DGJDAIGBCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8491F90", Offset = "0x8491190", VA = "0x188491F90")]
	public void CMEPKGCIECD(Task GEOEFKJEPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8492150", Offset = "0x8491350", VA = "0x188492150")]
	public void HLHCBBJGCFM(ONOANLDBBEM JGJIALJFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x84920C0", Offset = "0x84912C0", VA = "0x1884920C0")]
	public void HCIFPHAPLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8492030", Offset = "0x8491230", VA = "0x188492030")]
	internal void ELLMNAGBDBL(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class NJADKEBALMP
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8498930", Offset = "0x8497B30", VA = "0x188498930")]
	public static LBIKBDECECI ELABHEKHAGJ(this LBIKBDECECI EKFBEBELGHJ, EAAMLCEDMMD IMAEGMJEOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8498AD0", Offset = "0x8497CD0", VA = "0x188498AD0")]
	public static LBIKBDECECI KNNKNGOMLNG(this LBIKBDECECI EKFBEBELGHJ, ALGKPHFBIHO GLKGMOLMAGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class DFGDMOELGFD : EAPMNCNAJAH
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GBGDNHCCHIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public ALGKPHFBIHO subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GBGDNHCCHIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x84895E0", Offset = "0x84887E0", VA = "0x1884895E0")]
		internal bool FAOIPPOGCBA(EBAEPIOAJNM s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly KMMADBMONKE AOAFEEHHDIE;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public DFGDMOELGFD(KMMADBMONKE HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8485E10", Offset = "0x8485010", VA = "0x188485E10", Slot = "4")]
	public LBIKBDECECI DBJJOAFKEPP(long GIMOIIPALOE, long JAFHDCNJHEA, string KBKFCDKCGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8485CB0", Offset = "0x8484EB0", VA = "0x188485CB0", Slot = "5")]
	public LBIKBDECECI DBJJOAFKEPP(long GIMOIIPALOE, long JAFHDCNJHEA, JENOKPCEBIE NDINKJMLNJN, Guid? KPDMPLIMJOK, long KFBIFEHDOHB, bool LBGHMCHHKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x84857D0", Offset = "0x84849D0", VA = "0x1884857D0", Slot = "6")]
	public LBIKBDECECI DBJJOAFKEPP(FDACCKBMCMP AHNGJDDEGNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x84859D0", Offset = "0x8484BD0", VA = "0x1884859D0", Slot = "7")]
	public LBIKBDECECI DBJJOAFKEPP(EAAMLCEDMMD GPKMEJKNBFF, ALGKPHFBIHO GDKHIEOEBCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8485EA0", Offset = "0x84850A0", VA = "0x188485EA0")]
	private Guid? IELMBCBOENE(EAAMLCEDMMD NDNPLCMKHEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class FFHLJCBOMFO : NNCKDMIFPLA, KEEEPPHJJDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct MOGBKMJJBBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public FFHLJCBOMFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8497850", Offset = "0x8496A50", VA = "0x188497850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8497EE0", Offset = "0x84970E0", VA = "0x188497EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly JPIJMPDMIDF CIPBGLBCLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private string NFAMPICOBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Task FGADKKKELFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool ELJKMADLDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x84875D0", Offset = "0x84867D0", VA = "0x1884875D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task GAGOFKCHABM
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8487420", Offset = "0x8486620", VA = "0x188487420", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xA00D60", Offset = "0x9FFF60", VA = "0x180A00D60", Slot = "7")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8487600", Offset = "0x8486800", VA = "0x188487600", Slot = "6")]
	public void ILDPHJFGHHP(Task MKOPIIJMBLM, string EDIDKAFMHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x84874B0", Offset = "0x84866B0", VA = "0x1884874B0")]
	[AsyncStateMachine(typeof(MOGBKMJJBBG))]
	private Task DJNNBLPONKG(Task HBHFDBNJENG, string EDIDKAFMHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8487760", Offset = "0x8486960", VA = "0x188487760")]
	public FFHLJCBOMFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class INHLBMFAJLM : MKFMFBPOMOL, KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool IGLGFIJLNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private GDABOMEIBEI FOLMIKLNMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private AGONIDGIFFK NCFBNFPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private KMMADBMONKE HICOIPDJCOI;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public GDABOMEIBEI JNCHMGDNJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8491520", Offset = "0x8490720", VA = "0x188491520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8491590", Offset = "0x8490790", VA = "0x188491590", Slot = "7")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8491810", Offset = "0x8490A10", VA = "0x188491810", Slot = "5")]
	public void MLNFGJIJFLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x84917D0", Offset = "0x84909D0", VA = "0x1884917D0", Slot = "6")]
	public void KKFGCEPKGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8491710", Offset = "0x8490910", VA = "0x188491710")]
	private Task BLDPLNCCGIJ(OLKMJBHOEAD LDINAKFKJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x84917D0", Offset = "0x84909D0", VA = "0x1884917D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public INHLBMFAJLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class HGHKBOAPLMC : KMMADBMONKE
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class IPEJIGGDLMP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly IIOGDLIHHEO GKOIAJLIOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly string MHDODBCCAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly T FEOJADDJKIL;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T LFLEGEJLLKE
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA75190", Offset = "0xA74390", VA = "0x180A75190")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA75210", Offset = "0xA74410", VA = "0x180A75210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4E104C0", Offset = "0x4E0F6C0", VA = "0x184E104C0")]
		public IPEJIGGDLMP(IIOGDLIHHEO GKOIAJLIOIJ, string MHDODBCCAJB, T FEOJADDJKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4E10070", Offset = "0x4E0F270", VA = "0x184E10070")]
		private void BDAMNMHNODM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly IIOGDLIHHEO GKOIAJLIOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly IPEJIGGDLMP<TimeSpan> LNJNNOIAMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly IPEJIGGDLMP<TimeSpan> PFEFNKKOCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly IPEJIGGDLMP<TimeSpan> KFLJCMKCEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly IPEJIGGDLMP<TimeSpan> IJLNGBCJBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly IPEJIGGDLMP<bool> MDBCABKJEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly IPEJIGGDLMP<bool> FPEMJNIFDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly IPEJIGGDLMP<bool> ABMDBHONCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly IPEJIGGDLMP<int> JMEBJMCMKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly IPEJIGGDLMP<bool> JEENJJPHEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly IPEJIGGDLMP<bool> NFNALABNDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly IPEJIGGDLMP<GEIIGPDKAIP> OFPMMLGPCDN;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan BHPONNLHOHN
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x848B8E0", Offset = "0x848AAE0", VA = "0x18848B8E0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan IJAMKOGJEOO
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x848B820", Offset = "0x848AA20", VA = "0x18848B820", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan NALHOAAKAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x848B920", Offset = "0x848AB20", VA = "0x18848B920", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan ILHCEIJHIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x848B760", Offset = "0x848A960", VA = "0x18848B760", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool NBOFFKJKAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x848B8A0", Offset = "0x848AAA0", VA = "0x18848B8A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool NFGDGBCHCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x848B720", Offset = "0x848A920", VA = "0x18848B720", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool PKIHELAKBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x848B7E0", Offset = "0x848A9E0", VA = "0x18848B7E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int EGCMKNJHKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x848B7A0", Offset = "0x848A9A0", VA = "0x18848B7A0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool JNDEEGDEBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x848B960", Offset = "0x848AB60", VA = "0x18848B960", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool KMEFMHEELGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x848B860", Offset = "0x848AA60", VA = "0x18848B860", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JLJODKALAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x848B9A0", Offset = "0x848ABA0", VA = "0x18848B9A0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x848B9F0", Offset = "0x848ABF0", VA = "0x18848B9F0")]
	[UnityEngine.Scripting.Preserve]
	public HGHKBOAPLMC([NGLIAOPBMFM(null)] IIOGDLIHHEO GKOIAJLIOIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class BKIKJCGOMJI : JFLENANMJPK, KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class DLKEBNCBLOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public BAILLPCCAKA roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DLKEBNCBLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8485F50", Offset = "0x8485150", VA = "0x188485F50")]
		internal object DCFNCAEPLGK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event JMMNJNDCHLI HADMCDEGFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x84840E0", Offset = "0x84832E0", VA = "0x1884840E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8484460", Offset = "0x8483660", VA = "0x188484460", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event JMMNJNDCHLI JPCCNOFLJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8484180", Offset = "0x8483380", VA = "0x188484180", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x84842D0", Offset = "0x84834D0", VA = "0x1884842D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event JMMNJNDCHLI NBGBPAABLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8484370", Offset = "0x8483570", VA = "0x188484370", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8483FE0", Offset = "0x84831E0", VA = "0x188483FE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<AIMFMPJJMCG, bool> IDHNEDBEFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8484220", Offset = "0x8483420", VA = "0x188484220", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8483F30", Offset = "0x8483130", VA = "0x188483F30", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "16")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8484080", Offset = "0x8483280", VA = "0x188484080", Slot = "12")]
	public void IKHIDHOKMHN(BAILLPCCAKA KABJBFJMJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x84840B0", Offset = "0x84832B0", VA = "0x1884840B0", Slot = "13")]
	public void IMIKEFIKAEC(BAILLPCCAKA KABJBFJMJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8483D40", Offset = "0x8482F40", VA = "0x188483D40", Slot = "14")]
	public void ALJMPLNKAJD(BAILLPCCAKA KABJBFJMJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8484410", Offset = "0x8483610", VA = "0x188484410", Slot = "15")]
	public void MOOMOLIIFLD(AIMFMPJJMCG JEMHLLLEHAD, bool LPBBIEGNCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8483D70", Offset = "0x8482F70", VA = "0x188483D70")]
	private void CLNGLIDPKMF(JMMNJNDCHLI LNODHBGPGBD, BAILLPCCAKA KABJBFJMJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public BKIKJCGOMJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[UnityEngine.Scripting.Preserve]
internal class EFCABHFELDH : FEFPCGFOOFE, KEEEPPHJJDK, IDisposable, JIPAPDGIIFO
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class FMNIHHAFHHN : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct MINMEOLAMCD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public FMNIHHAFHHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public JIPAPDGIIFO.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private BKCBFFDELCF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private HEBBOJMKNJO[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private TaskAwaiter<HEBBOJMKNJO.JDNNJDGPLGK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x84970C0", Offset = "0x84962C0", VA = "0x1884970C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x84977F0", Offset = "0x84969F0", VA = "0x1884977F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct NJEAKGLJKNB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public AsyncTaskMethodBuilder<HEBBOJMKNJO.JDNNJDGPLGK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public HEBBOJMKNJO fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public FMNIHHAFHHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JIPAPDGIIFO.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private BKCBFFDELCF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private HENGPFJHNFL <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private TaskAwaiter<HEBBOJMKNJO.JDNNJDGPLGK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x8498C60", Offset = "0x8497E60", VA = "0x188498C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x84998F0", Offset = "0x8498AF0", VA = "0x1884998F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class AKEBKFHPAIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public HEBBOJMKNJO fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public AKEBKFHPAIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x847CD70", Offset = "0x847BF70", VA = "0x18847CD70")]
			internal object IGAJHLOFJAC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public Task MKOPIIJMBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationTokenSource JBKLDOEMDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public HENGPFJHNFL NPMNKKLMFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public FANFNGDGAHN PLKEMCOOOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JDHAANHFGMM PHIHHHNMFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public HPLNAENGEIP EJHGGALBJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public HEBBOJMKNJO[] ICPDOJGHHJJ;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool NIFOKHJINBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8488780", Offset = "0x8487980", VA = "0x188488780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool HKOJNKAONAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x84883A0", Offset = "0x84875A0", VA = "0x1884883A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x84894C0", Offset = "0x84886C0", VA = "0x1884894C0")]
		public FMNIHHAFHHN(FANFNGDGAHN PLKEMCOOOMD, JDHAANHFGMM PHIHHHNMFCO, HPLNAENGEIP EJHGGALBJHE, HEBBOJMKNJO[] ICPDOJGHHJJ, CancellationToken FHBCOAHILMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8487E50", Offset = "0x8487050", VA = "0x188487E50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8488500", Offset = "0x8487700", VA = "0x188488500")]
		public void HHLFFIADOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8488620", Offset = "0x8487820", VA = "0x188488620")]
		public void KHJKLPHIDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x84880F0", Offset = "0x84872F0", VA = "0x1884880F0")]
		public void FOPNLDFEJAA(JIPAPDGIIFO.Reason DGCPAIEHGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x84888B0", Offset = "0x8487AB0", VA = "0x1884888B0")]
		[AsyncStateMachine(typeof(MINMEOLAMCD))]
		public Task MLPGDLMNIDF(JIPAPDGIIFO.Reason GBBFGBIIOBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x84883C0", Offset = "0x84875C0", VA = "0x1884883C0")]
		[AsyncStateMachine(typeof(NJEAKGLJKNB))]
		private Task<HEBBOJMKNJO.JDNNJDGPLGK> HGPMEOGAEGM(JIPAPDGIIFO.Reason GBBFGBIIOBJ, HEBBOJMKNJO CCIJLANCKFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8487D30", Offset = "0x8486F30", VA = "0x188487D30")]
		private void CPKPLENIMFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8488570", Offset = "0x8487770", VA = "0x188488570")]
		public bool JMMKMAOGBPH(JIPAPDGIIFO.Reason NKGIDECGEIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x84889B0", Offset = "0x8487BB0", VA = "0x1884889B0")]
		private void ODGIADIHMCM(HENGPFJHNFL CKCKEFFHJAP, JIPAPDGIIFO.Reason GBBFGBIIOBJ = JIPAPDGIIFO.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8488F60", Offset = "0x8488160", VA = "0x188488F60")]
		private void PJACDHBKOHJ(HENGPFJHNFL CKCKEFFHJAP, HEBBOJMKNJO.JDNNJDGPLGK ACALKMLJJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8488DC0", Offset = "0x8487FC0", VA = "0x188488DC0")]
		private void PEFCMKBJDFJ(HENGPFJHNFL CKCKEFFHJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8487970", Offset = "0x8486B70", VA = "0x188487970")]
		private void CHKLHNBMKNF(HENGPFJHNFL CKCKEFFHJAP, HEBBOJMKNJO.JDNNJDGPLGK ACALKMLJJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8488C60", Offset = "0x8487E60", VA = "0x188488C60")]
		private void OMPKBANEMLJ(HENGPFJHNFL CKCKEFFHJAP, Exception JNDFFCAMALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8487FE0", Offset = "0x84871E0", VA = "0x188487FE0")]
		private void FNGLNCMKOHP(HEBBOJMKNJO CCIJLANCKFI, JIPAPDGIIFO.Reason GBBFGBIIOBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x84887A0", Offset = "0x84879A0", VA = "0x1884887A0")]
		private void MINBNOGFNBE(HEBBOJMKNJO CCIJLANCKFI, JIPAPDGIIFO.Reason GBBFGBIIOBJ, string NBMOGDCJMFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8489130", Offset = "0x8488330", VA = "0x188489130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class HENGPFJHNFL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public Task<HEBBOJMKNJO.JDNNJDGPLGK> MKOPIIJMBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public CancellationTokenSource JBKLDOEMDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public HEBBOJMKNJO CCIJLANCKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public JIPAPDGIIFO.Reason DGCPAIEHGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public HashSet<JIPAPDGIIFO.Reason> KLDNNOEDOLA;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool NIFOKHJINBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x8488780", Offset = "0x8487980", VA = "0x188488780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool HKOJNKAONAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x84883A0", Offset = "0x84875A0", VA = "0x1884883A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x848B0F0", Offset = "0x848A2F0", VA = "0x18848B0F0")]
		public void BHDHLEMKOHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x848B250", Offset = "0x848A450", VA = "0x18848B250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x848B270", Offset = "0x848A470", VA = "0x18848B270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x848B5E0", Offset = "0x848A7E0", VA = "0x18848B5E0")]
		public HENGPFJHNFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class KIBNKEPLODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public JIPAPDGIIFO.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KIBNKEPLODG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8493510", Offset = "0x8492710", VA = "0x188493510")]
		internal object ENOJHKJAMHI(HENGPFJHNFL x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x84934A0", Offset = "0x84926A0", VA = "0x1884934A0")]
		internal object COPILGBIMMD(FMNIHHAFHHN x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8493580", Offset = "0x8492780", VA = "0x188493580")]
		internal object FAHEKNIJCOB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct GJHJGLJNCNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public JIPAPDGIIFO.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public EFCABHFELDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private KIBNKEPLODG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8489D50", Offset = "0x8488F50", VA = "0x188489D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x848A7B0", Offset = "0x84899B0", VA = "0x18848A7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct LLLGKMOKHHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public EFCABHFELDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public JIPAPDGIIFO.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private FMNIHHAFHHN <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8494390", Offset = "0x8493590", VA = "0x188494390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8495000", Offset = "0x8494200", VA = "0x188495000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct OKPCLBGPBLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public EFCABHFELDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8499ED0", Offset = "0x84990D0", VA = "0x188499ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x849A440", Offset = "0x8499640", VA = "0x18849A440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	internal static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	internal static readonly KEPOMIIOHBM ODGMIMMBGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private FANFNGDGAHN PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private FMNIHHAFHHN PPHODLPFDDK;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private BPFCLMEBPNG EEJBLGPIIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8486F60", Offset = "0x8486160", VA = "0x188486F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool HEFILFJACDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x24DD4C0", Offset = "0x24DC6C0", VA = "0x1824DD4C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool PEAAFIHHIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8486C20", Offset = "0x8485E20", VA = "0x188486C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8486570", Offset = "0x8485770", VA = "0x188486570", Slot = "6")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8486B40", Offset = "0x8485D40", VA = "0x188486B40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x84865F0", Offset = "0x84857F0", VA = "0x1884865F0", Slot = "9")]
	public void BHDHLEMKOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8486FB0", Offset = "0x84861B0", VA = "0x188486FB0")]
	private bool ICMNIGMPAIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8486B50", Offset = "0x8485D50", VA = "0x188486B50", Slot = "5")]
	private void ENELFIKLHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x8487090", Offset = "0x8486290", VA = "0x188487090", Slot = "8")]
	[AsyncStateMachine(typeof(GJHJGLJNCNI))]
	public Task KLEBLGPKKCG(JIPAPDGIIFO.Reason GBBFGBIIOBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8486C90", Offset = "0x8485E90", VA = "0x188486C90")]
	private bool GNHLHLJLCKN(JIPAPDGIIFO.Reason GBBFGBIIOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8486770", Offset = "0x8485970", VA = "0x188486770")]
	private HEBBOJMKNJO[] DONMNJAHFDM(HPLNAENGEIP CKMCMPCCGFB, JDHAANHFGMM NMADENOEAOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8487250", Offset = "0x8486450", VA = "0x188487250")]
	[AsyncStateMachine(typeof(LLLGKMOKHHP))]
	private Task NPMJENPINHJ(JIPAPDGIIFO.Reason GBBFGBIIOBJ, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8487180", Offset = "0x8486380", VA = "0x188487180")]
	[AsyncStateMachine(typeof(OKPCLBGPBLK))]
	private Task LFNOIONGAOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public EFCABHFELDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class HMHICDDHGAB : CCIPIEMODMF, KEEEPPHJJDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct BFGBNIFHPHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public HMHICDDHGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public FPDNILICPEG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8482930", Offset = "0x8481B30", VA = "0x188482930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8483290", Offset = "0x8482490", VA = "0x188483290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct PBHOMGGHEDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public HMHICDDHGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public FPDNILICPEG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private BGHCJGPGCNF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private BKCBFFDELCF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private CGBDEFKMHHI <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private IDCFDGBFOML <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x849A820", Offset = "0x8499A20", VA = "0x18849A820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x849B970", Offset = "0x849AB70", VA = "0x18849B970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class HGGLJIELAIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public Matchmaking.HNGNBBDCAPL result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public MJDHEAFMIOG errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HGGLJIELAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x848B670", Offset = "0x848A870", VA = "0x18848B670")]
		internal object GDEGHLDHKPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class PFFCLHKGJAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Task<LBIKBDECECI> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public PFFCLHKGJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		internal Task<LBIKBDECECI> OHCJECHEJIG(BGHCJGPGCNF<string>.IPAINGKGFDM _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct BAKOGMAGHJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public HMHICDDHGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public FPDNILICPEG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public CGBDEFKMHHI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private PFFCLHKGJAL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private DHHHLMIJLMK <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private BKCBFFDELCF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private OHEDPJJAEEG <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private Task<Matchmaking.FIOJJCCKODK> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private KLFHNLFCFDM <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.FIOJJCCKODK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<LBIKBDECECI> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x847CE60", Offset = "0x847C060", VA = "0x18847CE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x84827E0", Offset = "0x84819E0", VA = "0x1884827E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class FBBHJJJELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task<LBIKBDECECI> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public FBBHJJJELNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		internal Task<LBIKBDECECI> LDGLFMJFBEN(BGHCJGPGCNF<string>.IPAINGKGFDM _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct PMIKBILCLNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public HMHICDDHGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public FPDNILICPEG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public CGBDEFKMHHI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private DHHHLMIJLMK <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private BKCBFFDELCF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private OHEDPJJAEEG <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private Task<Matchmaking.FIOJJCCKODK> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private LBIKBDECECI <initialRoomLoadPayload>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private EIAPKNHOKAL <preloadContext>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<LBIKBDECECI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private KLFHNLFCFDM <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Task <loadEmptySceneTask>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private AHEOMIBFHKH <sceneManagementService>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private PMNACDPOEAJ <scenePreloadRequest>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private CancellationTokenSource <cameraFadeCts>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private TaskAwaiter<CAGKJJGCDMM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private int <i>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private YieldAwaitable.YieldAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private TaskAwaiter<Matchmaking.FIOJJCCKODK> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private CancellationToken <photonJoinedToken>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x84B6890", Offset = "0x84B5A90", VA = "0x1884B6890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x84BBF20", Offset = "0x84BB120", VA = "0x1884BBF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct JHMCGBJKANF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public HMHICDDHGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <disconnectTimerScope>5__3;

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
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x84AFA00", Offset = "0x84AEC00", VA = "0x1884AFA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x84B0460", Offset = "0x84AF660", VA = "0x1884B0460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct IEADIJFKAFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public HMHICDDHGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private FJCFOKJAKFO <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x84AD870", Offset = "0x84ACA70", VA = "0x1884AD870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x84ADD00", Offset = "0x84ACF00", VA = "0x1884ADD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct PKCBOBCHKLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder<Matchmaking.FIOJJCCKODK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public HMHICDDHGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private TaskAwaiter<Matchmaking.FIOJJCCKODK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x84B5A00", Offset = "0x84B4C00", VA = "0x1884B5A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x84B5EE0", Offset = "0x84B50E0", VA = "0x1884B5EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct ANIFIJDLPEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public Matchmaking.FIOJJCCKODK serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public HMHICDDHGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public CGBDEFKMHHI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<JPCFAJMDPLN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x849D7C0", Offset = "0x849C9C0", VA = "0x18849D7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x849DE00", Offset = "0x849D000", VA = "0x18849DE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class EEDFJGDMDHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public HPLNAENGEIP targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EEDFJGDMDHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x84A3C20", Offset = "0x84A2E20", VA = "0x1884A3C20")]
		internal object PFCFBLCNGHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x84A3B20", Offset = "0x84A2D20", VA = "0x1884A3B20")]
		internal string MLBIFGNKJGO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct CKCDKOMAEGO : IAsyncStateMachine
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
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public HMHICDDHGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private EEDFJGDMDHJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private BKCBFFDELCF <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x84A0060", Offset = "0x849F260", VA = "0x1884A0060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x84A0BF0", Offset = "0x849FDF0", VA = "0x1884A0BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct PGJFMKMDCDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public HMHICDDHGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CGBDEFKMHHI joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public LBIKBDECECI initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public HPLNAENGEIP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public EIAPKNHOKAL preloadContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public DHHHLMIJLMK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x84B4FA0", Offset = "0x84B41A0", VA = "0x1884B4FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x84B5790", Offset = "0x84B4990", VA = "0x1884B5790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct BEIMOBHNNPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public HMHICDDHGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private BKCBFFDELCF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap3;

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
		private BKCBFFDELCF <>7__wrap5;

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
		[Cpp2IlInjected.Address(RVA = "0x849E060", Offset = "0x849D260", VA = "0x18849E060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x849F840", Offset = "0x849EA40", VA = "0x18849F840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct GEPOFIEJLHF : IAsyncStateMachine
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
		public OHDGGAAKGEM localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public HMHICDDHGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private TaskAwaiter<ONOANLDBBEM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x84A7020", Offset = "0x84A6220", VA = "0x1884A7020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x84A7820", Offset = "0x84A6A20", VA = "0x1884A7820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class PHEJALEBJOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public PHEJALEBJOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x84B5830", Offset = "0x84B4A30", VA = "0x1884B5830")]
		internal object AOAJFDPAMPE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class GBKNOCIBLMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GBKNOCIBLMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x84A6F80", Offset = "0x84A6180", VA = "0x1884A6F80")]
		internal void GJLIGBIEMMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class DBMIOEGNMAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DBMIOEGNMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x84A1600", Offset = "0x84A0800", VA = "0x1884A1600")]
		internal object LBCHFDDKEIL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class PGEEOGAIGAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public PGEEOGAIGAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x84B4EA0", Offset = "0x84B40A0", VA = "0x1884B4EA0")]
		internal string NCGKHOHCFCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly KEPOMIIOHBM ICGOIOIHMFG;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly KEPOMIIOHBM AIBLLIFIILA;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static readonly KEPOMIIOHBM PODAAMBOODJ;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly string PPEAEIMBOLI;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly string BBJIFGNFBMK;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly string JGHJOMGEEJN;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly Guid MHODHHMEFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private GFDGEADJOLK DJAEFDPEFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private JLEGCCMAOMJ MBKOOBJMOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private AGONIDGIFFK NCFBNFPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private FANFNGDGAHN PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private FEFPCGFOOFE LKGLKJGGLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NNCKDMIFPLA AIDICANLPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private JFLENANMJPK FANIAMKJHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private GMOGLPEOKFM PGFHJGFEGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private OKEDMDENPIA GNHCKBFGMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private IDisposable AANCPLALJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private KPIOGOKHAGB MKJPNEFAJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly JPIJMPDMIDF HMBGFKIBMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private KLFHNLFCFDM LKDDDKGHBJG;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus BLKMLPHLOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA29010", Offset = "0xA28210", VA = "0x180A29010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x13F1F80", Offset = "0x13F1180", VA = "0x1813F1F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private BPFCLMEBPNG EEJBLGPIIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x848DAF0", Offset = "0x848CCF0", VA = "0x18848DAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x848C130", Offset = "0x848B330", VA = "0x18848C130", Slot = "6")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x848CE40", Offset = "0x848C040", VA = "0x18848CE40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x848D460", Offset = "0x848C660", VA = "0x18848D460", Slot = "5")]
	[AsyncStateMachine(typeof(BFGBNIFHPHL))]
	public Task GAOOAKDEECF(HPLNAENGEIP CKKPLENLEPO, FPDNILICPEG HODBGMFAIPK, CancellationToken CDMFGCJPANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x848DD60", Offset = "0x848CF60", VA = "0x18848DD60")]
	[AsyncStateMachine(typeof(PBHOMGGHEDG))]
	private Task INBAEHMGJGF(HPLNAENGEIP CKKPLENLEPO, FPDNILICPEG HODBGMFAIPK, CancellationToken CDMFGCJPANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x848CFF0", Offset = "0x848C1F0", VA = "0x18848CFF0")]
	private void FMHKFALOHAD(GMOGLPEOKFM PGFHJGFEGPD, HPLNAENGEIP CKKPLENLEPO, Exception JNDFFCAMALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x848DEB0", Offset = "0x848D0B0", VA = "0x18848DEB0")]
	private static void KDCIMCAEAJJ(IDCFDGBFOML LAHFMMONLMA, Exception JNDFFCAMALC, [Optional] List<int> HKDOFEHENCE, int MBPKHDIIMIJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x848EE70", Offset = "0x848E070", VA = "0x18848EE70")]
	[AsyncStateMachine(typeof(BAKOGMAGHJN))]
	private Task NOKFMGMEAFE(BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, HPLNAENGEIP CKKPLENLEPO, FPDNILICPEG HODBGMFAIPK, CGBDEFKMHHI NKKBEHAGJPH, CancellationToken CDMFGCJPANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x848EC90", Offset = "0x848DE90", VA = "0x18848EC90")]
	[AsyncStateMachine(typeof(PMIKBILCLNO))]
	private Task NENPFNDLENM(BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, HPLNAENGEIP CKKPLENLEPO, FPDNILICPEG HODBGMFAIPK, CGBDEFKMHHI NKKBEHAGJPH, CancellationToken CDMFGCJPANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x848F370", Offset = "0x848E570", VA = "0x18848F370")]
	private void ODAFOAMAKBC([CallerMemberName] string INPMAHMFGCG = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x848C000", Offset = "0x848B200", VA = "0x18848C000")]
	[AsyncStateMachine(typeof(JHMCGBJKANF))]
	private Task AEGDBJFAPJK(BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x848E960", Offset = "0x848DB60", VA = "0x18848E960")]
	private void LNHOEOAPHNH(HPLNAENGEIP CKKPLENLEPO, CancellationToken CDMFGCJPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x848F110", Offset = "0x848E310", VA = "0x18848F110")]
	private void OBODFAAHODK(HPLNAENGEIP CKKPLENLEPO, TaskStatus CFPLGINEKHK, string NPEJLHCJPAI, CGBDEFKMHHI NKKBEHAGJPH, Exception JLAMGOGLIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x848EDF0", Offset = "0x848DFF0", VA = "0x18848EDF0")]
	private void NMCGHKCJBBI(HPLNAENGEIP CKKPLENLEPO, CGBDEFKMHHI NKKBEHAGJPH, OperationCanceledException IPIHDDJJMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x848E880", Offset = "0x848DA80", VA = "0x18848E880")]
	private void LIBJNDJKJHN(HPLNAENGEIP CKKPLENLEPO, CGBDEFKMHHI NKKBEHAGJPH, Exception JNDFFCAMALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x848D8E0", Offset = "0x848CAE0", VA = "0x18848D8E0")]
	private void HIAJMCPEJJC(HPLNAENGEIP CKKPLENLEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x848CA00", Offset = "0x848BC00", VA = "0x18848CA00")]
	private static BAILLPCCAKA CBBHIPJKODF(HPLNAENGEIP CKKPLENLEPO)
	{
		return default(BAILLPCCAKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x848CD70", Offset = "0x848BF70", VA = "0x18848CD70")]
	[AsyncStateMachine(typeof(IEADIJFKAFN))]
	private Task DNNKHPKCEHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x848CE90", Offset = "0x848C090", VA = "0x18848CE90")]
	[AsyncStateMachine(typeof(PKCBOBCHKLK))]
	private Task<Matchmaking.FIOJJCCKODK> FBLEBGMCEDB(HPLNAENGEIP CKKPLENLEPO, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x848DC50", Offset = "0x848CE50", VA = "0x18848DC50")]
	private static JPCFAJMDPLN IBCGHDGBMGM(Matchmaking.FIOJJCCKODK HECNGIHABCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x848D5A0", Offset = "0x848C7A0", VA = "0x18848D5A0")]
	[AsyncStateMachine(typeof(ANIFIJDLPEI))]
	private Task GEHPEMHHBLM(Matchmaking.FIOJJCCKODK HECNGIHABCB, CGBDEFKMHHI NKKBEHAGJPH, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken AFHBHDLKFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x848EFD0", Offset = "0x848E1D0", VA = "0x18848EFD0")]
	[AsyncStateMachine(typeof(CKCDKOMAEGO))]
	private Task OBJKNFIIEFJ(HPLNAENGEIP CKKPLENLEPO, CancellationTokenSource NOJMIKKLKPD, Task JDCNMDHLGJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x848C880", Offset = "0x848BA80", VA = "0x18848C880")]
	[AsyncStateMachine(typeof(PGJFMKMDCDF))]
	private Task BOFMPNGJMCB(LBIKBDECECI NGOELKBHDAI, DHHHLMIJLMK HPONBKACHOH, HPLNAENGEIP PNPJKKGMLHA, CGBDEFKMHHI KAIDIMNMBKN, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FPCHANCOHED, [Optional] EIAPKNHOKAL PPEEEDLLJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x848CB80", Offset = "0x848BD80", VA = "0x18848CB80")]
	private CGBDEFKMHHI CPIOOBGJLAO(CGBDEFKMHHI KAIDIMNMBKN, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x848BEC0", Offset = "0x848B0C0", VA = "0x18848BEC0")]
	[AsyncStateMachine(typeof(BEIMOBHNNPH))]
	private Task ADIBAFGPFOL(BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x848F4F0", Offset = "0x848E6F0", VA = "0x18848F4F0")]
	[AsyncStateMachine(typeof(GEPOFIEJLHF))]
	private Task PBPMLGAIOHM(CancellationToken FHBCOAHILMJ, int CBCJLPKKBGM, OHDGGAAKGEM PFPIBCCLABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x848C700", Offset = "0x848B900", VA = "0x18848C700")]
	private static void BHMOMEFMGDK(HPLNAENGEIP CKKPLENLEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x848C460", Offset = "0x848B660", VA = "0x18848C460")]
	private void AGBGOJPLKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x848CAF0", Offset = "0x848BCF0", VA = "0x18848CAF0")]
	private void CKBCJMFGHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x848F620", Offset = "0x848E820", VA = "0x18848F620")]
	private void PPNMEDMNHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x848CA60", Offset = "0x848BC60", VA = "0x18848CA60")]
	private void CGACIFPLBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x848D7F0", Offset = "0x848C9F0", VA = "0x18848D7F0")]
	private static void GODEPLIDFDP(HPLNAENGEIP CKKPLENLEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x848DB40", Offset = "0x848CD40", VA = "0x18848DB40")]
	private static CancellationTokenRegistration IAPEIBBKGKF(HPLNAENGEIP CKKPLENLEPO, CancellationToken AFHBHDLKFFC)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x848D6F0", Offset = "0x848C8F0", VA = "0x18848D6F0")]
	private static void GHLLHGLHFPC(HPLNAENGEIP CKKPLENLEPO, Exception JNDFFCAMALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x848E6D0", Offset = "0x848D8D0", VA = "0x18848E6D0")]
	private void KDHIGFBFGFP(HPLNAENGEIP CKKPLENLEPO, Task JDCNMDHLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x848C6A0", Offset = "0x848B8A0", VA = "0x18848C6A0")]
	private static void AODHEIHGBPN(Func<string> PFLKBJPGFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x848F8B0", Offset = "0x848EAB0", VA = "0x18848F8B0")]
	public HMHICDDHGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x848E900", Offset = "0x848DB00", VA = "0x18848E900")]
	[CompilerGenerated]
	internal static (int, int?) LMDIJJIAIIM(MJDHEAFMIOG LKKKAKAHAFI)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[RecRoom.NoEngine.Common.Preserve]
internal class GLJLBFLANLC : FAGAHDOLLOE, KEEEPPHJJDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct KOGAAPNKJOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public GLJLBFLANLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public OHDGGAAKGEM localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x84B1460", Offset = "0x84B0660", VA = "0x1884B1460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x84B1940", Offset = "0x84B0B40", VA = "0x1884B1940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class GJENFMBFLPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public GLJLBFLANLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public OHDGGAAKGEM localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GJENFMBFLPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x84A8CD0", Offset = "0x84A7ED0", VA = "0x1884A8CD0")]
		internal List<Task> CDFALJKNKAM(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct CPGFBBHFNMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public BBJKJLONOHC taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public OHDGGAAKGEM localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x84A0F50", Offset = "0x84A0150", VA = "0x1884A0F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x84A12F0", Offset = "0x84A04F0", VA = "0x1884A12F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct DPPELGMHKKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public GLJLBFLANLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x84A3710", Offset = "0x84A2910", VA = "0x1884A3710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x84A39F0", Offset = "0x84A2BF0", VA = "0x1884A39F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private readonly HashSet<BBJKJLONOHC> DFDAFKDMGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private JLEGCCMAOMJ MBKOOBJMOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private CBFAMDHOPFE ENMCEBBOHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private PMMMNAGJELM BLDOHLPOPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private IDisposable AANCPLALJMJ;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x84A8D10", Offset = "0x84A7F10", VA = "0x1884A8D10", Slot = "5")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x84A9380", Offset = "0x84A8580", VA = "0x1884A9380", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x84A9BC0", Offset = "0x84A8DC0", VA = "0x1884A9BC0", Slot = "4")]
	public bool MBOMIDCFLED(BBJKJLONOHC KLOAFLDIHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x84A99D0", Offset = "0x84A8BD0", VA = "0x1884A99D0")]
	private void KNNMGAKKOKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x84A9160", Offset = "0x84A8360", VA = "0x1884A9160")]
	private void DLDCGLLCBHB(IMGOPGMMMDH JCFOMPGDMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x84A9070", Offset = "0x84A8270", VA = "0x1884A9070")]
	[AsyncStateMachine(typeof(KOGAAPNKJOA))]
	private Task DCAAAPBAFOK(int CBCJLPKKBGM, OHDGGAAKGEM PFPIBCCLABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x84A93E0", Offset = "0x84A85E0", VA = "0x1884A93E0")]
	private Func<CancellationToken, List<Task>> GHGPHJCLHGE(int CBCJLPKKBGM, OHDGGAAKGEM PFPIBCCLABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x84A94B0", Offset = "0x84A86B0", VA = "0x1884A94B0")]
	private List<Task> GKGAGBKBDOH(int CBCJLPKKBGM, OHDGGAAKGEM PFPIBCCLABA, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x84A9AA0", Offset = "0x84A8CA0", VA = "0x1884A9AA0")]
	[AsyncStateMachine(typeof(CPGFBBHFNMM))]
	private Task LJCOLFOBEHP(BBJKJLONOHC GENBMGLCFEE, CancellationToken CCLFNPCGNED, int CBCJLPKKBGM, OHDGGAAKGEM PFPIBCCLABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x84A9C20", Offset = "0x84A8E20", VA = "0x1884A9C20")]
	[AsyncStateMachine(typeof(DPPELGMHKKH))]
	private Task PLKMDGKCMID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x84A8FF0", Offset = "0x84A81F0", VA = "0x1884A8FF0")]
	private void BHDHLEMKOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x84A9CF0", Offset = "0x84A8EF0", VA = "0x1884A9CF0")]
	public GLJLBFLANLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[UnityEngine.Scripting.Preserve]
internal sealed class EKBCOGCCOCL : CGKOCCLEAOB, KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class EJFDGPAOIHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EJFDGPAOIHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x84A3D20", Offset = "0x84A2F20", VA = "0x1884A3D20")]
		internal object FAPJIFLHDDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class HIMDKJNGJHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HIMDKJNGJHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x84AD810", Offset = "0x84ACA10", VA = "0x1884AD810")]
		internal object DBGEJKAIDLH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class HDEDGKLDOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HDEDGKLDOMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class OIPADLBIIMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public OIPADLBIIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x84B46D0", Offset = "0x84B38D0", VA = "0x1884B46D0")]
		internal object KJKFFFLHCGD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class ANMJDGJGFIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ANMJDGJGFIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x849DE60", Offset = "0x849D060", VA = "0x18849DE60")]
		internal object EGDEHMDLOFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private readonly Dictionary<Guid, JJNJDECOOAA> AKBOLNJLJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly TimeSpan LMCBHBPPMAD;

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "9")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x84A3D80", Offset = "0x84A2F80", VA = "0x1884A3D80", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x84A4310", Offset = "0x84A3510", VA = "0x1884A4310", Slot = "4")]
	public MEMHEIOCIPD LHOMNBOIMGH(Guid GHIHMOONOIF)
	{
		return default(MEMHEIOCIPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x84A4760", Offset = "0x84A3960", VA = "0x1884A4760", Slot = "5")]
	public bool PKCJOLGDFLO(Guid GHIHMOONOIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x84A3F70", Offset = "0x84A3170", VA = "0x1884A3F70", Slot = "6")]
	public bool JGBCKMGEBAC(Guid GHIHMOONOIF, Task GEOEFKJEPHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x84A3D90", Offset = "0x84A2F90", VA = "0x1884A3D90", Slot = "7")]
	public bool HDGJKGBOFFH(Guid GHIHMOONOIF, ONOANLDBBEM JGJIALJFAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x84A42A0", Offset = "0x84A34A0", VA = "0x1884A42A0", Slot = "8")]
	public Task<(ONOANLDBBEM, Task)> KEMJNOHEJEL(Guid GHIHMOONOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x84A4530", Offset = "0x84A3730", VA = "0x1884A4530")]
	private void PFFBJPPHOIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x84A4970", Offset = "0x84A3B70", VA = "0x1884A4970")]
	public EKBCOGCCOCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[RecRoom.NoEngine.Common.Preserve]
internal class GHDPIHDLMMC : CCDDHJNDGNF, KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class KHCELONLGGD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private readonly HPLNAENGEIP ODCMJFJDLEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private readonly CancellationTokenSource IHOFGGILNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public readonly CancellationToken KIHNHODFIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private bool KGPILPCHKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private bool OLFOBLPNEEI;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x84B11E0", Offset = "0x84B03E0", VA = "0x1884B11E0")]
		public KHCELONLGGD(HPLNAENGEIP ODCMJFJDLEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x84B1060", Offset = "0x84B0260", VA = "0x1884B1060")]
		public void BHDHLEMKOHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x84B11B0", Offset = "0x84B03B0", VA = "0x1884B11B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class DINBJMEKOPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public OLKMJBHOEAD disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DINBJMEKOPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x84A1FB0", Offset = "0x84A11B0", VA = "0x1884A1FB0")]
		internal object BAEFIEMBBFK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private struct NMBNBDMNEIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public OLKMJBHOEAD disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public GHDPIHDLMMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x84B3510", Offset = "0x84B2710", VA = "0x1884B3510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x84B3960", Offset = "0x84B2B60", VA = "0x1884B3960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class EAAEJFPMGFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public GHDPIHDLMMC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EAAEJFPMGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x84A3A50", Offset = "0x84A2C50", VA = "0x1884A3A50")]
		internal object DBOCNGMHMKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class BMJJLGCNDNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public HPLNAENGEIP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public EAAEJFPMGFI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BMJJLGCNDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x849FFA0", Offset = "0x849F1A0", VA = "0x18849FFA0")]
		internal object NGBPLCOBBJO((HPLNAENGEIP lastLocalPlayerRoomInstance, HPLNAENGEIP newRoomInstance, FEFPCGFOOFE fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct ENIIDELPKJH : IAsyncStateMachine
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
		public GHDPIHDLMMC <>4__this;

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
		private BKCBFFDELCF <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x84A5670", Offset = "0x84A4870", VA = "0x1884A5670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA508E0", Offset = "0xA4FAE0", VA = "0x180A508E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class AOOFAPBOAGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public HPLNAENGEIP newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AOOFAPBOAGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x849DF40", Offset = "0x849D140", VA = "0x18849DF40")]
		internal object ILDFADGGKIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x849DFE0", Offset = "0x849D1E0", VA = "0x18849DFE0")]
		internal void NDIOPEMMGFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x849DF00", Offset = "0x849D100", VA = "0x18849DF00")]
		internal object EHKOGEJDOCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x849DEC0", Offset = "0x849D0C0", VA = "0x18849DEC0")]
		internal object BPGOEANFBLO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct IKGIMPBEHKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public HPLNAENGEIP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public GHDPIHDLMMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public FPDNILICPEG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private AOOFAPBOAGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private BKCBFFDELCF <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x84AE9E0", Offset = "0x84ADBE0", VA = "0x1884AE9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x84AF9A0", Offset = "0x84AEBA0", VA = "0x1884AF9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly OHEIKGPEIIG.GPDJOCKECFJ PONFJMPLCNE;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly MIMEKMMJGDE CJIIDMHJHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private JLEGCCMAOMJ MBKOOBJMOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private FEFPCGFOOFE LKGLKJGGLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private FANFNGDGAHN PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private KMMADBMONKE HICOIPDJCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private CCIPIEMODMF IKJEPHDAABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private HPLNAENGEIP KGBNMHHBEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private KHCELONLGGD MIKEOEFDNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool LGFFMGLGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private Task KAEFBKBOLME;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private BPFCLMEBPNG EEJBLGPIIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x84A80C0", Offset = "0x84A72C0", VA = "0x1884A80C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool DFAOPMBLPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xCCB610", Offset = "0xCCA810", VA = "0x180CCB610")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x84A86C0", Offset = "0x84A78C0", VA = "0x1884A86C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x84A7880", Offset = "0x84A6A80", VA = "0x1884A7880", Slot = "4")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x84A7DC0", Offset = "0x84A6FC0", VA = "0x1884A7DC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x84A8110", Offset = "0x84A7310", VA = "0x1884A8110")]
	[AsyncStateMachine(typeof(NMBNBDMNEIP))]
	private Task IGMMFIJKGAP(OLKMJBHOEAD BFOHBLPNPNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x84A86D0", Offset = "0x84A78D0", VA = "0x1884A86D0")]
	private void KDIMKKCGFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x84A7F30", Offset = "0x84A7130", VA = "0x1884A7F30")]
	private void FCLFNBFOJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x84A7BF0", Offset = "0x84A6DF0", VA = "0x1884A7BF0")]
	private void BOKAAGOCDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x84A8860", Offset = "0x84A7A60", VA = "0x1884A8860")]
	private bool KNFBCMFCPNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x84A7B20", Offset = "0x84A6D20", VA = "0x1884A7B20")]
	[AsyncStateMachine(typeof(ENIIDELPKJH))]
	private void BADKJKBJFJL(int LPGODJOFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x84A8430", Offset = "0x84A7630", VA = "0x1884A8430")]
	private void JGHDCBBDEEE([Out] IDisposable GOBGILBJNEO, [Out] IDisposable MHOGMGNMJMH, [Out] IDisposable NOPPHOAAOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x84A8330", Offset = "0x84A7530", VA = "0x1884A8330")]
	private bool IPFAENHLPIB(HPLNAENGEIP ODCMJFJDLEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x84A7D70", Offset = "0x84A6F70", VA = "0x1884A7D70")]
	private void DGDMOFAGBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x84A8200", Offset = "0x84A7400", VA = "0x1884A8200")]
	[AsyncStateMachine(typeof(IKGIMPBEHKF))]
	private Task INBAEHMGJGF(HPLNAENGEIP ODCMJFJDLEN, FPDNILICPEG HODBGMFAIPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x84A8C60", Offset = "0x84A7E60", VA = "0x1884A8C60")]
	public GHDPIHDLMMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[UnityEngine.Scripting.Preserve]
internal sealed class GMAKIEFMOGI : KEEIKOODEHM, KEEEPPHJJDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct CNEAEPOPKNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<AFDJAMFDOCD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public GMAKIEFMOGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<AFDJAMFDOCD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x84A0C50", Offset = "0x849FE50", VA = "0x1884A0C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x84A0EE0", Offset = "0x84A00E0", VA = "0x1884A0EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class MLHIAIMHLGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public FBDLPCDKOKJ message;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public MLHIAIMHLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x84B2850", Offset = "0x84B1A50", VA = "0x1884B2850")]
		internal object FMJFBEHFEFL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class IFGBEGLEBAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public FBDLPCDKOKJ messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public IFGBEGLEBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x84ADD60", Offset = "0x84ACF60", VA = "0x1884ADD60")]
		internal object NKHLIAHJBFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class ECHLAEEDLGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public FBDLPCDKOKJ request;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ECHLAEEDLGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x84A3AC0", Offset = "0x84A2CC0", VA = "0x1884A3AC0")]
		internal object MODKJCAAAJD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct DEIEDIPFNAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public FBDLPCDKOKJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public GMAKIEFMOGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private TaskAwaiter<LAHJPJCGMDC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x84A1680", Offset = "0x84A0880", VA = "0x1884A1680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x84A1F50", Offset = "0x84A1150", VA = "0x1884A1F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class DMHEAILFKAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public FBDLPCDKOKJ operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DMHEAILFKAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x84A3050", Offset = "0x84A2250", VA = "0x1884A3050")]
		internal object BIKBLOKGMCL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct ENDODFLKKOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public FBDLPCDKOKJ operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public GMAKIEFMOGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private CGBDEFKMHHI <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter<FBDLPCDKOKJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x84A4AA0", Offset = "0x84A3CA0", VA = "0x1884A4AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x84A5610", Offset = "0x84A4810", VA = "0x1884A5610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct MCECBCEOCDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AsyncTaskMethodBuilder<LAHJPJCGMDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public GMAKIEFMOGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public FBDLPCDKOKJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private DKBJHHMEFLI.CELBGKAGPJC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private CGBDEFKMHHI <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter<FBDLPCDKOKJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x84B22B0", Offset = "0x84B14B0", VA = "0x1884B22B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x84B27E0", Offset = "0x84B19E0", VA = "0x1884B27E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class BGDCEHFONGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public LAHJPJCGMDC operation;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BGDCEHFONGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x849F8A0", Offset = "0x849EAA0", VA = "0x18849F8A0")]
		internal object KJCDPOIIDND()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct JLKILOPEMKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public LAHJPJCGMDC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public GMAKIEFMOGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private BGHCJGPGCNF<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x84B04C0", Offset = "0x84AF6C0", VA = "0x1884B04C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x84B0B00", Offset = "0x84AFD00", VA = "0x1884B0B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class ONIPAJLMNOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public FBDLPCDKOKJ request;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ONIPAJLMNOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x84B4730", Offset = "0x84B3930", VA = "0x1884B4730")]
		internal object CDEPBPHOKNJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class LGBBBAEFJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public FBDLPCDKOKJ request;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LGBBBAEFJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x84B2070", Offset = "0x84B1270", VA = "0x1884B2070")]
		internal object MCHGNMJILNG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private NNCKDMIFPLA AIDICANLPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private KEIAIDMOLNO HCABJLGPKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private ABCFEBOMBEM KAFNDKKJBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private AGONIDGIFFK NCFBNFPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private TaskCompletionSource<AFDJAMFDOCD> NECELMMPBCB;

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x84A9D80", Offset = "0x84A8F80", VA = "0x1884A9D80", Slot = "7")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x84A9F80", Offset = "0x84A9180", VA = "0x1884A9F80", Slot = "6")]
	[AsyncStateMachine(typeof(CNEAEPOPKNC))]
	public Task<AFDJAMFDOCD> DJGDOOJKCKO(CancellationToken BMOAGFJLNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x84AA2C0", Offset = "0x84A94C0", VA = "0x1884AA2C0", Slot = "4")]
	public void HGJHDOLENJG(FBDLPCDKOKJ NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x84AADD0", Offset = "0x84A9FD0", VA = "0x1884AADD0", Slot = "5")]
	public void PLDFCMNHFFN(FBDLPCDKOKJ DKLLKNADAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x84A9E70", Offset = "0x84A9070", VA = "0x1884A9E70")]
	[AsyncStateMachine(typeof(DEIEDIPFNAK))]
	private Task CLGALOBJCEM(FBDLPCDKOKJ IKFDGIFGHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x84AA1B0", Offset = "0x84A93B0", VA = "0x1884AA1B0")]
	[AsyncStateMachine(typeof(ENDODFLKKOM))]
	private Task FBHHGDLNOOL(FBDLPCDKOKJ FPJIINBJBPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x84AA860", Offset = "0x84A9A60", VA = "0x1884AA860")]
	[AsyncStateMachine(typeof(MCECBCEOCDP))]
	private Task<LAHJPJCGMDC> JIIFIGLGOCH(FBDLPCDKOKJ IKFDGIFGHKP, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x84AAD40", Offset = "0x84A9F40", VA = "0x1884AAD40")]
	private CGBDEFKMHHI OPGIADBHFCE(FBDLPCDKOKJ OIKJJICAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x84AA090", Offset = "0x84A9290", VA = "0x1884AA090")]
	[AsyncStateMachine(typeof(JLKILOPEMKG))]
	private Task EHIKMAFKAJD(LAHJPJCGMDC LPBJFFLCJMN, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x84AA650", Offset = "0x84A9850", VA = "0x1884AA650")]
	private LAHJPJCGMDC ILFHFPPDBIN(FBDLPCDKOKJ IKFDGIFGHKP, CGBDEFKMHHI KPCEMBLFBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x3A13E00", Offset = "0x3A13000", VA = "0x183A13E00")]
	private T KBHKNANNLHL<T>(T KJIOHKMJAPE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x84AA9B0", Offset = "0x84A9BB0", VA = "0x1884AA9B0")]
	private LAHJPJCGMDC NHBKFDBJDPC(FBDLPCDKOKJ IKFDGIFGHKP, CGBDEFKMHHI KPCEMBLFBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public GMAKIEFMOGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class GOEMEJBGPFI : KEIAIDMOLNO, KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class EMBKLOFDLBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EMBKLOFDLBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x84A4A30", Offset = "0x84A3C30", VA = "0x1884A4A30")]
		internal object EAPMPNBHMDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class LFNJGNPABMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LFNJGNPABMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x84B2000", Offset = "0x84B1200", VA = "0x1884B2000")]
		internal object FDOCICCPHED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private AGONIDGIFFK NCFBNFPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private OKIBBCNJEOI IFEOGNBFBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private KEEIKOODEHM IMNFKDKDMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private CGKOCCLEAOB AKBOLNJLJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private BIFKLCBEFHK GJCCFBAKBEK;

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x84AB130", Offset = "0x84AA330", VA = "0x1884AB130", Slot = "6")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x84AB950", Offset = "0x84AAB50", VA = "0x1884AB950", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x84AC200", Offset = "0x84AB400", VA = "0x1884AC200", Slot = "4")]
	public MEMHEIOCIPD GKENOIKGCEG(FBDLPCDKOKJ FNMMMDGJBLG)
	{
		return default(MEMHEIOCIPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x84AB740", Offset = "0x84AA940", VA = "0x1884AB740", Slot = "5")]
	public void DNHAAFJAHLE(Guid GHIHMOONOIF, Task GEOEFKJEPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x84ACC90", Offset = "0x84ABE90", VA = "0x1884ACC90")]
	private void IKGDLMBMCLB(HIPDGMOFECH HEAHMHOMOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x84ABA00", Offset = "0x84AAC00", VA = "0x1884ABA00")]
	private void EFCFBAJKGNE(LAGFABEKDBM ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x84ABF80", Offset = "0x84AB180", VA = "0x1884ABF80")]
	private void FGAHEOANDKF(LAGFABEKDBM ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x84AC870", Offset = "0x84ABA70", VA = "0x1884AC870")]
	private void GOPGOAAFMPB(LAGFABEKDBM ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x84AB2A0", Offset = "0x84AA4A0", VA = "0x1884AB2A0")]
	private ONOANLDBBEM CNDCCLFODKG(FBDLPCDKOKJ OIKJJICAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x84AB540", Offset = "0x84AA740", VA = "0x1884AB540")]
	private void DHHEPCIHCLE(FBDLPCDKOKJ FPJIINBJBPJ, ONOANLDBBEM JGJIALJFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x84ACAB0", Offset = "0x84ABCB0", VA = "0x1884ACAB0")]
	private bool IFGOIKCCLKM(FBDLPCDKOKJ FPJIINBJBPJ, ONOANLDBBEM JGJIALJFAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x84ACDA0", Offset = "0x84ABFA0", VA = "0x1884ACDA0")]
	private bool OJJIMMHJGHM(FBDLPCDKOKJ DAGEPKNBCFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x84AC620", Offset = "0x84AB820", VA = "0x1884AC620")]
	private bool GOBMBDOMDAI(byte HADNLMBOMNH, ExitGames.Client.Photon.Hashtable ODLIDIMANGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public GOEMEJBGPFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class JOMKLPFHCLI : JCPLNKMCPEJ, KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class GACJGEKLHKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AFDJAMFDOCD operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public JOMKLPFHCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public FBDLPCDKOKJ roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GACJGEKLHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x84A6DE0", Offset = "0x84A5FE0", VA = "0x1884A6DE0")]
		internal object JKOGMBCCGCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x84A6E50", Offset = "0x84A6050", VA = "0x1884A6E50")]
		internal object NHMBFCFFEFA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct PGDLHKOLAOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public AsyncTaskMethodBuilder<ONOANLDBBEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public JOMKLPFHCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public FBDLPCDKOKJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter<ONOANLDBBEM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x84B4790", Offset = "0x84B3990", VA = "0x1884B4790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x84B4E30", Offset = "0x84B4030", VA = "0x1884B4E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class KKAJGKKHOKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AFDJAMFDOCD operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KKAJGKKHOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x84B1290", Offset = "0x84B0490", VA = "0x1884B1290")]
		internal object BJLEIGHLCHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class DAAGKNAFAOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public FBDLPCDKOKJ request;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DAAGKNAFAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x84A1470", Offset = "0x84A0670", VA = "0x1884A1470")]
		internal object MBHPMCOAMIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x84A1400", Offset = "0x84A0600", VA = "0x1884A1400")]
		internal object FLDIGBDCMKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x84A14E0", Offset = "0x84A06E0", VA = "0x1884A14E0")]
		internal object NDLMIFDEDBM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct PMIAJDMPIFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public AsyncTaskMethodBuilder<ONOANLDBBEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public FBDLPCDKOKJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public JOMKLPFHCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private DAAGKNAFAOO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private MEMHEIOCIPD <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private ONOANLDBBEM <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private TaskAwaiter<(ONOANLDBBEM validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x84B5F50", Offset = "0x84B5150", VA = "0x1884B5F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x84B6820", Offset = "0x84B5A20", VA = "0x1884B6820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private AGONIDGIFFK NCFBNFPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private OKIBBCNJEOI IFEOGNBFBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private KEIAIDMOLNO HCABJLGPKJB;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x84B0B60", Offset = "0x84AFD60", VA = "0x1884B0B60", Slot = "5")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x84B0C10", Offset = "0x84AFE10", VA = "0x1884B0C10", Slot = "4")]
	[AsyncStateMachine(typeof(PGDLHKOLAOE))]
	private Task<ONOANLDBBEM> FDDKOBGHFNH(FBDLPCDKOKJ OIKJJICAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x84B0D30", Offset = "0x84AFF30", VA = "0x1884B0D30")]
	private bool GGGDCMPOLON(AFDJAMFDOCD JEMHLLLEHAD, [Out] ONOANLDBBEM ACALKMLJJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x84B0F20", Offset = "0x84B0120", VA = "0x1884B0F20")]
	[AsyncStateMachine(typeof(PMIAJDMPIFD))]
	private Task<ONOANLDBBEM> MFJABFPCNCE(FBDLPCDKOKJ IKFDGIFGHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public JOMKLPFHCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class HHKENKJJDNI : KKKHODIMONB, KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private struct KCLLCONICEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public JENOKPCEBIE EKMANLJMLIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public long MALMFBGFJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public Guid? DINJKKCBBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public bool JFMIPMGDPLH;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct IJIBIKJHAOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder<LBIKBDECECI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public HHKENKJJDNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<EAAMLCEDMMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter<LBIKBDECECI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x84ADDC0", Offset = "0x84ACFC0", VA = "0x1884ADDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x84AE390", Offset = "0x84AD590", VA = "0x1884AE390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class DAFABKJELPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DAFABKJELPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x84A1550", Offset = "0x84A0750", VA = "0x1884A1550")]
		internal object LMABJIEHIEN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct LDFINDGHHHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AsyncTaskMethodBuilder<EAAMLCEDMMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public HHKENKJJDNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private DAFABKJELPF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private TaskAwaiter<EAAMLCEDMMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x84B19A0", Offset = "0x84B0BA0", VA = "0x1884B19A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x84B1F90", Offset = "0x84B1190", VA = "0x1884B1F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct IJJKFJECJIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public AsyncTaskMethodBuilder<LBIKBDECECI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public HHKENKJJDNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public EAAMLCEDMMD roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<KCLLCONICEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x84AE400", Offset = "0x84AD600", VA = "0x1884AE400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x84AE970", Offset = "0x84ADB70", VA = "0x1884AE970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class LNLCLFGHNAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public EAAMLCEDMMD roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LNLCLFGHNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xECEF10", Offset = "0xECE110", VA = "0x180ECEF10")]
		internal bool HJOKLHNBNOI(EBAEPIOAJNM sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x84B2160", Offset = "0x84B1360", VA = "0x1884B2160")]
		internal object INKIKGKGEOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x84B20D0", Offset = "0x84B12D0", VA = "0x1884B20D0")]
		internal object CHCNNOGBMKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x84B2220", Offset = "0x84B1420", VA = "0x1884B2220")]
		internal object KAPNFNGPIDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class KLIFKOALGCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public LNLCLFGHNAM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KLIFKOALGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x84B1300", Offset = "0x84B0500", VA = "0x1884B1300")]
		internal object KLNGBKDCEKA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct DLDJNHPOLAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public AsyncTaskMethodBuilder<KCLLCONICEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public EAAMLCEDMMD roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public HHKENKJJDNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public HPLNAENGEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private KLIFKOALGCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private TaskAwaiter<KCLLCONICEO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private TaskAwaiter<BIDCFCNHFIC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x84A2040", Offset = "0x84A1240", VA = "0x1884A2040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x84A2FE0", Offset = "0x84A21E0", VA = "0x1884A2FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class CPNLMMFKAHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public CPNLMMFKAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x84A1350", Offset = "0x84A0550", VA = "0x1884A1350")]
		internal object JFIDGFDAGFA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct PPHMHAIFOPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<KCLLCONICEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public EBAEPIOAJNM subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public HHKENKJJDNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public HPLNAENGEIP dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private CPNLMMFKAHG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private TaskAwaiter<ALGKPHFBIHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x84BBF80", Offset = "0x84BB180", VA = "0x1884BBF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x84BC650", Offset = "0x84BB850", VA = "0x1884BC650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private FANFNGDGAHN PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private KMMADBMONKE HICOIPDJCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private MCCNADEBFLC LHPDGBFBJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private EAPMNCNAJAH BLCJGLOEDAC;

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x84AD010", Offset = "0x84AC210", VA = "0x1884AD010", Slot = "5")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x84AD6B0", Offset = "0x84AC8B0", VA = "0x1884AD6B0", Slot = "4")]
	[AsyncStateMachine(typeof(IJIBIKJHAOO))]
	public Task<LBIKBDECECI> IDAHIHOOCEC(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, HPLNAENGEIP CKKPLENLEPO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x84AD270", Offset = "0x84AC470", VA = "0x1884AD270")]
	[AsyncStateMachine(typeof(LDFINDGHHHF))]
	private Task<EAAMLCEDMMD> CJEMNLMHLEO(HPLNAENGEIP CKKPLENLEPO, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x84AD3D0", Offset = "0x84AC5D0", VA = "0x1884AD3D0")]
	[AsyncStateMachine(typeof(IJJKFJECJIE))]
	private Task<LBIKBDECECI> DNFNLHBIGNK(HPLNAENGEIP CKKPLENLEPO, EAAMLCEDMMD GBGPPHPELPD, long OPILFBADOKA, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x84AD100", Offset = "0x84AC300", VA = "0x1884AD100")]
	[AsyncStateMachine(typeof(DLDJNHPOLAA))]
	private Task<KCLLCONICEO> CGJAPBAEPNO(HPLNAENGEIP CKKPLENLEPO, EAAMLCEDMMD GBGPPHPELPD, long OPILFBADOKA, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x84AD540", Offset = "0x84AC740", VA = "0x1884AD540")]
	[AsyncStateMachine(typeof(PPHMHAIFOPN))]
	private Task<KCLLCONICEO> HFEPPPFCMKF(HPLNAENGEIP CPDDIIEIPBE, EBAEPIOAJNM JEAFNAEELPJ, long OPILFBADOKA, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public HHKENKJJDNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[UnityEngine.Scripting.Preserve]
internal sealed class OHKOHIMFPIG : ABCFEBOMBEM, KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class HEDPHNLDNOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public FBDLPCDKOKJ request;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HEDPHNLDNOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x84ACFB0", Offset = "0x84AC1B0", VA = "0x1884ACFB0")]
		internal object OOPPMEMAPKO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private struct BIGJCNFMHNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public AsyncTaskMethodBuilder<FBDLPCDKOKJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public FBDLPCDKOKJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public OHKOHIMFPIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public CGBDEFKMHHI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private TaskAwaiter<FBDLPCDKOKJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x849F920", Offset = "0x849EB20", VA = "0x18849F920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x849FF30", Offset = "0x849F130", VA = "0x18849FF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct DOGDLIMPBKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public AsyncTaskMethodBuilder<FBDLPCDKOKJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public OHKOHIMFPIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public CGBDEFKMHHI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private TaskAwaiter<IGFIPDJAONH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x84A30B0", Offset = "0x84A22B0", VA = "0x1884A30B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x84A36A0", Offset = "0x84A28A0", VA = "0x1884A36A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class KMICBCGKLNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public FBDLPCDKOKJ request;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KMICBCGKLNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x84B1400", Offset = "0x84B0600", VA = "0x1884B1400")]
		internal object AFDAOPOEIJD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct MMBAMCOMPMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public AsyncTaskMethodBuilder<FBDLPCDKOKJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public FBDLPCDKOKJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public OHKOHIMFPIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public CGBDEFKMHHI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private FEEGOJLLKAK <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private OGCEMKMBILP <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private TaskAwaiter<IGFIPDJAONH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x84B28B0", Offset = "0x84B1AB0", VA = "0x1884B28B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x84B34A0", Offset = "0x84B26A0", VA = "0x1884B34A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private AGONIDGIFFK NCFBNFPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private MKFMFBPOMOL LGFLDAGFPAN;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private GDABOMEIBEI JNCHMGDNJMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x84B3F90", Offset = "0x84B3190", VA = "0x1884B3F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x84B4050", Offset = "0x84B3250", VA = "0x1884B4050", Slot = "8")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x84B4210", Offset = "0x84B3410", VA = "0x1884B4210", Slot = "4")]
	[AsyncStateMachine(typeof(BIGJCNFMHNB))]
	public Task<FBDLPCDKOKJ> GAHNMJHIMIJ(FBDLPCDKOKJ IKFDGIFGHKP, CGBDEFKMHHI KPCEMBLFBDD, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x84B4580", Offset = "0x84B3780", VA = "0x1884B4580", Slot = "5")]
	[AsyncStateMachine(typeof(DOGDLIMPBKF))]
	public Task<FBDLPCDKOKJ> PNMIDAIOPDN(CancellationToken FHBCOAHILMJ, CGBDEFKMHHI KPCEMBLFBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x84B44D0", Offset = "0x84B36D0", VA = "0x1884B44D0", Slot = "6")]
	public FBDJJJEGEAF JDHELBKPLMN(LAHJPJCGMDC PMBJAEFPMGN, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x84B40E0", Offset = "0x84B32E0", VA = "0x1884B40E0", Slot = "7")]
	public FBDJJJEGEAF FAOGLAONOBM(LAHJPJCGMDC PMBJAEFPMGN, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x84B4370", Offset = "0x84B3570", VA = "0x1884B4370")]
	[AsyncStateMachine(typeof(MMBAMCOMPMC))]
	private Task<FBDLPCDKOKJ> HNJIHFOACCE(FBDLPCDKOKJ IKFDGIFGHKP, CGBDEFKMHHI KPCEMBLFBDD, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x39DA880", Offset = "0x39D9A80", VA = "0x1839DA880")]
	private static byte[] BILGPHKNPDB(FBDLPCDKOKJ NPEJLHCJPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public OHKOHIMFPIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[UnityEngine.Scripting.Preserve]
internal sealed class OGPDEAIENMF : OKIBBCNJEOI, KEEEPPHJJDK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private CHEBGOMCOHH PIJGDCDLBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private AGONIDGIFFK NCFBNFPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private NNCKDMIFPLA AIDICANLPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private AKIOIOJPPLM JHIPJECKOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private FANFNGDGAHN PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private CCIPIEMODMF IKJEPHDAABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private FAGAHDOLLOE CMPLHLLDIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private KMMADBMONKE HICOIPDJCOI;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private BPFCLMEBPNG EEJBLGPIIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x84B3CB0", Offset = "0x84B2EB0", VA = "0x1884B3CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static ONOANLDBBEM JPDJJAKCOLP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x84B3D00", Offset = "0x84B2F00", VA = "0x1884B3D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x84B39C0", Offset = "0x84B2BC0", VA = "0x1884B39C0", Slot = "6")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x84B3B40", Offset = "0x84B2D40", VA = "0x1884B3B40", Slot = "4")]
	public ONOANLDBBEM FJNAAJFPBNA(BNFABCHNBCL DGJDBPKMOOE, AFDJAMFDOCD FNNHHHKCEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x84B3D10", Offset = "0x84B2F10", VA = "0x1884B3D10", Slot = "5")]
	public ONOANLDBBEM OCMIGJJIJDI(BNFABCHNBCL MCHIEDFKOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x84B3B30", Offset = "0x84B2D30", VA = "0x1884B3B30")]
	private static ONOANLDBBEM CGFGIKDKPAA(KMDPCKKCIOG GBBFGBIIOBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public OGPDEAIENMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class PGPBNGOKODP : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x84B57F0", Offset = "0x84B49F0", VA = "0x1884B57F0")]
	public PGPBNGOKODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x76528C0", Offset = "0x7651AC0", VA = "0x1876528C0")]
	public PGPBNGOKODP(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[UnityEngine.Scripting.Preserve]
internal sealed class LFNKLGCNKKM : CKCEILMKLLA, KEEEPPHJJDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct DBIBNNHKJCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public AsyncTaskMethodBuilder<ONOANLDBBEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public LFNKLGCNKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public CBBEGLFAAKE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private BGHCJGPGCNF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private GJPMEAPLECE <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter<ONOANLDBBEM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x84BFEE0", Offset = "0x84BF0E0", VA = "0x1884BFEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x84C08B0", Offset = "0x84BFAB0", VA = "0x1884C08B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct GHCLLMEIFIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public LFNKLGCNKKM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84C7BF0", Offset = "0x84C6DF0", VA = "0x1884C7BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x84C8330", Offset = "0x84C7530", VA = "0x1884C8330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct DDKKLCIHAMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public LFNKLGCNKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x84C1340", Offset = "0x84C0540", VA = "0x1884C1340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x84C1850", Offset = "0x84C0A50", VA = "0x1884C1850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct BCHLGMMBAIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public LFNKLGCNKKM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84BD910", Offset = "0x84BCB10", VA = "0x1884BD910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x84BE0D0", Offset = "0x84BD2D0", VA = "0x1884BE0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct AKAIDPGAKKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public LFNKLGCNKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x84BD440", Offset = "0x84BC640", VA = "0x1884BD440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x84BD5E0", Offset = "0x84BC7E0", VA = "0x1884BD5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct KFONHCNLEPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public LFNKLGCNKKM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84CCCD0", Offset = "0x84CBED0", VA = "0x1884CCCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x84CD3E0", Offset = "0x84CC5E0", VA = "0x1884CD3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct ILNMDBODJGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public LFNKLGCNKKM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84CAF30", Offset = "0x84CA130", VA = "0x1884CAF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x84CB3A0", Offset = "0x84CA5A0", VA = "0x1884CB3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct ENMMINIALDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public LFNKLGCNKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public IDBHCDKMGJP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private BGHCJGPGCNF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x84C49D0", Offset = "0x84C3BD0", VA = "0x1884C49D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x84C4F70", Offset = "0x84C4170", VA = "0x1884C4F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private AGONIDGIFFK NCFBNFPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private FANFNGDGAHN PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private ABCFEBOMBEM KAFNDKKJBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private NNCKDMIFPLA AIDICANLPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private FAGAHDOLLOE CMPLHLLDIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private CancellationTokenSource KOFGCFLENGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private Task NFLHJACIAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private TaskCompletionSource<int> GGKBFKIOJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private int OEBAHAIIIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private int OBLIGHNPNFP;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x84CF100", Offset = "0x84CE300", VA = "0x1884CF100", Slot = "6")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x1398BE0", Offset = "0x1397DE0", VA = "0x181398BE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x84CF900", Offset = "0x84CEB00", VA = "0x1884CF900")]
	private void ICCBCMFDBJP(float GFEDFIDPIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x84CFFA0", Offset = "0x84CF1A0", VA = "0x1884CFFA0", Slot = "4")]
	[AsyncStateMachine(typeof(DBIBNNHKJCP))]
	public Task<ONOANLDBBEM> MBDDMNOONEN(CBBEGLFAAKE AABAAIKLAIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x84CF530", Offset = "0x84CE730", VA = "0x1884CF530", Slot = "5")]
	[AsyncStateMachine(typeof(GHCLLMEIFIG))]
	public Task CHPJLLLNAOD([Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x1398BE0", Offset = "0x1397DE0", VA = "0x181398BE0")]
	public void CKDEGOHPJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x84CFD70", Offset = "0x84CEF70", VA = "0x1884CFD70")]
	private GJPMEAPLECE KJPLJOOOEKD(CBBEGLFAAKE AABAAIKLAIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x84CF710", Offset = "0x84CE910", VA = "0x1884CF710")]
	[AsyncStateMachine(typeof(DDKKLCIHAMI))]
	private Task ELPMHLINENA(CancellationToken CDMFGCJPANH, int CBCJLPKKBGM, OHDGGAAKGEM PFPIBCCLABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x84D00D0", Offset = "0x84CF2D0", VA = "0x1884D00D0")]
	[AsyncStateMachine(typeof(BCHLGMMBAIE))]
	private Task PJGMPIFIGAD(CancellationToken CDMFGCJPANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x84CF620", Offset = "0x84CE820", VA = "0x1884CF620")]
	[AsyncStateMachine(typeof(AKAIDPGAKKM))]
	private Task COBNPLHENDM([Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x84CF440", Offset = "0x84CE640", VA = "0x1884CF440")]
	[AsyncStateMachine(typeof(KFONHCNLEPH))]
	private Task CDOODDMEGAA(CancellationToken CDMFGCJPANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x84CF800", Offset = "0x84CEA00", VA = "0x1884CF800")]
	[AsyncStateMachine(typeof(ILNMDBODJGC))]
	private Task GLPJNOMJDGK(CancellationToken NDFLFMELGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x84CF2B0", Offset = "0x84CE4B0", VA = "0x1884CF2B0")]
	private Task CCIBICGMBCG(IDBHCDKMGJP LOAICONOLLD, CancellationToken CDMFGCJPANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x84CFC60", Offset = "0x84CEE60", VA = "0x1884CFC60")]
	[AsyncStateMachine(typeof(ENMMINIALDK))]
	private Task JMFGJMJAAAO(IDBHCDKMGJP LOAICONOLLD, CancellationToken CDMFGCJPANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x84CF9E0", Offset = "0x84CEBE0", VA = "0x1884CF9E0")]
	private bool IIKEOLDLKPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public LFNKLGCNKKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[UnityEngine.Scripting.Preserve]
internal class DAMFKIMNNBP : AKIOIOJPPLM, KEEEPPHJJDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct ODJDHNMDOJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public DAMFKIMNNBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private BGHCJGPGCNF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x84D7880", Offset = "0x84D6A80", VA = "0x1884D7880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x84D7E40", Offset = "0x84D7040", VA = "0x1884D7E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	private FMJDBDONLDC DJOOOBHJMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private OKIBBCNJEOI IFEOGNBFBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	private ABCFEBOMBEM KAFNDKKJBDM;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x84BF910", Offset = "0x84BEB10", VA = "0x1884BF910", Slot = "6")]
	public void AFLILFPIJAH(AEHEGPIEOCE IKFFOMHBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x84BFBF0", Offset = "0x84BEDF0", VA = "0x1884BFBF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x84BFDE0", Offset = "0x84BEFE0", VA = "0x1884BFDE0", Slot = "5")]
	[AsyncStateMachine(typeof(ODJDHNMDOJM))]
	public Task OOFPOHGMENN(string BLOCNHOFANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x84BFC40", Offset = "0x84BEE40", VA = "0x1884BFC40", Slot = "4")]
	public ONOANLDBBEM IIKEOLDLKPG(BNFABCHNBCL DGJDBPKMOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x84BFCA0", Offset = "0x84BEEA0", VA = "0x1884BFCA0")]
	private ICPCCDFMFPJ IMOBFKLHPID(string BLOCNHOFANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public DAMFKIMNNBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class FMEGNBMHBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x84C6A60", Offset = "0x84C5C60", VA = "0x1884C6A60")]
	public static void MKOMAFJNKII(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x84C64D0", Offset = "0x84C56D0", VA = "0x1884C64D0")]
	internal static void FMBKACDFEFC(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x84C6CA0", Offset = "0x84C5EA0", VA = "0x1884C6CA0")]
	internal static void NPGOBDIFLEC(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x84C6630", Offset = "0x84C5830", VA = "0x1884C6630")]
	internal static void KDLFADPOPNF(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x39EFE20", Offset = "0x39EF020", VA = "0x1839EFE20")]
	private static void GCKHINGHDJI<Interface, Impl, Interface>(FJCFOKJAKFO MBLPEFIMNGA) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal class JCLNICAMHJA : KGIKCCJACDM<FBDLPCDKOKJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class EKMOPBINLLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public FBDLPCDKOKJ message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EKMOPBINLLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x84C3DD0", Offset = "0x84C2FD0", VA = "0x1884C3DD0")]
		internal object GCKHNOFKFEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly JCLNICAMHJA AIBLJDBPKAO;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x84CC9C0", Offset = "0x84CBBC0", VA = "0x1884CC9C0")]
	public ExitGames.Client.Photon.Hashtable ELKKKBEIKKA(FBDLPCDKOKJ NPEJLHCJPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x84CCA50", Offset = "0x84CBC50", VA = "0x1884CCA50", Slot = "5")]
	protected override void MGEIBHKOJHK(FBDLPCDKOKJ NPEJLHCJPAI, IDictionary<object, object> CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x84CC790", Offset = "0x84CB990", VA = "0x1884CC790", Slot = "6")]
	public override FBDLPCDKOKJ BHIBMPPAILM(IDictionary<object, object> CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x84CC680", Offset = "0x84CB880", VA = "0x1884CC680")]
	private static void AODHEIHGBPN(string HNAPICGNPBO, FBDLPCDKOKJ NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x84CCC10", Offset = "0x84CBE10", VA = "0x1884CCC10")]
	public JCLNICAMHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x84CC3D0", Offset = "0x84CB5D0", VA = "0x1884CC3D0")]
	[CompilerGenerated]
	internal static string AJBEHCOKHLC(LBIKBDECECI EKFBEBELGHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class AILEPPLEFGC
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static ONOANLDBBEM JPDJJAKCOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x84BD190", Offset = "0x84BC390", VA = "0x1884BD190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x84BD170", Offset = "0x84BC370", VA = "0x1884BD170")]
	public static bool KAKEFBCBHDO(this ONOANLDBBEM JGJIALJFAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x84BCF20", Offset = "0x84BC120", VA = "0x1884BCF20")]
	public static ONOANLDBBEM CGFGIKDKPAA(KMDPCKKCIOG BGIMMPEECCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x84BCF80", Offset = "0x84BC180", VA = "0x1884BCF80")]
	public static ONOANLDBBEM IGBBMEJKGIC(IEnumerable<ONOANLDBBEM> DOHIJPNPNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x84BD1F0", Offset = "0x84BC3F0", VA = "0x1884BD1F0")]
	public static string PFHKKHBDOKJ(this ONOANLDBBEM ACALKMLJJOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public abstract class CKKFMDJKMAP : COECKDNEPBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public delegate ONOANLDBBEM PIPFFPADHOI([NotNull] BNFABCHNBCL GALNOKDLDNP);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class BONGIKONDMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public BNFABCHNBCL photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BONGIKONDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1661110", Offset = "0x1660310", VA = "0x181661110")]
		internal ONOANLDBBEM JKIEMADNMCF(PIPFFPADHOI v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private bool JDKAOICAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	protected readonly HashSet<PIPFFPADHOI> KOFIHGLPEFJ;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x84BEC70", Offset = "0x84BDE70", VA = "0x1884BEC70", Slot = "4")]
	public void MBDEIDNJAFH(PIPFFPADHOI LGDEOBFGFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x84BEC10", Offset = "0x84BDE10", VA = "0x1884BEC10", Slot = "5")]
	public void LCBHMOPJLHF(PIPFFPADHOI LGDEOBFGFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x84BE930", Offset = "0x84BDB30", VA = "0x1884BE930", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x84BE980", Offset = "0x84BDB80", VA = "0x1884BE980")]
	protected ONOANLDBBEM GKFIFGJKAKN(BNFABCHNBCL MCHIEDFKOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x84BECD0", Offset = "0x84BDED0", VA = "0x1884BECD0")]
	protected CKKFMDJKMAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class CNCGIKBHIOL : CKKFMDJKMAP, CHEBGOMCOHH, COECKDNEPBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class EDOGOEBAMFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public ONOANLDBBEM result;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EDOGOEBAMFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x84C3460", Offset = "0x84C2660", VA = "0x1884C3460")]
		internal object EIACNBMIOCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x84BEE70", Offset = "0x84BE070", VA = "0x1884BEE70")]
	[UnityEngine.Scripting.Preserve]
	public CNCGIKBHIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x84BED60", Offset = "0x84BDF60", VA = "0x1884BED60", Slot = "8")]
	public ONOANLDBBEM FCCEMJDLMOK(BNFABCHNBCL MCHIEDFKOJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class OKCOILINNJB : CKKFMDJKMAP, FMJDBDONLDC, COECKDNEPBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class LEJECIMDLDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public ONOANLDBBEM result;

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LEJECIMDLDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x84CF0A0", Offset = "0x84CE2A0", VA = "0x1884CF0A0")]
		internal object AFOLBLINNDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x84BEE70", Offset = "0x84BE070", VA = "0x1884BEE70")]
	[UnityEngine.Scripting.Preserve]
	public OKCOILINNJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x84D80E0", Offset = "0x84D72E0", VA = "0x1884D80E0", Slot = "8")]
	public ONOANLDBBEM IIKEOLDLKPG(BNFABCHNBCL NKEACAOKBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal static class DCIFGGCPDFI
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class PCEMLLJHGKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public BGHCJGPGCNF<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public PCEMLLJHGKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x84D81F0", Offset = "0x84D73F0", VA = "0x1884D81F0")]
		internal object EILBMOAGIFB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x84C10E0", Offset = "0x84C02E0", VA = "0x1884C10E0")]
	public static BGHCJGPGCNF<string> CLLJBGLGJGH(KEPOMIIOHBM EBHKLAMEJCE, [Optional] string EHJIGHHBKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x84C1280", Offset = "0x84C0480", VA = "0x1884C1280")]
	public static void MKEKNGGJGIJ(BGHCJGPGCNF<string> LAEALHELJKO, KEPOMIIOHBM EBHKLAMEJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x84C11C0", Offset = "0x84C03C0", VA = "0x1884C11C0")]
	public static string KINNBLGAJBN(FBDLPCDKOKJ OIKJJICAEAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal static class EBLNAKNDCKH
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x84C23B0", Offset = "0x84C15B0", VA = "0x1884C23B0")]
	public static void EIHAPLMOFOI(this AGONIDGIFFK NCFBNFPHDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x84C23C0", Offset = "0x84C15C0", VA = "0x1884C23C0")]
	public static void NMADALIHHNA(this AGONIDGIFFK NCFBNFPHDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x84C2290", Offset = "0x84C1490", VA = "0x1884C2290")]
	private static void EHKDJLPGIKG(this AGONIDGIFFK NCFBNFPHDDJ, bool PCBKFKNONNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class PNIFDHGLEDA : CMJOIEPIJJK, CBJOBDJGPPE, OEHCLHIPBJL, OEEIPIIFMJI
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[DefaultMember("Item")]
	private class ENDPCOCKNFC : HIPDGMOFECH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private readonly byte IEGHFABKDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private readonly int GCPKMNCMKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private readonly object OIPNCGKDPFE;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte PDGHMKFJMJK
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xA75190", Offset = "0xA74390", VA = "0x180A75190", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int MJAAKMGHDNM
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA90990", Offset = "0xA8FB90", VA = "0x180A90990", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object CECAADHHAGD
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object HAHLLCOCBCC
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x84C4980", Offset = "0x84C3B80", VA = "0x1884C4980", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x7659EF0", Offset = "0x76590F0", VA = "0x187659EF0")]
		public ENDPCOCKNFC(byte IEGHFABKDKJ, int GCPKMNCMKPP, object OIPNCGKDPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x84C4930", Offset = "0x84C3B30", VA = "0x1884C4930", Slot = "8")]
		public bool FBLKJFCBGPJ(byte MHDODBCCAJB, [Out] object KJIOHKMJAPE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly CBJOBDJGPPE CCPNJFIHPHK;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public BNFABCHNBCL NDGKEBACOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x84D9730", Offset = "0x84D8930", VA = "0x1884D9730", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int HBMHPKDEAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x84D8EB0", Offset = "0x84D80B0", VA = "0x1884D8EB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int DDOLIPMONHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x84D9180", Offset = "0x84D8380", VA = "0x1884D9180", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public BNFABCHNBCL FAKLMIENPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x84D8E10", Offset = "0x84D8010", VA = "0x1884D8E10", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool LNOIDHHPFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int IKHGDNGBACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA4FC30", Offset = "0xA4EE30", VA = "0x180A4FC30", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string JLIFHFHIKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x84D9320", Offset = "0x84D8520", VA = "0x1884D9320", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> PGNOKLFAGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x84D9050", Offset = "0x84D8250", VA = "0x1884D9050", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<string, long> MCEAFMEMKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<HIPDGMOFECH> PPGKLDLOIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F00", Offset = "0x84D8100", VA = "0x1884D8F00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x84D9500", Offset = "0x84D8700", VA = "0x1884D9500", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> DKBOMHFOAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "26")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "27")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<BNFABCHNBCL> PONJHEFHAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action MMPGJGEHHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x84D8FB0", Offset = "0x84D81B0", VA = "0x1884D8FB0", Slot = "35")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x84D95B0", Offset = "0x84D87B0", VA = "0x1884D95B0", Slot = "36")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x84D9120", Offset = "0x84D8320", VA = "0x1884D9120", Slot = "19")]
	public void GBNMLLMKILO(string GBOCGPJOEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xD7C100", Offset = "0xD7B300", VA = "0x180D7C100")]
	public PNIFDHGLEDA(CBJOBDJGPPE CCPNJFIHPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x84D91D0", Offset = "0x84D83D0", VA = "0x1884D91D0", Slot = "8")]
	public bool GJELHJLMOHL(byte HADNLMBOMNH, object FAONOPFFPFN, FLEPBPAFMND GMFBDIONGGP, BMEOONJFDHA DHAAPHEFKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x84D9460", Offset = "0x84D8660", VA = "0x1884D9460", Slot = "20")]
	public BNFABCHNBCL JIGDLBCECOK(int CBKLGKPCDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x84D9380", Offset = "0x84D8580", VA = "0x1884D9380", Slot = "21")]
	public BNFABCHNBCL IJFPHDJFBFP(int LJKLNEIKJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x84D8D30", Offset = "0x84D7F30", VA = "0x1884D8D30", Slot = "22")]
	public BNFABCHNBCL AFAPGKBNDHO(int CBKLGKPCDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x84D9650", Offset = "0x84D8850", VA = "0x1884D9650", Slot = "23")]
	public IReadOnlyList<BNFABCHNBCL> MONOPOACAIF(bool ABMLPAFGNAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x84D92E0", Offset = "0x84D84E0", VA = "0x1884D92E0", Slot = "24")]
	public IReadOnlyList<BNFABCHNBCL> GJIHCLCIMCP(bool ABMLPAFGNAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "25")]
	public bool NFFANMOLIFJ(BNFABCHNBCL IBGMFKKIGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "28")]
	public void MPBPEIFMMFP(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "29")]
	public void OCIIOBMICJL(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "30")]
	public void COOFHBHOBKI(object CCLFNPCGNED, bool HPDDMCOBLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x84D8E60", Offset = "0x84D8060", VA = "0x1884D8E60", Slot = "31")]
	public IDisposable AIGFOOEDALH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "32")]
	private bool BHBFKPKLFOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "33")]
	public void IJBFHJGMLFB(StringBuilder EBDMNFPBBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xFAEA80", Offset = "0xFADC80", VA = "0x180FAEA80", Slot = "34")]
	public bool LICMGIIPDFF(bool MKFFIHAOAKG, [Out] string HKIJLMNBOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xF246B0", Offset = "0xF238B0", VA = "0x180F246B0", Slot = "37")]
	public void BEBHJOMIEEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct LAGFABEKDBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly IDictionary<object, object> ODLIDIMANGE;

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0xD91890", Offset = "0xD90A90", VA = "0x180D91890")]
	public LAGFABEKDBM(IDictionary<object, object> ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x84CDB80", Offset = "0x84CCD80", VA = "0x1884CDB80")]
	public bool DACAFMOLMEF([Out] FBDLPCDKOKJ NPEJLHCJPAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x84CDD20", Offset = "0x84CCF20", VA = "0x1884CDD20")]
	public Guid JKPMIHFDGNH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x84CDA50", Offset = "0x84CCC50", VA = "0x1884CDA50")]
	public ONOANLDBBEM BAHPPICMLPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x84CDC30", Offset = "0x84CCE30", VA = "0x1884CDC30")]
	public static ExitGames.Client.Photon.Hashtable DBJJOAFKEPP(FBDLPCDKOKJ NPEJLHCJPAI, ONOANLDBBEM JGJIALJFAJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal static class JOJDKFMMCMM
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x84CCC50", Offset = "0x84CBE50", VA = "0x1884CCC50")]
	public static bool OABIMHOKBHF(this HPLNAENGEIP EJHGGALBJHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct PMMMNAGJELM : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct OJIMHAAJKPG : IAsyncStateMachine
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
		public PMMMNAGJELM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x84D7EA0", Offset = "0x84D70A0", VA = "0x1884D7EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x84D8080", Offset = "0x84D7280", VA = "0x1884D8080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly CancellationTokenSource IHOFGGILNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private bool JDKAOICAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private Task MKOPIIJMBLM;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool APFGOMCKPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x84D8B80", Offset = "0x84D7D80", VA = "0x1884D8B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x84D8C00", Offset = "0x84D7E00", VA = "0x1884D8C00")]
	public PMMMNAGJELM(CancellationToken FHBCOAHILMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x84D8A70", Offset = "0x84D7C70", VA = "0x1884D8A70")]
	[AsyncStateMachine(typeof(OJIMHAAJKPG))]
	public Task BLJDEFJMBFK(Func<CancellationToken, List<Task>> LFGACIJHCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x84D8BB0", Offset = "0x84D7DB0", VA = "0x1884D8BB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public readonly struct OMHLEEGPNEH<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct HEGPFJLCGLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<BCCCDAHDJFG<TData>, DCJPFEGHGPF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public OMHLEEGPNEH<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TaskAwaiter<DJNAMIFBMIO<BCCCDAHDJFG<TData>, DCJPFEGHGPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x4CA0220", Offset = "0x4C9F420", VA = "0x184CA0220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x420CDD0", Offset = "0x420BFD0", VA = "0x18420CDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly PPACNMHEMIK<TGetDataArg, TData> EMPPIJCDCNI;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0xD91890", Offset = "0xD90A90", VA = "0x180D91890")]
	internal OMHLEEGPNEH(PPACNMHEMIK<TGetDataArg, TData> AHPCPGHNHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x562D560", Offset = "0x562C760", VA = "0x18562D560")]
	[AsyncStateMachine(typeof(OMHLEEGPNEH<, >.HEGPFJLCGLD))]
	public Task<DJNAMIFBMIO<BCCCDAHDJFG<TData>, DCJPFEGHGPF>> AGHJPJBCINO(TGetDataArg BNCBJIMFGHJ, string KFDHOKEPECL, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class MIIIEFODKHG
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA75D0", Offset = "0x2FA67D0", VA = "0x182FA75D0")]
	public static OMHLEEGPNEH<TGetDataArg, TData> FAHGDJGLLGD<TGetDataArg, TData>(PPACNMHEMIK<TGetDataArg, TData> AHPCPGHNHGP)
	{
		return default(OMHLEEGPNEH<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct MJDHEAFMIOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public readonly int PDGHMKFJMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public readonly int? PLHKEIDGFJG;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x51CEDB0", Offset = "0x51CDFB0", VA = "0x1851CEDB0")]
	public MJDHEAFMIOG(int IEGHFABKDKJ, [Optional] int? IAFFBJBHMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x84D3C30", Offset = "0x84D2E30", VA = "0x1884D3C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface MBDPOBHEDJN<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPBDDIGJEDI();

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MBDPOBHEDJN<T> PNFONGMGAAL(string GNLDHDANFJL);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MBDPOBHEDJN<T> LDDNMLCCLFB(BDDEGIIGGJH<T> OONPOGFMBOI);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MBDPOBHEDJN<T> GAGFGBEMJEH(int LKKKAKAHAFI);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MBDPOBHEDJN<T> KOBLIPLLDGA(int LKKKAKAHAFI, IPJAABMHJPM<T> CPOPJJDEHKA);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface GMOGLPEOKFM
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBDPOBHEDJN<T> LPOCBCHIABO<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LBMHKBKLILB OAFKIMPNEHK(Exception JNDFFCAMALC);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MJDHEAFMIOG MAPJJNALEGH(Exception JNDFFCAMALC);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public delegate string BDDEGIIGGJH<in T>(T JNDFFCAMALC) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public delegate int IPJAABMHJPM<in T>(T JNDFFCAMALC) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class NIDJNFGCBCL : GMOGLPEOKFM
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private delegate string POALEOMGLKK(Exception JNDFFCAMALC);

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private delegate int PJJMGJDOPPA(Exception JNDFFCAMALC);

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class AEHGLJFFFIH<T> : MBDPOBHEDJN<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class ADDAFEKCELA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public ADDAFEKCELA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
			internal string EECBDADPACO(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class AJPMKNCFIBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public BDDEGIIGGJH<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public AJPMKNCFIBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x46E9B10", Offset = "0x46E8D10", VA = "0x1846E9B10")]
			internal string IEPEEICPNOA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class EOBHNAKECKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public IPJAABMHJPM<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public EOBHNAKECKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x46E9B10", Offset = "0x46E8D10", VA = "0x1846E9B10")]
			internal int CNLFCHJANNB(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private readonly NIDJNFGCBCL PGFHJGFEGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private readonly Type DMACCNDMJHC;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x4E4B390", Offset = "0x4E4A590", VA = "0x184E4B390")]
		internal AEHGLJFFFIH(NIDJNFGCBCL PGFHJGFEGPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x4E4B000", Offset = "0x4E4A200", VA = "0x184E4B000", Slot = "4")]
		public void CPBDDIGJEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x4E4B290", Offset = "0x4E4A490", VA = "0x184E4B290", Slot = "5")]
		public MBDPOBHEDJN<T> PNFONGMGAAL(string GNLDHDANFJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x4E4B190", Offset = "0x4E4A390", VA = "0x184E4B190", Slot = "6")]
		public MBDPOBHEDJN<T> LDDNMLCCLFB(BDDEGIIGGJH<T> OONPOGFMBOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x4E4B030", Offset = "0x4E4A230", VA = "0x184E4B030", Slot = "7")]
		public MBDPOBHEDJN<T> GAGFGBEMJEH(int LKKKAKAHAFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x4E4B070", Offset = "0x4E4A270", VA = "0x184E4B070", Slot = "8")]
		public MBDPOBHEDJN<T> KOBLIPLLDGA(int LKKKAKAHAFI, IPJAABMHJPM<T> CPOPJJDEHKA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class BAFOMPNFNOL<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private bool FGNDKIELLOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly List<Type> ABGMCIOCJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private readonly Dictionary<Type, TVal> HJLPLMGDMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly Dictionary<Type, int> INCLCBAODON;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> LMLDKGJCNFI
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x60B9A20", Offset = "0x60B8C20", VA = "0x1860B9A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x60B9FF0", Offset = "0x60B91F0", VA = "0x1860B9FF0")]
		public BAFOMPNFNOL(Dictionary<Type, int> INCLCBAODON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x60B9DF0", Offset = "0x60B8FF0", VA = "0x1860B9DF0")]
		public void LHOMNBOIMGH(Type MHDODBCCAJB, TVal DIPIKNPCGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x60B99E0", Offset = "0x60B8BE0", VA = "0x1860B99E0")]
		public bool FALMCDECAMG(Type DMACCNDMJHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x60B9CC0", Offset = "0x60B8EC0", VA = "0x1860B9CC0")]
		public bool LGBKGMAOMHF(TVal KJIOHKMJAPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x4240F30", Offset = "0x4240130", VA = "0x184240F30")]
		public TVal AFHCIICHJIO(Type GDHKDBJPDLG)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x60B9C20", Offset = "0x60B8E20", VA = "0x1860B9C20")]
		[CompilerGenerated]
		private int HNGKAMFELHL(Type DFIHMNMBBLO, Type DHPENMNKJJH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class EMIODLFHAGH : IEnumerable<MJDHEAFMIOG>, IEnumerable, IEnumerator<MJDHEAFMIOG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private MJDHEAFMIOG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public NIDJNFGCBCL <>4__this;

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
		private IEnumerator<MJDHEAFMIOG> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private MJDHEAFMIOG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x420C580", Offset = "0x420B780", VA = "0x18420C580", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MJDHEAFMIOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x84C4790", Offset = "0x84C3990", VA = "0x1884C4790", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public EMIODLFHAGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x84C47E0", Offset = "0x84C39E0", VA = "0x1884C47E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x84C41D0", Offset = "0x84C33D0", VA = "0x1884C41D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x84C4130", Offset = "0x84C3330", VA = "0x1884C4130")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x84C4180", Offset = "0x84C3380", VA = "0x1884C4180")]
		private void GHEPLDLLGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x84C4740", Offset = "0x84C3940", VA = "0x1884C4740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x84C4680", Offset = "0x84C3880", VA = "0x1884C4680", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MJDHEAFMIOG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x84C4680", Offset = "0x84C3880", VA = "0x1884C4680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private static readonly MJDHEAFMIOG FLKFBLCPLAK;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private static readonly Dictionary<Type, int> LNFDIFIJIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private readonly HashSet<Type> NIKMNAOBAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private readonly BAFOMPNFNOL<int> KKAJPHOGDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly BAFOMPNFNOL<PJJMGJDOPPA> AGGKOMJKODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly BAFOMPNFNOL<POALEOMGLKK> GAIBLJCKDFC;

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x84D6100", Offset = "0x84D5300", VA = "0x1884D6100")]
	[MGCKGAIBEHC.PCMIGKEOIEO.MAPPJIPMPIK]
	internal static void CNMFKDBOHKK(FJCFOKJAKFO CBAPLOOHOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x84D74E0", Offset = "0x84D66E0", VA = "0x1884D74E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public NIDJNFGCBCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x3791E70", Offset = "0x3791070", VA = "0x183791E70", Slot = "4")]
	public MBDPOBHEDJN<T> LPOCBCHIABO<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x84D71A0", Offset = "0x84D63A0", VA = "0x1884D71A0", Slot = "5")]
	public LBMHKBKLILB OAFKIMPNEHK(Exception JNDFFCAMALC)
	{
		return default(LBMHKBKLILB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x84D6CA0", Offset = "0x84D5EA0", VA = "0x1884D6CA0", Slot = "6")]
	public MJDHEAFMIOG MAPJJNALEGH(Exception? JNDFFCAMALC)
	{
		return default(MJDHEAFMIOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x84D7230", Offset = "0x84D6430", VA = "0x1884D7230", Slot = "7")]
	[IteratorStateMachine(typeof(EMIODLFHAGH))]
	public IEnumerable<MJDHEAFMIOG> OODNGJMMDEO(Exception JNDFFCAMALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x84D72D0", Offset = "0x84D64D0", VA = "0x1884D72D0", Slot = "8")]
	public string PFHKOOJCCJA(Exception? JNDFFCAMALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x84D6EA0", Offset = "0x84D60A0", VA = "0x1884D6EA0")]
	private string MCEOHHBCGLD(AggregateException APJCFPDNPNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x84D63C0", Offset = "0x84D55C0", VA = "0x1884D63C0")]
	private void EBAFFGBMKGE(Type DMACCNDMJHC, int LKKKAKAHAFI, PJJMGJDOPPA? BPOBPCLIMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x84D6170", Offset = "0x84D5370", VA = "0x1884D6170")]
	private void DJMGCPIMFKM(Type DMACCNDMJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x84D68F0", Offset = "0x84D5AF0", VA = "0x1884D68F0")]
	private void FCBBPOGDJMP(Type DMACCNDMJHC, POALEOMGLKK LNCGFLFHMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x84D6770", Offset = "0x84D5970", VA = "0x1884D6770")]
	private static int EHGKBBOINAL(Type DMACCNDMJHC, Dictionary<Type, int> INCLCBAODON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F540", Offset = "0x3B5E740", VA = "0x183B5F540")]
	private static bool DNHAPDHGOFH<TVal>(BAFOMPNFNOL<TVal> LMKJLPPFOFC, Type DMACCNDMJHC, [Out] TVal KJIOHKMJAPE) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x84D6BC0", Offset = "0x84D5DC0", VA = "0x1884D6BC0")]
	[CompilerGenerated]
	internal static int LJFDJBHEKJO(Type FIOGHBKAEBC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public struct LBMHKBKLILB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public readonly MJDHEAFMIOG FJJNPHLLEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public readonly string MJEOKMFGLKP;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x84CEB20", Offset = "0x84CDD20", VA = "0x1884CEB20")]
	public LBMHKBKLILB(string GFDMLONIMPO, MJDHEAFMIOG LKKKAKAHAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x84CEA80", Offset = "0x84CDC80", VA = "0x1884CEA80")]
	public string HMEEGPBEKNP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public class GFDGEADJOLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private readonly PGCLBGKNLGG MKDKHOBDMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	private string AFBKDMLIALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	private long? GGFKMNBGLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private long? DLMDBEHPAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private long? HOCOEFHLJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private string DFPLEDCDFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private HIBEIMPBEBE CJOEOEIKJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private long? KFODOKCJEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private bool PAKJIGNKAAM;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string IBIHCCGMADH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long JDCBOAOKBHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x84C7B50", Offset = "0x84C6D50", VA = "0x1884C7B50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long NGDBEAPLFFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x84C79B0", Offset = "0x84C6BB0", VA = "0x1884C79B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long EFLNHABNMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x84C7A50", Offset = "0x84C6C50", VA = "0x1884C7A50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string KJCPKOGBDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x84C7A10", Offset = "0x84C6C10", VA = "0x1884C7A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public HIBEIMPBEBE PICOODEAHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xDD9A20", Offset = "0xDD8C20", VA = "0x180DD9A20")]
		get
		{
			return default(HIBEIMPBEBE);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x84C7540", Offset = "0x84C6740", VA = "0x1884C7540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long MOBJICEOBML
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x84C7050", Offset = "0x84C6250", VA = "0x1884C7050")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x84C7BB0", Offset = "0x84C6DB0", VA = "0x1884C7BB0")]
	[UnityEngine.Scripting.Preserve]
	public GFDGEADJOLK([NGLIAOPBMFM(null)] PGCLBGKNLGG MKDKHOBDMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x84C6E00", Offset = "0x84C6000", VA = "0x1884C6E00")]
	private void CGIPBLKMKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x84C70B0", Offset = "0x84C62B0", VA = "0x1884C70B0")]
	public void DMBHAKGGPOL(long LADMAADOIBG, long OPILFBADOKA, [Optional] long? DCNFHIPJBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x84C7AB0", Offset = "0x84C6CB0", VA = "0x1884C7AB0")]
	public void PEBNCPPALJG(long DCNFHIPJBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x84C6D80", Offset = "0x84C5F80", VA = "0x1884C6D80")]
	public void CAANPHGMHIL(string NHABOIJNACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x84C7630", Offset = "0x84C6830", VA = "0x1884C7630")]
	public void JPLNIGFCPMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal class FBDJJJEGEAF : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct MFALKDNLMPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public AsyncTaskMethodBuilder<FBDLPCDKOKJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public FBDLPCDKOKJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public FBDJJJEGEAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter<GDABOMEIBEI.CGLGJNDHHHM<FBDLPCDKOKJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x84D17D0", Offset = "0x84D09D0", VA = "0x1884D17D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x84D1D10", Offset = "0x84D0F10", VA = "0x1884D1D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct PHHDLEGHMGK<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class FGAIENBLEHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public FBDLPCDKOKJ roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public FGAIENBLEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x84C63F0", Offset = "0x84C55F0", VA = "0x1884C63F0")]
		internal FBDLPCDKOKJ CBOBPHDCIDN(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct EBLNFGJDOBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public AsyncTaskMethodBuilder<GDABOMEIBEI.CGLGJNDHHHM<FBDLPCDKOKJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public FBDLPCDKOKJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public FBDJJJEGEAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private FEEGOJLLKAK <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private TaskAwaiter<GDABOMEIBEI.CGLGJNDHHHM<FBDLPCDKOKJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x84C23D0", Offset = "0x84C15D0", VA = "0x1884C23D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x84C29E0", Offset = "0x84C1BE0", VA = "0x1884C29E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct JMCBJOMLJBN<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public FBDJJJEGEAF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5076B20", Offset = "0x5075D20", VA = "0x185076B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x420CDD0", Offset = "0x420BFD0", VA = "0x18420CDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct EAOLADAMEJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public FBDJJJEGEAF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84C1F50", Offset = "0x84C1150", VA = "0x1884C1F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x84C2230", Offset = "0x84C1430", VA = "0x1884C2230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class LPFPCOBHCLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LPFPCOBHCLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x84D10B0", Offset = "0x84D02B0", VA = "0x1884D10B0")]
		internal object JKOCAHNLKKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x84D1110", Offset = "0x84D0310", VA = "0x1884D1110")]
		internal bool OHJFOIPDCID(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class MKGALOLMIJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public MKGALOLMIJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x84D4810", Offset = "0x84D3A10", VA = "0x1884D4810")]
		internal object BIOFICHIOBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class HNPNNMEBEFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HNPNNMEBEFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x84C9620", Offset = "0x84C8820", VA = "0x1884C9620")]
		internal object MONHABIANPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class JCCNGOMPNJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public JCCNGOMPNJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x84CC360", Offset = "0x84CB560", VA = "0x1884CC360")]
		internal object DBMEHFLADNC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class GPPKJDCGCNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public FBDJJJEGEAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GPPKJDCGCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x84C8C00", Offset = "0x84C7E00", VA = "0x1884C8C00")]
		internal object GCKHNOFKFEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private static readonly Guid AIPFFIJPKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public readonly LAHJPJCGMDC IBALOMCONOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private readonly GDABOMEIBEI LINICCBLBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private readonly OEHCLHIPBJL NCFBNFPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private readonly OEEIPIIFMJI OJGKKPLDBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private bool PPHABNDBEGA;

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x84C61C0", Offset = "0x84C53C0", VA = "0x1884C61C0")]
	public FBDJJJEGEAF(LAHJPJCGMDC LPBJFFLCJMN, GDABOMEIBEI LINICCBLBON, OEHCLHIPBJL NCFBNFPHDDJ, OEEIPIIFMJI OJGKKPLDBNG, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x84C50E0", Offset = "0x84C42E0", VA = "0x1884C50E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x84C50F0", Offset = "0x84C42F0", VA = "0x1884C50F0")]
	public void ECKHBMIKHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x84C5860", Offset = "0x84C4A60", VA = "0x1884C5860")]
	public void HOPKACPOJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x84C5C60", Offset = "0x84C4E60", VA = "0x1884C5C60")]
	public void KHNLGGHKAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x84C5210", Offset = "0x84C4410", VA = "0x1884C5210")]
	[AsyncStateMachine(typeof(MFALKDNLMPH))]
	internal Task<FBDLPCDKOKJ> FFIPHOKACGH(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, FBDLPCDKOKJ OIKJJICAEAA, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x39DA880", Offset = "0x39D9A80", VA = "0x1839DA880")]
	private static byte[] ILGHLGOLGDP<T>(T NPEJLHCJPAI) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x39DA210", Offset = "0x39D9410", VA = "0x1839DA210")]
	private static T BKHKDELEGOC<T>(MessageParser<T> IDEKOJMAAKB, byte[] NPEJLHCJPAI, T LGBMMPNMMGO) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x84C5D20", Offset = "0x84C4F20", VA = "0x1884C5D20")]
	[AsyncStateMachine(typeof(EBLNFGJDOBF))]
	private Task<GDABOMEIBEI.CGLGJNDHHHM<FBDLPCDKOKJ>> LOIKDHANPIL(FBDLPCDKOKJ OIKJJICAEAA, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x39DA360", Offset = "0x39D9560", VA = "0x1839DA360")]
	[AsyncStateMachine(typeof(JMCBJOMLJBN<>))]
	internal Task<T> FLABMJCDLJF<T>(CancellationToken CDMFGCJPANH, Func<CancellationToken, Task<T>> OELPIGIDDAN, int BGGIHPMAKAF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x84C54A0", Offset = "0x84C46A0", VA = "0x1884C54A0")]
	[AsyncStateMachine(typeof(EAOLADAMEJE))]
	internal Task FLABMJCDLJF(CancellationToken CDMFGCJPANH, Func<CancellationToken, Task> OELPIGIDDAN, int BGGIHPMAKAF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x84C5920", Offset = "0x84C4B20", VA = "0x1884C5920")]
	public BGGBJLOPHHL JBAIAJGKINP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x84C5E60", Offset = "0x84C5060", VA = "0x1884C5E60")]
	public MFFOHLEJHJD MNHHPHOFFHG([Optional] EIAPKNHOKAL PPEEEDLLJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x84C59A0", Offset = "0x84C4BA0", VA = "0x1884C59A0")]
	public OHGADGKJGCI JDIAGIBKJGL([Optional] KEPOMIIOHBM? EBHKLAMEJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x84C5EF0", Offset = "0x84C50F0", VA = "0x1884C5EF0")]
	public void PHOFGIJBEHL(Func<Guid, bool> DNGFAPFHJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x84C5750", Offset = "0x84C4950", VA = "0x1884C5750")]
	public void HJBGODOMIBN(Func<Guid, bool> LGPJGNKNJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x84C55D0", Offset = "0x84C47D0", VA = "0x1884C55D0")]
	public Guid HIFMMODDNKM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x84C6050", Offset = "0x84C5250", VA = "0x1884C6050")]
	public void PIDLPDNEKBP(Guid CLIJDFLEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x84C5370", Offset = "0x84C4570", VA = "0x1884C5370")]
	public void FKCPNBJIHOD(FBDLPCDKOKJ NBGJHCLLHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x84C4FD0", Offset = "0x84C41D0", VA = "0x1884C4FD0")]
	public void AODHEIHGBPN(string HCIMLNAAAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x39DA890", Offset = "0x39D9A90", VA = "0x1839DA890")]
	private T KBHKNANNLHL<T>(T KJIOHKMJAPE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x84C5C10", Offset = "0x84C4E10", VA = "0x1884C5C10")]
	public void KCCFDKOFLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x39DA5E0", Offset = "0x39D97E0", VA = "0x1839DA5E0")]
	[CompilerGenerated]
	internal static string ICJLFGHAOGJ<T>(byte[] DJMFMHNIFDE, int CLCGGINKCCG, PHHDLEGHMGK<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal sealed class DBMCIIJGHLI : LAHJPJCGMDC
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class GMEINENPEME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GMEINENPEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x84C87D0", Offset = "0x84C79D0", VA = "0x1884C87D0")]
		internal object GDFIBKODBPE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct IOAPPEJMOOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public DBMCIIJGHLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public FBDJJJEGEAF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private LPLCCKHEJAM <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private MFFOHLEJHJD <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private TaskAwaiter<GFLMKCMBFNN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x84CB400", Offset = "0x84CA600", VA = "0x1884CB400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x84CC300", Offset = "0x84CB500", VA = "0x1884CC300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct PDPENCJKBMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public DBMCIIJGHLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private TaskAwaiter<EAAMLCEDMMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x84D8270", Offset = "0x84D7470", VA = "0x1884D8270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A10", Offset = "0x84D7C10", VA = "0x1884D8A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct HEJMLDBMOHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public DBMCIIJGHLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<FLCIPAFBKAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x84C9050", Offset = "0x84C8250", VA = "0x1884C9050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x84C9360", Offset = "0x84C8560", VA = "0x1884C9360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class EGNMFHENLCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public LPLCCKHEJAM presence;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EGNMFHENLCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x84C34C0", Offset = "0x84C26C0", VA = "0x1884C34C0")]
		internal object JHBAADAJNEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private static readonly KEPOMIIOHBM EEJJLLMCMPH;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private static readonly KEPOMIIOHBM IAGPMLFHAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly LBIKBDECECI NGOELKBHDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly HPLNAENGEIP GHIFCAOPGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private readonly EIAPKNHOKAL PPEEEDLLJCI;

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x84C0F30", Offset = "0x84C0130", VA = "0x1884C0F30")]
	public DBMCIIJGHLI(LBIKBDECECI NGOELKBHDAI, HPLNAENGEIP GHIFCAOPGGO, Guid GHIHMOONOIF, AEHEGPIEOCE IKFFOMHBDLM, CGBDEFKMHHI FEECKACPEIG, EIAPKNHOKAL PPEEEDLLJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x84C0A30", Offset = "0x84BFC30", VA = "0x1884C0A30", Slot = "7")]
	[AsyncStateMachine(typeof(IOAPPEJMOOH))]
	protected override Task GPEIIEFODPC(FBDJJJEGEAF PCFNKCLPMOK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x84C0B80", Offset = "0x84BFD80", VA = "0x1884C0B80")]
	[AsyncStateMachine(typeof(PDPENCJKBMF))]
	private Task KMOIIAGGODH(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x84C0920", Offset = "0x84BFB20", VA = "0x1884C0920")]
	[AsyncStateMachine(typeof(HEJMLDBMOHK))]
	private Task<int> FBNFJKDDKEB(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x84C0C80", Offset = "0x84BFE80", VA = "0x1884C0C80")]
	private LPLCCKHEJAM OGLPAHCIAGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal class GJPMEAPLECE : LAHJPJCGMDC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct EDHEMBFILCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public GJPMEAPLECE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public FBDJJJEGEAF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private TaskAwaiter<FDACCKBMCMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x84C2A50", Offset = "0x84C1C50", VA = "0x1884C2A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x84C3400", Offset = "0x84C2600", VA = "0x1884C3400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private readonly int LMPNBPAGOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly CBBEGLFAAKE MFAEBMNCOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public readonly long NICOLNMBAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public readonly long IHEELIGPDMH;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public FDACCKBMCMP CPEMJCLAELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xA0E520", Offset = "0xA0D720", VA = "0x180A0E520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA0E400", Offset = "0xA0D600", VA = "0x180A0E400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x84C86A0", Offset = "0x84C78A0", VA = "0x1884C86A0")]
	public GJPMEAPLECE(Guid GHIHMOONOIF, AEHEGPIEOCE IKFFOMHBDLM, CGBDEFKMHHI FEECKACPEIG, int LMPNBPAGOCH, CBBEGLFAAKE MFAEBMNCOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x84C8580", Offset = "0x84C7780", VA = "0x1884C8580", Slot = "7")]
	[AsyncStateMachine(typeof(EDHEMBFILCA))]
	protected override Task GPEIIEFODPC(FBDJJJEGEAF PCFNKCLPMOK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal abstract class BBIOFHIIJHL : LAHJPJCGMDC
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class BMMKJNPGONG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public BBIOFHIIJHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public ABGHNPFLDKH playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BMMKJNPGONG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x84BE720", Offset = "0x84BD920", VA = "0x1884BE720")]
		internal Task DOGIMCFILGF(BGHCJGPGCNF<string>.IPAINGKGFDM postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x84BE760", Offset = "0x84BD960", VA = "0x1884BE760")]
		internal object ONGDOOHAEEJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct DAIBEFAPNGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public BBIOFHIIJHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public FBDJJJEGEAF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private BMMKJNPGONG <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x84BEFA0", Offset = "0x84BE1A0", VA = "0x1884BEFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x84BF8B0", Offset = "0x84BEAB0", VA = "0x1884BF8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct KOECPOPOEGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public ABGHNPFLDKH playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public BBIOFHIIJHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x84CD440", Offset = "0x84CC640", VA = "0x1884CD440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x84CD9F0", Offset = "0x84CCBF0", VA = "0x1884CD9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x84BD8C0", Offset = "0x84BCAC0", VA = "0x1884BD8C0")]
	public BBIOFHIIJHL(Guid GHIHMOONOIF, AEHEGPIEOCE IKFFOMHBDLM, CGBDEFKMHHI FEECKACPEIG, string KGABCHDNGPE, AIMFMPJJMCG JEMHLLLEHAD, bool KHGPMIBJDNI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x84BD780", Offset = "0x84BC980", VA = "0x1884BD780", Slot = "7")]
	[AsyncStateMachine(typeof(DAIBEFAPNGG))]
	protected override Task GPEIIEFODPC(FBDJJJEGEAF PCFNKCLPMOK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task GAJPFDMLCGG(FBDJJJEGEAF PCFNKCLPMOK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x84BD640", Offset = "0x84BC840", VA = "0x1884BD640")]
	[AsyncStateMachine(typeof(KOECPOPOEGO))]
	private Task EJDCMDEICAN(IDisposable PBPINJGKGLF, ABGHNPFLDKH MCPDHEOACKN, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal class HOBOAHGKKGP : LAHJPJCGMDC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct BFPAKMICDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public HOBOAHGKKGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public FBDJJJEGEAF operationContext;

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
		private TaskAwaiter<PEPAFJMLFCF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x84BE130", Offset = "0x84BD330", VA = "0x1884BE130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x84BE6C0", Offset = "0x84BD8C0", VA = "0x1884BE6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private readonly IDBHCDKMGJP LOAICONOLLD;

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x84C9890", Offset = "0x84C8A90", VA = "0x1884C9890")]
	public HOBOAHGKKGP(Guid GHIHMOONOIF, AEHEGPIEOCE IKFFOMHBDLM, CGBDEFKMHHI FEECKACPEIG, IDBHCDKMGJP LOAICONOLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x84C97B0", Offset = "0x84C89B0", VA = "0x1884C97B0", Slot = "6")]
	protected override string OOIDDHAJPDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x84C9690", Offset = "0x84C8890", VA = "0x1884C9690", Slot = "7")]
	[AsyncStateMachine(typeof(BFPAKMICDAA))]
	protected override Task GPEIIEFODPC(FBDJJJEGEAF PCFNKCLPMOK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal abstract class LAHJPJCGMDC : GPIKKJLGADI
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	public delegate Task HOHMGKOPCPC(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class DJIMFAEGODL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public LAHJPJCGMDC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DJIMFAEGODL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x84C18B0", Offset = "0x84C0AB0", VA = "0x1884C18B0")]
		internal Task OPEDODCBKMB(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class LDJLNPFAMJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public DJIMFAEGODL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LDJLNPFAMJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x84CEB40", Offset = "0x84CDD40", VA = "0x1884CEB40")]
		internal object PIPNGHDDPIM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct IEOGNDAJLLP : IAsyncStateMachine
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
		public LAHJPJCGMDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public Func<LAHJPJCGMDC, BGHCJGPGCNF<string>.IPAINGKGFDM, FBDJJJEGEAF> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private DJIMFAEGODL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private FBDJJJEGEAF <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter<FBDLPCDKOKJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x84C9C40", Offset = "0x84C8E40", VA = "0x1884C9C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x84CAED0", Offset = "0x84CA0D0", VA = "0x1884CAED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct MJEDOJMLMPN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x84D3D10", Offset = "0x84D2F10", VA = "0x1884D3D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x84D47B0", Offset = "0x84D39B0", VA = "0x1884D47B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct GPODCDHMNAA : IAsyncStateMachine
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
		public LAHJPJCGMDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x84C8840", Offset = "0x84C7A40", VA = "0x1884C8840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x84C8BA0", Offset = "0x84C7DA0", VA = "0x1884C8BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public readonly Guid BKBCBLBMHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public readonly ByteString LLGCFBBCHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public readonly CGBDEFKMHHI MPENDBDHMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	protected readonly string JCKDMNONKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	private readonly AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	private readonly bool KHGPMIBJDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly Queue<HOHMGKOPCPC> CMCABMOAEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private readonly OHEDPJJAEEG BCPMKJKJFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private readonly AIMFMPJJMCG JEMHLLLEHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private bool GNNBGBBPAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public HIBEIMPBEBE POGNIAENDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public HIBEIMPBEBE DJDCPBALNFB;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public AEHEGPIEOCE NCKGIDEPMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public FANFNGDGAHN ONPPLLOGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x84CE7F0", Offset = "0x84CD9F0", VA = "0x1884CE7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public FGBIFPHEHIH JHFEFNFLGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x84CE160", Offset = "0x84CD360", VA = "0x1884CE160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public BPFCLMEBPNG EEJBLGPIIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x84CDFF0", Offset = "0x84CD1F0", VA = "0x1884CDFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event NMDLEPKPHNK IPHDOGJCOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x84CDE30", Offset = "0x84CD030", VA = "0x1884CDE30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x84CDE50", Offset = "0x84CD050", VA = "0x1884CDE50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x84CE920", Offset = "0x84CDB20", VA = "0x1884CE920")]
	protected LAHJPJCGMDC(Guid GHIHMOONOIF, AEHEGPIEOCE IKFFOMHBDLM, CGBDEFKMHHI FEECKACPEIG, string KGABCHDNGPE, AIMFMPJJMCG JEMHLLLEHAD, bool KHGPMIBJDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x84CE8E0", Offset = "0x84CDAE0", VA = "0x1884CE8E0", Slot = "6")]
	protected virtual string OOIDDHAJPDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x84CDDD0", Offset = "0x84CCFD0", VA = "0x1884CDDD0")]
	public void BDHFACPJIPH(HOHMGKOPCPC GENBMGLCFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x84CE840", Offset = "0x84CDA40", VA = "0x1884CE840")]
	protected void NJBPNAEHAJN(float AGIIBANJIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x84CE3D0", Offset = "0x84CD5D0", VA = "0x1884CE3D0")]
	[AsyncStateMachine(typeof(IEOGNDAJLLP))]
	public Task JGHBEDNJLDN(CancellationToken FHBCOAHILMJ, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, [Optional] Func<LAHJPJCGMDC, BGHCJGPGCNF<string>.IPAINGKGFDM, FBDJJJEGEAF> FPLMEAPDKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x84CE640", Offset = "0x84CD840", VA = "0x1884CE640")]
	[AsyncStateMachine(typeof(MJEDOJMLMPN))]
	private static Task KKJFIIAMHND(Func<CancellationToken, Task> IMAHJOIMDMN, Func<CancellationToken, Task> EODFLGHFGHJ, CancellationToken CDMFGCJPANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x84CDE70", Offset = "0x84CD070", VA = "0x1884CDE70")]
	private void HEFAAKCMCNG(bool LPBBIEGNCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x84CE1B0", Offset = "0x84CD3B0", VA = "0x1884CE1B0")]
	private void JEGFJMOALAL(FBDJJJEGEAF PCFNKCLPMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task GPEIIEFODPC(FBDJJJEGEAF PCFNKCLPMOK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x84CE520", Offset = "0x84CD720", VA = "0x1884CE520")]
	[AsyncStateMachine(typeof(GPODCDHMNAA))]
	private Task JPIHNNHFNNP(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x84CE770", Offset = "0x84CD970", VA = "0x1884CE770")]
	public FBDLPCDKOKJ MPPEPPLLDCE(FEEGOJLLKAK GCJFHAMGHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x84CE070", Offset = "0x84CD270", VA = "0x1884CE070")]
	[CompilerGenerated]
	private Task HNADJKCDPIK(CancellationToken DACBPJEFOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x84CE860", Offset = "0x84CDA60", VA = "0x1884CE860")]
	[CompilerGenerated]
	private object OIHEHGHMKAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal sealed class HBIGHAHJEIL : BBIOFHIIJHL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct EJGNBHMKKPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public HBIGHAHJEIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public FBDJJJEGEAF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private BAILLPCCAKA <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private MFFOHLEJHJD <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x84C3600", Offset = "0x84C2800", VA = "0x1884C3600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x84C3D70", Offset = "0x84C2F70", VA = "0x1884C3D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly LBIKBDECECI IMFBJJFCFLP;

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x84C8FA0", Offset = "0x84C81A0", VA = "0x1884C8FA0")]
	public HBIGHAHJEIL(Guid GHIHMOONOIF, AEHEGPIEOCE IKFFOMHBDLM, LBIKBDECECI IMFBJJFCFLP, CGBDEFKMHHI FEECKACPEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x84C8E50", Offset = "0x84C8050", VA = "0x1884C8E50", Slot = "8")]
	[AsyncStateMachine(typeof(EJGNBHMKKPE))]
	protected override Task GAJPFDMLCGG(FBDJJJEGEAF PCFNKCLPMOK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal class ICPCCDFMFPJ : LAHJPJCGMDC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct MPEBIGBIDOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public ICPCCDFMFPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public FBDJJJEGEAF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private TaskAwaiter<PEPAFJMLFCF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x84D5CF0", Offset = "0x84D4EF0", VA = "0x1884D5CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x84D60A0", Offset = "0x84D52A0", VA = "0x1884D60A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private readonly string MKPOCKFFAHD;

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x84C9B90", Offset = "0x84C8D90", VA = "0x1884C9B90")]
	public ICPCCDFMFPJ(Guid GHIHMOONOIF, AEHEGPIEOCE IKFFOMHBDLM, CGBDEFKMHHI FEECKACPEIG, string MKPOCKFFAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x84C9A80", Offset = "0x84C8C80", VA = "0x1884C9A80", Slot = "7")]
	[AsyncStateMachine(typeof(MPEBIGBIDOF))]
	protected override Task GPEIIEFODPC(FBDJJJEGEAF PCFNKCLPMOK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal class DNCFFGGPGPI : BBIOFHIIJHL
{
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class COEFDLGMOJO
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
			public AsyncTaskMethodBuilder<FBDLPCDKOKJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			public COEFDLGMOJO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004AC")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			private TaskAwaiter<PEPAFJMLFCF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			private TaskAwaiter<FBDLPCDKOKJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x84D9780", Offset = "0x84D8980", VA = "0x1884D9780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0x84D9C70", Offset = "0x84D8E70", VA = "0x1884D9C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public DNCFFGGPGPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public OHGADGKJGCI serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public EDJHGEODNOP roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public BGGBJLOPHHL uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public NHGPKAMOGJM roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public COEFDLGMOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x84BEE80", Offset = "0x84BE080", VA = "0x1884BEE80")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<FBDLPCDKOKJ> MIJJBOCEODC(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct LKOEGKPJJON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public DNCFFGGPGPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public FBDJJJEGEAF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private COEFDLGMOJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private BAILLPCCAKA <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private MFFOHLEJHJD <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private FBDLPCDKOKJ <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter<FBDLPCDKOKJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x84D01D0", Offset = "0x84CF3D0", VA = "0x1884D01D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x84D1050", Offset = "0x84D0250", VA = "0x1884D1050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private static readonly KEPOMIIOHBM EEJJLLMCMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private readonly int FAJKMEHKDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	[CanBeNull]
	private readonly AJOEGJCHHHM JPGGEILHFHL;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x84C1EA0", Offset = "0x84C10A0", VA = "0x1884C1EA0")]
	public DNCFFGGPGPI(Guid GHIHMOONOIF, AEHEGPIEOCE IKFFOMHBDLM, int FAJKMEHKDDK, AJOEGJCHHHM JPGGEILHFHL, CGBDEFKMHHI FEECKACPEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x84C19E0", Offset = "0x84C0BE0", VA = "0x1884C19E0", Slot = "8")]
	[AsyncStateMachine(typeof(LKOEGKPJJON))]
	protected override Task GAJPFDMLCGG(FBDJJJEGEAF PCFNKCLPMOK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x84C1B20", Offset = "0x84C0D20", VA = "0x1884C1B20")]
	private void MLBHCIPBAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x84C1C20", Offset = "0x84C0E20", VA = "0x1884C1C20")]
	private void PFIAPFCDLGM(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, BAILLPCCAKA KABJBFJMJJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal class GHPKINLPLIH : LAHJPJCGMDC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct MMJILMBJBLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public GHPKINLPLIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private BAILLPCCAKA <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private FLCIPAFBKAP <currentRoomSave>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private HLHLINEFKHE<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TaskAwaiter<FLCIPAFBKAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TaskAwaiter<FDACCKBMCMP> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x84D4870", Offset = "0x84D3A70", VA = "0x1884D4870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x84D5C90", Offset = "0x84D4E90", VA = "0x1884D5C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private readonly int FAJKMEHKDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private readonly AJOEGJCHHHM JPGGEILHFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private Func<PEPAFJMLFCF, PEPAFJMLFCF> JKLOMGHGAEM;

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x84C84C0", Offset = "0x84C76C0", VA = "0x1884C84C0")]
	public GHPKINLPLIH(Guid GHIHMOONOIF, AEHEGPIEOCE IKFFOMHBDLM, int FAJKMEHKDDK, AJOEGJCHHHM JPGGEILHFHL, Func<PEPAFJMLFCF, PEPAFJMLFCF> JKLOMGHGAEM, CGBDEFKMHHI FEECKACPEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x84C8390", Offset = "0x84C7590", VA = "0x1884C8390", Slot = "7")]
	[AsyncStateMachine(typeof(MMJILMBJBLC))]
	protected override Task GPEIIEFODPC(FBDJJJEGEAF PCFNKCLPMOK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal abstract class HHGIPOOMMLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public readonly LAHJPJCGMDC IBALOMCONOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public readonly FBDJJJEGEAF CJKDGEINNNE;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public FANFNGDGAHN ONPPLLOGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x84C9570", Offset = "0x84C8770", VA = "0x1884C9570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public BPFCLMEBPNG EEJBLGPIIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x84C94E0", Offset = "0x84C86E0", VA = "0x1884C94E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x84C95C0", Offset = "0x84C87C0", VA = "0x1884C95C0")]
	protected HHGIPOOMMLP(FBDJJJEGEAF PCFNKCLPMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x84C93D0", Offset = "0x84C85D0", VA = "0x1884C93D0")]
	protected void AODHEIHGBPN(string HCIMLNAAAMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct LPNDEBNABPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public Dictionary<Guid, List<MNKAFBLBFBC>> EIFLPNAKJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public Dictionary<Guid, List<MNKAFBLBFBC>> FDIACLHEDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public Dictionary<Guid, List<MNKAFBLBFBC>> GLNHHBMPFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public List<Guid> HOIOFCDECDM;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x84D11D0", Offset = "0x84D03D0", VA = "0x1884D11D0")]
	public static LPNDEBNABPA AFHCIICHJIO(FANFNGDGAHN PLKEMCOOOMD, HIBEIMPBEBE EPOPNCBHMOG, IMGOPGMMMDH BBBFBFKEOJH)
	{
		return default(LPNDEBNABPA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct NJKNHMMDILK
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0")]
	public static NJKNHMMDILK DBJJOAFKEPP()
	{
		return default(NJKNHMMDILK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct CAGKJJGCDMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public readonly EAAMLCEDMMD PCKDNOKGHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public readonly EBAEPIOAJNM FDPCLNIOPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public readonly Guid? KNDLKPHHAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public readonly IReadOnlyCollection<MBKDIDMGHMN> DHIDOGAMPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public readonly IReadOnlyCollection<MBKDIDMGHMN> JBOPLHDOBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public readonly JENOKPCEBIE NDINKJMLNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public readonly JENOKPCEBIE AIMLLENJKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public readonly BIDCFCNHFIC JIFJLIOKGHB;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool NILDOEADGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x84BE7F0", Offset = "0x84BD9F0", VA = "0x1884BE7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x84BE880", Offset = "0x84BDA80", VA = "0x1884BE880")]
	public CAGKJJGCDMM(EAAMLCEDMMD PCKDNOKGHKJ, EBAEPIOAJNM FDPCLNIOPMG, Guid? KNDLKPHHAPO, IReadOnlyList<MBKDIDMGHMN> DHIDOGAMPDJ, IReadOnlyCollection<MBKDIDMGHMN> JBOPLHDOBPP, JENOKPCEBIE NDINKJMLNJN, JENOKPCEBIE AIMLLENJKOF, BIDCFCNHFIC JIFJLIOKGHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct LDLKJJMKKCF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private readonly FBDJJJEGEAF PCFNKCLPMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private readonly Guid CLIJDFLEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private bool LPBBIEGNCEB;

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x84CEC10", Offset = "0x84CDE10", VA = "0x1884CEC10")]
	public static LDLKJJMKKCF HIFMMODDNKM(FBDJJJEGEAF PCFNKCLPMOK)
	{
		return default(LDLKJJMKKCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x1226090", Offset = "0x1225290", VA = "0x181226090")]
	public void GOBMHLFHDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x84CEC00", Offset = "0x84CDE00", VA = "0x1884CEC00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x84CEF10", Offset = "0x84CE110", VA = "0x1884CEF10")]
	private LDLKJJMKKCF(FBDJJJEGEAF PCFNKCLPMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x84CECE0", Offset = "0x84CDEE0", VA = "0x1884CECE0")]
	private void PIDLPDNEKBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x84CEC40", Offset = "0x84CDE40", VA = "0x1884CEC40")]
	private Func<Guid, bool> JHPDHMGOKFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal class MFFOHLEJHJD : HHGIPOOMMLP, GPIKKJLGADI
{
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public delegate Task<HIBEIMPBEBE> NGHCNHKFJBJ(IMGOPGMMMDH CAIGHLKIDBF, KDLPAPBPGJJ IONOJOBPHFC, OHEDPJJAEEG HPONBKACHOH, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct NJEPHBNNEME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public LBIKBDECECI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private LDLKJJMKKCF <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter<FBDLPCDKOKJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x84ED7B0", Offset = "0x84EC9B0", VA = "0x1884ED7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x84EDF00", Offset = "0x84ED100", VA = "0x1884EDF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct KLBGJELHPOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public AsyncTaskMethodBuilder<FBDLPCDKOKJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public LBIKBDECECI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter<FBDLPCDKOKJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x84E9220", Offset = "0x84E8420", VA = "0x1884E9220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x84E9650", Offset = "0x84E8850", VA = "0x1884E9650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct GEOEKIBFCND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public LBIKBDECECI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x84E4E60", Offset = "0x84E4060", VA = "0x1884E4E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x84E5320", Offset = "0x84E4520", VA = "0x1884E5320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class PMBCFGGAHJN
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
			public AsyncTaskMethodBuilder<CAGKJJGCDMM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public PMBCFGGAHJN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			private CAGKJJGCDMM <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			private TaskAwaiter<HIBEIMPBEBE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			private TaskAwaiter<CAGKJJGCDMM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x84EF9B0", Offset = "0x84EEBB0", VA = "0x1884EF9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x84F0270", Offset = "0x84EF470", VA = "0x1884F0270", Slot = "5")]
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
			public AsyncTaskMethodBuilder<IMGOPGMMMDH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public PMBCFGGAHJN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			private IMGOPGMMMDH <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			private TaskAwaiter<HIBEIMPBEBE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			private TaskAwaiter<IMGOPGMMMDH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x84F02E0", Offset = "0x84EF4E0", VA = "0x1884F02E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x84F0930", Offset = "0x84EFB30", VA = "0x1884F0930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public LBIKBDECECI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public OHEDPJJAEEG preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public OHEDPJJAEEG downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public CAGKJJGCDMM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public OHEDPJJAEEG postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public IMGOPGMMMDH phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public OCAMMJABECJ.DKNFOGEIBIK <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public PMBCFGGAHJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x84EEB90", Offset = "0x84EDD90", VA = "0x1884EEB90")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<CAGKJJGCDMM> MDMGDEFFIEC(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x84EE9F0", Offset = "0x84EDBF0", VA = "0x1884EE9F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<IMGOPGMMMDH> CFOEGBJMPLH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x84EEB10", Offset = "0x84EDD10", VA = "0x1884EEB10")]
		internal void JCEIJMABKPM(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x84EECE0", Offset = "0x84EDEE0", VA = "0x1884EECE0")]
		internal Task NLFNNGIJADP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x84EEB50", Offset = "0x84EDD50", VA = "0x1884EEB50")]
		internal Task LHMCBGIMBNM(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct COBOHFINCMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public LBIKBDECECI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private PMBCFGGAHJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private TaskAwaiter<CAGKJJGCDMM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private TaskAwaiter<IMGOPGMMMDH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x84DF0D0", Offset = "0x84DE2D0", VA = "0x1884DF0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x84DFD80", Offset = "0x84DEF80", VA = "0x1884DFD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct EBEEMALFHDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public IMGOPGMMMDH phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public OHEDPJJAEEG postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private TaskAwaiter<HIBEIMPBEBE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private KDLPAPBPGJJ <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x84E0620", Offset = "0x84DF820", VA = "0x1884E0620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x84E1480", Offset = "0x84E0680", VA = "0x1884E1480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct GBHPAEHMKLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x84E4620", Offset = "0x84E3820", VA = "0x1884E4620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x84E4E00", Offset = "0x84E4000", VA = "0x1884E4E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct AJLLEPPPMBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public OHEDPJJAEEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private TaskAwaiter<HIBEIMPBEBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x84DAB00", Offset = "0x84D9D00", VA = "0x1884DAB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x84DB340", Offset = "0x84DA540", VA = "0x1884DB340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct JPDPHNPNMFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public AsyncTaskMethodBuilder<HIBEIMPBEBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public OHEDPJJAEEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<HIBEIMPBEBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x84E7600", Offset = "0x84E6800", VA = "0x1884E7600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x84E85C0", Offset = "0x84E77C0", VA = "0x1884E85C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct NGMDNPNGLNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public AsyncTaskMethodBuilder<HIBEIMPBEBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public OHEDPJJAEEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public KDLPAPBPGJJ timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private TaskAwaiter<HIBEIMPBEBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x84EC630", Offset = "0x84EB830", VA = "0x1884EC630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x84ED740", Offset = "0x84EC940", VA = "0x1884ED740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct KHGDIEMCMKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public AsyncTaskMethodBuilder<HIBEIMPBEBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public HIBEIMPBEBE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public OHEDPJJAEEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public IMGOPGMMMDH deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private TaskAwaiter<HIBEIMPBEBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x84E8630", Offset = "0x84E7830", VA = "0x1884E8630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x84E8890", Offset = "0x84E7A90", VA = "0x1884E8890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class BCOEIJCBCEI
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
			public AsyncTaskMethodBuilder<HIBEIMPBEBE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			public BCOEIJCBCEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			private BKCBFFDELCF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			private TaskAwaiter<HIBEIMPBEBE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x84F09A0", Offset = "0x84EFBA0", VA = "0x1884F09A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x84F0FC0", Offset = "0x84F01C0", VA = "0x1884F0FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public OHEDPJJAEEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public NGHCNHKFJBJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public KDLPAPBPGJJ timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public HIBEIMPBEBE originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BCOEIJCBCEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x84DBA70", Offset = "0x84DAC70", VA = "0x1884DBA70")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<HIBEIMPBEBE> HBJHKAJGHPF(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct CEGNEKODBEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public AsyncTaskMethodBuilder<HIBEIMPBEBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public OHEDPJJAEEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public NGHCNHKFJBJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public KDLPAPBPGJJ timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private TaskAwaiter<HIBEIMPBEBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x84DE8C0", Offset = "0x84DDAC0", VA = "0x1884DE8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x84DEDE0", Offset = "0x84DDFE0", VA = "0x1884DEDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct BOOGLEBFANH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public OHEDPJJAEEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private HIBEIMPBEBE <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private IEnumerator<HIBEIMPBEBE> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private TaskAwaiter<HIBEIMPBEBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x84DDB10", Offset = "0x84DCD10", VA = "0x1884DDB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x84DE070", Offset = "0x84DD270", VA = "0x1884DE070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct DGCFDGIFPPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x84E02D0", Offset = "0x84DF4D0", VA = "0x1884E02D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x84E05C0", Offset = "0x84DF7C0", VA = "0x1884E05C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct CFGCAPOHHEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x84DEE50", Offset = "0x84DE050", VA = "0x1884DEE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x84DF070", Offset = "0x84DE270", VA = "0x1884DF070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class NPGPAAIFKFC
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
			public AsyncTaskMethodBuilder<HIBEIMPBEBE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			public NPGPAAIFKFC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public IMGOPGMMMDH data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public OHEDPJJAEEG progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private TaskAwaiter<HIBEIMPBEBE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			private TaskAwaiter<CJEPKMLCMLN> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x84F1030", Offset = "0x84F0230", VA = "0x1884F1030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x84F1B00", Offset = "0x84F0D00", VA = "0x1884F1B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public CCGDMOADANF mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NPGPAAIFKFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x84EDF60", Offset = "0x84ED160", VA = "0x1884EDF60")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<HIBEIMPBEBE> FAPNADKICFH(IMGOPGMMMDH data, KDLPAPBPGJJ _, OHEDPJJAEEG progressTracker, BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct BGPFBFCIPHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public IMGOPGMMMDH phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public OHEDPJJAEEG postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private NPGPAAIFKFC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private KDLPAPBPGJJ <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter<HIBEIMPBEBE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x84DBB90", Offset = "0x84DAD90", VA = "0x1884DBB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x84DC9E0", Offset = "0x84DBBE0", VA = "0x1884DC9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct LKBEANNBLHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x84EB560", Offset = "0x84EA760", VA = "0x1884EB560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x84EB960", Offset = "0x84EAB60", VA = "0x1884EB960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct KHPDBCOKDBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder<HIBEIMPBEBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public MFFOHLEJHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public OHEDPJJAEEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private TaskAwaiter<HIBEIMPBEBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x84E8900", Offset = "0x84E7B00", VA = "0x1884E8900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x84E8F20", Offset = "0x84E8120", VA = "0x1884E8F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private readonly JPIJMPDMIDF HBJBCIDGIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private readonly JPIJMPDMIDF CBIFNLNEDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private readonly GFDGEADJOLK DJAEFDPEFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private readonly CJHEKMMKKMB DOOENKGLIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private readonly IFDEAGGIAIF DCNLCHOLCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private ProfilerCounterValue<int> PALDEMNNBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private readonly DHHHLMIJLMK CCFLLHJMEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private readonly EIAPKNHOKAL PPEEEDLLJCI;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private AEHEGPIEOCE NCKGIDEPMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x84D2700", Offset = "0x84D1900", VA = "0x1884D2700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event NMDLEPKPHNK IPHDOGJCOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x84D1FF0", Offset = "0x84D11F0", VA = "0x1884D1FF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x84D23E0", Offset = "0x84D15E0", VA = "0x1884D23E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x84D3940", Offset = "0x84D2B40", VA = "0x1884D3940")]
	public MFFOHLEJHJD(FBDJJJEGEAF PCFNKCLPMOK, EIAPKNHOKAL PPEEEDLLJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x84D2D90", Offset = "0x84D1F90", VA = "0x1884D2D90")]
	[AsyncStateMachine(typeof(NJEPHBNNEME))]
	public Task JDAOMMPDCNH(LBIKBDECECI IKFDGIFGHKP, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x84D35A0", Offset = "0x84D27A0", VA = "0x1884D35A0")]
	[AsyncStateMachine(typeof(KLBGJELHPOA))]
	private Task<FBDLPCDKOKJ> OBGCMKLHLDJ(LBIKBDECECI IKFDGIFGHKP, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x84D2010", Offset = "0x84D1210", VA = "0x1884D2010")]
	[AsyncStateMachine(typeof(GEOEKIBFCND))]
	private Task DCECDIHFNAF(LBIKBDECECI IKFDGIFGHKP, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x84D2730", Offset = "0x84D1930", VA = "0x1884D2730")]
	[AsyncStateMachine(typeof(COBOHFINCMO))]
	private Task HOMFIKAMAGI(LBIKBDECECI IKFDGIFGHKP, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken IHAKCBJECHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x84D2460", Offset = "0x84D1660", VA = "0x1884D2460")]
	[AsyncStateMachine(typeof(EBEEMALFHDF))]
	private Task GINLHMIDCLF(IMGOPGMMMDH LKEJMMPAILA, OHEDPJJAEEG MKMEAENEEAJ, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken LDIOKJKBOIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x84D2150", Offset = "0x84D1350", VA = "0x1884D2150")]
	[AsyncStateMachine(typeof(GBHPAEHMKLM))]
	private Task EBGPPCOBGAM(BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x84D3330", Offset = "0x84D2530", VA = "0x1884D3330")]
	[AsyncStateMachine(typeof(AJLLEPPPMBG))]
	private Task MGJGMGBKGLO(IMGOPGMMMDH CAIGHLKIDBF, OHEDPJJAEEG HPONBKACHOH, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x84D1E50", Offset = "0x84D1050", VA = "0x1884D1E50")]
	[AsyncStateMachine(typeof(JPDPHNPNMFK))]
	private Task<HIBEIMPBEBE> BEDEHPONJAH(IMGOPGMMMDH CAIGHLKIDBF, KDLPAPBPGJJ IFKPJKKPEDL, OHEDPJJAEEG HPONBKACHOH, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x84D2260", Offset = "0x84D1460", VA = "0x1884D2260")]
	[AsyncStateMachine(typeof(NGMDNPNGLNL))]
	private Task<HIBEIMPBEBE> EHIBOFAGHPL(IMGOPGMMMDH CAIGHLKIDBF, KDLPAPBPGJJ IFKPJKKPEDL, OHEDPJJAEEG HPONBKACHOH, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x84D2940", Offset = "0x84D1B40", VA = "0x1884D2940")]
	[AsyncStateMachine(typeof(KHGDIEMCMKP))]
	private Task<HIBEIMPBEBE> INIHKPNABHB(HIBEIMPBEBE EPOPNCBHMOG, IMGOPGMMMDH BBBFBFKEOJH, OHEDPJJAEEG HPONBKACHOH, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ, bool LLFMONHBHMI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x84D31C0", Offset = "0x84D23C0", VA = "0x1884D31C0")]
	private bool KKKMKFOPPLC(IMGOPGMMMDH LKEJMMPAILA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x84D3030", Offset = "0x84D2230", VA = "0x1884D3030")]
	[AsyncStateMachine(typeof(CEGNEKODBEL))]
	protected Task<HIBEIMPBEBE> KHKINHKIIBF(IMGOPGMMMDH CAIGHLKIDBF, KDLPAPBPGJJ IFKPJKKPEDL, OHEDPJJAEEG HPONBKACHOH, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ, NGHCNHKFJBJ GOLCGIPLAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x84D2EE0", Offset = "0x84D20E0", VA = "0x1884D2EE0")]
	[AsyncStateMachine(typeof(BOOGLEBFANH))]
	private Task KFODHMEOKPG(IMGOPGMMMDH CAIGHLKIDBF, OHEDPJJAEEG HPONBKACHOH, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x84D2870", Offset = "0x84D1A70", VA = "0x1884D2870")]
	private void HONMFFDJLDN(HIBEIMPBEBE HJNJAGMMLFG, OHEDPJJAEEG HPONBKACHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x84D2420", Offset = "0x84D1620", VA = "0x1884D2420")]
	private void GFPLPJJAGKL(HIBEIMPBEBE FAPBLLDHGAN, [Out] HIBEIMPBEBE EDNBLFOBBPI, [Out] HIBEIMPBEBE PCLPOFMEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x84D28E0", Offset = "0x84D1AE0", VA = "0x1884D28E0")]
	private Task<CAGKJJGCDMM> IGFHIDLMNLL(LBIKBDECECI IKFDGIFGHKP, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x84D1FB0", Offset = "0x84D11B0", VA = "0x1884D1FB0")]
	private Task<IMGOPGMMMDH> BIIANNOLHDP(CAGKJJGCDMM CAIGHLKIDBF, OCAMMJABECJ.DKNFOGEIBIK AEDDOKNLOFP, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x84D2AC0", Offset = "0x84D1CC0", VA = "0x1884D2AC0")]
	[AsyncStateMachine(typeof(DGCFDGIFPPB))]
	private Task IOFIKICPMBB(IMGOPGMMMDH CAIGHLKIDBF, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ, bool MPGANFMLKKI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x84D3700", Offset = "0x84D2900", VA = "0x1884D3700")]
	[AsyncStateMachine(typeof(CFGCAPOHHEJ))]
	private Task ODADHHMBLEE(IMGOPGMMMDH CAIGHLKIDBF, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x84D3300", Offset = "0x84D2500", VA = "0x1884D3300")]
	private Task LNCBGNEBLKG(IMGOPGMMMDH CAIGHLKIDBF, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x84D2920", Offset = "0x84D1B20", VA = "0x1884D2920")]
	private Task ILGDOLKNOIA(IMGOPGMMMDH CAIGHLKIDBF, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x84D28C0", Offset = "0x84D1AC0", VA = "0x1884D28C0")]
	private Task HPDFBMILHLF(IMGOPGMMMDH CAIGHLKIDBF, KDLPAPBPGJJ IFKPJKKPEDL, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x84D1E30", Offset = "0x84D1030", VA = "0x1884D1E30")]
	private Task APEBFIPEIHK(IMGOPGMMMDH CAIGHLKIDBF, KDLPAPBPGJJ IFKPJKKPEDL, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x84D37F0", Offset = "0x84D29F0", VA = "0x1884D37F0")]
	private static Task PENOPCCKFAM(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x84D2400", Offset = "0x84D1600", VA = "0x1884D2400")]
	private Task FLINKLFOADN(IMGOPGMMMDH CAIGHLKIDBF, KDLPAPBPGJJ IFKPJKKPEDL, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x84D2C10", Offset = "0x84D1E10", VA = "0x1884D2C10")]
	private Task JCBKAEKINLE(IMGOPGMMMDH CAIGHLKIDBF, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x84D32B0", Offset = "0x84D24B0", VA = "0x1884D32B0")]
	private void LHICFFMIFFB(LBIKBDECECI IKFDGIFGHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x84D1D80", Offset = "0x84D0F80", VA = "0x1884D1D80")]
	public void AKEADENPIFI(long DCNFHIPJBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void NBMFAALCGJH(EAAMLCEDMMD PCKDNOKGHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x84D25B0", Offset = "0x84D17B0", VA = "0x1884D25B0")]
	[AsyncStateMachine(typeof(BGPFBFCIPHM))]
	private Task GJIGICNJPCI(IMGOPGMMMDH LKEJMMPAILA, OHEDPJJAEEG MKMEAENEEAJ, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken LDIOKJKBOIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x84D3800", Offset = "0x84D2A00", VA = "0x1884D3800")]
	[AsyncStateMachine(typeof(LKBEANNBLHN))]
	private Task PNGKHJBKOGC(IMGOPGMMMDH CAIGHLKIDBF, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x84D3480", Offset = "0x84D2680", VA = "0x1884D3480")]
	private static KPOKEHFKHFL NDDKCABEPJP(IMGOPGMMMDH BBBFBFKEOJH)
	{
		return default(KPOKEHFKHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x84D2C30", Offset = "0x84D1E30", VA = "0x1884D2C30")]
	[AsyncStateMachine(typeof(KHPDBCOKDBN))]
	private Task<HIBEIMPBEBE> JCHFNBLJJOC(IMGOPGMMMDH CAIGHLKIDBF, KDLPAPBPGJJ IFKPJKKPEDL, OHEDPJJAEEG HPONBKACHOH, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private void ECNCMNOHOGD(HIBEIMPBEBE EHLGPPLJMPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct LLNCKEPFAOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	private IMGOPGMMMDH CAIGHLKIDBF;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private FANFNGDGAHN ONPPLLOGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x84EBCC0", Offset = "0x84EAEC0", VA = "0x1884EBCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x84EB9C0", Offset = "0x84EABC0", VA = "0x1884EB9C0")]
	public static Task JGHBEDNJLDN(AEHEGPIEOCE IKFFOMHBDLM, IMGOPGMMMDH CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x84EBAA0", Offset = "0x84EACA0", VA = "0x1884EBAA0")]
	private void JGHBEDNJLDN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct HLMDNHENHBC
{
	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x84E5C00", Offset = "0x84E4E00", VA = "0x1884E5C00")]
	public static Task JGHBEDNJLDN(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct IDPCAJJPCPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct AIKGJLEPDIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public FBDJJJEGEAF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x84DA570", Offset = "0x84D9770", VA = "0x1884DA570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x84DAAA0", Offset = "0x84D9CA0", VA = "0x1884DAAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x84E5E00", Offset = "0x84E5000", VA = "0x1884E5E00")]
	[AsyncStateMachine(typeof(AIKGJLEPDIF))]
	public static Task JGHBEDNJLDN(FBDJJJEGEAF PCFNKCLPMOK, IMGOPGMMMDH CAIGHLKIDBF, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct JLFNNAGLIMG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct KMCHEJPNBGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public FBDJJJEGEAF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public KDLPAPBPGJJ timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private AEHEGPIEOCE <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private FANFNGDGAHN <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private HIBEIMPBEBE <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private BKCBFFDELCF <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private List<(PersistenceView, IHCKNOKFLCP)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private IHCKNOKFLCP <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x84E96C0", Offset = "0x84E88C0", VA = "0x1884E96C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x84EA390", Offset = "0x84E9590", VA = "0x1884EA390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x84E72C0", Offset = "0x84E64C0", VA = "0x1884E72C0")]
	[AsyncStateMachine(typeof(KMCHEJPNBGF))]
	public static Task JGHBEDNJLDN(FBDJJJEGEAF PCFNKCLPMOK, IMGOPGMMMDH CAIGHLKIDBF, KDLPAPBPGJJ IFKPJKKPEDL, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x84E7410", Offset = "0x84E6610", VA = "0x1884E7410")]
	private static void JILDBJKFBDN(PersistenceView PEGCLJNJBJG, IHCKNOKFLCP ABECEAAIGGD, IMGOPGMMMDH CAIGHLKIDBF, HIBEIMPBEBE EPOPNCBHMOG, bool DABEAMOFNJO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct PLOMAFCGEEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct OEMOIDDEOFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public AEHEGPIEOCE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private BKCBFFDELCF <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x84EE250", Offset = "0x84ED450", VA = "0x1884EE250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x84EE870", Offset = "0x84EDA70", VA = "0x1884EE870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x84EE8D0", Offset = "0x84EDAD0", VA = "0x1884EE8D0")]
	[AsyncStateMachine(typeof(OEMOIDDEOFB))]
	public static Task JGHBEDNJLDN(AEHEGPIEOCE IKFFOMHBDLM, IMGOPGMMMDH CAIGHLKIDBF, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct BOBJNMNJHCK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct POIFNKFLHIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public AEHEGPIEOCE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public FBDJJJEGEAF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x84EED20", Offset = "0x84EDF20", VA = "0x1884EED20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x84EEF30", Offset = "0x84EE130", VA = "0x1884EEF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class HNPNFPFPHEJ
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
			public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005EE")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005EF")]
			public HNPNFPFPHEJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F0")]
			private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x84F1B70", Offset = "0x84F0D70", VA = "0x1884F1B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x84F1F00", Offset = "0x84F1100", VA = "0x1884F1F00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HNPNFPFPHEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x84E5CE0", Offset = "0x84E4EE0", VA = "0x1884E5CE0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task GDKNONECNKM(BGHCJGPGCNF<string>.IPAINGKGFDM timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct EDJILAGCBHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public BOBJNMNJHCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private BKCBFFDELCF <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private TaskAwaiter<FBDLPCDKOKJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x84E14E0", Offset = "0x84E06E0", VA = "0x1884E14E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x84E20F0", Offset = "0x84E12F0", VA = "0x1884E20F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class OAEPDKHHEMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public MGNNNNPADNA version;

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
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public OAEPDKHHEMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x84EE170", Offset = "0x84ED370", VA = "0x1884EE170")]
		internal object JBHCIFOGBED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x84EE0C0", Offset = "0x84ED2C0", VA = "0x1884EE0C0")]
		internal object GDBAHLFCFBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private IMGOPGMMMDH CAIGHLKIDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private FBDJJJEGEAF PCFNKCLPMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private bool MPGANFMLKKI;

	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private static readonly ByteString OPAMJBMEMIK;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private FANFNGDGAHN ONPPLLOGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x84DDA30", Offset = "0x84DCC30", VA = "0x1884DDA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private BPFCLMEBPNG EEJBLGPIIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x84DD710", Offset = "0x84DC910", VA = "0x1884DD710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x84DD7B0", Offset = "0x84DC9B0", VA = "0x1884DD7B0")]
	[AsyncStateMachine(typeof(POIFNKFLHIO))]
	public static Task JGHBEDNJLDN(AEHEGPIEOCE IKFFOMHBDLM, IMGOPGMMMDH CAIGHLKIDBF, FBDJJJEGEAF PCFNKCLPMOK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ, bool MPGANFMLKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x84DD900", Offset = "0x84DCB00", VA = "0x1884DD900")]
	[AsyncStateMachine(typeof(EDJILAGCBHC))]
	private Task JGHBEDNJLDN(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x84DCF40", Offset = "0x84DC140", VA = "0x1884DCF40")]
	private void HGJENAHOABN([NotNull] OJIMHFCMHLE FPHEFLPLCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x84DCF00", Offset = "0x84DC100", VA = "0x1884DCF00")]
	private bool BLFPOOANLHF(MGNNNNPADNA EPCDIDIGEAG, OJIMHFCMHLE FPHEFLPLCMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct GGIEBNIMBCO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct FEFHEHBHHHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public AsyncTaskMethodBuilder<IMGOPGMMMDH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public GGIEBNIMBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public OCAMMJABECJ.DKNFOGEIBIK downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private TaskAwaiter<IReadOnlyCollection<MBKDIDMGHMN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private TaskAwaiter<(DJNAMIFBMIO<ENJOOAGPMBD, DCJPFEGHGPF>, DJNAMIFBMIO<BCCCDAHDJFG<OJIMHFCMHLE>, DCJPFEGHGPF>, DJNAMIFBMIO<BCCCDAHDJFG<KLFAJJACBNI>, DCJPFEGHGPF>, DJNAMIFBMIO<BCCCDAHDJFG<IEnumerable<KKEGNBCFCEE>>, DCJPFEGHGPF>, DJNAMIFBMIO<BCCCDAHDJFG<BODMDNMFLKL>, DCJPFEGHGPF>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x84E3440", Offset = "0x84E2640", VA = "0x1884E3440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x84E4220", Offset = "0x84E3420", VA = "0x1884E4220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct AOGCCJGIOCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<ENJOOAGPMBD, DCJPFEGHGPF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public GGIEBNIMBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public IReadOnlyCollection<MBKDIDMGHMN> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public IReadOnlyCollection<MBKDIDMGHMN> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public OCAMMJABECJ.DKNFOGEIBIK downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private TaskAwaiter<DJNAMIFBMIO<ENJOOAGPMBD, DCJPFEGHGPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x84DB3A0", Offset = "0x84DA5A0", VA = "0x1884DB3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x84DBA00", Offset = "0x84DAC00", VA = "0x1884DBA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000601")]
	private OMHLEEGPNEH<JENOKPCEBIE, KLFAJJACBNI> GJODHBGNKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	private OMHLEEGPNEH<JENOKPCEBIE, OJIMHFCMHLE> FLKBCDLBDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private OMHLEEGPNEH<BIDCFCNHFIC, IEnumerable<KKEGNBCFCEE>> FGBGFGEDFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private OMHLEEGPNEH<long, BODMDNMFLKL> BLADPAJBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private ODKGACJINAN FLAKGMJIPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private EAAMLCEDMMD PCKDNOKGHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private EBAEPIOAJNM FDPCLNIOPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private Guid? KNDLKPHHAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private IReadOnlyCollection<MBKDIDMGHMN> DHIDOGAMPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private Task<IReadOnlyCollection<MBKDIDMGHMN>> LEALCICKKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private JENOKPCEBIE NDINKJMLNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private JENOKPCEBIE AIMLLENJKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private JENOKPCEBIE? CGFKAMBJHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private BIDCFCNHFIC JIFJLIOKGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x84E5380", Offset = "0x84E4580", VA = "0x1884E5380")]
	public static Task<IMGOPGMMMDH> CJBGJMMBAIB(AEHEGPIEOCE IKFFOMHBDLM, [In] CAGKJJGCDMM CAIGHLKIDBF, OCAMMJABECJ.DKNFOGEIBIK AEDDOKNLOFP, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x84E5A50", Offset = "0x84E4C50", VA = "0x1884E5A50")]
	[AsyncStateMachine(typeof(FEFHEHBHHHC))]
	private Task<IMGOPGMMMDH> JGHBEDNJLDN(OCAMMJABECJ.DKNFOGEIBIK AEDDOKNLOFP, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x84E5820", Offset = "0x84E4A20", VA = "0x1884E5820")]
	[AsyncStateMachine(typeof(AOGCCJGIOCM))]
	private Task<DJNAMIFBMIO<ENJOOAGPMBD, DCJPFEGHGPF>> FCJLHBMMDMJ(Guid? KNDLKPHHAPO, IReadOnlyCollection<MBKDIDMGHMN> DHIDOGAMPDJ, IReadOnlyCollection<MBKDIDMGHMN> JBOPLHDOBPP, long? LADMAADOIBG, long? JAFHDCNJHEA, OCAMMJABECJ.DKNFOGEIBIK AEDDOKNLOFP, BGHCJGPGCNF<string>.IPAINGKGFDM OCEFOLBGLIA, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct IMIHAFHOFOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct BHBCOHFFANP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public AsyncTaskMethodBuilder<CAGKJJGCDMM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public IMIHAFHOFOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private TaskAwaiter<CAGKJJGCDMM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x84DCA40", Offset = "0x84DBC40", VA = "0x1884DCA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x84DCE90", Offset = "0x84DC090", VA = "0x1884DCE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct DCLDEOBMBPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public AsyncTaskMethodBuilder<CAGKJJGCDMM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public IMIHAFHOFOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private TaskAwaiter<CAGKJJGCDMM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x84DFDE0", Offset = "0x84DEFE0", VA = "0x1884DFDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x84E0260", Offset = "0x84DF460", VA = "0x1884E0260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class EKCBLELPBJB
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
			public EKCBLELPBJB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			private TaskAwaiter<OGNBBNBFGHI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			private TaskAwaiter<FLCIPAFBKAP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x84EEF90", Offset = "0x84EE190", VA = "0x1884EEF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x84EF950", Offset = "0x84EEB50", VA = "0x1884EF950", Slot = "5")]
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
		public DHDJMPADGJE roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public FANFNGDGAHN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public JENOKPCEBIE superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public JENOKPCEBIE subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public IReadOnlyList<MBKDIDMGHMN> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public IReadOnlyList<MBKDIDMGHMN> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public EAAMLCEDMMD roomDetails;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EKCBLELPBJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xECEF10", Offset = "0xECE110", VA = "0x180ECEF10")]
		internal bool OJIMLEFBNPC(EBAEPIOAJNM sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x84E3370", Offset = "0x84E2570", VA = "0x1884E3370")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task MPNKACMCPKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x84E3170", Offset = "0x84E2370", VA = "0x1884E3170")]
		internal Task<BIDCFCNHFIC> MADOCAMOGMG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct EIOPPJPJBHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public AsyncTaskMethodBuilder<CAGKJJGCDMM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public DHDJMPADGJE roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public FANFNGDGAHN callbacks;

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
		public JENOKPCEBIE superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private EKCBLELPBJB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private EBAEPIOAJNM <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private Task<BIDCFCNHFIC> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private TaskAwaiter<EAAMLCEDMMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private TaskAwaiter<BIDCFCNHFIC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x84E2150", Offset = "0x84E1350", VA = "0x1884E2150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x84E3100", Offset = "0x84E2300", VA = "0x1884E3100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000627")]
	private FANFNGDGAHN PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	private GFDGEADJOLK DJAEFDPEFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	private DHDJMPADGJE IKFIONIIIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private long LADMAADOIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	private long OPILFBADOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private long KFBIFEHDOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private string KBKFCDKCGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private JENOKPCEBIE CNMIPNMKFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private Guid KGDFKMAFOEP;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x84E61E0", Offset = "0x84E53E0", VA = "0x1884E61E0")]
	public static Task<CAGKJJGCDMM> CJBGJMMBAIB(AEHEGPIEOCE IKFFOMHBDLM, LBIKBDECECI IKFDGIFGHKP, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x84E6770", Offset = "0x84E5970", VA = "0x1884E6770")]
	[AsyncStateMachine(typeof(BHBCOHFFANP))]
	private Task<CAGKJJGCDMM> JGHBEDNJLDN(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x84E6600", Offset = "0x84E5800", VA = "0x1884E6600")]
	[AsyncStateMachine(typeof(DCLDEOBMBPD))]
	private Task<CAGKJJGCDMM> IGFHIDLMNLL(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x84E6430", Offset = "0x84E5630", VA = "0x1884E6430")]
	[AsyncStateMachine(typeof(EIOPPJPJBHC))]
	private static Task<CAGKJJGCDMM> IGFHIDLMNLL(FANFNGDGAHN PLKEMCOOOMD, DHDJMPADGJE IKFIONIIIOP, long LADMAADOIBG, long OPILFBADOKA, long KFBIFEHDOHB, string KBKFCDKCGMH, JENOKPCEBIE CNMIPNMKFCE, Guid KGDFKMAFOEP, CancellationToken FHBCOAHILMJ, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x84E68C0", Offset = "0x84E5AC0", VA = "0x1884E68C0")]
	private void PHCGAIHPMLD(EAAMLCEDMMD PCKDNOKGHKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal struct LAIOEPDFJKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct LCINBBJEIOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public LAIOEPDFJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x84EAA20", Offset = "0x84E9C20", VA = "0x1884EAA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x84EAFB0", Offset = "0x84EA1B0", VA = "0x1884EAFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private FANFNGDGAHN PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private IMGOPGMMMDH CAIGHLKIDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private float ECHPACIIDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private float ANNJDLBJEDD;

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x84EA3F0", Offset = "0x84E95F0", VA = "0x1884EA3F0")]
	public static Task ADPENAIIIHA(AEHEGPIEOCE IKFFOMHBDLM, IMGOPGMMMDH CAIGHLKIDBF, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x84EA6C0", Offset = "0x84E98C0", VA = "0x1884EA6C0")]
	[AsyncStateMachine(typeof(LCINBBJEIOM))]
	public Task JGHBEDNJLDN(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x84EA590", Offset = "0x84E9790", VA = "0x1884EA590")]
	private static void JDCOKDOEPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x84EA7E0", Offset = "0x84E99E0", VA = "0x1884EA7E0")]
	private void KHEEOMAPKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x84EA960", Offset = "0x84E9B60", VA = "0x1884EA960")]
	private static float PCDNKIDNBBO(FANFNGDGAHN PLKEMCOOOMD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x84EA940", Offset = "0x84E9B40", VA = "0x1884EA940")]
	private static float KKMMOMLJPBA()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal struct ADJGKHLPAMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct MJEBCKBNECN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public FBDJJJEGEAF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private LAHJPJCGMDC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private AEHEGPIEOCE <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private HPKOIBJJIEE.MGDIADAKHMF <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private TaskAwaiter<FBDLPCDKOKJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x84EBD10", Offset = "0x84EAF10", VA = "0x1884EBD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x84EC500", Offset = "0x84EB700", VA = "0x1884EC500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct FGHCPLJFKCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x84E4290", Offset = "0x84E3490", VA = "0x1884E4290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x84E45C0", Offset = "0x84E37C0", VA = "0x1884E45C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x84DA370", Offset = "0x84D9570", VA = "0x1884DA370")]
	[AsyncStateMachine(typeof(MJEBCKBNECN))]
	public static Task JGHBEDNJLDN(FBDJJJEGEAF PCFNKCLPMOK, IMGOPGMMMDH CAIGHLKIDBF, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x84DA300", Offset = "0x84D9500", VA = "0x1884DA300")]
	private static Task<FBDLPCDKOKJ> DCAICMLDNEL(FBDJJJEGEAF PCFNKCLPMOK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x84DA4B0", Offset = "0x84D96B0", VA = "0x1884DA4B0")]
	[AsyncStateMachine(typeof(FGHCPLJFKCB))]
	private static Task KMIMBHHDNFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal struct KKMGBECGACK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct CBOJCBLJPGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public KKMGBECGACK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x84DE0D0", Offset = "0x84DD2D0", VA = "0x1884DE0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x84DE860", Offset = "0x84DDA60", VA = "0x1884DE860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class MOGIGOFOJJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public MOGIGOFOJJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x84EC560", Offset = "0x84EB760", VA = "0x1884EC560")]
		internal object CKKDOGDIBNF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct JJCPHGMFOHL : IAsyncStateMachine
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
		public KKMGBECGACK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x84E6DE0", Offset = "0x84E5FE0", VA = "0x1884E6DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x84E7260", Offset = "0x84E6460", VA = "0x1884E7260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private bool MCEBPCOJPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private CancellationToken FHBCOAHILMJ;

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x84E8F90", Offset = "0x84E8190", VA = "0x1884E8F90")]
	public static Task IJPAMOPNNHP(AEHEGPIEOCE IKFFOMHBDLM, bool MCEBPCOJPCO, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken AFHBHDLKFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x84E9000", Offset = "0x84E8200", VA = "0x1884E9000")]
	[AsyncStateMachine(typeof(CBOJCBLJPGG))]
	private Task JGHBEDNJLDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x84E90F0", Offset = "0x84E82F0", VA = "0x1884E90F0")]
	[AsyncStateMachine(typeof(JJCPHGMFOHL))]
	private Task JKDPNNLGKHG(bool LPEBBANBBFG, string KFEKBOLMGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0")]
	private bool ACNMFFHCCEL(bool MCEBPCOJPCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal struct IMDNCHMAILB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct LGELMLKAHDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public IMDNCHMAILB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x84EB010", Offset = "0x84EA210", VA = "0x1884EB010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x84EB4F0", Offset = "0x84EA6F0", VA = "0x1884EB4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class NBCFBAEHINB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NBCFBAEHINB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x84EC5E0", Offset = "0x84EB7E0", VA = "0x1884EC5E0")]
		internal object CKKDOGDIBNF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct INBJCJHLOCC : IAsyncStateMachine
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
		public IMDNCHMAILB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x84E68F0", Offset = "0x84E5AF0", VA = "0x1884E68F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x84E6D70", Offset = "0x84E5F70", VA = "0x1884E6D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private DOFBEMFJAIH JCIMCLAALNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x84E5F40", Offset = "0x84E5140", VA = "0x1884E5F40")]
	public static Task<Scene> AGMFKHGIJIH(AEHEGPIEOCE IKFFOMHBDLM, DOFBEMFJAIH CHHCKEMHCLP, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x84E5F90", Offset = "0x84E5190", VA = "0x1884E5F90")]
	[AsyncStateMachine(typeof(LGELMLKAHDK))]
	private Task<Scene> JGHBEDNJLDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x84E60A0", Offset = "0x84E52A0", VA = "0x1884E60A0")]
	[AsyncStateMachine(typeof(INBJCJHLOCC))]
	private Task<Scene> JKDPNNLGKHG(string KFEKBOLMGJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal struct IFDEAGGIAIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct PHJGEDNCHJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public AsyncTaskMethodBuilder<HIBEIMPBEBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public IFDEAGGIAIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public HIBEIMPBEBE nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public IMGOPGMMMDH deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private TaskAwaiter<HIBEIMPBEBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x85052B0", Offset = "0x85044B0", VA = "0x1885052B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x8505D80", Offset = "0x8504F80", VA = "0x188505D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct PKIEGJCDKFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public AsyncTaskMethodBuilder<HIBEIMPBEBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public IFDEAGGIAIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public HIBEIMPBEBE state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private TaskAwaiter<FBDLPCDKOKJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8506D30", Offset = "0x8505F30", VA = "0x188506D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8507010", Offset = "0x8506210", VA = "0x188507010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private readonly FBDJJJEGEAF PCFNKCLPMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private readonly GFDGEADJOLK DJAEFDPEFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private readonly CJHEKMMKKMB DOOENKGLIOC;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private LAHJPJCGMDC IBALOMCONOG
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x68DE540", Offset = "0x68DD740", VA = "0x1868DE540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x84FD430", Offset = "0x84FC630", VA = "0x1884FD430")]
	public IFDEAGGIAIF(FBDJJJEGEAF PCFNKCLPMOK, GFDGEADJOLK DJAEFDPEFJK, CJHEKMMKKMB DOOENKGLIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x84FD150", Offset = "0x84FC350", VA = "0x1884FD150")]
	[AsyncStateMachine(typeof(PHJGEDNCHJO))]
	public Task<HIBEIMPBEBE> JCBMPFFEBAD(HIBEIMPBEBE LLAGDELDLOE, IMGOPGMMMDH BBBFBFKEOJH, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ, bool LLFMONHBHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x84FD2D0", Offset = "0x84FC4D0", VA = "0x1884FD2D0")]
	[AsyncStateMachine(typeof(PKIEGJCDKFI))]
	private Task<HIBEIMPBEBE> MAIHMFFBKLF(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, HIBEIMPBEBE CKCKEFFHJAP, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x84FD120", Offset = "0x84FC320", VA = "0x1884FD120")]
	private bool CDADKMCJFGB(HIBEIMPBEBE MIKJLJMCBCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x84FD100", Offset = "0x84FC300", VA = "0x1884FD100")]
	private void AODHEIHGBPN(string PFLKBJPGFAN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct CFDJFGDNFLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct BLKEKJOIFJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public LAHJPJCGMDC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public KDLPAPBPGJJ timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private BKCBFFDELCF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private List<(PersistenceView, IHCKNOKFLCP)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private (PersistenceView, IHCKNOKFLCP) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x84F4570", Offset = "0x84F3770", VA = "0x1884F4570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x84F4C30", Offset = "0x84F3E30", VA = "0x1884F4C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x84F4E30", Offset = "0x84F4030", VA = "0x1884F4E30")]
	[AsyncStateMachine(typeof(BLKEKJOIFJM))]
	public static Task JGHBEDNJLDN(LAHJPJCGMDC LPBJFFLCJMN, IMGOPGMMMDH CAIGHLKIDBF, KDLPAPBPGJJ IFKPJKKPEDL, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct GLFHKFBCCBM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct JHABLALNEDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public LAHJPJCGMDC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public KDLPAPBPGJJ timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		private MGNNNNPADNA <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private BKCBFFDELCF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private List<(PersistenceView, IHCKNOKFLCP)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private IHCKNOKFLCP <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x84FE0A0", Offset = "0x84FD2A0", VA = "0x1884FE0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x84FE980", Offset = "0x84FDB80", VA = "0x1884FE980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x84F93E0", Offset = "0x84F85E0", VA = "0x1884F93E0")]
	[AsyncStateMachine(typeof(JHABLALNEDM))]
	public static Task JGHBEDNJLDN(LAHJPJCGMDC LPBJFFLCJMN, IMGOPGMMMDH CAIGHLKIDBF, KDLPAPBPGJJ IFKPJKKPEDL, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public struct DNMAAGKFFBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct EGMIHKODJMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<ENJOOAGPMBD, DCJPFEGHGPF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public DNMAAGKFFBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public OCAMMJABECJ.DKNFOGEIBIK preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private TaskAwaiter<DJNAMIFBMIO<ENJOOAGPMBD, DCJPFEGHGPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x84F6BA0", Offset = "0x84F5DA0", VA = "0x1884F6BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x84F7220", Offset = "0x84F6420", VA = "0x1884F7220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private long NCPNEFIANJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private long NEBJGDOMGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private Guid? POLMNKBBONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private IReadOnlyCollection<MBKDIDMGHMN> NPIPLFGOFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private IReadOnlyCollection<MBKDIDMGHMN> PBEHAGLGOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private ODKGACJINAN JFDPFMIJCEL;

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x84F6860", Offset = "0x84F5A60", VA = "0x1884F6860")]
	public static Task<DJNAMIFBMIO<ENJOOAGPMBD, DCJPFEGHGPF>> CJBGJMMBAIB(long LADMAADOIBG, long OPILFBADOKA, FLCIPAFBKAP GONAGEEDPGG, OCAMMJABECJ.DKNFOGEIBIK FPBIJKHDDPF, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x84F69C0", Offset = "0x84F5BC0", VA = "0x1884F69C0")]
	[AsyncStateMachine(typeof(EGMIHKODJMJ))]
	private Task<DJNAMIFBMIO<ENJOOAGPMBD, DCJPFEGHGPF>> JGHBEDNJLDN(OCAMMJABECJ.DKNFOGEIBIK FPBIJKHDDPF, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct HPKOIBJJIEE
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	public struct MGDIADAKHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public List<GHHAIJGAMIK> KKJPKMBFKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public List<IHCKNOKFLCP> FPCDMEDAFDH;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xB268B0", Offset = "0xB25AB0", VA = "0x180B268B0")]
		public MGDIADAKHMF(List<GHHAIJGAMIK> KKJPKMBFKHK, List<IHCKNOKFLCP> FPCDMEDAFDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class NLLAKCLOHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public IEnumerable<GHHAIJGAMIK> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NLLAKCLOHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x8503E50", Offset = "0x8503050", VA = "0x188503E50")]
		internal object GKPDAKNGOMK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	private AEHEGPIEOCE IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006E4")]
	private IMGOPGMMMDH CAIGHLKIDBF;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private FANFNGDGAHN ONPPLLOGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x84FB560", Offset = "0x84FA760", VA = "0x1884FB560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x84FAD00", Offset = "0x84F9F00", VA = "0x1884FAD00")]
	public static MGDIADAKHMF JGHBEDNJLDN(AEHEGPIEOCE IKFFOMHBDLM, IMGOPGMMMDH CAIGHLKIDBF)
	{
		return default(MGDIADAKHMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x84FAD60", Offset = "0x84F9F60", VA = "0x1884FAD60")]
	private MGDIADAKHMF JGHBEDNJLDN()
	{
		return default(MGDIADAKHMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x84FAFB0", Offset = "0x84FA1B0", VA = "0x1884FAFB0")]
	private MGDIADAKHMF KKBKKLCAEEI(OJIMHFCMHLE FPHEFLPLCMP, MGNNNNPADNA BAPPDGICHBL)
	{
		return default(MGDIADAKHMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x84FAB30", Offset = "0x84F9D30", VA = "0x1884FAB30")]
	private bool INGPAKDOEAN(IEnumerable<GHHAIJGAMIK> KKJPKMBFKHK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct KNDOIDCDAJG
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class IAKKFHPPLNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public HPKOIBJJIEE.MGDIADAKHMF instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public IAKKFHPPLNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x84FB5B0", Offset = "0x84FA7B0", VA = "0x1884FB5B0")]
		internal object GDKNONECNKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class IFPFCGFCPML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public IFPFCGFCPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x84FD490", Offset = "0x84FC690", VA = "0x1884FD490")]
		internal object OPEDODCBKMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x84FEEF0", Offset = "0x84FE0F0", VA = "0x1884FEEF0")]
	public static void JGHBEDNJLDN(LAHJPJCGMDC LPBJFFLCJMN, IMGOPGMMMDH CAIGHLKIDBF, HPKOIBJJIEE.MGDIADAKHMF MJAIAIFIFLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
internal class CJHEKMMKKMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct NKILKIKMKCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public CJHEKMMKKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public HIBEIMPBEBE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public IMGOPGMMMDH deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x8503680", Offset = "0x8502880", VA = "0x188503680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x8503DF0", Offset = "0x8502FF0", VA = "0x188503DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private sealed class NJNEMPEDCIN
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
			public NJNEMPEDCIN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x8507540", Offset = "0x8506740", VA = "0x188507540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x8507800", Offset = "0x8506A00", VA = "0x188507800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public CJHEKMMKKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NJNEMPEDCIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x8503590", Offset = "0x8502790", VA = "0x188503590")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task BJJCJDOGKEN(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private struct NEAHIBINMNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public CJHEKMMKKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private NJNEMPEDCIN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x85024E0", Offset = "0x85016E0", VA = "0x1885024E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x8502A10", Offset = "0x8501C10", VA = "0x188502A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct HBALLLHAIKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public CJHEKMMKKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private Dictionary<Guid, List<MNKAFBLBFBC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x84F98C0", Offset = "0x84F8AC0", VA = "0x1884F98C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x84F9ED0", Offset = "0x84F90D0", VA = "0x1884F9ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct ILIBKFNDFED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public CJHEKMMKKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		private Dictionary<Guid, List<MNKAFBLBFBC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x84FD520", Offset = "0x84FC720", VA = "0x1884FD520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x84FDBC0", Offset = "0x84FCDC0", VA = "0x1884FDBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class ELNNGGBHENL
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
			public MNKAFBLBFBC handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000720")]
			public ELNNGGBHENL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			private BKCBFFDELCF <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000722")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x8507080", Offset = "0x8506280", VA = "0x188507080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x85074E0", Offset = "0x85066E0", VA = "0x1885074E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public KBNOLLLMMGI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public List<MNKAFBLBFBC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ELNNGGBHENL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x84F79A0", Offset = "0x84F6BA0", VA = "0x1884F79A0")]
		internal object HCEDENBMIFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x84F7B80", Offset = "0x84F6D80", VA = "0x1884F7B80")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task OHDKEAMEDDH(MNKAFBLBFBC handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x84F7A90", Offset = "0x84F6C90", VA = "0x1884F7A90")]
		internal object JJJMNPOLJAM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private struct HOKJNMGBCBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public KBNOLLLMMGI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public List<MNKAFBLBFBC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private ELNNGGBHENL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x84FA600", Offset = "0x84F9800", VA = "0x1884FA600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x84FAAD0", Offset = "0x84F9CD0", VA = "0x1884FAAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct DICLBBCPIHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public CJHEKMMKKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timer;

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
		[Cpp2IlInjected.Address(RVA = "0x84F61A0", Offset = "0x84F53A0", VA = "0x1884F61A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x84F6760", Offset = "0x84F5960", VA = "0x1884F6760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class AIDGPACJFBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AIDGPACJFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x84F2700", Offset = "0x84F1900", VA = "0x1884F2700")]
		internal object DFNFEMOPIBN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct NHHCAGDPEIL : IAsyncStateMachine
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
		public CJHEKMMKKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public IMGOPGMMMDH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x8503070", Offset = "0x8502270", VA = "0x188503070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x8503530", Offset = "0x8502730", VA = "0x188503530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class HLPCCDBNEBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HLPCCDBNEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x84FA590", Offset = "0x84F9790", VA = "0x1884FA590")]
		internal object GIKMJAIJCNF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private struct MFGKKGFJPGM : IAsyncStateMachine
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
		public CJHEKMMKKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		private BKCBFFDELCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private TaskAwaiter<FBDLPCDKOKJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x8501B10", Offset = "0x8500D10", VA = "0x188501B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x8502140", Offset = "0x8501340", VA = "0x188502140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class ONOKNJFGIGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ONOKNJFGIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x8505100", Offset = "0x8504300", VA = "0x188505100")]
		internal object FMGGHHEFOAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EB")]
	private readonly FBDJJJEGEAF PCFNKCLPMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	private LPNDEBNABPA DOOENKGLIOC;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private LAHJPJCGMDC IBALOMCONOG
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x111D2D0", Offset = "0x111C4D0", VA = "0x18111D2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public CJHEKMMKKMB(FBDJJJEGEAF PCFNKCLPMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x84F55B0", Offset = "0x84F47B0", VA = "0x1884F55B0")]
	[AsyncStateMachine(typeof(NKILKIKMKCO))]
	public Task JGHBEDNJLDN(HIBEIMPBEBE EPOPNCBHMOG, IMGOPGMMMDH BBBFBFKEOJH, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x84F52A0", Offset = "0x84F44A0", VA = "0x1884F52A0")]
	[AsyncStateMachine(typeof(NEAHIBINMNA))]
	private Task CAEBIIMODHO(IMGOPGMMMDH CAIGHLKIDBF, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C00", Offset = "0x84F4E00", VA = "0x1884F5C00")]
	[AsyncStateMachine(typeof(HBALLLHAIKN))]
	private Task PFNKGGLPCHJ(IMGOPGMMMDH CAIGHLKIDBF, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x84F5020", Offset = "0x84F4220", VA = "0x1884F5020")]
	[AsyncStateMachine(typeof(ILIBKFNDFED))]
	private Task BCAEDINKJMP(IMGOPGMMMDH CAIGHLKIDBF, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x84F5840", Offset = "0x84F4A40", VA = "0x1884F5840")]
	[AsyncStateMachine(typeof(HOKJNMGBCBJ))]
	private Task JKKNKDHPMDP(Guid ECNHDFPBHIO, List<MNKAFBLBFBC> NHDLBJHMMBI, KBNOLLLMMGI BIFIIFKONBE, IMGOPGMMMDH CAIGHLKIDBF, CancellationToken CCLFNPCGNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x84F5700", Offset = "0x84F4900", VA = "0x1884F5700")]
	[AsyncStateMachine(typeof(DICLBBCPIHM))]
	private Task JIDOCELNBIA(IMGOPGMMMDH CAIGHLKIDBF, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x84F5D40", Offset = "0x84F4F40", VA = "0x1884F5D40")]
	[AsyncStateMachine(typeof(NHHCAGDPEIL))]
	private Task POLNKOCHBIJ(Guid CGLOEEBDDBJ, IMGOPGMMMDH CAIGHLKIDBF, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x84F5160", Offset = "0x84F4360", VA = "0x1884F5160")]
	[AsyncStateMachine(typeof(MFGKKGFJPGM))]
	private Task BHIADNDKJKK(Guid CGLOEEBDDBJ, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x84F5AF0", Offset = "0x84F4CF0", VA = "0x1884F5AF0")]
	private void MIAMMGFJNFJ(Guid CGLOEEBDDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x84F4F70", Offset = "0x84F4170", VA = "0x1884F4F70")]
	private void ANDDDADCDGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x84F5990", Offset = "0x84F4B90", VA = "0x1884F5990")]
	public Guid LOOMLDJAHLP(HIBEIMPBEBE HJNJAGMMLFG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x84F53E0", Offset = "0x84F45E0", VA = "0x1884F53E0")]
	[CompilerGenerated]
	private object FHMFPPFELEF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal struct FJOACLLDLJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private struct FKBHFAAJLAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public FJOACLLDLJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private IEnumerator<JMFCLCMDBEE> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x84F8CE0", Offset = "0x84F7EE0", VA = "0x1884F8CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x84F9380", Offset = "0x84F8580", VA = "0x1884F9380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	private FANFNGDGAHN PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	private BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400074D")]
	private CancellationToken FHBCOAHILMJ;

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x84F89B0", Offset = "0x84F7BB0", VA = "0x1884F89B0")]
	public static Task BLJDEFJMBFK(FANFNGDGAHN PLKEMCOOOMD, BGHCJGPGCNF<string>.IPAINGKGFDM LAEALHELJKO, CancellationToken AFHBHDLKFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x84F8A20", Offset = "0x84F7C20", VA = "0x1884F8A20")]
	[AsyncStateMachine(typeof(FKBHFAAJLAF))]
	private Task JGHBEDNJLDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public readonly struct NHGPKAMOGJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000754")]
	public readonly bool HLILNFPGAMN;

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x2ACF3E0", Offset = "0x2ACE5E0", VA = "0x182ACF3E0")]
	public NHGPKAMOGJM(bool HENDDDOKDBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public readonly struct PEPAFJMLFCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000755")]
	public readonly OJIMHFCMHLE? NKNMLOAPJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000756")]
	public readonly LEFCPINKBPL JLHBELIFMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000757")]
	public readonly Guid? GJJACFEFMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000758")]
	public readonly IReadOnlyList<Guid> NFDNIKMDGCA;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> NBIKEPHPDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x8505190", Offset = "0x8504390", VA = "0x188505190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> PPPGOMJMKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x8505170", Offset = "0x8504370", VA = "0x188505170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x85051B0", Offset = "0x85043B0", VA = "0x1885051B0")]
	public PEPAFJMLFCF(OJIMHFCMHLE? JCFOMPGDMKN, LEFCPINKBPL NJMIFJLCJDK, Guid? KNDLKPHHAPO, [Optional] IReadOnlyList<Guid>? MLEHFIPDEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class OHGADGKJGCI : HHGIPOOMMLP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private struct EKBNFJCJNCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public AsyncTaskMethodBuilder<PEPAFJMLFCF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public OHGADGKJGCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public ALLJAELJMGC serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public EDJHGEODNOP roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		private BKCBFFDELCF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x84F7290", Offset = "0x84F6490", VA = "0x1884F7290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x84F7930", Offset = "0x84F6B30", VA = "0x1884F7930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class JABJOJJNGJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public JABJOJJNGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x84FDC20", Offset = "0x84FCE20", VA = "0x1884FDC20")]
		internal object AKKEAONIMBI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private struct ICJALMNBJJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public OHGADGKJGCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public ALLJAELJMGC serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		private JABJOJJNGJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private BKCBFFDELCF <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		private NKNHMBEFOJB<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x84FC120", Offset = "0x84FB320", VA = "0x1884FC120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x84FCBE0", Offset = "0x84FBDE0", VA = "0x1884FCBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000759")]
	private readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x400075A")]
	private static readonly TimeSpan NFAHKGJHDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	private readonly FFOEKLLALHB PIPIIAJPJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	private readonly JHCOOKGIFBJ NKPPGIOENBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	private readonly NCEPPMBFOIF PHBBJJLLLKK;

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x8505090", Offset = "0x8504290", VA = "0x188505090")]
	public OHGADGKJGCI(FBDJJJEGEAF PCFNKCLPMOK, FFOEKLLALHB PIPIIAJPJDE, JHCOOKGIFBJ JCLIACMEPIJ, NCEPPMBFOIF PHBBJJLLLKK, KEPOMIIOHBM EBHKLAMEJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x8503ED0", Offset = "0x85030D0", VA = "0x188503ED0")]
	[AsyncStateMachine(typeof(EKBNFJCJNCA))]
	public Task<PEPAFJMLFCF> ELKKKBEIKKA(long OPILFBADOKA, EDJHGEODNOP LBOHKNIKOHK, ALLJAELJMGC EJIFCBFMJHA, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x8504020", Offset = "0x8503220", VA = "0x188504020")]
	[AsyncStateMachine(typeof(ICJALMNBJJE))]
	private Task GFEADLFKGBJ(ALLJAELJMGC EJIFCBFMJHA, PersistenceView[] FIDFLICMFGA, StringBuilder AODAPEBFPIO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x8504850", Offset = "0x8503A50", VA = "0x188504850")]
	private PEPAFJMLFCF KNJHJGHHJNP(long OPILFBADOKA, EDJHGEODNOP LBOHKNIKOHK, ALLJAELJMGC EJIFCBFMJHA, IEnumerable<PersistenceView> FIDFLICMFGA, StringBuilder AODAPEBFPIO)
	{
		return default(PEPAFJMLFCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x8504E60", Offset = "0x8504060", VA = "0x188504E60")]
	private OJIMHFCMHLE NFJIEDMGLNN(long OPILFBADOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x8504160", Offset = "0x8503360", VA = "0x188504160")]
	private void GFGBOLBLLNB(OJIMHFCMHLE JEJAOMOCEBC, StringBuilder AODAPEBFPIO, IEnumerable<PersistenceView> FIDFLICMFGA, [In] GBABIBPNNEA KCPCJFLCGMH, JECDKMJCGFK BBLAKKCCBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x85043B0", Offset = "0x85035B0", VA = "0x1885043B0")]
	private void GOMAKEMKKCF(OJIMHFCMHLE JEJAOMOCEBC, StringBuilder AODAPEBFPIO, PersistenceView PEGCLJNJBJG, JECDKMJCGFK BBLAKKCCBNE, [In] GBABIBPNNEA KCPCJFLCGMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal class BGGBJLOPHHL : HHGIPOOMMLP
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class AJFEHBEMLKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public JFCGPCLMOJE.AEJPFPKJIAC roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AJFEHBEMLKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x84F2C20", Offset = "0x84F1E20", VA = "0x1884F2C20")]
		internal object ELCPDCCIGJD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private struct BLFGGOOFNJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public AsyncTaskMethodBuilder<(JFCGPCLMOJE.AEJPFPKJIAC roomDataUpload, JFCGPCLMOJE.AEJPFPKJIAC subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public PEPAFJMLFCF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public FANFNGDGAHN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private AJFEHBEMLKN <>8__1;

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
		private TaskAwaiter<JFCGPCLMOJE.AEJPFPKJIAC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x84F3C80", Offset = "0x84F2E80", VA = "0x1884F3C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x84F4500", Offset = "0x84F3700", VA = "0x1884F4500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct LPJPPCIGOCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public AsyncTaskMethodBuilder<FDACCKBMCMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public BGGBJLOPHHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public AJOEGJCHHHM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public PEPAFJMLFCF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		private TaskAwaiter<FDACCKBMCMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x85013E0", Offset = "0x85005E0", VA = "0x1885013E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x8501680", Offset = "0x8500880", VA = "0x188501680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct PKFNCHLHNMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public AsyncTaskMethodBuilder<FDACCKBMCMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public FANFNGDGAHN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public PEPAFJMLFCF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public IGMCFJMNJGH ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public AJOEGJCHHHM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		private TaskAwaiter<(JFCGPCLMOJE.AEJPFPKJIAC roomDataUpload, JFCGPCLMOJE.AEJPFPKJIAC subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		private TaskAwaiter<FDACCKBMCMP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x8506660", Offset = "0x8505860", VA = "0x188506660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x8506CC0", Offset = "0x8505EC0", VA = "0x188506CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private struct HGPBAMHFINK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public AsyncTaskMethodBuilder<OGNBBNBFGHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public BGGBJLOPHHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public PEPAFJMLFCF roomSerializedData;

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
		private TaskAwaiter<(JFCGPCLMOJE.AEJPFPKJIAC roomDataUpload, JFCGPCLMOJE.AEJPFPKJIAC subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		private TaskAwaiter<OGNBBNBFGHI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x84F9F30", Offset = "0x84F9130", VA = "0x1884F9F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x84FA3F0", Offset = "0x84F95F0", VA = "0x1884FA3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class HIIEOGDPFIK
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
			public AsyncTaskMethodBuilder<FBDLPCDKOKJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			public HIIEOGDPFIK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			private FBDLPCDKOKJ <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			private TaskAwaiter<OGNBBNBFGHI> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			private TaskAwaiter<FDACCKBMCMP> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			private TaskAwaiter<FBDLPCDKOKJ> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0x8507860", Offset = "0x8506A60", VA = "0x188507860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x8508A70", Offset = "0x8507C70", VA = "0x188508A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public BGGBJLOPHHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public PEPAFJMLFCF roomSerializedData;

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
		public AJOEGJCHHHM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public NHGPKAMOGJM roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HIIEOGDPFIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x84FA460", Offset = "0x84F9660", VA = "0x1884FA460")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<FBDLPCDKOKJ> EDFBIFBJPOM(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[CompilerGenerated]
	private struct HADCPIOJHKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		public AsyncTaskMethodBuilder<FBDLPCDKOKJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		public BGGBJLOPHHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		public PEPAFJMLFCF roomSerializedData;

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
		public AJOEGJCHHHM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public NHGPKAMOGJM roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		private TaskAwaiter<FBDLPCDKOKJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x84F9520", Offset = "0x84F8720", VA = "0x1884F9520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x84F9850", Offset = "0x84F8A50", VA = "0x1884F9850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000777")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x4000778")]
	private static readonly KEPOMIIOHBM EEJJLLMCMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000779")]
	private readonly KKKHODIMONB DFNHDHNINMB;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private AEHEGPIEOCE NCKGIDEPMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x84D2700", Offset = "0x84D1900", VA = "0x1884D2700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x84F3BF0", Offset = "0x84F2DF0", VA = "0x1884F3BF0")]
	public BGGBJLOPHHL(FBDJJJEGEAF PCFNKCLPMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x84F3A10", Offset = "0x84F2C10", VA = "0x1884F3A10")]
	[AsyncStateMachine(typeof(BLFGGOOFNJC))]
	private static Task<(JFCGPCLMOJE.AEJPFPKJIAC, JFCGPCLMOJE.AEJPFPKJIAC)> GMJMMEKFKFG(FANFNGDGAHN PLKEMCOOOMD, PEPAFJMLFCF FKIIFAIOCNB, long LADMAADOIBG, long JAFHDCNJHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x84F3570", Offset = "0x84F2770", VA = "0x1884F3570")]
	[AsyncStateMachine(typeof(LPJPPCIGOCL))]
	public Task<FDACCKBMCMP> CEGHOMDNEEK(int FAJKMEHKDDK, [CanBeNull] AJOEGJCHHHM JPGGEILHFHL, PEPAFJMLFCF FKIIFAIOCNB, long LADMAADOIBG, long JAFHDCNJHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x84F3220", Offset = "0x84F2420", VA = "0x1884F3220")]
	public static Task<FDACCKBMCMP> CEGHOMDNEEK(FANFNGDGAHN PLKEMCOOOMD, int FAJKMEHKDDK, [CanBeNull] AJOEGJCHHHM JPGGEILHFHL, PEPAFJMLFCF FKIIFAIOCNB, long LADMAADOIBG, long JAFHDCNJHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x84F3090", Offset = "0x84F2290", VA = "0x1884F3090")]
	[AsyncStateMachine(typeof(PKFNCHLHNMG))]
	public static Task<FDACCKBMCMP> CEGHOMDNEEK(FANFNGDGAHN PLKEMCOOOMD, int FAJKMEHKDDK, [CanBeNull] AJOEGJCHHHM JPGGEILHFHL, PEPAFJMLFCF FKIIFAIOCNB, long LADMAADOIBG, long JAFHDCNJHEA, IGMCFJMNJGH BNNEOIILDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x84F36E0", Offset = "0x84F28E0", VA = "0x1884F36E0")]
	[AsyncStateMachine(typeof(HGPBAMHFINK))]
	private Task<OGNBBNBFGHI> DGJLGNIOHNA(string KBKFCDKCGMH, int FAJKMEHKDDK, PEPAFJMLFCF FKIIFAIOCNB, long LADMAADOIBG, long JAFHDCNJHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x84F3860", Offset = "0x84F2A60", VA = "0x1884F3860")]
	[AsyncStateMachine(typeof(HADCPIOJHKB))]
	public Task<FBDLPCDKOKJ> DIDMANKOAAP(int FAJKMEHKDDK, AJOEGJCHHHM? JPGGEILHFHL, PEPAFJMLFCF FKIIFAIOCNB, long LADMAADOIBG, long JAFHDCNJHEA, NHGPKAMOGJM NIHLNHBHPFK, BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public abstract class CBNMJBHBBLD<T> where T : CBNMJBHBBLD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007BF")]
	internal readonly AEHEGPIEOCE MDBFIOABKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C0")]
	private int? FKBNINAMDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C1")]
	protected readonly Guid BKBCBLBMHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C2")]
	protected readonly AFDJAMFDOCD MKNPBMPANNE;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T BBPKHOKHANK
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x66C1900", Offset = "0x66C0B00", VA = "0x1866C1900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x66C1960", Offset = "0x66C0B60", VA = "0x1866C1960")]
	internal CBNMJBHBBLD(AEHEGPIEOCE LPNPOGPBEDO, AFDJAMFDOCD FNNHHHKCEEP, [Optional] Guid? GHIHMOONOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x66C1790", Offset = "0x66C0990", VA = "0x1866C1790")]
	private FBDLPCDKOKJ GICGHCJEMAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	protected virtual void NANALAMJBJE(FBDLPCDKOKJ NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x66C1870", Offset = "0x66C0A70", VA = "0x1866C1870")]
	public T JDPPIJANHKL(BNFABCHNBCL NKEACAOKBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x66C15E0", Offset = "0x66C07E0", VA = "0x1866C15E0")]
	public T DLCIMHLLFIL(int NEIMJDBJAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x66C1670", Offset = "0x66C0870", VA = "0x1866C1670", Slot = "5")]
	public virtual Task<ONOANLDBBEM> FOABMFNIOMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class CABAMHBHPPN : CBNMJBHBBLD<CABAMHBHPPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C3")]
	private LBIKBDECECI EKFBEBELGHJ;

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x84F4D60", Offset = "0x84F3F60", VA = "0x1884F4D60")]
	internal CABAMHBHPPN(AEHEGPIEOCE LPNPOGPBEDO, AFDJAMFDOCD FNNHHHKCEEP, [Optional] Guid? GHIHMOONOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x770C460", Offset = "0x770B660", VA = "0x18770C460")]
	public CABAMHBHPPN DOFDPFIJPEH(LBIKBDECECI EKFBEBELGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x84F4C90", Offset = "0x84F3E90", VA = "0x1884F4C90", Slot = "4")]
	protected override void NANALAMJBJE(FBDLPCDKOKJ NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class AJCJIHKIFOH : CBNMJBHBBLD<AJCJIHKIFOH>
{
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	internal enum GMDEHFJAAPF
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
	private struct MEGDNFHIADD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public AsyncTaskMethodBuilder<ONOANLDBBEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public AJCJIHKIFOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		private TaskAwaiter<ONOANLDBBEM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x85016F0", Offset = "0x85008F0", VA = "0x1885016F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x8501AA0", Offset = "0x8500CA0", VA = "0x188501AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C4")]
	private GMDEHFJAAPF NNMNCJPOKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007C5")]
	private string LGBHOFHEPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007C6")]
	private AJOEGJCHHHM EKFBEBELGHJ;

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x84F2AB0", Offset = "0x84F1CB0", VA = "0x1884F2AB0")]
	internal AJCJIHKIFOH(AEHEGPIEOCE LPNPOGPBEDO, AFDJAMFDOCD FNNHHHKCEEP, [Optional] Guid? GHIHMOONOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x84F2770", Offset = "0x84F1970", VA = "0x1884F2770")]
	public AJCJIHKIFOH DCLNMEJODKF(string AOOEEPGFGKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x84F28B0", Offset = "0x84F1AB0", VA = "0x1884F28B0")]
	public AJCJIHKIFOH MAFIBFCKJEA(bool OLJCIAPECHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x84F27A0", Offset = "0x84F19A0", VA = "0x1884F27A0")]
	public AJCJIHKIFOH DHMKAILGBLJ(bool CIEMDFNDJOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x84F28D0", Offset = "0x84F1AD0", VA = "0x1884F28D0")]
	public AJCJIHKIFOH MMKEFEOFNEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x84F2900", Offset = "0x84F1B00", VA = "0x1884F2900", Slot = "4")]
	protected override void NANALAMJBJE(FBDLPCDKOKJ NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x84F27C0", Offset = "0x84F19C0", VA = "0x1884F27C0", Slot = "5")]
	[AsyncStateMachine(typeof(MEGDNFHIADD))]
	public override Task<ONOANLDBBEM> FOABMFNIOMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x84F2A70", Offset = "0x84F1C70", VA = "0x1884F2A70")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<ONOANLDBBEM> NPNKBNLKIFH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal static class FJOMOIPGMLP
{
	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x84F8B90", Offset = "0x84F7D90", VA = "0x1884F8B90")]
	public static void KABFIIIMMJH(this LPLCCKHEJAM JELNNIPGJDC, HPLNAENGEIP GHIFCAOPGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x84F8B10", Offset = "0x84F7D10", VA = "0x1884F8B10")]
	public static void BHMOMEFMGDK(this HPLNAENGEIP EJHGGALBJHE, [Optional] string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public static class ENDJLEIEDFM
{
	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x84F8860", Offset = "0x84F7A60", VA = "0x1884F8860")]
	public static JENOKPCEBIE JCOCJLFHKNB(this NAKLEPGBHHE IFNCFMCINII)
	{
		return default(JENOKPCEBIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x84F8900", Offset = "0x84F7B00", VA = "0x1884F8900")]
	public static NAKLEPGBHHE MGFMGIOJMDM(this JENOKPCEBIE GHJKBABNJEO)
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
			public KMDPCKKCIOG ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D5")]
			public KMDPCKKCIOG HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		private static KMDPCKKCIOG[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private Dictionary<KMDPCKKCIOG, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x8509170", Offset = "0x8508370", VA = "0x188509170")]
		public bool NFFCKEAKPJI(KMDPCKKCIOG BGIMMPEECCA, [Out] ResultConfig HICOIPDJCOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x8509030", Offset = "0x8508230", VA = "0x188509030")]
		public ResultConfig MJMANJHNEHM(KMDPCKKCIOG GBBFGBIIOBJ, [Optional] HashSet<KMDPCKKCIOG> LOAFHPKJEHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x8509780", Offset = "0x8508980", VA = "0x188509780", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x85091E0", Offset = "0x85083E0", VA = "0x1885091E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xC19EC0", Offset = "0xC190C0", VA = "0x180C19EC0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public class MFJLCFOJPCI : KPIOGOKHAGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[CompilerGenerated]
	private struct AFJDFOJKDPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		public MFJLCFOJPCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x84F2410", Offset = "0x84F1610", VA = "0x1884F2410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x84F26A0", Offset = "0x84F18A0", VA = "0x1884F26A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[CompilerGenerated]
	private struct JHHGDJIIOBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public KPIOGOKHAGB preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x84FE9E0", Offset = "0x84FDBE0", VA = "0x1884FE9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x84FEE90", Offset = "0x84FE090", VA = "0x1884FEE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007DE")]
	private readonly JMMABMMBEPA KFHPIONBPAK;

	[Cpp2IlInjected.Token(Token = "0x40007DF")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string KBJIPHCLIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x8502440", Offset = "0x8501640", VA = "0x188502440", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x85022C0", Offset = "0x85014C0", VA = "0x1885022C0")]
	[MGCKGAIBEHC.PCMIGKEOIEO.MAPPJIPMPIK]
	internal static void JEGDMFJDHHB(FJCFOKJAKFO CBAPLOOHOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MFJLCFOJPCI([NGLIAOPBMFM(null)] JMMABMMBEPA KFHPIONBPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x8502330", Offset = "0x8501530", VA = "0x188502330", Slot = "5")]
	[AsyncStateMachine(typeof(AFJDFOJKDPB))]
	public Task JGHBEDNJLDN(BGHCJGPGCNF<string>.IPAINGKGFDM DBFPGNMMCPA, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x85021A0", Offset = "0x85013A0", VA = "0x1885021A0")]
	[AsyncStateMachine(typeof(JHHGDJIIOBF))]
	private Task BMMNJBHNEOD(KPIOGOKHAGB MKJPNEFAJOL, BGHCJGPGCNF<string>.IPAINGKGFDM DBFPGNMMCPA, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public interface JMMABMMBEPA : KPIOGOKHAGB
{
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public interface KPIOGOKHAGB
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string KBJIPHCLIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JGHBEDNJLDN(BGHCJGPGCNF<string>.IPAINGKGFDM DBFPGNMMCPA, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public static class JEMCJPDPAHM
{
	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x84FDC90", Offset = "0x84FCE90", VA = "0x1884FDC90")]
	[MGCKGAIBEHC.PCMIGKEOIEO.MAPPJIPMPIK]
	internal static void LDPAGBHHOJF(FJCFOKJAKFO CBAPLOOHOHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public interface CBBEGLFAAKE : IEquatable<CBBEGLFAAKE>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime HFFJHDNMOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJNPHOMBMDB();

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HNMMANCAKKJ(long LADMAADOIBG, long OPILFBADOKA, [Out] PEPAFJMLFCF FKIIFAIOCNB);
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
internal class EMBLGCAGEFI : MCCCLJHHDGE
{
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[CompilerGenerated]
	private sealed class BECBFOMBKGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public IDBHCDKMGJP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BECBFOMBKGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x84F3020", Offset = "0x84F2220", VA = "0x1884F3020")]
		internal object MILEHBOOEHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007ED")]
	private readonly KMCFMKBMBHO AKKGKKAEFLK;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<CBBEGLFAAKE> KKGFAOEFJLC
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x84F8700", Offset = "0x84F7900", VA = "0x1884F8700", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x84F8650", Offset = "0x84F7850", VA = "0x1884F8650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	[UnityEngine.Scripting.Preserve]
	public EMBLGCAGEFI([NGLIAOPBMFM(null)] KMCFMKBMBHO AKKGKKAEFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x84F8350", Offset = "0x84F7550", VA = "0x1884F8350", Slot = "6")]
	public bool ILNOKIINNAH(long LADMAADOIBG, long OPILFBADOKA, PEPAFJMLFCF FKIIFAIOCNB, IDBHCDKMGJP LOAICONOLLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0xE101A0", Offset = "0xE0F3A0", VA = "0x180E101A0")]
	private void BNIFOKGLLJN(CBBEGLFAAKE MFAEBMNCOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x84F81E0", Offset = "0x84F73E0", VA = "0x1884F81E0", Slot = "7")]
	public bool GCNMGMCKHJH(long LADMAADOIBG, long OPILFBADOKA, [Out] CBBEGLFAAKE AABAAIKLAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x84F87B0", Offset = "0x84F79B0", VA = "0x1884F87B0", Slot = "8")]
	public bool NFKAEKJONDJ(long LADMAADOIBG, long OPILFBADOKA, IDBHCDKMGJP LOAICONOLLD, [Out] CBBEGLFAAKE AABAAIKLAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x84F7DB0", Offset = "0x84F6FB0", VA = "0x1884F7DB0")]
	private void EMANNGJNPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x84F7C80", Offset = "0x84F6E80", VA = "0x1884F7C80", Slot = "9")]
	public void CDPDGDBLPDN(long LADMAADOIBG, long OPILFBADOKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal abstract class ICDEJINNABH : KMCFMKBMBHO
{
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	protected enum HOJOLIAOAIP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[CompilerGenerated]
	private sealed class APECPKJFKMB : IEnumerable<CBBEGLFAAKE>, IEnumerable, IEnumerator<CBBEGLFAAKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private CBBEGLFAAKE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		public ICDEJINNABH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		private IDBHCDKMGJP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		public IDBHCDKMGJP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private CBBEGLFAAKE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public APECPKJFKMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x84F2CF0", Offset = "0x84F1EF0", VA = "0x1884F2CF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x84F2FD0", Offset = "0x84F21D0", VA = "0x1884F2FD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x84F2F20", Offset = "0x84F2120", VA = "0x1884F2F20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CBBEGLFAAKE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x84F2F20", Offset = "0x84F2120", VA = "0x1884F2F20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class DMLGFGHAIDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		public IDBHCDKMGJP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DMLGFGHAIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x84F67C0", Offset = "0x84F59C0", VA = "0x1884F67C0")]
		internal object PCGLHKHEGME()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[CompilerGenerated]
	private sealed class ANKCIHLBLMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		public ICDEJINNABH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ANKCIHLBLMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x84F2C70", Offset = "0x84F1E70", VA = "0x1884F2C70")]
		internal void BDCMCGFIGHL(BMEOGEPPLMJ.BEIMIABEDID ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F3")]
	private readonly object GIPPJPNDNNF;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string PBAJDNMHHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x84FB850", Offset = "0x84FAA50", VA = "0x1884FB850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract CHBNMPHGBJK HGCGLNKIICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x84FC0A0", Offset = "0x84FB2A0", VA = "0x1884FC0A0")]
	protected ICDEJINNABH([CanBeNull] string JEPONFMOMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x84FB660", Offset = "0x84FA860", VA = "0x1884FB660", Slot = "5")]
	public bool CFNIMOPCPMG(long LADMAADOIBG, long OPILFBADOKA, IDBHCDKMGJP LOAICONOLLD, [Out] CBBEGLFAAKE MFAEBMNCOGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x84FB860", Offset = "0x84FAA60", VA = "0x1884FB860", Slot = "6")]
	[IteratorStateMachine(typeof(APECPKJFKMB))]
	public IEnumerable<CBBEGLFAAKE> DIPNPPFFHBN(IDBHCDKMGJP LOAICONOLLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void HHCLPAKPFAN(Stream MBFKLCEIJDN, long LADMAADOIBG, long OPILFBADOKA, PEPAFJMLFCF FKIIFAIOCNB);

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool JPLDHOPFHIJ(Stream DIAPJMNMFEO, long LADMAADOIBG, long OPILFBADOKA, JKLGDKDMAPB JAAJPDHDEPM, [Out] PEPAFJMLFCF FKIIFAIOCNB);

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x84FB8F0", Offset = "0x84FAAF0", VA = "0x1884FB8F0", Slot = "7")]
	public CBBEGLFAAKE ICFPDOKBFLM(long LADMAADOIBG, long OPILFBADOKA, PEPAFJMLFCF FKIIFAIOCNB, IDBHCDKMGJP LOAICONOLLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo FDPPPOBCOEJ(long LADMAADOIBG, long OPILFBADOKA, IDBHCDKMGJP LOAICONOLLD, HOJOLIAOAIP LNPFLDJBELM);

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo NHBEHIFNKIE(IDBHCDKMGJP LOAICONOLLD, HOJOLIAOAIP LNPFLDJBELM);

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x84FC030", Offset = "0x84FB230", VA = "0x1884FC030")]
	protected void JOIMEODBBBH(BMEOGEPPLMJ.BEIMIABEDID NIEKKFMMBND, string PFLKBJPGFAN, FileInfo MAKEJCMINLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x84FBC70", Offset = "0x84FAE70", VA = "0x1884FBC70")]
	internal bool JBMLGEEBNGJ(FileInfo IJAGCIMGAOG, long LADMAADOIBG, long OPILFBADOKA, [Out] PEPAFJMLFCF FKIIFAIOCNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private void JHFGCOLILKE(Exception JLAMGOGLIAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal class LABAOHHIEPC : ICDEJINNABH
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override CHBNMPHGBJK HGCGLNKIICN
	{
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x1336710", Offset = "0x1335910", VA = "0x181336710", Slot = "8")]
		get
		{
			return default(CHBNMPHGBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x85000B0", Offset = "0x84FF2B0", VA = "0x1885000B0")]
	public LABAOHHIEPC([Optional] string JEPONFMOMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x84FF4A0", Offset = "0x84FE6A0", VA = "0x1884FF4A0")]
	private void BJJBJEIALBI(IDBHCDKMGJP LOAICONOLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x84FF610", Offset = "0x84FE810", VA = "0x1884FF610", Slot = "9")]
	internal override void HHCLPAKPFAN(Stream MBFKLCEIJDN, long LADMAADOIBG, long OPILFBADOKA, PEPAFJMLFCF FKIIFAIOCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x84FF8C0", Offset = "0x84FEAC0", VA = "0x1884FF8C0", Slot = "10")]
	internal override bool JPLDHOPFHIJ(Stream DIAPJMNMFEO, long LADMAADOIBG, long OPILFBADOKA, JKLGDKDMAPB JAAJPDHDEPM, [Out] PEPAFJMLFCF FKIIFAIOCNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x84FF520", Offset = "0x84FE720", VA = "0x1884FF520", Slot = "11")]
	protected override FileInfo FDPPPOBCOEJ(long LADMAADOIBG, long OPILFBADOKA, IDBHCDKMGJP LOAICONOLLD, HOJOLIAOAIP LNPFLDJBELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x84FFFB0", Offset = "0x84FF1B0", VA = "0x1884FFFB0", Slot = "12")]
	protected override DirectoryInfo NHBEHIFNKIE(IDBHCDKMGJP LOAICONOLLD, HOJOLIAOAIP LNPFLDJBELM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
internal sealed class LGGICOIIGAA : ICDEJINNABH
{
	[Cpp2IlInjected.Token(Token = "0x4000803")]
	private static readonly byte[] MHDODBCCAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000804")]
	private readonly byte[] LDHAHIDJJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000805")]
	private readonly byte[] KONJENLJAPD;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override CHBNMPHGBJK HGCGLNKIICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x18CD1C0", Offset = "0x18CC3C0", VA = "0x1818CD1C0", Slot = "8")]
		get
		{
			return default(CHBNMPHGBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x85012F0", Offset = "0x85004F0", VA = "0x1885012F0")]
	public LGGICOIIGAA([Optional] string JEPONFMOMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x8500220", Offset = "0x84FF420", VA = "0x188500220", Slot = "9")]
	internal override void HHCLPAKPFAN(Stream MBFKLCEIJDN, long LADMAADOIBG, long OPILFBADOKA, PEPAFJMLFCF FKIIFAIOCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x8500630", Offset = "0x84FF830", VA = "0x188500630", Slot = "10")]
	internal override bool JPLDHOPFHIJ(Stream DIAPJMNMFEO, long LADMAADOIBG, long OPILFBADOKA, JKLGDKDMAPB JAAJPDHDEPM, [Out] PEPAFJMLFCF FKIIFAIOCNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x85011A0", Offset = "0x85003A0", VA = "0x1885011A0")]
	private void PMDOCMLLGHK(byte[] DJMFMHNIFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x85000F0", Offset = "0x84FF2F0", VA = "0x1885000F0", Slot = "11")]
	protected override FileInfo FDPPPOBCOEJ(long LADMAADOIBG, long OPILFBADOKA, IDBHCDKMGJP LOAICONOLLD, HOJOLIAOAIP LNPFLDJBELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x8501090", Offset = "0x8500290", VA = "0x188501090", Slot = "12")]
	protected override DirectoryInfo NHBEHIFNKIE(IDBHCDKMGJP LOAICONOLLD, HOJOLIAOAIP LNPFLDJBELM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
public enum CHBNMPHGBJK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000809")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400080A")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400080B")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
internal class PHKGMOODIKN : KMCFMKBMBHO
{
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	[CompilerGenerated]
	private sealed class IEBHPBOJPPK : IEnumerable<CBBEGLFAAKE>, IEnumerable, IEnumerator<CBBEGLFAAKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		private CBBEGLFAAKE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		public PHKGMOODIKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private IDBHCDKMGJP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		public IDBHCDKMGJP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private CHBNMPHGBJK[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private IEnumerator<CBBEGLFAAKE> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private CBBEGLFAAKE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public IEBHPBOJPPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x84FD070", Offset = "0x84FC270", VA = "0x1884FD070", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x84FCC90", Offset = "0x84FBE90", VA = "0x1884FCC90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x84FCC40", Offset = "0x84FBE40", VA = "0x1884FCC40")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x84FD020", Offset = "0x84FC220", VA = "0x1884FD020", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x84FCF70", Offset = "0x84FC170", VA = "0x1884FCF70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CBBEGLFAAKE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x84FCF70", Offset = "0x84FC170", VA = "0x1884FCF70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400080C")]
	private readonly CHBNMPHGBJK[] ELJPAIDEOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400080D")]
	private readonly Dictionary<CHBNMPHGBJK, KMCFMKBMBHO> GGHKPNCOBCN;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public CHBNMPHGBJK HGCGLNKIICN
	{
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x85060C0", Offset = "0x85052C0", VA = "0x1885060C0", Slot = "4")]
		get
		{
			return default(CHBNMPHGBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x8506330", Offset = "0x8505530", VA = "0x188506330")]
	[UnityEngine.Scripting.Preserve]
	public PHKGMOODIKN(params KMCFMKBMBHO[] BIPFAHMBIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x8505DF0", Offset = "0x8504FF0", VA = "0x188505DF0", Slot = "5")]
	public bool CFNIMOPCPMG(long LADMAADOIBG, long OPILFBADOKA, IDBHCDKMGJP LOAICONOLLD, [Out] CBBEGLFAAKE MFAEBMNCOGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x85060F0", Offset = "0x85052F0", VA = "0x1885060F0")]
	private void PHEAOIDFPJM(int KEKHDLFLMNA, long LADMAADOIBG, long OPILFBADOKA, IDBHCDKMGJP LOAICONOLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x8505F40", Offset = "0x8505140", VA = "0x188505F40", Slot = "6")]
	[IteratorStateMachine(typeof(IEBHPBOJPPK))]
	public IEnumerable<CBBEGLFAAKE> DIPNPPFFHBN(IDBHCDKMGJP LOAICONOLLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x8505FD0", Offset = "0x85051D0", VA = "0x188505FD0", Slot = "7")]
	public CBBEGLFAAKE ICFPDOKBFLM(long LADMAADOIBG, long OPILFBADOKA, PEPAFJMLFCF FKIIFAIOCNB, IDBHCDKMGJP LOAICONOLLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
internal static class CPLEBDKMIKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x84F5E80", Offset = "0x84F5080", VA = "0x1884F5E80")]
	internal static byte[] BCOFKJNILIJ(byte[] DJMFMHNIFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x84F5F40", Offset = "0x84F5140", VA = "0x1884F5F40")]
	public static void BGKGAKBPOFM(Stream BGJBNEGGABC, byte[] CFLHGEINGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x84F5FC0", Offset = "0x84F51C0", VA = "0x1884F5FC0")]
	public static bool DFKFKNOOCBA(Stream BGJBNEGGABC, long DMBDKKLAGOG, JKLGDKDMAPB GHLJDLOOFMN, [Out] byte[] CDAKENGKLPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
internal sealed class NFCNJCEJACG : CBBEGLFAAKE, IEquatable<CBBEGLFAAKE>, IEquatable<NFCNJCEJACG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400081B")]
	private readonly ICDEJINNABH HLICCELFOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400081C")]
	public readonly FileInfo DPCEGHDNBIN;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public CHBNMPHGBJK HGCGLNKIICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC3E0", Offset = "0x7DAB5E0", VA = "0x187DAC3E0", Slot = "9")]
		get
		{
			return default(CHBNMPHGBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime HFFJHDNMOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x8502C90", Offset = "0x8501E90", VA = "0x188502C90", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x8502F60", Offset = "0x8502160", VA = "0x188502F60")]
	public NFCNJCEJACG(ICDEJINNABH AOMKDPIJFFI, FileInfo IJAGCIMGAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x8502EB0", Offset = "0x85020B0", VA = "0x188502EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x8502DF0", Offset = "0x8501FF0", VA = "0x188502DF0", Slot = "5")]
	public void OJNPHOMBMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x8502DB0", Offset = "0x8501FB0", VA = "0x188502DB0", Slot = "6")]
	public bool HNMMANCAKKJ(long LADMAADOIBG, long OPILFBADOKA, [Out] PEPAFJMLFCF FKIIFAIOCNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x8502A70", Offset = "0x8501C70", VA = "0x188502A70", Slot = "7")]
	public bool Equals(CBBEGLFAAKE CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x8502AE0", Offset = "0x8501CE0", VA = "0x188502AE0", Slot = "8")]
	public bool Equals(NFCNJCEJACG CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x8502BA0", Offset = "0x8501DA0", VA = "0x188502BA0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x8502D20", Offset = "0x8501F20", VA = "0x188502D20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
public delegate void JKLGDKDMAPB(BMEOGEPPLMJ.BEIMIABEDID KJJMDCPCDMA, string NPEJLHCJPAI);
[Cpp2IlInjected.Token(Token = "0x20001D3")]
internal interface KMCFMKBMBHO
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	CHBNMPHGBJK HGCGLNKIICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CFNIMOPCPMG(long LADMAADOIBG, long OPILFBADOKA, IDBHCDKMGJP LOAICONOLLD, [Out] CBBEGLFAAKE MFAEBMNCOGP);

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<CBBEGLFAAKE> DIPNPPFFHBN(IDBHCDKMGJP LOAICONOLLD);

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CBBEGLFAAKE ICFPDOKBFLM(long LADMAADOIBG, long OPILFBADOKA, PEPAFJMLFCF FKIIFAIOCNB, IDBHCDKMGJP LOAICONOLLD);
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
