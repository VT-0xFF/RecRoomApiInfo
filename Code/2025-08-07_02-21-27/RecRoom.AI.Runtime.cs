using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RecNet;
using RecNet.Data;
using RecRoom.AI.Internal;
using RecRoom.AI.OpenAI.Realtime;
using RecRoom.Audio;
using RecRoom.DataLayer.Audio;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Tokens;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
internal sealed class ZHUHIVBLLLZ<a, b, c>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly a CCYCPKEELBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly b HOXZDGDBTTU;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly c SNJMXYBTNLB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public a CFFWKEOMCTA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
		get
		{
			return (a)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public b JSHGNQSGJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
		get
		{
			return (b)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public c CQHEGAPZZOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
		get
		{
			return (c)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xE3EF80", Offset = "0xE3DB80", VA = "0x180E3EF80")]
	[DebuggerHidden]
	public ZHUHIVBLLLZ(a a, b b, c c)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4496620", Offset = "0x4495220", VA = "0x184496620", Slot = "0")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4496DF0", Offset = "0x44959F0", VA = "0x184496DF0", Slot = "2")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4496F90", Offset = "0x4495B90", VA = "0x184496F90", Slot = "3")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[CompilerGenerated]
internal sealed class RQZDBWLCIXN<a, b>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly a XIIMAXYGQXZ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly b JDCFEGTHZZI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public a DBMNTWVUMFW
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
		get
		{
			return (a)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public b KZXSYIXDKHZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
		get
		{
			return (b)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
	[DebuggerHidden]
	public RQZDBWLCIXN(a a, b b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4491820", Offset = "0x4490420", VA = "0x184491820", Slot = "0")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6290550", Offset = "0x628F150", VA = "0x186290550", Slot = "2")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6290B50", Offset = "0x628F750", VA = "0x186290B50", Slot = "3")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
internal sealed class EYYOQVBTRHZ<a>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly a XIIMAXYGQXZ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public a DBMNTWVUMFW
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
		get
		{
			return (a)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
	[DebuggerHidden]
	public EYYOQVBTRHZ(a a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8DE0", Offset = "0x4CE79E0", VA = "0x184CE8DE0", Slot = "0")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8F50", Offset = "0x4CE7B50", VA = "0x184CE8F50", Slot = "2")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4CE98A0", Offset = "0x4CE84A0", VA = "0x184CE98A0", Slot = "3")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CompilerGenerated]
internal sealed class WIAEZHSMTLW<a>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly a QEPXGZCQZPR;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public a JTWZLIWMWLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030")]
		get
		{
			return (a)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xDC26B0", Offset = "0xDC12B0", VA = "0x180DC26B0")]
	[DebuggerHidden]
	public WIAEZHSMTLW(a a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D66C40", Offset = "0x6D65840", VA = "0x186D66C40", Slot = "0")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D66CF0", Offset = "0x6D658F0", VA = "0x186D66CF0", Slot = "2")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D66E40", Offset = "0x6D65A40", VA = "0x186D66E40", Slot = "3")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8723BA0", Offset = "0x87227A0", VA = "0x188723BA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class DZISONAGUEP
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x871FF30", Offset = "0x871EB30", VA = "0x18871FF30")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
	public DZISONAGUEP()
	{
	}
}
namespace _LogRegistration.RecRoom_AI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x87238A0", Offset = "0x87224A0", VA = "0x1887238A0", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.AI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public abstract class LREDLEKRSAI : IDisposable, WWKJJEHEDTU
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <RunPeriodicUpload>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public LREDLEKRSAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8733190", Offset = "0x8731D90", VA = "0x188733190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <TrySyncLatestCostInfoIfChanged>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public LREDLEKRSAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8734C50", Offset = "0x8733850", VA = "0x188734C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8734EF0", Offset = "0x8733AF0", VA = "0x188734EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		protected static readonly Log NPHEYIXDMFH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly TimeSpan HBFLQWIOHWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CancellationTokenSource NDXXQCRYFNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly WFSBWHDMOYH YIXIDMLSGXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly long DDOIENLESKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly long BSTJYMYTOZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private decimal KPCIDUZJANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Guid SLALJAMEATF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public decimal BFHLCSIEFPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1383B60", Offset = "0x1382760", VA = "0x181383B60")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x85E8300", Offset = "0x85E6F00", VA = "0x1885E8300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x87236E0", Offset = "0x87222E0", VA = "0x1887236E0")]
		public LREDLEKRSAI(WFSBWHDMOYH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8723350", Offset = "0x8721F50", VA = "0x188723350", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87233C0", Offset = "0x8721FC0", VA = "0x1887233C0")]
		[AsyncStateMachine(typeof(<RunPeriodicUpload>d__14))]
		private void IEXMIMDLCOW(CancellationToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8723490", Offset = "0x8722090", VA = "0x188723490")]
		[AsyncStateMachine(typeof(<TrySyncLatestCostInfoIfChanged>d__15))]
		private Task<bool> PMZEGYGNFAI(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract Task<bool> TrySyncLatestCostInfo(WFSBWHDMOYH recNetAI, Guid spendSessionId, long roomId, long roomInstanceId, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x87235A0", Offset = "0x87221A0", VA = "0x1887235A0", Slot = "5")]
		public void RRNPTZGJSWN(decimal a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum ArgType
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		String
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ArgSchema : IEquatable<ArgSchema>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		[CompilerGenerated]
		protected virtual Type RAEISDJSSFV
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x871EDC0", Offset = "0x871D9C0", VA = "0x18871EDC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ArgType JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			[CompilerGenerated]
			get
			{
				return default(ArgType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string UXJYQDOEVFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool OPIYTSYQXLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xDD0FC0", Offset = "0xDCFBC0", VA = "0x180DD0FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xC901B0", Offset = "0xC8EDB0", VA = "0x180C901B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x871EFB0", Offset = "0x871DBB0", VA = "0x18871EFB0")]
		public ArgSchema(ArgType Type, string Name, string Description = "", bool IsArray = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x871EE60", Offset = "0x871DA60", VA = "0x18871EE60", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x871EAB0", Offset = "0x871D6B0", VA = "0x18871EAB0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool GYERVTDYCHN(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1372750", Offset = "0x1371350", VA = "0x181372750")]
		[CompilerGenerated]
		public static bool SZMIMWEVICM(ArgSchema? a, ArgSchema? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x13722E0", Offset = "0x1370EE0", VA = "0x1813722E0")]
		[CompilerGenerated]
		public static bool EOXNKNKFOQL(ArgSchema? a, ArgSchema? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x871EC10", Offset = "0x871D810", VA = "0x18871EC10", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x871E7C0", Offset = "0x871D3C0", VA = "0x18871E7C0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x871E850", Offset = "0x871D450", VA = "0x18871E850", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(ArgSchema? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x871EA20", Offset = "0x871D620", VA = "0x18871EA20", Slot = "8")]
		[CompilerGenerated]
		public virtual ArgSchema GDCYYQSJXOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x871EF50", Offset = "0x871DB50", VA = "0x18871EF50")]
		[CompilerGenerated]
		protected ArgSchema(ArgSchema original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x871EE10", Offset = "0x871DA10", VA = "0x18871EE10")]
		[CompilerGenerated]
		public void SGLQLYIOUSX([Out] ArgType a, [Out] string b, [Out] string c, [Out] bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class Arg : IEquatable<Arg>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		[CompilerGenerated]
		protected virtual Type RAEISDJSSFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x871F420", Offset = "0x871E020", VA = "0x18871F420", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JToken FCWFZLEDINY
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ArgSchema XTVEOTRJYJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1369110", Offset = "0x1367D10", VA = "0x181369110")]
		public Arg(JToken Token, ArgSchema ArgSchema)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x871FB00", Offset = "0x871E700", VA = "0x18871FB00")]
		public static int XZZIAQINHXV(Arg a)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x871F940", Offset = "0x871E540", VA = "0x18871F940")]
		public static float XZZIAQINHXV(Arg a)
		{
			return default(float);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x871F880", Offset = "0x871E480", VA = "0x18871F880")]
		public static bool XZZIAQINHXV(Arg a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x871F5A0", Offset = "0x871E1A0", VA = "0x18871F5A0")]
		public static string XZZIAQINHXV(Arg a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x871F780", Offset = "0x871E380", VA = "0x18871F780")]
		public static int[] XZZIAQINHXV(Arg a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x871FBC0", Offset = "0x871E7C0", VA = "0x18871FBC0")]
		public static float[] XZZIAQINHXV(Arg a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x871F680", Offset = "0x871E280", VA = "0x18871F680")]
		public static bool[] XZZIAQINHXV(Arg a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x871FA00", Offset = "0x871E600", VA = "0x18871FA00")]
		public static string[] XZZIAQINHXV(Arg a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x871F4B0", Offset = "0x871E0B0", VA = "0x18871F4B0", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x871F260", Offset = "0x871DE60", VA = "0x18871F260", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool GYERVTDYCHN(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1372750", Offset = "0x1371350", VA = "0x181372750")]
		[CompilerGenerated]
		public static bool SZMIMWEVICM(Arg? a, Arg? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x13722E0", Offset = "0x1370EE0", VA = "0x1813722E0")]
		[CompilerGenerated]
		public static bool EOXNKNKFOQL(Arg? a, Arg? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x871F300", Offset = "0x871DF00", VA = "0x18871F300", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x871F000", Offset = "0x871DC00", VA = "0x18871F000", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x871F090", Offset = "0x871DC90", VA = "0x18871F090", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(Arg? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x871F1E0", Offset = "0x871DDE0", VA = "0x18871F1E0", Slot = "8")]
		[CompilerGenerated]
		public virtual Arg GDCYYQSJXOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x871FCC0", Offset = "0x871E8C0", VA = "0x18871FCC0")]
		[CompilerGenerated]
		protected Arg(Arg original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x871F470", Offset = "0x871E070", VA = "0x18871F470")]
		[CompilerGenerated]
		public void SGLQLYIOUSX([Out] JToken a, [Out] ArgSchema b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class LJKKZBUIGHL : BSBXBMQIYNN
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string CLKDHTCPOEK = "Open AI Realtime API";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string BAMHGSLEWFG = "endpoint";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly string CJHLDQEBATH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly List<Func<NKNMZIGJWYR.SJCYWDVYQIW, NKNMZIGJWYR.SJCYWDVYQIW>> HBTPDEWDQFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly List<Func<NKNMZIGJWYR.SJCYWDVYQIW, NKNMZIGJWYR.SJCYWDVYQIW>> IDXLCJIACTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly OYKLECPPHHI NWHHLHSXQKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly WWKJJEHEDTU JMRUWNEPTFG;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public POMAPQGXAWT? VQJMXKMBVUO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string LNJRTGOJSOL
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xB13160", Offset = "0xB11D60", VA = "0x180B13160", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool XURYFYSOIJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8720E40", Offset = "0x871FA40", VA = "0x188720E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8723240", Offset = "0x8721E40", VA = "0x188723240")]
		public LJKKZBUIGHL(OYKLECPPHHI a, WWKJJEHEDTU b, string c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8722D70", Offset = "0x8721970", VA = "0x188722D70")]
		private static NKNMZIGJWYR.SJCYWDVYQIW XTAPUQRYIMI(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8721720", Offset = "0x8720320", VA = "0x188721720")]
		private NKNMZIGJWYR.SJCYWDVYQIW JSYAIJDPPZB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8722500", Offset = "0x8721100", VA = "0x188722500", Slot = "8")]
		public void VYGNEYDOXTN(string? sessionId, string a, string b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8723020", Offset = "0x8721C20", VA = "0x188723020", Slot = "10")]
		public void ZSJPGXLXNMP(string? sessionId, ErrorEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x87222A0", Offset = "0x8720EA0", VA = "0x1887222A0", Slot = "11")]
		public void UKJAFZPNOHT(string? sessionId, decimal a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8720EC0", Offset = "0x871FAC0", VA = "0x188720EC0")]
		public static void CIYWVWCQIBR(WWKJJEHEDTU a, string b, string c, decimal d, string e, params (string key, string val)[] extraProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x87227D0", Offset = "0x87213D0", VA = "0x1887227D0", Slot = "12")]
		public void XMXJEMETTSC(string? sessionId, ConversationItemDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8721100", Offset = "0x871FD00", VA = "0x188721100", Slot = "15")]
		public void GCGJLKGRUSI(string? sessionId, ResponseEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8721760", Offset = "0x8720360", VA = "0x188721760")]
		private (decimal?, string, string, string, string, string) NHXXSVKYADL(ResponseEventDTO a)
		{
			return default((decimal?, string, string, string, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8721B30", Offset = "0x8720730", VA = "0x188721B30", Slot = "13")]
		public void QOAVKFNPOZO(string? sessionId, ResponseEventDTO a, float? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8721670", Offset = "0x8720270", VA = "0x188721670", Slot = "14")]
		public void IRPBAWLXPHE(Func<NKNMZIGJWYR.SJCYWDVYQIW, NKNMZIGJWYR.SJCYWDVYQIW> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8722E00", Offset = "0x8721A00", VA = "0x188722E00", Slot = "9")]
		public void XVJJZIONXPV(Func<NKNMZIGJWYR.SJCYWDVYQIW, NKNMZIGJWYR.SJCYWDVYQIW> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8722EB0", Offset = "0x8721AB0", VA = "0x188722EB0", Slot = "16")]
		public void YKJBNJIJPLQ(string? a, string reason, string? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class YOUHCWAWFQM : BSBXBMQIYNN
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public POMAPQGXAWT? VQJMXKMBVUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public decimal BFHLCSIEFPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8737EE0", Offset = "0x8736AE0", VA = "0x188737EE0")]
			get
			{
				return default(decimal);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string LNJRTGOJSOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public OYKLECPPHHI? IXMNDMUFZAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
		public void VYGNEYDOXTN(string? sessionId, string a, string b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "9")]
		public void XVJJZIONXPV(Func<NKNMZIGJWYR.SJCYWDVYQIW, NKNMZIGJWYR.SJCYWDVYQIW> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "10")]
		public void ZSJPGXLXNMP(string? sessionId, ErrorEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "11")]
		public void UKJAFZPNOHT(string? sessionId, decimal a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "12")]
		public void XMXJEMETTSC(string? sessionId, ConversationItemDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "15")]
		public void GCGJLKGRUSI(string? sessionId, ResponseEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "13")]
		public void QOAVKFNPOZO(string? sessionId, ResponseEventDTO a, float? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "14")]
		public void IRPBAWLXPHE(Func<NKNMZIGJWYR.SJCYWDVYQIW, NKNMZIGJWYR.SJCYWDVYQIW> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "16")]
		public void YKJBNJIJPLQ(string? a, string reason, string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x28249D0", Offset = "0x28235D0", VA = "0x1828249D0")]
		public YOUHCWAWFQM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class GFPRYTZMVAE : LREDLEKRSAI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <TrySyncLatestCostInfo>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public WFSBWHDMOYH recNetAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public GFPRYTZMVAE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public Guid spendSessionId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public long roomInstanceId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private TaskAwaiter<OTGRJKXMVDS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8734F60", Offset = "0x8733B60", VA = "0x188734F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x87352E0", Offset = "0x8733EE0", VA = "0x1887352E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string NUIBDWPVUBC;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8720170", Offset = "0x871ED70", VA = "0x188720170")]
		public GFPRYTZMVAE(WFSBWHDMOYH a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8720010", Offset = "0x871EC10", VA = "0x188720010", Slot = "6")]
		[AsyncStateMachine(typeof(<TrySyncLatestCostInfo>d__2))]
		protected override Task<bool> TrySyncLatestCostInfo(WFSBWHDMOYH recNetAI, Guid spendSessionId, long roomId, long roomInstanceId, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface MOWDOXPORQG
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		HWNZTWGRXOC<ConversationItemDTO> FTKAQEQKDJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		IReadOnlyList<ConversationItemDTO> XYMDCAUJAZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<string> OAKSJDSJWLT(ConversationItemDTO a);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WTOUGCNYISI(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface DTCWUDJHATP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task GGKHRNQWCFW(IReadOnlyCollection<string> a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface HYUCSBDIOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ToolDTO[] VROBKHFTEQV();

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<string> NESNMJSICGM(string a, string b, CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface YVHMHVQECUL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface OYKLECPPHHI
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		const string KRYTPPJCMAE = "gpt-4o-mini-realtime-preview-2024-12-17";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		const string OGRIFQXGYDR = "gpt-4o-mini-transcribe";

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		SBVWTEFNUGH XJYHLSYUBGH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		AudioSource HLFIZRNJRTK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		MOWDOXPORQG? OXREHNDUJCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		DTCWUDJHATP? SPVMGDBRCRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		string? MBMPHMKIHEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IsSupportedOnCurrentPlatform
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IsSupportedInCurrentRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IsTextChatSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool HUZCELRYAUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool XUMFNZFIJZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool KBNLHGQMLEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool FQLBGPVRUAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool LXEFOARHBFF
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool UKEVOWHGXJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool WDSKRTHCQCY
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool DYRATQXBWQI
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool BEHAZZVDDAH
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		HWNZTWGRXOC<bool> JSLZYIVHCGU
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		AQWXMNIFQIV KUABTVFVNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		AQWXMNIFQIV LULJXBVXFRE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		HWISWPMUOCT<string, string> VBJKPKNSTBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		AQWXMNIFQIV ATLLDIPXTCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		AQWXMNIFQIV JXDWVQDSNHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		HWNZTWGRXOC<List<ToolDTO>> QDSHSXTOKZE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		AQWXMNIFQIV XIZUXALZFWX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		HWISWPMUOCT<float, string> FHOJQLREVTH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		HWNZTWGRXOC<string> FMPAOTJINZI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		string LNJRTGOJSOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(Slot = "52")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		bool MRSVSPJCDJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "53")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "54")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Task Connect(string instructions, VoiceOption voice, float temperature = 0.6f, string realtimeModel = "gpt-4o-mini-realtime-preview-2024-12-17", string transcriptionModel = "gpt-4o-mini-transcribe", [Optional] IReadOnlyCollection<string>? conversationHistory, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void Disconnect();

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Task GCFYEPWDZNP(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Task ORVTTZRXDFY(float a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task IDZAHTGOFVD(bool a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void BKZXWEWIGET(params YVHMHVQECUL[] serviceProviders);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool WBQSMWWLZZH(YVHMHVQECUL a);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void RMQINZQTSMI(params YVHMHVQECUL[] serviceProviders);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void QVHCCQGSDMO(Token a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void WEXYJISULMH(Token a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void PLGSTLNAKHG(Token a);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void YHRFUSZHERD(Token a);

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void FRRFTGSSDKI(decimal a, string b);

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task ZUKAFQGLZRV(byte[] a, string? transcript, [Optional] string? conversationItemId, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "41")]
		Task ZUKAFQGLZRV(string a, [Optional] string? conversationItemId, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task TSHERWCGZBP(string a, [Optional] string? conversationItemId, [Optional] string? previousItemId, bool b = false, bool c = false, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task WTOUGCNYISI(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<ResponseDTO> NVHIEPYGVWV(bool a = true, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task<string> WKNYBBXSLOP(string a, [Optional] IReadOnlyList<ConversationItemDTO>? conversation, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task<a> WKNYBBXSLOP<a>(string a, [Optional] IReadOnlyList<ConversationItemDTO>? conversation, [Optional] CancellationToken b) where a : class;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "47")]
		Task<List<Arg>> WKNYBBXSLOP(string a, IReadOnlyList<ConversationItemDTO>? conversation, IReadOnlyList<ArgSchema> b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "48")]
		bool GPTLCXXWAPQ(string a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "49")]
		bool VKYDDNJTFYA(string a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "50")]
		bool FFGKMBEMFXM(string a);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "51")]
		Task HNKAGQUSTCM(bool a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "55")]
		IReadOnlyCollection<string> SOKFAXVXPCY();

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "56")]
		MJEFJGYDAOX LDWJZXGVNGJ();

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "57")]
		Task<string> YDSGUMONKMP(string a, string b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface BSBXBMQIYNN
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		POMAPQGXAWT? VQJMXKMBVUO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		string LNJRTGOJSOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VYGNEYDOXTN(string? sessionId, string a, string b, float c);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XVJJZIONXPV(Func<NKNMZIGJWYR.SJCYWDVYQIW, NKNMZIGJWYR.SJCYWDVYQIW> a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZSJPGXLXNMP(string? sessionId, ErrorEventDTO a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void UKJAFZPNOHT(string? sessionId, decimal a, string b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void XMXJEMETTSC(string? sessionId, ConversationItemDTO a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void QOAVKFNPOZO(string? sessionId, ResponseEventDTO a, float? b);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void IRPBAWLXPHE(Func<NKNMZIGJWYR.SJCYWDVYQIW, NKNMZIGJWYR.SJCYWDVYQIW> a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void GCGJLKGRUSI(string? sessionId, ResponseEventDTO a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void YKJBNJIJPLQ(string? a, string reason, string? b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface RQEPBRLQQFC
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public delegate void ProcessAudioFrame(ReadOnlySpan<float> samples, int channels, int sampleRate);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZIOXGLZOJOY(ProcessAudioFrame a);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BSYNQJUSMPF(ProcessAudioFrame a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface WWKJJEHEDTU
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RRNPTZGJSWN(decimal a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class TLHZCTIBVSZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private enum JsonPropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			array,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			boolean,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			@enum,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			integer,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			number,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			@object,
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			@string
		}

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static ConcurrentDictionary<Type, JsonSchema> AENUCFHZFHN;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly Type[] ITTBGLNFSUC;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly Type[] DUOLMIVFRWZ;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4037570", Offset = "0x4036170", VA = "0x184037570")]
		public static JsonSchema Get<T>() where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x872B610", Offset = "0x872A210", VA = "0x18872B610")]
		public static JsonSchema LROZNIJKMZC(IReadOnlyList<ArgSchema> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x872B1B0", Offset = "0x8729DB0", VA = "0x18872B1B0")]
		private static JsonSchema CUUAVZLYXCN(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x872AC20", Offset = "0x8729820", VA = "0x18872AC20")]
		private static JsonSchema AXFGDEABIVQ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x872B940", Offset = "0x872A540", VA = "0x18872B940")]
		private static JsonPropertyType LWFWGCPFICE(Type a, [Out] Type? itemType)
		{
			return default(JsonPropertyType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x872BB20", Offset = "0x872A720", VA = "0x18872BB20")]
		private static bool PRAQEJXZABA(Type a, [Out][MaybeNullWhen(false)] Type elementType)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class XVWYFFLFAGL : YVHMHVQECUL, HYUCSBDIOLI
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate Task<string> FunctionCallDelegate(List<Arg> arguments);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <RecRoom-AI-IRecRoomAIServiceHandler-ExecuteFunctionCall>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public string methodName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public XVWYFFLFAGL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public string methodArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8730150", Offset = "0x872ED50", VA = "0x188730150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8730770", Offset = "0x872F370", VA = "0x188730770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly string YRAOTLCSPLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly string XNEPNPVGMBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly IReadOnlyList<ArgSchema> IIBATRHPIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly FunctionCallDelegate RKHUUJPVNXM;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x11F0770", Offset = "0x11EF370", VA = "0x1811F0770")]
		public XVWYFFLFAGL(string a, string b, IReadOnlyList<ArgSchema> c, FunctionCallDelegate d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8737D50", Offset = "0x8736950", VA = "0x188737D50", Slot = "4")]
		private ToolDTO[] TJRBAITTNUT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8737C10", Offset = "0x8736810", VA = "0x188737C10", Slot = "5")]
		[AsyncStateMachine(typeof(<RecRoom-AI-IRecRoomAIServiceHandler-ExecuteFunctionCall>d__7))]
		private Task<string> RTHPOVPGDGG(string a, string b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class RecRoomAIFunctionAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public RecRoomAIFunctionAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RecRoomAINotSupportedException : Exception, KXIWHZSEGUA
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string UserFriendlyErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x4482DF0", Offset = "0x44819F0", VA = "0x184482DF0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8729610", Offset = "0x8728210", VA = "0x188729610")]
		public RecRoomAINotSupportedException(string userFacingSystemName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class QONEIUXEJBP : OYKLECPPHHI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private enum ConnectionState
		{
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			NotConnected,
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			Connecting,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			Connected
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class GIMEOCKNDAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public ResponseDTO EVGFJTUBHNY;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GIMEOCKNDAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x87201F0", Offset = "0x871EDF0", VA = "0x1887201F0")]
			internal bool LHPOCWOOZIT(OutputAudioBufferEventDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class YPHWJQPWKXU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public QONEIUXEJBP VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public ResponseCreateEventDTO ZBJBQRAIHHQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public string KGOJFCHDRGI;

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public YPHWJQPWKXU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8737F40", Offset = "0x8736B40", VA = "0x188737F40")]
			internal void WGGXEYXHWKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8738030", Offset = "0x8736C30", VA = "0x188738030")]
			internal bool WGMECFRFFVX(ResponseEventDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class GJHBZQLSGXR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public QONEIUXEJBP VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public CancellationToken AOXLOEXRQNR;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GJHBZQLSGXR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8720220", Offset = "0x871EE20", VA = "0x188720220")]
			internal Task FSVMGXQTJKJ(ConversationItemDTO a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct <ConnectInternal>d__156 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public int? reconnectAttempt;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private CancellationTokenSource <cts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private CancellationToken <originalCancellationToken>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private IDisposable <combinedTokenDisposer>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private string <instructions>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private float <temperature>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private TaskAwaiter<SBVWTEFNUGH> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<bool> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x872C300", Offset = "0x872AF00", VA = "0x18872C300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x872E5D0", Offset = "0x872D1D0", VA = "0x18872E5D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private struct <DebugExecuteFunction>d__190 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public string arguments;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x872E630", Offset = "0x872D230", VA = "0x18872E630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x872EAC0", Offset = "0x872D6C0", VA = "0x18872EAC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private struct <ExecuteFunctionCall>d__203 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public ConversationItemDTO item;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x872EB30", Offset = "0x872D730", VA = "0x18872EB30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x872EDD0", Offset = "0x872D9D0", VA = "0x18872EDD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct <ExecuteFunctionCalls>d__202 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public ResponseDTO response;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private GJHBZQLSGXR <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x872EE30", Offset = "0x872DA30", VA = "0x18872EE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x872F5B0", Offset = "0x872E1B0", VA = "0x18872F5B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private struct <OnResponseCreated>d__197 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public ResponseEventDTO ev;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			private string <responseId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x872F610", Offset = "0x872E210", VA = "0x18872F610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private struct <RemoveMessage>d__178 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public string convresationItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x87307E0", Offset = "0x872F3E0", VA = "0x1887307E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8730CF0", Offset = "0x872F8F0", VA = "0x188730CF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private struct <RequestOutOfBandResponse>d__183 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public string instructions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public IReadOnlyList<ConversationItemDTO> conversation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x87315E0", Offset = "0x87301E0", VA = "0x1887315E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8731B50", Offset = "0x8730750", VA = "0x188731B50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct <RequestOutOfBandResponse>d__184<TOutput> : IAsyncStateMachine where TOutput : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public AsyncTaskMethodBuilder<TOutput> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public string instructions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public IReadOnlyList<ConversationItemDTO> conversation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x55F70A0", Offset = "0x55F5CA0", VA = "0x1855F70A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x55F7820", Offset = "0x55F6420", VA = "0x1855F7820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct <RequestOutOfBandResponse>d__185 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public AsyncTaskMethodBuilder<List<Arg>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public IReadOnlyList<ArgSchema> responseArgSchemas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public string instructions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public IReadOnlyList<ConversationItemDTO> conversation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8731BC0", Offset = "0x87307C0", VA = "0x188731BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8732260", Offset = "0x8730E60", VA = "0x188732260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private struct <RequestOutOfBandResponseInternal>d__186 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public AsyncTaskMethodBuilder<List<ConversationItemDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public string instructions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public IReadOnlyList<ConversationItemDTO> conversation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public JsonSchema responseSchema;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private TaskAwaiter<ResponseEventDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8730D50", Offset = "0x872F950", VA = "0x188730D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8731570", Offset = "0x8730170", VA = "0x188731570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private struct <RequestResponse>d__182 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			private GIMEOCKNDAK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public bool waitForAudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private TaskAwaiter<ResponseDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private TaskAwaiter<OutputAudioBufferEventDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x87322D0", Offset = "0x8730ED0", VA = "0x1887322D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8732AE0", Offset = "0x87316E0", VA = "0x188732AE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private struct <RequestServerResponseInternal>d__204 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private TaskAwaiter<ResponseDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8732B50", Offset = "0x8731750", VA = "0x188732B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8732EB0", Offset = "0x8731AB0", VA = "0x188732EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private struct <Restart>d__160 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public bool keepConversationHistory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8732F20", Offset = "0x8731B20", VA = "0x188732F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8733130", Offset = "0x8731D30", VA = "0x188733130", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct <RunSessionExpirationHandler>d__187 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public DateTime expirationTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8733550", Offset = "0x8732150", VA = "0x188733550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8733930", Offset = "0x8732530", VA = "0x188733930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct <SendSystemMessage>d__177 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public string conversationItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public bool suppressFromConversationLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool excludeFromConversationPruning;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public string message;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public string previousItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8733990", Offset = "0x8732590", VA = "0x188733990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8733EE0", Offset = "0x8732AE0", VA = "0x188733EE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct <SendUserMessage>d__175 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public string conversationItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public byte[] pcmAudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public string transcript;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x8733F40", Offset = "0x8732B40", VA = "0x188733F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x87343B0", Offset = "0x8732FB0", VA = "0x1887343B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private struct <SendUserMessage>d__176 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public string conversationItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public string message;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x8734410", Offset = "0x8733010", VA = "0x188734410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x8734880", Offset = "0x8733480", VA = "0x188734880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private struct <SetOutputAudioEnabled>d__165 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public bool enabled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x87348E0", Offset = "0x87334E0", VA = "0x1887348E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x8734BF0", Offset = "0x87337F0", VA = "0x188734BF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct <UpdateAutomaticVoiceResponse>d__164 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public bool enabled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8736060", Offset = "0x8734C60", VA = "0x188736060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x8736270", Offset = "0x8734E70", VA = "0x188736270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct <UpdateInstructions>d__162 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public string instructions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x87362D0", Offset = "0x8734ED0", VA = "0x1887362D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x8736500", Offset = "0x8735100", VA = "0x188736500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct <UpdateSessionToolConfiguration>d__194 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private List<ToolDTO> <tools>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x8736560", Offset = "0x8735160", VA = "0x188736560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x8736B80", Offset = "0x8735780", VA = "0x188736B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct <UpdateTemperature>d__163 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public float temperature;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x8736BE0", Offset = "0x87357E0", VA = "0x188736BE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8736DF0", Offset = "0x87359F0", VA = "0x188736DF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct <WaitForCurrentResponseToFinishAndThenRequestResponse>d__205 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public QONEIUXEJBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			private CancellationToken <cancellationToken>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			private DateTime? <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			private TaskAwaiter<ResponseDTO> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x8736E50", Offset = "0x8735A50", VA = "0x188736E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x87379B0", Offset = "0x87365B0", VA = "0x1887379B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly Log NPHEYIXDMFH;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const ToolChoice IYNHUTESDAH = ToolChoice.Auto;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private const float ZWEKOGDOVUU = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly TimeSpan[] NIMDRCLEEDM;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly TimeSpan XXXCBBQORTI;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly TimeSpan UNKIPCQXGBI;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly TimeSpan RMFHRDXUFYT;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TimeSpan FQRYHVKJCAB;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly TimeSpan TYCWBDSYXAK;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly TimeSpan GLHESVTFIPG;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private const string ZDHWIYCFCPK = "out-of-band-id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly ZODQAHISQFL IKNNDLVMRXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly RQEPBRLQQFC DJNGXCCFUEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		protected readonly WFSBWHDMOYH YIXIDMLSGXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly PAGAAEURHSN UMPTWLTGVGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly OKOYROTTXMC TNJSYDJDXOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly OKOYROTTXMC ESYRLYQDNBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly Dictionary<string, DateTime> PRRINRHKKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly Lazy<BSBXBMQIYNN> HZCJXECUQZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly WXKDNWJVUWB? QIZSRFFXVZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private string CREERPFGIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private VoiceOption RJGEWOJYVXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private float ETULHVFSEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private string DTTHZTGLLAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private string HCUTKWIYXID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private ConnectionState JLKDVULQQGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private CancellationTokenSource? NDXXQCRYFNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		protected SBVWTEFNUGH? MHBCMMORBYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private AudioSource PAODXVAZBSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private AudioSourceSimpleLevelMeter? BVHHODQTTDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private SUISFXDRLOF? SGXCDOETZVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private QBKAPKDIAGK? JCWIIPIMDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private ZROUOEBMAZX? BSNHUMXVSQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private CBLBNJWZZAW? DSAIAHVYLDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IReadOnlyCollection<string> HQKFIUFTNEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private DateTime? WGQNNOIHRZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private Task<ResponseDTO>? GCBDHEYAJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private uint MCVHWDYRYZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly HashSet<string> NQLDWOTTRHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly HashSet<string> BVFFMVRLAYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly HashSet<string> OHPVQPKTGUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool XCDPWUHMSNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Token? SMPWFGUFODZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool BXRVDOLLQJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private CancellationTokenSource? MPFCASDPQWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private string? FBVVJAUIWZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly MJEFJGYDAOX QVOQLGSDBJZ;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public SBVWTEFNUGH XJYHLSYUBGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8726D50", Offset = "0x8725950", VA = "0x188726D50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string? MBMPHMKIHEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8727540", Offset = "0x8726140", VA = "0x188727540", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public abstract bool IsSupportedOnCurrentPlatform
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "64")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public abstract bool IsSupportedInCurrentRoom
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "65")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public abstract bool IsTextChatSupported
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected abstract bool UploadTranscripts
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "67")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected abstract string? TranscriptLogFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "68")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected abstract string ConversationPrunerSingletonFunctionNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected abstract int ConversationPrunerMaxConversationSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected abstract int ConversationPrunerBatchSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "71")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected abstract Channel AudioChannel
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(Slot = "72")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected abstract string AISystemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(Slot = "73")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected virtual bool AutoSummarizePreviousConversation
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "74")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool HUZCELRYAUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8725450", Offset = "0x8724050", VA = "0x188725450", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool XUMFNZFIJZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x87259E0", Offset = "0x87245E0", VA = "0x1887259E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool KBNLHGQMLEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x87273A0", Offset = "0x8725FA0", VA = "0x1887273A0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool FQLBGPVRUAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xBD7AA0", Offset = "0xBD66A0", VA = "0x180BD7AA0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xC35E00", Offset = "0xC34A00", VA = "0x180C35E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool LXEFOARHBFF
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8726CA0", Offset = "0x87258A0", VA = "0x188726CA0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool UKEVOWHGXJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8726C50", Offset = "0x8725850", VA = "0x188726C50", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool WDSKRTHCQCY
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x25409C0", Offset = "0x253F5C0", VA = "0x1825409C0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool DYRATQXBWQI
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x87253E0", Offset = "0x8723FE0", VA = "0x1887253E0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool BEHAZZVDDAH
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8726B40", Offset = "0x8725740", VA = "0x188726B40", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		private bool FMXGGOEKDBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8727430", Offset = "0x8726030", VA = "0x188727430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		private bool EYHTKSRLGLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8727000", Offset = "0x8725C00", VA = "0x188727000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		private bool KNTRDBBYIFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2B54440", Offset = "0x2B53040", VA = "0x182B54440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool MRSVSPJCDJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2444E70", Offset = "0x2443A70", VA = "0x182444E70", Slot = "57")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2444A00", Offset = "0x2443600", VA = "0x182444A00", Slot = "58")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private uint VJTAUNFKITG
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xBB6DA0", Offset = "0xBB59A0", VA = "0x180BB6DA0")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8726F90", Offset = "0x8725B90", VA = "0x188726F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public AudioSource HLFIZRNJRTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public MOWDOXPORQG? OXREHNDUJCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public DTCWUDJHATP? SPVMGDBRCRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xB1B710", Offset = "0xB1A310", VA = "0x180B1B710", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string LNJRTGOJSOL
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8727930", Offset = "0x8726530", VA = "0x188727930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8725890", Offset = "0x8724490", VA = "0x188725890", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		protected virtual string? VOHWVQCLJNS
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xC088A0", Offset = "0xC074A0", VA = "0x180C088A0", Slot = "75")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		protected virtual Log? EEXGSBBOSJA
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "76")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected virtual Log? ZCGBCPSYIQD
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "77")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public HWNZTWGRXOC<bool> JSLZYIVHCGU
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xC08550", Offset = "0xC07150", VA = "0x180C08550", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public AQWXMNIFQIV KUABTVFVNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xC8F330", Offset = "0xC8DF30", VA = "0x180C8F330", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public AQWXMNIFQIV LULJXBVXFRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xC8F320", Offset = "0xC8DF20", VA = "0x180C8F320", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public HWISWPMUOCT<string, string> VBJKPKNSTBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xC8EDD0", Offset = "0xC8D9D0", VA = "0x180C8EDD0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public HWNZTWGRXOC<List<ToolDTO>> QDSHSXTOKZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xC8E010", Offset = "0xC8CC10", VA = "0x180C8E010", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public AQWXMNIFQIV ATLLDIPXTCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xC8E030", Offset = "0xC8CC30", VA = "0x180C8E030", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public AQWXMNIFQIV JXDWVQDSNHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xC8DF90", Offset = "0xC8CB90", VA = "0x180C8DF90", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public AQWXMNIFQIV XIZUXALZFWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xC8DFF0", Offset = "0xC8CBF0", VA = "0x180C8DFF0", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public HWISWPMUOCT<float, string> FHOJQLREVTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xC8E1D0", Offset = "0xC8CDD0", VA = "0x180C8E1D0", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public HWNZTWGRXOC<string> FMPAOTJINZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xC8E000", Offset = "0xC8CC00", VA = "0x180C8E000", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8728E00", Offset = "0x8727A00", VA = "0x188728E00")]
		public QONEIUXEJBP(ZODQAHISQFL a, RQEPBRLQQFC b, WFSBWHDMOYH c, [Optional] WXKDNWJVUWB? realtimeSessionCallbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "63")]
		protected abstract BSBXBMQIYNN CreateDataReporter();

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8723FA0", Offset = "0x8722BA0", VA = "0x188723FA0")]
		private void AACDRLXVESY(YVHMHVQECUL a, HYUCSBDIOLI? handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8724680", Offset = "0x8723280", VA = "0x188724680", Slot = "31")]
		public Task Connect(string instructions, VoiceOption voice, float temperature, string realtimeModel, string transcriptionModel, [Optional] IReadOnlyCollection<string>? conversationHistory, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8726570", Offset = "0x8725170", VA = "0x188726570")]
		[AsyncStateMachine(typeof(<ConnectInternal>d__156))]
		private Task HTZQBFSJEDG(int? a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x87245F0", Offset = "0x87231F0", VA = "0x1887245F0", Slot = "78")]
		protected virtual Task CheckAccess(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8727D00", Offset = "0x8726900", VA = "0x188727D00", Slot = "79")]
		protected virtual Task<bool> UploadTranscriptsForModeration(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x87247F0", Offset = "0x87233F0", VA = "0x1887247F0", Slot = "32")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8726460", Offset = "0x8725060", VA = "0x188726460", Slot = "55")]
		[AsyncStateMachine(typeof(<Restart>d__160))]
		public Task HNKAGQUSTCM(bool a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8725280", Offset = "0x8723E80", VA = "0x188725280", Slot = "80")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8725780", Offset = "0x8724380", VA = "0x188725780", Slot = "33")]
		[AsyncStateMachine(typeof(<UpdateInstructions>d__162))]
		public Task GCFYEPWDZNP(string a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8727190", Offset = "0x8725D90", VA = "0x188727190", Slot = "34")]
		[AsyncStateMachine(typeof(<UpdateTemperature>d__163))]
		public Task ORVTTZRXDFY(float a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8727590", Offset = "0x8726190", VA = "0x188727590")]
		[AsyncStateMachine(typeof(<UpdateAutomaticVoiceResponse>d__164))]
		public Task QTKVCMWVLIA(bool a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8726690", Offset = "0x8725290", VA = "0x188726690", Slot = "35")]
		[AsyncStateMachine(typeof(<SetOutputAudioEnabled>d__165))]
		public Task IDZAHTGOFVD(bool a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8724320", Offset = "0x8722F20", VA = "0x188724320", Slot = "36")]
		public void BKZXWEWIGET(params YVHMHVQECUL[] serviceProviders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8727EB0", Offset = "0x8726AB0", VA = "0x188727EB0", Slot = "37")]
		public bool WBQSMWWLZZH(YVHMHVQECUL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x87278B0", Offset = "0x87264B0", VA = "0x1887278B0", Slot = "38")]
		public void RMQINZQTSMI(params YVHMHVQECUL[] serviceProviders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x87276A0", Offset = "0x87262A0", VA = "0x1887276A0", Slot = "39")]
		public void QVHCCQGSDMO(Token a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8727F70", Offset = "0x8726B70", VA = "0x188727F70", Slot = "40")]
		public void WEXYJISULMH(Token a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8727360", Offset = "0x8725F60", VA = "0x188727360", Slot = "41")]
		public void PLGSTLNAKHG(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8728900", Offset = "0x8727500", VA = "0x188728900", Slot = "42")]
		public void YHRFUSZHERD(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x87279A0", Offset = "0x87265A0", VA = "0x1887279A0", Slot = "59")]
		public IReadOnlyCollection<string> SOKFAXVXPCY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x87254E0", Offset = "0x87240E0", VA = "0x1887254E0", Slot = "43")]
		public void FRRFTGSSDKI(decimal a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8728A80", Offset = "0x8727680", VA = "0x188728A80", Slot = "44")]
		[AsyncStateMachine(typeof(<SendUserMessage>d__175))]
		public Task ZUKAFQGLZRV(byte[] a, string? transcript, string? conversationItemId, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8728940", Offset = "0x8727540", VA = "0x188728940", Slot = "45")]
		[AsyncStateMachine(typeof(<SendUserMessage>d__176))]
		public Task ZUKAFQGLZRV(string a, string? conversationItemId, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8727AA0", Offset = "0x87266A0", VA = "0x188727AA0", Slot = "46")]
		[AsyncStateMachine(typeof(<SendSystemMessage>d__177))]
		public Task TSHERWCGZBP(string a, string? conversationItemId, string? previousItemId, bool b, bool c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x87283C0", Offset = "0x8726FC0", VA = "0x1887283C0", Slot = "47")]
		[AsyncStateMachine(typeof(<RemoveMessage>d__178))]
		public Task WTOUGCNYISI(string a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8725980", Offset = "0x8724580", VA = "0x188725980", Slot = "52")]
		public bool GPTLCXXWAPQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8727D60", Offset = "0x8726960", VA = "0x188727D60", Slot = "53")]
		public bool VKYDDNJTFYA(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8725460", Offset = "0x8724060", VA = "0x188725460", Slot = "54")]
		public bool FFGKMBEMFXM(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8727050", Offset = "0x8725C50", VA = "0x188727050", Slot = "48")]
		[AsyncStateMachine(typeof(<RequestResponse>d__182))]
		public Task<ResponseDTO> NVHIEPYGVWV(bool a = true, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8727FE0", Offset = "0x8726BE0", VA = "0x188727FE0", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestOutOfBandResponse>d__183))]
		public Task<string> WKNYBBXSLOP(string a, [Optional] IReadOnlyList<ConversationItemDTO>? conversation, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3F0BFE0", Offset = "0x3F0ABE0", VA = "0x183F0BFE0", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestOutOfBandResponse>d__184<>))]
		public Task<a> WKNYBBXSLOP<a>(string a, [Optional] IReadOnlyList<ConversationItemDTO>? conversation, [Optional] CancellationToken b) where a : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8728140", Offset = "0x8726D40", VA = "0x188728140", Slot = "51")]
		[AsyncStateMachine(typeof(<RequestOutOfBandResponse>d__185))]
		public Task<List<Arg>> WKNYBBXSLOP(string a, IReadOnlyList<ConversationItemDTO>? conversation, IReadOnlyList<ArgSchema> b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x87267A0", Offset = "0x87253A0", VA = "0x1887267A0")]
		[AsyncStateMachine(typeof(<RequestOutOfBandResponseInternal>d__186))]
		private Task<List<ConversationItemDTO>> IEOVEYQYDVQ(string a, IReadOnlyList<ConversationItemDTO>? conversation, JsonSchema? responseSchema, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8726A30", Offset = "0x8725630", VA = "0x188726A30")]
		[AsyncStateMachine(typeof(<RunSessionExpirationHandler>d__187))]
		private Task JFRDPEIZKYZ(DateTime a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xC8DF80", Offset = "0xC8CB80", VA = "0x180C8DF80", Slot = "60")]
		public MJEFJGYDAOX LDWJZXGVNGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x87287A0", Offset = "0x87273A0", VA = "0x1887287A0", Slot = "61")]
		[AsyncStateMachine(typeof(<DebugExecuteFunction>d__190))]
		public Task<string> YDSGUMONKMP(string a, string b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x87243A0", Offset = "0x8722FA0", VA = "0x1887243A0")]
		private bool CUAEZUHOZPO(ResponseDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8727ED0", Offset = "0x8726AD0", VA = "0x188727ED0")]
		private void WCIKNDMYWZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8727A00", Offset = "0x8726600", VA = "0x188727A00")]
		private void TAROCIBDEYX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8727DC0", Offset = "0x87269C0", VA = "0x188727DC0")]
		[AsyncStateMachine(typeof(<UpdateSessionToolConfiguration>d__194))]
		private Task VODOFEZUVFC([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8726B60", Offset = "0x8725760", VA = "0x188726B60")]
		private void JQIAPDXKMND(ReadOnlySpan<float> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x87272A0", Offset = "0x8725EA0", VA = "0x1887272A0")]
		private void PKVQHKADIDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8724720", Offset = "0x8723320", VA = "0x188724720")]
		[AsyncStateMachine(typeof(<OnResponseCreated>d__197))]
		private void DPDQMRRHCWN(ResponseEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8725640", Offset = "0x8724240", VA = "0x188725640")]
		private void FTKAQEQKDJR(ConversationItemDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3F0BEA0", Offset = "0x3F0AAA0", VA = "0x183F0BEA0")]
		private void GVTOAMPIRYD<T>(T a) where T : notnull, XZNINAHYSIP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8725A50", Offset = "0x8724650", VA = "0x188725A50")]
		private void HILKLHLGCCP(ResponseEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8728630", Offset = "0x8727230", VA = "0x188728630")]
		private void XSHNLDEGBNL(string a, string b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8726910", Offset = "0x8725510", VA = "0x188726910")]
		[AsyncStateMachine(typeof(<ExecuteFunctionCalls>d__202))]
		private Task JAUAYGNEYPD(ResponseDTO a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8726E80", Offset = "0x8725A80", VA = "0x188726E80")]
		[AsyncStateMachine(typeof(<ExecuteFunctionCall>d__203))]
		private Task NESNMJSICGM(ConversationItemDTO a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8727BF0", Offset = "0x87267F0", VA = "0x188727BF0")]
		[AsyncStateMachine(typeof(<RequestServerResponseInternal>d__204))]
		private Task<ResponseDTO> USERZOQQFQP(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x87282B0", Offset = "0x8726EB0", VA = "0x1887282B0")]
		[AsyncStateMachine(typeof(<WaitForCurrentResponseToFinishAndThenRequestResponse>d__205))]
		private Task<ResponseDTO> WRQQFFWZVWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8727710", Offset = "0x8726310", VA = "0x188727710")]
		private void RAPOLPKUMOK(ErrorEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x87253B0", Offset = "0x8723FB0", VA = "0x1887253B0")]
		private void EDQAWAWDQIH(InputAudioBufferSpeechStartedEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8726DF0", Offset = "0x87259F0", VA = "0x188726DF0")]
		private void MDCXXWMCFCL(InputAudioBufferSpeechStoppedEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x87284E0", Offset = "0x87270E0", VA = "0x1887284E0")]
		protected void XJRVOCWUUIX(string a, [Optional] string? metadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8726CE0", Offset = "0x87258E0", VA = "0x188726CE0")]
		private bool KZQZDLJQJVM(ResponseDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8725430", Offset = "0x8724030", VA = "0x188725430")]
		protected void EKNFJXHBYER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8726CA0", Offset = "0x87258A0", VA = "0x188726CA0")]
		[CompilerGenerated]
		private bool KURZBLAXHPM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8727850", Offset = "0x8726450", VA = "0x188727850")]
		[CompilerGenerated]
		private bool RLFCFDKXQMV()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class NEVEYPQVSKC : LREDLEKRSAI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct <TrySyncLatestCostInfo>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public WFSBWHDMOYH recNetAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public NEVEYPQVSKC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public Guid spendSessionId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public long roomInstanceId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			private TaskAwaiter<OTGRJKXMVDS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x8735350", Offset = "0x8733F50", VA = "0x188735350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x8735810", Offset = "0x8734410", VA = "0x188735810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly OYKLECPPHHI NWHHLHSXQKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private readonly string NUIBDWPVUBC;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8723B00", Offset = "0x8722700", VA = "0x188723B00")]
		public NEVEYPQVSKC(OYKLECPPHHI a, WFSBWHDMOYH b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x87239A0", Offset = "0x87225A0", VA = "0x1887239A0", Slot = "6")]
		[AsyncStateMachine(typeof(<TrySyncLatestCostInfo>d__3))]
		protected override Task<bool> TrySyncLatestCostInfo(WFSBWHDMOYH recNetAI, Guid spendSessionId, long roomId, long roomInstanceId, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
namespace RecRoom.AI.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public class HasServiceHandlerFactoryAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public HasServiceHandlerFactoryAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public interface TJSYKHFDGRW
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NNWIWFKFKPE(YVHMHVQECUL a, [Out] HYUCSBDIOLI b);
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class IUKZHOEGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class WPIXLPGCJVJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public PropertyInfo BRBQRMYNVPC
			{
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public Type VKVIOUJPFWY
			{
				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x7A13AB0", Offset = "0x7A126B0", VA = "0x187A13AB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public string ZNXIKLDTION
			{
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public bool OJTVOFSMDGY
			{
				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0xB13220", Offset = "0xB11E20", VA = "0x180B13220")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public Type? VEINDOEETIR
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x8737A20", Offset = "0x8736620", VA = "0x188737A20")]
			public WPIXLPGCJVJ(PropertyInfo a, JsonPropertyAttribute? jsonPropertyAttribute)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private static readonly ConcurrentDictionary<Type, List<WPIXLPGCJVJ>> QCDLPWDRVTA;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8720CD0", Offset = "0x871F8D0", VA = "0x188720CD0")]
		public static List<string> ZOHOQJTMNBA(string a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8720650", Offset = "0x871F250", VA = "0x188720650")]
		private static void REJHMBVWMJD(Type a, JObject b, List<string> c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8720340", Offset = "0x871EF40", VA = "0x188720340")]
		private static List<WPIXLPGCJVJ> BAFUTYLERDT(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8720C50", Offset = "0x871F850", VA = "0x188720C50")]
		private static bool SILKYDPMCJE(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public IUKZHOEGBJJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class ZROUOEBMAZX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public class Options
		{
			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public string? BZAAGWTCRMZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public int SHWUOKOKKXL
			{
				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0xB22FF0", Offset = "0xB21BF0", VA = "0x180B22FF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public int GGGJDKPBNWD
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x16E6ED0", Offset = "0x16E5AD0", VA = "0x1816E6ED0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x16E6EE0", Offset = "0x16E5AE0", VA = "0x1816E6EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8723C20", Offset = "0x8722820", VA = "0x188723C20")]
			public Options()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class ZUTKYPMGMHN
		{
			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public string AXUVQJAOTPO
			{
				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public ConversationItemType JGVJNZJVVLT
			{
				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
				[CompilerGenerated]
				get
				{
					return default(ConversationItemType);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0xB22FF0", Offset = "0xB21BF0", VA = "0x180B22FF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public string? HFVTPWKFDFG
			{
				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public string? QMZMPPIFWAW
			{
				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x8739230", Offset = "0x8737E30", VA = "0x188739230")]
			public ZUTKYPMGMHN(ConversationItemDTO a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class CITSQHBYTVL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public IEnumerable<string> OMYUCSAGCMD;

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CITSQHBYTVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x871FD50", Offset = "0x871E950", VA = "0x18871FD50")]
			internal bool HTUSCXRZZED(ZUTKYPMGMHN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class CIOLTAIBKKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public ZUTKYPMGMHN IBHXOZVWAZY;

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CIOLTAIBKKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x871FD10", Offset = "0x871E910", VA = "0x18871FD10")]
			internal bool HUFFXLFUSAV(string a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class QOCTNDBRPOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public ConversationItemDTO FAQPDUUDTIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public ZROUOEBMAZX VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOCTNDBRPOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x8723F60", Offset = "0x8722B60", VA = "0x188723F60")]
			internal bool IYHGLOQAFKN(string a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8723F10", Offset = "0x8722B10", VA = "0x188723F10")]
			internal bool IXWSRBCFMNV(ZUTKYPMGMHN a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8723CF0", Offset = "0x87228F0", VA = "0x188723CF0")]
			internal void BCASQFTOBZA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class CMIBJUZGHFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public IEnumerable<string?> HZKOKGIDWKI;

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CMIBJUZGHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x871FEC0", Offset = "0x871EAC0", VA = "0x18871FEC0")]
			internal bool LDIYYVYLWPH(ZUTKYPMGMHN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class CMCUMOFIXTS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public IEnumerable<string> ASWCNGXSRJC;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CMCUMOFIXTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x871FE60", Offset = "0x871EA60", VA = "0x18871FE60")]
			internal bool LCYLEIKRDSP(ZUTKYPMGMHN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class XLYSDAWRGEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public Queue<string> OWOTPXFXZCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public Func<bool> VNPNSVZAKTC;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XLYSDAWRGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8737BC0", Offset = "0x87367C0", VA = "0x188737BC0")]
			internal bool JEUGIGKAOWS()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private struct <ProcessConversationCleanupQueue>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public Queue<string> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			private XLYSDAWRGEK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public ZROUOEBMAZX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x872FBA0", Offset = "0x872E7A0", VA = "0x18872FBA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x87300F0", Offset = "0x872ECF0", VA = "0x1887300F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private readonly OYKLECPPHHI KKQEXXOMWSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly MOWDOXPORQG SGXCDOETZVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private readonly HashSet<string> GMSOIQUZGRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private readonly Options IHBUSOKPONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private readonly List<ZUTKYPMGMHN> HQKFIUFTNEL;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static Queue<string> XRPEIADEQEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly CancellationTokenSource VFJOWDLEFGV;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8738D50", Offset = "0x8737950", VA = "0x188738D50")]
		public ZROUOEBMAZX(OYKLECPPHHI a, MOWDOXPORQG b, Options c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x87380C0", Offset = "0x8736CC0", VA = "0x1887380C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8738550", Offset = "0x8737150", VA = "0x188738550")]
		public void HCLTYOCBZCJ(IEnumerable<string> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x87381A0", Offset = "0x8736DA0", VA = "0x1887381A0")]
		private void FTKAQEQKDJR(ConversationItemDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8738730", Offset = "0x8737330", VA = "0x188738730")]
		private void KZKIMJQTOYL(IEnumerable<string?> callIdsToRemove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8738BA0", Offset = "0x87377A0", VA = "0x188738BA0")]
		[AsyncStateMachine(typeof(<ProcessConversationCleanupQueue>d__14))]
		private Task PQUCSSWFPZI(Queue<string> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal class SUISFXDRLOF : MOWDOXPORQG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		internal class SPYDYRAWPKB
		{
			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public ConversationItemDTO TIKFJFNXMPY
			{
				[Cpp2IlInjected.Token(Token = "0x60001F8")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public bool TTVNXRVPPQN
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0xB69420", Offset = "0xB68020", VA = "0x180B69420")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(RVA = "0xB1A400", Offset = "0xB19000", VA = "0x180B1A400")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x16FEA50", Offset = "0x16FD650", VA = "0x1816FEA50")]
			public SPYDYRAWPKB(ConversationItemDTO a, bool b = false)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class IJBAKJDOGSK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public ConversationItemCreatedEventDTO GKFISIWCJUW;

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public IJBAKJDOGSK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x873B700", Offset = "0x873A300", VA = "0x18873B700")]
			internal bool IOHXVQWQWQL(SPYDYRAWPKB a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x873AD30", Offset = "0x8739930", VA = "0x18873AD30")]
			internal bool IONESXQOGBU(SPYDYRAWPKB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class VOMCTXEGQPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public ConversationItemDTO VVGWXUIUGTP;

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public VOMCTXEGQPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x873E550", Offset = "0x873D150", VA = "0x18873E550")]
			internal bool KOXTSVMDHRH(SPYDYRAWPKB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class TCPIQNKCSSB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public ConversationItemInputAudioTranscriptionCompletedEventDTO GKFISIWCJUW;

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TCPIQNKCSSB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x873AD30", Offset = "0x8739930", VA = "0x18873AD30")]
			internal bool ACUUATPBJFT(SPYDYRAWPKB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class TZPDHATRBYX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public ConversationItemDTO FAQPDUUDTIC;

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TZPDHATRBYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x873CDE0", Offset = "0x873B9E0", VA = "0x18873CDE0")]
			internal bool LQTVVJZRWHF(SPYDYRAWPKB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class OJDMKISOMTK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public string HHUAFXPBDVT;

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public OJDMKISOMTK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x24F3600", Offset = "0x24F2200", VA = "0x1824F3600")]
			internal bool USDRYICOGDW(ConversationItemDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class CUVDPTPUYLN : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private string DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private ConversationItemDTO FAQPDUUDTIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public ConversationItemDTO XHGFWOINMPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public SUISFXDRLOF VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private TZPDHATRBYX DLVHLELECQO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private List<ConversationItemContentDTO>.Enumerator OKMXNYRHUZP;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			private string DMWONALYXSM
			{
				[Cpp2IlInjected.Token(Token = "0x600020F")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public CUVDPTPUYLN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x873B670", Offset = "0x873A270", VA = "0x18873B670", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x873AD70", Offset = "0x8739970", VA = "0x18873AD70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x873B530", Offset = "0x873A130", VA = "0x18873B530")]
			private void QCWGZBRZQOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x873B580", Offset = "0x873A180", VA = "0x18873B580", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x873B5C0", Offset = "0x873A1C0", VA = "0x18873B5C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> YDQXJDTSKET()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x873B5C0", Offset = "0x873A1C0", VA = "0x18873B5C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private readonly QONEIUXEJBP KKQEXXOMWSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly SBVWTEFNUGH MHBCMMORBYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly Token CSWJFTXYMJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly List<SPYDYRAWPKB> PPUHFARUHHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly List<string> HQKFIUFTNEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly List<ConversationItemDTO> EPZDWAKCQTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private string? LONZXTIWQLA;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public HWNZTWGRXOC<ConversationItemDTO> FTKAQEQKDJR
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public IReadOnlyList<string> SIAFJASAPGG
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public IReadOnlyList<ConversationItemDTO> XYMDCAUJAZM
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x872A7A0", Offset = "0x87293A0", VA = "0x18872A7A0")]
		public SUISFXDRLOF(QONEIUXEJBP a, IReadOnlyCollection<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x87298D0", Offset = "0x87284D0", VA = "0x1887298D0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8729E60", Offset = "0x8728A60", VA = "0x188729E60")]
		public List<string> SOKFAXVXPCY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x872A2E0", Offset = "0x8728EE0", VA = "0x18872A2E0")]
		private void YEHLLILFSDS(ConversationItemCreatedEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8729B30", Offset = "0x8728730", VA = "0x188729B30")]
		private void HILKLHLGCCP(ResponseEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x872A050", Offset = "0x8728C50", VA = "0x18872A050")]
		private void WKJDNVFKIVF(ConversationItemInputAudioTranscriptionCompletedEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8729690", Offset = "0x8728290", VA = "0x188729690")]
		private void CEZJACSNSIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8729DD0", Offset = "0x87289D0", VA = "0x188729DD0", Slot = "6")]
		[IteratorStateMachine(typeof(CUVDPTPUYLN))]
		public IEnumerable<string> OAKSJDSJWLT(ConversationItemDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x872A200", Offset = "0x8728E00", VA = "0x18872A200", Slot = "7")]
		public void WTOUGCNYISI(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	internal class QBKAPKDIAGK : DTCWUDJHATP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private struct <SummarizePreviousConversation>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public IReadOnlyCollection<string> conversation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public QBKAPKDIAGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x873DDA0", Offset = "0x873C9A0", VA = "0x18873DDA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x873E230", Offset = "0x873CE30", VA = "0x18873E230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly QONEIUXEJBP KKQEXXOMWSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly string LNKSXKUHWAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly int QWDWHAZUANB;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x43D9380", Offset = "0x43D7F80", VA = "0x1843D9380")]
		public QBKAPKDIAGK(QONEIUXEJBP a, string b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x873CBF0", Offset = "0x873B7F0", VA = "0x18873CBF0", Slot = "4")]
		[AsyncStateMachine(typeof(<SummarizePreviousConversation>d__4))]
		public Task GGKHRNQWCFW(IReadOnlyCollection<string> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class RecRoomAIFunctionArgumentsDeserializationException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Type ArgumentsType
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public string Json
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x873CD10", Offset = "0x873B910", VA = "0x18873CD10")]
		public RecRoomAIFunctionArgumentsDeserializationException(Type argumentsType, string json, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal class PAGAAEURHSN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private struct <ExecuteFunctionCall>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public string args;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public PAGAAEURHSN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			private Dictionary<YVHMHVQECUL, HYUCSBDIOLI?>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			private TaskAwaiter<string?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x873CE30", Offset = "0x873BA30", VA = "0x18873CE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x873DAF0", Offset = "0x873C6F0", VA = "0x18873DAF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private static readonly Log NPHEYIXDMFH;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private static readonly List<TJSYKHFDGRW> DUCEFZQKLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private readonly Dictionary<YVHMHVQECUL, HYUCSBDIOLI?> PQQCDXRLKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public readonly HWISWPMUOCT<YVHMHVQECUL, HYUCSBDIOLI?> AACDRLXVESY;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x873C680", Offset = "0x873B280", VA = "0x18873C680")]
		static PAGAAEURHSN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x873B990", Offset = "0x873A590", VA = "0x18873B990")]
		public void BKZXWEWIGET(params YVHMHVQECUL[] serviceProviders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x873C420", Offset = "0x873B020", VA = "0x18873C420")]
		public bool WBQSMWWLZZH(YVHMHVQECUL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x873C110", Offset = "0x873AD10", VA = "0x18873C110")]
		public void RMQINZQTSMI(params YVHMHVQECUL[] serviceProviders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x873BC50", Offset = "0x873A850", VA = "0x18873BC50")]
		public void JDKGWVFXJHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x873BFB0", Offset = "0x873ABB0", VA = "0x18873BFB0")]
		[AsyncStateMachine(typeof(<ExecuteFunctionCall>d__9))]
		public Task<string> NESNMJSICGM(string a, string b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x873C480", Offset = "0x873B080", VA = "0x18873C480")]
		public List<ToolDTO> ZTWRULNRIPU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x873BCE0", Offset = "0x873A8E0", VA = "0x18873BCE0")]
		private static HYUCSBDIOLI MROARFKCGYD(YVHMHVQECUL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x873CB20", Offset = "0x873B720", VA = "0x18873CB20")]
		public PAGAAEURHSN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class YCZWFUZUUUY
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public static JsonSerializerSettings JCMGZEJYGYM;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x873E700", Offset = "0x873D300", VA = "0x18873E700")]
		static YCZWFUZUUUY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class CBLBNJWZZAW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		private class SPYDYRAWPKB
		{
			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public ConversationItemDTO TIKFJFNXMPY
			{
				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool TTVNXRVPPQN
			{
				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0xB69420", Offset = "0xB68020", VA = "0x180B69420")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0xB1A400", Offset = "0xB19000", VA = "0x180B1A400")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x16FEA50", Offset = "0x16FD650", VA = "0x1816FEA50")]
			public SPYDYRAWPKB(ConversationItemDTO a, bool b = false)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private abstract class NJYHFDLWQHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			private readonly StringBuilder ETFRLGFNXIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			private readonly TimeSpan FGVLGHLTSXD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			private DateTime BYSSAFSUHAJ;

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x873B8E0", Offset = "0x873A4E0", VA = "0x18873B8E0")]
			public NJYHFDLWQHA(TimeSpan a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x873B750", Offset = "0x873A350", VA = "0x18873B750")]
			public void FGZPZMKNUDF(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x873B7A0", Offset = "0x873A3A0", VA = "0x18873B7A0")]
			public void HVSQMUYLXYJ(bool a = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			protected abstract void KYJTCIXCLUW(string a);
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private class WUPKHNSASTG : NJYHFDLWQHA
		{
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			private static readonly TimeSpan ICXGRYBJZSA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			private readonly string EBZDJSVBIXB;

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x873E670", Offset = "0x873D270", VA = "0x18873E670")]
			public WUPKHNSASTG(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x873E590", Offset = "0x873D190", VA = "0x18873E590", Slot = "4")]
			protected override void KYJTCIXCLUW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		private class ZHOWPORKXRY : NJYHFDLWQHA
		{
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			private static readonly TimeSpan ICXGRYBJZSA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			private readonly WFSBWHDMOYH YIXIDMLSGXX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			private readonly SBVWTEFNUGH MHBCMMORBYW;

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x873EBD0", Offset = "0x873D7D0", VA = "0x18873EBD0")]
			public ZHOWPORKXRY(WFSBWHDMOYH a, SBVWTEFNUGH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x873E920", Offset = "0x873D520", VA = "0x18873E920", Slot = "4")]
			protected override void KYJTCIXCLUW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006D")]
		private class ZRWGPWKNKMF : NJYHFDLWQHA
		{
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			private static readonly TimeSpan ICXGRYBJZSA;

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x873ED60", Offset = "0x873D960", VA = "0x18873ED60")]
			public ZRWGPWKNKMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x873EC70", Offset = "0x873D870", VA = "0x18873EC70", Slot = "4")]
			protected override void KYJTCIXCLUW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private sealed class CMIBJUZGHFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public ConversationItemCreatedEventDTO GKFISIWCJUW;

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CMIBJUZGHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x873AD30", Offset = "0x8739930", VA = "0x18873AD30")]
			internal bool IOHXVQWQWQL(SPYDYRAWPKB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class XLYSDAWRGEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public ConversationItemDTO VVGWXUIUGTP;

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XLYSDAWRGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x873E550", Offset = "0x873D150", VA = "0x18873E550")]
			internal bool KOXTSVMDHRH(SPYDYRAWPKB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class KRJUMOXJQBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public ConversationItemInputAudioTranscriptionCompletedEventDTO GKFISIWCJUW;

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public KRJUMOXJQBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x873AD30", Offset = "0x8739930", VA = "0x18873AD30")]
			internal bool ACUUATPBJFT(SPYDYRAWPKB a)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct <RunLogFlushWorker>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public CBLBNJWZZAW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x873DB60", Offset = "0x873C760", VA = "0x18873DB60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x873DD40", Offset = "0x873C940", VA = "0x18873DD40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly TimeSpan ICXGRYBJZSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private readonly QONEIUXEJBP KKQEXXOMWSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private readonly SBVWTEFNUGH MHBCMMORBYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private readonly WFSBWHDMOYH YIXIDMLSGXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private readonly Token CSWJFTXYMJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private readonly List<NJYHFDLWQHA> ZAYPXKHFMCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private readonly List<SPYDYRAWPKB> PPUHFARUHHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private string? LONZXTIWQLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private CancellationTokenSource? KWVDMXPHDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private Task? QZMPIGIMTXV;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x873A660", Offset = "0x8739260", VA = "0x18873A660")]
		public CBLBNJWZZAW(QONEIUXEJBP a, WFSBWHDMOYH b, bool c, bool d, string? transcriptLogFilename)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8739300", Offset = "0x8737F00", VA = "0x188739300", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x873A190", Offset = "0x8738D90", VA = "0x18873A190")]
		private void YEHLLILFSDS(ConversationItemCreatedEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x87398B0", Offset = "0x87384B0", VA = "0x1887398B0")]
		private void HILKLHLGCCP(ResponseEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8739FE0", Offset = "0x8738BE0", VA = "0x188739FE0")]
		private void WKJDNVFKIVF(ConversationItemInputAudioTranscriptionCompletedEventDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8739B40", Offset = "0x8738740", VA = "0x188739B40")]
		private void JTOMSBAZEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8739D50", Offset = "0x8738950", VA = "0x188739D50")]
		private void VIVMMFZVQQB(ConversationItemDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x87395E0", Offset = "0x87381E0", VA = "0x1887395E0")]
		private void FGZPZMKNUDF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8739C60", Offset = "0x8738860", VA = "0x188739C60")]
		[AsyncStateMachine(typeof(<RunLogFlushWorker>d__19))]
		private Task TNORSXYHYIQ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8739790", Offset = "0x8738390", VA = "0x188739790")]
		private void GTCHHGSUPJI(bool a = false)
		{
		}
	}
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
