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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x804E120", Offset = "0x804CB20", VA = "0x18804E120")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_AI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x804B9A0", Offset = "0x804A3A0", VA = "0x18804B9A0", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class KDFCLIMNGPF : IDisposable, JMCNLKGCLBF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct FEBEPPCNBPD : IAsyncStateMachine
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
		public KDFCLIMNGPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8046020", Offset = "0x8044A20", VA = "0x188046020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct LPCDDJHGHLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KDFCLIMNGPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x804B690", Offset = "0x804A090", VA = "0x18804B690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x804B930", Offset = "0x804A330", VA = "0x18804B930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected static readonly MEBJEIOEDLD GCLDEHJKFHJ;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly TimeSpan IKBLIELJGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource NDMBBMONPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly JLIDFJPMMHL GGBCONJIEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly long LIAONHOEBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly long ICOGDMGILLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private decimal FLDOBJINAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Guid GMDJCNAFHNF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public decimal EGBHHKGJBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1275E70", Offset = "0x1274870", VA = "0x181275E70")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F28A40", Offset = "0x7F27440", VA = "0x187F28A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x804A8C0", Offset = "0x80492C0", VA = "0x18804A8C0")]
	public KDFCLIMNGPF(JLIDFJPMMHL PKOMFNFJPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x804A640", Offset = "0x8049040", VA = "0x18804A640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x804A740", Offset = "0x8049140", VA = "0x18804A740")]
	[AsyncStateMachine(typeof(FEBEPPCNBPD))]
	private void JGJDFKNDNOB(CancellationToken OMJKEHOJJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x804A530", Offset = "0x8048F30", VA = "0x18804A530")]
	[AsyncStateMachine(typeof(LPCDDJHGHLN))]
	private Task<bool> AIOELEOGKKO(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task<bool> TrySyncLatestCostInfo(JLIDFJPMMHL PKOMFNFJPHJ, Guid CMKNICHBINH, long DKMPIOFKFMN, long MNAMJIAHNIM, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x804A6B0", Offset = "0x80490B0", VA = "0x18804A6B0", Slot = "5")]
	public void EGENEMIAPAL(decimal PCALEEDDNHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum OHIHHIFOPNN
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
public class GCDMAJCMLBF : IEquatable<GCDMAJCMLBF>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected virtual Type NLBACNKMDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8046890", Offset = "0x8045290", VA = "0x188046890", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public OHIHHIFOPNN MMPEDFAPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(OHIHHIFOPNN);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool PPODANMJDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xC33050", Offset = "0xC31A50", VA = "0x180C33050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xBDAFA0", Offset = "0xBD99A0", VA = "0x180BDAFA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8046CF0", Offset = "0x80456F0", VA = "0x188046CF0")]
	public GCDMAJCMLBF(OHIHHIFOPNN MMPEDFAPIKH, string FAHMGKIDCFD, string LHKEDLABPNK = "", bool PPODANMJDCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8046B80", Offset = "0x8045580", VA = "0x188046B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8046450", Offset = "0x8044E50", VA = "0x188046450", Slot = "6")]
	protected virtual bool AICAJEMLONH(StringBuilder EBBBAHAEGHJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1269220", Offset = "0x1267C20", VA = "0x181269220")]
	public static bool CNNLEBNJPBE(GCDMAJCMLBF? KMGJNLBHING, GCDMAJCMLBF? ELFIMJDHHOB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x12695F0", Offset = "0x1267FF0", VA = "0x1812695F0")]
	public static bool JJNADAGGMDE(GCDMAJCMLBF? KMGJNLBHING, GCDMAJCMLBF? ELFIMJDHHOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8046940", Offset = "0x8045340", VA = "0x188046940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8046800", Offset = "0x8045200", VA = "0x188046800", Slot = "0")]
	public override bool Equals(object? CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8046640", Offset = "0x8045040", VA = "0x188046640", Slot = "7")]
	public virtual bool Equals(GCDMAJCMLBF? EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8046AF0", Offset = "0x80454F0", VA = "0x188046AF0", Slot = "8")]
	public virtual GCDMAJCMLBF HAFEIFHMPFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8046C90", Offset = "0x8045690", VA = "0x188046C90")]
	protected GCDMAJCMLBF(GCDMAJCMLBF HADHNPCHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80468F0", Offset = "0x80452F0", VA = "0x1880468F0")]
	public void GNAIPCHGPNM([Out] OHIHHIFOPNN MMPEDFAPIKH, [Out] string FAHMGKIDCFD, [Out] string LHKEDLABPNK, [Out] bool PPODANMJDCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FDKPMALMEND : IEquatable<FDKPMALMEND>
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected virtual Type NLBACNKMDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8045500", Offset = "0x8043F00", VA = "0x188045500", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JToken FIOAMKACPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public GCDMAJCMLBF LAANJLKDIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1258C50", Offset = "0x1257650", VA = "0x181258C50")]
	public FDKPMALMEND(JToken FIOAMKACPAK, GCDMAJCMLBF LAANJLKDIIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8045C30", Offset = "0x8044630", VA = "0x188045C30")]
	public static int KNCCAEBIBJO(FDKPMALMEND PDKJBMPOMNC)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8045A60", Offset = "0x8044460", VA = "0x188045A60")]
	public static float KNCCAEBIBJO(FDKPMALMEND PDKJBMPOMNC)
	{
		return default(float);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8045CF0", Offset = "0x80446F0", VA = "0x188045CF0")]
	public static bool KNCCAEBIBJO(FDKPMALMEND PDKJBMPOMNC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8045750", Offset = "0x8044150", VA = "0x188045750")]
	public static string KNCCAEBIBJO(FDKPMALMEND PDKJBMPOMNC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8045DB0", Offset = "0x80447B0", VA = "0x188045DB0")]
	public static int[] KNCCAEBIBJO(FDKPMALMEND PDKJBMPOMNC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8045B20", Offset = "0x8044520", VA = "0x188045B20")]
	public static float[] KNCCAEBIBJO(FDKPMALMEND PDKJBMPOMNC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8045950", Offset = "0x8044350", VA = "0x188045950")]
	public static bool[] KNCCAEBIBJO(FDKPMALMEND PDKJBMPOMNC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8045840", Offset = "0x8044240", VA = "0x188045840")]
	public static string[] KNCCAEBIBJO(FDKPMALMEND PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8045EC0", Offset = "0x80448C0", VA = "0x188045EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8045240", Offset = "0x8043C40", VA = "0x188045240", Slot = "6")]
	protected virtual bool AICAJEMLONH(StringBuilder EBBBAHAEGHJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1269220", Offset = "0x1267C20", VA = "0x181269220")]
	public static bool CNNLEBNJPBE(FDKPMALMEND? KMGJNLBHING, FDKPMALMEND? ELFIMJDHHOB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x12695F0", Offset = "0x1267FF0", VA = "0x1812695F0")]
	public static bool JJNADAGGMDE(FDKPMALMEND? KMGJNLBHING, FDKPMALMEND? ELFIMJDHHOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x80455A0", Offset = "0x8043FA0", VA = "0x1880455A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8045470", Offset = "0x8043E70", VA = "0x188045470", Slot = "0")]
	public override bool Equals(object? CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8045330", Offset = "0x8043D30", VA = "0x188045330", Slot = "7")]
	public virtual bool Equals(FDKPMALMEND? EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x80456C0", Offset = "0x80440C0", VA = "0x1880456C0", Slot = "8")]
	public virtual FDKPMALMEND HAFEIFHMPFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8045FD0", Offset = "0x80449D0", VA = "0x188045FD0")]
	protected FDKPMALMEND(FDKPMALMEND HADHNPCHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8045560", Offset = "0x8043F60", VA = "0x188045560")]
	public void GNAIPCHGPNM([Out] JToken FIOAMKACPAK, [Out] GCDMAJCMLBF LAANJLKDIIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class CJBLFPBNGMJ : IMKMKDAKDOO
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string MDPBPDMADDA = "Open AI Realtime API";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string MBLAFGPPPEC = "endpoint";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly string HAJHLFBDHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly List<Func<LOAIKPIGKFH.NNEPFOADFBJ, LOAIKPIGKFH.NNEPFOADFBJ>> LFPCMKKNJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly List<Func<LOAIKPIGKFH.NNEPFOADFBJ, LOAIKPIGKFH.NNEPFOADFBJ>> COHJOOIPPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly DOMAHLEMAHP HEEAKCBLEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly JMCNLKGCLBF CCAMAPLCFNP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public AGIMBPGLLKK? JHJFEAPBHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string NAMJGEMGDHL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GJDJBEPEOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x803CCC0", Offset = "0x803B6C0", VA = "0x18803CCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x803EDE0", Offset = "0x803D7E0", VA = "0x18803EDE0")]
	public CJBLFPBNGMJ(DOMAHLEMAHP CAPLINHHINP, JMCNLKGCLBF DPDHJNJMOMI, string AEFNNOFHKAH, string PKPEINDFGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x803D860", Offset = "0x803C260", VA = "0x18803D860")]
	private static LOAIKPIGKFH.NNEPFOADFBJ IIBBBDBONPK(string KGEPDCLGMOA, string APCOHHNFJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x803DE60", Offset = "0x803C860", VA = "0x18803DE60")]
	private LOAIKPIGKFH.NNEPFOADFBJ JDBFBMFNOGO(string KGEPDCLGMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x803CDA0", Offset = "0x803B7A0", VA = "0x18803CDA0", Slot = "8")]
	public void HMMHBFKCBDN(string? NECAJFCJIIO, string EHEGBKOFLNN, string CEHLGOHBIOI, float PKDPDIAMEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x803EB60", Offset = "0x803D560", VA = "0x18803EB60", Slot = "10")]
	public void MLAAECPPKIP(string? NECAJFCJIIO, ErrorEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x803D080", Offset = "0x803BA80", VA = "0x18803D080", Slot = "11")]
	public void HOGAGNHABKN(string? NECAJFCJIIO, decimal PKKGIIIEFOF, string HCLPHJDKMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x803CA90", Offset = "0x803B490", VA = "0x18803CA90")]
	public static void ACDPCHDELHK(JMCNLKGCLBF DPDHJNJMOMI, string OLLJNINDADG, string APCOHHNFJKK, decimal PKKGIIIEFOF, string HCLPHJDKMCA, params (string key, string val)[] ACDJLJKOBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x803D8F0", Offset = "0x803C2F0", VA = "0x18803D8F0", Slot = "12")]
	public void JCAICFCOAJP(string? NECAJFCJIIO, ConversationItemDTO HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x803D2E0", Offset = "0x803BCE0", VA = "0x18803D2E0", Slot = "15")]
	public void IEHNDNGAMJL(string? NECAJFCJIIO, ResponseEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x803E790", Offset = "0x803D190", VA = "0x18803E790")]
	private (decimal?, string, string, string, string, string) KONLEIKKIJH(ResponseEventDTO CLHICJCGIEH)
	{
		return default((decimal?, string, string, string, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x803E010", Offset = "0x803CA10", VA = "0x18803E010", Slot = "13")]
	public void KGJENJGHNKC(string? NECAJFCJIIO, ResponseEventDTO CLHICJCGIEH, float? CMKHEOIHCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x803CD40", Offset = "0x803B740", VA = "0x18803CD40", Slot = "14")]
	public void ENFEPCNKFDH(Func<LOAIKPIGKFH.NNEPFOADFBJ, LOAIKPIGKFH.NNEPFOADFBJ> PMOFPHDDNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x803ED80", Offset = "0x803D780", VA = "0x18803ED80", Slot = "9")]
	public void ODKJANAABCL(Func<LOAIKPIGKFH.NNEPFOADFBJ, LOAIKPIGKFH.NNEPFOADFBJ> PMOFPHDDNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x803DEA0", Offset = "0x803C8A0", VA = "0x18803DEA0", Slot = "16")]
	public void JPPAAGFMECN(string? NECAJFCJIIO, string HDDLNGLMMKN, string? HLJPNDHEBEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class PKDBAGIHNJM : IMKMKDAKDOO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public AGIMBPGLLKK? JHJFEAPBHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public decimal EGBHHKGJBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8054FD0", Offset = "0x80539D0", VA = "0x188054FD0")]
		get
		{
			return default(decimal);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string NAMJGEMGDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DOMAHLEMAHP? IAFFHBBEBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
	public void HMMHBFKCBDN(string? NECAJFCJIIO, string EHEGBKOFLNN, string CEHLGOHBIOI, float PKDPDIAMEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "9")]
	public void ODKJANAABCL(Func<LOAIKPIGKFH.NNEPFOADFBJ, LOAIKPIGKFH.NNEPFOADFBJ> PMOFPHDDNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "10")]
	public void MLAAECPPKIP(string? NECAJFCJIIO, ErrorEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "11")]
	public void HOGAGNHABKN(string? NECAJFCJIIO, decimal PKKGIIIEFOF, string HCLPHJDKMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "12")]
	public void JCAICFCOAJP(string? NECAJFCJIIO, ConversationItemDTO HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "15")]
	public void IEHNDNGAMJL(string? NECAJFCJIIO, ResponseEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "13")]
	public void KGJENJGHNKC(string? NECAJFCJIIO, ResponseEventDTO CLHICJCGIEH, float? CMKHEOIHCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "14")]
	public void ENFEPCNKFDH(Func<LOAIKPIGKFH.NNEPFOADFBJ, LOAIKPIGKFH.NNEPFOADFBJ> PMOFPHDDNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "16")]
	public void JPPAAGFMECN(string? NECAJFCJIIO, string HDDLNGLMMKN, string? HLJPNDHEBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8055030", Offset = "0x8053A30", VA = "0x188055030")]
	public PKDBAGIHNJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class AHAEGLNGJGF : KDFCLIMNGPF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct IIILELFGDGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public JLIDFJPMMHL recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AHAEGLNGJGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid spendSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<GBAJHOFECNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x80489E0", Offset = "0x80473E0", VA = "0x1880489E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8048D60", Offset = "0x8047760", VA = "0x188048D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly string GAEHAIEDADH;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x803B430", Offset = "0x8039E30", VA = "0x18803B430")]
	public AHAEGLNGJGF(JLIDFJPMMHL PKOMFNFJPHJ, string HJHBKDMFDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x803B2D0", Offset = "0x8039CD0", VA = "0x18803B2D0", Slot = "6")]
	[AsyncStateMachine(typeof(IIILELFGDGO))]
	protected override Task<bool> TrySyncLatestCostInfo(JLIDFJPMMHL PKOMFNFJPHJ, Guid CMKNICHBINH, long DKMPIOFKFMN, long MNAMJIAHNIM, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KPJDKPBAAGN
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	ECMKKKEPCGP<ConversationItemDTO> MPCICOAOODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	IReadOnlyList<ConversationItemDTO> FHHNHPIGHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<string> GEHBJLKBMKL(ConversationItemDTO HNLFGCKBFGI);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MECHAJFIDKP(string MPOMJBFIAML);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IJFJPAOJGKG
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BOOMHAGBNEO(IReadOnlyCollection<string> HPDAGNJGMCO, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IOJHILLLLIM
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ToolDTO[] GMBILLHDAPH();

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> EIAGDJMNJGD(string BDEEHABLNHA, string GJFNBOHMEJF, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OANEFANIMLD
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DOMAHLEMAHP
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	const string NAKLMKOLNHN = "gpt-4o-mini-realtime-preview-2024-12-17";

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	const string DGBNHPOPFPC = "gpt-4o-mini-transcribe";

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	DBGGBEIHDDJ GLIJBHHJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AudioSource CPBHNJPBMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	KPJDKPBAAGN? LOABKLMFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IJFJPAOJGKG? HIBIOBGGBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string? OKBODONOABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BBMOIGJCNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BCIJCAKIBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool AAELDIAKFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OIKIFLPPAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool ABGJOHFNIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool APNCKPOPDBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool PPFEAFMHHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool EAFEAEMLEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JAHOACAEKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool MLFIJJIMHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool IHIKOLNNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool FINCKFJPLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ECMKKKEPCGP<bool> KJPNPFBBNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	HPDJJKCNBLF ONEEKABFGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HPDJJKCNBLF CGKGCEHGGOK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NCMMNGPOLDF<string, string> LBDLCLLBDHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HPDJJKCNBLF PLIBPIDCGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HPDJJKCNBLF NFNELCDJKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	ECMKKKEPCGP<List<ToolDTO>> LPMPEOGAKLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	HPDJJKCNBLF PFAMGLJKMMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	NCMMNGPOLDF<float, string> FKOOLLJCNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	ECMKKKEPCGP<string> GILLFJHLCIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string NAMJGEMGDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool ILNAKOIPHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task IBAOFJGDOEH(string ODNCJIJIJFK, VoiceOption HIHLOKPILIN, float PKDPDIAMEDL = 0.6f, string COHLGKEHKLI = "gpt-4o-mini-realtime-preview-2024-12-17", string CEHLGOHBIOI = "gpt-4o-mini-transcribe", [Optional] IReadOnlyCollection<string>? MMFFLBLABLN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FGLGBKHFALG();

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task HDOLJIDELMO(string ODNCJIJIJFK, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task PFFPALAKEFN(float PKDPDIAMEDL, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task FHPDBHACPKM(bool DKBBOMHPGKC, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GBAJPDJPNAH(params OANEFANIMLD[] GFGMMGFEJFD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool MENAIDAGDEB(OANEFANIMLD OCNMJGBOEHK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void ADHNOMDKJJG(params OANEFANIMLD[] GFGMMGFEJFD);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void BDGPIBDMGHM(NJLNMLEFFEL DHNMCOFINFM, bool NGBIJOOMBII = false);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void GDLKGKOBANG(NJLNMLEFFEL DHNMCOFINFM, bool NGBIJOOMBII = false);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void IPNICELLLEE(NJLNMLEFFEL DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void HPEPGEOKNJL(NJLNMLEFFEL DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void CNCBOBCEHIJ(decimal PKKGIIIEFOF, string HCLPHJDKMCA);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task JLNCBBMOOPE(byte[] IFFPBJEFLDC, string? COECCLMOEJC, [Optional] string? FBBFHAHHIIP, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task JLNCBBMOOPE(string ONGDPODJNBL, [Optional] string? FBBFHAHHIIP, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task ACPPGJBMMAH(string ONGDPODJNBL, [Optional] string? FBBFHAHHIIP, [Optional] string? BHMIKOGCGFK, bool IIIHGLLLIHA = false, bool DKNCGGJGONO = false, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task MECHAJFIDKP(string FBBFHAHHIIP, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<ResponseDTO> DJEFAFAAGEJ(bool AEIAKGHLEMI = true, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<string> LMMNDJHPIFH(string ODNCJIJIJFK, [Optional] IReadOnlyList<ConversationItemDTO>? HPDAGNJGMCO, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<TOutput> LMMNDJHPIFH<TOutput>(string ODNCJIJIJFK, [Optional] IReadOnlyList<ConversationItemDTO>? HPDAGNJGMCO, [Optional] CancellationToken OMJKEHOJJFF) where TOutput : class;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task<List<FDKPMALMEND>> LMMNDJHPIFH(string ODNCJIJIJFK, IReadOnlyList<ConversationItemDTO>? HPDAGNJGMCO, IReadOnlyList<GCDMAJCMLBF> PKGKEPGONDN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool DGGMIKPKILF(string MPOMJBFIAML);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool ABJBOMJLAOD(string MPOMJBFIAML);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool EGLMAEIHFIE(string IHJOAODOKIB);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task HAIJGCPGANO(bool AGAJFKOHJGL, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "55")]
	IReadOnlyCollection<string> MKKLPAMDEPK();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IMKMKDAKDOO
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	AGIMBPGLLKK? JHJFEAPBHPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string NAMJGEMGDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HMMHBFKCBDN(string? NECAJFCJIIO, string EHEGBKOFLNN, string CEHLGOHBIOI, float PKDPDIAMEDL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ODKJANAABCL(Func<LOAIKPIGKFH.NNEPFOADFBJ, LOAIKPIGKFH.NNEPFOADFBJ> PMOFPHDDNJA);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MLAAECPPKIP(string? NECAJFCJIIO, ErrorEventDTO CLHICJCGIEH);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HOGAGNHABKN(string? NECAJFCJIIO, decimal PKKGIIIEFOF, string HCLPHJDKMCA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JCAICFCOAJP(string? NECAJFCJIIO, ConversationItemDTO HNLFGCKBFGI);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KGJENJGHNKC(string? NECAJFCJIIO, ResponseEventDTO CLHICJCGIEH, float? CMKHEOIHCOH);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ENFEPCNKFDH(Func<LOAIKPIGKFH.NNEPFOADFBJ, LOAIKPIGKFH.NNEPFOADFBJ> PMOFPHDDNJA);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IEHNDNGAMJL(string? NECAJFCJIIO, ResponseEventDTO CLHICJCGIEH);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JPPAAGFMECN(string? NECAJFCJIIO, string HDDLNGLMMKN, string? HLJPNDHEBEG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PFGEPOEKIEP
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void KPMFKLGFFBJ(ReadOnlySpan<float> HOJPNGNMCGP, int FFFBBGDMCAA, int OBDDMOILNLM);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ENCMDLNKPEJ(KPMFKLGFFBJ HKCOJOMINBP);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGFOEJAJIJD(KPMFKLGFFBJ HKCOJOMINBP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface JMCNLKGCLBF
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGENEMIAPAL(decimal PCALEEDDNHI);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class IOJENEJGBHC
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private enum MFLOHJDABFM
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		array,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		boolean,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		@enum,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		integer,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		number,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		@object,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		@string
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ConcurrentDictionary<Type, JsonSchema> IOILODMIMIG;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly Type[] FAIFIAJNJFN;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly Type[] FBPDDOAMMMA;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3CD9700", Offset = "0x3CD8100", VA = "0x183CD9700")]
	public static JsonSchema DHBICMHDGKM<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8048FD0", Offset = "0x80479D0", VA = "0x188048FD0")]
	public static JsonSchema KCKGOFKECEF(IReadOnlyList<GCDMAJCMLBF> GACFFBLMJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x80498B0", Offset = "0x80482B0", VA = "0x1880498B0")]
	private static JsonSchema LOJBLKNEHJL(Type AEOGKDPPBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8049320", Offset = "0x8047D20", VA = "0x188049320")]
	private static JsonSchema KGABAGBPHDI(Type AEOGKDPPBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8048DD0", Offset = "0x80477D0", VA = "0x188048DD0")]
	private static MFLOHJDABFM CDJPCBDPGGI(Type AEOGKDPPBBE, [Out] Type? LANAPDLOODN)
	{
		return default(MFLOHJDABFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8049D00", Offset = "0x8048700", VA = "0x188049D00")]
	private static bool OHBHDMIIFDN(Type AEOGKDPPBBE, [Out][MaybeNullWhen(false)] Type FANAAMLKIBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LKHIIFPKLEA : OANEFANIMLD, IOJHILLLLIM
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<string> FODCDOJIPBN(List<FDKPMALMEND> JEAMHIFDMBF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct LICKIEGOCLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public string methodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public LKHIIFPKLEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public string methodArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x804ACC0", Offset = "0x80496C0", VA = "0x18804ACC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x804B360", Offset = "0x8049D60", VA = "0x18804B360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly string GJENGPALBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly string CKINOCDNJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly IReadOnlyList<GCDMAJCMLBF> JFJPACIDEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly FODCDOJIPBN AGNKALAPDFJ;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x10D4760", Offset = "0x10D3160", VA = "0x1810D4760")]
	public LKHIIFPKLEA(string FLBFBHGDBLM, string IGEOMPONAKK, IReadOnlyList<GCDMAJCMLBF> GACFFBLMJOF, FODCDOJIPBN LCJFNEJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x804B510", Offset = "0x8049F10", VA = "0x18804B510", Slot = "4")]
	private ToolDTO[] GHPINFAFNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x804B3D0", Offset = "0x8049DD0", VA = "0x18804B3D0", Slot = "5")]
	[AsyncStateMachine(typeof(LICKIEGOCLO))]
	private Task<string> EBIKLOLBPKN(string BDEEHABLNHA, string GJFNBOHMEJF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class OFHMEHFCCLB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public OFHMEHFCCLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class MFDCGGFPMJF : Exception, OPAFBDPGLHE
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string INLFNNGFCFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4938ED0", Offset = "0x49378D0", VA = "0x184938ED0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x804BAB0", Offset = "0x804A4B0", VA = "0x18804BAB0")]
	public MFDCGGFPMJF(string GLFKOPKIFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class PFHEOONACEP : DOMAHLEMAHP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private enum CKMCAFFKBGA
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		NotConnected,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		Connected
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct DGOPKCGBFLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int? reconnectAttempt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private CancellationTokenSource <cts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private CancellationToken <originalCancellationToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private IDisposable <combinedTokenDisposer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string <instructions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private float <temperature>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<DBGGBEIHDDJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<bool> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8041970", Offset = "0x8040370", VA = "0x188041970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8043D60", Offset = "0x8042760", VA = "0x188043D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct PFHACJCLENC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public bool keepConversationHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x804F690", Offset = "0x804E090", VA = "0x18804F690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x804F8A0", Offset = "0x804E2A0", VA = "0x18804F8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct BJFDMBLIKMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x803C4B0", Offset = "0x803AEB0", VA = "0x18803C4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x803C6E0", Offset = "0x803B0E0", VA = "0x18803C6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct DMHELGJILFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public float temperature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x80446A0", Offset = "0x80430A0", VA = "0x1880446A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x80448B0", Offset = "0x80432B0", VA = "0x1880448B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct HPOKINHBCCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8047F60", Offset = "0x8046960", VA = "0x188047F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8048170", Offset = "0x8046B70", VA = "0x188048170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct PJOAGFDDPIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8054C70", Offset = "0x8053670", VA = "0x188054C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8054F70", Offset = "0x8053970", VA = "0x188054F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NJFCLBDBJEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public byte[] pcmAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public string transcript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x804CA50", Offset = "0x804B450", VA = "0x18804CA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x804CED0", Offset = "0x804B8D0", VA = "0x18804CED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct FBOJOFJPGHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8044D70", Offset = "0x8043770", VA = "0x188044D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x80451E0", Offset = "0x8043BE0", VA = "0x1880451E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct GPPGEIFLPPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool suppressFromConversationLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public bool excludeFromConversationPruning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public string previousItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8046D40", Offset = "0x8045740", VA = "0x188046D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8047290", Offset = "0x8045C90", VA = "0x188047290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct CPAGFJELOLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public string convresationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x80408D0", Offset = "0x803F2D0", VA = "0x1880408D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8040E00", Offset = "0x803F800", VA = "0x188040E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class EIJPMCJDHHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public ResponseDTO response;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public EIJPMCJDHHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8044910", Offset = "0x8043310", VA = "0x188044910")]
		internal bool BMNOEHJHOML(OutputAudioBufferEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NANIFAGLNOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private EIJPMCJDHHM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool waitForAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TaskAwaiter<OutputAudioBufferEventDTO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x804C1B0", Offset = "0x804ABB0", VA = "0x18804C1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x804C9E0", Offset = "0x804B3E0", VA = "0x18804C9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct AILPIMBHPKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x803B4B0", Offset = "0x8039EB0", VA = "0x18803B4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x803BA60", Offset = "0x803A460", VA = "0x18803BA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct GMJGDPAPOHE<TOutput> : IAsyncStateMachine where TOutput : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder<TOutput> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4FB7A50", Offset = "0x4FB6450", VA = "0x184FB7A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4FB82B0", Offset = "0x4FB6CB0", VA = "0x184FB82B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct OILAHJLPDMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public AsyncTaskMethodBuilder<List<FDKPMALMEND>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public IReadOnlyList<GCDMAJCMLBF> responseArgSchemas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x804ED40", Offset = "0x804D740", VA = "0x18804ED40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x804F410", Offset = "0x804DE10", VA = "0x18804F410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class KPFIHPJFOMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public ResponseCreateEventDTO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public string id;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KPFIHPJFOMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x804AA80", Offset = "0x8049480", VA = "0x18804AA80")]
		internal void FGCOCOLDJFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x804AB80", Offset = "0x8049580", VA = "0x18804AB80")]
		internal bool LFFJADDBLHD(ResponseEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct DHFEGLPNFPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder<List<ConversationItemDTO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public JsonSchema responseSchema;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter<ResponseEventDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8043DC0", Offset = "0x80427C0", VA = "0x188043DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8044630", Offset = "0x8043030", VA = "0x188044630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct BDMJCOAGGJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public DateTime expirationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x803C060", Offset = "0x803AA60", VA = "0x18803C060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x803C450", Offset = "0x803AE50", VA = "0x18803C450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MHHNBNKCNCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private List<ToolDTO> <tools>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x804BD30", Offset = "0x804A730", VA = "0x18804BD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x804C150", Offset = "0x804AB50", VA = "0x18804C150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct ANOAIOHKDCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public ResponseEventDTO ev;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private string <responseId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x803BAD0", Offset = "0x803A4D0", VA = "0x18803BAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class FBBPMKJCIHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FBBPMKJCIHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8044C50", Offset = "0x8043650", VA = "0x188044C50")]
		internal Task OEBDAAOIDIA(ConversationItemDTO outputItem)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct IHOJOMMAMMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public ResponseDTO response;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private FBBPMKJCIHN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x80481D0", Offset = "0x8046BD0", VA = "0x1880481D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8048980", Offset = "0x8047380", VA = "0x188048980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BPAEOEFMIDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x803C740", Offset = "0x803B140", VA = "0x18803C740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x803C9E0", Offset = "0x803B3E0", VA = "0x18803C9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct COFGFKCEIFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8040500", Offset = "0x803EF00", VA = "0x188040500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8040860", Offset = "0x803F260", VA = "0x188040860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct OCDAGIKGHKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public PFHEOONACEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationToken <cancellationToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private DateTime? <startTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter<ResponseDTO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x804E1A0", Offset = "0x804CBA0", VA = "0x18804E1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x804ECD0", Offset = "0x804D6D0", VA = "0x18804ECD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly MEBJEIOEDLD GCLDEHJKFHJ;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private const ToolChoice KPODKDDBPME = ToolChoice.Auto;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private const float CHIPMLGMHGK = 0.01f;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly TimeSpan[] GHEKCJFGAFG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly TimeSpan KKEJCOHBNCF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly TimeSpan BJDKCOLPLPG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly TimeSpan OECABICJKCK;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly TimeSpan LBNBCJLPBKJ;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly TimeSpan MNGCHNOCPPK;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly TimeSpan EHPDKDPCGJI;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private const string KLCLELELDHB = "out-of-band-id";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly KPGHENBLKEI BEPAGMPHLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly PFGEPOEKIEP EGCLAKCMKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	protected readonly JLIDFJPMMHL GGBCONJIEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly FOFFCPFOEOI IDAIFKIKBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DKHEFBJMACG LAHAHPJKDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly DKHEFBJMACG AIICMPPIGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<string, DateTime> OBFDMKMCPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Lazy<IMKMKDAKDOO> IKACGJCIBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly BLBJNHLLLJO? NLOAKCJMIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private string FMHLMPENACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private VoiceOption NMJMAGFBOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private float BIHEABLDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private string OLPHKDLEGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private string PDHEOKHOFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private CKMCAFFKBGA MLDOAHDAMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private CancellationTokenSource? NDMBBMONPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected DBGGBEIHDDJ? EDGOGMPKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private AudioSource JPODIHMCBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private AudioSourceSimpleLevelMeter? IHFDJJKKCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private CMHNDAPCDML? NLNDAMKAPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private JNMPGLFLECK? JLMNMCLNCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NJGCMPGNPIJ? IDEKOICKJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NGPABDKOFIB? KGPONBGAMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private IReadOnlyCollection<string> FBBHPPDNHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private DateTime? OBDKPHHPGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private Task<ResponseDTO>? BMGHCGBENCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private uint OPIMPNEALMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly HashSet<string> KDNIICGJBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly HashSet<string> INELABIEGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly HashSet<string> OAKLCIMOLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool BAHFFMLPIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private NJLNMLEFFEL? LGKLOCPHNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool GHIFJKEMHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private CancellationTokenSource? BAPCPAJENPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private string? CHCNNMPJBPO;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DBGGBEIHDDJ GLIJBHHJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8053CF0", Offset = "0x80526F0", VA = "0x188053CF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string? OKBODONOABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x80519A0", Offset = "0x80503A0", VA = "0x1880519A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract bool BBMOIGJCNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public abstract bool BCIJCAKIBFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public abstract bool AAELDIAKFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	protected abstract bool DPAICLGDOCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	protected abstract string? PHAIKMCDKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected abstract string FHICAHMMJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected abstract int FCOJHPEEEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected abstract int CFABJNFLGEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	protected abstract NEAPMCHDCGK OLECEEAODMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	protected abstract string GHIDOMHBFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	protected virtual bool CIIOCPANCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool OIKIFLPPAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8051D70", Offset = "0x8050770", VA = "0x188051D70", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool ABGJOHFNIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8052660", Offset = "0x8051060", VA = "0x188052660", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool APNCKPOPDBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x804FFB0", Offset = "0x804E9B0", VA = "0x18804FFB0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool PPFEAFMHHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xBE4DB0", Offset = "0xBE37B0", VA = "0x180BE4DB0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xBE5740", Offset = "0xBE4140", VA = "0x180BE5740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool EAFEAEMLEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8053D90", Offset = "0x8052790", VA = "0x188053D90", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool JAHOACAEKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x804FD80", Offset = "0x804E780", VA = "0x18804FD80", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool MLFIJJIMHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2831C60", Offset = "0x2830660", VA = "0x182831C60", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool IHIKOLNNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x80519F0", Offset = "0x80503F0", VA = "0x1880519F0", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool FINCKFJPLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8053B60", Offset = "0x8052560", VA = "0x188053B60", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private bool KHJCGPBOBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80521B0", Offset = "0x8050BB0", VA = "0x1880521B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private bool GHBJGBMLOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8050040", Offset = "0x804EA40", VA = "0x188050040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private bool JCMAPNBKMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8052080", Offset = "0x8050A80", VA = "0x188052080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool ILNAKOIPHCH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x265CDF0", Offset = "0x265B7F0", VA = "0x18265CDF0", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8053910", Offset = "0x8052310", VA = "0x188053910", Slot = "58")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private uint MFCKLNCHEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xB32670", Offset = "0xB31070", VA = "0x180B32670")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8053030", Offset = "0x8051A30", VA = "0x188053030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public AudioSource CPBHNJPBMAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAEDCD0", Offset = "0xAEC6D0", VA = "0x180AEDCD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public KPJDKPBAAGN? LOABKLMFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAEE0F0", Offset = "0xAECAF0", VA = "0x180AEE0F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public IJFJPAOJGKG? HIBIOBGGBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA89DE0", Offset = "0xA887E0", VA = "0x180A89DE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string NAMJGEMGDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x804FD10", Offset = "0x804E710", VA = "0x18804FD10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8053B80", Offset = "0x8052580", VA = "0x188053B80", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	protected virtual string? EGLEJILKPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xB65190", Offset = "0xB63B90", VA = "0x180B65190", Slot = "73")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected virtual MEBJEIOEDLD? KAIBOPJKOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "74")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected virtual MEBJEIOEDLD? AMJDNBKLACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "75")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public ECMKKKEPCGP<bool> KJPNPFBBNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xBEA150", Offset = "0xBE8B50", VA = "0x180BEA150", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public HPDJJKCNBLF ONEEKABFGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xBE9A80", Offset = "0xBE8480", VA = "0x180BE9A80", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public HPDJJKCNBLF CGKGCEHGGOK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xBDB970", Offset = "0xBDA370", VA = "0x180BDB970", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public NCMMNGPOLDF<string, string> LBDLCLLBDHM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xBF8800", Offset = "0xBF7200", VA = "0x180BF8800", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public ECMKKKEPCGP<List<ToolDTO>> LPMPEOGAKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xBE24F0", Offset = "0xBE0EF0", VA = "0x180BE24F0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public HPDJJKCNBLF PLIBPIDCGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xBDB750", Offset = "0xBDA150", VA = "0x180BDB750", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public HPDJJKCNBLF NFNELCDJKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xBE1360", Offset = "0xBDFD60", VA = "0x180BE1360", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public HPDJJKCNBLF PFAMGLJKMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xBF89B0", Offset = "0xBF73B0", VA = "0x180BF89B0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public NCMMNGPOLDF<float, string> FKOOLLJCNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xBE7C10", Offset = "0xBE6610", VA = "0x180BE7C10", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public ECMKKKEPCGP<string> GILLFJHLCIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xBE2EE0", Offset = "0xBE18E0", VA = "0x180BE2EE0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x80543D0", Offset = "0x8052DD0", VA = "0x1880543D0")]
	public PFHEOONACEP(KPGHENBLKEI HHDPFPDGCPI, PFGEPOEKIEP OAAFNFCLLPD, JLIDFJPMMHL PKOMFNFJPHJ, [Optional] BLBJNHLLLJO? FMLLLLFOMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "61")]
	protected abstract IMKMKDAKDOO CreateDataReporter();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x80530A0", Offset = "0x8051AA0", VA = "0x1880530A0")]
	private void LJOICFNABOI(OANEFANIMLD GACDMLEAKAP, IOJHILLLLIM? LCJFNEJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8051DC0", Offset = "0x80507C0", VA = "0x188051DC0", Slot = "31")]
	public Task IBAOFJGDOEH(string ODNCJIJIJFK, VoiceOption HIHLOKPILIN, float PKDPDIAMEDL, string COHLGKEHKLI, string CEHLGOHBIOI, [Optional] IReadOnlyCollection<string>? MMFFLBLABLN, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8052090", Offset = "0x8050A90", VA = "0x188052090")]
	[AsyncStateMachine(typeof(DGOPKCGBFLL))]
	private Task JCILGHEFHBP(int? DHLNNEBPCHP, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x80501F0", Offset = "0x804EBF0", VA = "0x1880501F0", Slot = "76")]
	protected virtual Task CheckAccess(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x8054140", Offset = "0x8052B40", VA = "0x188054140", Slot = "77")]
	protected virtual Task<bool> UploadTranscriptsForModeration(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8050990", Offset = "0x804F390", VA = "0x188050990", Slot = "32")]
	public void FGLGBKHFALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x8051AB0", Offset = "0x80504B0", VA = "0x188051AB0", Slot = "55")]
	[AsyncStateMachine(typeof(PFHACJCLENC))]
	public Task HAIJGCPGANO(bool AGAJFKOHJGL, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8050420", Offset = "0x804EE20", VA = "0x188050420", Slot = "78")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x8051BC0", Offset = "0x80505C0", VA = "0x188051BC0", Slot = "33")]
	[AsyncStateMachine(typeof(BJFDMBLIKMK))]
	public Task HDOLJIDELMO(string ODNCJIJIJFK, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8053DD0", Offset = "0x80527D0", VA = "0x188053DD0", Slot = "34")]
	[AsyncStateMachine(typeof(DMHELGJILFI))]
	public Task PFFPALAKEFN(float PKDPDIAMEDL, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x8052F00", Offset = "0x8051900", VA = "0x188052F00")]
	[AsyncStateMachine(typeof(HPOKINHBCCG))]
	public Task LHOKHKBFONE(bool DKBBOMHPGKC, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8051440", Offset = "0x804FE40", VA = "0x188051440", Slot = "35")]
	[AsyncStateMachine(typeof(PJOAGFDDPIK))]
	public Task FHPDBHACPKM(bool DKBBOMHPGKC, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x8051550", Offset = "0x804FF50", VA = "0x188051550", Slot = "36")]
	public void GBAJPDJPNAH(params OANEFANIMLD[] GFGMMGFEJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x8053820", Offset = "0x8052220", VA = "0x188053820", Slot = "37")]
	public bool MENAIDAGDEB(OANEFANIMLD OCNMJGBOEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x804FBD0", Offset = "0x804E5D0", VA = "0x18804FBD0", Slot = "38")]
	public void ADHNOMDKJJG(params OANEFANIMLD[] GFGMMGFEJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x804FDD0", Offset = "0x804E7D0", VA = "0x18804FDD0", Slot = "39")]
	public void BDGPIBDMGHM(NJLNMLEFFEL DHNMCOFINFM, bool NGBIJOOMBII = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x8051930", Offset = "0x8050330", VA = "0x188051930", Slot = "40")]
	public void GDLKGKOBANG(NJLNMLEFFEL DHNMCOFINFM, bool NGBIJOOMBII = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x8052040", Offset = "0x8050A40", VA = "0x188052040", Slot = "41")]
	public void IPNICELLLEE(NJLNMLEFFEL DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x8051D80", Offset = "0x8050780", VA = "0x188051D80", Slot = "42")]
	public void HPEPGEOKNJL(NJLNMLEFFEL DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8053920", Offset = "0x8052320", VA = "0x188053920", Slot = "59")]
	public IReadOnlyCollection<string> MKKLPAMDEPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8050090", Offset = "0x804EA90", VA = "0x188050090", Slot = "43")]
	public void CNCBOBCEHIJ(decimal PKKGIIIEFOF, string HCLPHJDKMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x80523D0", Offset = "0x8050DD0", VA = "0x1880523D0", Slot = "44")]
	[AsyncStateMachine(typeof(NJFCLBDBJEF))]
	public Task JLNCBBMOOPE(byte[] IFFPBJEFLDC, string? COECCLMOEJC, string? FBBFHAHHIIP, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8052520", Offset = "0x8050F20", VA = "0x188052520", Slot = "45")]
	[AsyncStateMachine(typeof(FBOJOFJPGHC))]
	public Task JLNCBBMOOPE(string ONGDPODJNBL, string? FBBFHAHHIIP, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x804FA80", Offset = "0x804E480", VA = "0x18804FA80", Slot = "46")]
	[AsyncStateMachine(typeof(GPPGEIFLPPP))]
	public Task ACPPGJBMMAH(string ONGDPODJNBL, string? FBBFHAHHIIP, string? BHMIKOGCGFK, bool IIIHGLLLIHA, bool DKNCGGJGONO, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8053700", Offset = "0x8052100", VA = "0x188053700", Slot = "47")]
	[AsyncStateMachine(typeof(CPAGFJELOLL))]
	public Task MECHAJFIDKP(string PIIOFEIFOCJ, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8050280", Offset = "0x804EC80", VA = "0x188050280", Slot = "52")]
	public bool DGGMIKPKILF(string MPOMJBFIAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x804FA20", Offset = "0x804E420", VA = "0x18804FA20", Slot = "53")]
	public bool ABJBOMJLAOD(string MPOMJBFIAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x80506C0", Offset = "0x804F0C0", VA = "0x1880506C0", Slot = "54")]
	public bool EGLMAEIHFIE(string IHJOAODOKIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x80502E0", Offset = "0x804ECE0", VA = "0x1880502E0", Slot = "48")]
	[AsyncStateMachine(typeof(NANIFAGLNOG))]
	public Task<ResponseDTO> DJEFAFAAGEJ(bool AEIAKGHLEMI = true, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8053430", Offset = "0x8051E30", VA = "0x188053430", Slot = "49")]
	[AsyncStateMachine(typeof(AILPIMBHPKG))]
	public Task<string> LMMNDJHPIFH(string ODNCJIJIJFK, [Optional] IReadOnlyList<ConversationItemDTO>? HPDAGNJGMCO, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3E8BFA0", Offset = "0x3E8A9A0", VA = "0x183E8BFA0", Slot = "50")]
	[AsyncStateMachine(typeof(GMJGDPAPOHE<>))]
	public Task<TOutput> LMMNDJHPIFH<TOutput>(string ODNCJIJIJFK, [Optional] IReadOnlyList<ConversationItemDTO>? HPDAGNJGMCO, [Optional] CancellationToken OMJKEHOJJFF) where TOutput : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x8053590", Offset = "0x8051F90", VA = "0x188053590", Slot = "51")]
	[AsyncStateMachine(typeof(OILAHJLPDMI))]
	public Task<List<FDKPMALMEND>> LMMNDJHPIFH(string ODNCJIJIJFK, IReadOnlyList<ConversationItemDTO>? HPDAGNJGMCO, IReadOnlyList<GCDMAJCMLBF> PKGKEPGONDN, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x804FE40", Offset = "0x804E840", VA = "0x18804FE40")]
	[AsyncStateMachine(typeof(DHFEGLPNFPB))]
	private Task<List<ConversationItemDTO>> BPJCNFLMOHK(string ODNCJIJIJFK, IReadOnlyList<ConversationItemDTO>? HPDAGNJGMCO, JsonSchema? IEDFNJCPCMC, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x80522C0", Offset = "0x8050CC0", VA = "0x1880522C0")]
	[AsyncStateMachine(typeof(BDMJCOAGGJN))]
	private Task JGNEFHEIHFM(DateTime DAKHMINHPOE, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x80516E0", Offset = "0x80500E0", VA = "0x1880516E0")]
	private bool GCKGKICCDJD(ResponseDTO FNAGPCFFJAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x8051CD0", Offset = "0x80506D0", VA = "0x188051CD0")]
	private void HGONNMNDMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8053AC0", Offset = "0x80524C0", VA = "0x188053AC0")]
	private void NCHJKOOLAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8051F50", Offset = "0x8050950", VA = "0x188051F50")]
	[AsyncStateMachine(typeof(MHHNBNKCNCH))]
	private Task ILGCHNLBKDK([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8051E60", Offset = "0x8050860", VA = "0x188051E60")]
	private void IKGAMFNOEAN(ReadOnlySpan<float> HOJPNGNMCGP, int FFFBBGDMCAA, int OBDDMOILNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x804FC50", Offset = "0x804E650", VA = "0x18804FC50")]
	private void AFJGHIEKOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8053840", Offset = "0x8052240", VA = "0x188053840")]
	[AsyncStateMachine(typeof(ANOAIOHKDCJ))]
	private void MGAJAFFPPMP(ResponseEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8053980", Offset = "0x8052380", VA = "0x188053980")]
	private void MPCICOAOODD(ConversationItemDTO HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3E8C0F0", Offset = "0x3E8AAF0", VA = "0x183E8C0F0")]
	private void PEBPBOIPMLH<T>(T CLHICJCGIEH) where T : notnull, NECPHEJINNO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8052760", Offset = "0x8051160", VA = "0x188052760")]
	private void KPMGCJEOMFG(ResponseEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8050550", Offset = "0x804EF50", VA = "0x188050550")]
	private void EEJAEMPPKCE(string EHEGBKOFLNN, string CEHLGOHBIOI, float PKDPDIAMEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x804F900", Offset = "0x804E300", VA = "0x18804F900")]
	[AsyncStateMachine(typeof(IHOJOMMAMMD))]
	private Task ABDGEKECOKN(ResponseDTO FNAGPCFFJAJ, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8050740", Offset = "0x804F140", VA = "0x188050740")]
	[AsyncStateMachine(typeof(BPAEOEFMIDE))]
	private Task EIAGDJMNJGD(ConversationItemDTO HNLFGCKBFGI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8054030", Offset = "0x8052A30", VA = "0x188054030")]
	[AsyncStateMachine(typeof(COFGFKCEIFK))]
	private Task<ResponseDTO> PPOKNKLCJAK(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x80515D0", Offset = "0x804FFD0", VA = "0x1880515D0")]
	[AsyncStateMachine(typeof(OCDAGIKGHKK))]
	private Task<ResponseDTO> GBOHGIMMFBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8050850", Offset = "0x804F250", VA = "0x188050850")]
	private void EKDJPDJAFDM(ErrorEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x80526D0", Offset = "0x80510D0", VA = "0x1880526D0")]
	private void KKMFCOHCPJM(InputAudioBufferSpeechStartedEventDTO GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8053C60", Offset = "0x8052660", VA = "0x188053C60")]
	private void OLFAAEEPBFB(InputAudioBufferSpeechStoppedEventDTO GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8053EE0", Offset = "0x80528E0", VA = "0x188053EE0")]
	protected void PNNJJLCEECH(string HDDLNGLMMKN, [Optional] string? HLJPNDHEBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8051A40", Offset = "0x8050440", VA = "0x188051A40")]
	private bool GOCLLHCNBKO(ResponseDTO FNAGPCFFJAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8053010", Offset = "0x8051A10", VA = "0x188053010")]
	protected void LIJONKDPMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8053D90", Offset = "0x8052790", VA = "0x188053D90")]
	[CompilerGenerated]
	private bool PMJNAKLABPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8052700", Offset = "0x8051100", VA = "0x188052700")]
	[CompilerGenerated]
	private bool KNPOEKLFKDN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class MGMFBFNKAON : KDFCLIMNGPF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct DCGFEFNIINN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public JLIDFJPMMHL recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public MGMFBFNKAON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Guid spendSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter<GBAJHOFECNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8040E80", Offset = "0x803F880", VA = "0x188040E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8041330", Offset = "0x803FD30", VA = "0x188041330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly DOMAHLEMAHP HEEAKCBLEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly string GAEHAIEDADH;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x804BC90", Offset = "0x804A690", VA = "0x18804BC90")]
	public MGMFBFNKAON(DOMAHLEMAHP CAPLINHHINP, JLIDFJPMMHL PKOMFNFJPHJ, string HJHBKDMFDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x804BB30", Offset = "0x804A530", VA = "0x18804BB30", Slot = "6")]
	[AsyncStateMachine(typeof(DCGFEFNIINN))]
	protected override Task<bool> TrySyncLatestCostInfo(JLIDFJPMMHL PKOMFNFJPHJ, Guid CMKNICHBINH, long DKMPIOFKFMN, long MNAMJIAHNIM, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
public class LOAMMGGFDAA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public LOAMMGGFDAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface BKCKOJFJDIH
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBCHBKMMBEF(OANEFANIMLD OCNMJGBOEHK, [Out] IOJHILLLLIM LCJFNEJNIDM);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class HKLJCJFKMCA
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class PEGIEFFPDML
	{
		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public PropertyInfo LFCPLAICKAK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Type DKIFNAFPJFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x72B5D50", Offset = "0x72B4750", VA = "0x1872B5D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public string BNNILBDKGDL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool NBJLNEPHHAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Type? FDEJIBNNHEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x804F4F0", Offset = "0x804DEF0", VA = "0x18804F4F0")]
		public PEGIEFFPDML(PropertyInfo AJHJMOHPDBL, JsonPropertyAttribute? DMNLLBJHKHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly ConcurrentDictionary<Type, List<PEGIEFFPDML>> LKCABOLJONJ;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8047DE0", Offset = "0x80467E0", VA = "0x188047DE0")]
	public static List<string> LBGEILKFDOK(string GJCLCJPIKBJ, Type HEMOFFLNODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x80477C0", Offset = "0x80461C0", VA = "0x1880477C0")]
	private static void KBFPFJBDHPM(Type AEOGKDPPBBE, JObject ANNNNPICOII, List<string> NGGIMNIJCMO, string GNFOPGNJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8047400", Offset = "0x8045E00", VA = "0x188047400")]
	private static List<PEGIEFFPDML> CIJCHKLIPKF(Type AEOGKDPPBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8047710", Offset = "0x8046110", VA = "0x188047710")]
	private static bool JLDBLOEMOLH(Type AEOGKDPPBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public HKLJCJFKMCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class NJGCMPGNPIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class DBEAOJEPPKN
	{
		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public string? IDDOHMJEKBI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public int LNMLHBFNBBM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public int FDCCNHGEJBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAADF50", Offset = "0xAAC950", VA = "0x180AADF50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xEB0C60", Offset = "0xEAF660", VA = "0x180EB0C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8040E60", Offset = "0x803F860", VA = "0x188040E60")]
		public DBEAOJEPPKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class OIMGADMMLBH
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public string BIKKNIIFDAP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public ConversationItemType MMPEDFAPIKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
			[CompilerGenerated]
			get
			{
				return default(ConversationItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string? ECNNEOPPKAO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string? FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x804F480", Offset = "0x804DE80", VA = "0x18804F480")]
		public OIMGADMMLBH(ConversationItemDTO HNLFGCKBFGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class HADJLCOMFBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public IEnumerable<string> functionNames;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HADJLCOMFBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x80472F0", Offset = "0x8045CF0", VA = "0x1880472F0")]
		internal bool GNKLOBCPBHE(OIMGADMMLBH c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class NMINPDLGFJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public OIMGADMMLBH c;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NMINPDLGFJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x804E0E0", Offset = "0x804CAE0", VA = "0x18804E0E0")]
		internal bool HDFOJCHBIFG(string n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class EPDJFKJINPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public NJGCMPGNPIJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public EPDJFKJINPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x80449A0", Offset = "0x80433A0", VA = "0x1880449A0")]
		internal bool BHBOAHKALFI(string n)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8044C00", Offset = "0x8043600", VA = "0x188044C00")]
		internal bool CHLJBALPLFO(OIMGADMMLBH c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x80449E0", Offset = "0x80433E0", VA = "0x1880449E0")]
		internal void CGFECOEEOKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class FHEHIOKMIJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public IEnumerable<string?> callIdsToRemove;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FHEHIOKMIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x80463E0", Offset = "0x8044DE0", VA = "0x1880463E0")]
		internal bool MDBODMBMNAK(OIMGADMMLBH c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class ENIAONMEBDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public IEnumerable<string> idsToRemove;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ENIAONMEBDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8044940", Offset = "0x8043340", VA = "0x188044940")]
		internal bool KFGLNFLEEAG(OIMGADMMLBH c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class CFMNHPOACLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public Func<bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CFMNHPOACLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x803CA40", Offset = "0x803B440", VA = "0x18803CA40")]
		internal bool BBNILHHHDAC()
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct DECIIAAGHBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private CFMNHPOACLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public NJGCMPGNPIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x80413A0", Offset = "0x803FDA0", VA = "0x1880413A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8041910", Offset = "0x8040310", VA = "0x188041910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly DOMAHLEMAHP HLEHDLJELDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly KPJDKPBAAGN NLNDAMKAPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly HashSet<string> IGBHEEBJIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly DBEAOJEPPKN NHIAHPGIPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly List<OIMGADMMLBH> FBBHPPDNHIB;

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static Queue<string> PMBAEEFLNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly CancellationTokenSource NMPOKMCNEJL;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x804DBD0", Offset = "0x804C5D0", VA = "0x18804DBD0")]
	public NJGCMPGNPIJ(DOMAHLEMAHP NDALKOEPAOF, KPJDKPBAAGN HJLDCGCNDHO, DBEAOJEPPKN HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x804D3C0", Offset = "0x804BDC0", VA = "0x18804D3C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x804D5C0", Offset = "0x804BFC0", VA = "0x18804D5C0")]
	public void MDAOOBFEFBJ(IEnumerable<string> AEOALFLINDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x804D7B0", Offset = "0x804C1B0", VA = "0x18804D7B0")]
	private void MPCICOAOODD(ConversationItemDTO HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x804CF30", Offset = "0x804B930", VA = "0x18804CF30")]
	private void DFFGDAIAJNB(IEnumerable<string?> KIEMJDFGCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x804D4A0", Offset = "0x804BEA0", VA = "0x18804D4A0")]
	[AsyncStateMachine(typeof(DECIIAAGHBA))]
	private Task IMGKHIKHAPE(Queue<string> EHDDOAPGAIK, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class CMHNDAPCDML : KPJDKPBAAGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal class PEHPAAHBFIF
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public ConversationItemDTO EFLOLIACEGI
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool ANMKJMEEEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xA87B30", Offset = "0xA86530", VA = "0x180A87B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x15913B0", Offset = "0x158FDB0", VA = "0x1815913B0")]
		public PEHPAAHBFIF(ConversationItemDTO HNLFGCKBFGI, bool ODGLKFOIECF = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class AHKBGKAMNII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AHKBGKAMNII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x80558C0", Offset = "0x80542C0", VA = "0x1880558C0")]
		internal bool FOBDOCFMBLP(PEHPAAHBFIF c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8055880", Offset = "0x8054280", VA = "0x188055880")]
		internal bool CCKDDCLDCOH(PEHPAAHBFIF c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class HKJHMPIGDKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HKJHMPIGDKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8055B50", Offset = "0x8054550", VA = "0x188055B50")]
		internal bool CCJIHIPBINH(PEHPAAHBFIF c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class NLHIBPAEEPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NLHIBPAEEPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8055880", Offset = "0x8054280", VA = "0x188055880")]
		internal bool GDNPGICHNHM(PEHPAAHBFIF c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class MCBODHOEJGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MCBODHOEJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8058E80", Offset = "0x8057880", VA = "0x188058E80")]
		internal bool DMCEEOKIJBG(PEHPAAHBFIF c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class JDJCBKNMFAM : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public ConversationItemDTO <>3__item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public CMHNDAPCDML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private MCBODHOEJGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private List<ConversationItemContentDTO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public JDJCBKNMFAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8058960", Offset = "0x8057360", VA = "0x188058960", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8058060", Offset = "0x8056A60", VA = "0x188058060", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8058010", Offset = "0x8056A10", VA = "0x188058010")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8058910", Offset = "0x8057310", VA = "0x188058910", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8058850", Offset = "0x8057250", VA = "0x188058850", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8058850", Offset = "0x8057250", VA = "0x188058850", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class BLNINKDBIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public string messageId;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BLNINKDBIEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2188720", Offset = "0x2187120", VA = "0x182188720")]
		internal bool PGBJMMOKJFF(ConversationItemDTO m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly PFHEOONACEP HLEHDLJELDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly DBGGBEIHDDJ EDGOGMPKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly NJLNMLEFFEL KGOAPKNIJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly List<PEHPAAHBFIF> LHMLMNAANHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly List<string> FBBHPPDNHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly List<ConversationItemDTO> AAGIDJLJCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private string? OLABDPHEDDJ;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public ECMKKKEPCGP<ConversationItemDTO> MPCICOAOODD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public IReadOnlyList<string> ELODBDIIINP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public IReadOnlyList<ConversationItemDTO> FHHNHPIGHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8040030", Offset = "0x803EA30", VA = "0x188040030")]
	public CMHNDAPCDML(PFHEOONACEP NDALKOEPAOF, IReadOnlyCollection<string> JGPMHBHKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x803F150", Offset = "0x803DB50", VA = "0x18803F150", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x803FE40", Offset = "0x803E840", VA = "0x18803FE40")]
	public List<string> MKKLPAMDEPK(bool HCCBOJIMOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x803F620", Offset = "0x803E020", VA = "0x18803F620")]
	private void KKHGMDPPMGI(ConversationItemCreatedEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x803FAB0", Offset = "0x803E4B0", VA = "0x18803FAB0")]
	private void KPMGCJEOMFG(ResponseEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x803F460", Offset = "0x803DE60", VA = "0x18803F460")]
	private void KBIOKKBNOHF(ConversationItemInputAudioTranscriptionCompletedEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x803EF10", Offset = "0x803D910", VA = "0x18803EF10")]
	private void CELAEDAKHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x803F3D0", Offset = "0x803DDD0", VA = "0x18803F3D0", Slot = "6")]
	[IteratorStateMachine(typeof(JDJCBKNMFAM))]
	public IEnumerable<string> GEHBJLKBMKL(ConversationItemDTO HNLFGCKBFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x803FD60", Offset = "0x803E760", VA = "0x18803FD60", Slot = "7")]
	public void MECHAJFIDKP(string MPOMJBFIAML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class JNMPGLFLECK : IJFJPAOJGKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct MOEOCEALGIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public IReadOnlyCollection<string> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public JNMPGLFLECK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8059120", Offset = "0x8057B20", VA = "0x188059120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x80595B0", Offset = "0x8057FB0", VA = "0x1880595B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly PFHEOONACEP HLEHDLJELDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly string GEFEPPKBCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly int BCIBGLEMFDC;

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBD00", Offset = "0x5EEA700", VA = "0x185EEBD00")]
	public JNMPGLFLECK(PFHEOONACEP NDALKOEPAOF, string NMGCANFNHNH, int IHBAFDLFGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x80589F0", Offset = "0x80573F0", VA = "0x1880589F0", Slot = "4")]
	[AsyncStateMachine(typeof(MOEOCEALGIF))]
	public Task BOOMHAGBNEO(IReadOnlyCollection<string> HPDAGNJGMCO, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class FEKMBLIGEDN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Type OJDGJDEAECF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAEDCD0", Offset = "0xAEC6D0", VA = "0x180AEDCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public string AFPAPOGCNIL
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA90900", Offset = "0xA8F300", VA = "0x180A90900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x8055F20", Offset = "0x8054920", VA = "0x188055F20")]
	public FEKMBLIGEDN(Type PNNDGPAHEBA, string GJCLCJPIKBJ, Exception GNHHAMPPHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FOFFCPFOEOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct HPLCHPLKCPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public string args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public FOFFCPFOEOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Dictionary<OANEFANIMLD, IOJHILLLLIM?>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter<string?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8057270", Offset = "0x8055C70", VA = "0x188057270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8057FA0", Offset = "0x80569A0", VA = "0x188057FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly MEBJEIOEDLD GCLDEHJKFHJ;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static readonly List<BKCKOJFJDIH> PJNMKOLEJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly Dictionary<OANEFANIMLD, IOJHILLLLIM?> KNLBEJMCLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly NCMMNGPOLDF<OANEFANIMLD, IOJHILLLLIM?> LJOICFNABOI;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8056CE0", Offset = "0x80556E0", VA = "0x188056CE0")]
	static FOFFCPFOEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8056660", Offset = "0x8055060", VA = "0x188056660")]
	public void GBAJPDJPNAH(params OANEFANIMLD[] GFGMMGFEJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8056920", Offset = "0x8055320", VA = "0x188056920")]
	public bool MENAIDAGDEB(OANEFANIMLD OCNMJGBOEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x8055FF0", Offset = "0x80549F0", VA = "0x188055FF0")]
	public void ADHNOMDKJJG(params OANEFANIMLD[] GFGMMGFEJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x8056980", Offset = "0x8055380", VA = "0x188056980")]
	public void OGBECEDPBAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8056500", Offset = "0x8054F00", VA = "0x188056500")]
	[AsyncStateMachine(typeof(HPLCHPLKCPF))]
	public Task<string> EIAGDJMNJGD(string FLBFBHGDBLM, string GACFFBLMJOF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8056310", Offset = "0x8054D10", VA = "0x188056310")]
	public List<ToolDTO> DINHJBDMAFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8056A10", Offset = "0x8055410", VA = "0x188056A10")]
	private static IOJHILLLLIM PCPEPJJIOFC(OANEFANIMLD OCNMJGBOEHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x8057020", Offset = "0x8055A20", VA = "0x188057020")]
	public FOFFCPFOEOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class MDKPLFDCHCN
{
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static JsonSerializerSettings NFHFGIMOBAH;

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8058ED0", Offset = "0x80578D0", VA = "0x188058ED0")]
	static MDKPLFDCHCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class NGPABDKOFIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private class NECAFGMHGDP
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public ConversationItemDTO EFLOLIACEGI
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool ANMKJMEEEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA87B30", Offset = "0xA86530", VA = "0x180A87B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x15913B0", Offset = "0x158FDB0", VA = "0x1815913B0")]
		public NECAFGMHGDP(ConversationItemDTO HNLFGCKBFGI, bool ODGLKFOIECF = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private abstract class BMFLFLGFDBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private readonly StringBuilder EMGOPPNCHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private readonly TimeSpan PHAGJBCGHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private DateTime EAHKCPOCMIC;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8055D20", Offset = "0x8054720", VA = "0x188055D20")]
		public BMFLFLGFDBP(TimeSpan LKPAFAAMKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8055B90", Offset = "0x8054590", VA = "0x188055B90")]
		public void MNPMEMBENGO(string MGLEDAHHPGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8055BE0", Offset = "0x80545E0", VA = "0x188055BE0")]
		public void OFIFLADBEBP(bool FGLPKBNAEFO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void MHHLHPBPFKD(string BCLNCLHGOEM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class GGOAGDGJBOE : BMFLFLGFDBP
	{
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static readonly TimeSpan DNDGFLOOBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private readonly string AFNBNFFGPGK;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x80571E0", Offset = "0x8055BE0", VA = "0x1880571E0")]
		public GGOAGDGJBOE(string EHLDAOMNLDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8057100", Offset = "0x8055B00", VA = "0x188057100", Slot = "4")]
		protected override void MHHLHPBPFKD(string BCLNCLHGOEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class LAGEFEELIFB : BMFLFLGFDBP
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly TimeSpan DNDGFLOOBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private readonly JLIDFJPMMHL GGBCONJIEAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private readonly DBGGBEIHDDJ EDGOGMPKGGB;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8058DE0", Offset = "0x80577E0", VA = "0x188058DE0")]
		public LAGEFEELIFB(JLIDFJPMMHL PKOMFNFJPHJ, DBGGBEIHDDJ CMKDNKCPOFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8058B10", Offset = "0x8057510", VA = "0x188058B10", Slot = "4")]
		protected override void MHHLHPBPFKD(string BCLNCLHGOEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class DKHODAIEHDL : BMFLFLGFDBP
	{
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static readonly TimeSpan DNDGFLOOBCB;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8055EC0", Offset = "0x80548C0", VA = "0x188055EC0")]
		public DKHODAIEHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8055DD0", Offset = "0x80547D0", VA = "0x188055DD0", Slot = "4")]
		protected override void MHHLHPBPFKD(string BCLNCLHGOEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class IPDDDMHDCCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public IPDDDMHDCCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8055880", Offset = "0x8054280", VA = "0x188055880")]
		internal bool FOBDOCFMBLP(NECAFGMHGDP c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class BFNNOJIOEDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BFNNOJIOEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8055B50", Offset = "0x8054550", VA = "0x188055B50")]
		internal bool CCJIHIPBINH(NECAFGMHGDP c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class PLPJPHGNMAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PLPJPHGNMAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8055880", Offset = "0x8054280", VA = "0x188055880")]
		internal bool GDNPGICHNHM(NECAFGMHGDP c)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct AHLAINFGIOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public NGPABDKOFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8055910", Offset = "0x8054310", VA = "0x188055910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8055AF0", Offset = "0x80544F0", VA = "0x188055AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static readonly TimeSpan DNDGFLOOBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private readonly PFHEOONACEP HLEHDLJELDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private readonly DBGGBEIHDDJ EDGOGMPKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly JLIDFJPMMHL GGBCONJIEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private readonly NJLNMLEFFEL KGOAPKNIJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private readonly List<BMFLFLGFDBP> EGPAMFNGPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly List<NECAFGMHGDP> LHMLMNAANHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private string? OLABDPHEDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private CancellationTokenSource? DLNLNNCLJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private Task? OCBODJKDPPB;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x805A980", Offset = "0x8059380", VA = "0x18805A980")]
	public NGPABDKOFIB(PFHEOONACEP NDALKOEPAOF, JLIDFJPMMHL PKOMFNFJPHJ, bool MHBLFKOCACA, bool FGEDCCMHEDH, string? DHKPKEJOIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8059700", Offset = "0x8058100", VA = "0x188059700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8059F80", Offset = "0x8058980", VA = "0x188059F80")]
	private void KKHGMDPPMGI(ConversationItemCreatedEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x805A4B0", Offset = "0x8058EB0", VA = "0x18805A4B0")]
	private void KPMGCJEOMFG(ResponseEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8059DC0", Offset = "0x80587C0", VA = "0x188059DC0")]
	private void KBIOKKBNOHF(ConversationItemInputAudioTranscriptionCompletedEventDTO CLHICJCGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8059CA0", Offset = "0x80586A0", VA = "0x188059CA0")]
	private void IGDIEPBIOLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8059A10", Offset = "0x8058410", VA = "0x188059A10")]
	private void FJGLPKMGHIL(ConversationItemDTO HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x805A760", Offset = "0x8059160", VA = "0x18805A760")]
	private void MNPMEMBENGO(string MGLEDAHHPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8059610", Offset = "0x8058010", VA = "0x188059610")]
	[AsyncStateMachine(typeof(AHLAINFGIOH))]
	private Task DHKEKPBENII(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x805A390", Offset = "0x8058D90", VA = "0x18805A390")]
	private void KOMECHKAILP(bool FGLPKBNAEFO = false)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class IFNBIANOKDF
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IFNBIANOKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x74C9350", Offset = "0x74C7D50", VA = "0x1874C9350")]
	public static string GGPGCGCJOGI(byte[] JCBPHBFKIAN, byte[] NOFNICNJALD)
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
