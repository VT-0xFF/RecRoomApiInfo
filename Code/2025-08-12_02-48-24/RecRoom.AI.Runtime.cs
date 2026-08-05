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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81A5240", Offset = "0x81A3840", VA = "0x1881A5240")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81A37E0", Offset = "0x81A1DE0", VA = "0x1881A37E0", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class DHPPDBLLJNN : IDisposable, LDIGLDIFLFE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct IAGNJFHCJGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DHPPDBLLJNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x819C050", Offset = "0x819A650", VA = "0x18819C050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAE2D00", Offset = "0xAE1300", VA = "0x180AE2D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BMOJOPIHDFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public DHPPDBLLJNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x818E260", Offset = "0x818C860", VA = "0x18818E260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x818E500", Offset = "0x818CB00", VA = "0x18818E500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected static readonly IDGHEFJHGEI AOPICECIPOD;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly TimeSpan OBMIHIIJJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource MJKCKPMHGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IHNBIIBBKOO MENJCMODBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly long GMMOODNGCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly long PGGEFKALECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private decimal BKKOPBOCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Guid PCBHFAFGNCM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public decimal NKCADOGNEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x129FD30", Offset = "0x129E330", VA = "0x18129FD30")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8066C70", Offset = "0x8065270", VA = "0x188066C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x818EF00", Offset = "0x818D500", VA = "0x18818EF00")]
	public DHPPDBLLJNN(IHNBIIBBKOO EHOACMCPAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x818ECD0", Offset = "0x818D2D0", VA = "0x18818ECD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x818EC00", Offset = "0x818D200", VA = "0x18818EC00")]
	[AsyncStateMachine(typeof(IAGNJFHCJGL))]
	private void DLBJFKMMLEN(CancellationToken MEKNAIONNND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x818ED40", Offset = "0x818D340", VA = "0x18818ED40")]
	[AsyncStateMachine(typeof(BMOJOPIHDFO))]
	private Task<bool> EEAIJMNHFIA(CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task<bool> TrySyncLatestCostInfo(IHNBIIBBKOO EHOACMCPAPE, Guid ILECBMFGBIG, long PANGCFBNCCJ, long MECJEAAIDNJ, CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x818EB70", Offset = "0x818D170", VA = "0x18818EB70", Slot = "5")]
	public void DCMFNMOOPGK(decimal KNFJBPOKNOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum PMCECICDPKN
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Float,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	String
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BALIHLOENGM : IEquatable<BALIHLOENGM>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected virtual Type IDPJOIDDLFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x818C100", Offset = "0x818A700", VA = "0x18818C100", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PMCECICDPKN MONFNOPPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(PMCECICDPKN);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FLLDLOOAFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xC00D60", Offset = "0xBFF360", VA = "0x180C00D60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string[]? HJFHFMCPNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x818C2E0", Offset = "0x818A8E0", VA = "0x18818C2E0")]
	public BALIHLOENGM(PMCECICDPKN MONFNOPPPGA, string CLGAHBNBCJM, string ACHJJIPNFFG = "", bool FLLDLOOAFAD = false, [Optional] string[]? HJFHFMCPNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x818C160", Offset = "0x818A760", VA = "0x18818C160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x818BC20", Offset = "0x818A220", VA = "0x18818BC20", Slot = "6")]
	protected virtual bool FEEJNMKOALE(StringBuilder MBGGGJHKEDJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x129AB10", Offset = "0x1299110", VA = "0x18129AB10")]
	public static bool PACMOMIAEBP(BALIHLOENGM? KCALPCMINJB, BALIHLOENGM? LLDLIDKIBDI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x129AAE0", Offset = "0x12990E0", VA = "0x18129AAE0")]
	public static bool LMIMJGGKHMP(BALIHLOENGM? KCALPCMINJB, BALIHLOENGM? LLDLIDKIBDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x818BE60", Offset = "0x818A460", VA = "0x18818BE60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x818B980", Offset = "0x8189F80", VA = "0x18818B980", Slot = "0")]
	public override bool Equals(object? NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x818BA10", Offset = "0x818A010", VA = "0x18818BA10", Slot = "7")]
	public virtual bool Equals(BALIHLOENGM? IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x818C060", Offset = "0x818A660", VA = "0x18818C060", Slot = "8")]
	public virtual BALIHLOENGM JIGFIMEFMEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x818C270", Offset = "0x818A870", VA = "0x18818C270")]
	protected BALIHLOENGM(BALIHLOENGM JECPIAPPEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x818B920", Offset = "0x8189F20", VA = "0x18818B920")]
	public void BHACFNDCJGJ([Out] PMCECICDPKN MONFNOPPPGA, [Out] string CLGAHBNBCJM, [Out] string ACHJJIPNFFG, [Out] bool FLLDLOOAFAD, [Out] string[]? HJFHFMCPNHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JEHNFBNLDAL : IEquatable<JEHNFBNLDAL>
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	protected virtual Type IDPJOIDDLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x81A05D0", Offset = "0x819EBD0", VA = "0x1881A05D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JToken CBGNCAEJLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public BALIHLOENGM DCAKJLMHEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x127FA40", Offset = "0x127E040", VA = "0x18127FA40")]
	public JEHNFBNLDAL(JToken CBGNCAEJLOI, BALIHLOENGM DCAKJLMHEBG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x819FDD0", Offset = "0x819E3D0", VA = "0x18819FDD0")]
	public static int ACOPOEEHBNI(JEHNFBNLDAL FKMNCAKIOFK)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x81A0060", Offset = "0x819E660", VA = "0x1881A0060")]
	public static float ACOPOEEHBNI(JEHNFBNLDAL FKMNCAKIOFK)
	{
		return default(float);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x819FFA0", Offset = "0x819E5A0", VA = "0x18819FFA0")]
	public static bool ACOPOEEHBNI(JEHNFBNLDAL FKMNCAKIOFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x819FCE0", Offset = "0x819E2E0", VA = "0x18819FCE0")]
	public static string ACOPOEEHBNI(JEHNFBNLDAL FKMNCAKIOFK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x819F9B0", Offset = "0x819DFB0", VA = "0x18819F9B0")]
	public static int[] ACOPOEEHBNI(JEHNFBNLDAL FKMNCAKIOFK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x819FE90", Offset = "0x819E490", VA = "0x18819FE90")]
	public static float[] ACOPOEEHBNI(JEHNFBNLDAL FKMNCAKIOFK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x819FAC0", Offset = "0x819E0C0", VA = "0x18819FAC0")]
	public static bool[] ACOPOEEHBNI(JEHNFBNLDAL FKMNCAKIOFK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x819FBD0", Offset = "0x819E1D0", VA = "0x18819FBD0")]
	public static string[] ACOPOEEHBNI(JEHNFBNLDAL FKMNCAKIOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81A0630", Offset = "0x819EC30", VA = "0x1881A0630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x81A0330", Offset = "0x819E930", VA = "0x1881A0330", Slot = "6")]
	protected virtual bool FEEJNMKOALE(StringBuilder MBGGGJHKEDJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x129AB10", Offset = "0x1299110", VA = "0x18129AB10")]
	public static bool PACMOMIAEBP(JEHNFBNLDAL? KCALPCMINJB, JEHNFBNLDAL? LLDLIDKIBDI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x129AAE0", Offset = "0x12990E0", VA = "0x18129AAE0")]
	public static bool LMIMJGGKHMP(JEHNFBNLDAL? KCALPCMINJB, JEHNFBNLDAL? LLDLIDKIBDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x81A0420", Offset = "0x819EA20", VA = "0x1881A0420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x81A02A0", Offset = "0x819E8A0", VA = "0x1881A02A0", Slot = "0")]
	public override bool Equals(object? NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x81A0160", Offset = "0x819E760", VA = "0x1881A0160", Slot = "7")]
	public virtual bool Equals(JEHNFBNLDAL? IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x81A0540", Offset = "0x819EB40", VA = "0x1881A0540", Slot = "8")]
	public virtual JEHNFBNLDAL JIGFIMEFMEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x81A0740", Offset = "0x819ED40", VA = "0x1881A0740")]
	protected JEHNFBNLDAL(JEHNFBNLDAL JECPIAPPEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x81A0120", Offset = "0x819E720", VA = "0x1881A0120")]
	public void BHACFNDCJGJ([Out] JToken CBGNCAEJLOI, [Out] BALIHLOENGM DCAKJLMHEBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class FOKLJOPPGJI : LNHIONJEEEO
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string FMFNGMFIFLN = "Open AI Realtime API";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string PFOBOOOJOCE = "endpoint";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly string JAHABFOJEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly List<Func<BADIKMHNEFC.AIBAOICHDFP, BADIKMHNEFC.AIBAOICHDFP>> BNNJLCOPCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<Func<BADIKMHNEFC.AIBAOICHDFP, BADIKMHNEFC.AIBAOICHDFP>> MKLLADJCBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly COKEEBJCEBE LGHHGINDEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly LDIGLDIFLFE IABBEODLLNG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public LGOOIFEAAND? GJKKPFPKNKE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string GKAIPAECDBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool EEIBIEHBJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8192D90", Offset = "0x8191390", VA = "0x188192D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8194ED0", Offset = "0x81934D0", VA = "0x188194ED0")]
	public FOKLJOPPGJI(COKEEBJCEBE IHMCCPNPALD, LDIGLDIFLFE MDPMELLELDN, string MHELJAGHFIK, string EOENFEJKCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8194090", Offset = "0x8192690", VA = "0x188194090")]
	private static BADIKMHNEFC.AIBAOICHDFP LJGEBBDCAIE(string HINMKEEBNDE, string BBOGBOFPMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x81948A0", Offset = "0x8192EA0", VA = "0x1881948A0")]
	private BADIKMHNEFC.AIBAOICHDFP MCOAJHMNHBJ(string HINMKEEBNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8193DB0", Offset = "0x81923B0", VA = "0x188193DB0", Slot = "8")]
	public void LGIEIMCMFMG(string? FIGODFNPPLD, string MAHKAFHEJID, string HHILGDFKKBA, float DPENBEMKJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8194A50", Offset = "0x8193050", VA = "0x188194A50", Slot = "10")]
	public void MIEPFEADKHO(string? FIGODFNPPLD, ErrorEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8194C70", Offset = "0x8193270", VA = "0x188194C70", Slot = "11")]
	public void OFAEEIPFNON(string? FIGODFNPPLD, decimal FEEOAMBCAFN, string HHPFOCCGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8192B50", Offset = "0x8191150", VA = "0x188192B50")]
	public static void CENCJOENFGL(LDIGLDIFLFE MDPMELLELDN, string KOHOAAFOHKL, string BBOGBOFPMLE, decimal FEEOAMBCAFN, string HHPFOCCGJIF, params (string key, string val)[] LDAEIKDMPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8192E30", Offset = "0x8191430", VA = "0x188192E30", Slot = "12")]
	public void DFGNDMEOKPP(string? FIGODFNPPLD, ConversationItemDTO KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8193830", Offset = "0x8191E30", VA = "0x188193830", Slot = "15")]
	public void KLNHBNHGPEA(string? FIGODFNPPLD, ResponseEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x81933A0", Offset = "0x81919A0", VA = "0x1881933A0")]
	private (decimal?, string, string, string, string, string) EIKGHGEIODD(ResponseEventDTO OHAAGLFJMJP)
	{
		return default((decimal?, string, string, string, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8194120", Offset = "0x8192720", VA = "0x188194120", Slot = "13")]
	public void MBNGMDIIBAA(string? FIGODFNPPLD, ResponseEventDTO OHAAGLFJMJP, float? DCEJLAANKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x81937D0", Offset = "0x8191DD0", VA = "0x1881937D0", Slot = "14")]
	public void JNPCPAICOFF(Func<BADIKMHNEFC.AIBAOICHDFP, BADIKMHNEFC.AIBAOICHDFP> JCBCBBGHBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8193770", Offset = "0x8191D70", VA = "0x188193770", Slot = "9")]
	public void FOALCAEMKAE(Func<BADIKMHNEFC.AIBAOICHDFP, BADIKMHNEFC.AIBAOICHDFP> JCBCBBGHBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x81948E0", Offset = "0x8192EE0", VA = "0x1881948E0", Slot = "16")]
	public void MGIEEPKHHAF(string? FIGODFNPPLD, string DAAMNHJEIGF, string? DIAEKDIDAKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NCIJDHCNOFL : LNHIONJEEEO
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public LGOOIFEAAND? GJKKPFPKNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public decimal NKCADOGNEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x81A4840", Offset = "0x81A2E40", VA = "0x1881A4840")]
		get
		{
			return default(decimal);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public string GKAIPAECDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public COKEEBJCEBE? GEIMJOKJALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "8")]
	public void LGIEIMCMFMG(string? FIGODFNPPLD, string MAHKAFHEJID, string HHILGDFKKBA, float DPENBEMKJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "9")]
	public void FOALCAEMKAE(Func<BADIKMHNEFC.AIBAOICHDFP, BADIKMHNEFC.AIBAOICHDFP> JCBCBBGHBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "10")]
	public void MIEPFEADKHO(string? FIGODFNPPLD, ErrorEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "11")]
	public void OFAEEIPFNON(string? FIGODFNPPLD, decimal FEEOAMBCAFN, string HHPFOCCGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "12")]
	public void DFGNDMEOKPP(string? FIGODFNPPLD, ConversationItemDTO KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "15")]
	public void KLNHBNHGPEA(string? FIGODFNPPLD, ResponseEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "13")]
	public void MBNGMDIIBAA(string? FIGODFNPPLD, ResponseEventDTO OHAAGLFJMJP, float? DCEJLAANKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "14")]
	public void JNPCPAICOFF(Func<BADIKMHNEFC.AIBAOICHDFP, BADIKMHNEFC.AIBAOICHDFP> JCBCBBGHBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "16")]
	public void MGIEEPKHHAF(string? FIGODFNPPLD, string DAAMNHJEIGF, string? DIAEKDIDAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x81A48A0", Offset = "0x81A2EA0", VA = "0x1881A48A0")]
	public NCIJDHCNOFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class ODAMOBFGHPP : DHPPDBLLJNN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct OMPBFCACNOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IHNBIIBBKOO recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ODAMOBFGHPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Guid spendSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private TaskAwaiter<KBCLCEENLJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x81A54A0", Offset = "0x81A3AA0", VA = "0x1881A54A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x81A5820", Offset = "0x81A3E20", VA = "0x1881A5820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly string JEKBLOFFBDD;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x81A5420", Offset = "0x81A3A20", VA = "0x1881A5420")]
	public ODAMOBFGHPP(IHNBIIBBKOO EHOACMCPAPE, string PELNHKIBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x81A52C0", Offset = "0x81A38C0", VA = "0x1881A52C0", Slot = "6")]
	[AsyncStateMachine(typeof(OMPBFCACNOL))]
	protected override Task<bool> TrySyncLatestCostInfo(IHNBIIBBKOO EHOACMCPAPE, Guid ILECBMFGBIG, long PANGCFBNCCJ, long MECJEAAIDNJ, CancellationToken MEKNAIONNND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CONFHPFDGMA
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	GJIKMKGBNOL<ConversationItemDTO> JFNCNNHMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IReadOnlyList<ConversationItemDTO> HADFGDHBNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<string> FNNBDPGBEMK(ConversationItemDTO KGKOGFAMIIC);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GPJCJPFEDJO(string JPJJPKECGCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NAKKNAIMJHI
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IFJEKGDIOLK(IReadOnlyCollection<string> HMMAKKOEFJJ, CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AGODCOENHLD
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ToolDTO[] KLIODEAONFJ();

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> HJKBBLACCLK(string BKCBMFPHNNL, string OPKDNGCKLCC, CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LIHBENLCCLN
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface COKEEBJCEBE
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	const string BPJHNOKJCGE = "gpt-4o-mini-realtime-preview-2024-12-17";

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	const string KHDHIPPNBKO = "gpt-4o-mini-transcribe";

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PPNKCOHODEC HBCCHCOEODI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	AudioSource OFGDBLGCHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	CONFHPFDGMA? FGEPDBNCPOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NAKKNAIMJHI? CKJGEMPHMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string? EDCLJBEHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BCBMMKDMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IMILCHDPMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool PLNDGNAFKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool MEJHHDKJPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool PLLMBJLHGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool OEKAHAMAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool IBIDAJJHOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool CCOFAAMKLOE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool KODPAMALLHE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool BBBGBFBEMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MCFJOOGCLCD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool NBJKAIADDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	GJIKMKGBNOL<bool> EDEDPCNOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HBPNKKOKOOA GIPONDBDGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HBPNKKOKOOA HLBEIOCDNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NCECCJAFPPJ<string, string> NLOPJGNEPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HBPNKKOKOOA NMEJJKLDJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	HBPNKKOKOOA AFPMMLBOLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	GJIKMKGBNOL<List<ToolDTO>> FFDFCPNCICE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	HBPNKKOKOOA OJFNOCMAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NCECCJAFPPJ<float, string> BNGBCIMKDAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GJIKMKGBNOL<string> OIHLBJOJJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string GKAIPAECDBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool LEOKNHDAPOM
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
	Task AFPBJEJDAOH(string HMBNKJCIOJO, VoiceOption AOJPPGLDHNI, float DPENBEMKJHB = 0.6f, string GKEOKLIBBNE = "gpt-4o-mini-realtime-preview-2024-12-17", string HHILGDFKKBA = "gpt-4o-mini-transcribe", [Optional] IReadOnlyCollection<string>? CHOMKADEKIG, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PHBPELHDHLN();

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task JAHLFDDAFBE(string HMBNKJCIOJO, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task OFAANMEBCNK(float DPENBEMKJHB, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task AOHGGKMAADA(bool ANBCINBEIHB, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void ADCLKGMKLAN(params LIHBENLCCLN[] ODAILKGHDLN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool AKMIPIBNHMF(LIHBENLCCLN KNGBIJFKMHM);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void IGCLDCOMPIL(params LIHBENLCCLN[] ODAILKGHDLN);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void COKPLKOIANE(GMFFHJDCBPL HNGIMMGBLII, bool ECFOPPGFILG = false);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void HNFMOMLKLKF(GMFFHJDCBPL HNGIMMGBLII, bool ECFOPPGFILG = false);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void GFCAFNAMKMF(GMFFHJDCBPL HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JIHOHOAOIFI(GMFFHJDCBPL HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void JMDGHHFDOON(decimal FEEOAMBCAFN, string HHPFOCCGJIF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task DPICKJBCIKP(byte[] OEJMGGODIMF, string? LDPNAGGNGBG, [Optional] string? GLCCBEMDJKD, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task DPICKJBCIKP(string IFEHDCDCFPK, [Optional] string? GLCCBEMDJKD, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task KOKHJFBOOAC(string IFEHDCDCFPK, [Optional] string? GLCCBEMDJKD, [Optional] string? AODCNPOKEFK, bool OAEJMAGEFPP = false, bool DNAPBBIGNGL = false, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task GPJCJPFEDJO(string GLCCBEMDJKD, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<ResponseDTO> HGLPOFJPIFE(bool JKOBIMGEMCL = true, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<string> KPGICAILNNH(string HMBNKJCIOJO, [Optional] IReadOnlyList<ConversationItemDTO>? HMMAKKOEFJJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<TOutput> KPGICAILNNH<TOutput>(string HMBNKJCIOJO, [Optional] IReadOnlyList<ConversationItemDTO>? HMMAKKOEFJJ, [Optional] CancellationToken MEKNAIONNND) where TOutput : class;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task<List<JEHNFBNLDAL>> KPGICAILNNH(string HMBNKJCIOJO, IReadOnlyList<ConversationItemDTO>? HMMAKKOEFJJ, IReadOnlyList<BALIHLOENGM> KDFLONNLPLC, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool CAJOMIHJOIL(string JPJJPKECGCJ);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool BHBADFHJMLH(string JPJJPKECGCJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool EODBEAKHLBD(string JCBOAFMJALG);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task FNPFDFMBCGO(bool LBCDFHCDOHA, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "55")]
	IReadOnlyCollection<string> BBDMPLKIPBH();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LNHIONJEEEO
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LGOOIFEAAND? GJKKPFPKNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string GKAIPAECDBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGIEIMCMFMG(string? FIGODFNPPLD, string MAHKAFHEJID, string HHILGDFKKBA, float DPENBEMKJHB);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FOALCAEMKAE(Func<BADIKMHNEFC.AIBAOICHDFP, BADIKMHNEFC.AIBAOICHDFP> JCBCBBGHBNL);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MIEPFEADKHO(string? FIGODFNPPLD, ErrorEventDTO OHAAGLFJMJP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OFAEEIPFNON(string? FIGODFNPPLD, decimal FEEOAMBCAFN, string HHPFOCCGJIF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DFGNDMEOKPP(string? FIGODFNPPLD, ConversationItemDTO KGKOGFAMIIC);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MBNGMDIIBAA(string? FIGODFNPPLD, ResponseEventDTO OHAAGLFJMJP, float? DCEJLAANKKA);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JNPCPAICOFF(Func<BADIKMHNEFC.AIBAOICHDFP, BADIKMHNEFC.AIBAOICHDFP> JCBCBBGHBNL);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KLNHBNHGPEA(string? FIGODFNPPLD, ResponseEventDTO OHAAGLFJMJP);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MGIEEPKHHAF(string? FIGODFNPPLD, string DAAMNHJEIGF, string? DIAEKDIDAKG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GOLNPCJBJJF
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void KEDEAOCDDJH(ReadOnlySpan<float> OLGJNFNONNO, int FPJPLDGHLOG, int LGGEJMJANBC);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHHDFKCBHHK(KEDEAOCDDJH APJDOJOFNPK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBOHBLANCBJ(KEDEAOCDDJH APJDOJOFNPK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface LDIGLDIFLFE
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCMFNMOOPGK(decimal KNFJBPOKNOM);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class JKJCELNHLOP
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private enum DGLPLKHHBHP
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		array,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		boolean,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		@enum,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		integer,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		number,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		@object,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		@string
	}

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static ConcurrentDictionary<Type, JsonSchema> ALMMKDKKINI;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly Type[] LGHLBNFJJJN;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly Type[] IHLJFLFCGAA;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E396E0", Offset = "0x3E37CE0", VA = "0x183E396E0")]
	public static JsonSchema JLOHDPKHFGN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x81A1870", Offset = "0x819FE70", VA = "0x1881A1870")]
	public static JsonSchema OPNHENJHLKC(IReadOnlyList<BALIHLOENGM> KGIPMLMDBBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x81A1610", Offset = "0x819FC10", VA = "0x1881A1610")]
	public static LGKOKOJLAFP MLHANOIGDGN(string DJFMCHMDHGK, string? OINDFPIKPLL, JsonSchema COFBELOEJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3E398A0", Offset = "0x3E37EA0", VA = "0x183E398A0")]
	public static LGKOKOJLAFP MLHANOIGDGN<T>(string DJFMCHMDHGK, string? OINDFPIKPLL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x81A1720", Offset = "0x819FD20", VA = "0x1881A1720")]
	public static LGKOKOJLAFP MLHANOIGDGN(string DJFMCHMDHGK, string? OINDFPIKPLL, IReadOnlyList<BALIHLOENGM> KGIPMLMDBBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x81A11C0", Offset = "0x819F7C0", VA = "0x1881A11C0")]
	private static JsonSchema LEGKEFDEGCA(Type EHLAHNIAPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x81A07C0", Offset = "0x819EDC0", VA = "0x1881A07C0")]
	private static JsonSchema BBDIAGCIELO(Type EHLAHNIAPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x81A0D50", Offset = "0x819F350", VA = "0x1881A0D50")]
	private static DGLPLKHHBHP FHPLKECFLAA(Type EHLAHNIAPLD, [Out] Type? HPGOBCAACJM)
	{
		return default(DGLPLKHHBHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x81A0F50", Offset = "0x819F550", VA = "0x1881A0F50")]
	private static bool HALHKHIIDBG(Type EHLAHNIAPLD, [Out][MaybeNullWhen(false)] Type MCCNLLIKKME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ELFGLDFFNBF : LIHBENLCCLN, AGODCOENHLD
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<string> PBCEBMILPHO(List<JEHNFBNLDAL> ILLMINLDJKA);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate string ENFGDBAOBOA(List<JEHNFBNLDAL> ILLMINLDJKA);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CKBEEJCBHOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public ENFGDBAOBOA handler;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public CKBEEJCBHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x818E7E0", Offset = "0x818CDE0", VA = "0x18818E7E0")]
		internal Task<string> KHGBLAEHIPK(List<JEHNFBNLDAL> invokedArgs)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct DMHMPAPAFKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public string methodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public ELFGLDFFNBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string methodArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x818F0C0", Offset = "0x818D6C0", VA = "0x18818F0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x818F770", Offset = "0x818DD70", VA = "0x18818F770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly string KHEFOKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly string NKMHJDMBLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IReadOnlyList<BALIHLOENGM> JPGHMELANKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly PBCEBMILPHO NCOJDDPIHKE;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1101990", Offset = "0x10FFF90", VA = "0x181101990")]
	public ELFGLDFFNBF(string DJFMCHMDHGK, string OINDFPIKPLL, IReadOnlyList<BALIHLOENGM> KGIPMLMDBBA, PBCEBMILPHO CACEFGPINFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x818FD20", Offset = "0x818E320", VA = "0x18818FD20")]
	public ELFGLDFFNBF(string DJFMCHMDHGK, string OINDFPIKPLL, IReadOnlyList<BALIHLOENGM> KGIPMLMDBBA, ENFGDBAOBOA CACEFGPINFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x818FB90", Offset = "0x818E190", VA = "0x18818FB90", Slot = "4")]
	private ToolDTO[] MCKOMJPNFDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x818FA50", Offset = "0x818E050", VA = "0x18818FA50", Slot = "5")]
	[AsyncStateMachine(typeof(DMHMPAPAFKO))]
	private Task<string> HFJPNFKOOPC(string BKCBMFPHNNL, string OPKDNGCKLCC, CancellationToken MEKNAIONNND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class DIKJLBPEDPA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
	public DIKJLBPEDPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LHPLCCDCFCL : Exception, EPFGFFJPCFI
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string EJMJAJBGGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5C9EC60", Offset = "0x5C9D260", VA = "0x185C9EC60", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x81A2C00", Offset = "0x81A1200", VA = "0x1881A2C00")]
	public LHPLCCDCFCL(string CLEKLKOAAFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class HBEFIPCMPLM : COKEEBJCEBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private enum FCGNNIAELFO
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		NotConnected,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Connected
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct IOFNFGLLPBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int? reconnectAttempt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private CancellationTokenSource <cts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private CancellationToken <originalCancellationToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private IDisposable <combinedTokenDisposer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private string <instructions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private float <temperature>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<PPNKCOHODEC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<bool> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x819CCD0", Offset = "0x819B2D0", VA = "0x18819CCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x819F0D0", Offset = "0x819D6D0", VA = "0x18819F0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct OONBFOIHDIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public bool keepConversationHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x81A5890", Offset = "0x81A3E90", VA = "0x1881A5890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x81A5AA0", Offset = "0x81A40A0", VA = "0x1881A5AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct EMONJCFCCHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x818FF10", Offset = "0x818E510", VA = "0x18818FF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8190140", Offset = "0x818E740", VA = "0x188190140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct AGKFNANOCLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public float temperature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x818B6B0", Offset = "0x8189CB0", VA = "0x18818B6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x818B8C0", Offset = "0x8189EC0", VA = "0x18818B8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct EJCMKJEBNNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x818F7E0", Offset = "0x818DDE0", VA = "0x18818F7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x818F9F0", Offset = "0x818DFF0", VA = "0x18818F9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct NGGMEEHGPGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x81A4900", Offset = "0x81A2F00", VA = "0x1881A4900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x81A4C00", Offset = "0x81A3200", VA = "0x1881A4C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct GENEHDGBPPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public byte[] pcmAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string transcript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x81955F0", Offset = "0x8193BF0", VA = "0x1881955F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8195A70", Offset = "0x8194070", VA = "0x188195A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct NKIOJCKFNBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x81A4C60", Offset = "0x81A3260", VA = "0x1881A4C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x81A50D0", Offset = "0x81A36D0", VA = "0x1881A50D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct MJDEKEDALKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public bool suppressFromConversationLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool excludeFromConversationPruning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public string previousItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x81A39A0", Offset = "0x81A1FA0", VA = "0x1881A39A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x81A3EF0", Offset = "0x81A24F0", VA = "0x1881A3EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KNPJAGNMHMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public string convresationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x81A2670", Offset = "0x81A0C70", VA = "0x1881A2670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x81A2BA0", Offset = "0x81A11A0", VA = "0x1881A2BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class JIFKHFDAOLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public ResponseDTO response;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public JIFKHFDAOLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x81A0790", Offset = "0x819ED90", VA = "0x1881A0790")]
		internal bool PCBILMNGNIB(OutputAudioBufferEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct IBJLMGBIJDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private JIFKHFDAOLO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool waitForAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter<OutputAudioBufferEventDTO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x819C410", Offset = "0x819AA10", VA = "0x18819C410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x819CC60", Offset = "0x819B260", VA = "0x18819CC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct BLIBFCCIDHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x818DC40", Offset = "0x818C240", VA = "0x18818DC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x818E1F0", Offset = "0x818C7F0", VA = "0x18818E1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct PLENOEBBCIL<TOutput> : IAsyncStateMachine where TOutput : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AsyncTaskMethodBuilder<TOutput> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5C80410", Offset = "0x5C7EA10", VA = "0x185C80410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5C80C70", Offset = "0x5C7F270", VA = "0x185C80C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct BKMPKAAEPMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder<List<JEHNFBNLDAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public IReadOnlyList<BALIHLOENGM> responseArgSchemas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x818D500", Offset = "0x818BB00", VA = "0x18818D500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x818DBD0", Offset = "0x818C1D0", VA = "0x18818DBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class JDMHFIOMMJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public ResponseCreateEventDTO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public string id;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public JDMHFIOMMJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x819F820", Offset = "0x819DE20", VA = "0x18819F820")]
		internal void JFDCBOFIHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x819F920", Offset = "0x819DF20", VA = "0x18819F920")]
		internal bool MMBIDGMKKDO(ResponseEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct NBMPNDFJAAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder<List<ConversationItemDTO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public JsonSchema responseSchema;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private TaskAwaiter<ResponseEventDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x81A3F50", Offset = "0x81A2550", VA = "0x1881A3F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x81A47D0", Offset = "0x81A2DD0", VA = "0x1881A47D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct FPBGLDBMMBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public DateTime expirationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8195000", Offset = "0x8193600", VA = "0x188195000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x81953F0", Offset = "0x81939F0", VA = "0x1881953F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct HPMBBNIMFJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private List<ToolDTO> <tools>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x819BBC0", Offset = "0x819A1C0", VA = "0x18819BBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x819BFF0", Offset = "0x819A5F0", VA = "0x18819BFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct GHCFAHEKHFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public ResponseEventDTO ev;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private string <responseId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8195AD0", Offset = "0x81940D0", VA = "0x188195AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAE2D00", Offset = "0xAE1300", VA = "0x180AE2D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class JCGHLFLELEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public JCGHLFLELEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x819F130", Offset = "0x819D730", VA = "0x18819F130")]
		internal Task HEKBCBHLBIB(ConversationItemDTO outputItem)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct FCBGGKLNPLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public ResponseDTO response;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private JCGHLFLELEJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8192330", Offset = "0x8190930", VA = "0x188192330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8192AF0", Offset = "0x81910F0", VA = "0x188192AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct DACJEIBGPBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x818E870", Offset = "0x818CE70", VA = "0x18818E870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x818EB10", Offset = "0x818D110", VA = "0x18818EB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct JMNAMDJBEKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x81A21A0", Offset = "0x81A07A0", VA = "0x1881A21A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x81A2500", Offset = "0x81A0B00", VA = "0x1881A2500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct EPEFHCBCDBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public HBEFIPCMPLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CancellationToken <cancellationToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private DateTime? <startTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private TaskAwaiter<ResponseDTO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x81901A0", Offset = "0x818E7A0", VA = "0x1881901A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8190CD0", Offset = "0x818F2D0", VA = "0x188190CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly IDGHEFJHGEI AOPICECIPOD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private const ToolChoice HJANADIKHGH = ToolChoice.Auto;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const float JFNDGLDJICH = 0.01f;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly TimeSpan[] JGDGDCHDMML;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly TimeSpan AJNJAJHJPME;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly TimeSpan EJMKEBFLIAN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly TimeSpan BPDKLCACLMD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly TimeSpan NABKMKDALHB;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly TimeSpan IPBIIEGJECI;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly TimeSpan KHNNKOKNKPO;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private const string OPNNCJGOKBJ = "out-of-band-id";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly AJJCOIFOHNI GDMJHOAEHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly GOLNPCJBJJF LDIEMPJEHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	protected readonly IHNBIIBBKOO MENJCMODBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JEEONMGODIH IIPGGKHGKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly DJODPCGDIDE CPADFHPNCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly DJODPCGDIDE OHFLLLAFOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<string, DateTime> MEGFCIEOPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Lazy<LNHIONJEEEO> FADCIIBBIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly DBIKPMOKGJK? FIOJMOMIINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private string JHHBJIKLGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private VoiceOption MLNHIHEFEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private float DAFEGLOMNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private string LNHHIPAEMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private string DBMNEFKNEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private FCGNNIAELFO OFMIFKJHGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private CancellationTokenSource? MJKCKPMHGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected PPNKCOHODEC? HIBOGKJEALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private AudioSource GOLMKHCFCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private AudioSourceSimpleLevelMeter? JGGILFJMFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private FBBOMEBPEDG? GLFOFGNMANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private BAKEABKLBIC? NPCIDDFKFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private BHDCBOIHNHE? BCDGFBOEBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private ECFJLGILFEB? JEAOCEJAOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private IReadOnlyCollection<string> BHKKEPIEABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private DateTime? MIMGADEKGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Task<ResponseDTO>? KONNDEPJACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private uint HCBLAMJCBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly HashSet<string> NBHEMKBMGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly HashSet<string> OBLNBBJBHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly HashSet<string> DJGDLHOAAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool LGDJHCLDHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private GMFFHJDCBPL? JNCDPPJMIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool DANKELHDLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private CancellationTokenSource? NFLNKOBPANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private string? HNGAOGBILNM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public PPNKCOHODEC HBCCHCOEODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8199470", Offset = "0x8197A70", VA = "0x188199470", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string? EDCLJBEHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x81976B0", Offset = "0x8195CB0", VA = "0x1881976B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public abstract bool BCBMMKDMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public abstract bool IMILCHDPMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract bool PLNDGNAFKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	protected abstract bool HOKKAIABMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected abstract string? PLFCDGNDFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected abstract string DJNEDABMNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected abstract int IGEGDCOOIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	protected abstract int HKFJFJMAEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	protected abstract IDDJCNJCDOH MPPMOHMGGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	protected abstract string CJBLAFLFODK
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	protected virtual bool PNEIBOLNGEC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool MEJHHDKJPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x81974A0", Offset = "0x8195AA0", VA = "0x1881974A0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool PLLMBJLHGDB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8197320", Offset = "0x8195920", VA = "0x188197320", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool OEKAHAMAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x81993E0", Offset = "0x81979E0", VA = "0x1881993E0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool IBIDAJJHOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xC01300", Offset = "0xBFF900", VA = "0x180C01300", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xC0BED0", Offset = "0xC0A4D0", VA = "0x180C0BED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool CCOFAAMKLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8198660", Offset = "0x8196C60", VA = "0x188198660", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool KODPAMALLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x81987F0", Offset = "0x8196DF0", VA = "0x1881987F0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool BBBGBFBEMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x28A2760", Offset = "0x28A0D60", VA = "0x1828A2760", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool MCFJOOGCLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8197FD0", Offset = "0x81965D0", VA = "0x188197FD0", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool NBJKAIADDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8197480", Offset = "0x8195A80", VA = "0x188197480", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private bool JKDCLNNCNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8196BF0", Offset = "0x81951F0", VA = "0x188196BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private bool ABAIOFOLKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8198520", Offset = "0x8196B20", VA = "0x188198520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private bool LBBIOKGJDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8197660", Offset = "0x8195C60", VA = "0x188197660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool LEOKNHDAPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x26CABE0", Offset = "0x26C91E0", VA = "0x1826CABE0", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x81963A0", Offset = "0x81949A0", VA = "0x1881963A0", Slot = "58")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private uint PLEGIPFPFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xB56FA0", Offset = "0xB555A0", VA = "0x180B56FA0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8197390", Offset = "0x8195990", VA = "0x188197390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public AudioSource OFGDBLGCHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xB19E20", Offset = "0xB18420", VA = "0x180B19E20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public CONFHPFDGMA? FGEPDBNCPOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xB65DA0", Offset = "0xB643A0", VA = "0x180B65DA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public NAKKNAIMJHI? CKJGEMPHMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA9F180", Offset = "0xA9D780", VA = "0x180A9F180", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string GKAIPAECDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8196890", Offset = "0x8194E90", VA = "0x188196890")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8198570", Offset = "0x8196B70", VA = "0x188198570", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected virtual string? KAKIOBOIHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xB8A8A0", Offset = "0xB88EA0", VA = "0x180B8A8A0", Slot = "73")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected virtual IDGHEFJHGEI? ADNIIDAJGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "74")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual IDGHEFJHGEI? IMBCMAJKCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "75")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public GJIKMKGBNOL<bool> EDEDPCNOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xC053D0", Offset = "0xC039D0", VA = "0x180C053D0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public HBPNKKOKOOA GIPONDBDGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xC04210", Offset = "0xC02810", VA = "0x180C04210", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public HBPNKKOKOOA HLBEIOCDNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xC0ECE0", Offset = "0xC0D2E0", VA = "0x180C0ECE0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public NCECCJAFPPJ<string, string> NLOPJGNEPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xC1EDB0", Offset = "0xC1D3B0", VA = "0x180C1EDB0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public GJIKMKGBNOL<List<ToolDTO>> FFDFCPNCICE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xC0CC70", Offset = "0xC0B270", VA = "0x180C0CC70", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public HBPNKKOKOOA NMEJJKLDJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xC0F9A0", Offset = "0xC0DFA0", VA = "0x180C0F9A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public HBPNKKOKOOA AFPMMLBOLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xC05B10", Offset = "0xC04110", VA = "0x180C05B10", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public HBPNKKOKOOA OJFNOCMAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xC1EF60", Offset = "0xC1D560", VA = "0x180C1EF60", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public NCECCJAFPPJ<float, string> BNGBCIMKDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xC045E0", Offset = "0xC02BE0", VA = "0x180C045E0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public GJIKMKGBNOL<string> OIHLBJOJJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xC04000", Offset = "0xC02600", VA = "0x180C04000", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x819ADF0", Offset = "0x81993F0", VA = "0x18819ADF0")]
	public HBEFIPCMPLM(AJJCOIFOHNI DBDHMBLGBLE, GOLNPCJBJJF MANCLCABOLB, IHNBIIBBKOO EHOACMCPAPE, [Optional] DBIKPMOKGJK? LKNIDMJBFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "61")]
	protected abstract LNHIONJEEEO CreateDataReporter();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8199540", Offset = "0x8197B40", VA = "0x188199540")]
	private void MNDHODJFNFF(LIHBENLCCLN OKHELEAHJMF, AGODCOENHLD? CACEFGPINFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x81963B0", Offset = "0x81949B0", VA = "0x1881963B0", Slot = "31")]
	public Task AFPBJEJDAOH(string HMBNKJCIOJO, VoiceOption AOJPPGLDHNI, float DPENBEMKJHB, string GKEOKLIBBNE, string HHILGDFKKBA, [Optional] IReadOnlyCollection<string>? CHOMKADEKIG, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x8198B10", Offset = "0x8197110", VA = "0x188198B10")]
	[AsyncStateMachine(typeof(IOFNFGLLPBN))]
	private Task LIFLCCFGMGM(int? PGFMKKJIEPK, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x8196970", Offset = "0x8194F70", VA = "0x188196970", Slot = "76")]
	protected virtual Task CheckAccess(CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x819AB60", Offset = "0x8199160", VA = "0x18819AB60", Slot = "77")]
	protected virtual Task<bool> UploadTranscriptsForModeration(CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x8199E80", Offset = "0x8198480", VA = "0x188199E80", Slot = "32")]
	public void PHBPELHDHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x81974B0", Offset = "0x8195AB0", VA = "0x1881974B0", Slot = "55")]
	[AsyncStateMachine(typeof(OONBFOIHDIJ))]
	public Task FNPFDFMBCGO(bool LBCDFHCDOHA, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8197100", Offset = "0x8195700", VA = "0x188197100", Slot = "78")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8198020", Offset = "0x8196620", VA = "0x188198020", Slot = "33")]
	[AsyncStateMachine(typeof(EMONJCFCCHG))]
	public Task JAHLFDDAFBE(string HMBNKJCIOJO, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8199C20", Offset = "0x8198220", VA = "0x188199C20", Slot = "34")]
	[AsyncStateMachine(typeof(AGKFNANOCLG))]
	public Task OFAANMEBCNK(float DPENBEMKJHB, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x81998D0", Offset = "0x8197ED0", VA = "0x1881998D0")]
	[AsyncStateMachine(typeof(EJCMKJEBNNO))]
	public Task NEEKCIOBJKA(bool ANBCINBEIHB, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8196560", Offset = "0x8194B60", VA = "0x188196560", Slot = "35")]
	[AsyncStateMachine(typeof(NGGMEEHGPGK))]
	public Task AOHGGKMAADA(bool ANBCINBEIHB, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8196320", Offset = "0x8194920", VA = "0x188196320", Slot = "36")]
	public void ADCLKGMKLAN(params LIHBENLCCLN[] ODAILKGHDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8196450", Offset = "0x8194A50", VA = "0x188196450", Slot = "37")]
	public bool AKMIPIBNHMF(LIHBENLCCLN KNGBIJFKMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8197E40", Offset = "0x8196440", VA = "0x188197E40", Slot = "38")]
	public void IGCLDCOMPIL(params LIHBENLCCLN[] ODAILKGHDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8196900", Offset = "0x8194F00", VA = "0x188196900", Slot = "39")]
	public void COKPLKOIANE(GMFFHJDCBPL HNGIMMGBLII, bool ECFOPPGFILG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8197DD0", Offset = "0x81963D0", VA = "0x188197DD0", Slot = "40")]
	public void HNFMOMLKLKF(GMFFHJDCBPL HNGIMMGBLII, bool ECFOPPGFILG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8197670", Offset = "0x8195C70", VA = "0x188197670", Slot = "41")]
	public void GFCAFNAMKMF(GMFFHJDCBPL HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8198380", Offset = "0x8196980", VA = "0x188198380", Slot = "42")]
	public void JIHOHOAOIFI(GMFFHJDCBPL HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x8196670", Offset = "0x8194C70", VA = "0x188196670", Slot = "59")]
	public IReadOnlyCollection<string> BBDMPLKIPBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x81983C0", Offset = "0x81969C0", VA = "0x1881983C0", Slot = "43")]
	public void JMDGHHFDOON(decimal FEEOAMBCAFN, string HHPFOCCGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x8196E70", Offset = "0x8195470", VA = "0x188196E70", Slot = "44")]
	[AsyncStateMachine(typeof(GENEHDGBPPP))]
	public Task DPICKJBCIKP(byte[] OEJMGGODIMF, string? LDPNAGGNGBG, string? GLCCBEMDJKD, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8196FC0", Offset = "0x81955C0", VA = "0x188196FC0", Slot = "45")]
	[AsyncStateMachine(typeof(NKIOJCKFNBN))]
	public Task DPICKJBCIKP(string IFEHDCDCFPK, string? GLCCBEMDJKD, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x81986A0", Offset = "0x8196CA0", VA = "0x1881986A0", Slot = "46")]
	[AsyncStateMachine(typeof(MJDEKEDALKL))]
	public Task KOKHJFBOOAC(string IFEHDCDCFPK, string? GLCCBEMDJKD, string? AODCNPOKEFK, bool OAEJMAGEFPP, bool DNAPBBIGNGL, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8197700", Offset = "0x8195D00", VA = "0x188197700", Slot = "47")]
	[AsyncStateMachine(typeof(KNPJAGNMHMA))]
	public Task GPJCJPFEDJO(string JHPJEIHINNB, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x81967D0", Offset = "0x8194DD0", VA = "0x1881967D0", Slot = "52")]
	public bool CAJOMIHJOIL(string JPJJPKECGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8196770", Offset = "0x8194D70", VA = "0x188196770", Slot = "53")]
	public bool BHBADFHJMLH(string JPJJPKECGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8197400", Offset = "0x8195A00", VA = "0x188197400", Slot = "54")]
	public bool EODBEAKHLBD(string JCBOAFMJALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8197A70", Offset = "0x8196070", VA = "0x188197A70", Slot = "48")]
	[AsyncStateMachine(typeof(IBJLMGBIJDN))]
	public Task<ResponseDTO> HGLPOFJPIFE(bool JKOBIMGEMCL = true, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8198840", Offset = "0x8196E40", VA = "0x188198840", Slot = "49")]
	[AsyncStateMachine(typeof(BLIBFCCIDHP))]
	public Task<string> KPGICAILNNH(string HMBNKJCIOJO, [Optional] IReadOnlyList<ConversationItemDTO>? HMMAKKOEFJJ, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5A40", Offset = "0x3DB4040", VA = "0x183DB5A40", Slot = "50")]
	[AsyncStateMachine(typeof(PLENOEBBCIL<>))]
	public Task<TOutput> KPGICAILNNH<TOutput>(string HMBNKJCIOJO, [Optional] IReadOnlyList<ConversationItemDTO>? HMMAKKOEFJJ, [Optional] CancellationToken MEKNAIONNND) where TOutput : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x81989A0", Offset = "0x8196FA0", VA = "0x1881989A0", Slot = "51")]
	[AsyncStateMachine(typeof(BKMPKAAEPMK))]
	public Task<List<JEHNFBNLDAL>> KPGICAILNNH(string HMBNKJCIOJO, IReadOnlyList<ConversationItemDTO>? HMMAKKOEFJJ, IReadOnlyList<BALIHLOENGM> KDFLONNLPLC, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8196D00", Offset = "0x8195300", VA = "0x188196D00")]
	[AsyncStateMachine(typeof(NBMPNDFJAAC))]
	private Task<List<ConversationItemDTO>> DLPAFCFNNHG(string HMBNKJCIOJO, IReadOnlyList<ConversationItemDTO>? HMMAKKOEFJJ, JsonSchema? MDNAJINBMNG, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8198130", Offset = "0x8196730", VA = "0x188198130")]
	[AsyncStateMachine(typeof(FPBGLDBMMBK))]
	private Task JFAKGOGMMOO(DateTime HOMGEOOBCEN, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8197820", Offset = "0x8195E20", VA = "0x188197820")]
	private bool HBMEHJAGCIJ(ResponseDTO LEFGFCJGALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x81966D0", Offset = "0x8194CD0", VA = "0x1881966D0")]
	private void BFAINKNKBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x81975C0", Offset = "0x8195BC0", VA = "0x1881975C0")]
	private void GAEGAOMJGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8197230", Offset = "0x8195830", VA = "0x188197230")]
	[AsyncStateMachine(typeof(HPMBBNIMFJM))]
	private Task EHLMBIKNAGL([Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8196470", Offset = "0x8194A70", VA = "0x188196470")]
	private void ANBODKNIAFH(ReadOnlySpan<float> OLGJNFNONNO, int FPJPLDGHLOG, int LGGEJMJANBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x819AAA0", Offset = "0x81990A0", VA = "0x18819AAA0")]
	private void POODBBDBPAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8196A00", Offset = "0x8195000", VA = "0x188196A00")]
	[AsyncStateMachine(typeof(GHCFAHEKHFP))]
	private void DBOBKDIDPFM(ResponseEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8198240", Offset = "0x8196840", VA = "0x188198240")]
	private void JFNCNNHMHLO(ConversationItemDTO KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5960", Offset = "0x3DB3F60", VA = "0x183DB5960")]
	private void GGJPKJMBHLO<T>(T OHAAGLFJMJP) where T : notnull, PBLCPGGAJMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8198C30", Offset = "0x8197230", VA = "0x188198C30")]
	private void LOFIMCPEBPN(ResponseEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x819A930", Offset = "0x8198F30", VA = "0x18819A930")]
	private void PJLBDDHEPHN(string MAHKAFHEJID, string HHILGDFKKBA, float DPENBEMKJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8196AD0", Offset = "0x81950D0", VA = "0x188196AD0")]
	[AsyncStateMachine(typeof(FCBGGKLNPLF))]
	private Task DHHMBAMOBDJ(ResponseDTO LEFGFCJGALC, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8197BB0", Offset = "0x81961B0", VA = "0x188197BB0")]
	[AsyncStateMachine(typeof(DACJEIBGPBM))]
	private Task HJKBBLACCLK(ConversationItemDTO KGKOGFAMIIC, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8197CC0", Offset = "0x81962C0", VA = "0x188197CC0")]
	[AsyncStateMachine(typeof(JMNAMDJBEKD))]
	private Task<ResponseDTO> HKDMDEDGFHJ(CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8197EC0", Offset = "0x81964C0", VA = "0x188197EC0")]
	[AsyncStateMachine(typeof(EPEFHCBCDBK))]
	private Task<ResponseDTO> IMBOHKPNCGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8199A50", Offset = "0x8198050", VA = "0x188199A50")]
	private void ODMNKENPOJB(ErrorEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8199510", Offset = "0x8197B10", VA = "0x188199510")]
	private void MKPJDLKHOGF(InputAudioBufferSpeechStartedEventDTO CGLIDCMIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8199B90", Offset = "0x8198190", VA = "0x188199B90")]
	private void OEKCBPIHEFD(InputAudioBufferSpeechStoppedEventDTO CGLIDCMIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8199D30", Offset = "0x8198330", VA = "0x188199D30")]
	protected void OMKJBCBEGCF(string DAAMNHJEIGF, [Optional] string? DIAEKDIDAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x81999E0", Offset = "0x8197FE0", VA = "0x1881999E0")]
	public static bool OBOMPHIBPBD(ResponseDTO LEFGFCJGALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x81993C0", Offset = "0x81979C0", VA = "0x1881993C0")]
	protected void MDOKMMEPEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8198660", Offset = "0x8196C60", VA = "0x188198660")]
	[CompilerGenerated]
	private bool KJDBPEPIEMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8196830", Offset = "0x8194E30", VA = "0x188196830")]
	[CompilerGenerated]
	private bool CLBMCOPMJDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class CCBODJJDCPF : DHPPDBLLJNN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct HFOAGHEKOCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public IHNBIIBBKOO recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public CCBODJJDCPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public Guid spendSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private TaskAwaiter<KBCLCEENLJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x819B690", Offset = "0x8199C90", VA = "0x18819B690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x819BB50", Offset = "0x819A150", VA = "0x18819BB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly COKEEBJCEBE LGHHGINDEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly string JEKBLOFFBDD;

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x818E6D0", Offset = "0x818CCD0", VA = "0x18818E6D0")]
	public CCBODJJDCPF(COKEEBJCEBE IHMCCPNPALD, IHNBIIBBKOO EHOACMCPAPE, string PELNHKIBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x818E570", Offset = "0x818CB70", VA = "0x18818E570", Slot = "6")]
	[AsyncStateMachine(typeof(HFOAGHEKOCG))]
	protected override Task<bool> TrySyncLatestCostInfo(IHNBIIBBKOO EHOACMCPAPE, Guid ILECBMFGBIG, long PANGCFBNCCJ, long MECJEAAIDNJ, CancellationToken MEKNAIONNND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
public class GOELMKPEAHI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
	public GOELMKPEAHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface NICKLPFDNOH
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ILICKDCFOEF(LIHBENLCCLN KNGBIJFKMHM, [Out] AGODCOENHLD CACEFGPINFP);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class LINEBGLNJCM
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class GEFHDDAJEPC
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public PropertyInfo KFACMEENNKM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Type PMBMBONEGEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x73F77B0", Offset = "0x73F5DB0", VA = "0x1873F77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string FELBAANEDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool IBANJGOAMFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Type? MEJFLDJHCIC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8195450", Offset = "0x8193A50", VA = "0x188195450")]
		public GEFHDDAJEPC(PropertyInfo KHNGHMGPNGK, JsonPropertyAttribute? FCMPAFMNLGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly ConcurrentDictionary<Type, List<GEFHDDAJEPC>> DNAGPGNNLIE;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x81A2C80", Offset = "0x81A1280", VA = "0x1881A2C80")]
	public static List<string> BLNIGNGFBNI(string GIBBEKEOBHA, Type LDPALJODNJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x81A2D70", Offset = "0x81A1370", VA = "0x1881A2D70")]
	private static void LMOMINILLLA(Type EHLAHNIAPLD, JObject HFKHHFNPDIO, List<string> OKPCFJEFHJN, string PDDOHILPIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x81A3390", Offset = "0x81A1990", VA = "0x1881A3390")]
	private static List<GEFHDDAJEPC> LNPGCNPGGBO(Type EHLAHNIAPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x81A36A0", Offset = "0x81A1CA0", VA = "0x1881A36A0")]
	private static bool PNFCCPOAKLB(Type EHLAHNIAPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LINEBGLNJCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class BHDCBOIHNHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class OPKKNKGPIJK
	{
		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string? JKJNNGPNEGH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public int LEDOPHAJMOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public int LELMALAOPBO
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xEDCE80", Offset = "0xEDB480", VA = "0x180EDCE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x81A5B00", Offset = "0x81A4100", VA = "0x1881A5B00")]
		public OPKKNKGPIJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class CDEOGJIIJDG
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public string AFPIOPNCMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public ConversationItemType MONFNOPPPGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			[CompilerGenerated]
			get
			{
				return default(ConversationItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string? NOENFLDLMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string? CLGAHBNBCJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x818E770", Offset = "0x818CD70", VA = "0x18818E770")]
		public CDEOGJIIJDG(ConversationItemDTO KGKOGFAMIIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class NNAAECMOAGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public IEnumerable<string> functionNames;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public NNAAECMOAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x81A5130", Offset = "0x81A3730", VA = "0x1881A5130")]
		internal bool HBEAJJDEEEH(CDEOGJIIJDG c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class MIKJBHBPLHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public CDEOGJIIJDG c;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MIKJBHBPLHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x81A3960", Offset = "0x81A1F60", VA = "0x1881A3960")]
		internal bool CLFBKJKFLPN(string n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class GOIGMGLMEPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public BHDCBOIHNHE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GOIGMGLMEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x81962E0", Offset = "0x81948E0", VA = "0x1881962E0")]
		internal bool OLFLMCOMNML(string n)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8196290", Offset = "0x8194890", VA = "0x188196290")]
		internal bool LPOAIICEMFA(CDEOGJIIJDG c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8196070", Offset = "0x8194670", VA = "0x188196070")]
		internal void LLEEHBHINMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class MAEDCFFEEKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public IEnumerable<string?> callIdsToRemove;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MAEDCFFEEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x81A38F0", Offset = "0x81A1EF0", VA = "0x1881A38F0")]
		internal bool DEBHHJELDGC(CDEOGJIIJDG c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class PJGBOMMMOHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public IEnumerable<string> idsToRemove;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public PJGBOMMMOHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x81A5B20", Offset = "0x81A4120", VA = "0x1881A5B20")]
		internal bool IOCACHPNOAA(CDEOGJIIJDG c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class KIIBKFOLHMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Func<bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public KIIBKFOLHMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x81A2620", Offset = "0x81A0C20", VA = "0x1881A2620")]
		internal bool ILJIAMBBFOA()
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct JCHFFOBCNOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private KIIBKFOLHMC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public BHDCBOIHNHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x819F250", Offset = "0x819D850", VA = "0x18819F250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x819F7C0", Offset = "0x819DDC0", VA = "0x18819F7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly COKEEBJCEBE MEEJEAMJJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly CONFHPFDGMA GLFOFGNMANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly HashSet<string> CCGOIIKAGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly OPKKNKGPIJK NPBMNALNHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly List<CDEOGJIIJDG> BHKKEPIEABI;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static Queue<string> ADGGIJKLOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly CancellationTokenSource BBPPAEMIJNM;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x818CFF0", Offset = "0x818B5F0", VA = "0x18818CFF0")]
	public BHDCBOIHNHE(COKEEBJCEBE ENMKBCDNHDO, CONFHPFDGMA KECNLHGGHPA, OPKKNKGPIJK EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x818C540", Offset = "0x818AB40", VA = "0x18818C540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x818C350", Offset = "0x818A950", VA = "0x18818C350")]
	public void ABLFGJJOAMK(IEnumerable<string> PGEPMKCEBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x818CAB0", Offset = "0x818B0B0", VA = "0x18818CAB0")]
	private void JFNCNNHMHLO(ConversationItemDTO KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x818C620", Offset = "0x818AC20", VA = "0x18818C620")]
	private void FMMAEEDNKKN(IEnumerable<string?> NANELHNELBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x818CE40", Offset = "0x818B440", VA = "0x18818CE40")]
	[AsyncStateMachine(typeof(JCHFFOBCNOI))]
	private Task MGLLCLCJMFH(Queue<string> GPJGBKHIBFO, CancellationToken MEKNAIONNND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class FBBOMEBPEDG : CONFHPFDGMA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal class JNHEBOKAGKA
	{
		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public ConversationItemDTO BNCJGLMKBOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool LKMFDFNFGJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA0590", Offset = "0xA9EB90", VA = "0x180AA0590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x15EB310", Offset = "0x15E9910", VA = "0x1815EB310")]
		public JNHEBOKAGKA(ConversationItemDTO KGKOGFAMIIC, bool NBMOKBJKEOO = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class POFAMFAJIMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public POFAMFAJIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x81ABB70", Offset = "0x81AA170", VA = "0x1881ABB70")]
		internal bool OPDOECHILCN(JNHEBOKAGKA c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x81A7280", Offset = "0x81A5880", VA = "0x1881A7280")]
		internal bool ILEBBPKDOLF(JNHEBOKAGKA c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class FNAPJOIAILD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public FNAPJOIAILD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x81A98B0", Offset = "0x81A7EB0", VA = "0x1881A98B0")]
		internal bool MPOKIGOHLNG(JNHEBOKAGKA c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class OBEMJDLGKAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public OBEMJDLGKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x81A7280", Offset = "0x81A5880", VA = "0x1881A7280")]
		internal bool IFLLANKBMOJ(JNHEBOKAGKA c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class IKAPHAAJEFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public IKAPHAAJEFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x81A9F50", Offset = "0x81A8550", VA = "0x1881A9F50")]
		internal bool OKLIPNAGLPM(JNHEBOKAGKA c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class ENNBMENLDBF : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public ConversationItemDTO <>3__item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public FBBOMEBPEDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private IKAPHAAJEFH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private List<ConversationItemContentDTO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
		[DebuggerHidden]
		public ENNBMENLDBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x81A96B0", Offset = "0x81A7CB0", VA = "0x1881A96B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x81A8D60", Offset = "0x81A7360", VA = "0x1881A8D60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x81A9550", Offset = "0x81A7B50", VA = "0x1881A9550")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x81A9660", Offset = "0x81A7C60", VA = "0x1881A9660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x81A95A0", Offset = "0x81A7BA0", VA = "0x1881A95A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x81A95A0", Offset = "0x81A7BA0", VA = "0x1881A95A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class IJJOAGFIINJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public string messageId;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public IJJOAGFIINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x21E3900", Offset = "0x21E1F00", VA = "0x1821E3900")]
		internal bool INHGPGAIEEA(ConversationItemDTO m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly HBEFIPCMPLM MEEJEAMJJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly PPNKCOHODEC HIBOGKJEALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly GMFFHJDCBPL MCKJBFNOHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly List<JNHEBOKAGKA> DHNMEKNEDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly List<string> BHKKEPIEABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly List<ConversationItemDTO> GJGPFCBEDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private string? DPGCEFDAHGP;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public GJIKMKGBNOL<ConversationItemDTO> JFNCNNHMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public IReadOnlyList<string> FFPINPCFMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public IReadOnlyList<ConversationItemDTO> HADFGDHBNBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x8191E60", Offset = "0x8190460", VA = "0x188191E60")]
	public FBBOMEBPEDG(HBEFIPCMPLM ENMKBCDNHDO, IReadOnlyCollection<string> ENMCPHPFDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x81910F0", Offset = "0x818F6F0", VA = "0x1881910F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8190D40", Offset = "0x818F340", VA = "0x188190D40")]
	public List<string> BBDMPLKIPBH(bool NGDALBEPMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8191400", Offset = "0x818FA00", VA = "0x188191400")]
	private void GMFDHOIBGDF(ConversationItemCreatedEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8191BB0", Offset = "0x81901B0", VA = "0x188191BB0")]
	private void LOFIMCPEBPN(ResponseEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8190F30", Offset = "0x818F530", VA = "0x188190F30")]
	private void CNDJKEGGNID(ConversationItemInputAudioTranscriptionCompletedEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8191970", Offset = "0x818FF70", VA = "0x188191970")]
	private void JGDDBKMLJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8191370", Offset = "0x818F970", VA = "0x188191370", Slot = "6")]
	[IteratorStateMachine(typeof(ENNBMENLDBF))]
	public IEnumerable<string> FNNBDPGBEMK(ConversationItemDTO KGKOGFAMIIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8191890", Offset = "0x818FE90", VA = "0x188191890", Slot = "7")]
	public void GPJCJPFEDJO(string JPJJPKECGCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class BAKEABKLBIC : NAKKNAIMJHI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct OBCKINAMAIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public IReadOnlyCollection<string> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public BAKEABKLBIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x81AB200", Offset = "0x81A9800", VA = "0x1881AB200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x81AB690", Offset = "0x81A9C90", VA = "0x1881AB690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly HBEFIPCMPLM MEEJEAMJJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly string ECNCLNDDCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly int KGKBDMLGOEJ;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x60464F0", Offset = "0x6044AF0", VA = "0x1860464F0")]
	public BAKEABKLBIC(HBEFIPCMPLM ENMKBCDNHDO, string JOABGMAIJKE, int DOAEBHFKBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x81A7160", Offset = "0x81A5760", VA = "0x1881A7160", Slot = "4")]
	[AsyncStateMachine(typeof(OBCKINAMAIG))]
	public Task IFJEKGDIOLK(IReadOnlyCollection<string> HMMAKKOEFJJ, CancellationToken MEKNAIONNND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class IGHIHIIOBAP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public Type PCHEOHHMOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xB19E20", Offset = "0xB18420", VA = "0x180B19E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public string DCABLNBEFCK
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA9D630", Offset = "0xA9BC30", VA = "0x180A9D630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x81A9E80", Offset = "0x81A8480", VA = "0x1881A9E80")]
	public IGHIHIIOBAP(Type NCHDJNEBBFE, string GIBBEKEOBHA, Exception ACENGOJDDLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class JEEONMGODIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct ADBEJBPIIDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public string args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public JEEONMGODIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private Dictionary<LIHBENLCCLN, AGODCOENHLD?>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private TaskAwaiter<string?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x81A63C0", Offset = "0x81A49C0", VA = "0x1881A63C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x81A70F0", Offset = "0x81A56F0", VA = "0x1881A70F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly IDGHEFJHGEI AOPICECIPOD;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly List<NICKLPFDNOH> PGPKCFOGGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly Dictionary<LIHBENLCCLN, AGODCOENHLD?> DLPKAFCACDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly NCECCJAFPPJ<LIHBENLCCLN, AGODCOENHLD?> MNDHODJFNFF;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x81AAC90", Offset = "0x81A9290", VA = "0x1881AAC90")]
	static JEEONMGODIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x81A9FA0", Offset = "0x81A85A0", VA = "0x1881A9FA0")]
	public void ADCLKGMKLAN(params LIHBENLCCLN[] ODAILKGHDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x81AA260", Offset = "0x81A8860", VA = "0x1881AA260")]
	public bool AKMIPIBNHMF(LIHBENLCCLN KNGBIJFKMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x81AA780", Offset = "0x81A8D80", VA = "0x1881AA780")]
	public void IGCLDCOMPIL(params LIHBENLCCLN[] ODAILKGHDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x81AA2C0", Offset = "0x81A88C0", VA = "0x1881AA2C0")]
	public void EFNKEBBODPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x81AA350", Offset = "0x81A8950", VA = "0x1881AA350")]
	[AsyncStateMachine(typeof(ADBEJBPIIDJ))]
	public Task<string> HJKBBLACCLK(string DJFMCHMDHGK, string KGIPMLMDBBA, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x81AAAA0", Offset = "0x81A90A0", VA = "0x1881AAAA0")]
	public List<ToolDTO> PFHILJGPMIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x81AA4B0", Offset = "0x81A8AB0", VA = "0x1881AA4B0")]
	private static AGODCOENHLD HPGPGLHBBIJ(LIHBENLCCLN KNGBIJFKMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x81AAFD0", Offset = "0x81A95D0", VA = "0x1881AAFD0")]
	public JEEONMGODIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class OGFNGFPCGEN
{
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static JsonSerializerSettings EMFECPNCGBL;

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x81AB6F0", Offset = "0x81A9CF0", VA = "0x1881AB6F0")]
	static OGFNGFPCGEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal class ECFJLGILFEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class ICEFJMIFDBI
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public ConversationItemDTO BNCJGLMKBOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool LKMFDFNFGJN
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xAA0590", Offset = "0xA9EB90", VA = "0x180AA0590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x15EB310", Offset = "0x15E9910", VA = "0x1815EB310")]
		public ICEFJMIFDBI(ConversationItemDTO KGKOGFAMIIC, bool NBMOKBJKEOO = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private abstract class GIKCMIOODHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private readonly StringBuilder PEIJCAMFPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private readonly TimeSpan MDJLBMHMHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private DateTime ALCEMOBNENL;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x81A9A80", Offset = "0x81A8080", VA = "0x1881A9A80")]
		public GIKCMIOODHO(TimeSpan JGLJNHKKHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x81A9A30", Offset = "0x81A8030", VA = "0x1881A9A30")]
		public void KANKDJLDELM(string CFMJBHANLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x81A98F0", Offset = "0x81A7EF0", VA = "0x1881A98F0")]
		public void JDFHFKEGAEP(bool MKJGBAFLMBJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void HABFEBLGBAD(string DMGMBCGCHOD);
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class FGNDCGPFAKD : GIKCMIOODHO
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly TimeSpan LAPCEAHANJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private readonly string LJOINKELGHP;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x81A9820", Offset = "0x81A7E20", VA = "0x1881A9820")]
		public FGNDCGPFAKD(string FJDLJPAACPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x81A9740", Offset = "0x81A7D40", VA = "0x1881A9740", Slot = "4")]
		protected override void HABFEBLGBAD(string DMGMBCGCHOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class IADOHIOLHAP : GIKCMIOODHO
	{
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private static readonly TimeSpan LAPCEAHANJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private readonly IHNBIIBBKOO MENJCMODBFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private readonly PPNKCOHODEC HIBOGKJEALE;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x81A9DE0", Offset = "0x81A83E0", VA = "0x1881A9DE0")]
		public IADOHIOLHAP(IHNBIIBBKOO EHOACMCPAPE, PPNKCOHODEC ILKMCMJOLCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x81A9B30", Offset = "0x81A8130", VA = "0x1881A9B30", Slot = "4")]
		protected override void HABFEBLGBAD(string DMGMBCGCHOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class NEKFBBIGADM : GIKCMIOODHO
	{
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private static readonly TimeSpan LAPCEAHANJD;

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x81AB1A0", Offset = "0x81A97A0", VA = "0x1881AB1A0")]
		public NEKFBBIGADM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x81AB0B0", Offset = "0x81A96B0", VA = "0x1881AB0B0", Slot = "4")]
		protected override void HABFEBLGBAD(string DMGMBCGCHOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class LKCHLGGAHGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LKCHLGGAHGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x81A7280", Offset = "0x81A5880", VA = "0x1881A7280")]
		internal bool OPDOECHILCN(ICEFJMIFDBI c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class ODJNFAGGOEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ODJNFAGGOEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x81A98B0", Offset = "0x81A7EB0", VA = "0x1881A98B0")]
		internal bool MPOKIGOHLNG(ICEFJMIFDBI c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class BNKLIMIDHOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public BNKLIMIDHOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x81A7280", Offset = "0x81A5880", VA = "0x1881A7280")]
		internal bool IFLLANKBMOJ(ICEFJMIFDBI c)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct OKBBIAGAEOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public ECFJLGILFEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x81AB930", Offset = "0x81A9F30", VA = "0x1881AB930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x81ABB10", Offset = "0x81AA110", VA = "0x1881ABB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly TimeSpan LAPCEAHANJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly HBEFIPCMPLM MEEJEAMJJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private readonly PPNKCOHODEC HIBOGKJEALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private readonly IHNBIIBBKOO MENJCMODBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly GMFFHJDCBPL MCKJBFNOHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly List<GIKCMIOODHO> KJADKHBENGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly List<ICEFJMIFDBI> DHNMEKNEDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private string? DPGCEFDAHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private CancellationTokenSource? JPCBDMHHHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private Task? GMNMCBCFPFH;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x81A8630", Offset = "0x81A6C30", VA = "0x1881A8630")]
	public ECFJLGILFEB(HBEFIPCMPLM ENMKBCDNHDO, IHNBIIBBKOO EHOACMCPAPE, bool FCOFJELPLKL, bool HBGEFGFAFMF, string? HONELCCGNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x81A7480", Offset = "0x81A5A80", VA = "0x1881A7480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x81A7880", Offset = "0x81A5E80", VA = "0x1881A7880")]
	private void GMFDHOIBGDF(ConversationItemCreatedEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x81A80D0", Offset = "0x81A66D0", VA = "0x1881A80D0")]
	private void LOFIMCPEBPN(ResponseEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x81A72C0", Offset = "0x81A58C0", VA = "0x1881A72C0")]
	private void CNDJKEGGNID(ConversationItemInputAudioTranscriptionCompletedEventDTO OHAAGLFJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x81A84A0", Offset = "0x81A6AA0", VA = "0x1881A84A0")]
	private void PGIEMEOPOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x81A7C90", Offset = "0x81A6290", VA = "0x1881A7C90")]
	private void HAAMBDMMIBE(ConversationItemDTO KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x81A7F20", Offset = "0x81A6520", VA = "0x1881A7F20")]
	private void KANKDJLDELM(string CFMJBHANLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x81A7790", Offset = "0x81A5D90", VA = "0x1881A7790")]
	[AsyncStateMachine(typeof(OKBBIAGAEOA))]
	private Task FFOBKJPJIHK(CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x81A8380", Offset = "0x81A6980", VA = "0x1881A8380")]
	private void OKNEKEIFEMP(bool MKJGBAFLMBJ = false)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class CMLEPANJLDE
{
	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CMLEPANJLDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7603210", Offset = "0x7601810", VA = "0x187603210")]
	public static string LGLCMNMBJJF(byte[] HIJEGMKCLKI, byte[] BBJNPAEMBIM)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
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
