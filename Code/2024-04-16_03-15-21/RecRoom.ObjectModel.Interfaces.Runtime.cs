using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : JICBOCPMGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x621C180", Offset = "0x621B380", VA = "0x18621C180", Slot = "4")]
		public override void OEPCKJDAMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LMPPHJHCOEP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x621BED0", Offset = "0x621B0D0", VA = "0x18621BED0")]
	public static void IKMNMNJHBHK(this Rigidbody NOEDFAGHGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x621C050", Offset = "0x621B250", VA = "0x18621C050")]
	public static void IKMNMNJHBHK(this Rigidbody NOEDFAGHGPJ, Vector3 AOGDKHLEHDL, Quaternion GJPAPHHKJEL, Vector3 ONIPNNLIOAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct BECPEMBNPON : IReadOnlyList<AGNLOFKLMDO>, IEnumerable<AGNLOFKLMDO>, IEnumerable, IReadOnlyCollection<AGNLOFKLMDO>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct OKKAKKFPOAD : IEnumerator<AGNLOFKLMDO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly MMHEDGNKOFC LONGGHDKNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator BJFMPKFKBNE;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AGNLOFKLMDO KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x621E2D0", Offset = "0x621D4D0", VA = "0x18621E2D0", Slot = "4")]
			get
			{
				return default(AGNLOFKLMDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x621E250", Offset = "0x621D450", VA = "0x18621E250", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D43260", Offset = "0x3D42460", VA = "0x183D43260")]
		public OKKAKKFPOAD(MMHEDGNKOFC LONGGHDKNBH, NativeArray<LocalId>.Enumerator BJFMPKFKBNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x621E190", Offset = "0x621D390", VA = "0x18621E190", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x621E1D0", Offset = "0x621D3D0", VA = "0x18621E1D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x621E210", Offset = "0x621D410", VA = "0x18621E210", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly MMHEDGNKOFC LONGGHDKNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> BFPFIMOOKDF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AGNLOFKLMDO KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x620EC80", Offset = "0x620DE80", VA = "0x18620EC80", Slot = "4")]
		get
		{
			return default(AGNLOFKLMDO);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x620E5E0", Offset = "0x620D7E0", VA = "0x18620E5E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int MEIHDGGDAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int OECJFLODMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool AKDOKGLOPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x620E6D0", Offset = "0x620D8D0", VA = "0x18620E6D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> PPGALIPGBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x233F370", Offset = "0x233E570", VA = "0x18233F370")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> ONGMECNCPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x620E670", Offset = "0x620D870", VA = "0x18620E670")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x620EA30", Offset = "0x620DC30", VA = "0x18620EA30")]
	public BECPEMBNPON(int ONEEJBCNCKG, MMHEDGNKOFC LONGGHDKNBH, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D428D0", Offset = "0x3D41AD0", VA = "0x183D428D0")]
	public BECPEMBNPON(MMHEDGNKOFC LONGGHDKNBH, NativeArray<LocalId> BFPFIMOOKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x620EB60", Offset = "0x620DD60", VA = "0x18620EB60")]
	internal BECPEMBNPON(MMHEDGNKOFC LONGGHDKNBH, NativeArray<Entity> GKCCDIIKKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x620EAC0", Offset = "0x620DCC0", VA = "0x18620EAC0")]
	public BECPEMBNPON(MMHEDGNKOFC LONGGHDKNBH, int EAMNBPDOIFO, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x620EBD0", Offset = "0x620DDD0", VA = "0x18620EBD0")]
	public BECPEMBNPON(BECPEMBNPON NPEHHLPNINL, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x620E7A0", Offset = "0x620D9A0", VA = "0x18620E7A0")]
	public BECPEMBNPON OGEBIAEMLFN(Allocator HOJMCOLANAB = Allocator.Temp)
	{
		return default(BECPEMBNPON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x620E630", Offset = "0x620D830", VA = "0x18620E630", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x620E710", Offset = "0x620D910", VA = "0x18620E710")]
	public OKKAKKFPOAD LEPKJMNOIOO()
	{
		return default(OKKAKKFPOAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x620E850", Offset = "0x620DA50", VA = "0x18620E850", Slot = "6")]
	private IEnumerator<AGNLOFKLMDO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x620E940", Offset = "0x620DB40", VA = "0x18620E940", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct PBNLPMHODPJ : IList<AGNLOFKLMDO>, ICollection<AGNLOFKLMDO>, IEnumerable<AGNLOFKLMDO>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct LLCDMGKGJDF : IEnumerator<AGNLOFKLMDO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MMHEDGNKOFC LONGGHDKNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator BJFMPKFKBNE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AGNLOFKLMDO KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x621BE80", Offset = "0x621B080", VA = "0x18621BE80", Slot = "4")]
			get
			{
				return default(AGNLOFKLMDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x621BE00", Offset = "0x621B000", VA = "0x18621BE00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D43260", Offset = "0x3D42460", VA = "0x183D43260")]
		public LLCDMGKGJDF(MMHEDGNKOFC LONGGHDKNBH, NativeArray<LocalId>.Enumerator BJFMPKFKBNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x621BD40", Offset = "0x621AF40", VA = "0x18621BD40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x621BD80", Offset = "0x621AF80", VA = "0x18621BD80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x621BDC0", Offset = "0x621AFC0", VA = "0x18621BDC0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MMHEDGNKOFC LONGGHDKNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> BFPFIMOOKDF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AGNLOFKLMDO KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x621F180", Offset = "0x621E380", VA = "0x18621F180", Slot = "4")]
		get
		{
			return default(AGNLOFKLMDO);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x621F200", Offset = "0x621E400", VA = "0x18621F200", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x621ED20", Offset = "0x621DF20", VA = "0x18621ED20", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OECJFLODMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x621ED20", Offset = "0x621DF20", VA = "0x18621ED20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool APKLFGKPCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x621F0F0", Offset = "0x621E2F0", VA = "0x18621F0F0")]
	public PBNLPMHODPJ(MMHEDGNKOFC LONGGHDKNBH, int EAMNBPDOIFO, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x621EB60", Offset = "0x621DD60", VA = "0x18621EB60")]
	public BECPEMBNPON IEPODCHFPKP()
	{
		return default(BECPEMBNPON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x621E900", Offset = "0x621DB00", VA = "0x18621E900", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x621E940", Offset = "0x621DB40", VA = "0x18621E940", Slot = "13")]
	public bool Contains(AGNLOFKLMDO KBNEJAIFICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x621E9D0", Offset = "0x621DBD0", VA = "0x18621E9D0", Slot = "14")]
	public void CopyTo(AGNLOFKLMDO[] BLGDAGLONDD, int IMCGHBJCPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x621E880", Offset = "0x621DA80", VA = "0x18621E880", Slot = "11")]
	public void Add(AGNLOFKLMDO KBNEJAIFICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x621EC70", Offset = "0x621DE70", VA = "0x18621EC70", Slot = "7")]
	public void Insert(int MBGANDEDPDN, AGNLOFKLMDO KBNEJAIFICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x621EE40", Offset = "0x621E040", VA = "0x18621EE40", Slot = "15")]
	public bool Remove(AGNLOFKLMDO KBNEJAIFICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x621EBE0", Offset = "0x621DDE0", VA = "0x18621EBE0", Slot = "6")]
	public int IndexOf(AGNLOFKLMDO KBNEJAIFICP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x621EDF0", Offset = "0x621DFF0", VA = "0x18621EDF0", Slot = "8")]
	public void RemoveAt(int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x621EB20", Offset = "0x621DD20", VA = "0x18621EB20", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x621ED60", Offset = "0x621DF60", VA = "0x18621ED60")]
	public LLCDMGKGJDF LEPKJMNOIOO()
	{
		return default(LLCDMGKGJDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x621EF10", Offset = "0x621E110", VA = "0x18621EF10", Slot = "16")]
	private IEnumerator<AGNLOFKLMDO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x621F000", Offset = "0x621E200", VA = "0x18621F000", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HGIPHEDPPNH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int NMOKMHFMOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> AFBLMGAMJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AGNLOFKLMDO JLLNCOJGLKE(AGNLOFKLMDO BFPFIMOOKDF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AMAFCGANNJO : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface HHHPAGOBGDI : DCBPLICMNAO, ELDNEGPEECB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool OIOOJDHLJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CGMAJAEAEJJ JAGNHMLLLAK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JDPFHCBGGGM HMODOJNAIAD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	DBJHLPJFGDP FFEJIFDKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	CNJOHBKENBE HGCIKDABNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	CKCDBEIANKF LMEHALHIPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface ELDNEGPEECB
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EJECNOODHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface OELIGICEGAG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDDBOENJANG(bool EKDDCPALANJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface CNJOHBKENBE
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool EMFKJLAANOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PJMGGOGPJBN;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJGJMHKGMBJ(bool KIOKGDOKJKG);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CBEIDNACNJJ(ByteString DKCIFBLHDJF);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FOLLBCHFBLH();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMILHPGENLJ();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MKJLKGBKMPE();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface DBJHLPJFGDP
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	NKHDFGLOEFE JAGNHMLLLAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	JDPFHCBGGGM HMODOJNAIAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	AMEEJEIIGMP HCFKHMINHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	HHHPAGOBGDI CPELHDNMJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	EGKJBCGMGIF JGPHNJNADEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	PLFDPOJPHML IBEPOCJIONO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BFKODGMLOLD AAJBPCEAMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	FAEFGOJFLLJ KLENMBGAOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IOFEDJDHMMM JCPGCBIGKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	AIIAOOMOJOP JOJHJNFAEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	PHGKBBFKJJG MFJMPFPCGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	EJPJAAMGIMB NMGHFDPKJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	KPBJKBJABEC IIOLOHAADCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	BGIFFHFHMPI FDCNBFOCNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CBAJJGAKEPF FHAPPKDBBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ICJJEBPEMBG KAONBKIKAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LBIDLJNDDLP EPLNHJDOGON
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	OJEBNOLMNLL BLCGLJMDDKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NHMJMDDCKMN ADBEGPOAIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	DJFPAENAPEE PFCCBEJCNLE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	FGOFALKPMHH HIFGOFFCJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BEPMHNBAGLF EAPOMIKCJPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	HDJHFBBDMDN KGOBANDOLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	NONBDFGJCBB OCJNLFBFNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerTypeProxy(typeof(JAPMFIHHCHN))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct AGNLOFKLMDO : IComparable<AGNLOFKLMDO>, IEquatable<AGNLOFKLMDO>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly AGNLOFKLMDO BMBGBFLCPKI;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int GLABGJEKKDJ = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int NFFMBEEOGLN = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int HGMBCJJMHJN = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int JFJFCLHGCEA = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId NAJMDMAIPJN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public HHHPAGOBGDI CPELHDNMJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x620DD20", Offset = "0x620CF20", VA = "0x18620DD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LocalId NDGGPJGFNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x620E0B0", Offset = "0x620D2B0", VA = "0x18620E0B0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal CKCDBEIANKF LMEHALHIPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x620E150", Offset = "0x620D350", VA = "0x18620E150")]
		get
		{
			return default(CKCDBEIANKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool BFJAEMLKAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x620DB00", Offset = "0x620CD00", VA = "0x18620DB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool ABGPICJINHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x620DAB0", Offset = "0x620CCB0", VA = "0x18620DAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x620E2B0", Offset = "0x620D4B0", VA = "0x18620E2B0")]
	public AGNLOFKLMDO(MMHEDGNKOFC OMBABBDEGEJ, LocalId NAJMDMAIPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
	public MMLCOCHHNEC AIEHFMFMNMG()
	{
		return default(MMLCOCHHNEC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x620E030", Offset = "0x620D230", VA = "0x18620E030")]
	public static LocalId GEOGJCANPGE(AGNLOFKLMDO GFOEGHIPLHN)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x620E070", Offset = "0x620D270", VA = "0x18620E070")]
	public static Entity GEOGJCANPGE(AGNLOFKLMDO GFOEGHIPLHN)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x620DF10", Offset = "0x620D110", VA = "0x18620DF10")]
	public static bool FPIEKNKMEBM(AGNLOFKLMDO LLLCBODKBAN, AGNLOFKLMDO HIOEJKGFIKI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x620E160", Offset = "0x620D360", VA = "0x18620E160")]
	public static bool LEBDJINPIPG(AGNLOFKLMDO LLLCBODKBAN, AGNLOFKLMDO HIOEJKGFIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x620E180", Offset = "0x620D380", VA = "0x18620E180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x620DD80", Offset = "0x620CF80", VA = "0x18620DD80", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x620DC40", Offset = "0x620CE40", VA = "0x18620DC40", Slot = "4")]
	public int CompareTo(AGNLOFKLMDO MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "5")]
	public bool Equals(AGNLOFKLMDO MEJMHKPOODP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ANJOHHAIPFD
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x620E530", Offset = "0x620D730", VA = "0x18620E530")]
	public static HGKLNILLMDD IGLNFABEDOF(this AGNLOFKLMDO GLMGCMELGFD)
	{
		return default(HGKLNILLMDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x620E470", Offset = "0x620D670", VA = "0x18620E470")]
	public static MMLCOCHHNEC FDAOBAIMKAK(this AGNLOFKLMDO GLMGCMELGFD, [Optional] object GMMJMENGHCD)
	{
		return default(MMLCOCHHNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2EADFB0", Offset = "0x2EAD1B0", VA = "0x182EADFB0")]
	public static T KOIBKAIHOKJ<T>(this AGNLOFKLMDO GLMGCMELGFD) where T : struct, CJAKPFKCCCM
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class JAPMFIHHCHN
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct CKCDBEIANKF : IEquatable<CKCDBEIANKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte OEHGECKOHPK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] EPHAEIHNJPP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static MMHEDGNKOFC IKIDHDFNMMD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static HHHPAGOBGDI AOANKPMCHNM;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static MMHEDGNKOFC[] KNOGFIGPOMI;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static HHHPAGOBGDI[] OLOLGIKJCMO;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> OGEGLIKDENP;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public HHHPAGOBGDI CPELHDNMJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x620F7F0", Offset = "0x620E9F0", VA = "0x18620F7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public MMHEDGNKOFC DCIDCPNEECN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x620FCF0", Offset = "0x620EEF0", VA = "0x18620FCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x62103C0", Offset = "0x620F5C0", VA = "0x1862103C0")]
	static CKCDBEIANKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xCC1420", Offset = "0xCC0620", VA = "0x180CC1420")]
	internal CKCDBEIANKF(byte EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5437640", Offset = "0x5436840", VA = "0x185437640", Slot = "4")]
	public bool Equals(CKCDBEIANKF MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x620FC40", Offset = "0x620EE40", VA = "0x18620FC40", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1B6FB70", Offset = "0x1B6ED70", VA = "0x181B6FB70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6210300", Offset = "0x620F500", VA = "0x186210300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x620FF40", Offset = "0x620F140", VA = "0x18620FF40")]
	private static MMHEDGNKOFC NFMHNJPAILH(byte OEHGECKOHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x620F560", Offset = "0x620E760", VA = "0x18620F560")]
	private static HHHPAGOBGDI AGGPBFDEBDD(byte OEHGECKOHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x620FDD0", Offset = "0x620EFD0", VA = "0x18620FDD0")]
	private static object MGCLLEEDNNJ(byte OEHGECKOHPK, object[] DBIFCPFENHC, object LKGDLFBLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x620F8D0", Offset = "0x620EAD0", VA = "0x18620F8D0")]
	private static int DCHNMHHLHDN(byte OEHGECKOHPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x620FCE0", Offset = "0x620EEE0", VA = "0x18620FCE0")]
	private static int HBDKKJFOMOL(byte OEHGECKOHPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6210280", Offset = "0x620F480", VA = "0x186210280")]
	private static (int, int) PCIILLGDLKL(byte OEHGECKOHPK)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x620FF30", Offset = "0x620F130", VA = "0x18620FF30")]
	private static byte MHKBFGLFNCJ(int BKPHPJDBECD, int MBGANDEDPDN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x620FFE0", Offset = "0x620F1E0", VA = "0x18620FFE0")]
	internal static CKCDBEIANKF OEPCKJDAMHI(HHHPAGOBGDI JNAHJKIJJGJ, MMHEDGNKOFC OADIIMIEPCB)
	{
		return default(CKCDBEIANKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x620F600", Offset = "0x620E800", VA = "0x18620F600")]
	internal static void CIPMPDGKPOP(CKCDBEIANKF OEHGECKOHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x620F8E0", Offset = "0x620EAE0", VA = "0x18620F8E0")]
	private static void DMECMAGAENG(int ONEEJBCNCKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface KCLNJKCOJDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLGFIHJIJDC();

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLENLDFDABD(bool OKPFLLJLOKK);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIDKKIEFIKP(GameObject CHIOFKOKCNE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface GNJBONPADDC
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	Guid KCLCCOAMNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GPGJAEAGBFM(Guid ECBFONKGJMK, Guid FANHKHJHPNO);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DDLCDBFJDEK(AGNLOFKLMDO ICFPGPNLGKJ);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CACPOPPFBJL(AGNLOFKLMDO MMGOAMJJJHK, AGNLOFKLMDO DLAKBCKOLFN, [Out] Vector3 CCDONDNKELE, [Out] Quaternion CHNFMIDIJDA);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BHGDNHMEOPK(MILALCFMIAA JLMKBLBFANB, Vector3 CCDONDNKELE, Quaternion CHNFMIDIJDA);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAADKDNFENF(AGNLOFKLMDO ILGJGLAIMLG, [Out] Vector3 GAJKAAONFMC, [Out] Quaternion KHOCHFIODMB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface HFDCOAPGKMP
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDLCLEHGAKB(BECPEMBNPON BFPFIMOOKDF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface HJIJKAFDINN
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IBLBBIPGJPE(GameObject KFLBCBDMLNI, GameObject GJGEPCFNCIO, int HDIDPBFFDAK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface JDPFHCBGGGM
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	KCLNJKCOJDJ CJPCLDIMGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	NCMOJGHMFDH IHIAMJFDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	OKMEEDNDMLI IAHELLAFDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	CEHLPDFKPFD HECPAGFOOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	DOKAMFFCCCC BLEBBHIKLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	HBHPDDHDFPH IBMCCJJPODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	LOAHHLFGGAH IJJDCJHFDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AMAABJJIJBK OIJEIKCDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface GIDMFIIKPNE
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDOJIOBHADL(Action OFOIHENMFDE, bool GJNGCNLHLGD);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IMGHGJJLFHI(string MPENHPFDCDK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface NCMOJGHMFDH
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string FLLMBBMMHEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] ABFDDFBLEEL(IEnumerable<CMIMPALJGEM> EGLPPHANCHG);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCAPHJJOEKL(GameObject CHIOFKOKCNE, [Out] HGKLNILLMDD[] PHIPEPCMJME);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMAOEJEELBF(GameObject CHIOFKOKCNE, [Out] int POPPJBFFBML, [Out] AIMLLPOCAAB BCOGJAIKHDP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CHDOFPFNIMP EHJDHEKGABF(CMIMPALJGEM NOGNLJBIFAF);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CHDOFPFNIMP EHJDHEKGABF(string OGBJKBBFCCI, HGKLNILLMDD[] AIBJMECNKIH, Vector3 JCMPCLFLJHD, Quaternion ECLCOOPOABI, Vector3 OFBFBKPELML);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject GGLBGOPAHNI(string OGBJKBBFCCI);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PEFCGGAMEOE(GameObject HINGGGIAHGP, bool IKGCBKDCEAJ);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GNMMDJLBECN(GameObject CHIOFKOKCNE, bool OEOBMNLEEIM, bool HNADNNENHBE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class NLGOGLGGOPM
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x621DF40", Offset = "0x621D140", VA = "0x18621DF40")]
	public static CHDOFPFNIMP EHJDHEKGABF(this NCMOJGHMFDH CHEOCJAKLBN, Vector3 JCMPCLFLJHD, Quaternion ECLCOOPOABI, Vector3 OFBFBKPELML, params HGKLNILLMDD[] PHIPEPCMJME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface OKMEEDNDMLI
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALFNGOMHHCC(bool KIOKGDOKJKG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface CEHLPDFKPFD
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool BNAJMMHKCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool MPGNAPCPHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool BFEMGDPJNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int NDMOMLDIJON
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DLABFKEGMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JFMGMHKCHDI(object JAHJOCBHFCP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FMLMPCOJIHO(object JAHJOCBHFCP);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NPAMCMLMLGC(object JGFCAMDGBLE);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HIPDHGKMKAE(object JGFCAMDGBLE);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int CDMJPKPFEGD(GameObject LPJEIMNEFOH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PIJNLDOFJJK(NativeArray<int> PHOLPEBPELA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JMCKMCCEOKC(NativeArray<int> JPJPGANMOHO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BDHHKFKFKGN();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GJNBCHDHKEB(uint GMJCNHOFLBK, ReadOnlySpan<byte> ODMILHAFPBG, bool JFOJDENEALE = false);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GJNBCHDHKEB(uint GMJCNHOFLBK, ReadOnlySpan<byte> ODMILHAFPBG, ReadOnlySpan<byte> IIPPKLFNGDA, bool JFOJDENEALE = false);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface DOKAMFFCCCC
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCGPCOILCEA(GameObject CHIOFKOKCNE);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface NEJMHEEDLAA
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIFNGLLNDOF(string FFDOAJJEAOK);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface LOIFHBJJCDG
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DCBFCGIHJON(GameObject CHIOFKOKCNE);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBCGLJAJICI(GameObject CHIOFKOKCNE);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CICIMBKKFBN(int KGKDPPPPNGC);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object HBOLCPPDKCK(AGNLOFKLMDO NAJMDMAIPJN, GameObject CHIOFKOKCNE, Action<AGNLOFKLMDO, int> CMMPHMKBCDC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ACEMICAEIKP(GameObject CHIOFKOKCNE, object LJLKGGOBCGO);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface NHFLHHALECK
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool EMBMMGAIENA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate LOCMKLLHCJL(IALFPKMPKCJ.KHEPGOCDKEB NJNKDGKCMKA, Action<IALFPKMPKCJ.KHEPGOCDKEB> CMMPHMKBCDC);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HGFEFHDAHGL(IALFPKMPKCJ.KHEPGOCDKEB NJNKDGKCMKA, Delegate CMMPHMKBCDC);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate NLIMAOKLDAB(IALFPKMPKCJ.KHEPGOCDKEB NJNKDGKCMKA, Action<IALFPKMPKCJ.KHEPGOCDKEB> BAMLFMDOGDJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FKIKHCAAOIL(IALFPKMPKCJ.KHEPGOCDKEB NJNKDGKCMKA, Delegate CMMPHMKBCDC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OGNGDDIFAPG(IALFPKMPKCJ.KHEPGOCDKEB NJNKDGKCMKA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IALFPKMPKCJ.KHEPGOCDKEB JHNJCOENFOP(GameObject CHIOFKOKCNE);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface HBHPDDHDFPH
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	int DODMADJIEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	int MCJIKBLAHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int AIAKOLCIGBB(GameObject CHIOFKOKCNE);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OJJIGHEFOCK([Out] Vector3 JCMPCLFLJHD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDFKPAIIAGM();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface LOAHHLFGGAH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool EMFKJLAANOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool CIBICEGGBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface NGLHIHIHKIK
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	GAFEFIOOPCM CCENHAFOHID
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	GLAEAADPLNP PLFKKFKGIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IJALNJOFJJO(Transform DIFJEPLFOKN);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NABCNLJNOMO(Transform DIFJEPLFOKN, FACIIGAFJII IOFKPDJOAJC);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EPOOJNEJKIE(Transform DIFJEPLFOKN, NJFLAEHPIGP NBINPNLDMFM);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface AMAABJJIJBK
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMJJDCPNKOM();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface FJOJPDHJOJF
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGKEMLOLEIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface EAHEHLHBLGC
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIMLLPOCAAB KEAHMHABDBH(GameObject LPJEIMNEFOH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAIBPNLDIKL(GameObject CHIOFKOKCNE, OBPHPMOBDFL PCIOINBFOJO, OLHAMEMJPND NOMEHGJACMG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string BEAMOEDOLMB(int POAELFIOKHK);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MLNOBJHAGOM(string KLOCHNOKOMB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDKFPPLCAHL(AGNLOFKLMDO NAJMDMAIPJN, int[] GIDCLHMBPPO);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CGHLODNIEHP(InteractionFilterData MJGHOBDIDHD, int BJLBPPPFCJE);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PBOHOLNELDO(AGNLOFKLMDO NAJMDMAIPJN, int GIDCLHMBPPO);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JAKEPFIFKJB(AGNLOFKLMDO NAJMDMAIPJN, int GIDCLHMBPPO);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AIBJBBJPABN(AGNLOFKLMDO NAJMDMAIPJN, bool BFIDGNPLEMC, float3 COEFDBHFAEF, quaternion GJFOMDHLDHG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct JIKLEBKBLOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly NBDBEPLCEBF GGLMJACONBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly NBDBEPLCEBF HOMODAIKDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint GLBDOLFONED;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6217340", Offset = "0x6216540", VA = "0x186217340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct AIJIGPIOIMD
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly IOBNAOMELJK AOBMECMACLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly JIKLEBKBLOP OFOIHENMFDE;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x620E3E0", Offset = "0x620D5E0", VA = "0x18620E3E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct NMGJPFMBHGE
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly IOBNAOMELJK AOBMECMACLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly JIKLEBKBLOP OFOIHENMFDE;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x620E3E0", Offset = "0x620D5E0", VA = "0x18620E3E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct HPKBCINLHIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint GLBDOLFONED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool JCPAAJEFHPD;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x62172A0", Offset = "0x62164A0", VA = "0x1862172A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NBDBEPLCEBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int BMIAFODFMCE;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x621DD90", Offset = "0x621CF90", VA = "0x18621DD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface CDKLMHFEEOF
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	DPIIAJCEMJJ IKPJPNOOGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum OPGAOBFAPNC
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Legacy,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CHDOFPFNIMP : PMKLDKOBKFL
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	OPGAOBFAPNC KIEECJNHIND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool ADNPONFMEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	GameObject CHIOFKOKCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CHDOFPFNIMP> CJDBPOOJPFJ;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(AMEEJEIIGMP OLJBLBEHIAE, AGNLOFKLMDO GEOEMCBJEIM);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool EIKEKLNMLCL);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class LHGBLGLLLEM
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x621BC10", Offset = "0x621AE10", VA = "0x18621BC10")]
	public static bool GJPBCHCNHKJ(this CHDOFPFNIMP FIPFEJOGMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x621BBC0", Offset = "0x621ADC0", VA = "0x18621BBC0")]
	public static bool COODJGAGGLD(this CHDOFPFNIMP FIPFEJOGMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x621BC60", Offset = "0x621AE60", VA = "0x18621BC60")]
	public static bool HEKMJGDCGOD(this CHDOFPFNIMP FIPFEJOGMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x621BCB0", Offset = "0x621AEB0", VA = "0x18621BCB0")]
	public static bool OIOOJDHLJDP(this CHDOFPFNIMP FIPFEJOGMMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface PMKLDKOBKFL
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool HKJFMKICGME
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
internal interface NHIMPOMIGBC
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<KDLBOGHAELH> CGMDCHFHIBE;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface OEHIAEEMGIJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface OKPBDEPHLPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(POKMEHNCJBC BNFGBEBAHAB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface POKMEHNCJBC
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	GameObject CHIOFKOKCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Transform DIFJEPLFOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	MPABILDJPPM KKFHAAAMDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool MHGJEPJCAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGENMMFMJBA(MPABILDJPPM HMEKKAINJCD);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MPABILDJPPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Rigidbody LKJEANBPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	POKMEHNCJBC MCBNKDJJGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	GameObject MCONHIMIFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	Transform MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	MPABILDJPPM IIBNAPJLELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	MPABILDJPPM NECEBBLCHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	int FKDINEDDBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool OGNGDDIFAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool AHBMMBODCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	AEELDBJLIOI OCIHGIEMFAF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	OFDDOEGADFI AOGLCJHKNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	float PKPAGNEHHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Vector3 MLDNALOKFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	Vector3 BIKJNHHJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	Vector3 HEGJMPMNGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 OOBKCEPGDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool KLJNFPNIMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool FIABCHJOGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool LABKLHCLHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 OACIIGEFMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 GNCLKAIHHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 CMPINJFJFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 DGCOODKILIE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float CEFKOHHOLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float IDCMHAOKCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 MOMIPLEMDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Quaternion JHJINPPHKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float NNIBHOHJPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float OOLIMOECINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool FGLBIDFCLGD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	DOAGAABAFKI DCLHOBDFJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool DMFCIKABDOL
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Transform MPPFKJCEGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 JCMLCJJMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float OFEANHDOONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float GCFGGEMOFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Quaternion OGJCDKOFEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 LBCBIKCAOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Quaternion HLNGFPFIIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	RigidbodyConstraints HKEHMJBNHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool CKEOACICAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	CollisionDetectionMode EDHBGNGDFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool CLLNGBLDHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event DJPOHPOJKMP MIKEDADMJIE;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DJPOHPOJKMP IKFDKBDLEKJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event DJPOHPOJKMP PFJLKPMAOJM;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event DJPOHPOJKMP CBFNHGBDHGO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event DJPOHPOJKMP KLHHGNIABHH;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event DJPOHPOJKMP MNJPFKICJGN;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event DJPOHPOJKMP OEFIGOGDIMI;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event MBDFLHOAEJJ ECCHALHHPCJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<LABHNEIMMOD, LABHNEIMMOD> IFDAOOPJMGM;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MPABILDJPPM FMAHEHLKPDM(int MBGANDEDPDN);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void HMFLODDFELK((Quaternion rot, Vector3 moments) OBCPHNOEGPK);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void NLCNDFBLMIC();

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void BOGHDHHJJEF();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void ELEABJCGEHG();

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void CMLPDOPBLNJ();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void DPPHNCDDAIK(MPABILDJPPM EKDDCPALANJ, bool DJPOIHCPABJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void MCLCMPHELAM(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void KHLIHLENIEO(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 BJBEJCNBCNB(Vector3 NIPPPODPAFG);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 DEGALIMHJLI(Vector3 KAIPEFHNECD);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void GJGAKFBBGJK();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void JIBBBIAEOBJ();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void ABFEFKGBJEG();

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void LBIFKLFNFJM(Vector3 ADCGEFMCJOH, Vector3 EGBIJKDMLFI);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void KAOOKPDMDAH(Vector3 FBFKKIJADKF, Vector3 MLKEHNHJPMP);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void GACEHJBOCDE(Vector3 LIEBIHNKIND);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void GDMKGLIKMNN(IFIOCMHLOGF OOJJGDDKMPH, Vector3 NKPBIBGIGIC, float FDGBHJOLFOB, float KCMPEKMFBNO = 8f, float MLECCBHOGPH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void KONHEMLLAAO(MIGAFPNFDBJ AAJGHHOMLEP, Vector3 CGOPPOICKIH, float AHDEBMHEIKE = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void BMADFLFMOBL(MIGAFPNFDBJ AAJGHHOMLEP, Vector3 ECLCOOPOABI, float CMFBFEMGGMP = 7f, float HHEHPPDENGJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 AFNHCCJOILN(Vector3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 CLCBFIDAFJA(Vector3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void AMIMOGILGBF();

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void GEHOFEDEDAB(MPABILDJPPM OFEKIDOIODB, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void PJOGHJMIMBC(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void OGIIBBJKPBG();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void KEJBHMJHIGD();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void HMHJBGCCKEF();

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool NMGHIDBNOPP();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void ODJKIEDOKDA();

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void LNJEKJEBIAF(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void AOEMMMCOGNB(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void DDGDJJIOCAK(object GMMJMENGHCD, bool AHPGPMLNBDI);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void PADFEOACABO(Vector3 BBIPDCGGCJI, Quaternion HDGDBKNDAGC);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void NLNKIPBMLCK(Vector3 KNIDEDNJIKD, Quaternion IINALNNAGOL);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool IGOMPGANJPA(float GGHLFGGDEEP);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void KNCHCJPNICA(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void FBOLFKCDDHF(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void FGGEPJLINMM(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void EAPMHAHADDB(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void FOFFMCNJKFD(Vector3 HLOIBGCELIK, ForceMode CEHCIFMOKCP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void GMMBJLBFGNI(Vector3 HLOIBGCELIK, Vector3 JCMPCLFLJHD, ForceMode CEHCIFMOKCP);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void MKPNHPKHKJI(Vector3 OAMGOONLJPM, ForceMode CEHCIFMOKCP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void EHMIPAHPANM(Vector3 OAMGOONLJPM, ForceMode CEHCIFMOKCP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool IMBEONMFNPO(Vector3 HIMAANDEJKI, [Out] RaycastHit HAENHELGKML, float NHMHEGFGMMF);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void HEBNFIPHGLG();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface OFDDOEGADFI
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNAPKDEOOKE(Vector3 NMGJCNGLHKM);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJCDPEFJJNA(Vector3 DIDBDFPOMNO);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJOKICPAPFH(Vector3 NMGJCNGLHKM);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DGPDAGIPFOJ(Vector3 DIDBDFPOMNO);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface AEELDBJLIOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FBJACNMIAPG();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 KKLDNPIJPEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public delegate void DJPOHPOJKMP(POKMEHNCJBC KKAHOGBEBJH);
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum JFLCCJDNJKD
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum IFIOCMHLOGF
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public delegate void MBDFLHOAEJJ(POKMEHNCJBC KKAHOGBEBJH, bool DJPOIHCPABJ = false);
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum MIGAFPNFDBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct GFEFICMLNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Rigidbody KIMBNNEGFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object NDMFFPNMIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 ACMNOFBFEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector3 AECMCLOEGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public BKKIHAGPCJF ACJKHHABOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool JGFLMNGHONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool OMBIPDCGDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool EPHGAPDCDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public bool GCADBBGHKAL;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface JONOMCDBBJG : CKHOKMGGIKM<HGKLNILLMDD>, HEFFKAOIEGK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HKJHCLLAHCL<T> : DEIOKIHDGIN<HGKLNILLMDD, T>, CKHOKMGGIKM<HGKLNILLMDD>, HEFFKAOIEGK, IDisposable, JONOMCDBBJG where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LAIHONDDAFG
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x29077E0", Offset = "0x29069E0", VA = "0x1829077E0")]
	public static bool AMEEOJPNNKO<T>(this CKHOKMGGIKM<HGKLNILLMDD> BMIMCNPMKAE, HGKLNILLMDD AIBJMECNKIH, [Out] T EKDDCPALANJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x271E970", Offset = "0x271DB70", VA = "0x18271E970")]
	public static bool HPPDEOLAJNB<T>(this CKHOKMGGIKM<HGKLNILLMDD> BMIMCNPMKAE, HGKLNILLMDD AIBJMECNKIH, [In] T CICAFALGPCA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface KHGPLBOIDDA : CKHOKMGGIKM<AGNLOFKLMDO>, HEFFKAOIEGK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface IIFKNLBAEGA<T> : DEIOKIHDGIN<AGNLOFKLMDO, T>, CKHOKMGGIKM<AGNLOFKLMDO>, HEFFKAOIEGK, IDisposable, KHGPLBOIDDA where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class ABONDHKPKNG
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x271E600", Offset = "0x271D800", VA = "0x18271E600")]
	public static T CEIMJGKDJPN<T>(this CKHOKMGGIKM<AGNLOFKLMDO> BMIMCNPMKAE, AGNLOFKLMDO NAJMDMAIPJN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x271E990", Offset = "0x271DB90", VA = "0x18271E990")]
	public static bool HPPDEOLAJNB<T>(this CKHOKMGGIKM<AGNLOFKLMDO> BMIMCNPMKAE, AGNLOFKLMDO NAJMDMAIPJN, [In] T CICAFALGPCA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct LFBHDOENOPD : IComparable<LFBHDOENOPD>, IEquatable<LFBHDOENOPD>
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly LFBHDOENOPD BMBGBFLCPKI;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly LFBHDOENOPD OPMEAEACPHO;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly LFBHDOENOPD FKBEFAFGDNA;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LFBHDOENOPD PKANLJGHKDP;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly LFBHDOENOPD MDMFJCHFDNP;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly LFBHDOENOPD OHLNBMKMGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int ABDHHHCLNNL;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool DKFIHEOEDAH
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x621B000", Offset = "0x621A200", VA = "0x18621B000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int NODDNNKNOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x621B0F0", Offset = "0x621A2F0", VA = "0x18621B0F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0")]
	public LFBHDOENOPD(int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x621B090", Offset = "0x621A290", VA = "0x18621B090", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x621B010", Offset = "0x621A210", VA = "0x18621B010", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x88E910", Offset = "0x88DB10", VA = "0x18088E910", Slot = "5")]
	public bool Equals(LFBHDOENOPD MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x18B2650", Offset = "0x18B1850", VA = "0x1818B2650", Slot = "4")]
	public int CompareTo(LFBHDOENOPD MEJMHKPOODP)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0xD898F0", Offset = "0xD88AF0", VA = "0x180D898F0")]
	public static LFBHDOENOPD GEOGJCANPGE(int MBGANDEDPDN)
	{
		return default(LFBHDOENOPD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0xD898F0", Offset = "0xD88AF0", VA = "0x180D898F0")]
	public static int GEOGJCANPGE(LFBHDOENOPD KCCIKABICGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x621B100", Offset = "0x621A300", VA = "0x18621B100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct MMLCOCHHNEC : IEquatable<MMLCOCHHNEC>, PMKLDKOBKFL
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly MMLCOCHHNEC AKKMIDDBLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0", Slot = "6")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public JMHJLFKAJBI MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(JMHJLFKAJBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public LFGCBCHGHNJ JGPHNJNADEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(LFGCBCHGHNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public GameObject CHIOFKOKCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x621D5C0", Offset = "0x621C7C0", VA = "0x18621D5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public HGKLNILLMDD KBAHLHLMEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x621D310", Offset = "0x621C510", VA = "0x18621D310")]
		get
		{
			return default(HGKLNILLMDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public PLJJEACEGHF DJPKPGEDJFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x621CE40", Offset = "0x621C040", VA = "0x18621CE40")]
		get
		{
			return default(PLJJEACEGHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public AIMLLPOCAAB OIDAIJAIBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x621D3B0", Offset = "0x621C5B0", VA = "0x18621D3B0")]
		get
		{
			return default(AIMLLPOCAAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool IPKAEKNJFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x621D180", Offset = "0x621C380", VA = "0x18621D180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool EFKIACLIDOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x621D030", Offset = "0x621C230", VA = "0x18621D030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool KOJMPNKKLMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x621D560", Offset = "0x621C760", VA = "0x18621D560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool EEMKOEMJLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x621CEE0", Offset = "0x621C0E0", VA = "0x18621CEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool MOLAKJODBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x621CE20", Offset = "0x621C020", VA = "0x18621CE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool FFHEEKFHAMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x621D4B0", Offset = "0x621C6B0", VA = "0x18621D4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool AGGBGFDMOFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x621CFF0", Offset = "0x621C1F0", VA = "0x18621CFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool DIFJAPDKNHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x621D4F0", Offset = "0x621C6F0", VA = "0x18621D4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool GIMDKEJJCDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x621D490", Offset = "0x621C690", VA = "0x18621D490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public AFKJLKPMKEG AEEAPDHNGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AFKJLKPMKEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public PANLIPMEAPH PPDINFKLGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(PANLIPMEAPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public EOCCDKOCHGD NMGHFDPKJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(EOCCDKOCHGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public GPJMAGEBNLL JIKMGKDAKKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(GPJMAGEBNLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public EDOGIONHDBN MFJMPFPCGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(EDOGIONHDBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public NAOMBJMLKOF DBNDCCCOBBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(NAOMBJMLKOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public MILALCFMIAA AKGKNONCCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MILALCFMIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public ONNKPMAJEIA JJNCGJFFNMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(ONNKPMAJEIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public KCGKPAJLFLE DCJHGBHAKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(KCGKPAJLFLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public JLADFKMBDMG GFDIFCJFLOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(JLADFKMBDMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool GJPBCHCNHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x621CF00", Offset = "0x621C100", VA = "0x18621CF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool EPLCGKPHOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x621D580", Offset = "0x621C780", VA = "0x18621D580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool JOPLEBDCHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x621D450", Offset = "0x621C650", VA = "0x18621D450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private bool JNGIPGLBLOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public MMLCOCHHNEC(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6210FB0", Offset = "0x62101B0", VA = "0x186210FB0")]
	public static bool GEOGJCANPGE(MMLCOCHHNEC EKDDCPALANJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static AGNLOFKLMDO GEOGJCANPGE(MMLCOCHHNEC EKDDCPALANJ)
	{
		return default(AGNLOFKLMDO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6210F00", Offset = "0x6210100", VA = "0x186210F00")]
	public static bool FPIEKNKMEBM(MMLCOCHHNEC LLLCBODKBAN, MMLCOCHHNEC HIOEJKGFIKI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x620E160", Offset = "0x620D360", VA = "0x18620E160")]
	public static bool LEBDJINPIPG(MMLCOCHHNEC LLLCBODKBAN, MMLCOCHHNEC HIOEJKGFIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x621D050", Offset = "0x621C250", VA = "0x18621D050", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(MMLCOCHHNEC MEJMHKPOODP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static MMLCOCHHNEC GEOGJCANPGE(AGNLOFKLMDO HPEEIPMMJAC)
	{
		return default(MMLCOCHHNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x621D1A0", Offset = "0x621C3A0", VA = "0x18621D1A0")]
	public EDKOPDLLMBF FLKIEHAODEI()
	{
		return default(EDKOPDLLMBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x621D530", Offset = "0x621C730", VA = "0x18621D530")]
	public HKBIDKCKJBJ NJGHMLFDFFA()
	{
		return default(HKBIDKCKJBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x621CDD0", Offset = "0x621BFD0", VA = "0x18621CDD0")]
	public EFLGGPGGBGJ BFAJAAKFPLN()
	{
		return default(EFLGGPGGBGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x621D0E0", Offset = "0x621C2E0", VA = "0x18621D0E0")]
	public void FDAOBAIMKAK([Optional] object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x621CCE0", Offset = "0x621BEE0", VA = "0x18621CCE0")]
	public bool AGNDAEKGPCO(object GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x621D220", Offset = "0x621C420", VA = "0x18621D220")]
	public bool HBMGCGILGNN(object GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x621D750", Offset = "0x621C950", VA = "0x18621D750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct MILALCFMIAA : IEquatable<MILALCFMIAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private DBJHLPJFGDP FFEJIFDKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x621C360", Offset = "0x621B560", VA = "0x18621C360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private CBAJJGAKEPF NLJHDLFOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x621C3F0", Offset = "0x621B5F0", VA = "0x18621C3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool ILKCAHHGNCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x621CA00", Offset = "0x621BC00", VA = "0x18621CA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public Guid AFOAALLAALN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x621C570", Offset = "0x621B770", VA = "0x18621C570")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool OJDIMKDBKLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x621C4E0", Offset = "0x621B6E0", VA = "0x18621C4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Guid OLKFFDNLIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x621C8E0", Offset = "0x621BAE0", VA = "0x18621C8E0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public MILALCFMIAA(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6210FB0", Offset = "0x62101B0", VA = "0x186210FB0")]
	public static bool GEOGJCANPGE(MILALCFMIAA EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x621C450", Offset = "0x621B650", VA = "0x18621C450", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(MILALCFMIAA MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x621C7B0", Offset = "0x621B9B0", VA = "0x18621C7B0")]
	public bool KEECFKDDHJD([Out] Guid KEAGJDNLFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x621CA90", Offset = "0x621BC90", VA = "0x18621CA90")]
	public void NOLKEDKJAFN(Guid FKBAIKAGEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x621CBB0", Offset = "0x621BDB0", VA = "0x18621CBB0")]
	public bool OBFKPANPGOH([Out] Guid MBBENIIFGEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x621C690", Offset = "0x621B890", VA = "0x18621C690")]
	public void INJHICHIJHN(Guid FKBAIKAGEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x621C850", Offset = "0x621BA50", VA = "0x18621C850")]
	public void LAMEBGMBLMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct EFLGGPGGBGJ : IEquatable<EFLGGPGGBGJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private DBJHLPJFGDP FFEJIFDKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6214500", Offset = "0x6213700", VA = "0x186214500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private ICJJEBPEMBG AKGLLEPNACE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6214770", Offset = "0x6213970", VA = "0x186214770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 CJOAPMDHNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6214620", Offset = "0x6213820", VA = "0x186214620")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion NAHAFLGNJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x62147D0", Offset = "0x62139D0", VA = "0x1862147D0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public MMLCOCHHNEC NJAMDGMGFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6214470", Offset = "0x6213670", VA = "0x186214470")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public EFLGGPGGBGJ(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static AGNLOFKLMDO GEOGJCANPGE(EFLGGPGGBGJ EKDDCPALANJ)
	{
		return default(AGNLOFKLMDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6214590", Offset = "0x6213790", VA = "0x186214590", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(EFLGGPGGBGJ MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct EDKOPDLLMBF : IEquatable<EDKOPDLLMBF>
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly EDKOPDLLMBF AKKMIDDBLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public JMHJLFKAJBI MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(JMHJLFKAJBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public LFGCBCHGHNJ JGPHNJNADEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(LFGCBCHGHNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private DBJHLPJFGDP FFEJIFDKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6211A60", Offset = "0x6210C60", VA = "0x186211A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private EGKJBCGMGIF AHEOHHMCOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6213050", Offset = "0x6212250", VA = "0x186213050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public BECPEMBNPON MIGJNIIGLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6212F20", Offset = "0x6212120", VA = "0x186212F20")]
		get
		{
			return default(BECPEMBNPON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IEnumerable<MMLCOCHHNEC> FCLBFFIINLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x62134A0", Offset = "0x62126A0", VA = "0x1862134A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public IEnumerable<MMLCOCHHNEC> GLJLJLLJGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6212D60", Offset = "0x6211F60", VA = "0x186212D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int FKDINEDDBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6213350", Offset = "0x6212550", VA = "0x186213350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int EJJIHKGCKME
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6213450", Offset = "0x6212650", VA = "0x186213450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6213240", Offset = "0x6212440", VA = "0x186213240")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x62130B0", Offset = "0x62122B0", VA = "0x1862130B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public JLICOMJJGPO FKNOFOANNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6211C80", Offset = "0x6210E80", VA = "0x186211C80")]
		get
		{
			return default(JLICOMJJGPO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6211EC0", Offset = "0x62110C0", VA = "0x186211EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public NMFMEBNCGMB DNLFJHPDJFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6212C90", Offset = "0x6211E90", VA = "0x186212C90")]
		get
		{
			return default(NMFMEBNCGMB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x62133E0", Offset = "0x62125E0", VA = "0x1862133E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public KJOJBBBAKAP PDHECLBCFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6211740", Offset = "0x6210940", VA = "0x186211740")]
		get
		{
			return default(KJOJBBBAKAP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6211660", Offset = "0x6210860", VA = "0x186211660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float NMIEELFCFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x62120A0", Offset = "0x62112A0", VA = "0x1862120A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x62131D0", Offset = "0x62123D0", VA = "0x1862131D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool NOACEKDCALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6211C20", Offset = "0x6210E20", VA = "0x186211C20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6212FE0", Offset = "0x62121E0", VA = "0x186212FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool AEDOGMADLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6211FA0", Offset = "0x62111A0", VA = "0x186211FA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6211AF0", Offset = "0x6210CF0", VA = "0x186211AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool GANGMFEFMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x62117A0", Offset = "0x62109A0", VA = "0x1862117A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6212CF0", Offset = "0x6211EF0", VA = "0x186212CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool JFGKHGCDHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6211B60", Offset = "0x6210D60", VA = "0x186211B60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6213160", Offset = "0x6212360", VA = "0x186213160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool MACCIPBBMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6211D50", Offset = "0x6210F50", VA = "0x186211D50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6211F30", Offset = "0x6211130", VA = "0x186211F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool NEOLIGGKMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6211BC0", Offset = "0x6210DC0", VA = "0x186211BC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x62126A0", Offset = "0x62118A0", VA = "0x1862126A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool EJNIEPIJLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x62132F0", Offset = "0x62124F0", VA = "0x1862132F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6211CE0", Offset = "0x6210EE0", VA = "0x186211CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public OIGBGKEBEFC DHFEOCDOEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x62128C0", Offset = "0x6211AC0", VA = "0x1862128C0")]
		get
		{
			return default(OIGBGKEBEFC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x62115F0", Offset = "0x62107F0", VA = "0x1862115F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public IEnumerable<int> IBJAKKOLHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6212E80", Offset = "0x6212080", VA = "0x186212E80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6211800", Offset = "0x6210A00", VA = "0x186211800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public int NJPKDLNMIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6212000", Offset = "0x6211200", VA = "0x186212000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public EDKOPDLLMBF(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6210FB0", Offset = "0x62101B0", VA = "0x186210FB0")]
	public static bool GEOGJCANPGE(EDKOPDLLMBF EKDDCPALANJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6210F00", Offset = "0x6210100", VA = "0x186210F00")]
	public static bool FPIEKNKMEBM(EDKOPDLLMBF LLLCBODKBAN, EDKOPDLLMBF HIOEJKGFIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6211E30", Offset = "0x6211030", VA = "0x186211E30", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(EDKOPDLLMBF MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static MMLCOCHHNEC GEOGJCANPGE(EDKOPDLLMBF AOFIGDLFNLH)
	{
		return default(MMLCOCHHNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x62115D0", Offset = "0x62107D0", VA = "0x1862115D0")]
	public bool AHFMHILKMPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x62116D0", Offset = "0x62108D0", VA = "0x1862116D0")]
	public bool BKKNAEOCPKE(BPEECEOEIPM LAENJLIODBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6211DB0", Offset = "0x6210FB0", VA = "0x186211DB0")]
	public void EFIBJJDOOCA(BPEECEOEIPM LAENJLIODBG, bool EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6212710", Offset = "0x6211910", VA = "0x186212710")]
	public BECPEMBNPON JACLFCOOAJB(Allocator HOJMCOLANAB)
	{
		return default(BECPEMBNPON);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6212920", Offset = "0x6211B20", VA = "0x186212920")]
	public void JDJJPACDIJK(EDKOPDLLMBF MEJMHKPOODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6212100", Offset = "0x6211300", VA = "0x186212100")]
	public void HCKKMBEBDIF(List<MMLCOCHHNEC> BAMOMPMCCMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct GJKIHLHAFMJ : IEquatable<GJKIHLHAFMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6215670", Offset = "0x6214870", VA = "0x186215670", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(GJKIHLHAFMJ MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct PANLIPMEAPH : IEquatable<PANLIPMEAPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public PANLIPMEAPH(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x621E7F0", Offset = "0x621D9F0", VA = "0x18621E7F0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(PANLIPMEAPH MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x621E610", Offset = "0x621D810", VA = "0x18621E610")]
	public void CJPKHGMGMMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x621E750", Offset = "0x621D950", VA = "0x18621E750")]
	public void EEKGGAAOLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x621E6B0", Offset = "0x621D8B0", VA = "0x18621E6B0")]
	public bool DCMFCFNMJND()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct LFGCBCHGHNJ : IEquatable<LFGCBCHGHNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	private MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private DBJHLPJFGDP FFEJIFDKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x621B230", Offset = "0x621A430", VA = "0x18621B230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private EGKJBCGMGIF AHEOHHMCOHN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x621BAD0", Offset = "0x621ACD0", VA = "0x18621BAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public AGNLOFKLMDO NMNNMJMNIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x621BA40", Offset = "0x621AC40", VA = "0x18621BA40")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public MMLCOCHHNEC IIBNAPJLELD
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x621B4F0", Offset = "0x621A6F0", VA = "0x18621B4F0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public MMLCOCHHNEC NECEBBLCHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x621B610", Offset = "0x621A810", VA = "0x18621B610")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public LFGCBCHGHNJ(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x621B580", Offset = "0x621A780", VA = "0x18621B580", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(LFGCBCHGHNJ MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x621B3C0", Offset = "0x621A5C0", VA = "0x18621B3C0")]
	public bool DPPHNCDDAIK(MMLCOCHHNEC DLAKBCKOLFN, bool JNGEGNKJFOJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x621B2C0", Offset = "0x621A4C0", VA = "0x18621B2C0")]
	public bool DAEBIDONNPN(MMLCOCHHNEC DOCGKJJCLDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x621B6A0", Offset = "0x621A8A0", VA = "0x18621B6A0")]
	private void GBBEHDFAPEN(MMLCOCHHNEC KONBBGLDFEJ, List<MMLCOCHHNEC> KJOBACMDDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x621BB30", Offset = "0x621AD30", VA = "0x18621BB30")]
	public EDKOPDLLMBF NDLECIGDBMD()
	{
		return default(EDKOPDLLMBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x621B360", Offset = "0x621A560", VA = "0x18621B360")]
	public void DLHDHPHEEML(List<MMLCOCHHNEC> NLOEOABEDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x621B920", Offset = "0x621AB20", VA = "0x18621B920")]
	public NativeArray<AGNLOFKLMDO> GMEEHCCJLJE()
	{
		return default(NativeArray<AGNLOFKLMDO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct AFKJLKPMKEG : IEquatable<AFKJLKPMKEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public string BJGHKOAJBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x620D4C0", Offset = "0x620C6C0", VA = "0x18620D4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public string MOKIHCJPAGH
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x620D310", Offset = "0x620C510", VA = "0x18620D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool OBPDOEJFPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x620D5E0", Offset = "0x620C7E0", VA = "0x18620D5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public string CLHMCBCFMOP
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x620D3D0", Offset = "0x620C5D0", VA = "0x18620D3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string PPHNAFLKFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x620D750", Offset = "0x620C950", VA = "0x18620D750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string CAHHEBOIFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x620D9A0", Offset = "0x620CBA0", VA = "0x18620D9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public AFKJLKPMKEG(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x620D540", Offset = "0x620C740", VA = "0x18620D540", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(AFKJLKPMKEG MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct PLLLEFFLEFI : IEquatable<PLLLEFFLEFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x621F290", Offset = "0x621E490", VA = "0x18621F290", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(PLLLEFFLEFI MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct EOCCDKOCHGD : IEquatable<EOCCDKOCHGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public EOCCDKOCHGD(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6214910", Offset = "0x6213B10", VA = "0x186214910", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(EOCCDKOCHGD MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x62149A0", Offset = "0x6213BA0", VA = "0x1862149A0")]
	public bool KIDGFIGBLIG([Out] Collider IGKJJBGCJAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct JLADFKMBDMG : IEquatable<JLADFKMBDMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private HDJHFBBDMDN DDFNFLDDMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x62176A0", Offset = "0x62168A0", VA = "0x1862176A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public JLADFKMBDMG(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x62175A0", Offset = "0x62167A0", VA = "0x1862175A0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(JLADFKMBDMG MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6217630", Offset = "0x6216830", VA = "0x186217630")]
	public void GPAALOEMOGI(bool OOBLAOPABIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct GPJMAGEBNLL : IEquatable<GPJMAGEBNLL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private DBJHLPJFGDP FFEJIFDKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x62159C0", Offset = "0x6214BC0", VA = "0x1862159C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private ObjectPolicyDataWrapper OPHCGLMEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x62161A0", Offset = "0x62153A0", VA = "0x1862161A0")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private NavMeshGenerationDataWrapper ODHJKAJEBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6216710", Offset = "0x6215910", VA = "0x186216710")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool NLMBLCHCHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6216540", Offset = "0x6215740", VA = "0x186216540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool NJCNMOGIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6215F50", Offset = "0x6215150", VA = "0x186215F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public bool ILNOBMICNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6215FC0", Offset = "0x62151C0", VA = "0x186215FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool ANHJGPJJBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6215950", Offset = "0x6214B50", VA = "0x186215950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool PFHJMJFHAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6215870", Offset = "0x6214A70", VA = "0x186215870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool ELHICDGGAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6215DF0", Offset = "0x6214FF0", VA = "0x186215DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool ALMJIMCOPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6216030", Offset = "0x6215230", VA = "0x186216030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public bool LJLILFKMPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6216340", Offset = "0x6215540", VA = "0x186216340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool JFIALAGHLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6215CA0", Offset = "0x6214EA0", VA = "0x186215CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool KPFLCNKEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6216580", Offset = "0x6215780", VA = "0x186216580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool FNMMEDBMJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x62158E0", Offset = "0x6214AE0", VA = "0x1862158E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public bool PAGDNMBOOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x62163B0", Offset = "0x62155B0", VA = "0x1862163B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool IGEBPOMKKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6215D10", Offset = "0x6214F10", VA = "0x186215D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool FCBIHIBLIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6215810", Offset = "0x6214A10", VA = "0x186215810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool KOBIKAIIBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x62166B0", Offset = "0x62158B0", VA = "0x1862166B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x62162D0", Offset = "0x62154D0", VA = "0x1862162D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public CCEAMCMKGBM CLHADGJDOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6215EF0", Offset = "0x62150F0", VA = "0x186215EF0")]
		get
		{
			return default(CCEAMCMKGBM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x62157A0", Offset = "0x62149A0", VA = "0x1862157A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool IMKKPOIBJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6215A50", Offset = "0x6214C50", VA = "0x186215A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public OLHAMEMJPND PGJHCFHJKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6216200", Offset = "0x6215400", VA = "0x186216200")]
		get
		{
			return default(OLHAMEMJPND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public bool OCJFCHJPJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6216770", Offset = "0x6215970", VA = "0x186216770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 OLKNNDPEENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x62165F0", Offset = "0x62157F0", VA = "0x1862165F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 BGNPPJMKAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6216490", Offset = "0x6215690", VA = "0x186216490")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool FKPJGPKEACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x62160A0", Offset = "0x62152A0", VA = "0x1862160A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public GPJMAGEBNLL(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6215E60", Offset = "0x6215060", VA = "0x186215E60", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(GPJMAGEBNLL MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6216260", Offset = "0x6215460", VA = "0x186216260")]
	public bool KLAKOANAOGF(IJPFCCDEOGE LAENJLIODBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6215D80", Offset = "0x6214F80", VA = "0x186215D80")]
	public bool EFDANKMIMLB(OBPHPMOBDFL LAENJLIODBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6215C20", Offset = "0x6214E20", VA = "0x186215C20")]
	public void DJJFHGEBNHD(OBPHPMOBDFL LAENJLIODBG, bool CCMFFLCDHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x62167D0", Offset = "0x62159D0", VA = "0x1862167D0")]
	public OBPHPMOBDFL PKNIBCPBJAA()
	{
		return default(OBPHPMOBDFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6216420", Offset = "0x6215620", VA = "0x186216420")]
	public bool MKBGLIAOCEN(OBPHPMOBDFL EKDDCPALANJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct NAOMBJMLKOF : IEquatable<NAOMBJMLKOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private DBJHLPJFGDP FFEJIFDKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x621DB50", Offset = "0x621CD50", VA = "0x18621DB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public NAOMBJMLKOF(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x621DBE0", Offset = "0x621CDE0", VA = "0x18621DBE0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(NAOMBJMLKOF MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x621DC70", Offset = "0x621CE70", VA = "0x18621DC70")]
	public void GBPGLFPDIIG(bool EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x621DD00", Offset = "0x621CF00", VA = "0x18621DD00")]
	public void GEJCHIKLDEF(bool EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x29C1F50", Offset = "0x29C1150", VA = "0x1829C1F50")]
	public T AHKNFMCPPKM<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct EDOGIONHDBN : IEquatable<EDOGIONHDBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private DBJHLPJFGDP FFEJIFDKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x62138B0", Offset = "0x6212AB0", VA = "0x1862138B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private PHGKBBFKJJG AGANIDDOMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6213850", Offset = "0x6212A50", VA = "0x186213850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private NHMJMDDCKMN ADBEGPOAIBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x62141E0", Offset = "0x62133E0", VA = "0x1862141E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool LOHABGAOPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x62143E0", Offset = "0x62135E0", VA = "0x1862143E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool PGFNNHNCAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6214340", Offset = "0x6213540", VA = "0x186214340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool LLHCOGHBGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x62141B0", Offset = "0x62133B0", VA = "0x1862141B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool APMILABAGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6213940", Offset = "0x6212B40", VA = "0x186213940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool BGPBKFKFEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6214180", Offset = "0x6213380", VA = "0x186214180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool CJAHAKHANGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x6214240", Offset = "0x6213440", VA = "0x186214240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool OKGGFHNOMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6213A10", Offset = "0x6212C10", VA = "0x186213A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool KBMKJFMIEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6213C20", Offset = "0x6212E20", VA = "0x186213C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public EDOGIONHDBN(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6210FB0", Offset = "0x62101B0", VA = "0x186210FB0")]
	public static bool GEOGJCANPGE(EDOGIONHDBN EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6213D90", Offset = "0x6212F90", VA = "0x186213D90", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(EDOGIONHDBN MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x62142D0", Offset = "0x62134D0", VA = "0x1862142D0")]
	public bool OEOHCKBIADH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x62137B0", Offset = "0x62129B0", VA = "0x1862137B0")]
	public MMLCOCHHNEC AKLBFLDONNE(MMLCOCHHNEC JGFCAMDGBLE)
	{
		return default(MMLCOCHHNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6214070", Offset = "0x6213270", VA = "0x186214070")]
	public AGNLOFKLMDO LCACOFGPGGJ()
	{
		return default(AGNLOFKLMDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6213FD0", Offset = "0x62131D0", VA = "0x186213FD0")]
	public bool KKNMKKBHOJL(AGNLOFKLMDO MGCNPLBKEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6213F30", Offset = "0x6213130", VA = "0x186213F30")]
	public bool JNBOGIJALFI(AGNLOFKLMDO BLBEOFBCPAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6213E20", Offset = "0x6213020", VA = "0x186213E20")]
	public bool HNBCJGGIIPN(AGNLOFKLMDO JGFCAMDGBLE, [Out] AGNLOFKLMDO MGCNPLBKEIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct HKBIDKCKJBJ : IEquatable<HKBIDKCKJBJ>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly HKBIDKCKJBJ AKKMIDDBLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public JMHJLFKAJBI MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(JMHJLFKAJBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private ShapeTypeDataWrapper LDJEAJOLBMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6216DB0", Offset = "0x6215FB0", VA = "0x186216DB0")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public StandardRenderableVisualDataWrapper EEBEFEEHKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6217030", Offset = "0x6216230", VA = "0x186217030")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public PhysicsMaterialDataWrapper PBGLGAAPENP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6217090", Offset = "0x6216290", VA = "0x186217090")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public ShapeConfigDataWrapper JAJNJMNFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6216F60", Offset = "0x6216160", VA = "0x186216F60")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public AOPPGPEDKLO IHKNIBMFMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6216FC0", Offset = "0x62161C0", VA = "0x186216FC0")]
		get
		{
			return default(AOPPGPEDKLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public DKFFJGDMCCB BGOBLBNPHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x62171D0", Offset = "0x62163D0", VA = "0x1862171D0")]
		get
		{
			return default(DKFFJGDMCCB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6216C50", Offset = "0x6215E50", VA = "0x186216C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public JFLGFGJFHHM IEABADFPIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6216B70", Offset = "0x6215D70", VA = "0x186216B70")]
		get
		{
			return default(JFLGFGJFHHM);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6216EF0", Offset = "0x62160F0", VA = "0x186216EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public float ELACOMABNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6216D50", Offset = "0x6215F50", VA = "0x186216D50")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6216E80", Offset = "0x6216080", VA = "0x186216E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Vector3 NMPGNDAEIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6216A30", Offset = "0x6215C30", VA = "0x186216A30")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6216AD0", Offset = "0x6215CD0", VA = "0x186216AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public float FJEBLFAGMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6217230", Offset = "0x6216430", VA = "0x186217230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public GFPBOGIPHND LIDCIPFBMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x62170F0", Offset = "0x62162F0", VA = "0x1862170F0")]
		get
		{
			return default(GFPBOGIPHND);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6216E10", Offset = "0x6216010", VA = "0x186216E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public HKBIDKCKJBJ(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6210FB0", Offset = "0x62101B0", VA = "0x186210FB0")]
	public static bool GEOGJCANPGE(HKBIDKCKJBJ EKDDCPALANJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x620E160", Offset = "0x620D360", VA = "0x18620E160")]
	public static bool LEBDJINPIPG(HKBIDKCKJBJ LLLCBODKBAN, HKBIDKCKJBJ HIOEJKGFIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6216CC0", Offset = "0x6215EC0", VA = "0x186216CC0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(HKBIDKCKJBJ MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6217150", Offset = "0x6216350", VA = "0x186217150")]
	public GBMHKHFDLOK OBMLMONBNBO()
	{
		return default(GBMHKHFDLOK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6216BD0", Offset = "0x6215DD0", VA = "0x186216BD0")]
	public DNNNJKKEGPF CIHGHILKCFD()
	{
		return default(DNNNJKKEGPF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct GBMHKHFDLOK : IEquatable<GBMHKHFDLOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public HKBIDKCKJBJ KPJHNIKCOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(HKBIDKCKJBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private PrimitiveShapeDataWrapper LNMMAFCCIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6215590", Offset = "0x6214790", VA = "0x186215590")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public DBGCOLPIMDG JNILLIGJODA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x62154A0", Offset = "0x62146A0", VA = "0x1862154A0")]
		get
		{
			return default(DBGCOLPIMDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public GBMHKHFDLOK(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6210FB0", Offset = "0x62101B0", VA = "0x186210FB0")]
	public static bool GEOGJCANPGE(GBMHKHFDLOK EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6215500", Offset = "0x6214700", VA = "0x186215500", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(GBMHKHFDLOK MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DefaultMember("Item")]
public readonly struct DNNNJKKEGPF : IEquatable<DNNNJKKEGPF>
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly DNNNJKKEGPF AKKMIDDBLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public JMHJLFKAJBI MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(JMHJLFKAJBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private DBJHLPJFGDP FFEJIFDKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x6210930", Offset = "0x620FB30", VA = "0x186210930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private IOFEDJDHMMM JCPGCBIGKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x62108D0", Offset = "0x620FAD0", VA = "0x1862108D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public HKBIDKCKJBJ KPJHNIKCOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(HKBIDKCKJBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public JLLBINFBBDN CMOOOABAJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x62113A0", Offset = "0x62105A0", VA = "0x1862113A0")]
		get
		{
			return default(JLLBINFBBDN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6211060", Offset = "0x6210260", VA = "0x186211060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public IEnumerable<FOIBDNOJMMG> OFBCICLEOCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6210C80", Offset = "0x620FE80", VA = "0x186210C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public FOIBDNOJMMG KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x62114C0", Offset = "0x62106C0", VA = "0x1862114C0")]
		get
		{
			return default(FOIBDNOJMMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6210FD0", Offset = "0x62101D0", VA = "0x186210FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public DNNNJKKEGPF(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6210FB0", Offset = "0x62101B0", VA = "0x186210FB0")]
	public static bool GEOGJCANPGE(DNNNJKKEGPF EKDDCPALANJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6210F00", Offset = "0x6210100", VA = "0x186210F00")]
	public static bool FPIEKNKMEBM(DNNNJKKEGPF LLLCBODKBAN, DNNNJKKEGPF HIOEJKGFIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6210E70", Offset = "0x6210070", VA = "0x186210E70", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(DNNNJKKEGPF MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6211180", Offset = "0x6210380", VA = "0x186211180")]
	public FOIBDNOJMMG HOMLNECJADA(float3? JCMPCLFLJHD, [Optional] quaternion? ECLCOOPOABI, [Optional] Vector3? OFBFBKPELML)
	{
		return default(FOIBDNOJMMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x62109C0", Offset = "0x620FBC0", VA = "0x1862109C0")]
	public FOIBDNOJMMG CPGDDCDOCPB(int MBGANDEDPDN, float3? JCMPCLFLJHD, [Optional] quaternion? ECLCOOPOABI, [Optional] Vector3? OFBFBKPELML)
	{
		return default(FOIBDNOJMMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6210F10", Offset = "0x6210110", VA = "0x186210F10")]
	public void GEIHOAAAGMP(int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6210BF0", Offset = "0x620FDF0", VA = "0x186210BF0")]
	public void DBHKOJLPIHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct FOIBDNOJMMG : IEquatable<FOIBDNOJMMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public DNNNJKKEGPF KKHEPCMIKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6214EE0", Offset = "0x62140E0", VA = "0x186214EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float3 LBCBIKCAOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x62152E0", Offset = "0x62144E0", VA = "0x1862152E0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x62151E0", Offset = "0x62143E0", VA = "0x1862151E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public quaternion HLNGFPFIIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6214E60", Offset = "0x6214060", VA = "0x186214E60")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x6214FD0", Offset = "0x62141D0", VA = "0x186214FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public float3 MKBPFDDHCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x6215040", Offset = "0x6214240", VA = "0x186215040")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x6215260", Offset = "0x6214460", VA = "0x186215260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public DHOGHBGBODA JICBFDDJMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6214D60", Offset = "0x6213F60", VA = "0x186214D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private SplinePointParentDataWrapper LIDJHHHGHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x6215120", Offset = "0x6214320", VA = "0x186215120")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private SplinePointPositionDataWrapper KBFPGKKIMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6214D00", Offset = "0x6213F00", VA = "0x186214D00")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private SplinePointRotationDataWrapper MHFOGHACBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6214F70", Offset = "0x6214170", VA = "0x186214F70")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private SplinePointScaleDataWrapper NHLDFAIICOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6215180", Offset = "0x6214380", VA = "0x186215180")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private SplinePointOrderDataWrapper FKMELKDDPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x62150C0", Offset = "0x62142C0", VA = "0x1862150C0")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public FOIBDNOJMMG(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6214DD0", Offset = "0x6213FD0", VA = "0x186214DD0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(FOIBDNOJMMG MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6214EE0", Offset = "0x62140E0", VA = "0x186214EE0")]
	public void IKIEPFKLNFB(DNNNJKKEGPF EKDDCPALANJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct KCGKPAJLFLE : IEquatable<KCGKPAJLFLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	private MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private DBJHLPJFGDP FFEJIFDKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6219CB0", Offset = "0x6218EB0", VA = "0x186219CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private BEPMHNBAGLF LOEHCLMCAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6219DA0", Offset = "0x6218FA0", VA = "0x186219DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private ToolCleanupSettingsDataWrapper EIAFKPFKAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x621A390", Offset = "0x6219590", VA = "0x18621A390")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool EILIIDFGHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x621A0A0", Offset = "0x62192A0", VA = "0x18621A0A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6219BA0", Offset = "0x6218DA0", VA = "0x186219BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool AELJNCNCDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6219D40", Offset = "0x6218F40", VA = "0x186219D40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6219B30", Offset = "0x6218D30", VA = "0x186219B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public float BHBPHHEHEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6219EA0", Offset = "0x62190A0", VA = "0x186219EA0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x621A6F0", Offset = "0x62198F0", VA = "0x18621A6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public bool HEDBAMPCOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6219E00", Offset = "0x6219000", VA = "0x186219E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public KCGKPAJLFLE(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x621A010", Offset = "0x6219210", VA = "0x18621A010", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(KCGKPAJLFLE MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6219C10", Offset = "0x6218E10", VA = "0x186219C10")]
	public void BPLOCLHJADN(int PDJKKMEADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6219F00", Offset = "0x6219100", VA = "0x186219F00")]
	public bool EOHDGCALDFE([Out] int PDJKKMEADLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x621A3F0", Offset = "0x62195F0", VA = "0x18621A3F0")]
	public void MLFDBNFCGOF(bool HLBOLNNFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x621A100", Offset = "0x6219300", VA = "0x18621A100")]
	public void KGCNFGIKIOL(float OBJNLOEGHBC, float OEIKELFCJGP, float KICGJJMNKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x621A240", Offset = "0x6219440", VA = "0x18621A240")]
	public void LFFPPJLAPOI(float3 AIBAINCDJLG, quaternion OEPLIHKEHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x621A5C0", Offset = "0x62197C0", VA = "0x18621A5C0")]
	public bool OPPKAHABBBF([Out] float3 AIBAINCDJLG, [Out] quaternion OEPLIHKEHJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x621A490", Offset = "0x6219690", VA = "0x18621A490")]
	public bool MOINFHFNMPB([Out] float IBGNGBCOAFB, [Out] float KMJHLGNBBPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct JMHJLFKAJBI : IEquatable<JMHJLFKAJBI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public LFGCBCHGHNJ JGPHNJNADEF
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(LFGCBCHGHNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private MMHEDGNKOFC JHAJGMANBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x620E0F0", Offset = "0x620D2F0", VA = "0x18620E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private PLFDPOJPHML FLMKBJKPFGA
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6217D30", Offset = "0x6216F30", VA = "0x186217D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool DJLPFALCJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x62192A0", Offset = "0x62184A0", VA = "0x1862192A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public Vector3 LBCBIKCAOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6219950", Offset = "0x6218B50", VA = "0x186219950")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6219690", Offset = "0x6218890", VA = "0x186219690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Quaternion HLNGFPFIIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x62185A0", Offset = "0x62177A0", VA = "0x1862185A0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6218BB0", Offset = "0x6217DB0", VA = "0x186218BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 JCMLCJJMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6217EA0", Offset = "0x62170A0", VA = "0x186217EA0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6218310", Offset = "0x6217510", VA = "0x186218310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Quaternion OGJCDKOFEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6217950", Offset = "0x6216B50", VA = "0x186217950")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6217B70", Offset = "0x6216D70", VA = "0x186217B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float OFEANHDOONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x62178B0", Offset = "0x6216AB0", VA = "0x1862178B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x62192E0", Offset = "0x62184E0", VA = "0x1862192E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float GCFGGEMOFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6218A20", Offset = "0x6217C20", VA = "0x186218A20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public Vector3 MKBPFDDHCON
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6219100", Offset = "0x6218300", VA = "0x186219100")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6219760", Offset = "0x6218960", VA = "0x186219760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public Vector3 IHMLFJEFHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x6217C40", Offset = "0x6216E40", VA = "0x186217C40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public Matrix4x4 HHIEGHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x6219390", Offset = "0x6218590", VA = "0x186219390")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public JMHJLFKAJBI(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6218280", Offset = "0x6217480", VA = "0x186218280", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(JMHJLFKAJBI MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6219900", Offset = "0x6218B00", VA = "0x186219900")]
	public AFMLJEGJNBJ PIFPLCMGACF()
	{
		return default(AFMLJEGJNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x62193D0", Offset = "0x62185D0", VA = "0x1862193D0")]
	public void NMELEPAFCCI([Out] Matrix4x4 MFMCJLFMNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6218150", Offset = "0x6217350", VA = "0x186218150")]
	public void EOKGAPKHENO([Out] Vector3 LFCFFJNGGGN, [Out] Quaternion DAJNPAHIMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x6218790", Offset = "0x6217990", VA = "0x186218790")]
	public void HGGKABJEBAO([Out] RigidTransform ACBNFCGIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x6218B80", Offset = "0x6217D80", VA = "0x186218B80")]
	public UniformTRS KCNKOOBHDLE()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x6218AC0", Offset = "0x6217CC0", VA = "0x186218AC0")]
	public void KCNKOOBHDLE([Out] UniformTRS JDAELFCGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6219A40", Offset = "0x6218C40", VA = "0x186219A40")]
	public UniformTRS PPHDMNNPMOL()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x6219A70", Offset = "0x6218C70", VA = "0x186219A70")]
	public void PPHDMNNPMOL([Out] UniformTRS ACBNFCGIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6218840", Offset = "0x6217A40", VA = "0x186218840")]
	public Vector3 IKIIHLDMHBM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6219830", Offset = "0x6218A30", VA = "0x186219830")]
	public void OJMCEBCCLFG([In] Vector3 EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6219010", Offset = "0x6218210", VA = "0x186219010")]
	public Vector3 LHDPDGOJCHF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x62183E0", Offset = "0x62175E0", VA = "0x1862183E0")]
	public void FPNHMDHDGII([In] Vector3 EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6218C80", Offset = "0x6217E80", VA = "0x186218C80")]
	public Quaternion KIPLBDKCGFG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6217AA0", Offset = "0x6216CA0", VA = "0x186217AA0")]
	public void AKLPLPACOFJ([In] Quaternion EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6217760", Offset = "0x6216960", VA = "0x186217760")]
	public Quaternion AFMNOOOICBN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6218DD0", Offset = "0x6217FD0", VA = "0x186218DD0")]
	public void KLGGJACHHHG([In] Quaternion EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x62186F0", Offset = "0x62178F0", VA = "0x1862186F0")]
	public float HBJPDJELGJD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x62191F0", Offset = "0x62183F0", VA = "0x1862191F0")]
	public void LJJOKOBIPBB(float EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6218F70", Offset = "0x6218170", VA = "0x186218F70")]
	public float LFINNHGNEPE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6217DF0", Offset = "0x6216FF0", VA = "0x186217DF0")]
	public void CNIBENAHHBE(float EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x62195C0", Offset = "0x62187C0", VA = "0x1862195C0")]
	public void NPAOLFCNDDE([In] Vector3 EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x62184B0", Offset = "0x62176B0", VA = "0x1862184B0")]
	public Vector3 FPOFIJLGJEG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x62194F0", Offset = "0x62186F0", VA = "0x1862194F0")]
	public void NOJIOKKDCEL([In] Vector3 EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6217F90", Offset = "0x6217190", VA = "0x186217F90")]
	public Vector3 DDKLKHNPHBK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x6218EA0", Offset = "0x62180A0", VA = "0x186218EA0")]
	public void LAGGNIDNOGJ([In] Vector3 EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6218930", Offset = "0x6217B30", VA = "0x186218930")]
	public Vector3 JBDCAFIEMNO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6218080", Offset = "0x6217280", VA = "0x186218080")]
	public void DLFPMLJDNEA([In] Vector3 EKDDCPALANJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct ONNKPMAJEIA : IEquatable<ONNKPMAJEIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly AGNLOFKLMDO HPEEIPMMJAC;

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public MMLCOCHHNEC PAOMFBJFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		get
		{
			return default(MMLCOCHHNEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public int[] HKBFIGHGNKG
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x621E4B0", Offset = "0x621D6B0", VA = "0x18621E4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool FCAOHAMILPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x621E3C0", Offset = "0x621D5C0", VA = "0x18621E3C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x621E5A0", Offset = "0x621D7A0", VA = "0x18621E5A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
	public ONNKPMAJEIA(AGNLOFKLMDO NAJMDMAIPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x620D720", Offset = "0x620C920", VA = "0x18620D720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x621E420", Offset = "0x621D620", VA = "0x18621E420", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C7D0", VA = "0x18620D5D0", Slot = "4")]
	public bool Equals(ONNKPMAJEIA MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x620DA90", Offset = "0x620CC90", VA = "0x18620DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DNCFFJJEJIJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private struct GMOCEJKBCGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Guid JJMGPACFMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public GLKNHOAABJJ AMOKKHGCOMH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct GLKNHOAABJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int EKDDCPALANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int IAMPLEHKGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int GMJCNHOFLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int OLELPFDMDCH;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6215700", Offset = "0x6214900", VA = "0x186215700")]
		public bool ADPDMGCIGBE([Out] HGKLNILLMDD AIBJMECNKIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6215780", Offset = "0x6214980", VA = "0x186215780")]
		public GLKNHOAABJJ(HGKLNILLMDD AIBJMECNKIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6210830", Offset = "0x620FA30", VA = "0x186210830")]
	public static Guid EJKKCGEPPMG(this HGKLNILLMDD AIBJMECNKIH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x62108B0", Offset = "0x620FAB0", VA = "0x1862108B0")]
	public static bool KEHKFAJMPGI(this Guid JJMGPACFMMB, [Out] HGKLNILLMDD AIBJMECNKIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal static class MMMAPKICPFI
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x621D830", Offset = "0x621CA30", VA = "0x18621D830")]
	public static DBJHLPJFGDP FFEJIFDKKNO(this AGNLOFKLMDO POAELFIOKHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x621D8C0", Offset = "0x621CAC0", VA = "0x18621D8C0")]
	public static AMEEJEIIGMP HCFKHMINHIF(this AGNLOFKLMDO POAELFIOKHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x621D990", Offset = "0x621CB90", VA = "0x18621D990")]
	public static EntityManager NHEHCCGMCJE(this AGNLOFKLMDO POAELFIOKHK)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x2954210", Offset = "0x2953410", VA = "0x182954210")]
	public static T JDOFKOLKJED<T>(this AGNLOFKLMDO POAELFIOKHK) where T : struct, CJAKPFKCCCM
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2955320", Offset = "0x2954520", VA = "0x182955320")]
	public static bool LKMMGHOCCNO<T>(this AGNLOFKLMDO POAELFIOKHK) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2954160", Offset = "0x2953360", VA = "0x182954160")]
	public static bool AILAFDEIMCO<T>(this AGNLOFKLMDO POAELFIOKHK) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface CBAJJGAKEPF
{
	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJDIMKDBKLH(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ILKCAHHGNCP(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KEECFKDDHJD(AGNLOFKLMDO NAJMDMAIPJN, [Out] Guid KEAGJDNLFNN);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid MJBBLDOLPBP(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOLKEDKJAFN(AGNLOFKLMDO NAJMDMAIPJN, Guid KEAGJDNLFNN);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OBFKPANPGOH(AGNLOFKLMDO NAJMDMAIPJN, [Out] Guid MBBENIIFGEP);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid CEOBLHGBFPO(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void INJHICHIJHN(AGNLOFKLMDO NAJMDMAIPJN, Guid MBBENIIFGEP);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LAMEBGMBLMG(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task LFLEDOOEPCP(AGNLOFKLMDO MMGOAMJJJHK, AGNLOFKLMDO DLAKBCKOLFN);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface FKODMHNDHPI
{
	[Cpp2IlInjected.Token(Token = "0x17000160")]
	Guid KCLCCOAMNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNKNBNNAPDL(NativeList<Guid> BJFLEBCMBCA, NativeList<Guid> NPOPNHOBJPP, NativeList<FixedString64Bytes> KEFKNHJIKPB);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface DJFPAENAPEE
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDHOPCGKGNO(List<AGNLOFKLMDO> CNBMOIOFEPB);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GDPBOOPIIIB(AGNLOFKLMDO GEOEMCBJEIM);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FJEEAECICCH(AGNLOFKLMDO GEOEMCBJEIM);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OGGFIODEKGF(AGNLOFKLMDO GEOEMCBJEIM);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NLIHEDBHONI(AGNLOFKLMDO GEOEMCBJEIM);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JKBPCBPBLLO(AGNLOFKLMDO GEOEMCBJEIM, int BJLBPPPFCJE);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AGNLOFKLMDO GEBHHJMLGGP(AGNLOFKLMDO HOJCHHAEFNG);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OIFALJBKKLK(AGNLOFKLMDO HOJCHHAEFNG, AGNLOFKLMDO JDIDPDFOCDO);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GBPMABAJCNM(AGNLOFKLMDO HOJCHHAEFNG);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int GKOMEDAAIMA(AGNLOFKLMDO HOJCHHAEFNG);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MHDJGAKNLHH(AGNLOFKLMDO HOJCHHAEFNG, int AHELFPJJDGN);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EGOBLPDMBLP(AGNLOFKLMDO HPEEIPMMJAC);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HMMKBJDIFEK(AGNLOFKLMDO NAJMDMAIPJN, bool JOPGKHFDFDO);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ECCMFGHAGCO(AGNLOFKLMDO[] BFPFIMOOKDF, bool JOPGKHFDFDO);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface OJEBNOLMNLL
{
	[Cpp2IlInjected.Token(Token = "0x17000161")]
	IReadOnlyCollection<LAKJMBDBKGD> FCLIHNICCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPDJJLOJDDN(int IPGPCGDBEKF, [Out] LAKJMBDBKGD IMHJIKPNBIG);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LAKJMBDBKGD DNLLLDJPEGM(Type MJMAEGDPBNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class IPMOLPBAGJK
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x28C8BE0", Offset = "0x28C7DE0", VA = "0x1828C8BE0")]
	public static T FICPENOPBCF<T>(this OJEBNOLMNLL CFBKMFFPNKI, Entity ACPAMCNIKHM) where T : struct, CJAKPFKCCCM
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x28C7F80", Offset = "0x28C7180", VA = "0x1828C7F80")]
	public static LAKJMBDBKGD DNLLLDJPEGM<T>(this OJEBNOLMNLL CFBKMFFPNKI) where T : struct, CJAKPFKCCCM
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface JNFAPIPAMML
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HGKLNILLMDD[] MFBNFDKPGPB(string MPENHPFDCDK, MMLCOCHHNEC IFFECJNENIB, bool OGJFOIHOCFA = false);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBIANALFCFP(string OGBJKBBFCCI, HGKLNILLMDD[] PHIPEPCMJME);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface ICJJEBPEMBG
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<AGNLOFKLMDO, AGNLOFKLMDO> JNFOAJFANJB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<AGNLOFKLMDO, AGNLOFKLMDO> BPFEDIEBKFM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<AGNLOFKLMDO, AGNLOFKLMDO, AGNLOFKLMDO> DHDMEOLMGAL;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AGNLOFKLMDO> KLAHNNBBNFC;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JDEEFCFLKFF(AGNLOFKLMDO NAJMDMAIPJN, AGNLOFKLMDO OBEDGDNAKOD);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AGNLOFKLMDO BBHMMKJDGDB(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<AGNLOFKLMDO> JOAEOILNFGC(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AGNLOFKLMDO MKIHNEOGGGH(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BNNIJJIICLH(AGNLOFKLMDO NAJMDMAIPJN, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IELGPKHBENG(AGNLOFKLMDO NAJMDMAIPJN, float MMALJBFNOFN);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CIPHFDOFLLC(AGNLOFKLMDO NAJMDMAIPJN, [Out] RigidTransform IKMGFCNAGMK);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LEFLAEHFAGF(AGNLOFKLMDO NAJMDMAIPJN, [Out] float DIDPEHDLAMN);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 FPEGFNOJLBN(EFLGGPGGBGJ LJBKINELJNM);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion FFONKLBFCMA(EFLGGPGGBGJ LJBKINELJNM);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class DBKPEHNKPPG
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface MIAKDELDJJK
{
	[Cpp2IlInjected.Token(Token = "0x17000162")]
	object DCMEICJBPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FDLCLEHGAKB(BECPEMBNPON BFPFIMOOKDF);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public enum OGDBEOAHPHG
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class BLGICCIDLMA
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xBF41A0", Offset = "0xBF33A0", VA = "0x180BF41A0")]
	public static bool EMBFILJIEKA(this OGDBEOAHPHG GAEMKAANAID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0xBF41C0", Offset = "0xBF33C0", VA = "0x180BF41C0")]
	public static bool HCCIFOKGJPA(this OGDBEOAHPHG GAEMKAANAID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2323FD0", Offset = "0x23231D0", VA = "0x182323FD0")]
	public static bool KDDCOHPAGLF(this OGDBEOAHPHG GAEMKAANAID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface LBIDLJNDDLP
{
	[Cpp2IlInjected.Token(Token = "0x17000163")]
	OGDBEOAHPHG AMAHGFLCEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	OGDBEOAHPHG NKFJKHBBMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	OGDBEOAHPHG OALMEMACFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	OGDBEOAHPHG OGEBIAEMLFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	OGDBEOAHPHG DAEDCFJOHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	OGDBEOAHPHG LAGAMOAIHAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	OGDBEOAHPHG NMGHFDPKJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	OGDBEOAHPHG JJJHEPJIDKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	OGDBEOAHPHG AOAOFOJBJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	OGDBEOAHPHG NJNBGNEJJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	OGDBEOAHPHG GGLELKPKNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	OGDBEOAHPHG FMMGIEHBNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	OGDBEOAHPHG BJJNNJECBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface EGKJBCGMGIF
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<KDLBOGHAELH> CGMDCHFHIBE;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AGNLOFKLMDO ODNFEDJDJEI(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKOLLCCFNDA(List<AGNLOFKLMDO> CNBMOIOFEPB);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DHOGHBGBODA JABEJOPCBJL(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DHOGHBGBODA BEAIPAKHCDN(AGNLOFKLMDO DLAKBCKOLFN, AGNLOFKLMDO NGGIHAOFJPD, bool DLHOIHGJNCN, AGNLOFKLMDO JGFCAMDGBLE);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AGNLOFKLMDO OPAHCEDNAIB(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DPPHNCDDAIK(AGNLOFKLMDO NAJMDMAIPJN, AGNLOFKLMDO DLAKBCKOLFN, bool JNGEGNKJFOJ);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DCIOBGCOMEL(AGNLOFKLMDO NAJMDMAIPJN, AGNLOFKLMDO DLAKBCKOLFN);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FHJGDMOLBFP(AGNLOFKLMDO FAFEKJHKJNP, AGNLOFKLMDO NHOFFHEGKAD);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int CFOAOKGNELI(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BECPEMBNPON BJAOBLFEDLD(AGNLOFKLMDO HPEEIPMMJAC);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NativeArray<AGNLOFKLMDO> GMEEHCCJLJE(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool FMCLKMDFBCE(AGNLOFKLMDO NAJMDMAIPJN, AGNLOFKLMDO BACPHJNFACN);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<AGNLOFKLMDO> PABHBLJGMDD(AGNLOFKLMDO NAJMDMAIPJN, bool KDEPPDBHNNN = false);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool DAEBIDONNPN(AGNLOFKLMDO NAJMDMAIPJN, AGNLOFKLMDO DOCGKJJCLDL);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	AGNLOFKLMDO PEGPOMFLCGK(AGNLOFKLMDO JGFCAMDGBLE, AGNLOFKLMDO OCAGOPDKCBF);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LEEGABOPJAG(AGNLOFKLMDO JGFCAMDGBLE, AGNLOFKLMDO OCAGOPDKCBF, [Out] AGNLOFKLMDO BNMIHGHJKCB);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class CFCMAOPMBNA
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x620F460", Offset = "0x620E660", VA = "0x18620F460")]
	public static List<AGNLOFKLMDO> NKOLLCCFNDA(this EGKJBCGMGIF BDJFCJPIEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x620F3F0", Offset = "0x620E5F0", VA = "0x18620F3F0")]
	public static bool DGHGDGMONLM(this EGKJBCGMGIF BDJFCJPIEPJ, AGNLOFKLMDO NAJMDMAIPJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface OCONGMHFGAH
{
	[Cpp2IlInjected.Token(Token = "0x17000170")]
	bool DLGKEILPHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	bool MOBEHIHKOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface JEOBNJGKCBI : AKLPLKGGDPP
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JPLACPEHNEN(Entity ACPAMCNIKHM, [Out] OLICNDINABC OEHGECKOHPK);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPFKBPLAGDC(NativeArray<OLICNDINABC> EPHAEIHNJPP, NativeArray<GIJIMDHOINM> HEHPMCCLDKL);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKGACMLEIFC(OLICNDINABC OEHGECKOHPK);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AHOOIEGKMEI(OLICNDINABC OEHGECKOHPK, [Out] Collider IGKJJBGCJAA);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface AKLPLKGGDPP
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBEFENOLKPF([In] float3 BNOKKIEBDEJ, [In] float3 HIMAANDEJKI, float NHMHEGFGMMF, Allocator HOJMCOLANAB, [Out] NativeArray<Entity> GKCCDIIKKCI);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface AIIAOOMOJOP
{
	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBEFENOLKPF([In] float3 BNOKKIEBDEJ, [In] float3 HIMAANDEJKI, float NHMHEGFGMMF, [Out] OJKJAMPFJGA KJEILHMGHDA, [Out] AGNLOFKLMDO MNAHIBFBBOC);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface CFFMGFBFKPE
{
	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBEFENOLKPF([In] NativeArray<Entity> GKCCDIIKKCI, [In] float3 BNOKKIEBDEJ, [In] float3 HIMAANDEJKI, [In] NativeArray<OJKJAMPFJGA> MFIEOCKIPNC);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct OLICNDINABC : GBFEIFPHLOE, IEquatable<OLICNDINABC>
{
	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int ABDHHHCLNNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int OGIJDDFLLOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2335DF0", Offset = "0x2334FF0", VA = "0x182335DF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5587230", Offset = "0x5586430", VA = "0x185587230", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x621E320", Offset = "0x621D520", VA = "0x18621E320", Slot = "8")]
	public bool Equals(OLICNDINABC MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x621E370", Offset = "0x621D570", VA = "0x18621E370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct OJKJAMPFJGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float NJPIKKKLPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 KBHLNPNINOC;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface LKMIJPNJBAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface MMHEDGNKOFC
{
	[Cpp2IlInjected.Token(Token = "0x17000174")]
	DBJHLPJFGDP FFEJIFDKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	CKCDBEIANKF LMEHALHIPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BECPEMBNPON, NativeArray<AIMLLPOCAAB>> DAGJIBEDBHO;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<BECPEMBNPON> MAEOBGJCBDE;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PLJJEACEGHF CNKBANMIIDN(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AIMLLPOCAAB DKEBMOFIOBG(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OEPCKJDAMHI(HGKLNILLMDD AIBJMECNKIH, CHDOFPFNIMP FIPFEJOGMMD);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KJPGCGGJJLL(HGKLNILLMDD[] PHIPEPCMJME, GameObject CHIOFKOKCNE);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MMLCOCHHNEC FDAOBAIMKAK(AGNLOFKLMDO NAJMDMAIPJN, [Optional] object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ALOCFDOFDGH(AGNLOFKLMDO NAJMDMAIPJN, [Out] CHDOFPFNIMP FIPFEJOGMMD);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OHCPEDEAGCK(AGNLOFKLMDO NAJMDMAIPJN, [Out] Transform DIFJEPLFOKN);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GJPBCHCNHKJ(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OAJFFAHOPNJ(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AGNDAEKGPCO(LocalId NAJMDMAIPJN, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HBMGCGILGNN(LocalId NAJMDMAIPJN, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	AGNLOFKLMDO NHLKPLAOBED(HGKLNILLMDD AIBJMECNKIH);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool PBMKNFLHKCF(HGKLNILLMDD AIBJMECNKIH, [Out] AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	HGKLNILLMDD IGLNFABEDOF(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BECPEMBNPON NHLKPLAOBED(NativeArray<HGKLNILLMDD> AIBJMECNKIH, Allocator HOJMCOLANAB);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	BECPEMBNPON BGFPPGDMEEM(AIMLLPOCAAB BCOGJAIKHDP, int KMJOEPJMADC, Allocator HOJMCOLANAB);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	BECPEMBNPON MBONMFKAFOG(NativeArray<HGKLNILLMDD> AIBJMECNKIH, NativeArray<FPHCLGGHEEC> BNGKDDPGAJA, Allocator HOJMCOLANAB);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	HGKLNILLMDD[] MFBNFDKPGPB(string OGBJKBBFCCI, MMLCOCHHNEC IFFECJNENIB, bool OGJFOIHOCFA);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CBIANALFCFP(string OGBJKBBFCCI, HGKLNILLMDD[] PHIPEPCMJME);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "25")]
	MMLCOCHHNEC OPMEAEACPHO(AIMLLPOCAAB BCOGJAIKHDP, bool BLELFMBDKNP);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MMLCOCHHNEC OPMEAEACPHO(AIMLLPOCAAB BCOGJAIKHDP);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	MMLCOCHHNEC KFNFNCEOBHE(AIMLLPOCAAB BCOGJAIKHDP);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "28")]
	MMLCOCHHNEC CLFNHJKABIM(AIMLLPOCAAB BCOGJAIKHDP);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	MMLCOCHHNEC CCDGPECGAKI(HGKLNILLMDD AIBJMECNKIH, AIMLLPOCAAB BCOGJAIKHDP);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "30")]
	EDKOPDLLMBF BHLFHMEEGEB();

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DNNNJKKEGPF AMJDDCPMNMH();

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "32")]
	GBMHKHFDLOK OAEJDOEKGPB(DBGCOLPIMDG LOLELPAAEJG);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void EEKGGAAOLJH(BECPEMBNPON BFPFIMOOKDF);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void CJPKHGMGMMP(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void KFMMNPEGBIH(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EEKGGAAOLJH(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool DCMFCFNMJND(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "38")]
	BECPEMBNPON GLCKEGKPDEN(BECPEMBNPON GNEMOOJNHHJ, Allocator HOJMCOLANAB);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool BFJAEMLKAPK(AGNLOFKLMDO NAJMDMAIPJN);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class CDHHLKADIKH
{
	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x620F270", Offset = "0x620E470", VA = "0x18620F270")]
	public static void OAJFFAHOPNJ(this MMHEDGNKOFC LONGGHDKNBH, CHDOFPFNIMP FIPFEJOGMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x620F240", Offset = "0x620E440", VA = "0x18620F240")]
	public static MMLCOCHHNEC LKCFJBDKIPB(this MMHEDGNKOFC LONGGHDKNBH, LocalId NAJMDMAIPJN)
	{
		return default(MMLCOCHHNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x620F1E0", Offset = "0x620E3E0", VA = "0x18620F1E0")]
	public static MMLCOCHHNEC LKCFJBDKIPB(this MMHEDGNKOFC LONGGHDKNBH, HGKLNILLMDD AIBJMECNKIH)
	{
		return default(MMLCOCHHNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x620F240", Offset = "0x620E440", VA = "0x18620F240")]
	public static AGNLOFKLMDO NHLKPLAOBED(this MMHEDGNKOFC LONGGHDKNBH, LocalId NAJMDMAIPJN)
	{
		return default(AGNLOFKLMDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x620F060", Offset = "0x620E260", VA = "0x18620F060")]
	public static HGKLNILLMDD IGLNFABEDOF(this MMHEDGNKOFC LONGGHDKNBH, LocalId NAJMDMAIPJN)
	{
		return default(HGKLNILLMDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x620ECC0", Offset = "0x620DEC0", VA = "0x18620ECC0")]
	public static bool BFJAEMLKAPK(this MMHEDGNKOFC LONGGHDKNBH, HGKLNILLMDD AIBJMECNKIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x26C6FD0", Offset = "0x26C61D0", VA = "0x1826C6FD0")]
	public static T KOIBKAIHOKJ<T>(this MMHEDGNKOFC LONGGHDKNBH, LocalId NAJMDMAIPJN) where T : struct, CJAKPFKCCCM
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x620F2F0", Offset = "0x620E4F0", VA = "0x18620F2F0")]
	public static EDKOPDLLMBF OMOPFFKIBOK(this MMHEDGNKOFC LONGGHDKNBH, RigidTransform JDAELFCGPCD, [Optional] object GMMJMENGHCD)
	{
		return default(EDKOPDLLMBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x620ED30", Offset = "0x620DF30", VA = "0x18620ED30")]
	public static GBMHKHFDLOK DKMGKOJCAEI(this MMHEDGNKOFC LONGGHDKNBH, DBGCOLPIMDG JKCHGNMACAK, RigidTransform JDAELFCGPCD, [Optional] object GMMJMENGHCD)
	{
		return default(GBMHKHFDLOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x620F0E0", Offset = "0x620E2E0", VA = "0x18620F0E0")]
	public static DNNNJKKEGPF IOHIKCPBGKJ(this MMHEDGNKOFC LONGGHDKNBH, RigidTransform JDAELFCGPCD, [Optional] object GMMJMENGHCD)
	{
		return default(DNNNJKKEGPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x620EE40", Offset = "0x620E040", VA = "0x18620EE40")]
	private static void EJPPKDMMCGH(MMLCOCHHNEC OACGLPAGIPL, RigidTransform JDAELFCGPCD, [Optional] object GMMJMENGHCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface PHGKBBFKJJG
{
	[Cpp2IlInjected.Token(Token = "0x17000176")]
	bool ACLJHLIOJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	AGNLOFKLMDO LAGEJDFCPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	MMLCOCHHNEC FOOJBDJIJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event HLMGBMPLLEC OPKOIPHIGGC;

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AGNLOFKLMDO PEGPOMFLCGK(AGNLOFKLMDO JGFCAMDGBLE, AGNLOFKLMDO OCAGOPDKCBF);

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LEEGABOPJAG(AGNLOFKLMDO JGFCAMDGBLE, AGNLOFKLMDO OCAGOPDKCBF, [Out] AGNLOFKLMDO BNMIHGHJKCB);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IPBINGCEFFO();

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LPLCMIKAOCL();

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LOHABGAOPHN(AGNLOFKLMDO JGFCAMDGBLE);

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CJAHAKHANGG(AGNLOFKLMDO JGFCAMDGBLE);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void HLMGBMPLLEC(MMLCOCHHNEC JINHLBKNPPK, MMLCOCHHNEC FPNDOAGMMOE);
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class EDOEPANIHHP
{
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x6213680", Offset = "0x6212880", VA = "0x186213680")]
	public static bool MKHGDCDBMBL(this PHGKBBFKJJG BHIMFHKLAJD, MMLCOCHHNEC JGFCAMDGBLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x62136D0", Offset = "0x62128D0", VA = "0x1862136D0")]
	public static bool OLAHPHIFEEC(this PHGKBBFKJJG BHIMFHKLAJD, AGNLOFKLMDO JGFCAMDGBLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x6213600", Offset = "0x6212800", VA = "0x186213600")]
	public static bool APMILABAGDG(this PHGKBBFKJJG BHIMFHKLAJD, AGNLOFKLMDO JGFCAMDGBLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface KGGNBDEFFMH
{
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDKICNLLIGI(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHBLMDNCPIO(AGNLOFKLMDO NAJMDMAIPJN, Transform DIFJEPLFOKN);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface NHMJMDDCKMN
{
	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KKNMKKBHOJL(AGNLOFKLMDO JGFCAMDGBLE, AGNLOFKLMDO MGCNPLBKEIH);

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JNBOGIJALFI(AGNLOFKLMDO JGFCAMDGBLE, AGNLOFKLMDO BLBEOFBCPAF);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HNBCJGGIIPN(AGNLOFKLMDO JGFCAMDGBLE, [Out] AGNLOFKLMDO DACEPBABHJB);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface BGIFFHFHMPI
{
	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBPGLFPDIIG(AGNLOFKLMDO HPEEIPMMJAC, bool EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEJCHIKLDEF(AGNLOFKLMDO HPEEIPMMJAC, bool EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKHEENEGDHE(AGNLOFKLMDO HPEEIPMMJAC, int EKDDCPALANJ);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface IOFEDJDHMMM
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<AGNLOFKLMDO> HKCOFPEGFBC(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AGNLOFKLMDO FMIMHACNKAC(AGNLOFKLMDO NAJMDMAIPJN, int MBGANDEDPDN);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int PDAAJIFAKDJ(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JLLBINFBBDN KMNBOOFBNGB(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OMFNHHAMOIA(AGNLOFKLMDO NAJMDMAIPJN, JLLBINFBBDN GLKCCNFHICO);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AGNLOFKLMDO HLEBKBNPFEM(AGNLOFKLMDO NAJMDMAIPJN, [Optional] float3? JCMPCLFLJHD, [Optional] quaternion? ECLCOOPOABI, [Optional] float3? OFBFBKPELML);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AGNLOFKLMDO GFIMKHLFOPA(AGNLOFKLMDO NAJMDMAIPJN, int MBGANDEDPDN, [Optional] float3? JCMPCLFLJHD, [Optional] quaternion? ECLCOOPOABI, [Optional] float3? OFBFBKPELML);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HFEIPMNANGP(AGNLOFKLMDO NAJMDMAIPJN, int MBGANDEDPDN);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JMCIHLJJGFM(AGNLOFKLMDO NAJMDMAIPJN);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface EDKMOLEDIBC
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COCHHJNPPGL();

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBCEEAGIANO();

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIHAJLDMMAP();

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMPNFPKCBJK();

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BAEPEDPMDMD();

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DBAEAILKMLP();

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ELFMEBEKKMK();

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ILIOKCJDKDG();

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JOBELJOOAKD();

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KHHDLDBMEMH();

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JEAACLHHDPB();

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KFKPNPMKEPC();
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface BEPMHNBAGLF
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOHDGCALDFE(AGNLOFKLMDO JGFCAMDGBLE, [Out] int PDJKKMEADLE);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPLOCLHJADN(AGNLOFKLMDO JGFCAMDGBLE, int PDJKKMEADLE);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJNBNNGIGIC(AGNLOFKLMDO JGFCAMDGBLE, bool CCMFFLCDHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLFDBNFCGOF(AGNLOFKLMDO JGFCAMDGBLE, bool HLBOLNNFHFB);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KGCNFGIKIOL(AGNLOFKLMDO JGFCAMDGBLE, float OBJNLOEGHBC, float OEIKELFCJGP, float KICGJJMNKOM);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MOINFHFNMPB(AGNLOFKLMDO NAJMDMAIPJN, [Out] float OEIKELFCJGP, [Out] float KICGJJMNKOM);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LFFPPJLAPOI(AGNLOFKLMDO JGFCAMDGBLE, float3 JCMPCLFLJHD, quaternion ECLCOOPOABI);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OPPKAHABBBF(AGNLOFKLMDO JGFCAMDGBLE, [Out] float3 JCMPCLFLJHD, [Out] quaternion ECLCOOPOABI);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface PLFDPOJPHML
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALMHDDEMEBD(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJMCEBCCLFG(Entity ACPAMCNIKHM, [In] float3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 IKIIHLDMHBM(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AKLPLPACOFJ(Entity ACPAMCNIKHM, [In] quaternion EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion KIPLBDKCGFG(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EOKGAPKHENO(Entity ACPAMCNIKHM, [Out] float3 JCMPCLFLJHD, [Out] quaternion ECLCOOPOABI);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOKGAPKHENO(Entity ACPAMCNIKHM, [Out] RigidTransform ENHGCGIKPGP);

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HGGKABJEBAO(Entity ACPAMCNIKHM, [Out] RigidTransform ENHGCGIKPGP);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 LKLLOPEMHML(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NPAOLFCNDDE(Entity ACPAMCNIKHM, [In] float3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LJJOKOBIPBB(Entity ACPAMCNIKHM, float EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float HBJPDJELGJD(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LAGGNIDNOGJ(Entity ACPAMCNIKHM, [In] float3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 DDKLKHNPHBK(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FPNHMDHDGII(Entity ACPAMCNIKHM, [In] float3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 LHDPDGOJCHF(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KLGGJACHHHG(Entity ACPAMCNIKHM, [In] quaternion EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion AFMNOOOICBN(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 FPOFIJLGJEG(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NOJIOKKDCEL(Entity ACPAMCNIKHM, [In] float3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CNIBENAHHBE(Entity ACPAMCNIKHM, float EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float LFINNHGNEPE(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DLFPMLJDNEA(Entity ACPAMCNIKHM, [In] float3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 JBDCAFIEMNO(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FFMGAGNNOBL(Entity ACPAMCNIKHM, [Out] float4x4 MFMCJLFMNOP);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void OIDIKAICGKO(Entity ACPAMCNIKHM, [In] float4x4 MFMCJLFMNOP);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ENLMGHDJBGH(Entity ACPAMCNIKHM, [Out] float4x4 MFMCJLFMNOP);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool OHCPEDEAGCK(Entity ACPAMCNIKHM, [Out] Transform DIFJEPLFOKN);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HPFAIFALMLB(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MJHFGIEKMOG(Entity ACPAMCNIKHM, Entity OEIDFPFMBNF, Entity EBKJLIBKJMN);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class JOKHMEDBKOJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface NONBDFGJCBB
{
	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFDDCKHPCAJ(bool IAMGENCLHPK);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface MAPIBIAOKHO
{
	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World BLPEGFCBPHE(string BGIJOKIMENP = "Main");

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World MKOLAIFLKGN(string BGIJOKIMENP = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World OKEMNAMFIIP(string BGIJOKIMENP = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World HGMOCIGKPLC(string BGIJOKIMENP = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface AMEEJEIIGMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000179")]
	World INKJMJDKEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	World MNPJPIOPNHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	EntityManager NHEHCCGMCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	bool OIOOJDHLJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase FOACIIAFOCA(Type MJMAEGDPBNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class MJNEEBBIJJI
{
	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x621CC50", Offset = "0x621BE50", VA = "0x18621CC50")]
	public static ComponentSystemBase EMJNLMGLEFD(this World OLJBLBEHIAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2953160", Offset = "0x2952360", VA = "0x182953160")]
	public static T FOACIIAFOCA<T>(this AMEEJEIIGMP NKBBCLAAMHP) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface JKILIAMICIC
{
	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCIAKGIFKND(NativeListAsync<Entity> GHFHKDEKJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHPIKDENEBP(KPNKAJNJHJM BOFOPBFFFHB);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBKCPCLNEFG(NativeListAsync<Entity> OJCMAJNMBFB, bool CBCNLOKBILO);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNALBEBDNMN();
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface FGOFALKPMHH
{
	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BLLJNAFHNNB(Collider IGKJJBGCJAA, [Out] AJFACKHGDCO FFNLNILPOEN);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface EJPJAAMGIMB
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NKHGIMAFGFJ(AGNLOFKLMDO NAJMDMAIPJN, [Out] Collider IGKJJBGCJAA);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject JMNMGPLCNNB(AGNLOFKLMDO ADMIJIDEFNK, GameObject GBNEICHJJBP, Vector3 OCBBPFAEPEN, Quaternion IKIEOLKACCC);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBCOCLGDADL(GameObject IGKJJBGCJAA);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider PGJHHCJNGLF<TCollider>(GameObject GGMFKLKMGHN) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHEIPGFANOM(Collider IGKJJBGCJAA);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject LDBKIHMGGAH<TCollider>(string MPENHPFDCDK) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface APAKGEJMCFH
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHCLKBNFJPI(AGNLOFKLMDO NAJMDMAIPJN, JLICOMJJGPO CHIKDPEJOKI, bool AMOHJOIJLBJ, BPEECEOEIPM CGHFICEOCNF);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFPMIKPBBCF(AGNLOFKLMDO NAJMDMAIPJN, JLICOMJJGPO CHIKDPEJOKI, bool AMOHJOIJLBJ, bool ONALDGOGMCK, bool IMGOEABFFEA);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MCFEEEGCMMG GJOHEOPBIFP(AGNLOFKLMDO MFIBAFBMCBA, List<AGNLOFKLMDO> AKOCEIFIIEH);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void APMBMHLCGAM(GameObject OAOOHIIELCL, GameObject OHDGLADCCKP);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJAEAMKIIGF(GameObject OHDGLADCCKP);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T PGJHHCJNGLF<T>(GameObject GGMFKLKMGHN) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HHEIPGFANOM(Collider IGKJJBGCJAA);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject ENFEGGAKJFL<T>(string MPENHPFDCDK) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KCPLGGGBCHP(Collider IGKJJBGCJAA, [Out] AGNLOFKLMDO PDJKKMEADLE);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KLJDDMLCOLL(AGNLOFKLMDO NAJMDMAIPJN, [Out] AJFACKHGDCO FFNLNILPOEN);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface HMBOODGEJEK
{
	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJAHBJFPKEC(AGNLOFKLMDO NAJMDMAIPJN, AGNLOFKLMDO EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABLBDOGEKDF(AGNLOFKLMDO NAJMDMAIPJN, AGNLOFKLMDO EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CFOAOKGNELI(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AGNLOFKLMDO FMAHEHLKPDM(AGNLOFKLMDO NAJMDMAIPJN, int MBGANDEDPDN);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BECPEMBNPON PPDHJPIFNEL(AGNLOFKLMDO NAJMDMAIPJN, Allocator HOJMCOLANAB = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GACKCHJELNJ(AGNLOFKLMDO NAJMDMAIPJN, object GMMJMENGHCD, AGNLOFKLMDO EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NGNLNPHKMBC(AGNLOFKLMDO NAJMDMAIPJN, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FJIAHIMOCGN(AGNLOFKLMDO NAJMDMAIPJN, [Out] AGNLOFKLMDO EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AMBLFBGDEKH(AGNLOFKLMDO NAJMDMAIPJN, float3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PEPDGKKGABO(AGNLOFKLMDO NAJMDMAIPJN, [Out] float3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EBNKJJPBCED(AGNLOFKLMDO NAJMDMAIPJN, float3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BKAPIBMOPOG(AGNLOFKLMDO NAJMDMAIPJN, [Out] float3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FHJELKFHDPL(AGNLOFKLMDO NAJMDMAIPJN, (Quaternion rot, Vector3 moments) OBCPHNOEGPK);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NADBCDOPEHF(AGNLOFKLMDO NAJMDMAIPJN, [Out] quaternion CHNFMIDIJDA, [Out] float3 GKENOIJKPGE);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AKIAIKOIBLP(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 IFKDLILMKIB(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 OOLACGKGMOC(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JPOLEFJEAKM(AGNLOFKLMDO NAJMDMAIPJN, float3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HGPGECLNIDP(AGNLOFKLMDO NAJMDMAIPJN, float3 EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float FPMIFLLLHLC(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float NIKOFPCCIKA(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BNCHNDDEEEC(AGNLOFKLMDO NAJMDMAIPJN, float EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IBAMBHDHFFC(AGNLOFKLMDO NAJMDMAIPJN, float EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode HMJDOBBLDJG(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IOKOCMJAPLI(AGNLOFKLMDO NAJMDMAIPJN, CollisionDetectionMode EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "25")]
	DOAGAABAFKI MAGJMFENLIM(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IKNKHHHAKKI(AGNLOFKLMDO NAJMDMAIPJN, DOAGAABAFKI EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CACGCHAACFC(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OOLGMBGGHHE(AGNLOFKLMDO NAJMDMAIPJN, bool EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	AGNLOFKLMDO ODNFEDJDJEI(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void FAKBOBOFMLD(AGNLOFKLMDO NAJMDMAIPJN, AGNLOFKLMDO EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "31")]
	AGNLOFKLMDO OPAHCEDNAIB(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void DPPHNCDDAIK(AGNLOFKLMDO NAJMDMAIPJN, AGNLOFKLMDO EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "33")]
	BKKIHAGPCJF MHOFGDDIALJ(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void AMMLMPLOBEN(AGNLOFKLMDO NAJMDMAIPJN, BKKIHAGPCJF ACJKHHABOOP);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool EKKHCKHFFIA(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void JLGJFIOGJDB(AGNLOFKLMDO NAJMDMAIPJN, bool EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool CCCFGGDEPHC(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void DGNECKBOLCB(AGNLOFKLMDO NAJMDMAIPJN, bool EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints AFKKHLPJHBG(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void JBCDJNKBLPF(AGNLOFKLMDO NAJMDMAIPJN, RigidbodyConstraints EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float IEAHPCIDLIP(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void EEEEMGIBFCO(AGNLOFKLMDO NAJMDMAIPJN, float EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float JHEIKHFFNFE(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void BDBJFCOCFJK(AGNLOFKLMDO NAJMDMAIPJN, float EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool OCMEFLJAILB(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void JBAIADOGIGH(AGNLOFKLMDO NAJMDMAIPJN, bool EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool EKBDLCMPOLG(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void KMEGPALHJDD(AGNLOFKLMDO NAJMDMAIPJN, bool EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void GDFBNKADONJ(AGNLOFKLMDO NAJMDMAIPJN, int EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "50")]
	AEELDBJLIOI JEGBDIOENAF(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void PNFODEEPMEL(AGNLOFKLMDO NAJMDMAIPJN, AEELDBJLIOI EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "52")]
	OFDDOEGADFI IKMBGEMBMJF(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void CCBPOPMNHLM(AGNLOFKLMDO NAJMDMAIPJN, OFDDOEGADFI EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float ADDFOEEDDMM(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void HNKEPJADPBG(AGNLOFKLMDO NAJMDMAIPJN, float EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void CGAEAAOEIMK(AGNLOFKLMDO NAJMDMAIPJN, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void PHKNMEJHNLE(AGNLOFKLMDO NAJMDMAIPJN, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool FPACEFNCDNL(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void HOHLDKOKCOM(AGNLOFKLMDO NAJMDMAIPJN, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void AHJPLHKIAMB(AGNLOFKLMDO NAJMDMAIPJN, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool JBMFFPLJNCB(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool GAPAEIMENMI(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody GKMBCBJEPBM(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void NHFHHMPHLOB(AGNLOFKLMDO NAJMDMAIPJN, Rigidbody BCOOEAJBGOP);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void FGGEPJLINMM(AGNLOFKLMDO NAJMDMAIPJN, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void EAPMHAHADDB(AGNLOFKLMDO NAJMDMAIPJN, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool ECCHKLGNCHK(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void NHFOFBMJCBA(AGNLOFKLMDO NAJMDMAIPJN, float3 MDKLJOBFIPP);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void CAIIEJEFNIE(AGNLOFKLMDO NAJMDMAIPJN, float3 DIDBDFPOMNO);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool NGBFCECFJBJ(AGNLOFKLMDO NAJMDMAIPJN, [Out] float3 MDKLJOBFIPP);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool EAENOPEOAML(AGNLOFKLMDO NAJMDMAIPJN, [Out] float3 DIDBDFPOMNO);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool DMFCIKABDOL(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void KNAJNDJKJIC(AGNLOFKLMDO NAJMDMAIPJN, object GMMJMENGHCD, bool AHPGPMLNBDI);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void CLKIFPIAJOH(AGNLOFKLMDO NAJMDMAIPJN, bool PAILBAJGLJG);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void HOIFCCCCEEE(AGNLOFKLMDO NAJMDMAIPJN);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool LLNCGNMFCMB(AGNLOFKLMDO NAJMDMAIPJN);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface FJMPEILJCGO
{
	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGACPDOPHCJ(Entity LNCCBKLFDDK);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKBJFAEGIHG(Entity LNCCBKLFDDK);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface HDJHFBBDMDN
{
	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCBHNLPGBCG(AGNLOFKLMDO JGFCAMDGBLE, bool OOBLAOPABIB);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAAKJGAMMLD(AGNLOFKLMDO JGFCAMDGBLE, int KGKDPPPPNGC);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public delegate void FKALFHEMGMO(MNEABBJHKFA AMIFGBHOLPA);
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct MNEABBJHKFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly BECPEMBNPON GKENNNJIOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NativeArray<byte> OAGFINNAPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly NativeArray<byte> ONJFJDBAMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly LFBHDOENOPD KCCIKABICGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly int CNPIAEOPLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly Type MMGLGNDOABP;

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public BECPEMBNPON JBKFCECNNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x905A30", Offset = "0x904C30", VA = "0x180905A30")]
		get
		{
			return default(BECPEMBNPON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x621DAE0", Offset = "0x621CCE0", VA = "0x18621DAE0")]
	public MNEABBJHKFA(BECPEMBNPON GKENNNJIOGG, NativeArray<byte> OAGFINNAPHP, NativeArray<byte> ONJFJDBAMIB, LFBHDOENOPD KCCIKABICGA, int CNPIAEOPLEM, Type MMGLGNDOABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x2956180", Offset = "0x2955380", VA = "0x182956180")]
	public NativeArray<T> BCMHEHDMNEL<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x29562B0", Offset = "0x29554B0", VA = "0x1829562B0")]
	public NativeArray<T> NIMKBCCKHLF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x29561C0", Offset = "0x29553C0", VA = "0x1829561C0")]
	public (BECPEMBNPON, NativeArray<T>, NativeArray<T>) CEIMJGKDJPN<T>() where T : struct
	{
		return default((BECPEMBNPON, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x621DA90", Offset = "0x621CC90", VA = "0x18621DA90")]
	public KDLBOGHAELH FLGPKJMEDGF()
	{
		return default(KDLBOGHAELH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface CGEIMAKACLF
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	string LLAEJDIKKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	CGEIMAKACLF JEPOAKJMFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	IEnumerable<CGEIMAKACLF> PKBJPJMLGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface ABFLMPKFLFH
{
	[Cpp2IlInjected.Token(Token = "0x17000181")]
	CGEIMAKACLF PPDMKHFBCCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	List<KHGPLBOIDDA> COFJGACBMOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GODNIPDONBJ(KHGPLBOIDDA BMIMCNPMKAE, [Out] CGEIMAKACLF MGGCNGMFFHE);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OEPCKJDAMHI(KHGPLBOIDDA BMIMCNPMKAE, FKALFHEMGMO DCJLHHHGCPF);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CIPMPDGKPOP(KHGPLBOIDDA BMIMCNPMKAE, FKALFHEMGMO DCJLHHHGCPF);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public readonly struct KDLBOGHAELH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly MNEABBJHKFA MJGHOBDIDHD;

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public BECPEMBNPON JBKFCECNNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x905A30", Offset = "0x904C30", VA = "0x180905A30")]
		get
		{
			return default(BECPEMBNPON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x621AA20", Offset = "0x6219C20", VA = "0x18621AA20")]
	public KDLBOGHAELH(MNEABBJHKFA MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x621A760", Offset = "0x6219960", VA = "0x18621A760")]
	public BECPEMBNPON BCMHEHDMNEL()
	{
		return default(BECPEMBNPON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x621A950", Offset = "0x6219B50", VA = "0x18621A950")]
	public BECPEMBNPON NIMKBCCKHLF()
	{
		return default(BECPEMBNPON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x621A830", Offset = "0x6219A30", VA = "0x18621A830")]
	public (BECPEMBNPON, BECPEMBNPON, BECPEMBNPON) CEIMJGKDJPN()
	{
		return default((BECPEMBNPON, BECPEMBNPON, BECPEMBNPON));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[DefaultMember("Item")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface MGFEHDFHAIG : IEnumerable<POBGGKBBIKM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000184")]
	NativeBitArray MCOFBJMLALB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	NativeArray<int> LEIPKDFDHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	POBGGKBBIKM KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	POBGGKBBIKM KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	POBGGKBBIKM AMALIIHAHIL(MCMLLJMFIEL CCKNMJLGCHL);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LFBHDOENOPD DIBONDCFNFL(MCMLLJMFIEL CCKNMJLGCHL);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class GAOEGHGNGPP
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
[DefaultMember("Item")]
public interface NAJPGICBJHK : IEnumerable<JONOMCDBBJG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000189")]
	int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	JONOMCDBBJG KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JONOMCDBBJG AMALIIHAHIL(MCMLLJMFIEL CCKNMJLGCHL);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LFBHDOENOPD DIBONDCFNFL(MCMLLJMFIEL CCKNMJLGCHL);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class IEOKHDAPFKA
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x28B85E0", Offset = "0x28B77E0", VA = "0x1828B85E0")]
	public static LFBHDOENOPD DIBONDCFNFL<T>(this NAJPGICBJHK MABGPNCPILM, NKDILCMHFJA<T> MPENHPFDCDK) where T : struct
	{
		return default(LFBHDOENOPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
[DefaultMember("Item")]
public interface KFAGKDNPILL : IEnumerable<KHGPLBOIDDA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	KHGPLBOIDDA KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KHGPLBOIDDA AMALIIHAHIL(MCMLLJMFIEL CCKNMJLGCHL);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LFBHDOENOPD DIBONDCFNFL(MCMLLJMFIEL CCKNMJLGCHL);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class CBCKAEGAMGN
{
	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x26C4F50", Offset = "0x26C4150", VA = "0x1826C4F50")]
	public static IIFKNLBAEGA<T> AMALIIHAHIL<T>(this KFAGKDNPILL MABGPNCPILM, MCMLLJMFIEL MPENHPFDCDK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x26C5090", Offset = "0x26C4290", VA = "0x1826C5090")]
	public static LFBHDOENOPD DIBONDCFNFL<T>(this KFAGKDNPILL MABGPNCPILM, NKDILCMHFJA<T> MPENHPFDCDK) where T : struct
	{
		return default(LFBHDOENOPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface FAEFGOJFLLJ
{
	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEPCKJDAMHI(MCMLLJMFIEL BMIMCNPMKAE, FKALFHEMGMO DCJLHHHGCPF);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIPMPDGKPOP(MCMLLJMFIEL BMIMCNPMKAE, FKALFHEMGMO DCJLHHHGCPF);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class JBIIDAEJDKG
{
	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x28D5F00", Offset = "0x28D5100", VA = "0x1828D5F00")]
	public static void OEPCKJDAMHI<T>(this FAEFGOJFLLJ HIPICDAKCEA, NKDILCMHFJA<T> BMIMCNPMKAE, FKALFHEMGMO DCJLHHHGCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x28D5CE0", Offset = "0x28D4EE0", VA = "0x1828D5CE0")]
	public static void CIPMPDGKPOP<T>(this FAEFGOJFLLJ HIPICDAKCEA, NKDILCMHFJA<T> BMIMCNPMKAE, FKALFHEMGMO DCJLHHHGCPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface GLDMLLNOMNI
{
	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	NIIEPHPICJD ANDIHGBKFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FJEBEGPHEOB(HGKLNILLMDD AIBJMECNKIH, LFBHDOENOPD BMIMCNPMKAE);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMBIGENJOLI(HGKLNILLMDD AIBJMECNKIH, Span<LFBHDOENOPD> MABGPNCPILM, bool BPFJNIMGNKB);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPNMNKEBOBN(NativeArray<HGKLNILLMDD> PHIPEPCMJME);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public static class KMPLHENEIIO
{
	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x621AA50", Offset = "0x6219C50", VA = "0x18621AA50")]
	public static void MMBIGENJOLI(this GLDMLLNOMNI OKFIDFMHBLF, HGKLNILLMDD AIBJMECNKIH, LFBHDOENOPD BMIMCNPMKAE, bool BPFJNIMGNKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public readonly struct NIIEPHPICJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NativeBitArray CKKAKPHOFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly NativeParallelHashMap<HGKLNILLMDD, int> NHFFEJAGEOA;

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public bool EJECNOODHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x621DF20", Offset = "0x621D120", VA = "0x18621DF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0xBDBED0", Offset = "0xBDB0D0", VA = "0x180BDBED0")]
	public NIIEPHPICJD(NativeBitArray CKKAKPHOFPL, NativeParallelHashMap<HGKLNILLMDD, int> NHFFEJAGEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x621DDF0", Offset = "0x621CFF0", VA = "0x18621DDF0")]
	public bool FJEBEGPHEOB(HGKLNILLMDD AIBJMECNKIH, LFBHDOENOPD BMIMCNPMKAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface JFBDLFIKIHL
{
	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AKKBENAFCAC(AGNLOFKLMDO NAJMDMAIPJN, GNCANOLPFEF EKDDCPALANJ);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface EJPOFAIMEOI
{
	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	NJFLAEHPIGP MCIFCAIBDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface CFBICOPFNDA
{
	[Cpp2IlInjected.Token(Token = "0x17000190")]
	Type JICOENMBLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ILGOHFDJPOE(GDOPADDLIHF.LoadInstance)]
public interface KPBJKBJABEC
{
	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMNHOCMPDPD(AGNLOFKLMDO HPEEIPMMJAC, bool EKDDCPALANJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct KOCJEJDODKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IEnumerable<CMIMPALJGEM> EGLPPHANCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IReadOnlyList<GameObject> INCIGNKOEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<int> IJKPIIJNIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IReadOnlyList<(HGKLNILLMDD, HGKLNILLMDD)> IBBLNAFLKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int FEDFAEAGINM;

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public bool DJHIIBCIELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x621AF30", Offset = "0x621A130", VA = "0x18621AF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public int HEHNOFJBADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x95D910", Offset = "0x95CB10", VA = "0x18095D910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public IEnumerable<GameObject> EGIBAJAHAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x8FFBE0", Offset = "0x8FEDE0", VA = "0x1808FFBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public IEnumerable<(HGKLNILLMDD src, HGKLNILLMDD dst)> NFLOECIHMAE
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x621AF90", Offset = "0x621A190", VA = "0x18621AF90")]
	public KOCJEJDODKA(IEnumerable<CMIMPALJGEM> EGLPPHANCHG, IReadOnlyList<GameObject> INCIGNKOEDL, IReadOnlyList<int> IJKPIIJNIPM, IReadOnlyList<(HGKLNILLMDD src, HGKLNILLMDD dst)> IBBLNAFLKII, int FEDFAEAGINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x621ABB0", Offset = "0x6219DB0", VA = "0x18621ABB0")]
	public (GameObject, int)[] FEIABOINHLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface BFKODGMLOLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000195")]
	bool BIDNNEGLCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	bool OGLMPCOGGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	CMFFMKBJDBF OFCMFJJIJMO
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JJDJFFGKLNF CKIANCBOIKF();

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JJDJFFGKLNF LPMOJLAINKG(IEnumerable<AGNLOFKLMDO> BFPFIMOOKDF, [In] UniformTRS CHLHNMOLGBM);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BLHPEHHFLEL HADMIBJKDPC(ByteString FALBDCENAFM);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KHHGENOLHLB NBEBALFADFJ(ByteString DKCIFBLHDJF, AGNLOFKLMDO DLAKBCKOLFN, [In] UniformTRS ODFOPCMGPHF, FJGMPHIEFIN HNKPEDKNONK, bool BKGJNGPGLLK = true);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PMJGHPPEENF();

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KOCJEJDODKA AGLFCBBGBAI(IEnumerable<CMIMPALJGEM> EGLPPHANCHG);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class EJDEKNMOCHE
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface MMBDJOINDJE
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action NMILHPGENLJ;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action EHDMAKDOEIL;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct FPHCLGGHEEC : MHHCOOJIDHE, IEquatable<FPHCLGGHEEC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public AIMLLPOCAAB BCOGJAIKHDP;

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6215410", Offset = "0x6214610", VA = "0x186215410", Slot = "5")]
	public void MAOCPLNNJJM(OBDKNNKGIKC GILMBCDEMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x62153E0", Offset = "0x62145E0", VA = "0x1862153E0", Slot = "4")]
	public void JCBMCDNAHJB(KJBONOLPCBM IBOFEJJMDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x6215440", Offset = "0x6214640", VA = "0x186215440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x88E910", Offset = "0x88DB10", VA = "0x18088E910", Slot = "6")]
	public bool Equals(FPHCLGGHEEC MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6215360", Offset = "0x6214560", VA = "0x186215360", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct HGKLNILLMDD : IComparable<HGKLNILLMDD>, IEquatable<HGKLNILLMDD>, MHHCOOJIDHE
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const uint IAMPNIFGLPH = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public const uint LHFOOMGDLAD = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly HGKLNILLMDD BMBGBFLCPKI;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const int MBFJEGDNNKJ = 24;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const uint IHPLPJGOINO = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const int FBJJEIMMCBN = 8;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private const uint DCOHKJJOHHN = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly uint GNPAJENJDCN;

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public uint DIHECJHMPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x80B0D0", Offset = "0x80A2D0", VA = "0x18080B0D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public uint LJLHDNLHLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x6216910", Offset = "0x6215B10", VA = "0x186216910")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public uint JAIOKBNJHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public bool DJHIIBCIELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6187480", Offset = "0x6186680", VA = "0x186187480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0xD898F0", Offset = "0xD88AF0", VA = "0x180D898F0")]
	public static HGKLNILLMDD BDADGODEGNG(uint GNPAJENJDCN)
	{
		return default(HGKLNILLMDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x6216A20", Offset = "0x6215C20", VA = "0x186216A20")]
	public HGKLNILLMDD(int MMPLLKMIKJL, int GJLHLBGMGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x6216A20", Offset = "0x6215C20", VA = "0x186216A20")]
	public HGKLNILLMDD(uint MMPLLKMIKJL, int GJLHLBGMGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x6216A20", Offset = "0x6215C20", VA = "0x186216A20")]
	public HGKLNILLMDD(uint MMPLLKMIKJL, uint GJLHLBGMGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0")]
	private HGKLNILLMDD(uint GNPAJENJDCN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x18A5D90", Offset = "0x18A4F90", VA = "0x1818A5D90")]
	public static bool FPIEKNKMEBM(HGKLNILLMDD LLLCBODKBAN, HGKLNILLMDD HIOEJKGFIKI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x6216920", Offset = "0x6215B20", VA = "0x186216920")]
	public static bool LEBDJINPIPG(HGKLNILLMDD LLLCBODKBAN, HGKLNILLMDD HIOEJKGFIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x88E910", Offset = "0x88DB10", VA = "0x18088E910", Slot = "5")]
	public bool Equals(HGKLNILLMDD POAELFIOKHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x6216830", Offset = "0x6215A30", VA = "0x186216830", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2323EE0", Offset = "0x23230E0", VA = "0x182323EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x6216990", Offset = "0x6215B90", VA = "0x186216990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x62168B0", Offset = "0x6215AB0", VA = "0x1862168B0", Slot = "6")]
	public void JCBMCDNAHJB(KJBONOLPCBM IBOFEJJMDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6216930", Offset = "0x6215B30", VA = "0x186216930", Slot = "7")]
	public void MAOCPLNNJJM(OBDKNNKGIKC GILMBCDEMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x6135D20", Offset = "0x6134F20", VA = "0x186135D20", Slot = "4")]
	public int CompareTo(HGKLNILLMDD MEJMHKPOODP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct CMIMPALJGEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Guid JJMGPACFMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public string OGBJKBBFCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Vector3 JCMPCLFLJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Quaternion ECLCOOPOABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Vector3 OFBFBKPELML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int DAGIFPDKKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Dictionary<string, object> GLKCCNFHICO;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x6210550", Offset = "0x620F750", VA = "0x186210550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x62103D0", Offset = "0x620F5D0", VA = "0x1862103D0")]
	private static string NFCFIEILMLA(Dictionary<string, object> HOGIEKCHMOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum ILMJCEDMHPC
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class HBFKGDAHBPL
{
	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x56BC030", Offset = "0x56BB230", VA = "0x1856BC030")]
	public static bool PNEJKJIPHNF(this ILMJCEDMHPC MJMAEGDPBNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[Flags]
public enum FGCHKIIFFOJ
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	AdditivePhases = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public interface KHHGENOLHLB : CMFFMKBJDBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	FJGMPHIEFIN PFLCFKKDNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFGPKDDGEPG();

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLHCFIFPJNF();
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public interface CMFFMKBJDBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	IEnumerable<CMIMPALJGEM> MEHLFHFHIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	KOCJEJDODKA IJKJIFMKIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	LocalId IJCDODGJIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	HGIPHEDPPNH JIIHDKLPHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GNDGKBBHPCI(FGCHKIIFFOJ CIMIFNLEFCK);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public interface FJGMPHIEFIN
{
	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PEHLOCLCJDC(Guid NGGIHAOFJPD, [Out] Guid EADBCDOLPOI);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface BLHPEHHFLEL : CMFFMKBJDBF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[Flags]
public enum EKNLBMHPLJM
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface JJDJFFGKLNF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	HGIPHEDPPNH NBPEEDJGHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString HEBKFFHJFLP();
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum GACAMLBPGEI
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public delegate bool KOJHHOKAGBD(INEEDJNOPOG CKIEJKDBFGD, [In] BBEOOLPOLAJ EKDDCPALANJ);
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public delegate bool EODAAJGIJOM<T>(INEEDJNOPOG CKIEJKDBFGD, [In] T EKDDCPALANJ);
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface LFIIHBHJGEO
{
	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEPCKJDAMHI(LFBHDOENOPD KCCIKABICGA, Type EHGAANDDNNM, KOJHHOKAGBD FENOLHHGDJH);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GKBNADBOKGN(LFBHDOENOPD KCCIKABICGA, [Out] KOJHHOKAGBD FENOLHHGDJH);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class MCHAIDCGFDD
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class DCJLDPNFEDI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public EODAAJGIJOM<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public DCJLDPNFEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x5086ED0", Offset = "0x50860D0", VA = "0x185086ED0")]
		internal bool PGAHJGEOELK(INEEDJNOPOG pendingList, [In] BBEOOLPOLAJ value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2932F60", Offset = "0x2932160", VA = "0x182932F60")]
	public static void OEPCKJDAMHI<T>(this LFIIHBHJGEO HIPICDAKCEA, LFBHDOENOPD KCCIKABICGA, EODAAJGIJOM<T> FENOLHHGDJH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x621C250", Offset = "0x621B450", VA = "0x18621C250")]
	public static bool GCEGIFIGMBC(this LFIIHBHJGEO HIPICDAKCEA, INEEDJNOPOG CKIEJKDBFGD, LFBHDOENOPD KCCIKABICGA, [In] BBEOOLPOLAJ EKDDCPALANJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface LCMAKPAPLOK
{
	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	uint MHAGBLBNIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface INEEDJNOPOG
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDLPNLKPCGG(HGKLNILLMDD KGBJGIEEIOH, LFBHDOENOPD KCCIKABICGA, ReadOnlySpan<byte> IGACNMIGONA, ReadOnlySpan<byte> NDFMONDGIGG);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EHNFHPAFLAK(HGKLNILLMDD KGBJGIEEIOH, LFBHDOENOPD KCCIKABICGA);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MLKONEGOPOF(HGKLNILLMDD KGBJGIEEIOH, LFBHDOENOPD KCCIKABICGA, ReadOnlySpan<byte> NDFMONDGIGG);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GKHFJKPLJHL(HGKLNILLMDD KGBJGIEEIOH, LFBHDOENOPD KCCIKABICGA, Span<byte> IGACNMIGONA, Span<byte> NDFMONDGIGG);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class MOMFMBDPBLB
{
	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2956450", Offset = "0x2955650", VA = "0x182956450")]
	public static bool GKHFJKPLJHL<T>(this INEEDJNOPOG GGJHMNCKPGP, HGKLNILLMDD KGBJGIEEIOH, LFBHDOENOPD KCCIKABICGA, [Out] T IGACNMIGONA, [Out] T NDFMONDGIGG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2956600", Offset = "0x2955800", VA = "0x182956600")]
	public static bool MLKONEGOPOF<T>(this INEEDJNOPOG GGJHMNCKPGP, HGKLNILLMDD KGBJGIEEIOH, LFBHDOENOPD KCCIKABICGA, T NDFMONDGIGG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum LAPPDBBGJCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface ENPNGBIDICL
{
	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJLAGNEDHLM(FNHHAGGFKIC HEEIDJMADFG, ReadOnlySpan<byte> JAHJOCBHFCP);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HDHFKAMHJDG(uint GMJCNHOFLBK, ReadOnlySpan<byte> JAHJOCBHFCP);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EJMINGFAILE(int HOHGIEGNLJN);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface OHICFHALADJ
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FNHHAGGFKIC KGNJDFPHMHA(ReadOnlySpan<byte> JAHJOCBHFCP);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface HEBPCGNJKBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFMGMHKCHDI(FNHHAGGFKIC GHBNLDGJPCB, ReadOnlySpan<byte> JAHJOCBHFCP);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APFJIEFMNMC(ReadOnlySpan<FNHHAGGFKIC> HAMHEAKLJHD);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public struct FAKGIOCPOLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public FNHHAGGFKIC HEEIDJMADFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public ReadOnlyMemory<byte> JAHJOCBHFCP;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public struct FNHHAGGFKIC
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public static FNHHAGGFKIC PIEOODAADPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public uint MMPLLKMIKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public int DALMHJJLDIC;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0xAE09D0", Offset = "0xADFBD0", VA = "0x180AE09D0")]
	public FNHHAGGFKIC(uint MMPLLKMIKJL, int DALMHJJLDIC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6214BC0", Offset = "0x6213DC0", VA = "0x186214BC0")]
	public static bool FPIEKNKMEBM([In] FNHHAGGFKIC DEHAFGPDPHM, [In] FNHHAGGFKIC FAFKEFEMLFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x6214B10", Offset = "0x6213D10", VA = "0x186214B10", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x6214BE0", Offset = "0x6213DE0", VA = "0x186214BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x6214C10", Offset = "0x6213E10", VA = "0x186214C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6214B00", Offset = "0x6213D00", VA = "0x186214B00")]
	public void EHCLCENNOFJ([Out] uint MMPLLKMIKJL, [Out] int DALMHJJLDIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface BIMNGLIDCHI : BBGNIHFNLCB<BIMNGLIDCHI>
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AMEEOJPNNKO(LFBHDOENOPD POAELFIOKHK, [Out] AKBDEILLFJJ IMHJIKPNBIG);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class KOLINFMLJOK
{
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public interface AKBDEILLFJJ
{
	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	Type PAOJBGMHIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAOCPLNNJJM(OBDKNNKGIKC GILMBCDEMDA, Span<byte> JGFCAMDGBLE);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCBMCDNAHJB(KJBONOLPCBM IBOFEJJMDAD, ReadOnlySpan<byte> HEEIDJMADFG);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class LGFOMEDPCOL
{
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct GIJIMDHOINM : ISystemStateComponentData, IComponentData, IEquatable<GIJIMDHOINM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 FHLMKMAINFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3 AJBHMLIPMNM;

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x62155F0", Offset = "0x62147F0", VA = "0x1862155F0", Slot = "4")]
	public bool Equals(GIJIMDHOINM MEJMHKPOODP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class HDGKNGCCBDL
{
	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HDGKNGCCBDL()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
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
