using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
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
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7900", Offset = "0x6AC6700", VA = "0x186AC7900")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OKJMOGFGHMF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly byte[] PLHMHNJGNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemoryStream LHFNIFCKGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CodedOutputStream MCPEODHLBFC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC510", Offset = "0x6ACB310", VA = "0x186ACC510", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BPGDKGFEDKF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MemoryStream LHFNIFCKGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CodedInputStream FFGFCPOKADE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4A60", Offset = "0x6AC3860", VA = "0x186AC4A60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct HHFGENCEDDA<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CGBEIHLCPKK : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public HHFGENCEDDA<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Protobuf <element>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x93C090", Offset = "0x93AE90", VA = "0x18093C090", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3B24990", Offset = "0x3B23790", VA = "0x183B24990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A2A070", Offset = "0x2A28E70", VA = "0x182A2A070")]
		[DebuggerHidden]
		public CGBEIHLCPKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3B247A0", Offset = "0x3B235A0", VA = "0x183B247A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3B24950", Offset = "0x3B23750", VA = "0x183B24950", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> GMPNNCDFNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream LHFNIFCKGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream FFGFCPOKADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf FODHHFDFGON;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int BBPCGKEHJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x838BF0", Offset = "0x8379F0", VA = "0x180838BF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x374E340", Offset = "0x374D140", VA = "0x18374E340")]
	private HHFGENCEDDA(byte[] PLHMHNJGNNB, Action<Protobuf> GMPNNCDFNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A96C90", Offset = "0x2A95A90", VA = "0x182A96C90")]
	public static HHFGENCEDDA<Protobuf> FLOGCKGNDEE<Data>(ReadOnlySpan<byte> NCMINFKEPHO, ReadOnlySpan<Data> BAHBPPHMFLI, Action<Protobuf> GMPNNCDFNHM)
	{
		return default(HHFGENCEDDA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x374E1B0", Offset = "0x374CFB0", VA = "0x18374E1B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x374E1F0", Offset = "0x374CFF0", VA = "0x18374E1F0", Slot = "4")]
	[IteratorStateMachine(typeof(HHFGENCEDDA<>.CGBEIHLCPKK))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x374E2F0", Offset = "0x374D0F0", VA = "0x18374E2F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HNGGPHFFDPI<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly byte[] PLHMHNJGNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Protobuf FODHHFDFGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream LHFNIFCKGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedOutputStream MCPEODHLBFC;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3B0F9C0", Offset = "0x3B0E7C0", VA = "0x183B0F9C0")]
	private HNGGPHFFDPI(byte[] PLHMHNJGNNB, in Protobuf FODHHFDFGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2A99F00", Offset = "0x2A98D00", VA = "0x182A99F00")]
	public static HNGGPHFFDPI<Protobuf> FLOGCKGNDEE<T>(ReadOnlySpan<T> BAHBPPHMFLI)
	{
		return default(HNGGPHFFDPI<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B0F7D0", Offset = "0x3B0E5D0", VA = "0x183B0F7D0")]
	public void ALNDEOOAEBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B0F930", Offset = "0x3B0E730", VA = "0x183B0F930")]
	public ByteString HGKGAMDPANG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B0F800", Offset = "0x3B0E600", VA = "0x183B0F800", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class MMBOIHGCODO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class FPNKPAOHBOD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static T KKLNCEHOHED;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static bool KFLNDDALKGN;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x36DA5A0", Offset = "0x36D93A0", VA = "0x1836DA5A0")]
		public static void DFMCNBMFALI(in T ALOICDECJNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public FPNKPAOHBOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly IBKLHAEEEEI EKFPDHJKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeHashMap<LIAAOIDECMB, int2> OIJCAFCJKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NativeList<byte> PLHMHNJGNNB;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC240", Offset = "0x6ACB040", VA = "0x186ACC240")]
	public MMBOIHGCODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2823490", Offset = "0x2822290", VA = "0x182823490")]
	public void MDELLMLPPIN<T>(T KKLNCEHOHED) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2820DE0", Offset = "0x281FBE0", VA = "0x182820DE0")]
	public T KOLGIMOOKDG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBFE0", Offset = "0x6ACADE0", VA = "0x186ACBFE0")]
	public void MDELLMLPPIN(Type LKLFHGBOOLP, BIABKMPNANG KKLNCEHOHED, int OHILEHDBMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB810", Offset = "0x6ACA610", VA = "0x186ACB810")]
	public bool BBJAFPAMNLG(Type LKLFHGBOOLP, out BIABKMPNANG FAJCHBCCGOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBF10", Offset = "0x6ACAD10", VA = "0x186ACBF10")]
	public BIABKMPNANG KOLGIMOOKDG(Type LKLFHGBOOLP)
	{
		return default(BIABKMPNANG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB980", Offset = "0x6ACA780", VA = "0x186ACB980")]
	public NativeArray<byte>.ReadOnly FBENKFGINGA(Type LKLFHGBOOLP)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBD80", Offset = "0x6ACAB80", VA = "0x186ACBD80")]
	public bool HDCHNONJANO(Type LKLFHGBOOLP, out NativeArray<byte>.ReadOnly FAJCHBCCGOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB8E0", Offset = "0x6ACA6E0", VA = "0x186ACB8E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBC60", Offset = "0x6ACAA60", VA = "0x186ACBC60", Slot = "1")]
	~MMBOIHGCODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBB90", Offset = "0x6ACA990", VA = "0x186ACBB90")]
	private NativeArray<byte>.ReadOnly FJMADGBINMA(int2 HGBFNNBIFPN)
	{
		return default(NativeArray<byte>.ReadOnly);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PANAMJAKCEP<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T ODIKHJJHMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x38EFB60", Offset = "0x38EE960", VA = "0x1838EFB60")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x38ECB20", Offset = "0x38EB920", VA = "0x1838ECB20")]
	public static PANAMJAKCEP<T> HAJGNNHEPJI(T KKLNCEHOHED)
	{
		return default(PANAMJAKCEP<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x38ED890", Offset = "0x38EC690", VA = "0x1838ED890")]
	public static T HAJGNNHEPJI(PANAMJAKCEP<T> DGNBLLFJDJH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NJPNEABJEHD
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static MMBOIHGCODO PGEAAGKDPHA;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x340CA80", Offset = "0x340B880", VA = "0x18340CA80")]
	public static void MDELLMLPPIN<T>(T KKLNCEHOHED) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x340BB80", Offset = "0x340A980", VA = "0x18340BB80")]
	public static T KOLGIMOOKDG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC380", Offset = "0x6ACB180", VA = "0x186ACC380")]
	public static NativeArray<byte>.ReadOnly FBENKFGINGA(Type LKLFHGBOOLP)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC2F0", Offset = "0x6ACB0F0", VA = "0x186ACC2F0")]
	public static bool BBJAFPAMNLG(Type LKLFHGBOOLP, out BIABKMPNANG FAJCHBCCGOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct MGEJDLDGPCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int FHMAJLHBFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int FNLBOMKPGBB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BGAJCPLBEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA2A950", Offset = "0xA29750", VA = "0x180A2A950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD1D510", Offset = "0xD1C310", VA = "0x180D1D510")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x19316E0", Offset = "0x19304E0", VA = "0x1819316E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FIFFBLDOLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA2A950", Offset = "0xA29750", VA = "0x180A2A950")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAFF400", Offset = "0xAFE200", VA = "0x180AFF400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EBLHJDEJOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6ACB6D0", Offset = "0x6ACA4D0", VA = "0x186ACB6D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6ACB6E0", Offset = "0x6ACA4E0", VA = "0x186ACB6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x866E30", Offset = "0x865C30", VA = "0x180866E30")]
	private MGEJDLDGPCB(int FHMAJLHBFAD, int FNLBOMKPGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3F44A10", Offset = "0x3F43810", VA = "0x183F44A10")]
	public static MGEJDLDGPCB KENGDHJGBJK(int FHMAJLHBFAD, int FNLBOMKPGBB)
	{
		return default(MGEJDLDGPCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB6C0", Offset = "0x6ACA4C0", VA = "0x186ACB6C0")]
	public static MGEJDLDGPCB ABPICKIDIFL(int IOEACHBFFDL, int IJAHGCHCONN)
	{
		return default(MGEJDLDGPCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB6F0", Offset = "0x6ACA4F0", VA = "0x186ACB6F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct PBDBAHPMLNK : LKFNFPNPOFA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD1A0", Offset = "0x6ACBFA0", VA = "0x186ACD1A0")]
	public float FMAJCHENIPN(in float3 KKLNCEHOHED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD1A0", Offset = "0x6ACBFA0", VA = "0x186ACD1A0", Slot = "4")]
	private float MJPCIEDLOJF(in float3 KKLNCEHOHED)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JBMPIAKDBHE : LKFNFPNPOFA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9520", Offset = "0x6AC8320", VA = "0x186AC9520")]
	public float FMAJCHENIPN(in float3 KKLNCEHOHED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9520", Offset = "0x6AC8320", VA = "0x186AC9520", Slot = "4")]
	private float MJPCIEDLOJF(in float3 KKLNCEHOHED)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MKNLPMIAFLO : LKFNFPNPOFA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1CED810", Offset = "0x1CEC610", VA = "0x181CED810")]
	public float FMAJCHENIPN(in float3 KKLNCEHOHED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1CED810", Offset = "0x1CEC610", VA = "0x181CED810", Slot = "4")]
	private float MJPCIEDLOJF(in float3 KKLNCEHOHED)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OEOHHAPFMPD : LKFNFPNPOFA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1307A80", Offset = "0x1306880", VA = "0x181307A80")]
	public int FMAJCHENIPN(in int3 KKLNCEHOHED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1307A80", Offset = "0x1306880", VA = "0x181307A80", Slot = "4")]
	private int MAOGFJLHMGO(in int3 KKLNCEHOHED)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct DBNFOKDNLFH : LKFNFPNPOFA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x66E25D0", Offset = "0x66E13D0", VA = "0x1866E25D0")]
	public int FMAJCHENIPN(in int3 KKLNCEHOHED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x66E25D0", Offset = "0x66E13D0", VA = "0x1866E25D0", Slot = "4")]
	private int MAOGFJLHMGO(in int3 KKLNCEHOHED)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KGDCNAEGIAA : LKFNFPNPOFA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2BB19E0", Offset = "0x2BB07E0", VA = "0x182BB19E0")]
	public int FMAJCHENIPN(in int3 KKLNCEHOHED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2BB19E0", Offset = "0x2BB07E0", VA = "0x182BB19E0", Slot = "4")]
	private int MAOGFJLHMGO(in int3 KKLNCEHOHED)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[BurstCompile]
internal struct BIGCOKLGGCK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public ComponentDataFromEntity GMBGFBNMHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<Entity> FEMLCDGNFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeList<Entity> FLDNGACCIPM;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6AC49D0", Offset = "0x6AC37D0", VA = "0x186AC49D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GNAFDKDMJAN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Type LPGAGGMGHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Type[] OFOJNHAEGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class DLNFDGOHKLI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly World JNDJAEGBBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly World ICIDHCMDIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly ENBGCIGLEDL HKCGFEJFHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly ComponentSystemGroup[] IBACMLEKINO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public World ABKBCFGBHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public World EMCFKMKNNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EntityManager FOKKLIPOJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6AC55C0", Offset = "0x6AC43C0", VA = "0x186AC55C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ENBGCIGLEDL FJKAOBGGDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public OJFOOOKIOHD<PADCBKIDDOD> OOBLCKOEMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x952E30", Offset = "0x951C30", VA = "0x180952E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public OJFOOOKIOHD<KPCIKMODEPA> OHKCKLMFBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x916A30", Offset = "0x915830", VA = "0x180916A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public OJFOOOKIOHD<KIBLHGFGPLO> IJIKLKKLKAH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x922C40", Offset = "0x921A40", VA = "0x180922C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> JNLGKDEJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3D23820", Offset = "0x3D22620", VA = "0x183D23820")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ComponentSystemGroup[] DANOJJIEHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4ED0", Offset = "0x6AC3CD0", VA = "0x186AC4ED0")]
	public static DLNFDGOHKLI GCPOIJOGLCF(string PPPOJKMOIGD, KFPAFMBJBMO KCEKDHFAAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5760", Offset = "0x6AC4560", VA = "0x186AC5760")]
	public DLNFDGOHKLI(string PPPOJKMOIGD, KFPAFMBJBMO KCEKDHFAAAO = KFPAFMBJBMO.Simulation, NAKEIOKHACF MALOLNGNBCO = NAKEIOKHACF.Default, bool CONMELFNDPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4EB0", Offset = "0x6AC3CB0", VA = "0x186AC4EB0")]
	public ComponentSystemBase EIACBMNJFAP(Type LKLFHGBOOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDB80", Offset = "0x2EEC980", VA = "0x182EEDB80")]
	public T EIACBMNJFAP<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5640", Offset = "0x6AC4440", VA = "0x186AC5640")]
	public void NOCHFNEEEHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AC51B0", Offset = "0x6AC3FB0", VA = "0x186AC51B0")]
	public void KKJNKHOLJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6AC55E0", Offset = "0x6AC43E0", VA = "0x186AC55E0")]
	public void NLFPEFIEGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5210", Offset = "0x6AC4010", VA = "0x186AC5210")]
	public void KOHDINJOFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC56A0", Offset = "0x6AC44A0", VA = "0x186AC56A0")]
	public void NOLNIGPOBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5060", Offset = "0x6AC3E60", VA = "0x186AC5060")]
	public void IFMKCNHEFGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4DE0", Offset = "0x6AC3BE0", VA = "0x186AC4DE0")]
	public void DKDALALMDCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC50C0", Offset = "0x6AC3EC0", VA = "0x186AC50C0")]
	public void JBBDJLKCPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5150", Offset = "0x6AC3F50", VA = "0x186AC5150")]
	public void JFGOGMOEGJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5700", Offset = "0x6AC4500", VA = "0x186AC5700")]
	public void PHCKHMOPFGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4D00", Offset = "0x6AC3B00", VA = "0x186AC4D00")]
	internal void CEFMPEDNCPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5540", Offset = "0x6AC4340", VA = "0x186AC5540")]
	private bool MNBACEKKNAJ(ComponentSystemGroup LMNBADHDHAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5270", Offset = "0x6AC4070", VA = "0x186AC5270")]
	private void MADFKLPAKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4F50", Offset = "0x6AC3D50", VA = "0x186AC4F50")]
	private ComponentSystemGroup[] IEGLKFDKGLN(NAKEIOKHACF MALOLNGNBCO, bool CAFGJLKECAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4E40", Offset = "0x6AC3C40", VA = "0x186AC4E40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class LJPNMHGCJJK
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB500", Offset = "0x6ACA300", VA = "0x186ACB500")]
	[MustUseReturnValue]
	public static JobHandle OAOMDNGCOLD(this EntityCommandBufferSystem DLEOHIDEOHO, NativeList<Entity> KHPJJPHILOJ, [Optional] JobHandle KFKJELHPNAC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB400", Offset = "0x6ACA200", VA = "0x186ACB400")]
	[MustUseReturnValue]
	public static JobHandle OAOMDNGCOLD(this EntityCommandBufferSystem DLEOHIDEOHO, NativeArrayAsync<Entity> KHPJJPHILOJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class PHDPLEEIBNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3FB17B0", Offset = "0x3FB05B0", VA = "0x183FB17B0")]
	public static void NPOEPENFLJM<T>(this EntityCommandBufferSystem DLEOHIDEOHO, EntityQuery HNJMIAEHBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3FB1570", Offset = "0x3FB0370", VA = "0x183FB1570")]
	[MustUseReturnValue]
	public static JobHandle BODOFLNBKIK<T>(this EntityCommandBufferSystem DLEOHIDEOHO, NativeListAsync<Entity> KHPJJPHILOJ, [Optional] JobHandle KFKJELHPNAC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3FB0F70", Offset = "0x3FAFD70", VA = "0x183FB0F70")]
	[MustUseReturnValue]
	public static JobHandle BODOFLNBKIK<T>(this EntityCommandBufferSystem DLEOHIDEOHO, NativeArrayAsync<Entity> KHPJJPHILOJ, [Optional] JobHandle KFKJELHPNAC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
public class ENBGCIGLEDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly DLNFDGOHKLI JNDJAEGBBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly EntityManager HCPDBMFJKPJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DLNFDGOHKLI ABKBCFGBHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7680", Offset = "0x6AC6480", VA = "0x186AC7680")]
	public ENBGCIGLEDL(DLNFDGOHKLI JNDJAEGBBCD, EntityManager HCPDBMFJKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5916EF0", Offset = "0x5915CF0", VA = "0x185916EF0")]
	public bool IEBGIAAJNCG<T>(Entity FPIIEOBJDDB) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5916E60", Offset = "0x5915C60", VA = "0x185916E60")]
	public bool GFAAKMLPGKA<T>(Entity FPIIEOBJDDB, out T KKLNCEHOHED) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5915310", Offset = "0x5914110", VA = "0x185915310")]
	public T DGLKIMDNLGJ<T>(Entity FPIIEOBJDDB) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5916F30", Offset = "0x5915D30", VA = "0x185916F30")]
	private ComponentType KKPODHIGJGP<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AC74F0", Offset = "0x6AC62F0", VA = "0x186AC74F0")]
	private ComponentType KKPODHIGJGP(Type LKLFHGBOOLP)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class DCEHGDGCAGA
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct HGACPDBMHAN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public NativeArray<Entity> HFAAHCEMPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public NativeArray<T> ODOFECAJCEP;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct DNHJOKPNFHJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public NativeList<Entity> HFAAHCEMPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public NativeArray<T> ODOFECAJCEP;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct CHENAMDOLJI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NativeArrayAsync<Entity> HFAAHCEMPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NativeArrayAsync<T> ODOFECAJCEP;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3150370", Offset = "0x314F170", VA = "0x183150370")]
		public NativeListAsync<Entity> DGKAGCDIIHH<TPredicate>() where TPredicate : struct, FKDFHBPMIIB<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2EE5CE0", Offset = "0x2EE4AE0", VA = "0x182EE5CE0")]
	public static CHENAMDOLJI<T> AJCOLFPPFAH<T>(this NativeArrayAsync<Entity> FEMLCDGNFNL, NativeArrayAsync<T> KAPHOKPKPAO, Allocator FIPHDKMNFDJ = Allocator.TempJob) where T : struct
	{
		return default(CHENAMDOLJI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JAPIDDHKJEP : PDCIMEOLOCL
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Type JGOAMCPHIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F63B0", Offset = "0x7F51B0", VA = "0x1807F63B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6AC94D0", Offset = "0x6AC82D0", VA = "0x186AC94D0")]
	public JAPIDDHKJEP(Type EGGBDINLDHC, Type GMBGFBNMHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class ILGFCIADDDA
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct ECCDNMCFOIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly Dictionary<Type, List<Type>> AHLNBAEDOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly HashSet<Type> DHBIABOMBKP;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xAFE080", Offset = "0xAFCE80", VA = "0x180AFE080")]
	public ECCDNMCFOIH(Dictionary<Type, List<Type>> AHLNBAEDOBO, HashSet<Type> DHBIABOMBKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct FGJEENAODMP
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PHNHKOOOMOP : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Type <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private IEnumerable<Type> types;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IEnumerable<Type> <>3__types;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public FGJEENAODMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public FGJEENAODMP <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private IEnumerator<Type> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Type <type>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool <allow>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		Type IEnumerator<Type>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xD2EFB0", Offset = "0xD2DDB0", VA = "0x180D2EFB0")]
		[DebuggerHidden]
		public PHNHKOOOMOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD520", Offset = "0x6ACC320", VA = "0x186ACD520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD260", Offset = "0x6ACC060", VA = "0x186ACD260", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD210", Offset = "0x6ACC010", VA = "0x186ACD210")]
		private void KJLKGHHLDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD4E0", Offset = "0x6ACC2E0", VA = "0x186ACD4E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD430", Offset = "0x6ACC230", VA = "0x186ACD430", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD430", Offset = "0x6ACC230", VA = "0x186ACD430", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct DPENOMHPMEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Dictionary<Type, List<Type>> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Queue<Type> queue;
	}

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly IBKLHAEEEEI EKFPDHJKIFI;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly Type FCLFDIBEEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private NAKEIOKHACF MALOLNGNBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private bool KLDLJBBJJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool CPHOIDGEHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool CAFGJLKECAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private IEnumerable<Type> AHANELPAGLF;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8260", Offset = "0x6AC7060", VA = "0x186AC8260")]
	public static FGJEENAODMP FLOGCKGNDEE()
	{
		return default(FGJEENAODMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8820", Offset = "0x6AC7620", VA = "0x186AC8820")]
	public FGJEENAODMP PAEGBKOFMFN(NAKEIOKHACF KCEKDHFAAAO)
	{
		return default(FGJEENAODMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8560", Offset = "0x6AC7360", VA = "0x186AC8560")]
	public FGJEENAODMP IIHOBLHAJFB(IEnumerable<Type> MECLDLOMGDJ)
	{
		return default(FGJEENAODMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8760", Offset = "0x6AC7560", VA = "0x186AC8760")]
	public FGJEENAODMP JDHKHDENKKL(bool GGCAMCNFCOF)
	{
		return default(FGJEENAODMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8810", Offset = "0x6AC7610", VA = "0x186AC8810")]
	public FGJEENAODMP NMAEDGMPNID(bool LFMFJFKIION)
	{
		return default(FGJEENAODMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8770", Offset = "0x6AC7570", VA = "0x186AC8770")]
	public ECCDNMCFOIH KEMDHBLHPIE(Type[] BHIAKCCKJNA)
	{
		return default(ECCDNMCFOIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7920", Offset = "0x6AC6720", VA = "0x186AC7920")]
	[IteratorStateMachine(typeof(PHNHKOOOMOP))]
	internal IEnumerable<Type> BKEPLGJDGEB(IEnumerable<Type> MECLDLOMGDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8280", Offset = "0x6AC7080", VA = "0x186AC8280")]
	internal Dictionary<Type, List<Type>> HOGNKOLIHOK(IEnumerable<Type> MECLDLOMGDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7B10", Offset = "0x6AC6910", VA = "0x186AC7B10")]
	private void CLCICCPDCKE(Dictionary<Type, List<Type>> OINDOPOHBIG, Type LKLFHGBOOLP, Type NBKHAJMEHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6AC85A0", Offset = "0x6AC73A0", VA = "0x186AC85A0")]
	internal HashSet<Type> IPJCAKLBCKO(IEnumerable<Type> IBACMLEKINO, Dictionary<Type, List<Type>> BFOFBGJCGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7C20", Offset = "0x6AC6A20", VA = "0x186AC7C20")]
	internal bool DILCJAOKAFP(Type LKLFHGBOOLP, NAKEIOKHACF MALOLNGNBCO, bool CAFGJLKECAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6AC79B0", Offset = "0x6AC67B0", VA = "0x186AC79B0")]
	[CompilerGenerated]
	internal static void CGAPHOCIPKG(Type LKLFHGBOOLP, ref DPENOMHPMEP P_1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class PGAEMKPIKFH
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3DCEC10", Offset = "0x3DCDA10", VA = "0x183DCEC10")]
	public static NativeList<Entity> AJKHKNKPCMJ<T>(this NativeArray<Entity> FEMLCDGNFNL, EntityManager HCPDBMFJKPJ, Allocator FIPHDKMNFDJ = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class MPIHMGAPMJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct DCFCBPOBHAP : LKFNFPNPOFA<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> FFIDMEPNECE;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4CF0", Offset = "0x6AC3AF0", VA = "0x186AC4CF0")]
		[BurstCompatible]
		public Entity FMAJCHENIPN(in Entity KKLNCEHOHED)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4CF0", Offset = "0x6AC3AF0", VA = "0x186AC4CF0", Slot = "4")]
		private Entity IJMKOLDNJML(in Entity KKLNCEHOHED)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class CFIOJEDMCKN
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4AA0", Offset = "0x6AC38A0", VA = "0x186AC4AA0")]
	public static bool BNFPFPDEBFD(Type LKLFHGBOOLP, Type MFIMMKMOMGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class EPEAFDIJKJK : LNKKKKNCPLC
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7850", Offset = "0x6AC6650", VA = "0x186AC7850", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase EKHHEKCBHHN();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6AC77B0", Offset = "0x6AC65B0", VA = "0x186AC77B0")]
	protected ComponentSystemBase EFHJIGOLFHL(params ComponentSystemBase[] DHBIABOMBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x319FF50", Offset = "0x319ED50", VA = "0x18319FF50")]
	protected ComponentSystemBase EFHJIGOLFHL<T>(params ComponentSystemBase[] DHBIABOMBKP) where T : LNKKKKNCPLC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x31A0040", Offset = "0x319EE40", VA = "0x1831A0040")]
	protected ComponentSystemBase ILEAFJKJFAB<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x31A0040", Offset = "0x319EE40", VA = "0x1831A0040")]
	protected ComponentSystemBase NIDMLOENNDK<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7800", Offset = "0x6AC6600", VA = "0x186AC7800")]
	protected ComponentSystemBase JLHGJAODCIG(params SystemHandleUntyped[] DHBIABOMBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x31A0080", Offset = "0x319EE80", VA = "0x1831A0080")]
	protected ComponentSystemBase JLHGJAODCIG<T>(params SystemHandleUntyped[] DHBIABOMBKP) where T : LNKKKKNCPLC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x319FFF0", Offset = "0x319EDF0", VA = "0x18319FFF0")]
	protected SystemHandleUntyped GCFHJLOBDDD<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC78A0", Offset = "0x6AC66A0", VA = "0x186AC78A0")]
	protected EPEAFDIJKJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface GJPAOKGJIED<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BBJPLADBJND(int LMGCLJPIIAF);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OJFOOOKIOHD<BaseClass> FMCBJGJJEHN();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class FLAKIKMAJIM
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x233ACE0", Offset = "0x2339AE0", VA = "0x18233ACE0")]
	public static NativeList<T> FNEKIHPGNKN<T>(NativeList<T> KAPHOKPKPAO, Allocator FIPHDKMNFDJ) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KMMEFNEJFKK
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct GKCPLIFHFHO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : LKFNFPNPOFA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[ReadOnly]
	public NativeArray<TFrom> ODOFECAJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeList<TFrom> EFFIEOKIBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeHashSet<TTo> FIJKCKMMGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public TMap EHPEOJCHKEM;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct COBGJEDPLIN<T, TPredicate> : IJob where T : struct where TPredicate : struct, FKDFHBPMIIB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public NativeArray<T> ODOFECAJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> HFAAHCEMPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> JOGAIJGFMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public TPredicate EHPEOJCHKEM;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x38FC940", Offset = "0x38FB740", VA = "0x1838FC940", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct AKNOCKJEFEM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, LKFNFPNPOFA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	public NativeArray<TFrom> NECIAEMLOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[WriteOnly]
	public NativeList<TTo> ACAGHAMJAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public TMap EHPEOJCHKEM;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[AttributeUsage(AttributeTargets.Class)]
public sealed class GMMFGJPMOLA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NAKEIOKHACF DMEPDCPLCDO;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class HCPAJIDFLPM : KCJOIADENAN<JAPIDDHKJEP, PADCBKIDDOD>
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9110", Offset = "0x6AC7F10", VA = "0x186AC9110")]
	public HCPAJIDFLPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal abstract class KCJOIADENAN<Attribute, BaseClass> : GJPAOKGJIED<BaseClass>, PHJLEKFCCGF where Attribute : PDCIMEOLOCL
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static readonly IBKLHAEEEEI EKFPDHJKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly string PPPOJKMOIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly Dictionary<int, Type> GKJLAAMIBJG;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4191C50", Offset = "0x4190A50", VA = "0x184191C50")]
	public KCJOIADENAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x41915E0", Offset = "0x41903E0", VA = "0x1841915E0", Slot = "4")]
	public bool BBJPLADBJND(int LMGCLJPIIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x41917D0", Offset = "0x41905D0", VA = "0x1841917D0", Slot = "5")]
	public OJFOOOKIOHD<BaseClass> FMCBJGJJEHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4191640", Offset = "0x4190440", VA = "0x184191640", Slot = "7")]
	protected virtual bool BNFPFPDEBFD(Type LKLFHGBOOLP, int KCJCGDOHNNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4191A80", Offset = "0x4190880", VA = "0x184191A80", Slot = "8")]
	protected virtual int LHKDLJICNPC(Type LKLFHGBOOLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4191740", Offset = "0x4190540", VA = "0x184191740")]
	public void DHFPPHBCEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4191B10", Offset = "0x4190910", VA = "0x184191B10", Slot = "6")]
	public void MAHHBIDHLIK(Type LKLFHGBOOLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DOFPLMHKLIO
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private struct HFDBLMPDKML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly ulong IMBFEAAJKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly HGKLBBJOGLP ENJBAMDPIAD;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x866900", Offset = "0x865700", VA = "0x180866900")]
		public HFDBLMPDKML(ulong AHLCCFANKAD, HGKLBBJOGLP BJAFIDLDHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9180", Offset = "0x6AC7F80", VA = "0x186AC9180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class LHGILIEJGLB : IEnumerable<HGKLBBJOGLP>, IEnumerable, IEnumerator<HGKLBBJOGLP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private HGKLBBJOGLP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private ulong nameHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public ulong <>3__nameHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private IEnumerator<KGJJNEDIOGJ> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private KGJJNEDIOGJ <attrib>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private HGKLBBJOGLP System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Attributes.NameHash>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HGKLBBJOGLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB2F0", Offset = "0x6ACA0F0", VA = "0x186ACB2F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD2EFB0", Offset = "0xD2DDB0", VA = "0x180D2EFB0")]
		[DebuggerHidden]
		public LHGILIEJGLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6ACB340", Offset = "0x6ACA140", VA = "0x186ACB340", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6ACAF90", Offset = "0x6AC9D90", VA = "0x186ACAF90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6ACAF40", Offset = "0x6AC9D40", VA = "0x186ACAF40")]
		private void KJLKGHHLDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6ACB2B0", Offset = "0x6ACA0B0", VA = "0x186ACB2B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6ACB200", Offset = "0x6ACA000", VA = "0x186ACB200", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HGKLBBJOGLP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Attributes.NameHash>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6ACB200", Offset = "0x6ACA000", VA = "0x186ACB200", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly IBKLHAEEEEI EKFPDHJKIFI;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly Type EJIPLMHNBLB;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static Dictionary<ulong, int> KKAGDDJBFLI;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static HFDBLMPDKML[] ECKOIDGIIEP;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static bool KFLNDDALKGN;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6170", Offset = "0x6AC4F70", VA = "0x186AC6170")]
	public static ulong BKOGKKAGGDP(int LMGCLJPIIAF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AC61D0", Offset = "0x6AC4FD0", VA = "0x186AC61D0")]
	public static int CGNOFLJINLC(ulong BJAFIDLDHHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6900", Offset = "0x6AC5700", VA = "0x186AC6900")]
	public static void HFKECJNCAPE(bool CONMELFNDPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6AC66D0", Offset = "0x6AC54D0", VA = "0x186AC66D0")]
	private static void DIEMPEEJDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6400", Offset = "0x6AC5200", VA = "0x186AC6400")]
	private static void DIEMPEEJDOH(IEnumerable<Type> MECLDLOMGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6820", Offset = "0x6AC5620", VA = "0x186AC6820")]
	private static void GJPCLAJMDCL(int MALCPFFPEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5E10", Offset = "0x6AC4C10", VA = "0x186AC5E10")]
	private static void BEBPMCAIAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6280", Offset = "0x6AC5080", VA = "0x186AC6280")]
	private static (ulong, IEnumerable<HGKLBBJOGLP>) CJPKAJDGGIL(Type LKLFHGBOOLP)
	{
		return default((ulong, IEnumerable<HGKLBBJOGLP>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5C80", Offset = "0x6AC4A80", VA = "0x186AC5C80")]
	[IteratorStateMachine(typeof(LHGILIEJGLB))]
	private static IEnumerable<HGKLBBJOGLP> AHAJFKPNJNE(Type LKLFHGBOOLP, ulong BJAFIDLDHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6B50", Offset = "0x6AC5950", VA = "0x186AC6B50")]
	private static void JBCPBAPLINH(ulong BJAFIDLDHHH, IEnumerable<HGKLBBJOGLP> IOJDEDIBKLO, TypeManager.TypeInfo IDIILDFAOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5D10", Offset = "0x6AC4B10", VA = "0x186AC5D10")]
	private static void AOPJOKGCGPC(HFDBLMPDKML IDIILDFAOIA, int LMGCLJPIIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6E50", Offset = "0x6AC5C50", VA = "0x186AC6E50")]
	private static void LGKEOBMLHII(HFDBLMPDKML IDIILDFAOIA, int LMGCLJPIIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6790", Offset = "0x6AC5590", VA = "0x186AC6790")]
	private static HFDBLMPDKML DONLBKCOKEA(int LMGCLJPIIAF)
	{
		return default(HFDBLMPDKML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6F40", Offset = "0x6AC5D40", VA = "0x186AC6F40")]
	private static int NCMOBCMGMEK(int LMGCLJPIIAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LKMNDHOMKOI
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct BOELLHKFNFG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly NativeArray<T>.ReadOnly PKPHLPFOPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int DIDHGEABMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int MCGJHODLCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private T MFFEECAHGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private T HDMOJKBCEBH;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public MGEJDLDGPCB BBAIOHMIHDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x3763E30", Offset = "0x3762C30", VA = "0x183763E30")]
			get
			{
				return default(MGEJDLDGPCB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T HAJABPIIGGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x2A29C30", Offset = "0x2A28A30", VA = "0x182A29C30")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (T, MGEJDLDGPCB) CFKFFOLONBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x3CD92F0", Offset = "0x3CD80F0", VA = "0x183CD92F0")]
			get
			{
				return default((T, MGEJDLDGPCB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9500", Offset = "0x3CD8300", VA = "0x183CD9500")]
		public BOELLHKFNFG(NativeArray<T> PKPHLPFOPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x367F8A0", Offset = "0x367E6A0", VA = "0x18367F8A0")]
		public BOELLHKFNFG<T> JOJADCJMMBH()
		{
			return default(BOELLHKFNFG<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9160", Offset = "0x3CD7F60", VA = "0x183CD9160")]
		public bool CHKPILOCJDD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3150000", Offset = "0x314EE00", VA = "0x183150000")]
		public GIJPPMNKBOJ<T, TComparer> DCOMABEFBPF<TComparer>([Optional] TComparer HMGFDJPFEJK) where TComparer : struct, IEqualityComparer<T>
		{
			return default(GIJPPMNKBOJ<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct GIJPPMNKBOJ<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<T>.ReadOnly PKPHLPFOPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int DIDHGEABMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int MCGJHODLCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T MFFEECAHGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private T HDMOJKBCEBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TComparer HMGFDJPFEJK;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public MGEJDLDGPCB BBAIOHMIHDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x3763E30", Offset = "0x3762C30", VA = "0x183763E30")]
			get
			{
				return default(MGEJDLDGPCB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T HAJABPIIGGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x2A29C30", Offset = "0x2A28A30", VA = "0x182A29C30")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T value, MGEJDLDGPCB range) CFKFFOLONBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x3763D20", Offset = "0x3762B20", VA = "0x183763D20")]
			get
			{
				return default((T, MGEJDLDGPCB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3763E40", Offset = "0x3762C40", VA = "0x183763E40")]
		public GIJPPMNKBOJ(NativeArray<T>.ReadOnly PKPHLPFOPGM, TComparer HMGFDJPFEJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3763DF0", Offset = "0x3762BF0", VA = "0x183763DF0")]
		public GIJPPMNKBOJ<T, TComparer> JOJADCJMMBH()
		{
			return default(GIJPPMNKBOJ<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3763AC0", Offset = "0x37628C0", VA = "0x183763AC0")]
		public bool CHKPILOCJDD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x301E5C0", Offset = "0x301D3C0", VA = "0x18301E5C0")]
	public static BOELLHKFNFG<T> EFHJIGOLFHL<T>(this NativeArray<T> PKPHLPFOPGM) where T : struct
	{
		return default(BOELLHKFNFG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface LKFNFPNPOFA<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo FMAJCHENIPN(in TFrom KKLNCEHOHED);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class PALCBOAECBE
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CPHAJPDOLAF
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class JODIEIHKFPO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		public JODIEIHKFPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class EEAGIIKFEGN<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		public EEAGIIKFEGN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly List<Func<JobHandle, JobHandle>> BEDBJGINCFD;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4C70", Offset = "0x6AC3A70", VA = "0x186AC4C70")]
	public CPHAJPDOLAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class KFCNJMIDIKH
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class LJHIBEGOPMP : EntityCommandBufferSystem, MOPFHGEKGDK
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
	protected LJHIBEGOPMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LAAGHADNKEC
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2E52A50", Offset = "0x2E51850", VA = "0x182E52A50")]
	[MustUseReturnValue]
	public static JobHandle LNMADGNFPFB<T>(this EntityCommandBufferSystem DLEOHIDEOHO, NativeArray<Entity> KHPJJPHILOJ, NativeArray<T> FAJCHBCCGOJ, JobHandle KFKJELHPNAC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct KFDLIJNHOCC<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	public NativeArray<T> ODOFECAJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<T> EFFIEOKIBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeHashSet<T> FIJKCKMMGEF;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x41983D0", Offset = "0x41971D0", VA = "0x1841983D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class OJFOOOKIOHD<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<int, BaseClass> DBBNELOKBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly Dictionary<Type, BaseClass> NLLHALKLPML;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x27D2D30", Offset = "0x27D1B30", VA = "0x1827D2D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IEnumerable<BaseClass> IDCJIKHMHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4AF2310", Offset = "0x4AF1110", VA = "0x184AF2310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4AF26E0", Offset = "0x4AF14E0", VA = "0x184AF26E0")]
	public OJFOOOKIOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4AF2540", Offset = "0x4AF1340", VA = "0x184AF2540")]
	public OJFOOOKIOHD(int OFPPAGPDNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4AF2290", Offset = "0x4AF1090", VA = "0x184AF2290")]
	internal void IMFFJGIMDFG(int LMGCLJPIIAF, BaseClass HKCGFEJFHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3B65190", Offset = "0x3B63F90", VA = "0x183B65190")]
	public bool EDABFNJJKJC<T>(out BaseClass KKLNCEHOHED) where T : IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4AF21F0", Offset = "0x4AF0FF0", VA = "0x184AF21F0")]
	public bool EDABFNJJKJC(Type OPBKILPABOM, out BaseClass KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x43F9BD0", Offset = "0x43F89D0", VA = "0x1843F9BD0")]
	public bool KACOOMPCCNL(int LMGCLJPIIAF, out BaseClass KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3B650B0", Offset = "0x3B63EB0", VA = "0x183B650B0")]
	public T AOOELCPKJEF<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4AF21C0", Offset = "0x4AF0FC0", VA = "0x184AF21C0")]
	public BaseClass AOOELCPKJEF(Type EGPFJNOCPHG)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class ONHOMADHILG : KCJOIADENAN<GMNJFJDOCKL, KPCIKMODEPA>
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCD90", Offset = "0x6ACBB90", VA = "0x186ACCD90")]
	public ONHOMADHILG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct PFPFMOCOHGE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public NativeArray<Entity> KHPJJPHILOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public EntityCommandBuffer BIIIPDFACJO;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD1B0", Offset = "0x6ACBFB0", VA = "0x186ACD1B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class DFHMABEEIOD
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2EE73B0", Offset = "0x2EE61B0", VA = "0x182EE73B0")]
	public static NativeArray<T> FELKHAJFLNB<T>(this NativeList<Entity> KAPHOKPKPAO, EntityManager HCPDBMFJKPJ, Allocator FIPHDKMNFDJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2EE7140", Offset = "0x2EE5F40", VA = "0x182EE7140")]
	public static NativeArray<T> FELKHAJFLNB<T>(this NativeArray<Entity> KAPHOKPKPAO, EntityManager HCPDBMFJKPJ, Allocator FIPHDKMNFDJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface AEGCEFPBMFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class DFKJKDEMPNC
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal struct HLLCLFMLMIF<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	public NativeArray<Entity> KHPJJPHILOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public T KKLNCEHOHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public EntityCommandBuffer BIIIPDFACJO;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3B03F00", Offset = "0x3B02D00", VA = "0x183B03F00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class CLPFCHBPBIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2E88580", Offset = "0x2E87380", VA = "0x182E88580")]
	[MustUseReturnValue]
	public static JobHandle PKJDDLPKOKK<T>(this EntityCommandBufferSystem DLEOHIDEOHO, EntityCommandBuffer BIIIPDFACJO, EntityQuery HNJMIAEHBAM, T KKLNCEHOHED) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2E884A0", Offset = "0x2E872A0", VA = "0x182E884A0")]
	[MustUseReturnValue]
	public static JobHandle PKJDDLPKOKK<T>(this EntityCommandBufferSystem DLEOHIDEOHO, NativeArrayAsync<Entity> KHPJJPHILOJ, NativeArrayAsync<T> KKLNCEHOHED) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2E88330", Offset = "0x2E87130", VA = "0x182E88330")]
	[MustUseReturnValue]
	public static JobHandle PKJDDLPKOKK<T>(this EntityCommandBufferSystem DLEOHIDEOHO, EntityCommandBuffer BIIIPDFACJO, NativeArrayAsync<Entity> KHPJJPHILOJ, NativeArrayAsync<T> KKLNCEHOHED) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class FPJCJJBCAMD : KCJOIADENAN<AMKLKGACMBL, KIBLHGFGPLO>
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8A80", Offset = "0x6AC7880", VA = "0x186AC8A80")]
	public FPJCJJBCAMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class BOLGPBIJHND<Data> : KPCIKMODEPA where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public virtual Data KBEILLGFBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x33F41A0", Offset = "0x33F2FA0", VA = "0x1833F41A0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x81CAA0", Offset = "0x81B8A0", VA = "0x18081CAA0", Slot = "8")]
	protected virtual bool AFFLCNIGHEC(ReadOnlySpan<Data> BAHBPPHMFLI, GFGJKKDFHMJ DAMGGCLMGDB, out ReadOnlySpan<byte> NCMINFKEPHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x81CAB0", Offset = "0x81B8B0", VA = "0x18081CAB0", Slot = "9")]
	protected virtual bool EEKBIHHINCO(int OAFCEFJIFII, Span<Data> BAHBPPHMFLI, in ReadOnlySpan<byte> NCMINFKEPHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x33F40C0", Offset = "0x33F2EC0", VA = "0x1833F40C0", Slot = "5")]
	internal sealed override bool AFFLCNIGHEC(ref Unity.Entities.Chunk LAFMMHFNMIO, int LKMEOGBJGBI, GFGJKKDFHMJ DAMGGCLMGDB, out ReadOnlySpan<byte> NCMINFKEPHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x33F4AA0", Offset = "0x33F38A0", VA = "0x1833F4AA0", Slot = "6")]
	internal sealed override bool EEKBIHHINCO(int OAFCEFJIFII, ref Unity.Entities.Chunk LAFMMHFNMIO, int LKMEOGBJGBI, in ReadOnlySpan<byte> NCMINFKEPHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3150050", Offset = "0x314EE50", VA = "0x183150050")]
	protected HNGGPHFFDPI<Protobuf> BHLAOGDGFDE<Protobuf>(ReadOnlySpan<Data> BAHBPPHMFLI) where Protobuf : IMessage, new()
	{
		return default(HNGGPHFFDPI<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x31500A0", Offset = "0x314EEA0", VA = "0x1831500A0")]
	protected HHFGENCEDDA<Protobuf> FLHBMAJCKOE<Protobuf>(ReadOnlySpan<byte> NCMINFKEPHO, ReadOnlySpan<Data> BAHBPPHMFLI, Action<Protobuf> GMPNNCDFNHM) where Protobuf : IMessage, new()
	{
		return default(HHFGENCEDDA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2ABBF10", Offset = "0x2ABAD10", VA = "0x182ABBF10")]
	protected BOLGPBIJHND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class KPCIKMODEPA
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	protected internal abstract int MKCLCLCLGPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAF20", Offset = "0x6AC9D20", VA = "0x186ACAF20", Slot = "5")]
	internal virtual bool AFFLCNIGHEC(ref Unity.Entities.Chunk LAFMMHFNMIO, int LKMEOGBJGBI, GFGJKKDFHMJ DAMGGCLMGDB, out ReadOnlySpan<byte> NCMINFKEPHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x81CAB0", Offset = "0x81B8B0", VA = "0x18081CAB0", Slot = "6")]
	internal virtual bool EEKBIHHINCO(int OAFCEFJIFII, ref Unity.Entities.Chunk LAFMMHFNMIO, int LKMEOGBJGBI, in ReadOnlySpan<byte> NCMINFKEPHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	protected KPCIKMODEPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class NJOCKDAFFLE
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct AJLMGHJLDEA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public struct AGHLAKMGDGJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			internal AJLMGHJLDEA<TFrom> GMBPOBACJJI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		internal Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		internal NativeArray<TFrom> PEJGDDHHDBH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct IEFDIHCHHOM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public struct GCBJNBKPGPP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			internal IEFDIHCHHOM<TFrom> GMBPOBACJJI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		internal Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		internal NativeList<TFrom> PEJGDDHHDBH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct GDCKCNKEILL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public struct JGKIHJPLFEK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			internal GDCKCNKEILL<TFrom> GMBPOBACJJI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal NativeArrayAsync<TFrom> PEJGDDHHDBH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct HFJHFKCOGHH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public struct BCHBOGLIHLK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			internal HFJHFKCOGHH<TFrom> GMBPOBACJJI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal NativeListAsync<TFrom> PEJGDDHHDBH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct HGCNIHCCANE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LHLFGKPPOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	public NativeArray<Entity> ODOFECAJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[WriteOnly]
	public NativeArray<T> ACAGHAMJAEB;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x374A7C0", Offset = "0x37495C0", VA = "0x18374A7C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[BurstCompile]
internal struct MIIBJMAOEIL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GMBGFBNMHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	public NativeArray<Entity> FEMLCDGNFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<bool> OMEJPKCCOID;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct PLMOMIMMBPL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<Entity> KHPJJPHILOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	public NativeArray<T> PFPIGLEBEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public EntityCommandBuffer BIIIPDFACJO;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4AB6130", Offset = "0x4AB4F30", VA = "0x184AB6130", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KKBKONGCCNP
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class FHGLMEEANEE
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2335F30", Offset = "0x2334D30", VA = "0x182335F30")]
	public static NativeListAsync<Entity> HBMCPOKDPJH<T, TPredicate>(this NativeArrayAsync<T> KAPHOKPKPAO, NativeArrayAsync<Entity> FEMLCDGNFNL, Allocator FIPHDKMNFDJ = Allocator.TempJob) where T : struct where TPredicate : struct, FKDFHBPMIIB<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2335D80", Offset = "0x2334B80", VA = "0x182335D80")]
	private static NativeListAsync<Entity> BPGAGAINLKK<T, TPredicate>(NativeArrayAsync<T> FHBGPOAAEEK, NativeArrayAsync<Entity> FEMLCDGNFNL, int CNKKOGIEKAD, Allocator FIPHDKMNFDJ) where T : struct where TPredicate : struct, FKDFHBPMIIB<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class IGHGPIHNBFK
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x25E3E80", Offset = "0x25E2C80", VA = "0x1825E3E80")]
	[MustUseReturnValue]
	public static JobHandle AJIFEIGKPGD<T>(this EntityCommandBufferSystem DLEOHIDEOHO, NativeArray<Entity> KHPJJPHILOJ, T KKLNCEHOHED, [Optional] JobHandle KFKJELHPNAC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x25E3DB0", Offset = "0x25E2BB0", VA = "0x1825E3DB0")]
	[MustUseReturnValue]
	public static JobHandle AJIFEIGKPGD<T>(this EntityCommandBufferSystem DLEOHIDEOHO, EntityCommandBuffer BIIIPDFACJO, NativeArray<Entity> KHPJJPHILOJ, T KKLNCEHOHED, [Optional] JobHandle KFKJELHPNAC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x25E3CF0", Offset = "0x25E2AF0", VA = "0x1825E3CF0")]
	[MustUseReturnValue]
	public static JobHandle AJIFEIGKPGD<T>(this EntityCommandBufferSystem DLEOHIDEOHO, EntityCommandBuffer BIIIPDFACJO, NativeArray<Entity> KHPJJPHILOJ, NativeArray<T> PFPIGLEBEEP, [Optional] JobHandle KFKJELHPNAC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class AMKLKGACMBL : PDCIMEOLOCL
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class MCNBIMHJGIA
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x302EE50", Offset = "0x302DC50", VA = "0x18302EE50")]
	public static NativeList<T> FNEKIHPGNKN<T>(this NativeList<T> KAPHOKPKPAO, Allocator FIPHDKMNFDJ = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x302EC80", Offset = "0x302DA80", VA = "0x18302EC80")]
	public static NativeList<T> FNEKIHPGNKN<T>(this NativeArray<T> KAPHOKPKPAO, Allocator FIPHDKMNFDJ = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class OIPBKOPALDM
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct DKANMJEEANK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NativeArray<T> ODOFECAJCEP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct IEBPOOODMNF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeList<T> ODOFECAJCEP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct JIBBLEPCDIJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public NativeArrayAsync<T> ODOFECAJCEP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct GHOHIIIGAJC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public NativeListAsync<T> ODOFECAJCEP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct KOPAFDFKAOK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, LKFNFPNPOFA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	public NativeArray<TFrom> ODOFECAJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[WriteOnly]
	public NativeArray<TTo> ACAGHAMJAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public TMap EHPEOJCHKEM;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[Flags]
public enum NAKEIOKHACF
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	GameObjectConversion = 0x30,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	EntitySceneOptimizations = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	ProcessAfterLoad = 8,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	HybridGameObjectConversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DotsRuntimeGameObjectConversion = 0x20
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface FKDFHBPMIIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGKAGCDIIHH(T KKLNCEHOHED);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct KBFOCPOANFE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	public NativeArray<Entity> KHPJJPHILOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public EntityCommandBuffer BIIIPDFACJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public ComponentTypes JLMGBOELFMA;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9560", Offset = "0x6AC8360", VA = "0x186AC9560", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[BurstCompile]
internal struct GNFFIHNFLFL<T, TPredicate> : IJob where T : struct where TPredicate : struct, FKDFHBPMIIB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	public NativeArray<T> ODOFECAJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<T> EFFIEOKIBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public TPredicate EHPEOJCHKEM;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class LNKKKKNCPLC : NNPCPPCHKDA
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB690", Offset = "0x6ACA490", VA = "0x186ACB690", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC78A0", Offset = "0x6AC66A0", VA = "0x186AC78A0")]
	public LNKKKKNCPLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class PDCIMEOLOCL : LMBDOPFLGJC
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Type ONEHDNGIMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B90", Offset = "0x7F0990", VA = "0x1807F1B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xE55380", Offset = "0xE54180", VA = "0x180E55380")]
	public PDCIMEOLOCL(Type GMBGFBNMHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class GMAHBOMCLFI
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly Dictionary<int, int> JOLHLIJOOFG;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static bool KFLNDDALKGN;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8C00", Offset = "0x6AC7A00", VA = "0x186AC8C00")]
	public static int DEOCCKOBBDH(int LMGCLJPIIAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8CA0", Offset = "0x6AC7AA0", VA = "0x186AC8CA0")]
	public static void HFKECJNCAPE(bool CONMELFNDPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8E10", Offset = "0x6AC7C10", VA = "0x186AC8E10")]
	private static void NDGNPJCAKLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8D40", Offset = "0x6AC7B40", VA = "0x186AC8D40")]
	private static int KLPMPJFLCHD(Type LKLFHGBOOLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8D90", Offset = "0x6AC7B90", VA = "0x186AC8D90")]
	private static void LEKENBMMMEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[BurstCompile]
internal struct NKEMHOKNIIG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GMBGFBNMHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	public NativeArray<Entity> FEMLCDGNFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<bool> OMEJPKCCOID;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3EC48D0", Offset = "0x3EC36D0", VA = "0x183EC48D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[BurstCompile]
internal struct NIHNHLMJNLD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeArray<Entity> KHPJJPHILOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	public NativeArray<T> FAJCHBCCGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public EntityCommandBuffer BIIIPDFACJO;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3EC25C0", Offset = "0x3EC13C0", VA = "0x183EC25C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class GLCPHFGALAM
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8B00", Offset = "0x6AC7900", VA = "0x186AC8B00")]
	public static ulong MACGDGIOGAG(Type LKLFHGBOOLP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8B90", Offset = "0x6AC7990", VA = "0x186AC8B90")]
	public static ulong MACGDGIOGAG(string KAOJHLJGNHE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal static class OMEKBNMAMFE
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly Dictionary<Type, int> OPBDIDBDGKC;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static bool KFLNDDALKGN;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC6E0", Offset = "0x6ACB4E0", VA = "0x186ACC6E0")]
	public static void HFKECJNCAPE(bool CONMELFNDPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC780", Offset = "0x6ACB580", VA = "0x186ACC780")]
	private static void HPAGGBOLJFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC9B0", Offset = "0x6ACB7B0", VA = "0x186ACC9B0")]
	private static void JFBMPPEGJPI(Type IMFOPMBHLIL, Type LMBGOHINBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCB90", Offset = "0x6ACB990", VA = "0x186ACCB90")]
	private static void LEKENBMMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCC10", Offset = "0x6ACBA10", VA = "0x186ACCC10")]
	public static int NBFDOJNEJAD(Type IMFOPMBHLIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC640", Offset = "0x6ACB440", VA = "0x186ACC640")]
	public static bool DJLAPJBNADC(Type IMFOPMBHLIL, out int LMGCLJPIIAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class KMFGDBHICHJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly IBKLHAEEEEI EKFPDHJKIFI;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA5C0", Offset = "0x6AC93C0", VA = "0x186ACA5C0")]
	public static ComponentSystemGroup[] IEGLKFDKGLN(World JNDJAEGBBCD, NAKEIOKHACF MALOLNGNBCO = NAKEIOKHACF.Default, bool CAFGJLKECAN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA820", Offset = "0x6AC9620", VA = "0x186ACA820")]
	private static Type[] NLNEDMFCKMO(NAKEIOKHACF MALOLNGNBCO, bool CAFGJLKECAN, ComponentSystemGroup[] IBACMLEKINO, ComponentSystemGroup HAADJNFJCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAB80", Offset = "0x6AC9980", VA = "0x186ACAB80")]
	private static ComponentSystemGroup[] PCEOIKAIGHH(World JNDJAEGBBCD, out ComponentSystemGroup HAADJNFJCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA330", Offset = "0x6AC9130", VA = "0x186ACA330")]
	internal static bool GKAHKJHKOJF(KFPAFMBJBMO KCEKDHFAAAO, out GNAFDKDMJAN IHJAMDNNAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA250", Offset = "0x6AC9050", VA = "0x186ACA250")]
	private static ComponentSystemGroup GILPMJCAPHC(Type LKLFHGBOOLP, World JNDJAEGBBCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA6F0", Offset = "0x6AC94F0", VA = "0x186ACA6F0")]
	private static ComponentSystemGroup[] LPPEEEHJJCP(Type[] MECLDLOMGDJ, World JNDJAEGBBCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9D30", Offset = "0x6AC8B30", VA = "0x186AC9D30")]
	internal static void FKBNDMJGLLJ(World JNDJAEGBBCD, Type[] IJKCKHGBHBL, ComponentSystemGroup[] IBACMLEKINO, ComponentSystemGroup HAADJNFJCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9CD0", Offset = "0x6AC8AD0", VA = "0x186AC9CD0")]
	internal static bool FBEIPMLOFPJ(ComponentSystemBase GIHNJLGLCPK, ComponentSystemGroup[] IBACMLEKINO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA690", Offset = "0x6AC9490", VA = "0x186ACA690")]
	private static void IJHEMFLAMLG(ComponentSystemGroup[] IBACMLEKINO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class GMNJFJDOCKL : PDCIMEOLOCL
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xE55380", Offset = "0xE54180", VA = "0x180E55380")]
	public GMNJFJDOCKL(Type GMBGFBNMHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[BurstCompile]
internal struct MJFOMCPODLM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public ComponentDataFromEntity GMBGFBNMHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	public NativeArray<Entity> FEMLCDGNFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public NativeList<Entity> FLDNGACCIPM;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB780", Offset = "0x6ACA580", VA = "0x186ACB780", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class FMGBHDMFNBJ : SystemBase, MOPFHGEKGDK
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8930", Offset = "0x6AC7730", VA = "0x186AC8930")]
	public ComponentDataFromEntity ECBGKMECMKE(int LMGCLJPIIAF, bool NCMJFNEGFHA = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8A00", Offset = "0x6AC7800", VA = "0x186AC8A00")]
	public EntityExistenceLookupByEntity GNABDPENMFO()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8A20", Offset = "0x6AC7820", VA = "0x186AC8A20")]
	public EntityQuery GNANMDEFGIO(in EntityQueryDescBuilder HBDPPPFHKBI)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8A70", Offset = "0x6AC7870", VA = "0x186AC8A70", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x9B3AA0", Offset = "0x9B28A0", VA = "0x1809B3AA0")]
	protected FMGBHDMFNBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class JJAMPNHIAOG : FMGBHDMFNBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9530", Offset = "0x6AC8330", VA = "0x186AC9530", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x9B3AA0", Offset = "0x9B28A0", VA = "0x1809B3AA0")]
	protected JJAMPNHIAOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class KBDPPKJOGNI
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface MOPFHGEKGDK
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public abstract class NNPCPPCHKDA : ComponentSystemGroup, MOPFHGEKGDK
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6AC78A0", Offset = "0x6AC66A0", VA = "0x186AC78A0")]
	protected NNPCPPCHKDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class HCDGMNNBCBP<View, Data> : PADCBKIDDOD where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static ComponentType AAPDCMHNFOJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public override Type NNPHANCNIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3B40640", Offset = "0x3B3F440", VA = "0x183B40640", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override int BNJDCGLBDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3B3F550", Offset = "0x3B3E350", VA = "0x183B3F550", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3B3F610", Offset = "0x3B3E410", VA = "0x183B3F610")]
	public Data ELLBPJJFPFB(Entity FPIIEOBJDDB)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View ODEKMBEOCOJ(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x44E37D0", Offset = "0x44E25D0", VA = "0x1844E37D0", Slot = "14")]
	protected internal override T ODEKMBEOCOJ<T>(Entity FPIIEOBJDDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2ABBF10", Offset = "0x2ABAD10", VA = "0x182ABBF10")]
	protected HCDGMNNBCBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class PADCBKIDDOD : IMNMHFEADJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private DynamicComponentTypeHandle IEMANMKKCJH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public EntityManager FOKKLIPOJAA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x89BCE0", Offset = "0x89AAE0", VA = "0x18089BCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract Type NNPHANCNIFB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract int BNJDCGLBDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Type GGGDGPJFHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x11204C0", Offset = "0x111F2C0", VA = "0x1811204C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private int MPHOOPANJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCF50", Offset = "0x6ACBD50", VA = "0x186ACCF50", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private CPBOEHNKFNO[] DEEHPLBNBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA288B0", Offset = "0xA276B0", VA = "0x180A288B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	protected internal virtual CPBOEHNKFNO[] GJOMGOHIKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD0E0", Offset = "0x6ACBEE0", VA = "0x186ACD0E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCFC0", Offset = "0x6ACBDC0", VA = "0x186ACCFC0")]
	public void HFKECJNCAPE(EntityManager HCPDBMFJKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
	protected IMNMHFEADJO ENBONHCBOGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected internal abstract T ODEKMBEOCOJ<T>(Entity FPIIEOBJDDB) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCE90", Offset = "0x6ACBC90", VA = "0x186ACCE90", Slot = "8")]
	public (uint, uint) DEOCCKOBBDH(Entity FPIIEOBJDDB)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCE00", Offset = "0x6ACBC00", VA = "0x186ACCE00", Slot = "9")]
	public bool AFMEIJJMDJI(Entity FPIIEOBJDDB, (uint order, uint change) OAFCEFJIFII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	protected PADCBKIDDOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal struct BEHEEFGADNN
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly IBKLHAEEEEI EKFPDHJKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<Type> MECLDLOMGDJ;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	private BEHEEFGADNN(List<Type> MECLDLOMGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4610", Offset = "0x6AC3410", VA = "0x186AC4610")]
	public static void DHFPPHBCEKD(List<Type> MECLDLOMGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC46A0", Offset = "0x6AC34A0", VA = "0x186AC46A0")]
	private void DINOPLABOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4530", Offset = "0x6AC3330", VA = "0x186AC4530")]
	private bool BNFPFPDEBFD(Type LKLFHGBOOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC45B0", Offset = "0x6AC33B0", VA = "0x186AC45B0")]
	private void DCBMPLBDGFJ(Type LKLFHGBOOLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class OMPEKPAMCBE
{
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
internal struct AFALAFBKAEL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LHLFGKPPOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	public NativeArray<Entity> ODOFECAJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[WriteOnly]
	public NativeList<T> EFFIEOKIBGC;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Flags]
public enum KFPAFMBJBMO
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Game = 5,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class LEIMPMDMOAP : LMBDOPFLGJC
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KFPAFMBJBMO KDIIMPFMKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7F1060", Offset = "0x7EFE60", VA = "0x1807F1060")]
		[CompilerGenerated]
		get
		{
			return default(KFPAFMBJBMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1943840", Offset = "0x1942640", VA = "0x181943840")]
	public LEIMPMDMOAP(KFPAFMBJBMO KCEKDHFAAAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class IIKALFMJNHN : LMBDOPFLGJC
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x9B3AA0", Offset = "0x9B28A0", VA = "0x1809B3AA0")]
	public IIKALFMJNHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public abstract class KIBLHGFGPLO
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	protected KIBLHGFGPLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class DBBLMFBDICM
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public readonly struct MCHMFMCGLAF<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly NativeArray<TSrc> PKPHLPFOPGM;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x861610", Offset = "0x860410", VA = "0x180861610")]
		public MCHMFMCGLAF(NativeArray<TSrc> PKPHLPFOPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		public EFJCPKBJMPI<TSrc, TValue> KLJJJMNOGNM<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(EFJCPKBJMPI<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public readonly struct EFJCPKBJMPI<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly NativeArray<TSrc> PKPHLPFOPGM;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x861610", Offset = "0x860410", VA = "0x180861610")]
		public EFJCPKBJMPI(NativeArray<TSrc> PKPHLPFOPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		public GDLFAAFAMMB<TSrc, TValue, TSelector> AGDNPBOJNCJ<TSelector>() where TSelector : struct, LKFNFPNPOFA<TSrc, TValue>
		{
			return default(GDLFAAFAMMB<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public readonly struct GDLFAAFAMMB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, LKFNFPNPOFA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly NativeArray<TSrc> PKPHLPFOPGM;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x861610", Offset = "0x860410", VA = "0x180861610")]
		public GDLFAAFAMMB(NativeArray<TSrc> PKPHLPFOPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3940020", Offset = "0x393EE20", VA = "0x183940020")]
		public EMHAAGCFBFC<TSrc, TValue, TSelector> EFHJIGOLFHL()
		{
			return default(EMHAAGCFBFC<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public struct PIICICPMLDO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, LKFNFPNPOFA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly NativeArray<TSrc> PKPHLPFOPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TSelector OHINOBJEIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int FHOMILACEHB;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public TValue CFKFFOLONBC
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3604330", Offset = "0x3603130", VA = "0x183604330")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int PGIEFBHCKJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x838BE0", Offset = "0x8379E0", VA = "0x180838BE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int BBPCGKEHJPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x36044D0", Offset = "0x36032D0", VA = "0x1836044D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x36044E0", Offset = "0x36032E0", VA = "0x1836044E0")]
		public PIICICPMLDO(NativeArray<TSrc> PKPHLPFOPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3604310", Offset = "0x3603110", VA = "0x183604310")]
		public bool CHKPILOCJDD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x36043A0", Offset = "0x36031A0", VA = "0x1836043A0")]
		private TSrc OAMKDBMPPAM(int EFGAFPEAGGO)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public struct EMHAAGCFBFC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, LKFNFPNPOFA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private PIICICPMLDO<TSrc, TValue, TSelector> HBEBKLDONPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private TValue MFFEECAHGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int DIDHGEABMII;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public MGEJDLDGPCB BBAIOHMIHDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2370C50", Offset = "0x236FA50", VA = "0x182370C50")]
			get
			{
				return default(MGEJDLDGPCB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TValue HAJABPIIGGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x86DAD0", Offset = "0x86C8D0", VA = "0x18086DAD0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public (TValue value, MGEJDLDGPCB range) CFKFFOLONBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2370B50", Offset = "0x236F950", VA = "0x182370B50")]
			get
			{
				return default((TValue, MGEJDLDGPCB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2370C90", Offset = "0x236FA90", VA = "0x182370C90")]
		public EMHAAGCFBFC(NativeArray<TSrc> PKPHLPFOPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2370C30", Offset = "0x236FA30", VA = "0x182370C30")]
		public EMHAAGCFBFC<TSrc, TValue, TSelector> JOJADCJMMBH()
		{
			return default(EMHAAGCFBFC<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2370A20", Offset = "0x236F820", VA = "0x182370A20")]
		public bool CHKPILOCJDD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2EE52D0", Offset = "0x2EE40D0", VA = "0x182EE52D0")]
	public static MCHMFMCGLAF<T> HLALFEOOMAF<T>(this NativeList<T> IPGDFFNNILJ) where T : struct
	{
		return default(MCHMFMCGLAF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
	public static MCHMFMCGLAF<T> HLALFEOOMAF<T>(this NativeArray<T> PKPHLPFOPGM) where T : struct
	{
		return default(MCHMFMCGLAF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class IAEFDBHILCF
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public struct FAFOGELKKFH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct EHECOCLJHOE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public FAFOGELKKFH<TFrom> PEJGDDHHDBH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public NativeArray<TFrom> ODOFECAJCEP;
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public struct IFGIFLKJDBE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		public struct GLEKGMCDONG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public IFGIFLKJDBE<TFrom> PEJGDDHHDBH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public NativeArrayAsync<TFrom> ODOFECAJCEP;
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public struct JJOGFNBEEFK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public struct CPPBEPGPJBJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public JJOGFNBEEFK<TFrom> PEJGDDHHDBH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Allocator FIPHDKMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public NativeListAsync<TFrom> ODOFECAJCEP;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
internal struct LJGODHCMPDL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[ReadOnly]
	public NativeArray<Entity> KHPJJPHILOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public EntityCommandBuffer BIIIPDFACJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public ComponentType OPBKILPABOM;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB3D0", Offset = "0x6ACA1D0", VA = "0x186ACB3D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class KCGNHNDBLJG
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2E48440", Offset = "0x2E47240", VA = "0x182E48440")]
	public static bool KDIOGNGDOJB<T>(this NativeArray<Entity> FEMLCDGNFNL, EntityManager HCPDBMFJKPJ, Allocator FIPHDKMNFDJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class KAOLCKLHOIG
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class FNANPGIOIOK
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class JFAOHIBDAJE : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual bool FGPCODICNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	protected JFAOHIBDAJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DisableAutoCreation]
public sealed class NOIBNELLOKI : JFAOHIBDAJE
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public NOIBNELLOKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DisableAutoCreation]
public sealed class LBJPNKECGIP : JFAOHIBDAJE
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public LBJPNKECGIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[DisableAutoCreation]
public sealed class NFAFODDEBNJ : JFAOHIBDAJE
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public NFAFODDEBNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[DisableAutoCreation]
public sealed class IPMNCINGJIA : JFAOHIBDAJE
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public IPMNCINGJIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[DisableAutoCreation]
public sealed class JKGAMJFOJPM : JFAOHIBDAJE
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public JKGAMJFOJPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[DisableAutoCreation]
public sealed class HIIIDPLGHMO : JFAOHIBDAJE
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public HIIIDPLGHMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[DisableAutoCreation]
public sealed class CIBDFPGLPIO : JFAOHIBDAJE
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public CIBDFPGLPIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[DisableAutoCreation]
public sealed class OEDKJLKOJMH : JFAOHIBDAJE
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public OEDKJLKOJMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[DisableAutoCreation]
public sealed class EMAMOICIBMG : JFAOHIBDAJE
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public EMAMOICIBMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public sealed class KLMLOGOKONB : NPOHEFFKHKL
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public KLMLOGOKONB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class EGOGPPIHLLP : NPOHEFFKHKL
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public EGOGPPIHLLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public sealed class LICKLDPBDGO : NPOHEFFKHKL
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public LICKLDPBDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public sealed class BIDNILEACFL : NPOHEFFKHKL
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public BIDNILEACFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[DisableAutoCreation]
[BIOJKJMKPHG(NFMGCFGBFLP.Application)]
public class NPOHEFFKHKL : JFAOHIBDAJE
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public override bool FGPCODICNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3770", VA = "0x186AC4970")]
	public NPOHEFFKHKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class KCOOHFNOCAG
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly HCPAJIDFLPM ONNABJBHNGO;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly ONHOMADHILG GCJMLFADCKB;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly FPJCJJBCAMD ADBDINDANKN;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly List<Type> IHNKPAMNPBO;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static bool KFLNDDALKGN;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	internal static GJPAOKGJIED<PADCBKIDDOD> OOBLCKOEMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9A40", Offset = "0x6AC8840", VA = "0x186AC9A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal static GJPAOKGJIED<KPCIKMODEPA> OHKCKLMFBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC95C0", Offset = "0x6AC83C0", VA = "0x186AC95C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal static GJPAOKGJIED<KIBLHGFGPLO> IJIKLKKLKAH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9620", Offset = "0x6AC8420", VA = "0x186AC9620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9700", Offset = "0x6AC8500", VA = "0x186AC9700")]
	public static void HFKECJNCAPE(bool CONMELFNDPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9680", Offset = "0x6AC8480", VA = "0x186AC9680")]
	public static Type[] FFNFMJBPBKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class HPJOMLEHEOA
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x31E6630", Offset = "0x31E5430", VA = "0x1831E6630")]
	[MustUseReturnValue]
	public static JobHandle CJJCHBJDLGE<T>(this EntityCommandBufferSystem DLEOHIDEOHO, NativeArrayAsync<Entity> KHPJJPHILOJ, NativeArrayAsync<T> FAJCHBCCGOJ, [Optional] JobHandle KFKJELHPNAC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x31E6B40", Offset = "0x31E5940", VA = "0x1831E6B40")]
	[MustUseReturnValue]
	public static JobHandle CJJCHBJDLGE<T>(this EntityCommandBufferSystem DLEOHIDEOHO, NativeArrayAsync<Entity> KHPJJPHILOJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x31E6510", Offset = "0x31E5310", VA = "0x1831E6510")]
	[MustUseReturnValue]
	public static JobHandle CJJCHBJDLGE<T>(this EntityCommandBufferSystem DLEOHIDEOHO, NativeArray<Entity> KHPJJPHILOJ, [Optional] JobHandle KFKJELHPNAC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x31E6A20", Offset = "0x31E5820", VA = "0x1831E6A20")]
	[MustUseReturnValue]
	public static JobHandle CJJCHBJDLGE<T>(this EntityCommandBufferSystem DLEOHIDEOHO, EntityCommandBuffer BIIIPDFACJO, NativeArray<Entity> KHPJJPHILOJ, [Optional] JobHandle KFKJELHPNAC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9220", Offset = "0x6AC8020", VA = "0x186AC9220")]
	[MustUseReturnValue]
	public static JobHandle CJJCHBJDLGE(this EntityCommandBufferSystem DLEOHIDEOHO, NativeArray<Entity> KHPJJPHILOJ, ComponentTypes JLMGBOELFMA, [Optional] JobHandle KFKJELHPNAC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9380", Offset = "0x6AC8180", VA = "0x186AC9380")]
	[MustUseReturnValue]
	public static JobHandle CJJCHBJDLGE(this EntityCommandBufferSystem DLEOHIDEOHO, EntityCommandBuffer BIIIPDFACJO, NativeArray<Entity> KHPJJPHILOJ, ComponentTypes JLMGBOELFMA, [Optional] JobHandle KFKJELHPNAC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class EEBLGHMKENJ
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7050", Offset = "0x6AC5E50", VA = "0x186AC7050")]
	private unsafe static Span<byte> BCABMECBEMM(Unity.Entities.Chunk* LAFMMHFNMIO, int LKMEOGBJGBI)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3783B10", Offset = "0x3782910", VA = "0x183783B10")]
	public unsafe static Span<T> OBFHPJJOPPF<T>(Unity.Entities.Chunk* LAFMMHFNMIO, int LKMEOGBJGBI)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3783CA0", Offset = "0x3782AA0", VA = "0x183783CA0")]
	public static Span<T> OBFHPJJOPPF<T>(this ref Unity.Entities.Chunk LAFMMHFNMIO, int LKMEOGBJGBI)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7120", Offset = "0x6AC5F20", VA = "0x186AC7120")]
	public unsafe static Span<Entity> CEFBGCMADBM(Unity.Entities.Chunk* LAFMMHFNMIO)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7190", Offset = "0x6AC5F90", VA = "0x186AC7190")]
	public unsafe static void LEKENBMMMEI(Unity.Entities.Chunk* LAFMMHFNMIO, int LKMEOGBJGBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class GFGJKKDFHMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> GBAHGCOJPIP;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8641B0", Offset = "0x862FB0", VA = "0x1808641B0")]
	public GFGJKKDFHMJ(NativeArray<EntityRemapUtility.EntityRemapInfo> GBAHGCOJPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8AF0", Offset = "0x6AC78F0", VA = "0x186AC8AF0")]
	public Entity HICOKMECHKP(Entity KGDHPOJLMNA)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[AttributeUsage(AttributeTargets.Class)]
public class NDKLOOBEKJL : LMBDOPFLGJC
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x9B3AA0", Offset = "0x9B28A0", VA = "0x1809B3AA0")]
	public NDKLOOBEKJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class EJAJKLMALKE
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public delegate void LDLPBKHHJJP<From, To>(From PEJGDDHHDBH, ref To FCAKJLDDKGP, GFGJKKDFHMJ DAMGGCLMGDB);

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class PCAOJCCGAIN<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static LDLPBKHHJJP<From, To> LAMPBKBMDAG;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public PCAOJCCGAIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7320", Offset = "0x6AC6120", VA = "0x186AC7320")]
	static EJAJKLMALKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x378A970", Offset = "0x3789770", VA = "0x18378A970")]
	public static void AFEHGPCFIOA<T>(LDLPBKHHJJP<T, T> LCADCICJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x378A730", Offset = "0x3789530", VA = "0x18378A730")]
	public static void AFEHGPCFIOA<From, To>(LDLPBKHHJJP<From, To> LCADCICJONC, LDLPBKHHJJP<To, From> NMCBFGDEANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x378A6E0", Offset = "0x37894E0", VA = "0x18378A6E0")]
	public static void AFEHGPCFIOA<From, To>(LDLPBKHHJJP<From, To> LAMPBKBMDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x378F7A0", Offset = "0x378E5A0", VA = "0x18378F7A0")]
	public static LDLPBKHHJJP<From, To> HOANHJBACGH<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x378CD00", Offset = "0x378BB00", VA = "0x18378CD00")]
	public static void HKCAGLBJCGD<From, To>(From PEJGDDHHDBH, ref To FCAKJLDDKGP, GFGJKKDFHMJ DAMGGCLMGDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public interface GLEGCDOAMLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AKMMGIKAEDH(Entity FPIIEOBJDDB, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HAHLMNFGIJE(Entity FPIIEOBJDDB, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EKEOEMMNFCJ(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<object> GBJFMDJNJHP(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CCHGIDMKNIL(Entity FPIIEOBJDDB);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class FKIFNOEMPMC<TComponentData, TValue> : HGKBFOHNEMI<TValue>, IDisposable where TComponentData : struct, PBBGKOOHOCC
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class DAAJHDBNBON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private List<(object token, TValue value)> IPGDFFNNILJ;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int EFAPJKDFNLF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2372160", Offset = "0x2370F60", VA = "0x182372160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC0E0", Offset = "0x2ABAEE0", VA = "0x182ABC0E0")]
		public bool LMJCFPCGGHE(out TValue KKLNCEHOHED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC030", Offset = "0x2ABAE30", VA = "0x182ABC030")]
		public void IMFFJGIMDFG(object GKNJCIECGND, TValue KKLNCEHOHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC1A0", Offset = "0x2ABAFA0", VA = "0x182ABC1A0")]
		public bool OIPPMFBKPAM(object GKNJCIECGND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBF80", Offset = "0x2ABAD80", VA = "0x182ABBF80")]
		public int GBKMNEGKILN(object GKNJCIECGND)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC220", Offset = "0x2ABB020", VA = "0x182ABC220")]
		public DAAJHDBNBON()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Stack<DAAJHDBNBON> PBGGDGPPHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private JNGGDLCILNE<ENDOEPPMPID, DAAJHDBNBON> OHEKABIOJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private EntityManager HCPDBMFJKPJ;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x36CEDA0", Offset = "0x36CDBA0", VA = "0x1836CEDA0")]
	public FKIFNOEMPMC(EntityManager HCPDBMFJKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x36CE730", Offset = "0x36CD530", VA = "0x1836CE730", Slot = "4")]
	public void AKMMGIKAEDH(Entity FPIIEOBJDDB, object GKNJCIECGND, TValue KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x36CE940", Offset = "0x36CD740", VA = "0x1836CE940", Slot = "5")]
	public bool HAHLMNFGIJE(Entity FPIIEOBJDDB, object GKNJCIECGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x36CEBA0", Offset = "0x36CD9A0", VA = "0x1836CEBA0", Slot = "6")]
	public bool LMJCFPCGGHE(Entity FPIIEOBJDDB, out TValue KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x36CE920", Offset = "0x36CD720", VA = "0x1836CE920", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x36CEC90", Offset = "0x36CDA90", VA = "0x1836CEC90")]
	private void NHGLMALOFKG(DAAJHDBNBON AGHNDPMOFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x36CEAD0", Offset = "0x36CD8D0", VA = "0x1836CEAD0")]
	private bool HJAOJHCCECH(Entity FPIIEOBJDDB, out ENDOEPPMPID PDHOEHKDKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x36CED10", Offset = "0x36CDB10", VA = "0x1836CED10")]
	private void PGDMENFIEMF(Entity FPIIEOBJDDB, ENDOEPPMPID PDHOEHKDKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x36CEC70", Offset = "0x36CDA70", VA = "0x1836CEC70")]
	private bool MKNHHAJCMBL(ENDOEPPMPID PDHOEHKDKMC, out DAAJHDBNBON AGHNDPMOFNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x36CE850", Offset = "0x36CD650", VA = "0x1836CE850")]
	private DAAJHDBNBON APGGDLOBOHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public interface HGKBFOHNEMI<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKMMGIKAEDH(Entity FPIIEOBJDDB, object GKNJCIECGND, TValue KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HAHLMNFGIJE(Entity FPIIEOBJDDB, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LMJCFPCGGHE(Entity FPIIEOBJDDB, out TValue KKLNCEHOHED);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public interface PBBGKOOHOCC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	ENDOEPPMPID GJJBONAPLFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct ENDOEPPMPID : LLEEHKNOMNP<ENDOEPPMPID>, IDGNIPDDEJI, IEquatable<ENDOEPPMPID>
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static readonly ENDOEPPMPID IOPEGLNHBHH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[CreateProperty]
	public int PGIEFBHCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA2A950", Offset = "0xA29750", VA = "0x180A2A950", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xAFF400", Offset = "0xAFE200", VA = "0x180AFF400", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[CreateProperty]
	public int MKCLCLCLGPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xD1D510", Offset = "0xD1C310", VA = "0x180D1D510", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x19316E0", Offset = "0x19304E0", VA = "0x1819316E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6AC76D0", Offset = "0x6AC64D0", VA = "0x186AC76D0", Slot = "8")]
	public bool Equals(ENDOEPPMPID FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7720", Offset = "0x6AC6520", VA = "0x186AC7720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class CAHNLNMLOIA<THasTokensTag> : GLEGCDOAMLA, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Dictionary<Entity, ENDOEPPMPID> FFFKDNCCOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Stack<HashSet<object>> PBGGDGPPHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private JNGGDLCILNE<ENDOEPPMPID, HashSet<object>> OHEKABIOJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EntityManager HCPDBMFJKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private EntityCommandBufferSystem DLEOHIDEOHO;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x486D3B0", Offset = "0x486C1B0", VA = "0x18486D3B0")]
	public CAHNLNMLOIA(EntityManager HCPDBMFJKPJ, EntityCommandBufferSystem DLEOHIDEOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x486A010", Offset = "0x4868E10", VA = "0x18486A010", Slot = "4")]
	public bool AKMMGIKAEDH(Entity FPIIEOBJDDB, object GKNJCIECGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x486C210", Offset = "0x486B010", VA = "0x18486C210", Slot = "5")]
	public bool HAHLMNFGIJE(Entity FPIIEOBJDDB, object GKNJCIECGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x486B090", Offset = "0x4869E90", VA = "0x18486B090", Slot = "6")]
	public bool EKEOEMMNFCJ(Entity FPIIEOBJDDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x486B250", Offset = "0x486A050", VA = "0x18486B250", Slot = "10")]
	public bool EKEOEMMNFCJ(ENDOEPPMPID PDHOEHKDKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x486B810", Offset = "0x486A610", VA = "0x18486B810", Slot = "7")]
	public IEnumerable<object> GBJFMDJNJHP(Entity FPIIEOBJDDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x486B6B0", Offset = "0x486A4B0", VA = "0x18486B6B0", Slot = "11")]
	public IEnumerable<object> GBJFMDJNJHP(ENDOEPPMPID PDHOEHKDKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x486AB00", Offset = "0x4869900", VA = "0x18486AB00", Slot = "8")]
	public bool CCHGIDMKNIL(Entity FPIIEOBJDDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x486AFD0", Offset = "0x4869DD0", VA = "0x18486AFD0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x486CF50", Offset = "0x486BD50", VA = "0x18486CF50")]
	private void NHGLMALOFKG(HashSet<object> AGHNDPMOFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x486C830", Offset = "0x486B630", VA = "0x18486C830")]
	private bool HJAOJHCCECH(Entity FPIIEOBJDDB, out ENDOEPPMPID PDHOEHKDKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x486CC90", Offset = "0x486BA90", VA = "0x18486CC90")]
	private bool MHCJEMEEAEH(Entity FPIIEOBJDDB, out ENDOEPPMPID PDHOEHKDKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x486BD90", Offset = "0x486AB90", VA = "0x18486BD90")]
	private void GKCCFCMMFHP(Entity FPIIEOBJDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x486AEC0", Offset = "0x4869CC0", VA = "0x18486AEC0")]
	private void DNANAMCPFFE(Entity FPIIEOBJDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x486B4B0", Offset = "0x486A2B0", VA = "0x18486B4B0")]
	private void FGFNKKJCEHD(Entity FPIIEOBJDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x486D340", Offset = "0x486C140", VA = "0x18486D340")]
	private void PGDMENFIEMF(Entity FPIIEOBJDDB, ENDOEPPMPID PDHOEHKDKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x486CE30", Offset = "0x486BC30", VA = "0x18486CE30")]
	private bool NBPMCFNPNCG(ENDOEPPMPID PDHOEHKDKMC, out HashSet<object> AGHNDPMOFNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x486A970", Offset = "0x4869770", VA = "0x18486A970")]
	private HashSet<object> APGGDLOBOHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class ADGCNNCDDPM
{
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void MPIEEICCLJH(this IBKLHAEEEEI EKFPDHJKIFI, NativeArray<Entity> KHPJJPHILOJ, [Optional][CallerFilePath] string NGFNLDJMNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void MPIEEICCLJH(this IBKLHAEEEEI EKFPDHJKIFI, string PPPOJKMOIGD, NativeArray<Entity> KHPJJPHILOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void MPIEEICCLJH(this IBKLHAEEEEI EKFPDHJKIFI, string NGFNLDJMNKG, NativeArray<Entity> KHPJJPHILOJ, bool FAMINLNBNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void FODDNLOPBMH(this IBKLHAEEEEI EKFPDHJKIFI, NativeArray<Entity> KHPJJPHILOJ, EntityManager HCPDBMFJKPJ, [Optional][CallerFilePath] string NGFNLDJMNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void FODDNLOPBMH(this IBKLHAEEEEI EKFPDHJKIFI, string NGFNLDJMNKG, NativeArray<Entity> KHPJJPHILOJ, EntityManager HCPDBMFJKPJ, bool FAMINLNBNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void FDNEKAOMACA(this IBKLHAEEEEI EKFPDHJKIFI, NativeArray<Entity> KHPJJPHILOJ, NativeArray<Entity> AFDIPKBGMDG, [Optional][CallerFilePath] string NGFNLDJMNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void FDNEKAOMACA(this IBKLHAEEEEI EKFPDHJKIFI, string NGFNLDJMNKG, NativeArray<Entity> KHPJJPHILOJ, NativeArray<Entity> AFDIPKBGMDG, bool FAMINLNBNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x1BDDFF0", Offset = "0x1BDCDF0", VA = "0x181BDDFF0")]
	public static void EEADCANDOHG<T>(this IBKLHAEEEEI EKFPDHJKIFI, string PPPOJKMOIGD, NativeArray<Entity> KHPJJPHILOJ, NativeList<T> FAJCHBCCGOJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1BDDFA0", Offset = "0x1BDCDA0", VA = "0x181BDDFA0")]
	public static void EEADCANDOHG<T>(this IBKLHAEEEEI EKFPDHJKIFI, NativeArray<Entity> KHPJJPHILOJ, NativeArray<T> FAJCHBCCGOJ, [Optional][CallerFilePath] string NGFNLDJMNKG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1BDDF60", Offset = "0x1BDCD60", VA = "0x181BDDF60")]
	public static void EEADCANDOHG<T>(this IBKLHAEEEEI EKFPDHJKIFI, string PPPOJKMOIGD, NativeArray<Entity> KHPJJPHILOJ, NativeArray<T> FAJCHBCCGOJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void EEADCANDOHG<T>(this IBKLHAEEEEI EKFPDHJKIFI, string NGFNLDJMNKG, NativeArray<Entity> KHPJJPHILOJ, NativeArray<T> FAJCHBCCGOJ, bool FAMINLNBNLP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1BDE080", Offset = "0x1BDCE80", VA = "0x181BDE080")]
	public static void FOJILJOEPMA<T>(this IBKLHAEEEEI EKFPDHJKIFI, NativeList<T> FAJCHBCCGOJ, [Optional][CallerFilePath] string NGFNLDJMNKG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1BDE0E0", Offset = "0x1BDCEE0", VA = "0x181BDE0E0")]
	public static void FOJILJOEPMA<T>(this IBKLHAEEEEI EKFPDHJKIFI, NativeArray<T> FAJCHBCCGOJ, [Optional][CallerFilePath] string NGFNLDJMNKG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void FOJILJOEPMA<T>(this IBKLHAEEEEI EKFPDHJKIFI, string NGFNLDJMNKG, NativeArray<T> FAJCHBCCGOJ, bool FAMINLNBNLP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void BADCEDBKNML(this IBKLHAEEEEI EKFPDHJKIFI, EntityQuery HNJMIAEHBAM, [Optional][CallerFilePath] string NGFNLDJMNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void BADCEDBKNML(this IBKLHAEEEEI EKFPDHJKIFI, string PPPOJKMOIGD, EntityQuery HNJMIAEHBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void BADCEDBKNML(this IBKLHAEEEEI EKFPDHJKIFI, string NGFNLDJMNKG, EntityQuery HNJMIAEHBAM, bool FAMINLNBNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1BDDF30", Offset = "0x1BDCD30", VA = "0x181BDDF30")]
	public static void DPBHKMOBLKI<T, T2>(this IBKLHAEEEEI EKFPDHJKIFI, string PPPOJKMOIGD, EntityQuery HNJMIAEHBAM) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	private static void DPBHKMOBLKI<T, T2>(this IBKLHAEEEEI EKFPDHJKIFI, string NGFNLDJMNKG, EntityQuery HNJMIAEHBAM, bool FAMINLNBNLP) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1BDDF30", Offset = "0x1BDCD30", VA = "0x181BDDF30")]
	public static void LHPEIIONBJC<T>(this IBKLHAEEEEI EKFPDHJKIFI, string PPPOJKMOIGD, NativeList<T> PKPHLPFOPGM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void LHPEIIONBJC<T>(this IBKLHAEEEEI EKFPDHJKIFI, string NGFNLDJMNKG, NativeList<T> PKPHLPFOPGM, bool FAMINLNBNLP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1BDDF30", Offset = "0x1BDCD30", VA = "0x181BDDF30")]
	public static void DIBDJCAJJOI<T>(this IBKLHAEEEEI EKFPDHJKIFI, string PPPOJKMOIGD, NativeArray<T> PKPHLPFOPGM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void DIBDJCAJJOI<T>(this IBKLHAEEEEI EKFPDHJKIFI, string NGFNLDJMNKG, NativeArray<T> PKPHLPFOPGM, bool FAMINLNBNLP) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
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
