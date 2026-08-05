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
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x738DE00", Offset = "0x738D000", VA = "0x18738DE00", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MHMLCKAHBEO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x738E260", Offset = "0x738D460", VA = "0x18738E260")]
	public static void FJGIPAHCEGD(this Rigidbody GJKFPPGHDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x738E130", Offset = "0x738D330", VA = "0x18738E130")]
	public static void FJGIPAHCEGD(this Rigidbody GJKFPPGHDPC, Vector3 JAIBOBLAFJF, Quaternion CKFDGHNJDCN, Vector3 PKOJJFAMENE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct NDNBDIACCIO : IReadOnlyList<CIBKNFGEPGP>, IEnumerable<CIBKNFGEPGP>, IEnumerable, IReadOnlyCollection<CIBKNFGEPGP>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct MFGDDOHJPDD : IEnumerator<CIBKNFGEPGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly EKHABGHIANL HHGPPDCIJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator PDIDANFNIEJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CIBKNFGEPGP AJGNMEAPLII
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x738E0E0", Offset = "0x738D2E0", VA = "0x18738E0E0", Slot = "4")]
			get
			{
				return default(CIBKNFGEPGP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x738E060", Offset = "0x738D260", VA = "0x18738E060", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x49CADD0", Offset = "0x49C9FD0", VA = "0x1849CADD0")]
		public MFGDDOHJPDD(EKHABGHIANL HHGPPDCIJMN, NativeArray<LocalId>.Enumerator PDIDANFNIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x738DFA0", Offset = "0x738D1A0", VA = "0x18738DFA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x738DFE0", Offset = "0x738D1E0", VA = "0x18738DFE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x738E020", Offset = "0x738D220", VA = "0x18738E020", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly EKHABGHIANL HHGPPDCIJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> PPCLEJEKIDG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CIBKNFGEPGP FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x738FB50", Offset = "0x738ED50", VA = "0x18738FB50", Slot = "4")]
		get
		{
			return default(CIBKNFGEPGP);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x738F6F0", Offset = "0x738E8F0", VA = "0x18738F6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int FCNCOEIFHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8F21A0", Offset = "0x8F13A0", VA = "0x1808F21A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int JBMLOIOBDME
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F21A0", Offset = "0x8F13A0", VA = "0x1808F21A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GJCMKJAFLDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x738F4D0", Offset = "0x738E6D0", VA = "0x18738F4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> CNHGBDIBKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B690", Offset = "0x2B3A890", VA = "0x182B3B690")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> LNLOPHILFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x738F510", Offset = "0x738E710", VA = "0x18738F510")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x738FAC0", Offset = "0x738ECC0", VA = "0x18738FAC0")]
	public NDNBDIACCIO(int EKPEFEBPGMB, EKHABGHIANL HHGPPDCIJMN, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x49CA720", Offset = "0x49C9920", VA = "0x1849CA720")]
	public NDNBDIACCIO(EKHABGHIANL HHGPPDCIJMN, NativeArray<LocalId> PPCLEJEKIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x738FA50", Offset = "0x738EC50", VA = "0x18738FA50")]
	internal NDNBDIACCIO(EKHABGHIANL HHGPPDCIJMN, NativeArray<Entity> NNDJLDGDLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x738F9B0", Offset = "0x738EBB0", VA = "0x18738F9B0")]
	public NDNBDIACCIO(EKHABGHIANL HHGPPDCIJMN, int BJJBELCKPHA, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x738F900", Offset = "0x738EB00", VA = "0x18738F900")]
	public NDNBDIACCIO(NDNBDIACCIO GCEJNCFCNAD, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x738F640", Offset = "0x738E840", VA = "0x18738F640")]
	public NDNBDIACCIO KBOLCOBAECE(Allocator NNHCNMKJHLF = Allocator.Temp)
	{
		return default(NDNBDIACCIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x738F570", Offset = "0x738E770", VA = "0x18738F570", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x738F5B0", Offset = "0x738E7B0", VA = "0x18738F5B0")]
	public MFGDDOHJPDD EMKBHPPGLAN()
	{
		return default(MFGDDOHJPDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x738F740", Offset = "0x738E940", VA = "0x18738F740", Slot = "6")]
	private IEnumerator<CIBKNFGEPGP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x738F820", Offset = "0x738EA20", VA = "0x18738F820", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct IODHKOECLEP : IList<CIBKNFGEPGP>, ICollection<CIBKNFGEPGP>, IEnumerable<CIBKNFGEPGP>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct IALIEBDJHPO : IEnumerator<CIBKNFGEPGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly EKHABGHIANL HHGPPDCIJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator PDIDANFNIEJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CIBKNFGEPGP AJGNMEAPLII
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x738A330", Offset = "0x7389530", VA = "0x18738A330", Slot = "4")]
			get
			{
				return default(CIBKNFGEPGP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x738A2B0", Offset = "0x73894B0", VA = "0x18738A2B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x49CADD0", Offset = "0x49C9FD0", VA = "0x1849CADD0")]
		public IALIEBDJHPO(EKHABGHIANL HHGPPDCIJMN, NativeArray<LocalId>.Enumerator PDIDANFNIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x738A1F0", Offset = "0x73893F0", VA = "0x18738A1F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x738A230", Offset = "0x7389430", VA = "0x18738A230", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x738A270", Offset = "0x7389470", VA = "0x18738A270", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EKHABGHIANL HHGPPDCIJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> PPCLEJEKIDG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CIBKNFGEPGP FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x738AEA0", Offset = "0x738A0A0", VA = "0x18738AEA0", Slot = "4")]
		get
		{
			return default(CIBKNFGEPGP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x738AF20", Offset = "0x738A120", VA = "0x18738AF20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x738A820", Offset = "0x7389A20", VA = "0x18738A820", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JBMLOIOBDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x738A820", Offset = "0x7389A20", VA = "0x18738A820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> CNHGBDIBKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B690", Offset = "0x2B3A890", VA = "0x182B3B690")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool NPIFBDLIKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x738AD00", Offset = "0x7389F00", VA = "0x18738AD00")]
	public IODHKOECLEP(int EKPEFEBPGMB, EKHABGHIANL HHGPPDCIJMN, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x738AE20", Offset = "0x738A020", VA = "0x18738AE20")]
	public IODHKOECLEP(EKHABGHIANL HHGPPDCIJMN, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x738AD90", Offset = "0x7389F90", VA = "0x18738AD90")]
	public IODHKOECLEP(EKHABGHIANL HHGPPDCIJMN, int BJJBELCKPHA, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x738A9A0", Offset = "0x7389BA0", VA = "0x18738A9A0")]
	public NDNBDIACCIO KOKIKGBCOHA()
	{
		return default(NDNBDIACCIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x738A530", Offset = "0x7389730", VA = "0x18738A530", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x738A570", Offset = "0x7389770", VA = "0x18738A570", Slot = "13")]
	public bool Contains(CIBKNFGEPGP OCLIEIADJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x738A600", Offset = "0x7389800", VA = "0x18738A600", Slot = "14")]
	public void CopyTo(CIBKNFGEPGP[] HCOCCGHLKNN, int BKDPKOGEFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x738A4B0", Offset = "0x73896B0", VA = "0x18738A4B0", Slot = "11")]
	public void Add(CIBKNFGEPGP OCLIEIADJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x738A8F0", Offset = "0x7389AF0", VA = "0x18738A8F0", Slot = "7")]
	public void Insert(int CPLNODNGKGB, CIBKNFGEPGP OCLIEIADJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x738AA70", Offset = "0x7389C70", VA = "0x18738AA70", Slot = "15")]
	public bool Remove(CIBKNFGEPGP OCLIEIADJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x738A860", Offset = "0x7389A60", VA = "0x18738A860", Slot = "6")]
	public int IndexOf(CIBKNFGEPGP OCLIEIADJMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x738AA20", Offset = "0x7389C20", VA = "0x18738AA20", Slot = "8")]
	public void RemoveAt(int CPLNODNGKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x738A750", Offset = "0x7389950", VA = "0x18738A750", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x738A790", Offset = "0x7389990", VA = "0x18738A790")]
	public IALIEBDJHPO EMKBHPPGLAN()
	{
		return default(IALIEBDJHPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x738AB40", Offset = "0x7389D40", VA = "0x18738AB40", Slot = "16")]
	private IEnumerator<CIBKNFGEPGP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x738AC20", Offset = "0x7389E20", VA = "0x18738AC20", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DIOLKHKMLAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int GDAGHICGPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> KKPIKAKDFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CIBKNFGEPGP HIHMIIAOMPD(CIBKNFGEPGP PPCLEJEKIDG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LILMCBJGHKM : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[ServiceLifetime(Lifetime.Application)]
public interface IFACMMPAJGL : MPEPKKADDLK, EKANBBOODKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	HEKAFONNIOP JFBKPHBILMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	IJPFLEAABMH CFHCLEHKHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	DDJGKFJPEIA ECFJFFIFBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface EKANBBOODKL
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool MEJCLCCDGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface JCBBGGMAJMP
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAAALHGFCIA(bool OMEFCJCOLII);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface MCDODPGOENF
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ODOKNOMEHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNAKMFDHLEC(bool MPKIENECBCP);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPCJPIFLKEP();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KGBBCOHLOLB(ByteString IBMGILDHNGE);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHEJLOJBFNG();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LHCIKDDPEEJ();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FNFCAOGCPEF();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FPMPIBHJKEF();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NBIKPDLMLJD();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NKFKJNFNNHD();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.Application)]
public interface BBPKOKGMLME
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	DMNOAHHBJOJ JFBKPHBILMG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	IJPFLEAABMH CFHCLEHKHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	EEPABMPJIMJ AJMAHBOENMM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	GGFNELMAGBE DHGLOHAECPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IFACMMPAJGL NBGFDPBHOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	MCDODPGOENF JDGNGPHDMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	GGFBFEIEEOM GKLKJFNCMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	BGCIOADNHMO GNIJDIPKIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LGPNHEBMOLL CCDPBMPDLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	LFNDBJLAEDM EAANELIEOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	BFDDDBCCDOC MMDFAHLNGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	CKLGKANFICN HKNIKLOPJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	LMAKPLIKPNH LFEEBGONJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	DBDFBDLKLCO IIPLGCGLGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	NHMJFNPMBLN ONGAKOPCMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NJGPMDFAAOF CDJFPIIBKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CGADFIBDDDE DKNGFKGLAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	DKGIONCBAMG KHKCOEDMGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	BEKMNEBJFDN HKPOINCLEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	DNKELJAGPAO IKDAHCPBEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	GKABMLCHAOI EGHLFPPJGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	PGLLOHJHJLK NCJOJDIJHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	CBPKJJGCCHH KFMIFJCIMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	FELJJILIKAN PNPMAENCJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	PFGAACPCDNO FLMMIAIIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NLCLDNOPJLK DHJNHEJAOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LIDOLEINANO HBCHOCAJEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	BKDBNGEINBI JLJEIANAGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GJHKOCHJLHN KPPEGACJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	EINGBNHMEFH EIGFBJGKHAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(FBENPMDCELJ))]
public readonly struct CIBKNFGEPGP : IComparable<CIBKNFGEPGP>, IEquatable<CIBKNFGEPGP>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly CIBKNFGEPGP EPGHELDKPDG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int NFDKHIFGBLD = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int IDEBKHBKLMA = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int NHOAGINEMCC = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int CNMLNIEMDPN = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId IMMLHGFCKGF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IFACMMPAJGL NBGFDPBHOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7383480", Offset = "0x7382680", VA = "0x187383480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public LocalId NKBODANJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7383A30", Offset = "0x7382C30", VA = "0x187383A30")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal DDJGKFJPEIA ECFJFFIFBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7383810", Offset = "0x7382A10", VA = "0x187383810")]
		get
		{
			return default(DDJGKFJPEIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KIFOFJDPIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x73836F0", Offset = "0x73828F0", VA = "0x1873836F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private bool KPFEHICBPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7383A70", Offset = "0x7382C70", VA = "0x187383A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7383BF0", Offset = "0x7382DF0", VA = "0x187383BF0")]
	public CIBKNFGEPGP(EKHABGHIANL HIFMCNBAILI, LocalId IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
	public JGGGIHBIMPC ODEDLAIKCDL()
	{
		return default(JGGGIHBIMPC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x73839B0", Offset = "0x7382BB0", VA = "0x1873839B0")]
	public static LocalId KEDBNOKLEHE(CIBKNFGEPGP KKAPKEFAMEF)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x73839F0", Offset = "0x7382BF0", VA = "0x1873839F0")]
	public static Entity KEDBNOKLEHE(CIBKNFGEPGP KKAPKEFAMEF)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x73834E0", Offset = "0x73826E0", VA = "0x1873834E0")]
	public static bool CCHBIHOFELC(CIBKNFGEPGP KKLLOEEDINO, CIBKNFGEPGP NHCGDJCFKIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7381B00", Offset = "0x7380D00", VA = "0x187381B00")]
	public static bool IMFBACMHPLD(CIBKNFGEPGP KKLLOEEDINO, CIBKNFGEPGP NHCGDJCFKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7383AC0", Offset = "0x7382CC0", VA = "0x187383AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7383820", Offset = "0x7382A20", VA = "0x187383820", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7383600", Offset = "0x7382800", VA = "0x187383600", Slot = "4")]
	public int CompareTo(CIBKNFGEPGP JAINJPLCLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "5")]
	public bool Equals(CIBKNFGEPGP JAINJPLCLDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LMNCDHOOPFI
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x738D040", Offset = "0x738C240", VA = "0x18738D040")]
	public static CBHIEDOMBAP IJIMJNKOKDE(this CIBKNFGEPGP LCACGJDNDHA)
	{
		return default(CBHIEDOMBAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x738D0F0", Offset = "0x738C2F0", VA = "0x18738D0F0")]
	public static JGGGIHBIMPC PMPJGBMMBBP(this CIBKNFGEPGP LCACGJDNDHA)
	{
		return default(JGGGIHBIMPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class FBENPMDCELJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct DDJGKFJPEIA : IEquatable<DDJGKFJPEIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte AINDMPLBNFF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] MDDOOEMKCOM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static EKHABGHIANL KGEEOPNBGMC;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static IFACMMPAJGL LIPHODDENBB;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static EKHABGHIANL[] ANJEAOPLAOJ;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static IFACMMPAJGL[] LPGBKKAPFIL;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> KNFCJCHGHBI;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IFACMMPAJGL NBGFDPBHOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7384D00", Offset = "0x7383F00", VA = "0x187384D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EKHABGHIANL IAHKABCBJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7385180", Offset = "0x7384380", VA = "0x187385180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7385C00", Offset = "0x7384E00", VA = "0x187385C00")]
	static DDJGKFJPEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x26FF1B0", Offset = "0x26FE3B0", VA = "0x1826FF1B0")]
	internal DDJGKFJPEIA(byte OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x63EDD40", Offset = "0x63ECF40", VA = "0x1863EDD40", Slot = "4")]
	public bool Equals(DDJGKFJPEIA JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x73853C0", Offset = "0x73845C0", VA = "0x1873853C0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5AC00", VA = "0x180D5BA00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7385B40", Offset = "0x7384D40", VA = "0x187385B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7385260", Offset = "0x7384460", VA = "0x187385260")]
	private static EKHABGHIANL EJLCHPGFMKL(byte AINDMPLBNFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7385310", Offset = "0x7384510", VA = "0x187385310")]
	private static IFACMMPAJGL ENOOLOCBHIC(byte AINDMPLBNFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x73859C0", Offset = "0x7384BC0", VA = "0x1873859C0")]
	private static object NACFJAIHMPA(byte AINDMPLBNFF, object[] CJALOAIIOIM, object JEBHMGJFPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7385170", Offset = "0x7384370", VA = "0x187385170")]
	private static int DJLPAACPPDI(byte AINDMPLBNFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7385670", Offset = "0x7384870", VA = "0x187385670")]
	private static int IHHCAMCDFKN(byte AINDMPLBNFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7385940", Offset = "0x7384B40", VA = "0x187385940")]
	private static (int, int) KHBMPEDHGIN(byte AINDMPLBNFF)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7385B30", Offset = "0x7384D30", VA = "0x187385B30")]
	private static byte OJJNLGLGFAE(int LNKNPHKNIOF, int CPLNODNGKGB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7385680", Offset = "0x7384880", VA = "0x187385680")]
	internal static DDJGKFJPEIA JMFBCAGPLCG(IFACMMPAJGL DBLPOFJMIGA, EKHABGHIANL IHKPGDOPBKA)
	{
		return default(DDJGKFJPEIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7385460", Offset = "0x7384660", VA = "0x187385460")]
	internal static void GLLHIOFIBAC(DDJGKFJPEIA AINDMPLBNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7384DE0", Offset = "0x7383FE0", VA = "0x187384DE0")]
	private static void BOHHADNJAKJ(int EKPEFEBPGMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface OGFKJKDGAGB
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDNOCEFAIEG();

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPOHJHEEFJP(bool KJKAGLFMGBA);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDCADDLNFBD(GameObject GBMEGJCINPI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[ServiceLifetime(Lifetime.Application)]
public interface FOEHAKGBLEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Guid KJACAFMKOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ACOOOIECAMF(Guid EBGABJEGGHF, Guid MFMLNNMNGAP, Guid DFBECIKAIGN);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task AHPHJGAHICG(Guid EBGABJEGGHF, Guid[] ELNNIKFBABG, Guid DFBECIKAIGN);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid BKHAIFOFJDG(Guid KMGNKJBKEAL);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PEOOAONGDAA(CIBKNFGEPGP CCCDGDBJIHH);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CLLGHEPDLME(Guid KMGNKJBKEAL);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PFPJBBNGBMA(AHKGBAIIAIA IPIPLIIGPML, Guid ALEAAMGHEAD);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NBFPFNHGKFI(Guid KMGNKJBKEAL, bool MPKIENECBCP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[ServiceLifetime(Lifetime.Application)]
public interface MOPGAAPEFGA
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKGHGCHDMGM(NDNBDIACCIO PPCLEJEKIDG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ServiceLifetime(Lifetime.Application)]
public interface LBGGBDEEMPB
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JBFKIFECMPE(GameObject MNFJKPFBNLN, GameObject JANNLCPMFLP, int EGJOLCEKGFE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ServiceLifetime(Lifetime.Application)]
public interface IJPFLEAABMH
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	OGFKJKDGAGB FPFDMPNMDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	DNFDMMLONNB MANIPFIJKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	DINMDGALBPM IGAAHOKALKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	OOCOMKBKPIP CJEDBFAHFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	JMMIHPHALBI MMDBOABBJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	LIAAHDLGMDA EPDIDEIEBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	JDPDEBAIGFO FKFAOCJJECE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	MPKMKDAOCAG HHFJLGLGBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	HCJGCFJJHIG CDAEMIJDGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	GCLGCHJKJOB DLLBLPBDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	JDKNAHPBEOH GHOAKMIILNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ServiceLifetime(Lifetime.Application)]
public interface DNFDMMLONNB
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string OIOIKDHLEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[ServiceLifetime(Lifetime.Application)]
public interface CDBDKOMMJHB
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMHKCKONBDO(Action KOMGLJOLBFC, bool GAAPFLHHLEM);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DIJKOIIDNJB(string LMOANCJLHKC);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int IILCNBLILDC(string LMOANCJLHKC, int JEBHMGJFPIP);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JKGNFHDAKOH([Out] bool OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CGKFFEODKEP([Out] bool OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MLGJAFOLIFO([Out] int OMEFCJCOLII);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface DINMDGALBPM
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	string DMIPOGDBDED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] NNONMLMBEIP(IEnumerable<FJCKLOBLJMO> JHPJFCHDMIL, bool IENIBDKDMGO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DHJAIMGDLNF(GameObject GBMEGJCINPI, [Out] CBHIEDOMBAP[] FBEGNHDLGJI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JKHMKFCKEHD(GameObject GBMEGJCINPI, [Out] int JOGFPNOCPHJ, [Out] EHDGIFBGGFC FNDCBDLPGJI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AHKGBAIIAIA IHLNFCBAJPB(FJCKLOBLJMO JLBJPEIMAMB);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AHKGBAIIAIA IHLNFCBAJPB(string ACAIINBEMMK, CBHIEDOMBAP[] ACOACGBKLMC, Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, Vector3 KGBNKPFPEFM);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AHKGBAIIAIA GJEACNIHODG(string ACAIINBEMMK, CBHIEDOMBAP[] ACOACGBKLMC, Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, Vector3 KGBNKPFPEFM);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject CNGAOOJCIHK(string ACAIINBEMMK);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HFHILEIMLBG(GameObject PBOGGMEJDDH, bool CICEJGGDGEC);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LFGBLIDMMEK(GameObject GBMEGJCINPI, bool INCPEHBPEOL, bool EGCCLOONGJN);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class NDEOJNKGCHP
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x738F380", Offset = "0x738E580", VA = "0x18738F380")]
	public static AHKGBAIIAIA IHLNFCBAJPB(this DINMDGALBPM CKNLAJJPLCN, Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, Vector3 KGBNKPFPEFM, params CBHIEDOMBAP[] FBEGNHDLGJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x738F230", Offset = "0x738E430", VA = "0x18738F230")]
	public static AHKGBAIIAIA GJEACNIHODG(this DINMDGALBPM CKNLAJJPLCN, Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, Vector3 KGBNKPFPEFM, params CBHIEDOMBAP[] FBEGNHDLGJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ServiceLifetime(Lifetime.Application)]
public interface OOCOMKBKPIP
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNNINGJNOIC(bool MPKIENECBCP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[ServiceLifetime(Lifetime.Application)]
public interface JMMIHPHALBI
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool DCJKFOPBHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool OLFEDGGGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool MACBLHOBMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	int KGEPEICHPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool CEINNCNKOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCMHICAKFAO(object OCPJHHIMKFB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODHHAEJKEKN(object OCPJHHIMKFB);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FDBOGEMHPDH(object MKMPLOHPJDC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LIJPPFODMDG(object MKMPLOHPJDC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId JCOONPKNPGL(GameObject NDKEGGFHGCM);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AAGKKAEABIG(NativeArray<ViewId> DHPMEDCJGKL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BCPGEIFGJHE(NativeArray<ViewId> ENGCJKGCCOP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IKKMICPPKJD();

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IDPGHNBMDNN(uint IIMKKDJMCBG, ReadOnlySpan<byte> PDDKKGGEHOF, bool GHLIMLMICFE = false);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IDPGHNBMDNN(uint IIMKKDJMCBG, ReadOnlySpan<byte> PDDKKGGEHOF, ReadOnlySpan<byte> DHLKJEIHFCB, bool GHLIMLMICFE = false);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KBHNOPIAFDP(Func<int, bool, int> MBNKEAICNGM, bool PGBFJDPGPIJ);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JAPADOHCGDC(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CJPODNLFHEH(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint GBFNHGBFIGN(uint DHKGEFAKBIG);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class AABDLCMIFAM
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7380B10", Offset = "0x737FD10", VA = "0x187380B10")]
	public static JBHABADGGAP OEKDJIAMMIO(this JMMIHPHALBI DNIPNOKEENP, object BCOHKLCJCPM)
	{
		return default(JBHABADGGAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JBHABADGGAP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private JMMIHPHALBI DNIPNOKEENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object BCOHKLCJCPM;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x738B1D0", Offset = "0x738A3D0", VA = "0x18738B1D0")]
	public JBHABADGGAP(JMMIHPHALBI DNIPNOKEENP, object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x738B180", Offset = "0x738A380", VA = "0x18738B180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface LIAAHDLGMDA
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJCBKMGBOMO(GameObject GBMEGJCINPI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface JDPDEBAIGFO
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct LGHKDGKFCMF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private JDPDEBAIGFO PDNBMMLJELG;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x738CFB0", Offset = "0x738C1B0", VA = "0x18738CFB0")]
		public LGHKDGKFCMF(JDPDEBAIGFO PDNBMMLJELG, string KJEMHKAMFCH, string DLGCODNEMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x738CEF0", Offset = "0x738C0F0", VA = "0x18738CEF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct OGANDOPEPDP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private JDPDEBAIGFO PDNBMMLJELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Task JPPEAAIELKB;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x73922B0", Offset = "0x73914B0", VA = "0x1873922B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDEOKJFNBGI(string CBCJFCINKPJ, float NHFPPHNGOPH = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMDAEKBFBGD();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFIOAOIGEKG(bool ONKMPCOJFLF, string KJEMHKAMFCH, string DLGCODNEMDB);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MIHLKGCIGIH
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x738F0C0", Offset = "0x738E2C0", VA = "0x18738F0C0")]
	public static JDPDEBAIGFO.LGHKDGKFCMF BMFAIODKFJK(this JDPDEBAIGFO DNIPNOKEENP, string KJEMHKAMFCH, string DLGCODNEMDB)
	{
		return default(JDPDEBAIGFO.LGHKDGKFCMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface OFFNCIPKFGM
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PNALJMHMLDD(GameObject GBMEGJCINPI);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHMLJLDGNHM(GameObject GBMEGJCINPI);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LBBLNLFNNIC(int NIGKDAPIFGC);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object JAJBGELGNOJ(CIBKNFGEPGP IMMLHGFCKGF, GameObject GBMEGJCINPI, Action<CIBKNFGEPGP, int> FOCHKIPOIOG);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DKHCJBGIDDL(GameObject GBMEGJCINPI, object GHLFGPMNPNH);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface DMOEHHPGNFE
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool KPPDCGBLENA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate CFLBKCGGFMF(KIDJHCMBOHI.BKHBBABDMKN LEGLIHGDPGO, Action<KIDJHCMBOHI.BKHBBABDMKN> FOCHKIPOIOG);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHMFNCPAGEG(KIDJHCMBOHI.BKHBBABDMKN LEGLIHGDPGO, Delegate FOCHKIPOIOG);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate JNKONAALAML(KIDJHCMBOHI.BKHBBABDMKN LEGLIHGDPGO, Action<KIDJHCMBOHI.BKHBBABDMKN> KBFDEKMLNDJ);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BCLIHONBJEE(KIDJHCMBOHI.BKHBBABDMKN LEGLIHGDPGO, Delegate FOCHKIPOIOG);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CDGJNGKBODD(KIDJHCMBOHI.BKHBBABDMKN LEGLIHGDPGO);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KIDJHCMBOHI.BKHBBABDMKN BEEDMOIFGFA(GameObject GBMEGJCINPI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface MPKMKDAOCAG
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int CLEIANAGIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int MLNDNKFIPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool OLFEDGGGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool FIHMLDEAJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool MGLGFJNNKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int JBLKGHKADBC(GameObject GBMEGJCINPI);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ICBIDAFKLPE([Out] Vector3 FCKJMOMOHAE);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MIGGEEMLHDL();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CIBKNFGEPGP JGAKIGAEFBH(int NIGKDAPIFGC);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AIJBDPGLNDF();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface HCJGCFJJHIG
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool ODOKNOMEHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[ServiceLifetime(Lifetime.Application)]
public interface GCLGCHJKJOB
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	ELNPEFEPDJC CEBOGOEKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	AOFAIHBKPNG GDGMCIKKOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDOMJNBMBNO(Transform MCPAEAAAAAM);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJIBOLEHAIJ(Transform MCPAEAAAAAM, NAOAHHFOEAM FHCCDADOPEE);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IECIHMAFFDP(Transform MCPAEAAAAAM, JHEIHPJJONE EIHFAHFNELO);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HJJAJGCFJPG();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OOLHEPDGOOM();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.Application)]
public interface NJJBJAMCHDJ
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.Application)]
public interface JDKNAHPBEOH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PNGHGPHLAII;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANMNCMIAPPM(NDNBDIACCIO GBBIBCFLEMN, bool ONKMPCOJFLF);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface GMJOECAGABP
{
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMOBJNNBFGH();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface DGHDIKBDPGP
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EHDGIFBGGFC BCOHIDNAHKB(GameObject NDKEGGFHGCM);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPOONJFJAJF(GameObject GBMEGJCINPI, BMLLGPFCOHL GACEHKEEAAA, FMALEHIBCFB OGGAPMFCAOE);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HFGHGJNIGME(CIBKNFGEPGP IMMLHGFCKGF, bool LOAKMLAMNGL, float3 KFBMJCBJJBA, quaternion GGAKJELHPMK);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BHJEGGAHGEN(JGGGIHBIMPC EMDADMPPCND, JGGGIHBIMPC MKMPLOHPJDC, CJJHDAEBBAK BGJHPMCGJDB);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGKNPCLHFAH(JGGGIHBIMPC EMDADMPPCND, CJJHDAEBBAK BGJHPMCGJDB);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LHPGOOAILCO(NDNBDIACCIO GAIDLNBALLL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BOAGHFDNHIF(NDNBDIACCIO HHGPPDCIJMN, NativeArray<LocalPoseData> OHGKJIHMNFF, NativeArray<float3> DHNEKBKEIBC);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FFMEIFGOIAF(NDNBDIACCIO HHGPPDCIJMN, NDNBDIACCIO HODGBONNOFH);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FDINCPJHIFI(NDNBDIACCIO HHGPPDCIJMN, bool LDPIJCLBOIF);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AGMDNDDOFJD(NDNBDIACCIO HHGPPDCIJMN, bool JEKICNHGJJJ);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject FMPBJNLGPJG(Guid BKHKAPNIHPG);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LDFOLGIHFLH(KMKOIABPNNL NDNLMFPEABK);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NGOGKCHLFEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly NBAGIFAOMMK JEMCAHPLMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly NBAGIFAOMMK OBOEOHHCBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint EDEOACJOGHP;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x738FC60", Offset = "0x738EE60", VA = "0x18738FC60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct BEKPPODFCEH
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly NGOGKCHLFEL KOMGLJOLBFC;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7383350", Offset = "0x7382550", VA = "0x187383350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct IFKPNOJHEIL
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly NGOGKCHLFEL KOMGLJOLBFC;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7383350", Offset = "0x7382550", VA = "0x187383350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct ONMMECNOMCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly uint EDEOACJOGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal readonly bool OOIPPAHDEHD;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7392990", Offset = "0x7391B90", VA = "0x187392990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct NBAGIFAOMMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal int KLICPJBJAIA;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x738F1D0", Offset = "0x738E3D0", VA = "0x18738F1D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface LCJKNBDPCLI
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	EFGPIFIGPDF MCBPGHOPFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum DPGFDMNJPCH
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Legacy,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface AHKGBAIIAIA : JCCNHPEFPNH
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	DPGFDMNJPCH PJKPHNCALLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool GBBPGAHNJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject GBMEGJCINPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<AHKGBAIIAIA> FCLLELCHFIK;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(EEPABMPJIMJ HMFCAHOKFHD, CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool KBOKCEHFBMD);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class NIMEEKKDCHK
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x738FFA0", Offset = "0x738F1A0", VA = "0x18738FFA0")]
	public static bool JGLAJLBHICG(this AHKGBAIIAIA ONBMLEFABLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x738FEC0", Offset = "0x738F0C0", VA = "0x18738FEC0")]
	public static bool EAOJNDAMMCG(this AHKGBAIIAIA ONBMLEFABLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x738FFF0", Offset = "0x738F1F0", VA = "0x18738FFF0")]
	public static bool ODJMCAFBCPN(this AHKGBAIIAIA ONBMLEFABLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x738FF10", Offset = "0x738F110", VA = "0x18738FF10")]
	public static bool HOKILEEDJAJ(this AHKGBAIIAIA ONBMLEFABLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface JCCNHPEFPNH
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EGOKNOHOJKA
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void OIDPDCLIIDL(DMLDPBOMLKD JHKIAHJNMNO);

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OIDPDCLIIDL EIJJDFBOFKA;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface PAELOLMFKBB
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJFCAPKFIOE(Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, Vector3 KGBNKPFPEFM);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIDFBJMELPN(CIBKNFGEPGP DBEHKFODEEL);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OLFDPJMGKDK(bool HPHDFEFMLJP);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBIGGHDNFOD(bool JEKICNHGJJJ);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface JMGBFNPIPGC
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CBJAADBFEAL
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(CIBKNFGEPGP FPGPHAKEACE);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool LNMONLNDMKM);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACCOHFHDNKL(CIBKNFGEPGP OFNKJKFNBEJ);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface NPPJNBPLKLD
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(ELOCKNMGHMD IBAFHDPININ);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface ELOCKNMGHMD
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	GameObject GBMEGJCINPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Transform MCPAEAAAAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	GPODHFNGINM AMNJKALIOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool MOILGINCIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGMPEJFMCOD(GPODHFNGINM CMFHMEJHOAJ);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GPODHFNGINM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Rigidbody CBOGJJMPNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	ELOCKNMGHMD GKOEGMCBHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	GameObject EBDEMNLMABA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Transform JICGKLMMHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	GPODHFNGINM ACBBFNLKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	GPODHFNGINM KMOBICEOLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	int PFBNKEEHFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool CICFKLPBGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool CDGJNGKBODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool NGMOEHIJKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	NBAEIOPIALM ANCCMGOONMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	PPIGDFPOOHP BHIKJHJICOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float DDDMPMDMEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 JGGPFBFLABC
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 GEOOMBNALKG
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 DIFJPKIBIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Vector3 KGPGDELOCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool CGFDNHECKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool FPGBADHJKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool IOKBCEGNDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool ABPMBIIOFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 BGLIEPHCDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 FEIHJPDIJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Vector3 BOMNJPLGECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Vector3 KDDCIOBPFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	float MHFOCONJJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	float KCGMIHMMMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 BHMICBBNMNM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	Quaternion PNEPICKOIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float KPFLLIFAFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	float CGJJNJKHIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool DECKNFKFENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	NEGICDPELDL FHNLLHPDPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	bool NENADNLDIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Transform JGFGNIJOCBM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Vector3 HPOCEBIKCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	float HCLEOEMBEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	float KNFGAKJFNOC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	Quaternion OKAKNFFOGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Vector3 MLGLPLALOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Quaternion FPDDOGEDCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	RigidbodyConstraints DFENNLLJCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool HKGLPHFJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	CollisionDetectionMode HNEGELGLGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool FCCELNGFEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KDJOAOJNEEJ FFIJIDFLGGH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KDJOAOJNEEJ MJIPJIICMAC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event KDJOAOJNEEJ GILNHIDCMGH;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event KDJOAOJNEEJ GECOOCJHPIF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KDJOAOJNEEJ GCMCIAGJEFF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KDJOAOJNEEJ IKJIFBALHDC;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KDJOAOJNEEJ IDCOKMCLOLB;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event PEPIOKEAOLL OIMNOMEFLGG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<MICCOKKHGKO, MICCOKKHGKO> CCLEFPPHOHC;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	GPODHFNGINM KHGACFDDFNM(int CPLNODNGKGB);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void IDKDLMIKDGJ((Quaternion rot, Vector3 moments) MKOKFACDBAF);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void OPOIMAMNCED();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void ICCGKJEINBI();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void CALOAJDDJBO();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void GHAHEGACDFN();

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void POBEMAFBMNG();

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void HIDFBJMELPN(GPODHFNGINM OMEFCJCOLII, bool OAPIJHCEDGK = false);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void LCLEBDMCNJH(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void KDANOPNNNBM(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 PNNMIOGPOAO(Vector3 OBJBFFGONOB);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 LABHOECDIAM(Vector3 BDFPPBAJEKP);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void DIMCELBBHIA();

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void DIMNJEAJCJN();

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void AEIJIEGLGCB();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void CFEJJDMIMHC(Vector3 DDEHOJMJKFE, Vector3 PBACHNIDMAE);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void BCPOLNFJONJ(Vector3 MNIOOCMEKFF, Vector3 EDPKEMKJOLD);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void ALFKLFMKHGI(Vector3 MODNMCMOGLE);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void KDALCBEOLGH(BCFMLJKNNCD DJDEEKAABAM, Vector3 AFILDHPCPMP, float APGCJNOHJED, float MJCEINCCACJ = 8f, float JCCODJMCPLL = 1f);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void LEOKIPACBIJ(IEAEOEGIAFO PAKJIFKAIDO, Vector3 IBABFPJEHLF, float CJDFGFLAADO = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void LKMEOLGJABC(IEAEOEGIAFO PAKJIFKAIDO, Vector3 EGIHDGHICMO, float ECJPGOHLCGO = 7f, float KJLDKEIPCJB = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 FEIPGENEBFC(Vector3 OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 DKCGHJIBDNM(Vector3 OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void IPMCPJFIIDP();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void CKKGFPNCCLI(GPODHFNGINM HCDEEFMCLII, object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void DMLJBCCJFNC(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void PDHIFPIEOIE();

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void PENJBFJGOBG();

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void HDPMPMKEGEM();

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool DPCOCGEBANM();

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void HILANGOBFJK();

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void PKPIKGGLDIE(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void OONALJJEKJP(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void EKPMOCNLHAD(object BCOHKLCJCPM, bool EEJHBJOAMHG);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void BMKDLIBFKMC(Vector3 EBFOEOCLHGJ, Quaternion MFCDNHAADAP);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void PIKILGLOGDG(Vector3 DKEJLDLNJBE, Quaternion GFIIPINEBMA);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool ELFECLJNMED(float DDDEDIGFCFH);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void OOOLBHPAIEO(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void OGHBFEGPNEK(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void MCBPMNODKFL(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void JFABOKLMNDF(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void GCCCNLIILHO(Vector3 DCOODACAFGM, ForceMode POEIPILMDFG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void BODMKGKEOCI(Vector3 DCOODACAFGM, Vector3 FCKJMOMOHAE, ForceMode POEIPILMDFG);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void CEPGKDELPKB(Vector3 KDCKDOGBGNN, ForceMode POEIPILMDFG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void DPJFNBALGHE(Vector3 KDCKDOGBGNN, ForceMode POEIPILMDFG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool CLHJEHDCPKJ(Vector3 BDIPLNMOFCC, [Out] RaycastHit FIAPOMAPPID, float ABBGAHJHLCA);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void MPIJFJILGIL();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface PPIGDFPOOHP
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOCKPGECGLB(Vector3 CKELMDDGHGB);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EAGLEDBELIH(Vector3 HGECGPDEJMF);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MOFEHMEIMEH(Vector3 CKELMDDGHGB);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LDJCHCHGNPL(Vector3 HGECGPDEJMF);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface NBAEIOPIALM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 ANNBLCAKDAM();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 KIJCJCMDGHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public delegate void KDJOAOJNEEJ(ELOCKNMGHMD MCNOCAMEAMN);
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum ADALCMDJONM
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum BCFMLJKNNCD
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public delegate void PEPIOKEAOLL(ELOCKNMGHMD MCNOCAMEAMN, bool OAPIJHCEDGK = false);
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum IEAEOEGIAFO
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct ENALNGMJFGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Rigidbody DKODMFMIHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public object CEPBBDKEOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 BAKALIDCPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector3 JBBMMGPDEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DCBINGCLJFB KNCGOCBINPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool NEFLKGGHJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool KLDMBJIFDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool HABIAAMKKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public bool HFFGCGDGFPP;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct JGGGIHBIMPC : IEquatable<JGGGIHBIMPC>, JCCNHPEFPNH
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly JGGGIHBIMPC JBOFFCIPJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0", Slot = "6")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public NKOOLANNBNC JICGKLMMHCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(NKOOLANNBNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public AHJFAOGJBHP GKLKJFNCMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(AHJFAOGJBHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GameObject GBMEGJCINPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x738B2F0", Offset = "0x738A4F0", VA = "0x18738B2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public CBHIEDOMBAP HDMNJNIINFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x738B610", Offset = "0x738A810", VA = "0x18738B610")]
		get
		{
			return default(CBHIEDOMBAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public LDMHHIICGCO FFKKKJJEBGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x738B8F0", Offset = "0x738AAF0", VA = "0x18738B8F0")]
		get
		{
			return default(LDMHHIICGCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public EHDGIFBGGFC LLBNGKPLLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x738B6B0", Offset = "0x738A8B0", VA = "0x18738B6B0")]
		get
		{
			return default(EHDGIFBGGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool FCJLHDJKHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x738B490", Offset = "0x738A690", VA = "0x18738B490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool LHJEKAJGFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x738B4B0", Offset = "0x738A6B0", VA = "0x18738B4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool IJLJOLLMPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x738B5C0", Offset = "0x738A7C0", VA = "0x18738B5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool HBPEDLKNBEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x738B9F0", Offset = "0x738ABF0", VA = "0x18738B9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool NOMGDFGLALE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x738B560", Offset = "0x738A760", VA = "0x18738B560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool GHDAPKEEMFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x738B990", Offset = "0x738AB90", VA = "0x18738B990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool BCLHAAIJKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x738B9B0", Offset = "0x738ABB0", VA = "0x18738B9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool OAFIHCDJCAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x738B580", Offset = "0x738A780", VA = "0x18738B580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public FOGACMNCEOH AGFHEFFALEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(FOGACMNCEOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JALOONJGCBG NGPCOGODCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JALOONJGCBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public FGGCJBJPOGA IIPLGCGLGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(FGGCJBJPOGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public LDODLPECHGP FKFGOPMACCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(LDODLPECHGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public CLDCDHDPMHJ LFEEBGONJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CLDCDHDPMHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public OLCKBJNEJMB OKHLOAEOOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(OLCKBJNEJMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public EDONPPNMBOM MNHBHGDFLHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(EDONPPNMBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LNCEOKMPAEE NCPCFMKKHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(LNCEOKMPAEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public FPOGNLMFMDE BNILFFPJNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(FPOGNLMFMDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public FBBPAFKAHPD MOOHIAGICGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(FBBPAFKAHPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public PFDBOGLGCII MOKNNBMEJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(PFDBOGLGCII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public HFHFHLPLPCD OIDEPPODPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(HFHFHLPLPCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public NJNDFCHGGPE NEFJEKIHIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(NJNDFCHGGPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public JOMIIFNHCOG FCHEHHOKAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JOMIIFNHCOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool JGLAJLBHICG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x738B780", Offset = "0x738A980", VA = "0x18738B780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool LLGPGNPDIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x738BA10", Offset = "0x738AC10", VA = "0x18738BA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool EPAODHFMBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x738B2B0", Offset = "0x738A4B0", VA = "0x18738B2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool GELPOKBCLAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public JGGGIHBIMPC(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7381C30", Offset = "0x7380E30", VA = "0x187381C30")]
	public static bool KEDBNOKLEHE(JGGGIHBIMPC OMEFCJCOLII)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static CIBKNFGEPGP KEDBNOKLEHE(JGGGIHBIMPC OMEFCJCOLII)
	{
		return default(CIBKNFGEPGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x738B480", Offset = "0x738A680", VA = "0x18738B480")]
	public static bool CCHBIHOFELC(JGGGIHBIMPC KKLLOEEDINO, JGGGIHBIMPC NHCGDJCFKIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7381B00", Offset = "0x7380D00", VA = "0x187381B00")]
	public static bool IMFBACMHPLD(JGGGIHBIMPC KKLLOEEDINO, JGGGIHBIMPC NHCGDJCFKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x738B4D0", Offset = "0x738A6D0", VA = "0x18738B4D0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(JGGGIHBIMPC JAINJPLCLDO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static JGGGIHBIMPC KEDBNOKLEHE(CIBKNFGEPGP MMGDIFNEOOE)
	{
		return default(JGGGIHBIMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x738B870", Offset = "0x738AA70", VA = "0x18738B870")]
	public AICJJJCJBNN NHMJJCINCMG()
	{
		return default(AICJJJCJBNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x738B750", Offset = "0x738A950", VA = "0x18738B750")]
	public AHLKFMNMFMG LMADOPGPNEK()
	{
		return default(AHLKFMNMFMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x738B260", Offset = "0x738A460", VA = "0x18738B260")]
	public PGPPOOJGNLB AEDKLLDMKCG()
	{
		return default(PGPPOOJGNLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x738B5E0", Offset = "0x738A7E0", VA = "0x18738B5E0")]
	public PCKOBJNGIFF JKBKMNIPNOL()
	{
		return default(PCKOBJNGIFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x738BA50", Offset = "0x738AC50", VA = "0x18738BA50")]
	public void PMPJGBMMBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x738BAF0", Offset = "0x738ACF0", VA = "0x18738BAF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct EDONPPNMBOM : IEquatable<EDONPPNMBOM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7386900", Offset = "0x7385B00", VA = "0x187386900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private CGADFIBDDDE ACODKICIOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7386A20", Offset = "0x7385C20", VA = "0x187386A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool EIMCBFFEEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7386990", Offset = "0x7385B90", VA = "0x187386990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Guid ADMIMLPKILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x73862D0", Offset = "0x73854D0", VA = "0x1873862D0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool JLEKPKGHOEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7386750", Offset = "0x7385950", VA = "0x187386750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Guid GBLKJPFBIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x73867E0", Offset = "0x73859E0", VA = "0x1873867E0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public EDONPPNMBOM(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7386480", Offset = "0x7385680", VA = "0x187386480", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(EDONPPNMBOM JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7386230", Offset = "0x7385430", VA = "0x187386230")]
	public bool ABBBNKLHHGP([Out] Guid KMGNKJBKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7386630", Offset = "0x7385830", VA = "0x187386630")]
	public void HLEALHAHCEB(Guid IAPIOFHOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7386A80", Offset = "0x7385C80", VA = "0x187386A80")]
	public bool PFNFJIPBOIM([Out] Guid MFMLNNMNGAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7386510", Offset = "0x7385710", VA = "0x187386510")]
	public void FDAAGDIBGEC(Guid IAPIOFHOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x73863F0", Offset = "0x73855F0", VA = "0x1873863F0")]
	public void BCABDECGMBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct PGPPOOJGNLB : IEquatable<PGPPOOJGNLB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7393AE0", Offset = "0x7392CE0", VA = "0x187393AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private DKGIONCBAMG OIJMBOLNAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7393E40", Offset = "0x7393040", VA = "0x187393E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 PKEGGELNBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x73937C0", Offset = "0x73929C0", VA = "0x1873937C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Quaternion OAODDNJKKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x73939A0", Offset = "0x7392BA0", VA = "0x1873939A0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public JGGGIHBIMPC CJJNODELAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x73935F0", Offset = "0x73927F0", VA = "0x1873935F0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public PGPPOOJGNLB(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7381C30", Offset = "0x7380E30", VA = "0x187381C30")]
	public static bool KEDBNOKLEHE(PGPPOOJGNLB OMEFCJCOLII)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static CIBKNFGEPGP KEDBNOKLEHE(PGPPOOJGNLB OMEFCJCOLII)
	{
		return default(CIBKNFGEPGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7393910", Offset = "0x7392B10", VA = "0x187393910", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(PGPPOOJGNLB JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7393680", Offset = "0x7392880", VA = "0x187393680")]
	public NDNBDIACCIO AKBCODOEJDO(Allocator NNHCNMKJHLF)
	{
		return default(NDNBDIACCIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7393EA0", Offset = "0x73930A0", VA = "0x187393EA0")]
	public void NOMACKDPDMJ(Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7393D30", Offset = "0x7392F30", VA = "0x187393D30")]
	public void NNLEFBGKLML(float KGBNKPFPEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7393B70", Offset = "0x7392D70", VA = "0x187393B70")]
	public void NJIJJEGHGGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct AICJJJCJBNN : IEquatable<AICJJJCJBNN>
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly AICJJJCJBNN JBOFFCIPJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public NKOOLANNBNC JICGKLMMHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(NKOOLANNBNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public AHJFAOGJBHP GKLKJFNCMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(AHJFAOGJBHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7382D60", Offset = "0x7381F60", VA = "0x187382D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	private GGFBFEIEEOM BEGDCEHLMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7383140", Offset = "0x7382340", VA = "0x187383140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public NDNBDIACCIO BDFBMIBGNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7383020", Offset = "0x7382220", VA = "0x187383020")]
		get
		{
			return default(NDNBDIACCIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public IEnumerable<JGGGIHBIMPC> ICEEGCEHMMH
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7382B40", Offset = "0x7381D40", VA = "0x187382B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public IEnumerable<JGGGIHBIMPC> KAMJEIHPPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7382940", Offset = "0x7381B40", VA = "0x187382940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public int PFBNKEEHFCP
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7382CD0", Offset = "0x7381ED0", VA = "0x187382CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public int JPDAOOLEHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7382A70", Offset = "0x7381C70", VA = "0x187382A70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7381ED0", Offset = "0x73810D0", VA = "0x187381ED0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7382AC0", Offset = "0x7381CC0", VA = "0x187382AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public AICJJJCJBNN(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7381C30", Offset = "0x7380E30", VA = "0x187381C30")]
	public static bool KEDBNOKLEHE(AICJJJCJBNN OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x73828B0", Offset = "0x7381AB0", VA = "0x1873828B0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(AICJJJCJBNN JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static JGGGIHBIMPC KEDBNOKLEHE(AICJJJCJBNN MLNFAKCEGNM)
	{
		return default(JGGGIHBIMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7382CB0", Offset = "0x7381EB0", VA = "0x187382CB0")]
	public bool KMDIMEFEMNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7382DF0", Offset = "0x7381FF0", VA = "0x187382DF0")]
	public NDNBDIACCIO MJMJFFHCFDL(Allocator NNHCNMKJHLF)
	{
		return default(NDNBDIACCIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7382500", Offset = "0x7381700", VA = "0x187382500")]
	public void EJKJKGLMCNF(AICJJJCJBNN JAINJPLCLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7381F50", Offset = "0x7381150", VA = "0x187381F50")]
	public void CBJFADLIHNB(List<JGGGIHBIMPC> ELMABPNEBJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct JOMIIFNHCOG : IEquatable<JOMIIFNHCOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool CKEJEOLIIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x738C110", Offset = "0x738B310", VA = "0x18738C110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public Vector3 BHMOGDLIHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x738C090", Offset = "0x738B290", VA = "0x18738C090")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x738C260", Offset = "0x738B460", VA = "0x18738C260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public JOMIIFNHCOG(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x738C150", Offset = "0x738B350", VA = "0x18738C150", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(JOMIIFNHCOG JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x738C090", Offset = "0x738B290", VA = "0x18738C090")]
	public Vector3 CGFJKBGHLIP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x738C1E0", Offset = "0x738B3E0", VA = "0x18738C1E0")]
	public void PJHBDAEPOHO([In] Vector3 OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x738C020", Offset = "0x738B220", VA = "0x18738C020")]
	public bool ACAHFDBHHNJ([In] Vector3 OMEFCJCOLII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct JALOONJGCBG : IEquatable<JALOONJGCBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public JALOONJGCBG(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x738AFB0", Offset = "0x738A1B0", VA = "0x18738AFB0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(JALOONJGCBG JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x738B0E0", Offset = "0x738A2E0", VA = "0x18738B0E0")]
	public void PMJODLDALJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x738B040", Offset = "0x738A240", VA = "0x18738B040")]
	public bool HFDJDCMFCGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct AHJFAOGJBHP : IEquatable<AHJFAOGJBHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x73812A0", Offset = "0x73804A0", VA = "0x1873812A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private GGFBFEIEEOM BEGDCEHLMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7381490", Offset = "0x7380690", VA = "0x187381490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public CIBKNFGEPGP LAJNHPPMPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x73814F0", Offset = "0x73806F0", VA = "0x1873814F0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public JGGGIHBIMPC ACBBFNLKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7380D70", Offset = "0x737FF70", VA = "0x187380D70")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public JGGGIHBIMPC KMOBICEOLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7380FF0", Offset = "0x73801F0", VA = "0x187380FF0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public int PFBNKEEHFCP
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x73811C0", Offset = "0x73803C0", VA = "0x1873811C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public AHJFAOGJBHP(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7380CD0", Offset = "0x737FED0", VA = "0x187380CD0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(AHJFAOGJBHP JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7380E30", Offset = "0x7380030", VA = "0x187380E30")]
	public bool HIDFBJMELPN(JGGGIHBIMPC DBEHKFODEEL, bool MEHDOJDAFOD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x73813F0", Offset = "0x73805F0", VA = "0x1873813F0")]
	public bool MNKAEDBJMDO(JGGGIHBIMPC FNIOOAHGDGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7381580", Offset = "0x7380780", VA = "0x187381580")]
	private void PIDGJFBMAOP(JGGGIHBIMPC OKPOLOPFKEH, List<JGGGIHBIMPC> ALNLOFIPMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x73811A0", Offset = "0x73803A0", VA = "0x1873811A0")]
	public bool KMDIMEFEMNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7380CC0", Offset = "0x737FEC0", VA = "0x187380CC0")]
	public void DHCNCLOBBBB(List<JGGGIHBIMPC> APABBPBNAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7380F60", Offset = "0x7380160", VA = "0x187380F60")]
	public AICJJJCJBNN HKOKFENEOAB()
	{
		return default(AICJJJCJBNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7381330", Offset = "0x7380530", VA = "0x187381330")]
	public void MCFFOAGCNBK(List<JGGGIHBIMPC> APABBPBNAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7381080", Offset = "0x7380280", VA = "0x187381080")]
	public NativeArray<CIBKNFGEPGP> KDPKGOKIOPJ()
	{
		return default(NativeArray<CIBKNFGEPGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7380C30", Offset = "0x737FE30", VA = "0x187380C30")]
	public int BAPKNNIDIAP()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct FOGACMNCEOH : IEquatable<FOGACMNCEOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string OEOKJNDFNOG
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x73891E0", Offset = "0x73883E0", VA = "0x1873891E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string HDLFCEDJEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7389020", Offset = "0x7388220", VA = "0x187389020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private bool CLALJBCCOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7389260", Offset = "0x7388460", VA = "0x187389260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string BJFLCACACIP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7389400", Offset = "0x7388600", VA = "0x187389400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public string PGJLAPFIFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7388DD0", Offset = "0x7387FD0", VA = "0x187388DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string LBNOKHPPNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7388CE0", Offset = "0x7387EE0", VA = "0x187388CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public FOGACMNCEOH(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7389150", Offset = "0x7388350", VA = "0x187389150", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(FOGACMNCEOH JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct PFDBOGLGCII : IEquatable<PFDBOGLGCII>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7393390", Offset = "0x7392590", VA = "0x187393390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private GJHKOCHJLHN KPPEGACJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7392FE0", Offset = "0x73921E0", VA = "0x187392FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public KEADHBOCJDP OHCCDAHGJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7392BD0", Offset = "0x7391DD0", VA = "0x187392BD0")]
		get
		{
			return default(KEADHBOCJDP);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7393280", Offset = "0x7392480", VA = "0x187393280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool LKOKNKDEMMH
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7393040", Offset = "0x7392240", VA = "0x187393040")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7392E10", Offset = "0x7392010", VA = "0x187392E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public string[] MIJFDMJEDLF
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7393420", Offset = "0x7392620", VA = "0x187393420")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7392CD0", Offset = "0x7391ED0", VA = "0x187392CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public string[] KECGCNBELAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x73931F0", Offset = "0x73923F0", VA = "0x1873931F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7392D70", Offset = "0x7391F70", VA = "0x187392D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public string[] CALIABFLKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7392EB0", Offset = "0x73920B0", VA = "0x187392EB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7392F40", Offset = "0x7392140", VA = "0x187392F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string[] EEIAOICEEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7393160", Offset = "0x7392360", VA = "0x187393160")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7393550", Offset = "0x7392750", VA = "0x187393550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public PFDBOGLGCII(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static CIBKNFGEPGP KEDBNOKLEHE(PFDBOGLGCII OMEFCJCOLII)
	{
		return default(CIBKNFGEPGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x73930D0", Offset = "0x73922D0", VA = "0x1873930D0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(PFDBOGLGCII JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x73934B0", Offset = "0x73926B0", VA = "0x1873934B0")]
	public bool NAHNPLEDADD(CIBKNFGEPGP IBFPGGCAJBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct BHLPNJBIFPM : IEquatable<BHLPNJBIFPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x73833F0", Offset = "0x73825F0", VA = "0x1873833F0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(BHLPNJBIFPM JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct FGGCJBJPOGA : IEquatable<FGGCJBJPOGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Collider MNHFNJKGPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7387E80", Offset = "0x7387080", VA = "0x187387E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public BDJEHBJKPBL BJJCOINBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7388560", Offset = "0x7387760", VA = "0x187388560")]
		get
		{
			return default(BDJEHBJKPBL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x73881D0", Offset = "0x73873D0", VA = "0x1873881D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public GMCNNNOCDCB MFADENPPAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x73882F0", Offset = "0x73874F0", VA = "0x1873882F0")]
		get
		{
			return default(GMCNNNOCDCB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x73883F0", Offset = "0x73875F0", VA = "0x1873883F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public PGGGFOKEONL HOGPMLMBPKF
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7388150", Offset = "0x7387350", VA = "0x187388150")]
		get
		{
			return default(PGGGFOKEONL);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7387E30", Offset = "0x7387030", VA = "0x187387E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public float GPLOAICLOAI
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7388190", Offset = "0x7387390", VA = "0x187388190")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7388330", Offset = "0x7387530", VA = "0x187388330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool KAGEEALEJDE
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x73884B0", Offset = "0x73876B0", VA = "0x1873884B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public bool ADBEPEHKNAL
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7388380", Offset = "0x7387580", VA = "0x187388380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool GCFGCOCIFGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7388220", Offset = "0x7387420", VA = "0x187388220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool EJCBKDODFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7388060", Offset = "0x7387260", VA = "0x187388060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool IGCCCLINHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7388520", Offset = "0x7387720", VA = "0x187388520")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7388700", Offset = "0x7387900", VA = "0x187388700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool PADMEKHDIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7387DE0", Offset = "0x7386FE0", VA = "0x187387DE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7388440", Offset = "0x7387640", VA = "0x187388440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public FGGCJBJPOGA(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7387FD0", Offset = "0x73871D0", VA = "0x187387FD0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(FGGCJBJPOGA JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x73885A0", Offset = "0x73877A0", VA = "0x1873885A0")]
	public bool NLBHAGIEDEG([Out] CBJAADBFEAL GIBMJBECLPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7388770", Offset = "0x7387970", VA = "0x187388770")]
	public bool OJJAPILJKHN([Out] CIBKNFGEPGP DONMCNODAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7388290", Offset = "0x7387490", VA = "0x187388290")]
	public bool INCPOICJLFF(EFIBLMLADKJ CGDNKIJMMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x73880D0", Offset = "0x73872D0", VA = "0x1873880D0")]
	public void HFHGPDLJONB(EFIBLMLADKJ CGDNKIJMMML, bool FOFAGPDFKME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct PCKOBJNGIFF : IEquatable<PCKOBJNGIFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public bool HLHBMIFBDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7392B80", Offset = "0x7391D80", VA = "0x187392B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public PCKOBJNGIFF(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7392AF0", Offset = "0x7391CF0", VA = "0x187392AF0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(PCKOBJNGIFF JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct FPOGNLMFMDE : IEquatable<FPOGNLMFMDE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7389620", Offset = "0x7388820", VA = "0x187389620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private PFGAACPCDNO FLMMIAIIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x73896B0", Offset = "0x73888B0", VA = "0x1873896B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public FPOGNLMFMDE(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x73894F0", Offset = "0x73886F0", VA = "0x1873894F0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(FPOGNLMFMDE JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7389580", Offset = "0x7388780", VA = "0x187389580")]
	public void IHIIDJADNOH(bool DACNABCKDLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct LDODLPECHGP : IEquatable<LDODLPECHGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x738CD20", Offset = "0x738BF20", VA = "0x18738CD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool CICAAIMGLCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x738CA20", Offset = "0x738BC20", VA = "0x18738CA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool FBEKJEBKOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x738CC80", Offset = "0x738BE80", VA = "0x18738CC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool MMFLIJIFENE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x738CAF0", Offset = "0x738BCF0", VA = "0x18738CAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool LCNIFAACJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x738CDB0", Offset = "0x738BFB0", VA = "0x18738CDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool CBJNPNCEJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x738C280", Offset = "0x738B480", VA = "0x18738C280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool PNJLJKEFMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x738CE00", Offset = "0x738C000", VA = "0x18738CE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool HBBMBFBIOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x738CA60", Offset = "0x738BC60", VA = "0x18738CA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool ALEHADKHLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x738CEA0", Offset = "0x738C0A0", VA = "0x18738CEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool KPHDOMHLGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x738C480", Offset = "0x738B680", VA = "0x18738C480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool JLLHKMHNIBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x738CCD0", Offset = "0x738BED0", VA = "0x18738CCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool FJKACJIOOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x738C6A0", Offset = "0x738B8A0", VA = "0x18738C6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool NEJMHNCFBDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x738C9D0", Offset = "0x738BBD0", VA = "0x18738C9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool HCOBHBLCDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x738C390", Offset = "0x738B590", VA = "0x18738C390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool LFMKCLLEKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x738CAB0", Offset = "0x738BCB0", VA = "0x18738CAB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x738C640", Offset = "0x738B840", VA = "0x18738C640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public CKFIOHPKJNE HDHDIDINNIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x738C510", Offset = "0x738B710", VA = "0x18738C510")]
		get
		{
			return default(CKFIOHPKJNE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x738CE50", Offset = "0x738C050", VA = "0x18738CE50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool MEAAOALPIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x738C6F0", Offset = "0x738B8F0", VA = "0x18738C6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public FMALEHIBCFB BKECIBEFGGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x738CB40", Offset = "0x738BD40", VA = "0x18738CB40")]
		get
		{
			return default(FMALEHIBCFB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x738C900", Offset = "0x738BB00", VA = "0x18738C900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool ODHJJLCGDEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x738C4D0", Offset = "0x738B6D0", VA = "0x18738C4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Vector3 GIFAPIJJDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x738C950", Offset = "0x738BB50", VA = "0x18738C950")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public Vector3 LECPGBFHELI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x738C310", Offset = "0x738B510", VA = "0x18738C310")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool DKDLMIDEGAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x738CB80", Offset = "0x738BD80", VA = "0x18738CB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public LDODLPECHGP(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x738C550", Offset = "0x738B750", VA = "0x18738C550", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(LDODLPECHGP JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x738C5E0", Offset = "0x738B7E0", VA = "0x18738C5E0")]
	public bool GCAFOLPADLB(LJJMOJEAPPO CGDNKIJMMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x738C430", Offset = "0x738B630", VA = "0x18738C430")]
	public bool EBFDEDCOCNE(BMLLGPFCOHL CGDNKIJMMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x738C880", Offset = "0x738BA80", VA = "0x18738C880")]
	public void GMIOLNHPNML(BMLLGPFCOHL CGDNKIJMMML, bool FOFAGPDFKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x738C2D0", Offset = "0x738B4D0", VA = "0x18738C2D0")]
	public BMLLGPFCOHL BNBDIHPMHIL()
	{
		return default(BMLLGPFCOHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x738C3E0", Offset = "0x738B5E0", VA = "0x18738C3E0")]
	public bool DNEECLACJKH(BMLLGPFCOHL OMEFCJCOLII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct FBBPAFKAHPD : IEquatable<FBBPAFKAHPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7387A00", Offset = "0x7386C00", VA = "0x187387A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private BKDBNGEINBI JLJEIANAGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7387D80", Offset = "0x7386F80", VA = "0x187387D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public FBBPAFKAHPD(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7387550", Offset = "0x7386750", VA = "0x187387550", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(FBBPAFKAHPD JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x73877C0", Offset = "0x73869C0", VA = "0x1873877C0")]
	public bool IKLBBKHHGBM(CJJHDAEBBAK BGJHPMCGJDB, List<JGGGIHBIMPC> ELMABPNEBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x73878F0", Offset = "0x7386AF0", VA = "0x1873878F0")]
	public int JCOFPFILNOC(CJJHDAEBBAK BGJHPMCGJDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7387BC0", Offset = "0x7386DC0", VA = "0x187387BC0")]
	public void NEDNIFINFOD(List<JGGGIHBIMPC> ELMABPNEBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7387200", Offset = "0x7386400", VA = "0x187387200")]
	public int CGOOINFGAFC(JGGGIHBIMPC MKMPLOHPJDC, CJJHDAEBBAK BGJHPMCGJDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7387690", Offset = "0x7386890", VA = "0x187387690")]
	public JGGGIHBIMPC GNGEMJMGCGA(int CPLNODNGKGB, CJJHDAEBBAK BGJHPMCGJDB)
	{
		return default(JGGGIHBIMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7387A90", Offset = "0x7386C90", VA = "0x187387A90")]
	public void MBJHGMDOINH(JGGGIHBIMPC MKMPLOHPJDC, CJJHDAEBBAK BGJHPMCGJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7387CD0", Offset = "0x7386ED0", VA = "0x187387CD0")]
	public bool OGJHLJPAGGO(JGGGIHBIMPC MKMPLOHPJDC, CJJHDAEBBAK BGJHPMCGJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7387330", Offset = "0x7386530", VA = "0x187387330")]
	public void DCMLNBGGBFC(CJJHDAEBBAK BGJHPMCGJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x73875E0", Offset = "0x73867E0", VA = "0x1873875E0")]
	public bool GNGCGFOFDBF(JGGGIHBIMPC MKMPLOHPJDC, CJJHDAEBBAK BGJHPMCGJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7387440", Offset = "0x7386640", VA = "0x187387440")]
	public bool DPFDKIACAPK(CJJHDAEBBAK BGJHPMCGJDB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct OLCKBJNEJMB : IEquatable<OLCKBJNEJMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7392900", Offset = "0x7391B00", VA = "0x187392900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public OLCKBJNEJMB(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7392870", Offset = "0x7391A70", VA = "0x187392870", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(OLCKBJNEJMB JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x73927E0", Offset = "0x73919E0", VA = "0x1873927E0")]
	public void DDBIPINGMMD(bool OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7392750", Offset = "0x7391950", VA = "0x187392750")]
	public void CBPAOJGANGL(bool OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x344B970", Offset = "0x344AB70", VA = "0x18344B970")]
	public T JEBAAAOGHKJ<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct HFHFHLPLPCD : IEquatable<HFHFHLPLPCD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7389E30", Offset = "0x7389030", VA = "0x187389E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private PGLLOHJHJLK NKADHBLLGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7389EC0", Offset = "0x73890C0", VA = "0x187389EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool OPIHNCLABBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7389C80", Offset = "0x7388E80", VA = "0x187389C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool FKBGBIPAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7389DA0", Offset = "0x7388FA0", VA = "0x187389DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public HFHFHLPLPCD(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7389D10", Offset = "0x7388F10", VA = "0x187389D10", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(HFHFHLPLPCD JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct HEOIMHIHOIC : IEquatable<HEOIMHIHOIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7389BF0", Offset = "0x7388DF0", VA = "0x187389BF0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(HEOIMHIHOIC JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct CLDCDHDPMHJ : IEquatable<CLDCDHDPMHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7384660", Offset = "0x7383860", VA = "0x187384660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private LMAKPLIKPNH LLIDBCKKEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7383E50", Offset = "0x7383050", VA = "0x187383E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private GKABMLCHAOI EGHLFPPJGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7384450", Offset = "0x7383650", VA = "0x187384450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool LLJDMKGOLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7383F50", Offset = "0x7383150", VA = "0x187383F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool LHGFBACECGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7383DB0", Offset = "0x7382FB0", VA = "0x187383DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool LOPCIFPHHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7384210", Offset = "0x7383410", VA = "0x187384210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool OLHIPCEGEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7384830", Offset = "0x7383A30", VA = "0x187384830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool PGNBOOJODPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x7383FE0", Offset = "0x73831E0", VA = "0x187383FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public bool EHOEEHFEDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x73847A0", Offset = "0x73839A0", VA = "0x1873847A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public bool OOOLINPOEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x7384900", Offset = "0x7383B00", VA = "0x187384900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool GIDDLBBHGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7384010", Offset = "0x7383210", VA = "0x187384010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool GGKLCPJBPOP
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x7384240", Offset = "0x7383440", VA = "0x187384240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public CLDCDHDPMHJ(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7381C30", Offset = "0x7380E30", VA = "0x187381C30")]
	public static bool KEDBNOKLEHE(CLDCDHDPMHJ OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7384180", Offset = "0x7383380", VA = "0x187384180", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(CLDCDHDPMHJ JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x73843E0", Offset = "0x73835E0", VA = "0x1873843E0")]
	public bool HHEPCGOGMJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x7383EB0", Offset = "0x73830B0", VA = "0x187383EB0")]
	public JGGGIHBIMPC EAONGGDKPHB(JGGGIHBIMPC MKMPLOHPJDC)
	{
		return default(JGGGIHBIMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x7384550", Offset = "0x7383750", VA = "0x187384550")]
	public CIBKNFGEPGP KMLNLJOKGEE()
	{
		return default(CIBKNFGEPGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7384B10", Offset = "0x7383D10", VA = "0x187384B10")]
	public bool PMIEGFDAJCD(CIBKNFGEPGP HOPGEAJFCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x73844B0", Offset = "0x73836B0", VA = "0x1873844B0")]
	public bool JCCFBJBBCAK(CIBKNFGEPGP BGMMBAEMHDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x73846F0", Offset = "0x73838F0", VA = "0x1873846F0")]
	public bool MKBDPGIABKA(CIBKNFGEPGP MKMPLOHPJDC, [Out] CIBKNFGEPGP HOPGEAJFCDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct AHLKFMNMFMG : IEquatable<AHLKFMNMFMG>
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly AHLKFMNMFMG JBOFFCIPJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public NKOOLANNBNC JICGKLMMHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(NKOOLANNBNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public AHJFAOGJBHP GKLKJFNCMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(AHJFAOGJBHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public GCOJHJHCPIC BDALKFLNCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7381DA0", Offset = "0x7380FA0", VA = "0x187381DA0")]
		get
		{
			return default(GCOJHJHCPIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public MIAEMOOKOJL GOJFOHDEPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x7381BF0", Offset = "0x7380DF0", VA = "0x187381BF0")]
		get
		{
			return default(MIAEMOOKOJL);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x7381DE0", Offset = "0x7380FE0", VA = "0x187381DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public MOEHFGBKLHG JFIBOJKBAAO
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x7381B20", Offset = "0x7380D20", VA = "0x187381B20")]
		get
		{
			return default(MOEHFGBKLHG);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x7381C50", Offset = "0x7380E50", VA = "0x187381C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float DLPNCANMJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x7381990", Offset = "0x7380B90", VA = "0x187381990")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x7381820", Offset = "0x7380A20", VA = "0x187381820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 DANKFNBFDGD
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x73819D0", Offset = "0x7380BD0", VA = "0x1873819D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7381D20", Offset = "0x7380F20", VA = "0x187381D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float GDLFEMJPKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7381BA0", Offset = "0x7380DA0", VA = "0x187381BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public GCEHINAIMFJ DBHPKMFMDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7381870", Offset = "0x7380A70", VA = "0x187381870")]
		get
		{
			return default(GCEHINAIMFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x73818B0", Offset = "0x7380AB0", VA = "0x1873818B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool LBIGOPPPGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7381B60", Offset = "0x7380D60", VA = "0x187381B60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x7381A50", Offset = "0x7380C50", VA = "0x187381A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public AHLKFMNMFMG(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7381C30", Offset = "0x7380E30", VA = "0x187381C30")]
	public static bool KEDBNOKLEHE(AHLKFMNMFMG OMEFCJCOLII)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7381B00", Offset = "0x7380D00", VA = "0x187381B00")]
	public static bool IMFBACMHPLD(AHLKFMNMFMG KKLLOEEDINO, AHLKFMNMFMG NHCGDJCFKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7381900", Offset = "0x7380B00", VA = "0x187381900", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(AHLKFMNMFMG JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7381AB0", Offset = "0x7380CB0", VA = "0x187381AB0")]
	public MDMHKPBJOEA ILLPNDNOHPJ()
	{
		return default(MDMHKPBJOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7381E30", Offset = "0x7381030", VA = "0x187381E30")]
	public MIFOPKBCNCO MONDFINIIOC()
	{
		return default(MIFOPKBCNCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7381E80", Offset = "0x7381080", VA = "0x187381E80")]
	private bool OIIKEBOJAIH(GCEHINAIMFJ CGDNKIJMMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7381CA0", Offset = "0x7380EA0", VA = "0x187381CA0")]
	public void KLCKJGOFEOF(GCEHINAIMFJ CGDNKIJMMML, bool FOFAGPDFKME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct MDMHKPBJOEA : IEquatable<MDMHKPBJOEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public AHLKFMNMFMG LOFPEAOEMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(AHLKFMNMFMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public EAOBBGHPEOO LDFDLFIBENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x738DF60", Offset = "0x738D160", VA = "0x18738DF60")]
		get
		{
			return default(EAOBBGHPEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public MDMHKPBJOEA(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7381C30", Offset = "0x7380E30", VA = "0x187381C30")]
	public static bool KEDBNOKLEHE(MDMHKPBJOEA OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x738DED0", Offset = "0x738D0D0", VA = "0x18738DED0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(MDMHKPBJOEA JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
public readonly struct MIFOPKBCNCO : IEquatable<MIFOPKBCNCO>
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly MIFOPKBCNCO JBOFFCIPJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public NKOOLANNBNC JICGKLMMHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(NKOOLANNBNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x738EFA0", Offset = "0x738E1A0", VA = "0x18738EFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private BFDDDBCCDOC MMDFAHLNGOF
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x738EB80", Offset = "0x738DD80", VA = "0x18738EB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public AHLKFMNMFMG LOFPEAOEMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(AHLKFMNMFMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public LMHHOBCBPNM LAEGEKMOAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x738E3F0", Offset = "0x738D5F0", VA = "0x18738E3F0")]
		get
		{
			return default(LMHHOBCBPNM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x738E700", Offset = "0x738D900", VA = "0x18738E700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public IEnumerable<GHEFNHFHIMC> POGABPEOCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x738E510", Offset = "0x738D710", VA = "0x18738E510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public GHEFNHFHIMC FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x738EE90", Offset = "0x738E090", VA = "0x18738EE90")]
		get
		{
			return default(GHEFNHFHIMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x738F030", Offset = "0x738E230", VA = "0x18738F030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public MIFOPKBCNCO(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7381C30", Offset = "0x7380E30", VA = "0x187381C30")]
	public static bool KEDBNOKLEHE(MIFOPKBCNCO OMEFCJCOLII)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x738B480", Offset = "0x738A680", VA = "0x18738B480")]
	public static bool CCHBIHOFELC(MIFOPKBCNCO KKLLOEEDINO, MIFOPKBCNCO NHCGDJCFKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x738EE00", Offset = "0x738E000", VA = "0x18738EE00", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(MIFOPKBCNCO JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x738EBE0", Offset = "0x738DDE0", VA = "0x18738EBE0")]
	public GHEFNHFHIMC ELIHHEGFEMB(float3? FCKJMOMOHAE, [Optional] quaternion? EGIHDGHICMO, [Optional] Vector3? KGBNKPFPEFM)
	{
		return default(GHEFNHFHIMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x738E820", Offset = "0x738DA20", VA = "0x18738E820")]
	public GHEFNHFHIMC DBGANPBEGJO(int CPLNODNGKGB, float3? FCKJMOMOHAE, [Optional] quaternion? EGIHDGHICMO, [Optional] Vector3? KGBNKPFPEFM)
	{
		return default(GHEFNHFHIMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x738EAE0", Offset = "0x738DCE0", VA = "0x18738EAE0")]
	public void DCAHKMKHKLH(int CPLNODNGKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x738EA50", Offset = "0x738DC50", VA = "0x18738EA50")]
	public void DBGBEIOBMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct GHEFNHFHIMC : IEquatable<GHEFNHFHIMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public MIFOPKBCNCO MEPMIAPFPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7389760", Offset = "0x7388960", VA = "0x187389760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public float3 MLGLPLALOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x73898D0", Offset = "0x7388AD0", VA = "0x1873898D0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7389930", Offset = "0x7388B30", VA = "0x187389930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public quaternion FPDDOGEDCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7389710", Offset = "0x7388910", VA = "0x187389710")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x73897E0", Offset = "0x73889E0", VA = "0x1873897E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public float3 HDONMDADOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x73899E0", Offset = "0x7388BE0", VA = "0x1873899E0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7389A40", Offset = "0x7388C40", VA = "0x187389A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public CACHBFICFAK JLNOMKNAIAP
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7389990", Offset = "0x7388B90", VA = "0x187389990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public GHEFNHFHIMC(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7389830", Offset = "0x7388A30", VA = "0x187389830", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(GHEFNHFHIMC JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x73898C0", Offset = "0x7388AC0", VA = "0x1873898C0")]
	public void GNELKJHMAMA(MIFOPKBCNCO OMEFCJCOLII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct LNCEOKMPAEE : IEquatable<LNCEOKMPAEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x738D960", Offset = "0x738CB60", VA = "0x18738D960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private FELJJILIKAN KKHBLGMINJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x738D800", Offset = "0x738CA00", VA = "0x18738D800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public bool PMEJIPNBPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x738DAB0", Offset = "0x738CCB0", VA = "0x18738DAB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x738DB00", Offset = "0x738CD00", VA = "0x18738DB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public bool LOBJKJOKFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x738D3B0", Offset = "0x738C5B0", VA = "0x18738D3B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x738D860", Offset = "0x738CA60", VA = "0x18738D860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public float KIEBJDAODNC
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x738D9F0", Offset = "0x738CBF0", VA = "0x18738D9F0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x738DDB0", Offset = "0x738CFB0", VA = "0x18738DDB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool KMECEFEBBMB
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x738D360", Offset = "0x738C560", VA = "0x18738D360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public LNCEOKMPAEE(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x738D2D0", Offset = "0x738C4D0", VA = "0x18738D2D0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(LNCEOKMPAEE JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x738D8C0", Offset = "0x738CAC0", VA = "0x18738D8C0")]
	public void LELAAAEHFHA(int EMDADMPPCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x738DCA0", Offset = "0x738CEA0", VA = "0x18738DCA0")]
	public bool PIPHMBHONGK([Out] int EMDADMPPCND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x738D230", Offset = "0x738C430", VA = "0x18738D230")]
	public void EMPJMPNONJA(bool EABDOBKHLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x738D550", Offset = "0x738C750", VA = "0x18738D550")]
	public bool GLACEINGOAK(GIPGPNDMMEK CGDNKIJMMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x738DA30", Offset = "0x738CC30", VA = "0x18738DA30")]
	public void NBIJLNGDPML(GIPGPNDMMEK CGDNKIJMMML, bool FOFAGPDFKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x738DB60", Offset = "0x738CD60", VA = "0x18738DB60")]
	public void PHDEHGPHDIO(float FPDGAEEHBHM, float AFPPDIFJDPK, float IFIPBBPACEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x738D400", Offset = "0x738C600", VA = "0x18738D400")]
	public void FJGPPOPLDID(float3 BOBBLHOPIIN, quaternion ALLMLNBBIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x738D6D0", Offset = "0x738C8D0", VA = "0x18738D6D0")]
	public bool ILEACBDINOC([Out] float3 BOBBLHOPIIN, [Out] quaternion ALLMLNBBIKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x738D5A0", Offset = "0x738C7A0", VA = "0x18738D5A0")]
	public bool HACDHMCDOJB([Out] float MDOAOFLIHPA, [Out] float NPMEBAMJGEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x738D1A0", Offset = "0x738C3A0", VA = "0x18738D1A0")]
	public void BAEMIOIPBDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct NKOOLANNBNC : IEquatable<NKOOLANNBNC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public AHJFAOGJBHP GKLKJFNCMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(AHJFAOGJBHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private BGCIOADNHMO GKNBHLKIIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7391840", Offset = "0x7390A40", VA = "0x187391840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public Vector3 MLGLPLALOCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7391080", Offset = "0x7390280", VA = "0x187391080")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x73911D0", Offset = "0x73903D0", VA = "0x1873911D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public Quaternion FPDDOGEDCML
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7390700", Offset = "0x738F900", VA = "0x187390700")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7390BE0", Offset = "0x738FDE0", VA = "0x187390BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Vector3 HPOCEBIKCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7390840", Offset = "0x738FA40", VA = "0x187390840")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7390630", Offset = "0x738F830", VA = "0x187390630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public Quaternion OKAKNFFOGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7390E90", Offset = "0x7390090", VA = "0x187390E90")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x7391370", Offset = "0x7390570", VA = "0x187391370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public float HCLEOEMBEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7390A90", Offset = "0x738FC90", VA = "0x187390A90")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7390B30", Offset = "0x738FD30", VA = "0x187390B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public float KNFGAKJFNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7391DD0", Offset = "0x7390FD0", VA = "0x187391DD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public Matrix4x4 NLDMBNFIALH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7391900", Offset = "0x7390B00", VA = "0x187391900")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public NKOOLANNBNC(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7390CB0", Offset = "0x738FEB0", VA = "0x187390CB0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(NKOOLANNBNC JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7391750", Offset = "0x7390950", VA = "0x187391750")]
	public HLDKLCEAPAJ MKMIPGLMNLM()
	{
		return default(HLDKLCEAPAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7390450", Offset = "0x738F650", VA = "0x187390450")]
	public void AENJFNPAKJJ([Out] Matrix4x4 HGDBCCODBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7392060", Offset = "0x7391260", VA = "0x187392060")]
	public void PPPBHFBJPJN([Out] Vector3 PDMKGGNDIJH, [Out] Quaternion BMDBLIGOLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7391FB0", Offset = "0x73911B0", VA = "0x187391FB0")]
	public void PPPBHFBJPJN([Out] RigidTransform HHKNPCEAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7390990", Offset = "0x738FB90", VA = "0x187390990")]
	public void DBIPHFIMIIA([In] Vector3 PDMKGGNDIJH, [In] Quaternion BMDBLIGOLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7391AC0", Offset = "0x7390CC0", VA = "0x187391AC0")]
	public void NOPDGHJNMCE([Out] Vector3 PDMKGGNDIJH, [Out] Quaternion BMDBLIGOLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7391A10", Offset = "0x7390C10", VA = "0x187391A10")]
	public void NOPDGHJNMCE([Out] RigidTransform HHKNPCEAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7391500", Offset = "0x7390700", VA = "0x187391500")]
	public UniformTRS KAGGHAHGDHI()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7391440", Offset = "0x7390640", VA = "0x187391440")]
	public void KAGGHAHGDHI([Out] UniformTRS CDDDAJLNEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x7391BA0", Offset = "0x7390DA0", VA = "0x187391BA0")]
	public UniformTRS ONJMANPGGEK()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x7391BD0", Offset = "0x7390DD0", VA = "0x187391BD0")]
	public void ONJMANPGGEK([Out] UniformTRS HHKNPCEAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7390D40", Offset = "0x738FF40", VA = "0x187390D40")]
	public Vector3 GPGCKOCMBHK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7391940", Offset = "0x7390B40", VA = "0x187391940")]
	public void NGOFMIFOBEM([In] Vector3 OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7391530", Offset = "0x7390730", VA = "0x187391530")]
	public Vector3 LDGALBAKBKK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7391680", Offset = "0x7390880", VA = "0x187391680")]
	public void LPLFGCFKPPA([In] Vector3 OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7391C90", Offset = "0x7390E90", VA = "0x187391C90")]
	public Quaternion OPKJPAJDHPL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7390560", Offset = "0x738F760", VA = "0x187390560")]
	public void AIHJPCDMCFI([In] Quaternion OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7391E70", Offset = "0x7391070", VA = "0x187391E70")]
	public Quaternion PFNECPFBGAL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x73912A0", Offset = "0x73904A0", VA = "0x1873912A0")]
	public void ILNBKLHAADB([In] Quaternion OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x7390300", Offset = "0x738F500", VA = "0x187390300")]
	public float ABGBFIEAKJJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7390FD0", Offset = "0x73901D0", VA = "0x187390FD0")]
	public void HHCNBHFFPEC(float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x73917A0", Offset = "0x73909A0", VA = "0x1873917A0")]
	public float MMMGAKECLPJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x73903A0", Offset = "0x738F5A0", VA = "0x1873903A0")]
	public void AECNEMOJBHD(float OMEFCJCOLII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct NJNDFCHGGPE : IEquatable<NJNDFCHGGPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	private EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7381390", Offset = "0x7380590", VA = "0x187381390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	private BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7390130", Offset = "0x738F330", VA = "0x187390130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	private LIDOLEINANO HBCHOCAJEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7390040", Offset = "0x738F240", VA = "0x187390040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	public NJNDFCHGGPE(CIBKNFGEPGP IMMLHGFCKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x7380000", VA = "0x187380E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x73900A0", Offset = "0x738F2A0", VA = "0x1873900A0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FF60", VA = "0x187380D60", Slot = "4")]
	public bool Equals(NJNDFCHGGPE JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7381800", Offset = "0x7380A00", VA = "0x187381800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x73901C0", Offset = "0x738F3C0", VA = "0x1873901C0")]
	public void ODPGENJLLCA(string ODABBBAHLHK, IODHKOECLEP HHGPPDCIJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class PADEDFIBCDK
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct MEICFNGEPOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Guid IBPGMNEANFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NGFBLIKKFHG OCJBJODIFLC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private struct NGFBLIKKFHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int OMEFCJCOLII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int DFAJOCLJFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int IIMKKDJMCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int GOEGCOIHCMJ;

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x738FB90", Offset = "0x738ED90", VA = "0x18738FB90")]
		public bool GJOGAGCNCJN([Out] CBHIEDOMBAP ACOACGBKLMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x738FC20", Offset = "0x738EE20", VA = "0x18738FC20")]
		public NGFBLIKKFHG(CBHIEDOMBAP ACOACGBKLMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x7392A30", Offset = "0x7391C30", VA = "0x187392A30")]
	public static Guid DBKMEFGLFEP(this CBHIEDOMBAP ACOACGBKLMC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7392AD0", Offset = "0x7391CD0", VA = "0x187392AD0")]
	public static bool LOMNAPFJGAF(this Guid IBPGMNEANFH, [Out] CBHIEDOMBAP ACOACGBKLMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class OKOODPDIJGJ
{
	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x73924D0", Offset = "0x73916D0", VA = "0x1873924D0")]
	public static BBPKOKGMLME BANBHEAECAC(this CIBKNFGEPGP BEHEHKFONGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7392400", Offset = "0x7391600", VA = "0x187392400")]
	public static EEPABMPJIMJ AJMAHBOENMM(this CIBKNFGEPGP BEHEHKFONGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x7392300", Offset = "0x7391500", VA = "0x187392300")]
	public static EntityManager AGJILKLBNJK(this CIBKNFGEPGP BEHEHKFONGA)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x34493A0", Offset = "0x34485A0", VA = "0x1834493A0")]
	internal static bool CCEIBFBABLF<T>(this CIBKNFGEPGP BEHEHKFONGA, bool FOFAGPDFKME) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x7392560", Offset = "0x7391760", VA = "0x187392560")]
	public static bool OENHFDGGNKC(this CIBKNFGEPGP BEHEHKFONGA, GFCAKFAODMC FPOONLFOOIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x3449480", Offset = "0x3448680", VA = "0x183449480")]
	public static bool HKGOAHAFFLH<T>(this CIBKNFGEPGP BEHEHKFONGA) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x3449700", Offset = "0x3448900", VA = "0x183449700")]
	public static bool IMGHMLKPBPI<T>(this CIBKNFGEPGP BEHEHKFONGA) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x3447D20", Offset = "0x3446F20", VA = "0x183447D20")]
	[CFMECFOONIJ]
	public static T BOFHHEBJNIG<T>(this CIBKNFGEPGP BEHEHKFONGA) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x34497B0", Offset = "0x34489B0", VA = "0x1834497B0")]
	[CFMECFOONIJ]
	public static T PKOKPOCCOGD<T>(this CIBKNFGEPGP BEHEHKFONGA) where T : struct, IComponentData
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CGADFIBDDDE
{
	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLEKPKGHOEM(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EIMCBFFEEEK(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task IPJACJHIGGB(JGGGIHBIMPC LCACGJDNDHA);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ABBBNKLHHGP(CIBKNFGEPGP IMMLHGFCKGF, [Out] Guid KMGNKJBKEAL);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid GEALENPHHMM(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HLEALHAHCEB(CIBKNFGEPGP IMMLHGFCKGF, Guid KMGNKJBKEAL);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PFNFJIPBOIM(CIBKNFGEPGP IMMLHGFCKGF, [Out] Guid MFMLNNMNGAP);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Guid MNLBBAAIFOJ(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FDAAGDIBGEC(CIBKNFGEPGP IMMLHGFCKGF, Guid MFMLNNMNGAP);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BCABDECGMBM(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task NLKKOBHNOKK(CIBKNFGEPGP KGPDHHGDIDC, CIBKNFGEPGP DBEHKFODEEL);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DGHHKBPNBLN
{
	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	Guid KJACAFMKOAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNLLCMICGDO(NativeList<Guid> DEGMDHDMEPI, NativeList<Guid> ELNNIKFBABG, NativeList<FixedString64Bytes> MJGNODDLJKH);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PGLLOHJHJLK
{
	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKCEGGAPMIF(List<CIBKNFGEPGP> IJCMMKKOAJG);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEEFHBKGAOD(List<CIBKNFGEPGP> IJKKBFFPJJN);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CMOCCAJCDDK(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OPIHNCLABBJ(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FKBGBIPAFEH(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int HMCFFBCKCGJ(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CLMJAJHBINN(CIBKNFGEPGP OFNKJKFNBEJ, int NEKLIKCEFAN);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CIBKNFGEPGP AEICGICECOB(CIBKNFGEPGP GMCOGJDAGIE);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int LDJOEILMCNL(CIBKNFGEPGP GMCOGJDAGIE);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void POOBOFMLJNH(CIBKNFGEPGP GMCOGJDAGIE, int POGIKBLPHFH);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int NJPFAKDBONI(CIBKNFGEPGP GMCOGJDAGIE);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PEDODCNLHAB(CIBKNFGEPGP GMCOGJDAGIE, int IKPJACBKKPA);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PMHGMDDOIPO(CIBKNFGEPGP MMGDIFNEOOE);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FGEBLNDMGPC(CIBKNFGEPGP IMMLHGFCKGF, bool ACKOLMGGOJD);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IILHBECKPHA(CIBKNFGEPGP[] PPCLEJEKIDG, bool ACKOLMGGOJD);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AEEFNCAHFIF(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JBPCLHJJIAH(CIBKNFGEPGP OFNKJKFNBEJ, bool PGHACNGFAGB);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GNOJPGOGKLA
{
	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBHIEDOMBAP[] FCDHHMPCIIO(string LMOANCJLHKC, JGGGIHBIMPC KEGJCAAILPK, bool HOGBOAPBANE = false);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNFECDOHMIC(string ACAIINBEMMK, CBHIEDOMBAP[] FBEGNHDLGJI);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DKGIONCBAMG
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<CIBKNFGEPGP, CIBKNFGEPGP> HLPMCEJPPAC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<CIBKNFGEPGP, CIBKNFGEPGP> BMAPPMGFBPL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<CIBKNFGEPGP, CIBKNFGEPGP, CIBKNFGEPGP> CPAIKIPMBDN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<CIBKNFGEPGP> HCIIGNHGHHO;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AKPKDGNIIOG(CIBKNFGEPGP IMMLHGFCKGF, CIBKNFGEPGP PLPDDKCBLNA);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CIBKNFGEPGP MJACFEBMIMM(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NDNBDIACCIO AKBCODOEJDO(CIBKNFGEPGP IMMLHGFCKGF, Allocator NNHCNMKJHLF);

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CIBKNFGEPGP OMKCAGEDKKM(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NOMACKDPDMJ(CIBKNFGEPGP IMMLHGFCKGF, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NNLEFBGKLML(CIBKNFGEPGP IMMLHGFCKGF, float KCJANBMNMAB);

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool OBNFJGLAMDB(CIBKNFGEPGP IMMLHGFCKGF, [Out] CIBKNFGEPGP DBEHKFODEEL);

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OPLHNJHOJEH(CIBKNFGEPGP IMMLHGFCKGF, [Out] RigidTransform CJDPHOGNDFI);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool ODHJGPBNMLP(CIBKNFGEPGP IMMLHGFCKGF, [Out] float NJDKHFOJIOD);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 OGMFMLEOLNG(PGPPOOJGNLB MMPPGBNJMIM);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion MJAKIEHOMKE(PGPPOOJGNLB MMPPGBNJMIM);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class MCMOJAHCOBP
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PKMEKNGHOPI
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	object DFNNCNOGOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKGHGCHDMGM(NDNBDIACCIO PPCLEJEKIDG);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EINGBNHMEFH
{
	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIBHDAEPMJO(CIBKNFGEPGP LCACGJDNDHA, KMKOIABPNNL NDNLMFPEABK);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIMFIGMOCOM(KMKOIABPNNL NDNLMFPEABK);

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KENPFACLAOB(CIBKNFGEPGP IMMLHGFCKGF, [Out] KMKOIABPNNL KEFBIODDBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct EPECGPILNKN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly string LMOANCJLHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly T JEBHMGJFPIP;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x3F29830", Offset = "0x3F28A30", VA = "0x183F29830")]
	public EPECGPILNKN(T JEBHMGJFPIP, [Optional][CallerMemberName] string LMOANCJLHKC)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly EPECGPILNKN<int> BNFGNLADDJG;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly EPECGPILNKN<int> ILIGGONNDCK;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly EPECGPILNKN<int> MIJKIFNMGBH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum HCIIMLFLCLL
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class FEIKNHPPODA
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x13CACB0", Offset = "0x13C9EB0", VA = "0x1813CACB0")]
	public static bool NPLMEFEFJEE(this HCIIMLFLCLL ONNLPKDFGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x13CACA0", Offset = "0x13C9EA0", VA = "0x1813CACA0")]
	public static bool CCKANLGFNIO(this HCIIMLFLCLL ONNLPKDFGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2B213C0", Offset = "0x2B205C0", VA = "0x182B213C0")]
	public static bool EFHBMILKOIO(this HCIIMLFLCLL ONNLPKDFGPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FECNMDICGCG
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum HKHIHIDDPAM
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public enum MBILLCNLPOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	HKHIHIDDPAM CKEKDDKBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	bool NAKBKOGNING
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	bool GKCHFFGLEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	MBILLCNLPOF JMAHKPHMKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BODOGBGJIOD();
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[ServiceLifetime(Lifetime.Application)]
public interface DNKELJAGPAO
{
	[Cpp2IlInjected.Token(Token = "0x17000181")]
	HCIIMLFLCLL PHHCOAPOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	HCIIMLFLCLL JAGPIMIGLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	HCIIMLFLCLL HPEDNNHKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	HCIIMLFLCLL KBOLCOBAECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	HCIIMLFLCLL EKEBBMNDFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	HCIIMLFLCLL NAMLNFKGAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	HCIIMLFLCLL JJMPPGOICNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	HCIIMLFLCLL AOFKBGPMLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	HCIIMLFLCLL IIBHCOPPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	HCIIMLFLCLL IIPLGCGLGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	HCIIMLFLCLL HLBHPPAKNLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	HCIIMLFLCLL JCEHLMOFPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	HCIIMLFLCLL BBDBNAPFEKM
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	HCIIMLFLCLL PDDACEENKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	HCIIMLFLCLL PFPDIANCGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	HCIIMLFLCLL AOPFPIAIPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	HCIIMLFLCLL ACGIJLKLAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BGMHNJIJIDG(EPECGPILNKN<int> LFKGAGFDDEM);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GGFBFEIEEOM
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event EGOKNOHOJKA.OIDPDCLIIDL EIJJDFBOFKA;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CIBKNFGEPGP MDHPIGKLOIL(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LEJMEMHEODJ(List<CIBKNFGEPGP> IJKKBFFPJJN);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CACHBFICFAK PGDBLPDEBEL(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NAOFDAGGGCF(IEnumerable<CIBKNFGEPGP> BCLLJHFCEHL);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CACHBFICFAK DIMOMMHIKPG(CIBKNFGEPGP DBEHKFODEEL, CIBKNFGEPGP BGKIOALJNDJ, bool CJOPCAEOABF, CIBKNFGEPGP MKMPLOHPJDC);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CIBKNFGEPGP PMNHNJKCDDE(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HIDFBJMELPN(CIBKNFGEPGP IMMLHGFCKGF, CIBKNFGEPGP DBEHKFODEEL, bool MEHDOJDAFOD = false);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DCAFJBIKKII(CIBKNFGEPGP IMMLHGFCKGF, CIBKNFGEPGP DBEHKFODEEL);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MCBMBABFOCL(CIBKNFGEPGP PAEPHJLOCCK, CIBKNFGEPGP AFPPGAINIHC);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int BAPKNNIDIAP(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NDNBDIACCIO FEKKGJJNCJB(CIBKNFGEPGP MMGDIFNEOOE);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<CIBKNFGEPGP> KDPKGOKIOPJ(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool KCPMFIDJHIG(CIBKNFGEPGP IMMLHGFCKGF, CIBKNFGEPGP JNLKEJAGEGE);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<CIBKNFGEPGP> NJCPIEHFJDE(CIBKNFGEPGP IMMLHGFCKGF, bool FIKKDFDGGOE = false);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool MNKAEDBJMDO(CIBKNFGEPGP IMMLHGFCKGF, CIBKNFGEPGP FNIOOAHGDGJ);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "17")]
	CIBKNFGEPGP JDAOOMJMDNC(CIBKNFGEPGP MKMPLOHPJDC, CIBKNFGEPGP MEMEJFGCHBF);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OAFIKCOAMFA(CIBKNFGEPGP MKMPLOHPJDC, CIBKNFGEPGP MEMEJFGCHBF, [Out] CIBKNFGEPGP MMLOPMMFPIO);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "19")]
	CIBKNFGEPGP PDCDJFFHJEK(CIBKNFGEPGP[] PPCLEJEKIDG);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class NNBFBBIDKBH
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x73921B0", Offset = "0x73913B0", VA = "0x1873921B0")]
	public static List<CIBKNFGEPGP> LEJMEMHEODJ(this GGFBFEIEEOM FIBCOOGKMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7392140", Offset = "0x7391340", VA = "0x187392140")]
	public static bool CICFKLPBGDG(this GGFBFEIEEOM FIBCOOGKMPG, CIBKNFGEPGP IMMLHGFCKGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GJHKOCHJLHN
{
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KEADHBOCJDP IMPECJFIMIH(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHAALFPPCHD(CIBKNFGEPGP OFNKJKFNBEJ, KEADHBOCJDP DLIHMADKMIK);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GJFIPCCBLPB(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGAMMNKILOI(CIBKNFGEPGP OFNKJKFNBEJ, bool OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] KIPBEEAKDKB(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMMONIGPIGL(CIBKNFGEPGP OFNKJKFNBEJ, IEnumerable<string> FIHHAAIJGPL);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] PNIEJIAOIEK(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BNLJLBCIMIH(CIBKNFGEPGP OFNKJKFNBEJ, IEnumerable<string> FIHHAAIJGPL);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] AIAPDNFMHFE(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NOLPIHIFMPK(CIBKNFGEPGP OFNKJKFNBEJ, IEnumerable<string> FIHHAAIJGPL);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] GLCKLOEGPNG(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EEHJIELAMPE(CIBKNFGEPGP OFNKJKFNBEJ, IEnumerable<string> FIHHAAIJGPL);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NAHNPLEDADD(CIBKNFGEPGP OFNKJKFNBEJ, CIBKNFGEPGP IBFPGGCAJBP);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EOJPBENJFKC
{
	[Cpp2IlInjected.Token(Token = "0x17000192")]
	bool FPFOOGKLEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	bool JCMNLMOFNJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	bool HJPAMDHIIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CKLGKANFICN
{
	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOJPNFIHMPM([In] float3 KGJLHKKBBFC, [In] float3 BDIPLNMOFCC, float ABBGAHJHLCA, [Out] EKLDBLGCPOH HJMHEDLDFME, [Out] CIBKNFGEPGP KAAKBIHCNAB);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int ODFBDEGNBEC([In] float3 KGJLHKKBBFC, float COBBNHPDFBH, List<CIBKNFGEPGP> PPCLEJEKIDG);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KIIPFJLKPOH(Plane[] PFPKLAMFDIP, float3 KGJLHKKBBFC, float3 BPIPBKANBAH, quaternion EGIHDGHICMO, List<CIBKNFGEPGP> PPCLEJEKIDG);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BFJMBCANGEC
{
	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOJPNFIHMPM([In] NativeArray<Entity> NNDJLDGDLBA, [In] float3 KGJLHKKBBFC, [In] float3 BDIPLNMOFCC, [In] NativeArray<EKLDBLGCPOH> GLMMOMEONDP);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> ODFBDEGNBEC([In] NativeArray<Entity> NNDJLDGDLBA, [In] float3 KGJLHKKBBFC, float COBBNHPDFBH);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> KIIPFJLKPOH([In] NativeArray<Entity> NNDJLDGDLBA, [In] NativeArray<float4> FFKGBFNAAIB);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct IMBKFMKOKGB : LODJCBKGHME, IEquatable<IMBKFMKOKGB>
{
	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public int JDABKJNJMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public int DCLMEHAOAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B3F0", Offset = "0x2B3A5F0", VA = "0x182B3B3F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x655CDD0", Offset = "0x655BFD0", VA = "0x18655CDD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x738A410", Offset = "0x7389610", VA = "0x18738A410", Slot = "8")]
	public bool Equals(IMBKFMKOKGB JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x738A460", Offset = "0x7389660", VA = "0x18738A460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct EKLDBLGCPOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float ONBGAIIMDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public float3 LAOLFCMCDHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FJFMDMFPLOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EKHABGHIANL
{
	[Cpp2IlInjected.Token(Token = "0x17000197")]
	BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	DDJGKFJPEIA ECFJFFIFBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<NDNBDIACCIO, NativeArray<EHDGIFBGGFC>> HIGHPNBMBBK;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<NDNBDIACCIO> JPADMJBEGND;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LDMHHIICGCO OGCBLNFILKC(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EHDGIFBGGFC JNEKNCHLOCN(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JMFBCAGPLCG(CBHIEDOMBAP ACOACGBKLMC, AHKGBAIIAIA ONBMLEFABLO);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FBPOGLGCEJJ(CBHIEDOMBAP[] FBEGNHDLGJI, GameObject GBMEGJCINPI);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JGGGIHBIMPC PMPJGBMMBBP(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KBIGKHEIGIK(CIBKNFGEPGP IMMLHGFCKGF, [Out] Transform MCPAEAAAAAM);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JGLAJLBHICG(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HBKDHMAIJLK(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CIBKNFGEPGP ICINLELOAKG(CBHIEDOMBAP ACOACGBKLMC);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MPNEAPLFMOK(CBHIEDOMBAP ACOACGBKLMC, [Out] CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CBHIEDOMBAP IJIMJNKOKDE(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NDNBDIACCIO ICINLELOAKG(NativeArray<CBHIEDOMBAP> ACOACGBKLMC, Allocator NNHCNMKJHLF);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "18")]
	NDNBDIACCIO IPHIELGANHC(EHDGIFBGGFC FNDCBDLPGJI, int EOKNBJLIKEG, Allocator NNHCNMKJHLF);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "19")]
	NDNBDIACCIO AIJKKBLCOAB(NativeArray<CBHIEDOMBAP> ACOACGBKLMC, NativeArray<DEKFFHAAJPL> OGANOGGENEI, Allocator NNHCNMKJHLF);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "20")]
	CBHIEDOMBAP[] FCDHHMPCIIO(string ACAIINBEMMK, JGGGIHBIMPC KEGJCAAILPK, bool HOGBOAPBANE);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NNFECDOHMIC(string ACAIINBEMMK, CBHIEDOMBAP[] FBEGNHDLGJI);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "22")]
	JGGGIHBIMPC MDFEGOIPNFL(EHDGIFBGGFC FNDCBDLPGJI, bool NNGBKGHCJOP);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "23")]
	JGGGIHBIMPC MDFEGOIPNFL(EHDGIFBGGFC FNDCBDLPGJI);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "24")]
	JGGGIHBIMPC MAOOBDEAOFN(EHDGIFBGGFC FNDCBDLPGJI);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JGGGIHBIMPC GCEBKOIJLBM(EHDGIFBGGFC FNDCBDLPGJI);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	JGGGIHBIMPC MPMAHKBAIMG(CBHIEDOMBAP ACOACGBKLMC, EHDGIFBGGFC FNDCBDLPGJI);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	AICJJJCJBNN HIJPINHMGOH();

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	MIFOPKBCNCO MCJDDENKOBI();

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	MDMHKPBJOEA DILBOLIKANB(EAOBBGHPEOO HLAPIPPDLCK);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void PMJODLDALJN(NDNBDIACCIO PPCLEJEKIDG);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void LEGDOGAINAB(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void OIPHMDHOOBE(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void PMJODLDALJN(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void NGLNPMPEKAM(CIBKNFGEPGP PPCLEJEKIDG);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool HFDJDCMFCGF(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "36")]
	NDNBDIACCIO CEBCEIEODJD(NDNBDIACCIO LBKJGCKHLEC, Allocator NNHCNMKJHLF);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool KIFOFJDPIIL(CIBKNFGEPGP IMMLHGFCKGF);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class EMOMFDEPJEH
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x7386E00", Offset = "0x7386000", VA = "0x187386E00")]
	public static void HBKDHMAIJLK(this EKHABGHIANL HHGPPDCIJMN, AHKGBAIIAIA ONBMLEFABLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x7386E80", Offset = "0x7386080", VA = "0x187386E80")]
	public static JGGGIHBIMPC JHGLIICLEGF(this EKHABGHIANL HHGPPDCIJMN, LocalId IMMLHGFCKGF)
	{
		return default(JGGGIHBIMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x7386F30", Offset = "0x7386130", VA = "0x187386F30")]
	public static JGGGIHBIMPC JHGLIICLEGF(this EKHABGHIANL HHGPPDCIJMN, CBHIEDOMBAP ACOACGBKLMC)
	{
		return default(JGGGIHBIMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x7386E80", Offset = "0x7386080", VA = "0x187386E80")]
	public static CIBKNFGEPGP ICINLELOAKG(this EKHABGHIANL HHGPPDCIJMN, LocalId IMMLHGFCKGF)
	{
		return default(CIBKNFGEPGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x7386EB0", Offset = "0x73860B0", VA = "0x187386EB0")]
	public static CBHIEDOMBAP IJIMJNKOKDE(this EKHABGHIANL HHGPPDCIJMN, LocalId IMMLHGFCKGF)
	{
		return default(CBHIEDOMBAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x7387190", Offset = "0x7386390", VA = "0x187387190")]
	public static bool KIFOFJDPIIL(this EKHABGHIANL HHGPPDCIJMN, CBHIEDOMBAP ACOACGBKLMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x7386C20", Offset = "0x7385E20", VA = "0x187386C20")]
	public static AICJJJCJBNN FAANLGPDLHC(this EKHABGHIANL HHGPPDCIJMN, RigidTransform CDDDAJLNEMP)
	{
		return default(AICJJJCJBNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x7386B20", Offset = "0x7385D20", VA = "0x187386B20")]
	public static MDMHKPBJOEA DCAAJKPLPNH(this EKHABGHIANL HHGPPDCIJMN, EAOBBGHPEOO BGHKGPOBOOH, RigidTransform CDDDAJLNEMP)
	{
		return default(MDMHKPBJOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7386D10", Offset = "0x7385F10", VA = "0x187386D10")]
	public static MIFOPKBCNCO GCFNOALBCCN(this EKHABGHIANL HHGPPDCIJMN, RigidTransform CDDDAJLNEMP)
	{
		return default(MIFOPKBCNCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x7386F90", Offset = "0x7386190", VA = "0x187386F90")]
	private static void KGEFKMHICNK(JGGGIHBIMPC AFFINLCEBFK, RigidTransform CDDDAJLNEMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LMAKPLIKPNH
{
	[Cpp2IlInjected.Token(Token = "0x17000199")]
	bool PFHGJPFMLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	CIBKNFGEPGP AHCBEAHGILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	JGGGIHBIMPC ODOBBNMAEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event BMNPCPPPJOP FBEFBKDJKKE;

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CIBKNFGEPGP JDAOOMJMDNC(CIBKNFGEPGP MKMPLOHPJDC, CIBKNFGEPGP MEMEJFGCHBF);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OAFIKCOAMFA(CIBKNFGEPGP MKMPLOHPJDC, CIBKNFGEPGP MEMEJFGCHBF, [Out] CIBKNFGEPGP MMLOPMMFPIO);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LNBKOCOKJAH();

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OJDNJJBDGHH();

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LLJDMKGOLNE(CIBKNFGEPGP MKMPLOHPJDC);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EHOEEHFEDKN(CIBKNFGEPGP MKMPLOHPJDC);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public delegate void BMNPCPPPJOP(JGGGIHBIMPC LGKIBGACFME, JGGGIHBIMPC AMNEIMNLPNM);
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class BBCDMIGGBKN
{
	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x73831A0", Offset = "0x73823A0", VA = "0x1873831A0")]
	public static bool OAEJPGNDEIA(this LMAKPLIKPNH CDABEKHMCJM, JGGGIHBIMPC MKMPLOHPJDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x7383270", Offset = "0x7382470", VA = "0x187383270")]
	public static bool PKNFCALBIHN(this LMAKPLIKPNH CDABEKHMCJM, CIBKNFGEPGP MKMPLOHPJDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x73831F0", Offset = "0x73823F0", VA = "0x1873831F0")]
	public static bool OLHIPCEGEDI(this LMAKPLIKPNH CDABEKHMCJM, CIBKNFGEPGP MKMPLOHPJDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BKDBNGEINBI
{
	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKLBBKHHGBM(JGGGIHBIMPC AFFINLCEBFK, CJJHDAEBBAK BGJHPMCGJDB, List<JGGGIHBIMPC> ELMABPNEBJP);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JCOFPFILNOC(JGGGIHBIMPC AFFINLCEBFK, CJJHDAEBBAK BGJHPMCGJDB);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NEDNIFINFOD(JGGGIHBIMPC AFFINLCEBFK, List<JGGGIHBIMPC> ELMABPNEBJP);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CGOOINFGAFC(JGGGIHBIMPC EMDADMPPCND, JGGGIHBIMPC MKMPLOHPJDC, CJJHDAEBBAK BGJHPMCGJDB);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JGGGIHBIMPC GNGEMJMGCGA(JGGGIHBIMPC EMDADMPPCND, int CPLNODNGKGB, CJJHDAEBBAK BGJHPMCGJDB);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MBJHGMDOINH(JGGGIHBIMPC EMDADMPPCND, JGGGIHBIMPC MKMPLOHPJDC, CJJHDAEBBAK BGJHPMCGJDB);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OGJHLJPAGGO(JGGGIHBIMPC EMDADMPPCND, JGGGIHBIMPC MKMPLOHPJDC, CJJHDAEBBAK BGJHPMCGJDB);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DCMLNBGGBFC(JGGGIHBIMPC EMDADMPPCND, CJJHDAEBBAK BGJHPMCGJDB);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GNGCGFOFDBF(JGGGIHBIMPC EMDADMPPCND, JGGGIHBIMPC MKMPLOHPJDC, CJJHDAEBBAK BGJHPMCGJDB);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DKFJAMIELOJ(Entity EMDADMPPCND, Entity MKMPLOHPJDC, CJJHDAEBBAK BGJHPMCGJDB);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LKDICPCLJDP(Entity EMDADMPPCND, CJJHDAEBBAK BGJHPMCGJDB);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DPFDKIACAPK(JGGGIHBIMPC MKMPLOHPJDC, CJJHDAEBBAK BGJHPMCGJDB);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AHJIBOCDKJK
{
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMOHMDIOLAM(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EOELDNCPJFF(CIBKNFGEPGP IMMLHGFCKGF, Transform MCPAEAAAAAM);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GKABMLCHAOI
{
	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMIEGFDAJCD(CIBKNFGEPGP MKMPLOHPJDC, CIBKNFGEPGP HOPGEAJFCDN);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JCCFBJBBCAK(CIBKNFGEPGP MKMPLOHPJDC, CIBKNFGEPGP BGMMBAEMHDM);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MKBDPGIABKA(CIBKNFGEPGP MKMPLOHPJDC, [Out] CIBKNFGEPGP DJHKKJKLLBL);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NJGPMDFAAOF
{
	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDBIPINGMMD(CIBKNFGEPGP MMGDIFNEOOE, bool OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBPAOJGANGL(CIBKNFGEPGP MMGDIFNEOOE, bool OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FEABADCJJMG(CIBKNFGEPGP MMGDIFNEOOE, int OMEFCJCOLII);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BFDDDBCCDOC
{
	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<CIBKNFGEPGP> OAANODKNHAA(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CIBKNFGEPGP GCCHHOFCHED(CIBKNFGEPGP IMMLHGFCKGF, int CPLNODNGKGB);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int ECGHKKGLLFO(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LMHHOBCBPNM JEIGKMFENLG(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIAEDOIFJCK(CIBKNFGEPGP IMMLHGFCKGF, LMHHOBCBPNM HLJPDMABNJO);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CIBKNFGEPGP PEBGIANIGEO(CIBKNFGEPGP IMMLHGFCKGF, [Optional] float3? FCKJMOMOHAE, [Optional] quaternion? EGIHDGHICMO, [Optional] float3? KGBNKPFPEFM);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CIBKNFGEPGP PNDJADJDLPD(CIBKNFGEPGP IMMLHGFCKGF, int CPLNODNGKGB, [Optional] float3? FCKJMOMOHAE, [Optional] quaternion? EGIHDGHICMO, [Optional] float3? KGBNKPFPEFM);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ALMDLFDHEOL(CIBKNFGEPGP IMMLHGFCKGF, int CPLNODNGKGB);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EBCBPAAHPGF(CIBKNFGEPGP IMMLHGFCKGF);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GGFNELMAGBE
{
	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJIPKPPFLOJ();

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PGJAILIMIJB();

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHCFCPBLMCE();

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHJPOCAIGFC();

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPHMANDGEFD();

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DNJPDHMAGNP();

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DOOJHJKNNIP();

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KMKKNNDGFLB();

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PJKLEPJIJFF();

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MABKMFLJOJL();

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GECEDKFBHKL();

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NOLPMKGMDEK();

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BAPNEDKNLLC();
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FELJJILIKAN
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PIPHMBHONGK(CIBKNFGEPGP MKMPLOHPJDC, [Out] int EMDADMPPCND);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LELAAAEHFHA(CIBKNFGEPGP MKMPLOHPJDC, int EMDADMPPCND);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMPJMPNONJA(CIBKNFGEPGP MKMPLOHPJDC, bool EABDOBKHLDP);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHDEHGPHDIO(CIBKNFGEPGP MKMPLOHPJDC, float FPDGAEEHBHM, float AFPPDIFJDPK, float IFIPBBPACEK);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HACDHMCDOJB(CIBKNFGEPGP IMMLHGFCKGF, [Out] float AFPPDIFJDPK, [Out] float IFIPBBPACEK);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FJGPPOPLDID(CIBKNFGEPGP MKMPLOHPJDC, float3 FCKJMOMOHAE, quaternion EGIHDGHICMO);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ILEACBDINOC(CIBKNFGEPGP MKMPLOHPJDC, [Out] float3 FCKJMOMOHAE, [Out] quaternion EGIHDGHICMO);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BAEMIOIPBDA(CIBKNFGEPGP MKMPLOHPJDC);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BGCIOADNHMO
{
	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGNMENIHAMP(Entity KPFAGKHHMMH);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGOFMIFOBEM(Entity KPFAGKHHMMH, [In] float3 OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 GPGCKOCMBHK(Entity KPFAGKHHMMH);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AIHJPCDMCFI(Entity KPFAGKHHMMH, [In] quaternion OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion OPKJPAJDHPL(Entity KPFAGKHHMMH);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDCIIILPBJH(Entity KPFAGKHHMMH, [In] float3 FCKJMOMOHAE, [In] quaternion EGIHDGHICMO);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PPPBHFBJPJN(Entity KPFAGKHHMMH, [Out] float3 FCKJMOMOHAE, [Out] quaternion EGIHDGHICMO);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PPPBHFBJPJN(Entity KPFAGKHHMMH, [Out] RigidTransform MCNFAKJPPIC);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DBIPHFIMIIA(Entity KPFAGKHHMMH, [In] float3 FCKJMOMOHAE, [In] quaternion EGIHDGHICMO);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NOPDGHJNMCE(Entity KPFAGKHHMMH, [Out] float3 FCKJMOMOHAE, [Out] quaternion EGIHDGHICMO);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NOPDGHJNMCE(Entity KPFAGKHHMMH, [Out] RigidTransform MCNFAKJPPIC);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HHCNBHFFPEC(Entity KPFAGKHHMMH, float OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float ABGBFIEAKJJ(Entity KPFAGKHHMMH);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LPLFGCFKPPA(Entity KPFAGKHHMMH, [In] float3 OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	float3 LDGALBAKBKK(Entity KPFAGKHHMMH);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ILNBKLHAADB(Entity KPFAGKHHMMH, [In] quaternion OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	quaternion PFNECPFBGAL(Entity KPFAGKHHMMH);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AECNEMOJBHD(Entity KPFAGKHHMMH, float OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float MMMGAKECLPJ(Entity KPFAGKHHMMH);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void AHGOEHJPFAD(Entity KPFAGKHHMMH, [Out] float4x4 HGDBCCODBIA);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HIBJPALGHFJ(Entity KPFAGKHHMMH, [In] float4x4 HGDBCCODBIA);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BFHIKMGHJII(Entity KPFAGKHHMMH, [Out] float4x4 HGDBCCODBIA);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool KBIGKHEIGIK(Entity KPFAGKHHMMH, [Out] Transform MCPAEAAAAAM);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NBJAAJDNPLG(Entity KPFAGKHHMMH);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BCACMDHNDCI(Entity KPFAGKHHMMH, Entity PBJPKNOEMPL, Entity BCPOGOCDLFM);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class KAIMOGFBPON
{
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NLCLDNOPJLK
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMHHKDPBJLL(bool DGANKCELALD);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LIDOLEINANO
{
	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOCKPJGJHHB(CIBKNFGEPGP OFNKJKFNBEJ, IEnumerable<string> FIHHAAIJGPL);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOJOLCGEFGO(CIBKNFGEPGP OFNKJKFNBEJ, IEnumerable<string> FIHHAAIJGPL);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFPCGJNAHJP(CIBKNFGEPGP OFNKJKFNBEJ, params string[] FIHHAAIJGPL);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INGMHKOOOEE(CIBKNFGEPGP OFNKJKFNBEJ, params string[] FIHHAAIJGPL);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PPMCJNFKFOB(CIBKNFGEPGP OFNKJKFNBEJ, params string[] FIHHAAIJGPL);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LLHEEMJHLEE(CIBKNFGEPGP OFNKJKFNBEJ, params string[] FIHHAAIJGPL);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int AMFBAHAHIBE(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int BHKDLIMBMIB(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int KJOHHGNANDE(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CMOJLDHFHHM(CIBKNFGEPGP OFNKJKFNBEJ, ICollection<string> MPEAPFFMFIL);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool INLNEKEFMIK(CIBKNFGEPGP OFNKJKFNBEJ);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DDOJLALENFN(CIBKNFGEPGP OFNKJKFNBEJ, ICollection<string> MPEAPFFMFIL);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CEFEDMJJAJK(CIBKNFGEPGP OFNKJKFNBEJ, string ODABBBAHLHK);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HIAIENIJIBD(string ODABBBAHLHK, IODHKOECLEP LPALIJJMEFB);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CIBKNFGEPGP BBMDPCHMGGE(string ODABBBAHLHK);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KAGFKHGKFJC(string ODABBBAHLHK, IODHKOECLEP LPALIJJMEFB);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ODPGENJLLCA(CIBKNFGEPGP MCDHBEPOBIA, string ODABBBAHLHK, IODHKOECLEP LPALIJJMEFB);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool GJEEAMCELNJ();

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FBNKPJLIEAI(IEnumerable<string> FIHHAAIJGPL);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HCLDHBMMOBC
{
	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World KFAAHNGIKKP(string CAOKNNKPCNK = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World APFEFECGBLA(string CAOKNNKPCNK = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World MONKECGEEHP(string CAOKNNKPCNK = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World AJCKADEANGM(string CAOKNNKPCNK = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EEPABMPJIMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	World PIHACLGEMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	World NGHLIKAOMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	EntityManager AGJILKLBNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase BPCFGMMCPGO(Type MDOOANEGCAH);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class CILKMMEGDKG
{
	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x7383D20", Offset = "0x7382F20", VA = "0x187383D20")]
	public static ComponentSystemBase OMKDPMPGLDJ(this World HMFCAHOKFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x30BC6D0", Offset = "0x30BB8D0", VA = "0x1830BC6D0")]
	public static T BPCFGMMCPGO<T>(this EEPABMPJIMJ APOCADJFHBG) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JCMGGFKKIFK
{
	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDLNOIPIPCE(NativeListAsync<Entity> PCFECOFIBNM);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLEDLPCCKCE(OPHEHCEHDMC AIKLLKAIFIG);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKOBCBGFNHN(NativeListAsync<Entity> GEPNAKMOAAD, bool JOEIIMINHIH);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OKOLDKFFILP();

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJKOCAGHJOB(Entity DONMCNODAED);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CBPKJJGCCHH
{
	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGHBNNELHLI(Collider GIBMJBECLPO, [Out] BPLFGCNEMLM BCIOLNICCEO);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DBDFBDLKLCO
{
	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider OANNLMDIJLG(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject MHBBIOMHNNH(CIBKNFGEPGP JGIEFOBLLIO, GameObject CJAMBKAOMGP, Vector3 ONLMFNGKLOH, Quaternion IBAINNMCHCO);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGDAACEOPED(GameObject GIBMJBECLPO);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider IDCPKODNFND<TCollider>(GameObject LLJIEIMCGAL) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IAGIACFEGKP(Collider GIBMJBECLPO);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject FHKMBBJMMFC<TCollider>(string LMOANCJLHKC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CBJAADBFEAL LCCHAJGMEGH(CIBKNFGEPGP JEFIOIPIMIB, CIBKNFGEPGP HCAEOJFBEIN, EAOBBGHPEOO NCOOEIOLIDB, float3 GCBAOJFMOBE, quaternion AIMNGPAHLML, float3 JADJHKEDFMJ);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NLBHAGIEDEG(CIBKNFGEPGP IMMLHGFCKGF, [Out] CBJAADBFEAL GIBMJBECLPO);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HIPAOGMMGDN(CIBKNFGEPGP IMMLHGFCKGF, [Out] CIBKNFGEPGP DONMCNODAED);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public enum LMJKBCDMEEF
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HBJOEILPNHI
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public struct DFABNAMFPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int NCOOEIOLIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public GameObject CJAMBKAOMGP;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJNFNKEKGAG(CIBKNFGEPGP IMMLHGFCKGF, BDJEHBJKPBL FNFMPMNJPKE, bool MBDOKEBJDFE, EFIBLMLADKJ PJBAKFJDFIF);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEPAFBLHNJI(CIBKNFGEPGP IMMLHGFCKGF, BDJEHBJKPBL FNFMPMNJPKE, bool MBDOKEBJDFE, bool ENKDHKLCFMH, bool KHCFJLICIGL);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PFAHFLNFHHJ ECKGMDHHOJL(CIBKNFGEPGP DONMCNODAED, List<CIBKNFGEPGP> MAEHAOABFAP);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CBJAADBFEAL JFGPCNNOLJK(GameObject LAIHBHDLKKN, GameObject ALHLPKBHPML);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNNLFHECDPB(GameObject LAIHBHDLKKN, List<GameObject> PFKIHGDOGEK);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HECONINHKDC(GameObject ALHLPKBHPML);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T IDCPKODNFND<T>(GameObject LLJIEIMCGAL) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IAGIACFEGKP(Collider GIBMJBECLPO);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject EGGEGFCMGKP<T>(string LMOANCJLHKC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ENILAFBLGLJ(Collider GIBMJBECLPO, [Out] CIBKNFGEPGP EMDADMPPCND);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool COKCKLGAKMF(CIBKNFGEPGP IMMLHGFCKGF, [Out] BPLFGCNEMLM BCIOLNICCEO);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<LMJKBCDMEEF> OBOGLCKAPKA(Allocator NNHCNMKJHLF = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] NAFBEMFCMLI();

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int JEDBDMNBDJE(BDJEHBJKPBL FNFMPMNJPKE);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	string NPGIIIEFJLI(BDJEHBJKPBL FNFMPMNJPKE);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BEKMNEBJFDN
{
	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHJIJLKPAKP(CIBKNFGEPGP IMMLHGFCKGF, CIBKNFGEPGP OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEHAKIHJFLL(CIBKNFGEPGP IMMLHGFCKGF, CIBKNFGEPGP OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BAPKNNIDIAP(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CIBKNFGEPGP KHGACFDDFNM(CIBKNFGEPGP IMMLHGFCKGF, int CPLNODNGKGB);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NDNBDIACCIO IEFPCIGNFBO(CIBKNFGEPGP IMMLHGFCKGF, Allocator NNHCNMKJHLF = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BFEGIOPJKHM(CIBKNFGEPGP IMMLHGFCKGF, object BCOHKLCJCPM, CIBKNFGEPGP OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCDOKGGPFJE(CIBKNFGEPGP IMMLHGFCKGF, object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GGCADGILPMD(CIBKNFGEPGP IMMLHGFCKGF, [Out] CIBKNFGEPGP OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ONOBGKCPOOP(CIBKNFGEPGP IMMLHGFCKGF, float3 OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EAACEKGFFFK(CIBKNFGEPGP IMMLHGFCKGF, [Out] float3 OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HNKJGMBKLHB(CIBKNFGEPGP IMMLHGFCKGF, float3 OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FNCIBIKOHLD(CIBKNFGEPGP IMMLHGFCKGF, [Out] float3 OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HIKGOOCIGHK(CIBKNFGEPGP IMMLHGFCKGF, (Quaternion rot, Vector3 moments) MKOKFACDBAF);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JCPECHHOKGL(CIBKNFGEPGP IMMLHGFCKGF, [Out] quaternion EBCDHKCKBJF, [Out] float3 DHDOBCOAJNN);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CLCHDBPNOOA(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 HCBFELIBBJL(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 BDGMDPKJCLD(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DBNEPFLIKKH(CIBKNFGEPGP IMMLHGFCKGF, float3 OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KLKKLAFKAGB(CIBKNFGEPGP IMMLHGFCKGF, float3 OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float ALIAIGIDMHI(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float DKGNONHAOAN(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GJIHEAOBHBL(CIBKNFGEPGP IMMLHGFCKGF, float OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KOMFDHDLNNF(CIBKNFGEPGP IMMLHGFCKGF, float OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode JKAGNCKDHBG(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ACJDPLFJFMI(CIBKNFGEPGP IMMLHGFCKGF, CollisionDetectionMode OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NEGICDPELDL IFJOLPGCGBD(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LPMPKOHOFPE(CIBKNFGEPGP IMMLHGFCKGF, NEGICDPELDL OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LODJCMDHLFF(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LNCICOEPJON(CIBKNFGEPGP IMMLHGFCKGF, bool OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CIBKNFGEPGP MDHPIGKLOIL(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KNGCFBAHNAL(CIBKNFGEPGP IMMLHGFCKGF, CIBKNFGEPGP OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	CIBKNFGEPGP PMNHNJKCDDE(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HIDFBJMELPN(CIBKNFGEPGP IMMLHGFCKGF, CIBKNFGEPGP OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	DCBINGCLJFB NKFONOADFEJ(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void EGPIBHAPKMO(CIBKNFGEPGP IMMLHGFCKGF, DCBINGCLJFB KNCGOCBINPC);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool GGKPDMPMLGC(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void ONNGFDHJKGG(CIBKNFGEPGP IMMLHGFCKGF, bool OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool BLHOMBHDJHB(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JHNLKJEAHBA(CIBKNFGEPGP IMMLHGFCKGF, bool OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints JMFOJHOJLDO(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void BIIJGAICLCG(CIBKNFGEPGP IMMLHGFCKGF, RigidbodyConstraints OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float MOGDIDIPFFP(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void IAKOJMEGAME(CIBKNFGEPGP IMMLHGFCKGF, float OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float INKHMONKAAO(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void HDLMGDONOKJ(CIBKNFGEPGP IMMLHGFCKGF, float OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool ALKOICMNIAP(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void GBONMHJNNKA(CIBKNFGEPGP IMMLHGFCKGF, bool OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool CLNGJKBCMLE(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void DEDBCDFHKLJ(CIBKNFGEPGP IMMLHGFCKGF, bool OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void AALMOEMLHAC(CIBKNFGEPGP IMMLHGFCKGF, int OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "50")]
	NBAEIOPIALM KGMBDDFMAPC(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void ANDOEAEKMCB(CIBKNFGEPGP IMMLHGFCKGF, NBAEIOPIALM OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	PPIGDFPOOHP PIDDELJLGCM(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void EBGCCGCOHBC(CIBKNFGEPGP IMMLHGFCKGF, PPIGDFPOOHP OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float BAIAKEJJCDJ(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void MKHNDOHEOPG(CIBKNFGEPGP IMMLHGFCKGF, float OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void CAOGJMMAGHI(CIBKNFGEPGP IMMLHGFCKGF, object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void DNKFCDLBCFB(CIBKNFGEPGP IMMLHGFCKGF, object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool IGGJJOLJMDC(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void NKJDIGBGIJK(CIBKNFGEPGP IMMLHGFCKGF, object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void IINDNCIBAHI(CIBKNFGEPGP IMMLHGFCKGF, object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool NLGPBKAIKKN(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool BBDOJKOGPNK(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody KOJAGGOHGAL(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void MIKDCOOPGNJ(CIBKNFGEPGP IMMLHGFCKGF, Rigidbody MHCBGAAMHGE);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void MCBPMNODKFL(CIBKNFGEPGP IMMLHGFCKGF, object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void JFABOKLMNDF(CIBKNFGEPGP IMMLHGFCKGF, object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool NFOGGEGMLEN(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void IJJHJLNBLCO(CIBKNFGEPGP IMMLHGFCKGF, float3 BEIJOKHFPBB);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void IMOAKHAJEMH(CIBKNFGEPGP IMMLHGFCKGF, float3 HGECGPDEJMF);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool EDOIBAAFPMG(CIBKNFGEPGP IMMLHGFCKGF, [Out] float3 BEIJOKHFPBB);

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool MDKGPBHDDJD(CIBKNFGEPGP IMMLHGFCKGF, [Out] float3 HGECGPDEJMF);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool NENADNLDIPI(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void ODDGCJJHBNJ(CIBKNFGEPGP IMMLHGFCKGF, object BCOHKLCJCPM, bool EEJHBJOAMHG);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void KCAMFJFFNHI(CIBKNFGEPGP IMMLHGFCKGF, bool BGCGMINFFGO);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void GGDOIIJPIKL(CIBKNFGEPGP IMMLHGFCKGF);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool JKGJPJACBGM(CIBKNFGEPGP IMMLHGFCKGF);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PIOLHKMIHKP
{
	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLHEIAGDGHM(Entity PKIMOKKABJC);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIMIHJKEHPK(Entity PKIMOKKABJC);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PFGAACPCDNO
{
	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHFJGCCFGDF(CIBKNFGEPGP MKMPLOHPJDC, bool DACNABCKDLN);

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COGNJFHDBCF(CIBKNFGEPGP MKMPLOHPJDC, int NIGKDAPIFGC);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public delegate void GHDMIBMAMDC(AGLMBIPPLLA IGHAPPOPJNF);
[Cpp2IlInjected.Token(Token = "0x200009E")]
public readonly ref struct AGLMBIPPLLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly NDNBDIACCIO GAIDLNBALLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NativeArray<byte> KGKHOCAIHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NativeArray<byte> AIGNIMOHCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly GFCAKFAODMC FPOONLFOOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly int EKJFGEAGEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly Type BIKNALKNCLM;

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public NDNBDIACCIO IFIPHBGHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x49CB4E0", Offset = "0x49CA6E0", VA = "0x1849CB4E0")]
		get
		{
			return default(NDNBDIACCIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public int JBMLOIOBDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x7380BA0", Offset = "0x737FDA0", VA = "0x187380BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x7380BF0", Offset = "0x737FDF0", VA = "0x187380BF0")]
	public AGLMBIPPLLA(NDNBDIACCIO GAIDLNBALLL, NativeArray<byte> KGKHOCAIHMN, NativeArray<byte> AIGNIMOHCDJ, GFCAKFAODMC FPOONLFOOIF, int EKJFGEAGEKD, Type BIKNALKNCLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x39ED3B0", Offset = "0x39EC5B0", VA = "0x1839ED3B0")]
	public NativeArray<T> BBPFMPHJCEE<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x39ED4E0", Offset = "0x39EC6E0", VA = "0x1839ED4E0")]
	public NativeArray<T> MENPHCJMHHJ<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x39ED3F0", Offset = "0x39EC5F0", VA = "0x1839ED3F0")]
	public (NDNBDIACCIO, NativeArray<T>, NativeArray<T>) BGMHNJIJIDG<T>() where T : struct
	{
		return default((NDNBDIACCIO, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x7380BC0", Offset = "0x737FDC0", VA = "0x187380BC0")]
	public DMLDPBOMLKD OICPGJDPGHE()
	{
		return default(DMLDPBOMLKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface NKDGKKIBGPK
{
	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	string JEEOFPKMGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	NKDGKKIBGPK LAPCIOOKIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	IEnumerable<NKDGKKIBGPK> CINIMLLBKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DFNEHJMGEOJ
{
	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	NKDGKKIBGPK FJFFNLDCHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	NativeArray<GFCAKFAODMC> BFLCNDEEMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NLHFEKHKILG(GFCAKFAODMC FPOONLFOOIF, [Out] NKDGKKIBGPK GEDEGGCFAKO);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMFBCAGPLCG(GFCAKFAODMC FPOONLFOOIF, GHDMIBMAMDC PNHJGLINFHM);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLLHIOFIBAC(GFCAKFAODMC FPOONLFOOIF, GHDMIBMAMDC PNHJGLINFHM);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LFNDBJLAEDM
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMFBCAGPLCG(GFCAKFAODMC FPOONLFOOIF, GHDMIBMAMDC PNHJGLINFHM);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLLHIOFIBAC(GFCAKFAODMC FPOONLFOOIF, GHDMIBMAMDC PNHJGLINFHM);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class CNIDAJKCAND
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JFKCAAABPDJ
{
	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	DACPMAAJPHH FIPFODLAGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKLALGFDPEK(CBHIEDOMBAP ACOACGBKLMC, GFCAKFAODMC FPOONLFOOIF);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBFENNJHFDG(CBHIEDOMBAP ACOACGBKLMC, Span<GFCAKFAODMC> LJAGDLAELPK, bool DLHAALHELDM);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIKNNFOOOCN(NativeArray<CBHIEDOMBAP> FBEGNHDLGJI);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class DIINAPDAIIC
{
	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x7385CF0", Offset = "0x7384EF0", VA = "0x187385CF0")]
	public static void NBFENNJHFDG(this JFKCAAABPDJ GFJOPMOKIFK, CBHIEDOMBAP ACOACGBKLMC, GFCAKFAODMC FPOONLFOOIF, bool DLHAALHELDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public readonly ref struct DMLDPBOMLKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly AGLMBIPPLLA LFDKFEEPNFP;

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public NDNBDIACCIO IFIPHBGHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x49CB4E0", Offset = "0x49CA6E0", VA = "0x1849CB4E0")]
		get
		{
			return default(NDNBDIACCIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x7386200", Offset = "0x7385400", VA = "0x187386200")]
	public DMLDPBOMLKD(AGLMBIPPLLA LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x7385E40", Offset = "0x7385040", VA = "0x187385E40")]
	public NDNBDIACCIO BBPFMPHJCEE()
	{
		return default(NDNBDIACCIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x7386130", Offset = "0x7385330", VA = "0x187386130")]
	public NDNBDIACCIO MENPHCJMHHJ()
	{
		return default(NDNBDIACCIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x7385F10", Offset = "0x7385110", VA = "0x187385F10")]
	public (NDNBDIACCIO, NDNBDIACCIO, NDNBDIACCIO) BGMHNJIJIDG()
	{
		return default((NDNBDIACCIO, NDNBDIACCIO, NDNBDIACCIO));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class GPDGCJGBOKB
{
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public readonly struct DACPMAAJPHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly NativeBitArray JFNAACFIBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly NativeParallelHashMap<CBHIEDOMBAP, int> BLNBHKOPANO;

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public bool MEJCLCCDGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x7384CE0", Offset = "0x7383EE0", VA = "0x187384CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x49ADA30", Offset = "0x49ACC30", VA = "0x1849ADA30")]
	public DACPMAAJPHH(NativeBitArray JFNAACFIBLK, NativeParallelHashMap<CBHIEDOMBAP, int> BLNBHKOPANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x7384BB0", Offset = "0x7383DB0", VA = "0x187384BB0")]
	public bool CKLALGFDPEK(CBHIEDOMBAP ACOACGBKLMC, GFCAKFAODMC FPOONLFOOIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JPLOJLEEOAH
{
	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	JHEIHPJJONE NMJCMNFBIOC
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NHCMBLLOECB
{
	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KKHPIEPDMMG(CIBKNFGEPGP IMMLHGFCKGF, LHLPPNFLPDM OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IMHPOJOIOJD DBDDPKEINCA();
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JCOJACFHIFA
{
	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BAEKNIDPMEI(World HMFCAHOKFHD);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKDFIIPFLDB(World HMFCAHOKFHD);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase KJICMCEPAAC(World HMFCAHOKFHD);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CPBCIMCDKHK(World HMFCAHOKFHD);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CMPAHLJPGFO(World HMFCAHOKFHD);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AOGPOIDKFFP(World HMFCAHOKFHD);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GAHNCEAGCGD(World HMFCAHOKFHD);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> FJOLLLLLEKD();
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NHMJFNPMBLN
{
	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAIHGBEBDLJ(CIBKNFGEPGP MMGDIFNEOOE, bool OMEFCJCOLII);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public readonly struct JLAAGMIGLMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IEnumerable<FJCKLOBLJMO> JHPJFCHDMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly IReadOnlyList<GameObject> OOMAJILCEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly IReadOnlyList<int> CBIKNPHNNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly IReadOnlyList<(CBHIEDOMBAP, CBHIEDOMBAP)> IADOKFJPEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly int HECGBLJHIJO;

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public bool CLGLGAODANF
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x738BBD0", Offset = "0x738ADD0", VA = "0x18738BBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public int ANKPFKDIKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public IEnumerable<GameObject> IJKGCEPPEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xC14800", Offset = "0xC13A00", VA = "0x180C14800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public IEnumerable<(CBHIEDOMBAP src, CBHIEDOMBAP dst)> EPBJNHEPPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x738BFB0", Offset = "0x738B1B0", VA = "0x18738BFB0")]
	public JLAAGMIGLMF(IEnumerable<FJCKLOBLJMO> JHPJFCHDMIL, IReadOnlyList<GameObject> OOMAJILCEFM, IReadOnlyList<int> CBIKNPHNNOK, IReadOnlyList<(CBHIEDOMBAP src, CBHIEDOMBAP dst)> IADOKFJPEGH, int HECGBLJHIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x738BC30", Offset = "0x738AE30", VA = "0x18738BC30")]
	public (GameObject, int)[] AJMIPOIIJAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.Application)]
public interface LGPNHEBMOLL
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public class HNHAMGACPME
	{
		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public CIBKNFGEPGP ACBBFNLKNHG
		{
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			[CompilerGenerated]
			get
			{
				return default(CIBKNFGEPGP);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0xBAAAB0", Offset = "0xBA9CB0", VA = "0x180BAAAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public UniformTRS KEKNJNCMLCE
		{
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x3FBAF90", Offset = "0x3FBA190", VA = "0x183FBAF90")]
			[CompilerGenerated]
			get
			{
				return default(UniformTRS);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x738A120", Offset = "0x7389320", VA = "0x18738A120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public bool AONOEPKLANK
		{
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0xC0B620", Offset = "0xC0A820", VA = "0x180C0B620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0xC0B640", Offset = "0xC0A840", VA = "0x180C0B640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public KCPJIHCMNEK EIJFKBPOAHN
		{
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0A0", Offset = "0x8FA2A0", VA = "0x1808FB0A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public bool DEHBANIAIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0xABD790", Offset = "0xABC990", VA = "0x180ABD790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0xAC3940", Offset = "0xAC2B40", VA = "0x180AC3940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public InventionIdData BKOIAJEOCHC
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x8F21D0", Offset = "0x8F13D0", VA = "0x1808F21D0")]
			[CompilerGenerated]
			get
			{
				return default(InventionIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0xCC4CE0", Offset = "0xCC3EE0", VA = "0x180CC4CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public InventionInstanceIdData ECGLJFCNLIG
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xBBC090", Offset = "0xBBB290", VA = "0x180BBC090")]
			[CompilerGenerated]
			get
			{
				return default(InventionInstanceIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0xEB66D0", Offset = "0xEB58D0", VA = "0x180EB66D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public bool EHEMKNHJLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0xBBC060", Offset = "0xBBB260", VA = "0x180BBC060")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0xD5D500", Offset = "0xD5C700", VA = "0x180D5D500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x738A130", Offset = "0x7389330", VA = "0x18738A130")]
		public HNHAMGACPME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	bool KHGIMJKCFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	bool GFEGOONEGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	PDPGPILEHHN FKFNOPBDINC
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DBOONAOPNLD HKIFNACHDCJ();

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DBOONAOPNLD GNFDFELINAA(IEnumerable<CIBKNFGEPGP> PPCLEJEKIDG, [In] UniformTRS ABOKLLBKJAB);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HEDEONKFIAC IMOKLCLFNDI(ByteString PMKCPABLHHJ);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CJPOJLJGJJJ FANIDDLOBJF(ByteString IBMGILDHNGE, HNHAMGACPME HLJPDMABNJO);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OGECMIBLHND();

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JLAAGMIGLMF OPAIJGFGHDA(IEnumerable<FJCKLOBLJMO> JHPJFCHDMIL);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class AGEFJHLHBGP
{
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.Application)]
public interface JFPHOCNGNNI
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action KKCDMKGKJHD;
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct DEKFFHAAJPL : IEquatable<DEKFFHAAJPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public EHDGIFBGGFC FNDCBDLPGJI;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x7385C90", Offset = "0x7384E90", VA = "0x187385C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x1EAF350", Offset = "0x1EAE550", VA = "0x181EAF350", Slot = "4")]
	public bool Equals(DEKFFHAAJPL JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x7385C10", Offset = "0x7384E10", VA = "0x187385C10", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MOKFJNOFIFG
{
	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	uint HFJCLGIHFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum JLMCHNKPMHH
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BOLDJHEFOKG
{
	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPNNBHGEIKJ(HLDFMHEKDJA PDEGCFKDOBB, ReadOnlySpan<byte> OCPJHHIMKFB);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJGMDCHLEHF(uint IIMKKDJMCBG, ReadOnlySpan<byte> OCPJHHIMKFB);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNKNGJDHCCC(int FGKNOCMAHEA);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PDFEJMANKFJ
{
	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLDFMHEKDJA IAPOCDGKCLF(ReadOnlySpan<byte> OCPJHHIMKFB);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AHAAENLJKMB
{
	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCMHICAKFAO(HLDFMHEKDJA OFPBICPHALF, ReadOnlySpan<byte> OCPJHHIMKFB);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNIBLMFNGAN(ReadOnlySpan<HLDFMHEKDJA> FHLEIDBJOFF);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct KADEJLLHBEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public HLDFMHEKDJA PDEGCFKDOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public ReadOnlyMemory<byte> OCPJHHIMKFB;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct HLDFMHEKDJA
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public static HLDFMHEKDJA NPNJMHDEAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public uint OHCCKDFOMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int JHBOBDEOPAO;

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0xBBA4F0", Offset = "0xBB96F0", VA = "0x180BBA4F0")]
	public HLDFMHEKDJA(uint OHCCKDFOMNM, int JHBOBDEOPAO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x7389F20", Offset = "0x7389120", VA = "0x187389F20")]
	public static bool CCHBIHOFELC([In] HLDFMHEKDJA FBCBJPMNPEK, [In] HLDFMHEKDJA HHDMEFHBCOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x7389F40", Offset = "0x7389140", VA = "0x187389F40", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x7389FF0", Offset = "0x73891F0", VA = "0x187389FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x738A030", Offset = "0x7389230", VA = "0x18738A030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x738A020", Offset = "0x7389220", VA = "0x18738A020")]
	public void NLHBJIEEJHA([Out] uint OHCCKDFOMNM, [Out] int JHBOBDEOPAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct FJCKLOBLJMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Guid IBPGMNEANFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public string ACAIINBEMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Vector3 FCKJMOMOHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Quaternion EGIHDGHICMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public Vector3 KGBNKPFPEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public int CDOPMELEHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public Dictionary<string, object> HLJPDMABNJO;

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x73889F0", Offset = "0x7387BF0", VA = "0x1873889F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x7388860", Offset = "0x7387A60", VA = "0x187388860")]
	private static string EJJBDOGKMAM(Dictionary<string, object> EAFLMLPMBIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public enum NFOELFHPGJH
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	SubGraphReplace,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class PMMMOMIEDBG
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x7393FF0", Offset = "0x73931F0", VA = "0x187393FF0")]
	public static bool DHKAFDDPHDG(this NFOELFHPGJH MDOOANEGCAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[Flags]
public enum DEAOEEFGDGE
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	AdditivePhases = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public interface CJPOJLJGJJJ : PDPGPILEHHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	KCPJIHCMNEK EIJFKBPOAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOIJOOGLJMA();

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFNECDCJBNP();
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface PDPGPILEHHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	IEnumerable<FJCKLOBLJMO> FBCLOJPBJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	JLAAGMIGLMF HDDGJIGMCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	NFOELFHPGJH BLFPNJPCADF
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	LocalId JBAKICLJHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	DIOLKHKMLAM HBGPKNJKEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OPAIAFJGAEK(DEAOEEFGDGE PBDIEFIEIHM);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface KCPJIHCMNEK
{
	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMFFOKOLAAD(Guid BGKIOALJNDJ, [Out] Guid GGHDHEDBJLK);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface HEDEONKFIAC : PDPGPILEHHN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[Flags]
public enum EOBOAEHMKED
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public interface DBOONAOPNLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	DIOLKHKMLAM EFPGDJCDFBF
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString PFPDOPCCGCC();
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public enum CCANNPAPONC
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public struct MLPBIFHOPPC : ISystemStateComponentData, IComponentData, IEquatable<MLPBIFHOPPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public float3 KPOPDEAOOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public float3 NJKIDOPPMIA;

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x738F150", Offset = "0x738E350", VA = "0x18738F150", Slot = "4")]
	public bool Equals(MLPBIFHOPPC JAINJPLCLDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PGHPDJHDPHH
{
	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNCCHLMNJFN(long IEFELBDFABH);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKBCHLMMLAC(NativeParallelHashSet<long> NOICAEKGNBI);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EFFPCPHBPPD(World HMFCAHOKFHD, NativeParallelHashMap<Guid, long> PMALBODAEMG);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMDAEKJGKDB(CBHIEDOMBAP ACOACGBKLMC);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DDBFIBDCCHB(CBHIEDOMBAP ACOACGBKLMC, [Out] Guid KJKNDCHDJFK, [Out] long IEFELBDFABH);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LLMLKFDNAFL(CBHIEDOMBAP ACOACGBKLMC, Guid KJKNDCHDJFK, long IEFELBDFABH);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BCFFLFPPOFK(Guid KJKNDCHDJFK);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CNMDHPPPOCK(Guid KJKNDCHDJFK, [Out] int DFPHOCPMEKC, [Out] int CCFEOJGCLKF);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MLOAHJBMHCB(Guid KJKNDCHDJFK, int DFPHOCPMEKC, int CCFEOJGCLKF);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PCMLMBHNOCF(Guid KJKNDCHDJFK);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class ODLABCMJMIE
{
	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public ODLABCMJMIE()
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
