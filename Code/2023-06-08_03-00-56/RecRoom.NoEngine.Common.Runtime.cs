using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF9D0", Offset = "0x6FAE7D0", VA = "0x186FAF9D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x917630", Offset = "0x916430", VA = "0x180917630")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xF6F160", Offset = "0xF6DF60", VA = "0x180F6F160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class DCNKMACCFPP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xF6F160", Offset = "0xF6DF60", VA = "0x180F6F160")]
	public DCNKMACCFPP(bool CLEHIMMNNPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class CDPAEOOJFFF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xF6F160", Offset = "0xF6DF60", VA = "0x180F6F160")]
	public CDPAEOOJFFF(bool CLEHIMMNNPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class LKOMFAGALHF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF860", Offset = "0x6FAE660", VA = "0x186FAF860")]
	public LKOMFAGALHF(bool CLEHIMMNNPC, string JLOIOCPGEGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.All)]
public class NPLFFICJPOI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly string KLJJLLIEMIN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x917630", Offset = "0x916430", VA = "0x180917630")]
	public NPLFFICJPOI(string LKJPFKCMBNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JECBHLEAKKM
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class EANPMGCGFBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Exception <ex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EANPMGCGFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC240", Offset = "0x6FAB040", VA = "0x186FAC240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD890", Offset = "0x6FAC690", VA = "0x186FAD890")]
	public static Task<TaskStatus> AJDADJOECAC(this Task FEEMIHFJMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2E00EC0", Offset = "0x2DFFCC0", VA = "0x182E00EC0")]
	public static Task<T> KIDLINPMGDD<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FADB30", Offset = "0x6FAC930", VA = "0x186FADB30")]
	public static Task MKEIGCGJLMD(this Task OGICGLLMMAC, CancellationToken GKNJCIECGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2E01AC0", Offset = "0x2E008C0", VA = "0x182E01AC0")]
	public static Task<TResult> MKEIGCGJLMD<TResult>(this Task<TResult> OGICGLLMMAC, CancellationToken GKNJCIECGND) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD9E0", Offset = "0x6FAC7E0", VA = "0x186FAD9E0")]
	[DebuggerStepThrough]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(EANPMGCGFBN))]
	internal static Task<TaskStatus> KGJJBIGMMAH(Task CKGAOGIPLEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KHHLDKCIMJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TimeSpan ONGJIMFLGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Action? PFBJBLINBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GMDFGDBDKPC();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDNCLGGKGEN();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LHAHJILIHBH();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct IKOIBCCBMOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly string ODIKHJJHMMN;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	public IKOIBCCBMOH(string KKLNCEHOHED)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
	public static string HAJGNNHEPJI(in IKOIBCCBMOH FEEMIHFJMDK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x17B4750", Offset = "0x17B3550", VA = "0x1817B4750")]
	public static IKOIBCCBMOH HAJGNNHEPJI(string FGBEDAPNDEP)
	{
		return default(IKOIBCCBMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD6E0", Offset = "0x6FAC4E0", VA = "0x186FAD6E0")]
	public string AGDNPBOJNCJ(string MAGABHMDKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD730", Offset = "0x6FAC530", VA = "0x186FAD730")]
	public string MEPBFNJNADF(object LEKGDHHINNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct GHDKILHJCNJ<T> : IEquatable<GHDKILHJCNJ<T>>, INACGBJLEGA<GHDKILHJCNJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T ODIKHJJHMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int PGIEFBHCKJD;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x17B4A20", Offset = "0x17B3820", VA = "0x1817B4A20")]
	public GHDKILHJCNJ(in T KKLNCEHOHED, int FHOMILACEHB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3756970", Offset = "0x3755770", VA = "0x183756970")]
	public static bool DDONPFMGGHF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B68A0", Offset = "0x7B5CA0")] in GHDKILHJCNJ<T> BGNJLPDNBMK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6910", Offset = "0x7B5D10")] in GHDKILHJCNJ<T> MDKJCMEMIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3605A40", Offset = "0x3604840", VA = "0x183605A40", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6980", Offset = "0x7B5D80")] GHDKILHJCNJ<T> FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3756F60", Offset = "0x3755D60", VA = "0x183756F60", Slot = "0")]
	public override bool Equals(object FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3756ED0", Offset = "0x3755CD0", VA = "0x183756ED0")]
	public bool DLIDBHANGIE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B69E0", Offset = "0x7B5DE0")] in GHDKILHJCNJ<T> FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3757310", Offset = "0x3756110", VA = "0x183757310", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3758030", Offset = "0x3756E30", VA = "0x183758030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3757A90", Offset = "0x3756890", VA = "0x183757A90")]
	public void ODIHOPAGDEH(out T KKLNCEHOHED, out int FHOMILACEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3757420", Offset = "0x3756220", VA = "0x183757420")]
	public (T, int) JEHIMNIMMAM()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x37573D0", Offset = "0x37561D0", VA = "0x1837573D0", Slot = "5")]
	private bool IKIPDCHLLBM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6A50", Offset = "0x7B5E50")] in GHDKILHJCNJ<T> FGBEDAPNDEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NBIHADGFBDC
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3405C60", Offset = "0x3404A60", VA = "0x183405C60")]
	public static GHDKILHJCNJ<T> PKJHFAGPFPD<T>(in T KKLNCEHOHED, int FHOMILACEHB) where T : notnull
	{
		return default(GHDKILHJCNJ<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct MELLEHNAKNA : IEquatable<MELLEHNAKNA>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660", Slot = "4")]
	public bool Equals(MELLEHNAKNA FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF940", Offset = "0x6FAE740", VA = "0x186FAF940", Slot = "0")]
	public override bool Equals(object FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF990", Offset = "0x6FAE790", VA = "0x186FAF990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF9A0", Offset = "0x6FAE7A0", VA = "0x186FAF9A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct CFEGPOCNKPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly FNCMOHGMAEG ENKHKMGKNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly ICNLGIMEDON INJMNENKPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly DONOEIGHFDG APMCOKNDOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly NAGFEBLBNIM PAJCLCEMPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly OFFBDHDEFCL CFEIPAIEKGI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly DONOEIGHFDG AMHFJEODHJB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly NAGFEBLBNIM LEPFGALKBDM;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly OFFBDHDEFCL MONIIOPKKDA;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly CFEGPOCNKPB GLDKKHCFJPK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KDDGCCJAMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6FABD40", Offset = "0x6FAAB40", VA = "0x186FABD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC1B0", Offset = "0x6FAAFB0", VA = "0x186FAC1B0")]
	public CFEGPOCNKPB(in FNCMOHGMAEG HFOIFJFPDDD, in ICNLGIMEDON DNIDLBMEKCK, DONOEIGHFDG NNMDMNLBBKB, NAGFEBLBNIM LAFJMLIHFGC, OFFBDHDEFCL IODEHKBBHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6FABD00", Offset = "0x6FAAB00", VA = "0x186FABD00")]
	private static string DDCBPIOOIMK(object GNOEFMFMEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090")]
	private static long OIKOPBEOPME()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
	private static string DININNOKAGJ(string PAAKDHAMJAA, string? JNOLBBDFOCG, bool GGEEGGIJFOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6FABBE0", Offset = "0x6FAA9E0", VA = "0x186FABBE0")]
	private static CFEGPOCNKPB CNIHENJJBGO()
	{
		return default(CFEGPOCNKPB);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JAJFDIMGLGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public ulong ILNDPHCOLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public long ILIFHGFALNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public double BGBMAFBGCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public uint HNKCOGCPFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public uint IPFMLDJCHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int JHOHBGIMKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int GMHCPPJOPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float IKPDOMNEFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float EEJGDLDMBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public ushort ALABDKPNPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public ushort NLFCGHPNGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public ushort MAPIDHHGGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public ushort KCLMKJCIDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public short ODGCIDIIHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public short ABJMIOJPDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public short HKEDMMOLHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public short IIEEJACBNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public char IMBLPAOMPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public char KHOFEGHJLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public char ICPLIFJGDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public char NIPMMJIHNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public byte MILBNPHNIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public byte ILNGNIPLGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public byte MNDPNBPADFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte HBBHDOELOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte ABDFEPHGOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public byte JOJEKCHFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte DHADIKLOHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public byte EAHOMLPAGCF;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD830", Offset = "0x6FAC630", VA = "0x186FAD830")]
	public static JAJFDIMGLGO PKJHFAGPFPD(byte AGEGKBNFNFN, byte KPHCMLHODPC, byte FDLCOCNELMA, byte HKKGJJLFGHE, byte GLBIOMFIGFP, byte LDDIKABLJOL, byte LLOBOGKJIMF, byte DCAMGFGHCAO)
	{
		return default(JAJFDIMGLGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct FNCMOHGMAEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly HEMMLCPLPPN KGADEHNOBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly IEJFHHPDJDA GEKLDGELLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly HEMMLCPLPPN BJIANCHNHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly IEJFHHPDJDA CGEONFMLIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly HEMMLCPLPPN BKJCBHKMNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IEJFHHPDJDA KGMENEEIMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly EHFHCEGFHFK KNCCFOMEBLO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly HEMMLCPLPPN BJOAPAPNLEM;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly IEJFHHPDJDA FLJNIEDHGLM;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly HEMMLCPLPPN MDKEGIHFIGM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly IEJFHHPDJDA IEMBEGANJKJ;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly HEMMLCPLPPN NBEDGKIPDID;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly IEJFHHPDJDA KPCIGDGGGOI;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly EHFHCEGFHFK GKDMPGKPFOM;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly FNCMOHGMAEG GLDKKHCFJPK;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly HEMMLCPLPPN MMPGPDKMDEA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KDDGCCJAMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC6F0", Offset = "0x6FAB4F0", VA = "0x186FAC6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1C31AF0", Offset = "0x1C308F0", VA = "0x181C31AF0")]
	public FNCMOHGMAEG(HEMMLCPLPPN LCLMOGBHEPO, IEJFHHPDJDA KLIEKEOOOCD, HEMMLCPLPPN NMPNNFINNDP, IEJFHHPDJDA DEOGGOFPFNO, HEMMLCPLPPN KGCDEDJPGND, IEJFHHPDJDA AFGAMIMJLNF, EHFHCEGFHFK JKGAMNJCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840")]
	private static bool DDBEFFMBJMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	private static void GFMJJCAIGBK(string CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840")]
	private static bool BCGOCGEMHMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	private static void HIIOGEAAIDO(string CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840")]
	private static bool HEJEDGEPBFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	private static void ACOHIODOEEI(string CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	private static void JHDEFBJLBGM(Exception OFHHJDEMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC450", Offset = "0x6FAB250", VA = "0x186FAC450")]
	private static FNCMOHGMAEG CNIHENJJBGO()
	{
		return default(FNCMOHGMAEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660")]
	private static bool LIGLFEFKIMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC680", Offset = "0x6FAB480", VA = "0x186FAC680")]
	public void JMPIMKEPGCC(object CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC590", Offset = "0x6FAB390", VA = "0x186FAC590")]
	public void FJBPMGCIHDO(object CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC430", Offset = "0x6FAB230", VA = "0x186FAC430")]
	public void BEDJPDADNLD(Exception OFHHJDEMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x233B3D0", Offset = "0x233A1D0", VA = "0x18233B3D0")]
	public void FJBPMGCIHDO<T>(T GAECONBCCJH, MBEIFJDLNML<T> CAJMIGKHKEC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x233B450", Offset = "0x233A250", VA = "0x18233B450")]
	public void JMPIMKEPGCC<T>(in T GAECONBCCJH, IHHFGPMAHJJ<T> CAJMIGKHKEC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC600", Offset = "0x6FAB400", VA = "0x186FAC600")]
	public bool ILGBIKINJMJ(bool MONHMLPFNBJ, string CAJMIGKHKEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class AKHNLJIBKON
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F8A0", Offset = "0x2C5E6A0", VA = "0x182C5F8A0")]
	public static IEnumerable<T> DPIDPAHEPAB<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
	public static T[] BFCGEOEKHPG<T>(params T[] COIHPFHJFPB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
	public static IEnumerable<T> KBFKGKJFIFE<T>(params T[] COIHPFHJFPB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2339E20", Offset = "0x2338C20", VA = "0x182339E20")]
	public static HashSet<T> LKEFHNAIJEB<T>(params T[] COIHPFHJFPB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F8B0", Offset = "0x2C5E6B0", VA = "0x182C5F8B0")]
	public static KeyValuePair<TKey, TValue> HCGGEODCMLI<TKey, TValue>(in TKey LGKPJAJAOLI, in TValue KKLNCEHOHED) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2339E20", Offset = "0x2338C20", VA = "0x182339E20")]
	public static List<T> KDFDJAAKKJF<T>(IEnumerable<T> KLBCGPELFKC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[AttributeUsage(AttributeTargets.All)]
public sealed class FGGPGJIKDHG : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly string FKNBLIPIDCO;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x917630", Offset = "0x916430", VA = "0x180917630")]
	public FGGPGJIKDHG(string BFOHIFNEMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class LHFOABMJFOC
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x301A1E0", Offset = "0x3018FE0", VA = "0x18301A1E0")]
	public static IKOIBCCBMOH JMNHBPDDNIL<T>()
	{
		return default(IKOIBCCBMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x301A3A0", Offset = "0x30191A0", VA = "0x18301A3A0")]
	public static IKOIBCCBMOH LOFBOCKDGDJ<T>([CallerMemberName] string PPPOJKMOIGD = "") where T : notnull
	{
		return default(IKOIBCCBMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x301A150", Offset = "0x3018F50", VA = "0x18301A150")]
	public static IKOIBCCBMOH JMNHBPDDNIL<T>(this T FLIPNKNBGHG) where T : notnull
	{
		return default(IKOIBCCBMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3019FE0", Offset = "0x3018DE0", VA = "0x183019FE0")]
	public static IKOIBCCBMOH IFKMECDIOGK<T>(this T FLIPNKNBGHG, [CallerMemberName] string PPPOJKMOIGD = "") where T : notnull
	{
		return default(IKOIBCCBMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x301A430", Offset = "0x3019230", VA = "0x18301A430")]
	public static IKOIBCCBMOH LOFBOCKDGDJ<T>(this T FEEMIHFJMDK, [CallerMemberName] string PPPOJKMOIGD = "") where T : notnull
	{
		return default(IKOIBCCBMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF7E0", Offset = "0x6FAE5E0", VA = "0x186FAF7E0")]
	public static IKOIBCCBMOH LOFBOCKDGDJ(string HNCFJFLIFNA, [CallerMemberName] string PPPOJKMOIGD = "")
	{
		return default(IKOIBCCBMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF720", Offset = "0x6FAE520", VA = "0x186FAF720")]
	public static string LOBBIOFDAPK(this object FEEMIHFJMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KIJMHLAPNPC]
public delegate long NAGFEBLBNIM();
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate void HGKANIKHONG<T>(in T GAECONBCCJH);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class PNMCEPGAIJO
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static CFEGPOCNKPB NIHJLAKPMFJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CFEGPOCNKPB GHEJKFHNBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFAF0", Offset = "0x6FAE8F0", VA = "0x186FAFAF0")]
		get
		{
			return default(CFEGPOCNKPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static FNCMOHGMAEG ENKHKMGKNKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0050", Offset = "0x6FAEE50", VA = "0x186FB0050")]
		get
		{
			return default(FNCMOHGMAEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static ICNLGIMEDON INJMNENKPOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFBD0", Offset = "0x6FAE9D0", VA = "0x186FAFBD0")]
		get
		{
			return default(ICNLGIMEDON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FB00B0", Offset = "0x6FAEEB0", VA = "0x186FB00B0")]
	public static void NPGNPMBLKLJ(in CFEGPOCNKPB GNHCLEBBOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFEB0", Offset = "0x6FAECB0", VA = "0x186FAFEB0")]
	public static void JMPIMKEPGCC(string CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFC30", Offset = "0x6FAEA30", VA = "0x186FAFC30")]
	public static void FJBPMGCIHDO(string CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3FC8170", Offset = "0x3FC6F70", VA = "0x183FC8170")]
	public static void FJBPMGCIHDO<T>(T GAECONBCCJH, MBEIFJDLNML<T> CAJMIGKHKEC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFB50", Offset = "0x6FAE950", VA = "0x186FAFB50")]
	public static void BEDJPDADNLD(Exception OFHHJDEMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFFD0", Offset = "0x6FAEDD0", VA = "0x186FAFFD0")]
	public static string LOBBIOFDAPK(object GNOEFMFMEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFF60", Offset = "0x6FAED60", VA = "0x186FAFF60")]
	public static long KBLGJPDNGDD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFDD0", Offset = "0x6FAEBD0", VA = "0x186FAFDD0")]
	public static bool ILGBIKINJMJ(bool MONHMLPFNBJ, string CAJMIGKHKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFCE0", Offset = "0x6FAEAE0", VA = "0x186FAFCE0")]
	public static double HOMFKNMFOOP()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BDHIPAEKNAF : HAPPJIHKFGD
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly HAPPJIHKFGD LNABDBHCENK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DateTime FIFIDFHNOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6FABB30", Offset = "0x6FAA930", VA = "0x186FABB30", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public BDHIPAEKNAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class KIJMHLAPNPC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
	public KIJMHLAPNPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate TResult KKCBOCGCNFJ<T, out TResult>(in T GAECONBCCJH);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult DDJLEDMCPBO<T1, T2, out TResult>(in T1 LEHDLJDNFPO, in T2 LGKMJIDOCAJ);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class GOECEEPNNHN : KHHLDKCIMJH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly TimeSpan PIPHCMGDHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly System.Timers.Timer HKGIHMIPOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private TimeSpan HFKMHAHJMBO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TimeSpan ONGJIMFLGEI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6FACF70", Offset = "0x6FABD70", VA = "0x186FACF70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Action? PFBJBLINBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B90", Offset = "0x7F0990", VA = "0x1807F1B90", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD160", Offset = "0x6FABF60", VA = "0x186FAD160")]
	[Preserve]
	public GOECEEPNNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD1D0", Offset = "0x6FABFD0", VA = "0x186FAD1D0")]
	public GOECEEPNNHN(TimeSpan HFKMHAHJMBO, [Optional] Action? DKIPOAPOKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6FACE50", Offset = "0x6FABC50", VA = "0x186FACE50", Slot = "7")]
	public void GMDFGDBDKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6FACF30", Offset = "0x6FABD30", VA = "0x186FACF30", Slot = "8")]
	public void IDNCLGGKGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD0C0", Offset = "0x6FABEC0", VA = "0x186FAD0C0", Slot = "9")]
	public void LHAHJILIHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x19F6840", Offset = "0x19F5640", VA = "0x1819F6840")]
	private void ODOIIMIMJLD(object FLIPNKNBGHG, ElapsedEventArgs HAKMMDDMINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6FACEB0", Offset = "0x6FABCB0", VA = "0x186FACEB0")]
	private static void GPBHIODCNDA(ref TimeSpan LFFCFKKBOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6FACDB0", Offset = "0x6FABBB0", VA = "0x186FACDB0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.Class)]
public class MMBMKHHBAJO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
	public MMBMKHHBAJO()
	{
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class MNOKKOCBECA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
	public MNOKKOCBECA(string BJJNLEKGMCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HAPPJIHKFGD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime FIFIDFHNOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct JHOFGDANIFI : IEquatable<JHOFGDANIFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public uint ABFLCCPIDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int DEKHFFCAEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public float KGEJMEKHKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public ushort ALABDKPNPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public ushort NLFCGHPNGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public short ODGCIDIIHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public short ABJMIOJPDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public char IMBLPAOMPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public char KHOFEGHJLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public byte MILBNPHNIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public byte ILNGNIPLGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public byte MNDPNBPADFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte HBBHDOELOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool LHEOLLNAJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool FKLFNJONHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool OPCENHEPCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool FHOJFPFNBHH;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xCB2D60", Offset = "0xCB1B60", VA = "0x180CB2D60")]
	public static JHOFGDANIFI LLAJHONCEMB(uint KJHNLMHBCJB)
	{
		return default(JHOFGDANIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xCB2D60", Offset = "0xCB1B60", VA = "0x180CB2D60")]
	public static JHOFGDANIFI NIOLMKIIJGA(int NDNBONMCEEE)
	{
		return default(JHOFGDANIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2CCB720", Offset = "0x2CCA520", VA = "0x182CCB720")]
	public static JHOFGDANIFI NFAPGOGDOEF(float GNADNCHFFPK)
	{
		return default(JHOFGDANIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6FADDF0", Offset = "0x6FACBF0", VA = "0x186FADDF0")]
	public static JHOFGDANIFI GEDCPLFNJMH(byte AGEGKBNFNFN, byte KPHCMLHODPC, byte FDLCOCNELMA, byte HKKGJJLFGHE)
	{
		return default(JHOFGDANIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6FADDF0", Offset = "0x6FACBF0", VA = "0x186FADDF0")]
	public static JHOFGDANIFI IKMCMFOHOIO(bool OFGOCIKCMLL, bool CALECHELADF, bool POOFJBJDLJM, bool FEOHCMOJDKI)
	{
		return default(JHOFGDANIFI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x57E2000", Offset = "0x57E0E00", VA = "0x1857E2000")]
	public static bool DDONPFMGGHF(JHOFGDANIFI AEFFKJDEELO, JHOFGDANIFI CPGPPMFIMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xCB11A0", Offset = "0xCAFFA0", VA = "0x180CB11A0", Slot = "4")]
	public bool Equals(JHOFGDANIFI FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6FADD60", Offset = "0x6FACB60", VA = "0x186FADD60", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xF66D30", Offset = "0xF65B30", VA = "0x180F66D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6FADE10", Offset = "0x6FACC10", VA = "0x186FADE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[NPLFFICJPOI("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct PJNDAEIJLOE<T> : IEquatable<PJNDAEIJLOE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly T ODIKHJJHMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly bool GKLAMNKPMJM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OCNDBNEBJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x36053C0", Offset = "0x36041C0", VA = "0x1836053C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3606E70", Offset = "0x3605C70", VA = "0x183606E70")]
	public PJNDAEIJLOE(in T KKLNCEHOHED, bool HBIMJKJJFKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3605880", Offset = "0x3604680", VA = "0x183605880")]
	public static bool DDONPFMGGHF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6DC0", Offset = "0x7B61C0")] in PJNDAEIJLOE<T> BGNJLPDNBMK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6E30", Offset = "0x7B6230")] in PJNDAEIJLOE<T> MDKJCMEMIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3605F40", Offset = "0x3604D40", VA = "0x183605F40", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6EA0", Offset = "0x7B62A0")] PJNDAEIJLOE<T> FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3605940", Offset = "0x3604740", VA = "0x183605940", Slot = "0")]
	public override bool Equals(object FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3606470", Offset = "0x3605270", VA = "0x183606470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3606C70", Offset = "0x3605A70", VA = "0x183606C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class MEFIHOGEKBE
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3030A80", Offset = "0x302F880", VA = "0x183030A80")]
	public static PJNDAEIJLOE<T> MPKHOIHEHMF<T>(in T KKLNCEHOHED) where T : notnull
	{
		return default(PJNDAEIJLOE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3030BC0", Offset = "0x302F9C0", VA = "0x183030BC0")]
	public static PJNDAEIJLOE<T?> OEBMANOOELN<T>()
	{
		return default(PJNDAEIJLOE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3030C30", Offset = "0x302FA30", VA = "0x183030C30")]
	public static bool PECJPFEACGC<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6F40", Offset = "0x7B6340")] this in PJNDAEIJLOE<T> OCGIIPAGLOD, [DCNKMACCFPP(true)] out T KKLNCEHOHED) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface INACGBJLEGA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DLIDBHANGIE(in T FGBEDAPNDEP);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct ICNLGIMEDON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly ENJJBAOAKCH MMAFEOMHDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly JJOLEDBDGBF CLBPJOPMMOA;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly ENJJBAOAKCH HAKAFGLDNDI;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly JJOLEDBDGBF AAEFAHGKIBM;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly ICNLGIMEDON GLDKKHCFJPK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool KDDGCCJAMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD480", Offset = "0x6FAC280", VA = "0x186FAD480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xAFE080", Offset = "0xAFCE80", VA = "0x180AFE080")]
	public ICNLGIMEDON(ENJJBAOAKCH OPEJMHPGCAE, JJOLEDBDGBF GBGGBKAPFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	private static void GANDBMBHMFF(string PPPOJKMOIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	private static void HCPNENIEHMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD3F0", Offset = "0x6FAC1F0", VA = "0x186FAD3F0")]
	private static ICNLGIMEDON CNIHENJJBGO()
	{
		return default(ICNLGIMEDON);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class ODFLILCCLGO
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x325FD40", Offset = "0x325EB40", VA = "0x18325FD40")]
	public static bool DLIDBHANGIE<T, U>(in T FEEMIHFJMDK, in U GNOEFMFMEOO) where T : notnull, INACGBJLEGA<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class MIJFHNEHAOL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly EqualityComparer<T> AIPEEIBMAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public T ODIKHJJHMMN;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x58462B0", Offset = "0x58450B0", VA = "0x1858462B0")]
	public MIJFHNEHAOL(in T KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5845920", Offset = "0x5844720", VA = "0x185845920", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5845F90", Offset = "0x5844D90", VA = "0x185845F90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5846040", Offset = "0x5844E40", VA = "0x185846040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class JPCHHEPEPHK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long FONALLKLHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF1A0", Offset = "0x6FADFA0", VA = "0x186FAF1A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long MABLKMJPMJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF010", Offset = "0x6FADE10", VA = "0x186FAF010")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double MMODFLFHCPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FAEEF0", Offset = "0x6FADCF0", VA = "0x186FAEEF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double AGHFHFDIPKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF2B0", Offset = "0x6FAE0B0", VA = "0x186FAF2B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static double FGKCKKGAPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF140", Offset = "0x6FADF40", VA = "0x186FAF140")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static double HCPDEOHGIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF070", Offset = "0x6FADE70", VA = "0x186FAF070")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEE40", Offset = "0x6FADC40", VA = "0x186FAEE40")]
	public static double EBAKIEKCBHJ(long EPJJIPBHIPH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEF60", Offset = "0x6FADD60", VA = "0x186FAEF60")]
	public static double HBCHNFKAOAD(long EPJJIPBHIPH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF200", Offset = "0x6FAE000", VA = "0x186FAF200")]
	public static double MJHIJPCMNBC(double IEDFBMKAKLK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6FAED90", Offset = "0x6FADB90", VA = "0x186FAED90")]
	public static long APPHIFNCCJN(long PFNOEDNDKJB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEF50", Offset = "0x6FADD50", VA = "0x186FAEF50")]
	public static long GLDJHBGEKPH(long ACPAINNNEHO, long GNJFOGFCJFL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF310", Offset = "0x6FAE110", VA = "0x186FAF310")]
	public static double PBOOPDEINHP(long ACPAINNNEHO, long GNJFOGFCJFL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF0D0", Offset = "0x6FADED0", VA = "0x186FAF0D0")]
	public static double JPEKPAPGNON(long ACPAINNNEHO, long GNJFOGFCJFL)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[KIJMHLAPNPC]
public delegate void IEJFHHPDJDA(string CAJMIGKHKEC);
[Cpp2IlInjected.Token(Token = "0x200002D")]
[KIJMHLAPNPC]
public delegate string DONOEIGHFDG(object GNOEFMFMEOO);
[Cpp2IlInjected.Token(Token = "0x200002E")]
[KIJMHLAPNPC]
public delegate void JJOLEDBDGBF();
[Cpp2IlInjected.Token(Token = "0x200002F")]
public delegate object IHHFGPMAHJJ<T>(in T DCPGFNKOIOA);
[Cpp2IlInjected.Token(Token = "0x2000030")]
public delegate object ECDAKEFFEOM();
[Cpp2IlInjected.Token(Token = "0x2000031")]
[KIJMHLAPNPC]
public delegate string OFFBDHDEFCL(string PAAKDHAMJAA, string? JNOLBBDFOCG, bool GGEEGGIJFOL);
[Cpp2IlInjected.Token(Token = "0x2000032")]
[KIJMHLAPNPC]
public delegate bool HEMMLCPLPPN();
[Cpp2IlInjected.Token(Token = "0x2000033")]
public delegate object MBEIFJDLNML<T>(T DCPGFNKOIOA);
[Cpp2IlInjected.Token(Token = "0x2000034")]
[KIJMHLAPNPC]
public delegate void ENJJBAOAKCH(string PPPOJKMOIGD);
[Cpp2IlInjected.Token(Token = "0x2000035")]
[KIJMHLAPNPC]
public delegate void EHFHCEGFHFK(Exception OFHHJDEMGBM);
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
