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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD3FC0", Offset = "0x7FD27C0", VA = "0x187FD3FC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_FuzzySearch_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FD39C0", Offset = "0x7FD21C0", VA = "0x187FD39C0", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class GCBEBLCIBLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly DCEKFOLAAAO IKHGGPKDGDH;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2480", Offset = "0x7FD0C80", VA = "0x187FD2480")]
	public GCBEBLCIBLO(IReadOnlyCollection<string> DGIPGKOHDAI, [In] NIEJPBDBLCH OIIBNOKOCAB, [Optional] DCEKFOLAAAO.MJFOPJKKLGC JIFHLFIHBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2240", Offset = "0x7FD0A40", VA = "0x187FD2240")]
	public IReadOnlyList<PNEOLHPOLNN> LPEIMILDFCK(string GJOJINKMAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FD20A0", Offset = "0x7FD08A0", VA = "0x187FD20A0")]
	public void BGNMCFMIGEB(string GJOJINKMAKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DCEKFOLAAAO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int MJFOPJKKLGC(IReadOnlyList<char> PNHEBCAFGFE, int BAAIHCLHNAE, string ABMPBBDKMOI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NIEJPBDBLCH PKEGOECCIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly MJFOPJKKLGC KACHJJICHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] DAMKEGOJGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly PNEOLHPOLNN[] EOJDHIBJAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] PKEHAJIKOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] OGNHJEJPBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly PNEOLHPOLNN[] NBBCNEAGMGF;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50")]
	public static int FKNOCHPLLLD(IReadOnlyList<char> PNHEBCAFGFE, int BAAIHCLHNAE, string ABMPBBDKMOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0240", Offset = "0x7FCEA40", VA = "0x187FD0240")]
	public DCEKFOLAAAO(IReadOnlyCollection<string> DGIPGKOHDAI, [In] NIEJPBDBLCH OIIBNOKOCAB, [Optional] MJFOPJKKLGC JIFHLFIHBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD01A0", Offset = "0x7FCE9A0", VA = "0x187FD01A0")]
	public string FAPAGDEABJH(string GJOJINKMAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0230", Offset = "0x7FCEA30", VA = "0x187FD0230")]
	public int MFBEAAIFDNH(int HJCDELBBHBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFBA0", Offset = "0x7FCE3A0", VA = "0x187FCFBA0")]
	public int BGNMCFMIGEB(string GJOJINKMAKC, int CPNKPELGACH, int AOIOCNILDFJ, int BAAIHCLHNAE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct NIEJPBDBLCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool LHCNFLGNGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool DOHPIBOFIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int NLMHLFJLEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int IJJDPOBOIDF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly NIEJPBDBLCH OAFEJOBOBKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NIEJPBDBLCH JMOEBDABFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3D40", Offset = "0x7FD2540", VA = "0x187FD3D40")]
		get
		{
			return default(NIEJPBDBLCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3DF0", Offset = "0x7FD25F0", VA = "0x187FD3DF0")]
	public NIEJPBDBLCH(bool MEKLFMJEGIK, bool MDLJKCBJMAN, int IHDOMONKGON, int BHMAIFBILGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct PNEOLHPOLNN : IEquatable<PNEOLHPOLNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int PJLMPJGAPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int BGNMCFMIGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int GJOIKHDGMPI;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xDC2E80", Offset = "0xDC1680", VA = "0x180DC2E80")]
	public PNEOLHPOLNN(int PNJCJGEIDHG, int ICKBNECFNNO, int MCMKCGAACBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4A60", Offset = "0x7FD3260", VA = "0x187FD4A60")]
	public static int FLPIPFCPDBM([In] PNEOLHPOLNN NOGJAHKGFJD, [In] PNEOLHPOLNN LHMEHOJLNDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27405B0", Offset = "0x273EDB0", VA = "0x1827405B0", Slot = "4")]
	public bool Equals(PNEOLHPOLNN KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD49B0", Offset = "0x7FD31B0", VA = "0x187FD49B0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4A80", Offset = "0x7FD3280", VA = "0x187FD4A80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IONEJIIIOLD
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKPBALPHHIH(string GJOJINKMAKC, [Out][NotNullWhen(true)] IReadOnlyList<MCPPIBLIPND>? EBAHALBPMDD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JNGPDAFPFBC : IONEJIIIOLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int FAGODOCOBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<MCPPIBLIPND> results)> LPHLJKPCIAD;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2F10", Offset = "0x7FD1710", VA = "0x187FD2F10")]
	public JNGPDAFPFBC(int FAGODOCOBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2D90", Offset = "0x7FD1590", VA = "0x187FD2D90", Slot = "4")]
	public bool LKPBALPHHIH(string GJOJINKMAKC, [Out][NotNullWhen(true)] IReadOnlyList<MCPPIBLIPND>? EBAHALBPMDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NPBPEAKAFOI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void BLFGPEKLPAO(IReadOnlyList<MCPPIBLIPND> EBAHALBPMDD);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class HBAEGDMABLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NPBPEAKAFOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public HBAEGDMABLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2BC0", Offset = "0x7FD13C0", VA = "0x187FD2BC0")]
		internal MCPPIBLIPND[] MLEHOECIMJK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct FBJLCKFIDGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NPBPEAKAFOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public BLFGPEKLPAO onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private CancellationTokenSource <localCts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<MCPPIBLIPND[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1D10", Offset = "0x7FD0510", VA = "0x187FD1D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private CancellationTokenSource? KFHNGCODDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly DLGNKHODNBE EACBPPFONED;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CDOKICCNJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA780F0", Offset = "0xA768F0", VA = "0x180A780F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xDA8C40", Offset = "0xDA7440", VA = "0x180DA8C40")]
	public NPBPEAKAFOI(DLGNKHODNBE EACBPPFONED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3E50", Offset = "0x7FD2650", VA = "0x187FD3E50")]
	[AsyncStateMachine(typeof(FBJLCKFIDGD))]
	public void LPEIMILDFCK(string GJOJINKMAKC, BLFGPEKLPAO PNOGMOKIMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3E10", Offset = "0x7FD2610", VA = "0x187FD3E10")]
	public void FBONGFMPKDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JMPNBLJDNMN
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2D20", Offset = "0x7FD1520", VA = "0x187FD2D20")]
	public static NPBPEAKAFOI HELMLHKOIBC(this DLGNKHODNBE EACBPPFONED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DLGNKHODNBE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate int JMGIFCFMJFE(ReadOnlySpan<char> GJOJINKMAKC, ReadOnlySpan<char> GMBFLBCIDMA, int EPGOIBAKMOG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly PDNEGMGPBIM OOMIFLDLFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly JNIKKNAOEAD EDLBIJFOLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly JMGIFCFMJFE? IAFLJBGCFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MCPPIBLIPND[] LFNJEDICONL;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD14B0", Offset = "0x7FCFCB0", VA = "0x187FD14B0")]
	public DLGNKHODNBE(PDNEGMGPBIM OOMIFLDLFHC, JNIKKNAOEAD EDLBIJFOLNB, [Optional] JMGIFCFMJFE? IAFLJBGCFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0E40", Offset = "0x7FCF640", VA = "0x187FD0E40")]
	public MCPPIBLIPND[] LPEIMILDFCK(string GJOJINKMAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0DB0", Offset = "0x7FCF5B0", VA = "0x187FD0DB0")]
	private static int LIGAIBLICNM([In] MCPPIBLIPND NOGJAHKGFJD, [In] MCPPIBLIPND LHMEHOJLNDH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct MCPPIBLIPND
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class KPNIPFPCPAG : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
		public MCPPIBLIPND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public MCPPIBLIPND <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x11A4EE0", Offset = "0x11A36E0", VA = "0x1811A4EE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7FD3970", Offset = "0x7FD2170", VA = "0x187FD3970", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x139A8E0", Offset = "0x13990E0", VA = "0x18139A8E0")]
		[DebuggerHidden]
		public KPNIPFPCPAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7FD37C0", Offset = "0x7FD1FC0", VA = "0x187FD37C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3920", Offset = "0x7FD2120", VA = "0x187FD3920", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3860", Offset = "0x7FD2060", VA = "0x187FD3860", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3860", Offset = "0x7FD2060", VA = "0x187FD3860", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float BGNMCFMIGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int PJLMPJGAPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> BAHJFCNFEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray BLJLNDAOJHK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> AKLHIPALHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3A50", Offset = "0x7FD2250", VA = "0x187FD3A50")]
		[IteratorStateMachine(typeof(KPNIPFPCPAG))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3AE0", Offset = "0x7FD22E0", VA = "0x187FD3AE0")]
	public MCPPIBLIPND(float ICKBNECFNNO, int PNJCJGEIDHG, ReadOnlyMemory<char> OLBBKGLINIK, IEnumerable<int> BLJLNDAOJHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct GMKLJGPBHOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool LHCNFLGNGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool DOHPIBOFIOK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4C5E6F0", Offset = "0x4C5CEF0", VA = "0x184C5E6F0")]
	public GMKLJGPBHOA(bool DCHMFPOGIAH, bool NJMGMAJOLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2B30", Offset = "0x7FD1330", VA = "0x187FD2B30")]
	public string LPMFMGGMOEL(string FIBFJHPJKOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JNIKKNAOEAD
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float BGNMCFMIGEB(ReadOnlySpan<char> GJOJINKMAKC, ReadOnlySpan<char> GMBFLBCIDMA, [Optional] List<int>? LFJJHANCIKE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OMFCCLNAHJD : JNIKKNAOEAD
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct IDAEGKCNEBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float CONPAMNBHOL;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA980", Offset = "0x2AA9180", VA = "0x182AAA980")]
		public IDAEGKCNEBF(float LPKKOLCBMNL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] CIFMEHBHNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] MPLGFGBHPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray BNPNOAOCGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDAEGKCNEBF OIIBNOKOCAB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD48D0", Offset = "0x7FD30D0", VA = "0x187FD48D0")]
	public OMFCCLNAHJD([In] IDAEGKCNEBF OIIBNOKOCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4040", Offset = "0x7FD2840", VA = "0x187FD4040", Slot = "4")]
	public float BGNMCFMIGEB(ReadOnlySpan<char> GJOJINKMAKC, ReadOnlySpan<char> GMBFLBCIDMA, [Optional] List<int>? LFJJHANCIKE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD44D0", Offset = "0x7FD2CD0", VA = "0x187FD44D0")]
	private void NIEBBMEBDLM(int GGIJOHIPOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4560", Offset = "0x7FD2D60", VA = "0x187FD4560")]
	private float PJIEAKOIDCJ(ReadOnlySpan<char> GJOJINKMAKC, ReadOnlySpan<char> GMBFLBCIDMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FD43C0", Offset = "0x7FD2BC0", VA = "0x187FD43C0")]
	private int HANENMEKGKE(ReadOnlySpan<char> EACBPPFONED, ReadOnlySpan<char> OLBBKGLINIK, int DOHLGAEMKLM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EBLKAHEAJNC : JNIKKNAOEAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int IHDOMONKGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? ICDACNACPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] HHHDEKACDDK;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1C60", Offset = "0x7FD0460", VA = "0x187FD1C60")]
	public EBLKAHEAJNC(int IHDOMONKGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7FD15B0", Offset = "0x7FCFDB0", VA = "0x187FD15B0", Slot = "4")]
	public float BGNMCFMIGEB(ReadOnlySpan<char> GJOJINKMAKC, ReadOnlySpan<char> GMBFLBCIDMA, [Optional] List<int>? LFJJHANCIKE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PDNEGMGPBIM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> MKHFHLEJOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KLNAMLGNPFG : PDNEGMGPBIM
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DJJKNOFCICH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GMKLJGPBHOA settings;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DJJKNOFCICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0D20", Offset = "0x7FCF520", VA = "0x187FD0D20")]
		internal string CHOMCFDJKME(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GHIOIEIOMKG : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
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
		public KLNAMLGNPFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<KBDLKOIKJND<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ReadOnlyMemory<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7FD2A50", Offset = "0x7FD1250", VA = "0x187FD2A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x272FD70", Offset = "0x272E570", VA = "0x18272FD70")]
		[DebuggerHidden]
		public GHIOIEIOMKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2AA0", Offset = "0x7FD12A0", VA = "0x187FD2AA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2580", Offset = "0x7FD0D80", VA = "0x187FD2580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2530", Offset = "0x7FD0D30", VA = "0x187FD2530")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2A00", Offset = "0x7FD1200", VA = "0x187FD2A00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2950", Offset = "0x7FD1150", VA = "0x187FD2950", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2950", Offset = "0x7FD1150", VA = "0x187FD2950", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] IJGLJOJMELD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> MKHFHLEJOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2FB0", Offset = "0x7FD17B0", VA = "0x187FD2FB0", Slot = "4")]
		[IteratorStateMachine(typeof(GHIOIEIOMKG))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3030", Offset = "0x7FD1830", VA = "0x187FD3030")]
	public KLNAMLGNPFG(IEnumerable<string> OOMIFLDLFHC, GMKLJGPBHOA OIIBNOKOCAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class BNDBILIHFCB<TSchedulerContext> : IDisposable where TSchedulerContext : notnull, MonoBehaviour, GKEGMHGFIBN
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void ENNCOGOFOFL(IReadOnlyList<PNEOLHPOLNN> EBAHALBPMDD, IReadOnlyList<bool> MNFFPEBGEBD);

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private const string JKAONGOFDCD = "r2adoption_2025q2_better_palette_search";

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private const string MMBOONJJEHA = "algorithm";

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static OKNMANBEBON? ANOIHLPEACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly IONEJIIIOLD? LPHLJKPCIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly NPBPEAKAFOI EACBPPFONED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly GMKLJGPBHOA DENHCBFBHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NIEJPBDBLCH OIIBNOKOCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ENNCOGOFOFL OGCOCEKLDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly DLGNKHODNBE.JMGIFCFMJFE? IAFLJBGCFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private IReadOnlyList<PNEOLHPOLNN> ALGOJDKNHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private IReadOnlyList<bool> GLJBAMCPIIL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<PNEOLHPOLNN> HKFPOFJNAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> APCPHLCLBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool CDOKICCNJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x61823B0", Offset = "0x6180BB0", VA = "0x1861823B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61823D0", Offset = "0x6180BD0", VA = "0x1861823D0")]
	public BNDBILIHFCB(IReadOnlyList<string> DGIPGKOHDAI, [In] NIEJPBDBLCH OIIBNOKOCAB, ENNCOGOFOFL PNOGMOKIMJL, [Optional] DLGNKHODNBE.JMGIFCFMJFE? IAFLJBGCFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6181B50", Offset = "0x6180350", VA = "0x186181B50")]
	public void CEINMOAJPDN(string GJOJINKMAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6181E00", Offset = "0x6180600", VA = "0x186181E00")]
	private void MJNOOAGIHIH(IReadOnlyList<MCPPIBLIPND> EBAHALBPMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6181CF0", Offset = "0x61804F0", VA = "0x186181CF0")]
	private int DMEAMLAGDIP(ReadOnlySpan<char> BJNLPCOGDLM, ReadOnlySpan<char> OLBBKGLINIK, int EGGKCJNMJBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61817B0", Offset = "0x617FFB0", VA = "0x1861817B0")]
	private JNIKKNAOEAD BDBOGIOJHAE()
	{
		return null;
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
