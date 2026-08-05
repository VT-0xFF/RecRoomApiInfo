using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Logging.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8131730", Offset = "0x8130330", VA = "0x188131730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_FuzzySearch_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8131570", Offset = "0x8130170", VA = "0x188131570", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class ACIECGFEBKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly LINKGBKJOPM MJDJLDLPFCJ;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x812BF40", Offset = "0x812AB40", VA = "0x18812BF40")]
	public ACIECGFEBKJ(IReadOnlyCollection<string> HAMKJDHCCOO, [In] JFNJLNIOGFJ DKFCHCGNBIM, [Optional] LINKGBKJOPM.KKCGKEOAOHN OGGAEIOCPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x812BB60", Offset = "0x812A760", VA = "0x18812BB60")]
	public IReadOnlyList<GKHKCBEAKOD> NCDKPPJGNIB(string OMPMALIAKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x812BDA0", Offset = "0x812A9A0", VA = "0x18812BDA0")]
	public void PLDPMJFMNEA(string OMPMALIAKPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LINKGBKJOPM
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int KKCGKEOAOHN(IReadOnlyList<char> LPECBDGKAEM, int PABKFJEAJCB, string KDJPMCLKICL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JFNJLNIOGFJ ADIJEKNLKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly KKCGKEOAOHN FDFMMDEPBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] EKPMFAOHEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly GKHKCBEAKOD[] OPEMLHGCENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] PACDIICONHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] PEKPNOJALLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly GKHKCBEAKOD[] MKPNHBOEIFL;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030")]
	public static int PAIPGNAGOKP(IReadOnlyList<char> LPECBDGKAEM, int PABKFJEAJCB, string KDJPMCLKICL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8130A80", Offset = "0x812F680", VA = "0x188130A80")]
	public LINKGBKJOPM(IReadOnlyCollection<string> HAMKJDHCCOO, [In] JFNJLNIOGFJ DKFCHCGNBIM, [Optional] KKCGKEOAOHN OGGAEIOCPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x81303E0", Offset = "0x812EFE0", VA = "0x1881303E0")]
	public string JDFAPNPPIPN(string OMPMALIAKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8130470", Offset = "0x812F070", VA = "0x188130470")]
	public int OMHNAICNJLE(int LJKFFEIOOPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8130480", Offset = "0x812F080", VA = "0x188130480")]
	public int PLDPMJFMNEA(string OMPMALIAKPG, int DMLDNANEMKH, int IIDMACKIEEP, int PABKFJEAJCB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct JFNJLNIOGFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool IODJLNODJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool HEMGBJBPNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int MDFMBIKBNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int JEFAHLKMBDO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly JFNJLNIOGFJ FKOLNDEDPEE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JFNJLNIOGFJ JOFMPALJJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x812FC80", Offset = "0x812E880", VA = "0x18812FC80")]
		get
		{
			return default(JFNJLNIOGFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x812FD30", Offset = "0x812E930", VA = "0x18812FD30")]
	public JFNJLNIOGFJ(bool ILNDKPIHMLA, bool DMMDMMCPGLI, int PCGKIMALILN, int PPEBGJIBNII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct GKHKCBEAKOD : IEquatable<GKHKCBEAKOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int CLIFKJOPCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int PLDPMJFMNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int LILBPBICEAP;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xE48CD0", Offset = "0xE478D0", VA = "0x180E48CD0")]
	public GKHKCBEAKOD(int LCCBBMBENOH, int BIIMFPCCKAK, int HDILEFMJABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x812FC60", Offset = "0x812E860", VA = "0x18812FC60")]
	public static int JFOKAMEPDGC([In] GKHKCBEAKOD OHEOONFKODG, [In] GKHKCBEAKOD GOPANKCDGOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28C29F0", Offset = "0x28C15F0", VA = "0x1828C29F0", Slot = "4")]
	public bool Equals(GKHKCBEAKOD IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x812FB40", Offset = "0x812E740", VA = "0x18812FB40", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x812FBF0", Offset = "0x812E7F0", VA = "0x18812FBF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FCFCHOICODG
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IMKFPKMBFIB(string OMPMALIAKPG, [Out][NotNullWhen(true)] IReadOnlyList<POHHKCIDIJO>? GDMLMHKNJNF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FFAABEGPEGO : FCFCHOICODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int IPMIIANJANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<POHHKCIDIJO> results)> HGDHKCAADKN;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x812FA10", Offset = "0x812E610", VA = "0x18812FA10")]
	public FFAABEGPEGO(int IPMIIANJANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x812F890", Offset = "0x812E490", VA = "0x18812F890", Slot = "4")]
	public bool IMKFPKMBFIB(string OMPMALIAKPG, [Out][NotNullWhen(true)] IReadOnlyList<POHHKCIDIJO>? GDMLMHKNJNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FEAEMCGMFOB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void AJKAIILDHIK(IReadOnlyList<POHHKCIDIJO> GDMLMHKNJNF);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class EPDOPPGFFHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FEAEMCGMFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationTokenSource localCts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public EPDOPPGFFHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x812EB00", Offset = "0x812D700", VA = "0x18812EB00")]
		internal POHHKCIDIJO[] JPFENCMEDJO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct FCCJELOHDJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public FEAEMCGMFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private EPDOPPGFFHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AJKAIILDHIK onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<POHHKCIDIJO[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x812F200", Offset = "0x812DE00", VA = "0x18812F200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly FAIDIMOIJNG AHNBPPOPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly EHHEHCPBBNJ GACILMCANMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly FPDNMFEIBOK.MMIOOGDBLPA? MKPOEMMCEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private POHHKCIDIJO[] ADGCKILOHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CancellationTokenSource? ENGBOLJKMHF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KPMGDFMAIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x11F6FA0", Offset = "0x11F5BA0", VA = "0x1811F6FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x812F7E0", Offset = "0x812E3E0", VA = "0x18812F7E0")]
	public FEAEMCGMFOB(FAIDIMOIJNG AHNBPPOPJNA, EHHEHCPBBNJ GACILMCANMK, [Optional] FPDNMFEIBOK.MMIOOGDBLPA? MKPOEMMCEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x812F660", Offset = "0x812E260", VA = "0x18812F660")]
	[AsyncStateMachine(typeof(FCCJELOHDJM))]
	public void NCDKPPJGNIB(string OMPMALIAKPG, AJKAIILDHIK IIKJOKNFAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x812F620", Offset = "0x812E220", VA = "0x18812F620")]
	public void JGECLGLABGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FPDNMFEIBOK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int MMIOOGDBLPA(ReadOnlySpan<char> OMPMALIAKPG, ReadOnlySpan<char> NIJBCDNADKJ, int HCAHMCHFGCL);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x812FAB0", Offset = "0x812E6B0", VA = "0x18812FAB0")]
	public static int JJPIPMMEMHH([In] POHHKCIDIJO OHEOONFKODG, [In] POHHKCIDIJO GOPANKCDGOD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct POHHKCIDIJO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class BFACLEADOAD : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public POHHKCIDIJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public POHHKCIDIJO <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1282590", Offset = "0x1281190", VA = "0x181282590", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x812D420", Offset = "0x812C020", VA = "0x18812D420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1356980", Offset = "0x1355580", VA = "0x181356980")]
		[DebuggerHidden]
		public BFACLEADOAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x812D270", Offset = "0x812BE70", VA = "0x18812D270", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x812D3D0", Offset = "0x812BFD0", VA = "0x18812D3D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x812D310", Offset = "0x812BF10", VA = "0x18812D310", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x812D310", Offset = "0x812BF10", VA = "0x18812D310", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float PLDPMJFMNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int CLIFKJOPCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> CHFNAAKBOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray PLEIDFMFFMO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> DPFKMIHPBBO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81317B0", Offset = "0x81303B0", VA = "0x1881317B0")]
		[IteratorStateMachine(typeof(BFACLEADOAD))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8131840", Offset = "0x8130440", VA = "0x188131840")]
	public POHHKCIDIJO(float BIIMFPCCKAK, int LCCBBMBENOH, ReadOnlyMemory<char> ADGCHNLKFKK, IEnumerable<int> PLEIDFMFFMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct JGGOBLMPEMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool IODJLNODJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool HEMGBJBPNEP;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x48CD6A0", Offset = "0x48CC2A0", VA = "0x1848CD6A0")]
	public JGGOBLMPEMN(bool APDACJKCHJD, bool KPKPLFAMNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x812FD50", Offset = "0x812E950", VA = "0x18812FD50")]
	public string LNIBKOKGCBA(string JIBDMFNCFIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EHHEHCPBBNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float PLDPMJFMNEA(ReadOnlySpan<char> OMPMALIAKPG, ReadOnlySpan<char> NIJBCDNADKJ, [Optional] List<int>? FENAFBDEPMO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AFAPPGBIBME : EHHEHCPBBNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct KGNHHFBLALH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float BBIKCNPDBBI;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2C53B40", Offset = "0x2C52740", VA = "0x182C53B40")]
		public KGNHHFBLALH(float HFPGLBKHIFK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] ELDJHCAAAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] LOOFPIJJOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray ENMPDFNOFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KGNHHFBLALH DKFCHCGNBIM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x812C8D0", Offset = "0x812B4D0", VA = "0x18812C8D0")]
	public AFAPPGBIBME([In] KGNHHFBLALH DKFCHCGNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x812C440", Offset = "0x812B040", VA = "0x18812C440", Slot = "4")]
	public float PLDPMJFMNEA(ReadOnlySpan<char> OMPMALIAKPG, ReadOnlySpan<char> NIJBCDNADKJ, [Optional] List<int>? FENAFBDEPMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x812C3B0", Offset = "0x812AFB0", VA = "0x18812C3B0")]
	private void NNLIGLGHHON(int PFHGPMHBODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x812BFF0", Offset = "0x812ABF0", VA = "0x18812BFF0")]
	private float MCGMJLNBNAG(ReadOnlySpan<char> OMPMALIAKPG, ReadOnlySpan<char> NIJBCDNADKJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x812C7C0", Offset = "0x812B3C0", VA = "0x18812C7C0")]
	private int PPJEBCIIGEN(ReadOnlySpan<char> MHMBHJJNCAE, ReadOnlySpan<char> ADGCHNLKFKK, int FNPBFMOFCDK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EHNFCCEIBJK : EHHEHCPBBNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int PCGKIMALILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? HMOPLDOCDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] IFGIMPCJDJD;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x812EA50", Offset = "0x812D650", VA = "0x18812EA50")]
	public EHNFCCEIBJK(int PCGKIMALILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x812E3A0", Offset = "0x812CFA0", VA = "0x18812E3A0", Slot = "4")]
	public float PLDPMJFMNEA(ReadOnlySpan<char> OMPMALIAKPG, ReadOnlySpan<char> NIJBCDNADKJ, [Optional] List<int>? FENAFBDEPMO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FAIDIMOIJNG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> FAPHODHFOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BELLFMNGBIK : FAIDIMOIJNG
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BBGGIBAAKCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public JGGOBLMPEMN settings;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public BBGGIBAAKCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x812C9B0", Offset = "0x812B5B0", VA = "0x18812C9B0")]
		internal string GEHOIAPHLML(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JMGAKNPKDJD : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ReadOnlyMemory<char> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public BELLFMNGBIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<NLCAHHBKCIO<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD1C5C0", Offset = "0xD1B1C0", VA = "0x180D1C5C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ReadOnlyMemory<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8130300", Offset = "0x812EF00", VA = "0x188130300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28B1F30", Offset = "0x28B0B30", VA = "0x1828B1F30")]
		[DebuggerHidden]
		public JMGAKNPKDJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8130350", Offset = "0x812EF50", VA = "0x188130350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x812FE30", Offset = "0x812EA30", VA = "0x18812FE30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x812FDE0", Offset = "0x812E9E0", VA = "0x18812FDE0")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x81302B0", Offset = "0x812EEB0", VA = "0x1881302B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8130200", Offset = "0x812EE00", VA = "0x188130200", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8130200", Offset = "0x812EE00", VA = "0x188130200", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] GHIIEIOGONH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> FAPHODHFOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x812CA40", Offset = "0x812B640", VA = "0x18812CA40", Slot = "4")]
		[IteratorStateMachine(typeof(JMGAKNPKDJD))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x812CAC0", Offset = "0x812B6C0", VA = "0x18812CAC0")]
	public BELLFMNGBIK(IEnumerable<string> AHNBPPOPJNA, JGGOBLMPEMN DKFCHCGNBIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class DKHJKKHGCAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void EOCENBHIBCO(IReadOnlyList<GKHKCBEAKOD> GDMLMHKNJNF, IReadOnlyList<bool> HKECEJHGHPB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly FCFCHOICODG? HGDHKCAADKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly FEAEMCGMFOB MHMBHJJNCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly JGGOBLMPEMN MCGCMECPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly JFNJLNIOGFJ DKFCHCGNBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly EOCENBHIBCO BOMBEHKKMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly FPDNMFEIBOK.MMIOOGDBLPA? MKPOEMMCEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private IReadOnlyList<GKHKCBEAKOD> CLLNCJEOHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private IReadOnlyList<bool> KMHEPPMGDPK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<GKHKCBEAKOD> NNNAKKOPOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> LCHNJEICENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KPMGDFMAIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x812DB90", Offset = "0x812C790", VA = "0x18812DB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x812DF50", Offset = "0x812CB50", VA = "0x18812DF50")]
	public DKHJKKHGCAJ(IReadOnlyList<string> HAMKJDHCCOO, [In] JFNJLNIOGFJ DKFCHCGNBIM, EOCENBHIBCO IIKJOKNFAKD, [Optional] FPDNMFEIBOK.MMIOOGDBLPA? MKPOEMMCEHA, [Optional] EHHEHCPBBNJ? EDMOJINPKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x812DBB0", Offset = "0x812C7B0", VA = "0x18812DBB0")]
	public void MLKPPOJELJE(string OMPMALIAKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x812D670", Offset = "0x812C270", VA = "0x18812D670")]
	private void DIFHEILLOJD(IReadOnlyList<POHHKCIDIJO> GDMLMHKNJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x812D470", Offset = "0x812C070", VA = "0x18812D470")]
	private int DIAMPLKMIMC(ReadOnlySpan<char> NDMEBHICHPO, ReadOnlySpan<char> ADGCHNLKFKK, int CMMCDCEPLCH)
	{
		return default(int);
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
