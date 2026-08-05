using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
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
using RecRoom.AI.OpenAI.Realtime;
using RecRoom.Audio;
using RecRoom.DataLayer.Audio;
using RecRoom.Logging.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x822A4C0", Offset = "0x8228AC0", VA = "0x18822A4C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_AI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8224F60", Offset = "0x8223560", VA = "0x188224F60", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class BDOMEMFJABO : IDisposable, IBGFEKDIBHM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct AIFFCPGOPPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BDOMEMFJABO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8214A80", Offset = "0x8213080", VA = "0x188214A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NDJELJMGLPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public BDOMEMFJABO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8227D00", Offset = "0x8226300", VA = "0x188227D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8228030", Offset = "0x8226630", VA = "0x188228030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected static readonly IPHNFELODMJ EANLMHBELEK;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly TimeSpan EFPLFKDFLFM;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const decimal GMCEFKPODAO = 0.005m;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource AGHBEJBOKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EHIPKKAJPOC PCDGKGGHFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly long NCPOLACFFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly long MEBGCNMKDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly Guid JLENHGMIJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private decimal DKPPAHEPNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? NAHKFBPMBFI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public decimal JLDEFHLECFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1022E40", Offset = "0x1021440", VA = "0x181022E40")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1022E30", Offset = "0x1021430", VA = "0x181022E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public decimal FLACAOOHJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82169F0", Offset = "0x8214FF0", VA = "0x1882169F0", Slot = "6")]
		get
		{
			return default(decimal);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8216D70", Offset = "0x8215370", VA = "0x188216D70")]
	public BDOMEMFJABO(EHIPKKAJPOC KCNPHOPKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8216960", Offset = "0x8214F60", VA = "0x188216960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
	protected virtual void RunPeriodicMonitorSideEffect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8216BA0", Offset = "0x82151A0", VA = "0x188216BA0")]
	[AsyncStateMachine(typeof(AIFFCPGOPPP))]
	private void OOKPNDELMMG(CancellationToken PJCIHHKJKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8216A90", Offset = "0x8215090", VA = "0x188216A90")]
	[AsyncStateMachine(typeof(NDJELJMGLPJ))]
	protected Task<bool> OLAHBCAGNCN(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task<bool> TrySyncLatestCostInfo(EHIPKKAJPOC KCNPHOPKNPI, Guid GPDACIBCFMD, long DDLHEHAKJGF, long BIBNADECNIE, CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x82168D0", Offset = "0x8214ED0", VA = "0x1882168D0", Slot = "9")]
	public virtual void AddCost(decimal LLDGOMOFAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "10")]
	protected virtual void GPHKLHMOODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "11")]
	protected virtual void DMALFMHEFCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum MNPBEBFILAC
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Float,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	String
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PFPALIIENIG : IEquatable<PFPALIIENIG>
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	protected virtual Type MIPMFKLLDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x822C880", Offset = "0x822AE80", VA = "0x18822C880", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MNPBEBFILAC HIKNDMJOAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		[CompilerGenerated]
		get
		{
			return default(MNPBEBFILAC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string KIOBNCLEIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DBEKFKFIGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC58290", Offset = "0xC56890", VA = "0x180C58290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xC18890", Offset = "0xC16E90", VA = "0x180C18890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string[]? AJDBJKCDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string? HIIGJIDJPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public StringFormat? ENMJPKHIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xFE1000", Offset = "0xFDF600", VA = "0x180FE1000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double? CGOIFDHMNAO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xEC0B10", Offset = "0xEBF110", VA = "0x180EC0B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5F14100", Offset = "0x5F12700", VA = "0x185F14100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double? CGLCMFLAPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xEC0B00", Offset = "0xEBF100", VA = "0x180EC0B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE170", Offset = "0x7FFC770", VA = "0x187FFE170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double? HIHBGLKHCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x55915B0", Offset = "0x558FBB0", VA = "0x1855915B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x55915F0", Offset = "0x558FBF0", VA = "0x1855915F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double? HDDPNKMKNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x136A850", Offset = "0x1368E50", VA = "0x18136A850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x822C250", Offset = "0x822A850", VA = "0x18822C250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public double? MCMMMILCBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1D32540", Offset = "0x1D30B40", VA = "0x181D32540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5CFE9A0", Offset = "0x5CFCFA0", VA = "0x185CFE9A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int? IGEAELDPPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAB0450", Offset = "0xAAEA50", VA = "0x180AB0450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1288950", Offset = "0x1286F50", VA = "0x181288950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int? APOFBEKDCOL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xB78DA0", Offset = "0xB773A0", VA = "0x180B78DA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8770", Offset = "0x2AE6D70", VA = "0x182AE8770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x822C9F0", Offset = "0x822AFF0", VA = "0x18822C9F0")]
	public PFPALIIENIG(MNPBEBFILAC HIKNDMJOAGH, string EEABAFMMHKN, string KIOBNCLEIFA = "", bool DBEKFKFIGKD = false, [Optional] string[]? AJDBJKCDLKF, [Optional] string? HIIGJIDJPKC, [Optional] StringFormat? ENMJPKHIOPK, [Optional] double? CGOIFDHMNAO, [Optional] double? CGLCMFLAPCG, [Optional] double? HIHBGLKHCEI, [Optional] double? HDDPNKMKNKM, [Optional] double? MCMMMILCBBH, [Optional] int? IGEAELDPPDK, [Optional] int? APOFBEKDCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x822C8E0", Offset = "0x822AEE0", VA = "0x18822C8E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x822C260", Offset = "0x822A860", VA = "0x18822C260", Slot = "6")]
	protected virtual bool MGBJCLMFCPB(StringBuilder JMCGCJHMINI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x12CADA0", Offset = "0x12C93A0", VA = "0x1812CADA0")]
	public static bool HKOGMNAKMAE(PFPALIIENIG? BNHNFFDCFNM, PFPALIIENIG? JAENAFJMCLC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x12CAEE0", Offset = "0x12C94E0", VA = "0x1812CAEE0")]
	public static bool MGLHCKHANFO(PFPALIIENIG? BNHNFFDCFNM, PFPALIIENIG? JAENAFJMCLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x822BCA0", Offset = "0x822A2A0", VA = "0x18822BCA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x822B750", Offset = "0x8229D50", VA = "0x18822B750", Slot = "0")]
	public override bool Equals(object? MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x822B7E0", Offset = "0x8229DE0", VA = "0x18822B7E0", Slot = "7")]
	public virtual bool Equals(PFPALIIENIG? AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x822B640", Offset = "0x8229C40", VA = "0x18822B640", Slot = "8")]
	public virtual PFPALIIENIG BDKBGLJFLAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x822CAE0", Offset = "0x822B0E0", VA = "0x18822CAE0")]
	protected PFPALIIENIG(PFPALIIENIG JJEFLPECABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x822C160", Offset = "0x822A760", VA = "0x18822C160")]
	public void HEAGIBMIAPN([Out] MNPBEBFILAC HIKNDMJOAGH, [Out] string EEABAFMMHKN, [Out] string KIOBNCLEIFA, [Out] bool DBEKFKFIGKD, [Out] string[]? AJDBJKCDLKF, [Out] string? HIIGJIDJPKC, [Out] StringFormat? ENMJPKHIOPK, [Out] double? CGOIFDHMNAO, [Out] double? CGLCMFLAPCG, [Out] double? HIHBGLKHCEI, [Out] double? HDDPNKMKNKM, [Out] double? MCMMMILCBBH, [Out] int? IGEAELDPPDK, [Out] int? APOFBEKDCOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CLLFHPIMHIH : IEquatable<CLLFHPIMHIH>
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected virtual Type MIPMFKLLDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8218040", Offset = "0x8216640", VA = "0x188218040", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JToken FMBEFCNGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PFPALIIENIG GAEFMPOEPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x12B3FB0", Offset = "0x12B25B0", VA = "0x1812B3FB0")]
	public CLLFHPIMHIH(JToken FMBEFCNGHJG, PFPALIIENIG GAEFMPOEPFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x82174B0", Offset = "0x8215AB0", VA = "0x1882174B0")]
	public static int EKCCCGGJJAM(CLLFHPIMHIH KOPHBHGIACG)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8217850", Offset = "0x8215E50", VA = "0x188217850")]
	public static float EKCCCGGJJAM(CLLFHPIMHIH KOPHBHGIACG)
	{
		return default(float);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8217570", Offset = "0x8215B70", VA = "0x188217570")]
	public static bool EKCCCGGJJAM(CLLFHPIMHIH KOPHBHGIACG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8217910", Offset = "0x8215F10", VA = "0x188217910")]
	public static string EKCCCGGJJAM(CLLFHPIMHIH KOPHBHGIACG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8217B10", Offset = "0x8216110", VA = "0x188217B10")]
	public static int[] EKCCCGGJJAM(CLLFHPIMHIH KOPHBHGIACG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8217630", Offset = "0x8215C30", VA = "0x188217630")]
	public static float[] EKCCCGGJJAM(CLLFHPIMHIH KOPHBHGIACG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8217A00", Offset = "0x8216000", VA = "0x188217A00")]
	public static bool[] EKCCCGGJJAM(CLLFHPIMHIH KOPHBHGIACG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8217740", Offset = "0x8215D40", VA = "0x188217740")]
	public static string[] EKCCCGGJJAM(CLLFHPIMHIH KOPHBHGIACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x82180A0", Offset = "0x82166A0", VA = "0x1882180A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8217F50", Offset = "0x8216550", VA = "0x188217F50", Slot = "6")]
	protected virtual bool MGBJCLMFCPB(StringBuilder JMCGCJHMINI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x12CADA0", Offset = "0x12C93A0", VA = "0x1812CADA0")]
	public static bool HKOGMNAKMAE(CLLFHPIMHIH? BNHNFFDCFNM, CLLFHPIMHIH? JAENAFJMCLC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x12CAEE0", Offset = "0x12C94E0", VA = "0x1812CAEE0")]
	public static bool MGLHCKHANFO(CLLFHPIMHIH? BNHNFFDCFNM, CLLFHPIMHIH? JAENAFJMCLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8217DF0", Offset = "0x82163F0", VA = "0x188217DF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8217D60", Offset = "0x8216360", VA = "0x188217D60", Slot = "0")]
	public override bool Equals(object? MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8217C20", Offset = "0x8216220", VA = "0x188217C20", Slot = "7")]
	public virtual bool Equals(CLLFHPIMHIH? AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8217420", Offset = "0x8215A20", VA = "0x188217420", Slot = "8")]
	public virtual CLLFHPIMHIH BDKBGLJFLAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x82181B0", Offset = "0x82167B0", VA = "0x1882181B0")]
	protected CLLFHPIMHIH(CLLFHPIMHIH JJEFLPECABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8217F10", Offset = "0x8216510", VA = "0x188217F10")]
	public void HEAGIBMIAPN([Out] JToken FMBEFCNGHJG, [Out] PFPALIIENIG GAEFMPOEPFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class MMPAPANFMPH : IKNDIIJHOPN
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const string AFBOIKGIEKB = "Open AI Realtime API";

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private const string KPJBNDBHDDP = "endpoint";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly string FGMABPOPCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly List<Func<DGFJDFCLOAM.PCLDPMJNMIH, DGFJDFCLOAM.PCLDPMJNMIH>> ODOKNCONLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<Func<DGFJDFCLOAM.PCLDPMJNMIH, DGFJDFCLOAM.PCLDPMJNMIH>> IDGJGHGMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly FENLOKHHBLN LFFAAGOPDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly IBGFEKDIBHM CBLOADCELNF;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EMNKBGHPOPN? IOHJOHBIKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string EGLMJMGLGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xAA5640", Offset = "0xAA3C40", VA = "0x180AA5640", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EONKLAHIHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8225400", Offset = "0x8223A00", VA = "0x188225400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x82276F0", Offset = "0x8225CF0", VA = "0x1882276F0")]
	public MMPAPANFMPH(FENLOKHHBLN FJEAIEGEBMP, IBGFEKDIBHM KMHCKMEEFPP, string IMLGGHFIKIN, string CCKHGNALING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8225370", Offset = "0x8223970", VA = "0x188225370")]
	private static DGFJDFCLOAM.PCLDPMJNMIH ADLBCBIKBJE(string IOPGNCAEOGL, string KCILMCEEBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82270E0", Offset = "0x82256E0", VA = "0x1882270E0")]
	private DGFJDFCLOAM.PCLDPMJNMIH MGIHLOGFPED(string IOPGNCAEOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8226460", Offset = "0x8224A60", VA = "0x188226460", Slot = "8")]
	public void KBDPEEMLKHC(string? CONLLKNEAOP, string NLGHBEJDCEA, string ABGDKGKNIIG, float BHKINJBMMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8226EC0", Offset = "0x82254C0", VA = "0x188226EC0", Slot = "10")]
	public void MEBIGJJDOJH(string? CONLLKNEAOP, ErrorEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8225FC0", Offset = "0x82245C0", VA = "0x188225FC0", Slot = "11")]
	public void IANJMACNMAP(string? CONLLKNEAOP, decimal LIEMBGFJNAE, string JIFPJFGEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8226220", Offset = "0x8224820", VA = "0x188226220")]
	public static void JJAKGBABGHK(IBGFEKDIBHM KMHCKMEEFPP, string EIDEEAHADAH, string KCILMCEEBCE, decimal LIEMBGFJNAE, string JIFPJFGEAIK, params (string key, string val)[] DDGNLMMFIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8227180", Offset = "0x8225780", VA = "0x188227180", Slot = "12")]
	public void OKJHMDHICPK(string? CONLLKNEAOP, ConversationItemDTO NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x82254A0", Offset = "0x8223AA0", VA = "0x1882254A0", Slot = "15")]
	public void DFHAEFDMBNG(string? CONLLKNEAOP, ResponseEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8225BF0", Offset = "0x82241F0", VA = "0x188225BF0")]
	private (decimal?, string, string, string, string, string) GEKJNPKNDEH(ResponseEventDTO OMAEIAPNEHN)
	{
		return default((decimal?, string, string, string, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8226740", Offset = "0x8224D40", VA = "0x188226740", Slot = "13")]
	public void KFMOHMCFHMN(string? CONLLKNEAOP, ResponseEventDTO OMAEIAPNEHN, float? GMBOCKKOMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8225B90", Offset = "0x8224190", VA = "0x188225B90", Slot = "14")]
	public void FPPKKDLNKDA(Func<DGFJDFCLOAM.PCLDPMJNMIH, DGFJDFCLOAM.PCLDPMJNMIH> CCCOKHLJCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8227120", Offset = "0x8225720", VA = "0x188227120", Slot = "9")]
	public void NCAJJLALNKG(Func<DGFJDFCLOAM.PCLDPMJNMIH, DGFJDFCLOAM.PCLDPMJNMIH> CCCOKHLJCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8225A20", Offset = "0x8224020", VA = "0x188225A20", Slot = "16")]
	public void EGAKMANOIIE(string? CONLLKNEAOP, string LEILDDGFOJJ, string? EFCBFMKHFCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class KOLJLDJKMKA : IKNDIIJHOPN
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public EMNKBGHPOPN? IOHJOHBIKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public decimal JLDEFHLECFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8224EA0", Offset = "0x82234A0", VA = "0x188224EA0")]
		get
		{
			return default(decimal);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string EGLMJMGLGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public FENLOKHHBLN? ENINFCDOIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "8")]
	public void KBDPEEMLKHC(string? CONLLKNEAOP, string NLGHBEJDCEA, string ABGDKGKNIIG, float BHKINJBMMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "9")]
	public void NCAJJLALNKG(Func<DGFJDFCLOAM.PCLDPMJNMIH, DGFJDFCLOAM.PCLDPMJNMIH> CCCOKHLJCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "10")]
	public void MEBIGJJDOJH(string? CONLLKNEAOP, ErrorEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "11")]
	public void IANJMACNMAP(string? CONLLKNEAOP, decimal LIEMBGFJNAE, string JIFPJFGEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "12")]
	public void OKJHMDHICPK(string? CONLLKNEAOP, ConversationItemDTO NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "15")]
	public void DFHAEFDMBNG(string? CONLLKNEAOP, ResponseEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "13")]
	public void KFMOHMCFHMN(string? CONLLKNEAOP, ResponseEventDTO OMAEIAPNEHN, float? GMBOCKKOMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "14")]
	public void FPPKKDLNKDA(Func<DGFJDFCLOAM.PCLDPMJNMIH, DGFJDFCLOAM.PCLDPMJNMIH> CCCOKHLJCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "16")]
	public void EGAKMANOIIE(string? CONLLKNEAOP, string LEILDDGFOJJ, string? EFCBFMKHFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8224F00", Offset = "0x8223500", VA = "0x188224F00")]
	public KOLJLDJKMKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class HCALAOADJHM : BDOMEMFJABO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct AFKFDDMFNKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public EHIPKKAJPOC recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public HCALAOADJHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Guid spendSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<LFMAIGHAOKH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8214420", Offset = "0x8212A20", VA = "0x188214420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x82147A0", Offset = "0x8212DA0", VA = "0x1882147A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly string HELOFCIEMOG;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8223710", Offset = "0x8221D10", VA = "0x188223710")]
	public HCALAOADJHM(EHIPKKAJPOC KCNPHOPKNPI, string CCDNBMKFHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x82235B0", Offset = "0x8221BB0", VA = "0x1882235B0", Slot = "8")]
	[AsyncStateMachine(typeof(AFKFDDMFNKD))]
	protected override Task<bool> TrySyncLatestCostInfo(EHIPKKAJPOC KCNPHOPKNPI, Guid GPDACIBCFMD, long DDLHEHAKJGF, long BIBNADECNIE, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CLPDFIENAPO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	PKBDHHCMFJK<ConversationItemDTO> FDIMCBOHDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IReadOnlyList<ConversationItemDTO> LGDKJFILFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<string> DCAFOAONPHM(ConversationItemDTO NANHMPOBBLI);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LOPICEKLLAN(string NMGOIKEGKAO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JPFKIODFMAN
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DDNIAMLMKKE(IReadOnlyCollection<string> HJFNFENPLEH, CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IGHJGMHPEEM
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ToolDTO[] AHBDHBDGIOF();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> EMPLEENCDIG(string HFFKJPDLDPD, string FIPPMHKBLBF, CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OHPAOPHAGPI
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MILKFMGDEKJ : OHPAOPHAGPI, IGHJGMHPEEM
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BLPNGLCOKDE
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Reconnect
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FENLOKHHBLN
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	const string KFBBFKMOFCO = "gpt-4o-mini-realtime-preview-2024-12-17";

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	const string FICPHEFGJPJ = "gpt-4o-mini-transcribe";

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	MDLHCKNJMIB FECMODDMKFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	AudioSource LGCOLHFAIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CLPDFIENAPO? PEHOJLFJLEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	JPFKIODFMAN? AKHCGJBGEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string? FJPPCEPKOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IIEJKMEFHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool HIDAJHHCKPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool KCPOAFPEOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool JBHPEMNBKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool EMHNFALOKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool BKNOCCNMEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	float BGLHMONEABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool JBMCDDFNMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool CNNKLMNAMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool KIPCMAJMNFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool EMDJHIFJCCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool LHIOPBBLBPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool FPIEEHFENEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PKBDHHCMFJK<bool> FHPNJHLAEFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HLLOFHFLNHG OKNDPCKACAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	PKBDHHCMFJK<BLPNGLCOKDE> IHHPEBFEDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FCCGMMLDHAB<string, string> BGJPLCOMMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	HLLOFHFLNHG KNMDCIADIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	HLLOFHFLNHG PLEGJJCPHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	PKBDHHCMFJK<List<ToolDTO>> PAFFPIHJEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	HLLOFHFLNHG BAIBGNCFKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	FCCGMMLDHAB<float, string> ODJNFLBBLPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	PKBDHHCMFJK<string> MNCDCOBHICE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	HLLOFHFLNHG HFBBOEKNPAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string EGLMJMGLGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool JBMBPAPBHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task NOEFOBHBBMA(string OOGMKLAEPFP, VoiceOption JCAOFHAJLIF, float BHKINJBMMJL = 0.6f, string LAGIFIDLDCA = "gpt-4o-mini-realtime-preview-2024-12-17", string ABGDKGKNIIG = "gpt-4o-mini-transcribe", [Optional] IReadOnlyCollection<string>? PNBDHPMMGAH, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void LILDAAPKGIB();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task ONKCAKJHKMK(string OOGMKLAEPFP, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task KDDDLEEKJMG(float BHKINJBMMJL, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task DBCNAKDOEKJ(bool KBMMNNBFAAB, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void DCDANFOOPPL(params OHPAOPHAGPI[] FHDPJCIKCAF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool ICGLBGMBBMH(OHPAOPHAGPI PIALKPIDJDO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void CHCAJAPLNED(params OHPAOPHAGPI[] FHDPJCIKCAF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void KFNNKPFAJKC(NBKBJBPEAPN INEEADCBMPK, bool BIKMKHMMDKM = false);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void ANHLIDHLFMM(NBKBJBPEAPN INEEADCBMPK, bool BIKMKHMMDKM = false);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void BGHMNHLGFBP(NBKBJBPEAPN INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void CMEKBPPOBIC(NBKBJBPEAPN INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void GDOFOBBDHGE(decimal LIEMBGFJNAE, string JIFPJFGEAIK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task HFKDPOMELHC(byte[] JIIMPGBEJCG, string? MJJDPPOFDBH, [Optional] string? EICBLGIKPJH, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task HFKDPOMELHC(string GKNICJPCIJJ, [Optional] string? EICBLGIKPJH, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task DANNMIKAEMC(string GKNICJPCIJJ, [Optional] string? EICBLGIKPJH, [Optional] string? BDBAAAAOOOM, bool HPJGEGHCOPO = false, bool FAKJKPNHCHA = false, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task LOPICEKLLAN(string EICBLGIKPJH, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<ResponseDTO> CODJEDOEBBO(bool NEBOCHDGIIJ = true, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task<string> KNHJLCIGOOI(string OOGMKLAEPFP, [Optional] IReadOnlyList<ConversationItemDTO>? HJFNFENPLEH, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<TOutput> KNHJLCIGOOI<TOutput>(string OOGMKLAEPFP, [Optional] IReadOnlyList<ConversationItemDTO>? HJFNFENPLEH, [Optional] CancellationToken PJCIHHKJKBP) where TOutput : class;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<List<CLLFHPIMHIH>> KNHJLCIGOOI(string OOGMKLAEPFP, IReadOnlyList<ConversationItemDTO>? HJFNFENPLEH, IReadOnlyList<PFPALIIENIG> DEILFMEAEGJ, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool AEEICJBKMOB(string NMGOIKEGKAO);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool OBALEFLGFEL(string NMGOIKEGKAO);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool PFLHHPGOLOA(string CEKHFFDACIM);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task GLIJHBPKKJC(bool MDFFGLBKOIO, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "57")]
	IReadOnlyCollection<string> KHIFOADLLNL();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IKNDIIJHOPN
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EMNKBGHPOPN? IOHJOHBIKHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string EGLMJMGLGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBDPEEMLKHC(string? CONLLKNEAOP, string NLGHBEJDCEA, string ABGDKGKNIIG, float BHKINJBMMJL);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NCAJJLALNKG(Func<DGFJDFCLOAM.PCLDPMJNMIH, DGFJDFCLOAM.PCLDPMJNMIH> CCCOKHLJCKG);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MEBIGJJDOJH(string? CONLLKNEAOP, ErrorEventDTO OMAEIAPNEHN);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IANJMACNMAP(string? CONLLKNEAOP, decimal LIEMBGFJNAE, string JIFPJFGEAIK);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OKJHMDHICPK(string? CONLLKNEAOP, ConversationItemDTO NANHMPOBBLI);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KFMOHMCFHMN(string? CONLLKNEAOP, ResponseEventDTO OMAEIAPNEHN, float? GMBOCKKOMJJ);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FPPKKDLNKDA(Func<DGFJDFCLOAM.PCLDPMJNMIH, DGFJDFCLOAM.PCLDPMJNMIH> CCCOKHLJCKG);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DFHAEFDMBNG(string? CONLLKNEAOP, ResponseEventDTO OMAEIAPNEHN);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EGAKMANOIIE(string? CONLLKNEAOP, string LEILDDGFOJJ, string? EFCBFMKHFCC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface MKCJAOJEDAL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void NJAPJPOLIPN(ReadOnlySpan<float> JDONDHOKKFH, int NOJMAMBJJKK, int KBIICOGOBJL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGDEMLGBNMC(NJAPJPOLIPN BOGGDLFCPCM);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMIOOPCOHAA(NJAPJPOLIPN BOGGDLFCPCM);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface IBGFEKDIBHM
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	decimal FLACAOOHJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AddCost(decimal LLDGOMOFAJC);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class AMIOEJOJBFK
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private enum HNDHAJEHHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		array,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		boolean,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		@enum,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		integer,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		number,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		@object,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		@string
	}

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static ConcurrentDictionary<Type, JsonSchema> NHNIFOGFPMB;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static readonly Type[] BCOJNCDOJHI;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static readonly Type[] DGFDKNJMJBJ;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x330B140", Offset = "0x3309740", VA = "0x18330B140")]
	public static JsonSchema HBAOOBIPNDD<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8215B70", Offset = "0x8214170", VA = "0x188215B70")]
	public static JsonSchema JOFEMDIHCPM(IReadOnlyList<PFPALIIENIG> PNGANGECEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x82157F0", Offset = "0x8213DF0", VA = "0x1882157F0")]
	public static OCMPBCBDDNC HNPDAEFBKJJ(string NDIENANOGEK, string? NGPLKKDGJMB, JsonSchema AJDMAELEIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x330B300", Offset = "0x3309900", VA = "0x18330B300")]
	public static OCMPBCBDDNC HNPDAEFBKJJ<T>(string NDIENANOGEK, string? NGPLKKDGJMB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x82156A0", Offset = "0x8213CA0", VA = "0x1882156A0")]
	public static OCMPBCBDDNC HNPDAEFBKJJ(string NDIENANOGEK, string? NGPLKKDGJMB, IReadOnlyList<PFPALIIENIG> PNGANGECEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8215EC0", Offset = "0x82144C0", VA = "0x188215EC0")]
	private static JsonSchema NJBGNCHEDEG(Type GPEIAHGICNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8215110", Offset = "0x8213710", VA = "0x188215110")]
	private static JsonSchema EJLFJBIOIMC(Type GPEIAHGICNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8214F10", Offset = "0x8213510", VA = "0x188214F10")]
	private static HNDHAJEHHEJ COIGNAKKOJC(Type GPEIAHGICNA, [Out] Type? OICDECBABOL)
	{
		return default(HNDHAJEHHEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x8215900", Offset = "0x8213F00", VA = "0x188215900")]
	private static bool HOPIIHGEPKK(Type GPEIAHGICNA, [Out][MaybeNullWhen(false)] Type NJLCGBCMDCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ADKGOIMHMNP : MILKFMGDEKJ, OHPAOPHAGPI, IGHJGMHPEEM
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate Task<string> DAAMGJGGKMP(List<CLLFHPIMHIH> MGPPHEGFGJP);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate string HPEFAODIFBM(List<CLLFHPIMHIH> MGPPHEGFGJP);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class FOJFLLPJENG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public HPEFAODIFBM handler;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public FOJFLLPJENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8222090", Offset = "0x8220690", VA = "0x188222090")]
		internal Task<string> KJLMOGFJHPI(List<CLLFHPIMHIH> invokedArgs)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct EPLLAEKFDOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public string methodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public ADKGOIMHMNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public string methodArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8221970", Offset = "0x821FF70", VA = "0x188221970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8222020", Offset = "0x8220620", VA = "0x188222020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly string JLFIMMGPKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string NNELPHFMAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IReadOnlyList<PFPALIIENIG> HCOGJNGELEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly DAAMGJGGKMP BOKLABJAGHK;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1125D70", Offset = "0x1124370", VA = "0x181125D70")]
	public ADKGOIMHMNP(string NDIENANOGEK, string NGPLKKDGJMB, IReadOnlyList<PFPALIIENIG> PNGANGECEEL, DAAMGJGGKMP KMEJDHBNOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8213FA0", Offset = "0x82125A0", VA = "0x188213FA0")]
	public ADKGOIMHMNP(string NDIENANOGEK, string NGPLKKDGJMB, IReadOnlyList<PFPALIIENIG> PNGANGECEEL, HPEFAODIFBM KMEJDHBNOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8213E20", Offset = "0x8212420", VA = "0x188213E20", Slot = "4")]
	private ToolDTO[] PEANBNAKIHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8213CE0", Offset = "0x82122E0", VA = "0x188213CE0", Slot = "5")]
	[AsyncStateMachine(typeof(EPLLAEKFDOI))]
	private Task<string> GNKBGNDHKLF(string HFFKJPDLDPD, string FIPPMHKBLBF, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class APCFMKLBDKE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
	public APCFMKLBDKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OHCEHDFFIJH : Exception, CICLJCHHDKC
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string EBFEFJCNMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5163C00", Offset = "0x5162200", VA = "0x185163C00", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x822B5C0", Offset = "0x8229BC0", VA = "0x18822B5C0")]
	public OHCEHDFFIJH(string JPAFACINAGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class CPKIPMBOEAG : FENLOKHHBLN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private enum IJODMHEEADB
	{
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		NotConnected,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		Connected
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct EGOBACPGIOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int? reconnectAttempt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private CancellationTokenSource <cts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private CancellationToken <originalCancellationToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private IDisposable <combinedTokenDisposer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private string <instructions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private float <temperature>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<MDLHCKNJMIB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<bool> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x821E280", Offset = "0x821C880", VA = "0x18821E280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x82206D0", Offset = "0x821ECD0", VA = "0x1882206D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct NPCOAEOLFKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public bool keepConversationHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x822A250", Offset = "0x8228850", VA = "0x18822A250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x822A460", Offset = "0x8228A60", VA = "0x18822A460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct AEFIHMMNEFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8214190", Offset = "0x8212790", VA = "0x188214190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x82143C0", Offset = "0x82129C0", VA = "0x1882143C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct AFLGGONGHDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float temperature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8214810", Offset = "0x8212E10", VA = "0x188214810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8214A20", Offset = "0x8213020", VA = "0x188214A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct KBFFOANEOOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x82238B0", Offset = "0x8221EB0", VA = "0x1882238B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8223AC0", Offset = "0x82220C0", VA = "0x188223AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct BNLJBCONMOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x82170C0", Offset = "0x82156C0", VA = "0x1882170C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x82173C0", Offset = "0x82159C0", VA = "0x1882173C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct NDGMPMIALGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public byte[] pcmAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public string transcript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8227820", Offset = "0x8225E20", VA = "0x188227820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8227CA0", Offset = "0x82262A0", VA = "0x188227CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct EOJNILBGNLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8220BD0", Offset = "0x821F1D0", VA = "0x188220BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8221040", Offset = "0x821F640", VA = "0x188221040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DDFDOFKDBDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public bool suppressFromConversationLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool excludeFromConversationPruning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string previousItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x821D840", Offset = "0x821BE40", VA = "0x18821D840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x821DD90", Offset = "0x821C390", VA = "0x18821DD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct OBLMMJAAIND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public string convresationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x822A540", Offset = "0x8228B40", VA = "0x18822A540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x822A9A0", Offset = "0x8228FA0", VA = "0x18822A9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class COBLJKLDDIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public ResponseDTO response;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public COBLJKLDDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8218200", Offset = "0x8216800", VA = "0x188218200")]
		internal bool BHAJLMAGNDP(OutputAudioBufferEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct NFFDJNMFJAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private COBLJKLDDIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public bool waitForAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter<OutputAudioBufferEventDTO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x82280A0", Offset = "0x82266A0", VA = "0x1882280A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x82288F0", Offset = "0x8226EF0", VA = "0x1882288F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct ABDOOHBNJGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x82136C0", Offset = "0x8211CC0", VA = "0x1882136C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8213C70", Offset = "0x8212270", VA = "0x188213C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct LGNBNFPDIBO<TOutput> : IAsyncStateMachine where TOutput : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder<TOutput> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x57C8220", Offset = "0x57C6820", VA = "0x1857C8220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x57C8A80", Offset = "0x57C7080", VA = "0x1857C8A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct OFPIAPKIDAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder<List<CLLFHPIMHIH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public IReadOnlyList<PFPALIIENIG> responseArgSchemas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x822AE80", Offset = "0x8229480", VA = "0x18822AE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x822B550", Offset = "0x8229B50", VA = "0x18822B550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class BFLIPEGBHKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public ResponseCreateEventDTO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public string id;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BFLIPEGBHKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8216F30", Offset = "0x8215530", VA = "0x188216F30")]
		internal void JDFJFKPEPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8217030", Offset = "0x8215630", VA = "0x188217030")]
		internal bool NFIEFLJMGIH(ResponseEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct GDFDGPKBEPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AsyncTaskMethodBuilder<List<ConversationItemDTO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public JsonSchema responseSchema;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private TaskAwaiter<ResponseEventDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8222CC0", Offset = "0x82212C0", VA = "0x188222CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8223540", Offset = "0x8221B40", VA = "0x188223540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct ELKOHHKIJLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8220730", Offset = "0x821ED30", VA = "0x188220730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8220B70", Offset = "0x821F170", VA = "0x188220B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct KMFDOOCPOPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public DateTime expirationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8224A50", Offset = "0x8223050", VA = "0x188224A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8224E40", Offset = "0x8223440", VA = "0x188224E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DOMOPLCLNFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private List<ToolDTO> <tools>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x821DDF0", Offset = "0x821C3F0", VA = "0x18821DDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x821E220", Offset = "0x821C820", VA = "0x18821E220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct PNJGKPBBJDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public ResponseEventDTO ev;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private string <responseId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x822CBC0", Offset = "0x822B1C0", VA = "0x18822CBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class HOJEDFBIOOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HOJEDFBIOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8223790", Offset = "0x8221D90", VA = "0x188223790")]
		internal Task DOONNHPHNHB(ConversationItemDTO outputItem)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct EPLEONJFCAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public ResponseDTO response;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private HOJEDFBIOOH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x82210A0", Offset = "0x821F6A0", VA = "0x1882210A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8221910", Offset = "0x821FF10", VA = "0x188221910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct MHLHBIOMGFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8225070", Offset = "0x8223670", VA = "0x188225070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8225310", Offset = "0x8223910", VA = "0x188225310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KFLBIPBAOHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8223B20", Offset = "0x8222120", VA = "0x188223B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8223E80", Offset = "0x8222480", VA = "0x188223E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct FPJCJMLJDAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CPKIPMBOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private CancellationToken <cancellationToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private DateTime? <startTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<ResponseDTO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8222120", Offset = "0x8220720", VA = "0x188222120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8222C50", Offset = "0x8221250", VA = "0x188222C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly IPHNFELODMJ EANLMHBELEK;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private const ToolChoice FENOGEIJAEA = ToolChoice.Auto;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private const float LFLEJONLFNK = 0.01f;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly TimeSpan[] NKALOPDENNL;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly TimeSpan FGLNKHLHPJO;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly TimeSpan CKBDDMOEILN;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly TimeSpan FGCLKKEFAPB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly TimeSpan HBKDCNOFLNN;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly TimeSpan AFPFFLMCLAF;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly TimeSpan MIBACEFGFBG;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private const string NIKKJNIKCHH = "out-of-band-id";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly PGOBNKFHHFC OALOHNCNKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly MKCJAOJEDAL CHDFAGGCNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected readonly EHIPKKAJPOC PCDGKGGHFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly NFKAKMGCAJD OLIPOPGIKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly BGICKGNAFMP LOCPHKEOACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly BGICKGNAFMP MKBDEGEGJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<string, DateTime> AKPLDCFECPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly Lazy<IKNDIIJHOPN> POMNCEEPIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly PNLCHNNCBNF? IHJIFNMNGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private string PNBLDHDILIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private VoiceOption IGFKFAANEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private float EKBGBMICBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private string PPCBEALKCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private string JKNKJKFMJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private IJODMHEEADB IJHJMDJBGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private CancellationTokenSource? AGHBEJBOKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	protected MDLHCKNJMIB? EDIMPNFJHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private AudioSource? OLOKHFAALNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private AudioSourceSimpleLevelMeter? PNADEIMCKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private HOJONONAFNC? IKNEEHEFMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private GDFBGHBLDHE? DOIDBGNMLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private NJJINDPCACI? IFICJAEJCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private NFNAENMIBDO? FEJKNCDMHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private IReadOnlyCollection<string> LPEJKDMDDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private DateTime? BAOOMGLNKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Task<ResponseDTO>? JEICEFILPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private uint LADHLBNPNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly HashSet<string> NEKPIGLPNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly HashSet<string> AFIDFDBBHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly HashSet<string> AEKKPHFGLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool FBJFPFOAMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private NBKBJBPEAPN? PPBKEFCLCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool KGHPFOBHHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private CancellationTokenSource? IDIJFBLAMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private string? ADBOKKJAKLE;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public MDLHCKNJMIB FECMODDMKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x821B8E0", Offset = "0x8219EE0", VA = "0x18821B8E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string? FJPPCEPKOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x821CD50", Offset = "0x821B350", VA = "0x18821CD50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool HLENBDHALCH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1004050", Offset = "0x1002650", VA = "0x181004050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public abstract bool IIEJKMEFHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract bool HIDAJHHCKPM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract bool KCPOAFPEOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected abstract bool LNDMFHJJPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected abstract string? FDAJLDJIFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected abstract string LFGINHHNFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected abstract int PLAKBCFKPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected abstract int JPAKNKHDDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	protected abstract OCNIKIFHEBK PMBKFNGNOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	protected abstract string AHMJCAAACIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected virtual bool BLBECOGCIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "74")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected Func<bool>? GDHKJOFDJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xB9E080", Offset = "0xB9C680", VA = "0x180B9E080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xB95AC0", Offset = "0xB940C0", VA = "0x180B95AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool JBHPEMNBKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x821C0E0", Offset = "0x821A6E0", VA = "0x18821C0E0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool EMHNFALOKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x821CBD0", Offset = "0x821B1D0", VA = "0x18821CBD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool BKNOCCNMEAD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x82188D0", Offset = "0x8216ED0", VA = "0x1882188D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public float BGLHMONEABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x82185F0", Offset = "0x8216BF0", VA = "0x1882185F0", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool JBMCDDFNMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xBD5B00", Offset = "0xBD4100", VA = "0x180BD5B00", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xBCEFB0", Offset = "0xBCD5B0", VA = "0x180BCEFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool CNNKLMNAMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x821B330", Offset = "0x8219930", VA = "0x18821B330", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool KIPCMAJMNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x821C7E0", Offset = "0x821ADE0", VA = "0x18821C7E0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool EMDJHIFJCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x290D170", Offset = "0x290B770", VA = "0x18290D170", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool LHIOPBBLBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8219C20", Offset = "0x8218220", VA = "0x188219C20", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool FPIEEHFENEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x821C0F0", Offset = "0x821A6F0", VA = "0x18821C0F0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private bool AHIGAEDCOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x821ABB0", Offset = "0x82191B0", VA = "0x18821ABB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private bool CDJOFAPBFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8219920", Offset = "0x8217F20", VA = "0x188219920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private bool BPCMIPIAEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x821BBA0", Offset = "0x821A1A0", VA = "0x18821BBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool JBMBPAPBHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x205BE50", Offset = "0x205A450", VA = "0x18205BE50", Slot = "59")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x503C640", Offset = "0x503AC40", VA = "0x18503C640", Slot = "60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private uint IINEKPKCOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xB69390", Offset = "0xB67990", VA = "0x180B69390")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x821AB40", Offset = "0x8219140", VA = "0x18821AB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public AudioSource LGCOLHFAIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xB2DCA0", Offset = "0xB2C2A0", VA = "0x180B2DCA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public CLPDFIENAPO? PEHOJLFJLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xB78DA0", Offset = "0xB773A0", VA = "0x180B78DA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public JPFKIODFMAN? AKHCGJBGEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xAAEE90", Offset = "0xAAD490", VA = "0x180AAEE90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string EGLMJMGLGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x821B520", Offset = "0x8219B20", VA = "0x18821B520")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8218730", Offset = "0x8216D30", VA = "0x188218730", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	protected virtual string? LHNJABHNFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xC200A0", Offset = "0xC1E6A0", VA = "0x180C200A0", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	protected virtual IPHNFELODMJ? MENGDHLAMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	protected virtual IPHNFELODMJ? EJGPBBILHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "77")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public PKBDHHCMFJK<bool> FHPNJHLAEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xC1C0D0", Offset = "0xC1A6D0", VA = "0x180C1C0D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public HLLOFHFLNHG OKNDPCKACAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xC263A0", Offset = "0xC249A0", VA = "0x180C263A0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public PKBDHHCMFJK<BLPNGLCOKDE> IHHPEBFEDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xC3A7D0", Offset = "0xC38DD0", VA = "0x180C3A7D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FCCGMMLDHAB<string, string> BGJPLCOMMFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xC22600", Offset = "0xC20C00", VA = "0x180C22600", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public PKBDHHCMFJK<List<ToolDTO>> PAFFPIHJEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xC1E6D0", Offset = "0xC1CCD0", VA = "0x180C1E6D0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public HLLOFHFLNHG KNMDCIADIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xC1DC00", Offset = "0xC1C200", VA = "0x180C1DC00", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public HLLOFHFLNHG PLEGJJCPHOB
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xC3A980", Offset = "0xC38F80", VA = "0x180C3A980", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public HLLOFHFLNHG BAIBGNCFKHE
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xC1F3B0", Offset = "0xC1D9B0", VA = "0x180C1F3B0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FCCGMMLDHAB<float, string> ODJNFLBBLPH
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xC1BAC0", Offset = "0xC1A0C0", VA = "0x180C1BAC0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public PKBDHHCMFJK<string> MNCDCOBHICE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xC351E0", Offset = "0xC337E0", VA = "0x180C351E0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public HLLOFHFLNHG HFBBOEKNPAK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xB48BD0", Offset = "0xB471D0", VA = "0x180B48BD0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x821D0B0", Offset = "0x821B6B0", VA = "0x18821D0B0")]
	public CPKIPMBOEAG(PGOBNKFHHFC HHKAFOOOPOD, MKCJAOJEDAL FPKODOAEMLG, EHIPKKAJPOC KCNPHOPKNPI, [Optional] PNLCHNNCBNF? KBDMPJPCCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x821B370", Offset = "0x8219970", VA = "0x18821B370")]
	private void HODNHELEHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "63")]
	protected abstract IKNDIIJHOPN CreateDataReporter();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x821C240", Offset = "0x821A840", VA = "0x18821C240")]
	private void LPDIKDPOCJP(OHPAOPHAGPI ONCPPCGCCMB, IGHJGMHPEEM? KMEJDHBNOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x821C8F0", Offset = "0x821AEF0", VA = "0x18821C8F0", Slot = "33")]
	public Task NOEFOBHBBMA(string OOGMKLAEPFP, VoiceOption JCAOFHAJLIF, float BHKINJBMMJL, string LAGIFIDLDCA, string ABGDKGKNIIG, [Optional] IReadOnlyCollection<string>? PNBDHPMMGAH, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x821C6C0", Offset = "0x821ACC0", VA = "0x18821C6C0")]
	[AsyncStateMachine(typeof(EGOBACPGIOI))]
	private Task NHMBPACNKJL(int? KPDJBIBBEAF, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8218AE0", Offset = "0x82170E0", VA = "0x188218AE0", Slot = "78")]
	protected virtual Task CheckAccess(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x821CE20", Offset = "0x821B420", VA = "0x18821CE20", Slot = "79")]
	protected virtual Task<bool> UploadTranscriptsForModeration(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x821C110", Offset = "0x821A710", VA = "0x18821C110", Slot = "34")]
	public void LILDAAPKGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8218E50", Offset = "0x8217450", VA = "0x188218E50")]
	private void DCKJDJHFGDF(BLPNGLCOKDE PBMFDDLEJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x821AF90", Offset = "0x8219590", VA = "0x18821AF90", Slot = "57")]
	[AsyncStateMachine(typeof(NPCOAEOLFKK))]
	public Task GLIJHBPKKJC(bool MDFFGLBKOIO, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8219970", Offset = "0x8217F70", VA = "0x188219970", Slot = "80")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x821CC40", Offset = "0x821B240", VA = "0x18821CC40", Slot = "35")]
	[AsyncStateMachine(typeof(AEFIHMMNEFC))]
	public Task ONKCAKJHKMK(string OOGMKLAEPFP, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x821BA20", Offset = "0x821A020", VA = "0x18821BA20", Slot = "36")]
	[AsyncStateMachine(typeof(AFLGGONGHDK))]
	public Task KDDDLEEKJMG(float BHKINJBMMJL, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x821B7D0", Offset = "0x8219DD0", VA = "0x18821B7D0")]
	[AsyncStateMachine(typeof(KBFFOANEOOK))]
	public Task IMGDCGPBPFO(bool KBMMNNBFAAB, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8218CC0", Offset = "0x82172C0", VA = "0x188218CC0", Slot = "37")]
	[AsyncStateMachine(typeof(BNLJBCONMOP))]
	public Task DBCNAKDOEKJ(bool KBMMNNBFAAB, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8218DD0", Offset = "0x82173D0", VA = "0x188218DD0", Slot = "38")]
	public void DCDANFOOPPL(params OHPAOPHAGPI[] FHDPJCIKCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x821B590", Offset = "0x8219B90", VA = "0x18821B590", Slot = "39")]
	public bool ICGLBGMBBMH(OHPAOPHAGPI PIALKPIDJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8218820", Offset = "0x8216E20", VA = "0x188218820", Slot = "40")]
	public void CHCAJAPLNED(params OHPAOPHAGPI[] FHDPJCIKCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x821BB30", Offset = "0x821A130", VA = "0x18821BB30", Slot = "41")]
	public void KFNNKPFAJKC(NBKBJBPEAPN INEEADCBMPK, bool BIKMKHMMDKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8218680", Offset = "0x8216C80", VA = "0x188218680", Slot = "42")]
	public void ANHLIDHLFMM(NBKBJBPEAPN INEEADCBMPK, bool BIKMKHMMDKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x82186F0", Offset = "0x8216CF0", VA = "0x1882186F0", Slot = "43")]
	public void BGHMNHLGFBP(NBKBJBPEAPN INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8218960", Offset = "0x8216F60", VA = "0x188218960", Slot = "44")]
	public void CMEKBPPOBIC(NBKBJBPEAPN INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x821BBB0", Offset = "0x821A1B0", VA = "0x18821BBB0", Slot = "61")]
	public IReadOnlyCollection<string> KHIFOADLLNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x821ACC0", Offset = "0x82192C0", VA = "0x18821ACC0", Slot = "45")]
	public void GDOFOBBDHGE(decimal LIEMBGFJNAE, string JIFPJFGEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x821B1E0", Offset = "0x82197E0", VA = "0x18821B1E0", Slot = "46")]
	[AsyncStateMachine(typeof(NDGMPMIALGB))]
	public Task HFKDPOMELHC(byte[] JIIMPGBEJCG, string? MJJDPPOFDBH, string? EICBLGIKPJH, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x821B0A0", Offset = "0x82196A0", VA = "0x18821B0A0", Slot = "47")]
	[AsyncStateMachine(typeof(EOJNILBGNLN))]
	public Task HFKDPOMELHC(string GKNICJPCIJJ, string? EICBLGIKPJH, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8218B70", Offset = "0x8217170", VA = "0x188218B70", Slot = "48")]
	[AsyncStateMachine(typeof(DDFDOFKDBDP))]
	public Task DANNMIKAEMC(string GKNICJPCIJJ, string? EICBLGIKPJH, string? BDBAAAAOOOM, bool HPJGEGHCOPO, bool FAKJKPNHCHA, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x821C120", Offset = "0x821A720", VA = "0x18821C120", Slot = "49")]
	[AsyncStateMachine(typeof(OBLMMJAAIND))]
	public Task LOPICEKLLAN(string BLAMIDKDGEJ, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8218230", Offset = "0x8216830", VA = "0x188218230", Slot = "54")]
	public bool AEEICJBKMOB(string NMGOIKEGKAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x821CAD0", Offset = "0x821B0D0", VA = "0x18821CAD0", Slot = "55")]
	public bool OBALEFLGFEL(string NMGOIKEGKAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x821CDA0", Offset = "0x821B3A0", VA = "0x18821CDA0", Slot = "56")]
	public bool PFLHHPGOLOA(string CEKHFFDACIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x82189A0", Offset = "0x8216FA0", VA = "0x1882189A0", Slot = "50")]
	[AsyncStateMachine(typeof(NFFDJNMFJAB))]
	public Task<ResponseDTO> CODJEDOEBBO(bool NEBOCHDGIIJ = true, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x821BD00", Offset = "0x821A300", VA = "0x18821BD00", Slot = "51")]
	[AsyncStateMachine(typeof(ABDOOHBNJGD))]
	public Task<string> KNHJLCIGOOI(string OOGMKLAEPFP, [Optional] IReadOnlyList<ConversationItemDTO>? HJFNFENPLEH, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2DC0", Offset = "0x3BE13C0", VA = "0x183BE2DC0", Slot = "52")]
	[AsyncStateMachine(typeof(LGNBNFPDIBO<>))]
	public Task<TOutput> KNHJLCIGOOI<TOutput>(string OOGMKLAEPFP, [Optional] IReadOnlyList<ConversationItemDTO>? HJFNFENPLEH, [Optional] CancellationToken PJCIHHKJKBP) where TOutput : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x821BE60", Offset = "0x821A460", VA = "0x18821BE60", Slot = "53")]
	[AsyncStateMachine(typeof(OFPIAPKIDAD))]
	public Task<List<CLLFHPIMHIH>> KNHJLCIGOOI(string OOGMKLAEPFP, IReadOnlyList<ConversationItemDTO>? HJFNFENPLEH, IReadOnlyList<PFPALIIENIG> DEILFMEAEGJ, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8219E10", Offset = "0x8218410", VA = "0x188219E10")]
	[AsyncStateMachine(typeof(GDFDGPKBEPM))]
	private Task<List<ConversationItemDTO>> ELLOPEMPECB(string OOGMKLAEPFP, IReadOnlyList<ConversationItemDTO>? HJFNFENPLEH, JsonSchema? NKODDCJNHEI, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x821C5D0", Offset = "0x821ABD0", VA = "0x18821C5D0")]
	[AsyncStateMachine(typeof(ELKOHHKIJLE))]
	public Task MCIPLPBLOAJ([Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8218290", Offset = "0x8216890", VA = "0x188218290")]
	[AsyncStateMachine(typeof(KMFDOOCPOPJ))]
	private Task AJIICEDCDGP(DateTime BHPFDBEBHDN, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x82183A0", Offset = "0x82169A0", VA = "0x1882183A0")]
	private bool AKFKEMHECGC(ResponseDTO JIEFFLNKFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x821B980", Offset = "0x8219F80", VA = "0x18821B980")]
	private void KALABHJJEAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x821CB30", Offset = "0x821B130", VA = "0x18821CB30")]
	private void OEDOAPJDAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x821BC10", Offset = "0x821A210", VA = "0x18821BC10")]
	[AsyncStateMachine(typeof(DOMOPLCLNFE))]
	private Task KNHBABGHMGG([Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x821A880", Offset = "0x8218E80", VA = "0x18821A880")]
	private void EOLPKFJNIBP(ReadOnlySpan<float> JDONDHOKKFH, int NOJMAMBJJKK, int KBIICOGOBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x821C830", Offset = "0x821AE30", VA = "0x18821C830")]
	private void NKKIJKBENCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x821B700", Offset = "0x8219D00", VA = "0x18821B700")]
	[AsyncStateMachine(typeof(PNJGKPBBJDF))]
	private void IENCDOEHLKD(ResponseEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x821AA00", Offset = "0x8219000", VA = "0x18821AA00")]
	private void FDIMCBOHDEO(ConversationItemDTO NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2CE0", Offset = "0x3BE12E0", VA = "0x183BE2CE0")]
	private void FCPHLKKOPBF<T>(T OMAEIAPNEHN) where T : notnull, BLGBHBJAAFF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x821A090", Offset = "0x8218690", VA = "0x18821A090")]
	private void EOCCNGGENEN(ResponseEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x821AE20", Offset = "0x8219420", VA = "0x18821AE20")]
	private void GHCMJAMBCNN(string NLGHBEJDCEA, string ABGDKGKNIIG, float BHKINJBMMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8219CF0", Offset = "0x82182F0", VA = "0x188219CF0")]
	[AsyncStateMachine(typeof(EPLEONJFCAE))]
	private Task ELCPFEKABOP(ResponseDTO JIEFFLNKFPC, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8219F80", Offset = "0x8218580", VA = "0x188219F80")]
	[AsyncStateMachine(typeof(MHLHBIOMGFC))]
	private Task EMPLEENCDIG(ConversationItemDTO NANHMPOBBLI, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x821BFD0", Offset = "0x821A5D0", VA = "0x18821BFD0")]
	[AsyncStateMachine(typeof(KFLBIPBAOHI))]
	private Task<ResponseDTO> KNOPHNFNBMO(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x8219AA0", Offset = "0x82180A0", VA = "0x188219AA0")]
	[AsyncStateMachine(typeof(FPJCJMLJDAK))]
	private Task<ResponseDTO> ECGMBNFGFGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x821C990", Offset = "0x821AF90", VA = "0x18821C990")]
	private void NOMJNHPGEKE(ErrorEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x82188A0", Offset = "0x8216EA0", VA = "0x1882188A0")]
	private void CHHBJKONKJK(InputAudioBufferSpeechStartedEventDTO APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x821A970", Offset = "0x8218F70", VA = "0x18821A970")]
	private void FABBDFDJLOF(InputAudioBufferSpeechStoppedEventDTO APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x821B5B0", Offset = "0x8219BB0", VA = "0x18821B5B0")]
	protected void IDEFMIHHCAI(string LEILDDGFOJJ, [Optional] string? EFCBFMKHFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8219BB0", Offset = "0x82181B0", VA = "0x188219BB0")]
	public static bool EDFODDGLIKN(ResponseDTO JIEFFLNKFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8219C70", Offset = "0x8218270", VA = "0x188219C70")]
	protected void EIKKFGGBKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x821B330", Offset = "0x8219930", VA = "0x18821B330")]
	[CompilerGenerated]
	private bool NFDIBAFLEBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8219C90", Offset = "0x8218290", VA = "0x188219C90")]
	[CompilerGenerated]
	private bool EJAPFEEMFHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class OFADJMIIGBF : BDOMEMFJABO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct NJIDHJOMEFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public EHIPKKAJPOC recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public OFADJMIIGBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Guid spendSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter<LFMAIGHAOKH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8228A10", Offset = "0x8227010", VA = "0x188228A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8228ED0", Offset = "0x82274D0", VA = "0x188228ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly FENLOKHHBLN LFFAAGOPDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly string HELOFCIEMOG;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x822AD90", Offset = "0x8229390", VA = "0x18822AD90")]
	public OFADJMIIGBF(FENLOKHHBLN FJEAIEGEBMP, EHIPKKAJPOC KCNPHOPKNPI, string CCDNBMKFHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x822AC30", Offset = "0x8229230", VA = "0x18822AC30", Slot = "8")]
	[AsyncStateMachine(typeof(NJIDHJOMEFB))]
	protected override Task<bool> TrySyncLatestCostInfo(EHIPKKAJPOC KCNPHOPKNPI, Guid GPDACIBCFMD, long DDLHEHAKJGF, long BIBNADECNIE, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x822ABB0", Offset = "0x82291B0", VA = "0x18822ABB0", Slot = "10")]
	protected override void GPHKLHMOODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x822AB30", Offset = "0x8229130", VA = "0x18822AB30", Slot = "11")]
	protected override void DMALFMHEFCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x822AA00", Offset = "0x8229000", VA = "0x18822AA00")]
	private DGFJDFCLOAM.PCLDPMJNMIH ADLBCBIKBJE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
public class GHKFJKPJGNN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
	public GHKFJKPJGNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface KGFOKOPNOCJ
{
	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GCMBKDELCNF(OHPAOPHAGPI PIALKPIDJDO, [Out] IGHJGMHPEEM KMEJDHBNOCM);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class KGLBMPMAJBD
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class NNHDBBDFLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public PropertyInfo JPLLGLFIMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Type CBPEGPFKLHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x74769C0", Offset = "0x7474FC0", VA = "0x1874769C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public string EOLNNDNNGPA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool DDMJLEPJIHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5700", Offset = "0xAA3D00", VA = "0x180AA5700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Type? ONCBLCBMELD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x822A0B0", Offset = "0x82286B0", VA = "0x18822A0B0")]
		public NNHDBBDFLNJ(PropertyInfo JMGNOEGJODG, JsonPropertyAttribute? JHNBHFDAHME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly ConcurrentDictionary<Type, List<NNHDBBDFLNJ>> NEMHKFEMDDI;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x82248D0", Offset = "0x8222ED0", VA = "0x1882248D0")]
	public static List<string> LHINHPBHIEI(string PAEDANEFMIH, Type JBFMPIPBCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x8223FA0", Offset = "0x82225A0", VA = "0x188223FA0")]
	private static void FBACKGJJLNK(Type GPEIAHGICNA, JObject NAAGPELIBOL, List<string> IGAABAGJBKE, string JOPDLCJOABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x82245C0", Offset = "0x8222BC0", VA = "0x1882245C0")]
	private static List<NNHDBBDFLNJ> KDECGIBJJAF(Type GPEIAHGICNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x8223EF0", Offset = "0x82224F0", VA = "0x188223EF0")]
	private static bool CFFFCGLGBID(Type GPEIAHGICNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public KGLBMPMAJBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal class NJJINDPCACI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KIGOCFALBLD
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string? KNICKNONHNG
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int OOPMNLIKGAK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public int AOPAMMBEIEG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xACF420", Offset = "0xACDA20", VA = "0x180ACF420")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xEF9A80", Offset = "0xEF8080", VA = "0x180EF9A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8232430", Offset = "0x8230A30", VA = "0x188232430")]
		public KIGOCFALBLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class OCIAPGAKNDK
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public string HMNNHOPLICJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public ConversationItemType HIKNDMJOAGH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
			[CompilerGenerated]
			get
			{
				return default(ConversationItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public string? MNPPHEONMJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public string? EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8235A60", Offset = "0x8234060", VA = "0x188235A60")]
		public OCIAPGAKNDK(ConversationItemDTO NANHMPOBBLI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class EPCOIDLGOBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public IEnumerable<string> functionNames;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public EPCOIDLGOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x822E860", Offset = "0x822CE60", VA = "0x18822E860")]
		internal bool GKOLEFENHGO(OCIAPGAKNDK c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class KCNHLODDFCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public OCIAPGAKNDK c;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public KCNHLODDFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8231400", Offset = "0x822FA00", VA = "0x188231400")]
		internal bool HAGEBKLMDBN(string n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class AJFPIHNPMMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public NJJINDPCACI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AJFPIHNPMMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x822DB30", Offset = "0x822C130", VA = "0x18822DB30")]
		internal bool EIMIHCNCKJF(string n)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x822DD90", Offset = "0x822C390", VA = "0x18822DD90")]
		internal bool MFCNKAIGKDO(OCIAPGAKNDK c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x822DB70", Offset = "0x822C170", VA = "0x18822DB70")]
		internal void IPAHKEBIGMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class JFGMFJMFPGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public IEnumerable<string?> callIdsToRemove;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JFGMFJMFPGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8230C90", Offset = "0x822F290", VA = "0x188230C90")]
		internal bool OFALMJCCBKL(OCIAPGAKNDK c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class HKDJEIMEDEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public IEnumerable<string> idsToRemove;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HKDJEIMEDEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x822EAE0", Offset = "0x822D0E0", VA = "0x18822EAE0")]
		internal bool NILCPBHMHLJ(OCIAPGAKNDK c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class BFCEBCAAEMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Func<bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BFCEBCAAEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x822DDE0", Offset = "0x822C3E0", VA = "0x18822DDE0")]
		internal bool PNBCHPKPJNK()
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct DCKADGFMCMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private BFCEBCAAEMA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public NJJINDPCACI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x822E250", Offset = "0x822C850", VA = "0x18822E250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x822E7C0", Offset = "0x822CDC0", VA = "0x18822E7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly FENLOKHHBLN HKACPAOAGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly CLPDFIENAPO IKNEEHEFMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly HashSet<string> EEOBBPOLPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly KIGOCFALBLD JEGDGGNBMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly List<OCIAPGAKNDK> LPEJKDMDDHI;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static Queue<string> NIFFCAFEBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly CancellationTokenSource FIOLBIGBKIO;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8229BA0", Offset = "0x82281A0", VA = "0x188229BA0")]
	public NJJINDPCACI(FENLOKHHBLN CHKIGKNFHID, CLPDFIENAPO EOMKMFNCPFP, KIGOCFALBLD PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8229250", Offset = "0x8227850", VA = "0x188229250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8229060", Offset = "0x8227660", VA = "0x188229060")]
	public void AOBEBLDDNGC(IEnumerable<string> BALIMDHOIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8229330", Offset = "0x8227930", VA = "0x188229330")]
	private void FDIMCBOHDEO(ConversationItemDTO NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8229680", Offset = "0x8227C80", VA = "0x188229680")]
	private void GJELHHMNBPJ(IEnumerable<string?> ICHNAPCELBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8228F40", Offset = "0x8227540", VA = "0x188228F40")]
	[AsyncStateMachine(typeof(DCKADGFMCMM))]
	private Task AGIENHJMJPI(Queue<string> HIOHIPLNPFI, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class HOJONONAFNC : CLPDFIENAPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class FOBLDNBOGIB
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public ConversationItemDTO LAJHLDAJFPK
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool JMNEJFKOOFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0xB268D0", Offset = "0xB24ED0", VA = "0x180B268D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xAB4E30", Offset = "0xAB3430", VA = "0x180AB4E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x16397F0", Offset = "0x1637DF0", VA = "0x1816397F0")]
		public FOBLDNBOGIB(ConversationItemDTO NANHMPOBBLI, bool EGLNMGCHLNJ = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class HBDHPJNCKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HBDHPJNCKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x822EA90", Offset = "0x822D090", VA = "0x18822EA90")]
		internal bool PIHAKOEOPHO(FOBLDNBOGIB c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x822E820", Offset = "0x822CE20", VA = "0x18822E820")]
		internal bool CNLIOGLBMEL(FOBLDNBOGIB c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class KAJKJPDIFCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public KAJKJPDIFCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x822E070", Offset = "0x822C670", VA = "0x18822E070")]
		internal bool OLBCFDFAAMD(FOBLDNBOGIB c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class PFDFFGNKOEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PFDFFGNKOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x822E820", Offset = "0x822CE20", VA = "0x18822E820")]
		internal bool HECMFPELFKA(FOBLDNBOGIB c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class JIBGICGCMOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JIBGICGCMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8230D00", Offset = "0x822F300", VA = "0x188230D00")]
		internal bool CLJFAFCLKOD(FOBLDNBOGIB c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class IDMDPKPLGFJ : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public ConversationItemDTO <>3__item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public HOJONONAFNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private JIBGICGCMOJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private List<ConversationItemContentDTO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
		[DebuggerHidden]
		public IDMDPKPLGFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x82309B0", Offset = "0x822EFB0", VA = "0x1882309B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x82300B0", Offset = "0x822E6B0", VA = "0x1882300B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8230060", Offset = "0x822E660", VA = "0x188230060")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8230960", Offset = "0x822EF60", VA = "0x188230960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x82308A0", Offset = "0x822EEA0", VA = "0x1882308A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x82308A0", Offset = "0x822EEA0", VA = "0x1882308A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class GGNOCNICPHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public string messageId;

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GGNOCNICPHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2239990", Offset = "0x2237F90", VA = "0x182239990")]
		internal bool CGICOIMONLC(ConversationItemDTO m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly CPKIPMBOEAG HKACPAOAGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly MDLHCKNJMIB EDIMPNFJHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly NBKBJBPEAPN JDLNNNGLFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly List<FOBLDNBOGIB> PPFIEKKNGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly List<string> LPEJKDMDDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly List<ConversationItemDTO> GEBPHAPOAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private string? FAMHHBNOBFC;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public PKBDHHCMFJK<ConversationItemDTO> FDIMCBOHDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public IReadOnlyList<string> FMPJIFMGHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public IReadOnlyList<ConversationItemDTO> LGDKJFILFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x822FC20", Offset = "0x822E220", VA = "0x18822FC20")]
	public HOJONONAFNC(CPKIPMBOEAG CHKIGKNFHID, IReadOnlyCollection<string> OKFHLIDMOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x822EBE0", Offset = "0x822D1E0", VA = "0x18822EBE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x822F590", Offset = "0x822DB90", VA = "0x18822F590")]
	public List<string> KHIFOADLLNL(bool KJLIJMIJKAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x822F0F0", Offset = "0x822D6F0", VA = "0x18822F0F0")]
	private void IEJLBODJHLI(ConversationItemCreatedEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x822EE40", Offset = "0x822D440", VA = "0x18822EE40")]
	private void EOCCNGGENEN(ResponseEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x822FA60", Offset = "0x822E060", VA = "0x18822FA60")]
	private void PMADGKPHLJJ(ConversationItemInputAudioTranscriptionCompletedEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x822F860", Offset = "0x822DE60", VA = "0x18822F860")]
	private void NANACFAADKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x822EB40", Offset = "0x822D140", VA = "0x18822EB40", Slot = "6")]
	[IteratorStateMachine(typeof(IDMDPKPLGFJ))]
	public IEnumerable<string> DCAFOAONPHM(ConversationItemDTO NANHMPOBBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x822F780", Offset = "0x822DD80", VA = "0x18822F780", Slot = "7")]
	public void LOPICEKLLAN(string NMGOIKEGKAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class GDFBGHBLDHE : JPFKIODFMAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct LIOCEGDGDPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public IReadOnlyCollection<string> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public GDFBGHBLDHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8232450", Offset = "0x8230A50", VA = "0x188232450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8232870", Offset = "0x8230E70", VA = "0x188232870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly CPKIPMBOEAG HKACPAOAGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly string APMAIPMGCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly int NJNEIABMBKG;

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x60989D0", Offset = "0x6096FD0", VA = "0x1860989D0")]
	public GDFBGHBLDHE(CPKIPMBOEAG CHKIGKNFHID, string DPPLLGDCMCP, int GBDIEHENKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x822E970", Offset = "0x822CF70", VA = "0x18822E970", Slot = "4")]
	[AsyncStateMachine(typeof(LIOCEGDGDPA))]
	public Task DDNIAMLMKKE(IReadOnlyCollection<string> HJFNFENPLEH, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class AEJCLCGKDPK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Type DLFADOBHBIC
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xB2DCA0", Offset = "0xB2C2A0", VA = "0x180B2DCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public string EGBKIGHLGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xAB0450", Offset = "0xAAEA50", VA = "0x180AB0450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x822DA60", Offset = "0x822C060", VA = "0x18822DA60")]
	public AEJCLCGKDPK(Type NEBFLAAINDH, string PAEDANEFMIH, Exception KJLAGGDJKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class NFKAKMGCAJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct KHBDBOGBBNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public string args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public NFKAKMGCAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private Dictionary<OHPAOPHAGPI, IGHJGMHPEEM?>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<string?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8231690", Offset = "0x822FC90", VA = "0x188231690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x82323C0", Offset = "0x82309C0", VA = "0x1882323C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly IPHNFELODMJ EANLMHBELEK;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly List<KGFOKOPNOCJ> APHOKBHCGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly Dictionary<OHPAOPHAGPI, IGHJGMHPEEM?> DEICEHNPKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public readonly FCCGMMLDHAB<OHPAOPHAGPI, IGHJGMHPEEM?> LPDIKDPOCJP;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8233BA0", Offset = "0x82321A0", VA = "0x188233BA0")]
	static NFKAKMGCAJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x82331D0", Offset = "0x82317D0", VA = "0x1882331D0")]
	public void DCDANFOOPPL(params OHPAOPHAGPI[] FHDPJCIKCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x82338C0", Offset = "0x8231EC0", VA = "0x1882338C0")]
	public bool ICGLBGMBBMH(OHPAOPHAGPI PIALKPIDJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8232EB0", Offset = "0x82314B0", VA = "0x188232EB0")]
	public void CHCAJAPLNED(params OHPAOPHAGPI[] FHDPJCIKCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x8233920", Offset = "0x8231F20", VA = "0x188233920")]
	public void LGOGFEIMHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x8233490", Offset = "0x8231A90", VA = "0x188233490")]
	[AsyncStateMachine(typeof(KHBDBOGBBNG))]
	public Task<string> EMPLEENCDIG(string NDIENANOGEK, string PNGANGECEEL, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x82339B0", Offset = "0x8231FB0", VA = "0x1882339B0")]
	public List<ToolDTO> MOJGKEOFDCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x82335F0", Offset = "0x8231BF0", VA = "0x1882335F0")]
	private static IGHJGMHPEEM GPBLGCLDCLG(OHPAOPHAGPI PIALKPIDJDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x8233EE0", Offset = "0x82324E0", VA = "0x188233EE0")]
	public NFKAKMGCAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class IGCCCDAEIKK
{
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static JsonSerializerSettings LHOCCKIHLFL;

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8230A40", Offset = "0x822F040", VA = "0x188230A40")]
	static IGCCCDAEIKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal class NFNAENMIBDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class OIIIDHBHMLF
	{
		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public ConversationItemDTO LAJHLDAJFPK
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool JMNEJFKOOFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0xB268D0", Offset = "0xB24ED0", VA = "0x180B268D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xAB4E30", Offset = "0xAB3430", VA = "0x180AB4E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x16397F0", Offset = "0x1637DF0", VA = "0x1816397F0")]
		public OIIIDHBHMLF(ConversationItemDTO NANHMPOBBLI, bool EGLNMGCHLNJ = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private abstract class BNECFNNICHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private readonly StringBuilder KKMIHIHHCGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private readonly TimeSpan BBAGPECANJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private DateTime IBIPEFBNCDJ;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x822DFC0", Offset = "0x822C5C0", VA = "0x18822DFC0")]
		public BNECFNNICHI(TimeSpan JEONAKGECKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x822DE30", Offset = "0x822C430", VA = "0x18822DE30")]
		public void FPELMAOIODO(string AEJDDHEHHKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x822DE80", Offset = "0x822C480", VA = "0x18822DE80")]
		public void NMBCNGLDPJK(bool AKKFOJDOENB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract Task HIMFHEHOILL(string MEJLBKIDBME);
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class KEKLFBBMJKO : BNECFNNICHI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct KBLPOJDCIGK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public KEKLFBBMJKO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public string text;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8230F90", Offset = "0x822F590", VA = "0x188230F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x82313A0", Offset = "0x822F9A0", VA = "0x1882313A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static readonly TimeSpan NCLCFNOFOEF;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static readonly SemaphoreSlim FNKJMPCLJHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private readonly string MLMNMCGDLDC;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8231600", Offset = "0x822FC00", VA = "0x188231600")]
		public KEKLFBBMJKO(string FOJGLONLCLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8231440", Offset = "0x822FA40", VA = "0x188231440", Slot = "4")]
		[AsyncStateMachine(typeof(KBLPOJDCIGK))]
		protected override Task HIMFHEHOILL(string MEJLBKIDBME)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private class PFBGDCGPPHN : BNECFNNICHI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct MJNODEIIAOC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public PFBGDCGPPHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public string text;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8232AC0", Offset = "0x82310C0", VA = "0x188232AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8232E50", Offset = "0x8231450", VA = "0x188232E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private static readonly TimeSpan NCLCFNOFOEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private readonly EHIPKKAJPOC PCDGKGGHFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private readonly MDLHCKNJMIB EDIMPNFJHOH;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8235C30", Offset = "0x8234230", VA = "0x188235C30")]
		public PFBGDCGPPHN(EHIPKKAJPOC KCNPHOPKNPI, MDLHCKNJMIB JCHKFLNNNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8235AD0", Offset = "0x82340D0", VA = "0x188235AD0", Slot = "4")]
		[AsyncStateMachine(typeof(MJNODEIIAOC))]
		protected override Task HIMFHEHOILL(string MEJLBKIDBME)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class CKKPOCPOEDJ : BNECFNNICHI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct MDBIMMFMHCB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public string text;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x82328D0", Offset = "0x8230ED0", VA = "0x1882328D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8232A60", Offset = "0x8231060", VA = "0x188232A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private static readonly TimeSpan NCLCFNOFOEF;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x822E1F0", Offset = "0x822C7F0", VA = "0x18822E1F0")]
		public CKKPOCPOEDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x822E0B0", Offset = "0x822C6B0", VA = "0x18822E0B0", Slot = "4")]
		[AsyncStateMachine(typeof(MDBIMMFMHCB))]
		protected override Task HIMFHEHOILL(string MEJLBKIDBME)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class NHLEGFGOEHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public NHLEGFGOEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x822E820", Offset = "0x822CE20", VA = "0x18822E820")]
		internal bool PIHAKOEOPHO(OIIIDHBHMLF c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class BNPJFHMHJGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BNPJFHMHJGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x822E070", Offset = "0x822C670", VA = "0x18822E070")]
		internal bool OLBCFDFAAMD(OIIIDHBHMLF c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class DFFPBEICHHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public DFFPBEICHHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x822E820", Offset = "0x822CE20", VA = "0x18822E820")]
		internal bool HECMFPELFKA(OIIIDHBHMLF c)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct JJCIFGNFBFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public NFNAENMIBDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8230D50", Offset = "0x822F350", VA = "0x188230D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8230F30", Offset = "0x822F530", VA = "0x188230F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly TimeSpan NCLCFNOFOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private readonly CPKIPMBOEAG HKACPAOAGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly MDLHCKNJMIB EDIMPNFJHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly EHIPKKAJPOC PCDGKGGHFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly NBKBJBPEAPN JDLNNNGLFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly List<BNECFNNICHI> APHMPNMGEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly List<OIIIDHBHMLF> PPFIEKKNGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private string? FAMHHBNOBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private CancellationTokenSource? MCBOCCIDKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private Task? ILEBEDHFPEB;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8235330", Offset = "0x8233930", VA = "0x188235330")]
	public NFNAENMIBDO(CPKIPMBOEAG CHKIGKNFHID, EHIPKKAJPOC KCNPHOPKNPI, bool HPHLFAAGIOK, bool NLHPOBJHBDL, string? OOHHBJHEMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8233FC0", Offset = "0x82325C0", VA = "0x188233FC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8234940", Offset = "0x8232F40", VA = "0x188234940")]
	private void IEJLBODJHLI(ConversationItemCreatedEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x82342D0", Offset = "0x82328D0", VA = "0x1882342D0")]
	private void EOCCNGGENEN(ResponseEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8235100", Offset = "0x8233700", VA = "0x188235100")]
	private void PMADGKPHLJJ(ConversationItemInputAudioTranscriptionCompletedEventDTO OMAEIAPNEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8234D50", Offset = "0x8233350", VA = "0x188234D50")]
	private void JNBNDCIPKAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8234E70", Offset = "0x8233470", VA = "0x188234E70")]
	private void OGPKHAMIOOP(ConversationItemDTO NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8234790", Offset = "0x8232D90", VA = "0x188234790")]
	private void FPELMAOIODO(string AEJDDHEHHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x82346A0", Offset = "0x8232CA0", VA = "0x1882346A0")]
	[AsyncStateMachine(typeof(JJCIFGNFBFE))]
	private Task FMPPAJMMNKH(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8234580", Offset = "0x8232B80", VA = "0x188234580")]
	private void FHBJNECOMHG(bool AKKFOJDOENB = false)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class IDEENHLMJMC
{
	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public IDEENHLMJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x768A3E0", Offset = "0x76889E0", VA = "0x18768A3E0")]
	public static string HKGPHGJGBLC(byte[] NNNBFANLILN, byte[] COPABLGBACJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
