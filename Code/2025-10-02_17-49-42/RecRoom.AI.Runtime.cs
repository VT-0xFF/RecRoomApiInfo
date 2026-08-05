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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8222C40", Offset = "0x8221640", VA = "0x188222C40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x821E7D0", Offset = "0x821D1D0", VA = "0x18821E7D0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class BKIFECMIGFM : IDisposable, EDMNFONCPNG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct MBPDFCOOIJE : IAsyncStateMachine
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
		public BKIFECMIGFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x821E8E0", Offset = "0x821D2E0", VA = "0x18821E8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct MMOCGNJPACL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public BKIFECMIGFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8221840", Offset = "0x8220240", VA = "0x188221840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8221B70", Offset = "0x8220570", VA = "0x188221B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected static readonly OLFEOKKCIEG JAPFEIFECJM;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly TimeSpan OJOLMPMDNIM;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const decimal JGBHKPAEDEJ = 0.005m;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource DPEJNBPPFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EIMOPKCOAGH HJHIDDFDMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly long LFBPAOIPACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly long MDJKJLDPHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly Guid HLBLOABJNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private decimal CHJODCNPLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? MCCCKHPGBMP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public decimal FJGNECAEAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x102B9A0", Offset = "0x102A3A0", VA = "0x18102B9A0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x102B990", Offset = "0x102A390", VA = "0x18102B990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public decimal CMNGLEGLDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x820C040", Offset = "0x820AA40", VA = "0x18820C040", Slot = "6")]
		get
		{
			return default(decimal);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x820C3C0", Offset = "0x820ADC0", VA = "0x18820C3C0")]
	public BKIFECMIGFM(EIMOPKCOAGH CIFMONJOFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x820BFB0", Offset = "0x820A9B0", VA = "0x18820BFB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
	protected virtual void RunPeriodicMonitorSideEffect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x820C0E0", Offset = "0x820AAE0", VA = "0x18820C0E0")]
	[AsyncStateMachine(typeof(MBPDFCOOIJE))]
	private void FIPMFBHFFGN(CancellationToken AHOMALKMHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x820C1B0", Offset = "0x820ABB0", VA = "0x18820C1B0")]
	[AsyncStateMachine(typeof(MMOCGNJPACL))]
	protected Task<bool> NBCKGPEOHKG(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task<bool> TrySyncLatestCostInfo(EIMOPKCOAGH CIFMONJOFAP, Guid ILMHMCLGFKA, long GDCAPMONNDM, long AFCPIMKFDHC, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x820BF20", Offset = "0x820A920", VA = "0x18820BF20", Slot = "9")]
	public virtual void AddCost(decimal JNJIBPBFNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "10")]
	protected virtual void OOELGODMJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "11")]
	protected virtual void FCNGLOLHPAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum DGIGKCLNFGE
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
public class HBALCKPOHKB : IEquatable<HBALCKPOHKB>
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	protected virtual Type HCMMHEKOCIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8213E80", Offset = "0x8212880", VA = "0x188213E80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DGIGKCLNFGE EMHLKEMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(DGIGKCLNFGE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KLBLJKGJHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xC1EBD0", Offset = "0xC1D5D0", VA = "0x180C1EBD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string[]? FKOGBNIHGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string? MGAHIGAIEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public StringFormat? DBFLIDEOLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xFEB710", Offset = "0xFEA110", VA = "0x180FEB710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double? ANEECMKKIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xEC9A80", Offset = "0xEC8480", VA = "0x180EC9A80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9360", Offset = "0x5EF7D60", VA = "0x185EF9360")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double? NFIFPPPKNKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xEC9A50", Offset = "0xEC8450", VA = "0x180EC9A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF1D0", Offset = "0x7FEDBD0", VA = "0x187FEF1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double? JPAJEAPCOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x518C4B0", Offset = "0x518AEB0", VA = "0x18518C4B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x518AF90", Offset = "0x5189990", VA = "0x18518AF90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double? LPGKCEDLKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x136F430", Offset = "0x136DE30", VA = "0x18136F430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8213EE0", Offset = "0x82128E0", VA = "0x188213EE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public double? LEMHBDDMBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1D375E0", Offset = "0x1D35FE0", VA = "0x181D375E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x563BDB0", Offset = "0x563A7B0", VA = "0x18563BDB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int? HKEJILFLNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x128F7C0", Offset = "0x128E1C0", VA = "0x18128F7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int? COIFELBKAOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB580", Offset = "0x2AE9F80", VA = "0x182AEB580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82142E0", Offset = "0x8212CE0", VA = "0x1882142E0")]
	public HBALCKPOHKB(DGIGKCLNFGE EMHLKEMKMPE, string DDPJMHMICBF, string ELDLMDNPEJP = "", bool KLBLJKGJHKN = false, [Optional] string[]? FKOGBNIHGND, [Optional] string? MGAHIGAIEIG, [Optional] StringFormat? DBFLIDEOLNL, [Optional] double? ANEECMKKIHG, [Optional] double? NFIFPPPKNKF, [Optional] double? JPAJEAPCOBF, [Optional] double? LPGKCEDLKKD, [Optional] double? LEMHBDDMBPF, [Optional] int? HKEJILFLNGD, [Optional] int? COIFELBKAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82140F0", Offset = "0x8212AF0", VA = "0x1882140F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8212E50", Offset = "0x8211850", VA = "0x188212E50", Slot = "6")]
	protected virtual bool ECBFINKPGDH(StringBuilder EAHPNFLHNJH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x12D0300", Offset = "0x12CED00", VA = "0x1812D0300")]
	public static bool DFNINOIAFHB(HBALCKPOHKB? FKHOLJEDBPC, HBALCKPOHKB? EEAEODONEDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x12D07B0", Offset = "0x12CF1B0", VA = "0x1812D07B0")]
	public static bool NOPNAEDOCOI(HBALCKPOHKB? FKHOLJEDBPC, HBALCKPOHKB? EEAEODONEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82139C0", Offset = "0x82123C0", VA = "0x1882139C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8213930", Offset = "0x8212330", VA = "0x188213930", Slot = "0")]
	public override bool Equals(object? PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8213470", Offset = "0x8211E70", VA = "0x188213470", Slot = "7")]
	public virtual bool Equals(HBALCKPOHKB? GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8213EF0", Offset = "0x82128F0", VA = "0x188213EF0", Slot = "8")]
	public virtual HBALCKPOHKB OAGDMDEKLJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8214200", Offset = "0x8212C00", VA = "0x188214200")]
	protected HBALCKPOHKB(HBALCKPOHKB KDKPJJBFLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8214000", Offset = "0x8212A00", VA = "0x188214000")]
	public void ODNAGOAKDMJ([Out] DGIGKCLNFGE EMHLKEMKMPE, [Out] string DDPJMHMICBF, [Out] string ELDLMDNPEJP, [Out] bool KLBLJKGJHKN, [Out] string[]? FKOGBNIHGND, [Out] string? MGAHIGAIEIG, [Out] StringFormat? DBFLIDEOLNL, [Out] double? ANEECMKKIHG, [Out] double? NFIFPPPKNKF, [Out] double? JPAJEAPCOBF, [Out] double? LPGKCEDLKKD, [Out] double? LEMHBDDMBPF, [Out] int? HKEJILFLNGD, [Out] int? COIFELBKAOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EFDIDMLCPND : IEquatable<EFDIDMLCPND>
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected virtual Type HCMMHEKOCIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8210900", Offset = "0x820F300", VA = "0x188210900", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JToken EBOBALABOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public HBALCKPOHKB DCILOHOICML
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x12BB190", Offset = "0x12B9B90", VA = "0x1812BB190")]
	public EFDIDMLCPND(JToken EBOBALABOOI, HBALCKPOHKB DCILOHOICML)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8210C40", Offset = "0x820F640", VA = "0x188210C40")]
	public static int HPICJIDKLEC(EFDIDMLCPND KMAFNKGMDCF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8210F00", Offset = "0x820F900", VA = "0x188210F00")]
	public static float HPICJIDKLEC(EFDIDMLCPND KMAFNKGMDCF)
	{
		return default(float);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8210960", Offset = "0x820F360", VA = "0x188210960")]
	public static bool HPICJIDKLEC(EFDIDMLCPND KMAFNKGMDCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8210D00", Offset = "0x820F700", VA = "0x188210D00")]
	public static string HPICJIDKLEC(EFDIDMLCPND KMAFNKGMDCF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8210DF0", Offset = "0x820F7F0", VA = "0x188210DF0")]
	public static int[] HPICJIDKLEC(EFDIDMLCPND KMAFNKGMDCF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8210FC0", Offset = "0x820F9C0", VA = "0x188210FC0")]
	public static float[] HPICJIDKLEC(EFDIDMLCPND KMAFNKGMDCF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8210B30", Offset = "0x820F530", VA = "0x188210B30")]
	public static bool[] HPICJIDKLEC(EFDIDMLCPND KMAFNKGMDCF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8210A20", Offset = "0x820F420", VA = "0x188210A20")]
	public static string[] HPICJIDKLEC(EFDIDMLCPND KMAFNKGMDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x82111A0", Offset = "0x820FBA0", VA = "0x1882111A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8210520", Offset = "0x820EF20", VA = "0x188210520", Slot = "6")]
	protected virtual bool ECBFINKPGDH(StringBuilder EAHPNFLHNJH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x12D0300", Offset = "0x12CED00", VA = "0x1812D0300")]
	public static bool DFNINOIAFHB(EFDIDMLCPND? FKHOLJEDBPC, EFDIDMLCPND? EEAEODONEDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x12D07B0", Offset = "0x12CF1B0", VA = "0x1812D07B0")]
	public static bool NOPNAEDOCOI(EFDIDMLCPND? FKHOLJEDBPC, EFDIDMLCPND? EEAEODONEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x82107E0", Offset = "0x820F1E0", VA = "0x1882107E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8210750", Offset = "0x820F150", VA = "0x188210750", Slot = "0")]
	public override bool Equals(object? PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8210610", Offset = "0x820F010", VA = "0x188210610", Slot = "7")]
	public virtual bool Equals(EFDIDMLCPND? GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x82110D0", Offset = "0x820FAD0", VA = "0x1882110D0", Slot = "8")]
	public virtual EFDIDMLCPND OAGDMDEKLJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x82112B0", Offset = "0x820FCB0", VA = "0x1882112B0")]
	protected EFDIDMLCPND(EFDIDMLCPND KDKPJJBFLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8211160", Offset = "0x820FB60", VA = "0x188211160")]
	public void ODNAGOAKDMJ([Out] JToken EBOBALABOOI, [Out] HBALCKPOHKB DCILOHOICML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class KPLAJOOKMEE : IEFAGDHFKMD
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const string FJEJHGFIMIG = "Open AI Realtime API";

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private const string PNLMKLNONNF = "endpoint";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly string CCDABHIKJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly List<Func<KLBPGLFMBCI.IBADOKOGBMO, KLBPGLFMBCI.IBADOKOGBMO>> FLLMNIOBNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<Func<KLBPGLFMBCI.IBADOKOGBMO, KLBPGLFMBCI.IBADOKOGBMO>> JIDEGKBIMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CDAOGDIKOBE INMPHHKAPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly EDMNFONCPNG PHAONEPAIIF;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FCDJDPPJMGI? PCOBKBBKODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string CBEFBKCLHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GKBCMGNFMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x821D030", Offset = "0x821BA30", VA = "0x18821D030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x821E5E0", Offset = "0x821CFE0", VA = "0x18821E5E0")]
	public KPLAJOOKMEE(CDAOGDIKOBE HGGIEPIIFIP, EDMNFONCPNG LPNONGOPHJG, string EEAEHKJAKEJ, string FJNABJEHLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x821CF40", Offset = "0x821B940", VA = "0x18821CF40")]
	private static KLBPGLFMBCI.IBADOKOGBMO KLNFOMGEIAN(string HCEKGFLBGMF, string AINBPJDGOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x821C260", Offset = "0x821AC60", VA = "0x18821C260")]
	private KLBPGLFMBCI.IBADOKOGBMO BCFLEJKJFMB(string HCEKGFLBGMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x821C890", Offset = "0x821B290", VA = "0x18821C890", Slot = "8")]
	public void GNIIICDFDKJ(string? MEDJNHBKECM, string JMMIJOBFAPH, string LDNCOAJNKKO, float MPCAADCMDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x821C670", Offset = "0x821B070", VA = "0x18821C670", Slot = "10")]
	public void FDJHOCIDLDO(string? MEDJNHBKECM, ErrorEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x821C410", Offset = "0x821AE10", VA = "0x18821C410", Slot = "11")]
	public void DMJMIAKNEAJ(string? MEDJNHBKECM, decimal NDJBKIDHIBG, string IJNPIDPIBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x821DDD0", Offset = "0x821C7D0", VA = "0x18821DDD0")]
	public static void ODPCEDLHGMM(EDMNFONCPNG LPNONGOPHJG, string LGDIEGLPFLO, string AINBPJDGOKG, decimal NDJBKIDHIBG, string IJNPIDPIBFP, params (string key, string val)[] LGLOJMOIDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x821E070", Offset = "0x821CA70", VA = "0x18821E070", Slot = "12")]
	public void PMNDGIMBGMG(string? MEDJNHBKECM, ConversationItemDTO EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x821D850", Offset = "0x821C250", VA = "0x18821D850", Slot = "15")]
	public void MOKPMBNEPKJ(string? MEDJNHBKECM, ResponseEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x821CB70", Offset = "0x821B570", VA = "0x18821CB70")]
	private (decimal?, string, string, string, string, string) JCOAGKFEDEG(ResponseEventDTO IBBIBNNJNJM)
	{
		return default((decimal?, string, string, string, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x821D0D0", Offset = "0x821BAD0", VA = "0x18821D0D0", Slot = "13")]
	public void MKJMOOOJMKO(string? MEDJNHBKECM, ResponseEventDTO IBBIBNNJNJM, float? OBEONAMJKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x821E010", Offset = "0x821CA10", VA = "0x18821E010", Slot = "14")]
	public void PFLOPCCPMHC(Func<KLBPGLFMBCI.IBADOKOGBMO, KLBPGLFMBCI.IBADOKOGBMO> GMDKLAIIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x821CFD0", Offset = "0x821B9D0", VA = "0x18821CFD0", Slot = "9")]
	public void LAFFHGKMAKE(Func<KLBPGLFMBCI.IBADOKOGBMO, KLBPGLFMBCI.IBADOKOGBMO> GMDKLAIIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x821C2A0", Offset = "0x821ACA0", VA = "0x18821C2A0", Slot = "16")]
	public void DCNCLKOGNJA(string? MEDJNHBKECM, string LJPPNNLHGCJ, string? JPPEOEEHJOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class LGPCEPMGDNB : IEFAGDHFKMD
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public FCDJDPPJMGI? PCOBKBBKODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public decimal FJGNECAEAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x821E710", Offset = "0x821D110", VA = "0x18821E710")]
		get
		{
			return default(decimal);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string CBEFBKCLHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CDAOGDIKOBE? GMLANMGJEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
	public void GNIIICDFDKJ(string? MEDJNHBKECM, string JMMIJOBFAPH, string LDNCOAJNKKO, float MPCAADCMDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "9")]
	public void LAFFHGKMAKE(Func<KLBPGLFMBCI.IBADOKOGBMO, KLBPGLFMBCI.IBADOKOGBMO> GMDKLAIIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "10")]
	public void FDJHOCIDLDO(string? MEDJNHBKECM, ErrorEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "11")]
	public void DMJMIAKNEAJ(string? MEDJNHBKECM, decimal NDJBKIDHIBG, string IJNPIDPIBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "12")]
	public void PMNDGIMBGMG(string? MEDJNHBKECM, ConversationItemDTO EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "15")]
	public void MOKPMBNEPKJ(string? MEDJNHBKECM, ResponseEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "13")]
	public void MKJMOOOJMKO(string? MEDJNHBKECM, ResponseEventDTO IBBIBNNJNJM, float? OBEONAMJKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "14")]
	public void PFLOPCCPMHC(Func<KLBPGLFMBCI.IBADOKOGBMO, KLBPGLFMBCI.IBADOKOGBMO> GMDKLAIIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "16")]
	public void DCNCLKOGNJA(string? MEDJNHBKECM, string LJPPNNLHGCJ, string? JPPEOEEHJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x821E770", Offset = "0x821D170", VA = "0x18821E770")]
	public LGPCEPMGDNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class DEJPLKGCADA : BKIFECMIGFM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct KLKNHNFJOAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public EIMOPKCOAGH recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public DEJPLKGCADA <>4__this;

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
		private TaskAwaiter<JLBJIODKMGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x821B8D0", Offset = "0x821A2D0", VA = "0x18821B8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x821BC50", Offset = "0x821A650", VA = "0x18821BC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly string GMGIELIGPEP;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x820EEF0", Offset = "0x820D8F0", VA = "0x18820EEF0")]
	public DEJPLKGCADA(EIMOPKCOAGH CIFMONJOFAP, string ILHBIPCPNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x820ED90", Offset = "0x820D790", VA = "0x18820ED90", Slot = "8")]
	[AsyncStateMachine(typeof(KLKNHNFJOAL))]
	protected override Task<bool> TrySyncLatestCostInfo(EIMOPKCOAGH CIFMONJOFAP, Guid ILMHMCLGFKA, long GDCAPMONNDM, long AFCPIMKFDHC, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FPJBGDMLCHH
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	AHDLCNFLGGK<ConversationItemDTO> EPCMBOPHNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IReadOnlyList<ConversationItemDTO> AGDHJNMJCOD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<string> JPOEBEFOENC(ConversationItemDTO EOJOFJJBHLN);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void POGAPIBEAFO(string CNNMFHGFJJD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JFKMCDGJHOP
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OONKONHMIOD(IReadOnlyCollection<string> BCHNGBBGBNP, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BNMEKDAONEB
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ToolDTO[] KLIOLNEFFEG();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> NOECNOJOLJO(string KNLFOCHNGKB, string AHLPBIJOEDG, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LECOFHGNIOJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GBKBEKDCMCN : LECOFHGNIOJ, BNMEKDAONEB
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum DNIMHLMNCIK
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Reconnect
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CDAOGDIKOBE
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	const string IIAJAGAMCKP = "gpt-4o-mini-realtime-preview-2024-12-17";

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	const string KHOFCINHGOJ = "gpt-4o-mini-transcribe";

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	IHHAMDLIAHN IPNAKLKNJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	AudioSource MHDBMCIEGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	FPJBGDMLCHH? JJEBLMKJFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	JFKMCDGJHOP? HDEAAFAIILI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string? CBEHNNBCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool PDDBDHCOHJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool FAIOBMIEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool NHIEDEJCEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool MNLFPPPNCMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool JHIBAEHPAKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool CJAFFOMBGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	float KBJKILGFIEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool AGPDCONGJEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool CIAOLMOANKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool OFPJIKFIOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool APOLDFDNCON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool ICOCKLHAONL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool OCPFBJIKBIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	AHDLCNFLGGK<bool> KPEMFNFNOBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	EBDGCEEEFPM IFDPKBDPFLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	AHDLCNFLGGK<DNIMHLMNCIK> LJNLAODIBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FONIFJMDCJB<string, string> BBMEACBFJIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	EBDGCEEEFPM MNHLIKJBBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	EBDGCEEEFPM GHHEJIKKANH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	AHDLCNFLGGK<List<ToolDTO>> ACPCBEMNJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	EBDGCEEEFPM DBMFACEOKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	FONIFJMDCJB<float, string> LPEMBAHLFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	AHDLCNFLGGK<string> MCEPPEEAICA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	EBDGCEEEFPM LIOIDGEDJAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string CBEFBKCLHBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool OBAICKBFCDK
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
	Task IODAEJNKHNE(string CGPFDODFOOL, VoiceOption JDFDIABHFMB, float MPCAADCMDJI = 0.6f, string DOCAJHJNAPB = "gpt-4o-mini-realtime-preview-2024-12-17", string LDNCOAJNKKO = "gpt-4o-mini-transcribe", [Optional] IReadOnlyCollection<string>? MHAMFKNMKBF, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void FJIMPEDAFPB();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task MACKBBALPDL(string CGPFDODFOOL, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task HIHCLFMMENN(float MPCAADCMDJI, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task HCIPGGABCNI(bool LEFHPHFNFDO, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void MAAOEOLHLPA(params LECOFHGNIOJ[] DFBPPJJMNGB);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool JCGGJFGGHHK(LECOFHGNIOJ AOPIOMHENKP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void CPGDCNEAKOA(params LECOFHGNIOJ[] DFBPPJJMNGB);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void MGAHAOPEPLI(OMCJCLBFMAA MFKHKDDANII, bool ONEKELCHPBP = false);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void DGLMFNBPIBD(OMCJCLBFMAA MFKHKDDANII, bool ONEKELCHPBP = false);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void BMAHGAKJBGN(OMCJCLBFMAA MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void NMJKOONHCIJ(OMCJCLBFMAA MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void FPELFIJAICC(decimal NDJBKIDHIBG, string IJNPIDPIBFP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task JGMCIOINAPO(byte[] CDHNLHLJOFO, string? EKPDCONMIHJ, [Optional] string? BICHLDCJMHL, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task JGMCIOINAPO(string JEBOHIALEMJ, [Optional] string? BICHLDCJMHL, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task KAOGCONMNGE(string JEBOHIALEMJ, [Optional] string? BICHLDCJMHL, [Optional] string? ODMEMFKBPFL, bool ONMGLGPIBCG = false, bool IEGJMMNGHIG = false, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task POGAPIBEAFO(string BICHLDCJMHL, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<ResponseDTO> OPCGLAALPFN(bool HLIGLIBDFCJ = true, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task<string> NKPGEDGHNFB(string CGPFDODFOOL, [Optional] IReadOnlyList<ConversationItemDTO>? BCHNGBBGBNP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<TOutput> NKPGEDGHNFB<TOutput>(string CGPFDODFOOL, [Optional] IReadOnlyList<ConversationItemDTO>? BCHNGBBGBNP, [Optional] CancellationToken AHOMALKMHKK) where TOutput : class;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<List<EFDIDMLCPND>> NKPGEDGHNFB(string CGPFDODFOOL, IReadOnlyList<ConversationItemDTO>? BCHNGBBGBNP, IReadOnlyList<HBALCKPOHKB> FMCFKKNPEKH, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool KELEIEMIGOH(string CNNMFHGFJJD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool NAEIBCLDJJA(string CNNMFHGFJJD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool CAALPGGLGGD(string NKHHEPEPINP);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task NNFEIICFIOA(bool GLIAPBIIDKA, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "57")]
	IReadOnlyCollection<string> GBPKAKNFMJO();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IEFAGDHFKMD
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FCDJDPPJMGI? PCOBKBBKODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string CBEFBKCLHBA
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
	void GNIIICDFDKJ(string? MEDJNHBKECM, string JMMIJOBFAPH, string LDNCOAJNKKO, float MPCAADCMDJI);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LAFFHGKMAKE(Func<KLBPGLFMBCI.IBADOKOGBMO, KLBPGLFMBCI.IBADOKOGBMO> GMDKLAIIBAB);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FDJHOCIDLDO(string? MEDJNHBKECM, ErrorEventDTO IBBIBNNJNJM);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DMJMIAKNEAJ(string? MEDJNHBKECM, decimal NDJBKIDHIBG, string IJNPIDPIBFP);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PMNDGIMBGMG(string? MEDJNHBKECM, ConversationItemDTO EOJOFJJBHLN);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MKJMOOOJMKO(string? MEDJNHBKECM, ResponseEventDTO IBBIBNNJNJM, float? OBEONAMJKAC);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PFLOPCCPMHC(Func<KLBPGLFMBCI.IBADOKOGBMO, KLBPGLFMBCI.IBADOKOGBMO> GMDKLAIIBAB);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MOKPMBNEPKJ(string? MEDJNHBKECM, ResponseEventDTO IBBIBNNJNJM);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DCNCLKOGNJA(string? MEDJNHBKECM, string LJPPNNLHGCJ, string? JPPEOEEHJOI);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface DFGKNCPCOKL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void CKAGDNFKIOJ(ReadOnlySpan<float> EFNPFAIMEFP, int MCAKEJBBCAG, int HGCOIPKMAAD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDLCHOEKHNG(CKAGDNFKIOJ MBFPBKDOJPD);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBOOFDIJPHN(CKAGDNFKIOJ MBFPBKDOJPD);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EDMNFONCPNG
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	decimal CMNGLEGLDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AddCost(decimal JNJIBPBFNFO);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class CHILHEEPKFF
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private enum ILCDKMNJENP
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
	private static ConcurrentDictionary<Type, JsonSchema> KADKAGGHIBE;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static readonly Type[] OAKMAEOHHKF;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static readonly Type[] HDONEHGLGHA;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3B8B500", Offset = "0x3B89F00", VA = "0x183B8B500")]
	public static JsonSchema GFFPJLNAMHB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x820D810", Offset = "0x820C210", VA = "0x18820D810")]
	public static JsonSchema LEJDFMCCBGA(IReadOnlyList<HBALCKPOHKB> ALHCDLPBNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x820CF60", Offset = "0x820B960", VA = "0x18820CF60")]
	public static HIJPBOEHCOE CBABILGKHCL(string IELIBBNCJAC, string? GDFPOPIGPDJ, JsonSchema AKNNLNNGMIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B8B480", Offset = "0x3B89E80", VA = "0x183B8B480")]
	public static HIJPBOEHCOE CBABILGKHCL<T>(string IELIBBNCJAC, string? GDFPOPIGPDJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x820D070", Offset = "0x820BA70", VA = "0x18820D070")]
	public static HIJPBOEHCOE CBABILGKHCL(string IELIBBNCJAC, string? GDFPOPIGPDJ, IReadOnlyList<HBALCKPOHKB> ALHCDLPBNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x820D1C0", Offset = "0x820BBC0", VA = "0x18820D1C0")]
	private static JsonSchema FIHBJCOAODN(Type DGNODDPLLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x820C9D0", Offset = "0x820B3D0", VA = "0x18820C9D0")]
	private static JsonSchema ALHIHNEBCKN(Type DGNODDPLLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x820D610", Offset = "0x820C010", VA = "0x18820D610")]
	private static ILCDKMNJENP JKPGJEIKCPP(Type DGNODDPLLPC, [Out] Type? BMFIGBAJCHH)
	{
		return default(ILCDKMNJENP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x820DB60", Offset = "0x820C560", VA = "0x18820DB60")]
	private static bool OHPDKAHNKMN(Type DGNODDPLLPC, [Out][MaybeNullWhen(false)] Type BMPBOCMBNAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ECGJLHACJCE : GBKBEKDCMCN, LECOFHGNIOJ, BNMEKDAONEB
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate Task<string> JIKBHNANBGI(List<EFDIDMLCPND> DNEDADEPKEO);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate string AGHCBLMMJIJ(List<EFDIDMLCPND> DNEDADEPKEO);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class CONAADDEMBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AGHCBLMMJIJ handler;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CONAADDEMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x820ED00", Offset = "0x820D700", VA = "0x18820ED00")]
		internal Task<string> DFKCOOJLNMK(List<EFDIDMLCPND> invokedArgs)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct NNABAIIBDAK : IAsyncStateMachine
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
		public ECGJLHACJCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public string methodArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x82221C0", Offset = "0x8220BC0", VA = "0x1882221C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8222870", Offset = "0x8221270", VA = "0x188222870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly string KGHHGPDHHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string AHOIDGNLMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IReadOnlyList<HBALCKPOHKB> EDNLMFNKBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly JIKBHNANBGI JAOKDNEFBCO;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x112D030", Offset = "0x112BA30", VA = "0x18112D030")]
	public ECGJLHACJCE(string IELIBBNCJAC, string GDFPOPIGPDJ, IReadOnlyList<HBALCKPOHKB> ALHCDLPBNNA, JIKBHNANBGI OIAJENBJKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x820FB90", Offset = "0x820E590", VA = "0x18820FB90")]
	public ECGJLHACJCE(string IELIBBNCJAC, string GDFPOPIGPDJ, IReadOnlyList<HBALCKPOHKB> ALHCDLPBNNA, AGHCBLMMJIJ OIAJENBJKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x820F8D0", Offset = "0x820E2D0", VA = "0x18820F8D0", Slot = "4")]
	private ToolDTO[] CANCEFJPKDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x820FA50", Offset = "0x820E450", VA = "0x18820FA50", Slot = "5")]
	[AsyncStateMachine(typeof(NNABAIIBDAK))]
	private Task<string> HEBEPBHMOCE(string KNLFOCHNGKB, string AHLPBIJOEDG, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class GBLKGLOLNMK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
	public GBLKGLOLNMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MPLOGPLLBDC : Exception, JMACELMAENA
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string NDOGKHNBKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5A677E0", Offset = "0x5A661E0", VA = "0x185A677E0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8221BE0", Offset = "0x82205E0", VA = "0x188221BE0")]
	public MPLOGPLLBDC(string CCEHMBCOGBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class IGKENJHBLNJ : CDAOGDIKOBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private enum EHIHJICKOMJ
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
	private struct MLAMKFEHFNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public IGKENJHBLNJ <>4__this;

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
		private TaskAwaiter<IHHAMDLIAHN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<bool> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x821F390", Offset = "0x821DD90", VA = "0x18821F390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x82217E0", Offset = "0x82201E0", VA = "0x1882217E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct FPGEDAGHDFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8212090", Offset = "0x8210A90", VA = "0x188212090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x82122A0", Offset = "0x8210CA0", VA = "0x1882122A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PFHKMOHKOBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8222CC0", Offset = "0x82216C0", VA = "0x188222CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8222EF0", Offset = "0x82218F0", VA = "0x188222EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct IPEMNGPNLOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x821B190", Offset = "0x8219B90", VA = "0x18821B190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x821B3A0", Offset = "0x8219DA0", VA = "0x18821B3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct EECAEIECBHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x820FD80", Offset = "0x820E780", VA = "0x18820FD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x820FF90", Offset = "0x820E990", VA = "0x18820FF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct NOMLKEOIKIM : IAsyncStateMachine
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
		public IGKENJHBLNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x82228E0", Offset = "0x82212E0", VA = "0x1882228E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8222BE0", Offset = "0x82215E0", VA = "0x188222BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct HBFMNGOKJMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x82143D0", Offset = "0x8212DD0", VA = "0x1882143D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8214850", Offset = "0x8213250", VA = "0x188214850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DPEMNNMNCOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x820F400", Offset = "0x820DE00", VA = "0x18820F400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x820F870", Offset = "0x820E270", VA = "0x18820F870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct PGFGEAAFLAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8222F50", Offset = "0x8221950", VA = "0x188222F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x82234A0", Offset = "0x8221EA0", VA = "0x1882234A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct ADCDFPCNLMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8209BA0", Offset = "0x82085A0", VA = "0x188209BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x820A000", Offset = "0x8208A00", VA = "0x18820A000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class KEMBHPLAAKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public ResponseDTO response;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KEMBHPLAAKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x821B8A0", Offset = "0x821A2A0", VA = "0x18821B8A0")]
		internal bool KLOCEFFFGOO(OutputAudioBufferEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct COGKIKMNMFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public IGKENJHBLNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private KEMBHPLAAKO <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x820E440", Offset = "0x820CE40", VA = "0x18820E440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x820EC90", Offset = "0x820D690", VA = "0x18820EC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct MDHGBBDEGMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x821ED70", Offset = "0x821D770", VA = "0x18821ED70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x821F320", Offset = "0x821DD20", VA = "0x18821F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct EDNFNIHODMG<TOutput> : IAsyncStateMachine where TOutput : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder<TOutput> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4B06150", Offset = "0x4B04B50", VA = "0x184B06150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4B069B0", Offset = "0x4B053B0", VA = "0x184B069B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct HFKCOJKGOOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder<List<EFDIDMLCPND>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public IReadOnlyList<HBALCKPOHKB> responseArgSchemas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x82148B0", Offset = "0x82132B0", VA = "0x1882148B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8214F80", Offset = "0x8213980", VA = "0x188214F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class NLFBPPEEAMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public IGKENJHBLNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public ResponseCreateEventDTO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public string id;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NLFBPPEEAMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x82220C0", Offset = "0x8220AC0", VA = "0x1882220C0")]
		internal void KEEABMMNAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8222030", Offset = "0x8220A30", VA = "0x188222030")]
		internal bool ANCJAHPAFEJ(ResponseEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct FKDFCFMHABP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AsyncTaskMethodBuilder<List<ConversationItemDTO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x82114A0", Offset = "0x820FEA0", VA = "0x1882114A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8211D20", Offset = "0x8210720", VA = "0x188211D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct JCHDAFKFPHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x821B400", Offset = "0x8219E00", VA = "0x18821B400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x821B840", Offset = "0x821A240", VA = "0x18821B840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BPDAAGBKNBE : IAsyncStateMachine
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
		public IGKENJHBLNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x820C580", Offset = "0x820AF80", VA = "0x18820C580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x820C970", Offset = "0x820B370", VA = "0x18820C970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DIJBIKPBDNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x820EF70", Offset = "0x820D970", VA = "0x18820EF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x820F3A0", Offset = "0x820DDA0", VA = "0x18820F3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct KMJBGPHACEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x821BCC0", Offset = "0x821A6C0", VA = "0x18821BCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class ACLCHHHNOGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public IGKENJHBLNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ACLCHHHNOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8209A80", Offset = "0x8208480", VA = "0x188209A80")]
		internal Task PBDIAALCDIF(ConversationItemDTO outputItem)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct AFCNPKINDFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public IGKENJHBLNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public ResponseDTO response;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private ACLCHHHNOGD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x820A060", Offset = "0x8208A60", VA = "0x18820A060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x820A8D0", Offset = "0x82092D0", VA = "0x18820A8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct FLGKOHJLAPL : IAsyncStateMachine
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
		public IGKENJHBLNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8211D90", Offset = "0x8210790", VA = "0x188211D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8212030", Offset = "0x8210A30", VA = "0x188212030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct NEDPAKFNFPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public IGKENJHBLNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8221C60", Offset = "0x8220660", VA = "0x188221C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8221FC0", Offset = "0x82209C0", VA = "0x188221FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct HKFHMLPKPMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public IGKENJHBLNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8214FF0", Offset = "0x82139F0", VA = "0x188214FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8215B20", Offset = "0x8214520", VA = "0x188215B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly OLFEOKKCIEG JAPFEIFECJM;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private const ToolChoice IOBPFGIHIIF = ToolChoice.Auto;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private const float AEDIAFLPMGK = 0.01f;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly TimeSpan[] PDDOHKLOGJA;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly TimeSpan MLFPPHLMEKJ;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly TimeSpan HHAHGGBEEFH;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly TimeSpan ABDAPLDBNGO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly TimeSpan FHKCJHFKMDH;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly TimeSpan EJNFHFNAFPC;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly TimeSpan CFOFKPAIBIH;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private const string KFLCLPIKONI = "out-of-band-id";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly FLLMPDGKPPM LONKOMGLOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly DFGKNCPCOKL BMPAEBACHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected readonly EIMOPKCOAGH HJHIDDFDMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly KMEMMBOIPEF NAFFMNMEPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IGNLLEDJLPA NHJOALLAKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IGNLLEDJLPA HLLONODENCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<string, DateTime> GODEABHLFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly Lazy<IEFAGDHFKMD> DLJBGKPMCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CLIPBDKIDFO? BNIPMNJJFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private string BNMNJELHHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private VoiceOption PCMAMIOHLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private float EFHDLAJOAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private string HGLEGMDAALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private string BBGAPCICAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private EHIHJICKOMJ JIAAEOHLMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private CancellationTokenSource? DPEJNBPPFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	protected IHHAMDLIAHN? OACJMCOFKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private AudioSource? KLECMCBILJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private AudioSourceSimpleLevelMeter? JCNEHCOHMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private ENMPIAAJHNF? PMOBAFMOLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private IFKDBGJCPNE? BBOGIDDALOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private ALKEGKJPMGI? IGJEJKFGMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private HEMPGJGLDKD? EKNMJNCFDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private IReadOnlyCollection<string> PAPLFGPPJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private DateTime? EJEMOMFDJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Task<ResponseDTO>? OAOCHIELJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private uint ENBCDNKNPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly HashSet<string> AEINFNHMBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly HashSet<string> JCJPIDBBFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly HashSet<string> CDKCLAHIOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool FHHHLCBOIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private OMCJCLBFMAA? BNOONAIBCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool GCGBIELPDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private CancellationTokenSource? LCCBFAEOFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private string? NOLACJLJBCP;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public IHHAMDLIAHN IPNAKLKNJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8217D50", Offset = "0x8216750", VA = "0x188217D50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string? CBEHNNBCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x821A450", Offset = "0x8218E50", VA = "0x18821A450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool CCLBIDGDFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1001D10", Offset = "0x1000710", VA = "0x181001D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public abstract bool PDDBDHCOHJF
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract bool FAIOBMIEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract bool NHIEDEJCEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected abstract bool HKMMHKHHGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected abstract string? JNPGNOENGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected abstract string FMLGJCKPEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected abstract int GOEBEJDECFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected abstract int IMKIKINLFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	protected abstract GLPGDNLNMKB CJNFLFHACOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	protected abstract string NNKNKGFMPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected virtual bool JCLKFCPCAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "74")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected Func<bool>? FJDLALLMMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xBA4B00", Offset = "0xBA3500", VA = "0x180BA4B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xB9CAD0", Offset = "0xB9B4D0", VA = "0x180B9CAD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool MNLFPPPNCMP
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8217090", Offset = "0x8215A90", VA = "0x188217090", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool JHIBAEHPAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8219050", Offset = "0x8217A50", VA = "0x188219050", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool CJAFFOMBGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x821A150", Offset = "0x8218B50", VA = "0x18821A150", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public float KBJKILGFIEO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8217DF0", Offset = "0x82167F0", VA = "0x188217DF0", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool AGPDCONGJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xBDC4A0", Offset = "0xBDAEA0", VA = "0x180BDC4A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xBD5400", Offset = "0xBD3E00", VA = "0x180BD5400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool CIAOLMOANKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8215B90", Offset = "0x8214590", VA = "0x188215B90", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool OFPJIKFIOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8217E80", Offset = "0x8216880", VA = "0x188217E80", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool APOLDFDNCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2910350", Offset = "0x290ED50", VA = "0x182910350", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool ICOCKLHAONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8216520", Offset = "0x8214F20", VA = "0x188216520", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool OCPFBJIKBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8215DE0", Offset = "0x82147E0", VA = "0x188215DE0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private bool DNGENIEDALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x82191B0", Offset = "0x8217BB0", VA = "0x1882191B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private bool OJGAIJADMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x82196A0", Offset = "0x82180A0", VA = "0x1882196A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private bool CIEFJJNMOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x82170A0", Offset = "0x8215AA0", VA = "0x1882170A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool OBAICKBFCDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x20604C0", Offset = "0x205EEC0", VA = "0x1820604C0", Slot = "59")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5032430", Offset = "0x5030E30", VA = "0x185032430", Slot = "60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private uint BGNICGFGLNH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xB70EA0", Offset = "0xB6F8A0", VA = "0x180B70EA0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8219630", Offset = "0x8218030", VA = "0x188219630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public AudioSource MHDBMCIEGLA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public FPJBGDMLCHH? JJEBLMKJFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public JFKMCDGJHOP? HDEAAFAIILI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xAB9520", Offset = "0xAB7F20", VA = "0x180AB9520", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string CBEFBKCLHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8218620", Offset = "0x8217020", VA = "0x188218620")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8216FA0", Offset = "0x82159A0", VA = "0x188216FA0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	protected virtual string? NHEINFIDDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xC28520", Offset = "0xC26F20", VA = "0x180C28520", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	protected virtual OLFEOKKCIEG? MMLIHCDACJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	protected virtual OLFEOKKCIEG? OAFJOGODMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "77")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public AHDLCNFLGGK<bool> KPEMFNFNOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xC261F0", Offset = "0xC24BF0", VA = "0x180C261F0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public EBDGCEEEFPM IFDPKBDPFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xC265D0", Offset = "0xC24FD0", VA = "0x180C265D0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public AHDLCNFLGGK<DNIMHLMNCIK> LJNLAODIBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xC40F40", Offset = "0xC3F940", VA = "0x180C40F40", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FONIFJMDCJB<string, string> BBMEACBFJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xC29330", Offset = "0xC27D30", VA = "0x180C29330", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public AHDLCNFLGGK<List<ToolDTO>> ACPCBEMNJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xC2F450", Offset = "0xC2DE50", VA = "0x180C2F450", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public EBDGCEEEFPM MNHLIKJBBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xC26D40", Offset = "0xC25740", VA = "0x180C26D40", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public EBDGCEEEFPM GHHEJIKKANH
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xC410F0", Offset = "0xC3FAF0", VA = "0x180C410F0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public EBDGCEEEFPM DBMFACEOKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xC25680", Offset = "0xC24080", VA = "0x180C25680", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FONIFJMDCJB<float, string> LPEMBAHLFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xC28670", Offset = "0xC27070", VA = "0x180C28670", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public AHDLCNFLGGK<string> MCEPPEEAICA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xC3B980", Offset = "0xC3A380", VA = "0x180C3B980", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EBDGCEEEFPM LIOIDGEDJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xB4F5B0", Offset = "0xB4DFB0", VA = "0x180B4F5B0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x821AA00", Offset = "0x8219400", VA = "0x18821AA00")]
	public IGKENJHBLNJ(FLLMPDGKPPM ALLAKMJLBMO, DFGKNCPCOKL NKLOODLFINH, EIMOPKCOAGH CIFMONJOFAP, [Optional] CLIPBDKIDFO? GIIGDGKADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x821A4A0", Offset = "0x8218EA0", VA = "0x18821A4A0")]
	private void PNEBPFCIDNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "63")]
	protected abstract IEFAGDHFKMD CreateDataReporter();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8216190", Offset = "0x8214B90", VA = "0x188216190")]
	private void BNKHMPMIGOE(LECOFHGNIOJ HKAIOBBCBGO, BNMEKDAONEB? OIAJENBJKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x82182D0", Offset = "0x8216CD0", VA = "0x1882182D0", Slot = "33")]
	public Task IODAEJNKHNE(string CGPFDODFOOL, VoiceOption JDFDIABHFMB, float MPCAADCMDJI, string DOCAJHJNAPB, string LDNCOAJNKKO, [Optional] IReadOnlyCollection<string>? MHAMFKNMKBF, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8215E00", Offset = "0x8214800", VA = "0x188215E00")]
	[AsyncStateMachine(typeof(MLAMKFEHFNP))]
	private Task BFMMFLDPJEO(int? EFEHMPIFFOA, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8216AB0", Offset = "0x82154B0", VA = "0x188216AB0", Slot = "78")]
	protected virtual Task CheckAccess(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x821A770", Offset = "0x8219170", VA = "0x18821A770", Slot = "79")]
	protected virtual Task<bool> UploadTranscriptsForModeration(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x82170B0", Offset = "0x8215AB0", VA = "0x1882170B0", Slot = "34")]
	public void FJIMPEDAFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8217280", Offset = "0x8215C80", VA = "0x188217280")]
	private void GDHGGODOHPM(DNIMHLMNCIK LPCNHKPFNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8219F10", Offset = "0x8218910", VA = "0x188219F10", Slot = "57")]
	[AsyncStateMachine(typeof(FPGEDAGHDFE))]
	public Task NNFEIICFIOA(bool GLIAPBIIDKA, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8216BB0", Offset = "0x82155B0", VA = "0x188216BB0", Slot = "80")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8219340", Offset = "0x8217D40", VA = "0x188219340", Slot = "35")]
	[AsyncStateMachine(typeof(PFHKMOHKOBP))]
	public Task MACKBBALPDL(string CGPFDODFOOL, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8217FE0", Offset = "0x82169E0", VA = "0x188217FE0", Slot = "36")]
	[AsyncStateMachine(typeof(IPEMNGPNLOI))]
	public Task HIHCLFMMENN(float MPCAADCMDJI, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8216570", Offset = "0x8214F70", VA = "0x188216570")]
	[AsyncStateMachine(typeof(EECAEIECBHC))]
	public Task BOKLOEGNEFB(bool LEFHPHFNFDO, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8217ED0", Offset = "0x82168D0", VA = "0x188217ED0", Slot = "37")]
	[AsyncStateMachine(typeof(NOMLKEOIKIM))]
	public Task HCIPGGABCNI(bool LEFHPHFNFDO, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x82192C0", Offset = "0x8217CC0", VA = "0x1882192C0", Slot = "38")]
	public void MAAOEOLHLPA(params LECOFHGNIOJ[] DFBPPJJMNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8218370", Offset = "0x8216D70", VA = "0x188218370", Slot = "39")]
	public bool JCGGJFGGHHK(LECOFHGNIOJ AOPIOMHENKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8216A30", Offset = "0x8215430", VA = "0x188216A30", Slot = "40")]
	public void CPGDCNEAKOA(params LECOFHGNIOJ[] DFBPPJJMNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x82195C0", Offset = "0x8217FC0", VA = "0x1882195C0", Slot = "41")]
	public void MGAHAOPEPLI(OMCJCLBFMAA MFKHKDDANII, bool ONEKELCHPBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8216B40", Offset = "0x8215540", VA = "0x188216B40", Slot = "42")]
	public void DGLMFNBPIBD(OMCJCLBFMAA MFKHKDDANII, bool ONEKELCHPBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8216150", Offset = "0x8214B50", VA = "0x188216150", Slot = "43")]
	public void BMAHGAKJBGN(OMCJCLBFMAA MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8219D80", Offset = "0x8218780", VA = "0x188219D80", Slot = "44")]
	public void NMJKOONHCIJ(OMCJCLBFMAA MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8217220", Offset = "0x8215C20", VA = "0x188217220", Slot = "61")]
	public IReadOnlyCollection<string> GBPKAKNFMJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x82170C0", Offset = "0x8215AC0", VA = "0x1882170C0", Slot = "45")]
	public void FPELFIJAICC(decimal NDJBKIDHIBG, string IJNPIDPIBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x82184D0", Offset = "0x8216ED0", VA = "0x1882184D0", Slot = "46")]
	[AsyncStateMachine(typeof(HBFMNGOKJMJ))]
	public Task JGMCIOINAPO(byte[] CDHNLHLJOFO, string? EKPDCONMIHJ, string? BICHLDCJMHL, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8218390", Offset = "0x8216D90", VA = "0x188218390", Slot = "47")]
	[AsyncStateMachine(typeof(DPEMNNMNCOP))]
	public Task JGMCIOINAPO(string JEBOHIALEMJ, string? BICHLDCJMHL, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8218EA0", Offset = "0x82178A0", VA = "0x188218EA0", Slot = "48")]
	[AsyncStateMachine(typeof(PGFGEAAFLAD))]
	public Task KAOGCONMNGE(string JEBOHIALEMJ, string? BICHLDCJMHL, string? ODMEMFKBPFL, bool ONMGLGPIBCG, bool IEGJMMNGHIG, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x821A650", Offset = "0x8219050", VA = "0x18821A650", Slot = "49")]
	[AsyncStateMachine(typeof(ADCDFPCNLMF))]
	public Task POGAPIBEAFO(string MDKMKNBLFJM, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8218FF0", Offset = "0x82179F0", VA = "0x188218FF0", Slot = "54")]
	public bool KELEIEMIGOH(string CNNMFHGFJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x82196F0", Offset = "0x82180F0", VA = "0x1882196F0", Slot = "55")]
	public bool NAEIBCLDJJA(string CNNMFHGFJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8216680", Offset = "0x8215080", VA = "0x188216680", Slot = "56")]
	public bool CAALPGGLGGD(string NKHHEPEPINP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x821A1E0", Offset = "0x8218BE0", VA = "0x18821A1E0", Slot = "50")]
	[AsyncStateMachine(typeof(COGKIKMNMFG))]
	public Task<ResponseDTO> OPCGLAALPFN(bool HLIGLIBDFCJ = true, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8219B10", Offset = "0x8218510", VA = "0x188219B10", Slot = "51")]
	[AsyncStateMachine(typeof(MDHGBBDEGMM))]
	public Task<string> NKPGEDGHNFB(string CGPFDODFOOL, [Optional] IReadOnlyList<ConversationItemDTO>? BCHNGBBGBNP, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3DEE9A0", Offset = "0x3DED3A0", VA = "0x183DEE9A0", Slot = "52")]
	[AsyncStateMachine(typeof(EDNFNIHODMG<>))]
	public Task<TOutput> NKPGEDGHNFB<TOutput>(string CGPFDODFOOL, [Optional] IReadOnlyList<ConversationItemDTO>? BCHNGBBGBNP, [Optional] CancellationToken AHOMALKMHKK) where TOutput : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x82199A0", Offset = "0x82183A0", VA = "0x1882199A0", Slot = "53")]
	[AsyncStateMachine(typeof(HFKCOJKGOOD))]
	public Task<List<EFDIDMLCPND>> NKPGEDGHNFB(string CGPFDODFOOL, IReadOnlyList<ConversationItemDTO>? BCHNGBBGBNP, IReadOnlyList<HBALCKPOHKB> FMCFKKNPEKH, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8215BD0", Offset = "0x82145D0", VA = "0x188215BD0")]
	[AsyncStateMachine(typeof(FKDFCFMHABP))]
	private Task<List<ConversationItemDTO>> ACIAOMMLLGI(string CGPFDODFOOL, IReadOnlyList<ConversationItemDTO>? BCHNGBBGBNP, JsonSchema? NKAFKNODBIK, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x82190C0", Offset = "0x8217AC0", VA = "0x1882190C0")]
	[AsyncStateMachine(typeof(JCHDAFKFPHP))]
	public Task KPJLOCKLCLN([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8216D50", Offset = "0x8215750", VA = "0x188216D50")]
	[AsyncStateMachine(typeof(BPDAAGBKNBE))]
	private Task EJHAJDNCCPN(DateTime EICKHCHPIJA, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8219750", Offset = "0x8218150", VA = "0x188219750")]
	private bool NGPHGOCHANJ(ResponseDTO EKMCEDIJMDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8215D40", Offset = "0x8214740", VA = "0x188215D40")]
	private void ADBCHEDIOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x821A3B0", Offset = "0x8218DB0", VA = "0x18821A3B0")]
	private void PHKGKEMDIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x82180F0", Offset = "0x8216AF0", VA = "0x1882180F0")]
	[AsyncStateMachine(typeof(DIJBIKPBDNH))]
	private Task HKNMONJNHAM([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x82181E0", Offset = "0x8216BE0", VA = "0x1882181E0")]
	private void HOFPKCIBDJD(ReadOnlySpan<float> EFNPFAIMEFP, int MCAKEJBBCAG, int HGCOIPKMAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8216090", Offset = "0x8214A90", VA = "0x188216090")]
	private void BLGIKKKIAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8216840", Offset = "0x8215240", VA = "0x188216840")]
	[AsyncStateMachine(typeof(KMJBGPHACEO))]
	private void CIMNOAHLEJC(ResponseEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8216E60", Offset = "0x8215860", VA = "0x188216E60")]
	private void EPCMBOPHNGL(ConversationItemDTO EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3DEE860", Offset = "0x3DED260", VA = "0x183DEE860")]
	private void GEMFEEMFDCO<T>(T IBBIBNNJNJM) where T : notnull, ABJIBPMIAMC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x8218690", Offset = "0x8217090", VA = "0x188218690")]
	private void JPAJKOENBIO(ResponseEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8219450", Offset = "0x8217E50", VA = "0x188219450")]
	private void MFCMDBFBJPD(string JMMIJOBFAPH, string LDNCOAJNKKO, float MPCAADCMDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8216910", Offset = "0x8215310", VA = "0x188216910")]
	[AsyncStateMachine(typeof(AFCNPKINDFJ))]
	private Task CJOIFAEGFBD(ResponseDTO EKMCEDIJMDM, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x821A040", Offset = "0x8218A40", VA = "0x18821A040")]
	[AsyncStateMachine(typeof(FLGKOHJLAPL))]
	private Task NOECNOJOLJO(ConversationItemDTO EOJOFJJBHLN, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8219C70", Offset = "0x8218670", VA = "0x188219C70")]
	[AsyncStateMachine(typeof(NEDPAKFNFPA))]
	private Task<ResponseDTO> NMFIMKDPNOE(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x8215F80", Offset = "0x8214980", VA = "0x188215F80")]
	[AsyncStateMachine(typeof(HKFHMLPKPMI))]
	private Task<ResponseDTO> BJPFCDKNCGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8216700", Offset = "0x8215100", VA = "0x188216700")]
	private void CGDAKJNKALF(ErrorEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8218E70", Offset = "0x8217870", VA = "0x188218E70")]
	private void JPDDFKLMLDC(InputAudioBufferSpeechStartedEventDTO HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x821A320", Offset = "0x8218D20", VA = "0x18821A320")]
	private void PBMPJABAGPF(InputAudioBufferSpeechStoppedEventDTO HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8219DC0", Offset = "0x82187C0", VA = "0x188219DC0")]
	protected void NNDKBOFPEAF(string LJPPNNLHGCJ, [Optional] string? JPPEOEEHJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8216CE0", Offset = "0x82156E0", VA = "0x188216CE0")]
	public static bool EAIOOJICBDD(ResponseDTO EKMCEDIJMDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x821A020", Offset = "0x8218A20", VA = "0x18821A020")]
	protected void NNNEHFOFIHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8215B90", Offset = "0x8214590", VA = "0x188215B90")]
	[CompilerGenerated]
	private bool FECPBILMJAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8215F20", Offset = "0x8214920", VA = "0x188215F20")]
	[CompilerGenerated]
	private bool BHOHHIEDACJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class AMKJCLENJJA : BKIFECMIGFM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct EEOANGGLBIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public EIMOPKCOAGH recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AMKJCLENJJA <>4__this;

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
		private TaskAwaiter<JLBJIODKMGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x820FFF0", Offset = "0x820E9F0", VA = "0x18820FFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x82104B0", Offset = "0x820EEB0", VA = "0x1882104B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly CDAOGDIKOBE INMPHHKAPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly string GMGIELIGPEP;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x820BE30", Offset = "0x820A830", VA = "0x18820BE30")]
	public AMKJCLENJJA(CDAOGDIKOBE HGGIEPIIFIP, EIMOPKCOAGH CIFMONJOFAP, string ILHBIPCPNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x820BCD0", Offset = "0x820A6D0", VA = "0x18820BCD0", Slot = "8")]
	[AsyncStateMachine(typeof(EEOANGGLBIO))]
	protected override Task<bool> TrySyncLatestCostInfo(EIMOPKCOAGH CIFMONJOFAP, Guid ILMHMCLGFKA, long GDCAPMONNDM, long AFCPIMKFDHC, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x820BC50", Offset = "0x820A650", VA = "0x18820BC50", Slot = "10")]
	protected override void OOELGODMJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x820BAA0", Offset = "0x820A4A0", VA = "0x18820BAA0", Slot = "11")]
	protected override void FCNGLOLHPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x820BB20", Offset = "0x820A520", VA = "0x18820BB20")]
	private KLBPGLFMBCI.IBADOKOGBMO KLNFOMGEIAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
public class NBAFEIPBCEB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
	public NBAFEIPBCEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface MKMODIIGCON
{
	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAIOHPBCHFM(LECOFHGNIOJ AOPIOMHENKP, [Out] BNMEKDAONEB OIAJENBJKKC);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class GAPOBEFPIGC
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class FEGGOGGOBJC
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public PropertyInfo PNDHAOOPCME
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Type KOHNOJFBACP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x74719F0", Offset = "0x74703F0", VA = "0x1874719F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public string KKBGKFIEEIB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool MLMJGCONMFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Type? JIIHPKDIGKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8211300", Offset = "0x820FD00", VA = "0x188211300")]
		public FEGGOGGOBJC(PropertyInfo ECDCHGGHANA, JsonPropertyAttribute? COIDCGKDAGA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly ConcurrentDictionary<Type, List<FEGGOGGOBJC>> OFMBEHLECLA;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x82123B0", Offset = "0x8210DB0", VA = "0x1882123B0")]
	public static List<string> MNKOHOMIPGE(string LGKBNMPAIAJ, Type ADAHDIHJIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x82124A0", Offset = "0x8210EA0", VA = "0x1882124A0")]
	private static void MOEHPCGIJOA(Type DGNODDPLLPC, JObject KBHLMIPKLIK, List<string> IPIMKNALOCN, string FEGBHGKMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x8212AB0", Offset = "0x82114B0", VA = "0x188212AB0")]
	private static List<FEGGOGGOBJC> NDDHGMPBCOB(Type DGNODDPLLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x8212300", Offset = "0x8210D00", VA = "0x188212300")]
	private static bool LAIMFIDKDGP(Type DGNODDPLLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GAPOBEFPIGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal class ALKEGKJPMGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class LDJLFFGOGKH
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string? COPPCGLOMDG
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int IDIBFLLLIHP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public int NOHHALPMGKP
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xEFFCF0", Offset = "0xEFE6F0", VA = "0x180EFFCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x822BF70", Offset = "0x822A970", VA = "0x18822BF70")]
		public LDJLFFGOGKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class NGDOODDEJBA
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public string BKICOPKGOOC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public ConversationItemType EMHLKEMKMPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			[CompilerGenerated]
			get
			{
				return default(ConversationItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public string? FLCOPOMNPCA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public string? DDPJMHMICBF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x822BF90", Offset = "0x822A990", VA = "0x18822BF90")]
		public NGDOODDEJBA(ConversationItemDTO EOJOFJJBHLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class HJKGLOFAJAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public IEnumerable<string> functionNames;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HJKGLOFAJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8229860", Offset = "0x8228260", VA = "0x188229860")]
		internal bool GHDOCAAMPOP(NGDOODDEJBA c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class JIFMNDILIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public NGDOODDEJBA c;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public JIFMNDILIJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x822A9A0", Offset = "0x82293A0", VA = "0x18822A9A0")]
		internal bool DNAAHFHPHGK(string n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class FKCDPALGIBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public ALKEGKJPMGI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FKCDPALGIBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8226DC0", Offset = "0x82257C0", VA = "0x188226DC0")]
		internal bool GHNFKBEKAAH(string n)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8226D70", Offset = "0x8225770", VA = "0x188226D70")]
		internal bool DDFGOEAMPBJ(NGDOODDEJBA c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8226E00", Offset = "0x8225800", VA = "0x188226E00")]
		internal void PMAFHLINMKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class INEGNAFHCPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public IEnumerable<string?> callIdsToRemove;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public INEGNAFHCPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8229A90", Offset = "0x8228490", VA = "0x188229A90")]
		internal bool GCEOIICDGIH(NGDOODDEJBA c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class DINKAPNCIDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public IEnumerable<string> idsToRemove;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DINKAPNCIDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8224B10", Offset = "0x8223510", VA = "0x188224B10")]
		internal bool MDKFDLPHCFG(NGDOODDEJBA c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KEDMIHADPFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Func<bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KEDMIHADPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x822A9E0", Offset = "0x82293E0", VA = "0x18822A9E0")]
		internal bool NAGLDAKKNKD()
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct COGMKDBDICD : IAsyncStateMachine
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
		private KEDMIHADPFI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public ALKEGKJPMGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8224300", Offset = "0x8222D00", VA = "0x188224300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8224870", Offset = "0x8223270", VA = "0x188224870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly CDAOGDIKOBE PJPHEGFIBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly FPJBGDMLCHH PMOBAFMOLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly HashSet<string> APBBEIHIOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly LDJLFFGOGKH DIHGBLHABPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly List<NGDOODDEJBA> PAPLFGPPJAM;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static Queue<string> KAGAKHGFFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly CancellationTokenSource EGNKBMPNOHK;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x820B590", Offset = "0x8209F90", VA = "0x18820B590")]
	public ALKEGKJPMGI(CDAOGDIKOBE GDDAKCDNHHP, FPJBGDMLCHH PDHNCJFIOJF, LDJLFFGOGKH ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x820A930", Offset = "0x8209330", VA = "0x18820A930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x820AD60", Offset = "0x8209760", VA = "0x18820AD60")]
	public void MEJMDDPPPAA(IEnumerable<string> FMGKCONAHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x820AA10", Offset = "0x8209410", VA = "0x18820AA10")]
	private void EPCMBOPHNGL(ConversationItemDTO EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x820B070", Offset = "0x8209A70", VA = "0x18820B070")]
	private void PPGKGNGCMEM(IEnumerable<string?> PPBGMOEHFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x820AF50", Offset = "0x8209950", VA = "0x18820AF50")]
	[AsyncStateMachine(typeof(COGMKDBDICD))]
	private Task OIDPLCGFFLD(Queue<string> LBPHLNLFCPC, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class ENMPIAAJHNF : FPJBGDMLCHH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class AFHPMGFFKEK
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public ConversationItemDTO PCCJLFHFGOC
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool FOECIABLOAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0xB36DB0", Offset = "0xB357B0", VA = "0x180B36DB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xAB2B80", Offset = "0xAB1580", VA = "0x180AB2B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x163DEC0", Offset = "0x163C8C0", VA = "0x18163DEC0")]
		public AFHPMGFFKEK(ConversationItemDTO EOJOFJJBHLN, bool NJIKCHPEHND = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class CGOKHAIJLHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CGOKHAIJLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x82242B0", Offset = "0x8222CB0", VA = "0x1882242B0")]
		internal bool HEEPANMLOIG(AFHPMGFFKEK c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8223E00", Offset = "0x8222800", VA = "0x188223E00")]
		internal bool BKJDAAMGKFN(AFHPMGFFKEK c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class OAHGABIBLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OAHGABIBLIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8229B00", Offset = "0x8228500", VA = "0x188229B00")]
		internal bool AGPMOJKJIGE(AFHPMGFFKEK c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class FCPFHCJBPMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FCPFHCJBPMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8223E00", Offset = "0x8222800", VA = "0x188223E00")]
		internal bool GGODDDHPGEE(AFHPMGFFKEK c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class OFFLIKBFPGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OFFLIKBFPGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x822C000", Offset = "0x822AA00", VA = "0x18822C000")]
		internal bool MJCPKIHKGFI(AFHPMGFFKEK c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class JBHJNEIHDOK : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public ENMPIAAJHNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private OFFLIKBFPGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private List<ConversationItemContentDTO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public JBHJNEIHDOK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x822A490", Offset = "0x8228E90", VA = "0x18822A490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8229B90", Offset = "0x8228590", VA = "0x188229B90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8229B40", Offset = "0x8228540", VA = "0x188229B40")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x822A440", Offset = "0x8228E40", VA = "0x18822A440", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x822A380", Offset = "0x8228D80", VA = "0x18822A380", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x822A380", Offset = "0x8228D80", VA = "0x18822A380", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class MNLBGCIOJMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public string messageId;

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public MNLBGCIOJMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x224D7D0", Offset = "0x224C1D0", VA = "0x18224D7D0")]
		internal bool MMGMHEFAGCK(ConversationItemDTO m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly IGKENJHBLNJ PJPHEGFIBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly IHHAMDLIAHN OACJMCOFKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly OMCJCLBFMAA OGBLEMOOACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly List<AFHPMGFFKEK> PHLCDIOCCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly List<string> PAPLFGPPJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly List<ConversationItemDTO> CKCJOLABAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private string? FDINKFPHFKF;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public AHDLCNFLGGK<ConversationItemDTO> EPCMBOPHNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public IReadOnlyList<string> OBDGHCLOIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public IReadOnlyList<ConversationItemDTO> AGDHJNMJCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8226030", Offset = "0x8224A30", VA = "0x188226030")]
	public ENMPIAAJHNF(IGKENJHBLNJ GDDAKCDNHHP, IReadOnlyCollection<string> BCIJCJDHNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8225150", Offset = "0x8223B50", VA = "0x188225150", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x82253B0", Offset = "0x8223DB0", VA = "0x1882253B0")]
	public List<string> GBPKAKNFMJO(bool CNHJAIOIMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x8225AB0", Offset = "0x82244B0", VA = "0x188225AB0")]
	private void PFJIOFKNPPM(ConversationItemCreatedEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x82255A0", Offset = "0x8223FA0", VA = "0x1882255A0")]
	private void JPAJKOENBIO(ResponseEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x82258F0", Offset = "0x82242F0", VA = "0x1882258F0")]
	private void MDFACDFNEMI(ConversationItemInputAudioTranscriptionCompletedEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8224F50", Offset = "0x8223950", VA = "0x188224F50")]
	private void CLPGBDKFELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8225850", Offset = "0x8224250", VA = "0x188225850", Slot = "6")]
	[IteratorStateMachine(typeof(JBHJNEIHDOK))]
	public IEnumerable<string> JPOEBEFOENC(ConversationItemDTO EOJOFJJBHLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8225F50", Offset = "0x8224950", VA = "0x188225F50", Slot = "7")]
	public void POGAPIBEAFO(string CNNMFHGFJJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class IFKDBGJCPNE : JFKMCDGJHOP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct JENEGNFCMIM : IAsyncStateMachine
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
		public IFKDBGJCPNE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x822A520", Offset = "0x8228F20", VA = "0x18822A520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x822A940", Offset = "0x8229340", VA = "0x18822A940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly IGKENJHBLNJ PJPHEGFIBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly string JANMPBCOCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly int IPJHFCDBGCG;

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x60709D0", Offset = "0x606F3D0", VA = "0x1860709D0")]
	public IFKDBGJCPNE(IGKENJHBLNJ GDDAKCDNHHP, string IGJHKNJHBGF, int OBCNMFDCDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x8229970", Offset = "0x8228370", VA = "0x188229970", Slot = "4")]
	[AsyncStateMachine(typeof(JENEGNFCMIM))]
	public Task OONKONHMIOD(IReadOnlyCollection<string> BCHNGBBGBNP, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class EPMOFGOANEC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Type IJGAACMJJPF
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public string GIOJDNNMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x8226470", Offset = "0x8224E70", VA = "0x188226470")]
	public EPMOFGOANEC(Type LNHJINMJFFH, string LGKBNMPAIAJ, Exception BFLPFMDLFDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class KMEMMBOIPEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct FMGOGAHJCLN : IAsyncStateMachine
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
		public KMEMMBOIPEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private Dictionary<LECOFHGNIOJ, BNMEKDAONEB?>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<string?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8227020", Offset = "0x8225A20", VA = "0x188227020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8227D50", Offset = "0x8226750", VA = "0x188227D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly OLFEOKKCIEG JAPFEIFECJM;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly List<MKMODIIGCON> LKJNAMECCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly Dictionary<LECOFHGNIOJ, BNMEKDAONEB?> CCHBGELFEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public readonly FONIFJMDCJB<LECOFHGNIOJ, BNMEKDAONEB?> BNKHMPMIGOE;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x822B720", Offset = "0x822A120", VA = "0x18822B720")]
	static KMEMMBOIPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x822B270", Offset = "0x8229C70", VA = "0x18822B270")]
	public void MAAOEOLHLPA(params LECOFHGNIOJ[] DFBPPJJMNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x822AD50", Offset = "0x8229750", VA = "0x18822AD50")]
	public bool JCGGJFGGHHK(LECOFHGNIOJ AOPIOMHENKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x822AA30", Offset = "0x8229430", VA = "0x18822AA30")]
	public void CPGDCNEAKOA(params LECOFHGNIOJ[] DFBPPJJMNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x822B690", Offset = "0x822A090", VA = "0x18822B690")]
	public void OFODMIKEJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x822B530", Offset = "0x8229F30", VA = "0x18822B530")]
	[AsyncStateMachine(typeof(FMGOGAHJCLN))]
	public Task<string> NOECNOJOLJO(string IELIBBNCJAC, string ALHCDLPBNNA, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x822B080", Offset = "0x8229A80", VA = "0x18822B080")]
	public List<ToolDTO> LKOLFAOMBOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x822ADB0", Offset = "0x82297B0", VA = "0x18822ADB0")]
	private static BNMEKDAONEB LIAHGIIFDNL(LECOFHGNIOJ AOPIOMHENKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x822BA60", Offset = "0x822A460", VA = "0x18822BA60")]
	public KMEMMBOIPEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class DNIEOCMAAGP
{
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static JsonSerializerSettings HANHHJPKNOM;

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8224B70", Offset = "0x8223570", VA = "0x188224B70")]
	static DNIEOCMAAGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal class HEMPGJGLDKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class CJJGKNIDOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public ConversationItemDTO PCCJLFHFGOC
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool FOECIABLOAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0xB36DB0", Offset = "0xB357B0", VA = "0x180B36DB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xAB2B80", Offset = "0xAB1580", VA = "0x180AB2B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x163DEC0", Offset = "0x163C8C0", VA = "0x18163DEC0")]
		public CJJGKNIDOKJ(ConversationItemDTO EOJOFJJBHLN, bool NJIKCHPEHND = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private abstract class COJMIIFFFIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private readonly StringBuilder EALKMFOFJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private readonly TimeSpan GOPAPBKOEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private DateTime BCKGJGMIHON;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8224A60", Offset = "0x8223460", VA = "0x188224A60")]
		public COJMIIFFFIF(TimeSpan HKFJCKDMHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8224A10", Offset = "0x8223410", VA = "0x188224A10")]
		public void PNHIIICOOCA(string JIAHILAGKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x82248D0", Offset = "0x82232D0", VA = "0x1882248D0")]
		public void NKELCENPCLK(bool KEJIJALNLAM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract Task GFNEBLFKLDI(string AKEJFNGKBEL);
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class FHMMKPEBAFJ : COJMIIFFFIF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct BBHPPJJIFNG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public FHMMKPEBAFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public string text;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8223E40", Offset = "0x8222840", VA = "0x188223E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8224250", Offset = "0x8222C50", VA = "0x188224250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static readonly TimeSpan EIKICEAKPHD;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static readonly SemaphoreSlim DIOGINFJKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private readonly string BACKBLDGDMN;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8226AE0", Offset = "0x82254E0", VA = "0x188226AE0")]
		public FHMMKPEBAFJ(string JAKIJIEGAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8226920", Offset = "0x8225320", VA = "0x188226920", Slot = "4")]
		[AsyncStateMachine(typeof(BBHPPJJIFNG))]
		protected override Task GFNEBLFKLDI(string AKEJFNGKBEL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private class FJAFNJKMBPD : COJMIIFFFIF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct FCEFCFJONAJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public FJAFNJKMBPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public string text;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8226540", Offset = "0x8224F40", VA = "0x188226540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x82268C0", Offset = "0x82252C0", VA = "0x1882268C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private static readonly TimeSpan EIKICEAKPHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private readonly EIMOPKCOAGH HJHIDDFDMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private readonly IHHAMDLIAHN OACJMCOFKOM;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8226CD0", Offset = "0x82256D0", VA = "0x188226CD0")]
		public FJAFNJKMBPD(EIMOPKCOAGH CIFMONJOFAP, IHHAMDLIAHN DBICILBJNEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8226B70", Offset = "0x8225570", VA = "0x188226B70", Slot = "4")]
		[AsyncStateMachine(typeof(FCEFCFJONAJ))]
		protected override Task GFNEBLFKLDI(string AKEJFNGKBEL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class ENGHOJPHEFA : COJMIIFFFIF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct LCCGGLFNLCA : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x822BD80", Offset = "0x822A780", VA = "0x18822BD80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x822BF10", Offset = "0x822A910", VA = "0x18822BF10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private static readonly TimeSpan EIKICEAKPHD;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8224EF0", Offset = "0x82238F0", VA = "0x188224EF0")]
		public ENGHOJPHEFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8224DB0", Offset = "0x82237B0", VA = "0x188224DB0", Slot = "4")]
		[AsyncStateMachine(typeof(LCCGGLFNLCA))]
		protected override Task GFNEBLFKLDI(string AKEJFNGKBEL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class HLCAJMBIJIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HLCAJMBIJIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8223E00", Offset = "0x8222800", VA = "0x188223E00")]
		internal bool HEEPANMLOIG(CJJGKNIDOKJ c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class IPIANHDFFGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IPIANHDFFGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8229B00", Offset = "0x8228500", VA = "0x188229B00")]
		internal bool AGPMOJKJIGE(CJJGKNIDOKJ c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class ADJMOEHEONL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ADJMOEHEONL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8223E00", Offset = "0x8222800", VA = "0x188223E00")]
		internal bool GGODDDHPGEE(CJJGKNIDOKJ c)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct KNCEFKHCNGB : IAsyncStateMachine
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
		public HEMPGJGLDKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x822BB40", Offset = "0x822A540", VA = "0x18822BB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x822BD20", Offset = "0x822A720", VA = "0x18822BD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly TimeSpan EIKICEAKPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private readonly IGKENJHBLNJ PJPHEGFIBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly IHHAMDLIAHN OACJMCOFKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly EIMOPKCOAGH HJHIDDFDMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly OMCJCLBFMAA OGBLEMOOACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly List<COJMIIFFFIF> MIONAHCEGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly List<CJJGKNIDOKJ> PHLCDIOCCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private string? FDINKFPHFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private CancellationTokenSource? KPLJKKIDBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private Task? LIOGILNGFLL;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8229130", Offset = "0x8227B30", VA = "0x188229130")]
	public HEMPGJGLDKD(IGKENJHBLNJ GDDAKCDNHHP, EIMOPKCOAGH CIFMONJOFAP, bool OJPEMLFHLMB, bool FHEMOBHNGNF, string? FLOONNEOAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8227FD0", Offset = "0x82269D0", VA = "0x188227FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x82289E0", Offset = "0x82273E0", VA = "0x1882289E0")]
	private void PFJIOFKNPPM(ConversationItemCreatedEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8228570", Offset = "0x8226F70", VA = "0x188228570")]
	private void JPAJKOENBIO(ResponseEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8228820", Offset = "0x8227220", VA = "0x188228820")]
	private void MDFACDFNEMI(ConversationItemInputAudioTranscriptionCompletedEventDTO IBBIBNNJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8228DF0", Offset = "0x82277F0", VA = "0x188228DF0")]
	private void PLDGJHBFEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x82282E0", Offset = "0x8226CE0", VA = "0x1882282E0")]
	private void HMJEOIACLGN(ConversationItemDTO EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8228F10", Offset = "0x8227910", VA = "0x188228F10")]
	private void PNHIIICOOCA(string JIAHILAGKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8227DC0", Offset = "0x82267C0", VA = "0x188227DC0")]
	[AsyncStateMachine(typeof(KNCEFKHCNGB))]
	private Task AEICOCOKKLN(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8227EB0", Offset = "0x82268B0", VA = "0x188227EB0")]
	private void DFKCFDLGEEA(bool KEJIJALNLAM = false)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class HOMBPOKEPHI
{
	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HOMBPOKEPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x7684ED0", Offset = "0x76838D0", VA = "0x187684ED0")]
	public static string GFBFIMHGKPM(byte[] DDEIHHFHHME, byte[] JHDCFCMBFOH)
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
