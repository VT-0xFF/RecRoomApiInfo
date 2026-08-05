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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82DE6B0", Offset = "0x82DDAB0", VA = "0x1882DE6B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82DE4E0", Offset = "0x82DD8E0", VA = "0x1882DE4E0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class COCGCKFGBOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PPCGAEHFONM HEEDNJCIPMK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82DA660", Offset = "0x82D9A60", VA = "0x1882DA660")]
	public COCGCKFGBOE(IReadOnlyCollection<string> OALFJLJHCPK, [In] AHPIJNCFJAM FKBCJNJEHBA, [Optional] PPCGAEHFONM.KJOOMBBMIAB DCEMCLFEGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x82DA280", Offset = "0x82D9680", VA = "0x1882DA280")]
	public IReadOnlyList<MPMNCJGKFOH> GFJNLAAKBMM(string NPOEIHBELKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82DA4C0", Offset = "0x82D98C0", VA = "0x1882DA4C0")]
	public void HOEOHDLPMEB(string NPOEIHBELKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class PPCGAEHFONM
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int KJOOMBBMIAB(IReadOnlyList<char> LHLNGJNLPPO, int CLLLPGOJFMN, string OJAKGLCMAEP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly AHPIJNCFJAM JNCBIJHECAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly KJOOMBBMIAB FKNKCCKKHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] MNPBIFIECNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly MPMNCJGKFOH[] OMMOIDMJEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] NEAKABNPFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] PFPOJNGCLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly MPMNCJGKFOH[] DMLHIDMKOAE;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80")]
	public static int EHLABCJDJOG(IReadOnlyList<char> LHLNGJNLPPO, int CLLLPGOJFMN, string OJAKGLCMAEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82DF530", Offset = "0x82DE930", VA = "0x1882DF530")]
	public PPCGAEHFONM(IReadOnlyCollection<string> OALFJLJHCPK, [In] AHPIJNCFJAM FKBCJNJEHBA, [Optional] KJOOMBBMIAB DCEMCLFEGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x82DF4A0", Offset = "0x82DE8A0", VA = "0x1882DF4A0")]
	public string JHNHDHIPILO(string NPOEIHBELKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x82DEE90", Offset = "0x82DE290", VA = "0x1882DEE90")]
	public int DMABMOKBFCI(int HNHNPDLMFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x82DEEA0", Offset = "0x82DE2A0", VA = "0x1882DEEA0")]
	public int HOEOHDLPMEB(string NPOEIHBELKE, int GCJOENGKJNB, int JCJALKBILDO, int CLLLPGOJFMN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct AHPIJNCFJAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool MNFKJGIFDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool GMFDEJONEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int CMJNEMMCHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int JAFMJBPHEAB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly AHPIJNCFJAM DPDBHCPENMH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AHPIJNCFJAM BCIBOEFGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82DA120", Offset = "0x82D9520", VA = "0x1882DA120")]
		get
		{
			return default(AHPIJNCFJAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82DA1D0", Offset = "0x82D95D0", VA = "0x1882DA1D0")]
	public AHPIJNCFJAM(bool ENDJECILMHA, bool IHHGCMPCIKA, int HHBCFPNGIJN, int CJOMLMMFGBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct MPMNCJGKFOH : IEquatable<MPMNCJGKFOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int JHGBNCFKBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int HOEOHDLPMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int NPJHHLPBJHG;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xE6C710", Offset = "0xE6BB10", VA = "0x180E6C710")]
	public MPMNCJGKFOH(int NOEININIMIL, int DFFOALKNKHK, int IGGGMHLEFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82DE570", Offset = "0x82DD970", VA = "0x1882DE570")]
	public static int AIGNGMKFFCG([In] MPMNCJGKFOH KEHFCBFJCMA, [In] MPMNCJGKFOH KGECIONKOCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x292F000", Offset = "0x292E400", VA = "0x18292F000", Slot = "4")]
	public bool Equals(MPMNCJGKFOH LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x82DE590", Offset = "0x82DD990", VA = "0x1882DE590", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82DE640", Offset = "0x82DDA40", VA = "0x1882DE640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EEHBCMLCBMK
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PJHPAOPMIIB(string NPOEIHBELKE, [Out][NotNullWhen(true)] IReadOnlyList<JPJIHFIMFBN>? LJLNHEOADNE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DCLFHLBNAIO : EEHBCMLCBMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int LCCCELFKJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<JPJIHFIMFBN> results)> INGGBOBKCIL;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82DA890", Offset = "0x82D9C90", VA = "0x1882DA890")]
	public DCLFHLBNAIO(int LCCCELFKJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82DA710", Offset = "0x82D9B10", VA = "0x1882DA710", Slot = "4")]
	public bool PJHPAOPMIIB(string NPOEIHBELKE, [Out][NotNullWhen(true)] IReadOnlyList<JPJIHFIMFBN>? LJLNHEOADNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EJECDEPHIOA
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void EOONLMBKACG(IReadOnlyList<JPJIHFIMFBN> LJLNHEOADNE);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IHALOAENKBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public EJECDEPHIOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationTokenSource localCts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IHALOAENKBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82DD0F0", Offset = "0x82DC4F0", VA = "0x1882DD0F0")]
		internal JPJIHFIMFBN[] IJNHOEDIIEO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct HNEBIBGLPNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public EJECDEPHIOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private IHALOAENKBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public EOONLMBKACG onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<JPJIHFIMFBN[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x82DCCD0", Offset = "0x82DC0D0", VA = "0x1882DCCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly CADAKMEEAGE KIBNCDDDBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly BJOIJILGHJJ AGIGNJIBGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly EJNKPKPOFIB.GFECCHJCCFC? FDOHBKHFNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private JPJIHFIMFBN[] NDGBNLDGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CancellationTokenSource? EBACOGHDBNL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KBDDIGGMIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x123A270", Offset = "0x1239670", VA = "0x18123A270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82DC010", Offset = "0x82DB410", VA = "0x1882DC010")]
	public EJECDEPHIOA(CADAKMEEAGE KIBNCDDDBLI, BJOIJILGHJJ AGIGNJIBGMD, [Optional] EJNKPKPOFIB.GFECCHJCCFC? FDOHBKHFNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82DBE50", Offset = "0x82DB250", VA = "0x1882DBE50")]
	[AsyncStateMachine(typeof(HNEBIBGLPNL))]
	public void GFJNLAAKBMM(string NPOEIHBELKE, EOONLMBKACG ENLKEIGCJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82DBF40", Offset = "0x82DB340", VA = "0x1882DBF40")]
	public void IMAIIMDHCFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EJNKPKPOFIB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int GFECCHJCCFC(ReadOnlySpan<char> NPOEIHBELKE, ReadOnlySpan<char> OGEPLBGLKAE, int NMALCAOCKHD);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x82DC0C0", Offset = "0x82DB4C0", VA = "0x1882DC0C0")]
	public static int MDMLBKFAJEM([In] JPJIHFIMFBN KEHFCBFJCMA, [In] JPJIHFIMFBN KGECIONKOCO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JPJIHFIMFBN
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class JELAEODJLNE : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
		public JPJIHFIMFBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public JPJIHFIMFBN <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x12CA5C0", Offset = "0x12C99C0", VA = "0x1812CA5C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x82DD990", Offset = "0x82DCD90", VA = "0x1882DD990", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1515760", Offset = "0x1514B60", VA = "0x181515760")]
		[DebuggerHidden]
		public JELAEODJLNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82DD7E0", Offset = "0x82DCBE0", VA = "0x1882DD7E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x82DD940", Offset = "0x82DCD40", VA = "0x1882DD940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82DD880", Offset = "0x82DCC80", VA = "0x1882DD880", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82DD880", Offset = "0x82DCC80", VA = "0x1882DD880", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float HOEOHDLPMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int JHGBNCFKBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> HFHHCAILFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray FOLJDABIGNC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> NGCBKFKNDNG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82DD9E0", Offset = "0x82DCDE0", VA = "0x1882DD9E0")]
		[IteratorStateMachine(typeof(JELAEODJLNE))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82DDA70", Offset = "0x82DCE70", VA = "0x1882DDA70")]
	public JPJIHFIMFBN(float DFFOALKNKHK, int NOEININIMIL, ReadOnlyMemory<char> NJJNDJLGDNH, IEnumerable<int> FOLJDABIGNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct HJBIPPLBGPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool MNFKJGIFDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool GMFDEJONEMI;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x54DB8C0", Offset = "0x54DACC0", VA = "0x1854DB8C0")]
	public HJBIPPLBGPP(bool FCDKPNMPBJN, bool DELNMDOLBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x82DCC40", Offset = "0x82DC040", VA = "0x1882DCC40")]
	public string IAKFMMOEHPA(string BPHJBCALMCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BJOIJILGHJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float HOEOHDLPMEB(ReadOnlySpan<char> NPOEIHBELKE, ReadOnlySpan<char> OGEPLBGLKAE, [Optional] List<int>? FKGLAOFNOBB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GCDBCAEPADL : BJOIJILGHJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct OKBFKLCLNMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float GPKIBBAELMK;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2CEA450", Offset = "0x2CE9850", VA = "0x182CEA450")]
		public OKBFKLCLNMM(float FCANDPBCINN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] DHMFIJDLIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] LHAAFKEMHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray JDDCHOIFGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OKBFKLCLNMM FKBCJNJEHBA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x82DCA30", Offset = "0x82DBE30", VA = "0x1882DCA30")]
	public GCDBCAEPADL([In] OKBFKLCLNMM FKBCJNJEHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x82DC150", Offset = "0x82DB550", VA = "0x1882DC150", Slot = "4")]
	public float HOEOHDLPMEB(ReadOnlySpan<char> NPOEIHBELKE, ReadOnlySpan<char> OGEPLBGLKAE, [Optional] List<int>? FKGLAOFNOBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x82DC9A0", Offset = "0x82DBDA0", VA = "0x1882DC9A0")]
	private void PJMIJOALJJB(int MPDDFCCPIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82DC5E0", Offset = "0x82DB9E0", VA = "0x1882DC5E0")]
	private float MINCAGHBMEI(ReadOnlySpan<char> NPOEIHBELKE, ReadOnlySpan<char> OGEPLBGLKAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82DC4D0", Offset = "0x82DB8D0", VA = "0x1882DC4D0")]
	private int IPMBFFJKKJL(ReadOnlySpan<char> MIAKCMIDDDD, ReadOnlySpan<char> NJJNDJLGDNH, int BDGOGCLOIBP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OKIFIEJNHEN : BJOIJILGHJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int HHBCFPNGIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? FNCOLMMCLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] PBINNOLEPEE;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82DEDE0", Offset = "0x82DE1E0", VA = "0x1882DEDE0")]
	public OKIFIEJNHEN(int HHBCFPNGIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x82DE730", Offset = "0x82DDB30", VA = "0x1882DE730", Slot = "4")]
	public float HOEOHDLPMEB(ReadOnlySpan<char> NPOEIHBELKE, ReadOnlySpan<char> OGEPLBGLKAE, [Optional] List<int>? FKGLAOFNOBB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CADAKMEEAGE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> BBIJLLLHJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LIFENHGELAA : CADAKMEEAGE
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CEMFFPBAAKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public HJBIPPLBGPP settings;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CEMFFPBAAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82DA1F0", Offset = "0x82D95F0", VA = "0x1882DA1F0")]
		internal string CHCOOHFKFHN(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EHNABDGMEFB : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
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
		public LIFENHGELAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<HHEMJJEFDOC<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x82DBD70", Offset = "0x82DB170", VA = "0x1882DBD70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x291E530", Offset = "0x291D930", VA = "0x18291E530")]
		[DebuggerHidden]
		public EHNABDGMEFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x82DBDC0", Offset = "0x82DB1C0", VA = "0x1882DBDC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82DB8A0", Offset = "0x82DACA0", VA = "0x1882DB8A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x82DB850", Offset = "0x82DAC50", VA = "0x1882DB850")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x82DBD20", Offset = "0x82DB120", VA = "0x1882DBD20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x82DBC70", Offset = "0x82DB070", VA = "0x1882DBC70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x82DBC70", Offset = "0x82DB070", VA = "0x1882DBC70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] HHBCBBIGMAC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> BBIJLLLHJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82DDCD0", Offset = "0x82DD0D0", VA = "0x1882DDCD0", Slot = "4")]
		[IteratorStateMachine(typeof(EHNABDGMEFB))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x82DDD50", Offset = "0x82DD150", VA = "0x1882DDD50")]
	public LIFENHGELAA(IEnumerable<string> KIBNCDDDBLI, HJBIPPLBGPP FKBCJNJEHBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class DDLMNLLHLEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void FJIGOCGGPFL(IReadOnlyList<MPMNCJGKFOH> LJLNHEOADNE, IReadOnlyList<bool> LGFHKHEDJCC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly EEHBCMLCBMK? INGGBOBKCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly EJECDEPHIOA MIAKCMIDDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HJBIPPLBGPP PIMBICNIMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly AHPIJNCFJAM FKBCJNJEHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly FJIGOCGGPFL AILBHFDDLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly EJNKPKPOFIB.GFECCHJCCFC? FDOHBKHFNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private IReadOnlyList<MPMNCJGKFOH> ENLPKCJJOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private IReadOnlyList<bool> DPGNPNKGAEE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<MPMNCJGKFOH> AKCEPBDAICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> OBLBIHNGLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KBDDIGGMIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82DB1F0", Offset = "0x82DA5F0", VA = "0x1882DB1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82DB410", Offset = "0x82DA810", VA = "0x1882DB410")]
	public DDLMNLLHLEL(IReadOnlyList<string> OALFJLJHCPK, [In] AHPIJNCFJAM FKBCJNJEHBA, FJIGOCGGPFL ENLKEIGCJHD, [Optional] EJNKPKPOFIB.GFECCHJCCFC? FDOHBKHFNEM, [Optional] BJOIJILGHJJ? HICECBDPOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82DA930", Offset = "0x82D9D30", VA = "0x1882DA930")]
	public void DHAJGFKFABA(string NPOEIHBELKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82DACD0", Offset = "0x82DA0D0", VA = "0x1882DACD0")]
	private void ENHGFECDPNF(IReadOnlyList<JPJIHFIMFBN> LJLNHEOADNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82DB210", Offset = "0x82DA610", VA = "0x1882DB210")]
	private int PKOMCNFKHPD(ReadOnlySpan<char> NHDOFIDIKGL, ReadOnlySpan<char> NJJNDJLGDNH, int BOPALNHGMCD)
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
