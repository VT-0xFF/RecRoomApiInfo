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
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F722F0", Offset = "0x7F710F0", VA = "0x187F722F0", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JMKOLFEHHDH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EC70", Offset = "0x7F6DA70", VA = "0x187F6EC70")]
	public static void BPFMMHLOGEF(this Rigidbody NHFMMANDNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EB40", Offset = "0x7F6D940", VA = "0x187F6EB40")]
	public static void BPFMMHLOGEF(this Rigidbody NHFMMANDNBA, Vector3 FKHAIDGOBLC, Quaternion BLDKPPGJBJN, Vector3 HADBIFLIHHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct LHGPEBNJFMN : IReadOnlyList<JBBGAMGOICI>, IEnumerable<JBBGAMGOICI>, IEnumerable, IReadOnlyCollection<JBBGAMGOICI>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct ICMECJBJJII : IEnumerator<JBBGAMGOICI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly FNPHLLFAMCL BNLNGOBLDJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator BMMKBOAHBPI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public JBBGAMGOICI CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D630", Offset = "0x7F6C430", VA = "0x187F6D630", Slot = "4")]
			get
			{
				return default(JBBGAMGOICI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D5E0", Offset = "0x7F6C3E0", VA = "0x187F6D5E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x513FAC0", Offset = "0x513E8C0", VA = "0x18513FAC0")]
		public ICMECJBJJII(FNPHLLFAMCL BNLNGOBLDJO, NativeArray<LocalId>.Enumerator BMMKBOAHBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D520", Offset = "0x7F6C320", VA = "0x187F6D520", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D560", Offset = "0x7F6C360", VA = "0x187F6D560", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D5A0", Offset = "0x7F6C3A0", VA = "0x187F6D5A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AFKBECNHLIC BHHPJCAPOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> DGLKBCCIOFF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JBBGAMGOICI ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F70B30", Offset = "0x7F6F930", VA = "0x187F70B30", Slot = "4")]
		get
		{
			return default(JBBGAMGOICI);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F70290", Offset = "0x7F6F090", VA = "0x187F70290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int KMHAKIKFEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FNPHLLFAMCL ALKLOCLCPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F70240", Offset = "0x7F6F040", VA = "0x187F70240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool AMBHJOJJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F70200", Offset = "0x7F6F000", VA = "0x187F70200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> LNCNEHDKLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x29D9D60", Offset = "0x29D8B60", VA = "0x1829D9D60")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> BPOCBCIELEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F701A0", Offset = "0x7F6EFA0", VA = "0x187F701A0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F70850", Offset = "0x7F6F650", VA = "0x187F70850")]
	public LHGPEBNJFMN(int KIOMCEJDGPM, FNPHLLFAMCL BNLNGOBLDJO, Allocator LNMGNHHGHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F70A90", Offset = "0x7F6F890", VA = "0x187F70A90")]
	public LHGPEBNJFMN(AFKBECNHLIC BHHPJCAPOMD, NativeArray<LocalId> DGLKBCCIOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F70900", Offset = "0x7F6F700", VA = "0x187F70900")]
	public LHGPEBNJFMN(AFKBECNHLIC BHHPJCAPOMD, NativeArray<Entity> DGLKBCCIOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F70AA0", Offset = "0x7F6F8A0", VA = "0x187F70AA0")]
	internal LHGPEBNJFMN(FNPHLLFAMCL BNLNGOBLDJO, NativeArray<Entity> KKDBICIHPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F70A20", Offset = "0x7F6F820", VA = "0x187F70A20")]
	internal LHGPEBNJFMN(FNPHLLFAMCL BNLNGOBLDJO, NativeArray<LocalId> DGLKBCCIOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F707A0", Offset = "0x7F6F5A0", VA = "0x187F707A0")]
	public LHGPEBNJFMN(FNPHLLFAMCL BNLNGOBLDJO, int NPCJGIOCILE, Allocator LNMGNHHGHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F70970", Offset = "0x7F6F770", VA = "0x187F70970")]
	public LHGPEBNJFMN(LHGPEBNJFMN BECHMNEMMBG, Allocator LNMGNHHGHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F702F0", Offset = "0x7F6F0F0", VA = "0x187F702F0")]
	public void JCJPJJOOLPO(List<JBBGAMGOICI> COKPAJOONAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F70110", Offset = "0x7F6EF10", VA = "0x187F70110")]
	public void DNCJPBEGKCI(int GLAOLHCPLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F70560", Offset = "0x7F6F360", VA = "0x187F70560")]
	public LHGPEBNJFMN LAGKNEOGNDP(Allocator LNMGNHHGHLL)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FF20", Offset = "0x7F6ED20", VA = "0x187F6FF20")]
	public Span<JBBGAMGOICI> ABOMOKOCFPK()
	{
		return default(Span<JBBGAMGOICI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F70070", Offset = "0x7F6EE70", VA = "0x187F70070")]
	public LHGPEBNJFMN CCIOHIJMBNF(int GNMMLFONKNO, int NPCJGIOCILE)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F70160", Offset = "0x7F6EF60", VA = "0x187F70160", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F70600", Offset = "0x7F6F400", VA = "0x187F70600")]
	public ICMECJBJJII PHEMDOOJNPF()
	{
		return default(ICMECJBJJII);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F706C0", Offset = "0x7F6F4C0", VA = "0x187F706C0", Slot = "6")]
	private IEnumerator<JBBGAMGOICI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F70730", Offset = "0x7F6F530", VA = "0x187F70730", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DEHMNGNPIPH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37546C0", Offset = "0x37534C0", VA = "0x1837546C0")]
	public static CONCPCFABOF<T> AIAAOGLOANK<T>(this LHGPEBNJFMN KHJEADFMOJM) where T : Component
	{
		return default(CONCPCFABOF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct LOBGEMGFCOO : IList<JBBGAMGOICI>, ICollection<JBBGAMGOICI>, IEnumerable<JBBGAMGOICI>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct ONLCMCDCIPI : IEnumerator<JBBGAMGOICI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly FNPHLLFAMCL BNLNGOBLDJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator BMMKBOAHBPI;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JBBGAMGOICI CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7F73C10", Offset = "0x7F72A10", VA = "0x187F73C10", Slot = "4")]
			get
			{
				return default(JBBGAMGOICI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7F73BC0", Offset = "0x7F729C0", VA = "0x187F73BC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x513FAC0", Offset = "0x513E8C0", VA = "0x18513FAC0")]
		public ONLCMCDCIPI(FNPHLLFAMCL BNLNGOBLDJO, NativeArray<LocalId>.Enumerator BMMKBOAHBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F73B00", Offset = "0x7F72900", VA = "0x187F73B00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F73B40", Offset = "0x7F72940", VA = "0x187F73B40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7F73B80", Offset = "0x7F72980", VA = "0x187F73B80", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FNPHLLFAMCL BNLNGOBLDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> DGLKBCCIOFF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JBBGAMGOICI ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F71620", Offset = "0x7F70420", VA = "0x187F71620", Slot = "4")]
		get
		{
			return default(JBBGAMGOICI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F71710", Offset = "0x7F70510", VA = "0x187F71710", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7F70C30", Offset = "0x7F6FA30", VA = "0x187F70C30", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F70C30", Offset = "0x7F6FA30", VA = "0x187F70C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> LNCNEHDKLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x29D9D60", Offset = "0x29D8B60", VA = "0x1829D9D60")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LHOLHNBADAD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F71510", Offset = "0x7F70310", VA = "0x187F71510")]
	public LOBGEMGFCOO(FNPHLLFAMCL BNLNGOBLDJO, Allocator LNMGNHHGHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F71590", Offset = "0x7F70390", VA = "0x187F71590")]
	public LOBGEMGFCOO(FNPHLLFAMCL BNLNGOBLDJO, int NPCJGIOCILE, Allocator LNMGNHHGHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F71090", Offset = "0x7F6FE90", VA = "0x187F71090")]
	public LHGPEBNJFMN OJAECEJJEAJ()
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F70C70", Offset = "0x7F6FA70", VA = "0x187F70C70", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F70CB0", Offset = "0x7F6FAB0", VA = "0x187F70CB0", Slot = "13")]
	public bool Contains(JBBGAMGOICI HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F70D40", Offset = "0x7F6FB40", VA = "0x187F70D40", Slot = "14")]
	public void CopyTo(JBBGAMGOICI[] KNDCNOIHMGO, int PIJHOBEHDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F70BB0", Offset = "0x7F6F9B0", VA = "0x187F70BB0", Slot = "11")]
	public void Add(JBBGAMGOICI HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F70FE0", Offset = "0x7F6FDE0", VA = "0x187F70FE0", Slot = "7")]
	public void Insert(int GLAOLHCPLLG, JBBGAMGOICI HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F71280", Offset = "0x7F70080", VA = "0x187F71280", Slot = "15")]
	public bool Remove(JBBGAMGOICI HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F70F50", Offset = "0x7F6FD50", VA = "0x187F70F50", Slot = "6")]
	public int IndexOf(JBBGAMGOICI HHHFHHLBBIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F71230", Offset = "0x7F70030", VA = "0x187F71230", Slot = "8")]
	public void RemoveAt(int GLAOLHCPLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F70F10", Offset = "0x7F6FD10", VA = "0x187F70F10", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F711A0", Offset = "0x7F6FFA0", VA = "0x187F711A0")]
	public ONLCMCDCIPI PHEMDOOJNPF()
	{
		return default(ONLCMCDCIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F71350", Offset = "0x7F70150", VA = "0x187F71350", Slot = "16")]
	private IEnumerator<JBBGAMGOICI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7F71430", Offset = "0x7F70230", VA = "0x187F71430", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DENHOBJJLFN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JBBGAMGOICI MANBEHHHOPM(JBBGAMGOICI DGLKBCCIOFF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HLOKICDHONM : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface ELJKHBJNFGO : LKGMBBELLLK, MMLPDOJJIBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	BOGNLGINFDP MANNMPDIOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	AFKBECNHLIC LOANCINFKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface MMLPDOJJIBI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CJJDLPNFICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface NNHJANKIDPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELHDILIADKM(bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCLJDABAPHP();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface NHGGPFOMEJD
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HHONGLBHPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool JEKBNGPNJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool EBPKCPDKNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DGLPMBGAABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AJDJDJHJNJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OCKPNFMCPHK(bool MAFNDJNJAOJ);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ALEMEBNCOLM(ByteString OIMGKDCCDGB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KEIEJNMMJJJ();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NECDPOCLDHC();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OFMAHKHNPLG();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface JHHFKKLJKBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	LFBEMDOHFPC MANNMPDIOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PMPAFCIFDHO JKEDAJOCAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	FCAAHOBIHDB BEEMDACOKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	ELJKHBJNFGO CLOFKPECAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	CKLMNDIMBCA IBCLFHGFJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	NHGGPFOMEJD DIHAFJEMHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	JCIKEDDHEJM DCNLFMKNGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ABFMHAOJLEC LJAECIIPJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	OOEFJPHJGKF GPHJLKGDOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HKNJHJGCLNN DHHINDFAFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	BFIDPBDMGHC NFCMFBMHODB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	JHBMGIINGEG LAFEINHLJMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	FNPHLLFAMCL ALKLOCLCPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	NBLKJAIFLOK EDPDPBJMKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	BHPMOPIBKNJ KLBNDDAEOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	DKDGIOABHOE CNCDICJGMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	LHAHJDFHEAG NOMIBAKIPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CDJJBMHAFBN KOEFDOPADMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	HIHFOBNJGGG GLPKHKNJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	CIFJNIMAPGE GJHIGOLIJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	EGNNCJLCDLA MAKFAEIGMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JGNJPENDGFP NJOOJPLGDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	JEBBIMDPKFK PLMBEJNOGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	DKOEOMOIFKP NBJMMEJAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	HCFDIAMEJEH DINBCBGBAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	AJBBBDFMJKH ACEEGFCDHDK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NLIDPNLLMOE GHFGFMOGLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	HCALMMNKPKA DFOIIHCIFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	DCBDDKPMBOC INLKELJGPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	NGHGHNKGFEC AAEPGGHANKB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	DKMLBBCEDBN CDFAPGCACBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KEIHHBEOEPM ODALAFALJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NIBPOPLEHKN BEGJEAAHCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	PNAPNCMOKDC DAMPIELFGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	ACCMOKPPGII EBFHOJOCDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(OIIFOMPPKPC))]
public readonly struct JBBGAMGOICI : IComparable<JBBGAMGOICI>, IEquatable<JBBGAMGOICI>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly JBBGAMGOICI IPPDMFADBOE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int IJIFBODEJFO = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int CINPAFIGOBJ = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int KMAGBLKGDJK = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int AGGPOMIBLJF = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId CBBNAACPEGP;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public FNPHLLFAMCL ALKLOCLCPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F684F0", Offset = "0x7F672F0", VA = "0x187F684F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ELJKHBJNFGO CLOFKPECAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E480", Offset = "0x7F6D280", VA = "0x187F6E480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LocalId CNFFIBCAOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E560", Offset = "0x7F6D360", VA = "0x187F6E560")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal AFKBECNHLIC LOANCINFKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E6C0", Offset = "0x7F6D4C0", VA = "0x187F6E6C0")]
		get
		{
			return default(AFKBECNHLIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool APHGFBFFFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E180", Offset = "0x7F6CF80", VA = "0x187F6E180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private bool JELJCGPIDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E430", Offset = "0x7F6D230", VA = "0x187F6E430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E800", Offset = "0x7F6D600", VA = "0x187F6E800")]
	public JBBGAMGOICI(FNPHLLFAMCL FHNEMAGHCGF, LocalId CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E8C0", Offset = "0x7F6D6C0", VA = "0x187F6E8C0")]
	public JBBGAMGOICI(AFKBECNHLIC BHHPJCAPOMD, LocalId CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
	public GALEOJBODPG MPOJCHNLJJG()
	{
		return default(GALEOJBODPG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E4E0", Offset = "0x7F6D2E0", VA = "0x187F6E4E0")]
	public static LocalId HEKJAOMNHLJ(JBBGAMGOICI CPEKFLDAEBC)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E520", Offset = "0x7F6D320", VA = "0x187F6E520")]
	public static Entity HEKJAOMNHLJ(JBBGAMGOICI CPEKFLDAEBC)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E5A0", Offset = "0x7F6D3A0", VA = "0x187F6E5A0")]
	public static bool PBEBFPKJKLO(JBBGAMGOICI CHIPBNNCPBF, JBBGAMGOICI MDEAIGKHMKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F664B0", Offset = "0x7F652B0", VA = "0x187F664B0")]
	public static bool INFPGDPCEAI(JBBGAMGOICI CHIPBNNCPBF, JBBGAMGOICI MDEAIGKHMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E6D0", Offset = "0x7F6D4D0", VA = "0x187F6E6D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E2A0", Offset = "0x7F6D0A0", VA = "0x187F6E2A0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E090", Offset = "0x7F6CE90", VA = "0x187F6E090", Slot = "4")]
	public int CompareTo(JBBGAMGOICI HBLONCAMFLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "5")]
	public bool Equals(JBBGAMGOICI HBLONCAMFLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EOPMNKDDCDH
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F697A0", Offset = "0x7F685A0", VA = "0x187F697A0")]
	public static LAFPBLKJNNP KMNAKCGEKLE(this JBBGAMGOICI GLEBGNJJOHG)
	{
		return default(LAFPBLKJNNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class OIIFOMPPKPC
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct AFKBECNHLIC : IEquatable<AFKBECNHLIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte BHHPJCAPOMD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] FPNAGIBIHJN;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static FNPHLLFAMCL OLALEAFNAHE;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static ELJKHBJNFGO AMKCFPFLHOD;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static FNPHLLFAMCL[] MPCJLIFNHMA;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static ELJKHBJNFGO[] KMCPFOCLMOJ;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> ANMGGDEHHFM;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public ELJKHBJNFGO CLOFKPECAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7F60E60", Offset = "0x7F5FC60", VA = "0x187F60E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public FNPHLLFAMCL HJNMIBEIGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7F609F0", Offset = "0x7F5F7F0", VA = "0x187F609F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7F61650", Offset = "0x7F60450", VA = "0x187F61650")]
	static AFKBECNHLIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2A25C90", Offset = "0x2A24A90", VA = "0x182A25C90")]
	internal AFKBECNHLIC(byte OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6E2ACA0", Offset = "0x6E29AA0", VA = "0x186E2ACA0", Slot = "4")]
	public bool Equals(AFKBECNHLIC HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7F60950", Offset = "0x7F5F750", VA = "0x187F60950", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xF776F0", Offset = "0xF764F0", VA = "0x180F776F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F61590", Offset = "0x7F60390", VA = "0x187F61590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7F614E0", Offset = "0x7F602E0", VA = "0x187F614E0")]
	private static FNPHLLFAMCL OOOODNOKJLD(byte BHHPJCAPOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F61220", Offset = "0x7F60020", VA = "0x187F61220")]
	private static ELJKHBJNFGO NGILJCDMNLM(byte BHHPJCAPOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7F607D0", Offset = "0x7F5F5D0", VA = "0x187F607D0")]
	private static object CJNKKBKICNH(byte BHHPJCAPOMD, object[] BGBLHEHBHCD, object LDGCNLHOBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7F61210", Offset = "0x7F60010", VA = "0x187F61210")]
	private static int NECMNEDEFBO(byte BHHPJCAPOMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7F60940", Offset = "0x7F5F740", VA = "0x187F60940")]
	private static int DMIBNEEMCLH(byte BHHPJCAPOMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F60750", Offset = "0x7F5F550", VA = "0x187F60750")]
	private static (int, int) AIANGHCOJDM(byte BHHPJCAPOMD)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F60F40", Offset = "0x7F5FD40", VA = "0x187F60F40")]
	private static byte HHNCPLJBMKI(int MFIBIFPFGCD, int GLAOLHCPLLG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F60F50", Offset = "0x7F5FD50", VA = "0x187F60F50")]
	internal static AFKBECNHLIC KEMEJJLNDFN(ELJKHBJNFGO FDFIJELGGAL, FNPHLLFAMCL CGBFOHCHDBD)
	{
		return default(AFKBECNHLIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F612D0", Offset = "0x7F600D0", VA = "0x187F612D0")]
	internal static void NGPIMBAFGHP(AFKBECNHLIC BHHPJCAPOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F60AD0", Offset = "0x7F5F8D0", VA = "0x187F60AD0")]
	private static void FOGJEPMKNIA(int KIOMCEJDGPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum OOGOJLIMCCH
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
public interface LKOIBJGMNPL
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool ENKFNPDDBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool FJPBNNBNNDI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool LHHLNHOCHFO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool GBDGGEHBBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool KIEPMNIHODA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KNBKAEDOCAN
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBMMAHLFCIH(KKBIKMPDAHB AHGNCOFKLHK, int GLAOLHCPLLG);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FBDDCPJLKFJ(KKBIKMPDAHB NHPLFMPFGHM, int GLAOLHCPLLG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KOEHPMOKBGC : KKBIKMPDAHB, LKOIBJGMNPL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int JODPKGNHIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEJPAAFOAGD(NIOOFAIBNMF HMDNNMIJNJJ, int GLAOLHCPLLG);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KKBIKMPDAHB : LKOIBJGMNPL
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum ALHLACHPJKI
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

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool MABPMGLMNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool OFDNOLJPKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool HHHPMBCNIND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NIOOFAIBNMF
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool EHKLGPONNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	AEHNMCPGHOA OBFNPMKPAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	ENDAGELFFEM LGHDBBMOODH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float3 HKMBNCFKKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	quaternion PHNPMAOBIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float3 JFDFJOEOLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	AKNHCNJGENP HCJHJANFJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	JOOCMDBDCKI KEMFIGNEAMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float DCFNGINFAKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float3 BBGPGAAGFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float KLFPMBHEJMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	PGGJHKNGOPJ FGMBINPLOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PMABKEMJNHN
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 EGIJBOFOPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float3 FMIOEEJGLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion FFPNPOCHPLG(float3 HDJPDJPKNAK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface ENDAGELFFEM
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool IMDCLHNOKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool LCBEGGAOLML
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool JBNHOGIHMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float BIGFHKNOFML
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	int MNLNKGDCNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int EGLPIHOENCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OKAHAAEBLCM(PMABKEMJNHN HMDNNMIJNJJ, int GLAOLHCPLLG);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface LKGCNHILCIO
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Guid AGHDDBIKDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EFFDOBFBAPC(Guid GBMPLCJAMFH, Guid HLGNHFCFAMG, Guid NJPMFOLEJPE);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task HCKFOEJAIMJ(Guid GBMPLCJAMFH, Guid[] MMKAKKPJHEB, Guid NJPMFOLEJPE);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PCKCBNADIGE(Guid AEHJOFBOANC);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NJDBGOOMADA(JBBGAMGOICI GLDBNOJLHPP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MFCBJIDPILC(Guid AEHJOFBOANC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JJAMHMABCDJ(JGNPLCMILBE BICIMHJBPJE, Guid LMIEDDEKKOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OLDILOPDMIK(Guid AEHJOFBOANC, bool MAFNDJNJAOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AENDDJOCDIJ(Guid AEHJOFBOANC, LAFPBLKJNNP LKAPFIIDHFA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LIOKKBCIONA(LAFPBLKJNNP LKAPFIIDHFA);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ODJHPAIGGCO(JBBGAMGOICI CBBNAACPEGP);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface AIKNHHAADNB
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface EMMEDDPJJOK
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GCKHMBOBFJN(GameObject PPAIPEPFMHO, GameObject BNLNHAOGNHE, int FNKJBHGFEHM);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface BJFNFKFFKOI
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "0")]
	void AKLGLKEBDOI(bool HMKCBLNCLGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface PMPAFCIFDHO
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	BJFNFKFFKOI IGJHFANHGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	ONNPPAIDDFM IAPMJKHNOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	DPGGOAKHDGI JNOIHODKNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	CDCKPMDEDOJ LMPEILIOJCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	GADBIHCFMHL FKJDGICJJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	ACGIMABFNFD NNJHKDJPHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	MPLGMHFJJMG KPMCMKJIGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	KFKAPJOLOCN KLPHFPIHBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface ONNPPAIDDFM
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	string IAFMFHPKPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface CGGKIMMPENH
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHNLMCMJHIF(Action CFDGGKIIHOI, bool BJEODFEPDCP);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NOPEFJPLGDK(string IHGFMOMOADA);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int NOJNFBAMCMB(string IHGFMOMOADA, int LDGCNLHOBMI);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IBKEDJALBNE([Out] bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DICMHONMPFC([Out] bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HCLHPLGCDDL([Out] int OAIIHELJHLG);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface DPGGOAKHDGI
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "0")]
	void CDLBNFIBGCC(bool MAFNDJNJAOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface CDCKPMDEDOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid MDENEMPGNCM;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid LPINCOOBDMI;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid LDKGPGBLOKB;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid NKJBMNLANIJ;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool NJLPPGLDCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool MMDJBMCMMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool GAECMFHBAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F63480", Offset = "0x7F62280", VA = "0x187F63480", Slot = "3")]
	string[] DFOHIIPNCLO(DMDGHBDFKMP KPEIBOOMGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCNOKNLMCCG();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F63450", Offset = "0x7F62250", VA = "0x187F63450", Slot = "5")]
	Guid DFLGHABHLBH(Guid ADMOKOELINH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HEBNDMOAEBI(DMDGHBDFKMP KPEIBOOMGAE);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OLAILNNOCKO(DMDGHBDFKMP KPEIBOOMGAE, NativeArray<EBPOOJIJECL> GFGCAJMGAFD, NativeList<UniformTRS> EJIHFCLKAMN);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int ELAAKKIJOLB(Guid PDFBNFKDLAH);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BABGAMPBCOF(string PGMKJGMLBKD, [Out] Guid PDFBNFKDLAH);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string OFEPGDANCFL(Guid PDFBNFKDLAH);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FHIGJENBCKO(RRObjectPrefabData IGBGALJMPHH, [Out] LocalId OFJKELIPJNP);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CONCPCFABOF<byte[]> PJNMPMAJNPO(NativeArray<EBPOOJIJECL> MBDNFPEOCFE);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ODEOBGKAONO(byte[] FGGOMEKNFPG);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GameObject KAJKEPKAKHM(string PGMKJGMLBKD);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BMPBKNNCFPH(Transform MAAFBDAKBJA, RRObjectPrefabData BPDBBEAMIIJ, GHEBJLJHKJI JAPGNGDBBIF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool JKKBDOLFGEC(DMDGHBDFKMP KPEIBOOMGAE, NativeParallelHashMap<Guid, LocalId> BEGGGJIDCGA, [Out] Exception BKLHGCIIDBN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CMGPAFGMFEO(DMDGHBDFKMP KPEIBOOMGAE, NativeParallelHashMap<Guid, LocalId> BEGGGJIDCGA, [Out] NativeArray<LocalId> KKDBICIHPCE, [Out] NativeArray<LocalId> GEGMKOHLNDI, [Out] NativeArray<AuthoredLocalPoseData> GIIGAFDJIBK, Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "18")]
	void KCLEIOLMNGH(DMDGHBDFKMP MLFFBNNKHKH, NativeArray<int> PECKHJOFPCH, HIMKNIEIOHE<GameObject> CCKFGOLMLJG, CONCPCFABOF<GameObject> GPBJNNDGNFA, OOGOJLIMCCH LJBANMJGDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PPFIMEAPCEP();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "20")]
	void FEBCFCKBGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "21")]
	void LLKPDPEKLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "22")]
	bool NGPLHCACPCH(DMDGHBDFKMP KPEIBOOMGAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "23")]
	KNBKAEDOCAN MNGLLIFBICJ(DMDGHBDFKMP KPEIBOOMGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "24")]
	void LKEJDLCPHJB(Guid KCIDHDICMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "25")]
	bool JPONDMJAJCF(Guid KCIDHDICMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7F63510", Offset = "0x7F62310", VA = "0x187F63510")]
	static CDCKPMDEDOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface BDEMLDNIKOF
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	long DNBLMOJBALI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	long DJJFMAPBLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface GADBIHCFMHL
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool MPFMOGHFLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool NDANJPPHLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int PFOPKNGJLID
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	int NHIHMODMOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	int GEMIKGFHNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool FOCMGDNOPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int MCLHJJIGPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "6")]
	void CNJCKKLCLJD(AJIMKJNIPDD HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
	void HOIJOMBKFMD(bool NALAHOICNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "8")]
	bool BHEOLLMODMF(HMJDCIMFIOA LCALHIDHIGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "9")]
	void AIGMNFJDDJC(object DKEBGKJJPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "10")]
	void AKEDEPPGGFE(object DKEBGKJJPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EHKGLPDNCBB(Action<object> MLFIGNFDOAF);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HGJEHIKJMKH(Action<object> MLFIGNFDOAF);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "13")]
	void MNEIPOBBBDE(NativeArray<ViewId> KLOMDIFPIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "14")]
	void JFDBGOBONDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "15")]
	void JAANKKPFDOF(MLHKGBLBCLB AAFMBEEMJAC, ReadOnlySpan<byte> FFEMKICJPKP, HMJDCIMFIOA JBJICEBBHIA, bool LADCGNMPDCM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "16")]
	void JAANKKPFDOF(MLHKGBLBCLB AAFMBEEMJAC, ReadOnlySpan<byte> BMGKLNOAMEH, bool LADCGNMPDCM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "17")]
	void JAANKKPFDOF(MLHKGBLBCLB AAFMBEEMJAC, ReadOnlySpan<byte> BMGKLNOAMEH, ReadOnlySpan<byte> BHPFIADEPFP, bool LADCGNMPDCM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "18")]
	void KDFOBOLFPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "19")]
	void DECJFJDLCDB(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "20")]
	void FOLOPDDADDM(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "21")]
	void BMCDOMNLBCD(Dictionary<object, object> ICBDOFODGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "22")]
	void HEEAMAFKOMA(NativeList<LAFPBLKJNNP> EOBDGMKCGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "24")]
	void OMGBLMKBPPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "25")]
	void ADKGAMHCMAD(List<object> ELMBDFGIJCN, int AJOJFAFFHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "26")]
	void JCPLAHAKBCL(int LEDAMNBPIIM, object FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "27")]
	void FJHDICFIHKJ(HMJDCIMFIOA LCALHIDHIGO, Dictionary<object, object> ADPBPEDNFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "28")]
	void KAIHEAGEBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "29")]
	void IJAOPDFGJPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PFDEFLPJKGH
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7F75950", Offset = "0x7F74750", VA = "0x187F75950")]
	public static IFEBEDAMFML JPPAPBFOGNE(this GADBIHCFMHL NMFFKEACGFO, object JLFLGDNCANL)
	{
		return default(IFEBEDAMFML);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct IFEBEDAMFML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GADBIHCFMHL NMFFKEACGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object JLFLGDNCANL;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D750", Offset = "0x7F6C550", VA = "0x187F6D750")]
	public IFEBEDAMFML(GADBIHCFMHL NMFFKEACGFO, object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D700", Offset = "0x7F6C500", VA = "0x187F6D700", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MMBIICOFCGK
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void JPHKAIKPHEA(ViewId EMPDJGGGCNA, KLOPPHJHMCG HEDEJOPCPGP, int HLDOEFCHGDK);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "0")]
	void LADOGLBAAOK(JPHKAIKPHEA FNHKEAPDGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "1")]
	void HOGPKLPKELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "2")]
	void LFOOHFCDAEJ(GBFCLKEFOGF KPAGBEKAECE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface HGMNDGAPNJH
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[ServiceLifetime(Lifetime.Application)]
public interface ACGIMABFNFD
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct LFPABLMPDAE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private ACGIMABFNFD DBMBHAEEENL;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7F6FE90", Offset = "0x7F6EC90", VA = "0x187F6FE90")]
		public LFPABLMPDAE(ACGIMABFNFD DBMBHAEEENL, string GINDFOHMNIK, string MKODOKAIHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7F6FE30", Offset = "0x7F6EC30", VA = "0x187F6FE30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct IHCDJANHLKO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private ACGIMABFNFD DBMBHAEEENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task JDEJDGHOHNF;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D8C0", Offset = "0x7F6C6C0", VA = "0x187F6D8C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "0")]
	void PKPEFOFGGJA(string NJJDPBHNDPA, float NFGIPBFMCLH = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "1")]
	void LFKGNGPFEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GKPCACOINMM(bool LEJNMBHFMDF, string GINDFOHMNIK, string MKODOKAIHCE);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "3")]
	void ABIJKCKBNCJ(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class CLCMMCKAPFP
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7F64470", Offset = "0x7F63270", VA = "0x187F64470")]
	public static ACGIMABFNFD.LFPABLMPDAE ACGOHGNHOGA(this ACGIMABFNFD NMFFKEACGFO, string GINDFOHMNIK, string MKODOKAIHCE)
	{
		return default(ACGIMABFNFD.LFPABLMPDAE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface NEAIMKEMDFN
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int ABHOFNEBGLE(GameObject MMMAEDGEACA);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBNNCLAKEHJ(GameObject MMMAEDGEACA);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool COFIBGCLOPE(int LCALHIDHIGO);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object GDBNKCMLDHB(JBBGAMGOICI CBBNAACPEGP, GameObject MMMAEDGEACA, Action<JBBGAMGOICI, int> LDLIMOGOGBF);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPKEPMEOIHG(GameObject MMMAEDGEACA, object EMGBHIBEDGH);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MCCKCIHPEPB
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNNKEGNCGDF(ECFMGHLFIHK DLJDIONABKD, LLPDOLMILHD KLAAIBKFNDA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface MNCDBIAHPLO
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIDMEGDOMCG(object GLEBGNJJOHG, NativeList<byte> FFEMKICJPKP);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object LGDBIGPAFJK(NativeArray<byte> FFEMKICJPKP);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface BLPJACMEHCN
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool PGEJONHIOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate LLFKHHHAPMK(AOMONGPLOBA ECMMLILBPBM, Action<AOMONGPLOBA> LDLIMOGOGBF);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBHIAAEAEIJ(AOMONGPLOBA ECMMLILBPBM, Delegate LDLIMOGOGBF);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate MHEKJDDMCAF(AOMONGPLOBA ECMMLILBPBM, Action<AOMONGPLOBA> NKKEHJJBBLG);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AAAIFCDCBGD(AOMONGPLOBA ECMMLILBPBM, Delegate LDLIMOGOGBF);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OBEEEOBKNAD(AOMONGPLOBA ECMMLILBPBM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AOMONGPLOBA BMINFMAFJOO(GameObject MMMAEDGEACA);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface AFMLCPMEJFE
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int CKPFANIGIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int ABCHONALPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool MPFMOGHFLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool CPFGDLGOACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool GICDGKNCBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JBBGAMGOICI OOFCCAPKFGI(int LCALHIDHIGO);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface HFMJFJNBLHH
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNNKEGNCGDF(int FAPLIEIFOHC, LLPDOLMILHD HJKNJOPJHNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface MPLGMHFJJMG
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool HHONGLBHPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface PHMNNCHKCOI
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	NBGHGFAEDDJ BBAOFGPOLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	GDJLPLLNOFP ICHODNMACGF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool IBJOLCLKIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDEPKIOIFLK(Transform MAAFBDAKBJA);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKIKLBPHDAD(Transform MAAFBDAKBJA, BBFHFFOIEKE FMNFKCFMNNM);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GMKKGCNDINE(Transform MAAFBDAKBJA, MNEOPFCLMIK IBFIHEMIHJO);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface KFKAPJOLOCN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PNADECKFIMH;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface AIPACENPIEB
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBNNDMEIFEN();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[ServiceLifetime(Lifetime.Application)]
public interface NJFFCBOMEHA
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APGEFIEPNNJ(GameObject MMMAEDGEACA, LIDOOEGDINP KINLHKHBJLB, KHPKLCEFDDK PPCMFBLBLGM);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OKMGEGGEBJE(JBBGAMGOICI CBBNAACPEGP, bool MHLHBCAEIEO, float3 NFPLICBOEEN, quaternion ELDPHFIACCC);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEPIJBIGMFM(LHGPEBNJFMN OILLNNJNCIK);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFIMGCFMIPB(GALEOJBODPG EALBMDJEHIA, GALEOJBODPG GDCDKMJLKDH, FMPIAKEFFMI OEFNLALAAAN);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KGHKMNIKBLC(GALEOJBODPG EALBMDJEHIA, FMPIAKEFFMI OEFNLALAAAN);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MJJFCDAJCPM(LHGPEBNJFMN GAPIKHHBAHD);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DNONAKODIFO(DMDGHBDFKMP HIDBMDJLPPO, ReadOnlySpan<Guid> PNPCEPAEKLF, ReadOnlySpan<int> IBLBGLNANNO, CONCPCFABOF<GameObject> CBPBOJELMMA);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EJBNCLFDNCN(ABKBGPGDIAJ NJCLLFFIHGK);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct HGGKDAFJAHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> FFEMKICJPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle BHHPJCAPOMD;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C890", Offset = "0x7F6B690", VA = "0x187F6C890")]
	public HGGKDAFJAHF(ReadOnlyMemory<byte> OJGHKHPIHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C850", Offset = "0x7F6B650", VA = "0x187F6C850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum OPJAMKEELMO
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
public struct DMDGHBDFKMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString NOIKGFGCMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object IPDKMBLNEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object AOMLNICLGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> NGFNHGNNHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool OMKAGFDGJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public DOJMAGJMJKJ.FILJCPAKFGG? HAEBNCMLAAE;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7F64D00", Offset = "0x7F63B00", VA = "0x187F64D00")]
	public DMDGHBDFKMP(ByteString NOIKGFGCMIH, [Optional] object IPDKMBLNEEA, [Optional] object AOMLNICLGBI, [Optional] IEnumerable<string> NGFNHGNNHBD, bool OMKAGFDGJAF = true, [Optional] DOJMAGJMJKJ.FILJCPAKFGG? HAEBNCMLAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct FBBAOCFOPEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object MJJKIDBMBLF;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct EBPOOJIJECL
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Flags]
	public enum JDPCJGJPFLP
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
		IsR1Upgrade = 0x20
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public RRObjectPrefabData OKFFFKEBPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid MLMMNGNEKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid EEPJDKMIGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid GBGBKGDMGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid KGCENLMBNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public JDPCJGJPFLP KKBDAOHAGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 PJDGBIKFOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int IGAICHKJHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public OPGINPCDEBK BMAENIFPMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int CNNNOKPAIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int PEBFPAMGOBP;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Guid GLAFCIMPEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5140390", Offset = "0x513F190", VA = "0x185140390")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool CKOHLILIOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7F656F0", Offset = "0x7F644F0", VA = "0x187F656F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool BMLGMNOMNJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7F65700", Offset = "0x7F64500", VA = "0x187F65700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool KLKNPOHLKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7F656E0", Offset = "0x7F644E0", VA = "0x187F656E0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct DMHCODEMIFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly LFNBIKLBCDI GNMMLFONKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly LFNBIKLBCDI ONOFHBPOEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly uint IAPHKFMKLLE;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7F64D80", Offset = "0x7F63B80", VA = "0x187F64D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct KHDKEFLPHGD
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal readonly DMHCODEMIFO CFDGGKIIHOI;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C420", Offset = "0x7F6B220", VA = "0x187F6C420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct HDHOPPCAEBD
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal readonly DMHCODEMIFO CFDGGKIIHOI;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C420", Offset = "0x7F6B220", VA = "0x187F6C420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct BJFLKHJMGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly uint IAPHKFMKLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly bool FNJAHIFADIK;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7F61C90", Offset = "0x7F60A90", VA = "0x187F61C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct LFNBIKLBCDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal int PPPFIBNDOMK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FC80", Offset = "0x7F6EA80", VA = "0x187F6FC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[ServiceLifetime(Lifetime.Application)]
public interface DOBLJLBDFMN
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	BHAJFGHPBOL GBLEBDIIFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface JGNPLCMILBE
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface HMDOMMDFAFN
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class CPBHIMCOLGA
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3719380", Offset = "0x3718180", VA = "0x183719380")]
	public static GALEOJBODPG MPOJCHNLJJG<T>(this T CBBNAACPEGP) where T : JGNPLCMILBE
	{
		return default(GALEOJBODPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7F64860", Offset = "0x7F63660", VA = "0x187F64860")]
	public static MonoBehaviour DGKHPCDPCKF(this JGNPLCMILBE CBBNAACPEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7F648E0", Offset = "0x7F636E0", VA = "0x187F648E0")]
	public static GameObject DIBJMNKHENG(this JGNPLCMILBE CBBNAACPEGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface IBOBEEDDGFC : JGNPLCMILBE
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(JBBGAMGOICI NIFNCNHCJID);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface AGDOCPNKJOB : JGNPLCMILBE
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HMEKNJEAEKD
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate void KPLNPGNPHBN(HMKKNPEPDPM BBDKHBANPKK);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KPLNPGNPHBN AGMJPDMHPNE;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface MLPOHEKEMAJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface NCMPOFENEKP
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface LCELIPGBGBI
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(JBBGAMGOICI PFHFIIJDODP);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool OJCCKCECJBD);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FMHEFFCOHEP(JBBGAMGOICI HMMCMNPLNJA);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface PPJFNPCIGFP
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(DJKODAHGDFK POOOKGFDOMG);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface DJKODAHGDFK
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	GameObject MMMAEDGEACA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Transform MAAFBDAKBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	BNEBJELOGPG LEHLBJIOCDK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool FDJCMEEJGNL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFMLECJCLEI(BNEBJELOGPG OMKBHAHHOCG);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MGCLLADFKEL GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class CHEPICMHFOE
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7F640D0", Offset = "0x7F62ED0", VA = "0x187F640D0")]
	public static void PDODLHNBCPA(this DJKODAHGDFK OEGPMEHPDFC, GHEBJLJHKJI JAPGNGDBBIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface BNEBJELOGPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Rigidbody FHACEMLODOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	DJKODAHGDFK IOEOEPMNAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	GameObject DIBJMNKHENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Transform MNFKMLBDMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	BNEBJELOGPG DPEBHIBHPBC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	BNEBJELOGPG NLFMPGFBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	int NKEJNNNELDL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool LFGLGHMNANE
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool OBEEEOBKNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool HGOEAGNGJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	FDHABFHCHKN OMKJBICJOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	MOFBPFIADAD MCPIALHDBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	float AEBOBMEJAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 KJHEABGPCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Vector3 AKAPJDGKLNI
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	Vector3 BEKHCNOKDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	Vector3 IBJNIIMABAD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool IJCDCBNNFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool HFOKOBOEGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool CEKBMCHJIHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	bool OBIOFDBDDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 MPGGIIMEIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 GJANFFGOPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 OPDEFFENGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 KAIGLKCPEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	float GECFBCCDCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	float JEDJMEDNLAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Vector3 ACFCFCBFMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Quaternion CLFAOPEJMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	float IPKLHPEKCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	float ICBKCCDGPOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool EBJPLFMKHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	HGOCJAJAHJN PGJAPNAKKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool ENAMOGMAFCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Transform MDGKGHNFJPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Vector3 AAIGDBLJPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	float LAHLNKMHAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float PHCDLLGNBGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	Quaternion MBEOEIHHPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Vector3 EGIJBOFOPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Quaternion DGDGJCDLDBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	RigidbodyConstraints EGIODLEBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	bool KLMCKAAMJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode MBHLFDEDGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	bool JAMFLBLKLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MIOLGGFIPGF JBDBHPAPKOK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MIOLGGFIPGF OMPAMMEAHDD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MIOLGGFIPGF ICELLOHJAFI;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event MIOLGGFIPGF ABKDDFPNAPP;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event MIOLGGFIPGF OHJCBMMIPBF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MIOLGGFIPGF ECEHECCAFCN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event MIOLGGFIPGF DNCDKDMCKMI;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GLOLNKBBBNH OKNIDFBIFFC;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MOCFDENFFJA, MOCFDENFFJA> PJDFMBOFOKG;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BNEBJELOGPG CFMPECDEIMF(int GLAOLHCPLLG);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void GBENDDAIJNE((Quaternion rot, Vector3 moments) AHPJADDOMJM);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void IKNOEPKPIAO();

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void BIBFJNBONAL();

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void JFJBEMBOGGG();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void FHJNPCOBAGJ();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void AHDGJLDDOBD();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void GPAFCMPBBMA(BNEBJELOGPG OAIIHELJHLG, bool EJHHHIDNFHE = false);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void FDJJKNMADBE(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void GCJCHIMMGIK(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 KIPAKEBLEGJ(Vector3 LNIADJMLGIK);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 FGOBHOLAFPK(Vector3 EKLGFNDJLMJ);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void PFJBHMKCPGL();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void BKHMMDNEKOE();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void EIBNPBBNFGP();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void LFDGAMHBFAH(Vector3 JJEBPBJEEKD, Vector3 EILMIBFNCJC);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void CIHNMCAEGFP(Vector3 JHLPMGHHGEG, Vector3 OJFGKMMJPLJ);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void NPAAIGDMLIN(Vector3 HGKCDPFNIKC);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void PEBDPNDGMFB(AIPGFHKOAOH LMIHCDIEAAL, Vector3 CEINDOKFBOP, float LKBJKLCFGIN, float FADCPNGFJEM = 8f, float OHMJMHHACPJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void BCAIEPCMGIL(OIHNMBFPFKI HMKMOJFBDLP, Vector3 BIDDHJCLFLK, float PDNOMCMHGEH = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void JJDKCJPJDJL(OIHNMBFPFKI HMKMOJFBDLP, Vector3 LJIHJJKHDDH, float KGIMKDKAEAH = 7f, float AAIDDDOHLBA = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 PJNHGDBDEGL(Vector3 OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 KIDJIBFNIHP(Vector3 OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void NHFPIBLBNGD();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void KHABNJPMIPE(BNEBJELOGPG HKHABADDJLA, object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void HMEONHIJHCB(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void OKJBFNLGKOD();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void LDPOIEOIEFI();

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void DPBIBMLABPL();

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool DIDHAIJMHEI();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void OCGFJCJDBAP();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void LPEJKIINIKC(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void EOPGKHIKMGP(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void CCOFIEADNPD(object JLFLGDNCANL, bool OHLMJEAGLOD);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void JPMKMKMHJNH(Vector3 CJHBACNEMHB, Quaternion PLDKEAJHIEI);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void BNMNFFMBIPD(Vector3 MNIAPMAMIPF, Quaternion HLNCFPIIEDM);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool DPDBJILLEGF(float LILMPFGODPN);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void LIPPCGMPIHE(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void OJGPHHPDAPA(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void PAIOOOAKCBF(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void FEJODPCJEIF(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void HPCEOCNDDPG(Vector3 PGBCKJJIOAA, ForceMode FHPLDJIAAMG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void KCAGEDKPBII(Vector3 PGBCKJJIOAA, Vector3 NPJPCFKLMHD, ForceMode FHPLDJIAAMG);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void DJIBJJAPPOF(Vector3 BFBHEICBECE, ForceMode FHPLDJIAAMG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void FGKAGPOMBIC(Vector3 BFBHEICBECE, ForceMode FHPLDJIAAMG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool DMLBCABMIIE(Vector3 MACLBEFOGKL, [Out] RaycastHit EMIJFAALBFB, float HBKDKLDLCIL);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void NAFCDPGBHMM();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface MOFBPFIADAD
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AODDDLKBKMH(Vector3 KENBDKKNDNN);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KEAHDINAFGP(Vector3 MFGCBODNMPM);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHNOJOEPHIC(Vector3 KENBDKKNDNN);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AFPCCCMHFOM(Vector3 MFGCBODNMPM);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface FDHABFHCHKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 MIPMAEIOAPO();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 IEGLNGDHEDI();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CNNBFLBOMNG(float BPNOBGCHENI, float DDNJBIIKMIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void MIOLGGFIPGF(DJKODAHGDFK JNHFGNOCEAI);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum NPCBAHGLLBD
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum AIPGFHKOAOH
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public delegate void GLOLNKBBBNH(DJKODAHGDFK JNHFGNOCEAI, bool EJHHHIDNFHE = false);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum OIHNMBFPFKI
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct MGCLLADFKEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Rigidbody BLDBEDPDIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public object DNCCNJDOKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector3 NLHEABDFAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 BJKCDGABEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public JFLNIIIFAEP GHLLJKOAGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool DNCPBLLDNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool EHMJLIEFGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool MALKBLDFAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool JHIFEGILCJB;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct GALEOJBODPG : IEquatable<GALEOJBODPG>
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly GALEOJBODPG LABFBGKEAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GameObject MMMAEDGEACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7F69FE0", Offset = "0x7F68DE0", VA = "0x187F69FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public LAFPBLKJNNP CJANOIALIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7F69E20", Offset = "0x7F68C20", VA = "0x187F69E20")]
		get
		{
			return default(LAFPBLKJNNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public NNCGLECLGPE NJMJGAJEGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A2B0", Offset = "0x7F690B0", VA = "0x187F6A2B0")]
		get
		{
			return default(NNCGLECLGPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public RRObjectPrefabData EBBDHIMNDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7F69B80", Offset = "0x7F68980", VA = "0x187F69B80")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool FDBIOFMJGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A6F0", Offset = "0x7F694F0", VA = "0x187F6A6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool MPIFJDLEGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A720", Offset = "0x7F69520", VA = "0x187F6A720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool EHKLGPONNMG
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7F69EC0", Offset = "0x7F68CC0", VA = "0x187F69EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool FCFGFFOPMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7F69A70", Offset = "0x7F68870", VA = "0x187F69A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool OPPLHFBHIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7F69B60", Offset = "0x7F68960", VA = "0x187F69B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool PKBLBICAJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7F69A40", Offset = "0x7F68840", VA = "0x187F69A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool GIJJAFMOFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A390", Offset = "0x7F69190", VA = "0x187F6A390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool AKEHCKLLJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7F69A00", Offset = "0x7F68800", VA = "0x187F69A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool PMIDBHJDOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7F69A90", Offset = "0x7F68890", VA = "0x187F69A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool IJMLEOHKCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7F69EE0", Offset = "0x7F68CE0", VA = "0x187F69EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool KKEMCCJGMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7F69AD0", Offset = "0x7F688D0", VA = "0x187F69AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool MJJMMICDEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7F69FA0", Offset = "0x7F68DA0", VA = "0x187F69FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public NIKMOCPDODA KBLJFEFHCND
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(NIKMOCPDODA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public HLOCMPCEIFN OIHOHGGMJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(HLOCMPCEIFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public PJNAMODFGMG EDPDPBJMKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(PJNAMODFGMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public INCFFNNGAPC OBGNIODLIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(INCFFNNGAPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public PDINOAPOBGA AINMBGMHJDG
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(PDINOAPOBGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public LONEPMJCLKH KHFGLGHBMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(LONEPMJCLKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public CAMIJHMJGEH HHBPAAKFLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(CAMIJHMJGEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public DDMIGGNFFBK LFDHPHBNNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(DDMIGGNFFBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public BPFDLNMDCGD KLBNDDAEOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(BPFDLNMDCGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public ECHMMNDBBAB IDHMNIIPLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(ECHMMNDBBAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public PMKLPIDDCHC BDAHOAFECCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(PMKLPIDDCHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public BJGLBBNOAJF DGKGOFCFGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(BJGLBBNOAJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public GEEJKHDDBAK CBCKJPHIMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GEEJKHDDBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool BOCHKHIGLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A3D0", Offset = "0x7F691D0", VA = "0x187F6A3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool NPGACFBNFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A4F0", Offset = "0x7F692F0", VA = "0x187F6A4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool JFLOLBINEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A630", Offset = "0x7F69430", VA = "0x187F6A630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool APHGFBFFFFI
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7F69CB0", Offset = "0x7F68AB0", VA = "0x187F69CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool BPKNEOGLNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A670", Offset = "0x7F69470", VA = "0x187F6A670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool OPHDNCGMAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A350", Offset = "0x7F69150", VA = "0x187F6A350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool LDHPFNFNJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A6B0", Offset = "0x7F694B0", VA = "0x187F6A6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public ELMJBIFIJEP MNFKMLBDMML
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(ELMJBIFIJEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public CDGINBCLAOG DHHINDFAFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(CDGINBCLAOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private FNPHLLFAMCL ALKLOCLCPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7F684F0", Offset = "0x7F672F0", VA = "0x187F684F0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static GALEOJBODPG HEKJAOMNHLJ(JBBGAMGOICI NIFNCNHCJID)
	{
		return default(GALEOJBODPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7F69F20", Offset = "0x7F68D20", VA = "0x187F69F20")]
	public GOFCJOAKJOK HEBEAIOMMGE()
	{
		return default(GOFCJOAKJOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7F69D50", Offset = "0x7F68B50", VA = "0x187F69D50")]
	public EFHPLKJPPBG FBCOJIHHFEI()
	{
		return default(EFHPLKJPPBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A170", Offset = "0x7F68F70", VA = "0x187F6A170")]
	public ELBDIAFLPNK JKGOFFIFKFJ()
	{
		return default(ELBDIAFLPNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A4C0", Offset = "0x7F692C0", VA = "0x187F6A4C0")]
	public KEGLMAPNEMJ MCADPPLFIFD()
	{
		return default(KEGLMAPNEMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A260", Offset = "0x7F69060", VA = "0x187F6A260")]
	public PBGNKBLAGLE KHBGIDBOBFN()
	{
		return default(PBGNKBLAGLE);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7F69B10", Offset = "0x7F68910", VA = "0x187F69B10")]
	public IGFMBGJJEMD DJGCAFJMFBG()
	{
		return default(IGFMBGJJEMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A530", Offset = "0x7F69330", VA = "0x187F6A530")]
	public void NHCJLEEIJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A1C0", Offset = "0x7F68FC0", VA = "0x187F6A1C0")]
	public void KCGBACPBOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7F69D80", Offset = "0x7F68B80", VA = "0x187F69D80")]
	public bool FMCDAIDJNMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A740", Offset = "0x7F69540", VA = "0x187F6A740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public GALEOJBODPG(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7F62C00", Offset = "0x7F61A00", VA = "0x187F62C00")]
	public static bool HEKJAOMNHLJ(GALEOJBODPG OAIIHELJHLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static JBBGAMGOICI HEKJAOMNHLJ(GALEOJBODPG OAIIHELJHLG)
	{
		return default(JBBGAMGOICI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A710", Offset = "0x7F69510", VA = "0x187F6A710")]
	public static bool PBEBFPKJKLO(GALEOJBODPG CHIPBNNCPBF, GALEOJBODPG MDEAIGKHMKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7F664B0", Offset = "0x7F652B0", VA = "0x187F664B0")]
	public static bool INFPGDPCEAI(GALEOJBODPG CHIPBNNCPBF, GALEOJBODPG MDEAIGKHMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7F69CC0", Offset = "0x7F68AC0", VA = "0x187F69CC0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(GALEOJBODPG HBLONCAMFLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct BJGLBBNOAJF : IEquatable<BJGLBBNOAJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private PNAPNCMOKDC OCBKGOJFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7F62500", Offset = "0x7F61300", VA = "0x187F62500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7F62180", Offset = "0x7F60F80", VA = "0x187F62180")]
	public void JNHIKCAEHMP(uint FONJFDCCINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7F62080", Offset = "0x7F60E80", VA = "0x187F62080")]
	public bool IEKFJIILENF([Out] uint FONJFDCCINO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7F61D40", Offset = "0x7F60B40", VA = "0x187F61D40")]
	public bool DLFOEPINMIM([Out] uint FONJFDCCINO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7F62290", Offset = "0x7F61090", VA = "0x187F62290")]
	public void KHFKFFBFMIH(string FONJFDCCINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7F61ED0", Offset = "0x7F60CD0", VA = "0x187F61ED0")]
	[CanBeNull]
	public string FANGHBGIDND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7F62380", Offset = "0x7F61180", VA = "0x187F62380")]
	public bool LNODMBJCEGM([Out] string GBJJKAOHDFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7F61FE0", Offset = "0x7F60DE0", VA = "0x187F61FE0")]
	public void HEOOEAMLEFK(string GBJJKAOHDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public BJGLBBNOAJF(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7F61E40", Offset = "0x7F60C40", VA = "0x187F61E40", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(BJGLBBNOAJF HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct NIKMOCPDODA : IEquatable<NIKMOCPDODA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private JCIKEDDHEJM CNHFDPLFPKL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7F73320", Offset = "0x7F72120", VA = "0x187F73320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private PNAPNCMOKDC DAMPIELFGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7F738B0", Offset = "0x7F726B0", VA = "0x187F738B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool OLMCICJKJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7F73660", Offset = "0x7F72460", VA = "0x187F73660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool HNOCIOLLABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x7F72FC0", Offset = "0x7F71DC0", VA = "0x187F72FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool OHBGADNKIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x7F737F0", Offset = "0x7F725F0", VA = "0x187F737F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Guid ODKJPMNDPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7F73910", Offset = "0x7F72710", VA = "0x187F73910")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Guid ACBABJDGAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7F732A0", Offset = "0x7F720A0", VA = "0x187F732A0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Guid GFBJGAFBEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7F73000", Offset = "0x7F71E00", VA = "0x187F73000")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public CDGINBCLAOG DHHINDFAFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(CDGINBCLAOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7F735C0", Offset = "0x7F723C0", VA = "0x187F735C0")]
	public bool JPOLPGEMNOK([Out] Guid AEHJOFBOANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7F73990", Offset = "0x7F72790", VA = "0x187F73990")]
	public bool PCDCEEEJLOF([Out] Guid HLGNHFCFAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7F73380", Offset = "0x7F72180", VA = "0x187F73380")]
	public void JMOKDOJNOKE(Guid AFBDJBIOHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7F736F0", Offset = "0x7F724F0", VA = "0x187F736F0")]
	public void NALCFGFOLAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7F734A0", Offset = "0x7F722A0", VA = "0x187F734A0")]
	public Guid JOODMEABIFL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public NIKMOCPDODA(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7F73210", Offset = "0x7F72010", VA = "0x187F73210", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(NIKMOCPDODA HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct ELBDIAFLPNK : IEquatable<ELBDIAFLPNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private OOEFJPHJGKF CPOIBOCPNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7F67480", Offset = "0x7F66280", VA = "0x187F67480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 CPLACKMMGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7F66CD0", Offset = "0x7F65AD0", VA = "0x187F66CD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Quaternion IFKDMNIMDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7F670D0", Offset = "0x7F65ED0", VA = "0x187F670D0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public GALEOJBODPG IIBMCJELHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7F674E0", Offset = "0x7F662E0", VA = "0x187F674E0")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7F66E20", Offset = "0x7F65C20", VA = "0x187F66E20")]
	public LHGPEBNJFMN EGHNBAKMGEN(Allocator LNMGNHHGHLL)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x7F673E0", Offset = "0x7F661E0", VA = "0x187F673E0")]
	public bool LLJJFHKJKAI(GALEOJBODPG BOGJJGPKPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7F66EF0", Offset = "0x7F65CF0", VA = "0x187F66EF0")]
	public void EPMHHNKCDFP(Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7F66BC0", Offset = "0x7F659C0", VA = "0x187F66BC0")]
	public void BLEMPAMKKKF(float JCGDFDLNFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7F67220", Offset = "0x7F66020", VA = "0x187F67220")]
	public void JBOJCOMABMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public ELBDIAFLPNK(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7F62C00", Offset = "0x7F61A00", VA = "0x187F62C00")]
	public static bool HEKJAOMNHLJ(ELBDIAFLPNK OAIIHELJHLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static JBBGAMGOICI HEKJAOMNHLJ(ELBDIAFLPNK OAIIHELJHLG)
	{
		return default(JBBGAMGOICI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7F67040", Offset = "0x7F65E40", VA = "0x187F67040", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(ELBDIAFLPNK HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct GOFCJOAKJOK : IEquatable<GOFCJOAKJOK>
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly GOFCJOAKJOK LABFBGKEAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private HKNJHJGCLNN BPDPPFKNMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B0E0", Offset = "0x7F69EE0", VA = "0x187F6B0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<GALEOJBODPG> HDOMAGFGOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AED0", Offset = "0x7F69CD0", VA = "0x187F6AED0")]
		get
		{
			return default(Span<GALEOJBODPG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B140", Offset = "0x7F69F40", VA = "0x187F6B140")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AFD0", Offset = "0x7F69DD0", VA = "0x187F6AFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public ELMJBIFIJEP MNFKMLBDMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(ELMJBIFIJEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public CDGINBCLAOG DHHINDFAFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(CDGINBCLAOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B1C0", Offset = "0x7F69FC0", VA = "0x187F6B1C0")]
	public void JEHGLJBHNKM(GOFCJOAKJOK HBLONCAMFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public GOFCJOAKJOK(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7F62C00", Offset = "0x7F61A00", VA = "0x187F62C00")]
	public static bool HEKJAOMNHLJ(GOFCJOAKJOK OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B050", Offset = "0x7F69E50", VA = "0x187F6B050", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(GOFCJOAKJOK HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static GALEOJBODPG HEKJAOMNHLJ(GOFCJOAKJOK FPFHIDBMBMI)
	{
		return default(GALEOJBODPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DefaultMember("Item")]
public struct KBOENGPNDFP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Dictionary<int, object> MNMCPCDGAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private MKENNIBEGFF HIKHLHKADIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool DLODKGPBAGL;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		[CompilerGenerated]
		readonly get
		{
			return default(GALEOJBODPG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public EPJNHJECBEL ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F130", Offset = "0x7F6DF30", VA = "0x187F6F130")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F260", Offset = "0x7F6E060", VA = "0x187F6F260")]
	internal KBOENGPNDFP(GALEOJBODPG GLEBGNJJOHG, bool DLODKGPBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EF50", Offset = "0x7F6DD50", VA = "0x187F6EF50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x39C4360", Offset = "0x39C3160", VA = "0x1839C4360")]
	public void GGPBJBPHJCG<T>(EPJNHJECBEL MAKJJJECHHB, T OAIIHELJHLG, [Optional] T LDGCNLHOBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F080", Offset = "0x7F6DE80", VA = "0x187F6F080")]
	public void FKCGDELNEED(EPJNHJECBEL MAKJJJECHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0xDB93E0", Offset = "0xDB81E0", VA = "0x180DB93E0")]
	public Dictionary<int, object> OOMCNHIGBEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F1F0", Offset = "0x7F6DFF0", VA = "0x187F6F1F0")]
	private readonly void IEFOOMNNOPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class HJJFMAFDJCI
{
	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C940", Offset = "0x7F6B740", VA = "0x187F6C940")]
	public static KBOENGPNDFP OHCJBHJCLEJ(this GALEOJBODPG GLEBGNJJOHG)
	{
		return default(KBOENGPNDFP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct GEEJKHDDBAK : IEquatable<GEEJKHDDBAK>
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly GEEJKHDDBAK LABFBGKEAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private bool KKEMCCJGMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A9E0", Offset = "0x7F697E0", VA = "0x187F6A9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Vector3 AJFOKEILODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AC60", Offset = "0x7F69A60", VA = "0x187F6AC60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AD90", Offset = "0x7F69B90", VA = "0x187F6AD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7F6ABE0", Offset = "0x7F699E0", VA = "0x187F6ABE0")]
	public Vector3 IEFCKIHPHOC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7F6AB60", Offset = "0x7F69960", VA = "0x187F6AB60")]
	public void HNGGKCAHPME([In] Vector3 OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7F6AD10", Offset = "0x7F69B10", VA = "0x187F6AD10")]
	public void LJCKOENKFMJ([In] Vector3 OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7F6AAB0", Offset = "0x7F698B0", VA = "0x187F6AAB0")]
	public bool GKOALMPKFDP([In] Vector3 OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public GEEJKHDDBAK(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6AA20", Offset = "0x7F69820", VA = "0x187F6AA20", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(GEEJKHDDBAK HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7F6ADF0", Offset = "0x7F69BF0", VA = "0x187F6ADF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct PPHADGEBLPF : IEquatable<PPHADGEBLPF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F76D40", Offset = "0x7F75B40", VA = "0x187F76D40", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(PPHADGEBLPF HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct CDGINBCLAOG : IEquatable<CDGINBCLAOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private HKNJHJGCLNN BPDPPFKNMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F63850", Offset = "0x7F62650", VA = "0x187F63850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public JBBGAMGOICI EIFNCBMBKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F638B0", Offset = "0x7F626B0", VA = "0x187F638B0")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public GALEOJBODPG DPEBHIBHPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F63E20", Offset = "0x7F62C20", VA = "0x187F63E20")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public GALEOJBODPG NLFMPGFBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F63FB0", Offset = "0x7F62DB0", VA = "0x187F63FB0")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F636C0", Offset = "0x7F624C0", VA = "0x187F636C0")]
	public Span<GALEOJBODPG> DFGLLDALHHH()
	{
		return default(Span<GALEOJBODPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F63940", Offset = "0x7F62740", VA = "0x187F63940")]
	public Span<GALEOJBODPG> GLHMKKJLHKI()
	{
		return default(Span<GALEOJBODPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F63B70", Offset = "0x7F62970", VA = "0x187F63B70")]
	public Span<GALEOJBODPG> HEHGBDMMJOL()
	{
		return default(Span<GALEOJBODPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F63EB0", Offset = "0x7F62CB0", VA = "0x187F63EB0")]
	public Span<GALEOJBODPG> MOCEMBJEBCG()
	{
		return default(Span<GALEOJBODPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F63A40", Offset = "0x7F62840", VA = "0x187F63A40")]
	public bool GPAFCMPBBMA(GALEOJBODPG BOGJJGPKPIJ, bool GDHODLLCPLI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F63C70", Offset = "0x7F62A70", VA = "0x187F63C70")]
	public bool HGLAAEAKLPG(GALEOJBODPG GDJNLDEHAHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F63D10", Offset = "0x7F62B10", VA = "0x187F63D10")]
	public GALEOJBODPG LAHEDCBMJLD(uint HFAFOICMKML)
	{
		return default(GALEOJBODPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F63630", Offset = "0x7F62430", VA = "0x187F63630")]
	public GOFCJOAKJOK CIAJKEBCGGM()
	{
		return default(GOFCJOAKJOK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public CDGINBCLAOG(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7F62C00", Offset = "0x7F61A00", VA = "0x187F62C00")]
	public static bool HEKJAOMNHLJ(CDGINBCLAOG OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F637C0", Offset = "0x7F625C0", VA = "0x187F637C0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(CDGINBCLAOG HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct HLOCMPCEIFN : IEquatable<HLOCMPCEIFN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public string KPDIBFFPHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CF10", Offset = "0x7F6BD10", VA = "0x187F6CF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public string IBEMDFICFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CEA0", Offset = "0x7F6BCA0", VA = "0x187F6CEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public string MHDHKALPIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CCA0", Offset = "0x7F6BAA0", VA = "0x187F6CCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public string BFMPEIDBJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CA00", Offset = "0x7F6B800", VA = "0x187F6CA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CDE0", Offset = "0x7F6BBE0", VA = "0x187F6CDE0")]
	public bool LNODMBJCEGM([Out] string GBJJKAOHDFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public HLOCMPCEIFN(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CD50", Offset = "0x7F6BB50", VA = "0x187F6CD50", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(HLOCMPCEIFN HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct PBGNKBLAGLE : IEquatable<PBGNKBLAGLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private BFIDPBDMGHC NFCMFBMHODB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F73F60", Offset = "0x7F72D60", VA = "0x187F73F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public FDGKKMHEELO OJJBGGJPIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F747A0", Offset = "0x7F735A0", VA = "0x187F747A0")]
		get
		{
			return default(FDGKKMHEELO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F740E0", Offset = "0x7F72EE0", VA = "0x187F740E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool BEGFIAEDHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F748A0", Offset = "0x7F736A0", VA = "0x187F748A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7F741F0", Offset = "0x7F72FF0", VA = "0x187F741F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public CONCPCFABOF<string> OELMLJAOLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F74C10", Offset = "0x7F73A10", VA = "0x187F74C10")]
		get
		{
			return default(CONCPCFABOF<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F74A50", Offset = "0x7F73850", VA = "0x187F74A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public CONCPCFABOF<string> HKKNKOIBELI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F743B0", Offset = "0x7F731B0", VA = "0x187F743B0")]
		get
		{
			return default(CONCPCFABOF<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F74930", Offset = "0x7F73730", VA = "0x187F74930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public CONCPCFABOF<string> BPCHNNPIHBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F73FC0", Offset = "0x7F72DC0", VA = "0x187F73FC0")]
		get
		{
			return default(CONCPCFABOF<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F74680", Offset = "0x7F73480", VA = "0x187F74680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public CONCPCFABOF<string> EACKIHOLMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F74290", Offset = "0x7F73090", VA = "0x187F74290")]
		get
		{
			return default(CONCPCFABOF<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F74560", Offset = "0x7F73360", VA = "0x187F74560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F74B70", Offset = "0x7F73970", VA = "0x187F74B70")]
	public bool NABECDMDDBL(JBBGAMGOICI ENPELEHFGFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public PBGNKBLAGLE(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static JBBGAMGOICI HEKJAOMNHLJ(PBGNKBLAGLE OAIIHELJHLG)
	{
		return default(JBBGAMGOICI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7F744D0", Offset = "0x7F732D0", VA = "0x187F744D0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(PBGNKBLAGLE HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct DAJEGFAMNOL : IEquatable<DAJEGFAMNOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F649A0", Offset = "0x7F637A0", VA = "0x187F649A0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(DAJEGFAMNOL HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct CDLPIIJBBCE : IEquatable<CDLPIIJBBCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F64040", Offset = "0x7F62E40", VA = "0x187F64040", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(CDLPIIJBBCE HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct PJNAMODFGMG : IEquatable<PJNAMODFGMG>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly ComponentTypes OKPNJHGMAND;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly PJNAMODFGMG LABFBGKEAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Collider DHBIOONAIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F76750", Offset = "0x7F75550", VA = "0x187F76750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public BJNCGALMFPE IHBENLFMPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F765E0", Offset = "0x7F753E0", VA = "0x187F765E0")]
		get
		{
			return default(BJNCGALMFPE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7F76700", Offset = "0x7F75500", VA = "0x187F76700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public CFPLEAGPEDL HPBLAHHGJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F76240", Offset = "0x7F75040", VA = "0x187F76240")]
		get
		{
			return default(CFPLEAGPEDL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F768A0", Offset = "0x7F756A0", VA = "0x187F768A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public HHOCJNIHBFP BPPPDDIEMHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F76620", Offset = "0x7F75420", VA = "0x187F76620")]
		get
		{
			return default(HHOCJNIHBFP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7F766B0", Offset = "0x7F754B0", VA = "0x187F766B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public float ECIIFNLGAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7F76280", Offset = "0x7F75080", VA = "0x187F76280")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F76660", Offset = "0x7F75460", VA = "0x187F76660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool MABPMGLMNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F76570", Offset = "0x7F75370", VA = "0x187F76570")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7F764D0", Offset = "0x7F752D0", VA = "0x187F764D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool NLAEJOKOPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F760C0", Offset = "0x7F74EC0", VA = "0x187F760C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7F76430", Offset = "0x7F75230", VA = "0x187F76430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool AFDECJOCJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F761C0", Offset = "0x7F74FC0", VA = "0x187F761C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F75B70", Offset = "0x7F74970", VA = "0x187F75B70")]
	public static bool CPDNKDIGFHB(GALEOJBODPG CGEIMCMCMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F75DE0", Offset = "0x7F74BE0", VA = "0x187F75DE0")]
	public static bool EDIACBOJIPL(GALEOJBODPG CGEIMCMCMFC, [Out] PJNAMODFGMG BICFCCNFNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7F762C0", Offset = "0x7F750C0", VA = "0x187F762C0")]
	public bool JGECHOPIIDH([Out] LCELIPGBGBI LMKDHIOMNKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7F759E0", Offset = "0x7F747E0", VA = "0x187F759E0")]
	public bool AADNKOEMLPB([Out] JBBGAMGOICI IPCOMOHMNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F75D80", Offset = "0x7F74B80", VA = "0x187F75D80")]
	public bool DOABIKHMMEE(KKNPPHDFLGB BFCGDPAMADE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F76140", Offset = "0x7F74F40", VA = "0x187F76140")]
	public void HBIPBHGPAHC(KKNPPHDFLGB BFCGDPAMADE, bool HMKCBLNCLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F75AD0", Offset = "0x7F748D0", VA = "0x187F75AD0")]
	public void BCMNLCFGOIH(KKNPPHDFLGB BFCGDPAMADE, bool HMKCBLNCLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public PJNAMODFGMG(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7F76030", Offset = "0x7F74E30", VA = "0x187F76030", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(PJNAMODFGMG HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7F768F0", Offset = "0x7F756F0", VA = "0x187F768F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct KEGLMAPNEMJ : IEquatable<KEGLMAPNEMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public bool LKEJGBKINAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F3F0", Offset = "0x7F6E1F0", VA = "0x187F6F3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public KEGLMAPNEMJ(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F440", Offset = "0x7F6E240", VA = "0x187F6F440", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(KEGLMAPNEMJ HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct INCFFNNGAPC : IEquatable<INCFFNNGAPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private DKDGIOABHOE CNCDICJGMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7F6DF00", Offset = "0x7F6CD00", VA = "0x187F6DF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DFF0", Offset = "0x7F6CDF0", VA = "0x187F6DFF0")]
	public void GMLDEAJICAO(bool LKIFNKGLENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public INCFFNNGAPC(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DF60", Offset = "0x7F6CD60", VA = "0x187F6DF60", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(INCFFNNGAPC HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct PDINOAPOBGA : IEquatable<PDINOAPOBGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public bool GEBFNMECEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x7F75660", Offset = "0x7F74460", VA = "0x187F75660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool LOJHBIKGAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x7F75540", Offset = "0x7F74340", VA = "0x187F75540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public bool JCMJJOFFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7F75140", Offset = "0x7F73F40", VA = "0x187F75140")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7F74E50", Offset = "0x7F73C50", VA = "0x187F74E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool DKDAGPCDCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7F74E70", Offset = "0x7F73C70", VA = "0x187F74E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool MHNLHCBOOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7F74EC0", Offset = "0x7F73CC0", VA = "0x187F74EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool GKHLKEFFOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7F75860", Offset = "0x7F74660", VA = "0x187F75860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool MPFBFHICPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7F756E0", Offset = "0x7F744E0", VA = "0x187F756E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool POBCILEIMEC
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7F75190", Offset = "0x7F73F90", VA = "0x187F75190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool LHGMLEMLIDA
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7F74F10", Offset = "0x7F73D10", VA = "0x187F74F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool CDFGEENOOCB
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7F757C0", Offset = "0x7F745C0", VA = "0x187F757C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool FPFPACLIHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7F75590", Offset = "0x7F74390", VA = "0x187F75590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool OKBKADIHENP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7F75810", Offset = "0x7F74610", VA = "0x187F75810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool FJPBNNBNNDI
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7F75240", Offset = "0x7F74040", VA = "0x187F75240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool LHHLNHOCHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7F758B0", Offset = "0x7F746B0", VA = "0x187F758B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7F751E0", Offset = "0x7F73FE0", VA = "0x187F751E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public MGGOIMAPIBJ GAJMKFLFMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7F756A0", Offset = "0x7F744A0", VA = "0x187F756A0")]
		get
		{
			return default(MGGOIMAPIBJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7F74D80", Offset = "0x7F73B80", VA = "0x187F74D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool PNAFMIOMPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7F75360", Offset = "0x7F74160", VA = "0x187F75360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public KHPKLCEFDDK EGONDGJECKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7F75730", Offset = "0x7F74530", VA = "0x187F75730")]
		get
		{
			return default(KHPKLCEFDDK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x7F75770", Offset = "0x7F74570", VA = "0x187F75770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public bool HMACDELONOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x7F75320", Offset = "0x7F74120", VA = "0x187F75320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 IEEHOAGCLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x7F75480", Offset = "0x7F74280", VA = "0x187F75480")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Vector3 PJOJHHENAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7F74DD0", Offset = "0x7F73BD0", VA = "0x187F74DD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool JKGDAMBFAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x7F75040", Offset = "0x7F73E40", VA = "0x187F75040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7F758F0", Offset = "0x7F746F0", VA = "0x187F758F0")]
	public bool PCGCDNKFMDB(AAIHKNKKIED BFCGDPAMADE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7F75290", Offset = "0x7F74090", VA = "0x187F75290")]
	public void IMIHABJAOLF(AAIHKNKKIED BFCGDPAMADE, bool HMKCBLNCLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7F74FF0", Offset = "0x7F73DF0", VA = "0x187F74FF0")]
	public bool GANLGNGKJHD(LIDOOEGDINP BFCGDPAMADE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7F755E0", Offset = "0x7F743E0", VA = "0x187F755E0")]
	public void LLDAECADFDE(LIDOOEGDINP BFCGDPAMADE, bool HMKCBLNCLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7F75500", Offset = "0x7F74300", VA = "0x187F75500")]
	public LIDOOEGDINP KJIBHHGBMGL()
	{
		return default(LIDOOEGDINP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7F74D30", Offset = "0x7F73B30", VA = "0x187F74D30")]
	public bool AANJLOLJPFI(LIDOOEGDINP OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public PDINOAPOBGA(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x7F74F60", Offset = "0x7F73D60", VA = "0x187F74F60", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(PDINOAPOBGA HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct LONEPMJCLKH : IEquatable<LONEPMJCLKH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private HIHFOBNJGGG GLPKHKNJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x7F71E10", Offset = "0x7F70C10", VA = "0x187F71E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7F71F80", Offset = "0x7F70D80", VA = "0x187F71F80")]
	public bool MBIMHGAEFFO(FMPIAKEFFMI OEFNLALAAAN, List<GALEOJBODPG> NPDCNNDIODA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7F719E0", Offset = "0x7F707E0", VA = "0x187F719E0")]
	public int DBHPNIIBHDC(FMPIAKEFFMI OEFNLALAAAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7F717A0", Offset = "0x7F705A0", VA = "0x187F717A0")]
	public void AKHLOGPCOLE(List<GALEOJBODPG> NPDCNNDIODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7F718B0", Offset = "0x7F706B0", VA = "0x187F718B0")]
	public int DAHONCDEKIP(GALEOJBODPG GDCDKMJLKDH, FMPIAKEFFMI OEFNLALAAAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7F71B80", Offset = "0x7F70980", VA = "0x187F71B80")]
	public GALEOJBODPG GJHKJDKCMFG(int GLAOLHCPLLG, FMPIAKEFFMI OEFNLALAAAN)
	{
		return default(GALEOJBODPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7F720B0", Offset = "0x7F70EB0", VA = "0x187F720B0")]
	public void NGKJABJONCI(GALEOJBODPG GDCDKMJLKDH, FMPIAKEFFMI OEFNLALAAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7F71CB0", Offset = "0x7F70AB0", VA = "0x187F71CB0")]
	public bool IPJJBGMCLEN(GALEOJBODPG GDCDKMJLKDH, FMPIAKEFFMI OEFNLALAAAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7F71E70", Offset = "0x7F70C70", VA = "0x187F71E70")]
	public void LCMCGGGKDKM(FMPIAKEFFMI OEFNLALAAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7F71D60", Offset = "0x7F70B60", VA = "0x187F71D60")]
	public bool KLEEPMBHGMB(GALEOJBODPG GDCDKMJLKDH, FMPIAKEFFMI OEFNLALAAAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7F721E0", Offset = "0x7F70FE0", VA = "0x187F721E0")]
	public bool OPPOOOPODLB(FMPIAKEFFMI OEFNLALAAAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public LONEPMJCLKH(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7F71AF0", Offset = "0x7F708F0", VA = "0x187F71AF0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(LONEPMJCLKH HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct CAMIJHMJGEH : IEquatable<CAMIJHMJGEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7F63330", Offset = "0x7F62130", VA = "0x187F63330")]
	public void JOBFEKIICJM(bool OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7F633C0", Offset = "0x7F621C0", VA = "0x187F633C0")]
	public void NEILCAGMCKC(bool OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x37065C0", Offset = "0x37053C0", VA = "0x1837065C0")]
	public T LFMOADFNNJN<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public CAMIJHMJGEH(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7F632A0", Offset = "0x7F620A0", VA = "0x187F632A0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(CAMIJHMJGEH HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct DDMIGGNFFBK : IEquatable<DDMIGGNFFBK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool LEFEAJLODBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7F64B90", Offset = "0x7F63990", VA = "0x187F64B90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x7F64AB0", Offset = "0x7F638B0", VA = "0x187F64AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool DIJBJBBOEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x7F64A30", Offset = "0x7F63830", VA = "0x187F64A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public int AGLHGDBJIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7F64C60", Offset = "0x7F63A60", VA = "0x187F64C60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7F64BD0", Offset = "0x7F639D0", VA = "0x187F64BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public DDMIGGNFFBK(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7F64B00", Offset = "0x7F63900", VA = "0x187F64B00", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(DDMIGGNFFBK HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct EFOPBANJKOC : IEquatable<EFOPBANJKOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public int DHHNMOAMDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7F66AA0", Offset = "0x7F658A0", VA = "0x187F66AA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x7F669C0", Offset = "0x7F657C0", VA = "0x187F669C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public int OOJNCBENLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7F66980", Offset = "0x7F65780", VA = "0x187F66980")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7F66AE0", Offset = "0x7F658E0", VA = "0x187F66AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public uint PNPJEEHBIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x7F66B80", Offset = "0x7F65980", VA = "0x187F66B80")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7F66B30", Offset = "0x7F65930", VA = "0x187F66B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public EFOPBANJKOC(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7F66A10", Offset = "0x7F65810", VA = "0x187F66A10", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(EFOPBANJKOC HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct BPFDLNMDCGD : IEquatable<BPFDLNMDCGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	private BHPMOPIBKNJ PBIPJPNLELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7F62BA0", Offset = "0x7F619A0", VA = "0x187F62BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private JGNJPENDGFP NJOOJPLGDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7F62790", Offset = "0x7F61590", VA = "0x187F62790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool DEHHAKPEEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7F62950", Offset = "0x7F61750", VA = "0x187F62950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool DKOJODJOIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7F62C20", Offset = "0x7F61A20", VA = "0x187F62C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool LHGIDJBNOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7F62920", Offset = "0x7F61720", VA = "0x187F62920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool PJNLDMLFAIO
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7F63020", Offset = "0x7F61E20", VA = "0x187F63020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool IGKCGGNFCDM
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7F627F0", Offset = "0x7F615F0", VA = "0x187F627F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool IOAOALGAKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7F62820", Offset = "0x7F61620", VA = "0x187F62820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool FKIEABNELOO
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7F625F0", Offset = "0x7F613F0", VA = "0x187F625F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool BLCOKAIALPO
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7F62CC0", Offset = "0x7F61AC0", VA = "0x187F62CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool JGMIHFNJFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7F62A70", Offset = "0x7F61870", VA = "0x187F62A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7F628B0", Offset = "0x7F616B0", VA = "0x187F628B0")]
	public bool DHMOFGEBMHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7F630F0", Offset = "0x7F61EF0", VA = "0x187F630F0")]
	public GALEOJBODPG OHPMLEMOGPD(GALEOJBODPG GDCDKMJLKDH)
	{
		return default(GALEOJBODPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7F63190", Offset = "0x7F61F90", VA = "0x187F63190")]
	public JBBGAMGOICI ONKLICDEFFL()
	{
		return default(JBBGAMGOICI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7F62E30", Offset = "0x7F61C30", VA = "0x187F62E30")]
	public bool MEILFCIAGAN(JBBGAMGOICI NGBLNHBBBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7F62F80", Offset = "0x7F61D80", VA = "0x187F62F80")]
	public bool NNMJELHFFOC(JBBGAMGOICI DMOHIIHINJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7F62ED0", Offset = "0x7F61CD0", VA = "0x187F62ED0")]
	public bool MPJDCNJAMHE(JBBGAMGOICI GDCDKMJLKDH, [Out] JBBGAMGOICI NGBLNHBBBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public BPFDLNMDCGD(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7F62C00", Offset = "0x7F61A00", VA = "0x187F62C00")]
	public static bool HEKJAOMNHLJ(BPFDLNMDCGD OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x7F629E0", Offset = "0x7F617E0", VA = "0x187F629E0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(BPFDLNMDCGD HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct EFHPLKJPPBG : IEquatable<EFHPLKJPPBG>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly EFHPLKJPPBG LABFBGKEAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public MFAFLMAFAKF OBFNPMKPAKP
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7F665F0", Offset = "0x7F653F0", VA = "0x187F665F0")]
		get
		{
			return default(MFAFLMAFAKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public JOOCMDBDCKI KEMFIGNEAMM
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7F66340", Offset = "0x7F65140", VA = "0x187F66340")]
		get
		{
			return default(JOOCMDBDCKI);
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7F668D0", Offset = "0x7F656D0", VA = "0x187F668D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public AKNHCNJGENP HCJHJANFJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7F66570", Offset = "0x7F65370", VA = "0x187F66570")]
		get
		{
			return default(AKNHCNJGENP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7F662F0", Offset = "0x7F650F0", VA = "0x187F662F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public float OJKMJFHCGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7F66740", Offset = "0x7F65540", VA = "0x187F66740")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7F66410", Offset = "0x7F65210", VA = "0x187F66410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public Vector3 BKMBGFHIDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7F66850", Offset = "0x7F65650", VA = "0x187F66850")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7F66630", Offset = "0x7F65430", VA = "0x187F66630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public float KLFPMBHEJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7F66520", Offset = "0x7F65320", VA = "0x187F66520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public PGGJHKNGOPJ FGMBINPLOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7F666B0", Offset = "0x7F654B0", VA = "0x187F666B0")]
		get
		{
			return default(PGGJHKNGOPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7F66780", Offset = "0x7F65580", VA = "0x187F66780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public bool LPEOJCIOMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7F665B0", Offset = "0x7F653B0", VA = "0x187F665B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7F66920", Offset = "0x7F65720", VA = "0x187F66920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public ELMJBIFIJEP MNFKMLBDMML
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(ELMJBIFIJEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public CDGINBCLAOG DHHINDFAFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(CDGINBCLAOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x7F666F0", Offset = "0x7F654F0", VA = "0x187F666F0")]
	public NJGPMGFPPGG NCEJFOKPAPA()
	{
		return default(NJGPMGFPPGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x7F66460", Offset = "0x7F65260", VA = "0x187F66460")]
	public GPDKOMIOIOC HMJCBNOBCPB()
	{
		return default(GPDKOMIOIOC);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7F664D0", Offset = "0x7F652D0", VA = "0x187F664D0")]
	private bool JFHNCJOBGLD(PGGJHKNGOPJ BFCGDPAMADE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7F667D0", Offset = "0x7F655D0", VA = "0x187F667D0")]
	public void NJKNCGHKBJC(PGGJHKNGOPJ BFCGDPAMADE, bool HMKCBLNCLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public EFHPLKJPPBG(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7F62C00", Offset = "0x7F61A00", VA = "0x187F62C00")]
	public static bool HEKJAOMNHLJ(EFHPLKJPPBG OAIIHELJHLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7F664B0", Offset = "0x7F652B0", VA = "0x187F664B0")]
	public static bool INFPGDPCEAI(EFHPLKJPPBG CHIPBNNCPBF, EFHPLKJPPBG MDEAIGKHMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F66380", Offset = "0x7F65180", VA = "0x187F66380", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(EFHPLKJPPBG HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct NJGPMGFPPGG : IEquatable<NJGPMGFPPGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public EFHPLKJPPBG JDLMNFBMMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(EFHPLKJPPBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public AEHNMCPGHOA JPGHHKCECDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F73AC0", Offset = "0x7F728C0", VA = "0x187F73AC0")]
		get
		{
			return default(AEHNMCPGHOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public NJGPMGFPPGG(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F62C00", Offset = "0x7F61A00", VA = "0x187F62C00")]
	public static bool HEKJAOMNHLJ(NJGPMGFPPGG OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F73A30", Offset = "0x7F72830", VA = "0x187F73A30", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(NJGPMGFPPGG HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
public readonly struct GPDKOMIOIOC : IEquatable<GPDKOMIOIOC>
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly GPDKOMIOIOC LABFBGKEAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	private HCFDIAMEJEH DINBCBGBAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C0B0", Offset = "0x7F6AEB0", VA = "0x187F6C0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public EFHPLKJPPBG JDLMNFBMMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(EFHPLKJPPBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public DDONCCKEKIL ALKHFDNABBL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F6BF80", Offset = "0x7F6AD80", VA = "0x187F6BF80")]
		get
		{
			return default(DDONCCKEKIL);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C110", Offset = "0x7F6AF10", VA = "0x187F6C110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public IEnumerable<BHFKEEBMCFO> BPDEFNEOPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7F6BA30", Offset = "0x7F6A830", VA = "0x187F6BA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public BHFKEEBMCFO ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7F6BE70", Offset = "0x7F6AC70", VA = "0x187F6BE70")]
		get
		{
			return default(BHFKEEBMCFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B660", Offset = "0x7F6A460", VA = "0x187F6B660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public ELMJBIFIJEP MNFKMLBDMML
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(ELMJBIFIJEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B810", Offset = "0x7F6A610", VA = "0x187F6B810")]
	public BHFKEEBMCFO FHLMBJOLLCJ(float3? NPJPCFKLMHD, [Optional] quaternion? LJIHJJKHDDH, [Optional] Vector3? JCGDFDLNFJA)
	{
		return default(BHFKEEBMCFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F6BC40", Offset = "0x7F6AA40", VA = "0x187F6BC40")]
	public BHFKEEBMCFO GNNCOOPODEO(int GLAOLHCPLLG, float3? NPJPCFKLMHD, [Optional] quaternion? LJIHJJKHDDH, [Optional] Vector3? JCGDFDLNFJA)
	{
		return default(BHFKEEBMCFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C230", Offset = "0x7F6B030", VA = "0x187F6C230")]
	public void OKAENFEBGHL(int GLAOLHCPLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B6F0", Offset = "0x7F6A4F0", VA = "0x187F6B6F0")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public GPDKOMIOIOC(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F62C00", Offset = "0x7F61A00", VA = "0x187F62C00")]
	public static bool HEKJAOMNHLJ(GPDKOMIOIOC OAIIHELJHLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A710", Offset = "0x7F69510", VA = "0x187F6A710")]
	public static bool PBEBFPKJKLO(GPDKOMIOIOC CHIPBNNCPBF, GPDKOMIOIOC MDEAIGKHMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B780", Offset = "0x7F6A580", VA = "0x187F6B780", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(GPDKOMIOIOC HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct BHFKEEBMCFO : IEquatable<BHFKEEBMCFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public GPDKOMIOIOC LGHDBBMOODH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F61A50", Offset = "0x7F60850", VA = "0x187F61A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public float3 EGIJBOFOPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F61AD0", Offset = "0x7F608D0", VA = "0x187F61AD0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F61970", Offset = "0x7F60770", VA = "0x187F61970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public quaternion DGDGJCDLDBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F61830", Offset = "0x7F60630", VA = "0x187F61830")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F61920", Offset = "0x7F60720", VA = "0x187F61920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public float3 FMIOEEJGLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F617C0", Offset = "0x7F605C0", VA = "0x187F617C0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F61B30", Offset = "0x7F60930", VA = "0x187F61B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public JHHNJJCPHJA FKNHKLMNPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F61A00", Offset = "0x7F60800", VA = "0x187F61A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F61820", Offset = "0x7F60620", VA = "0x187F61820")]
	public void BAMBAPFMOPF(GPDKOMIOIOC OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public BHFKEEBMCFO(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x7F61880", Offset = "0x7F60680", VA = "0x187F61880", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(BHFKEEBMCFO HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct IGFMBGJJEMD : IEquatable<IGFMBGJJEMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool OCGKEJGEDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D870", Offset = "0x7F6C670", VA = "0x187F6D870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public IGFMBGJJEMD(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D7E0", Offset = "0x7F6C5E0", VA = "0x187F6D7E0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(IGFMBGJJEMD HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct ECHMMNDBBAB : IEquatable<ECHMMNDBBAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	private NLIDPNLLMOE OKFOCDOPGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F66290", Offset = "0x7F65090", VA = "0x187F66290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public bool BCPEKCPHGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F65F60", Offset = "0x7F64D60", VA = "0x187F65F60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7F65F00", Offset = "0x7F64D00", VA = "0x187F65F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool PFFFMEFBMKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F65FB0", Offset = "0x7F64DB0", VA = "0x187F65FB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F65B40", Offset = "0x7F64940", VA = "0x187F65B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public float AAPBEONKBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7F661B0", Offset = "0x7F64FB0", VA = "0x187F661B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F65710", Offset = "0x7F64510", VA = "0x187F65710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public bool FNKHDMGMFHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F659A0", Offset = "0x7F647A0", VA = "0x187F659A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7F661F0", Offset = "0x7F64FF0", VA = "0x187F661F0")]
	public void MOKKNOMLKKJ(int EALBMDJEHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7F65890", Offset = "0x7F64690", VA = "0x187F65890")]
	public bool BNEFNPCBKDH([Out] int EALBMDJEHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7F65CC0", Offset = "0x7F64AC0", VA = "0x187F65CC0")]
	public void FCPCKNPGPBP(bool ACDEBOJGCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7F65D60", Offset = "0x7F64B60", VA = "0x187F65D60")]
	public bool FOHLOKPCBGO(EKAPLPCABAK BFCGDPAMADE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7F66130", Offset = "0x7F64F30", VA = "0x187F66130")]
	public void MGFCDHEHOPB(EKAPLPCABAK BFCGDPAMADE, bool HMKCBLNCLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F659F0", Offset = "0x7F647F0", VA = "0x187F659F0")]
	public void DIHODGBCIOC(float MJCPMKKGDBO, float CADFOEBJBIC, float EMPOGPIGJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F65DB0", Offset = "0x7F64BB0", VA = "0x187F65DB0")]
	public void GEOMFEGOJGC(float3 OOCDOGANGAA, quaternion MACGIKNICLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F66000", Offset = "0x7F64E00", VA = "0x187F66000")]
	public bool MDOALNHDIJL([Out] float3 OOCDOGANGAA, [Out] quaternion MACGIKNICLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7F65760", Offset = "0x7F64560", VA = "0x187F65760")]
	public bool BMIMCGDAAKN([Out] float GJMDNAEHAFA, [Out] float CLCGAKHMPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7F65BA0", Offset = "0x7F649A0", VA = "0x187F65BA0")]
	public void DNHFFKDIMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public ECHMMNDBBAB(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7F65C30", Offset = "0x7F64A30", VA = "0x187F65C30", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(ECHMMNDBBAB HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct ELMJBIFIJEP : IEquatable<ELMJBIFIJEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	private HCALMMNKPKA NMAFDEHHMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F67E20", Offset = "0x7F66C20", VA = "0x187F67E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public Vector3 EGIJBOFOPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F68D70", Offset = "0x7F67B70", VA = "0x187F68D70")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F68710", Offset = "0x7F67510", VA = "0x187F68710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public Quaternion DGDGJCDLDBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7F67C30", Offset = "0x7F66A30", VA = "0x187F67C30")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7F68640", Offset = "0x7F67440", VA = "0x187F68640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public Vector3 AAIGDBLJPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7F68550", Offset = "0x7F67350", VA = "0x187F68550")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x7F681E0", Offset = "0x7F66FE0", VA = "0x187F681E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public Quaternion MBEOEIHHPIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x7F68B80", Offset = "0x7F67980", VA = "0x187F68B80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x7F68900", Offset = "0x7F67700", VA = "0x187F68900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public float LAHLNKMHAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x7F67D80", Offset = "0x7F66B80", VA = "0x187F67D80")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x7F69460", Offset = "0x7F68260", VA = "0x187F69460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public float PHCDLLGNBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x7F689D0", Offset = "0x7F677D0", VA = "0x187F689D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public Matrix4x4 GEDGHOPKDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7F68B40", Offset = "0x7F67940", VA = "0x187F68B40")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public CDGINBCLAOG DHHINDFAFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(CDGINBCLAOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	private FNPHLLFAMCL ALKLOCLCPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x7F684F0", Offset = "0x7F672F0", VA = "0x187F684F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x7F67880", Offset = "0x7F66680", VA = "0x187F67880")]
	public GNLCMFNGHKL BOPHMAGHHKG()
	{
		return default(GNLCMFNGHKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7F687E0", Offset = "0x7F675E0", VA = "0x187F687E0")]
	public void GPEMIEJCLCC([Out] Matrix4x4 CNDMPNPBLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7F67FA0", Offset = "0x7F66DA0", VA = "0x187F67FA0")]
	public void EONGDBFEGBI([In] Vector3 IMPLDPKOJAO, [In] Quaternion MEPKHADFMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7F67EE0", Offset = "0x7F66CE0", VA = "0x187F67EE0")]
	public void EONGDBFEGBI([In] RigidTransform AMEPONKAELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7F68130", Offset = "0x7F66F30", VA = "0x187F68130")]
	public void FAPIGBNKGCB([Out] RigidTransform AMEPONKAELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7F67B30", Offset = "0x7F66930", VA = "0x187F67B30")]
	public void CPFKFFCONBF([In] Vector3 KCIPIFBFGIM, [In] Quaternion LOHDMKDJGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7F67A70", Offset = "0x7F66870", VA = "0x187F67A70")]
	public void CPFKFFCONBF([In] RigidTransform JGDALGAMEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7F68FC0", Offset = "0x7F67DC0", VA = "0x187F68FC0")]
	public void MOHCLHAIKII([Out] Vector3 KCIPIFBFGIM, [Out] Quaternion LOHDMKDJGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x7F690A0", Offset = "0x7F67EA0", VA = "0x187F690A0")]
	public void MOHCLHAIKII([Out] RigidTransform AMEPONKAELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x7F68400", Offset = "0x7F67200", VA = "0x187F68400")]
	public UniformTRS FODLHEFPJHL()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x7F68430", Offset = "0x7F67230", VA = "0x187F68430")]
	public void FODLHEFPJHL([Out] UniformTRS JGDALGAMEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7F69210", Offset = "0x7F68010", VA = "0x187F69210")]
	public UniformTRS NECNIAOLIAK()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7F69150", Offset = "0x7F67F50", VA = "0x187F69150")]
	public void NECNIAOLIAK([Out] UniformTRS AMEPONKAELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7F676E0", Offset = "0x7F664E0", VA = "0x187F676E0")]
	public Vector3 BMKGLNAPBHM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7F67610", Offset = "0x7F66410", VA = "0x187F67610")]
	public void BEPJNGAKAPA([In] Vector3 OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7F67980", Offset = "0x7F66780", VA = "0x187F67980")]
	public Vector3 CLDOHOALBNP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7F68EF0", Offset = "0x7F67CF0", VA = "0x187F68EF0")]
	public void LMNJBJAIAFH([In] Vector3 OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x7F682B0", Offset = "0x7F670B0", VA = "0x187F682B0")]
	public Quaternion FFPNPOCHPLG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7F68A70", Offset = "0x7F67870", VA = "0x187F68A70")]
	public void IKOFJMLILPD([In] Quaternion OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x7F69240", Offset = "0x7F68040", VA = "0x187F69240")]
	public Quaternion NIKLHKMGFGD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7F69390", Offset = "0x7F68190", VA = "0x187F69390")]
	public void NPFAAEPCHML([In] Quaternion OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7F67570", Offset = "0x7F66370", VA = "0x187F67570")]
	public float AMBLJBMGEBK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7F678D0", Offset = "0x7F666D0", VA = "0x187F678D0")]
	public void CJAJJGFKAFK(float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x7F68CD0", Offset = "0x7F67AD0", VA = "0x187F68CD0")]
	public float KAENCNHPHKI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7F677D0", Offset = "0x7F665D0", VA = "0x187F677D0")]
	public void BNPPOBNMIJG(float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x7F68E60", Offset = "0x7F67C60", VA = "0x187F68E60")]
	public Vector3 KNPDBKBOMJO([In] Vector3 MACLBEFOGKL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public ELMJBIFIJEP(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7F680A0", Offset = "0x7F66EA0", VA = "0x187F680A0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(ELMJBIFIJEP HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct PMKLPIDDCHC : IEquatable<PMKLPIDDCHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	private NGHGHNKGFEC AAEPGGHANKB
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x7F76BA0", Offset = "0x7F759A0", VA = "0x187F76BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	private JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D30", Offset = "0x7F60B30", VA = "0x187F61D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x7F76C00", Offset = "0x7F75A00", VA = "0x187F76C00")]
	public void LJCDOOEICFK(string EHKJLJIDDFP, LOBGEMGFCOO BNLNGOBLDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public PMKLPIDDCHC(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7F76B10", Offset = "0x7F75910", VA = "0x187F76B10", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(PMKLPIDDCHC HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60990", VA = "0x187F61B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct PAPCGOFKGLH : IEquatable<PAPCGOFKGLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public ECFMGHLFIHK MJHOGLOAACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x7F73E70", Offset = "0x7F72C70", VA = "0x187F73E70")]
		get
		{
			return default(ECFMGHLFIHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public PAPCGOFKGLH(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7F73DE0", Offset = "0x7F72BE0", VA = "0x187F73DE0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(PAPCGOFKGLH HBLONCAMFLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct DPKFEPGIGCA : IEquatable<DPKFEPGIGCA>
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct GCPOMPBPOOB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private JBBGAMGOICI CBBNAACPEGP;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A940", Offset = "0x7F69740", VA = "0x187F6A940")]
		public GCPOMPBPOOB(JBBGAMGOICI CBBNAACPEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A8B0", Offset = "0x7F696B0", VA = "0x187F6A8B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7F65110", Offset = "0x7F63F10", VA = "0x187F65110")]
	public GCPOMPBPOOB CFNDECDNKIB()
	{
		return default(GCPOMPBPOOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7F652F0", Offset = "0x7F640F0", VA = "0x187F652F0")]
	public OPBPLBNEDNG KOPPKEODKKE(Allocator LNMGNHHGHLL = Allocator.Temp)
	{
		return default(OPBPLBNEDNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7F64FE0", Offset = "0x7F63DE0", VA = "0x187F64FE0")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> AKEPBNJDBAJ(Allocator LNMGNHHGHLL = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7F65490", Offset = "0x7F64290", VA = "0x187F65490")]
	public NativeArray<LAFPBLKJNNP> LKHLCFDLLHJ(Allocator LNMGNHHGHLL = Allocator.Temp)
	{
		return default(NativeArray<LAFPBLKJNNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7F653E0", Offset = "0x7F641E0", VA = "0x187F653E0")]
	public NativeArray<LAFPBLKJNNP> LDPDCBBLLDG(Allocator LNMGNHHGHLL = Allocator.Temp)
	{
		return default(NativeArray<LAFPBLKJNNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7F65230", Offset = "0x7F64030", VA = "0x187F65230")]
	public LHGPEBNJFMN KCHNLGDAMHA(Allocator LNMGNHHGHLL = Allocator.Temp)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7F65540", Offset = "0x7F64340", VA = "0x187F65540")]
	public LHGPEBNJFMN MONPGOJMCEM(Allocator LNMGNHHGHLL = Allocator.Temp)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7F65600", Offset = "0x7F64400", VA = "0x187F65600")]
	public LHGPEBNJFMN NALKDDCJOPJ(Allocator LNMGNHHGHLL = Allocator.Temp)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public DPKFEPGIGCA(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7F651A0", Offset = "0x7F63FA0", VA = "0x187F651A0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(DPKFEPGIGCA HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7F656C0", Offset = "0x7F644C0", VA = "0x187F656C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct IELMAKCMBOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int OAGELHPIICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int FLIMOLGBHAI;
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct NIKJMMKGBCK : IEquatable<NIKJMMKGBCK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public DPKFEPGIGCA FIGIKCCGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(DPKFEPGIGCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public FAOKGLAHGEO IBGOAACNDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(FAOKGLAHGEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public PAPCGOFKGLH LKIAELHECNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(PAPCGOFKGLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7F72F20", Offset = "0x7F71D20", VA = "0x187F72F20")]
	public bool OCBNIKDHJKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7F72DA0", Offset = "0x7F71BA0", VA = "0x187F72DA0")]
	public bool KBLBAEGKICC([Out] Exception ANMGGEBBMLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public NIKJMMKGBCK(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static JBBGAMGOICI HEKJAOMNHLJ(NIKJMMKGBCK OAIIHELJHLG)
	{
		return default(JBBGAMGOICI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7F72D10", Offset = "0x7F71B10", VA = "0x187F72D10", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(NIKJMMKGBCK HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7F656C0", Offset = "0x7F644C0", VA = "0x187F656C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct NEGFDLNBPJM : IDisposable, IEquatable<NEGFDLNBPJM>
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public static readonly NEGFDLNBPJM LABFBGKEAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public NIKJMMKGBCK IDKGDPEDCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(NIKJMMKGBCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public DPKFEPGIGCA FIGIKCCGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(DPKFEPGIGCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7F72B40", Offset = "0x7F71940", VA = "0x187F72B40")]
	public void PGFEIEPGMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7F729E0", Offset = "0x7F717E0", VA = "0x187F729E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public NEGFDLNBPJM(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7F72AB0", Offset = "0x7F718B0", VA = "0x187F72AB0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "5")]
	public bool Equals(NEGFDLNBPJM HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7F72BC0", Offset = "0x7F719C0", VA = "0x187F72BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct FAOKGLAHGEO : IEquatable<FAOKGLAHGEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public bool PEIDHFEEFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x7F69850", Offset = "0x7F68650", VA = "0x187F69850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	public FAOKGLAHGEO(JBBGAMGOICI CBBNAACPEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7F619D0", Offset = "0x7F607D0", VA = "0x187F619D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7F698E0", Offset = "0x7F686E0", VA = "0x187F698E0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7F61910", Offset = "0x7F60710", VA = "0x187F61910", Slot = "4")]
	public bool Equals(FAOKGLAHGEO HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7F656C0", Offset = "0x7F644C0", VA = "0x187F656C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class KDFFNGNCONF
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private struct IKEALMLEIGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Guid PDFBNFKDLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public BHFLOIKKPFN FPCCEDPDMGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private struct BHFLOIKKPFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int OAIIHELJHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int NIEDOFANOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int KMGGPPOPAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int HAMOBFLOKPG;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x7F61BB0", Offset = "0x7F609B0", VA = "0x187F61BB0")]
		public bool JILFPLPJAAL([Out] LAFPBLKJNNP LEBLPDLNOOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7F61C50", Offset = "0x7F60A50", VA = "0x187F61C50")]
		public BHFLOIKKPFN(LAFPBLKJNNP LEBLPDLNOOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F350", Offset = "0x7F6E150", VA = "0x187F6F350")]
	public static Guid OJLKHMICGNH(this LAFPBLKJNNP LEBLPDLNOOO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F330", Offset = "0x7F6E130", VA = "0x187F6F330")]
	public static bool COANDFNINEC(this Guid PDFBNFKDLAH, [Out] LAFPBLKJNNP LEBLPDLNOOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal static class EOFODEMGKBA
{
	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x7F696B0", Offset = "0x7F684B0", VA = "0x187F696B0")]
	public static JHHFKKLJKBJ KBGAALBLMOG(this JBBGAMGOICI FONJFDCCINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x7F69740", Offset = "0x7F68540", VA = "0x187F69740")]
	public static KEIHHBEOEPM ODALAFALJKF(this JBBGAMGOICI FONJFDCCINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x7F69620", Offset = "0x7F68420", VA = "0x187F69620")]
	public static EntityManager CHBLGEAMDJL(this JBBGAMGOICI FONJFDCCINO)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x37879D0", Offset = "0x37867D0", VA = "0x1837879D0")]
	internal static bool OMIHIAFNLEE<T>(this JBBGAMGOICI FONJFDCCINO, bool HMKCBLNCLGO) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x7F69510", Offset = "0x7F68310", VA = "0x187F69510")]
	public static bool AOMDDCNJKIE(this JBBGAMGOICI FONJFDCCINO, JALOGBPPALL FEMKAJANBPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x3784780", Offset = "0x3783580", VA = "0x183784780")]
	public static bool LJAIMIPPDNK<T>(this JBBGAMGOICI FONJFDCCINO) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x3784600", Offset = "0x3783400", VA = "0x183784600")]
	public static bool FLINNIOIEIJ<T>(this JBBGAMGOICI FONJFDCCINO) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x3782760", Offset = "0x3781560", VA = "0x183782760")]
	[IPAKCAJGJKO]
	public static T CKGAKLHMGAI<T>(this JBBGAMGOICI FONJFDCCINO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x3784FA0", Offset = "0x3783DA0", VA = "0x183784FA0")]
	[IPAKCAJGJKO]
	public static T MLDCOADOFOI<T>(this JBBGAMGOICI FONJFDCCINO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x37844C0", Offset = "0x37832C0", VA = "0x1837844C0")]
	public static bool FJLHLKDFICH<T>(this JBBGAMGOICI FONJFDCCINO, [Out] T OAIIHELJHLG) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x37846B0", Offset = "0x37834B0", VA = "0x1837846B0")]
	public static T GEHHIAEFKIF<T>(this JBBGAMGOICI FONJFDCCINO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x3784420", Offset = "0x3783220", VA = "0x183784420")]
	public static T FIPKAGGJELH<T>(this JBBGAMGOICI FONJFDCCINO) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal static class KCBDGPDNKIP
{
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DefaultMember("Item")]
public struct OPBPLBNEDNG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private LHGPEBNJFMN KHJEADFMOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> KOFOKOHGFKE;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5D21E90", Offset = "0x5D20C90", VA = "0x185D21E90")]
	public OPBPLBNEDNG(LHGPEBNJFMN KHJEADFMOJM, NativeArray<EntityRemapUtility.EntityRemapInfo> KOFOKOHGFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7F73D50", Offset = "0x7F72B50", VA = "0x187F73D50")]
	public LocalId MANBEHHHOPM(LocalId GLEBGNJJOHG)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x7F73D90", Offset = "0x7F72B90", VA = "0x187F73D90")]
	public LocalId MANBEHHHOPM(int GLAOLHCPLLG)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x7F73CE0", Offset = "0x7F72AE0", VA = "0x187F73CE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IJPNLFKGMFM
{
	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGCOOCDOHGM(World KBBMPPHMANJ, NativeParallelHashSet<FixedString64Bytes> DNAFLFDNMHP);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PNAPNCMOKDC
{
	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DLFOEPINMIM(JBBGAMGOICI HMMCMNPLNJA, [Out] uint FONJFDCCINO);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IEKFJIILENF(JBBGAMGOICI HMMCMNPLNJA, [Out] uint FONJFDCCINO);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNHIKCAEHMP(JBBGAMGOICI HMMCMNPLNJA, uint FONJFDCCINO);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FONMFFIGBMM(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string FANGHBGIDND(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KHFKFFBFMIH(JBBGAMGOICI HMMCMNPLNJA, string FONJFDCCINO);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LNODMBJCEGM(JBBGAMGOICI HMMCMNPLNJA, [Out] string GBJJKAOHDFL);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HEOOEAMLEFK(JBBGAMGOICI HMMCMNPLNJA, string GBJJKAOHDFL);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JCIKEDDHEJM
{
	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	Guid AGHDDBIKDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	Guid HGPIPEFHPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OLMCICJKJBO(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KGNEIGHKKBN(GALEOJBODPG GLEBGNJJOHG);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid JOODMEABIFL(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JMOKDOJNOKE(JBBGAMGOICI CBBNAACPEGP, Guid HLGNHFCFAMG);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NALCFGFOLAG(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task HAAJJBMKDGI(JBBGAMGOICI OBOFPKCKJOC, JBBGAMGOICI BOGJJGPKPIJ);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CMKAGIDOBOG(JBBGAMGOICI CBBNAACPEGP, LAFPBLKJNNP LKAPFIIDHFA);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IJAGHGAAJKD
{
	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	Guid AGHDDBIKDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EINOEFAJLPL(NativeList<Guid> OKPMAFMPEBO, NativeList<Guid> MMKAKKPJHEB, NativeList<FixedString64Bytes> KOFDJNCOMHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CIFJNIMAPGE
{
	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LHGPEBNJFMN BOLIOELFGLK(Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LHGPEBNJFMN FBMLAGEJELF(Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CDBKBDDPJJK(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DIJBJBBOEMF(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LEFEAJLODBN(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FMECFLNOEGK(JBBGAMGOICI HMMCMNPLNJA, int FAPLIEIFOHC);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JBBGAMGOICI GLNFAIHAOIM(JBBGAMGOICI CMCBMKDECMI);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CPLNOEJBKPB(LHGPEBNJFMN DGLKBCCIOFF, bool FNIDOKOJHDB);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AEJGLHMJBFI(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PFKCEMNECIH(JBBGAMGOICI HMMCMNPLNJA, bool HPIEBLIJMAL);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int OKDDMKAKGGL();

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LAHCBOCAMIA(JBBGAMGOICI CBBNAACPEGP);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OOEFJPHJGKF
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<JBBGAMGOICI, JBBGAMGOICI> KNEDFCIMPMH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<JBBGAMGOICI, JBBGAMGOICI> EBMGPFKFGOG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<JBBGAMGOICI, JBBGAMGOICI, JBBGAMGOICI> JEMLILEPGHK;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<JBBGAMGOICI> LJGFECELCIC;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LLJJFHKJKAI(JBBGAMGOICI CBBNAACPEGP, JBBGAMGOICI EDHDEKEEFBP);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JBBGAMGOICI MFNGJKJOHNE(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LHGPEBNJFMN EGHNBAKMGEN(JBBGAMGOICI CBBNAACPEGP, Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JBBGAMGOICI APEDOFNPNCN(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EPMHHNKCDFP(JBBGAMGOICI CBBNAACPEGP, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BLEMPAMKKKF(JBBGAMGOICI CBBNAACPEGP, float HNMJCJFPGDA);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NMFAOCIBDIK(JBBGAMGOICI CBBNAACPEGP, [Out] JBBGAMGOICI BOGJJGPKPIJ);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NAIODLCEAKO(JBBGAMGOICI CBBNAACPEGP, [Out] RigidTransform EFGGENFHKEO);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 BMMAFBBCNNI(ELBDIAFLPNK FOGLBBODFNF);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion FCDNJDMPLMN(ELBDIAFLPNK FOGLBBODFNF);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class OLHCMKCPFIO
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PMINGLOBABF
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	object DFJOFDLIJFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ABFMHAOJLEC
{
	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBGLAONEAOP(JBBGAMGOICI GLEBGNJJOHG, ABKBGPGDIAJ NJCLLFFIHGK);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFFNIPFGACO(ABKBGPGDIAJ NJCLLFFIHGK);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NLPEJJGIEOO(JBBGAMGOICI CBBNAACPEGP, [Out] ABKBGPGDIAJ LPJIILEFMEC);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[Flags]
public enum GCPKNICDDMA
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public readonly struct CPEDDMDPOPO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly string IHGFMOMOADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly T LDGCNLHOBMI;

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6720A90", Offset = "0x671F890", VA = "0x186720A90")]
	public CPEDDMDPOPO(T LDGCNLHOBMI, [Optional][CallerMemberName] string IHGFMOMOADA)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly CPEDDMDPOPO<int> OLNJBICOLMO;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly CPEDDMDPOPO<int> JHBOIONBLHG;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly CPEDDMDPOPO<int> PHJBLFONAGB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public enum JLMKEELJKIJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class GCBDNLNEENF
{
	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x1286760", Offset = "0x1285560", VA = "0x181286760")]
	public static bool FJFCIPOMCNN(this JLMKEELJKIJ JNOIIIFBOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1687040", Offset = "0x1685E40", VA = "0x181687040")]
	public static bool FKMEJBNFPPD(this JLMKEELJKIJ JNOIIIFBOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x2E92110", Offset = "0x2E90F10", VA = "0x182E92110")]
	public static bool JAMKFEOLFOK(this JLMKEELJKIJ JNOIIIFBOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1286750", Offset = "0x1285550", VA = "0x181286750")]
	public static bool COCFOCBJOOH(this JLMKEELJKIJ JNOIIIFBOLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DOJMAGJMJKJ
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum CADJFDAMEDO
	{
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum FILJCPAKFGG
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	CADJFDAMEDO IMHFNCGBAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	bool NPJNEKIAEHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	bool JOJNIEGFDNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	FILJCPAKFGG ANNMMGBIFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.Application)]
public interface FCAAHOBIHDB
{
	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	JLMKEELJKIJ CIOMFBPMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	JLMKEELJKIJ LAGKNEOGNDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	JLMKEELJKIJ OOPNMCGPEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	JLMKEELJKIJ AHIDGMOAFFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	JLMKEELJKIJ AFCBHJGKILA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	JLMKEELJKIJ EIBPIBJPDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	JLMKEELJKIJ DEKBIMJAEAE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	JLMKEELJKIJ IEPPLDJPCOP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	JLMKEELJKIJ JLKGHDAHHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	JLMKEELJKIJ EDPDPBJMKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	JLMKEELJKIJ ELBBFGGAMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	JLMKEELJKIJ LEKHOPKOCGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	JLMKEELJKIJ DEEOHLPHAHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	JLMKEELJKIJ ELJJPIHEEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	JLMKEELJKIJ KCIPELJPEEH
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	JLMKEELJKIJ NMPCGIAPCIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	JLMKEELJKIJ JNMINCKINEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	JLMKEELJKIJ MFGKMJEPDGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	JLMKEELJKIJ NODCMHIFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	JLMKEELJKIJ NCGFDIJMFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MBFFDPKOBBN(CPEDDMDPOPO<int> EKMDFFAGMPN);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HKNJHJGCLNN
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event HMEKNJEAEKD.KPLNPGNPHBN AGMJPDMHPNE;

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JBBGAMGOICI CKEHDCMADAJ(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LHGPEBNJFMN ENOBDEGEJDE(Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JHHNJJCPHJA JCFBGCABNPD(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JNIMMIHFBIA(IEnumerable<JBBGAMGOICI> IBEBEJEKOJL);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JHHNJJCPHJA PGAGGPAMDLH(JBBGAMGOICI BOGJJGPKPIJ, JBBGAMGOICI KHJEADFMOJM, bool MMPPAHJIMBP, JBBGAMGOICI GDCDKMJLKDH);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JBBGAMGOICI DLKCDFLPOJC(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GPAFCMPBBMA(JBBGAMGOICI CBBNAACPEGP, JBBGAMGOICI BOGJJGPKPIJ, bool GDHODLLCPLI = false);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DMCFLGMLILI(JBBGAMGOICI CBBNAACPEGP, JBBGAMGOICI BOGJJGPKPIJ);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KHLBGLBCGFI(JBBGAMGOICI BCOFONBIPNI, JBBGAMGOICI IGIBDFKNIPN);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	LHGPEBNJFMN DKNFPAHCBBA(JBBGAMGOICI NIFNCNHCJID);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KKADNAECAMC(JBBGAMGOICI CBBNAACPEGP, JBBGAMGOICI HNKEGPCENKG);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LHGPEBNJFMN CKOBMEJLDEA(LHGPEBNJFMN PLBDAGCMACJ, GCPKNICDDMA KKBDAOHAGLC, Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool HGLAAEAKLPG(JBBGAMGOICI CBBNAACPEGP, JBBGAMGOICI GDJNLDEHAHA);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JBBGAMGOICI EEBBCFGPINF(JBBGAMGOICI GDCDKMJLKDH, JBBGAMGOICI GIPGHJMOMCK);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool CIBNGLKMEBD(JBBGAMGOICI GDCDKMJLKDH, JBBGAMGOICI GIPGHJMOMCK, [Out] JBBGAMGOICI OCILBCBIPPJ);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JBBGAMGOICI PHMAKCDGGCN(JBBGAMGOICI[] DGLKBCCIOFF);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	JBBGAMGOICI LAHEDCBMJLD(JBBGAMGOICI CBBNAACPEGP, uint HFAFOICMKML);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class MHONCAPGECM
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F727D0", Offset = "0x7F715D0", VA = "0x187F727D0")]
	public static bool LFGLGHMNANE(this HKNJHJGCLNN JHIOCMNHFMC, JBBGAMGOICI CBBNAACPEGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F72480", Offset = "0x7F71280", VA = "0x187F72480")]
	public static LHGPEBNJFMN CKOBMEJLDEA(this HKNJHJGCLNN BMACFGNFKCL, JBBGAMGOICI CBBNAACPEGP, GCPKNICDDMA KKBDAOHAGLC, Allocator LNMGNHHGHLL)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F72750", Offset = "0x7F71550", VA = "0x187F72750")]
	public static LHGPEBNJFMN GLHMKKJLHKI(this HKNJHJGCLNN BMACFGNFKCL, JBBGAMGOICI CBBNAACPEGP, Allocator LNMGNHHGHLL)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x7F729A0", Offset = "0x7F717A0", VA = "0x187F729A0")]
	public static LHGPEBNJFMN MOCEMBJEBCG(this HKNJHJGCLNN BMACFGNFKCL, JBBGAMGOICI CBBNAACPEGP, Allocator LNMGNHHGHLL)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x7F72440", Offset = "0x7F71240", VA = "0x187F72440")]
	public static LHGPEBNJFMN CHKJLHALLGO(this HKNJHJGCLNN BMACFGNFKCL, JBBGAMGOICI CBBNAACPEGP, Allocator LNMGNHHGHLL)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x7F72790", Offset = "0x7F71590", VA = "0x187F72790")]
	public static LHGPEBNJFMN HEHGBDMMJOL(this HKNJHJGCLNN BMACFGNFKCL, JBBGAMGOICI CBBNAACPEGP, Allocator LNMGNHHGHLL)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x7F72710", Offset = "0x7F71510", VA = "0x187F72710")]
	public static LHGPEBNJFMN DFGLLDALHHH(this HKNJHJGCLNN BMACFGNFKCL, JBBGAMGOICI CBBNAACPEGP, Allocator LNMGNHHGHLL)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x7F72840", Offset = "0x7F71640", VA = "0x187F72840")]
	public static LHGPEBNJFMN LKNMNIMIBOG(this HKNJHJGCLNN BMACFGNFKCL, JBBGAMGOICI CBBNAACPEGP, Allocator LNMGNHHGHLL)
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x7F72880", Offset = "0x7F71680", VA = "0x187F72880")]
	public static LHGPEBNJFMN LKNMNIMIBOG(this HKNJHJGCLNN BMACFGNFKCL, LHGPEBNJFMN CBBNAACPEGP, Allocator LNMGNHHGHLL)
	{
		return default(LHGPEBNJFMN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BFIDPBDMGHC
{
	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FDGKKMHEELO IDKJDGCLBGF(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKJDIDIJDHP(JBBGAMGOICI HMMCMNPLNJA, FDGKKMHEELO GGOIAPENPKO);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CGKDDGFCIBG(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DIMAKLANGMC(JBBGAMGOICI HMMCMNPLNJA, bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CONCPCFABOF<string> NHHLKNDBIJE(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJNGPBMGFNK(JBBGAMGOICI HMMCMNPLNJA, CONCPCFABOF<string> FIAMKOAPKNO);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CONCPCFABOF<string> ANBBEPNIBJN(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void INAAJPPFIGF(JBBGAMGOICI HMMCMNPLNJA, CONCPCFABOF<string> FIAMKOAPKNO);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CONCPCFABOF<string> JONMBGHCJHG(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OFHIPLOGEJD(JBBGAMGOICI HMMCMNPLNJA, CONCPCFABOF<string> FIAMKOAPKNO);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CONCPCFABOF<string> FGKDNOIBCNG(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BEAEHLPBHND(JBBGAMGOICI HMMCMNPLNJA, CONCPCFABOF<string> FIAMKOAPKNO);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NABECDMDDBL(JBBGAMGOICI HMMCMNPLNJA, JBBGAMGOICI ENPELEHFGFF);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DLELGCAFMOF
{
	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x7F64CA0", Offset = "0x7F63AA0", VA = "0x187F64CA0", Slot = "0")]
	Task<NIKJMMKGBCK> OBJGJEMOAMO(DMDGHBDFKMP HIDBMDJLPPO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "1")]
	void NJCIJKHFMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ACCMOKPPGII
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event HMEKNJEAEKD.KPLNPGNPHBN AGMJPDMHPNE;

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JBBGAMGOICI DLKCDFLPOJC(JBBGAMGOICI OBOFPKCKJOC);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<JBBGAMGOICI> HCAIPHOIJDI();

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<JBBGAMGOICI> HDOPIIEEMDK(JBBGAMGOICI BOGJJGPKPIJ);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CDKBNOGEEBD(JBBGAMGOICI IMDGCCNEALB, JBBGAMGOICI EPGELMEBKPB, [Out] JHHNJJCPHJA EGCDHPKPBCK);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DIMLMEKDGHP(JBBGAMGOICI IMDGCCNEALB, JBBGAMGOICI PANOGIGCFBN, [Out] JHHNJJCPHJA EGCDHPKPBCK);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JKKOAHKOHKN(JBBGAMGOICI IMDGCCNEALB);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DMCFLGMLILI(JBBGAMGOICI OJKHOPBHKIK, JBBGAMGOICI JDMAEDJOOLD);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JHHNJJCPHJA MMLJMPHCEJE(JBBGAMGOICI CBBNAACPEGP);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BAFJGOHFPIO
{
	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	bool OELJPKFPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	bool OPKNPJEIKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	bool EBBEMCNBEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MHJICGEMLKJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HCMBMNODLCH
{
	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEDIJHBOHKB(JBBGAMGOICI CBBNAACPEGP, JALOGBPPALL FEMKAJANBPA);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIPDLEPBOAD(JBBGAMGOICI CBBNAACPEGP, JALOGBPPALL FEMKAJANBPA);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DKOEOMOIFKP
{
	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ONLKACENELK([In] float3 NECPJOOPKDH, [In] float3 MACLBEFOGKL, float HBKDKLDLCIL, [Out] AGNHCPADDEK FBNLODNBCOD, [Out] JBBGAMGOICI GLOHLOECDHC);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JAGBPDOAKMH([In] float3 NECPJOOPKDH, float MEHMJKKFJEH, List<JBBGAMGOICI> DGLKBCCIOFF);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int IIFLMCNIEIA(Plane[] IMGBHPGNDJL, float3 NECPJOOPKDH, float3 HMOGDLHACOC, quaternion LJIHJJKHDDH, List<JBBGAMGOICI> DGLKBCCIOFF);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AEAMFAEFCOF
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONLKACENELK([In] NativeArray<Entity> KKDBICIHPCE, [In] float3 NECPJOOPKDH, [In] float3 MACLBEFOGKL, [In] NativeArray<AGNHCPADDEK> DHKLOEBCAEB);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> JAGBPDOAKMH([In] NativeArray<Entity> KKDBICIHPCE, [In] float3 NECPJOOPKDH, float MEHMJKKFJEH);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> IIFLMCNIEIA([In] NativeArray<Entity> KKDBICIHPCE, [In] NativeArray<float4> FOOHLKHBDKH);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct IMMEDEAMBHM : OBLKINNOMIA, IEquatable<IMMEDEAMBHM>
{
	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public int KBDABDGGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public int JCCDJKBJEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6640", Offset = "0x2EB5440", VA = "0x182EB6640", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F2F0", Offset = "0x6F9E0F0", VA = "0x186F9F2F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DE60", Offset = "0x7F6CC60", VA = "0x187F6DE60", Slot = "8")]
	public bool Equals(IMMEDEAMBHM HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DEB0", Offset = "0x7F6CCB0", VA = "0x187F6DEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct AGNHCPADDEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public float LBNEPEMBBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public float3 KODPDAPHGHG;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LOPGOHNFDMA
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FNPHLLFAMCL
{
	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	AFKBECNHLIC LOANCINFKAI
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<LHGPEBNJFMN, NativeArray<RRObjectPrefabData>> IGDGDHHHOPF;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<LHGPEBNJFMN> GEDEPFCEKJH;

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LHGPEBNJFMN BFMCKOCMJKL();

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NNCGLECLGPE GDBANPHNPGE(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData IBFBMDHEEBG(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KEBMELMMDHB(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GALEOJBODPG NHCJLEEIJBN(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BOCHKHIGLOL(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OMAELHPOPFL(JBBGAMGOICI CBBNAACPEGP, [Out] Transform MAAFBDAKBJA);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JBBGAMGOICI JDHHGCJGKCD(LAFPBLKJNNP LEBLPDLNOOO);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BOHCIKEFAGK(LAFPBLKJNNP LEBLPDLNOOO, [Out] JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LAFPBLKJNNP KMNAKCGEKLE(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "16")]
	LHGPEBNJFMN JDHHGCJGKCD(NativeArray<LAFPBLKJNNP> LEBLPDLNOOO, Allocator LNMGNHHGHLL, bool OJEAFIKAOFL = true);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CNEOCDKBABH(RRObjectPrefabData BMCGNJAOJFL, NativeArray<Entity> KKDBICIHPCE);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool DHBHNMBCIMG(NativeArray<NEHHBNAMGFO> AFBEAIPPNGC, NativeArray<LAFPBLKJNNP> GBGHGAKGHAG, NativeArray<Entity> MGOFCJIKJOL, CONCPCFABOF<MKENNIBEGFF> KMEOGMPNJGM);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	GALEOJBODPG DAMAAKPLKMC();

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	GALEOJBODPG DHHBOCOGBAA(RRObjectPrefabData BMCGNJAOJFL, [Optional] IKHGLHKGDCI AHNOGPGBINF);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	GOFCJOAKJOK JPNHCLDMDII();

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	GPDKOMIOIOC BPKNCEMPAOD();

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	NJGPMGFPPGG KOOLPNBGPBI(AEHNMCPGHOA OIPPALBLFAC);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AFMAJEFJMND(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool FMCDAIDJNMO(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "26")]
	LHGPEBNJFMN FONELMKEECG(LHGPEBNJFMN DLBAAAOMAEL, Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool APHGFBFFFFI(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool NLMJGFECCLC(JBBGAMGOICI CBBNAACPEGP, ComponentTypes CJNKCIJAONA);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "29")]
	JBBGAMGOICI HODCGBHLCNI(Transform MAAFBDAKBJA);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class KKHEHCHPCAK
{
	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FA20", Offset = "0x7F6E820", VA = "0x187F6FA20")]
	internal static JBBGAMGOICI PFNEIEMDKLF(this Entity OFJKELIPJNP, FNPHLLFAMCL BNLNGOBLDJO)
	{
		return default(JBBGAMGOICI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F590", Offset = "0x7F6E390", VA = "0x187F6F590")]
	public static GALEOJBODPG FOPDCOJFMPE(this FNPHLLFAMCL BNLNGOBLDJO, LocalId CBBNAACPEGP)
	{
		return default(GALEOJBODPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F5A0", Offset = "0x7F6E3A0", VA = "0x187F6F5A0")]
	public static JBBGAMGOICI JDHHGCJGKCD(this FNPHLLFAMCL BNLNGOBLDJO, LocalId CBBNAACPEGP)
	{
		return default(JBBGAMGOICI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F9B0", Offset = "0x7F6E7B0", VA = "0x187F6F9B0")]
	public static LAFPBLKJNNP KMNAKCGEKLE(this FNPHLLFAMCL BNLNGOBLDJO, LocalId CBBNAACPEGP)
	{
		return default(LAFPBLKJNNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FAD0", Offset = "0x7F6E8D0", VA = "0x187F6FAD0")]
	public static GOFCJOAKJOK PHCPKPJKHLI(this FNPHLLFAMCL BNLNGOBLDJO, RigidTransform JGDALGAMEBL)
	{
		return default(GOFCJOAKJOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F800", Offset = "0x7F6E600", VA = "0x187F6F800")]
	public static NJGPMGFPPGG JNLNMOAIBND(this FNPHLLFAMCL BNLNGOBLDJO, AEHNMCPGHOA MNGJGHJDPLA, RigidTransform JGDALGAMEBL)
	{
		return default(NJGPMGFPPGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F650", Offset = "0x7F6E450", VA = "0x187F6F650")]
	public static GPDKOMIOIOC JHFPJFBDHJO(this FNPHLLFAMCL BNLNGOBLDJO, RigidTransform JGDALGAMEBL)
	{
		return default(GPDKOMIOIOC);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F560", Offset = "0x7F6E360", VA = "0x187F6F560")]
	private static void BDBJBDEHHNA(GALEOJBODPG CGEIMCMCMFC, RigidTransform JGDALGAMEBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal interface LDJOFFOIHED
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BHPMOPIBKNJ
{
	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	bool GFGOCIJHOME
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	JBBGAMGOICI FOAKHMLNOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	GALEOJBODPG BJGICGDECHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event KBGJEIPDBMD OKCDKOANKFG;

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JBBGAMGOICI EEBBCFGPINF(JBBGAMGOICI GDCDKMJLKDH, JBBGAMGOICI GIPGHJMOMCK);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CIBNGLKMEBD(JBBGAMGOICI GDCDKMJLKDH, JBBGAMGOICI GIPGHJMOMCK, [Out] JBBGAMGOICI OCILBCBIPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JKFLMMOEAOD();

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IJNHFEIMACG();

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DEHHAKPEEGE(JBBGAMGOICI GDCDKMJLKDH);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IOAOALGAKIK(JBBGAMGOICI GDCDKMJLKDH);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public delegate void KBGJEIPDBMD(GALEOJBODPG JCPLFPCNOJN, GALEOJBODPG HDPPHLFMLLF);
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class JINABOCEOKI
{
	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E950", Offset = "0x7F6D750", VA = "0x187F6E950")]
	public static bool HFBLNEFOLOF(this BHPMOPIBKNJ DJINGFJDDFE, GALEOJBODPG GDCDKMJLKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E9A0", Offset = "0x7F6D7A0", VA = "0x187F6E9A0")]
	public static bool JBGPNMBFDGF(this BHPMOPIBKNJ DJINGFJDDFE, JBBGAMGOICI GDCDKMJLKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EA80", Offset = "0x7F6D880", VA = "0x187F6EA80")]
	public static bool PJNLDMLFAIO(this BHPMOPIBKNJ DJINGFJDDFE, JBBGAMGOICI GDCDKMJLKDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NIBPOPLEHKN
{
	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HALCKNIOEJK(NativeList<RRObjectPrefabData> GELFPJOHPMH);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HIHFOBNJGGG
{
	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBIMHGAEFFO(GALEOJBODPG CGEIMCMCMFC, FMPIAKEFFMI OEFNLALAAAN, List<GALEOJBODPG> NPDCNNDIODA);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int DBHPNIIBHDC(GALEOJBODPG CGEIMCMCMFC, FMPIAKEFFMI OEFNLALAAAN);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKHLOGPCOLE(GALEOJBODPG CGEIMCMCMFC, List<GALEOJBODPG> NPDCNNDIODA);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DAHONCDEKIP(GALEOJBODPG EALBMDJEHIA, GALEOJBODPG GDCDKMJLKDH, FMPIAKEFFMI OEFNLALAAAN);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GALEOJBODPG GJHKJDKCMFG(GALEOJBODPG EALBMDJEHIA, int GLAOLHCPLLG, FMPIAKEFFMI OEFNLALAAAN);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGKJABJONCI(GALEOJBODPG EALBMDJEHIA, GALEOJBODPG GDCDKMJLKDH, FMPIAKEFFMI OEFNLALAAAN);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IPJJBGMCLEN(GALEOJBODPG EALBMDJEHIA, GALEOJBODPG GDCDKMJLKDH, FMPIAKEFFMI OEFNLALAAAN);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LCMCGGGKDKM(GALEOJBODPG EALBMDJEHIA, FMPIAKEFFMI OEFNLALAAAN);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KLEEPMBHGMB(GALEOJBODPG EALBMDJEHIA, GALEOJBODPG GDCDKMJLKDH, FMPIAKEFFMI OEFNLALAAAN);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void INMGMEJEHHK(Entity EALBMDJEHIA, Entity GDCDKMJLKDH, FMPIAKEFFMI OEFNLALAAAN);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PPICHKKKDPL(Entity EALBMDJEHIA, FMPIAKEFFMI OEFNLALAAAN);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OPPOOOPODLB(GALEOJBODPG GDCDKMJLKDH, FMPIAKEFFMI OEFNLALAAAN);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EGNNCJLCDLA
{
	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	PAPCGOFKGLH FEAOJBIHBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ECFMGHLFIHK MJDAOLLIEEN(PAPCGOFKGLH EEMDMFPCGLE);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PAPCGOFKGLH OABICNKDOKN();

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PAPCGOFKGLH OEHEIMMPFOK();
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JGNJPENDGFP
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MEILFCIAGAN(JBBGAMGOICI GDCDKMJLKDH, JBBGAMGOICI NGBLNHBBBCB);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NNMJELHFFOC(JBBGAMGOICI GDCDKMJLKDH, JBBGAMGOICI DMOHIIHINJE);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MPJDCNJAMHE(JBBGAMGOICI GDCDKMJLKDH, [Out] JBBGAMGOICI LCDDEEGLHEP);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JEBBIMDPKFK
{
	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOBFEKIICJM(JBBGAMGOICI NIFNCNHCJID, bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEILCAGMCKC(JBBGAMGOICI NIFNCNHCJID, bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFEAKHIKJPK(JBBGAMGOICI NIFNCNHCJID, int OAIIHELJHLG);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HCFDIAMEJEH
{
	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<JBBGAMGOICI> GPHAEDFJLJH(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JBBGAMGOICI LMAJPCLABFB(JBBGAMGOICI CBBNAACPEGP, int GLAOLHCPLLG);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int AOACNAKCGEP(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DDONCCKEKIL PMOMFCFKCEK(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ANNKKOPMFOL(JBBGAMGOICI CBBNAACPEGP, DDONCCKEKIL CNCKIIIBBGO);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JBBGAMGOICI PNJPHKOMJCJ(JBBGAMGOICI CBBNAACPEGP, [Optional] float3? NPJPCFKLMHD, [Optional] quaternion? LJIHJJKHDDH, [Optional] float3? JCGDFDLNFJA);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JBBGAMGOICI MAMGMPNGGME(JBBGAMGOICI CBBNAACPEGP, int GLAOLHCPLLG, [Optional] float3? NPJPCFKLMHD, [Optional] quaternion? LJIHJJKHDDH, [Optional] float3? JCGDFDLNFJA);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GDGCJJKBKOA(JBBGAMGOICI CBBNAACPEGP, int GLAOLHCPLLG);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AMJDBDOOLFF(JBBGAMGOICI CBBNAACPEGP);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ABBNKIPKPLJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AJBBBDFMJKH
{
	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	bool NHJAOFIDMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPHCLLHPBDN();

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKKAAHNGJBH();

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFDGDNOJLKH();

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDLBAJIPAHF();

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CHDPHPMKPKF();

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DGOLADKKCMM();

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EMOGCMFMJPB();

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OGPECILCHIG();

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IIKAEBAHMFB();

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BGIPLGGADJO();

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DJOGEJLEJLK();

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AHJNKCLNDAM();
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NLIDPNLLMOE
{
	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNEFNPCBKDH(JBBGAMGOICI GDCDKMJLKDH, [Out] int EALBMDJEHIA);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOKKNOMLKKJ(JBBGAMGOICI GDCDKMJLKDH, int EALBMDJEHIA);

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCPCKNPGPBP(JBBGAMGOICI GDCDKMJLKDH, bool ACDEBOJGCOL);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DIHODGBCIOC(JBBGAMGOICI GDCDKMJLKDH, float MJCPMKKGDBO, float CADFOEBJBIC, float EMPOGPIGJHL);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BMIMCGDAAKN(JBBGAMGOICI CBBNAACPEGP, [Out] float CADFOEBJBIC, [Out] float EMPOGPIGJHL);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEOMFEGOJGC(JBBGAMGOICI GDCDKMJLKDH, float3 NPJPCFKLMHD, quaternion LJIHJJKHDDH);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MDOALNHDIJL(JBBGAMGOICI GDCDKMJLKDH, [Out] float3 NPJPCFKLMHD, [Out] quaternion LJIHJJKHDDH);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DNHFFKDIMPF(JBBGAMGOICI GDCDKMJLKDH);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HCALMMNKPKA
{
	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEPJNGAKAPA(Entity OFJKELIPJNP, [In] float3 OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 BMKGLNAPBHM(Entity OFJKELIPJNP);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKOFJMLILPD(Entity OFJKELIPJNP, [In] quaternion OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion FFPNPOCHPLG(Entity OFJKELIPJNP);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EONGDBFEGBI(Entity OFJKELIPJNP, [In] float3 NPJPCFKLMHD, [In] quaternion LJIHJJKHDDH);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FAPIGBNKGCB(Entity OFJKELIPJNP, [Out] RigidTransform OHIOAPJFAOB);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CPFKFFCONBF(Entity OFJKELIPJNP, [In] float3 NPJPCFKLMHD, [In] quaternion LJIHJJKHDDH);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MOHCLHAIKII(Entity OFJKELIPJNP, [Out] float3 NPJPCFKLMHD, [Out] quaternion LJIHJJKHDDH);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MOHCLHAIKII(Entity OFJKELIPJNP, [Out] RigidTransform OHIOAPJFAOB);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CJAJJGFKAFK(Entity OFJKELIPJNP, float OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float AMBLJBMGEBK(Entity OFJKELIPJNP);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LMNJBJAIAFH(Entity OFJKELIPJNP, [In] float3 OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 CLDOHOALBNP(Entity OFJKELIPJNP);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NPFAAEPCHML(Entity OFJKELIPJNP, [In] quaternion OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion NIKLHKMGFGD(Entity OFJKELIPJNP);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BNPPOBNMIJG(Entity OFJKELIPJNP, float OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float KAENCNHPHKI(Entity OFJKELIPJNP);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ECMLNHODAJH(Entity OFJKELIPJNP, [Out] float4x4 CNDMPNPBLND);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CAAHNAHHOJA(Entity OFJKELIPJNP, [In] float4x4 CNDMPNPBLND);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BKJKIOKGJGK(Entity OFJKELIPJNP);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DNPDIIDJOED(Entity OFJKELIPJNP, Entity MKDELEMEDEO, Entity JDMAEDJOOLD);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class CABHGHCEHMM
{
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DCBDDKPMBOC
{
	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAGEOLNFEIC(bool GKLLNNLGJLM);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NGHGHNKGFEC
{
	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHBKLKFMJPO(JBBGAMGOICI HMMCMNPLNJA, CONCPCFABOF<string> FIAMKOAPKNO);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFEHKNKAGOJ(JBBGAMGOICI HMMCMNPLNJA, CONCPCFABOF<string> FIAMKOAPKNO);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGPJANBFODF(JBBGAMGOICI HMMCMNPLNJA, CONCPCFABOF<string> FIAMKOAPKNO);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFEAEEKALCA(JBBGAMGOICI HMMCMNPLNJA, CONCPCFABOF<string> FIAMKOAPKNO);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFLHGIEDJCO(JBBGAMGOICI HMMCMNPLNJA, CONCPCFABOF<string> FIAMKOAPKNO);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LHBGBKKAMPF(JBBGAMGOICI HMMCMNPLNJA, CONCPCFABOF<string> FIAMKOAPKNO);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DFENIMOOBJA(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int MINCJDAPMAP(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int ALELFICFPPP(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HIMKNIEIOHE<string> HBNDEEGIEJP(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LLJDPOMODFK(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HIMKNIEIOHE<string> IHJLMPCFFCD(JBBGAMGOICI HMMCMNPLNJA);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JDHIHLBBHHL(JBBGAMGOICI HMMCMNPLNJA, string EHKJLJIDDFP);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DCELILPNJIP(string EHKJLJIDDFP, LOBGEMGFCOO PGIFFIOMMCJ);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JBBGAMGOICI PBBAJJBECHN(string EHKJLJIDDFP);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IOLCFNLEHLJ(string EHKJLJIDDFP, LOBGEMGFCOO PGIFFIOMMCJ);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LJCDOOEICFK(JBBGAMGOICI DDICENLHHPO, string EHKJLJIDDFP, LOBGEMGFCOO PGIFFIOMMCJ);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public static class IGNHHJAIBAM
{
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GIIKNAGPMOF
{
	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World DGMGJMLBJGB(string PDMDICKLJJK = "Main");

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World BEMFNDLHIBK(string PDMDICKLJJK = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World JHDMDAEKJGB(string PDMDICKLJJK = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World APOCILIENDH(string PDMDICKLJJK = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KEIHHBEOEPM
{
	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	World HMNCHLPAJIN
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	World DLHBLMJFKEC
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	EntityManager CHBLGEAMDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	bool KNAODMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase ICHCPFFJLGA(Type AAFMBEEMJAC);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class BJLJAKPBFDC
{
	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F62560", Offset = "0x7F61360", VA = "0x187F62560")]
	public static ComponentSystemBase KOAAJIDDJKM(this World KBBMPPHMANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x36A17C0", Offset = "0x36A05C0", VA = "0x1836A17C0")]
	public static T ICHCPFFJLGA<T>(this KEIHHBEOEPM IKLKCFKGGPG) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CPJMDBJCFJD
{
	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEDMIGAJGOB(NativeListAsync<Entity> NPDPFJIHEOM);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHFPGJJPHIM(CJHDHDJIFNC PKOPAKEAHMB);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGLOKLMKNDI(NativeListAsync<Entity> PKKMPLICFGE, bool PFEIPOCMGFP);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCNGOELHBDC();

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EPCALLEJPDD(Entity IPCOMOHMNHK);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JHBMGIINGEG
{
	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DJBKODCAAGL(Collider LMKDHIOMNKO, [Out] AJAHHFGNGNK HJGIPBBOLAC);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NBLKJAIFLOK
{
	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider DECADBOOFEO(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject KFABFLIDMBM(JBBGAMGOICI HKIGLJLPOKF, GameObject OHJAGGPLIGB, Vector3 IMPLDPKOJAO, Quaternion MEPKHADFMCL);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POAGNIGGBLH(GameObject LMKDHIOMNKO);

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider ANNBHDIFDBN<TCollider>(GameObject PAGMBGAEAMP) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AILNINOJDCM(Collider LMKDHIOMNKO);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject DMIOJILDLDE<TCollider>(string IHGFMOMOADA) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LCELIPGBGBI CANPAFMKGPD(JBBGAMGOICI ELBMKKCBMEN, JBBGAMGOICI FCGLKAKNDNL, AEHNMCPGHOA MOGLFEMNILA, float3 KDLPDGKGHFF, quaternion OIOKFEMNJLB, float3 JAFEPDOMLEC);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JGECHOPIIDH(JBBGAMGOICI CBBNAACPEGP, [Out] LCELIPGBGBI LMKDHIOMNKO);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FDMMBELLLCD(JBBGAMGOICI CBBNAACPEGP, [Out] JBBGAMGOICI IPCOMOHMNHK);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum HHIDCFCKCLN
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GMINMCACEMG
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public struct LHFCOAADHMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public int MOGLFEMNILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public GameObject OHJAGGPLIGB;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAOGPFPNHPL(JBBGAMGOICI CBBNAACPEGP, BJNCGALMFPE NBBOEPDOLMC, bool IPFPCGFDCMH, KKNPPHDFLGB DALOHJAENOJ);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBBOMNPOIIM(JBBGAMGOICI CBBNAACPEGP, BJNCGALMFPE NBBOEPDOLMC, bool IPFPCGFDCMH, bool IKHHOGFJFPM, bool GHHAILJMOIE);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FDFBPECHJLN LPKENAFMJPI(JBBGAMGOICI IPCOMOHMNHK, List<JBBGAMGOICI> GAJNAJBLCPF);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LCELIPGBGBI KPNPHAOJGIO(GameObject FPAHBHBGHLK, GameObject GCECPEOOCCP);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNNIJGGLECI(GameObject FPAHBHBGHLK, List<GameObject> AKIMPKJIEKA);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHGMIILDHEH(GameObject GCECPEOOCCP);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T ANNBHDIFDBN<T>(GameObject PAGMBGAEAMP) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AILNINOJDCM(Collider LMKDHIOMNKO);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject MPBDEGJNNBJ<T>(string IHGFMOMOADA) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MDBGNILHFOG(Collider LMKDHIOMNKO, [Out] JBBGAMGOICI EALBMDJEHIA);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IHOMMGKPDCB(JBBGAMGOICI CBBNAACPEGP, [Out] AJAHHFGNGNK HJGIPBBOLAC);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<HHIDCFCKCLN> HFABADBLHFO(Allocator LNMGNHHGHLL = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] GNPMEOFIOFG();
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CDJJBMHAFBN
{
	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFKKBLFBGKA(JBBGAMGOICI CBBNAACPEGP, JBBGAMGOICI OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCIJCMNCKHE(JBBGAMGOICI CBBNAACPEGP, JBBGAMGOICI OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int AOICNPNCEKK(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JBBGAMGOICI CFMPECDEIMF(JBBGAMGOICI CBBNAACPEGP, int GLAOLHCPLLG);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LHGPEBNJFMN NNDAKEPBAJA(JBBGAMGOICI CBBNAACPEGP, Allocator LNMGNHHGHLL = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KCJIKPEACMC(JBBGAMGOICI CBBNAACPEGP, object JLFLGDNCANL, JBBGAMGOICI OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BJGINHPAODG(JBBGAMGOICI CBBNAACPEGP, object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CPNDGGOJMLC(JBBGAMGOICI CBBNAACPEGP, [Out] JBBGAMGOICI OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KFIKMEAGKPG(JBBGAMGOICI CBBNAACPEGP, float3 OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PJADJLPJECN(JBBGAMGOICI CBBNAACPEGP, [Out] float3 OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LMAHPFJALGK(JBBGAMGOICI CBBNAACPEGP, float3 OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LDHBACLHPAP(JBBGAMGOICI CBBNAACPEGP, [Out] float3 OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EANDECLJNDL(JBBGAMGOICI CBBNAACPEGP, (Quaternion rot, Vector3 moments) AHPJADDOMJM);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NMKMLOCAHAP(JBBGAMGOICI CBBNAACPEGP, [Out] quaternion NHBCDKIJGAO, [Out] float3 DAMDEDBLGKK);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NABIHMJBNBE(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 CHOEMEDHCPM(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 KCFPHGHKBOG(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GCKPAKEHIHF(JBBGAMGOICI CBBNAACPEGP, float3 OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MEKJJMMPDHB(JBBGAMGOICI CBBNAACPEGP, float3 OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float AGOJEIJFDIN(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float KNNAIEBJIOF(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OAHCLGLLDNO(JBBGAMGOICI CBBNAACPEGP, float OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EDEBMFCBHOO(JBBGAMGOICI CBBNAACPEGP, float OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode KKMOIPPPBON(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DCIPIPDNBLL(JBBGAMGOICI CBBNAACPEGP, CollisionDetectionMode OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HGOCJAJAHJN IAAGCCHOOAM(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DJKOHPKKMDJ(JBBGAMGOICI CBBNAACPEGP, HGOCJAJAHJN OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool GLHENJEMFDM(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ACOKKLNIPDD(JBBGAMGOICI CBBNAACPEGP, bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	JBBGAMGOICI CKEHDCMADAJ(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void PJEALNPEPJG(JBBGAMGOICI CBBNAACPEGP, JBBGAMGOICI OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	JBBGAMGOICI DLKCDFLPOJC(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GPAFCMPBBMA(JBBGAMGOICI CBBNAACPEGP, JBBGAMGOICI OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	JFLNIIIFAEP LAIFHPHEHKF(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void CABOCCFJIJJ(JBBGAMGOICI CBBNAACPEGP, JFLNIIIFAEP GHLLJKOAGBP);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PHEBIBLFNHM(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void DIDNCMCHKIJ(JBBGAMGOICI CBBNAACPEGP, bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool CBLNLFKEJAP(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void IDIMNEJAPFJ(JBBGAMGOICI CBBNAACPEGP, bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints CMOIJJNHBEJ(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void FMGIBBGPIFM(JBBGAMGOICI CBBNAACPEGP, RigidbodyConstraints OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float MIAKFLPLFKJ(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void JPCCOILDKMB(JBBGAMGOICI CBBNAACPEGP, float OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float KCFPIHOCNFH(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void PHKCGGDFHOA(JBBGAMGOICI CBBNAACPEGP, float OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool MDKGJGGKIID(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void DBOLCDNAMIN(JBBGAMGOICI CBBNAACPEGP, bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool KCGNEOJPAEN(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void PFKJCOBCNNG(JBBGAMGOICI CBBNAACPEGP, bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void KBDEIOAAKBC(JBBGAMGOICI CBBNAACPEGP, int OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "50")]
	FDHABFHCHKN PFAIDGKFHNJ(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void HMEMODNCOGK(JBBGAMGOICI CBBNAACPEGP, FDHABFHCHKN OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "52")]
	MOFBPFIADAD HKHHCJPMPOK(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void PDOPMKEPCEN(JBBGAMGOICI CBBNAACPEGP, MOFBPFIADAD OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float PAEBJCOHNGG(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void ANMKGHCOMOH(JBBGAMGOICI CBBNAACPEGP, float OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void GCOGLLBNBKG(JBBGAMGOICI CBBNAACPEGP, object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void HCFEFELFLPK(JBBGAMGOICI CBBNAACPEGP, object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool GOOAKHBFBGN(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void DHCFOOCKAMF(JBBGAMGOICI CBBNAACPEGP, object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void NOKCKPDGMIP(JBBGAMGOICI CBBNAACPEGP, object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool FIMCDKAGIJN(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool BOMOBFPJHJC(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody DCELFBBIBLP(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void EOODHGMNCHE(JBBGAMGOICI CBBNAACPEGP, Rigidbody HDAOKPJKILI);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void PAIOOOAKCBF(JBBGAMGOICI CBBNAACPEGP, object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void FEJODPCJEIF(JBBGAMGOICI CBBNAACPEGP, object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool DGLEINCBKMD(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void DGDDIAIHHKK(JBBGAMGOICI CBBNAACPEGP, float3 GPBPHJJLKFP);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void FHLGDKNADLE(JBBGAMGOICI CBBNAACPEGP, float3 MFGCBODNMPM);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool BECEADMMPED(JBBGAMGOICI CBBNAACPEGP, [Out] float3 GPBPHJJLKFP);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool LMFCLMHHEOK(JBBGAMGOICI CBBNAACPEGP, [Out] float3 MFGCBODNMPM);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool ENAMOGMAFCP(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void KJBOPPHFIPN(JBBGAMGOICI CBBNAACPEGP, object JLFLGDNCANL, bool OHLMJEAGLOD);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void HFMPEFCCPHE(JBBGAMGOICI CBBNAACPEGP, bool FKOKKILMAMA);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void FAALHLCIPCJ(JBBGAMGOICI CBBNAACPEGP);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool LBFCAHFINBE(JBBGAMGOICI CBBNAACPEGP);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ICAECGLEILG
{
	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOJLFCGICAH(Entity DMAENGLAPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAODPIPMKGA(Entity DMAENGLAPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNKHMPLKKAO(Entity DMAENGLAPCJ);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DKDGIOABHOE
{
	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIIGDDENEIP(JBBGAMGOICI GDCDKMJLKDH, bool LKIFNKGLENJ);
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public delegate void GENJCPFKCGB(FCNPFOCIONN BNPIDJOCPAA);
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public readonly ref struct FCNPFOCIONN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly LHGPEBNJFMN GAPIKHHBAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly NativeArray<byte> HIKDLOJNBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly NativeArray<byte> PGFPNHDODGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly JALOGBPPALL FEMKAJANBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly int DIKGCOHEMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Type LIAGCGCENFH;

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public LHGPEBNJFMN ODJCABDBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x5140320", Offset = "0x513F120", VA = "0x185140320")]
		get
		{
			return default(LHGPEBNJFMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public int PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x7F69970", Offset = "0x7F68770", VA = "0x187F69970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public JALOGBPPALL KPNBGJGPCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xA276E0", Offset = "0xA264E0", VA = "0x180A276E0")]
		get
		{
			return default(JALOGBPPALL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x7F699C0", Offset = "0x7F687C0", VA = "0x187F699C0")]
	public FCNPFOCIONN(LHGPEBNJFMN GAPIKHHBAHD, NativeArray<byte> HIKDLOJNBJD, NativeArray<byte> PGFPNHDODGI, JALOGBPPALL FEMKAJANBPA, int DIKGCOHEMAN, Type LIAGCGCENFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x38DDA90", Offset = "0x38DC890", VA = "0x1838DDA90")]
	public NativeArray<T> KCMPCNFHOJN<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x38DDA50", Offset = "0x38DC850", VA = "0x1838DDA50")]
	public NativeArray<T> FAFICLLEJPK<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x38DDAD0", Offset = "0x38DC8D0", VA = "0x1838DDAD0")]
	public (LHGPEBNJFMN, NativeArray<T>, NativeArray<T>) MBFFDPKOBBN<T>() where T : struct
	{
		return default((LHGPEBNJFMN, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x7F69990", Offset = "0x7F68790", VA = "0x187F69990")]
	public HMKKNPEPDPM PKPOFDDJMJK()
	{
		return default(HMKKNPEPDPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public interface AMMJGKGFKHG
{
	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	string OAPGINEGBGF
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	AMMJGKGFKHG ECNBDFFBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	IEnumerable<AMMJGKGFKHG> CHIPJBBEBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LNGCNKDJIDO
{
	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	AMMJGKGFKHG LGCGJEBODAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	NativeArray<JALOGBPPALL> KOCOLCEKLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IBGOKFJJFEF(JALOGBPPALL FEMKAJANBPA, [Out] AMMJGKGFKHG NNLLPHNMAFL);

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KEMEJJLNDFN(JALOGBPPALL FEMKAJANBPA, GENJCPFKCGB CHDJFDHAMDI);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGPIMBAFGHP(JALOGBPPALL FEMKAJANBPA, GENJCPFKCGB CHDJFDHAMDI);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LHAHJDFHEAG
{
	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEMEJJLNDFN(JALOGBPPALL FEMKAJANBPA, GENJCPFKCGB CHDJFDHAMDI);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGPIMBAFGHP(JALOGBPPALL FEMKAJANBPA, GENJCPFKCGB CHDJFDHAMDI);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public static class FPIHLDPCCPL
{
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CBOPJEJFGFL
{
	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	bool JLKOFBIOMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	CLJEAGLOADA LDMOBDMBMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ECJKBFBEONM(ECFMGHLFIHK LEBLPDLNOOO, bool OPJKLOMHCKJ);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CNKDKBKMMFI(LAFPBLKJNNP LEBLPDLNOOO, JALOGBPPALL FEMKAJANBPA);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GAEJGBGELEC(NativeArray<LAFPBLKJNNP> KHBBGMPLMBP);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class IFGBNJKBCJF
{
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public readonly ref struct HMKKNPEPDPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly FCNPFOCIONN FFEMKICJPKP;

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public LHGPEBNJFMN ODJCABDBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x5140320", Offset = "0x513F120", VA = "0x185140320")]
		get
		{
			return default(LHGPEBNJFMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D4F0", Offset = "0x7F6C2F0", VA = "0x187F6D4F0")]
	public HMKKNPEPDPM(FCNPFOCIONN FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D0D0", Offset = "0x7F6BED0", VA = "0x187F6D0D0")]
	public LHGPEBNJFMN KCMPCNFHOJN()
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CFA0", Offset = "0x7F6BDA0", VA = "0x187F6CFA0")]
	public LHGPEBNJFMN FAFICLLEJPK()
	{
		return default(LHGPEBNJFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D200", Offset = "0x7F6C000", VA = "0x187F6D200")]
	public (LHGPEBNJFMN, LHGPEBNJFMN, LHGPEBNJFMN) MBFFDPKOBBN()
	{
		return default((LHGPEBNJFMN, LHGPEBNJFMN, LHGPEBNJFMN));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public static class KEBABAONKHI
{
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public readonly struct CLJEAGLOADA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly NativeBitArray EKBNMIHBKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly NativeParallelHashMap<LAFPBLKJNNP, int> KIGFIIHJFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly NativeParallelHashSet<ECFMGHLFIHK> JJDFGKHHJKG;

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public bool FGHJEBOPHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7F64720", Offset = "0x7F63520", VA = "0x187F64720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public bool JLKOFBIOMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x7F64500", Offset = "0x7F63300", VA = "0x187F64500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x5D9CC70", Offset = "0x5D9BA70", VA = "0x185D9CC70")]
	public CLJEAGLOADA(NativeBitArray EKBNMIHBKOO, NativeParallelHashMap<LAFPBLKJNNP, int> KIGFIIHJFGI, NativeParallelHashSet<ECFMGHLFIHK> JJDFGKHHJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x7F64530", Offset = "0x7F63330", VA = "0x187F64530")]
	public bool CNKDKBKMMFI(LAFPBLKJNNP LEBLPDLNOOO, JALOGBPPALL FEMKAJANBPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DMKHLICKBBC
{
	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	MNEOPFCLMIK ILNKCAOGEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JODNHFAOMAE
{
	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALIKBBIJCCC(JBBGAMGOICI CBBNAACPEGP, MPGMAKFMEHA OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BLHOJKOBONC HOGAEMGOJAJ();
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BJAFFPIEHPF
{
	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKLHMLOOCGC(World KBBMPPHMANJ);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHJJDEAHGHJ(World KBBMPPHMANJ);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase IDLMCJJCFGL(World KBBMPPHMANJ);

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MGFDNPEHMLF(World KBBMPPHMANJ);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CINCCNHMIEJ(World KBBMPPHMANJ);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CHDOCNCFICA(World KBBMPPHMANJ);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPPBBBENNHI(World KBBMPPHMANJ);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> OHLPIJDHFLB();
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DKMLBBCEDBN
{
	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCOPDMFNJME(JBBGAMGOICI NIFNCNHCJID, bool OAIIHELJHLG);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public readonly struct FIHIHOJGCFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly IEnumerable<CMLHBFADPCI> KKEOIEBPBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly IReadOnlyList<GameObject> OKHCMKKJNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly IReadOnlyList<int> MKMLNDCGDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly IReadOnlyList<(LAFPBLKJNNP, LAFPBLKJNNP)> PDMKAAMOKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int NEJMGABKFPM;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public struct NGMNIDBEMEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public InventionIdData FONJFDCCINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public InventionInstanceIdData ADFEGBCJFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool NMONKDNMBLH;

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x7F72CC0", Offset = "0x7F71AC0", VA = "0x187F72CC0")]
	public NGMNIDBEMEM(long FONJFDCCINO, Guid ADFEGBCJFEK, bool NMONKDNMBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[ServiceLifetime(Lifetime.Application)]
public interface CKLMNDIMBCA
{
	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NIKJMMKGBCK LBGLBIDCPBF(DMDGHBDFKMP KPEIBOOMGAE, int GIDPMCDAMFN = 0, bool COHGKNPOLKC = false);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NEGFDLNBPJM JCLIBACDNLN(DMDGHBDFKMP KPEIBOOMGAE, JBBGAMGOICI BOGJJGPKPIJ, [In] UniformTRS DFEBEMJPNOF, HKPIHOPDPCA GIMBMOGIFPG, [Optional] NGMNIDBEMEM AAJDFBBLJGJ, bool LFHMCGMDDAH = true, bool LFJEHEMDPNG = false, bool COHGKNPOLKC = false);

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EFGHIOIPNLD NBEHDJNBGLA();

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EFGHIOIPNLD EACMKLKNOKH(LHGPEBNJFMN DGLKBCCIOFF, [In] UniformTRS BJIKKCHOIEM, [Optional] HKPIHOPDPCA JBBFINLNJLO);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OCBNIKDHJKG(JBBGAMGOICI HLPOOCGPPLK);

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KBLBAEGKICC(JBBGAMGOICI HLPOOCGPPLK, [Out] Exception BKLHGCIIDBN);

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<LAFPBLKJNNP> LKHLCFDLLHJ(JBBGAMGOICI HLPOOCGPPLK, Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<LAFPBLKJNNP> LDPDCBBLLDG(JBBGAMGOICI HLPOOCGPPLK, Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LHGPEBNJFMN KCHNLGDAMHA(JBBGAMGOICI HLPOOCGPPLK, Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LHGPEBNJFMN MONPGOJMCEM(JBBGAMGOICI HLPOOCGPPLK, Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LHGPEBNJFMN GHDJGDDNLPL(JBBGAMGOICI HLPOOCGPPLK, Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> AKEPBNJDBAJ(JBBGAMGOICI HLPOOCGPPLK, Allocator LNMGNHHGHLL);

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DGCDPPHMANF(JBBGAMGOICI HLPOOCGPPLK);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int PHFHFOBNOOI(JBBGAMGOICI HLPOOCGPPLK, int ALFGNAHPKIG);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[ServiceLifetime(Lifetime.Application)]
public interface PCMAMBKNBEA
{
	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0xE05510", Offset = "0xE04310", VA = "0x180E05510", Slot = "0")]
	bool KFANGKAFJMA(object FELHJOMEEAD, GBFCLKEFOGF LANOOKFCHOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class AKJNBENOPGN
{
	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x7F616E0", Offset = "0x7F604E0", VA = "0x187F616E0")]
	public static bool KFANGKAFJMA(this PCMAMBKNBEA BMACFGNFKCL, object FELHJOMEEAD, [Out] GBFCLKEFOGF LANOOKFCHOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public enum EHHAPHEPLOB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface GBFCLKEFOGF
{
	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	EKKDBLOILKP KDNIOMEAELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	HMJDCIMFIOA EALAAGBDPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	bool HDMDCHHMGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	bool LANDDEKDCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object ONLADDFDIMB();

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "5")]
	(HMJDCIMFIOA, Dictionary<object, object>) PNHAIDHNIKJ()
	{
		return default((HMJDCIMFIOA, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "6")]
	(LAFPBLKJNNP, HMJDCIMFIOA) DKCHNCNNIMN()
	{
		return default((LAFPBLKJNNP, HMJDCIMFIOA));
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "7")]
	ILMNGEFPMMK<(LAFPBLKJNNP, HMJDCIMFIOA)> OPJHCGGAAHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "8")]
	(MLHKGBLBCLB, byte[]) IFPHLALPHCN()
	{
		return default((MLHKGBLBCLB, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "9")]
	(HFKGBNOFMOB, byte[]) FFPAOOJJODI()
	{
		return default((HFKGBNOFMOB, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "10")]
	T DOIHCEMHOKH<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class LFOGCAEJFDN
{
	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FCE0", Offset = "0x7F6EAE0", VA = "0x187F6FCE0")]
	public static bool OJEFMIPJOFE(this GBFCLKEFOGF KPAGBEKAECE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public interface LBBDDLCEJJB : ILMNGEFPMMK<KLOPPHJHMCG>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[DefaultMember("Item")]
public interface ILMNGEFPMMK<T>
{
	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	T ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	int PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public enum EKKDBLOILKP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RR_MasterLockBlockComplete = 27,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RR_NetworkSynchronization = 28,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_NetworkInstantiate = 29,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_BulkInstantiate = 31,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_Destroy = 32,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RR_BulkDestroy = 33,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_TransferOwnership = 34,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_OwnershipUpdate = 35,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_RPC = 36,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RR_JoinRequest = 100,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RR_JoinResponse = 101,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RR_RoomUpdate = 102,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RR_PlayerUpdate = 103,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RR_RemotePlayerJoined = 104,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RR_RemotePlayerLeft = 105,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_Leave = 106,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public enum MLHKGBLBCLB : uint
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class IHLICEHMAPE
{
	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DE20", Offset = "0x7F6CC20", VA = "0x187F6DE20")]
	public static LAFPBLKJNNP JDLEIHOMFNF(this NEGCPPNACKE FFEMKICJPKP)
	{
		return default(LAFPBLKJNNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DDD0", Offset = "0x7F6CBD0", VA = "0x187F6DDD0")]
	public static LAFPBLKJNNP FLLIBFKPMIA([In] this NEGCPPNACKE FFEMKICJPKP)
	{
		return default(LAFPBLKJNNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x7EF36C0", Offset = "0x7EF24C0", VA = "0x187EF36C0")]
	public static LAFPBLKJNNP KPAAANJKLCJ(this NEGCPPNACKE FFEMKICJPKP)
	{
		return default(LAFPBLKJNNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x7EF36C0", Offset = "0x7EF24C0", VA = "0x187EF36C0")]
	public static ViewId NFAENPLEKJB(this NEGCPPNACKE FFEMKICJPKP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D910", Offset = "0x7F6C710", VA = "0x187F6D910")]
	public static FixedString64Bytes CKAINAGFMJD(this ECFMGHLFIHK FONJFDCCINO)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DB50", Offset = "0x7F6C950", VA = "0x187F6DB50")]
	public static FixedString64Bytes DJHOIKLHNKN(this LAFPBLKJNNP FONJFDCCINO)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DAC0", Offset = "0x7F6C8C0", VA = "0x187F6DAC0")]
	public static FixedString32Bytes CKAINAGFMJD(this Entity OFJKELIPJNP)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OCEMFOOPNEN : AJIMKJNIPDD
{
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public enum FOOPFIFENPD
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NODDMGJGEIP
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<object> PKIMDPPLMKH;

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "2")]
	void ICPAFMNBHIA(object FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "3")]
	void KCHJGGEFMBJ(HFKGBNOFMOB EEDJPELJDDE, ReadOnlySpan<byte> DKEBGKJJPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	void MNCCFOGBEBG(MLHKGBLBCLB AAFMBEEMJAC, ReadOnlySpan<byte> DKEBGKJJPPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KNHIKMMFHKK
{
	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HFKGBNOFMOB HOKIPOBNKMM(ReadOnlySpan<byte> DKEBGKJJPPO);
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MHINEIEEMNP
{
	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIGMNFJDDJC(HFKGBNOFMOB MAKJJJECHHB, ReadOnlySpan<byte> DKEBGKJJPPO);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGMIIIJHLAM(ReadOnlySpan<HFKGBNOFMOB> LCLAIHPHMHC);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public struct PIDGDMICION
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public HFKGBNOFMOB EEDJPELJDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public ReadOnlyMemory<byte> DKEBGKJJPPO;
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct HFKGBNOFMOB
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static HFKGBNOFMOB FJKHJGGDPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public ECFMGHLFIHK DLJDIONABKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public int BDNEDNJOEJA;

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	public static ECFMGHLFIHK BMIBHLGOACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C4C0", Offset = "0x7F6B2C0", VA = "0x187F6C4C0")]
		get
		{
			return default(ECFMGHLFIHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x513F6F0", Offset = "0x513E4F0", VA = "0x18513F6F0")]
	public HFKGBNOFMOB(ECFMGHLFIHK DLJDIONABKD, int BDNEDNJOEJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C680", Offset = "0x7F6B480", VA = "0x187F6C680")]
	public static bool PBEBFPKJKLO([In] HFKGBNOFMOB ALCLKCHJGII, [In] HFKGBNOFMOB GFJPONDOIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C510", Offset = "0x7F6B310", VA = "0x187F6C510", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C620", Offset = "0x7F6B420", VA = "0x187F6C620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C710", Offset = "0x7F6B510", VA = "0x187F6C710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C610", Offset = "0x7F6B410", VA = "0x187F6C610")]
	public void GOKNENBJBKI([Out] ECFMGHLFIHK EMKNGKOPAPH, [Out] int BDNEDNJOEJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public static class KLIHKPNGPIJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public struct CMLHBFADPCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Guid PDFBNFKDLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public string PGMKJGMLBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Vector3 NPJPCFKLMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Quaternion LJIHJJKHDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Vector3 JCGDFDLNFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public int ICNKNAIBLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public IKHGLHKGDCI CNCKIIIBBGO;

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x7F64740", Offset = "0x7F63540", VA = "0x187F64740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public enum MMDLDDDNNNF
{
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public static class JJIOMCFGPLN
{
	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EB00", Offset = "0x7F6D900", VA = "0x187F6EB00")]
	public static bool AEMGJANIICP(this MMDLDDDNNNF AAFMBEEMJAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EB20", Offset = "0x7F6D920", VA = "0x187F6EB20")]
	public static bool JGLNAMJAIAA(this MMDLDDDNNNF AAFMBEEMJAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EB30", Offset = "0x7F6D930", VA = "0x187F6EB30")]
	public static bool JOKPGPJGHLD(this MMDLDDDNNNF AAFMBEEMJAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[Flags]
public enum LNIIADOFKKK
{
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface HKPIHOPDPCA
{
	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DIDAMJJGKFA([In] Guid KHJEADFMOJM, [Out] Guid BHBDEJBFADC);
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[Flags]
public enum MNGHBLLHDOI
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface EFGHIOIPNLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	DENHOBJJLFN EHLOCAGOEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString DGBFCCCHDDI();
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public enum HNFEGNBLLGF
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct AIEMOLJJLEO : ISystemStateComponentData, IComponentData, IEquatable<AIEMOLJJLEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public float3 MOHNDIPBIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public float3 HHAPGCKPBLI;

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x7F61660", Offset = "0x7F60460", VA = "0x187F61660", Slot = "4")]
	public bool Equals(AIEMOLJJLEO HBLONCAMFLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EADFMPIPMJM
{
	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KAFJMODKBNL(long COECJEJOOKF);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGMGKEKFKIN(NativeParallelHashSet<long> AGBAGKEHGPE);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKKCEIEKAHB(World KBBMPPHMANJ, NativeParallelHashMap<Guid, long> OEFCCPAHHIO);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HFPDGKJKFCI(LAFPBLKJNNP LEBLPDLNOOO);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NCEEBGJKEKL(LAFPBLKJNNP LEBLPDLNOOO, [Out] Guid HDFIIEGGMPE, [Out] long COECJEJOOKF);

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNJCBKBDGON(LAFPBLKJNNP LEBLPDLNOOO, Guid HDFIIEGGMPE, long COECJEJOOKF);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FHOBHJMIDOB(Guid HDFIIEGGMPE);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BMJJBIACLBH(Guid HDFIIEGGMPE, [Out] int POBIFMDABOD, [Out] int HOPIEFKAGLL);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JONJFEBHAOE(Guid HDFIIEGGMPE, int POBIFMDABOD, int HOPIEFKAGLL);

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EDABOHKIODI(Guid HDFIIEGGMPE);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class KAMDLADCGCG
{
	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KAMDLADCGCG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
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
