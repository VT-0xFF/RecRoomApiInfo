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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82DF880", Offset = "0x82DE480", VA = "0x1882DF880", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FMEGIBDJOEE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x82D5950", Offset = "0x82D4550", VA = "0x1882D5950")]
	public static void EAADILIHOHJ(this Rigidbody OBCMDENLDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x82D5820", Offset = "0x82D4420", VA = "0x1882D5820")]
	public static void EAADILIHOHJ(this Rigidbody OBCMDENLDPE, Vector3 IDECBPFHCOP, Quaternion NBCHBPMFOIO, Vector3 EIMKDFIKFKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct HFAACADMMPC : IReadOnlyList<CFFDHOCCNNL>, IEnumerable<CFFDHOCCNNL>, IEnumerable, IReadOnlyCollection<CFFDHOCCNNL>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct JEIHCPFDCNE : IEnumerator<CFFDHOCCNNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly HAOJOPIKEAB AMCCDFCIJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator MBBNOHOAAJD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CFFDHOCCNNL ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x82DB5E0", Offset = "0x82DA1E0", VA = "0x1882DB5E0", Slot = "4")]
			get
			{
				return default(CFFDHOCCNNL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x82DB590", Offset = "0x82DA190", VA = "0x1882DB590", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5449190", Offset = "0x5447D90", VA = "0x185449190")]
		public JEIHCPFDCNE(HAOJOPIKEAB AMCCDFCIJGE, NativeArray<LocalId>.Enumerator MBBNOHOAAJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82DB4D0", Offset = "0x82DA0D0", VA = "0x1882DB4D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82DB510", Offset = "0x82DA110", VA = "0x1882DB510", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82DB550", Offset = "0x82DA150", VA = "0x1882DB550", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly JHEPOKDHIGJ PHMFHDLJBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> KNEMEBLIDKG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CFFDHOCCNNL KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82D6E10", Offset = "0x82D5A10", VA = "0x1882D6E10", Slot = "4")]
		get
		{
			return default(CFFDHOCCNNL);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82D6940", Offset = "0x82D5540", VA = "0x1882D6940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int BLMGBFKJMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B110", Offset = "0xA59D10", VA = "0x180A5B110", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HAOJOPIKEAB BFFFNMCIFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82D6240", Offset = "0x82D4E40", VA = "0x1882D6240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PIELHOLGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5B110", Offset = "0xA59D10", VA = "0x180A5B110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool AKCFPEAFOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x82D6200", Offset = "0x82D4E00", VA = "0x1882D6200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> KHIGHPJMLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2C26E00", Offset = "0x2C25A00", VA = "0x182C26E00")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> KIIOCOJKMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82D6790", Offset = "0x82D5390", VA = "0x1882D6790")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x82D6B60", Offset = "0x82D5760", VA = "0x1882D6B60")]
	public HFAACADMMPC(int FJNGONEOHID, HAOJOPIKEAB AMCCDFCIJGE, Allocator HPEAGMDCCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82D6CC0", Offset = "0x82D58C0", VA = "0x1882D6CC0")]
	public HFAACADMMPC(JHEPOKDHIGJ PHMFHDLJBOO, NativeArray<LocalId> KNEMEBLIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82D6A80", Offset = "0x82D5680", VA = "0x1882D6A80")]
	public HFAACADMMPC(JHEPOKDHIGJ PHMFHDLJBOO, NativeArray<Entity> KNEMEBLIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x82D6CD0", Offset = "0x82D58D0", VA = "0x1882D6CD0")]
	internal HFAACADMMPC(HAOJOPIKEAB AMCCDFCIJGE, NativeArray<Entity> ADEOCFOIFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82D6AF0", Offset = "0x82D56F0", VA = "0x1882D6AF0")]
	internal HFAACADMMPC(HAOJOPIKEAB AMCCDFCIJGE, NativeArray<LocalId> KNEMEBLIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x82D6C10", Offset = "0x82D5810", VA = "0x1882D6C10")]
	public HFAACADMMPC(HAOJOPIKEAB AMCCDFCIJGE, int LBLBECEIAEC, Allocator HPEAGMDCCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82D6D60", Offset = "0x82D5960", VA = "0x1882D6D60")]
	public HFAACADMMPC(HFAACADMMPC BPIFLCBNPJD, Allocator HPEAGMDCCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82D6370", Offset = "0x82D4F70", VA = "0x1882D6370")]
	public void IMHILHBHKJC(List<CFFDHOCCNNL> ADEANPNALNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82D6680", Offset = "0x82D5280", VA = "0x1882D6680")]
	public void LOBGHBMDKEK(int LCCBBMBENOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82D65E0", Offset = "0x82D51E0", VA = "0x1882D65E0")]
	public HFAACADMMPC JEKMEOOFFAJ(Allocator HPEAGMDCCBL)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82D67F0", Offset = "0x82D53F0", VA = "0x1882D67F0")]
	public Span<CFFDHOCCNNL> MMIEANGHFML()
	{
		return default(Span<CFFDHOCCNNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82D62D0", Offset = "0x82D4ED0", VA = "0x1882D62D0")]
	public HFAACADMMPC GGOOPFJGKCP(int LJEEMMFNMLE, int LBLBECEIAEC)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82D6290", Offset = "0x82D4E90", VA = "0x1882D6290", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x82D66D0", Offset = "0x82D52D0", VA = "0x1882D66D0")]
	public JEIHCPFDCNE MIEHOANGBJG()
	{
		return default(JEIHCPFDCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82D69A0", Offset = "0x82D55A0", VA = "0x1882D69A0", Slot = "6")]
	private IEnumerator<CFFDHOCCNNL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82D6A10", Offset = "0x82D5610", VA = "0x1882D6A10", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CLKEIKDKPCL
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3A431C0", Offset = "0x3A41DC0", VA = "0x183A431C0")]
	public static OOJKGBPAOPB<T> IHEJJJIGIJB<T>(this HFAACADMMPC OJNBCCCOMPJ) where T : Component
	{
		return default(OOJKGBPAOPB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct PMBDFDDDFGF : IList<CFFDHOCCNNL>, ICollection<CFFDHOCCNNL>, IEnumerable<CFFDHOCCNNL>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct BPFDACPMGIB : IEnumerator<CFFDHOCCNNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly HAOJOPIKEAB AMCCDFCIJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator MBBNOHOAAJD;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CFFDHOCCNNL ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x82D0750", Offset = "0x82CF350", VA = "0x1882D0750", Slot = "4")]
			get
			{
				return default(CFFDHOCCNNL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x82D0700", Offset = "0x82CF300", VA = "0x1882D0700", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5449190", Offset = "0x5447D90", VA = "0x185449190")]
		public BPFDACPMGIB(HAOJOPIKEAB AMCCDFCIJGE, NativeArray<LocalId>.Enumerator MBBNOHOAAJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82D0640", Offset = "0x82CF240", VA = "0x1882D0640", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82D0680", Offset = "0x82CF280", VA = "0x1882D0680", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82D06C0", Offset = "0x82CF2C0", VA = "0x1882D06C0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HAOJOPIKEAB AMCCDFCIJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> KNEMEBLIDKG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CFFDHOCCNNL KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82E44A0", Offset = "0x82E30A0", VA = "0x1882E44A0", Slot = "4")]
		get
		{
			return default(CFFDHOCCNNL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82E4590", Offset = "0x82E3190", VA = "0x1882E4590", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x82E4070", Offset = "0x82E2C70", VA = "0x1882E4070", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PIELHOLGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82E4070", Offset = "0x82E2C70", VA = "0x1882E4070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> KHIGHPJMLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2C26E00", Offset = "0x2C25A00", VA = "0x182C26E00")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool OBFGHCLKFON
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82E4420", Offset = "0x82E3020", VA = "0x1882E4420")]
	public PMBDFDDDFGF(HAOJOPIKEAB AMCCDFCIJGE, Allocator HPEAGMDCCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x82E4390", Offset = "0x82E2F90", VA = "0x1882E4390")]
	public PMBDFDDDFGF(HAOJOPIKEAB AMCCDFCIJGE, int LBLBECEIAEC, Allocator HPEAGMDCCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x82E3AB0", Offset = "0x82E26B0", VA = "0x1882E3AB0")]
	public HFAACADMMPC BFJODDLEDOK()
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x82E3BC0", Offset = "0x82E27C0", VA = "0x1882E3BC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82E3C00", Offset = "0x82E2800", VA = "0x1882E3C00", Slot = "13")]
	public bool Contains(CFFDHOCCNNL BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82E3C90", Offset = "0x82E2890", VA = "0x1882E3C90", Slot = "14")]
	public void CopyTo(CFFDHOCCNNL[] COJHNLDFDFB, int FPBBDMPMMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82E3A30", Offset = "0x82E2630", VA = "0x1882E3A30", Slot = "11")]
	public void Add(CFFDHOCCNNL BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82E3F30", Offset = "0x82E2B30", VA = "0x1882E3F30", Slot = "7")]
	public void Insert(int LCCBBMBENOH, CFFDHOCCNNL BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x82E4100", Offset = "0x82E2D00", VA = "0x1882E4100", Slot = "15")]
	public bool Remove(CFFDHOCCNNL BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x82E3EA0", Offset = "0x82E2AA0", VA = "0x1882E3EA0", Slot = "6")]
	public int IndexOf(CFFDHOCCNNL BHNJKAEPJMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x82E40B0", Offset = "0x82E2CB0", VA = "0x1882E40B0", Slot = "8")]
	public void RemoveAt(int LCCBBMBENOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x82E3E60", Offset = "0x82E2A60", VA = "0x1882E3E60", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x82E3FE0", Offset = "0x82E2BE0", VA = "0x1882E3FE0")]
	public BPFDACPMGIB MIEHOANGBJG()
	{
		return default(BPFDACPMGIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x82E41D0", Offset = "0x82E2DD0", VA = "0x1882E41D0", Slot = "16")]
	private IEnumerator<CFFDHOCCNNL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x82E42B0", Offset = "0x82E2EB0", VA = "0x1882E42B0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GKBAKNMACAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CFFDHOCCNNL OKNCLAGAFJN(CFFDHOCCNNL KNEMEBLIDKG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IBDDAFILEOJ : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface MMAOPHOBLCK : CDLLNHLPKAI, DFPKEHOKJNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	PPEMOEKBADK JHOCHMGIFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JHEPOKDHIGJ GHGJCDLHFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface DFPKEHOKJNP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool FDGMPPBDHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface MHIIKGIOOFK
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBOAJPAOKJJ(bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAGLLFMPLGJ();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface LAMIMBLAFHD
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool CEAIFBKEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CJDKEBAHBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool HOHJPJNCGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool GGPFNIDLJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MAKNHAADLPF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DKLBEDCECHN(bool PMENEMBMEBK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NONGJKKBBDM(ByteString CHJABLHNCBP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PCBIKFIFDME();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HHIGDDPANKG();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GDHPGEKDFPM();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface ONGKNFGGJFK
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	MDHHMAKNOBB JHOCHMGIFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	BMPBIBDAOCD BMHAIKEPMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	DEPFOAJEOEC AAOCEAGKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	MMAOPHOBLCK EADNHPCBLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	OJDCMNHFLLI APKOBKLOBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	LAMIMBLAFHD ILBMFLNDIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ONEIBFNCCHG FLOOCCFFBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	GABJLHJEELJ IJNOHOMMJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	HDGLCOCHNOP AJJFGBJCLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	PAAJHIOLAGJ PLCEFDJJMGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	GLINBMAHDKN EMODEOKACKL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CPIJBHEGONL FDDJLONDPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	HAOJOPIKEAB BFFFNMCIFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CIHNBDDKDMO DNJCJJCBNNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	HHNLABFNIMA EOJGHJOMNAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HDKKEEJGDGJ LECBCNHPPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	IOICPHKDPDL NGGLJLKDBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	HEALBKDPMHD INIILKEEFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	OKKGAIPBFID MLFJAGBDEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	FDFOLCHEFDL FAPDLLGCAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	PNJILNBIGJH DAEBLMHJJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NCECDAJCGGB GLBCOKNBHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BLFGILFBOLO MGICNGHMFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	ICOBLIPELEK CLLLOFKNFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	PGJKJDGHCDD PNEOFHHMAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	EFHDEPNHOPK GABOMDLKBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	JNOEMKCMLEI OKOPCAMLDFB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	DDHLMFDNOPE MLGFNFKLABB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CEIPIGHCEMM JPLMMJNGMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PDDKMNNKOGD DIBKDNINLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	NEHCHGFCBMB JOHECPKFAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	JAAAEPMFELN DPCMCHNFMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MGFNGEKLBMB JPCHFIEPDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GCEHPGJMNCC HGIAIEFKKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CLBOLGMGHEH HEIMFENBOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	MCFDCEMMENA GLIIMEPBKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	LKMCAJFDHNO NEGNIDMLALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	LCGJIAHIHJG EKFBMHDBLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	ILGKAEGOOCA HKAHOMPLHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	EJCMHKCPHKA OEDIOCBJHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(NCGJBNDALLO))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct CFFDHOCCNNL : IComparable<CFFDHOCCNNL>, IEquatable<CFFDHOCCNNL>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly CFFDHOCCNNL DNKJCLIALLN;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int DNKBKLPKBAN = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int ALHJGPGGFNM = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int DMBNCDPPIKM = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int BKNEGDBJEHF = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId ILPOHEPFNOO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public HAOJOPIKEAB BFFFNMCIFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x82CB1F0", Offset = "0x82C9DF0", VA = "0x1882CB1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public MMAOPHOBLCK EADNHPCBLFL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x82D0D10", Offset = "0x82CF910", VA = "0x1882D0D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LocalId NGHFCIGNAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x82D0C00", Offset = "0x82CF800", VA = "0x1882D0C00")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal JHEPOKDHIGJ GHGJCDLHFJK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x82D0820", Offset = "0x82CF420", VA = "0x1882D0820")]
		get
		{
			return default(JHEPOKDHIGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool GDLGKCEKPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x82D0D70", Offset = "0x82CF970", VA = "0x1882D0D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private bool CLGIBMBCAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x82D0C40", Offset = "0x82CF840", VA = "0x1882D0C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x82D1050", Offset = "0x82CFC50", VA = "0x1882D1050")]
	public CFFDHOCCNNL(HAOJOPIKEAB EHGIIJNBGDJ, LocalId ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x82D0FC0", Offset = "0x82CFBC0", VA = "0x1882D0FC0")]
	public CFFDHOCCNNL(JHEPOKDHIGJ PHMFHDLJBOO, LocalId ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
	public MDCMDKHFPFC EACAEDNDGFH()
	{
		return default(MDCMDKHFPFC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x82D0C90", Offset = "0x82CF890", VA = "0x1882D0C90")]
	public static LocalId KDDDGPNBGLG(CFFDHOCCNNL OEEPIJMJAIL)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x82D0CD0", Offset = "0x82CF8D0", VA = "0x1882D0CD0")]
	public static Entity KDDDGPNBGLG(CFFDHOCCNNL OEEPIJMJAIL)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x82D0830", Offset = "0x82CF430", VA = "0x1882D0830")]
	public static bool CDGFDPOPEPC(CFFDHOCCNNL JPILOOHOBDJ, CFFDHOCCNNL MAKDDCFIOBO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x82D0BE0", Offset = "0x82CF7E0", VA = "0x1882D0BE0")]
	public static bool IECKAGJENEB(CFFDHOCCNNL JPILOOHOBDJ, CFFDHOCCNNL MAKDDCFIOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x82D0E90", Offset = "0x82CFA90", VA = "0x1882D0E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x82D0A40", Offset = "0x82CF640", VA = "0x1882D0A40", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82D0950", Offset = "0x82CF550", VA = "0x1882D0950", Slot = "4")]
	public int CompareTo(CFFDHOCCNNL IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "5")]
	public bool Equals(CFFDHOCCNNL IIOGPDPGOLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LMAOGIEGGFD
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x82DF7D0", Offset = "0x82DE3D0", VA = "0x1882DF7D0")]
	public static BPKOKGNGCMF AFPOCKCICDE(this CFFDHOCCNNL KOJLNGLNBMH)
	{
		return default(BPKOKGNGCMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class NCGJBNDALLO
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct JHEPOKDHIGJ : IEquatable<JHEPOKDHIGJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte PHMFHDLJBOO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] PFNBMKKIEIH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static HAOJOPIKEAB IDJIKPIJGHG;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static MMAOPHOBLCK OOAOFJIJLFN;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static HAOJOPIKEAB[] FKOLDBMDDPL;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static MMAOPHOBLCK[] HHKAPJPPMBN;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> EJIHLMAAFNK;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public MMAOPHOBLCK EADNHPCBLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x82DBEF0", Offset = "0x82DAAF0", VA = "0x1882DBEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public HAOJOPIKEAB EAHKJBDABPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x82DC410", Offset = "0x82DB010", VA = "0x1882DC410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x82DC670", Offset = "0x82DB270", VA = "0x1882DC670")]
	static JHEPOKDHIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2C574C0", Offset = "0x2C560C0", VA = "0x182C574C0")]
	internal JHEPOKDHIGJ(byte BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7126370", Offset = "0x7124F70", VA = "0x187126370", Slot = "4")]
	public bool Equals(JHEPOKDHIGJ IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x82DBE30", Offset = "0x82DAA30", VA = "0x1882DBE30", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x103E1F0", Offset = "0x103CDF0", VA = "0x18103E1F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x82DC5B0", Offset = "0x82DB1B0", VA = "0x1882DC5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x82DC500", Offset = "0x82DB100", VA = "0x1882DC500")]
	private static HAOJOPIKEAB NGEMCCGGNBK(byte PHMFHDLJBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x82DC360", Offset = "0x82DAF60", VA = "0x1882DC360")]
	private static MMAOPHOBLCK LPEIMGMGABF(byte PHMFHDLJBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x82DBC40", Offset = "0x82DA840", VA = "0x1882DBC40")]
	private static object CLLKJNKHGJL(byte PHMFHDLJBOO, object[] OKFGGFMLPHB, object PLEDLJICBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x82DBED0", Offset = "0x82DAAD0", VA = "0x1882DBED0")]
	private static int HHNCHMHAIBM(byte PHMFHDLJBOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x82DC4F0", Offset = "0x82DB0F0", VA = "0x1882DC4F0")]
	private static int NDPBAPKILJE(byte PHMFHDLJBOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x82DBDB0", Offset = "0x82DA9B0", VA = "0x1882DBDB0")]
	private static (int, int) EDBMJLOAELD(byte PHMFHDLJBOO)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x82DBEE0", Offset = "0x82DAAE0", VA = "0x1882DBEE0")]
	private static byte JEKBLGOPGME(int LAHAJPPAFND, int LCCBBMBENOH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x82DB980", Offset = "0x82DA580", VA = "0x1882DB980")]
	internal static JHEPOKDHIGJ AMHLLDBNIFP(MMAOPHOBLCK PEIABBHLIBK, HAOJOPIKEAB LAIPFPANCHE)
	{
		return default(JHEPOKDHIGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x82DB770", Offset = "0x82DA370", VA = "0x1882DB770")]
	internal static void ADKBIHLFMAC(JHEPOKDHIGJ PHMFHDLJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x82DBFD0", Offset = "0x82DABD0", VA = "0x1882DBFD0")]
	private static void LMFNEABJPHC(int FJNGONEOHID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum OGIAEDJOMGB
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
public interface GAIEMDHANKE
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool JIBMBPPAKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool APJEOAMOEEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool BFHOONFJFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool IIDFKBANGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool MFLODLLIEHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MLIGPCIEABE
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGOFELHLPON(DGEDCENCDGH EHEGCBFMKDA, int LCCBBMBENOH);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KAHJFPDCFAL(DGEDCENCDGH EMAKJAIKEPK, int LCCBBMBENOH);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DKOLPBGPBHB(MAAIGLGFMMK FHLIDMKCHPE, int LCCBBMBENOH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EBJMFCBAMHD : DGEDCENCDGH, GAIEMDHANKE
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int AMOBOJACOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOFEHLKHAPD(KGHACIJFGHG MIEJLCKINFM, int LCCBBMBENOH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DGEDCENCDGH : GAIEMDHANKE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum IPKNPNPGFDG
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
	bool MJHGHOIOKOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool GHAHCGFBLGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool LBHGMDDPOME
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KGHACIJFGHG
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool GONBDGDBPOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	LDLEEKNJJFJ AEDPIPKDNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	CEIGAKLELBA AAFLKNNKEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 BCBKGNPANPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	quaternion EFKBKJCNDBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float3 CBMLEOEPLHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	MEKNHMCLLHC HLAFGCCNOEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	PFELNBBIHNK MEHMDJKIAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float LOIJJKBLKAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float3 OMCNAKDLEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float LNNCLHLMEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	EHENCINGLKE PGBEBHMACKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface LCBBDELFFFK
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float3 IFBKCLIOOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float3 EPICMNANIEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion OCLNCOLHMLN(float3 MJKEFOMPECH);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CEIGAKLELBA
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool JKMDJDJCGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool PFJLFFLPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool DHEBGNPKEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float JPEGBLFKKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int IAAPJBOFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int PEBGOIJADNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IFOIANLPKKK(LCBBDELFFFK MIEJLCKINFM, int LCCBBMBENOH);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.OMRoom)]
public class HFEGHIHEMMC
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public HFEGHIHEMMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface MKMIIHMFIBF
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Guid KNKIHMHHMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JICNIBJBOJE(Guid GEKIMFCLJBA, Guid LJOMDKEKAFC, Guid DDLGALIOCJD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task ONONJNNGGBA(Guid GEKIMFCLJBA, Guid[] NOOHKFPEOOD, Guid DDLGALIOCJD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid JKMLAONDKLK(Guid DJIIOAADINA);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PFHLIALBKFN(CFFDHOCCNNL CPIOKEOEGHA);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JOMPJOOOLNI(Guid DJIIOAADINA);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NBENMDFPKLJ(ECBIPLOOBIL FHHNHOMPJKC, Guid LDAKAFDNCPO);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BFJBHKNAKAB(Guid DJIIOAADINA, bool PMENEMBMEBK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ECPFDODPGEO(Guid DJIIOAADINA, BPKOKGNGCMF PGCHNMPLKPP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AJPFIJBABNM(BPKOKGNGCMF PGCHNMPLKPP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HMHLCPCAINN(CFFDHOCCNNL ILPOHEPFNOO);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface HAHMMNIOMKC
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface FJGHAPEPJNB
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "0")]
	void ALIIMNHHAMJ(bool MNGLOBMLMGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface BMPBIBDAOCD
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	FJGHAPEPJNB IBOCOOGICMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	HGDPKLHFCMD OFBOFIOOCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	CHJIFEFOJJB NBGGDPCAGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	PLCOELJFMPK AGBFGHOJLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	DMBKBLEPJHM OLHGCKPMNDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	FCJBNFIOPCK FDDMLPDKMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	NLMEDMPCFMH JMNHEHADOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	NNOLIGOKEPL HEIEIKGFEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface HGDPKLHFCMD
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	string INKDEDMNNLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface DDJJBEAOBKC
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLMHPAOACCI(Action KLIEOOEGDML, bool KCKOAEBDGGL);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KLHEBEKHBJO(string BKILENEPEEB);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int MGLLFAFCJDK(string BKILENEPEEB, int PLEDLJICBFM);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FODNIIOMBKK([Out] bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CGOEOIHLCDI([Out] bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BBLFBDDPINN([Out] int BKMPCFIAHIG);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface CHJIFEFOJJB
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "0")]
	void NJHCLGAIAFD(bool PMENEMBMEBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface PLCOELJFMPK
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid ACNMIFIGKFF;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid CFFPDKCMPJN;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid FCMMNBIJKCE;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid MDHOGABPHJB;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool KFGLCLCMLHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool GBJPHBGMPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool GFMIBCMGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool LIJCCGGAOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x82E3880", Offset = "0x82E2480", VA = "0x1882E3880", Slot = "4")]
	string[] KJJAJKHJDPD(KFMAIGOOEPB NGFHOPNCFAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNKOPJPJAML();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x82E3850", Offset = "0x82E2450", VA = "0x1882E3850", Slot = "6")]
	Guid JNBBKCGMOFD(Guid FNPGMKGBNAA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int FALOCPPGDOA(KFMAIGOOEPB NGFHOPNCFAM);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LFBCNJKCEIL(KFMAIGOOEPB NGFHOPNCFAM, NativeArray<JJBOLCJLIKH> JJMEFBCEAMK, NativeList<UniformTRS> HDIPAGHHFGK);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int HELBBALHBMO(Guid FHNOHJCOOKK);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AANJBLNIKNM(string HNHFKFKDOJD, [Out] Guid FHNOHJCOOKK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string OEOLPPHCNDG(Guid FHNOHJCOOKK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MFHMHIEJGON(RRObjectPrefabData FFMAIOGFMIM, [Out] LocalId CGLPEGHHGMM);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OOJKGBPAOPB<byte[]> CAHNBLDFCMC(NativeArray<JJBOLCJLIKH> OEBJPMIJJIO);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JNIENPPCBLE(byte[] GDOKDMAJLDK);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GameObject AHNJCOHIJOL(string HNHFKFKDOJD);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AEPPHJBBAJN(Transform LMGPODOPMIJ, RRObjectPrefabData NMNIKOOMGOG, HBNCMEMJHAL PBHLPKLGFAP);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool DFJFPEMKKKM(KFMAIGOOEPB NGFHOPNCFAM, NativeParallelHashMap<Guid, LocalId> PPJMGCAEEEI, [Out] Exception BIBIMCAHIHC);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NPGJDCKPKFK(KFMAIGOOEPB NGFHOPNCFAM, NativeParallelHashMap<Guid, LocalId> PPJMGCAEEEI, [Out] NativeArray<LocalId> ADEOCFOIFAB, [Out] NativeArray<LocalId> PDBLAMJNJNC, [Out] NativeArray<AuthoredLocalPoseData> CHJCPLJLOJB, Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "19")]
	void EDMLBNNDOAP(KFMAIGOOEPB NBKNOAMHHFE, NativeArray<int> GDAKBDENKPG, EAICLJOGAIB<GameObject> PFIPBDLOHGG, OOJKGBPAOPB<GameObject> JPLCCHEGJMK, OGIAEDJOMGB OIHIBIMJCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EAHJPPBGMOG();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "21")]
	void JCGBKLAFFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "22")]
	void PLAGBKHNEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "23")]
	bool BNEOGIDCJMB(KFMAIGOOEPB NGFHOPNCFAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "24")]
	MLIGPCIEABE FEGFABOPGNP(KFMAIGOOEPB NGFHOPNCFAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "25")]
	void OKOLJPDCDGM(Guid HFPHIDDCINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "26")]
	bool OLLAOMJIKEM(Guid HFPHIDDCINP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x82E3910", Offset = "0x82E2510", VA = "0x1882E3910")]
	static PLCOELJFMPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface BNOOENBCKFB
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	long ABKDBAGMHLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long CLCLCLNLGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface DMBKBLEPJHM
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool LAJILHFCAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool NGBAEODMNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int OLKCOIECONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int BNKBEMIBMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int AJJDBBDHLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool APCANAIKDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	int HBOJDMEOJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "6")]
	void OINAJLFMNJC(DLBHCBOPGBF NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
	void LGNNDLNAHNG(bool NKIJGFONKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "8")]
	bool DDKOLBEEDBI(MKFFFMAICOP LHBOIGHHIJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "9")]
	void DGMKJCKGMKH(object HGBKIACHBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "10")]
	void PBEFJOLOPIF(object HGBKIACHBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GCKBKHDIGGI(Action<object> CLEBGGPHHOE);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GCADPEGKGOJ(Action<object> CLEBGGPHHOE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "13")]
	void DDFMEOGELNE(NativeArray<ViewId> GGFAAKGCPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "14")]
	void HKGLNIEFODI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "15")]
	void GHENBKDCBOB(MBKGIBNAPNI MDCDODCGNEK, ReadOnlySpan<byte> CBCNBAPLLJM, MKFFFMAICOP HPFELNLMLAB, bool GEFINJBNOHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "16")]
	void GHENBKDCBOB(MBKGIBNAPNI MDCDODCGNEK, ReadOnlySpan<byte> AAHNEDHPNLK, bool GEFINJBNOHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "17")]
	void GHENBKDCBOB(MBKGIBNAPNI MDCDODCGNEK, ReadOnlySpan<byte> AAHNEDHPNLK, ReadOnlySpan<byte> EPAJPBLLFAM, bool GEFINJBNOHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "18")]
	void PMODIMFOLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "19")]
	void KCNBHKIHGNG(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "20")]
	void PMIICFAOAGF(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "21")]
	void IOJHFHPJDHE(Dictionary<object, object> EKLMMLNOIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "22")]
	void APOKJEDGPMO(NativeList<BPKOKGNGCMF> KIBOGMNAFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "24")]
	void KIMIIEIPOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "25")]
	void MNCIOKICPGG(List<object> BNIPHBJIACN, int FAHOKHGHPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "26")]
	void CLIMNNMEODK(int GGJFPBCNGPL, object CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "27")]
	void CHIHNLLIHJB(MKFFFMAICOP LHBOIGHHIJM, Dictionary<object, object> FDEACFJBFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "28")]
	void LBEFNIAHEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "29")]
	void KEPIBEOJAHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class NJPLMGEFACO
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x82E27F0", Offset = "0x82E13F0", VA = "0x1882E27F0")]
	public static NMLIOPAPKMO HKBLMMBGKME(this DMBKBLEPJHM IEAEJIDPCDO, object DANCOEFIHDF)
	{
		return default(NMLIOPAPKMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct NMLIOPAPKMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private DMBKBLEPJHM IEAEJIDPCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object DANCOEFIHDF;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x82E29A0", Offset = "0x82E15A0", VA = "0x1882E29A0")]
	public NMLIOPAPKMO(DMBKBLEPJHM IEAEJIDPCDO, object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x82E2950", Offset = "0x82E1550", VA = "0x1882E2950", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OCLDEINPEGJ
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void PJBMIGBHLFB(ViewId ECLEFOAKJDA, IHJNLMEPEBP OIOIIPDCDNE, int NGJLHELIFON);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "0")]
	void JCFIDBBIPMM(PJBMIGBHLFB MMMAIEFFLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "1")]
	void LHOEAFBHNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "2")]
	void AOFJGLLMHFH(OIIDHFILPMC PJIJGMLMHGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface JMBDEGCCPAK
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[ServiceLifetime(Lifetime.Application)]
public interface FCJBNFIOPCK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct HJCNNABFPJN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private FCJBNFIOPCK GAKOHDNEBJK;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x82D7070", Offset = "0x82D5C70", VA = "0x1882D7070")]
		public HJCNNABFPJN(FCJBNFIOPCK GAKOHDNEBJK, string JNKLGPOIBON, string JLIEEILPBGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x82D6FB0", Offset = "0x82D5BB0", VA = "0x1882D6FB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct FKOGFNEFPEG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private FCJBNFIOPCK GAKOHDNEBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task MHGNKNMAFFC;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x82D57D0", Offset = "0x82D43D0", VA = "0x1882D57D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "0")]
	void EJMBDOOMDLG(string HLMEMBFCHLD, float AADMIAHAPGN = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "1")]
	void JEHGKMOCINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFEKLIPHHFE(bool HOAKHBIFGOG, string JNKLGPOIBON, string JLIEEILPBGK);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "3")]
	void GIJLDBIAKAA(string HLMEMBFCHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DIICJPNGLPP
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x82D3790", Offset = "0x82D2390", VA = "0x1882D3790")]
	public static FCJBNFIOPCK.HJCNNABFPJN MABIKGPOLBA(this FCJBNFIOPCK IEAEJIDPCDO, string JNKLGPOIBON, string JLIEEILPBGK)
	{
		return default(FCJBNFIOPCK.HJCNNABFPJN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface KHFBNFCLCKJ
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JOHHHDEMGAB(GameObject HLOIBGDKPID);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHOOJEJPKIA(GameObject HLOIBGDKPID);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NMEDAPFCELC(int LHBOIGHHIJM);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object BHLMNILAMJE(CFFDHOCCNNL ILPOHEPFNOO, GameObject HLOIBGDKPID, Action<CFFDHOCCNNL, int> HFBNHPDLHHL);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFEGKDNGPKA(GameObject HLOIBGDKPID, object HAHBOEPMNJI);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FLDHHDMDJEI
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIIKDGPJAKO(MJOIKADLMGF BKDDIFICJED, LGMDOCAFNFL KIJEMPCDPPF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface MNLMBGGHJCO
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBHGMJKEMBG(object KOJLNGLNBMH, NativeList<byte> CBCNBAPLLJM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object GLDNKJDIMCO(NativeArray<byte> CBCNBAPLLJM);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface OOHLDCILEIJ
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool LFEEFHHGBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate FDJAALHICCO(JJDJNNFCKLB FGOAEBKAAAD, Action<JJDJNNFCKLB> HFBNHPDLHHL);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGNLKCDAKCJ(JJDJNNFCKLB FGOAEBKAAAD, Delegate HFBNHPDLHHL);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate DHCNBMEMCAK(JJDJNNFCKLB FGOAEBKAAAD, Action<JJDJNNFCKLB> DBJHPOCIGJL);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HOOGNPEHJAL(JJDJNNFCKLB FGOAEBKAAAD, Delegate HFBNHPDLHHL);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PJIDGBEFLKK(JJDJNNFCKLB FGOAEBKAAAD);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JJDJNNFCKLB FOAJAAOBDFM(GameObject HLOIBGDKPID);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface CADFINPLKLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int MLOHOAAMHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	int PDMMKKKJFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool LAJILHFCAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool IPEBANPEFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool PJOPDKEEGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CFFDHOCCNNL DCAJJIECLIB(int LHBOIGHHIJM);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FFHECMNGDPC(GameObject IBIDBOEEAIP, JobHandle MPJNGABBNFM);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface IFHAPBABDCM
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIIKDGPJAKO(int JGGIBDMAPLG, LGMDOCAFNFL AHOPMNICLDC);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface NLMEDMPCFMH
{
	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool CEAIFBKEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface CDLMMLHCEPH
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	CDDCNNEAHAH LNGPPJAFPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	ANFGPDFLLEL KLALOGMANPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool MMEIAHOPBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOBFDLILMMK(Transform LMGPODOPMIJ);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHCKBKOJLKL(Transform LMGPODOPMIJ, KEFCOOGBPIF MFPGEFPGPEJ);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KJFLCJPLLCJ(Transform LMGPODOPMIJ, HEODKAOIMMP AFOHEDFHHBI);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface NNOLIGOKEPL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action EBCGNMGBOMP;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface FBHAHEMALBJ
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIADOIOGAHE();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[ServiceLifetime(Lifetime.Application)]
public interface MPGKGEPKACJ
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFCDNDOFKHD(GameObject HLOIBGDKPID, GOFNDNICMIL DOMAPHJLNIB, IKHNFFIHEKH GNOKLOLCLLA);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OHNNLEDFGAD(CFFDHOCCNNL ILPOHEPFNOO, bool IOOHPJBALFD, float3 AJBHHAGGKKF, quaternion EHNPJDMKNEM);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool COMFJPFMPBN(HFAACADMMPC CEDGCCCJBCH);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CKIGFJJHBII(MDCMDKHFPFC JAOGNEOIMGK, MDCMDKHFPFC ADGCHNLKFKK, MCKGLJLILAB MEGBHLJHDNE);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBACAKHALLN(MDCMDKHFPFC JAOGNEOIMGK, MCKGLJLILAB MEGBHLJHDNE);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FADPABGMLDD(HFAACADMMPC CNIIOHAAHJB);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MCMGHPMJHDB(KFMAIGOOEPB MOPLHOCDFJF, ReadOnlySpan<Guid> CCGPFFNLMFF, ReadOnlySpan<int> LDHKIHABGDJ, OOJKGBPAOPB<GameObject> MIGNPJCGFIH);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CCOGCOHGICP(FEFKONOOGAB GAHJODIGGJP);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OIMMAAFHGDP(MLPELMEJHIH CMGHDGICAGO, MLPELMEJHIH HKKIMLJCMIF);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CHDNFBLGBON(MLPELMEJHIH CMGHDGICAGO, MLPELMEJHIH HKKIMLJCMIF);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MFBJAPPLCPG(CFFDHOCCNNL IOIBFJENFLD);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct DCGJENOGEJK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> CBCNBAPLLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle PHMFHDLJBOO;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x82D2330", Offset = "0x82D0F30", VA = "0x1882D2330")]
	public DCGJENOGEJK(ReadOnlyMemory<byte> NFGNMIBGLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x82D22F0", Offset = "0x82D0EF0", VA = "0x1882D22F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum DAHFBHBGMHI
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
public struct KFMAIGOOEPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString CIPNFCGHOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object JOACPCOADCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object NEHLADHDNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> PFOELIGNOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool DDHIGAKMLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public IACOGKDGFJE.AOAMECMHOMK? FLBKOHPELCK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x82DD1B0", Offset = "0x82DBDB0", VA = "0x1882DD1B0")]
	public KFMAIGOOEPB(ByteString CIPNFCGHOKL, [Optional] object JOACPCOADCB, [Optional] object NEHLADHDNAB, [Optional] IEnumerable<string> PFOELIGNOEE, bool DDHIGAKMLOP = true, [Optional] IACOGKDGFJE.AOAMECMHOMK? FLBKOHPELCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct NHNKCJDFJCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object AGMGLAJABCA;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct JJBOLCJLIKH
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Flags]
	public enum HPHLOGCJLMN
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
	public RRObjectPrefabData HCNOFOGDHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid MJIIKICHOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid CMNEFCGMOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid OBOGICCIAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid OMGIGENNLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public HPHLOGCJLMN HHPCFHFLKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 MEBKAKPBGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int ICLIAEHPAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public LAPPBOKJFEA FMMDKDHOGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int HLJPPNJMOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int GAHKPAOGGEP;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Guid ABKMFGMFNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5449F70", Offset = "0x5448B70", VA = "0x185449F70")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool FFAEOLIAKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x82DC680", Offset = "0x82DB280", VA = "0x1882DC680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool DPJKMHFLFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x82DC6B0", Offset = "0x82DB2B0", VA = "0x1882DC6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool AGDEFEMDMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x82DC690", Offset = "0x82DB290", VA = "0x1882DC690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool FNHBFGOOIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x82DC6A0", Offset = "0x82DB2A0", VA = "0x1882DC6A0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct BLDFFGKFMFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly ENEIMOCMAIO LJEEMMFNMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly ENEIMOCMAIO MAFBAKDLLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly uint FCEPMHAGCDF;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x82CF850", Offset = "0x82CE450", VA = "0x1882CF850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct MHMCIJJPNCF
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly BLDFFGKFMFB KLIEOOEGDML;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x82DC930", Offset = "0x82DB530", VA = "0x1882DC930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct JOBGDKGAHID
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly BLDFFGKFMFB KLIEOOEGDML;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x82DC930", Offset = "0x82DB530", VA = "0x1882DC930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct OEKIBPCCBAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly uint FCEPMHAGCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly bool GGHBLBJBFOC;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x82E2A30", Offset = "0x82E1630", VA = "0x1882E2A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct ENEIMOCMAIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal int HDEKJKJDEIC;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x82D4D20", Offset = "0x82D3920", VA = "0x1882D4D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[ServiceLifetime(Lifetime.Application)]
public interface EBLANIBPNDI
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	LAPCDFLBCOP LDNJJPLOFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface ECBIPLOOBIL
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface HLEJDDFJIKG
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class PBFJHKDILJK
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3E07BE0", Offset = "0x3E067E0", VA = "0x183E07BE0")]
	public static MDCMDKHFPFC EACAEDNDGFH<T>(this T ILPOHEPFNOO) where T : ECBIPLOOBIL
	{
		return default(MDCMDKHFPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x82E2BF0", Offset = "0x82E17F0", VA = "0x1882E2BF0")]
	public static MonoBehaviour ICEHJHCLMEN(this ECBIPLOOBIL ILPOHEPFNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x82E2C70", Offset = "0x82E1870", VA = "0x1882E2C70")]
	public static GameObject LKABGMIDCKE(this ECBIPLOOBIL ILPOHEPFNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface HLHFLHGKHEB : ECBIPLOOBIL
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(CFFDHOCCNNL LNPPHFKBHPJ);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface DCBGDBIAHBF : ECBIPLOOBIL
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FMEDDJHIOCB
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate void MDDFNEGDNFC(BNLECOAIEIB JOLMPMPKPFJ);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event MDDFNEGDNFC PIGIMFHFDFF;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface CDDLCOIIAOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface GLMGEEDFKHK
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface KOHAGOCCJDH
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(CFFDHOCCNNL AGJCFNGKJHA);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool BKAOBDMOGPO);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EFJIAMKGHKH(CFFDHOCCNNL DBEBLODPEEN);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface OHKCOHOBNND
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(HAGJDPFPLEP JPJPGHBAJDP);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface HAGJDPFPLEP
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	GameObject HLOIBGDKPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Transform LMGPODOPMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	CEKLINLDBIH LOOLMPAGOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool JDKOBFPNHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LANCAEBILOK(CEKLINLDBIH EIFNOCFPPHB);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HDIANNLONJN GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class AGEGECPKDBM
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x82CC140", Offset = "0x82CAD40", VA = "0x1882CC140")]
	public static void NGHODLJLPPC(this HAGJDPFPLEP HOAOIBONAAE, HBNCMEMJHAL PBHLPKLGFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface CEKLINLDBIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Rigidbody PMNEJLBAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	HAGJDPFPLEP IBNBDEMMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	GameObject LKABGMIDCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	Transform AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	CEKLINLDBIH CCBOMPENMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	CEKLINLDBIH AMCBICJEEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	int NECJKPCNJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	bool CAHBCLGMMLH
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	bool PJIDGBEFLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool JHBJJHAFIOO
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	EJBNNOGLELE BMPAMCJNMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	KHBKNBENECM EPBIIECPPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	float PFEGNGGGEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Vector3 AMDMGIFFLMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 NFFPEAGEGMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 HGMBOAAPBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 GHBMHGJDHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool ICGDNMHNKII
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool NAIMFOOJIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool PFPHEKLBOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool CDFAGPGKFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Vector3 FABOEKFBBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Vector3 AICFMLECCOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 GCNKCLAILKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Vector3 ICBPPCKNBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	float KCNLEBIFBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	float LDBMPJOKFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Vector3 MBMECPLEMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Quaternion NNJPNMKDKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	float CELIGADKLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float PGCNBHPEPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool EENJDGCHOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	CFBMCAPEOOJ HMFLAPHOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	bool ANMAKICIKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	Transform GLDHBONKBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	Vector3 JMDAEAGPOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	float ABHHLMFPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	float PNPNMBHHMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	Quaternion FABGMLDCLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Vector3 IFBKCLIOOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Quaternion MNNHAPKBCKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	RigidbodyConstraints BEJNLFNPDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	bool PPILPIAEABO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	CollisionDetectionMode KAABIOCDHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	bool KPJILPMBBBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KDFLOOJFLHN MACKADHCHOH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KDFLOOJFLHN PKELLEMGAGL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KDFLOOJFLHN KBHEDGMHFHA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event KDFLOOJFLHN AOGCOCHNMCH;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event KDFLOOJFLHN FPONHHIEHIG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KDFLOOJFLHN LKINGNCHJDN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KDFLOOJFLHN JKNHPKPBNPA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MILLMPDEFNN CNNKFACOEDF;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<AFJPHDDPDEH, AFJPHDDPDEH> GMAIEGKLGNB;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CEKLINLDBIH BFGJLKKPLNE(int LCCBBMBENOH);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void GJMBNHOMFAE((Quaternion rot, Vector3 moments) EJBGAGMOFGM);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void ONFOCPIMDHM();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void BONJIOFKLNF();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void NFEBDHLMMEO();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void DCPLJGLHOAN();

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void NLEACNAAILG();

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void PLPIOCHBPFK(CEKLINLDBIH BKMPCFIAHIG, bool EBMHMKKDKEC = false);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void GJJNANBCHIL(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void FFDLEPMPADF(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 JBAHILFFAAI(Vector3 ICMJMFHDHFK);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 JDIDCCAMIDB(Vector3 CCLLMHLHBKA);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void MPEDPLGIDOC();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void HNCFODKEKDL();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void AAFFFJAFDNH();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void IMPMLNLNEBI(Vector3 EBAFNFHBEDD, Vector3 AEJLGCCIIMH);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void EEEIEBHMPGI(Vector3 PLOCPBPGBGG, Vector3 LFGIFPMDCKJ);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void PDLLFBAMNBN(Vector3 ELHAEEMJDEC);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void JNJCJDMBOOA(PCHGDODKJCD IECKMLOLLAN, Vector3 LBNBIHKIOIO, float HHHBDIGBKHH, float GNKOCPBPGOP = 8f, float CDMKNLFCMMB = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void OJPAEDLNLIM(IKFAIOFMFBF ADADEDHMFPP, Vector3 OIHODILJFBC, float KPJKKEJMCJB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void AJFHCOLINMN(IKFAIOFMFBF ADADEDHMFPP, Vector3 DINDLKHALMD, float PAGFHHDENOC = 7f, float ADHDDLNAIBP = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 NFNKMEFHGOJ(Vector3 BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 KJOCHDKPJGB(Vector3 BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void HLLCNPIJCKM();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void IHILOPDDPEC(CEKLINLDBIH NBDKHHCCEKD, object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void EDGPOGJHMIB(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void PBCPOACMOCA();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void KFPIDAKOPLJ();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void MLFMMCGKDJF();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool DHPGIJPNDIH();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void OMFOFKNHABI();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void JDODPBODCKL(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void FGDECALMIGB(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void KPGOPEHNJMM(object DANCOEFIHDF, bool ECALHGIKDNF);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void DPDKEHJIDJD(Vector3 MNKBKFBLFHE, Quaternion EOAIOFAPIOG);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void BCHHLEDJLAP(Vector3 NNAMNFGCMPA, Quaternion KMDPOPFNNLD);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool MKNEHCNEFEP(float MPBOAKIOADM);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void DDHJKLMIPMN(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void OLEKAAGHADB(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void PMBPNBLIEBN(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void FGJJNLGGGMM(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void FAEKOHELFJN(Vector3 GPAPPOJDLEG, ForceMode AMEHCBIAODE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void KFEAIHHIIJM(Vector3 GPAPPOJDLEG, Vector3 FEMJLOIOGIK, ForceMode AMEHCBIAODE);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void BDGNECNFKAL(Vector3 MIKOHEOLMMB, ForceMode AMEHCBIAODE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void PEODOFOLCED(Vector3 MIKOHEOLMMB, ForceMode AMEHCBIAODE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool LEKOBKOCPOJ(Vector3 DBIJDHDPOAF, [Out] RaycastHit JBNHJJJOKID, float FKJNFPHAHOE);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void KDLPNIDDPNH();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface KHBKNBENECM
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class JBIPDJIHKFK : KHBKNBENECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public JBIPDJIHKFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "0")]
	void PKBHIJJDEGB(Vector3 CLLLIELHJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "1")]
	void BFDDMKKNCMJ(Vector3 JGLAFHCCNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "2")]
	void NIJPIFBHECM(Vector3 CLLLIELHJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "3")]
	void IIFGPMKMKKP(Vector3 JGLAFHCCNMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface EJBNNOGLELE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 KPKHHAHAGPG();

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 NKPDMLGDLLJ();

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EGKKLCIOMLK(float EIMCADGNNHE, float IOMHEFDJGGD);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate void KDFLOOJFLHN(HAGJDPFPLEP GNHPLAPIGKN);
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum IDHANGGOJNM
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
public enum PCHGDODKJCD
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
public delegate void MILLMPDEFNN(HAGJDPFPLEP GNHPLAPIGKN, bool EBMHMKKDKEC = false);
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum IKFAIOFMFBF
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct HDIANNLONJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Rigidbody DOFJCHNPJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public object IECIOIOJDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 HEBFOFDKFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector3 OGFANHGPNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public KEMCMOHNHFH GHPLEABLMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool FIPLHLNPBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool APMHOEDAJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool FMHOEIGGBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool IFHNOGNGOFL;
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct MDCMDKHFPFC : IEquatable<MDCMDKHFPFC>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly MDCMDKHFPFC GLBIMMPBNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public GameObject HLOIBGDKPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x82E00E0", Offset = "0x82DECE0", VA = "0x1882E00E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public BPKOKGNGCMF OENOEBEDEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x82DFDF0", Offset = "0x82DE9F0", VA = "0x1882DFDF0")]
		get
		{
			return default(BPKOKGNGCMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public BHNGGMAMCBI GIABJFDOFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x82E0580", Offset = "0x82DF180", VA = "0x1882E0580")]
		get
		{
			return default(BHNGGMAMCBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public RRObjectPrefabData JDOHNIIMJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x82DFF30", Offset = "0x82DEB30", VA = "0x1882DFF30")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool LBGCMPKHHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x82E0620", Offset = "0x82DF220", VA = "0x1882E0620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool GKMGPHINMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x82E07B0", Offset = "0x82DF3B0", VA = "0x1882E07B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool GONBDGDBPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x82DFD00", Offset = "0x82DE900", VA = "0x1882DFD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool PDMKLNAHLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x82E0790", Offset = "0x82DF390", VA = "0x1882E0790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool PBLOLLKBEDG
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x82DFE90", Offset = "0x82DEA90", VA = "0x1882DFE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool FNPBEBBAFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x82E07D0", Offset = "0x82DF3D0", VA = "0x1882E07D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool HNGCBJFDBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x82E09A0", Offset = "0x82DF5A0", VA = "0x1882E09A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool PONLPFILEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x82E0440", Offset = "0x82DF040", VA = "0x1882E0440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool PIHOBLOANCL
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x82E0750", Offset = "0x82DF350", VA = "0x1882E0750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool MJEBJKBOOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x82E0640", Offset = "0x82DF240", VA = "0x1882E0640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool FGGIHINJDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x82E0300", Offset = "0x82DEF00", VA = "0x1882E0300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool KPCGNEMDALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x82DFDB0", Offset = "0x82DE9B0", VA = "0x1882DFDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool FNGMOFIMMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x82E0060", Offset = "0x82DEC60", VA = "0x1882E0060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool CLAGKMIMDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x82DFD70", Offset = "0x82DE970", VA = "0x1882DFD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool NJLIAGNDCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x82E06D0", Offset = "0x82DF2D0", VA = "0x1882E06D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool EBNEHDGJHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x82E0540", Offset = "0x82DF140", VA = "0x1882E0540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DDHCPOOFOLM IAOIJFKPLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(DDHCPOOFOLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public NBCMACFEBFO LMGODLGJNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(NBCMACFEBFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public IIMLEJPEJDA DNJCJJCBNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(IIMLEJPEJDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public JMGHLGNHAOF AAOOKKCGLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(JMGHLGNHAOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public KOEEHGMFJPO DLBEDAMINDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(KOEEHGMFJPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public LCMBPCHHFEH MELPFNPOEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(LCMBPCHHFEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public PFKHNFHFFMA PJKILPIFMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(PFKHNFHFFMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public DPHBMGBKAJG OKPFDEMJEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(DPHBMGBKAJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public GKLLFBANFEG DGIEGHHPGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(GKLLFBANFEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public IJBBGHINNKP EOJGHJOMNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(IJBBGHINNKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public EACPMNNFNPD IAOBJGOCBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(EACPMNNFNPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public HNEFFIGADIC OPIKGNKMDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(HNEFFIGADIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public FIMJEDFDOKC BNCPPABIKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(FIMJEDFDOKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public BGGMLNGAMJB HFNOLDCPOBI
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(BGGMLNGAMJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public BMOOGCDFCJI IEFFGHBKFOF
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(BMOOGCDFCJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool BKLBJHGCPJP
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x82E0840", Offset = "0x82DF440", VA = "0x1882E0840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool OOEFPJGEBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x82E0710", Offset = "0x82DF310", VA = "0x1882E0710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public bool PDEJODKAKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x82E0800", Offset = "0x82DF400", VA = "0x1882E0800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool GDLGKCEKPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x82E0A30", Offset = "0x82DF630", VA = "0x1882E0A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool KAEDIJPDFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x82E00A0", Offset = "0x82DECA0", VA = "0x1882E00A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool MNPABLLHLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x82E0500", Offset = "0x82DF100", VA = "0x1882E0500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool AALOKGFICPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x82E0960", Offset = "0x82DF560", VA = "0x1882E0960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public BJNKJNJOKOA AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(BJNKJNJOKOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public INJIKEOENHH PLCEFDJJMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(INJIKEOENHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private HAOJOPIKEAB BFFFNMCIFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x82CB1F0", Offset = "0x82C9DF0", VA = "0x1882CB1F0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static MDCMDKHFPFC KDDDGPNBGLG(CFFDHOCCNNL LNPPHFKBHPJ)
	{
		return default(MDCMDKHFPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x82DFEB0", Offset = "0x82DEAB0", VA = "0x1882DFEB0")]
	public PCHNCFLHIJE CLBMONLGIBK()
	{
		return default(PCHNCFLHIJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x82E0930", Offset = "0x82DF530", VA = "0x1882E0930")]
	public HKBILPJPHPE OIBHCCAPILH()
	{
		return default(HKBILPJPHPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x82DFD20", Offset = "0x82DE920", VA = "0x1882DFD20")]
	public HOJNODHJJPG ADBEPMFMLME()
	{
		return default(HOJNODHJJPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x82E0480", Offset = "0x82DF080", VA = "0x1882E0480")]
	public MMIFLOOOPPF IADBBIFFIIE()
	{
		return default(MMIFLOOOPPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x82E0B80", Offset = "0x82DF780", VA = "0x1882E0B80")]
	public BKCLEIBINBC PNDJAPKHBBH()
	{
		return default(BKCLEIBINBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x82E09E0", Offset = "0x82DF5E0", VA = "0x1882E09E0")]
	public NHCPKAIJKGO OPOIIBFGMIP()
	{
		return default(NHCPKAIJKGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x82E0680", Offset = "0x82DF280", VA = "0x1882E0680")]
	public MLPELMEJHIH LDHCKECHNPP()
	{
		return default(MLPELMEJHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x82E04B0", Offset = "0x82DF0B0", VA = "0x1882E04B0")]
	public KICELJKDEPF JEKEFMIGBAC()
	{
		return default(KICELJKDEPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x82E0BD0", Offset = "0x82DF7D0", VA = "0x1882E0BD0")]
	public MIEDBDGKCEP PNPLLHOAGNO()
	{
		return default(MIEDBDGKCEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x82E0340", Offset = "0x82DEF40", VA = "0x1882E0340")]
	public void FMJAPFNONKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x82E0A40", Offset = "0x82DF640", VA = "0x1882E0A40")]
	public void PCEOKDJFDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x82E0AE0", Offset = "0x82DF6E0", VA = "0x1882E0AE0")]
	public bool PNADBPNIPEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x82E0C20", Offset = "0x82DF820", VA = "0x1882E0C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public MDCMDKHFPFC(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x82D1EA0", Offset = "0x82D0AA0", VA = "0x1882D1EA0")]
	public static bool KDDDGPNBGLG(MDCMDKHFPFC BKMPCFIAHIG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static CFFDHOCCNNL KDDDGPNBGLG(MDCMDKHFPFC BKMPCFIAHIG)
	{
		return default(CFFDHOCCNNL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x82D1690", Offset = "0x82D0290", VA = "0x1882D1690")]
	public static bool CDGFDPOPEPC(MDCMDKHFPFC JPILOOHOBDJ, MDCMDKHFPFC MAKDDCFIOBO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x82D0BE0", Offset = "0x82CF7E0", VA = "0x1882D0BE0")]
	public static bool IECKAGJENEB(MDCMDKHFPFC JPILOOHOBDJ, MDCMDKHFPFC MAKDDCFIOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x82E0270", Offset = "0x82DEE70", VA = "0x1882E0270", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(MDCMDKHFPFC IIOGPDPGOLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct FIMJEDFDOKC : IEquatable<FIMJEDFDOKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private GCEHPGJMNCC CGKBFDNMADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x82D5400", Offset = "0x82D4000", VA = "0x1882D5400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x82D50C0", Offset = "0x82D3CC0", VA = "0x1882D50C0")]
	public void BJMDEOHGGAI(uint OIBGADINDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x82D4FC0", Offset = "0x82D3BC0", VA = "0x1882D4FC0")]
	public bool BHBFAPONLGG([Out] uint OIBGADINDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x82D56D0", Offset = "0x82D42D0", VA = "0x1882D56D0")]
	public bool PGICMAODKPJ([Out] uint OIBGADINDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x82D55E0", Offset = "0x82D41E0", VA = "0x1882D55E0")]
	public void NLHKNEOOJFE(string OIBGADINDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x82D51C0", Offset = "0x82D3DC0", VA = "0x1882D51C0")]
	[CanBeNull]
	public string BONFIOEEHLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x82D5460", Offset = "0x82D4060", VA = "0x1882D5460")]
	public bool NEEBHKOKEAM([Out] string BAEFNJGLAII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x82D5360", Offset = "0x82D3F60", VA = "0x1882D5360")]
	public void HAPNDEPEHPN(string BAEFNJGLAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public FIMJEDFDOKC(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x82D52D0", Offset = "0x82D3ED0", VA = "0x1882D52D0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(FIMJEDFDOKC IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct DDHCPOOFOLM : IEquatable<DDHCPOOFOLM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private ONEIBFNCCHG GNJKPAHHMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x82D3370", Offset = "0x82D1F70", VA = "0x1882D3370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private GCEHPGJMNCC HGIAIEFKKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x82D34F0", Offset = "0x82D20F0", VA = "0x1882D34F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public bool HFAIBPLEEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x82D2D20", Offset = "0x82D1920", VA = "0x1882D2D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool GGCKIPBIEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x82D2E50", Offset = "0x82D1A50", VA = "0x1882D2E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool GONMAPFHEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x82D31B0", Offset = "0x82D1DB0", VA = "0x1882D31B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Guid GJGLCPBKELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x82D2F20", Offset = "0x82D1B20", VA = "0x1882D2F20")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Guid LKAPADFKEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x82D3710", Offset = "0x82D2310", VA = "0x1882D3710")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Guid IAFOOBDFGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x82D2FA0", Offset = "0x82D1BA0", VA = "0x1882D2FA0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public INJIKEOENHH PLCEFDJJMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(INJIKEOENHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x82D3550", Offset = "0x82D2150", VA = "0x1882D3550")]
	public bool NLINEPGACNO([Out] Guid DJIIOAADINA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x82D2DB0", Offset = "0x82D19B0", VA = "0x1882D2DB0")]
	public bool BMHLFMJLJEF([Out] Guid LJOMDKEKAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x82D33D0", Offset = "0x82D1FD0", VA = "0x1882D33D0")]
	public void NDJNAPAKIHH(Guid PINMHDANIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x82D3270", Offset = "0x82D1E70", VA = "0x1882D3270")]
	public void LCDOLNECGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x82D35F0", Offset = "0x82D21F0", VA = "0x1882D35F0")]
	public Guid OJABBIPHILE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public DDHCPOOFOLM(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x82D2E90", Offset = "0x82D1A90", VA = "0x1882D2E90", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(DDHCPOOFOLM IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct HOJNODHJJPG : IEquatable<HOJNODHJJPG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private HDGLCOCHNOP HJMLLMNBHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x82D8600", Offset = "0x82D7200", VA = "0x1882D8600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Vector3 MIAOBAODKMO
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x82D8040", Offset = "0x82D6C40", VA = "0x1882D8040")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Quaternion HCCKJAINDHM
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x82D88A0", Offset = "0x82D74A0", VA = "0x1882D88A0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public MDCMDKHFPFC PNLKBDIDDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x82D8810", Offset = "0x82D7410", VA = "0x1882D8810")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x82D84A0", Offset = "0x82D70A0", VA = "0x1882D84A0")]
	public HFAACADMMPC DKHAJGIEPLH(Allocator HPEAGMDCCBL)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x82D8660", Offset = "0x82D7260", VA = "0x1882D8660")]
	public bool IICCDMALIJC(MDCMDKHFPFC IEPNOLIPIDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x82D8350", Offset = "0x82D6F50", VA = "0x1882D8350")]
	public void CEMOJOGNLGI(Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x82D8700", Offset = "0x82D7300", VA = "0x1882D8700")]
	public void JLGGFENFABN(float ECJMFFOLCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x82D8190", Offset = "0x82D6D90", VA = "0x1882D8190")]
	public void CCNFMIADFLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public HOJNODHJJPG(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x82D1EA0", Offset = "0x82D0AA0", VA = "0x1882D1EA0")]
	public static bool KDDDGPNBGLG(HOJNODHJJPG BKMPCFIAHIG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static CFFDHOCCNNL KDDDGPNBGLG(HOJNODHJJPG BKMPCFIAHIG)
	{
		return default(CFFDHOCCNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x82D8570", Offset = "0x82D7170", VA = "0x1882D8570", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(HOJNODHJJPG IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct PCHNCFLHIJE : IEquatable<PCHNCFLHIJE>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly PCHNCFLHIJE GLBIMMPBNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private PAAJHIOLAGJ KAFPCDHPFLL
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x82E31D0", Offset = "0x82E1DD0", VA = "0x1882E31D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<MDCMDKHFPFC> LPOCBIDNPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x82E3340", Offset = "0x82E1F40", VA = "0x1882E3340")]
		get
		{
			return default(Span<MDCMDKHFPFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public string FEGHCLOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x82E3440", Offset = "0x82E2040", VA = "0x1882E3440")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x82E3230", Offset = "0x82E1E30", VA = "0x1882E3230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public BJNKJNJOKOA AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(BJNKJNJOKOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public INJIKEOENHH PLCEFDJJMGA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(INJIKEOENHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x82E2D30", Offset = "0x82E1930", VA = "0x1882E2D30")]
	public void BGLJPCIJAJB(PCHNCFLHIJE IIOGPDPGOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public PCHNCFLHIJE(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x82D1EA0", Offset = "0x82D0AA0", VA = "0x1882D1EA0")]
	public static bool KDDDGPNBGLG(PCHNCFLHIJE BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x82E32B0", Offset = "0x82E1EB0", VA = "0x1882E32B0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(PCHNCFLHIJE IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static MDCMDKHFPFC KDDDGPNBGLG(PCHNCFLHIJE JBDFDFABHKD)
	{
		return default(MDCMDKHFPFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DefaultMember("Item")]
public struct JAAFJCNEMDM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> LDOBEDEHEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private PECJBNMGEAA CDGDEPGDFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool BCHGIOMMOEN;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		[CompilerGenerated]
		readonly get
		{
			return default(MDCMDKHFPFC);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public LDDCABDMBLN KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x82DB340", Offset = "0x82D9F40", VA = "0x1882DB340")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x82DB400", Offset = "0x82DA000", VA = "0x1882DB400")]
	internal JAAFJCNEMDM(MDCMDKHFPFC KOJLNGLNBMH, bool BCHGIOMMOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x82DB0F0", Offset = "0x82D9CF0", VA = "0x1882DB0F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF980", Offset = "0x3CBE580", VA = "0x183CBF980")]
	public void FBPLMOFAHPD<T>(LDDCABDMBLN DHCHBFGMFFD, T BKMPCFIAHIG, [Optional] T PLEDLJICBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x82DB220", Offset = "0x82D9E20", VA = "0x1882DB220")]
	public void ENKPLOICKCM(LDDCABDMBLN DHCHBFGMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0xAF3D80", Offset = "0xAF2980", VA = "0x180AF3D80")]
	public Dictionary<int, object> KPCADEIONMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x82DB2D0", Offset = "0x82D9ED0", VA = "0x1882DB2D0")]
	private readonly void JNACCIFKJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class JEJEDPLKDIB
{
	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x82DB6B0", Offset = "0x82DA2B0", VA = "0x1882DB6B0")]
	public static JAAFJCNEMDM FPKFLOAJIEF(this MDCMDKHFPFC KOJLNGLNBMH)
	{
		return default(JAAFJCNEMDM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct BGGMLNGAMJB : IEquatable<BGGMLNGAMJB>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly BGGMLNGAMJB GLBIMMPBNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private bool FGGIHINJDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x82CC6F0", Offset = "0x82CB2F0", VA = "0x1882CC6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 NOHMHPDOADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x82CC730", Offset = "0x82CB330", VA = "0x1882CC730")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x82CC7E0", Offset = "0x82CB3E0", VA = "0x1882CC7E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x82CC8C0", Offset = "0x82CB4C0", VA = "0x1882CC8C0")]
	public Vector3 PNOBDLFPJCJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x82CC840", Offset = "0x82CB440", VA = "0x1882CC840")]
	public void OPNGFGLAJOL([In] Vector3 BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x82CC530", Offset = "0x82CB130", VA = "0x1882CC530")]
	public void AHPIAICDICH([In] Vector3 BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x82CC5B0", Offset = "0x82CB1B0", VA = "0x1882CC5B0")]
	public bool COMNOIHGFML([In] Vector3 BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public BGGMLNGAMJB(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x82CC660", Offset = "0x82CB260", VA = "0x1882CC660", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(BGGMLNGAMJB IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x82CC940", Offset = "0x82CB540", VA = "0x1882CC940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct PGEHONILMDK : IEquatable<PGEHONILMDK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x82E3670", Offset = "0x82E2270", VA = "0x1882E3670", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(PGEHONILMDK IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct KICELJKDEPF : IEquatable<KICELJKDEPF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private LKMCAJFDHNO NEGNIDMLALK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x82DD490", Offset = "0x82DC090", VA = "0x1882DD490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool JNNDCKJOPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x82DD4F0", Offset = "0x82DC0F0", VA = "0x1882DD4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool OIBFHDEEAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x82DD920", Offset = "0x82DC520", VA = "0x1882DD920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public DOFJCKMAEFH PADKIFMEGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x82DD7E0", Offset = "0x82DC3E0", VA = "0x1882DD7E0")]
		get
		{
			return default(DOFJCKMAEFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool OJEHIOMLDDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x82DDA50", Offset = "0x82DC650", VA = "0x1882DDA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool BEJAOHKNPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x82DDA90", Offset = "0x82DC690", VA = "0x1882DDA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool OIGAENHOLNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x82DD230", Offset = "0x82DBE30", VA = "0x1882DD230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x82DD2C0", Offset = "0x82DBEC0", VA = "0x1882DD2C0")]
	public bool AIMNMGDEPOE(KICELJKDEPF GLBPCBNDLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x82DD360", Offset = "0x82DBF60", VA = "0x1882DD360")]
	public bool EBOAHHMEFOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x82DD740", Offset = "0x82DC340", VA = "0x1882DD740")]
	public bool LGEDOKHELPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x82DD620", Offset = "0x82DC220", VA = "0x1882DD620")]
	public ReadOnlySpan<CFFDHOCCNNL> KLBALCHFCNK()
	{
		return default(ReadOnlySpan<CFFDHOCCNNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public KICELJKDEPF(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x82D1690", Offset = "0x82D0290", VA = "0x1882D1690")]
	public static bool CDGFDPOPEPC(KICELJKDEPF JPILOOHOBDJ, KICELJKDEPF MAKDDCFIOBO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x82D0BE0", Offset = "0x82CF7E0", VA = "0x1882D0BE0")]
	public static bool IECKAGJENEB(KICELJKDEPF JPILOOHOBDJ, KICELJKDEPF MAKDDCFIOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x82DD400", Offset = "0x82DC000", VA = "0x1882DD400", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(KICELJKDEPF IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct MLPELMEJHIH : IEquatable<MLPELMEJHIH>
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly MLPELMEJHIH GLBIMMPBNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private LKMCAJFDHNO IAOFNLOBFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x82E17D0", Offset = "0x82E03D0", VA = "0x1882E17D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool IHFKLAHOODH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x82E1910", Offset = "0x82E0510", VA = "0x1882E1910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public BJNKJNJOKOA AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(BJNKJNJOKOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x82E1590", Offset = "0x82E0190", VA = "0x1882E1590")]
	public bool AIMNMGDEPOE(MLPELMEJHIH IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x82E1630", Offset = "0x82E0230", VA = "0x1882E1630")]
	public bool EBFIGAGJNDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x82E1830", Offset = "0x82E0430", VA = "0x1882E1830")]
	public bool MGOEPBEHKGK([Out] MLPELMEJHIH KIDNHAAJNHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x82E16D0", Offset = "0x82E02D0", VA = "0x1882E16D0")]
	public void EKNKFLPHPBO(HADDMPHJDFI KDCPEPKOEEE, bool ILEPCFNADHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public MLPELMEJHIH(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x82D1690", Offset = "0x82D0290", VA = "0x1882D1690")]
	public static bool CDGFDPOPEPC(MLPELMEJHIH JPILOOHOBDJ, MLPELMEJHIH MAKDDCFIOBO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x82D0BE0", Offset = "0x82CF7E0", VA = "0x1882D0BE0")]
	public static bool IECKAGJENEB(MLPELMEJHIH JPILOOHOBDJ, MLPELMEJHIH MAKDDCFIOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x82E1740", Offset = "0x82E0340", VA = "0x1882E1740", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(MLPELMEJHIH IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct INJIKEOENHH : IEquatable<INJIKEOENHH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private PAAJHIOLAGJ KAFPCDHPFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x82DAB90", Offset = "0x82D9790", VA = "0x1882DAB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public CFFDHOCCNNL KAJKCCNDGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x82DA900", Offset = "0x82D9500", VA = "0x1882DA900")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public MDCMDKHFPFC CCBOMPENMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x82DAC80", Offset = "0x82D9880", VA = "0x1882DAC80")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public MDCMDKHFPFC AMCBICJEEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x82DA660", Offset = "0x82D9260", VA = "0x1882DA660")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x82DA990", Offset = "0x82D9590", VA = "0x1882DA990")]
	public Span<MDCMDKHFPFC> CGPMFOPNEDJ()
	{
		return default(Span<MDCMDKHFPFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x82DADB0", Offset = "0x82D99B0", VA = "0x1882DADB0")]
	public Span<MDCMDKHFPFC> PFCNDPLDEEJ()
	{
		return default(Span<MDCMDKHFPFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x82DAA90", Offset = "0x82D9690", VA = "0x1882DAA90")]
	public Span<MDCMDKHFPFC> CIJCJGBLIDI()
	{
		return default(Span<MDCMDKHFPFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x82DA800", Offset = "0x82D9400", VA = "0x1882DA800")]
	public Span<MDCMDKHFPFC> BHAFEDOLNJP()
	{
		return default(Span<MDCMDKHFPFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x82DAEB0", Offset = "0x82D9AB0", VA = "0x1882DAEB0")]
	public bool PLPIOCHBPFK(MDCMDKHFPFC IEPNOLIPIDE, bool DGDBEFGIMDH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x82DAD10", Offset = "0x82D9910", VA = "0x1882DAD10")]
	public bool LHAJGOJLFON(MDCMDKHFPFC PMJLFMNJFLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x82DA6F0", Offset = "0x82D92F0", VA = "0x1882DA6F0")]
	public MDCMDKHFPFC AMILDFNHGII(uint PBNGKLJBCAB)
	{
		return default(MDCMDKHFPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x82DAFE0", Offset = "0x82D9BE0", VA = "0x1882DAFE0")]
	public PCHNCFLHIJE PMLHFCHBIJP()
	{
		return default(PCHNCFLHIJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public INJIKEOENHH(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x82D1EA0", Offset = "0x82D0AA0", VA = "0x1882D1EA0")]
	public static bool KDDDGPNBGLG(INJIKEOENHH BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x82DABF0", Offset = "0x82D97F0", VA = "0x1882DABF0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(INJIKEOENHH IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct NBCMACFEBFO : IEquatable<NBCMACFEBFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public string BMCPEJAJHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x82E2150", Offset = "0x82E0D50", VA = "0x1882E2150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public string EMALHGPAOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x82E2290", Offset = "0x82E0E90", VA = "0x1882E2290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string JIFFDKDGNND
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x82E21E0", Offset = "0x82E0DE0", VA = "0x1882E21E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public string JDLEJOLENIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x82E2390", Offset = "0x82E0F90", VA = "0x1882E2390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x82E2630", Offset = "0x82E1230", VA = "0x1882E2630")]
	public bool NEEBHKOKEAM([Out] string BAEFNJGLAII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public NBCMACFEBFO(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x82E2300", Offset = "0x82E0F00", VA = "0x1882E2300", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(NBCMACFEBFO IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct ECIBNNPFCCL : IEquatable<ECIBNNPFCCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x82D4A10", Offset = "0x82D3610", VA = "0x1882D4A10", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(ECIBNNPFCCL IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct AAIHOEDLGBE : IEquatable<AAIHOEDLGBE>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[Flags]
	public enum DCCFHGLEIGF
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
	private static PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly AAIHOEDLGBE GLBIMMPBNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private HAOJOPIKEAB BFFFNMCIFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x82CB1F0", Offset = "0x82C9DF0", VA = "0x1882CB1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x82CB250", Offset = "0x82C9E50", VA = "0x1882CB250")]
	public static DCCFHGLEIGF EMKIPJFDNAG(AAIHOEDLGBE JPILOOHOBDJ, AAIHOEDLGBE MAKDDCFIOBO)
	{
		return default(DCCFHGLEIGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x82CB750", Offset = "0x82CA350", VA = "0x1882CB750")]
	public bool KFLBNICMGEM([Out] GameObject IEPNOLIPIDE, [Out] GameObject HLOIBGDKPID, [Out] MDCMDKHFPFC EIGHLKEBDFF, [Out] MDCMDKHFPFC MJPAJLNOEFD, [Out] Vector3 FEMJLOIOGIK, [Out] Vector3 EIJGGFOMMEE, [Out] Vector3 HAKDIDBEIBL, [Out] MDCMDKHFPFC EKEPILMHGPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x82CB510", Offset = "0x82CA110", VA = "0x1882CB510")]
	public bool FLGGEHNIAKO([Out] GameObject IEPNOLIPIDE, [Out] GameObject HLOIBGDKPID, [Out] MDCMDKHFPFC EIGHLKEBDFF, [Out] MDCMDKHFPFC MJPAJLNOEFD, [Out] Vector3 FEMJLOIOGIK, [Out] Vector3 EIJGGFOMMEE, [Out] Vector3 HAKDIDBEIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x82CBC80", Offset = "0x82CA880", VA = "0x1882CBC80")]
	private void LFCEJKEAKDF(Entity CGLPEGHHGMM, EntityManager DCHCFDENMFF, MagneticAnchorData PBCPAHPPFJK, [Out] GameObject IEPNOLIPIDE, [Out] GameObject HLOIBGDKPID, [Out] MDCMDKHFPFC EIGHLKEBDFF, [Out] MDCMDKHFPFC MJPAJLNOEFD, [Out] Vector3 FEMJLOIOGIK, [Out] Vector3 EIJGGFOMMEE, [Out] Vector3 HAKDIDBEIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public AAIHOEDLGBE(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x82CB480", Offset = "0x82CA080", VA = "0x1882CB480", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(AAIHOEDLGBE IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x82CC040", Offset = "0x82CAC40", VA = "0x1882CC040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct KKFONKOIBMF : IEquatable<KKFONKOIBMF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x82DDB20", Offset = "0x82DC720", VA = "0x1882DDB20", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(KKFONKOIBMF IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct BMOOGCDFCJI : IEquatable<BMOOGCDFCJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private LCGJIAHIHJG IAOFNLOBFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x82D0010", Offset = "0x82CEC10", VA = "0x1882D0010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CLBPEPNMNAE BFKHBBHBGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x82CFFD0", Offset = "0x82CEBD0", VA = "0x1882CFFD0")]
		get
		{
			return default(CLBPEPNMNAE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x82D0070", Offset = "0x82CEC70", VA = "0x1882D0070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public OOJKGBPAOPB<string> OPBIIAKPONH
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD90", Offset = "0x82CE990", VA = "0x1882CFD90")]
		get
		{
			return default(OOJKGBPAOPB<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x82CFEB0", Offset = "0x82CEAB0", VA = "0x1882CFEB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public OOJKGBPAOPB<string> FNFILDMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x82CFC70", Offset = "0x82CE870", VA = "0x1882CFC70")]
		get
		{
			return default(OOJKGBPAOPB<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x82CFB50", Offset = "0x82CE750", VA = "0x1882CFB50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public BMOOGCDFCJI(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x82CFAC0", Offset = "0x82CE6C0", VA = "0x1882CFAC0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(BMOOGCDFCJI IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct IIMLEJPEJDA : IEquatable<IIMLEJPEJDA>
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly ComponentTypes IBLPPHBPICG;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly IIMLEJPEJDA GLBIMMPBNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Collider ADMMLOOPNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x82D9570", Offset = "0x82D8170", VA = "0x1882D9570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public PKHKHHIBOLB NEJFDCHKCIB
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x82D9530", Offset = "0x82D8130", VA = "0x1882D9530")]
		get
		{
			return default(PKHKHHIBOLB);
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x82D8EA0", Offset = "0x82D7AA0", VA = "0x1882D8EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public NGPGMOPOLKA FLEOKBFKIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x82D9710", Offset = "0x82D8310", VA = "0x1882D9710")]
		get
		{
			return default(NGPGMOPOLKA);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x82D96C0", Offset = "0x82D82C0", VA = "0x1882D96C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public EIBOFLPIJKL KFHIDOJMAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x82D90C0", Offset = "0x82D7CC0", VA = "0x1882D90C0")]
		get
		{
			return default(EIBOFLPIJKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x82D98A0", Offset = "0x82D84A0", VA = "0x1882D98A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public float HLBDPBMOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x82D8C50", Offset = "0x82D7850", VA = "0x1882D8C50")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x82D9850", Offset = "0x82D8450", VA = "0x1882D9850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool MJHGHOIOKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x82D94C0", Offset = "0x82D80C0", VA = "0x1882D94C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x82D9020", Offset = "0x82D7C20", VA = "0x1882D9020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool FDEBOFANDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x82D8D80", Offset = "0x82D7980", VA = "0x1882D8D80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x82D8F80", Offset = "0x82D7B80", VA = "0x1882D8F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool DCOAOIHPECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x82D97D0", Offset = "0x82D83D0", VA = "0x1882D97D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x82D8A40", Offset = "0x82D7640", VA = "0x1882D8A40")]
	public static bool CFHALMMDIIG(MDCMDKHFPFC HFOABIPNLOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x82D9100", Offset = "0x82D7D00", VA = "0x1882D9100")]
	public static bool GNMDKNPAJOM(MDCMDKHFPFC HFOABIPNLOP, [Out] IIMLEJPEJDA PFOAKJBNKGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x82D9350", Offset = "0x82D7F50", VA = "0x1882D9350")]
	public bool HADAKDNPONK([Out] KOHAGOCCJDH CKPKIHAALAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x82D8C90", Offset = "0x82D7890", VA = "0x1882D8C90")]
	public bool DCCOIALMDJF([Out] CFFDHOCCNNL OLIIIAEGOLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x82D89E0", Offset = "0x82D75E0", VA = "0x1882D89E0")]
	public bool AMIKBCNKIJA(GCOFBKNOKHB KDCPEPKOEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x82D9750", Offset = "0x82D8350", VA = "0x1882D9750")]
	public void NDGBLGNGKMD(GCOFBKNOKHB KDCPEPKOEEE, bool MNGLOBMLMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x82D8E00", Offset = "0x82D7A00", VA = "0x1882D8E00")]
	public void DONKOBKCKIC(GCOFBKNOKHB KDCPEPKOEEE, bool MNGLOBMLMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public IIMLEJPEJDA(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x82D8EF0", Offset = "0x82D7AF0", VA = "0x1882D8EF0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(IIMLEJPEJDA IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x82D98F0", Offset = "0x82D84F0", VA = "0x1882D98F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct MMIFLOOOPPF : IEquatable<MMIFLOOOPPF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool KCOBCEOJOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x82E1970", Offset = "0x82E0570", VA = "0x1882E1970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public MMIFLOOOPPF(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x82E19C0", Offset = "0x82E05C0", VA = "0x1882E19C0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(MMIFLOOOPPF IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct JMGHLGNHAOF : IEquatable<JMGHLGNHAOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	private HDKKEEJGDGJ LECBCNHPPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x82DC840", Offset = "0x82DB440", VA = "0x1882DC840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x82DC6C0", Offset = "0x82DB2C0", VA = "0x1882DC6C0")]
	public void BGNIMHEOIAA(bool NEPLEDAPNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public JMGHLGNHAOF(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x82DC7B0", Offset = "0x82DB3B0", VA = "0x1882DC7B0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(JMGHLGNHAOF IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct BKCLEIBINBC : IEquatable<BKCLEIBINBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private GLINBMAHDKN EMODEOKACKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x82CF470", Offset = "0x82CE070", VA = "0x1882CF470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public CLBPEPNMNAE BDAHLIIGDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x82CEFF0", Offset = "0x82CDBF0", VA = "0x1882CEFF0")]
		get
		{
			return default(CLBPEPNMNAE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x82CE940", Offset = "0x82CD540", VA = "0x1882CE940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool IHFKIKHJCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x82CEB70", Offset = "0x82CD770", VA = "0x1882CEB70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x82CF210", Offset = "0x82CDE10", VA = "0x1882CF210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public OOJKGBPAOPB<string> DJGBDADOIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x82CF0F0", Offset = "0x82CDCF0", VA = "0x1882CF0F0")]
		get
		{
			return default(OOJKGBPAOPB<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x82CED20", Offset = "0x82CD920", VA = "0x1882CED20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public OOJKGBPAOPB<string> NLBEAKPHAON
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x82CF350", Offset = "0x82CDF50", VA = "0x1882CF350")]
		get
		{
			return default(OOJKGBPAOPB<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x82CF600", Offset = "0x82CE200", VA = "0x1882CF600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public OOJKGBPAOPB<string> LEPIBDIMMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x82CEE40", Offset = "0x82CDA40", VA = "0x1882CEE40")]
		get
		{
			return default(OOJKGBPAOPB<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x82CEC00", Offset = "0x82CD800", VA = "0x1882CEC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public OOJKGBPAOPB<string> ACOLLDGFLPP
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x82CEA50", Offset = "0x82CD650", VA = "0x1882CEA50")]
		get
		{
			return default(OOJKGBPAOPB<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4E0", Offset = "0x82CE0E0", VA = "0x1882CF4E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x82CF2B0", Offset = "0x82CDEB0", VA = "0x1882CF2B0")]
	public bool KLLGACLMDIE(CFFDHOCCNNL FANAFCDPEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public BKCLEIBINBC(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static CFFDHOCCNNL KDDDGPNBGLG(BKCLEIBINBC BKMPCFIAHIG)
	{
		return default(CFFDHOCCNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x82CEF60", Offset = "0x82CDB60", VA = "0x1882CEF60", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(BKCLEIBINBC IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct KOEEHGMFJPO : IEquatable<KOEEHGMFJPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool FCGHNCHEDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x82DE4F0", Offset = "0x82DD0F0", VA = "0x1882DE4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool FBCCBKKADBK
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x82DE420", Offset = "0x82DD020", VA = "0x1882DE420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool IBGGLPFBIDD
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x82DEAC0", Offset = "0x82DD6C0", VA = "0x1882DEAC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x82DE8D0", Offset = "0x82DD4D0", VA = "0x1882DE8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool OJOANOENFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x82DEB60", Offset = "0x82DD760", VA = "0x1882DEB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool NBMGOKMPMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x82DE5D0", Offset = "0x82DD1D0", VA = "0x1882DE5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool ACALFJDEHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x82DDFB0", Offset = "0x82DCBB0", VA = "0x1882DDFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool MDLAKDBJMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x82DE740", Offset = "0x82DD340", VA = "0x1882DE740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool NJAKACGOKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x82DDE40", Offset = "0x82DCA40", VA = "0x1882DDE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool OEOOOOJBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x82DE530", Offset = "0x82DD130", VA = "0x1882DE530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool ENFDMJIAOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x82DE250", Offset = "0x82DCE50", VA = "0x1882DE250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool AHBAHBBBHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x82DE200", Offset = "0x82DCE00", VA = "0x1882DE200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool CNBIELPEGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x82DE790", Offset = "0x82DD390", VA = "0x1882DE790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool APJEOAMOEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x82DEB10", Offset = "0x82DD710", VA = "0x1882DEB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool BFHOONFJFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x82DE7E0", Offset = "0x82DD3E0", VA = "0x1882DE7E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x82DE0E0", Offset = "0x82DCCE0", VA = "0x1882DE0E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool MGFAJOKNFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x82DE820", Offset = "0x82DD420", VA = "0x1882DE820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public DMKDAHIMIGM NKOBNLNBLBP
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x82DE620", Offset = "0x82DD220", VA = "0x1882DE620")]
		get
		{
			return default(DMKDAHIMIGM);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x82DEC30", Offset = "0x82DD830", VA = "0x1882DEC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public bool KEGPKCBMHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x82DDE90", Offset = "0x82DCA90", VA = "0x1882DDE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public IKHNFFIHEKH PPAHOHFHOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x82DE140", Offset = "0x82DCD40", VA = "0x1882DE140")]
		get
		{
			return default(IKHNFFIHEKH);
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x82DE090", Offset = "0x82DCC90", VA = "0x1882DE090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public bool ABOCCMHDAFK
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x82DE180", Offset = "0x82DCD80", VA = "0x1882DE180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public Vector3 ENOPANFJJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x82DE470", Offset = "0x82DD070", VA = "0x1882DE470")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public Vector3 IKLEJOHFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x82DE660", Offset = "0x82DD260", VA = "0x1882DE660")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public bool HIKEGGGKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x82DE8F0", Offset = "0x82DD4F0", VA = "0x1882DE8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public bool KECJDGEADLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x82DE2A0", Offset = "0x82DCEA0", VA = "0x1882DE2A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	private EntityManager IEBLFDPIILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x82DE730", Offset = "0x82DD330", VA = "0x1882DE730")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x82DE870", Offset = "0x82DD470", VA = "0x1882DE870")]
	public bool MNNJNENIKGN(DLFJGOLOEDK KDCPEPKOEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x82DE000", Offset = "0x82DCC00", VA = "0x1882DE000")]
	public void CPOONNGGOLI(DLFJGOLOEDK KDCPEPKOEEE, bool MNGLOBMLMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x82DE580", Offset = "0x82DD180", VA = "0x1882DE580")]
	public bool KGOHEPPJBPP(GOFNDNICMIL KDCPEPKOEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x82DEBB0", Offset = "0x82DD7B0", VA = "0x1882DEBB0")]
	public void PMFIJDCIFHB(GOFNDNICMIL KDCPEPKOEEE, bool MNGLOBMLMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x82DE1C0", Offset = "0x82DCDC0", VA = "0x1882DE1C0")]
	public GOFNDNICMIL EFAAPEBDJOE()
	{
		return default(GOFNDNICMIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x82DE6E0", Offset = "0x82DD2E0", VA = "0x1882DE6E0")]
	public bool LGBJPNGOIKK(GOFNDNICMIL BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public KOEEHGMFJPO(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x82DE390", Offset = "0x82DCF90", VA = "0x1882DE390", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(KOEEHGMFJPO IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct LCMBPCHHFEH : IEquatable<LCMBPCHHFEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	private OKKGAIPBFID MLFJAGBDEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x82DEE20", Offset = "0x82DDA20", VA = "0x1882DEE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x82DF0C0", Offset = "0x82DDCC0", VA = "0x1882DF0C0")]
	public bool LNJCPJHOMJB(MCKGLJLILAB MEGBHLJHDNE, List<MDCMDKHFPFC> GDMLMHKNJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x82DF500", Offset = "0x82DE100", VA = "0x1882DF500")]
	public int NGNKEAMIGBJ(MCKGLJLILAB MEGBHLJHDNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x82DEFB0", Offset = "0x82DDBB0", VA = "0x1882DEFB0")]
	public void LLIHCCBGMFG(List<MDCMDKHFPFC> GDMLMHKNJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x82DEE80", Offset = "0x82DDA80", VA = "0x1882DEE80")]
	public int KFAOOJCFEOF(MDCMDKHFPFC ADGCHNLKFKK, MCKGLJLILAB MEGBHLJHDNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x82DF1F0", Offset = "0x82DDDF0", VA = "0x1882DF1F0")]
	public MDCMDKHFPFC MGNLDCLKGEH(int LCCBBMBENOH, MCKGLJLILAB MEGBHLJHDNE)
	{
		return default(MDCMDKHFPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x82DF3D0", Offset = "0x82DDFD0", VA = "0x1882DF3D0")]
	public void MLBFPHGLONM(MDCMDKHFPFC ADGCHNLKFKK, MCKGLJLILAB MEGBHLJHDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x82DF320", Offset = "0x82DDF20", VA = "0x1882DF320")]
	public bool MKDBELBFJHC(MDCMDKHFPFC ADGCHNLKFKK, MCKGLJLILAB MEGBHLJHDNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x82DF610", Offset = "0x82DE210", VA = "0x1882DF610")]
	public void NKPELIOBJFJ(MCKGLJLILAB MEGBHLJHDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x82DF720", Offset = "0x82DE320", VA = "0x1882DF720")]
	public bool PCCHPAKLLBO(MDCMDKHFPFC ADGCHNLKFKK, MCKGLJLILAB MEGBHLJHDNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x82DED10", Offset = "0x82DD910", VA = "0x1882DED10")]
	public bool IIGILMEJGMK(MCKGLJLILAB MEGBHLJHDNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public LCMBPCHHFEH(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC80", Offset = "0x82DD880", VA = "0x1882DEC80", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(LCMBPCHHFEH IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct PFKHNFHFFMA : IEquatable<PFKHNFHFFMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x82E34C0", Offset = "0x82E20C0", VA = "0x1882E34C0")]
	public void BCOHDFHCOBH(bool BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x82E35E0", Offset = "0x82E21E0", VA = "0x1882E35E0")]
	public void FOGAGDGIICG(bool BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x3E10B50", Offset = "0x3E0F750", VA = "0x183E10B50")]
	public T DJNJFDODBGB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public PFKHNFHFFMA(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x82E3550", Offset = "0x82E2150", VA = "0x1882E3550", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(PFKHNFHFFMA IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct DPHBMGBKAJG : IEquatable<DPHBMGBKAJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public bool ACNIJLPKCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x82D3C30", Offset = "0x82D2830", VA = "0x1882D3C30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x82D3D00", Offset = "0x82D2900", VA = "0x1882D3D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool JMIBMKPAMOE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x82D3AE0", Offset = "0x82D26E0", VA = "0x1882D3AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public int LEDANCCOOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x82D3BF0", Offset = "0x82D27F0", VA = "0x1882D3BF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x82D3C70", Offset = "0x82D2870", VA = "0x1882D3C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public DPHBMGBKAJG(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x82D3B60", Offset = "0x82D2760", VA = "0x1882D3B60", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(DPHBMGBKAJG IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct GKLLFBANFEG : IEquatable<GKLLFBANFEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public int JJFMOJJFOPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x82D5F50", Offset = "0x82D4B50", VA = "0x1882D5F50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x82D5E70", Offset = "0x82D4A70", VA = "0x1882D5E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public int HNJNHDCIAOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x82D5F90", Offset = "0x82D4B90", VA = "0x1882D5F90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x82D5E20", Offset = "0x82D4A20", VA = "0x1882D5E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public uint FLEAHDGICNA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x82D5DE0", Offset = "0x82D49E0", VA = "0x1882D5DE0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x82D5FD0", Offset = "0x82D4BD0", VA = "0x1882D5FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public GKLLFBANFEG(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x82D5EC0", Offset = "0x82D4AC0", VA = "0x1882D5EC0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(GKLLFBANFEG IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct IJBBGHINNKP : IEquatable<IJBBGHINNKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	private HHNLABFNIMA BGGFANBCHJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x82D9DA0", Offset = "0x82D89A0", VA = "0x1882D9DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	private NCECDAJCGGB GLBCOKNBHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x82D9CB0", Offset = "0x82D88B0", VA = "0x1882D9CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public bool ILJEGOCKAKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x82D9E00", Offset = "0x82D8A00", VA = "0x1882D9E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public bool CMJMCKLAHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x82D9B80", Offset = "0x82D8780", VA = "0x1882D9B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public bool MKEKDLANMNN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x82DA3F0", Offset = "0x82D8FF0", VA = "0x1882DA3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public bool JEFMFAHMAME
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x82DA590", Offset = "0x82D9190", VA = "0x1882DA590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool BAOHKIKKKEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x82DA3C0", Offset = "0x82D8FC0", VA = "0x1882DA3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool AEDLPGECCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x82D9C20", Offset = "0x82D8820", VA = "0x1882D9C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public bool PBDCPAIJPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x82D9F40", Offset = "0x82D8B40", VA = "0x1882D9F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public bool KOONGBPMOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x82DA420", Offset = "0x82D9020", VA = "0x1882DA420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool HAPAFLNFCCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x82DA1F0", Offset = "0x82D8DF0", VA = "0x1882DA1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x82D9B10", Offset = "0x82D8710", VA = "0x1882D9B10")]
	public bool BHPPNKAHBBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x82DA320", Offset = "0x82D8F20", VA = "0x1882DA320")]
	public MDCMDKHFPFC JFKJEBCKKAH(MDCMDKHFPFC ADGCHNLKFKK)
	{
		return default(MDCMDKHFPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x82DA0E0", Offset = "0x82D8CE0", VA = "0x1882DA0E0")]
	public CFFDHOCCNNL JAJFPNBGGNM()
	{
		return default(CFFDHOCCNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x82D9E90", Offset = "0x82D8A90", VA = "0x1882D9E90")]
	public bool IFEFIAIPENI(CFFDHOCCNNL ADGCHNLKFKK, [Out] CFFDHOCCNNL LNPOCHOCHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public IJBBGHINNKP(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x82D1EA0", Offset = "0x82D0AA0", VA = "0x1882D1EA0")]
	public static bool KDDDGPNBGLG(IJBBGHINNKP BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x82D9D10", Offset = "0x82D8910", VA = "0x1882D9D10", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(IJBBGHINNKP IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct HKBILPJPHPE : IEquatable<HKBILPJPHPE>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly HKBILPJPHPE GLBIMMPBNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public KNMEHEMEPOL AEDPIPKDNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x82D74E0", Offset = "0x82D60E0", VA = "0x1882D74E0")]
		get
		{
			return default(KNMEHEMEPOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public PFELNBBIHNK MEHMDJKIAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x82D73E0", Offset = "0x82D5FE0", VA = "0x1882D73E0")]
		get
		{
			return default(PFELNBBIHNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x82D7150", Offset = "0x82D5D50", VA = "0x1882D7150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public MEKNHMCLLHC HLAFGCCNOEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x82D7270", Offset = "0x82D5E70", VA = "0x1882D7270")]
		get
		{
			return default(MEKNHMCLLHC);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x82D72B0", Offset = "0x82D5EB0", VA = "0x1882D72B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public float EGGJFNKMCMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x82D7520", Offset = "0x82D6120", VA = "0x1882D7520")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x82D7720", Offset = "0x82D6320", VA = "0x1882D7720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public Vector3 GCDBDKMMNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x82D7420", Offset = "0x82D6020", VA = "0x1882D7420")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x82D7660", Offset = "0x82D6260", VA = "0x1882D7660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public float LNNCLHLMEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x82D7100", Offset = "0x82D5D00", VA = "0x1882D7100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public EHENCINGLKE PGBEBHMACKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x82D76E0", Offset = "0x82D62E0", VA = "0x1882D76E0")]
		get
		{
			return default(EHENCINGLKE);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x82D7610", Offset = "0x82D6210", VA = "0x1882D7610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public bool AIAIFDLKLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x82D74A0", Offset = "0x82D60A0", VA = "0x1882D74A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x82D7560", Offset = "0x82D6160", VA = "0x1882D7560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public BJNKJNJOKOA AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(BJNKJNJOKOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public INJIKEOENHH PLCEFDJJMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(INJIKEOENHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x82D71A0", Offset = "0x82D5DA0", VA = "0x1882D71A0")]
	public NMGAFDHDPBL ANPDFPGNBNM()
	{
		return default(NMGAFDHDPBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x82D75C0", Offset = "0x82D61C0", VA = "0x1882D75C0")]
	public CPLPDHBAEJC JDIJHLLBMBO()
	{
		return default(CPLPDHBAEJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x82D7300", Offset = "0x82D5F00", VA = "0x1882D7300")]
	private bool ENLCJLGCOKF(EHENCINGLKE KDCPEPKOEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x82D71F0", Offset = "0x82D5DF0", VA = "0x1882D71F0")]
	public void CAOPOONHFON(EHENCINGLKE KDCPEPKOEEE, bool MNGLOBMLMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public HKBILPJPHPE(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x82D1EA0", Offset = "0x82D0AA0", VA = "0x1882D1EA0")]
	public static bool KDDDGPNBGLG(HKBILPJPHPE BKMPCFIAHIG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x82D0BE0", Offset = "0x82CF7E0", VA = "0x1882D0BE0")]
	public static bool IECKAGJENEB(HKBILPJPHPE JPILOOHOBDJ, HKBILPJPHPE MAKDDCFIOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x82D7350", Offset = "0x82D5F50", VA = "0x1882D7350", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(HKBILPJPHPE IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct NMGAFDHDPBL : IEquatable<NMGAFDHDPBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public HKBILPJPHPE CGDACNNGACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(HKBILPJPHPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public LDLEEKNJJFJ HCELMBEODLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x82E2880", Offset = "0x82E1480", VA = "0x1882E2880")]
		get
		{
			return default(LDLEEKNJJFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public NMGAFDHDPBL(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x82D1EA0", Offset = "0x82D0AA0", VA = "0x1882D1EA0")]
	public static bool KDDDGPNBGLG(NMGAFDHDPBL BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x82E28C0", Offset = "0x82E14C0", VA = "0x1882E28C0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(NMGAFDHDPBL IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DefaultMember("Item")]
public readonly struct CPLPDHBAEJC : IEquatable<CPLPDHBAEJC>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly CPLPDHBAEJC GLBIMMPBNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	private PGJKJDGHCDD PNEOFHHMAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x82D1970", Offset = "0x82D0570", VA = "0x1882D1970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public HKBILPJPHPE CGDACNNGACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(HKBILPJPHPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public LIACMAGLFCP HNEPHNHFNLD
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x82D1560", Offset = "0x82D0160", VA = "0x1882D1560")]
		get
		{
			return default(LIACMAGLFCP);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x82D20E0", Offset = "0x82D0CE0", VA = "0x1882D20E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public IEnumerable<CONIGAAIGCB> KAEKNLMEPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x82D1B80", Offset = "0x82D0780", VA = "0x1882D1B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public CONIGAAIGCB KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x82D1D90", Offset = "0x82D0990", VA = "0x1882D1D90")]
		get
		{
			return default(CONIGAAIGCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x82D1A60", Offset = "0x82D0660", VA = "0x1882D1A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public BJNKJNJOKOA AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(BJNKJNJOKOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x82D1EC0", Offset = "0x82D0AC0", VA = "0x1882D1EC0")]
	public CONIGAAIGCB OIAGJKEAOCK(float3? FEMJLOIOGIK, [Optional] quaternion? DINDLKHALMD, [Optional] Vector3? ECJMFFOLCCL)
	{
		return default(CONIGAAIGCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x82D16A0", Offset = "0x82D02A0", VA = "0x1882D16A0")]
	public CONIGAAIGCB DLMHFMOANAD(int LCCBBMBENOH, float3? FEMJLOIOGIK, [Optional] quaternion? DINDLKHALMD, [Optional] Vector3? ECJMFFOLCCL)
	{
		return default(CONIGAAIGCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x82D18D0", Offset = "0x82D04D0", VA = "0x1882D18D0")]
	public void EADGMLABOEB(int LCCBBMBENOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x82D1AF0", Offset = "0x82D06F0", VA = "0x1882D1AF0")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public CPLPDHBAEJC(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x82D1EA0", Offset = "0x82D0AA0", VA = "0x1882D1EA0")]
	public static bool KDDDGPNBGLG(CPLPDHBAEJC BKMPCFIAHIG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x82D1690", Offset = "0x82D0290", VA = "0x1882D1690")]
	public static bool CDGFDPOPEPC(CPLPDHBAEJC JPILOOHOBDJ, CPLPDHBAEJC MAKDDCFIOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x82D19D0", Offset = "0x82D05D0", VA = "0x1882D19D0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(CPLPDHBAEJC IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct CONIGAAIGCB : IEquatable<CONIGAAIGCB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public CPLPDHBAEJC AAFLKNNKEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x82D1300", Offset = "0x82CFF00", VA = "0x1882D1300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public float3 IFBKCLIOOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x82D1380", Offset = "0x82CFF80", VA = "0x1882D1380")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x82D1500", Offset = "0x82D0100", VA = "0x1882D1500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public quaternion MNNHAPKBCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x82D12B0", Offset = "0x82CFEB0", VA = "0x1882D12B0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x82D11D0", Offset = "0x82CFDD0", VA = "0x1882D11D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public float3 EPICMNANIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x82D14A0", Offset = "0x82D00A0", VA = "0x1882D14A0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x82D1440", Offset = "0x82D0040", VA = "0x1882D1440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public EJDHJMPEDMM NLCBKJABDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x82D13E0", Offset = "0x82CFFE0", VA = "0x1882D13E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x82D1430", Offset = "0x82D0030", VA = "0x1882D1430")]
	public void KKPEBLLBBPG(CPLPDHBAEJC BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public CONIGAAIGCB(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x82D1220", Offset = "0x82CFE20", VA = "0x1882D1220", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(CONIGAAIGCB IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct NHCPKAIJKGO : IEquatable<NHCPKAIJKGO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public bool KEKFPNJOFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x82E2780", Offset = "0x82E1380", VA = "0x1882E2780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public NHCPKAIJKGO(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x82E26F0", Offset = "0x82E12F0", VA = "0x1882E26F0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(NHCPKAIJKGO IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct MIEDBDGKCEP : IEquatable<MIEDBDGKCEP>
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public static readonly MIEDBDGKCEP GLBIMMPBNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	private EJCMHKCPHKA OEDIOCBJHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x82E1310", Offset = "0x82DFF10", VA = "0x1882E1310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public uint EHGKAKFBJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x82E1010", Offset = "0x82DFC10", VA = "0x1882E1010")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x82E1440", Offset = "0x82E0040", VA = "0x1882E1440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public KCNHKGPCNMH ICLADGPKMME
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x82E1550", Offset = "0x82E0150", VA = "0x1882E1550")]
		get
		{
			return default(KCNHKGPCNMH);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x82E0E20", Offset = "0x82DFA20", VA = "0x1882E0E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public float IPGAENKCAEC
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x82E13B0", Offset = "0x82DFFB0", VA = "0x1882E13B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x82E1200", Offset = "0x82DFE00", VA = "0x1882E1200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public float ODFBFGHNMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x82E0E70", Offset = "0x82DFA70", VA = "0x1882E0E70")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x82E13F0", Offset = "0x82DFFF0", VA = "0x1882E13F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public ICMOIJBHMPP LBHOHOEOAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x82E1370", Offset = "0x82DFF70", VA = "0x1882E1370")]
		get
		{
			return default(ICMOIJBHMPP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x82E0EB0", Offset = "0x82DFAB0", VA = "0x1882E0EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public ReadOnlySpan<TerrainGenerationLayer> OHCIKNKOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x82E1490", Offset = "0x82E0090", VA = "0x1882E1490")]
		get
		{
			return default(ReadOnlySpan<TerrainGenerationLayer>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x82E0F00", Offset = "0x82DFB00", VA = "0x1882E0F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public ReadOnlySpan<CPAFJEBFNBF> DKHPGBGCEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x82E1250", Offset = "0x82DFE50", VA = "0x1882E1250")]
		get
		{
			return default(ReadOnlySpan<CPAFJEBFNBF>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x82E1050", Offset = "0x82DFC50", VA = "0x1882E1050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public MIEDBDGKCEP(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static CFFDHOCCNNL KDDDGPNBGLG(MIEDBDGKCEP BKMPCFIAHIG)
	{
		return default(CFFDHOCCNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x82E1170", Offset = "0x82DFD70", VA = "0x1882E1170", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(MIEDBDGKCEP IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct EACPMNNFNPD : IEquatable<EACPMNNFNPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	private JNOEMKCMLEI ODEAFMMPPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x82D4390", Offset = "0x82D2F90", VA = "0x1882D4390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public bool DPEGMOCBJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x82D46E0", Offset = "0x82D32E0", VA = "0x1882D46E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x82D43F0", Offset = "0x82D2FF0", VA = "0x1882D43F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public bool AOBGIMJAICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x82D4250", Offset = "0x82D2E50", VA = "0x1882D4250")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x82D4330", Offset = "0x82D2F30", VA = "0x1882D4330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public float PJEDKCEHMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x82D48F0", Offset = "0x82D34F0", VA = "0x1882D48F0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x82D44A0", Offset = "0x82D30A0", VA = "0x1882D44A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public bool IFFNCHEELCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x82D40B0", Offset = "0x82D2CB0", VA = "0x1882D40B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x82D44F0", Offset = "0x82D30F0", VA = "0x1882D44F0")]
	public void JKOGOFPPBOE(int JAOGNEOIMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x82D3DF0", Offset = "0x82D29F0", VA = "0x1882D3DF0")]
	public bool APGFAKLMOLA([Out] int JAOGNEOIMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x82D3D50", Offset = "0x82D2950", VA = "0x1882D3D50")]
	public void AAPPILJDNHP(bool BJGOOLGNJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x82D4450", Offset = "0x82D3050", VA = "0x1882D4450")]
	public bool GNIFAGJPIOF(DOAPHOIIDLI KDCPEPKOEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x82D3F00", Offset = "0x82D2B00", VA = "0x1882D3F00")]
	public void BBCCLEODJOD(DOAPHOIIDLI KDCPEPKOEEE, bool MNGLOBMLMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x82D4590", Offset = "0x82D3190", VA = "0x1882D4590")]
	public void KNJGLHOJNLA(float ODJJBNBGECF, float CCFBFCNDENG, float AJAJBIGENHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x82D4100", Offset = "0x82D2D00", VA = "0x1882D4100")]
	public void CHGGKHHGDFG(float3 PLHNBACLAMM, quaternion IIHOBIDMEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x82D3F80", Offset = "0x82D2B80", VA = "0x1882D3F80")]
	public bool BDLFIAAKHDJ([Out] float3 PLHNBACLAMM, [Out] quaternion IIHOBIDMEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x82D4730", Offset = "0x82D3330", VA = "0x1882D4730")]
	public bool PEEKGKOADHN([Out] float LFNOMIPJDAE, [Out] float MJIGFLOJCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x82D4860", Offset = "0x82D3460", VA = "0x1882D4860")]
	public void PFOENEFOHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public EACPMNNFNPD(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x82D42A0", Offset = "0x82D2EA0", VA = "0x1882D42A0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(EACPMNNFNPD IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct BJNKJNJOKOA : IEquatable<BJNKJNJOKOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	private DDHLMFDNOPE DNMFAFEDDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x82CE3A0", Offset = "0x82CCFA0", VA = "0x1882CE3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public Vector3 IFBKCLIOOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x82CD7D0", Offset = "0x82CC3D0", VA = "0x1882CD7D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x82CE620", Offset = "0x82CD220", VA = "0x1882CE620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public Quaternion MNNHAPKBCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x82CD5A0", Offset = "0x82CC1A0", VA = "0x1882CD5A0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x82CCEE0", Offset = "0x82CBAE0", VA = "0x1882CCEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public Vector3 JMDAEAGPOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x82CD8C0", Offset = "0x82CC4C0", VA = "0x1882CD8C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x82CDFB0", Offset = "0x82CCBB0", VA = "0x1882CDFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public Quaternion FABGMLDCLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x82CE1C0", Offset = "0x82CCDC0", VA = "0x1882CE1C0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x82CDE30", Offset = "0x82CCA30", VA = "0x1882CDE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public float ABHHLMFPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x82CCD50", Offset = "0x82CB950", VA = "0x1882CCD50")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x82CDF00", Offset = "0x82CCB00", VA = "0x1882CDF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public float PNPNMBHHMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x82CDB30", Offset = "0x82CC730", VA = "0x1882CDB30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public Matrix4x4 EIHMGPNFHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x82CE5E0", Offset = "0x82CD1E0", VA = "0x1882CE5E0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public INJIKEOENHH PLCEFDJJMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(INJIKEOENHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	private HAOJOPIKEAB BFFFNMCIFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x82CB1F0", Offset = "0x82C9DF0", VA = "0x1882CB1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x82CE170", Offset = "0x82CCD70", VA = "0x1882CE170")]
	public MFFDCMMCMLL LICIKDNDBNN()
	{
		return default(MFFDCMMCMLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x82CCA20", Offset = "0x82CB620", VA = "0x1882CCA20")]
	public void AFKLLAONJJB([Out] Matrix4x4 PPLFAKNDFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x82CD100", Offset = "0x82CBD00", VA = "0x1882CD100")]
	public void DDPDOAEKJLM([In] Vector3 COLBAOBOGCI, [In] Quaternion BFDIJLLKGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x82CD040", Offset = "0x82CBC40", VA = "0x1882CD040")]
	public void DDPDOAEKJLM([In] RigidTransform ELIBHMFLAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x82CD460", Offset = "0x82CC060", VA = "0x1882CD460")]
	public void ELBPNLINFGN([Out] RigidTransform ELIBHMFLAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x82CD2A0", Offset = "0x82CBEA0", VA = "0x1882CD2A0")]
	public void EGPEECLGCOB([In] Vector3 POAEBODHKJL, [In] Quaternion KOKIGMAFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x82CD3A0", Offset = "0x82CBFA0", VA = "0x1882CD3A0")]
	public void EGPEECLGCOB([In] RigidTransform HPMDLPBCCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x82CDBD0", Offset = "0x82CC7D0", VA = "0x1882CDBD0")]
	public void JBPKGENLNAG([Out] Vector3 POAEBODHKJL, [Out] Quaternion KOKIGMAFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x82CDCB0", Offset = "0x82CC8B0", VA = "0x1882CDCB0")]
	public void JBPKGENLNAG([Out] RigidTransform ELIBHMFLAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x82CCEB0", Offset = "0x82CBAB0", VA = "0x1882CCEB0")]
	public UniformTRS CKPFDHOFPHB()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x82CCDF0", Offset = "0x82CB9F0", VA = "0x1882CCDF0")]
	public void CKPFDHOFPHB([Out] UniformTRS HPMDLPBCCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x82CD6E0", Offset = "0x82CC2E0", VA = "0x1882CD6E0")]
	public UniformTRS GNIOPGPOGBG()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x82CD710", Offset = "0x82CC310", VA = "0x1882CD710")]
	public void GNIOPGPOGBG([Out] UniformTRS ELIBHMFLAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x82CE830", Offset = "0x82CD430", VA = "0x1882CE830")]
	public Vector3 PLFOIIFLBJC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x82CDA60", Offset = "0x82CC660", VA = "0x1882CDA60")]
	public void IKGBKJLKNMB([In] Vector3 BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x82CE080", Offset = "0x82CCC80", VA = "0x1882CE080")]
	public Vector3 KFEOIGOBPAH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x82CCC80", Offset = "0x82CB880", VA = "0x1882CCC80")]
	public void BLPONJNJADE([In] Vector3 BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x82CE6F0", Offset = "0x82CD2F0", VA = "0x1882CE6F0")]
	public Quaternion OCLNCOLHMLN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x82CE510", Offset = "0x82CD110", VA = "0x1882CE510")]
	public void NBPEAAJDDML([In] Quaternion BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x82CCB40", Offset = "0x82CB740", VA = "0x1882CCB40")]
	public Quaternion BJPKEAMFIFA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x82CDD60", Offset = "0x82CC960", VA = "0x1882CDD60")]
	public void JHGHMEEEBLO([In] Quaternion BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x82CE300", Offset = "0x82CCF00", VA = "0x1882CE300")]
	public float LNADJFLHJIL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x82CD9B0", Offset = "0x82CC5B0", VA = "0x1882CD9B0")]
	public void IJOLONKJLMF(float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x82CD200", Offset = "0x82CBE00", VA = "0x1882CD200")]
	public float DLJMCCGCDFF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x82CE460", Offset = "0x82CD060", VA = "0x1882CE460")]
	public void MKJOGBDDJDN(float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x82CCFB0", Offset = "0x82CBBB0", VA = "0x1882CCFB0")]
	public Vector3 COLNIEJIDNM([In] Vector3 DBIJDHDPOAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public BJNKJNJOKOA(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x82CD510", Offset = "0x82CC110", VA = "0x1882CD510", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(BJNKJNJOKOA IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct HNEFFIGADIC : IEquatable<HNEFFIGADIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	private PDDKMNNKOGD DIBKDNINLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x82D7D80", Offset = "0x82D6980", VA = "0x1882D7D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	public MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	private ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4D0", Offset = "0x82CE0D0", VA = "0x1882CF4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x82D7DE0", Offset = "0x82D69E0", VA = "0x1882D7DE0")]
	public void NAACCHFHJDF(string GMFCELNCIOG, PMBDFDDDFGF AMCCDFCIJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public HNEFFIGADIC(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x82D7CF0", Offset = "0x82D68F0", VA = "0x1882D7CF0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(HNEFFIGADIC IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x82CE920", Offset = "0x82CD520", VA = "0x1882CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct EJGODFOIGNH : IEquatable<EJGODFOIGNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public MJOIKADLMGF IFDGFIFMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x82D4C30", Offset = "0x82D3830", VA = "0x1882D4C30")]
		get
		{
			return default(MJOIKADLMGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public EJGODFOIGNH(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x82D4BA0", Offset = "0x82D37A0", VA = "0x1882D4BA0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(EJGODFOIGNH IIOGPDPGOLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct JOHPBCKMJIM : IEquatable<JOHPBCKMJIM>
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public struct BKPHAKIDCGP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private CFFDHOCCNNL ILPOHEPFNOO;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x82CF7B0", Offset = "0x82CE3B0", VA = "0x1882CF7B0")]
		public BKPHAKIDCGP(CFFDHOCCNNL ILPOHEPFNOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x82CF720", Offset = "0x82CE320", VA = "0x1882CF720", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x82DCD70", Offset = "0x82DB970", VA = "0x1882DCD70")]
	public BKPHAKIDCGP DBGMFDDHABD()
	{
		return default(BKPHAKIDCGP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x82DCC80", Offset = "0x82DB880", VA = "0x1882DCC80")]
	public EGILHKDIOKC BMFMDKINIPJ(Allocator HPEAGMDCCBL = Allocator.Temp)
	{
		return default(EGILHKDIOKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x82DCB50", Offset = "0x82DB750", VA = "0x1882DCB50")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> BCGNECEDJDH(Allocator HPEAGMDCCBL = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x82DCE90", Offset = "0x82DBA90", VA = "0x1882DCE90")]
	public NativeArray<BPKOKGNGCMF> IHFHDEDINPD(Allocator HPEAGMDCCBL = Allocator.Temp)
	{
		return default(NativeArray<BPKOKGNGCMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x82DCFC0", Offset = "0x82DBBC0", VA = "0x1882DCFC0")]
	public NativeArray<BPKOKGNGCMF> JAAECOIHBOC(Allocator HPEAGMDCCBL = Allocator.Temp)
	{
		return default(NativeArray<BPKOKGNGCMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x82DC9D0", Offset = "0x82DB5D0", VA = "0x1882DC9D0")]
	public HFAACADMMPC AEDJGAPFGEB(Allocator HPEAGMDCCBL = Allocator.Temp)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x82DD0F0", Offset = "0x82DBCF0", VA = "0x1882DD0F0")]
	public HFAACADMMPC LKFNBMOKACG(Allocator HPEAGMDCCBL = Allocator.Temp)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x82DCA90", Offset = "0x82DB690", VA = "0x1882DCA90")]
	public HFAACADMMPC AGMBJGAFOJP(Allocator HPEAGMDCCBL = Allocator.Temp)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public JOHPBCKMJIM(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x82DCE00", Offset = "0x82DBA00", VA = "0x1882DCE00", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(JOHPBCKMJIM IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x82D3AC0", Offset = "0x82D26C0", VA = "0x1882D3AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct GFDECLJMDNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int KFOKMEJOIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public int EFEPONECACB;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct DMBCIAMLBOC : IEquatable<DMBCIAMLBOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public JOHPBCKMJIM OJBNHLPPFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(JOHPBCKMJIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public OLFPEMEFNKA OPEMLHGCENF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(OLFPEMEFNKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public EJGODFOIGNH HJAFHDDBONO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(EJGODFOIGNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x82D3820", Offset = "0x82D2420", VA = "0x1882D3820")]
	public bool CDNALPJICKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x82D3950", Offset = "0x82D2550", VA = "0x1882D3950")]
	public bool NEPACPBEHND([Out] Exception OOPJJOBMHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public DMBCIAMLBOC(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static CFFDHOCCNNL KDDDGPNBGLG(DMBCIAMLBOC BKMPCFIAHIG)
	{
		return default(CFFDHOCCNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x82D38C0", Offset = "0x82D24C0", VA = "0x1882D38C0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(DMBCIAMLBOC IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x82D3AC0", Offset = "0x82D26C0", VA = "0x1882D3AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public readonly struct MCHDAGFDBNJ : IDisposable, IEquatable<MCHDAGFDBNJ>
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static readonly MCHDAGFDBNJ GLBIMMPBNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public DMBCIAMLBOC FDBICCPNADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(DMBCIAMLBOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public JOHPBCKMJIM OJBNHLPPFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(JOHPBCKMJIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x82DFB80", Offset = "0x82DE780", VA = "0x1882DFB80")]
	public void FLDMFNFHEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x82DFA20", Offset = "0x82DE620", VA = "0x1882DFA20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public MCHDAGFDBNJ(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x82DFAF0", Offset = "0x82DE6F0", VA = "0x1882DFAF0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "5")]
	public bool Equals(MCHDAGFDBNJ IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x82DFC00", Offset = "0x82DE800", VA = "0x1882DFC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public readonly struct OLFPEMEFNKA : IEquatable<OLFPEMEFNKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public bool COMKNFCKEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x82E2AD0", Offset = "0x82E16D0", VA = "0x1882E2AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	public OLFPEMEFNKA(CFFDHOCCNNL ILPOHEPFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x82CB720", Offset = "0x82CA320", VA = "0x1882CB720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x82E2B60", Offset = "0x82E1760", VA = "0x1882E2B60", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x82CB470", Offset = "0x82CA070", VA = "0x1882CB470", Slot = "4")]
	public bool Equals(OLFPEMEFNKA IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x82D3AC0", Offset = "0x82D26C0", VA = "0x1882D3AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class CJHEFMHAIGD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct LBIOENBMPNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Guid FHNOHJCOOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public HHAHCGPGKFE NFHLBGONGKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private struct HHAHCGPGKFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int BKMPCFIAHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int IFCMDBPBLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int JMDGNHNGCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int GCDKJFLHOMB;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x82D6E90", Offset = "0x82D5A90", VA = "0x1882D6E90")]
		public bool PEOKCCADLPL([Out] BPKOKGNGCMF PIIIPDILKIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x82D6F30", Offset = "0x82D5B30", VA = "0x1882D6F30")]
		public HHAHCGPGKFE(BPKOKGNGCMF PIIIPDILKIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x82D1110", Offset = "0x82CFD10", VA = "0x1882D1110")]
	public static Guid AGCOFKHKPKH(this BPKOKGNGCMF PIIIPDILKIL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x82D11B0", Offset = "0x82CFDB0", VA = "0x1882D11B0")]
	public static bool AIPKMPEPGIF(this Guid FHNOHJCOOKK, [Out] BPKOKGNGCMF PIIIPDILKIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class KLDCMMIKPFC
{
	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x82DDDB0", Offset = "0x82DC9B0", VA = "0x1882DDDB0")]
	public static ONGKNFGGJFK NMKMFCLEEOH(this CFFDHOCCNNL OIBGADINDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x82DDCC0", Offset = "0x82DC8C0", VA = "0x1882DDCC0")]
	public static JAAAEPMFELN DPCMCHNFMOP(this CFFDHOCCNNL OIBGADINDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x82DDD20", Offset = "0x82DC920", VA = "0x1882DDD20")]
	public static EntityManager IEBLFDPIILL(this CFFDHOCCNNL OIBGADINDDP)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B570", Offset = "0x3D0A170", VA = "0x183D0B570")]
	internal static bool MGADOHLEDEL<T>(this CFFDHOCCNNL OIBGADINDDP, bool MNGLOBMLMGA) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x82DDBB0", Offset = "0x82DC7B0", VA = "0x1882DDBB0")]
	public static bool BGADDIEIDNK(this CFFDHOCCNNL OIBGADINDDP, KMJOEPGFAJK ABMJBIODBLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x3D0AAD0", Offset = "0x3D096D0", VA = "0x183D0AAD0")]
	public static bool LENKLAKLCGK<T>(this CFFDHOCCNNL OIBGADINDDP) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x3D05D70", Offset = "0x3D04970", VA = "0x183D05D70")]
	public static bool CMIPHLCECHD<T>(this CFFDHOCCNNL OIBGADINDDP) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x3D05C80", Offset = "0x3D04880", VA = "0x183D05C80")]
	[OHAINDEKDMM]
	internal static NativeArray<T> CBFGBKAKFIB<T>(this CFFDHOCCNNL OIBGADINDDP, Allocator HPEAGMDCCBL) where T : struct, IBufferElementData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D05FF0", Offset = "0x3D04BF0", VA = "0x183D05FF0")]
	[OHAINDEKDMM]
	public static T GELIPHJBPED<T>(this CFFDHOCCNNL OIBGADINDDP) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x3D07A80", Offset = "0x3D06680", VA = "0x183D07A80")]
	[OHAINDEKDMM]
	public static T GFHJLFJLONB<T>(this CFFDHOCCNNL OIBGADINDDP) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x3D05ED0", Offset = "0x3D04AD0", VA = "0x183D05ED0")]
	public static bool DGJNDFHFAKN<T>(this CFFDHOCCNNL OIBGADINDDP, [Out] T BKMPCFIAHIG) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A9A0", Offset = "0x3D095A0", VA = "0x183D0A9A0")]
	public static T ILABBOGOMLO<T>(this CFFDHOCCNNL OIBGADINDDP) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x3D0AA50", Offset = "0x3D09650", VA = "0x183D0AA50")]
	public static T KGGFOJEMIMD<T>(this CFFDHOCCNNL OIBGADINDDP) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class CEKLNGHPBBH
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public struct EGILHKDIOKC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private HFAACADMMPC OJNBCCCOMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> JBFGDOBLCPD;

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5F90670", Offset = "0x5F8F270", VA = "0x185F90670")]
	public EGILHKDIOKC(HFAACADMMPC OJNBCCCOMPJ, NativeArray<EntityRemapUtility.EntityRemapInfo> JBFGDOBLCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x82D4B10", Offset = "0x82D3710", VA = "0x1882D4B10")]
	public LocalId OKNCLAGAFJN(LocalId KOJLNGLNBMH)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x82D4B50", Offset = "0x82D3750", VA = "0x1882D4B50")]
	public LocalId OKNCLAGAFJN(int LCCBBMBENOH)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x82D4AA0", Offset = "0x82D36A0", VA = "0x1882D4AA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IKLNFIELNAL
{
	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMKHMKAJBOJ(World FPCAGECIADG, NativeParallelHashSet<FixedString64Bytes> NICPMHLBCNA);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GCEHPGJMNCC
{
	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGICMAODKPJ(CFFDHOCCNNL DBEBLODPEEN, [Out] uint OIBGADINDDP);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BHBFAPONLGG(CFFDHOCCNNL DBEBLODPEEN, [Out] uint OIBGADINDDP);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJMDEOHGGAI(CFFDHOCCNNL DBEBLODPEEN, uint OIBGADINDDP);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GNKGKDNBBCJ(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string BONFIOEEHLB(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NLHKNEOOJFE(CFFDHOCCNNL DBEBLODPEEN, string OIBGADINDDP);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NEEBHKOKEAM(CFFDHOCCNNL DBEBLODPEEN, [Out] string BAEFNJGLAII);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HAPNDEPEHPN(CFFDHOCCNNL DBEBLODPEEN, string BAEFNJGLAII);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ONEIBFNCCHG
{
	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	Guid KNKIHMHHMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	Guid LLOMGHIALIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HFAIBPLEEHA(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ACNOHLLFDHA(MDCMDKHFPFC KOJLNGLNBMH);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid OJABBIPHILE(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDJNAPAKIHH(CFFDHOCCNNL ILPOHEPFNOO, Guid LJOMDKEKAFC);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LCDOLNECGIA(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task MHAFIMPANKK(CFFDHOCCNNL EPHCGLFDDNO, CFFDHOCCNNL IEPNOLIPIDE);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DKGAFABIAAK(CFFDHOCCNNL ILPOHEPFNOO, BPKOKGNGCMF PGCHNMPLKPP);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GMBHMBDADGH
{
	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	Guid KNKIHMHHMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGNAOHDEBEP(NativeList<Guid> PKDEEKALAOK, NativeList<Guid> NOOHKFPEOOD, NativeList<FixedString64Bytes> JFEFDBEBDFN);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FDFOLCHEFDL
{
	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HFAACADMMPC MFKHCOGPEED(Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HFAACADMMPC GMCGLJICNPN(Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HENBKBBNDFF(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JMIBMKPAMOE(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OPDHBKJGBBD(CFFDHOCCNNL DBEBLODPEEN, [Out] CFFDHOCCNNL PDHJLKKHEAK);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ACNIJLPKCCP(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void INPPKBHGKEM(CFFDHOCCNNL DBEBLODPEEN, int JGGIBDMAPLG);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CFFDHOCCNNL JBHEHAFNMPK(CFFDHOCCNNL PDHJLKKHEAK);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DMCNMLOBCOM(HFAACADMMPC KNEMEBLIDKG, bool PABDBBIKNFB);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OMNPIHKCMOL(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ICIMGELCDED(CFFDHOCCNNL DBEBLODPEEN, bool NAHPFEEEICA);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int LPOHLODGMBJ();

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BKMJDHGBJMB(CFFDHOCCNNL ILPOHEPFNOO);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HDGLCOCHNOP
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<CFFDHOCCNNL, CFFDHOCCNNL> MBKPAGMMCNC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<CFFDHOCCNNL, CFFDHOCCNNL> DOLCDFCIIGJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<CFFDHOCCNNL, CFFDHOCCNNL, CFFDHOCCNNL> CBBHBMKJAKG;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<CFFDHOCCNNL> EPFGHPBCFNL;

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IICCDMALIJC(CFFDHOCCNNL ILPOHEPFNOO, CFFDHOCCNNL DGEBLJIELPL);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CFFDHOCCNNL PNEEPLHINKB(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HFAACADMMPC DKHAJGIEPLH(CFFDHOCCNNL ILPOHEPFNOO, Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CFFDHOCCNNL IMNOONOJDGK(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CEMOJOGNLGI(CFFDHOCCNNL ILPOHEPFNOO, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JLGGFENFABN(CFFDHOCCNNL ILPOHEPFNOO, float ECOEJMIBMGD);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NDAECFAOLGK(CFFDHOCCNNL ILPOHEPFNOO, [Out] CFFDHOCCNNL IEPNOLIPIDE);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NHHBHGLEELH(CFFDHOCCNNL ILPOHEPFNOO, [Out] RigidTransform CACKKPMDMMG);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 JABAHILHMIA(HOJNODHJJPG JPOGJOKKBEK);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion DJMDGGBMMCM(HOJNODHJJPG JPOGJOKKBEK);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class DPEOFAHKFLK
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IBJJOLANEGC
{
	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	object OMMFCEJNDKK
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GABJLHJEELJ
{
	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLCHGHBMLPG(CFFDHOCCNNL KOJLNGLNBMH, FEFKONOOGAB GAHJODIGGJP);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOPCIEFFHNM(FEFKONOOGAB GAHJODIGGJP);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JHPBHBHLFJE(CFFDHOCCNNL ILPOHEPFNOO, [Out] FEFKONOOGAB HFEKLBOFAJO);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ILGKAEGOOCA
{
	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBLIEKIMMED(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ReadOnlySpan<CFFDHOCCNNL> JPCCDINDCKP();
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[Flags]
public enum JENIILFINEP
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
public interface LKMCAJFDHNO
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public ref struct DGALCAGNJBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ReadOnlySpan<CFFDHOCCNNL> HIGLAMOMJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public ReadOnlySpan<CFFDHOCCNNL> MPFOPJKJNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CFFDHOCCNNL ADOHHLKBFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CFFDHOCCNNL LKNJNNBCJMK;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGEEDNBDOLM(CFFDHOCCNNL IHKPIHGGPGN, CFFDHOCCNNL BFOLMNLJDIN);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JJBEPMDGNPG(CFFDHOCCNNL KMKNICEEDJF, bool GPAPPOJDLEG);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FCPJFGNCAMP(CFFDHOCCNNL OHPAEPDKLFG, CFFDHOCCNNL OAAHNLHDMKN);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OHLEFMINHDE(CFFDHOCCNNL EIEILELNLLN, bool GPAPPOJDLEG);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OIGAENHOLNA(CFFDHOCCNNL EIEILELNLLN);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BEJAOHKNPGJ(CFFDHOCCNNL EIEILELNLLN);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CFFDHOCCNNL BJFIPLOCHGH(CFFDHOCCNNL KMKNICEEDJF);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ReadOnlySpan<CFFDHOCCNNL> LACFFDEEBJO(CFFDHOCCNNL EIEILELNLLN);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ReadOnlySpan<CFFDHOCCNNL> IAFHADMGBHE(CFFDHOCCNNL EIEILELNLLN);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DGALCAGNJBP JHDJPKCFPDH(CFFDHOCCNNL EIEILELNLLN, float NDKODDIMMBL, float EPHNEDDFLBE);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ANPKLIHKIID(CFFDHOCCNNL EIEILELNLLN, [Out] DOFJCKMAEFH EGACJPALCCH);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OGOHCNCGKHA(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MKCOMMIGPEL(CFFDHOCCNNL ILPOHEPFNOO);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public readonly struct OLNAFHJLEIJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly string BKILENEPEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly T PLEDLJICBFM;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x5884E30", Offset = "0x5883A30", VA = "0x185884E30")]
	public OLNAFHJLEIJ(T PLEDLJICBFM, [Optional][CallerMemberName] string BKILENEPEEB)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly OLNAFHJLEIJ<int> OBHFOEKGJGB;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static readonly OLNAFHJLEIJ<int> JPPKPGPPICK;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly OLNAFHJLEIJ<int> KEPLLLJFNEF;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public enum GDPONGIPBOC
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class MMJKNGONIAK
{
	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x1435540", Offset = "0x1434140", VA = "0x181435540")]
	public static bool JNEODNAAHNI(this GDPONGIPBOC EKPDKNLBIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x18541D0", Offset = "0x1852DD0", VA = "0x1818541D0")]
	public static bool KHDFFBKIINJ(this GDPONGIPBOC EKPDKNLBIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x30FD0D0", Offset = "0x30FBCD0", VA = "0x1830FD0D0")]
	public static bool CGHCFBMCBPI(this GDPONGIPBOC EKPDKNLBIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x1435550", Offset = "0x1434150", VA = "0x181435550")]
	public static bool DDIIFGFNKJL(this GDPONGIPBOC EKPDKNLBIHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IACOGKDGFJE
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public enum AFNBJFLOBBF
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
	public enum AOAMECMHOMK
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	AFNBJFLOBBF NNGDEFPNOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	bool LJCFPJBOHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	bool FCPHBJDNDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	AOAMECMHOMK DLCHICDFINP
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
public interface DEPFOAJEOEC
{
	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	GDPONGIPBOC ONCJIEJLBNB
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	GDPONGIPBOC JEKMEOOFFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	GDPONGIPBOC KAHFHFOBIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	GDPONGIPBOC EAKGOBIEKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	GDPONGIPBOC NOHIFJINDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	GDPONGIPBOC NIMFCAFDJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	GDPONGIPBOC CEPHNOLNJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	GDPONGIPBOC NICIHPOIACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	GDPONGIPBOC GNNDKMKAMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	GDPONGIPBOC DNJCJJCBNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	GDPONGIPBOC MIIIKKOPDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	GDPONGIPBOC AEMFMCPJHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	GDPONGIPBOC PEEKLMLKEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	GDPONGIPBOC HOHAMBMLCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	GDPONGIPBOC OGFNCKMEEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	GDPONGIPBOC IBIMNPGJFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	GDPONGIPBOC BLICPNPFHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	GDPONGIPBOC CAFHBKJNNCH
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	GDPONGIPBOC HLBMLEEEHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	GDPONGIPBOC NOMABAJKGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LGFPFICEOKK(OLNAFHJLEIJ<int> IAPLIGCGIFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PAAJHIOLAGJ
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event FMEDDJHIOCB.MDDFNEGDNFC PIGIMFHFDFF;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CFFDHOCCNNL HFJNEDAEFMK(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HFAACADMMPC MLJCLBPMJOM(Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EJDHJMPEDMM KNALKDHIADF(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LEILFDLHLJM(IEnumerable<CFFDHOCCNNL> HNPDHMHIDDP);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EJDHJMPEDMM NOEPEABDBLI(CFFDHOCCNNL IEPNOLIPIDE, CFFDHOCCNNL OJNBCCCOMPJ, bool HFEKFIHPIAN, CFFDHOCCNNL ADGCHNLKFKK);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CFFDHOCCNNL JLPLCLPMPFD(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PLPIOCHBPFK(CFFDHOCCNNL ILPOHEPFNOO, CFFDHOCCNNL IEPNOLIPIDE, bool DGDBEFGIMDH = false);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PJGEFGNBKJJ(CFFDHOCCNNL ILPOHEPFNOO, CFFDHOCCNNL IEPNOLIPIDE);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FFPBBOALHAK(CFFDHOCCNNL GIDPAMHIBBD, CFFDHOCCNNL JBECGICDCIL);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	HFAACADMMPC JNCEHKANNMM(CFFDHOCCNNL LNPPHFKBHPJ);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ANIGGABPHOJ(CFFDHOCCNNL ILPOHEPFNOO, CFFDHOCCNNL FFMPDDLKNAG);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HFAACADMMPC KCPFCBNAGPI(HFAACADMMPC GKHHGFOFEKD, JENIILFINEP HHPCFHFLKHA, Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool LHAJGOJLFON(CFFDHOCCNNL ILPOHEPFNOO, CFFDHOCCNNL PMJLFMNJFLB);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CFFDHOCCNNL HOBAMGOOOMN(CFFDHOCCNNL ADGCHNLKFKK, CFFDHOCCNNL OICKAOFGMOK);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool GJNAIPFECIK(CFFDHOCCNNL ADGCHNLKFKK, CFFDHOCCNNL OICKAOFGMOK, [Out] CFFDHOCCNNL BKCCCEPHHKG);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "17")]
	CFFDHOCCNNL JDLCCLKMOJF(CFFDHOCCNNL[] KNEMEBLIDKG);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CFFDHOCCNNL AMILDFNHGII(CFFDHOCCNNL ILPOHEPFNOO, uint PBNGKLJBCAB);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class DCIEIPLMEFK
{
	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x82D2460", Offset = "0x82D1060", VA = "0x1882D2460")]
	public static bool CAHBCLGMMLH(this PAAJHIOLAGJ EJLIMJDFHFM, CFFDHOCCNNL ILPOHEPFNOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x82D2550", Offset = "0x82D1150", VA = "0x1882D2550")]
	public static HFAACADMMPC KCPFCBNAGPI(this PAAJHIOLAGJ AKIJMANCHPA, CFFDHOCCNNL ILPOHEPFNOO, JENIILFINEP HHPCFHFLKHA, Allocator HPEAGMDCCBL)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x82D27E0", Offset = "0x82D13E0", VA = "0x1882D27E0")]
	public static HFAACADMMPC PFCNDPLDEEJ(this PAAJHIOLAGJ AKIJMANCHPA, CFFDHOCCNNL ILPOHEPFNOO, Allocator HPEAGMDCCBL)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x82D2420", Offset = "0x82D1020", VA = "0x1882D2420")]
	public static HFAACADMMPC BHAFEDOLNJP(this PAAJHIOLAGJ AKIJMANCHPA, CFFDHOCCNNL ILPOHEPFNOO, Allocator HPEAGMDCCBL)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x82D23E0", Offset = "0x82D0FE0", VA = "0x1882D23E0")]
	public static HFAACADMMPC AJAFEKMGOFB(this PAAJHIOLAGJ AKIJMANCHPA, CFFDHOCCNNL ILPOHEPFNOO, Allocator HPEAGMDCCBL)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x82D2510", Offset = "0x82D1110", VA = "0x1882D2510")]
	public static HFAACADMMPC CIJCJGBLIDI(this PAAJHIOLAGJ AKIJMANCHPA, CFFDHOCCNNL ILPOHEPFNOO, Allocator HPEAGMDCCBL)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x82D24D0", Offset = "0x82D10D0", VA = "0x1882D24D0")]
	public static HFAACADMMPC CGPMFOPNEDJ(this PAAJHIOLAGJ AKIJMANCHPA, CFFDHOCCNNL ILPOHEPFNOO, Allocator HPEAGMDCCBL)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x82D2940", Offset = "0x82D1540", VA = "0x1882D2940")]
	public static HFAACADMMPC PJBHNFBKEGK(this PAAJHIOLAGJ AKIJMANCHPA, CFFDHOCCNNL ILPOHEPFNOO, Allocator HPEAGMDCCBL)
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x82D2820", Offset = "0x82D1420", VA = "0x1882D2820")]
	public static HFAACADMMPC PJBHNFBKEGK(this PAAJHIOLAGJ AKIJMANCHPA, HFAACADMMPC ILPOHEPFNOO, Allocator HPEAGMDCCBL)
	{
		return default(HFAACADMMPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AJICJOGHIKK
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x82CC4D0", Offset = "0x82CB0D0", VA = "0x1882CC4D0", Slot = "0")]
	Task<DMBCIAMLBOC> NHECHGFGKLO(KFMAIGOOEPB MOPLHOCDFJF, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "1")]
	void CGHHKGJGIGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CLBOLGMGHEH
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event FMEDDJHIOCB.MDDFNEGDNFC PIGIMFHFDFF;

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CFFDHOCCNNL JLPLCLPMPFD(CFFDHOCCNNL EPHCGLFDDNO);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<CFFDHOCCNNL> IAJADIGGBBB();

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<CFFDHOCCNNL> OIEKEHIEJEM(CFFDHOCCNNL IEPNOLIPIDE);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IONBNPNOGCM(CFFDHOCCNNL LNBMOBBABLP, CFFDHOCCNNL PNDNFMIIACB, [Out] EJDHJMPEDMM ENNMFHLFKGN);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GAIOGOOFPED(CFFDHOCCNNL LNBMOBBABLP, CFFDHOCCNNL HNMGCLLLMMN, [Out] EJDHJMPEDMM ENNMFHLFKGN);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JEBMHGEFPGL(CFFDHOCCNNL LNBMOBBABLP);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PJGEFGNBKJJ(CFFDHOCCNNL HEEMCKLNAEP, CFFDHOCCNNL AHLLNEDBFNM);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EJDHJMPEDMM OBNCIPILLJJ(CFFDHOCCNNL ILPOHEPFNOO);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PJCKLHFCOMI
{
	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	bool AALKOCKIOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	bool KMNOGGAFBKL
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	bool NNGBMDNFOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DLOBIMKFHFK
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MHBPHBINMOE
{
	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBPGDDEHJGP(CFFDHOCCNNL ILPOHEPFNOO, KMJOEPGFAJK ABMJBIODBLM);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNLBNBPAOJH(CFFDHOCCNNL ILPOHEPFNOO, KMJOEPGFAJK ABMJBIODBLM);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LCGJIAHIHJG
{
	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OOJKGBPAOPB<string> DMGDKEBIHNH(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OOJKGBPAOPB<string> DEHIAFAFGFE(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DLCOIMDMNAK(CFFDHOCCNNL ILPOHEPFNOO, OOJKGBPAOPB<string> OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OANPFBIGFAN(CFFDHOCCNNL ILPOHEPFNOO, OOJKGBPAOPB<string> OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DLKPFLFFJJF(CFFDHOCCNNL ODOEOPDEJCD, CFFDHOCCNNL OMLCAAOFEOC);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GLINBMAHDKN
{
	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLBPEPNMNAE PKLIIBDJFDE(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFGNAEEMCFG(CFFDHOCCNNL DBEBLODPEEN, CLBPEPNMNAE KCLJHPPKDIH);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JPIGCGHBAMG(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ONGAEJJJPOF(CFFDHOCCNNL DBEBLODPEEN, bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OOJKGBPAOPB<string> ANFNMGECBAM(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FMCBMFABLPM(CFFDHOCCNNL DBEBLODPEEN, OOJKGBPAOPB<string> OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OOJKGBPAOPB<string> JHLMAOGBAKO(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PBOLCHOMENN(CFFDHOCCNNL DBEBLODPEEN, OOJKGBPAOPB<string> OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OOJKGBPAOPB<string> OMNHKLFNGPJ(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LAIPMEOKALN(CFFDHOCCNNL DBEBLODPEEN, OOJKGBPAOPB<string> OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OOJKGBPAOPB<string> EMOOIBLIIHB(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HALILMIFEOP(CFFDHOCCNNL DBEBLODPEEN, OOJKGBPAOPB<string> OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KLLGACLMDIE(CFFDHOCCNNL DBEBLODPEEN, CFFDHOCCNNL FANAFCDPEEP);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ICOBLIPELEK
{
	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCFHCIJPBPO([In] float3 PFKAKKFNLEP, [In] float3 DBIJDHDPOAF, float FKJNFPHAHOE, [Out] KDGDMHECDPL BFNIKFOGPBG, [Out] CFFDHOCCNNL JAPNMDMDLII);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BGEDODICENA([In] float3 PFKAKKFNLEP, float BNDEJLLMNLK, List<CFFDHOCCNNL> KNEMEBLIDKG);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int IINJKEODDLC(Plane[] OKIEBJAEKHK, float3 PFKAKKFNLEP, float3 DDKGCHGHFEE, quaternion DINDLKHALMD, List<CFFDHOCCNNL> KNEMEBLIDKG);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PNJODMHCMHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCFHCIJPBPO([In] NativeArray<Entity> ADEOCFOIFAB, [In] float3 PFKAKKFNLEP, [In] float3 DBIJDHDPOAF, [In] NativeArray<KDGDMHECDPL> MHPOGHGKIKJ);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> BGEDODICENA([In] NativeArray<Entity> ADEOCFOIFAB, [In] float3 PFKAKKFNLEP, float BNDEJLLMNLK);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> IINJKEODDLC([In] NativeArray<Entity> ADEOCFOIFAB, [In] NativeArray<float4> OPLIFBKGDHN);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct DAGGODKLHMD : PDCJNGLGLLH, IEquatable<DAGGODKLHMD>
{
	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	public int CLIFKJOPCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x14B6AC0", Offset = "0x14B56C0", VA = "0x1814B6AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	public int IJGCLEGIDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x3119BD0", Offset = "0x31187D0", VA = "0x183119BD0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6AD40", Offset = "0x6E69940", VA = "0x186E6AD40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x82D2200", Offset = "0x82D0E00", VA = "0x1882D2200", Slot = "8")]
	public bool Equals(DAGGODKLHMD IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x82D2250", Offset = "0x82D0E50", VA = "0x1882D2250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct KDGDMHECDPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float LFCDOMKLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public float3 JMBLGBJKENI;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IEHNMNFOAJN
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HAOJOPIKEAB
{
	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	JHEPOKDHIGJ GHGJCDLHFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<HFAACADMMPC, NativeArray<RRObjectPrefabData>> MICINHMHNNC;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<HFAACADMMPC> OGCIEIENLIA;

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HFAACADMMPC AJOIJDDHOFC();

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BHNGGMAMCBI EPGFFIEEMLH(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData MLOFLKDPFDL(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JLFOELIKFKM(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MDCMDKHFPFC FMJAPFNONKC(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BKLBJHGCPJP(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FOMEKHDFLBO(CFFDHOCCNNL ILPOHEPFNOO, [Out] Transform LMGPODOPMIJ);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CFFDHOCCNNL KEFBCGIGIBO(BPKOKGNGCMF PIIIPDILKIL);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool HOIIKDOODNN(BPKOKGNGCMF PIIIPDILKIL, [Out] CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BPKOKGNGCMF AFPOCKCICDE(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HFAACADMMPC KEFBCGIGIBO(NativeArray<BPKOKGNGCMF> PIIIPDILKIL, Allocator HPEAGMDCCBL, bool JBJPBCIHLFA = true);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LPGEOGEMPJK(NativeArray<DOIPNDLFEIK> KDEFIGKNLBL, NativeArray<BPKOKGNGCMF> MGMACKHGDAB, NativeArray<Entity> OMANNPFHFEC, OOJKGBPAOPB<PECJBNMGEAA> OIEOIEMMOPB);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	MDCMDKHFPFC GPFLLEMHGBK();

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	MDCMDKHFPFC PKKMJLPPHKP(RRObjectPrefabData JBGFIFPOODI, [Optional] MJAPGGNPMGD HMOHGLOAPEB);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	PCHNCFLHIJE GAGICBBKGBC();

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	CPLPDHBAEJC BHMPDAIAEDM();

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	NMGAFDHDPBL OCKPFBINHNA(LDLEEKNJJFJ NIKMBPKMJPO);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void PJDENONAAFL(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool PNADBPNIPEK(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HFAACADMMPC CCAKNHPIBEH(HFAACADMMPC DJFJPMJHMNB, Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool GDLGKCEKPAD(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IAIEBPPIJPL(CFFDHOCCNNL ILPOHEPFNOO, ComponentTypes IHJEFNGLFPG);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "28")]
	CFFDHOCCNNL DPHOAPAILJF(Transform LMGPODOPMIJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class MOCFADIHEFI
{
	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x82E1F00", Offset = "0x82E0B00", VA = "0x1882E1F00")]
	internal static CFFDHOCCNNL OJDDFMAPJAO(this Entity CGLPEGHHGMM, HAOJOPIKEAB AMCCDFCIJGE)
	{
		return default(CFFDHOCCNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x82E1AF0", Offset = "0x82E06F0", VA = "0x1882E1AF0")]
	public static MDCMDKHFPFC DHOKHKBNBHL(this HAOJOPIKEAB AMCCDFCIJGE, LocalId ILPOHEPFNOO)
	{
		return default(MDCMDKHFPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x82E1E50", Offset = "0x82E0A50", VA = "0x1882E1E50")]
	public static CFFDHOCCNNL KEFBCGIGIBO(this HAOJOPIKEAB AMCCDFCIJGE, LocalId ILPOHEPFNOO)
	{
		return default(CFFDHOCCNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x82E1A50", Offset = "0x82E0650", VA = "0x1882E1A50")]
	public static BPKOKGNGCMF AFPOCKCICDE(this HAOJOPIKEAB AMCCDFCIJGE, LocalId ILPOHEPFNOO)
	{
		return default(BPKOKGNGCMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x82E1CB0", Offset = "0x82E08B0", VA = "0x1882E1CB0")]
	public static PCHNCFLHIJE GBBAFJCNDLI(this HAOJOPIKEAB AMCCDFCIJGE, RigidTransform HPMDLPBCCIF)
	{
		return default(PCHNCFLHIJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x82E1B00", Offset = "0x82E0700", VA = "0x1882E1B00")]
	public static NMGAFDHDPBL DMOEEKILKPM(this HAOJOPIKEAB AMCCDFCIJGE, LDLEEKNJJFJ NEIMHFIDMMK, RigidTransform HPMDLPBCCIF)
	{
		return default(NMGAFDHDPBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x82E1FB0", Offset = "0x82E0BB0", VA = "0x1882E1FB0")]
	public static CPLPDHBAEJC PDDNAFJFJMJ(this HAOJOPIKEAB AMCCDFCIJGE, RigidTransform HPMDLPBCCIF)
	{
		return default(CPLPDHBAEJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x82E1AC0", Offset = "0x82E06C0", VA = "0x1882E1AC0")]
	private static void CBFDCBONDME(MDCMDKHFPFC HFOABIPNLOP, RigidTransform HPMDLPBCCIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal interface JBPDIAGNFKH
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HHNLABFNIMA
{
	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	bool CBFLOMNLHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	CFFDHOCCNNL CIKJGDNIJOA
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	MDCMDKHFPFC NEAKDHIJALK
	{
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event FDIKEIKEMKB LMEELDGGLHP;

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CFFDHOCCNNL HOBAMGOOOMN(CFFDHOCCNNL ADGCHNLKFKK, CFFDHOCCNNL OICKAOFGMOK);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GJNAIPFECIK(CFFDHOCCNNL ADGCHNLKFKK, CFFDHOCCNNL OICKAOFGMOK, [Out] CFFDHOCCNNL BKCCCEPHHKG);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AELBEDEADIK();

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IKEHCIFHBNG();

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ILJEGOCKAKG(CFFDHOCCNNL ADGCHNLKFKK);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool AEDLPGECCBN(CFFDHOCCNNL ADGCHNLKFKK);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public delegate void FDIKEIKEMKB(MDCMDKHFPFC IOMJMAIECAD, MDCMDKHFPFC BFAPLJKLDKC);
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class GHNKDPBLFFG
{
	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x82D5AE0", Offset = "0x82D46E0", VA = "0x1882D5AE0")]
	public static bool DPGKLDJIAPN(this HHNLABFNIMA EFPFBNJEBDH, MDCMDKHFPFC ADGCHNLKFKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x82D5B30", Offset = "0x82D4730", VA = "0x1882D5B30")]
	public static bool FHIHLJJDPGL(this HHNLABFNIMA EFPFBNJEBDH, CFFDHOCCNNL ADGCHNLKFKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x82D5C10", Offset = "0x82D4810", VA = "0x1882D5C10")]
	public static bool JEFMFAHMAME(this HHNLABFNIMA EFPFBNJEBDH, CFFDHOCCNNL ADGCHNLKFKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MGFNGEKLBMB
{
	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIPFCJEMDLO(NativeList<RRObjectPrefabData> KIBOINCPENA);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OKKGAIPBFID
{
	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNJCPJHOMJB(MDCMDKHFPFC HFOABIPNLOP, MCKGLJLILAB MEGBHLJHDNE, List<MDCMDKHFPFC> GDMLMHKNJNF);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int NGNKEAMIGBJ(MDCMDKHFPFC HFOABIPNLOP, MCKGLJLILAB MEGBHLJHDNE);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLIHCCBGMFG(MDCMDKHFPFC HFOABIPNLOP, List<MDCMDKHFPFC> GDMLMHKNJNF);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KFAOOJCFEOF(MDCMDKHFPFC JAOGNEOIMGK, MDCMDKHFPFC ADGCHNLKFKK, MCKGLJLILAB MEGBHLJHDNE);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MDCMDKHFPFC MGNLDCLKGEH(MDCMDKHFPFC JAOGNEOIMGK, int LCCBBMBENOH, MCKGLJLILAB MEGBHLJHDNE);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MLBFPHGLONM(MDCMDKHFPFC JAOGNEOIMGK, MDCMDKHFPFC ADGCHNLKFKK, MCKGLJLILAB MEGBHLJHDNE);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MKDBELBFJHC(MDCMDKHFPFC JAOGNEOIMGK, MDCMDKHFPFC ADGCHNLKFKK, MCKGLJLILAB MEGBHLJHDNE);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NKPELIOBJFJ(MDCMDKHFPFC JAOGNEOIMGK, MCKGLJLILAB MEGBHLJHDNE);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PCCHPAKLLBO(MDCMDKHFPFC JAOGNEOIMGK, MDCMDKHFPFC ADGCHNLKFKK, MCKGLJLILAB MEGBHLJHDNE);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CPMGCNAMKNI(Entity JAOGNEOIMGK, Entity ADGCHNLKFKK, MCKGLJLILAB MEGBHLJHDNE);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EAOMFDOCFCG(Entity JAOGNEOIMGK, MCKGLJLILAB MEGBHLJHDNE);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IIGILMEJGMK(MDCMDKHFPFC ADGCHNLKFKK, MCKGLJLILAB MEGBHLJHDNE);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PNJILNBIGJH
{
	[Cpp2IlInjected.Token(Token = "0x17000202")]
	EJGODFOIGNH FABHBAAFNKI
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
	MJOIKADLMGF FIOMMADEKAG(EJGODFOIGNH CMBCIMNOCEH);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EJGODFOIGNH JALNMJFALEF();

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EJGODFOIGNH DEBEDNJHEJP();
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NCECDAJCGGB
{
	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IFEFIAIPENI(CFFDHOCCNNL ADGCHNLKFKK, [Out] CFFDHOCCNNL DHHIANLFEIL);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BLFGILFBOLO
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<CFFDHOCCNNL> DIECPFFBKNA;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCOHDFHCOBH(CFFDHOCCNNL LNPPHFKBHPJ, bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOGAGDGIICG(CFFDHOCCNNL LNPPHFKBHPJ, bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJHCFBEPDEE(CFFDHOCCNNL LNPPHFKBHPJ, int BKMPCFIAHIG);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PGJKJDGHCDD
{
	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<CFFDHOCCNNL> BMNOEFNENLM(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CFFDHOCCNNL NNPPMAODMCL(CFFDHOCCNNL ILPOHEPFNOO, int LCCBBMBENOH);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int FFMKCHCMCKB(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LIACMAGLFCP EJGCDCBHPOL(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDGLBLHMKDE(CFFDHOCCNNL ILPOHEPFNOO, LIACMAGLFCP KCHMACEBLIA);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CFFDHOCCNNL PCMGEAPOPBC(CFFDHOCCNNL ILPOHEPFNOO, [Optional] float3? FEMJLOIOGIK, [Optional] quaternion? DINDLKHALMD, [Optional] float3? ECJMFFOLCCL);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CFFDHOCCNNL GHLAOGPNKHI(CFFDHOCCNNL ILPOHEPFNOO, int LCCBBMBENOH, [Optional] float3? FEMJLOIOGIK, [Optional] quaternion? DINDLKHALMD, [Optional] float3? ECJMFFOLCCL);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CFAHPAGLCHJ(CFFDHOCCNNL ILPOHEPFNOO, int LCCBBMBENOH);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MKMNEIGFAPL(CFFDHOCCNNL ILPOHEPFNOO);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NDNCKLLGKIM
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EJCMHKCPHKA
{
	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKHELHGOEBB(CFFDHOCCNNL ILPOHEPFNOO, ReadOnlySpan<TerrainGenerationLayer> EBFNGEDLBDF);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIBBBDAMIJH(CFFDHOCCNNL ILPOHEPFNOO, ReadOnlySpan<CPAFJEBFNBF> EBFNGEDLBDF);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EFHDEPNHOPK
{
	[Cpp2IlInjected.Token(Token = "0x17000203")]
	bool LIMHGEMLGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKFBEODPHIK();

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNPPLFKLIGO();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CDFOMENACGK();

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KGLDKGCEIPO();

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FENLCAJOECL();

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DJBPEKJLGOE();

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PAHOGGNCNGC();

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHOGBOKPJCB();

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EBNJDBHIPIJ();

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AOLHPACAJKH();

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HLDDDELBFNJ();

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FAFJEFLMNMB();
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JNOEMKCMLEI
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool APGFAKLMOLA(CFFDHOCCNNL ADGCHNLKFKK, [Out] int JAOGNEOIMGK);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKOGOFPPBOE(CFFDHOCCNNL ADGCHNLKFKK, int JAOGNEOIMGK);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AAPPILJDNHP(CFFDHOCCNNL ADGCHNLKFKK, bool BJGOOLGNJIF);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNJGLHOJNLA(CFFDHOCCNNL ADGCHNLKFKK, float ODJJBNBGECF, float CCFBFCNDENG, float AJAJBIGENHD);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PEEKGKOADHN(CFFDHOCCNNL ILPOHEPFNOO, [Out] float CCFBFCNDENG, [Out] float AJAJBIGENHD);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CHGGKHHGDFG(CFFDHOCCNNL ADGCHNLKFKK, float3 FEMJLOIOGIK, quaternion DINDLKHALMD);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BDLFIAAKHDJ(CFFDHOCCNNL ADGCHNLKFKK, [Out] float3 FEMJLOIOGIK, [Out] quaternion DINDLKHALMD);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PFOENEFOHBP(CFFDHOCCNNL ADGCHNLKFKK);
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DDHLMFDNOPE
{
	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKGBKJLKNMB(Entity CGLPEGHHGMM, [In] float3 BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 PLFOIIFLBJC(Entity CGLPEGHHGMM);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBPEAAJDDML(Entity CGLPEGHHGMM, [In] quaternion BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion OCLNCOLHMLN(Entity CGLPEGHHGMM);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDPDOAEKJLM(Entity CGLPEGHHGMM, [In] float3 FEMJLOIOGIK, [In] quaternion DINDLKHALMD);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ELBPNLINFGN(Entity CGLPEGHHGMM, [Out] RigidTransform DLDHFIENAGL);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EGPEECLGCOB(Entity CGLPEGHHGMM, [In] float3 FEMJLOIOGIK, [In] quaternion DINDLKHALMD);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBPKGENLNAG(Entity CGLPEGHHGMM, [Out] float3 FEMJLOIOGIK, [Out] quaternion DINDLKHALMD);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JBPKGENLNAG(Entity CGLPEGHHGMM, [Out] RigidTransform DLDHFIENAGL);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IJOLONKJLMF(Entity CGLPEGHHGMM, float BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float LNADJFLHJIL(Entity CGLPEGHHGMM);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BLPONJNJADE(Entity CGLPEGHHGMM, [In] float3 BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 KFEOIGOBPAH(Entity CGLPEGHHGMM);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JHGHMEEEBLO(Entity CGLPEGHHGMM, [In] quaternion BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion BJPKEAMFIFA(Entity CGLPEGHHGMM);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MKJOGBDDJDN(Entity CGLPEGHHGMM, float BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float DLJMCCGCDFF(Entity CGLPEGHHGMM);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JKGPHJPNACC(Entity CGLPEGHHGMM, [Out] float4x4 PPLFAKNDFFF);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OOJDIJJMPNF(Entity CGLPEGHHGMM, [In] float4x4 PPLFAKNDFFF);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EGINBNMPKEP(Entity CGLPEGHHGMM);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KOOJLLAELCA(Entity CGLPEGHHGMM, Entity EAAAJHJCLLM, Entity AHLLNEDBFNM);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class CGGLAPKNPHL
{
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CEIPIGHCEMM
{
	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BAHPGDLJEEP(bool JOGHHJHGGAG);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PDDKMNNKOGD
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFINOPDICMF(CFFDHOCCNNL DBEBLODPEEN, OOJKGBPAOPB<string> OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPDHKEACBOE(CFFDHOCCNNL DBEBLODPEEN, OOJKGBPAOPB<string> OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CMEJLAPBEGE(CFFDHOCCNNL DBEBLODPEEN, OOJKGBPAOPB<string> OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IKEKKLFNFBH(CFFDHOCCNNL DBEBLODPEEN, OOJKGBPAOPB<string> OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EPBOEJGLHFO(CFFDHOCCNNL DBEBLODPEEN, OOJKGBPAOPB<string> OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HAKPOJIJKPM(CFFDHOCCNNL DBEBLODPEEN, OOJKGBPAOPB<string> OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int LHDGGABBENP(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int JLHCMMMKEIA(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int DDGHADKIDNL(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EAICLJOGAIB<string> GCACJCKADGN(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OKIHLGCCDOA(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EAICLJOGAIB<string> ACDMPFFPLLF(CFFDHOCCNNL DBEBLODPEEN);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LFCFCCLEPID(CFFDHOCCNNL DBEBLODPEEN, string GMFCELNCIOG);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OEGIKOCDEFP(string GMFCELNCIOG, PMBDFDDDFGF LGHJKACPOPK);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CFFDHOCCNNL FOLFDMJNBIE(string GMFCELNCIOG);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OFLNDGMOFNA(string GMFCELNCIOG, PMBDFDDDFGF LGHJKACPOPK);

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NAACCHFHJDF(CFFDHOCCNNL NBKMFFCOMKP, string GMFCELNCIOG, PMBDFDDDFGF LGHJKACPOPK);

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "17")]
	EAICLJOGAIB<string> DEONCJPAAGC();
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class DMHGFNFMIBO
{
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HJIDLEBGPMO
{
	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World CEPIIINEDBO(string FLOJADNFOHK = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World BCLLCGBAMNM(string FLOJADNFOHK = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World FEPIEPKAMFK(string FLOJADNFOHK = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World ILBPDHEIELN(string FLOJADNFOHK = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JAAAEPMFELN
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	World PLLLLMOBEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	World MDGAJPJJCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	EntityManager IEBLFDPIILL
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	bool MIILNIMFKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase LODKKCOGCFG(Type MDCDODCGNEK);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class JMILFEINIDD
{
	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x82DC8A0", Offset = "0x82DB4A0", VA = "0x1882DC8A0")]
	public static ComponentSystemBase EPAPIEEDIEG(this World FPCAGECIADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE510", Offset = "0x3CCD110", VA = "0x183CCE510")]
	public static T LODKKCOGCFG<T>(this JAAAEPMFELN HMEMAAKEMEA) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IICMACLJNJC
{
	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIOHLHOJBKL(NativeListAsync<Entity> OENOHMJKIMP);

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KILNPGCBIPA(LELMGHONPJJ BEOKODAAFOM);

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPJCJEPFLFM(NativeListAsync<Entity> DKCDLIDCNKC, bool PIGLABJPCAC);

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DEENPMHBLCG();

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GKNLGNKAGOK(Entity OLIIIAEGOLD);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CPIJBHEGONL
{
	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JFICLPICBKK(Collider CKPKIHAALAC, [Out] GGODHFCPDIN HIKICAMIAAP);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CIHNBDDKDMO
{
	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider BPFDLJGHFKB(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject JMDLNPCHPFK(CFFDHOCCNNL JEMNOOHOGCI, GameObject JBPODHEOMGI, Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN);

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKBMLLAJBNL(GameObject CKPKIHAALAC);

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider MMDIFILLOJB<TCollider>(GameObject LJBAJCEEOPN) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CIPOBCJMMPO(Collider CKPKIHAALAC);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject AADIFLMIPEH<TCollider>(string BKILENEPEEB) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KOHAGOCCJDH PHIKOEOILJJ(CFFDHOCCNNL POGEMGGLBCH, CFFDHOCCNNL JOPDPCNFHKO, LDLEEKNJJFJ HDECADNGAAE, float3 LOGMLDPBNJF, quaternion IALKDENEGAB, float3 LEDEKGCGNFK);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HADAKDNPONK(CFFDHOCCNNL ILPOHEPFNOO, [Out] KOHAGOCCJDH CKPKIHAALAC);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PIIHELKAOLJ(CFFDHOCCNNL ILPOHEPFNOO, [Out] CFFDHOCCNNL OLIIIAEGOLD);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public enum KDHGAMMMLEN
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
public interface CLNBIBBJHAN
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public struct FFHPFBFKFJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int HDECADNGAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GameObject JBPODHEOMGI;
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGKNOFDJECF(CFFDHOCCNNL ILPOHEPFNOO, PKHKHHIBOLB DBOLDLOAIED, bool HFAGPHIFJGK, GCOFBKNOKHB JMAOKDDFKNK);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOPBIGBCGFO(CFFDHOCCNNL ILPOHEPFNOO, PKHKHHIBOLB DBOLDLOAIED, bool HFAGPHIFJGK, bool CBCHBJIOJNB, bool GEHCHMFGHAN);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KAPOCFHGBLJ MFELIJFHLOB(CFFDHOCCNNL OLIIIAEGOLD, List<CFFDHOCCNNL> NDFBHFBIEMA);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KOHAGOCCJDH EAEOBIKDPIG(GameObject ACEIOCIECFH, GameObject KNMJLNFJLNG);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKEHMDCBBFF(GameObject ACEIOCIECFH, List<GameObject> NBLAHLKDAGP);

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DIHJAEPFFJO(GameObject KNMJLNFJLNG);

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T MMDIFILLOJB<T>(GameObject LJBAJCEEOPN) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CIPOBCJMMPO(Collider CKPKIHAALAC);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject ALDAMHIOMLK<T>(string BKILENEPEEB) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KPBHAMDOGJJ(Collider CKPKIHAALAC, [Out] CFFDHOCCNNL JAOGNEOIMGK);

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KMJIFHENHCO(CFFDHOCCNNL ILPOHEPFNOO, [Out] GGODHFCPDIN HIKICAMIAAP);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<KDHGAMMMLEN> HCFDIGBIKOI(Allocator HPEAGMDCCBL = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] NBDDDNDLMCD();
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HEALBKDPMHD
{
	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLLMLKANMJK(CFFDHOCCNNL ILPOHEPFNOO, CFFDHOCCNNL BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOKPCMLCIEN(CFFDHOCCNNL ILPOHEPFNOO, CFFDHOCCNNL BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int DKCCIDEHJJI(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CFFDHOCCNNL BFGJLKKPLNE(CFFDHOCCNNL ILPOHEPFNOO, int LCCBBMBENOH);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HFAACADMMPC JBEGCHNIILM(CFFDHOCCNNL ILPOHEPFNOO, Allocator HPEAGMDCCBL = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GGFCFFELKGP(CFFDHOCCNNL ILPOHEPFNOO, object DANCOEFIHDF, CFFDHOCCNNL BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LLABGCPCNKM(CFFDHOCCNNL ILPOHEPFNOO, object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IFDNCJHBIOH(CFFDHOCCNNL ILPOHEPFNOO, [Out] CFFDHOCCNNL BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AOONEEGODPB(CFFDHOCCNNL ILPOHEPFNOO, float3 BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IDFJLAIGKIK(CFFDHOCCNNL ILPOHEPFNOO, [Out] float3 BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NEEMOIONLBH(CFFDHOCCNNL ILPOHEPFNOO, float3 BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MFEPHPJNANK(CFFDHOCCNNL ILPOHEPFNOO, [Out] float3 BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CLCGAHHOEEH(CFFDHOCCNNL ILPOHEPFNOO, (Quaternion rot, Vector3 moments) EJBGAGMOFGM);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool KPCIOANJFIA(CFFDHOCCNNL ILPOHEPFNOO, [Out] quaternion HAGOIDNFICA, [Out] float3 LOKKCAEBMGE);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IPGGOAPPLGD(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 HLNGCBLDFHL(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 JIMFFJLGNCP(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ENOPKMAEMIG(CFFDHOCCNNL ILPOHEPFNOO, float3 BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PKEHHEMHONK(CFFDHOCCNNL ILPOHEPFNOO, float3 BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float DKNGJBFIJEH(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float ECCACLIBAFF(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ECKNIOIHPNL(CFFDHOCCNNL ILPOHEPFNOO, float BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NHIKLCFCCDE(CFFDHOCCNNL ILPOHEPFNOO, float BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode HEPIJCFKJAI(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FHNEFGHLEOJ(CFFDHOCCNNL ILPOHEPFNOO, CollisionDetectionMode BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CFBMCAPEOOJ KDAICNMBBNA(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void OIOCIAHGMIP(CFFDHOCCNNL ILPOHEPFNOO, CFBMCAPEOOJ BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool EGPHOGFFCLE(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HEKCPHAMPEN(CFFDHOCCNNL ILPOHEPFNOO, bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CFFDHOCCNNL HFJNEDAEFMK(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void JGGPFCPJDNH(CFFDHOCCNNL ILPOHEPFNOO, CFFDHOCCNNL BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	CFFDHOCCNNL JLPLCLPMPFD(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void PLPIOCHBPFK(CFFDHOCCNNL ILPOHEPFNOO, CFFDHOCCNNL BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	KEMCMOHNHFH KFGDGFJACDH(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void HKNCMDLLNBE(CFFDHOCCNNL ILPOHEPFNOO, KEMCMOHNHFH GHPLEABLMHG);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool KIGCAAAHGAG(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void LLKHLCLKOLA(CFFDHOCCNNL ILPOHEPFNOO, bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool JNKHKLCBOEK(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void IBJLJOLGKAI(CFFDHOCCNNL ILPOHEPFNOO, bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints JLHJKHEOAJK(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void CFLALFIBKAD(CFFDHOCCNNL ILPOHEPFNOO, RigidbodyConstraints BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float GPDFLNCENJB(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void DNJDEBJIPAN(CFFDHOCCNNL ILPOHEPFNOO, float BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float MMLNPDPCPBE(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void MOBHGLCHHFD(CFFDHOCCNNL ILPOHEPFNOO, float BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool KCCAHHDKEJN(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void DPGNPBHADBI(CFFDHOCCNNL ILPOHEPFNOO, bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool HIKMBFHPDFD(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void KANMNACKPLL(CFFDHOCCNNL ILPOHEPFNOO, bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CFMBDOENLHH(CFFDHOCCNNL ILPOHEPFNOO, int BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "50")]
	EJBNNOGLELE BJAMNELCMFA(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void KJPNMIMJINF(CFFDHOCCNNL ILPOHEPFNOO, EJBNNOGLELE BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	KHBKNBENECM DLJOOBKLBHB(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void ABJBMCMDOAK(CFFDHOCCNNL ILPOHEPFNOO, KHBKNBENECM BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float EMFKCNBGMMA(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void NBNFKAKPNMF(CFFDHOCCNNL ILPOHEPFNOO, float BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void LPJNKHLEJOI(CFFDHOCCNNL ILPOHEPFNOO, object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void DKKMAJABGGJ(CFFDHOCCNNL ILPOHEPFNOO, object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool JIIJBPGCFAD(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void GCCKKENLHHE(CFFDHOCCNNL ILPOHEPFNOO, object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void PBDJAIMLFHN(CFFDHOCCNNL ILPOHEPFNOO, object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool NHBHOMFDAGC(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool IOKBPMDBAHD(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody GAIPBJCLEFG(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void FACDPMBNEDG(CFFDHOCCNNL ILPOHEPFNOO, Rigidbody NHJGDBOOFHP);

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void PMBPNBLIEBN(CFFDHOCCNNL ILPOHEPFNOO, object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void FGJJNLGGGMM(CFFDHOCCNNL ILPOHEPFNOO, object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool FJCABJABLPI(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void KBLADOJDMOL(CFFDHOCCNNL ILPOHEPFNOO, float3 ANDGMPFHLOF);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void JHBCMGHONPE(CFFDHOCCNNL ILPOHEPFNOO, float3 JGLAFHCCNMJ);

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool DPBHECJGJOE(CFFDHOCCNNL ILPOHEPFNOO, [Out] float3 ANDGMPFHLOF);

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool NAHOJEMBIEB(CFFDHOCCNNL ILPOHEPFNOO, [Out] float3 JGLAFHCCNMJ);

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool ANMAKICIKMC(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void PEGKLJBAAJP(CFFDHOCCNNL ILPOHEPFNOO, object DANCOEFIHDF, bool ECALHGIKDNF);

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void MFFDCGBMJCA(CFFDHOCCNNL ILPOHEPFNOO, bool LAOMAECPMML);

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void LCNDEHGFHLH(CFFDHOCCNNL ILPOHEPFNOO);

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool ONNILAPJFMJ(CFFDHOCCNNL ILPOHEPFNOO);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PHEBGDJJIJM
{
	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKNMELBAOKK(Entity HBCHCBBOGCA);

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFEADFPKCAN(Entity HBCHCBBOGCA);

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLHOGDJNAGN(Entity HBCHCBBOGCA);
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HDKKEEJGDGJ
{
	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGALPBEPLMJ(CFFDHOCCNNL ADGCHNLKFKK, bool NEPLEDAPNFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public delegate void INKMLMEFDPM(GLFGNNAFGOD BMGINBKKOEL);
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly ref struct GLFGNNAFGOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly HFAACADMMPC CNIIOHAAHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly NativeArray<byte> NFCHCPFDFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly NativeArray<byte> GAFJKOKCPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly KMJOEPGFAJK ABMJBIODBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly int ENFAAOJJGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly Type IEPCGNNBPDI;

	[Cpp2IlInjected.Token(Token = "0x17000208")]
	public HFAACADMMPC OIPJIFIDBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x4F71670", Offset = "0x4F70270", VA = "0x184F71670")]
		get
		{
			return default(HFAACADMMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000209")]
	public int PIELHOLGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x82D6050", Offset = "0x82D4C50", VA = "0x1882D6050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	public KMJOEPGFAJK NPHIEHLHIGM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xA7B160", Offset = "0xA79D60", VA = "0x180A7B160")]
		get
		{
			return default(KMJOEPGFAJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x82D6070", Offset = "0x82D4C70", VA = "0x1882D6070")]
	public GLFGNNAFGOD(HFAACADMMPC CNIIOHAAHJB, NativeArray<byte> NFCHCPFDFMN, NativeArray<byte> GAFJKOKCPFO, KMJOEPGFAJK ABMJBIODBLM, int ENFAAOJJGCG, Type IEPCGNNBPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C4A000", Offset = "0x3C48C00", VA = "0x183C4A000")]
	public NativeArray<T> LHKBJFOKJPO<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C49ED0", Offset = "0x3C48AD0", VA = "0x183C49ED0")]
	public NativeArray<T> DLJOFFNOJHA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C49F10", Offset = "0x3C48B10", VA = "0x183C49F10")]
	public (HFAACADMMPC, NativeArray<T>, NativeArray<T>) LGFPFICEOKK<T>() where T : struct
	{
		return default((HFAACADMMPC, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x82D6020", Offset = "0x82D4C20", VA = "0x1882D6020")]
	public BNLECOAIEIB NBEINHELING()
	{
		return default(BNLECOAIEIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface DNLKMCLBPBK
{
	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	string GCCOEGEKCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	DNLKMCLBPBK GGJEDOCGEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	IEnumerable<DNLKMCLBPBK> LCFFBHAMLOI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FKCAPKLMKKG
{
	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	DNLKMCLBPBK HJKGGBOAPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	NativeArray<KMJOEPGFAJK> DBMNEILJBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PINJIOEOFIC(KMJOEPGFAJK ABMJBIODBLM, [Out] DNLKMCLBPBK KAPGMCDEGPH);

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AMHLLDBNIFP(KMJOEPGFAJK ABMJBIODBLM, INKMLMEFDPM MEKKKHCELCE);

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADKBIHLFMAC(KMJOEPGFAJK ABMJBIODBLM, INKMLMEFDPM MEKKKHCELCE);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IOICPHKDPDL
{
	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMHLLDBNIFP(KMJOEPGFAJK ABMJBIODBLM, INKMLMEFDPM MEKKKHCELCE);

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADKBIHLFMAC(KMJOEPGFAJK ABMJBIODBLM, INKMLMEFDPM MEKKKHCELCE);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class DPDHMNDKEKN
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BDAMIMFHOJA
{
	[Cpp2IlInjected.Token(Token = "0x17000210")]
	bool KCBEAIDJGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	FAGONABFMGE NKCNAJPCAFI
	{
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NHPMHOJNFLM(MJOIKADLMGF PIIIPDILKIL, bool NLIOAGPJCIE);

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JGIGADDBFGA(BPKOKGNGCMF PIIIPDILKIL, KMJOEPGFAJK ABMJBIODBLM);

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MGPGEOCPODD(NativeArray<BPKOKGNGCMF> JNLHPHPGHHG);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class LHNGBBJMMNG
{
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public readonly ref struct BNLECOAIEIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly GLFGNNAFGOD CBCNBAPLLJM;

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public HFAACADMMPC OIPJIFIDBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x4F71670", Offset = "0x4F70270", VA = "0x184F71670")]
		get
		{
			return default(HFAACADMMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x82D0610", Offset = "0x82CF210", VA = "0x1882D0610")]
	public BNLECOAIEIB(GLFGNNAFGOD CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x82D04E0", Offset = "0x82CF0E0", VA = "0x1882D04E0")]
	public HFAACADMMPC LHKBJFOKJPO()
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x82D00C0", Offset = "0x82CECC0", VA = "0x1882D00C0")]
	public HFAACADMMPC DLJOFFNOJHA()
	{
		return default(HFAACADMMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x82D01F0", Offset = "0x82CEDF0", VA = "0x1882D01F0")]
	public (HFAACADMMPC, HFAACADMMPC, HFAACADMMPC) LGFPFICEOKK()
	{
		return default((HFAACADMMPC, HFAACADMMPC, HFAACADMMPC));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class CODJLIHOIEI
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public readonly struct FAGONABFMGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly NativeBitArray PLPKEFKINHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly NativeParallelHashMap<BPKOKGNGCMF, int> NBDNAENMIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly NativeParallelHashSet<MJOIKADLMGF> PPDJPKFMOHG;

	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public bool NKMDFHHKEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x82D4D80", Offset = "0x82D3980", VA = "0x1882D4D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public bool KCBEAIDJGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x82D4F90", Offset = "0x82D3B90", VA = "0x1882D4F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x600AF10", Offset = "0x6009B10", VA = "0x18600AF10")]
	public FAGONABFMGE(NativeBitArray PLPKEFKINHF, NativeParallelHashMap<BPKOKGNGCMF, int> NBDNAENMIIF, NativeParallelHashSet<MJOIKADLMGF> PPDJPKFMOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x82D4DA0", Offset = "0x82D39A0", VA = "0x1882D4DA0")]
	public bool JGIGADDBFGA(BPKOKGNGCMF PIIIPDILKIL, KMJOEPGFAJK ABMJBIODBLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GEPCMKHFHDK
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	HEODKAOIMMP IONMHLHENEN
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
public interface KHJEKAIJGGO
{
	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJAKGMLCAIJ(CFFDHOCCNNL ILPOHEPFNOO, ODGPDIMIKDO BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ILKDGFHCBCG FICFLPMLKNI();
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LEBDAJPFOGA
{
	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOGPOOIPELK(World FPCAGECIADG);

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAFCHILNNLE(World FPCAGECIADG);

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase AIBJOMJBCEN(World FPCAGECIADG);

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCOIMDDGLID(World FPCAGECIADG);

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FFGBOHAKOGL(World FPCAGECIADG);

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JOFCFICGGKB(World FPCAGECIADG);

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NNNFMODJIGJ(World FPCAGECIADG);

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> IDNFILGGEOH();
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NEHCHGFCBMB
{
	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKGIODNAANN(CFFDHOCCNNL LNPPHFKBHPJ, bool BKMPCFIAHIG);
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public readonly struct MHGKBJBCMAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly IEnumerable<HODBMCDIFKI> BJKHAGFNLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly IReadOnlyList<GameObject> HDEJCGNBNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly IReadOnlyList<int> DECKBAIDIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly IReadOnlyList<(BPKOKGNGCMF, BPKOKGNGCMF)> DMEOAPEPCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly int GKLNEKNMMEA;
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public struct DAGPGNJLAIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public InventionIdData OIBGADINDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public InventionInstanceIdData JLIPGILNIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public bool NPLCKCIOEAA;

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x82D22A0", Offset = "0x82D0EA0", VA = "0x1882D22A0")]
	public DAGPGNJLAIF(long OIBGADINDDP, Guid JLIPGILNIHH, bool NPLCKCIOEAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[ServiceLifetime(Lifetime.Application)]
public interface OJDCMNHFLLI
{
	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DMBCIAMLBOC DMFJKGBGFAA(KFMAIGOOEPB NGFHOPNCFAM, int NIHHGEAIOGB = 0, bool OHEHONOLFIL = false);

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MCHDAGFDBNJ CGMIOPFOMPK(KFMAIGOOEPB NGFHOPNCFAM, CFFDHOCCNNL IEPNOLIPIDE, [In] UniformTRS KKJJKPGEDIK, ANMDHDJDGMH FFHLMKMHNLJ, [Optional] DAGPGNJLAIF EAGEFALKPFB, bool ANJOKHCGCML = true, bool DBFBIEELJDL = false, bool OHEHONOLFIL = false, bool CGJDEJNEBLJ = false);

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DMJHPCGCBJL BBDPHCMPGIN();

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DMJHPCGCBJL KGHBDLJIBIH(HFAACADMMPC KNEMEBLIDKG, [In] UniformTRS IAKKDMPHEFE, [Optional] ANMDHDJDGMH HGIOEFMAJOO);

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CDNALPJICKL(CFFDHOCCNNL FCNAALGKMDB);

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NEPACPBEHND(CFFDHOCCNNL FCNAALGKMDB, [Out] Exception BIBIMCAHIHC);

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<BPKOKGNGCMF> IHFHDEDINPD(CFFDHOCCNNL FCNAALGKMDB, Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<BPKOKGNGCMF> JAAECOIHBOC(CFFDHOCCNNL FCNAALGKMDB, Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HFAACADMMPC AEDJGAPFGEB(CFFDHOCCNNL FCNAALGKMDB, Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HFAACADMMPC LKFNBMOKACG(CFFDHOCCNNL FCNAALGKMDB, Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HFAACADMMPC HJBKNHEHAFP(CFFDHOCCNNL FCNAALGKMDB, Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> BCGNECEDJDH(CFFDHOCCNNL FCNAALGKMDB, Allocator HPEAGMDCCBL);

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DFAGBDKEJNM(CFFDHOCCNNL FCNAALGKMDB);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int CBHDGMDHEFL(CFFDHOCCNNL FCNAALGKMDB, int NKGPOLKDIPE);
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[ServiceLifetime(Lifetime.Application)]
public interface MLKPGPIKNLN
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0xF1AEE0", Offset = "0xF19AE0", VA = "0x180F1AEE0", Slot = "0")]
	bool NEKBDFCIJDE(object CKGMOBNFAKG, OIIDHFILPMC FJKFKHLJPJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public static class EAEGJOLLBLJ
{
	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x82D4930", Offset = "0x82D3530", VA = "0x1882D4930")]
	public static bool NEKBDFCIJDE(this MLKPGPIKNLN AKIJMANCHPA, object CKGMOBNFAKG, [Out] OIIDHFILPMC FJKFKHLJPJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public enum KEJKIBLNEOJ : byte
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
public interface OIIDHFILPMC
{
	[Cpp2IlInjected.Token(Token = "0x17000216")]
	FINICCDBPBH GJCIAOMMHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	MKFFFMAICOP FNDAFDMPHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	bool MLNJDIKECMM
	{
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	bool FDKEACLDBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object IICOCMPAFIF();

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x105C4F0", Offset = "0x105B0F0", VA = "0x18105C4F0", Slot = "5")]
	(MKFFFMAICOP, Dictionary<object, object>) BLKAIAJAGMF()
	{
		return default((MKFFFMAICOP, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "6")]
	(BPKOKGNGCMF, MKFFFMAICOP) CBBNIHJMGHE()
	{
		return default((BPKOKGNGCMF, MKFFFMAICOP));
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "7")]
	IEHJOAHBOCP<(BPKOKGNGCMF, MKFFFMAICOP)> OOMAMCDGAHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x105C4F0", Offset = "0x105B0F0", VA = "0x18105C4F0", Slot = "8")]
	(MBKGIBNAPNI, byte[]) DEPCABPCCJF()
	{
		return default((MBKGIBNAPNI, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x105C4F0", Offset = "0x105B0F0", VA = "0x18105C4F0", Slot = "9")]
	(DDHBOPBHNJP, byte[]) CPMPBDNDFPI()
	{
		return default((DDHBOPBHNJP, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x105C4F0", Offset = "0x105B0F0", VA = "0x18105C4F0", Slot = "10")]
	T AAJBIGJDHOE<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public static class GIBBKPOMBFF
{
	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x82D5C90", Offset = "0x82D4890", VA = "0x1882D5C90")]
	public static bool JMNCLMFEPNC(this OIIDHFILPMC PJIJGMLMHGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface MPKKCIOPLLD : IEHJOAHBOCP<IHJNLMEPEBP>
{
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[DefaultMember("Item")]
public interface IEHJOAHBOCP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	T KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	int PIELHOLGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public enum FINICCDBPBH : byte
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
public enum MBKGIBNAPNI : uint
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
public static class HMEJNBPNFMG
{
	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x82D7770", Offset = "0x82D6370", VA = "0x1882D7770")]
	public static BPKOKGNGCMF ALKKBJEGLHD(this JICELGNMKJB CBCNBAPLLJM)
	{
		return default(BPKOKGNGCMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x82D77B0", Offset = "0x82D63B0", VA = "0x1882D77B0")]
	public static BPKOKGNGCMF EBFFFAGELCA([In] this JICELGNMKJB CBCNBAPLLJM)
	{
		return default(BPKOKGNGCMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x82538E0", Offset = "0x82524E0", VA = "0x1882538E0")]
	public static BPKOKGNGCMF EDCOHIBENIO(this JICELGNMKJB CBCNBAPLLJM)
	{
		return default(BPKOKGNGCMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x82538E0", Offset = "0x82524E0", VA = "0x1882538E0")]
	public static ViewId CJPKIOJEEIJ(this JICELGNMKJB CBCNBAPLLJM)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x82D7A90", Offset = "0x82D6690", VA = "0x1882D7A90")]
	public static FixedString64Bytes OAMGDCIBJKM(this MJOIKADLMGF OIBGADINDDP)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x82D7800", Offset = "0x82D6400", VA = "0x1882D7800")]
	public static FixedString64Bytes LEKAFJHOLCP(this BPKOKGNGCMF OIBGADINDDP)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x82D7C60", Offset = "0x82D6860", VA = "0x1882D7C60")]
	public static FixedString32Bytes OAMGDCIBJKM(this Entity CGLPEGHHGMM)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FBAAEGFMMJC : DLBHCBOPGBF
{
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public enum FAENFGNIJDM
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
public interface APNHGEHCHIA
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<object> KJCDONEAFBF;

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "2")]
	void HMFCEAMOHAI(object CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "3")]
	void HMKIJKNIKLG(DDHBOPBHNJP NDMEBHICHPO, ReadOnlySpan<byte> HGBKIACHBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	void GAOFLAOCJJB(MBKGIBNAPNI MDCDODCGNEK, ReadOnlySpan<byte> HGBKIACHBFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HHEPMHHAJAB
{
	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DDHBOPBHNJP EEJHPODFNDF(ReadOnlySpan<byte> HGBKIACHBFM);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KLDCBAEIPDO
{
	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGMKJCKGMKH(DDHBOPBHNJP DHCHBFGMFFD, ReadOnlySpan<byte> HGBKIACHBFM);

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECONNBFGDKM(ReadOnlySpan<DDHBOPBHNJP> HDPBAKHMHKN);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct NFELIPJPHBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public DDHBOPBHNJP NDMEBHICHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public ReadOnlyMemory<byte> HGBKIACHBFM;
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct DDHBOPBHNJP
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static DDHBOPBHNJP PIGIFDLDEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public MJOIKADLMGF BKDDIFICJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public int LAJABCEKGBK;

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public static MJOIKADLMGF GDJOMIKAHDK
	{
		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x82D2B90", Offset = "0x82D1790", VA = "0x1882D2B90")]
		get
		{
			return default(MJOIKADLMGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x5449470", Offset = "0x5448070", VA = "0x185449470")]
	public DDHBOPBHNJP(MJOIKADLMGF BKDDIFICJED, int LAJABCEKGBK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x82D2990", Offset = "0x82D1590", VA = "0x1882D2990")]
	public static bool CDGFDPOPEPC([In] DDHBOPBHNJP OHEOONFKODG, [In] DDHBOPBHNJP GOPANKCDGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x82D2A20", Offset = "0x82D1620", VA = "0x1882D2A20", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x82D2B30", Offset = "0x82D1730", VA = "0x1882D2B30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x82D2BE0", Offset = "0x82D17E0", VA = "0x1882D2BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x82D2980", Offset = "0x82D1580", VA = "0x1882D2980")]
	public void AEDAIPFNKDM([Out] MJOIKADLMGF DNMDEMHKFBL, [Out] int LAJABCEKGBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public static class MGPMBEPHNJK
{
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public struct HODBMCDIFKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Guid FHNOHJCOOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public string HNHFKFKDOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Vector3 FEMJLOIOGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public Quaternion DINDLKHALMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Vector3 ECJMFFOLCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public int BIENBCMKCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public MJAPGGNPMGD KCHMACEBLIA;

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x82D7F20", Offset = "0x82D6B20", VA = "0x1882D7F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public enum KJILDPGOINI
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
public static class HILMKBKMABP
{
	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x82D6F80", Offset = "0x82D5B80", VA = "0x1882D6F80")]
	public static bool LMJBJHNIGIH(this KJILDPGOINI MDCDODCGNEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x82D6FA0", Offset = "0x82D5BA0", VA = "0x1882D6FA0")]
	public static bool OCJBBMFBDNC(this KJILDPGOINI MDCDODCGNEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x82D6F70", Offset = "0x82D5B70", VA = "0x1882D6F70")]
	public static bool FLIMKFOPKEP(this KJILDPGOINI MDCDODCGNEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
[Flags]
public enum NEMGDEFJJMF
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
public interface ANMDHDJDGMH
{
	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KCMOJHGCLLO([In] Guid OJNBCCCOMPJ, [Out] Guid IOKMBOFHINB);
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[Flags]
public enum NMGEOMKKDMB
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
public interface DMJHPCGCBJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	GKBAKNMACAD ENKCGBFJEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString ICPGHEPBJOB();
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public enum OGJDCHCKACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct IPJDJLMIEIB : ISystemStateComponentData, IComponentData, IEquatable<IPJDJLMIEIB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public float3 DDFJOOKJOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public float3 JFOEHIMJFCH;

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x82DB070", Offset = "0x82D9C70", VA = "0x1882DB070", Slot = "4")]
	public bool Equals(IPJDJLMIEIB IIOGPDPGOLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MCFDCEMMENA
{
	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<CFFDHOCCNNL> CHPDKAAFKJB(CFFDHOCCNNL EIEILELNLLN);

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BDCGIIGMNCA(CFFDHOCCNNL AOLHBAFBDBA, [Out] CFFDHOCCNNL JCEBLLEKIKM);
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HGPLLENHCEN
{
	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDKGFJBOFON(long JOAHMDCKGCK);

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNJJDNEGLKB(NativeParallelHashSet<long> LEKFECIBDFN);

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAHDOIKCLFG(World FPCAGECIADG, NativeParallelHashMap<Guid, long> LHAPOLGDPIF);

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OJGNBEHMMKG(BPKOKGNGCMF PIIIPDILKIL);

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BPHNJKGDGEC(BPKOKGNGCMF PIIIPDILKIL, [Out] Guid IDOMJEIEBLH, [Out] long JOAHMDCKGCK);

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DCBLCAKJHCB(BPKOKGNGCMF PIIIPDILKIL, Guid IDOMJEIEBLH, long JOAHMDCKGCK);

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LGEBOIGAHKE(Guid IDOMJEIEBLH);

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HNOPNNKGBAP(Guid IDOMJEIEBLH, [Out] int NCHBFJOFLGO, [Out] int LJPNHIDKLEI);

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PJMOFEBMBEB(Guid IDOMJEIEBLH, int NCHBFJOFLGO, int LJPNHIDKLEI);

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MIBGPHIPPNP(Guid IDOMJEIEBLH);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class MBCOCJPKMMG
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MBCOCJPKMMG()
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
