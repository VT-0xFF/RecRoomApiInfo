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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FF2210", Offset = "0x7FF1610", VA = "0x187FF2210")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7FED640", Offset = "0x7FECA40", VA = "0x187FED640", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class FJLMFJILKJD : IDisposable, CPFBCEEAIPJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct INLONDFEDKM : IAsyncStateMachine
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
		public FJLMFJILKJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA7B0", Offset = "0x7FE9BB0", VA = "0x187FEA7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CPNAKBLDFJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public FJLMFJILKJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF8A0", Offset = "0x7FDECA0", VA = "0x187FDF8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7FDFB40", Offset = "0x7FDEF40", VA = "0x187FDFB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected static readonly AKNCNLDICPO GJFBEGANDPI;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly TimeSpan GLJPBIAMNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource NNOBGDPGJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly GBDCMLADEHH IJPBGFIHGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly long HKGMDDCCMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly long DKCFEBLEFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private decimal NBAFBFOPEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Guid IKGLNKBMHDH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public decimal KJGIIPLIHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x125D0D0", Offset = "0x125C4D0", VA = "0x18125D0D0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7EC56F0", Offset = "0x7EC4AF0", VA = "0x187EC56F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0F20", Offset = "0x7FE0320", VA = "0x187FE0F20")]
	public FJLMFJILKJD(GBDCMLADEHH ANCACDKGMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0CF0", Offset = "0x7FE00F0", VA = "0x187FE0CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0B90", Offset = "0x7FDFF90", VA = "0x187FE0B90")]
	[AsyncStateMachine(typeof(INLONDFEDKM))]
	private void DCECCKNHMDJ(CancellationToken GMKBGHHNCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0D60", Offset = "0x7FE0160", VA = "0x187FE0D60")]
	[AsyncStateMachine(typeof(CPNAKBLDFJP))]
	private Task<bool> GKDMEJPDIDO(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task<bool> TrySyncLatestCostInfo(GBDCMLADEHH ANCACDKGMMA, Guid BHNMHEIBCEK, long DCONEHIDLCB, long DAKBFKLMPGD, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0C60", Offset = "0x7FE0060", VA = "0x187FE0C60", Slot = "5")]
	public void DPGIDFJGOMJ(decimal DOEMPECIDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum GBAEGABEPAE
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
public class JMBNJPGKMMA : IEquatable<JMBNJPGKMMA>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected virtual Type EGGNAPINHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC300", Offset = "0x7FEB700", VA = "0x187FEC300", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GBAEGABEPAE GBFFBDIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(GBAEGABEPAE);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool ABHAKDJNIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xC1A7E0", Offset = "0xC19BE0", VA = "0x180C1A7E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xBC1BC0", Offset = "0xBC0FC0", VA = "0x180BC1BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string[]? AGIADOJOFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC510", Offset = "0x7FEB910", VA = "0x187FEC510")]
	public JMBNJPGKMMA(GBAEGABEPAE GBFFBDIJNIN, string GODGCHFEMGD, string GLHAEMONBHL = "", bool ABHAKDJNIMN = false, [Optional] string[]? AGIADOJOFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC400", Offset = "0x7FEB800", VA = "0x187FEC400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC0C0", Offset = "0x7FEB4C0", VA = "0x187FEC0C0", Slot = "6")]
	protected virtual bool LAHPDPPCCNN(StringBuilder IDAMHGBLFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1244400", Offset = "0x1243800", VA = "0x181244400")]
	public static bool AMDBHCBNEEF(JMBNJPGKMMA? DOGEBCJNCBM, JMBNJPGKMMA? CADKJEGELGB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1244770", Offset = "0x1243B70", VA = "0x181244770")]
	public static bool ILMCFLMCOJH(JMBNJPGKMMA? DOGEBCJNCBM, JMBNJPGKMMA? CADKJEGELGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBEC0", Offset = "0x7FEB2C0", VA = "0x187FEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBE30", Offset = "0x7FEB230", VA = "0x187FEBE30", Slot = "0")]
	public override bool Equals(object? DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBC20", Offset = "0x7FEB020", VA = "0x187FEBC20", Slot = "7")]
	public virtual bool Equals(JMBNJPGKMMA? LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC360", Offset = "0x7FEB760", VA = "0x187FEC360", Slot = "8")]
	public virtual JMBNJPGKMMA OPEMMHFGBGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC580", Offset = "0x7FEB980", VA = "0x187FEC580")]
	protected JMBNJPGKMMA(JMBNJPGKMMA NGLOBNNAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBBC0", Offset = "0x7FEAFC0", VA = "0x187FEBBC0")]
	public void BBBPACNHLNO([Out] GBAEGABEPAE GBFFBDIJNIN, [Out] string GODGCHFEMGD, [Out] string GLHAEMONBHL, [Out] bool ABHAKDJNIMN, [Out] string[]? AGIADOJOFHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JBEOLGHLMMP : IEquatable<JBEOLGHLMMP>
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	protected virtual Type EGGNAPINHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7FEB700", Offset = "0x7FEAB00", VA = "0x187FEB700", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JToken CKBDJOFGFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JMBNJPGKMMA LJMCCEPHFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x123AA90", Offset = "0x1239E90", VA = "0x18123AA90")]
	public JBEOLGHLMMP(JToken CKBDJOFGFBF, JMBNJPGKMMA LJMCCEPHFCE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB360", Offset = "0x7FEA760", VA = "0x187FEB360")]
	public static int LDIHJJHLCIM(JBEOLGHLMMP CBMEHPPMEEA)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB530", Offset = "0x7FEA930", VA = "0x187FEB530")]
	public static float LDIHJJHLCIM(JBEOLGHLMMP CBMEHPPMEEA)
	{
		return default(float);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB0A0", Offset = "0x7FEA4A0", VA = "0x187FEB0A0")]
	public static bool LDIHJJHLCIM(JBEOLGHLMMP CBMEHPPMEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB160", Offset = "0x7FEA560", VA = "0x187FEB160")]
	public static string LDIHJJHLCIM(JBEOLGHLMMP CBMEHPPMEEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB420", Offset = "0x7FEA820", VA = "0x187FEB420")]
	public static int[] LDIHJJHLCIM(JBEOLGHLMMP CBMEHPPMEEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB5F0", Offset = "0x7FEA9F0", VA = "0x187FEB5F0")]
	public static float[] LDIHJJHLCIM(JBEOLGHLMMP CBMEHPPMEEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAF90", Offset = "0x7FEA390", VA = "0x187FEAF90")]
	public static bool[] LDIHJJHLCIM(JBEOLGHLMMP CBMEHPPMEEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB250", Offset = "0x7FEA650", VA = "0x187FEB250")]
	public static string[] LDIHJJHLCIM(JBEOLGHLMMP CBMEHPPMEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB7F0", Offset = "0x7FEABF0", VA = "0x187FEB7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAEA0", Offset = "0x7FEA2A0", VA = "0x187FEAEA0", Slot = "6")]
	protected virtual bool LAHPDPPCCNN(StringBuilder IDAMHGBLFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1244400", Offset = "0x1243800", VA = "0x181244400")]
	public static bool AMDBHCBNEEF(JBEOLGHLMMP? DOGEBCJNCBM, JBEOLGHLMMP? CADKJEGELGB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1244770", Offset = "0x1243B70", VA = "0x181244770")]
	public static bool ILMCFLMCOJH(JBEOLGHLMMP? DOGEBCJNCBM, JBEOLGHLMMP? CADKJEGELGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAD80", Offset = "0x7FEA180", VA = "0x187FEAD80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7FEACF0", Offset = "0x7FEA0F0", VA = "0x187FEACF0", Slot = "0")]
	public override bool Equals(object? DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7FEABB0", Offset = "0x7FE9FB0", VA = "0x187FEABB0", Slot = "7")]
	public virtual bool Equals(JBEOLGHLMMP? LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB760", Offset = "0x7FEAB60", VA = "0x187FEB760", Slot = "8")]
	public virtual JBEOLGHLMMP OPEMMHFGBGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB900", Offset = "0x7FEAD00", VA = "0x187FEB900")]
	protected JBEOLGHLMMP(JBEOLGHLMMP NGLOBNNAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAB70", Offset = "0x7FE9F70", VA = "0x187FEAB70")]
	public void BBBPACNHLNO([Out] JToken CKBDJOFGFBF, [Out] JMBNJPGKMMA LJMCCEPHFCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class CNCMDLJBADN : GGFIFLPDFLA
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string ECCPGEGBFMH = "Open AI Realtime API";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string PNGKMKIMHKM = "endpoint";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly string LBOCEDJOBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly List<Func<LLMHKJOOLCM.EMNPPGLFKHI, LLMHKJOOLCM.EMNPPGLFKHI>> DGELGPGJFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<Func<LLMHKJOOLCM.EMNPPGLFKHI, LLMHKJOOLCM.EMNPPGLFKHI>> KCGAKNGKFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly OCGCKBCELPI BGIDPGLCAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly CPFBCEEAIPJ HJLEOOMEAHG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public KDHEKEJHECI? MCJOPAEIFON
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string HLIENDHEJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool MKCCKDMBJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCF80", Offset = "0x7FDC380", VA = "0x187FDCF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF380", Offset = "0x7FDE780", VA = "0x187FDF380")]
	public CNCMDLJBADN(OCGCKBCELPI KLDJLPBCDDF, CPFBCEEAIPJ BJOBOGCCFGD, string IOEILOMOPII, string AKACDLNBPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE9B0", Offset = "0x7FDDDB0", VA = "0x187FDE9B0")]
	private static LLMHKJOOLCM.EMNPPGLFKHI JPPDAIHJGFP(string EMPCPHBAAAL, string NNAOMPALEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEA40", Offset = "0x7FDDE40", VA = "0x187FDEA40")]
	private LLMHKJOOLCM.EMNPPGLFKHI KMMLJBGMIGC(string EMPCPHBAAAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE6D0", Offset = "0x7FDDAD0", VA = "0x187FDE6D0", Slot = "8")]
	public void JDNBOOGDBNB(string? NJKPMDJOLDC, string CEMPIJDGFJL, string HCHBGHGMKJP, float DLHGECLFIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEA80", Offset = "0x7FDDE80", VA = "0x187FDEA80", Slot = "10")]
	public void LDIOEPEEFIK(string? NJKPMDJOLDC, ErrorEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE470", Offset = "0x7FDD870", VA = "0x187FDE470", Slot = "11")]
	public void IKOEIJCALJC(string? NJKPMDJOLDC, decimal FJDKBIOMMOM, string HFJHENFIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE240", Offset = "0x7FDD640", VA = "0x187FDE240")]
	public static void GPDOPOCGFKK(CPFBCEEAIPJ BJOBOGCCFGD, string KOJGIHKIGBD, string NNAOMPALEFJ, decimal FJDKBIOMMOM, string HFJHENFIDEF, params (string key, string val)[] MPIGLKIJDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDB60", Offset = "0x7FDCF60", VA = "0x187FDDB60", Slot = "12")]
	public void EGHNGICBOBC(string? NJKPMDJOLDC, ConversationItemDTO GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEE00", Offset = "0x7FDE200", VA = "0x187FDEE00", Slot = "15")]
	public void ODKPDGAAEAB(string? NJKPMDJOLDC, ResponseEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD020", Offset = "0x7FDC420", VA = "0x187FDD020")]
	private (decimal?, string, string, string, string, string) CDEMHNMHCII(ResponseEventDTO BOBEBPGBGGK)
	{
		return default((decimal?, string, string, string, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD3E0", Offset = "0x7FDC7E0", VA = "0x187FDD3E0", Slot = "13")]
	public void ECCCAGGBKAN(string? NJKPMDJOLDC, ResponseEventDTO BOBEBPGBGGK, float? AEKIGIBEGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7FDECA0", Offset = "0x7FDE0A0", VA = "0x187FDECA0", Slot = "14")]
	public void NCIKEILJMCA(Func<LLMHKJOOLCM.EMNPPGLFKHI, LLMHKJOOLCM.EMNPPGLFKHI> BENCLMHFCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDED50", Offset = "0x7FDE150", VA = "0x187FDED50", Slot = "9")]
	public void NDJDELPHAOM(Func<LLMHKJOOLCM.EMNPPGLFKHI, LLMHKJOOLCM.EMNPPGLFKHI> BENCLMHFCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE0D0", Offset = "0x7FDD4D0", VA = "0x187FDE0D0", Slot = "16")]
	public void GLPMDBECLFA(string? NJKPMDJOLDC, string HBHJOPNAJMN, string? GHGLDMJMCGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class IJACKJGBGGN : GGFIFLPDFLA
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public KDHEKEJHECI? MCJOPAEIFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public decimal KJGIIPLIHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9C80", Offset = "0x7FE9080", VA = "0x187FE9C80")]
		get
		{
			return default(decimal);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public string HLIENDHEJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public OCGCKBCELPI? HAEAAEPIBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "8")]
	public void JDNBOOGDBNB(string? NJKPMDJOLDC, string CEMPIJDGFJL, string HCHBGHGMKJP, float DLHGECLFIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "9")]
	public void NDJDELPHAOM(Func<LLMHKJOOLCM.EMNPPGLFKHI, LLMHKJOOLCM.EMNPPGLFKHI> BENCLMHFCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "10")]
	public void LDIOEPEEFIK(string? NJKPMDJOLDC, ErrorEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "11")]
	public void IKOEIJCALJC(string? NJKPMDJOLDC, decimal FJDKBIOMMOM, string HFJHENFIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "12")]
	public void EGHNGICBOBC(string? NJKPMDJOLDC, ConversationItemDTO GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "15")]
	public void ODKPDGAAEAB(string? NJKPMDJOLDC, ResponseEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "13")]
	public void ECCCAGGBKAN(string? NJKPMDJOLDC, ResponseEventDTO BOBEBPGBGGK, float? AEKIGIBEGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "14")]
	public void NCIKEILJMCA(Func<LLMHKJOOLCM.EMNPPGLFKHI, LLMHKJOOLCM.EMNPPGLFKHI> BENCLMHFCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "16")]
	public void GLPMDBECLFA(string? NJKPMDJOLDC, string HBHJOPNAJMN, string? GHGLDMJMCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9CE0", Offset = "0x7FE90E0", VA = "0x187FE9CE0")]
	public IJACKJGBGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class DCBJIHPDPFB : FJLMFJILKJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct COMKPNDNCJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GBDCMLADEHH recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DCBJIHPDPFB <>4__this;

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
		private TaskAwaiter<HFCBDPJJDFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF4B0", Offset = "0x7FDE8B0", VA = "0x187FDF4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF830", Offset = "0x7FDEC30", VA = "0x187FDF830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly string LCNADCCMPLA;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFD10", Offset = "0x7FDF110", VA = "0x187FDFD10")]
	public DCBJIHPDPFB(GBDCMLADEHH ANCACDKGMMA, string GIEDBGIDEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFBB0", Offset = "0x7FDEFB0", VA = "0x187FDFBB0", Slot = "6")]
	[AsyncStateMachine(typeof(COMKPNDNCJP))]
	protected override Task<bool> TrySyncLatestCostInfo(GBDCMLADEHH ANCACDKGMMA, Guid BHNMHEIBCEK, long DCONEHIDLCB, long DAKBFKLMPGD, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IALLACCJCIL
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	BBKKNBJGBDM<ConversationItemDTO> LIFJKEAFJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IReadOnlyList<ConversationItemDTO> NFNEKIILOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<string> OFANBCBOAND(ConversationItemDTO GBDPBDHPLOA);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHPKMNDACHA(string CFJNLEKPCLF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MJMHKNDDEIF
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ENKEIEOAHJE(IReadOnlyCollection<string> BHIKCLKBIMF, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LCNBGAMGFGK
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ToolDTO[] DLJILBDBIIF();

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> KNBCFDCCNOB(string LLDFMPKDACF, string CAPECKNBLBN, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EHOAMMODIIK
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OCGCKBCELPI
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	const string HLCAFINDOAK = "gpt-4o-mini-realtime-preview-2024-12-17";

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	const string NJCFCAOLHEN = "gpt-4o-mini-transcribe";

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DEEFOEALJCI PKNHMOLCBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	AudioSource OBBHPBNBMLK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IALLACCJCIL? AJJOAJEONMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	MJMHKNDDEIF? ANNLGIMMEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string? CNFEPDMDFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool GEPLAHJKFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FMLIGCPFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool CMLLOGDGJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool APIPHKOEBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LGKFELIBIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool MAJJBICOAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool DPBHHGJPDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JOPHCMLPFKI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool EKACKLEGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool CMNHCAIBCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OGBGHAFBBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool NHFAIEEEBNE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	BBKKNBJGBDM<bool> HKOHCHHJCBE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	OFFOKCJIMNI KNIEMBPAKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	OFFOKCJIMNI IHHNAMJCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NIFKGGOBKPN<string, string> KHFLMCJEJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	OFFOKCJIMNI MBEAIOBCAGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	OFFOKCJIMNI CKNFACLDPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	BBKKNBJGBDM<List<ToolDTO>> KBJANOPNEDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	OFFOKCJIMNI BNIJKOIPDPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NIFKGGOBKPN<float, string> DIJOLBHHLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	BBKKNBJGBDM<string> AAGPFGDICFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string HLIENDHEJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool IDNMCBHENAC
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
	Task BNHIMEOLFPN(string ONPKNOLJFMP, VoiceOption PGMNGEDFIEF, float DLHGECLFIPG = 0.6f, string CHHAPNDAFKL = "gpt-4o-mini-realtime-preview-2024-12-17", string HCHBGHGMKJP = "gpt-4o-mini-transcribe", [Optional] IReadOnlyCollection<string>? GHKGNPGCIBN, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BNEJFADOIKI();

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task LGOLPINAPIK(string ONPKNOLJFMP, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task JENKIIBALMP(float DLHGECLFIPG, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task INFACHNBICH(bool DGKJCLCLLMA, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void AAKCNPEHMNC(params EHOAMMODIIK[] LKKMFGEONJM);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool CBEKMNDBEDN(EHOAMMODIIK FCOIPHLAODP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void AJDGAOLEOMM(params EHOAMMODIIK[] LKKMFGEONJM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void NOFDAGDAPOE(ACAHCPOBLDI MONGIMOHLAO, bool FCAGGKILNIP = false);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void MPJAGJOBBAJ(ACAHCPOBLDI MONGIMOHLAO, bool FCAGGKILNIP = false);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void ABHLOBJEHJN(ACAHCPOBLDI MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FJCFCIIODPF(ACAHCPOBLDI MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void GGKPIMCMOAB(decimal FJDKBIOMMOM, string HFJHENFIDEF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task DANHHHCJFPP(byte[] MMPAOCFKLJI, string? MHDNGEKGIPC, [Optional] string? JDHIAEAAKJI, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task DANHHHCJFPP(string AFDNIPHJHMO, [Optional] string? JDHIAEAAKJI, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task HNBJBCNFDEB(string AFDNIPHJHMO, [Optional] string? JDHIAEAAKJI, [Optional] string? AHPJGBLMCHK, bool AEBANGGICNK = false, bool OHMFANHOHGN = false, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task KHPKMNDACHA(string JDHIAEAAKJI, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<ResponseDTO> MHDAJIEFECO(bool HNBEFDPPLJE = true, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<string> ONDLDKBIPAF(string ONPKNOLJFMP, [Optional] IReadOnlyList<ConversationItemDTO>? BHIKCLKBIMF, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<TOutput> ONDLDKBIPAF<TOutput>(string ONPKNOLJFMP, [Optional] IReadOnlyList<ConversationItemDTO>? BHIKCLKBIMF, [Optional] CancellationToken GMKBGHHNCDJ) where TOutput : class;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task<List<JBEOLGHLMMP>> ONDLDKBIPAF(string ONPKNOLJFMP, IReadOnlyList<ConversationItemDTO>? BHIKCLKBIMF, IReadOnlyList<JMBNJPGKMMA> GLJNKHNGMFK, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool JOLEBNDADIM(string CFJNLEKPCLF);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool EPFPMKJJOFA(string CFJNLEKPCLF);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool DNIAPCONFGC(string KILBNAODNFA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task CBCPPILDGNO(bool ILIHBMMPJGE, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "55")]
	IReadOnlyCollection<string> FEOLJFIHGDJ();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GGFIFLPDFLA
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KDHEKEJHECI? MCJOPAEIFON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string HLIENDHEJJE
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
	void JDNBOOGDBNB(string? NJKPMDJOLDC, string CEMPIJDGFJL, string HCHBGHGMKJP, float DLHGECLFIPG);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDJDELPHAOM(Func<LLMHKJOOLCM.EMNPPGLFKHI, LLMHKJOOLCM.EMNPPGLFKHI> BENCLMHFCAD);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LDIOEPEEFIK(string? NJKPMDJOLDC, ErrorEventDTO BOBEBPGBGGK);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IKOEIJCALJC(string? NJKPMDJOLDC, decimal FJDKBIOMMOM, string HFJHENFIDEF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EGHNGICBOBC(string? NJKPMDJOLDC, ConversationItemDTO GBDPBDHPLOA);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ECCCAGGBKAN(string? NJKPMDJOLDC, ResponseEventDTO BOBEBPGBGGK, float? AEKIGIBEGEI);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NCIKEILJMCA(Func<LLMHKJOOLCM.EMNPPGLFKHI, LLMHKJOOLCM.EMNPPGLFKHI> BENCLMHFCAD);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ODKPDGAAEAB(string? NJKPMDJOLDC, ResponseEventDTO BOBEBPGBGGK);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GLPMDBECLFA(string? NJKPMDJOLDC, string HBHJOPNAJMN, string? GHGLDMJMCGK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface IPEKCBJCDFG
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void DJOKBAFPKND(ReadOnlySpan<float> IDHGNOPFHHB, int MBLOEPMGFGN, int FCFHMBNBOIH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCIDJAHDOMG(DJOKBAFPKND GKNBMKFDKOP);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLOKCJDGFGO(DJOKBAFPKND GKNBMKFDKOP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CPFBCEEAIPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPGIDFJGOMJ(decimal DOEMPECIDDM);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class BIELEKBMBEE
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private enum IDNACJIPMJB
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
	private static ConcurrentDictionary<Type, JsonSchema> NPOBGGPJJFJ;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly Type[] KIKFDHEOGFN;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly Type[] MCKCBLNPBHM;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A40840", Offset = "0x3A3FC40", VA = "0x183A40840")]
	public static JsonSchema DIJAEKOIPED<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9F50", Offset = "0x7FD9350", VA = "0x187FD9F50")]
	public static JsonSchema EGNFLCAEPHL(IReadOnlyList<JMBNJPGKMMA> PHAOHJHLKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9CF0", Offset = "0x7FD90F0", VA = "0x187FD9CF0")]
	public static PJPLDNEIIOG DGBPDNNBGOD(string HDNPPEBJPAE, string? GMABBLIJJKB, JsonSchema PODNOHGAICE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A407C0", Offset = "0x3A3FBC0", VA = "0x183A407C0")]
	public static PJPLDNEIIOG DGBPDNNBGOD<T>(string HDNPPEBJPAE, string? GMABBLIJJKB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9E00", Offset = "0x7FD9200", VA = "0x187FD9E00")]
	public static PJPLDNEIIOG DGBPDNNBGOD(string HDNPPEBJPAE, string? GMABBLIJJKB, IReadOnlyList<JMBNJPGKMMA> PHAOHJHLKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA710", Offset = "0x7FD9B10", VA = "0x187FDA710")]
	private static JsonSchema HFFNDIDHDBE(Type IIHAKBEOLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAB60", Offset = "0x7FD9F60", VA = "0x187FDAB60")]
	private static JsonSchema HPECJOMEAPI(Type IIHAKBEOLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA2A0", Offset = "0x7FD96A0", VA = "0x187FDA2A0")]
	private static IDNACJIPMJB FAGAKAAPNAE(Type IIHAKBEOLJD, [Out] Type? FHACIBPEDGD)
	{
		return default(IDNACJIPMJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA4A0", Offset = "0x7FD98A0", VA = "0x187FDA4A0")]
	private static bool GNAFGCLEMAO(Type IIHAKBEOLJD, [Out][MaybeNullWhen(false)] Type KADLGDIHHBH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MCLAFGBNIHP : EHOAMMODIIK, LCNBGAMGFGK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<string> KBFANEHNIIE(List<JBEOLGHLMMP> NODDCIHHMPD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct KELCNILDIKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public string methodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public MCLAFGBNIHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string methodArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC670", Offset = "0x7FEBA70", VA = "0x187FEC670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7FECD10", Offset = "0x7FEC110", VA = "0x187FECD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly string EFINADMOPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly string ELBEEHDMJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IReadOnlyList<JMBNJPGKMMA> DCCDGEKKMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly KBFANEHNIIE FKMAILIJJCO;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x10BB460", Offset = "0x10BA860", VA = "0x1810BB460")]
	public MCLAFGBNIHP(string HDNPPEBJPAE, string GMABBLIJJKB, IReadOnlyList<JMBNJPGKMMA> PHAOHJHLKGO, KBFANEHNIIE IGJIAOCAHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7FED750", Offset = "0x7FECB50", VA = "0x187FED750", Slot = "4")]
	private ToolDTO[] AHCAKDGLAHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7FED8E0", Offset = "0x7FECCE0", VA = "0x187FED8E0", Slot = "5")]
	[AsyncStateMachine(typeof(KELCNILDIKF))]
	private Task<string> AIEGPKIJIDE(string LLDFMPKDACF, string CAPECKNBLBN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class JLHFFBGAIPE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
	public JLHFFBGAIPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class KBBGHFPEFBJ : Exception, HCCMGCAOBHE
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string PJGHDLEHGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x49B1180", Offset = "0x49B0580", VA = "0x1849B1180", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC5F0", Offset = "0x7FEB9F0", VA = "0x187FEC5F0")]
	public KBBGHFPEFBJ(string HJKJDCHIKKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class FPCIIJEMHFB : OCGCKBCELPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private enum HNFIBMHBCND
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		NotConnected,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		Connected
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct IEBFLCHDJPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int? reconnectAttempt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private CancellationTokenSource <cts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private CancellationToken <originalCancellationToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private IDisposable <combinedTokenDisposer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string <instructions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private float <temperature>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<DEEFOEALJCI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<bool> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE7530", Offset = "0x7FE6930", VA = "0x187FE7530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9920", Offset = "0x7FE8D20", VA = "0x187FE9920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct JELELNMGAGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool keepConversationHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7FEB950", Offset = "0x7FEAD50", VA = "0x187FEB950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7FEBB60", Offset = "0x7FEAF60", VA = "0x187FEBB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct ABELEIAILOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9550", Offset = "0x7FD8950", VA = "0x187FD9550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9780", Offset = "0x7FD8B80", VA = "0x187FD9780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct CKPIECMDFDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public float temperature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCD10", Offset = "0x7FDC110", VA = "0x187FDCD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCF20", Offset = "0x7FDC320", VA = "0x187FDCF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct AFLDJNNDNCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7FD98F0", Offset = "0x7FD8CF0", VA = "0x187FD98F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9B00", Offset = "0x7FD8F00", VA = "0x187FD9B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct EOFGDLECPOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0060", Offset = "0x7FDF460", VA = "0x187FE0060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0360", Offset = "0x7FDF760", VA = "0x187FE0360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HJDIPCELOOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public byte[] pcmAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string transcript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7FE7050", Offset = "0x7FE6450", VA = "0x187FE7050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE74D0", Offset = "0x7FE68D0", VA = "0x187FE74D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct NHOBJOCIKFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0770", Offset = "0x7FEFB70", VA = "0x187FF0770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0BE0", Offset = "0x7FEFFE0", VA = "0x187FF0BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct IJGNLKGCGHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public bool suppressFromConversationLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public bool excludeFromConversationPruning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public string previousItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA1C0", Offset = "0x7FE95C0", VA = "0x187FEA1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA710", Offset = "0x7FE9B10", VA = "0x187FEA710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct OHEKCEBNBNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public string convresationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2290", Offset = "0x7FF1690", VA = "0x187FF2290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7FF27C0", Offset = "0x7FF1BC0", VA = "0x187FF27C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class GFFKPJMMIKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public ResponseDTO response;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GFFKPJMMIKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6E30", Offset = "0x7FE6230", VA = "0x187FE6E30")]
		internal bool KOKFOMGOLNN(OutputAudioBufferEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LHDDAJBIHFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private GFFKPJMMIKI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public bool waitForAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter<OutputAudioBufferEventDTO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7FECD80", Offset = "0x7FEC180", VA = "0x187FECD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7FED5D0", Offset = "0x7FEC9D0", VA = "0x187FED5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct MNAMBOGMJKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF120", Offset = "0x7FEE520", VA = "0x187FEF120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF6D0", Offset = "0x7FEEAD0", VA = "0x187FEF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct NOFOKDCMAOM<TOutput> : IAsyncStateMachine where TOutput : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public AsyncTaskMethodBuilder<TOutput> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x583B3E0", Offset = "0x583A7E0", VA = "0x18583B3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x583BC10", Offset = "0x583B010", VA = "0x18583BC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct MNPMKIMACPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder<List<JBEOLGHLMMP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public IReadOnlyList<JMBNJPGKMMA> responseArgSchemas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF740", Offset = "0x7FEEB40", VA = "0x187FEF740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFE10", Offset = "0x7FEF210", VA = "0x187FEFE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class BGFADJEADHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public ResponseCreateEventDTO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public string id;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BGFADJEADHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9BF0", Offset = "0x7FD8FF0", VA = "0x187FD9BF0")]
		internal void OLGDNGFBEAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9B60", Offset = "0x7FD8F60", VA = "0x187FD9B60")]
		internal bool BJNLNHFFAMF(ResponseEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct MOHNNODPMHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder<List<ConversationItemDTO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public JsonSchema responseSchema;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private TaskAwaiter<ResponseEventDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFE80", Offset = "0x7FEF280", VA = "0x187FEFE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0700", Offset = "0x7FEFB00", VA = "0x187FF0700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FLIDMJJHBOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public DateTime expirationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7FE10E0", Offset = "0x7FE04E0", VA = "0x187FE10E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7FE14D0", Offset = "0x7FE08D0", VA = "0x187FE14D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct IJDPCEJBIDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private List<ToolDTO> <tools>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9D40", Offset = "0x7FE9140", VA = "0x187FE9D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA160", Offset = "0x7FE9560", VA = "0x187FEA160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct GBAPBNHPKPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public ResponseEventDTO ev;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private string <responseId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6890", Offset = "0x7FE5C90", VA = "0x187FE6890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class PGKLHAGMCIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PGKLHAGMCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7FF3670", Offset = "0x7FF2A70", VA = "0x187FF3670")]
		internal Task KADAAEHHELA(ConversationItemDTO outputItem)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct PAEEKHANFMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public ResponseDTO response;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private PGKLHAGMCIF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2E50", Offset = "0x7FF2250", VA = "0x187FF2E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7FF3610", Offset = "0x7FF2A10", VA = "0x187FF3610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct IIBGOJFLKKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9980", Offset = "0x7FE8D80", VA = "0x187FE9980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9C20", Offset = "0x7FE9020", VA = "0x187FE9C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct NIGIKMEPLKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0C40", Offset = "0x7FF0040", VA = "0x187FF0C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0FA0", Offset = "0x7FF03A0", VA = "0x187FF0FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct MIDDFHKKOLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public FPCIIJEMHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <cancellationToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private DateTime? <startTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter<ResponseDTO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE580", Offset = "0x7FED980", VA = "0x187FEE580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF0B0", Offset = "0x7FEE4B0", VA = "0x187FEF0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly AKNCNLDICPO GJFBEGANDPI;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private const ToolChoice FAKCMNOLDBK = ToolChoice.Auto;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private const float FCEHPLDGBCH = 0.01f;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly TimeSpan[] JPFDOBCNHPN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly TimeSpan FNCFCDDJPJH;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly TimeSpan IJGBDGOHCGA;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly TimeSpan NELHKAILCOI;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly TimeSpan LEKPIJHIKEA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly TimeSpan GMGABGKBFFP;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly TimeSpan OHAJKIPGEMA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private const string HEMHILDMDML = "out-of-band-id";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly AKNDJBKAOGM NNKCEJNCBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly IPEKCBJCDFG GHDFFENIAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	protected readonly GBDCMLADEHH IJPBGFIHGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly AFKDNJAIDLM OEPJHHOLPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JPBKNFHFEPN LGEABLNNIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly JPBKNFHFEPN EHOEBELPLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<string, DateTime> GMBFJNFICBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Lazy<GGFIFLPDFLA> MDBMEMDJPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly LOBBIMMNKHK? CFJDFMINAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private string NOBEFNOMPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private VoiceOption ANFIOFNNMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private float PNNNFNPKBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private string MKEHFKBALJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private string KNLBGGACFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private HNFIBMHBCND CIKENCHHNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private CancellationTokenSource? NNOBGDPGJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	protected DEEFOEALJCI? ODPDHOCHBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private AudioSource KNEMCHGFIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private AudioSourceSimpleLevelMeter? IBKGLJCKDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private BKHIGNNBAAP? GHNDCCBPGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private LOEGMCKICHH? JEFPLBELEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NNADKMGKGEG? NLKEGKLGJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private ECIFOOPNLJL? EKFBLMFOIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private IReadOnlyCollection<string> OMKOKBMMKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private DateTime? ICKKHMIOKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Task<ResponseDTO>? CIHAIKGJKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private uint LJJMLNLCAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly HashSet<string> KDINALKJLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly HashSet<string> IICGABAGKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly HashSet<string> DCCHIMEKAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool BMJPGEEKGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private ACAHCPOBLDI? FALLBBPLFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool CJBAEJEKHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private CancellationTokenSource? GMEMPKDKAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private string? PCJINDPMNFB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DEEFOEALJCI PKNHMOLCBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4640", Offset = "0x7FE3A40", VA = "0x187FE4640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string? CNFEPDMDFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2910", Offset = "0x7FE1D10", VA = "0x187FE2910", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public abstract bool GEPLAHJKFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public abstract bool FMLIGCPFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract bool CMLLOGDGJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	protected abstract bool CHGLKEBCBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected abstract string? HKDGBAAHCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected abstract string GLPGLCGICKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected abstract int DJNDPOFLIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	protected abstract int HOCIEPAJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	protected abstract JPJLLBOCAAE FEEOFIGPAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	protected abstract string KDKJDPOCJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	protected virtual bool DDNLBFAEOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool APIPHKOEBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3310", Offset = "0x7FE2710", VA = "0x187FE3310", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool LGKFELIBIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7FE33E0", Offset = "0x7FE27E0", VA = "0x187FE33E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool MAJJBICOAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4910", Offset = "0x7FE3D10", VA = "0x187FE4910", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool DPBHHGJPDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xBCF8F0", Offset = "0xBCECF0", VA = "0x180BCF8F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xBD07B0", Offset = "0xBCFBB0", VA = "0x180BD07B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool JOPHCMLPFKI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1B80", Offset = "0x7FE0F80", VA = "0x187FE1B80", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool EKACKLEGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE54B0", Offset = "0x7FE48B0", VA = "0x187FE54B0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool CMNHCAIBCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x284A070", Offset = "0x2849470", VA = "0x18284A070", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool OGBGHAFBBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE29E0", Offset = "0x7FE1DE0", VA = "0x187FE29E0", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool NHFAIEEEBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C40", Offset = "0x7FE1040", VA = "0x187FE1C40", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private bool GJFLIONKIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5570", Offset = "0x7FE4970", VA = "0x187FE5570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private bool AJDEAGNBOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7FE49A0", Offset = "0x7FE3DA0", VA = "0x187FE49A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private bool JDGKHKPFMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7FE29D0", Offset = "0x7FE1DD0", VA = "0x187FE29D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool IDNMCBHENAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x26717F0", Offset = "0x2670BF0", VA = "0x1826717F0", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2FE0", Offset = "0x7FE23E0", VA = "0x187FE2FE0", Slot = "58")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private uint GNOKANLCIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB169A0", Offset = "0xB15DA0", VA = "0x180B169A0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3C60", Offset = "0x7FE3060", VA = "0x187FE3C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public AudioSource OBBHPBNBMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAD90C0", Offset = "0xAD84C0", VA = "0x180AD90C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public IALLACCJCIL? AJJOAJEONMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xB1F0B0", Offset = "0xB1E4B0", VA = "0x180B1F0B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public MJMHKNDDEIF? ANNLGIMMEPN
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA76C50", Offset = "0xA76050", VA = "0x180A76C50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string HLIENDHEJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2960", Offset = "0x7FE1D60", VA = "0x187FE2960")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4460", Offset = "0x7FE3860", VA = "0x187FE4460", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected virtual string? HDEJFIHHAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xB4BEA0", Offset = "0xB4B2A0", VA = "0x180B4BEA0", Slot = "73")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected virtual AKNCNLDICPO? OHEFCMFJENH
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "74")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual AKNCNLDICPO? HOOLJPBDNNP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "75")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public BBKKNBJGBDM<bool> HKOHCHHJCBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xBCF310", Offset = "0xBCE710", VA = "0x180BCF310", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public OFFOKCJIMNI KNIEMBPAKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xBCF390", Offset = "0xBCE790", VA = "0x180BCF390", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public OFFOKCJIMNI IHHNAMJCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xBD0B90", Offset = "0xBCFF90", VA = "0x180BD0B90", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public NIFKGGOBKPN<string, string> KHFLMCJEJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xBE0820", Offset = "0xBDFC20", VA = "0x180BE0820", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BBKKNBJGBDM<List<ToolDTO>> KBJANOPNEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xBC8C10", Offset = "0xBC8010", VA = "0x180BC8C10", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public OFFOKCJIMNI MBEAIOBCAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xBD1090", Offset = "0xBD0490", VA = "0x180BD1090", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public OFFOKCJIMNI CKNFACLDPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xBD31C0", Offset = "0xBD25C0", VA = "0x180BD31C0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public OFFOKCJIMNI BNIJKOIPDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xBE09D0", Offset = "0xBDFDD0", VA = "0x180BE09D0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public NIFKGGOBKPN<float, string> DIJOLBHHLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xBCDFF0", Offset = "0xBCD3F0", VA = "0x180BCDFF0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public BBKKNBJGBDM<string> AAGPFGDICFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xBD2B60", Offset = "0xBD1F60", VA = "0x180BD2B60", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5FF0", Offset = "0x7FE53F0", VA = "0x187FE5FF0")]
	public FPCIIJEMHFB(AKNDJBKAOGM MHNBAAABAJA, IPEKCBJCDFG JMBCFFLGGPI, GBDCMLADEHH ANCACDKGMMA, [Optional] LOBBIMMNKHK? OLELDHNDOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "61")]
	protected abstract GGFIFLPDFLA CreateDataReporter();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7FE17F0", Offset = "0x7FE0BF0", VA = "0x187FE17F0")]
	private void AGOMGGDNGEG(EHOAMMODIIK LGMBKMGAIMJ, LCNBGAMGFGK? IGJIAOCAHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2710", Offset = "0x7FE1B10", VA = "0x187FE2710", Slot = "31")]
	public Task BNHIMEOLFPN(string ONPKNOLJFMP, VoiceOption PGMNGEDFIEF, float DLHGECLFIPG, string CHHAPNDAFKL, string HCHBGHGMKJP, [Optional] IReadOnlyCollection<string>? GHKGNPGCIBN, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2A30", Offset = "0x7FE1E30", VA = "0x187FE2A30")]
	[AsyncStateMachine(typeof(IEBFLCHDJPJ))]
	private Task COFPMOIKDEB(int? CBDDGNDDGJH, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2B50", Offset = "0x7FE1F50", VA = "0x187FE2B50", Slot = "76")]
	protected virtual Task CheckAccess(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5D60", Offset = "0x7FE5160", VA = "0x187FE5D60", Slot = "77")]
	protected virtual Task<bool> UploadTranscriptsForModeration(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C60", Offset = "0x7FE1060", VA = "0x187FE1C60", Slot = "32")]
	public void BNEJFADOIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE27B0", Offset = "0x7FE1BB0", VA = "0x187FE27B0", Slot = "55")]
	[AsyncStateMachine(typeof(JELELNMGAGC))]
	public Task CBCPPILDGNO(bool ILIHBMMPJGE, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3180", Offset = "0x7FE2580", VA = "0x187FE3180", Slot = "78")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4B40", Offset = "0x7FE3F40", VA = "0x187FE4B40", Slot = "33")]
	[AsyncStateMachine(typeof(ABELEIAILOE))]
	public Task LGOLPINAPIK(string ONPKNOLJFMP, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3B50", Offset = "0x7FE2F50", VA = "0x187FE3B50", Slot = "34")]
	[AsyncStateMachine(typeof(CKPIECMDFDG))]
	public Task JENKIIBALMP(float DLHGECLFIPG, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7FE36C0", Offset = "0x7FE2AC0", VA = "0x187FE36C0")]
	[AsyncStateMachine(typeof(AFLDJNNDNCM))]
	public Task HECOJAPENIM(bool DGKJCLCLLMA, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3A40", Offset = "0x7FE2E40", VA = "0x187FE3A40", Slot = "35")]
	[AsyncStateMachine(typeof(EOFGDLECPOO))]
	public Task INFACHNBICH(bool DGKJCLCLLMA, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1530", Offset = "0x7FE0930", VA = "0x187FE1530", Slot = "36")]
	public void AAKCNPEHMNC(params EHOAMMODIIK[] LKKMFGEONJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7FE28C0", Offset = "0x7FE1CC0", VA = "0x187FE28C0", Slot = "37")]
	public bool CBEKMNDBEDN(EHOAMMODIIK FCOIPHLAODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1BC0", Offset = "0x7FE0FC0", VA = "0x187FE1BC0", Slot = "38")]
	public void AJDGAOLEOMM(params EHOAMMODIIK[] LKKMFGEONJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5500", Offset = "0x7FE4900", VA = "0x187FE5500", Slot = "39")]
	public void NOFDAGDAPOE(ACAHCPOBLDI MONGIMOHLAO, bool FCAGGKILNIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5350", Offset = "0x7FE4750", VA = "0x187FE5350", Slot = "40")]
	public void MPJAGJOBBAJ(ACAHCPOBLDI MONGIMOHLAO, bool FCAGGKILNIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE15B0", Offset = "0x7FE09B0", VA = "0x187FE15B0", Slot = "41")]
	public void ABHLOBJEHJN(ACAHCPOBLDI MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3380", Offset = "0x7FE2780", VA = "0x187FE3380", Slot = "42")]
	public void FJCFCIIODPF(ACAHCPOBLDI MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3320", Offset = "0x7FE2720", VA = "0x187FE3320", Slot = "59")]
	public IReadOnlyCollection<string> FEOLJFIHGDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3450", Offset = "0x7FE2850", VA = "0x187FE3450", Slot = "43")]
	public void GGKPIMCMOAB(decimal FJDKBIOMMOM, string HFJHENFIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2D50", Offset = "0x7FE2150", VA = "0x187FE2D50", Slot = "44")]
	[AsyncStateMachine(typeof(HJDIPCELOOO))]
	public Task DANHHHCJFPP(byte[] MMPAOCFKLJI, string? MHDNGEKGIPC, string? JDHIAEAAKJI, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2EA0", Offset = "0x7FE22A0", VA = "0x187FE2EA0", Slot = "45")]
	[AsyncStateMachine(typeof(NHOBJOCIKFI))]
	public Task DANHHHCJFPP(string AFDNIPHJHMO, string? JDHIAEAAKJI, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7FE37D0", Offset = "0x7FE2BD0", VA = "0x187FE37D0", Slot = "46")]
	[AsyncStateMachine(typeof(IJGNLKGCGHJ))]
	public Task HNBJBCNFDEB(string AFDNIPHJHMO, string? JDHIAEAAKJI, string? AHPJGBLMCHK, bool AEBANGGICNK, bool OHMFANHOHGN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7FE46E0", Offset = "0x7FE3AE0", VA = "0x187FE46E0", Slot = "47")]
	[AsyncStateMachine(typeof(OHEKCEBNBNE))]
	public Task KHPKMNDACHA(string EPGACCHOHIE, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4540", Offset = "0x7FE3940", VA = "0x187FE4540", Slot = "52")]
	public bool JOLEBNDADIM(string CFJNLEKPCLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7FE32B0", Offset = "0x7FE26B0", VA = "0x187FE32B0", Slot = "53")]
	public bool EPFPMKJJOFA(string CFJNLEKPCLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2FF0", Offset = "0x7FE23F0", VA = "0x187FE2FF0", Slot = "54")]
	public bool DNIAPCONFGC(string KILBNAODNFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5100", Offset = "0x7FE4500", VA = "0x187FE5100", Slot = "48")]
	[AsyncStateMachine(typeof(LHDDAJBIHFD))]
	public Task<ResponseDTO> MHDAJIEFECO(bool HNBEFDPPLJE = true, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5A40", Offset = "0x7FE4E40", VA = "0x187FE5A40", Slot = "49")]
	[AsyncStateMachine(typeof(MNAMBOGMJKH))]
	public Task<string> ONDLDKBIPAF(string ONPKNOLJFMP, [Optional] IReadOnlyList<ConversationItemDTO>? BHIKCLKBIMF, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2FC0", Offset = "0x3CA23C0", VA = "0x183CA2FC0", Slot = "50")]
	[AsyncStateMachine(typeof(NOFOKDCMAOM<>))]
	public Task<TOutput> ONDLDKBIPAF<TOutput>(string ONPKNOLJFMP, [Optional] IReadOnlyList<ConversationItemDTO>? BHIKCLKBIMF, [Optional] CancellationToken GMKBGHHNCDJ) where TOutput : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7FE58D0", Offset = "0x7FE4CD0", VA = "0x187FE58D0", Slot = "51")]
	[AsyncStateMachine(typeof(MNPMKIMACPB))]
	public Task<List<JBEOLGHLMMP>> ONDLDKBIPAF(string ONPKNOLJFMP, IReadOnlyList<ConversationItemDTO>? BHIKCLKBIMF, IReadOnlyList<JMBNJPGKMMA> GLJNKHNGMFK, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2BE0", Offset = "0x7FE1FE0", VA = "0x187FE2BE0")]
	[AsyncStateMachine(typeof(MOHNNODPMHI))]
	private Task<List<ConversationItemDTO>> DAMFJOGGMLL(string ONPKNOLJFMP, IReadOnlyList<ConversationItemDTO>? BHIKCLKBIMF, JsonSchema? IIONIJHIOHJ, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3070", Offset = "0x7FE2470", VA = "0x187FE3070")]
	[AsyncStateMachine(typeof(FLIDMJJHBOK))]
	private Task DPKGHPCODLO(DateTime OGNLPGOIECO, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5680", Offset = "0x7FE4A80", VA = "0x187FE5680")]
	private bool OMEKFCDAOCD(ResponseDTO HGHNDNAANCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5240", Offset = "0x7FE4640", VA = "0x187FE5240")]
	private void MJFJLOOCOCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE45A0", Offset = "0x7FE39A0", VA = "0x187FE45A0")]
	private void JOMAIMBMHJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE15F0", Offset = "0x7FE09F0", VA = "0x187FE15F0")]
	[AsyncStateMachine(typeof(IJDPCEJBIDA))]
	private Task ABJCBPJMHHH([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5BA0", Offset = "0x7FE4FA0", VA = "0x187FE5BA0")]
	private void OOKNFOMPBBB(ReadOnlySpan<float> IDHGNOPFHHB, int MBLOEPMGFGN, int FCFHMBNBOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4D90", Offset = "0x7FE4190", VA = "0x187FE4D90")]
	private void LMEBACAMFJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5C90", Offset = "0x7FE5090", VA = "0x187FE5C90")]
	[AsyncStateMachine(typeof(GBAPBNHPKPI))]
	private void PFNDJMEBEDL(ResponseEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4C50", Offset = "0x7FE4050", VA = "0x187FE4C50")]
	private void LIFJKEAFJMD(ConversationItemDTO GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2EE0", Offset = "0x3CA22E0", VA = "0x183CA2EE0")]
	private void HNFPPMPAPGH<T>(T BOBEBPGBGGK) where T : notnull, GJILLMMLADJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3CD0", Offset = "0x7FE30D0", VA = "0x187FE3CD0")]
	private void JIFBCIKJBGG(ResponseEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4E50", Offset = "0x7FE4250", VA = "0x187FE4E50")]
	private void MFKPOLMFCDI(string CEMPIJDGFJL, string HCHBGHGMKJP, float DLHGECLFIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3920", Offset = "0x7FE2D20", VA = "0x187FE3920")]
	[AsyncStateMachine(typeof(PAEEKHANFMF))]
	private Task HNEEKIAACOH(ResponseDTO HGHNDNAANCF, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4800", Offset = "0x7FE3C00", VA = "0x187FE4800")]
	[AsyncStateMachine(typeof(IIBGOJFLKKN))]
	private Task KNBCFDCCNOB(ConversationItemDTO GBDPBDHPLOA, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7FE35B0", Offset = "0x7FE29B0", VA = "0x187FE35B0")]
	[AsyncStateMachine(typeof(NIGIKMEPLKF))]
	private Task<ResponseDTO> GNGDJICEDPM(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7FE16E0", Offset = "0x7FE0AE0", VA = "0x187FE16E0")]
	[AsyncStateMachine(typeof(MIDDFHKKOLP))]
	private Task<ResponseDTO> AFEHIGFNPLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4FC0", Offset = "0x7FE43C0", VA = "0x187FE4FC0")]
	private void MGFGLMPMMDD(ErrorEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE28E0", Offset = "0x7FE1CE0", VA = "0x187FE28E0")]
	private void CGKAAIAPNEE(InputAudioBufferSpeechStartedEventDTO PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE53C0", Offset = "0x7FE47C0", VA = "0x187FE53C0")]
	private void MPOGNBKKJCN(InputAudioBufferSpeechStoppedEventDTO PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE49F0", Offset = "0x7FE3DF0", VA = "0x187FE49F0")]
	protected void LGMJBONMMCH(string HBHJOPNAJMN, [Optional] string? GHGLDMJMCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE52E0", Offset = "0x7FE46E0", VA = "0x187FE52E0")]
	public static bool MMCDDKPPHHO(ResponseDTO HGHNDNAANCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE33C0", Offset = "0x7FE27C0", VA = "0x187FE33C0")]
	protected void GAOILCFEPMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1B80", Offset = "0x7FE0F80", VA = "0x187FE1B80")]
	[CompilerGenerated]
	private bool CNIFNPNKKOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5450", Offset = "0x7FE4850", VA = "0x187FE5450")]
	[CompilerGenerated]
	private bool NECDHNDDOEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class EBMEIGJGEPM : FJLMFJILKJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct FFHBJLKNMFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public GBDCMLADEHH recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public EBMEIGJGEPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Guid spendSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TaskAwaiter<HFCBDPJJDFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0670", Offset = "0x7FDFA70", VA = "0x187FE0670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0B20", Offset = "0x7FDFF20", VA = "0x187FE0B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly OCGCKBCELPI BGIDPGLCAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly string LCNADCCMPLA;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFFA0", Offset = "0x7FDF3A0", VA = "0x187FDFFA0")]
	public EBMEIGJGEPM(OCGCKBCELPI KLDJLPBCDDF, GBDCMLADEHH ANCACDKGMMA, string GIEDBGIDEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFE40", Offset = "0x7FDF240", VA = "0x187FDFE40", Slot = "6")]
	[AsyncStateMachine(typeof(FFHBJLKNMFG))]
	protected override Task<bool> TrySyncLatestCostInfo(GBDCMLADEHH ANCACDKGMMA, Guid BHNMHEIBCEK, long DCONEHIDLCB, long DAKBFKLMPGD, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
public class AMBMPAEIDOA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
	public AMBMPAEIDOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface IOJPNADJPGK
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBIPADKKCBD(EHOAMMODIIK FCOIPHLAODP, [Out] LCNBGAMGFGK IGJIAOCAHMB);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MHFNNGJIFKM
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class HGKGFFCIJNN
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public PropertyInfo GADCNAHNNPN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Type NBFFAIKCBBM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x724B610", Offset = "0x724AA10", VA = "0x18724B610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string OJGHHDGPPGF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool GDLBIEJGACI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Type? JHMENDHLIFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6EB0", Offset = "0x7FE62B0", VA = "0x187FE6EB0")]
		public HGKGFFCIJNN(PropertyInfo CCLJFEEEBKB, JsonPropertyAttribute? AAOBBHEDFCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly ConcurrentDictionary<Type, List<HGKGFFCIJNN>> OGKOKOILHJF;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7FEDA20", Offset = "0x7FECE20", VA = "0x187FEDA20")]
	public static List<string> EEDMEMCPMCK(string GILAAHLNHOK, Type MMAPPPGAOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7FEDB10", Offset = "0x7FECF10", VA = "0x187FEDB10")]
	private static void GMIMBNPNHJA(Type IIHAKBEOLJD, JObject KCDLDCABCJB, List<string> CHFJFOICCNB, string IKAMPLAMMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE1E0", Offset = "0x7FED5E0", VA = "0x187FEE1E0")]
	private static List<HGKGFFCIJNN> PMPEHFFDOKC(Type IIHAKBEOLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE130", Offset = "0x7FED530", VA = "0x187FEE130")]
	private static bool KBIMCFBMDOI(Type IIHAKBEOLJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MHFNNGJIFKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class NNADKMGKGEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class EJKECINGNLN
	{
		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string? FABLMACFMCB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public int IHMINMGACPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public int FPBIHFEPBHH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xA97100", Offset = "0xA96500", VA = "0x180A97100")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xE9A000", Offset = "0xE99400", VA = "0x180E9A000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0040", Offset = "0x7FDF440", VA = "0x187FE0040")]
		public EJKECINGNLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class POKIEGKMDBE
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public string NGBODNHEHKM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public ConversationItemType GBFFBDIJNIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			[CompilerGenerated]
			get
			{
				return default(ConversationItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string? FDOEGCHIMKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string? GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7FF37F0", Offset = "0x7FF2BF0", VA = "0x187FF37F0")]
		public POKIEGKMDBE(ConversationItemDTO GBDPBDHPLOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class ACBNBIPNEOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public IEnumerable<string> functionNames;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ACBNBIPNEOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD97E0", Offset = "0x7FD8BE0", VA = "0x187FD97E0")]
		internal bool DBJOCGGHJPB(POKIEGKMDBE c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class INALLFOJHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public POKIEGKMDBE c;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public INALLFOJHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA770", Offset = "0x7FE9B70", VA = "0x187FEA770")]
		internal bool DMMPFJOPIJB(string n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class EOMPBHFHOEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public NNADKMGKGEG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EOMPBHFHOEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7FE03C0", Offset = "0x7FDF7C0", VA = "0x187FE03C0")]
		internal bool EHAOLGNOKHK(string n)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0400", Offset = "0x7FDF800", VA = "0x187FE0400")]
		internal bool LBKFKMNNGKI(POKIEGKMDBE c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0450", Offset = "0x7FDF850", VA = "0x187FE0450")]
		internal void NPOLCLGAHEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class OOONAPIOFDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public IEnumerable<string?> callIdsToRemove;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OOONAPIOFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2DE0", Offset = "0x7FF21E0", VA = "0x187FF2DE0")]
		internal bool LLADENPMGAH(POKIEGKMDBE c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class PKGEJGDLAEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public IEnumerable<string> idsToRemove;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PKGEJGDLAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FF3790", Offset = "0x7FF2B90", VA = "0x187FF3790")]
		internal bool ECGOOGADPNM(POKIEGKMDBE c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class GGMMGNODOGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Func<bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GGMMGNODOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6E60", Offset = "0x7FE6260", VA = "0x187FE6E60")]
		internal bool EPBHJGBGIOF()
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct OLMHLLDMLEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private GGMMGNODOGA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NNADKMGKGEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2820", Offset = "0x7FF1C20", VA = "0x187FF2820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2D80", Offset = "0x7FF2180", VA = "0x187FF2D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly OCGCKBCELPI IMLCHPJGPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly IALLACCJCIL GHNDCCBPGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly HashSet<string> IGEAPIBKMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly EJKECINGNLN GJDDMOEJHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly List<POKIEGKMDBE> OMKOKBMMKIK;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static Queue<string> HIOMIKIKHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly CancellationTokenSource IPBILNMIBJN;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1D00", Offset = "0x7FF1100", VA = "0x187FF1D00")]
	public NNADKMGKGEG(OCGCKBCELPI PBMMFMFBCHJ, IALLACCJCIL KAAHCKCLMCG, EJKECINGNLN LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1200", Offset = "0x7FF0600", VA = "0x187FF1200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1010", Offset = "0x7FF0410", VA = "0x187FF1010")]
	public void ANDHGIFFKIK(IEnumerable<string> MBIJNBNAMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1770", Offset = "0x7FF0B70", VA = "0x187FF1770")]
	private void LIFJKEAFJMD(ConversationItemDTO GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7FF12E0", Offset = "0x7FF06E0", VA = "0x187FF12E0")]
	private void GDAOOBKHPNM(IEnumerable<string?> LJHPEKFFGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1B50", Offset = "0x7FF0F50", VA = "0x187FF1B50")]
	[AsyncStateMachine(typeof(OLMHLLDMLEH))]
	private Task NHJJNLHDILN(Queue<string> CFNBPDBGKJF, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class BKHIGNNBAAP : IALLACCJCIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal class CIGAGAPGCCH
	{
		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public ConversationItemDTO FMHPKKMCCLF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool KNCOKDPHBEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xA7DA60", Offset = "0xA7CE60", VA = "0x180A7DA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x159C490", Offset = "0x159B890", VA = "0x18159C490")]
		public CIGAGAPGCCH(ConversationItemDTO GBDPBDHPLOA, bool DCMEPBFBLBJ = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class AMFDNEHFJAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AMFDNEHFJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FF51F0", Offset = "0x7FF45F0", VA = "0x187FF51F0")]
		internal bool LAGONECEHPN(CIGAGAPGCCH c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7FF51B0", Offset = "0x7FF45B0", VA = "0x187FF51B0")]
		internal bool KGNIHICDBFA(CIGAGAPGCCH c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class KHHFKBNOOKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KHHFKBNOOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5240", Offset = "0x7FF4640", VA = "0x187FF5240")]
		internal bool HAJMJKPPDLD(CIGAGAPGCCH c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class AHKLPCPOJEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AHKLPCPOJEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7FF51B0", Offset = "0x7FF45B0", VA = "0x187FF51B0")]
		internal bool KHHDNMLIIDM(CIGAGAPGCCH c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class DLKBIEPIFPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DLKBIEPIFPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5350", Offset = "0x7FF4750", VA = "0x187FF5350")]
		internal bool FLIFHHAIMCA(CIGAGAPGCCH c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class PCIMILGKAKI : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public ConversationItemDTO <>3__item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public BKHIGNNBAAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private DLKBIEPIFPB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private List<ConversationItemContentDTO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public PCIMILGKAKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7FF9870", Offset = "0x7FF8C70", VA = "0x187FF9870", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7FF8F70", Offset = "0x7FF8370", VA = "0x187FF8F70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7FF8F20", Offset = "0x7FF8320", VA = "0x187FF8F20")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7FF9820", Offset = "0x7FF8C20", VA = "0x187FF9820", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7FF9760", Offset = "0x7FF8B60", VA = "0x187FF9760", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF9760", Offset = "0x7FF8B60", VA = "0x187FF9760", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CKHLHEADHEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public string messageId;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CKHLHEADHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x2197420", Offset = "0x2196820", VA = "0x182197420")]
		internal bool CAONOAAJMAH(ConversationItemDTO m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly FPCIIJEMHFB IMLCHPJGPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly DEEFOEALJCI ODPDHOCHBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly ACAHCPOBLDI GNKFBCEMIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly List<CIGAGAPGCCH> IDADLBNGDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly List<string> OMKOKBMMKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly List<ConversationItemDTO> FEPCBKILMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private string? FMALEAJMAOF;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BBKKNBJGBDM<ConversationItemDTO> LIFJKEAFJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public IReadOnlyList<string> NIKIDGNAFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public IReadOnlyList<ConversationItemDTO> NFNEKIILOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC840", Offset = "0x7FDBC40", VA = "0x187FDC840")]
	public BKHIGNNBAAP(FPCIIJEMHFB PBMMFMFBCHJ, IReadOnlyCollection<string> BCIJNCLIBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB910", Offset = "0x7FDAD10", VA = "0x187FDB910", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBB90", Offset = "0x7FDAF90", VA = "0x187FDBB90")]
	public List<string> FEOLJFIHGDJ(bool APGOOJDNKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC030", Offset = "0x7FDB430", VA = "0x187FDC030")]
	private void JOOOHELNDFB(ConversationItemCreatedEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBD80", Offset = "0x7FDB180", VA = "0x187FDBD80")]
	private void JIFBCIKJBGG(ResponseEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC5F0", Offset = "0x7FDB9F0", VA = "0x187FDC5F0")]
	private void LHDCFCKFALD(ConversationItemInputAudioTranscriptionCompletedEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB6D0", Offset = "0x7FDAAD0", VA = "0x187FDB6D0")]
	private void DGDIOOBGBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC7B0", Offset = "0x7FDBBB0", VA = "0x187FDC7B0", Slot = "6")]
	[IteratorStateMachine(typeof(PCIMILGKAKI))]
	public IEnumerable<string> OFANBCBOAND(ConversationItemDTO GBDPBDHPLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC510", Offset = "0x7FDB910", VA = "0x187FDC510", Slot = "7")]
	public void KHPKMNDACHA(string CFJNLEKPCLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class LOEGMCKICHH : MJMHKNDDEIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct FHDBHMJKEPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public IReadOnlyCollection<string> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public LOEGMCKICHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7FF6FF0", Offset = "0x7FF63F0", VA = "0x187FF6FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7FF7480", Offset = "0x7FF6880", VA = "0x187FF7480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly FPCIIJEMHFB IMLCHPJGPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly string FHEPBBECJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int LHAPENLKDBG;

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4880", Offset = "0x5EB3C80", VA = "0x185EB4880")]
	public LOEGMCKICHH(FPCIIJEMHFB PBMMFMFBCHJ, string NKPDFBMDMEH, int GENBAMOLMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7D10", Offset = "0x7FF7110", VA = "0x187FF7D10", Slot = "4")]
	[AsyncStateMachine(typeof(FHDBHMJKEPP))]
	public Task ENKEIEOAHJE(IReadOnlyCollection<string> BHIKCLKBIMF, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DJGEIHKFNDC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public Type LJJNIGDJJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAD90C0", Offset = "0xAD84C0", VA = "0x180AD90C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public string LMHFLPABEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA7C860", Offset = "0xA7BC60", VA = "0x180A7C860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5280", Offset = "0x7FF4680", VA = "0x187FF5280")]
	public DJGEIHKFNDC(Type LANHKNCBBBE, string GILAAHLNHOK, Exception DNFKLOFLLMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class AFKDNJAIDLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct NJLADNHKLHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public string args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AFKDNJAIDLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private Dictionary<EHOAMMODIIK, LCNBGAMGFGK?>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private TaskAwaiter<string?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7FF8180", Offset = "0x7FF7580", VA = "0x187FF8180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7FF8EB0", Offset = "0x7FF82B0", VA = "0x187FF8EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static readonly AKNCNLDICPO GJFBEGANDPI;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly List<IOJPNADJPGK> CCBBMEBJHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private readonly Dictionary<EHOAMMODIIK, LCNBGAMGFGK?> NAONAALFLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly NIFKGGOBKPN<EHOAMMODIIK, LCNBGAMGFGK?> AGOMGGDNGEG;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4D90", Offset = "0x7FF4190", VA = "0x187FF4D90")]
	static AFKDNJAIDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7FF40A0", Offset = "0x7FF34A0", VA = "0x187FF40A0")]
	public void AAKCNPEHMNC(params EHOAMMODIIK[] LKKMFGEONJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7FF49E0", Offset = "0x7FF3DE0", VA = "0x187FF49E0")]
	public bool CBEKMNDBEDN(EHOAMMODIIK FCOIPHLAODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4360", Offset = "0x7FF3760", VA = "0x187FF4360")]
	public void AJDGAOLEOMM(params EHOAMMODIIK[] LKKMFGEONJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4950", Offset = "0x7FF3D50", VA = "0x187FF4950")]
	public void CAOAALPDLLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4A40", Offset = "0x7FF3E40", VA = "0x187FF4A40")]
	[AsyncStateMachine(typeof(NJLADNHKLHG))]
	public Task<string> KNBCFDCCNOB(string HDNPPEBJPAE, string PHAOHJHLKGO, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4BA0", Offset = "0x7FF3FA0", VA = "0x187FF4BA0")]
	public List<ToolDTO> OGPICMCECFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4680", Offset = "0x7FF3A80", VA = "0x187FF4680")]
	private static LCNBGAMGFGK AOFAKJECGGF(EHOAMMODIIK FCOIPHLAODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF50D0", Offset = "0x7FF44D0", VA = "0x187FF50D0")]
	public AFKDNJAIDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class GLIFBNOHMIN
{
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static JsonSerializerSettings CIANENCEIAH;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7720", Offset = "0x7FF6B20", VA = "0x187FF7720")]
	static GLIFBNOHMIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class ECIFOOPNLJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private class LKDEKECDAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public ConversationItemDTO FMHPKKMCCLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool KNCOKDPHBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xA7DA60", Offset = "0xA7CE60", VA = "0x180A7DA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x159C490", Offset = "0x159B890", VA = "0x18159C490")]
		public LKDEKECDAMJ(ConversationItemDTO GBDPBDHPLOA, bool DCMEPBFBLBJ = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private abstract class IPMICGCFEJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private readonly StringBuilder LHJEDJIFOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private readonly TimeSpan LJEGFGKEMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private DateTime HPMMBKJGBCC;

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7FF7AF0", Offset = "0x7FF6EF0", VA = "0x187FF7AF0")]
		public IPMICGCFEJE(TimeSpan EAMMKNHEPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7FF7960", Offset = "0x7FF6D60", VA = "0x187FF7960")]
		public void LHKBFFKJEAK(string OJBLIOIMALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7FF79B0", Offset = "0x7FF6DB0", VA = "0x187FF79B0")]
		public void MDMMCDOMCJA(bool KBIBIFOFAKG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void CNGONDLHGIE(string CAIIFLDFGNH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class JOGOLIOCOAD : IPMICGCFEJE
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static readonly TimeSpan OIFCFIKANPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private readonly string ODHIAJJNKFB;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7FF7C80", Offset = "0x7FF7080", VA = "0x187FF7C80")]
		public JOGOLIOCOAD(string NFABEECHIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF7BA0", Offset = "0x7FF6FA0", VA = "0x187FF7BA0", Slot = "4")]
		protected override void CNGONDLHGIE(string CAIIFLDFGNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class NAMODMNDPPO : IPMICGCFEJE
	{
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private static readonly TimeSpan OIFCFIKANPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private readonly GBDCMLADEHH IJPBGFIHGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private readonly DEEFOEALJCI ODPDHOCHBOJ;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7FF80E0", Offset = "0x7FF74E0", VA = "0x187FF80E0")]
		public NAMODMNDPPO(GBDCMLADEHH ANCACDKGMMA, DEEFOEALJCI OABFDOHIJLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7FF7E30", Offset = "0x7FF7230", VA = "0x187FF7E30", Slot = "4")]
		protected override void CNGONDLHGIE(string CAIIFLDFGNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class FGBNJBKIKOA : IPMICGCFEJE
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static readonly TimeSpan OIFCFIKANPM;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7FF6F90", Offset = "0x7FF6390", VA = "0x187FF6F90")]
		public FGBNJBKIKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7FF6EA0", Offset = "0x7FF62A0", VA = "0x187FF6EA0", Slot = "4")]
		protected override void CNGONDLHGIE(string CAIIFLDFGNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class OBJNAKDLGMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OBJNAKDLGMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7FF51B0", Offset = "0x7FF45B0", VA = "0x187FF51B0")]
		internal bool LAGONECEHPN(LKDEKECDAMJ c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class CBDMOOPFPFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CBDMOOPFPFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5240", Offset = "0x7FF4640", VA = "0x187FF5240")]
		internal bool HAJMJKPPDLD(LKDEKECDAMJ c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class CAGNIIIJLDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CAGNIIIJLDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF51B0", Offset = "0x7FF45B0", VA = "0x187FF51B0")]
		internal bool KHHDNMLIIDM(LKDEKECDAMJ c)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct FJDDCLDKONJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public ECIFOOPNLJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x7FF74E0", Offset = "0x7FF68E0", VA = "0x187FF74E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7FF76C0", Offset = "0x7FF6AC0", VA = "0x187FF76C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly TimeSpan OIFCFIKANPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private readonly FPCIIJEMHFB IMLCHPJGPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly DEEFOEALJCI ODPDHOCHBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private readonly GBDCMLADEHH IJPBGFIHGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private readonly ACAHCPOBLDI GNKFBCEMIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly List<IPMICGCFEJE> IJPMHDBDJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly List<LKDEKECDAMJ> IDADLBNGDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private string? FMALEAJMAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private CancellationTokenSource? KGMPCCKCING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private Task? HCIIAGEIHFB;

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6770", Offset = "0x7FF5B70", VA = "0x187FF6770")]
	public ECIFOOPNLJL(FPCIIJEMHFB PBMMFMFBCHJ, GBDCMLADEHH ANCACDKGMMA, bool JHBOKPMMPND, bool GLANLBGAKBP, string? GPFFDBDJDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7FF54C0", Offset = "0x7FF48C0", VA = "0x187FF54C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5E00", Offset = "0x7FF5200", VA = "0x187FF5E00")]
	private void JOOOHELNDFB(ConversationItemCreatedEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5B50", Offset = "0x7FF4F50", VA = "0x187FF5B50")]
	private void JIFBCIKJBGG(ResponseEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6270", Offset = "0x7FF5670", VA = "0x187FF6270")]
	private void LHDCFCKFALD(ConversationItemInputAudioTranscriptionCompletedEventDTO BOBEBPGBGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF53A0", Offset = "0x7FF47A0", VA = "0x187FF53A0")]
	private void AIANPCEHMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF57D0", Offset = "0x7FF4BD0", VA = "0x187FF57D0")]
	private void EBJPPMPNLDJ(ConversationItemDTO GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6430", Offset = "0x7FF5830", VA = "0x187FF6430")]
	private void LHKBFFKJEAK(string OJBLIOIMALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5A60", Offset = "0x7FF4E60", VA = "0x187FF5A60")]
	[AsyncStateMachine(typeof(FJDDCLDKONJ))]
	private Task JCNGHOPCJPD(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF65E0", Offset = "0x7FF59E0", VA = "0x187FF65E0")]
	private void MFMEFCODOOF(bool KBIBIFOFAKG = false)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class FCNBKKGCIKA
{
	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FCNBKKGCIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x745EEE0", Offset = "0x745E2E0", VA = "0x18745EEE0")]
	public static string AMPEGALKAAA(byte[] EMJFEBGJAHC, byte[] EODODMDCONG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
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
