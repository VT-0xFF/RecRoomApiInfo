using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8352980", Offset = "0x8351980", VA = "0x188352980", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HBMOKDPGGDI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x834E670", Offset = "0x834D670", VA = "0x18834E670")]
	public static void OFELEJEKEEL(this Rigidbody NJBJLKMNGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x834E540", Offset = "0x834D540", VA = "0x18834E540")]
	public static void OFELEJEKEEL(this Rigidbody NJBJLKMNGBK, Vector3 LILEPMDKHFI, Quaternion DCEKFABCPDB, Vector3 LCJMECGIHDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct CMDLBMCKJFH : IReadOnlyList<GOLADBGGMAB>, IEnumerable<GOLADBGGMAB>, IEnumerable, IReadOnlyCollection<GOLADBGGMAB>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct KGNGLEEIJOK : IEnumerator<GOLADBGGMAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly MLBLOFEMENF PMNGIBDJKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator CGEANDCJOJI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GOLADBGGMAB AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8350830", Offset = "0x834F830", VA = "0x188350830", Slot = "4")]
			get
			{
				return default(GOLADBGGMAB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x83507E0", Offset = "0x834F7E0", VA = "0x1883507E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5447A30", Offset = "0x5446A30", VA = "0x185447A30")]
		public KGNGLEEIJOK(MLBLOFEMENF PMNGIBDJKEE, NativeArray<LocalId>.Enumerator CGEANDCJOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8350720", Offset = "0x834F720", VA = "0x188350720", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8350760", Offset = "0x834F760", VA = "0x188350760", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83507A0", Offset = "0x834F7A0", VA = "0x1883507A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AENBPPFEJMA EBEJPHPLJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> IGGAEBJHGKC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GOLADBGGMAB LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8349D10", Offset = "0x8348D10", VA = "0x188349D10", Slot = "4")]
		get
		{
			return default(GOLADBGGMAB);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83496F0", Offset = "0x83486F0", VA = "0x1883496F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int IEBODBPAGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MLBLOFEMENF COOMBFPNNDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8349550", Offset = "0x8348550", VA = "0x188349550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OJMOGCONOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8349660", Offset = "0x8348660", VA = "0x188349660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> LMMNCIPAHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B1C0", Offset = "0x2C4A1C0", VA = "0x182C4B1C0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> FGECELHLKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83494B0", Offset = "0x83484B0", VA = "0x1883494B0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8349A80", Offset = "0x8348A80", VA = "0x188349A80")]
	public CMDLBMCKJFH(int HDEDDOIEPID, MLBLOFEMENF PMNGIBDJKEE, Allocator FKPBEKMFPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8349BE0", Offset = "0x8348BE0", VA = "0x188349BE0")]
	public CMDLBMCKJFH(AENBPPFEJMA EBEJPHPLJAD, NativeArray<LocalId> IGGAEBJHGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8349BF0", Offset = "0x8348BF0", VA = "0x188349BF0")]
	public CMDLBMCKJFH(AENBPPFEJMA EBEJPHPLJAD, NativeArray<Entity> IGGAEBJHGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x83499F0", Offset = "0x83489F0", VA = "0x1883499F0")]
	internal CMDLBMCKJFH(MLBLOFEMENF PMNGIBDJKEE, NativeArray<Entity> PCOPFIMLFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8349980", Offset = "0x8348980", VA = "0x188349980")]
	internal CMDLBMCKJFH(MLBLOFEMENF PMNGIBDJKEE, NativeArray<LocalId> IGGAEBJHGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8349B30", Offset = "0x8348B30", VA = "0x188349B30")]
	public CMDLBMCKJFH(MLBLOFEMENF PMNGIBDJKEE, int FCCMJLNEMIB, Allocator FKPBEKMFPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8349C60", Offset = "0x8348C60", VA = "0x188349C60")]
	public CMDLBMCKJFH(CMDLBMCKJFH EIKHHFFMBOP, Allocator FKPBEKMFPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8349240", Offset = "0x8348240", VA = "0x188349240")]
	public void CNNAEIEFJDJ(List<GOLADBGGMAB> KKAPDLIJLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x83496A0", Offset = "0x83486A0", VA = "0x1883496A0")]
	public void KPNEMAEDEKA(int HLGKMAPOEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8349100", Offset = "0x8348100", VA = "0x188349100")]
	public CMDLBMCKJFH AABAGJPEDHJ(Allocator FKPBEKMFPLB)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8349750", Offset = "0x8348750", VA = "0x188349750")]
	public Span<GOLADBGGMAB> PDEKNGAIMFO()
	{
		return default(Span<GOLADBGGMAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x83491A0", Offset = "0x83481A0", VA = "0x1883491A0")]
	public CMDLBMCKJFH AMLCMEJMPOG(int LMLEMDDGACN, int FCCMJLNEMIB)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8349510", Offset = "0x8348510", VA = "0x188349510", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x83495A0", Offset = "0x83485A0", VA = "0x1883495A0")]
	public KGNGLEEIJOK GHDHEBFDHCI()
	{
		return default(KGNGLEEIJOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x83498A0", Offset = "0x83488A0", VA = "0x1883498A0", Slot = "6")]
	private IEnumerator<GOLADBGGMAB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8349910", Offset = "0x8348910", VA = "0x188349910", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KBFNFPMHCGM
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D178E0", Offset = "0x3D168E0", VA = "0x183D178E0")]
	public static FHHKDIEHOCM<T> CNGCCCJDBGD<T>(this CMDLBMCKJFH BKFMBMLFOLE) where T : Component
	{
		return default(FHHKDIEHOCM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct MFGLPJADLCK : IList<GOLADBGGMAB>, ICollection<GOLADBGGMAB>, IEnumerable<GOLADBGGMAB>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct GAGCKMADNAD : IEnumerator<GOLADBGGMAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MLBLOFEMENF PMNGIBDJKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator CGEANDCJOJI;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GOLADBGGMAB AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x834CBD0", Offset = "0x834BBD0", VA = "0x18834CBD0", Slot = "4")]
			get
			{
				return default(GOLADBGGMAB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x834CB80", Offset = "0x834BB80", VA = "0x18834CB80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5447A30", Offset = "0x5446A30", VA = "0x185447A30")]
		public GAGCKMADNAD(MLBLOFEMENF PMNGIBDJKEE, NativeArray<LocalId>.Enumerator CGEANDCJOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x834CAC0", Offset = "0x834BAC0", VA = "0x18834CAC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x834CB00", Offset = "0x834BB00", VA = "0x18834CB00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x834CB40", Offset = "0x834BB40", VA = "0x18834CB40", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MLBLOFEMENF PMNGIBDJKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> IGGAEBJHGKC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GOLADBGGMAB LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8353620", Offset = "0x8352620", VA = "0x188353620", Slot = "4")]
		get
		{
			return default(GOLADBGGMAB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8353710", Offset = "0x8352710", VA = "0x188353710", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83531F0", Offset = "0x83521F0", VA = "0x1883531F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83531F0", Offset = "0x83521F0", VA = "0x1883531F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> LMMNCIPAHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B1C0", Offset = "0x2C4A1C0", VA = "0x182C4B1C0")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool COBLKMLKMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8353510", Offset = "0x8352510", VA = "0x188353510")]
	public MFGLPJADLCK(MLBLOFEMENF PMNGIBDJKEE, Allocator FKPBEKMFPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8353590", Offset = "0x8352590", VA = "0x188353590")]
	public MFGLPJADLCK(MLBLOFEMENF PMNGIBDJKEE, int FCCMJLNEMIB, Allocator FKPBEKMFPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8352C30", Offset = "0x8351C30", VA = "0x188352C30")]
	public CMDLBMCKJFH BMDDEIAGIBJ()
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8352D40", Offset = "0x8351D40", VA = "0x188352D40", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8352D80", Offset = "0x8351D80", VA = "0x188352D80", Slot = "13")]
	public bool Contains(GOLADBGGMAB ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8352E10", Offset = "0x8351E10", VA = "0x188352E10", Slot = "14")]
	public void CopyTo(GOLADBGGMAB[] MFIJBPNIELL, int EFMHKDAINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8352BB0", Offset = "0x8351BB0", VA = "0x188352BB0", Slot = "11")]
	public void Add(GOLADBGGMAB ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8353140", Offset = "0x8352140", VA = "0x188353140", Slot = "7")]
	public void Insert(int HLGKMAPOEBE, GOLADBGGMAB ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8353280", Offset = "0x8352280", VA = "0x188353280", Slot = "15")]
	public bool Remove(GOLADBGGMAB ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x83530B0", Offset = "0x83520B0", VA = "0x1883530B0", Slot = "6")]
	public int IndexOf(GOLADBGGMAB ADPMEPGEIDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8353230", Offset = "0x8352230", VA = "0x188353230", Slot = "8")]
	public void RemoveAt(int HLGKMAPOEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8352FE0", Offset = "0x8351FE0", VA = "0x188352FE0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8353020", Offset = "0x8352020", VA = "0x188353020")]
	public GAGCKMADNAD GHDHEBFDHCI()
	{
		return default(GAGCKMADNAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8353350", Offset = "0x8352350", VA = "0x188353350", Slot = "16")]
	private IEnumerator<GOLADBGGMAB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8353430", Offset = "0x8352430", VA = "0x188353430", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HJOAMFNHALA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GOLADBGGMAB NPGODMAMNCO(GOLADBGGMAB IGGAEBJHGKC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface APCILEMGGAI : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface OICIEHEDNEI : PMIMKBICCCD, GCKIEPKGGOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	PFNICHBNDIH BHJNMMAHAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	AENBPPFEJMA AGHBBKAIAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface GCKIEPKGGOK
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool EDNAKOIKBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface IGPJHALKBOM
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFNBOCEIOKI(bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPJFAMEFLHG();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface CABPMMMMPBM
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool ICDCHEDPGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool HLHNONONCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PPHALBKEIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JHIGKCOIKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ONBELAFIMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LGHAHCNBKOK(bool OPEAEGJENDN);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GGKKJOPELBA(ByteString LNFFBONFPEI);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BEJOOKLCFKD();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PFAADHDHKEE();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LGEIOBAGHKB();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface IANIJLFPGEK
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	BLPLIKKLKBG BHJNMMAHAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LDGOHEECGAG PKBEBJHJCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	PIOPCFKGHHN ODBMKAENKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	OICIEHEDNEI EDKNGMEADGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	DDOPFJHAODP KJINONKNMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	CABPMMMMPBM CICFCNMFIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	KBGMLCPGKEG NJPHMHJPCGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	MDFLJFLBGJG PHBNFMLPFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	BNKIBCCPBDC BCBCBDNNLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	ALDCMNCNIJH IPAAGBGNNHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	MIIIGKJCFDN KCDAOEDOCAN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	BPONEBCIIEL OCEBIFCLDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	MLBLOFEMENF COOMBFPNNDC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	ECMDBAEGKKP MBKDCFEGJMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	MIKJANMMKCG MPKFDGCMCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	KEKEOBFOFFF MFICJFNJIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	GOMJCBGPGNE LMGEGJHPHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DFCBFNPFHHH OIPPFEPHJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EPDIJBLMGLH OENAIAHEOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KGCLJGPLLND NDPMGNDOENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	CCCAELDKIOF NJECNJNCGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NDFODAJELCD FENJPFMFKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	PFHPACGGLIC JHFHJDHMGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	OPJBKKJOEBE HMFIGEBEMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	CEAHOBBINHN CGPMEGIGKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	HMKLJJFFGLI JEMDAKEDMOM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IILECJGHNJE IGPPAHJLLGC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CPPFMOPAJKK DLLFACHBFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KGBEBGKEIFG FEKEMHBAHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	HIFCFPPLBEL LIGIDBGHKHM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JBLPNFMGFEF ANIEOBIGEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	AIMNAMMCJGJ AABFOAEAFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IFOBNLBBBGH AJKINOANINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OKLMALKFJGP NDPDJFIOOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	FOGHOLNHJOB FLFKOKCFHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	LGCDPGHHJKB AEPGCALCKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	KFADKFHALNL LCODBHPBDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	BNJLPOMMMFC NLJHHAFOBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	FFHJOEFABLH ELJKAADBENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	KCBEMDIBPFN PBCNJPPNBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(FLFDGBCKEJL))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct GOLADBGGMAB : IComparable<GOLADBGGMAB>, IEquatable<GOLADBGGMAB>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly GOLADBGGMAB MELDNPHKGNM;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int HENFLOAJNAM = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int LOFAHLKIHCL = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int ILMJDAIBBMM = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int FGKPFIIJHPH = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId MPAKEJAFLKL;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MLBLOFEMENF COOMBFPNNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8348690", Offset = "0x8347690", VA = "0x188348690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public OICIEHEDNEI EDKNGMEADGL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x834DBA0", Offset = "0x834CBA0", VA = "0x18834DBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LocalId NOKOPNPECNE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x834DEF0", Offset = "0x834CEF0", VA = "0x18834DEF0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal AENBPPFEJMA AGHBBKAIAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x834DE90", Offset = "0x834CE90", VA = "0x18834DE90")]
		get
		{
			return default(AENBPPFEJMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool KLJIOEKBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x834DA80", Offset = "0x834CA80", VA = "0x18834DA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private bool PIGLAIJOGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x834DEA0", Offset = "0x834CEA0", VA = "0x18834DEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x834E200", Offset = "0x834D200", VA = "0x18834E200")]
	public GOLADBGGMAB(MLBLOFEMENF NCAGJDOLNIC, LocalId MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x834E2C0", Offset = "0x834D2C0", VA = "0x18834E2C0")]
	public GOLADBGGMAB(AENBPPFEJMA EBEJPHPLJAD, LocalId MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
	public CJNFLLJGPFC OAHBFHCCPKC()
	{
		return default(CJNFLLJGPFC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x834DF30", Offset = "0x834CF30", VA = "0x18834DF30")]
	public static LocalId MJOOONLKLLN(GOLADBGGMAB OIBMMJFJCFK)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x834DF70", Offset = "0x834CF70", VA = "0x18834DF70")]
	public static Entity MJOOONLKLLN(GOLADBGGMAB OIBMMJFJCFK)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x834DFB0", Offset = "0x834CFB0", VA = "0x18834DFB0")]
	public static bool PHGIAKEDBEK(GOLADBGGMAB JDINPJIAKOC, GOLADBGGMAB LDPKBPICKKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x83434D0", Offset = "0x83424D0", VA = "0x1883434D0")]
	public static bool BDCEBPMLGHE(GOLADBGGMAB JDINPJIAKOC, GOLADBGGMAB LDPKBPICKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x834E0D0", Offset = "0x834D0D0", VA = "0x18834E0D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x834DCF0", Offset = "0x834CCF0", VA = "0x18834DCF0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x834DC00", Offset = "0x834CC00", VA = "0x18834DC00", Slot = "4")]
	public int CompareTo(GOLADBGGMAB EDJHHGMLKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "5")]
	public bool Equals(GOLADBGGMAB EDJHHGMLKFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AHPDPHMPCEN
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8344AB0", Offset = "0x8343AB0", VA = "0x188344AB0")]
	public static AGKIKBEKNMF LMDHLBPAELO(this GOLADBGGMAB PGIOEBKALDP)
	{
		return default(AGKIKBEKNMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class FLFDGBCKEJL
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct AENBPPFEJMA : IEquatable<AENBPPFEJMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte EBEJPHPLJAD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] KNFPKIKAMOM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static MLBLOFEMENF JBGIMEHDKFM;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static OICIEHEDNEI JGFPENJPLOB;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static MLBLOFEMENF[] LLNAIOEADCJ;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static OICIEHEDNEI[] ANEFLEADOOJ;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> KHELKIICLIB;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public OICIEHEDNEI EDKNGMEADGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8343F50", Offset = "0x8342F50", VA = "0x188343F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public MLBLOFEMENF NLGNDJHADKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8343E60", Offset = "0x8342E60", VA = "0x188343E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8344AA0", Offset = "0x8343AA0", VA = "0x188344AA0")]
	static AENBPPFEJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B000", Offset = "0x2C8A000", VA = "0x182C8B000")]
	internal AENBPPFEJMA(byte IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7194550", Offset = "0x7193550", VA = "0x187194550", Slot = "4")]
	public bool Equals(AENBPPFEJMA EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8344710", Offset = "0x8343710", VA = "0x188344710", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1045C40", Offset = "0x1044C40", VA = "0x181045C40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x83449E0", Offset = "0x83439E0", VA = "0x1883449E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x83444F0", Offset = "0x83434F0", VA = "0x1883444F0")]
	private static MLBLOFEMENF EOKOGGPFLHD(byte EBEJPHPLJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8344030", Offset = "0x8343030", VA = "0x188344030")]
	private static OICIEHEDNEI EBPCANICJEN(byte EBEJPHPLJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x83445A0", Offset = "0x83435A0", VA = "0x1883445A0")]
	private static object EPJBAJNKABD(byte EBEJPHPLJAD, object[] NCIPNLHDHEI, object CAILINJCNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x83449D0", Offset = "0x83439D0", VA = "0x1883449D0")]
	private static int POGCFDDDFNI(byte EBEJPHPLJAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8343F40", Offset = "0x8342F40", VA = "0x188343F40")]
	private static int CAEJPFLLFOP(byte EBEJPHPLJAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x83440E0", Offset = "0x83430E0", VA = "0x1883440E0")]
	private static (int, int) EFEBDOOAPEJ(byte EBEJPHPLJAD)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x83449C0", Offset = "0x83439C0", VA = "0x1883449C0")]
	private static byte NIMHACHICLO(int LMOHNMMFGMP, int HLGKMAPOEBE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8343BA0", Offset = "0x8342BA0", VA = "0x188343BA0")]
	internal static AENBPPFEJMA AMNFOKHCMAP(OICIEHEDNEI PKGINIEIOJA, MLBLOFEMENF OOEAPKFLJIP)
	{
		return default(AENBPPFEJMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x83447B0", Offset = "0x83437B0", VA = "0x1883447B0")]
	internal static void JBLNIGGOIJH(AENBPPFEJMA EBEJPHPLJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8344160", Offset = "0x8343160", VA = "0x188344160")]
	private static void EJIODJGCKEL(int HDEDDOIEPID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum GGEIELDKNPE
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	SubGraph,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	SceneMainInitial,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	SceneMainJoining,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SceneAdditive
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JIMACNCCICB
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool FCOLDPJHCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool JDLLHHKAHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool KJLELLAHLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool OJBFIGAPPCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool IJMMFJJDLAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FPAMPPPLLJA
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJJFEFCIOMA(AHDBJOMIKLI PFJIPDCNGCE, int HLGKMAPOEBE);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PLGHIFNBOOP(AHDBJOMIKLI MDLPIFEFLPP, int HLGKMAPOEBE);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IMHEJHDPCGF(LFPGHENCFIG KOBNHLFBPEA, int HLGKMAPOEBE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FNHCLMEOEHF : AHDBJOMIKLI, JIMACNCCICB
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int AFJENEJLCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNIHIJCBDBF(LDEKALLJBMF CBGBGGEBCJG, int HLGKMAPOEBE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AHDBJOMIKLI : JIMACNCCICB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum OAOJEFNEKGN
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Physical_Sticky = 2,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Physical = 4
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool ILBDBOGGALI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool KPMOIPDINAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool KEHENBNEINB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LDEKALLJBMF
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool OJIPJNKEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	GOAIGCDFKPE MKLPPCHKFJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	NFLPHPKBCOA FFGPOMMCPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 JILMILDHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	quaternion FOJJHGMABOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float3 FOANFLBGIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	PAAELMLIHIG AGLIMLFKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	DGOEMBOEDNM CHNEPDKGONI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float DNKGEMIKELB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float3 FLDINEFDOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float MAACNIHPMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	DDFFFHLEFPB JICIOLPIPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BBGAHBIKMNG
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float3 KCFBPENHPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float3 DIIAFCFIKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion OKBHPHBMLNP(float3 IFLOMPHLJDM);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface NFLPHPKBCOA
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool GHDHADLKKMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool EGMNBLKHIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool EEMCFACAADG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float LOMHABMPDKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int IGFAPKMCCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int LAJFHFFJFEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CEIJCDLIIBG(BBGAHBIKMNG CBGBGGEBCJG, int HLGKMAPOEBE);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.OMRoom)]
public class JIOIODPFOAA
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public JIOIODPFOAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface BJEFCKBPBIG
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Guid DEKFAMLPOKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BGGADENGDJE(Guid GKKFBPOHIBF, Guid OMEKNOMEFGA, Guid GIMJFBCOMKO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DDCLFEILLCF(Guid GKKFBPOHIBF, Guid[] OGBMNCOKGEG, Guid GIMJFBCOMKO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid ICCDPKINEDI(Guid GLBONDOGBDB);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JFGKJFKCHEM(GOLADBGGMAB AJBMFNLEKBJ);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HPDGKFMNCAK(Guid GLBONDOGBDB);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GJLMCPJBELG(EFIPOHJBHIM KFEPHDKEPJG, Guid KMMKKPDPCIN);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JODCGLANMEF(Guid GLBONDOGBDB, bool OPEAEGJENDN);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MOAPLJIBKLG(Guid GLBONDOGBDB, AGKIKBEKNMF OFLDDBHKLMB);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KJCINONJAAJ(AGKIKBEKNMF OFLDDBHKLMB);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LNODDKHDNFP(GOLADBGGMAB MPAKEJAFLKL);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface POOLAKCKNGM
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface HHOPKKIICIG
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "0")]
	void PDJECLFEIFK(bool DAKNLGLKCLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface LDGOHEECGAG
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	HHOPKKIICIG DDHPCEJIMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	MMINKNKHNCC IDACPNOHMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	KPIMDKAEBDC KJHKHCKGGAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	JEFBBPMMFHA PAAJCNDHLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	KJGOBLBKEIB NCKGIILODEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	CKMAJNEGHFN EMHFDPEELFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	IJEHOPDKOAG NDEIBHHLEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	CCKFEAOLONI BJIFJBNKGIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface MMINKNKHNCC
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	string AIHKMKINJKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface HNDEHOKNBJG
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLNCBOAADOH(Action DMHPHEGJKMB, bool EOGAABACLEE);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPFPHAGEIHN(string HJLBILHBIIC);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KGOIOHPOBHM(string HJLBILHBIIC, int CAILINJCNIJ);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LFFNAAECJPM([Out] bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HEKBCPBJBOJ([Out] bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HOGFICILDNN([Out] int IOALKPFEKEK);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface KPIMDKAEBDC
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "0")]
	void HKNBJKCIPBO(bool OPEAEGJENDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface JEFBBPMMFHA
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid GKPHEFENPMO;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid AHDDEIICEGC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid HCNCECNDGAA;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid CLIEPEAMHBI;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool EPKEOBAEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool GOEGGAHKEKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool DIDFCCIDLNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool OGPCGKACGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x834F9D0", Offset = "0x834E9D0", VA = "0x18834F9D0", Slot = "4")]
	string[] LCFCMFJCAHF(KKPOINACGCE IAGPPAMHECH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BCJEFHFGBKA();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x834FA60", Offset = "0x834EA60", VA = "0x18834FA60", Slot = "6")]
	Guid NDFLJOKMHOG(Guid OOGFMHOHCCI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int DAJBLCPGAIE(KKPOINACGCE IAGPPAMHECH);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KHFLCAGEBLB(KKPOINACGCE IAGPPAMHECH, NativeArray<MKNKJGNALIB> NMMPEGEDEIK, NativeList<UniformTRS> FAODHBKALGO);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int KEBFGDKPHLL(Guid JFLBGDIIGHK);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool COCNKMCMAEH(string NIMMNBBALAD, [Out] Guid JFLBGDIIGHK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string IADLBEJADML(Guid JFLBGDIIGHK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PKBAHAJNCFN(RRObjectPrefabData NGJHEIJILNH, [Out] LocalId KELHIEHPDJD);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FHHKDIEHOCM<byte[]> JGIALPBMEIO(NativeArray<MKNKJGNALIB> GNFDLEENLGH);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LEJLBJOFBOL(byte[] CBOBEDKAHAH);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GameObject MHAJHDKBMFK(string NIMMNBBALAD);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NCGBMNIMIGO(Transform PLPGMCABFBF, RRObjectPrefabData PMGDGFIIANC, ODDBPMPHPJL IEGLIFIOOBM);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LNNKLBPANLO(KKPOINACGCE IAGPPAMHECH, NativeParallelHashMap<Guid, LocalId> DLFPGHFICEI, [Out] Exception JNADAKHBCKJ);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LALJNNAKAOM(KKPOINACGCE IAGPPAMHECH, NativeParallelHashMap<Guid, LocalId> DLFPGHFICEI, [Out] NativeArray<LocalId> PCOPFIMLFLG, [Out] NativeArray<LocalId> PMOOBGJMBHK, [Out] NativeArray<AuthoredLocalPoseData> KHGFCPMGPHK, Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "19")]
	void LEGDNGIKCLJ(KKPOINACGCE IANLOKBOBGO, NativeArray<int> GLJEAKCGGDG, FNGMMGDEDMM<GameObject> LNDKLNHJNKK, FHHKDIEHOCM<GameObject> NHHCEDBNBJD, GGEIELDKNPE DIDPJPBLFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IBEOKCLEHOP();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "21")]
	void KMEABPOGEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "22")]
	void HEPNOGGLDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "23")]
	bool MEOGODAFIOL(KKPOINACGCE IAGPPAMHECH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "24")]
	FPAMPPPLLJA BILHHADGGHN(KKPOINACGCE IAGPPAMHECH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "25")]
	void HNINMFOHPAC(Guid KCGDPCJFBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "26")]
	bool FOEOBLMDBID(Guid KCGDPCJFBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x834FA90", Offset = "0x834EA90", VA = "0x18834FA90")]
	static JEFBBPMMFHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface EPNDDHNNKIM
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	long ENFBMPKHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long AJNOEOMFHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface KJGOBLBKEIB
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool OAFDKAKOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool JPCEEPJEAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int NDDFOCHAEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int GHKHHOHJENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int NKKMNGFPDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool CPPNPLJOBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	int NMHPHICJJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "6")]
	void AOOIBFBHNCG(POFIOECFANB GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
	void OMMBBKJIJBN(bool KABIBIMCLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "8")]
	bool NHKPOALBPPG(DOHKIBLNJFC KJENEIANJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "9")]
	void AHALJBEAONO(object MBAGIDFJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "10")]
	void ECMNGPIDIGM(object MBAGIDFJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IOCDKJBJFBM(Action<object> MACNEABBDMI);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LENCHJPHNEM(Action<object> MACNEABBDMI);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "13")]
	void HDLKNKMGLFE(NativeArray<ViewId> GGDMGKGFACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "14")]
	void FDLMKNNLDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "15")]
	void LPCBBIBJKOJ(HGPLMIJAIIE BJLNCBFOGNL, ReadOnlySpan<byte> INCJDDLACNP, DOHKIBLNJFC AOLDFGCJAAE, bool JBBJHHAJKEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "16")]
	void LPCBBIBJKOJ(HGPLMIJAIIE BJLNCBFOGNL, ReadOnlySpan<byte> NPANDBJGOJB, bool JBBJHHAJKEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "17")]
	void LPCBBIBJKOJ(HGPLMIJAIIE BJLNCBFOGNL, ReadOnlySpan<byte> NPANDBJGOJB, ReadOnlySpan<byte> AHMLJKHJHKE, bool JBBJHHAJKEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "18")]
	void AJBFALOGCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "19")]
	void LGGNEFKBMEL(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "20")]
	void EMDGGOAONCB(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "21")]
	void HJEGDEJBPFP(Dictionary<object, object> JEHFFIGJGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "22")]
	void PNCEKGFLGHJ(NativeList<AGKIKBEKNMF> FCEIGPDNGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "24")]
	void HFCILMNFNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "25")]
	void AHPHMIIHPIP(List<object> JFIAKHFDPIP, int OBJODNIPNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "26")]
	void CLFHPCPIDAF(int LNJNGPJGPKD, object PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "27")]
	void JEPBOPDIHED(DOHKIBLNJFC KJENEIANJDF, Dictionary<object, object> KAEILAKIAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "28")]
	void EMGOHOCPKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "29")]
	void FDDEBIBFPBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class BDMFJGFAIPP
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8346670", Offset = "0x8345670", VA = "0x188346670")]
	public static KKFJEDBCLHI MPHAGLEPCGK(this KJGOBLBKEIB IEHKKLCADNA, object GFDDDAIMFOH)
	{
		return default(KKFJEDBCLHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct KKFJEDBCLHI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KJGOBLBKEIB IEHKKLCADNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object GFDDDAIMFOH;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8350DD0", Offset = "0x834FDD0", VA = "0x188350DD0")]
	public KKFJEDBCLHI(KJGOBLBKEIB IEHKKLCADNA, object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8350D80", Offset = "0x834FD80", VA = "0x188350D80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OHBJLJBJFEE
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void CBBPJDDFGFO(ViewId FKHACEBFNLD, BJLFHMKMEJE FOKDCDPHAON, int JLNNGEFEACL);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "0")]
	void DMPOMNOOGCK(CBBPJDDFGFO KGDMJIPLNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "1")]
	void CHJIEGPNNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "2")]
	void GCPBPCJMDEM(PJEMIAGADJB NPMBPMNFANE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface LENGEAAJJFN
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[ServiceLifetime(Lifetime.Application)]
public interface CKMAJNEGHFN
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct DENIBMEDBHC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private CKMAJNEGHFN MACKKEJNHMH;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x834AA60", Offset = "0x8349A60", VA = "0x18834AA60")]
		public DENIBMEDBHC(CKMAJNEGHFN MACKKEJNHMH, string CJOMCGGBBON, string MHANOCEEHFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x834A9A0", Offset = "0x83499A0", VA = "0x18834A9A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct MFKLMHLKLBG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private CKMAJNEGHFN MACKKEJNHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task CAIMNCAIJDI;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x83537A0", Offset = "0x83527A0", VA = "0x1883537A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "0")]
	void MLNAKHIKJDJ(string OBCNAJEENCI, float MFKAPIFDPJJ = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "1")]
	void DDMCIJCDGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLHEMGAOGFE(bool HNDJOOKMBHM, string CJOMCGGBBON, string MHANOCEEHFI);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "3")]
	void MPFBOAFAFMB(string OBCNAJEENCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class EGCLPJEJGMK
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x834B650", Offset = "0x834A650", VA = "0x18834B650")]
	public static CKMAJNEGHFN.DENIBMEDBHC IKIGPOOAFEK(this CKMAJNEGHFN IEHKKLCADNA, string CJOMCGGBBON, string MHANOCEEHFI)
	{
		return default(CKMAJNEGHFN.DENIBMEDBHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface HEJLGLCOBBJ
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BLBAMNHDJIB(GameObject GLGAAAMILBJ);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABPMOHOFPNE(GameObject GLGAAAMILBJ);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBPKGBEAHBK(int KJENEIANJDF);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object KGBHAECCINN(GOLADBGGMAB MPAKEJAFLKL, GameObject GLGAAAMILBJ, Action<GOLADBGGMAB, int> HCEFPMMOBCM);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNPBIPINAGI(GameObject GLGAAAMILBJ, object IHEIBLEBLBB);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface COPFKHOIBCH
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNLKIHKBDNB(HDLEPENBPIC BHCELHKNNAD, OGKGADHHDKM HGKEEFLEOJB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface EEDOKNFCIBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBGBLPHHDGN(object PGIOEBKALDP, NativeList<byte> INCJDDLACNP);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object LABNBGADOBH(NativeArray<byte> INCJDDLACNP);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface MEEMDHEILID
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool JBNNKOAFJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate OJDPPKAMOAJ(KGEJCFCCIMK DKIMHNOEMEK, Action<KGEJCFCCIMK> HCEFPMMOBCM);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJCABBGPPLO(KGEJCFCCIMK DKIMHNOEMEK, Delegate HCEFPMMOBCM);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate NNMBHJOAHHN(KGEJCFCCIMK DKIMHNOEMEK, Action<KGEJCFCCIMK> MDNOAJFCLDL);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LNCANNEEHNK(KGEJCFCCIMK DKIMHNOEMEK, Delegate HCEFPMMOBCM);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OIEKHFOHMAM(KGEJCFCCIMK DKIMHNOEMEK);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KGEJCFCCIMK BFGKLFNHEBP(GameObject GLGAAAMILBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface INBKFMJEFGN
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int OPMHNMJJFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	int AEAINCDIFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool OAFDKAKOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool NJDMKPENLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool EPHNENBJILI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GOLADBGGMAB DLLEGODOCJK(int KJENEIANJDF);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FBMLBAABKDI(GameObject MCCPHEPHBCG, JobHandle KPLKEILMHHC);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface DFCBBOEONAP
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNLKIHKBDNB(int NFDMOMMJDAE, OGKGADHHDKM EGLMDHKAILI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface IJEHOPDKOAG
{
	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool ICDCHEDPGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface CPHOFNKOFED
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	CANHEHLEDKA DGNOGNOGGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	DJNEMOFCFJP AKEFDKNONMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool JPENNGGFIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EIMLGFNMNJD(Transform PLPGMCABFBF);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OAKMJGCFIOI(Transform PLPGMCABFBF, CFCGOEKOEDO NMGMOCMPOBC);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IGBCNEFHOND(Transform PLPGMCABFBF, CIMLIBKMPND PJBEBIJGJFC);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface CCKFEAOLONI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PNHPBAEHNEH;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface DENACGCGGOI
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOBLJFHKLJM();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[ServiceLifetime(Lifetime.Application)]
public interface GEBHKMMBADE
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAFIOIPHOHH(GameObject GLGAAAMILBJ, NOMBAAECKJJ BPPMGELHIEA, HPIHHCJGCCG FOMIBGBDJKB);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDMKLGJEMFE(GOLADBGGMAB MPAKEJAFLKL, bool NBFHOJFPJIC, float3 IOPJNEEAMKD, quaternion IOFMGNPCNDG);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ANIMILGGIJH(CMDLBMCKJFH BMCBMHMNJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PGKMGIHLPKI(CJNFLLJGPFC FICFFHNKAMC, CJNFLLJGPFC AOJAHPGAGPO, EJKKDGPBELM CBONFFLHKGG);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNEBOEAMBPI(CJNFLLJGPFC FICFFHNKAMC, EJKKDGPBELM CBONFFLHKGG);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDCMONOEAEI(CMDLBMCKJFH MPIEFLFKCKM);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OGDGABCABBG(KKPOINACGCE PMJGKHFECJP, ReadOnlySpan<Guid> BADMDHKKKNN, ReadOnlySpan<int> HGIBCODHGGD, FHHKDIEHOCM<GameObject> IGKLOCLDDEN);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HIGLADLBMCD(PDCONBAHHJI APBLHJLFMFG);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EMEPPHKIEGI(GIFNDPKOGGC NKLMBKKDHMG, GIFNDPKOGGC LCFMDLFHBPM);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GLMFELKGIFC(GIFNDPKOGGC NKLMBKKDHMG, GIFNDPKOGGC LCFMDLFHBPM);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GIHHDJEFDNI(GOLADBGGMAB EGHDDKEHAPO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct IDLJOBAAEPF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> INCJDDLACNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle EBEJPHPLJAD;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x834F4F0", Offset = "0x834E4F0", VA = "0x18834F4F0")]
	public IDLJOBAAEPF(ReadOnlyMemory<byte> DFGJHNEFDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x834F4B0", Offset = "0x834E4B0", VA = "0x18834F4B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum NANLJKBMFMJ
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	V0PreObjectModel = 0,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	V1ObjectModelHierarchy = 1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	V2ObjectModelHierarchy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	V3Entities050 = 3,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	V4Entities050Compressed = 4,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	V5BumpObjectModelVersionMay2024 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	OldestCompatibleVersion = 3,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	LatestVersion = 5
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct KKPOINACGCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString OOGCCDCMHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object NPGPLACBDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object FLCMABNKDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> JEJAFNHKJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool JENIMPOOKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public IEJLCKLIGMC.DNJMCCGCGBG? HFJGHOFKAGJ;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8350E60", Offset = "0x834FE60", VA = "0x188350E60")]
	public KKPOINACGCE(ByteString OOGCCDCMHHB, [Optional] object NPGPLACBDPL, [Optional] object FLCMABNKDEB, [Optional] IEnumerable<string> JEJAFNHKJFF, bool JENIMPOOKGH = true, [Optional] IEJLCKLIGMC.DNJMCCGCGBG? HFJGHOFKAGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct KNJMAOBEAPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object GCPGFLNMMKN;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct MKNKJGNALIB
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Flags]
	public enum PPALLFGCDKF
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		IsInvalid = 1,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		IsStudioPrefab = 2,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		IsBetaOnly = 4,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		IsDevOnly = 8,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		IsR1Only = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		IsR1Upgrade = 0x20,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		IsAllowedDevOnly = 0x40
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public RRObjectPrefabData ANFDOPPMPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid ACHLNPFJANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid FKIAOFIGCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid JDMODEPGGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid MBDLENJELJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public PPALLFGCDKF OMENDEGIBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 LICMDCLNGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int PGDEGPGCAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public DKDDPCHLJEF BPHAELEECLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int IMBJEGAMLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int ANAINHLEJBK;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Guid ILFFGJAGLNC
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5444680", Offset = "0x5443680", VA = "0x185444680")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool HHACLEHCKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x83539E0", Offset = "0x83529E0", VA = "0x1883539E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool NKBOBANMIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x83539D0", Offset = "0x83529D0", VA = "0x1883539D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool BOEIJDPMKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8353A00", Offset = "0x8352A00", VA = "0x188353A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool FLJGGEBGGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x83539F0", Offset = "0x83529F0", VA = "0x1883539F0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct IPIEKOKHLLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly LFENPJNOFLP LMLEMDDGACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly LFENPJNOFLP KLLLDNANLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly uint PPEMJNHIMNH;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x834F760", Offset = "0x834E760", VA = "0x18834F760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct GLGCGKEHBDN
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly IPIEKOKHLLG DMHPHEGJKMB;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x834D910", Offset = "0x834C910", VA = "0x18834D910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct MAIGNEAGDAD
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly IPIEKOKHLLG DMHPHEGJKMB;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x834D910", Offset = "0x834C910", VA = "0x18834D910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct CJIGNEFKNEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly uint PPEMJNHIMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly bool MOLOJPEODOC;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8347F70", Offset = "0x8346F70", VA = "0x188347F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct LFENPJNOFLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal int MOAJDMPNBPN;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8350EE0", Offset = "0x834FEE0", VA = "0x188350EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[ServiceLifetime(Lifetime.Application)]
public interface LAOBFCCAOCE
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	LKDDBINMOKI CNPHMEGODOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface EFIPOHJBHIM
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface OMHCFIIDJME
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class JNLBJIIENIL
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3CF1910", Offset = "0x3CF0910", VA = "0x183CF1910")]
	public static CJNFLLJGPFC OAHBFHCCPKC<T>(this T MPAKEJAFLKL) where T : EFIPOHJBHIM
	{
		return default(CJNFLLJGPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8350420", Offset = "0x834F420", VA = "0x188350420")]
	public static MonoBehaviour EKAGBDDJGLK(this EFIPOHJBHIM MPAKEJAFLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x83504A0", Offset = "0x834F4A0", VA = "0x1883504A0")]
	public static GameObject HLLLIANPJBO(this EFIPOHJBHIM MPAKEJAFLKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface GEPCKFJHOLG : EFIPOHJBHIM
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(GOLADBGGMAB NCIBPMAFIKA);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface AOFGEHPBAEO : EFIPOHJBHIM
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CPEHAKDNCAL
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate void FHEAONKHFIK(HEPEIBDNAPC LCKDNAFMMHH);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event FHEAONKHFIK GKFONKCIAFF;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface IALMKICDNNL
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface LKFEPBMFBOA
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface DEFFNBOFLAG
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(GOLADBGGMAB BJOLFGGPDGG);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool HIDAHKFJFLC);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PEJEPCBHJCJ(GOLADBGGMAB GNMFDIECOJL);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface FCDBDHBHEHF
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(EOEFLGKDFOB CELMCLPCLKC);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface EOEFLGKDFOB
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	GameObject GLGAAAMILBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Transform PLPGMCABFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	MFIGOAEMMAF OLDPNPGHOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool PMNFMAGNEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKLFDEELLDD(MFIGOAEMMAF JOEHPNNMIOL);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	POOLCNKIBAH GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class OPCBMDJDODM
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x83595B0", Offset = "0x83585B0", VA = "0x1883595B0")]
	public static void CDNNNGNLGBC(this EOEFLGKDFOB FBMIODACPPK, ODDBPMPHPJL IEGLIFIOOBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface MFIGOAEMMAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Rigidbody CHKPFCFBIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	EOEFLGKDFOB JANONHMEKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	GameObject HLLLIANPJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	Transform DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	MFIGOAEMMAF GDFCPOBJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	MFIGOAEMMAF AOHAMHAHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	int KCCFAOPCIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	bool FKHKIDHBPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	bool OIEKHFOHMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool DJDBGPECKIC
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	CJDPDAAMOBM MMEHAJFLOLP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	NEPEHFKKAHG GJFLFCKDPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	float ILLCHEIADLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Vector3 MNAOACFOFFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 FFGOEMCJOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 CEBEECPEOGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 MPBGIMEBLAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool DPCAIJIEHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool EOKLDEIAEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool PHDHLJLMIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool NJMEINAJFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Vector3 DGPJNKHKOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Vector3 OCPCNFPMMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 JHEJMAHNPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Vector3 MHMKILICHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	float AMGCMLCLCBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	float DPJEGOOLEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Vector3 HOCIMGJPKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Quaternion EIJGCCEDODN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	float EECOPGNPCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float ABDAAKPCHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool AKBHMCCMMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	JEHFMNHABAI OAFIDMJJIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	bool HBGAICGJHMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	Transform BMDDMEMBCIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	Vector3 EFJMBKOHGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	float JHLOPGGKKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	float GNGHPELMGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	Quaternion NAIEIHHDDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Vector3 KCFBPENHPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Quaternion JEKEGKDFCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	RigidbodyConstraints LMOGEOKLEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	bool CLKOFGBADDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	CollisionDetectionMode OKCKKBNNDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	bool HNJOCDCIFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FIIMNHMKNMH PNOOHILMNMA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FIIMNHMKNMH PBICCJJDPLG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FIIMNHMKNMH NNMBHEJKLMO;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event FIIMNHMKNMH PNCLDBFDLCI;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event FIIMNHMKNMH ACOJALPIMJC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FIIMNHMKNMH ACKGCCKHMDK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FIIMNHMKNMH DMHOGJALOCI;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PALGGIDOPDJ ALJOINIAEFA;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<FECJOJFDCBL, FECJOJFDCBL> NPPNIPCOAAB;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MFIGOAEMMAF NNOGBOEKNJK(int HLGKMAPOEBE);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void DKLLEIPOFLE((Quaternion rot, Vector3 moments) MOHIENDLLGP);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void IDNMFFEDDDN();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void PNAOLOMOOIO();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void IGIOGBHBKAP();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void CODFBDJOOGP();

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void DHDDBOHNOOD();

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void AKCKLCNBHIA(MFIGOAEMMAF IOALKPFEKEK, bool LPDEIPGKDOE = false);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void BKHFHMPHKII(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void NGFIIFHOJBG(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 JBOHEHCFJIJ(Vector3 EJHCENJMOAJ);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 CBFAIKHJJKJ(Vector3 LPNLMKHOCCP);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void BLKJDILGPAN();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void IEENEHDMNDP();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void EOHEMBCJBEF();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void HMFOBNPECJD(Vector3 MKOHLGDKLKH, Vector3 BCOOKGPOLPI);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void EAGOLEOOLDD(Vector3 MPLGBPBMKDL, Vector3 JOHCPGENEAP);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void ENLCBFECKGI(Vector3 GKNFGDJONME);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void KDKEDIKDALM(PDEAKMCNOBP BHODJGJGDPL, Vector3 HDFLLIHEFEL, float BHOMNNEBJAB, float NFNKFEGBCDH = 8f, float BFCHCLEELBL = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void FHALJOPICEM(IPOBJHPAPLB IIMDKLGOCHN, Vector3 PDIJEFFPDPG, float HIFIKLNHOGN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void GJMOALLKOJC(IPOBJHPAPLB IIMDKLGOCHN, Vector3 KDHLIJMPIFF, float FJKPDIEAPAB = 7f, float CGBPKBEEFCI = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 DMPOJLEPCJM(Vector3 IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 INLIJDBNMNK(Vector3 IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void DMKJCHLEDNN();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void FOPOGIAODMJ(MFIGOAEMMAF AJICGEOMBJL, object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void MECAPMPJANI(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void FANGIMEHNDB();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void ADJGMOJPIGC();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void OHOPNDOPGNC();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool PGBDNOKPCJD();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void IPDLPKIGAIL();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void MBKNGPCCHDF(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void FJHOMGODMDJ(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void GLIAEMFMKNK(object GFDDDAIMFOH, bool NALIKJHDOEC);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void LECOOJEKMAC(Vector3 JEDFBKNAHJC, Quaternion GNCFNEMFPLP);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void GKPLKLEHMBK(Vector3 JFMFLMJAIHA, Quaternion FPFHCEKDEIC);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool OHKKGLFGECJ(float IOPKIIHMCNB);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void NPDNOHFBENH(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void FDDNIOOIKLE(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void CDDNPCBBODL(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void MDHCFFHBIKL(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void HEMDJAKLKFB(Vector3 HOJOMGEINAH, ForceMode DLJNDNGFIPO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void AIADFLLFLEP(Vector3 HOJOMGEINAH, Vector3 EBGKGBGFPOC, ForceMode DLJNDNGFIPO);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void HMNBOIPBKPM(Vector3 LAOLJOAKMLI, ForceMode DLJNDNGFIPO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void MGKIMILNCCG(Vector3 LAOLJOAKMLI, ForceMode DLJNDNGFIPO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool NIECBDANKIP(Vector3 NBFEGPDMMPI, [Out] RaycastHit CPCOHHMIMEG, float OAGBEPAKAEK);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void DAEOFNOBLFE();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface NEPEHFKKAHG
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class KMCMEOOACEE : NEPEHFKKAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KMCMEOOACEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "0")]
	void JNHCNBGAODE(Vector3 MFIGBPJHFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "1")]
	void GFJLALCLDJA(Vector3 MPLOLODGAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "2")]
	void FGJKHBDBFHA(Vector3 MFIGBPJHFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "3")]
	void KGPECCPGADD(Vector3 MPLOLODGAEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface CJDPDAAMOBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 EFNDDNNNFJE();

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BJBALAFBFOB();

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OHLADPAAILJ(float FFEIAKDDJNH, float KLDFFENIOMK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate void FIIMNHMKNMH(EOEFLGKDFOB NNBOLFEAABK);
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum BDDLIHMDHOO
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum PDEAKMCNOBP
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public delegate void PALGGIDOPDJ(EOEFLGKDFOB NNBOLFEAABK, bool LPDEIPGKDOE = false);
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum IPOBJHPAPLB
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct POOLCNKIBAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Rigidbody OEKAMIKGJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public object ELAKGDCNKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 PBPJMOAKLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector3 JBGGFJIIHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public PCMEBGNJIKH ELGDGMOPDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool PGAKEDBLLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool AHHBGIDLNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool JFAFPNDNJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool BOGIKDDEIJG;
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct CJNFLLJGPFC : IEquatable<CJNFLLJGPFC>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly CJNFLLJGPFC NKEMJGNDPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public GameObject GLGAAAMILBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8348AE0", Offset = "0x8347AE0", VA = "0x188348AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public AGKIKBEKNMF BGAJFIDHOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8348080", Offset = "0x8347080", VA = "0x188348080")]
		get
		{
			return default(AGKIKBEKNMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public MICGIIPNHMN AKDBMIGNJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8348DC0", Offset = "0x8347DC0", VA = "0x188348DC0")]
		get
		{
			return default(MICGIIPNHMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public RRObjectPrefabData MNFCPACEDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8348E60", Offset = "0x8347E60", VA = "0x188348E60")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool IOELPMJKJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x83483D0", Offset = "0x83473D0", VA = "0x1883483D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool FPEGCFMDMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8348920", Offset = "0x8347920", VA = "0x188348920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool OJIPJNKEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x83485D0", Offset = "0x83475D0", VA = "0x1883485D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool JHCEFOOMHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8348840", Offset = "0x8347840", VA = "0x188348840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool ADKPBHOOHOP
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8348AC0", Offset = "0x8347AC0", VA = "0x188348AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool FDKBLAAPMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8348730", Offset = "0x8347730", VA = "0x188348730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool HIGJJOGCNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x8348220", Offset = "0x8347220", VA = "0x188348220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool FOENHJAGLCG
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8348890", Offset = "0x8347890", VA = "0x188348890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool FPCOKLOOJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8348A80", Offset = "0x8347A80", VA = "0x188348A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool FLODNOBCOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8348940", Offset = "0x8347940", VA = "0x188348940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool HCECLNDBAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x83486F0", Offset = "0x83476F0", VA = "0x1883486F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool BCEDPENPDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8348390", Offset = "0x8347390", VA = "0x188348390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool BIHBCFONCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8348440", Offset = "0x8347440", VA = "0x188348440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool IGLBEBNIJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8348D80", Offset = "0x8347D80", VA = "0x188348D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool NBOBIMOHNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8348760", Offset = "0x8347760", VA = "0x188348760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool IMIEBEBLKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x83482B0", Offset = "0x83472B0", VA = "0x1883482B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public LLOLNNIDILF DILMECHBEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(LLOLNNIDILF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public EBAOFBFMJMG KPHPHHFMJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(EBAOFBFMJMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public MOOFIFIGCAK MBKDCFEGJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(MOOFIFIGCAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public MJJIIHECNBN MEAAFBOFIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(MJJIIHECNBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public NMFABAPCAFJ HKCMBOFKBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(NMFABAPCAFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public DAKHKHGFNBA OCNBCBNHDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(DAKHKHGFNBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public AMGKEEKAKDM EJKBHFGBLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(AMGKEEKAKDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public FPMLPDAOCGO LNNIBKPCFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(FPMLPDAOCGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public MOJOGEGEGIA HDCAKEEHEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(MOJOGEGEGIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public PCDNPCOAGBO MPKFDGCMCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(PCDNPCOAGBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public NKGJACDBEIO FHDMECIFEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(NKGJACDBEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public DJIFKPNNEJF FMKGAGADINI
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(DJIFKPNNEJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public FKBOEGEAPMM ADIEMGNDCEC
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(FKBOEGEAPMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public OKEOPEJAAFF BBJLDDIPNCN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(OKEOPEJAAFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public OFHPLFDMCLD PCEKLPDOJMM
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(OFHPLFDMCLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool IBHPPEEIDNH
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8348120", Offset = "0x8347120", VA = "0x188348120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool JDGNJMGCNMG
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8348010", Offset = "0x8347010", VA = "0x188348010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public bool CAHCLDLFENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8348550", Offset = "0x8347550", VA = "0x188348550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool KLJIOEKBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8348210", Offset = "0x8347210", VA = "0x188348210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool JOFPIKJHMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8348510", Offset = "0x8347510", VA = "0x188348510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool BLEKOLGDHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8348590", Offset = "0x8347590", VA = "0x188348590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool EJNKNKKHNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8348D40", Offset = "0x8347D40", VA = "0x188348D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public PINGJEPFKOC DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(PINGJEPFKOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public NAPFIGODKNN IPAAGBGNNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(NAPFIGODKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private MLBLOFEMENF COOMBFPNNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8348690", Offset = "0x8347690", VA = "0x188348690")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static CJNFLLJGPFC MJOOONLKLLN(GOLADBGGMAB NCIBPMAFIKA)
	{
		return default(CJNFLLJGPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8348CC0", Offset = "0x8347CC0", VA = "0x188348CC0")]
	public AJMHKKHLCIF OBOHFJHKFDC()
	{
		return default(AJMHKKHLCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8348860", Offset = "0x8347860", VA = "0x188348860")]
	public ACHOHANJLJJ GFBKJAKCFDM()
	{
		return default(ACHOHANJLJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x83488D0", Offset = "0x83478D0", VA = "0x1883488D0")]
	public OHIIGKFDNND HOKMEIECKJP()
	{
		return default(OHIIGKFDNND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8348050", Offset = "0x8347050", VA = "0x188348050")]
	public KJCPAGPLMIL AIKEIHLKKON()
	{
		return default(KJCPAGPLMIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x83482F0", Offset = "0x83472F0", VA = "0x1883482F0")]
	public CIFFABOAGKM DAIANHNPHPB()
	{
		return default(CIFFABOAGKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8348260", Offset = "0x8347260", VA = "0x188348260")]
	public NFPCPAGOMBF BOANJLBCNJB()
	{
		return default(NFPCPAGOMBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8348340", Offset = "0x8347340", VA = "0x188348340")]
	public GIFNDPKOGGC DAPJKIEMHCM()
	{
		return default(GIFNDPKOGGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x83483F0", Offset = "0x83473F0", VA = "0x1883483F0")]
	public OJEDNNLAKPN EHPJLCEJICH()
	{
		return default(OJEDNNLAKPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8348C70", Offset = "0x8347C70", VA = "0x188348C70")]
	public JHFPLKOAGAM NJEDJELOABL()
	{
		return default(JHFPLKOAGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8348980", Offset = "0x8347980", VA = "0x188348980")]
	public void KAICBOPJKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x83487A0", Offset = "0x83477A0", VA = "0x1883487A0")]
	public void GBLOHGCCHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x83485F0", Offset = "0x83475F0", VA = "0x1883485F0")]
	public bool FIEAFHDEMCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x8348F90", Offset = "0x8347F90", VA = "0x188348F90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public CJNFLLJGPFC(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x83439A0", Offset = "0x83429A0", VA = "0x1883439A0")]
	public static bool MJOOONLKLLN(CJNFLLJGPFC IOALKPFEKEK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static GOLADBGGMAB MJOOONLKLLN(CJNFLLJGPFC IOALKPFEKEK)
	{
		return default(GOLADBGGMAB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x83464B0", Offset = "0x83454B0", VA = "0x1883464B0")]
	public static bool PHGIAKEDBEK(CJNFLLJGPFC JDINPJIAKOC, CJNFLLJGPFC LDPKBPICKKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x83434D0", Offset = "0x83424D0", VA = "0x1883434D0")]
	public static bool BDCEBPMLGHE(CJNFLLJGPFC JDINPJIAKOC, CJNFLLJGPFC LDPKBPICKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8348480", Offset = "0x8347480", VA = "0x188348480", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(CJNFLLJGPFC EDJHHGMLKFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct FKBOEGEAPMM : IEquatable<FKBOEGEAPMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private OKLMALKFJGP MALJLFFAOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x834C160", Offset = "0x834B160", VA = "0x18834C160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x834C060", Offset = "0x834B060", VA = "0x18834C060")]
	public void CMMBLAAGOJB(uint PBJHGGBBAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x834C350", Offset = "0x834B350", VA = "0x18834C350")]
	public bool JIBGBDNJECO([Out] uint PBJHGGBBAAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x834C1C0", Offset = "0x834B1C0", VA = "0x18834C1C0")]
	public bool DNACLKFKBDN([Out] uint PBJHGGBBAAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x834C560", Offset = "0x834B560", VA = "0x18834C560")]
	public void OMDOMHDPMDI(string PBJHGGBBAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x834C450", Offset = "0x834B450", VA = "0x18834C450")]
	[CanBeNull]
	public string OJFAEOLDBLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x834C650", Offset = "0x834B650", VA = "0x18834C650")]
	public bool PJPGBOPDMJL([Out] string MHCHKMKKIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x834BFC0", Offset = "0x834AFC0", VA = "0x18834BFC0")]
	public void CKBLDCEABMH(string MHCHKMKKIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public FKBOEGEAPMM(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x834C2C0", Offset = "0x834B2C0", VA = "0x18834C2C0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(FKBOEGEAPMM EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct LLOLNNIDILF : IEquatable<LLOLNNIDILF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private KBGMLCPGKEG JHAMMGLNANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8352260", Offset = "0x8351260", VA = "0x188352260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private OKLMALKFJGP NDPDJFIOOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x83526F0", Offset = "0x83516F0", VA = "0x1883526F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public bool CLEPGBJABHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x83528F0", Offset = "0x83518F0", VA = "0x1883528F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool NJAKFNOMPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8351F10", Offset = "0x8350F10", VA = "0x188351F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool NBMIDMDBDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8351FF0", Offset = "0x8350FF0", VA = "0x188351FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Guid JNDDFLCNFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8352670", Offset = "0x8351670", VA = "0x188352670")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Guid FANKCKPNDHH
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8352870", Offset = "0x8351870", VA = "0x188352870")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Guid INMEEHALPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8352460", Offset = "0x8351460", VA = "0x188352460")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NAPFIGODKNN IPAAGBGNNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(NAPFIGODKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8351F50", Offset = "0x8350F50", VA = "0x188351F50")]
	public bool DHBCJINFJKK([Out] Guid GLBONDOGBDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x83523C0", Offset = "0x83513C0", VA = "0x1883523C0")]
	public bool IOMMPAILJMI([Out] Guid OMEKNOMEFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8352140", Offset = "0x8351140", VA = "0x188352140")]
	public void FNIAHFLAPOB(Guid GHNFCHHGJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x83522C0", Offset = "0x83512C0", VA = "0x1883522C0")]
	public void HJOLCKGJFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8352750", Offset = "0x8351750", VA = "0x188352750")]
	public Guid NAPEBOAOIII()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public LLOLNNIDILF(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x83520B0", Offset = "0x83510B0", VA = "0x1883520B0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(LLOLNNIDILF EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct OHIIGKFDNND : IEquatable<OHIIGKFDNND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private BNKIBCCPBDC BHGIDHCPKIL
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8357A00", Offset = "0x8356A00", VA = "0x188357A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Vector3 NIAMFFHDJPE
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8357F90", Offset = "0x8356F90", VA = "0x188357F90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Quaternion DKIKCFDNBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8357DC0", Offset = "0x8356DC0", VA = "0x188357DC0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public CJNFLLJGPFC KFGIBNDAKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8357F00", Offset = "0x8356F00", VA = "0x188357F00")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x8358180", Offset = "0x8357180", VA = "0x188358180")]
	public CMDLBMCKJFH NMNIOAJKNEG(Allocator FKPBEKMFPLB)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x83580E0", Offset = "0x83570E0", VA = "0x1883580E0")]
	public bool NIPEMGFDKDD(CJNFLLJGPFC EBJBKAEFOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x83578B0", Offset = "0x83568B0", VA = "0x1883578B0")]
	public void AJJACHEAPFN(Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x8357A60", Offset = "0x8356A60", VA = "0x188357A60")]
	public void EAACKEDALMG(float AJNABLFIHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x8357B70", Offset = "0x8356B70", VA = "0x188357B70")]
	public void EMIAEHCFFID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public OHIIGKFDNND(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x83439A0", Offset = "0x83429A0", VA = "0x1883439A0")]
	public static bool MJOOONLKLLN(OHIIGKFDNND IOALKPFEKEK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static GOLADBGGMAB MJOOONLKLLN(OHIIGKFDNND IOALKPFEKEK)
	{
		return default(GOLADBGGMAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x8357D30", Offset = "0x8356D30", VA = "0x188357D30", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(OHIIGKFDNND EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct AJMHKKHLCIF : IEquatable<AJMHKKHLCIF>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly AJMHKKHLCIF NKEMJGNDPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private ALDCMNCNIJH GMCOCPDLOPB
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x83454B0", Offset = "0x83444B0", VA = "0x1883454B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<CJNFLLJGPFC> JAKCMLAGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8345510", Offset = "0x8344510", VA = "0x188345510")]
		get
		{
			return default(Span<CJNFLLJGPFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8344EF0", Offset = "0x8343EF0", VA = "0x188344EF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8345610", Offset = "0x8344610", VA = "0x188345610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public PINGJEPFKOC DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(PINGJEPFKOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public NAPFIGODKNN IPAAGBGNNHH
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(NAPFIGODKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8344F80", Offset = "0x8343F80", VA = "0x188344F80")]
	public void BLACABDFHGO(AJMHKKHLCIF EDJHHGMLKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public AJMHKKHLCIF(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x83439A0", Offset = "0x83429A0", VA = "0x1883439A0")]
	public static bool MJOOONLKLLN(AJMHKKHLCIF IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8345420", Offset = "0x8344420", VA = "0x188345420", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(AJMHKKHLCIF EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static CJNFLLJGPFC MJOOONLKLLN(AJMHKKHLCIF OLHDOIOOPGE)
	{
		return default(CJNFLLJGPFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DefaultMember("Item")]
public struct PGJMEEHDJEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> JPAPECBEEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private KKPLCBIGLFN FONCFPDNHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool GCOHKCLGAHL;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		[CompilerGenerated]
		readonly get
		{
			return default(CJNFLLJGPFC);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public PGLHODPHMJI LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x835A7A0", Offset = "0x83597A0", VA = "0x18835A7A0")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x835A860", Offset = "0x8359860", VA = "0x18835A860")]
	internal PGJMEEHDJEL(CJNFLLJGPFC PGIOEBKALDP, bool GCOHKCLGAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x835A550", Offset = "0x8359550", VA = "0x18835A550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x3E38C00", Offset = "0x3E37C00", VA = "0x183E38C00")]
	public void JICPILHBOOB<T>(PGLHODPHMJI DAKIIEIEKNI, T IOALKPFEKEK, [Optional] T CAILINJCNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x835A6F0", Offset = "0x83596F0", VA = "0x18835A6F0")]
	public void LKIPLGLLFFP(PGLHODPHMJI DAKIIEIEKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0xAEAB70", Offset = "0xAE9B70", VA = "0x180AEAB70")]
	public Dictionary<int, object> NFOPFODHHPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x835A680", Offset = "0x8359680", VA = "0x18835A680")]
	private readonly void ICMIOFFKHDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class DENGOEBJAPJ
{
	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x834A8E0", Offset = "0x83498E0", VA = "0x18834A8E0")]
	public static PGJMEEHDJEL MFJDCIODMOH(this CJNFLLJGPFC PGIOEBKALDP)
	{
		return default(PGJMEEHDJEL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct OKEOPEJAAFF : IEquatable<OKEOPEJAAFF>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly OKEOPEJAAFF NKEMJGNDPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private bool HCECLNDBAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8359260", Offset = "0x8358260", VA = "0x188359260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 KOJLKJMHJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x83593A0", Offset = "0x83583A0", VA = "0x1883593A0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8359170", Offset = "0x8358170", VA = "0x188359170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x83592A0", Offset = "0x83582A0", VA = "0x1883592A0")]
	public Vector3 HNNAGNNFIEB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x8359320", Offset = "0x8358320", VA = "0x188359320")]
	public void KKCKMGAJMCL([In] Vector3 IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x8359450", Offset = "0x8358450", VA = "0x188359450")]
	public void OFLLAEHBMBG([In] Vector3 IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x83590C0", Offset = "0x83580C0", VA = "0x1883590C0")]
	public bool CEJBGOIECFI([In] Vector3 IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public OKEOPEJAAFF(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x83591D0", Offset = "0x83581D0", VA = "0x1883591D0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(OKEOPEJAAFF EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x83594D0", Offset = "0x83584D0", VA = "0x1883594D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct CBKPAIMEFGC : IEquatable<CBKPAIMEFGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8347110", Offset = "0x8346110", VA = "0x188347110", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(CBKPAIMEFGC EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct OJEDNNLAKPN : IEquatable<OJEDNNLAKPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private KFADKFHALNL LCODBHPBDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8358D80", Offset = "0x8357D80", VA = "0x188358D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool IJLNPJAEIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8358750", Offset = "0x8357750", VA = "0x188358750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool BHKNJLPOLIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8358B70", Offset = "0x8357B70", VA = "0x188358B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public HFEGPFPBOPD KOKKBCHFBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8358A30", Offset = "0x8357A30", VA = "0x188358A30")]
		get
		{
			return default(HFEGPFPBOPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool KIHJONLFABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8358CA0", Offset = "0x8357CA0", VA = "0x188358CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool MFJJEAMLDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x83589A0", Offset = "0x83579A0", VA = "0x1883589A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool KDMKBELBLBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8358880", Offset = "0x8357880", VA = "0x188358880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8358CE0", Offset = "0x8357CE0", VA = "0x188358CE0")]
	public bool NKGPAGJMCCE(OJEDNNLAKPN PENJMJDLOKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x83586B0", Offset = "0x83576B0", VA = "0x1883586B0")]
	public bool BPGHHHJCEHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8358610", Offset = "0x8357610", VA = "0x188358610")]
	public bool BIEDNBPAOAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x83584F0", Offset = "0x83574F0", VA = "0x1883584F0")]
	public ReadOnlySpan<GOLADBGGMAB> AGECHCEDHGD()
	{
		return default(ReadOnlySpan<GOLADBGGMAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public OJEDNNLAKPN(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x83464B0", Offset = "0x83454B0", VA = "0x1883464B0")]
	public static bool PHGIAKEDBEK(OJEDNNLAKPN JDINPJIAKOC, OJEDNNLAKPN LDPKBPICKKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x83434D0", Offset = "0x83424D0", VA = "0x1883434D0")]
	public static bool BDCEBPMLGHE(OJEDNNLAKPN JDINPJIAKOC, OJEDNNLAKPN LDPKBPICKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8358910", Offset = "0x8357910", VA = "0x188358910", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(OJEDNNLAKPN EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct GIFNDPKOGGC : IEquatable<GIFNDPKOGGC>
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly GIFNDPKOGGC NKEMJGNDPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private KFADKFHALNL FLPGCNAJDAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x834D680", Offset = "0x834C680", VA = "0x18834D680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool DJEMGKKCOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x834D780", Offset = "0x834C780", VA = "0x18834D780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public PINGJEPFKOC DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(PINGJEPFKOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x834D7E0", Offset = "0x834C7E0", VA = "0x18834D7E0")]
	public bool NKGPAGJMCCE(GIFNDPKOGGC EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x834D6E0", Offset = "0x834C6E0", VA = "0x18834D6E0")]
	public bool INDPGGNAAGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x834D510", Offset = "0x834C510", VA = "0x18834D510")]
	public bool BMKDJNIKLHJ([Out] GIFNDPKOGGC AMJGDEHFLHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x834D4A0", Offset = "0x834C4A0", VA = "0x18834D4A0")]
	public void AOHHHNLJJHJ(IGFHNJDCBEJ HOJOECLHBEJ, bool LEMOOBPFBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public GIFNDPKOGGC(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x83464B0", Offset = "0x83454B0", VA = "0x1883464B0")]
	public static bool PHGIAKEDBEK(GIFNDPKOGGC JDINPJIAKOC, GIFNDPKOGGC LDPKBPICKKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x83434D0", Offset = "0x83424D0", VA = "0x1883434D0")]
	public static bool BDCEBPMLGHE(GIFNDPKOGGC JDINPJIAKOC, GIFNDPKOGGC LDPKBPICKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x834D5F0", Offset = "0x834C5F0", VA = "0x18834D5F0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(GIFNDPKOGGC EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct NAPFIGODKNN : IEquatable<NAPFIGODKNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private ALDCMNCNIJH GMCOCPDLOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x83552E0", Offset = "0x83542E0", VA = "0x1883552E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public GOLADBGGMAB MCJNMOCCHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x83551C0", Offset = "0x83541C0", VA = "0x1883551C0")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public CJNFLLJGPFC GDFCPOBJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8355700", Offset = "0x8354700", VA = "0x188355700")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public CJNFLLJGPFC AOHAMHAHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8355670", Offset = "0x8354670", VA = "0x188355670")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8355570", Offset = "0x8354570", VA = "0x188355570")]
	public Span<CJNFLLJGPFC> LAGNMCNBHGF()
	{
		return default(Span<CJNFLLJGPFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8355470", Offset = "0x8354470", VA = "0x188355470")]
	public Span<CJNFLLJGPFC> JJLHOMKHAKN()
	{
		return default(Span<CJNFLLJGPFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x8354FB0", Offset = "0x8353FB0", VA = "0x188354FB0")]
	public Span<CJNFLLJGPFC> BICPLNNIAGG()
	{
		return default(Span<CJNFLLJGPFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x8354EB0", Offset = "0x8353EB0", VA = "0x188354EB0")]
	public Span<CJNFLLJGPFC> BEDMOJKMOHA()
	{
		return default(Span<CJNFLLJGPFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x8354D80", Offset = "0x8353D80", VA = "0x188354D80")]
	public bool AKCKLCNBHIA(CJNFLLJGPFC EBJBKAEFOPM, bool DFMMLCPAMHC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x83553D0", Offset = "0x83543D0", VA = "0x1883553D0")]
	public bool IDADBMDGAMG(CJNFLLJGPFC JBAIOIPGKBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x83550B0", Offset = "0x83540B0", VA = "0x1883550B0")]
	public CJNFLLJGPFC DMGMBJPIKOI(uint CIMNMIABLEL)
	{
		return default(CJNFLLJGPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x8355340", Offset = "0x8354340", VA = "0x188355340")]
	public AJMHKKHLCIF HNOBDDGOJNO()
	{
		return default(AJMHKKHLCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public NAPFIGODKNN(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x83439A0", Offset = "0x83429A0", VA = "0x1883439A0")]
	public static bool MJOOONLKLLN(NAPFIGODKNN IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x8355250", Offset = "0x8354250", VA = "0x188355250", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(NAPFIGODKNN EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct EBAOFBFMJMG : IEquatable<EBAOFBFMJMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public string MDMHNCCIHNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x834B0B0", Offset = "0x834A0B0", VA = "0x18834B0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public string CHNMHGLDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x834B470", Offset = "0x834A470", VA = "0x18834B470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string INDFAPDKMKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x834B4E0", Offset = "0x834A4E0", VA = "0x18834B4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public string IABHJCDAADC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x834B1D0", Offset = "0x834A1D0", VA = "0x18834B1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x834B590", Offset = "0x834A590", VA = "0x18834B590")]
	public bool PJPGBOPDMJL([Out] string MHCHKMKKIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public EBAOFBFMJMG(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x834B140", Offset = "0x834A140", VA = "0x18834B140", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(EBAOFBFMJMG EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct BJMJIPJNIAN : IEquatable<BJMJIPJNIAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8346700", Offset = "0x8345700", VA = "0x188346700", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(BJMJIPJNIAN EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct LHLENLHPCPO : IEquatable<LHLENLHPCPO>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[Flags]
	public enum IPLIBLIJDPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		SUCCESS = 0,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		ANCHOR_A_INVALID = 1,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		ANCHOR_B_INVALID = 2,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		ANCHOR_A_ALREADY_CONNECTED = 4,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		ANCHOR_B_ALREADY_CONNECTED = 8
	}

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly LHLENLHPCPO NKEMJGNDPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private MLBLOFEMENF COOMBFPNNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8348690", Offset = "0x8347690", VA = "0x188348690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x83516C0", Offset = "0x83506C0", VA = "0x1883516C0")]
	public static IPLIBLIJDPM KPGGHLKDNII(LHLENLHPCPO JDINPJIAKOC, LHLENLHPCPO LDPKBPICKKH)
	{
		return default(IPLIBLIJDPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x83518E0", Offset = "0x83508E0", VA = "0x1883518E0")]
	public bool OCAKLGPJJEL([Out] GameObject EBJBKAEFOPM, [Out] GameObject GLGAAAMILBJ, [Out] CJNFLLJGPFC JHMDDONIFJK, [Out] CJNFLLJGPFC EGBGFKDLKIN, [Out] Vector3 EBGKGBGFPOC, [Out] Vector3 IKJFFDMEENL, [Out] Vector3 PABLONCBPJK, [Out] CJNFLLJGPFC CGEHPBBNKMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8351060", Offset = "0x8350060", VA = "0x188351060")]
	public bool EGHFKALCOPL([Out] GameObject EBJBKAEFOPM, [Out] GameObject GLGAAAMILBJ, [Out] CJNFLLJGPFC JHMDDONIFJK, [Out] CJNFLLJGPFC EGBGFKDLKIN, [Out] Vector3 EBGKGBGFPOC, [Out] Vector3 IKJFFDMEENL, [Out] Vector3 PABLONCBPJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x8351300", Offset = "0x8350300", VA = "0x188351300")]
	private void HODICKGAGOL(Entity KELHIEHPDJD, EntityManager KPIIAOCGDOL, MagneticAnchorData MDDAFEOCBGL, [Out] GameObject EBJBKAEFOPM, [Out] GameObject GLGAAAMILBJ, [Out] CJNFLLJGPFC JHMDDONIFJK, [Out] CJNFLLJGPFC EGBGFKDLKIN, [Out] Vector3 EBGKGBGFPOC, [Out] Vector3 IKJFFDMEENL, [Out] Vector3 PABLONCBPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public LHLENLHPCPO(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8351270", Offset = "0x8350270", VA = "0x188351270", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(LHLENLHPCPO EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8351E10", Offset = "0x8350E10", VA = "0x188351E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct GJHJNOGGFGA : IEquatable<GJHJNOGGFGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x834D880", Offset = "0x834C880", VA = "0x18834D880", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(GJHJNOGGFGA EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct OFHPLFDMCLD : IEquatable<OFHPLFDMCLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private BNJLPOMMMFC FLPGCNAJDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x83575C0", Offset = "0x83565C0", VA = "0x1883575C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public OHACPJDAJBK JPMAINONMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x83574F0", Offset = "0x83564F0", VA = "0x1883574F0")]
		get
		{
			return default(OHACPJDAJBK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8357620", Offset = "0x8356620", VA = "0x188357620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public FHHKDIEHOCM<string> AEAMALLIIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x83573D0", Offset = "0x83563D0", VA = "0x1883573D0")]
		get
		{
			return default(FHHKDIEHOCM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x83572B0", Offset = "0x83562B0", VA = "0x1883572B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public FHHKDIEHOCM<string> LOBCHHCGEKN
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8357790", Offset = "0x8356790", VA = "0x188357790")]
		get
		{
			return default(FHHKDIEHOCM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8357670", Offset = "0x8356670", VA = "0x188357670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public OFHPLFDMCLD(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x8357530", Offset = "0x8356530", VA = "0x188357530", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(OFHPLFDMCLD EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct MOOFIFIGCAK : IEquatable<MOOFIFIGCAK>
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly ComponentTypes NIPPMANFEIM;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly MOOFIFIGCAK NKEMJGNDPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Collider PLFBGFKEAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x83542E0", Offset = "0x83532E0", VA = "0x1883542E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public PMKMCFAPLLD INMLOCFBDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8354640", Offset = "0x8353640", VA = "0x188354640")]
		get
		{
			return default(PMKMCFAPLLD);
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x83546F0", Offset = "0x83536F0", VA = "0x1883546F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public CGEOBJLILFH JKGCEMJECIG
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8354A60", Offset = "0x8353A60", VA = "0x188354A60")]
		get
		{
			return default(CGEOBJLILFH);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x83547C0", Offset = "0x83537C0", VA = "0x1883547C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public MKBPCMFBOGI BBGGBPGEDON
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8354810", Offset = "0x8353810", VA = "0x188354810")]
		get
		{
			return default(MKBPCMFBOGI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8353CF0", Offset = "0x8352CF0", VA = "0x188353CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public float IIGJKFDIJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8354B20", Offset = "0x8353B20", VA = "0x188354B20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8354290", Offset = "0x8353290", VA = "0x188354290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool ILBDBOGGALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8354680", Offset = "0x8353680", VA = "0x188354680")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8354430", Offset = "0x8353430", VA = "0x188354430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool FJKHLCFHAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8353F20", Offset = "0x8352F20", VA = "0x188353F20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8353C50", Offset = "0x8352C50", VA = "0x188353C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool EBOGMCBFEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8354AA0", Offset = "0x8353AA0", VA = "0x188354AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8354850", Offset = "0x8353850", VA = "0x188354850")]
	public static bool OLFHHLHBDEI(CJNFLLJGPFC GBAOGPOCBIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x8354040", Offset = "0x8353040", VA = "0x188354040")]
	public static bool HOOMFBIAHPE(CJNFLLJGPFC GBAOGPOCBIJ, [Out] MOOFIFIGCAK FKMFDCLJPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x83544D0", Offset = "0x83534D0", VA = "0x1883544D0")]
	public bool JODEIPBDHKO([Out] DEFFNBOFLAG EPMKKDPDDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8353D40", Offset = "0x8352D40", VA = "0x188353D40")]
	public bool DOIICGOOMKI([Out] GOLADBGGMAB NKBKNNLLHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8353E30", Offset = "0x8352E30", VA = "0x188353E30")]
	public bool EEBEPHIHAIL(MOLPEGLCKDH HOJOECLHBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8354740", Offset = "0x8353740", VA = "0x188354740")]
	public void NFDHHDAHIPG(MOLPEGLCKDH HOJOECLHBEJ, bool DAKNLGLKCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8353FA0", Offset = "0x8352FA0", VA = "0x188353FA0")]
	public void HGKIGCPBBAE(MOLPEGLCKDH HOJOECLHBEJ, bool DAKNLGLKCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public MOOFIFIGCAK(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8353E90", Offset = "0x8352E90", VA = "0x188353E90", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(MOOFIFIGCAK EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8354B60", Offset = "0x8353B60", VA = "0x188354B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct KJCPAGPLMIL : IEquatable<KJCPAGPLMIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool KMGJHNHOIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8350CA0", Offset = "0x834FCA0", VA = "0x188350CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public KJCPAGPLMIL(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x8350CF0", Offset = "0x834FCF0", VA = "0x188350CF0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(KJCPAGPLMIL EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct MJJIIHECNBN : IEquatable<MJJIIHECNBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	private KEKEOBFOFFF MFICJFNJIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8353880", Offset = "0x8352880", VA = "0x188353880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x83538E0", Offset = "0x83528E0", VA = "0x1883538E0")]
	public void PNFHEGDOLJJ(bool GLANDDNNPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public MJJIIHECNBN(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x83537F0", Offset = "0x83527F0", VA = "0x1883537F0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(MJJIIHECNBN EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct CIFFABOAGKM : IEquatable<CIFFABOAGKM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private MIIIGKJCFDN KCDAOEDOCAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8347A10", Offset = "0x8346A10", VA = "0x188347A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public OHACPJDAJBK KAKBKIDJFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8347D50", Offset = "0x8346D50", VA = "0x188347D50")]
		get
		{
			return default(OHACPJDAJBK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x83477E0", Offset = "0x83467E0", VA = "0x1883477E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool KNAIEGELOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8347750", Offset = "0x8346750", VA = "0x188347750")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8347B90", Offset = "0x8346B90", VA = "0x188347B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public FHHKDIEHOCM<string> DCEAPKMMMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8347C30", Offset = "0x8346C30", VA = "0x188347C30")]
		get
		{
			return default(FHHKDIEHOCM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8347360", Offset = "0x8346360", VA = "0x188347360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public FHHKDIEHOCM<string> KKMMICKHPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8347E50", Offset = "0x8346E50", VA = "0x188347E50")]
		get
		{
			return default(FHHKDIEHOCM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x83471A0", Offset = "0x83461A0", VA = "0x1883471A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public FHHKDIEHOCM<string> JDFEBFAIIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x8347A70", Offset = "0x8346A70", VA = "0x188347A70")]
		get
		{
			return default(FHHKDIEHOCM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8347480", Offset = "0x8346480", VA = "0x188347480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public FHHKDIEHOCM<string> CLBAEFCFNBH
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8347630", Offset = "0x8346630", VA = "0x188347630")]
		get
		{
			return default(FHHKDIEHOCM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x83478F0", Offset = "0x83468F0", VA = "0x1883478F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x83472C0", Offset = "0x83462C0", VA = "0x1883472C0")]
	public bool DBPMFEDBOAI(GOLADBGGMAB MFOAOKBDIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public CIFFABOAGKM(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static GOLADBGGMAB MJOOONLKLLN(CIFFABOAGKM IOALKPFEKEK)
	{
		return default(GOLADBGGMAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x83475A0", Offset = "0x83465A0", VA = "0x1883475A0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(CIFFABOAGKM EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct NMFABAPCAFJ : IEquatable<NMFABAPCAFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool CKMEDFCLGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8356D20", Offset = "0x8355D20", VA = "0x188356D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool GHILNCICCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x83569F0", Offset = "0x83559F0", VA = "0x1883569F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool DGOHAHDDNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x8357210", Offset = "0x8356210", VA = "0x188357210")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8357040", Offset = "0x8356040", VA = "0x188357040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool DNGPGGGBLFB
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8356B60", Offset = "0x8355B60", VA = "0x188356B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool HFIPGKDJEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8357120", Offset = "0x8356120", VA = "0x188357120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool MEPDBKNFKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8356590", Offset = "0x8355590", VA = "0x188356590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool JIBFIHGOFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8356920", Offset = "0x8355920", VA = "0x188356920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool NKHEBAHMHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x8356770", Offset = "0x8355770", VA = "0x188356770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool JMKKLLAKCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x83571C0", Offset = "0x83561C0", VA = "0x1883571C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool HEDKHLFDPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8356840", Offset = "0x8355840", VA = "0x188356840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool CBDDAJKKOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x83565E0", Offset = "0x83555E0", VA = "0x1883565E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool GPBOOLENJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8356A40", Offset = "0x8355A40", VA = "0x188356A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool JDLLHHKAHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8356720", Offset = "0x8355720", VA = "0x188356720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool KJLELLAHLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x8356800", Offset = "0x8355800", VA = "0x188356800")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x83570C0", Offset = "0x83560C0", VA = "0x1883570C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool IJJDCOPHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8357170", Offset = "0x8356170", VA = "0x188357170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public NFNHBFLIKDN AMADOHAAHPN
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8356A90", Offset = "0x8355A90", VA = "0x188356A90")]
		get
		{
			return default(NFNHBFLIKDN);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8356500", Offset = "0x8355500", VA = "0x188356500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public bool NGAAILHFAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8356C00", Offset = "0x8355C00", VA = "0x188356C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public HPIHHCJGCCG EDAJNLHFPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8356550", Offset = "0x8355550", VA = "0x188356550")]
		get
		{
			return default(HPIHHCJGCCG);
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8356D60", Offset = "0x8355D60", VA = "0x188356D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public bool KDKKNGAFAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8356F80", Offset = "0x8355F80", VA = "0x188356F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public Vector3 IJPINPMMJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8356AD0", Offset = "0x8355AD0", VA = "0x188356AD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public Vector3 GNFNNCCDIBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x8356FC0", Offset = "0x8355FC0", VA = "0x188356FC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public bool DHKPDELEAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8356DB0", Offset = "0x8355DB0", VA = "0x188356DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public bool KNEHKMNENNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8356630", Offset = "0x8355630", VA = "0x188356630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	private EntityManager GLANLJGHLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8356B50", Offset = "0x8355B50", VA = "0x188356B50")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8357060", Offset = "0x8356060", VA = "0x188357060")]
	public bool MLCFLDOKJBH(HOGLBHDBIPF HOJOECLHBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x8356470", Offset = "0x8355470", VA = "0x188356470")]
	public void ABBICIONPMG(HOGLBHDBIPF HOJOECLHBEJ, bool DAKNLGLKCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x8356BB0", Offset = "0x8355BB0", VA = "0x188356BB0")]
	public bool KHFCEAFEBMA(NOMBAAECKJJ HOJOECLHBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x8356970", Offset = "0x8355970", VA = "0x188356970")]
	public void FJIMKEALEOG(NOMBAAECKJJ HOJOECLHBEJ, bool DAKNLGLKCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x83567C0", Offset = "0x83557C0", VA = "0x1883567C0")]
	public NOMBAAECKJJ ENKAFDHJDBA()
	{
		return default(NOMBAAECKJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x8357260", Offset = "0x8356260", VA = "0x188357260")]
	public bool PHLHMFGKJFM(NOMBAAECKJJ IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public NMFABAPCAFJ(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x8356890", Offset = "0x8355890", VA = "0x188356890", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(NMFABAPCAFJ EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct DAKHKHGFNBA : IEquatable<DAKHKHGFNBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	private EPDIJBLMGLH OENAIAHEOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x834A880", Offset = "0x8349880", VA = "0x18834A880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x834A190", Offset = "0x8349190", VA = "0x18834A190")]
	public bool DPAGDFLAPIB(EJKKDGPBELM CBONFFLHKGG, List<CJNFLLJGPFC> MHPOCKAHOPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x8349D90", Offset = "0x8348D90", VA = "0x188349D90")]
	public int BEPMHBAOPCB(EJKKDGPBELM CBONFFLHKGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x834A770", Offset = "0x8349770", VA = "0x18834A770")]
	public void LAFPHEJBJPG(List<CJNFLLJGPFC> MHPOCKAHOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x834A2C0", Offset = "0x83492C0", VA = "0x18834A2C0")]
	public int EEGEMFPJFIH(CJNFLLJGPFC AOJAHPGAGPO, EJKKDGPBELM CBONFFLHKGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x834A530", Offset = "0x8349530", VA = "0x18834A530")]
	public CJNFLLJGPFC HFBDPHMMFBN(int HLGKMAPOEBE, EJKKDGPBELM CBONFFLHKGG)
	{
		return default(CJNFLLJGPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x834A060", Offset = "0x8349060", VA = "0x18834A060")]
	public void DKAJDDNGPIL(CJNFLLJGPFC AOJAHPGAGPO, EJKKDGPBELM CBONFFLHKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x8349FB0", Offset = "0x8348FB0", VA = "0x188349FB0")]
	public bool CADIPHHMFKH(CJNFLLJGPFC AOJAHPGAGPO, EJKKDGPBELM CBONFFLHKGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x8349EA0", Offset = "0x8348EA0", VA = "0x188349EA0")]
	public void BOFFGAPBBCN(EJKKDGPBELM CBONFFLHKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x834A480", Offset = "0x8349480", VA = "0x18834A480")]
	public bool FJPOHFIMOGN(CJNFLLJGPFC AOJAHPGAGPO, EJKKDGPBELM CBONFFLHKGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x834A660", Offset = "0x8349660", VA = "0x18834A660")]
	public bool KOHDKHFOBEM(EJKKDGPBELM CBONFFLHKGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public DAKHKHGFNBA(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x834A3F0", Offset = "0x83493F0", VA = "0x18834A3F0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(DAKHKHGFNBA EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct AMGKEEKAKDM : IEquatable<AMGKEEKAKDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x8345690", Offset = "0x8344690", VA = "0x188345690")]
	public void BFBCJLDPFKH(bool IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x83457B0", Offset = "0x83447B0", VA = "0x1883457B0")]
	public void FEGJBGOLPBL(bool IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x31ABA50", Offset = "0x31AAA50", VA = "0x1831ABA50")]
	public T CPFKMADIDBM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public AMGKEEKAKDM(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x8345720", Offset = "0x8344720", VA = "0x188345720", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(AMGKEEKAKDM EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct FPMLPDAOCGO : IEquatable<FPMLPDAOCGO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public bool LJOHOPCAPLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x834C850", Offset = "0x834B850", VA = "0x18834C850")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x834CA30", Offset = "0x834BA30", VA = "0x18834CA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool KGOOFDOKHEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x834C890", Offset = "0x834B890", VA = "0x18834C890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public int PGGDPDBEMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x834CA80", Offset = "0x834BA80", VA = "0x18834CA80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x834C910", Offset = "0x834B910", VA = "0x18834C910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public FPMLPDAOCGO(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x834C9A0", Offset = "0x834B9A0", VA = "0x18834C9A0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(FPMLPDAOCGO EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct MOJOGEGEGIA : IEquatable<MOJOGEGEGIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public int CILONOGMHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8353A10", Offset = "0x8352A10", VA = "0x188353A10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8353B80", Offset = "0x8352B80", VA = "0x188353B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public int LKCKDJMNMFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8353C10", Offset = "0x8352C10", VA = "0x188353C10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8353B30", Offset = "0x8352B30", VA = "0x188353B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public uint CJPJHKEAHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8353BD0", Offset = "0x8352BD0", VA = "0x188353BD0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x8353A50", Offset = "0x8352A50", VA = "0x188353A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public MOJOGEGEGIA(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x8353AA0", Offset = "0x8352AA0", VA = "0x188353AA0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(MOJOGEGEGIA EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct PCDNPCOAGBO : IEquatable<PCDNPCOAGBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	private MIKJANMMKCG NHIMAMFCMOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8359D10", Offset = "0x8358D10", VA = "0x188359D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	private NDFODAJELCD FENJPFMFKDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x835A190", Offset = "0x8359190", VA = "0x18835A190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public bool NKMDKOKJJED
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x835A360", Offset = "0x8359360", VA = "0x18835A360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public bool LCFIPNPLGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x835A2C0", Offset = "0x83592C0", VA = "0x18835A2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public bool MCFDIJKFINO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x835A3F0", Offset = "0x83593F0", VA = "0x18835A3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public bool OCFIJPHCPKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x835A1F0", Offset = "0x83591F0", VA = "0x18835A1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool KGHCEMBPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x83599D0", Offset = "0x83589D0", VA = "0x1883599D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool JHOHLJLCJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8359940", Offset = "0x8358940", VA = "0x188359940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public bool DPMFDOJOBDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8359F40", Offset = "0x8358F40", VA = "0x188359F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public bool NLBKINPNOEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8359B10", Offset = "0x8358B10", VA = "0x188359B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool CPHNIEJLBDF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8359E10", Offset = "0x8358E10", VA = "0x188359E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x835A420", Offset = "0x8359420", VA = "0x18835A420")]
	public bool PGPMNNDOJJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x8359D70", Offset = "0x8358D70", VA = "0x188359D70")]
	public CJNFLLJGPFC IFPCIAKAGGH(CJNFLLJGPFC AOJAHPGAGPO)
	{
		return default(CJNFLLJGPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x8359A00", Offset = "0x8358A00", VA = "0x188359A00")]
	public GOLADBGGMAB CHDDOIOLPJM()
	{
		return default(GOLADBGGMAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x835A0E0", Offset = "0x83590E0", VA = "0x18835A0E0")]
	public bool IOLDKEODCAN(GOLADBGGMAB AOJAHPGAGPO, [Out] GOLADBGGMAB EAMGLLPPJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public PCDNPCOAGBO(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x83439A0", Offset = "0x83429A0", VA = "0x1883439A0")]
	public static bool MJOOONLKLLN(PCDNPCOAGBO IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x8359C80", Offset = "0x8358C80", VA = "0x188359C80", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(PCDNPCOAGBO EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct ACHOHANJLJJ : IEquatable<ACHOHANJLJJ>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly ACHOHANJLJJ NKEMJGNDPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public PFODFFJDGFP MKLPPCHKFJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8343490", Offset = "0x8342490", VA = "0x188343490")]
		get
		{
			return default(PFODFFJDGFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public DGOEMBOEDNM CHNEPDKGONI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x8343AA0", Offset = "0x8342AA0", VA = "0x188343AA0")]
		get
		{
			return default(DGOEMBOEDNM);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x8343770", Offset = "0x8342770", VA = "0x188343770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public PAAELMLIHIG AGLIMLFKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x83434F0", Offset = "0x83424F0", VA = "0x1883434F0")]
		get
		{
			return default(PAAELMLIHIG);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x83436F0", Offset = "0x83426F0", VA = "0x1883436F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public float PNBMPDFBCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x8343530", Offset = "0x8342530", VA = "0x188343530")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x8343B30", Offset = "0x8342B30", VA = "0x188343B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public Vector3 HBOGCJMOMIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x83438A0", Offset = "0x83428A0", VA = "0x1883438A0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x8343A20", Offset = "0x8342A20", VA = "0x188343A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public float MAACNIHPMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x83437C0", Offset = "0x83427C0", VA = "0x1883437C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public DDFFFHLEFPB JICIOLPIPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x8343860", Offset = "0x8342860", VA = "0x188343860")]
		get
		{
			return default(DDFFFHLEFPB);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x8343810", Offset = "0x8342810", VA = "0x188343810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public bool KAELNHDLOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x8343660", Offset = "0x8342660", VA = "0x188343660")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x83439C0", Offset = "0x83429C0", VA = "0x1883439C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public PINGJEPFKOC DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(PINGJEPFKOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public NAPFIGODKNN IPAAGBGNNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(NAPFIGODKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8343AE0", Offset = "0x8342AE0", VA = "0x188343AE0")]
	public GODLBLNHOPC PLPNLIPMELA()
	{
		return default(GODLBLNHOPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x83436A0", Offset = "0x83426A0", VA = "0x1883436A0")]
	public BCMIKBHBKJF GJKCDDGMCPI()
	{
		return default(BCMIKBHBKJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8343610", Offset = "0x8342610", VA = "0x188343610")]
	private bool FFNLNBDDHDK(DDFFFHLEFPB HOJOECLHBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x8343920", Offset = "0x8342920", VA = "0x188343920")]
	public void MJIIDJACMMO(DDFFFHLEFPB HOJOECLHBEJ, bool DAKNLGLKCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public ACHOHANJLJJ(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x83439A0", Offset = "0x83429A0", VA = "0x1883439A0")]
	public static bool MJOOONLKLLN(ACHOHANJLJJ IOALKPFEKEK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x83434D0", Offset = "0x83424D0", VA = "0x1883434D0")]
	public static bool BDCEBPMLGHE(ACHOHANJLJJ JDINPJIAKOC, ACHOHANJLJJ LDPKBPICKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x8343580", Offset = "0x8342580", VA = "0x188343580", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(ACHOHANJLJJ EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct GODLBLNHOPC : IEquatable<GODLBLNHOPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public ACHOHANJLJJ CIHOJNBNFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(ACHOHANJLJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public GOAIGCDFKPE BJGONHHMLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x834DA40", Offset = "0x834CA40", VA = "0x18834DA40")]
		get
		{
			return default(GOAIGCDFKPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public GODLBLNHOPC(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x83439A0", Offset = "0x83429A0", VA = "0x1883439A0")]
	public static bool MJOOONLKLLN(GODLBLNHOPC IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x834D9B0", Offset = "0x834C9B0", VA = "0x18834D9B0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(GODLBLNHOPC EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DefaultMember("Item")]
public readonly struct BCMIKBHBKJF : IEquatable<BCMIKBHBKJF>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly BCMIKBHBKJF NKEMJGNDPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	private CEAHOBBINHN CGPMEGIGKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x83458E0", Offset = "0x83448E0", VA = "0x1883458E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public ACHOHANJLJJ CIHOJNBNFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(ACHOHANJLJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public NIPIDDDBDNP NOBEGMEKABD
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x8345F20", Offset = "0x8344F20", VA = "0x188345F20")]
		get
		{
			return default(NIPIDDDBDNP);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x8346050", Offset = "0x8345050", VA = "0x188346050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public IEnumerable<AIMFNKAJFPO> IBONIEKKHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x8345940", Offset = "0x8344940", VA = "0x188345940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public AIMFNKAJFPO LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x8345B50", Offset = "0x8344B50", VA = "0x188345B50")]
		get
		{
			return default(AIMFNKAJFPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8346420", Offset = "0x8345420", VA = "0x188346420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public PINGJEPFKOC DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(PINGJEPFKOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x8346200", Offset = "0x8345200", VA = "0x188346200")]
	public AIMFNKAJFPO KFJPMHBMPGL(float3? EBGKGBGFPOC, [Optional] quaternion? KDHLIJMPIFF, [Optional] Vector3? AJNABLFIHCD)
	{
		return default(AIMFNKAJFPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x8345CF0", Offset = "0x8344CF0", VA = "0x188345CF0")]
	public AIMFNKAJFPO FONPHIPLFMK(int HLGKMAPOEBE, float3? EBGKGBGFPOC, [Optional] quaternion? KDHLIJMPIFF, [Optional] Vector3? AJNABLFIHCD)
	{
		return default(AIMFNKAJFPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x8345840", Offset = "0x8344840", VA = "0x188345840")]
	public void CKPCCNNFBHK(int HLGKMAPOEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x8346170", Offset = "0x8345170", VA = "0x188346170")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public BCMIKBHBKJF(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x83439A0", Offset = "0x83429A0", VA = "0x1883439A0")]
	public static bool MJOOONLKLLN(BCMIKBHBKJF IOALKPFEKEK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x83464B0", Offset = "0x83454B0", VA = "0x1883464B0")]
	public static bool PHGIAKEDBEK(BCMIKBHBKJF JDINPJIAKOC, BCMIKBHBKJF LDPKBPICKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x8345C60", Offset = "0x8344C60", VA = "0x188345C60", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(BCMIKBHBKJF EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct AIMFNKAJFPO : IEquatable<AIMFNKAJFPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public BCMIKBHBKJF FFGPOMMCPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x8344DB0", Offset = "0x8343DB0", VA = "0x188344DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public float3 KCFBPENHPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x8344B60", Offset = "0x8343B60", VA = "0x188344B60")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8344E30", Offset = "0x8343E30", VA = "0x188344E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public quaternion JEKEGKDFCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x8344D60", Offset = "0x8343D60", VA = "0x188344D60")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x8344D10", Offset = "0x8343D10", VA = "0x188344D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public float3 DIIAFCFIKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x8344C50", Offset = "0x8343C50", VA = "0x188344C50")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x8344E90", Offset = "0x8343E90", VA = "0x188344E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public MBPKFOHGPLA DOPDPENGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x8344CC0", Offset = "0x8343CC0", VA = "0x188344CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x8344CB0", Offset = "0x8343CB0", VA = "0x188344CB0")]
	public void IJCIHMIHMJP(BCMIKBHBKJF IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public AIMFNKAJFPO(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x8344BC0", Offset = "0x8343BC0", VA = "0x188344BC0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(AIMFNKAJFPO EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct NFPCPAGOMBF : IEquatable<NFPCPAGOMBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public bool JLHPGDNIOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x8355820", Offset = "0x8354820", VA = "0x188355820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public NFPCPAGOMBF(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x8355790", Offset = "0x8354790", VA = "0x188355790", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(NFPCPAGOMBF EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct JHFPLKOAGAM : IEquatable<JHFPLKOAGAM>
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public static readonly JHFPLKOAGAM NKEMJGNDPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	private KCBEMDIBPFN PBCNJPPNBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x83503C0", Offset = "0x834F3C0", VA = "0x1883503C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public uint OCIOEONGJMO
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x834FE60", Offset = "0x834EE60", VA = "0x18834FE60")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x834FD40", Offset = "0x834ED40", VA = "0x18834FD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public HCAHFNLAHJG GGBCNDBLNIG
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x834FE20", Offset = "0x834EE20", VA = "0x18834FE20")]
		get
		{
			return default(HCAHFNLAHJG);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x8350370", Offset = "0x834F370", VA = "0x188350370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public float NKNAGHNMJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x834FCB0", Offset = "0x834ECB0", VA = "0x18834FCB0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x834FEA0", Offset = "0x834EEA0", VA = "0x18834FEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public float LNGPDFAHKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x8350190", Offset = "0x834F190", VA = "0x188350190")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x834FCF0", Offset = "0x834ECF0", VA = "0x18834FCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public KIJGMKDAKDJ CNDOBJLDDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8350330", Offset = "0x834F330", VA = "0x188350330")]
		get
		{
			return default(KIJGMKDAKDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x83502E0", Offset = "0x834F2E0", VA = "0x1883502E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public ReadOnlySpan<TerrainGenerationLayer> BNLGPACECLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x834FEF0", Offset = "0x834EEF0", VA = "0x18834FEF0")]
		get
		{
			return default(ReadOnlySpan<TerrainGenerationLayer>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x83501D0", Offset = "0x834F1D0", VA = "0x1883501D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public ReadOnlySpan<PJCPLMKFBGA> CEFBAKKMKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x83500D0", Offset = "0x834F0D0", VA = "0x1883500D0")]
		get
		{
			return default(ReadOnlySpan<PJCPLMKFBGA>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x834FFB0", Offset = "0x834EFB0", VA = "0x18834FFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public JHFPLKOAGAM(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static GOLADBGGMAB MJOOONLKLLN(JHFPLKOAGAM IOALKPFEKEK)
	{
		return default(GOLADBGGMAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x834FD90", Offset = "0x834ED90", VA = "0x18834FD90", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(JHFPLKOAGAM EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct NKGJACDBEIO : IEquatable<NKGJACDBEIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	private IILECJGHNJE MCJKBGFJFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x83560F0", Offset = "0x83550F0", VA = "0x1883560F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public bool OHOJBEJFDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x8356240", Offset = "0x8355240", VA = "0x188356240")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x83562E0", Offset = "0x83552E0", VA = "0x1883562E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public bool EGBEECENFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x8355B40", Offset = "0x8354B40", VA = "0x188355B40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x8356410", Offset = "0x8355410", VA = "0x188356410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public float OIADPLABJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x8356340", Offset = "0x8355340", VA = "0x188356340")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x83559C0", Offset = "0x83549C0", VA = "0x1883559C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public bool DFMEOCBLFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x83561F0", Offset = "0x83551F0", VA = "0x1883561F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x8356150", Offset = "0x8355150", VA = "0x188356150")]
	public void IONGNMFCFJK(int FICFFHNKAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x8355CE0", Offset = "0x8354CE0", VA = "0x188355CE0")]
	public bool EKCEBPPMIDF([Out] int FICFFHNKAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x8355FD0", Offset = "0x8354FD0", VA = "0x188355FD0")]
	public void GMOHENLDPKN(bool OFHMBLCHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x8356290", Offset = "0x8355290", VA = "0x188356290")]
	public bool MFBHLIEMNML(CDECJLEKPFN HOJOECLHBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x8356070", Offset = "0x8355070", VA = "0x188356070")]
	public void HBLKNKJODMD(CDECJLEKPFN HOJOECLHBEJ, bool DAKNLGLKCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x8355B90", Offset = "0x8354B90", VA = "0x188355B90")]
	public void EJLBIJLDNAH(float GNGMNGGDALM, float CLCEDBMFEPH, float DBNCGNLMDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x8355DF0", Offset = "0x8354DF0", VA = "0x188355DF0")]
	public void ENAEDMEHOKM(float3 HLNPGADFHNM, quaternion DICNLOLJDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x8355A10", Offset = "0x8354A10", VA = "0x188355A10")]
	public bool DAENKPBJFCA([Out] float3 HLNPGADFHNM, [Out] quaternion DICNLOLJDFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x8355890", Offset = "0x8354890", VA = "0x188355890")]
	public bool ACOMDGGLANI([Out] float KAEFEOBOGNF, [Out] float EKIOLKCFDHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x8356380", Offset = "0x8355380", VA = "0x188356380")]
	public void NBIHBFBPHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public NKGJACDBEIO(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x8355F40", Offset = "0x8354F40", VA = "0x188355F40", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(NKGJACDBEIO EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct PINGJEPFKOC : IEquatable<PINGJEPFKOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	private CPPFMOPAJKK LNKLHDGNMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x835B2E0", Offset = "0x835A2E0", VA = "0x18835B2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public Vector3 KCFBPENHPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x835AB50", Offset = "0x8359B50", VA = "0x18835AB50")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x835C580", Offset = "0x835B580", VA = "0x18835C580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public Quaternion JEKEGKDFCIB
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x835BDD0", Offset = "0x835ADD0", VA = "0x18835BDD0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x835B9A0", Offset = "0x835A9A0", VA = "0x18835B9A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public Vector3 EFJMBKOHGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x835AC40", Offset = "0x8359C40", VA = "0x18835AC40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x835B610", Offset = "0x835A610", VA = "0x18835B610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public Quaternion NAIEIHHDDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x835BC00", Offset = "0x835AC00", VA = "0x18835BC00")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x835BF10", Offset = "0x835AF10", VA = "0x18835BF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public float JHLOPGGKKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x835AF90", Offset = "0x8359F90", VA = "0x18835AF90")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x835AA00", Offset = "0x8359A00", VA = "0x18835AA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public float GNGHPELMGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x835AAB0", Offset = "0x8359AB0", VA = "0x18835AAB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public Matrix4x4 LLPAMIPJKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x835AEC0", Offset = "0x8359EC0", VA = "0x18835AEC0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public NAPFIGODKNN IPAAGBGNNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(NAPFIGODKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	private MLBLOFEMENF COOMBFPNNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x8348690", Offset = "0x8347690", VA = "0x188348690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x835C3F0", Offset = "0x835B3F0", VA = "0x18835C3F0")]
	public MHHODEBGAFD OBPJHINBGAA()
	{
		return default(MHHODEBGAFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x835B880", Offset = "0x835A880", VA = "0x18835B880")]
	public void JBDEJMEACOP([Out] Matrix4x4 KPOFKEGGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x835B030", Offset = "0x835A030", VA = "0x18835B030")]
	public void FEDGIGFPGHC([In] Vector3 GKANPAILENO, [In] Quaternion MMKPIDNBBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x835B130", Offset = "0x835A130", VA = "0x18835B130")]
	public void FEDGIGFPGHC([In] RigidTransform AAMMNIEPOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x835BFE0", Offset = "0x835AFE0", VA = "0x18835BFE0")]
	public void NDIJCGHIEMH([Out] RigidTransform AAMMNIEPOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x835C090", Offset = "0x835B090", VA = "0x18835C090")]
	public void NHAKFAHIIPP([In] Vector3 EOBLEMMKCEP, [In] Quaternion MIJPFMLMCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x835C190", Offset = "0x835B190", VA = "0x18835C190")]
	public void NHAKFAHIIPP([In] RigidTransform LELMEFHHAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x835ADE0", Offset = "0x8359DE0", VA = "0x18835ADE0")]
	public void DJIPOHPDFOF([Out] Vector3 EOBLEMMKCEP, [Out] Quaternion MIJPFMLMCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x835AD30", Offset = "0x8359D30", VA = "0x18835AD30")]
	public void DJIPOHPDFOF([Out] RigidTransform AAMMNIEPOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x835BA70", Offset = "0x835AA70", VA = "0x18835BA70")]
	public UniformTRS KLADGLOKLOC()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x835BAA0", Offset = "0x835AAA0", VA = "0x18835BAA0")]
	public void KLADGLOKLOC([Out] UniformTRS LELMEFHHAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x835B2B0", Offset = "0x835A2B0", VA = "0x18835B2B0")]
	public UniformTRS FHLGHFHPGCA()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x835B1F0", Offset = "0x835A1F0", VA = "0x18835B1F0")]
	public void FHLGHFHPGCA([Out] UniformTRS AAMMNIEPOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x835C250", Offset = "0x835B250", VA = "0x18835C250")]
	public Vector3 NLDCBNJOJLC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x835B540", Offset = "0x835A540", VA = "0x18835B540")]
	public void HOOAHFKNAAP([In] Vector3 IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x835B450", Offset = "0x835A450", VA = "0x18835B450")]
	public Vector3 HJCMKJOKKEB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x835A930", Offset = "0x8359930", VA = "0x18835A930")]
	public void AGEBFAMGLLK([In] Vector3 IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x835C6F0", Offset = "0x835B6F0", VA = "0x18835C6F0")]
	public Quaternion OKBHPHBMLNP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x835B7B0", Offset = "0x835A7B0", VA = "0x18835B7B0")]
	public void IDDOCCIMBDN([In] Quaternion IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x835C440", Offset = "0x835B440", VA = "0x18835C440")]
	public Quaternion OCNAHOBEBOC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x835B6E0", Offset = "0x835A6E0", VA = "0x18835B6E0")]
	public void ICBNHGBBDHE([In] Quaternion IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x835BB60", Offset = "0x835AB60", VA = "0x18835BB60")]
	public float KMHIFFBFEKD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x835B3A0", Offset = "0x835A3A0", VA = "0x18835B3A0")]
	public void HHIFHNHBHJH(float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x835C650", Offset = "0x835B650", VA = "0x18835C650")]
	public float OKBFNHIILNP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x835C340", Offset = "0x835B340", VA = "0x18835C340")]
	public void NPCLOGOIKDF(float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x835BD40", Offset = "0x835AD40", VA = "0x18835BD40")]
	public Vector3 MGPEFMIIEPA([In] Vector3 NBFEGPDMMPI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public PINGJEPFKOC(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x835AF00", Offset = "0x8359F00", VA = "0x18835AF00", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(PINGJEPFKOC EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct DJIFKPNNEJF : IEquatable<DJIFKPNNEJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	private HIFCFPPLBEL LIGIDBGHKHM
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x834AC40", Offset = "0x8349C40", VA = "0x18834AC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	public CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	private IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x8344F70", Offset = "0x8343F70", VA = "0x188344F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x834AD30", Offset = "0x8349D30", VA = "0x18834AD30")]
	public void MJGKABJHLCP(string MIMAHBNFICG, MFGLPJADLCK PMNGIBDJKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public DJIFKPNNEJF(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x834ACA0", Offset = "0x8349CA0", VA = "0x18834ACA0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(DJIFKPNNEJF EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342B80", VA = "0x188343B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct EMCAPMPGLGI : IEquatable<EMCAPMPGLGI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public HDLEPENBPIC GPAIOMJLNIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x834B7D0", Offset = "0x834A7D0", VA = "0x18834B7D0")]
		get
		{
			return default(HDLEPENBPIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public EMCAPMPGLGI(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x834B740", Offset = "0x834A740", VA = "0x18834B740", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(EMCAPMPGLGI EDJHHGMLKFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct GFNHDMLOHEK : IEquatable<GFNHDMLOHEK>
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public struct ILEOPBLDEGO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private GOLADBGGMAB MPAKEJAFLKL;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x834F6C0", Offset = "0x834E6C0", VA = "0x18834F6C0")]
		public ILEOPBLDEGO(GOLADBGGMAB MPAKEJAFLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x834F630", Offset = "0x834E630", VA = "0x18834F630", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x834CD60", Offset = "0x834BD60", VA = "0x18834CD60")]
	public ILEOPBLDEGO AILCCJNOEBG()
	{
		return default(ILEOPBLDEGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x834D0E0", Offset = "0x834C0E0", VA = "0x18834D0E0")]
	public JFAKAIMKMAI GNCHDNOFLHD(Allocator FKPBEKMFPLB = Allocator.Temp)
	{
		return default(JFAKAIMKMAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x834CE80", Offset = "0x834BE80", VA = "0x18834CE80")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> GEGFCDJDBJD(Allocator FKPBEKMFPLB = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x834D350", Offset = "0x834C350", VA = "0x18834D350")]
	public NativeArray<AGKIKBEKNMF> LOBNILGLDHJ(Allocator FKPBEKMFPLB = Allocator.Temp)
	{
		return default(NativeArray<AGKIKBEKNMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x834CFB0", Offset = "0x834BFB0", VA = "0x18834CFB0")]
	public NativeArray<AGKIKBEKNMF> GGCFDMIECJC(Allocator FKPBEKMFPLB = Allocator.Temp)
	{
		return default(NativeArray<AGKIKBEKNMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x834D290", Offset = "0x834C290", VA = "0x18834D290")]
	public CMDLBMCKJFH LDOPAGOJFKL(Allocator FKPBEKMFPLB = Allocator.Temp)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x834CCA0", Offset = "0x834BCA0", VA = "0x18834CCA0")]
	public CMDLBMCKJFH AIJAHKPAAIK(Allocator FKPBEKMFPLB = Allocator.Temp)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x834D1D0", Offset = "0x834C1D0", VA = "0x18834D1D0")]
	public CMDLBMCKJFH ILPHFMODDAE(Allocator FKPBEKMFPLB = Allocator.Temp)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public GFNHDMLOHEK(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x834CDF0", Offset = "0x834BDF0", VA = "0x18834CDF0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(GFNHDMLOHEK EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x834D480", Offset = "0x834C480", VA = "0x18834D480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct JCBFEBMDMCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int NCBCEOPLGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public int CLGKIHHGKHE;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct OIAGCHHJHPN : IEquatable<OIAGCHHJHPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public GFNHDMLOHEK NAMICNFNIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GFNHDMLOHEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public LHDBOKHDHOF IJBEHPGCOHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(LHDBOKHDHOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public EMCAPMPGLGI EECJLJMOCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(EMCAPMPGLGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x83582E0", Offset = "0x83572E0", VA = "0x1883582E0")]
	public bool NENBNENPAFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x8358380", Offset = "0x8357380", VA = "0x188358380")]
	public bool OFCJONBFELB([Out] Exception KKDGPEIEFMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public OIAGCHHJHPN(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static GOLADBGGMAB MJOOONLKLLN(OIAGCHHJHPN IOALKPFEKEK)
	{
		return default(GOLADBGGMAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x8358250", Offset = "0x8357250", VA = "0x188358250", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(OIAGCHHJHPN EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x834D480", Offset = "0x834C480", VA = "0x18834D480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public readonly struct OJGFONBOJAD : IDisposable, IEquatable<OJGFONBOJAD>
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static readonly OJGFONBOJAD NKEMJGNDPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public OIAGCHHJHPN NAMDBOANMDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(OIAGCHHJHPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public GFNHDMLOHEK NAMICNFNIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GFNHDMLOHEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x8358F40", Offset = "0x8357F40", VA = "0x188358F40")]
	public void MDIONIJGKAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x8358DE0", Offset = "0x8357DE0", VA = "0x188358DE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public OJGFONBOJAD(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x8358EB0", Offset = "0x8357EB0", VA = "0x188358EB0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "5")]
	public bool Equals(OJGFONBOJAD EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x8358FC0", Offset = "0x8357FC0", VA = "0x188358FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public readonly struct LHDBOKHDHOF : IEquatable<LHDBOKHDHOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public bool ODDDOFDNKII
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x8350FD0", Offset = "0x834FFD0", VA = "0x188350FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	public LHDBOKHDHOF(GOLADBGGMAB MPAKEJAFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342740", VA = "0x188343740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x8350F40", Offset = "0x834FF40", VA = "0x188350F40", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x8343570", Offset = "0x8342570", VA = "0x188343570", Slot = "4")]
	public bool Equals(LHDBOKHDHOF EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x834D480", Offset = "0x834C480", VA = "0x18834D480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class PCNBLJFOMBE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct GOEGMEIGLKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Guid JFLBGDIIGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public KCOBFIGKDMG KJNFNGMOHCN;
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private struct KCOBFIGKDMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int IOALKPFEKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int DAKOFAPAGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int JCKLBLAKCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int OLLNIEJNPNL;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x8350640", Offset = "0x834F640", VA = "0x188350640")]
		public bool FDNPIHDDEAA([Out] AGKIKBEKNMF CLCJHDIBCKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x83506E0", Offset = "0x834F6E0", VA = "0x1883506E0")]
		public KCOBFIGKDMG(AGKIKBEKNMF CLCJHDIBCKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x835A490", Offset = "0x8359490", VA = "0x18835A490")]
	public static Guid AAIHIAGAFMF(this AGKIKBEKNMF CLCJHDIBCKB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x835A530", Offset = "0x8359530", VA = "0x18835A530")]
	public static bool JCONHAIEJBH(this Guid JFLBGDIIGHK, [Out] AGKIKBEKNMF CLCJHDIBCKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class BOHNFNJHFMH
{
	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x8346880", Offset = "0x8345880", VA = "0x188346880")]
	public static IANIJLFPGEK HENPKKNEMOG(this GOLADBGGMAB PBJHGGBBAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x8346790", Offset = "0x8345790", VA = "0x188346790")]
	public static AIMNAMMCJGJ AABFOAEAFHG(this GOLADBGGMAB PBJHGGBBAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x83467F0", Offset = "0x83457F0", VA = "0x1883467F0")]
	public static EntityManager GLANLJGHLBG(this GOLADBGGMAB PBJHGGBBAAF)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x39E23D0", Offset = "0x39E13D0", VA = "0x1839E23D0")]
	internal static bool KNEGOHEJONL<T>(this GOLADBGGMAB PBJHGGBBAAF, bool DAKNLGLKCLP) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8346910", Offset = "0x8345910", VA = "0x188346910")]
	public static bool LHCFOCGMJNC(this GOLADBGGMAB PBJHGGBBAAF, PEDOGLOKHKA EKGLNGMKMKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x39E2590", Offset = "0x39E1590", VA = "0x1839E2590")]
	public static bool NHEAKGPEACA<T>(this GOLADBGGMAB PBJHGGBBAAF) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x39DF350", Offset = "0x39DE350", VA = "0x1839DF350")]
	public static bool FENLDMKFDMB<T>(this GOLADBGGMAB PBJHGGBBAAF) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x39DD580", Offset = "0x39DC580", VA = "0x1839DD580")]
	[JJMPKLAHHKN]
	internal static NativeArray<T> AMOOEOGHLHL<T>(this GOLADBGGMAB PBJHGGBBAAF, Allocator FKPBEKMFPLB) where T : struct, IBufferElementData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x39DD6F0", Offset = "0x39DC6F0", VA = "0x1839DD6F0")]
	[JJMPKLAHHKN]
	public static T CEHHKPPFEPO<T>(this GOLADBGGMAB PBJHGGBBAAF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x39DF4B0", Offset = "0x39DE4B0", VA = "0x1839DF4B0")]
	[JJMPKLAHHKN]
	public static T ILKOCPGPPKH<T>(this GOLADBGGMAB PBJHGGBBAAF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x39DF180", Offset = "0x39DE180", VA = "0x1839DF180")]
	public static bool DDLMEKNIODL<T>(this GOLADBGGMAB PBJHGGBBAAF, [Out] T IOALKPFEKEK) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x39DF2A0", Offset = "0x39DE2A0", VA = "0x1839DF2A0")]
	public static T EMJNLLOBAHO<T>(this GOLADBGGMAB PBJHGGBBAAF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x39DD670", Offset = "0x39DC670", VA = "0x1839DD670")]
	public static T CDCLGDOKHIJ<T>(this GOLADBGGMAB PBJHGGBBAAF) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class JKPCNELLLNJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public struct JFAKAIMKMAI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private CMDLBMCKJFH BKFMBMLFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> AEPNADFPGJB;

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x60010E0", Offset = "0x60000E0", VA = "0x1860010E0")]
	public JFAKAIMKMAI(CMDLBMCKJFH BKFMBMLFOLE, NativeArray<EntityRemapUtility.EntityRemapInfo> AEPNADFPGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x834FC20", Offset = "0x834EC20", VA = "0x18834FC20")]
	public LocalId NPGODMAMNCO(LocalId PGIOEBKALDP)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x834FC60", Offset = "0x834EC60", VA = "0x18834FC60")]
	public LocalId NPGODMAMNCO(int HLGKMAPOEBE)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x834FBB0", Offset = "0x834EBB0", VA = "0x18834FBB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MNGBOGLKFIB
{
	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEIMGLCIGKB(World BABHHEKHGKC, NativeParallelHashSet<FixedString64Bytes> HAEMIEMNLHC);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OKLMALKFJGP
{
	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNACLKFKBDN(GOLADBGGMAB GNMFDIECOJL, [Out] uint PBJHGGBBAAF);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JIBGBDNJECO(GOLADBGGMAB GNMFDIECOJL, [Out] uint PBJHGGBBAAF);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CMMBLAAGOJB(GOLADBGGMAB GNMFDIECOJL, uint PBJHGGBBAAF);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HDJNJCNANGM(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string OJFAEOLDBLJ(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMDOMHDPMDI(GOLADBGGMAB GNMFDIECOJL, string PBJHGGBBAAF);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PJPGBOPDMJL(GOLADBGGMAB GNMFDIECOJL, [Out] string MHCHKMKKIEK);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CKBLDCEABMH(GOLADBGGMAB GNMFDIECOJL, string MHCHKMKKIEK);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KBGMLCPGKEG
{
	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	Guid DEKFAMLPOKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	Guid GOELEIOICGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLEPGBJABHP(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task LDICLGFEODI(CJNFLLJGPFC PGIOEBKALDP);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid NAPEBOAOIII(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNIAHFLAPOB(GOLADBGGMAB MPAKEJAFLKL, Guid OMEKNOMEFGA);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HJOLCKGJFMI(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task HBNBKFAPGKH(GOLADBGGMAB EMABJDLOPJA, GOLADBGGMAB EBJBKAEFOPM);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OMCNFOANLMH(GOLADBGGMAB MPAKEJAFLKL, AGKIKBEKNMF OFLDDBHKLMB);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AMBIGHIEAHC
{
	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	Guid DEKFAMLPOKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKNBBNDNPIL(NativeList<Guid> MEAEIHPCIIM, NativeList<Guid> OGBMNCOKGEG, NativeList<FixedString64Bytes> BIMFBBBADGE);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KGCLJGPLLND
{
	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMDLBMCKJFH HLBAMPCPLCP(Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMDLBMCKJFH MNBIKNEMLOJ(Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IPNKNBCNLHD(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KGOOFDOKHEF(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LKPFAHDLLMI(GOLADBGGMAB GNMFDIECOJL, [Out] GOLADBGGMAB CCFCFOGKAHO);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LJOHOPCAPLG(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MFLKFIKGEHI(GOLADBGGMAB GNMFDIECOJL, int NFDMOMMJDAE);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GOLADBGGMAB MOLNAACHCDF(GOLADBGGMAB CCFCFOGKAHO);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AFMADOCDKKK(CMDLBMCKJFH IGGAEBJHGKC, bool CEBLFEIKALJ);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DNMFKBFBANC(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LPPLPBIIIPI(GOLADBGGMAB GNMFDIECOJL, bool KKAPJFEJKBM);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int AEGMDIOMJMM();

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GMPIHBHJGFB(GOLADBGGMAB MPAKEJAFLKL);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BNKIBCCPBDC
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<GOLADBGGMAB, GOLADBGGMAB> LFFNABNCDFI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<GOLADBGGMAB, GOLADBGGMAB> LDHNCHKNEBC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<GOLADBGGMAB, GOLADBGGMAB, GOLADBGGMAB> NCPKEOLALJM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<GOLADBGGMAB> ACNDCEPFPEK;

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NIPEMGFDKDD(GOLADBGGMAB MPAKEJAFLKL, GOLADBGGMAB KEFFJGFPFNH);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GOLADBGGMAB MCCFIELKNJO(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CMDLBMCKJFH NMNIOAJKNEG(GOLADBGGMAB MPAKEJAFLKL, Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GOLADBGGMAB FFGGNOPDNCG(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AJJACHEAPFN(GOLADBGGMAB MPAKEJAFLKL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EAACKEDALMG(GOLADBGGMAB MPAKEJAFLKL, float DFIAMPCHCLH);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool JANMNAJLCFN(GOLADBGGMAB MPAKEJAFLKL, [Out] GOLADBGGMAB EBJBKAEFOPM);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool GPDAGCMDHDF(GOLADBGGMAB MPAKEJAFLKL, [Out] RigidTransform AFLNGJJDBNF);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 DDDFIHPOJAP(OHIIGKFDNND GNJGGOGMDMB);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion CGGOMGJAEAP(OHIIGKFDNND GNJGGOGMDMB);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class AGHPMBCJBNP
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HJCGFPPEFMF
{
	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	object LOCHEGAJICK
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MDFLJFLBGJG
{
	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOEBJEJENII(GOLADBGGMAB PGIOEBKALDP, PDCONBAHHJI APBLHJLFMFG);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLFGKJGFJGI(PDCONBAHHJI APBLHJLFMFG);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DOJPMMMMCBP(GOLADBGGMAB MPAKEJAFLKL, [Out] PDCONBAHHJI ODMKBBBMAIO);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FFHJOEFABLH
{
	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOCCJKGMGJM(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ReadOnlySpan<GOLADBGGMAB> MCELNFKMKEK();
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[Flags]
public enum APMPHONECEL
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KFADKFHALNL
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public ref struct OFCIKEGFGEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ReadOnlySpan<GOLADBGGMAB> EFHKPJFDGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public ReadOnlySpan<GOLADBGGMAB> NJLKIINEDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public GOLADBGGMAB OBIHCCIIPHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public GOLADBGGMAB FDIKJFKHJII;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGPJJJLPAAG(GOLADBGGMAB LGGKHILLBLK, GOLADBGGMAB HCJBBDBGJHG);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CIPGFLCBPDL(GOLADBGGMAB BNCOEAKBHGC, bool HOJOMGEINAH);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DDICEEEFLEF(GOLADBGGMAB NJMBKFCDKPH, GOLADBGGMAB IMOKBDEJNFD);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GFOAHDFPNJH(GOLADBGGMAB JPAJKPMDGBM, bool HOJOMGEINAH);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KDMKBELBLBG(GOLADBGGMAB JPAJKPMDGBM);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MFJJEAMLDLO(GOLADBGGMAB JPAJKPMDGBM);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GOLADBGGMAB MHNGOBFOMKJ(GOLADBGGMAB BNCOEAKBHGC);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ReadOnlySpan<GOLADBGGMAB> ALHAEFMBANN(GOLADBGGMAB JPAJKPMDGBM);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ReadOnlySpan<GOLADBGGMAB> ONGCHIIKKFB(GOLADBGGMAB JPAJKPMDGBM);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OFCIKEGFGEO LAAHAMKFEKP(GOLADBGGMAB JPAJKPMDGBM, float PMEBKKNKANI, float CBAOBAGCDDB);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EBEIALIIOJD(GOLADBGGMAB JPAJKPMDGBM, [Out] HFEGPFPBOPD CCNILHLCOLN);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DPPMAAAGEPO(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FHIIIPPPEML(GOLADBGGMAB MPAKEJAFLKL);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public readonly struct LAMEDPPFBNA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly string HJLBILHBIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly T CAILINJCNIJ;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x544EDE0", Offset = "0x544DDE0", VA = "0x18544EDE0")]
	public LAMEDPPFBNA(T CAILINJCNIJ, [Optional][CallerMemberName] string HJLBILHBIIC)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly LAMEDPPFBNA<int> OIKMBBPFJNA;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static readonly LAMEDPPFBNA<int> KEBEMEPBCFC;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly LAMEDPPFBNA<int> LAOENMCGEIB;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public enum DPCPKHBEEAA
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class CIGMNHAACKE
{
	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x14581B0", Offset = "0x14571B0", VA = "0x1814581B0")]
	public static bool CMGLIGKCKHL(this DPCPKHBEEAA GICMHPOANOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x186E7F0", Offset = "0x186D7F0", VA = "0x18186E7F0")]
	public static bool ILKJBPIICPG(this DPCPKHBEEAA GICMHPOANOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x312B1C0", Offset = "0x312A1C0", VA = "0x18312B1C0")]
	public static bool ABBOMGIOJOM(this DPCPKHBEEAA GICMHPOANOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x14581A0", Offset = "0x14571A0", VA = "0x1814581A0")]
	public static bool KCPCBFJMEAG(this DPCPKHBEEAA GICMHPOANOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IEJLCKLIGMC
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public enum HJMGDGJALJA
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public enum DNJMCCGCGBG
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	HJMGDGJALJA NKFLGDBFNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	bool KCBFBGCIMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	bool PMIEJHICDBH
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	DNJMCCGCGBG PLCHKPECCPE
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.Application)]
public interface PIOPCFKGHHN
{
	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	DPCPKHBEEAA CADDCIDLNBP
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	DPCPKHBEEAA AABAGJPEDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	DPCPKHBEEAA PJGCPFEKMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	DPCPKHBEEAA PBLMCCENHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	DPCPKHBEEAA DCOKCCKOCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	DPCPKHBEEAA BHCFOALICJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	DPCPKHBEEAA IKICJNMIDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	DPCPKHBEEAA CIADJCPGGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	DPCPKHBEEAA JMNGKAOICNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	DPCPKHBEEAA MBKDCFEGJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	DPCPKHBEEAA JGJBEBCJIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	DPCPKHBEEAA BKBNABPPGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	DPCPKHBEEAA PDKMOMIPHEF
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	DPCPKHBEEAA PFKCJFIPKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	DPCPKHBEEAA JLBGIOLLPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	DPCPKHBEEAA KJAJNBHKJPM
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	DPCPKHBEEAA KDDIDDCGMAP
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	DPCPKHBEEAA MJEAKJIHDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	DPCPKHBEEAA PCKMCFILJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	DPCPKHBEEAA IMFHPAHHIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LMKONLJOAEP(LAMEDPPFBNA<int> ANJJOFOGAJP);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ALDCMNCNIJH
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event CPEHAKDNCAL.FHEAONKHFIK GKFONKCIAFF;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GOLADBGGMAB FLHBHPPGFKB(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CMDLBMCKJFH JLJIICPAKMD(Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MBPKFOHGPLA EFPNJPEAIFI(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MAHFOHAGGGN(IEnumerable<GOLADBGGMAB> DAMCJPANLMM);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MBPKFOHGPLA HNDHGMBKJNH(GOLADBGGMAB EBJBKAEFOPM, GOLADBGGMAB BKFMBMLFOLE, bool IAPGELOJANO, GOLADBGGMAB AOJAHPGAGPO);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GOLADBGGMAB GHBGGJNGHEC(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AKCKLCNBHIA(GOLADBGGMAB MPAKEJAFLKL, GOLADBGGMAB EBJBKAEFOPM, bool DFMMLCPAMHC = false);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ILIEHKGEAAE(GOLADBGGMAB MPAKEJAFLKL, GOLADBGGMAB EBJBKAEFOPM);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MEIGEIKGIGF(GOLADBGGMAB ICMDLBKABMF, GOLADBGGMAB JJMBAJFALKF);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	CMDLBMCKJFH MIBENGOPMGG(GOLADBGGMAB NCIBPMAFIKA);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IGPEIIHANLC(GOLADBGGMAB MPAKEJAFLKL, GOLADBGGMAB EKIPIDFCBIO);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CMDLBMCKJFH KIGHHIFJLLO(CMDLBMCKJFH FINMOBOKJAM, APMPHONECEL OMENDEGIBIL, Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool IDADBMDGAMG(GOLADBGGMAB MPAKEJAFLKL, GOLADBGGMAB JBAIOIPGKBB);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GOLADBGGMAB PAEOFFMNDEN(GOLADBGGMAB AOJAHPGAGPO, GOLADBGGMAB PLHHFIEJNBA);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool NNPEGGEOHKH(GOLADBGGMAB AOJAHPGAGPO, GOLADBGGMAB PLHHFIEJNBA, [Out] GOLADBGGMAB DPMOBGFAECH);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "17")]
	GOLADBGGMAB NLNCCMPNENP(GOLADBGGMAB[] IGGAEBJHGKC);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "18")]
	GOLADBGGMAB DMGMBJPIKOI(GOLADBGGMAB MPAKEJAFLKL, uint CIMNMIABLEL);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class CAPAOJLCCJK
{
	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x8346AA0", Offset = "0x8345AA0", VA = "0x188346AA0")]
	public static bool FKHKIDHBPAC(this ALDCMNCNIJH PCPALLGGNCI, GOLADBGGMAB MPAKEJAFLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x8346B50", Offset = "0x8345B50", VA = "0x188346B50")]
	public static CMDLBMCKJFH KIGHHIFJLLO(this ALDCMNCNIJH JMELKBNBGDN, GOLADBGGMAB MPAKEJAFLKL, APMPHONECEL OMENDEGIBIL, Allocator FKPBEKMFPLB)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x8346B10", Offset = "0x8345B10", VA = "0x188346B10")]
	public static CMDLBMCKJFH JJLHOMKHAKN(this ALDCMNCNIJH JMELKBNBGDN, GOLADBGGMAB MPAKEJAFLKL, Allocator FKPBEKMFPLB)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x8346A20", Offset = "0x8345A20", VA = "0x188346A20")]
	public static CMDLBMCKJFH BEDMOJKMOHA(this ALDCMNCNIJH JMELKBNBGDN, GOLADBGGMAB MPAKEJAFLKL, Allocator FKPBEKMFPLB)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x8346E20", Offset = "0x8345E20", VA = "0x188346E20")]
	public static CMDLBMCKJFH OMNBHEANEFC(this ALDCMNCNIJH JMELKBNBGDN, GOLADBGGMAB MPAKEJAFLKL, Allocator FKPBEKMFPLB)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x8346A60", Offset = "0x8345A60", VA = "0x188346A60")]
	public static CMDLBMCKJFH BICPLNNIAGG(this ALDCMNCNIJH JMELKBNBGDN, GOLADBGGMAB MPAKEJAFLKL, Allocator FKPBEKMFPLB)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x8346DE0", Offset = "0x8345DE0", VA = "0x188346DE0")]
	public static CMDLBMCKJFH LAGNMCNBHGF(this ALDCMNCNIJH JMELKBNBGDN, GOLADBGGMAB MPAKEJAFLKL, Allocator FKPBEKMFPLB)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x8346E60", Offset = "0x8345E60", VA = "0x188346E60")]
	public static CMDLBMCKJFH PLHDHPDMOHE(this ALDCMNCNIJH JMELKBNBGDN, GOLADBGGMAB MPAKEJAFLKL, Allocator FKPBEKMFPLB)
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x8346EA0", Offset = "0x8345EA0", VA = "0x188346EA0")]
	public static CMDLBMCKJFH PLHDHPDMOHE(this ALDCMNCNIJH JMELKBNBGDN, CMDLBMCKJFH MPAKEJAFLKL, Allocator FKPBEKMFPLB)
	{
		return default(CMDLBMCKJFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EJLIDGIHMMD
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x834B6E0", Offset = "0x834A6E0", VA = "0x18834B6E0", Slot = "0")]
	Task<OIAGCHHJHPN> APNNIOGMNDA(KKPOINACGCE PMJGKHFECJP, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "1")]
	void BMMPGJKOKCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FOGHOLNHJOB
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event CPEHAKDNCAL.FHEAONKHFIK GKFONKCIAFF;

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GOLADBGGMAB GHBGGJNGHEC(GOLADBGGMAB EMABJDLOPJA);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<GOLADBGGMAB> KLKBCFNJBOM();

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<GOLADBGGMAB> COHCENKELGA(GOLADBGGMAB EBJBKAEFOPM);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LFNLPDOPEKN(GOLADBGGMAB LNOIJJGANHF, GOLADBGGMAB INGMLPHKHLE, [Out] MBPKFOHGPLA ALFMFCNMBGK);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MMMMMLKACIO(GOLADBGGMAB LNOIJJGANHF, GOLADBGGMAB CFLPJAKGNEA, [Out] MBPKFOHGPLA ALFMFCNMBGK);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PPPLIJMDNGB(GOLADBGGMAB LNOIJJGANHF);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ILIEHKGEAAE(GOLADBGGMAB CPMMDODCOCB, GOLADBGGMAB BKAKGIFOLLC);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MBPKFOHGPLA IEPOAMAEJKB(GOLADBGGMAB MPAKEJAFLKL);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LGKOFLOEHGF
{
	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	bool EKNGGLELIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	bool JADLNILALKC
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	bool IEPNBLCOJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FHAAABFNCEI
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GCIACINKCJF
{
	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNIAFJIMPFE(GOLADBGGMAB MPAKEJAFLKL, PEDOGLOKHKA EKGLNGMKMKH);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKHNBJBNCGN(GOLADBGGMAB MPAKEJAFLKL, PEDOGLOKHKA EKGLNGMKMKH);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BNJLPOMMMFC
{
	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FHHKDIEHOCM<string> OGKDJDMOOIP(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FHHKDIEHOCM<string> LBKBMBDPAPM(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELNMNFLJOPP(GOLADBGGMAB MPAKEJAFLKL, FHHKDIEHOCM<string> LHCAACJBMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DEODHGCHCML(GOLADBGGMAB MPAKEJAFLKL, FHHKDIEHOCM<string> LHCAACJBMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BIAGGPFIEIK(GOLADBGGMAB JNBIEHAGHHB, GOLADBGGMAB ONPNMMHOHLI);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MIIIGKJCFDN
{
	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OHACPJDAJBK LCANNFNFNOE(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOADFFFEAAP(GOLADBGGMAB GNMFDIECOJL, OHACPJDAJBK JKDIBBKJAHG);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NBEHMFJMDAI(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJFEAHGMAOJ(GOLADBGGMAB GNMFDIECOJL, bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FHHKDIEHOCM<string> JCDBNCDNNJH(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IOBHMOGODBI(GOLADBGGMAB GNMFDIECOJL, FHHKDIEHOCM<string> LHCAACJBMFJ);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FHHKDIEHOCM<string> DOCMLLEGNDB(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BKAKPMIHAGM(GOLADBGGMAB GNMFDIECOJL, FHHKDIEHOCM<string> LHCAACJBMFJ);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FHHKDIEHOCM<string> NEKDMKHOCBJ(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CDHCNDFOIKN(GOLADBGGMAB GNMFDIECOJL, FHHKDIEHOCM<string> LHCAACJBMFJ);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FHHKDIEHOCM<string> JKLPOFJCDPK(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JLGGACBEJLM(GOLADBGGMAB GNMFDIECOJL, FHHKDIEHOCM<string> LHCAACJBMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DBPMFEDBOAI(GOLADBGGMAB GNMFDIECOJL, GOLADBGGMAB MFOAOKBDIIM);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OPJBKKJOEBE
{
	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFNCFFMLKND([In] float3 NAOOBLMKEHE, [In] float3 NBFEGPDMMPI, float OAGBEPAKAEK, [Out] BAJEFBNGCKP JLHHHEHDMHJ, [Out] GOLADBGGMAB PNINCLCEGEG);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LINNKPDGIPK([In] float3 NAOOBLMKEHE, float MGJGIJAADIJ, List<GOLADBGGMAB> IGGAEBJHGKC);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CDDPJJKEHPN(Plane[] MIADPIEPPLC, float3 NAOOBLMKEHE, float3 OHLAACOOIPF, quaternion KDHLIJMPIFF, List<GOLADBGGMAB> IGGAEBJHGKC);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EMFDPFKFEAL
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFNCFFMLKND([In] NativeArray<Entity> PCOPFIMLFLG, [In] float3 NAOOBLMKEHE, [In] float3 NBFEGPDMMPI, [In] NativeArray<BAJEFBNGCKP> GJLGJHLAFKD);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> LINNKPDGIPK([In] NativeArray<Entity> PCOPFIMLFLG, [In] float3 NAOOBLMKEHE, float MGJGIJAADIJ);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> CDDPJJKEHPN([In] NativeArray<Entity> PCOPFIMLFLG, [In] NativeArray<float4> GCPINCGCJPP);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct HAHDAJJHECJ : BDFEHDIGKLJ, IEquatable<HAHDAJJHECJ>
{
	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	public int MKOCHPIICKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x14E7060", Offset = "0x14E6060", VA = "0x1814E7060", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	public int IPPLPEJMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x314D220", Offset = "0x314C220", VA = "0x18314D220", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x6EC13E0", Offset = "0x6EC03E0", VA = "0x186EC13E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x834E4A0", Offset = "0x834D4A0", VA = "0x18834E4A0", Slot = "8")]
	public bool Equals(HAHDAJJHECJ EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x834E4F0", Offset = "0x834D4F0", VA = "0x18834E4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct BAJEFBNGCKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float HGHDDDLCIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public float3 PNJPAIKKPPF;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HIPGIJPIEFA
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MLBLOFEMENF
{
	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	AENBPPFEJMA AGHBBKAIAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<CMDLBMCKJFH, NativeArray<RRObjectPrefabData>> MLFEFDCMBGJ;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<CMDLBMCKJFH> EFLANKGFKDN;

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CMDLBMCKJFH HMFBDHKHFGL();

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MICGIIPNHMN MINDFBLBFNI(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData BENAFAKKPKG(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EIINBHPMLFI(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CJNFLLJGPFC KAICBOPJKON(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IBHPPEEIDNH(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NMMNADMDLDL(GOLADBGGMAB MPAKEJAFLKL, [Out] Transform PLPGMCABFBF);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GOLADBGGMAB DOHKCNJAFOJ(AGKIKBEKNMF CLCJHDIBCKB);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NDDAAAODNOK(AGKIKBEKNMF CLCJHDIBCKB, [Out] GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AGKIKBEKNMF LMDHLBPAELO(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CMDLBMCKJFH DOHKCNJAFOJ(NativeArray<AGKIKBEKNMF> CLCJHDIBCKB, Allocator FKPBEKMFPLB, bool JKODHIFFPLC = true);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool OBBFOMKPEEK(NativeArray<CCAGBPEALBN> DJNIKFEPIDC, NativeArray<AGKIKBEKNMF> EHCCCPAHBJP, NativeArray<Entity> EOOCLLOCDPC, FHHKDIEHOCM<KKPLCBIGLFN> MODLGGLJADP);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CJNFLLJGPFC PGEOHMNABIF();

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	CJNFLLJGPFC LDIIMLAKGCC(RRObjectPrefabData CMLIMNGJEDE, [Optional] ENKCMKGNHEJ PIGFCDMOMPJ);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	AJMHKKHLCIF DCLJNCKFJNO();

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	BCMIKBHBKJF AMDDMBMFJNL();

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	GODLBLNHOPC IKLINKNNFNM(GOAIGCDFKPE JIELAMKPIHK);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void IGJHGODPFOO(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool FIEAFHDEMCK(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CMDLBMCKJFH FHKMOGGFGEH(CMDLBMCKJFH CHICPIFINFB, Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool KLJIOEKBNLN(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IKBMGMHILAK(GOLADBGGMAB MPAKEJAFLKL, ComponentTypes OJFGLMILFBI);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "28")]
	GOLADBGGMAB DDJGEAMHODA(Transform PLPGMCABFBF);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class EOCGHKNFPBO
{
	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x834BEE0", Offset = "0x834AEE0", VA = "0x18834BEE0")]
	internal static GOLADBGGMAB NNKGCGOMGNB(this Entity KELHIEHPDJD, MLBLOFEMENF PMNGIBDJKEE)
	{
		return default(GOLADBGGMAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x834BE60", Offset = "0x834AE60", VA = "0x18834BE60")]
	public static CJNFLLJGPFC LINHANABHMC(this MLBLOFEMENF PMNGIBDJKEE, LocalId MPAKEJAFLKL)
	{
		return default(CJNFLLJGPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x834BDB0", Offset = "0x834ADB0", VA = "0x18834BDB0")]
	public static GOLADBGGMAB DOHKCNJAFOJ(this MLBLOFEMENF PMNGIBDJKEE, LocalId MPAKEJAFLKL)
	{
		return default(GOLADBGGMAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x834BE70", Offset = "0x834AE70", VA = "0x18834BE70")]
	public static AGKIKBEKNMF LMDHLBPAELO(this MLBLOFEMENF PMNGIBDJKEE, LocalId MPAKEJAFLKL)
	{
		return default(AGKIKBEKNMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x834BC10", Offset = "0x834AC10", VA = "0x18834BC10")]
	public static AJMHKKHLCIF BJFKIMFKCMD(this MLBLOFEMENF PMNGIBDJKEE, RigidTransform LELMEFHHAON)
	{
		return default(AJMHKKHLCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x834BA60", Offset = "0x834AA60", VA = "0x18834BA60")]
	public static GODLBLNHOPC BILKOBFGPPK(this MLBLOFEMENF PMNGIBDJKEE, GOAIGCDFKPE ABFAIEAFIJF, RigidTransform LELMEFHHAON)
	{
		return default(GODLBLNHOPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x834B8C0", Offset = "0x834A8C0", VA = "0x18834B8C0")]
	public static BCMIKBHBKJF AJAJELECDCG(this MLBLOFEMENF PMNGIBDJKEE, RigidTransform LELMEFHHAON)
	{
		return default(BCMIKBHBKJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x834BF90", Offset = "0x834AF90", VA = "0x18834BF90")]
	private static void PLCEJOAGKGI(CJNFLLJGPFC GBAOGPOCBIJ, RigidTransform LELMEFHHAON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal interface MCFJGNKLINO
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MIKJANMMKCG
{
	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	bool AGIGEMCLOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	GOLADBGGMAB JKFMGNIDGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	CJNFLLJGPFC DPEMBGNMEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event PNPMDONDNCA OLGGDLGPBKI;

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GOLADBGGMAB PAEOFFMNDEN(GOLADBGGMAB AOJAHPGAGPO, GOLADBGGMAB PLHHFIEJNBA);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NNPEGGEOHKH(GOLADBGGMAB AOJAHPGAGPO, GOLADBGGMAB PLHHFIEJNBA, [Out] GOLADBGGMAB DPMOBGFAECH);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KGBGPFFPPLK();

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KLFILHEJPCF();

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NKMDKOKJJED(GOLADBGGMAB AOJAHPGAGPO);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JHOHLJLCJJD(GOLADBGGMAB AOJAHPGAGPO);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public delegate void PNPMDONDNCA(CJNFLLJGPFC BBGODBGMCIM, CJNFLLJGPFC OFBMJEFMLNI);
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class BDEALIALMKF
{
	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x83464C0", Offset = "0x83454C0", VA = "0x1883464C0")]
	public static bool EFKCEALAGKN(this MIKJANMMKCG AJDJOPIJBJN, CJNFLLJGPFC AOJAHPGAGPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x8346510", Offset = "0x8345510", VA = "0x188346510")]
	public static bool MNBNGGNJMGK(this MIKJANMMKCG AJDJOPIJBJN, GOLADBGGMAB AOJAHPGAGPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x83465F0", Offset = "0x83455F0", VA = "0x1883465F0")]
	public static bool OCFIJPHCPKA(this MIKJANMMKCG AJDJOPIJBJN, GOLADBGGMAB AOJAHPGAGPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IFOBNLBBBGH
{
	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEPJNLIMOPF(NativeList<RRObjectPrefabData> LGGGHFHACND);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EPDIJBLMGLH
{
	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DPAGDFLAPIB(CJNFLLJGPFC GBAOGPOCBIJ, EJKKDGPBELM CBONFFLHKGG, List<CJNFLLJGPFC> MHPOCKAHOPH);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BEPMHBAOPCB(CJNFLLJGPFC GBAOGPOCBIJ, EJKKDGPBELM CBONFFLHKGG);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAFPHEJBJPG(CJNFLLJGPFC GBAOGPOCBIJ, List<CJNFLLJGPFC> MHPOCKAHOPH);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EEGEMFPJFIH(CJNFLLJGPFC FICFFHNKAMC, CJNFLLJGPFC AOJAHPGAGPO, EJKKDGPBELM CBONFFLHKGG);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CJNFLLJGPFC HFBDPHMMFBN(CJNFLLJGPFC FICFFHNKAMC, int HLGKMAPOEBE, EJKKDGPBELM CBONFFLHKGG);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DKAJDDNGPIL(CJNFLLJGPFC FICFFHNKAMC, CJNFLLJGPFC AOJAHPGAGPO, EJKKDGPBELM CBONFFLHKGG);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CADIPHHMFKH(CJNFLLJGPFC FICFFHNKAMC, CJNFLLJGPFC AOJAHPGAGPO, EJKKDGPBELM CBONFFLHKGG);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BOFFGAPBBCN(CJNFLLJGPFC FICFFHNKAMC, EJKKDGPBELM CBONFFLHKGG);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FJPOHFIMOGN(CJNFLLJGPFC FICFFHNKAMC, CJNFLLJGPFC AOJAHPGAGPO, EJKKDGPBELM CBONFFLHKGG);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CLHOHLGECIG(Entity FICFFHNKAMC, Entity AOJAHPGAGPO, EJKKDGPBELM CBONFFLHKGG);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BEBENOJMOGM(Entity FICFFHNKAMC, EJKKDGPBELM CBONFFLHKGG);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KOHDKHFOBEM(CJNFLLJGPFC AOJAHPGAGPO, EJKKDGPBELM CBONFFLHKGG);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CCCAELDKIOF
{
	[Cpp2IlInjected.Token(Token = "0x17000202")]
	EMCAPMPGLGI ONFDCILBEHA
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HDLEPENBPIC DCNJCAPIGIM(EMCAPMPGLGI KJIOEGBKNOL);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EMCAPMPGLGI LEOEGEKOBHM();

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMCAPMPGLGI OPNKBBFGMLF();
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NDFODAJELCD
{
	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOLDKEODCAN(GOLADBGGMAB AOJAHPGAGPO, [Out] GOLADBGGMAB MLIHLNMHPGM);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PFHPACGGLIC
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<GOLADBGGMAB> JGILNFLPPJC;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFBCJLDPFKH(GOLADBGGMAB NCIBPMAFIKA, bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEGJBGOLPBL(GOLADBGGMAB NCIBPMAFIKA, bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OOHJFIOLDMF(GOLADBGGMAB NCIBPMAFIKA, int IOALKPFEKEK);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CEAHOBBINHN
{
	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<GOLADBGGMAB> CHGMAONINIH(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GOLADBGGMAB BAMFCNBHMNK(GOLADBGGMAB MPAKEJAFLKL, int HLGKMAPOEBE);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int EMCIELKBOHG(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NIPIDDDBDNP DEIGDFGAGHJ(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JKBCFDJBJOP(GOLADBGGMAB MPAKEJAFLKL, NIPIDDDBDNP OGEALFKCCAP);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GOLADBGGMAB CBFMBGLNLKB(GOLADBGGMAB MPAKEJAFLKL, [Optional] float3? EBGKGBGFPOC, [Optional] quaternion? KDHLIJMPIFF, [Optional] float3? AJNABLFIHCD);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GOLADBGGMAB LDLBGCLIKNC(GOLADBGGMAB MPAKEJAFLKL, int HLGKMAPOEBE, [Optional] float3? EBGKGBGFPOC, [Optional] quaternion? KDHLIJMPIFF, [Optional] float3? AJNABLFIHCD);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CEPDOMLPFJP(GOLADBGGMAB MPAKEJAFLKL, int HLGKMAPOEBE);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MGBFMHAJLJH(GOLADBGGMAB MPAKEJAFLKL);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CJHDAHDILOO
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KCBEMDIBPFN
{
	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGEMKKAPJFL(GOLADBGGMAB MPAKEJAFLKL, ReadOnlySpan<TerrainGenerationLayer> JBKINJIFLDH);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGPFIFJIPKA(GOLADBGGMAB MPAKEJAFLKL, ReadOnlySpan<PJCPLMKFBGA> JBKINJIFLDH);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HMKLJJFFGLI
{
	[Cpp2IlInjected.Token(Token = "0x17000203")]
	bool DBLOKBDKODA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPADLELJHAA();

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KGAHLOKCEII();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ONIBJBLMCCF();

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OOJGNJMMMJI();

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNMHOHCHBDI();

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EFLLDBMEGGN();

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EMMNOACPAMF();

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NOKJDECDBNK();

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BJOCBMBNKAL();

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MICIKBFPOGO();

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PDOOCCHHBKO();

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HIPLMOHFDAO();
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IILECJGHNJE
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKCEBPPMIDF(GOLADBGGMAB AOJAHPGAGPO, [Out] int FICFFHNKAMC);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IONGNMFCFJK(GOLADBGGMAB AOJAHPGAGPO, int FICFFHNKAMC);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMOHENLDPKN(GOLADBGGMAB AOJAHPGAGPO, bool OFHMBLCHIEC);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EJLBIJLDNAH(GOLADBGGMAB AOJAHPGAGPO, float GNGMNGGDALM, float CLCEDBMFEPH, float DBNCGNLMDEP);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ACOMDGGLANI(GOLADBGGMAB MPAKEJAFLKL, [Out] float CLCEDBMFEPH, [Out] float DBNCGNLMDEP);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ENAEDMEHOKM(GOLADBGGMAB AOJAHPGAGPO, float3 EBGKGBGFPOC, quaternion KDHLIJMPIFF);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DAENKPBJFCA(GOLADBGGMAB AOJAHPGAGPO, [Out] float3 EBGKGBGFPOC, [Out] quaternion KDHLIJMPIFF);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NBIHBFBPHCL(GOLADBGGMAB AOJAHPGAGPO);
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CPPFMOPAJKK
{
	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOOAHFKNAAP(Entity KELHIEHPDJD, [In] float3 IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 NLDCBNJOJLC(Entity KELHIEHPDJD);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IDDOCCIMBDN(Entity KELHIEHPDJD, [In] quaternion IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion OKBHPHBMLNP(Entity KELHIEHPDJD);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FEDGIGFPGHC(Entity KELHIEHPDJD, [In] float3 EBGKGBGFPOC, [In] quaternion KDHLIJMPIFF);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDIJCGHIEMH(Entity KELHIEHPDJD, [Out] RigidTransform PDJEAGKDAOH);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NHAKFAHIIPP(Entity KELHIEHPDJD, [In] float3 EBGKGBGFPOC, [In] quaternion KDHLIJMPIFF);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DJIPOHPDFOF(Entity KELHIEHPDJD, [Out] float3 EBGKGBGFPOC, [Out] quaternion KDHLIJMPIFF);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DJIPOHPDFOF(Entity KELHIEHPDJD, [Out] RigidTransform PDJEAGKDAOH);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HHIFHNHBHJH(Entity KELHIEHPDJD, float IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float KMHIFFBFEKD(Entity KELHIEHPDJD);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AGEBFAMGLLK(Entity KELHIEHPDJD, [In] float3 IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 HJCMKJOKKEB(Entity KELHIEHPDJD);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ICBNHGBBDHE(Entity KELHIEHPDJD, [In] quaternion IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion OCNAHOBEBOC(Entity KELHIEHPDJD);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NPCLOGOIKDF(Entity KELHIEHPDJD, float IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float OKBFNHIILNP(Entity KELHIEHPDJD);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KELBPIJLGME(Entity KELHIEHPDJD, [Out] float4x4 KPOFKEGGPLL);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EEPHOOEAJNL(Entity KELHIEHPDJD, [In] float4x4 KPOFKEGGPLL);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CKBJLGGGJHL(Entity KELHIEHPDJD);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AEGKMDAOMDC(Entity KELHIEHPDJD, Entity BECJAAKDIOB, Entity BKAKGIFOLLC);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class PBHKEFALJPL
{
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KGBEBGKEIFG
{
	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPGFKJGFGGD(bool CMNHCHIKDKP);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HIFCFPPLBEL
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADLNJLFFKMN(GOLADBGGMAB GNMFDIECOJL, FHHKDIEHOCM<string> LHCAACJBMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKKNMPLMMFH(GOLADBGGMAB GNMFDIECOJL, FHHKDIEHOCM<string> LHCAACJBMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LJMMGOECFLJ(GOLADBGGMAB GNMFDIECOJL, FHHKDIEHOCM<string> LHCAACJBMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJBIFFDCCKA(GOLADBGGMAB GNMFDIECOJL, FHHKDIEHOCM<string> LHCAACJBMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GDLPDHOOJAA(GOLADBGGMAB GNMFDIECOJL, FHHKDIEHOCM<string> LHCAACJBMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KGGGECFGCCA(GOLADBGGMAB GNMFDIECOJL, FHHKDIEHOCM<string> LHCAACJBMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KOGPMIOOJBP(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int BODAGJHLFDN(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int AJNBIPJOHNL(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FNGMMGDEDMM<string> LFBLHHMCCDE(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EMFFBBPCBDJ(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FNGMMGDEDMM<string> LABBMJFHPEN(GOLADBGGMAB GNMFDIECOJL);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KEDGBMDOEHL(GOLADBGGMAB GNMFDIECOJL, string MIMAHBNFICG);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void INMFNKNDEOF(string MIMAHBNFICG, MFGLPJADLCK AKJOOBIDGDC);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GOLADBGGMAB PKMBJHJEHED(string MIMAHBNFICG);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ADPAIKGLFBC(string MIMAHBNFICG, MFGLPJADLCK AKJOOBIDGDC);

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MJGKABJHLCP(GOLADBGGMAB MODKGHJLBCJ, string MIMAHBNFICG, MFGLPJADLCK AKJOOBIDGDC);

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FNGMMGDEDMM<string> KPGJLBICNAK();
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class NECNBLBBHKA
{
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IBIFECKIOKM
{
	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World GNINHEFFPPB(string BDPODADANCP = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World NAOKMMKGIDF(string BDPODADANCP = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World JNHLLMKLMCE(string BDPODADANCP = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World MJKBJCOINDK(string BDPODADANCP = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AIMNAMMCJGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	World EIOLCIKBDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	World BCPOKEPMAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	EntityManager GLANLJGHLBG
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	bool EMJBEIDFIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase COBDFDLLGJA(Type BJLNCBFOGNL);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class PIOHMLCJFCN
{
	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x835C830", Offset = "0x835B830", VA = "0x18835C830")]
	public static ComponentSystemBase MNIFDHFBJBE(this World BABHHEKHGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x3E3AB40", Offset = "0x3E39B40", VA = "0x183E3AB40")]
	public static T COBDFDLLGJA<T>(this AIMNAMMCJGJ EBELPLDOAKG) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AHCJGLMLMNE
{
	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONIFNDKFIFE(NativeListAsync<Entity> OCPHIJFFIPA);

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOEMJPBBIGI(KCKPHCPINBD LGDEHGMAOJO);

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PHHNPCJDLIL(NativeListAsync<Entity> BJODOHECKNE, bool LHLJLBIDLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKAAHHCADOC();

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LMLHHOOMJEI(Entity NKBKNNLLHKF);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BPONEBCIIEL
{
	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGMEIIAANLH(Collider EPMKKDPDDLB, [Out] OLKICMIFJOM OBBBPBKBCBI);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ECMDBAEGKKP
{
	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider ELMJBDKOLEG(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject PEPNJKBEJDM(GOLADBGGMAB GKDLJLOJJJI, GameObject OCKHDKNFOGO, Vector3 GKANPAILENO, Quaternion MMKPIDNBBJN);

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKBIOBFKHKH(GameObject EPMKKDPDDLB);

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider CFPJMHCBGAG<TCollider>(GameObject CNDMEACPBMJ) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPDMDNOCPAE(Collider EPMKKDPDDLB);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject EPDBCOAJLGA<TCollider>(string HJLBILHBIIC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DEFFNBOFLAG AFPIFDABLFE(GOLADBGGMAB OPDNBCOIBPM, GOLADBGGMAB MKOCGHJHFHO, GOAIGCDFKPE MAIGNAMLPPM, float3 GFMFHEBIHDK, quaternion BHCGOOKHLEO, float3 IJEEPFLDOFC);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JODEIPBDHKO(GOLADBGGMAB MPAKEJAFLKL, [Out] DEFFNBOFLAG EPMKKDPDDLB);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LJLELEFPMPL(GOLADBGGMAB MPAKEJAFLKL, [Out] GOLADBGGMAB NKBKNNLLHKF);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public enum MJBNPLDIADP
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LNHIHKHCOML
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public struct FBLFCEHKDAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int MAIGNAMLPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GameObject OCKHDKNFOGO;
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDHCGBEKMJD(GOLADBGGMAB MPAKEJAFLKL, PMKMCFAPLLD HHNMHOKMOHP, bool BOPEANDLKEI, MOLPEGLCKDH NBGFGBJKABJ);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIFLCFMPIKH(GOLADBGGMAB MPAKEJAFLKL, PMKMCFAPLLD HHNMHOKMOHP, bool BOPEANDLKEI, bool KDMHNGGBLHA, bool PEKMCLDMBPF);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MDANFCHPFMJ AHLHPMIGMGL(GOLADBGGMAB NKBKNNLLHKF, List<GOLADBGGMAB> JIKNBNCBHKB);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DEFFNBOFLAG HLCECOCIKMK(GameObject CMKEBPKLJJL, GameObject NCFDIDOGPOD);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFCEOGHHOIP(GameObject CMKEBPKLJJL, List<GameObject> HLHNCPEGDKJ);

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFBEDOPCPOC(GameObject NCFDIDOGPOD);

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T CFPJMHCBGAG<T>(GameObject CNDMEACPBMJ) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LPDMDNOCPAE(Collider EPMKKDPDDLB);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject GLHILMNGHMA<T>(string HJLBILHBIIC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HDDEIDFCEKO(Collider EPMKKDPDDLB, [Out] GOLADBGGMAB FICFFHNKAMC);

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool APMINEJIGPD(GOLADBGGMAB MPAKEJAFLKL, [Out] OLKICMIFJOM OBBBPBKBCBI);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<MJBNPLDIADP> ELAINFEHGEA(Allocator FKPBEKMFPLB = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] NALFPHDPCJE();
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DFCBFNPFHHH
{
	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDMFDANLNLE(GOLADBGGMAB MPAKEJAFLKL, GOLADBGGMAB IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABLMAADCNKL(GOLADBGGMAB MPAKEJAFLKL, GOLADBGGMAB IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HFOKGGNPAIL(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GOLADBGGMAB NNOGBOEKNJK(GOLADBGGMAB MPAKEJAFLKL, int HLGKMAPOEBE);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CMDLBMCKJFH CIKICDAIHCK(GOLADBGGMAB MPAKEJAFLKL, Allocator FKPBEKMFPLB = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NEAPGLDLGIP(GOLADBGGMAB MPAKEJAFLKL, object GFDDDAIMFOH, GOLADBGGMAB IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IDPBPKJHEGJ(GOLADBGGMAB MPAKEJAFLKL, object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FHAHPOIFPNH(GOLADBGGMAB MPAKEJAFLKL, [Out] GOLADBGGMAB IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OCMDPBDNEAI(GOLADBGGMAB MPAKEJAFLKL, float3 IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AAIELDAKHCF(GOLADBGGMAB MPAKEJAFLKL, [Out] float3 IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PKNAIJJDAKC(GOLADBGGMAB MPAKEJAFLKL, float3 IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FFDJDFAHNJI(GOLADBGGMAB MPAKEJAFLKL, [Out] float3 IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CDPMCCLDBAA(GOLADBGGMAB MPAKEJAFLKL, (Quaternion rot, Vector3 moments) MOHIENDLLGP);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GGKPEMBAFLD(GOLADBGGMAB MPAKEJAFLKL, [Out] quaternion FKHDNOPJIJO, [Out] float3 MEADFAGBIAC);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JPOCJOHNHGJ(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 FNABOBIFDEL(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 APHBBCBPINJ(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KKICFOKLGNE(GOLADBGGMAB MPAKEJAFLKL, float3 IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HCBGLHCCFBM(GOLADBGGMAB MPAKEJAFLKL, float3 IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float JIMBILAGEEA(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float IKLHEGLLJKC(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BBAHPGEOOEP(GOLADBGGMAB MPAKEJAFLKL, float IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ACFDPDFMBGF(GOLADBGGMAB MPAKEJAFLKL, float IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode IABIMEPBAFK(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LNLJHMAIODG(GOLADBGGMAB MPAKEJAFLKL, CollisionDetectionMode IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JEHFMNHABAI MEHPNEAOJJM(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DMNGONBADBE(GOLADBGGMAB MPAKEJAFLKL, JEHFMNHABAI IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool HHAHMLKPEOF(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JEJPLJHGGLM(GOLADBGGMAB MPAKEJAFLKL, bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(Slot = "29")]
	GOLADBGGMAB FLHBHPPGFKB(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void LMOJMGNNABN(GOLADBGGMAB MPAKEJAFLKL, GOLADBGGMAB IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	GOLADBGGMAB GHBGGJNGHEC(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void AKCKLCNBHIA(GOLADBGGMAB MPAKEJAFLKL, GOLADBGGMAB IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	PCMEBGNJIKH AALIGGBDAGB(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void AHJHDBDAOHE(GOLADBGGMAB MPAKEJAFLKL, PCMEBGNJIKH ELGDGMOPDKC);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool GADOEJIOCEK(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void KLIAGMBDDDJ(GOLADBGGMAB MPAKEJAFLKL, bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool AEGMNDFDJDH(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void LMDADEEBPPL(GOLADBGGMAB MPAKEJAFLKL, bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints BLMBFHJCPKL(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void ABHEDOEJANF(GOLADBGGMAB MPAKEJAFLKL, RigidbodyConstraints IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float GJDIMFFLNCC(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void HBFFDPHBLFH(GOLADBGGMAB MPAKEJAFLKL, float IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float IIGMLHNCJGM(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void IBKLNJFBFJH(GOLADBGGMAB MPAKEJAFLKL, float IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool ABDAMPHGHCL(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void JODHJOIEHDG(GOLADBGGMAB MPAKEJAFLKL, bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool LLLMGKCLDKP(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void OBAPJPKGPGM(GOLADBGGMAB MPAKEJAFLKL, bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void KNJLCLDGMNJ(GOLADBGGMAB MPAKEJAFLKL, int IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "50")]
	CJDPDAAMOBM BBHINIHAEJI(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void NOCKIBJNILN(GOLADBGGMAB MPAKEJAFLKL, CJDPDAAMOBM IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	NEPEHFKKAHG NHGKIIHCCAA(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void FHIEPPDNABN(GOLADBGGMAB MPAKEJAFLKL, NEPEHFKKAHG IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float EBGLEAKPLNM(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void NGNFPOOPCAO(GOLADBGGMAB MPAKEJAFLKL, float IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void EGNLEKOLGEN(GOLADBGGMAB MPAKEJAFLKL, object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void IDOKALJKLPA(GOLADBGGMAB MPAKEJAFLKL, object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool LHFLBGJOHLN(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void FAKBAMJKDMH(GOLADBGGMAB MPAKEJAFLKL, object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void JCODEDAPAKJ(GOLADBGGMAB MPAKEJAFLKL, object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool APLIAAPGGIO(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool EJKPLGEINDP(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody MBJIFNJNBNN(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void HIFJMIPEKBG(GOLADBGGMAB MPAKEJAFLKL, Rigidbody OJLJIHMPMHO);

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void CDDNPCBBODL(GOLADBGGMAB MPAKEJAFLKL, object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void MDHCFFHBIKL(GOLADBGGMAB MPAKEJAFLKL, object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool PBDMFNKEKBC(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void NJIDKCHOJGI(GOLADBGGMAB MPAKEJAFLKL, float3 PJFEPLADHFM);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void AKEPPIKJDPM(GOLADBGGMAB MPAKEJAFLKL, float3 MPLOLODGAEG);

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool GFOCBFOLNAP(GOLADBGGMAB MPAKEJAFLKL, [Out] float3 PJFEPLADHFM);

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool LGKOPEIJPMC(GOLADBGGMAB MPAKEJAFLKL, [Out] float3 MPLOLODGAEG);

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool HBGAICGJHMM(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void KKFOGMKEMAF(GOLADBGGMAB MPAKEJAFLKL, object GFDDDAIMFOH, bool NALIKJHDOEC);

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void OBLPFHKHCKK(GOLADBGGMAB MPAKEJAFLKL, bool GONMDHOBGEG);

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void NAEKFLLGIHH(GOLADBGGMAB MPAKEJAFLKL);

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool DNACCENHGMO(GOLADBGGMAB MPAKEJAFLKL);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EIPJHOBGDJD
{
	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBJCPBFODOG(Entity MLJJJMJNICP);

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAMBJOEKCEP(Entity MLJJJMJNICP);

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPHPFBOGCEB(Entity MLJJJMJNICP);
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KEKEOBFOFFF
{
	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPLNPOHEOOG(GOLADBGGMAB AOJAHPGAGPO, bool GLANDDNNPLP);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public delegate void AOPMFIAGPKB(IGJODJAMKLB HGPGFBEMKAG);
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly ref struct IGJODJAMKLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly CMDLBMCKJFH MPIEFLFKCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly NativeArray<byte> PGAEDBIFHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly NativeArray<byte> DFNOKPMEGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly PEDOGLOKHKA EKGLNGMKMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly int CJPCGOGOHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly Type ENLLGBMKCKL;

	[Cpp2IlInjected.Token(Token = "0x17000208")]
	public CMDLBMCKJFH DMLHKJEMHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x5444600", Offset = "0x5443600", VA = "0x185444600")]
		get
		{
			return default(CMDLBMCKJFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000209")]
	public int BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x834F5D0", Offset = "0x834E5D0", VA = "0x18834F5D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	public PEDOGLOKHKA JFAMMMJCEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570")]
		get
		{
			return default(PEDOGLOKHKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x834F5F0", Offset = "0x834E5F0", VA = "0x18834F5F0")]
	public IGJODJAMKLB(CMDLBMCKJFH MPIEFLFKCKM, NativeArray<byte> PGAEDBIFHEJ, NativeArray<byte> DFNOKPMEGNH, PEDOGLOKHKA EKGLNGMKMKH, int CJPCGOGOHBH, Type ENLLGBMKCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4920", Offset = "0x3CA3920", VA = "0x183CA4920")]
	public NativeArray<T> GKIHADAELGF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x3CA48E0", Offset = "0x3CA38E0", VA = "0x183CA48E0")]
	public NativeArray<T> EBGMBDDBDIG<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4960", Offset = "0x3CA3960", VA = "0x183CA4960")]
	public (CMDLBMCKJFH, NativeArray<T>, NativeArray<T>) LMKONLJOAEP<T>() where T : struct
	{
		return default((CMDLBMCKJFH, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x834F5A0", Offset = "0x834E5A0", VA = "0x18834F5A0")]
	public HEPEIBDNAPC KJGBNEIHOAK()
	{
		return default(HEPEIBDNAPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface NJOCMHCEGDM
{
	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	string DLKAONPBBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	NJOCMHCEGDM APLIPOIIECD
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	IEnumerable<NJOCMHCEGDM> BKFCGKHJPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DHHFDHJFGCN
{
	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	NJOCMHCEGDM APKOHLAJBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	NativeArray<PEDOGLOKHKA> IAKIBCIJNHO
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JICEBLABAAJ(PEDOGLOKHKA EKGLNGMKMKH, [Out] NJOCMHCEGDM HNLEHANEADB);

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AMNFOKHCMAP(PEDOGLOKHKA EKGLNGMKMKH, AOPMFIAGPKB HCFNMKLGLDB);

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBLNIGGOIJH(PEDOGLOKHKA EKGLNGMKMKH, AOPMFIAGPKB HCFNMKLGLDB);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GOMJCBGPGNE
{
	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMNFOKHCMAP(PEDOGLOKHKA EKGLNGMKMKH, AOPMFIAGPKB HCFNMKLGLDB);

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBLNIGGOIJH(PEDOGLOKHKA EKGLNGMKMKH, AOPMFIAGPKB HCFNMKLGLDB);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class MBECLBMJDCA
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BIDEHNPHCNI
{
	[Cpp2IlInjected.Token(Token = "0x17000210")]
	bool PEHMBEOPBMG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	EABPHDOEJHN EKCBCBBMLDL
	{
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMHAIHBFNCO(HDLEPENBPIC CLCJHDIBCKB, bool AJHEJGICEEK);

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OGNAPKDCEBG(AGKIKBEKNMF CLCJHDIBCKB, PEDOGLOKHKA EKGLNGMKMKH);

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GAIANONBAPH(NativeArray<AGKIKBEKNMF> KFBDGCKNDBG);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class DKINOHFAGGO
{
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public readonly ref struct HEPEIBDNAPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly IGJODJAMKLB INCJDDLACNP;

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public CMDLBMCKJFH DMLHKJEMHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x5444600", Offset = "0x5443600", VA = "0x185444600")]
		get
		{
			return default(CMDLBMCKJFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x834ED50", Offset = "0x834DD50", VA = "0x18834ED50")]
	public HEPEIBDNAPC(IGJODJAMKLB INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x834E930", Offset = "0x834D930", VA = "0x18834E930")]
	public CMDLBMCKJFH GKIHADAELGF()
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x834E800", Offset = "0x834D800", VA = "0x18834E800")]
	public CMDLBMCKJFH EBGMBDDBDIG()
	{
		return default(CMDLBMCKJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x834EA60", Offset = "0x834DA60", VA = "0x18834EA60")]
	public (CMDLBMCKJFH, CMDLBMCKJFH, CMDLBMCKJFH) LMKONLJOAEP()
	{
		return default((CMDLBMCKJFH, CMDLBMCKJFH, CMDLBMCKJFH));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class EFFKDCNJKGG
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public readonly struct EABPHDOEJHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly NativeBitArray MFEJNKDJAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly NativeParallelHashMap<AGKIKBEKNMF, int> LNICJMENPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly NativeParallelHashSet<HDLEPENBPIC> LBINPDLMPKM;

	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public bool NBOBGJMBGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x834B090", Offset = "0x834A090", VA = "0x18834B090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public bool PEHMBEOPBMG
	{
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x834AE70", Offset = "0x8349E70", VA = "0x18834AE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x60740D0", Offset = "0x60730D0", VA = "0x1860740D0")]
	public EABPHDOEJHN(NativeBitArray MFEJNKDJAID, NativeParallelHashMap<AGKIKBEKNMF, int> LNICJMENPFP, NativeParallelHashSet<HDLEPENBPIC> LBINPDLMPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x834AEA0", Offset = "0x8349EA0", VA = "0x18834AEA0")]
	public bool OGNAPKDCEBG(AGKIKBEKNMF CLCJHDIBCKB, PEDOGLOKHKA EKGLNGMKMKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NAJHLIHKOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	CIMLIBKMPND GJJNMLHFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DLKBDHPNALP
{
	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FKLGACALKCL(GOLADBGGMAB MPAKEJAFLKL, FPIECMLDEPF IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FGANHAMJGGJ NCELEGDFKAD();
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OFEPDFNKNDL
{
	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDCMJBCBPGI(World BABHHEKHGKC);

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEMHMGEHHCH(World BABHHEKHGKC);

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase BFHIHMGHAAM(World BABHHEKHGKC);

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDIPNJBCINA(World BABHHEKHGKC);

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLGHMEPKGCK(World BABHHEKHGKC);

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FEPDGENAJGP(World BABHHEKHGKC);

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MLBINOBNFAL(World BABHHEKHGKC);

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> NJBGHOGOJIN();
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JBLPNFMGFEF
{
	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPOCACGEPGD(GOLADBGGMAB NCIBPMAFIKA, bool IOALKPFEKEK);
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public readonly struct PAGHMHPKLIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly IEnumerable<HNBGDDENOFI> EJNMOKIGKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly IReadOnlyList<GameObject> JKCFMGDPDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly IReadOnlyList<int> GAGINIFNOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly IReadOnlyList<(AGKIKBEKNMF, AGKIKBEKNMF)> OCLPBCBCLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly int GBFAIMIIMEJ;
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public struct IBPBJLNPKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public InventionIdData PBJHGGBBAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public InventionInstanceIdData BMDBNKCBFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public bool JFAHGIFDBKL;

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x834F460", Offset = "0x834E460", VA = "0x18834F460")]
	public IBPBJLNPKII(long PBJHGGBBAAF, Guid BMDBNKCBFCK, bool JFAHGIFDBKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[ServiceLifetime(Lifetime.Application)]
public interface DDOPFJHAODP
{
	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OIAGCHHJHPN IBPOPKCDFMK(KKPOINACGCE IAGPPAMHECH, int MAENJMKCDDI = 0, bool MBBJOKMGCIH = false);

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OJGFONBOJAD OPJNGGCEFKN(KKPOINACGCE IAGPPAMHECH, GOLADBGGMAB EBJBKAEFOPM, [In] UniformTRS NPGDNLIDGBP, JOLCCMOHKAD MBADOCGINHK, [Optional] IBPBJLNPKII KAOCMGEBHGG, bool JFAPLMGPAID = true, bool PFGJHMINFFD = false, bool MBBJOKMGCIH = false, bool MLLKGPMOGJN = false);

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GOKPJJJKKPM PLLJCIECFHO();

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GOKPJJJKKPM JODDCOBJOPE(CMDLBMCKJFH IGGAEBJHGKC, [In] UniformTRS IFPOALOHCCN, [Optional] JOLCCMOHKAD IFPFNELJAFI);

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NENBNENPAFN(GOLADBGGMAB OLAHFGCFBNE);

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OFCJONBFELB(GOLADBGGMAB OLAHFGCFBNE, [Out] Exception JNADAKHBCKJ);

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<AGKIKBEKNMF> LOBNILGLDHJ(GOLADBGGMAB OLAHFGCFBNE, Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<AGKIKBEKNMF> GGCFDMIECJC(GOLADBGGMAB OLAHFGCFBNE, Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CMDLBMCKJFH LDOPAGOJFKL(GOLADBGGMAB OLAHFGCFBNE, Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CMDLBMCKJFH AIJAHKPAAIK(GOLADBGGMAB OLAHFGCFBNE, Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CMDLBMCKJFH MFMFBNPPODL(GOLADBGGMAB OLAHFGCFBNE, Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> GEGFCDJDBJD(GOLADBGGMAB OLAHFGCFBNE, Allocator FKPBEKMFPLB);

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BDECMEGLGHL(GOLADBGGMAB OLAHFGCFBNE);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int ADDCNMIBFHH(GOLADBGGMAB OLAHFGCFBNE, int MFFPIAPMHCN);
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[ServiceLifetime(Lifetime.Application)]
public interface KLNNDINKLGO
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0xF1F780", Offset = "0xF1E780", VA = "0x180F1F780", Slot = "0")]
	bool AGIMFBCEFJB(object PHDJPEOAFMD, PJEMIAGADJB PJGOCFNEGCL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public static class KBAKHDAMJCB
{
	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x8350560", Offset = "0x834F560", VA = "0x188350560")]
	public static bool AGIMFBCEFJB(this KLNNDINKLGO JMELKBNBGDN, object PHDJPEOAFMD, [Out] PJEMIAGADJB PJGOCFNEGCL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public enum GEBELDOKJEP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface PJEMIAGADJB
{
	[Cpp2IlInjected.Token(Token = "0x17000216")]
	HGJJHEKNHLL HHDOJPCILPE
	{
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	DOHKIBLNJFC BEDFELGNCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	bool CILHAGGMFND
	{
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	bool KAJEJHPNJKN
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object FGNMCPKHBLJ();

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x1065960", Offset = "0x1064960", VA = "0x181065960", Slot = "5")]
	(DOHKIBLNJFC, Dictionary<object, object>) DMCOONEKPKE()
	{
		return default((DOHKIBLNJFC, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "6")]
	(AGKIKBEKNMF, DOHKIBLNJFC) NFGIALALIMM()
	{
		return default((AGKIKBEKNMF, DOHKIBLNJFC));
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "7")]
	OBBFKFHHJAB<(AGKIKBEKNMF, DOHKIBLNJFC)> FLNBKFHAKCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x1065960", Offset = "0x1064960", VA = "0x181065960", Slot = "8")]
	(HGPLMIJAIIE, byte[]) IBINJHNEDEA()
	{
		return default((HGPLMIJAIIE, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x1065960", Offset = "0x1064960", VA = "0x181065960", Slot = "9")]
	(KIHNPHHCPLP, byte[]) NLDEOIIGBPJ()
	{
		return default((KIHNPHHCPLP, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x1065960", Offset = "0x1064960", VA = "0x181065960", Slot = "10")]
	T BDGECBGONFO<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public static class DJBOAFCEHME
{
	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x834AAF0", Offset = "0x8349AF0", VA = "0x18834AAF0")]
	public static bool EDIHJOEIBBM(this PJEMIAGADJB NPMBPMNFANE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface DICBHMKMBFE : OBBFKFHHJAB<BJLFHMKMEJE>
{
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[DefaultMember("Item")]
public interface OBBFKFHHJAB<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	T LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	int BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public enum HGJJHEKNHLL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RR_MasterLockBlockComplete = 27,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RR_NetworkSynchronization = 28,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	RR_NetworkInstantiate = 29,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	RR_BulkInstantiate = 31,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	RR_Destroy = 32,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	RR_BulkDestroy = 33,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	RR_TransferOwnership = 34,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	RR_OwnershipUpdate = 35,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	RR_RPC = 36,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	RR_JoinRequest = 100,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	RR_JoinResponse = 101,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	RR_RoomUpdate = 102,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	RR_PlayerUpdate = 103,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	RR_RemotePlayerJoined = 104,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	RR_RemotePlayerLeft = 105,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	RR_Leave = 106,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public enum HGPLMIJAIIE : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public static class IBMECHMEBJB
{
	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x834F190", Offset = "0x834E190", VA = "0x18834F190")]
	public static AGKIKBEKNMF NDGGFBMFNOD(this LAKFIGAHNCB INCJDDLACNP)
	{
		return default(AGKIKBEKNMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x834EEE0", Offset = "0x834DEE0", VA = "0x18834EEE0")]
	public static AGKIKBEKNMF ECKEDIPPJAF([In] this LAKFIGAHNCB INCJDDLACNP)
	{
		return default(AGKIKBEKNMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x82CAF40", Offset = "0x82C9F40", VA = "0x1882CAF40")]
	public static AGKIKBEKNMF EJJOIGGNDNE(this LAKFIGAHNCB INCJDDLACNP)
	{
		return default(AGKIKBEKNMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x82CAF40", Offset = "0x82C9F40", VA = "0x1882CAF40")]
	public static ViewId BJMPAJFOIAO(this LAKFIGAHNCB INCJDDLACNP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x834EFC0", Offset = "0x834DFC0", VA = "0x18834EFC0")]
	public static FixedString64Bytes LCCIGCPNKHD(this HDLEPENBPIC PBJHGGBBAAF)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x834F1D0", Offset = "0x834E1D0", VA = "0x18834F1D0")]
	public static FixedString64Bytes PJMKPNMAOIH(this AGKIKBEKNMF PBJHGGBBAAF)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x834EF30", Offset = "0x834DF30", VA = "0x18834EF30")]
	public static FixedString32Bytes LCCIGCPNKHD(this Entity KELHIEHPDJD)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BCMFMEKENDK : POFIOECFANB
{
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public enum DMEPNHPDEMB
{
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JIAHAALABFH
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<object> JIFJPMGEONP;

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "2")]
	void HNMLPLBLIIH(object PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "3")]
	void NHNAJMJCGHG(KIHNPHHCPLP MKOOPFGGHLN, ReadOnlySpan<byte> MBAGIDFJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	void OHNCELPNPKF(HGPLMIJAIIE BJLNCBFOGNL, ReadOnlySpan<byte> MBAGIDFJGJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BEJPHNEDAEM
{
	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KIHNPHHCPLP ENCPCDELFCJ(ReadOnlySpan<byte> MBAGIDFJGJL);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JNHCHHCBMCK
{
	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHALJBEAONO(KIHNPHHCPLP DAKIIEIEKNI, ReadOnlySpan<byte> MBAGIDFJGJL);

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCDNIGMNHGL(ReadOnlySpan<KIHNPHHCPLP> BJIFFGJCJNL);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct LENBFADCIIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public KIHNPHHCPLP MKOOPFGGHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public ReadOnlyMemory<byte> MBAGIDFJGJL;
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct KIHNPHHCPLP
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static KIHNPHHCPLP HJJEACOAFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public HDLEPENBPIC BHCELHKNNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public int FMMEMKBNLCB;

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public static HDLEPENBPIC FKBBBOCHIDA
	{
		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x8350900", Offset = "0x834F900", VA = "0x188350900")]
		get
		{
			return default(HDLEPENBPIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x5443B50", Offset = "0x5442B50", VA = "0x185443B50")]
	public KIHNPHHCPLP(HDLEPENBPIC BHCELHKNNAD, int FMMEMKBNLCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x8350AD0", Offset = "0x834FAD0", VA = "0x188350AD0")]
	public static bool PHGIAKEDBEK([In] KIHNPHHCPLP MLCJFBKFHOP, [In] KIHNPHHCPLP FPNPAOBAPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x8350950", Offset = "0x834F950", VA = "0x188350950", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x8350A60", Offset = "0x834FA60", VA = "0x188350A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x8350B60", Offset = "0x834FB60", VA = "0x188350B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x8350AC0", Offset = "0x834FAC0", VA = "0x188350AC0")]
	public void HBLCGHBNJLA([Out] HDLEPENBPIC AEOGCMBMFHO, [Out] int FMMEMKBNLCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public static class FLHGBLAEKLM
{
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public struct HNBGDDENOFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Guid JFLBGDIIGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public string NIMMNBBALAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Vector3 EBGKGBGFPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public Quaternion KDHLIJMPIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Vector3 AJNABLFIHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public int KADDMNKEMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public ENKCMKGNHEJ OGEALFKCCAP;

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x834EDC0", Offset = "0x834DDC0", VA = "0x18834EDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public enum NAJBGDCPILA
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public static class HJCFFGGEHHO
{
	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x834ED80", Offset = "0x834DD80", VA = "0x18834ED80")]
	public static bool EJEDMDCCHIC(this NAJBGDCPILA BJLNCBFOGNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x834EDB0", Offset = "0x834DDB0", VA = "0x18834EDB0")]
	public static bool NLNKOFGLLNK(this NAJBGDCPILA BJLNCBFOGNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x834EDA0", Offset = "0x834DDA0", VA = "0x18834EDA0")]
	public static bool JDPBFMJBLLB(this NAJBGDCPILA BJLNCBFOGNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
[Flags]
public enum OIPHLPPCHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public interface JOLCCMOHKAD
{
	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FHNBINMJCKD([In] Guid BKFMBMLFOLE, [Out] Guid HCPHGFGFIBL);
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[Flags]
public enum MNCCKEJMPNO
{
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public interface GOKPJJJKKPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	HJOAMFNHALA CHPADODGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString NJACMFLLBKA();
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public enum JLKCAKEEBMM
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct FLMGEJNGJIB : ISystemStateComponentData, IComponentData, IEquatable<FLMGEJNGJIB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public float3 MADKGCPLBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public float3 EBBJCPOEOII;

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x834C7D0", Offset = "0x834B7D0", VA = "0x18834C7D0", Slot = "4")]
	public bool Equals(FLMGEJNGJIB EDJHHGMLKFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LGCDPGHHJKB
{
	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<GOLADBGGMAB> ABAJEJBKIGF(GOLADBGGMAB JPAJKPMDGBM);

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NFMKMMFKKFI(GOLADBGGMAB GCHDBACKAFI, [Out] GOLADBGGMAB OHCPHOABIKP);
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DIPCJNCDCGE
{
	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HHGAJDLOJDC(long GOECKJMEMHG);

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFFLEJNCKJK(NativeParallelHashSet<long> BODHJDHANFB);

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJHAFJDJCJH(World BABHHEKHGKC, NativeParallelHashMap<Guid, long> HOMJBGPHGCH);

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PLCKCICOMGK(AGKIKBEKNMF CLCJHDIBCKB);

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AMGGOIHCGHN(AGKIKBEKNMF CLCJHDIBCKB, [Out] Guid FEMPMECOKGA, [Out] long GOECKJMEMHG);

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDKNOBKBKJL(AGKIKBEKNMF CLCJHDIBCKB, Guid FEMPMECOKGA, long GOECKJMEMHG);

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HNGONACLHNL(Guid FEMPMECOKGA);

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EKOPJAPELPP(Guid FEMPMECOKGA, [Out] int IPACIMACHKH, [Out] int CEMGCIJHNFA);

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CDCHGILIMFK(Guid FEMPMECOKGA, int IPACIMACHKH, int CEMGCIJHNFA);

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KPLKFFMBDML(Guid FEMPMECOKGA);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class HLGNEFPMHEK
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HLGNEFPMHEK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
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
