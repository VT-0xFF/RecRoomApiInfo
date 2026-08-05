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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86DF110", Offset = "0x86DDB10", VA = "0x1886DF110", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IDPEIKDODKO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x86D76C0", Offset = "0x86D60C0", VA = "0x1886D76C0")]
	public static void GBHMLCONEHK(this Rigidbody OAOFECMFMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x86D7850", Offset = "0x86D6250", VA = "0x1886D7850")]
	public static void GBHMLCONEHK(this Rigidbody OAOFECMFMGN, Vector3 NPFHGMHEAHK, Quaternion PFDDJKNAFBO, Vector3 LBBIOGCPIDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct BKGDNKOLHBO : IReadOnlyList<IJNJMBEMEOM>, IEnumerable<IJNJMBEMEOM>, IEnumerable, IReadOnlyCollection<IJNJMBEMEOM>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct AFJOOCLLNNL : IEnumerator<IJNJMBEMEOM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly LHOENBPGPCA BNOBLABHPIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator BNAAJHEIBMD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IJNJMBEMEOM IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x86CC5E0", Offset = "0x86CAFE0", VA = "0x1886CC5E0", Slot = "4")]
			get
			{
				return default(IJNJMBEMEOM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x86CC590", Offset = "0x86CAF90", VA = "0x1886CC590", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x56F4740", Offset = "0x56F3140", VA = "0x1856F4740")]
		public AFJOOCLLNNL(LHOENBPGPCA BNOBLABHPIM, NativeArray<LocalId>.Enumerator BNAAJHEIBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86CC4D0", Offset = "0x86CAED0", VA = "0x1886CC4D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86CC510", Offset = "0x86CAF10", VA = "0x1886CC510", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86CC550", Offset = "0x86CAF50", VA = "0x1886CC550", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ABKBPEENBLI NOJLBGFGHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> JAPKGPLEDNP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IJNJMBEMEOM PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86CF630", Offset = "0x86CE030", VA = "0x1886CF630", Slot = "4")]
		get
		{
			return default(IJNJMBEMEOM);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86CF100", Offset = "0x86CDB00", VA = "0x1886CF100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int CMBJIPECILD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LHOENBPGPCA DIBEEIFKJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x86CF0B0", Offset = "0x86CDAB0", VA = "0x1886CF0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PNGIKAIMAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86CED60", Offset = "0x86CD760", VA = "0x1886CED60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> IEEHACEKELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2D72040", Offset = "0x2D70A40", VA = "0x182D72040")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> OIKBBAIJBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86CF160", Offset = "0x86CDB60", VA = "0x1886CF160")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86CF580", Offset = "0x86CDF80", VA = "0x1886CF580")]
	public BKGDNKOLHBO(int JHAGJEMJCCP, LHOENBPGPCA BNOBLABHPIM, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x86CF570", Offset = "0x86CDF70", VA = "0x1886CF570")]
	public BKGDNKOLHBO(ABKBPEENBLI NOJLBGFGHBD, NativeArray<LocalId> JAPKGPLEDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x86CF3E0", Offset = "0x86CDDE0", VA = "0x1886CF3E0")]
	public BKGDNKOLHBO(ABKBPEENBLI NOJLBGFGHBD, NativeArray<Entity> JAPKGPLEDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x86CF2A0", Offset = "0x86CDCA0", VA = "0x1886CF2A0")]
	internal BKGDNKOLHBO(LHOENBPGPCA BNOBLABHPIM, NativeArray<Entity> BKFKEKMLADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x86CF500", Offset = "0x86CDF00", VA = "0x1886CF500")]
	internal BKGDNKOLHBO(LHOENBPGPCA BNOBLABHPIM, NativeArray<LocalId> JAPKGPLEDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x86CF450", Offset = "0x86CDE50", VA = "0x1886CF450")]
	public BKGDNKOLHBO(LHOENBPGPCA BNOBLABHPIM, int AJDEGEPLAEO, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x86CF330", Offset = "0x86CDD30", VA = "0x1886CF330")]
	public BKGDNKOLHBO(BKGDNKOLHBO JGBMNAIPAEG, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x86CEE40", Offset = "0x86CD840", VA = "0x1886CEE40")]
	public void KPNIEKPKGAM(List<IJNJMBEMEOM> GBEHGKLEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x86CEC50", Offset = "0x86CD650", VA = "0x1886CEC50")]
	public void FHJJAGPGGOB(int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86CEA20", Offset = "0x86CD420", VA = "0x1886CEA20")]
	public BKGDNKOLHBO AFCIIKKNNFA(Allocator EIOOMONCLID)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x86CEAC0", Offset = "0x86CD4C0", VA = "0x1886CEAC0")]
	public Span<IJNJMBEMEOM> BJJOPHEGHDC()
	{
		return default(Span<IJNJMBEMEOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86CEDA0", Offset = "0x86CD7A0", VA = "0x1886CEDA0")]
	public BKGDNKOLHBO KOPEJPFGOJC(int NPCHJIPLCII, int AJDEGEPLAEO)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x86CEC10", Offset = "0x86CD610", VA = "0x1886CEC10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x86CECA0", Offset = "0x86CD6A0", VA = "0x1886CECA0")]
	public AFJOOCLLNNL FIIFAFDLDFC()
	{
		return default(AFJOOCLLNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x86CF1C0", Offset = "0x86CDBC0", VA = "0x1886CF1C0", Slot = "6")]
	private IEnumerator<IJNJMBEMEOM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x86CF230", Offset = "0x86CDC30", VA = "0x1886CF230", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PLHKEFPOFGB
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3F86120", Offset = "0x3F84B20", VA = "0x183F86120")]
	public static OCCFPJFFJEE<T> HMDJPMFMNHL<T>(this BKGDNKOLHBO KGCMICBGABJ) where T : Component
	{
		return default(OCCFPJFFJEE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct JCPKDLEFKEO : IList<IJNJMBEMEOM>, ICollection<IJNJMBEMEOM>, IEnumerable<IJNJMBEMEOM>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct LBFLDJHHJPM : IEnumerator<IJNJMBEMEOM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LHOENBPGPCA BNOBLABHPIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator BNAAJHEIBMD;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IJNJMBEMEOM IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x86DE460", Offset = "0x86DCE60", VA = "0x1886DE460", Slot = "4")]
			get
			{
				return default(IJNJMBEMEOM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x86DE410", Offset = "0x86DCE10", VA = "0x1886DE410", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x56F4740", Offset = "0x56F3140", VA = "0x1856F4740")]
		public LBFLDJHHJPM(LHOENBPGPCA BNOBLABHPIM, NativeArray<LocalId>.Enumerator BNAAJHEIBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86DE350", Offset = "0x86DCD50", VA = "0x1886DE350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86DE390", Offset = "0x86DCD90", VA = "0x1886DE390", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x86DE3D0", Offset = "0x86DCDD0", VA = "0x1886DE3D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LHOENBPGPCA BNOBLABHPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> JAPKGPLEDNP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IJNJMBEMEOM PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE00", Offset = "0x86D9800", VA = "0x1886DAE00", Slot = "4")]
		get
		{
			return default(IJNJMBEMEOM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86DAEF0", Offset = "0x86D98F0", VA = "0x1886DAEF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86DA8C0", Offset = "0x86D92C0", VA = "0x1886DA8C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86DA8C0", Offset = "0x86D92C0", VA = "0x1886DA8C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> IEEHACEKELB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2D72040", Offset = "0x2D70A40", VA = "0x182D72040")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MECKNDEFNLE
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x86DACF0", Offset = "0x86D96F0", VA = "0x1886DACF0")]
	public JCPKDLEFKEO(LHOENBPGPCA BNOBLABHPIM, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x86DAD70", Offset = "0x86D9770", VA = "0x1886DAD70")]
	public JCPKDLEFKEO(LHOENBPGPCA BNOBLABHPIM, int AJDEGEPLAEO, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86DA900", Offset = "0x86D9300", VA = "0x1886DA900")]
	public BKGDNKOLHBO PDMGLKGLJCL()
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x86DA410", Offset = "0x86D8E10", VA = "0x1886DA410", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x86DA450", Offset = "0x86D8E50", VA = "0x1886DA450", Slot = "13")]
	public bool Contains(IJNJMBEMEOM EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x86DA4E0", Offset = "0x86D8EE0", VA = "0x1886DA4E0", Slot = "14")]
	public void CopyTo(IJNJMBEMEOM[] BHEONMJLANC, int LKIFOIIFCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x86DA390", Offset = "0x86D8D90", VA = "0x1886DA390", Slot = "11")]
	public void Add(IJNJMBEMEOM EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x86DA810", Offset = "0x86D9210", VA = "0x1886DA810", Slot = "7")]
	public void Insert(int KABGMIEBEFC, IJNJMBEMEOM EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x86DAA60", Offset = "0x86D9460", VA = "0x1886DAA60", Slot = "15")]
	public bool Remove(IJNJMBEMEOM EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x86DA780", Offset = "0x86D9180", VA = "0x1886DA780", Slot = "6")]
	public int IndexOf(IJNJMBEMEOM EOJOFJJBHLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86DAA10", Offset = "0x86D9410", VA = "0x1886DAA10", Slot = "8")]
	public void RemoveAt(int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86DA6B0", Offset = "0x86D90B0", VA = "0x1886DA6B0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86DA6F0", Offset = "0x86D90F0", VA = "0x1886DA6F0")]
	public LBFLDJHHJPM FIIFAFDLDFC()
	{
		return default(LBFLDJHHJPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x86DAB30", Offset = "0x86D9530", VA = "0x1886DAB30", Slot = "16")]
	private IEnumerator<IJNJMBEMEOM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x86DAC10", Offset = "0x86D9610", VA = "0x1886DAC10", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KDKGGFBHJIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IJNJMBEMEOM KNCFKMCINHN(IJNJMBEMEOM JAPKGPLEDNP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AOKLABCPBLJ : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface FMBBCMKCJOA : BPPJENMAJAJ, OCGDPOEPBCD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	FIILDCLBJJB DBJICEBHLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	ABKBPEENBLI OHHNAHEPGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface OCGDPOEPBCD
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool APIHKJHKGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface IDACNLDOPIH
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJHLIFJAECJ(bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMMOLKMNHIK();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface CADEIPKIEDL
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool IHHCMOHMPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MDBDBNIDEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool JKFHGKEMLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool MLLAHFJJCJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JMJFGNEENCP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODHCBEIBCMB(bool LEFHPHFNFDO);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NDGDKPOMILD(ByteString JHIJALIPOAH);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HCOCFEFIKNP();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FIKLAFLOEDE();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FIAEFFGAGJK();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface DJAJCMGGCAM
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	BDGILPFNAIO DBJICEBHLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	EKICOJLNLIH OENAIMEAFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	LJHJGFCEIBF GCJBHICBIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	FMBBCMKCJOA JICMPHHLNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	JNHMOICCOJK JCBEJIGIGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	CADEIPKIEDL FPNOJHMJHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	LLFKLOBKKPA MMMLNPEBKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	JKGNDKAOGNI ANHDKDNPELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	LGMIKJJLGHL ALILADAEPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	BBKILMFCMED KNPLINAIFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	ECNBPBALKNJ BALEPAFMDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	NCLPFAMPBNJ JHOGMBELNDO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	LHOENBPGPCA DIBEEIFKJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	GMLBIPLEOJF LCGJCININOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	AFFMFFNAANM OIIPIHLPJHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	KKKDMENDHIF JBJIFJIOEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	FBINECLMPCK DFCCMKFFKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ANIJHAHLIEC FMEODBMKBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	GLFJLMFDIJE HNBBMMLIJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KKOGGOEFFFO DFJDNLEKBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GJCCGPANIPI NDOOMDABBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	CLNJGFMGDLL EMKPBDOMMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	GKJINKADGCK BPEPHNHMGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FCAFONNGLMO LMFKDENKDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	FMNCINIGDKB DGLFEGCOHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	MALMDEKCFPP GDKHLKHBCED
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	ALCOIKKLOJF CGMCBABJCOC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	DOOPGKEPAJL MLFNOGDCJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	IFBEOOBNIFH LNNBLCEDFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FHKPKFNPBBM OHJJGOAHGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	EHMLGMHGPGO NAAGDFANAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CAIBNPNLHFH CFMADAGLPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	AJOFDPKBOJN LBIACGNJPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	DLINNPGLBOH AEIGEMPANEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	LGBDMHJCAGD PDJBGMAOJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KNLFMFEEKPA MPCIDACJAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	OPILNFDNHMH OFKONPCGJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	LFJPGHPMJEE MNEEHNNCBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	HKNGBJEBBJL EEOCGODLJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	CCFGJOFLFAJ AFODDBHOFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(MDLOKJDHOKH))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct IJNJMBEMEOM : IComparable<IJNJMBEMEOM>, IEquatable<IJNJMBEMEOM>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly IJNJMBEMEOM NAJKPDPODFG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int JLLFFMLIIGA = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int AICBAJOAAJO = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int POFFECDDCJL = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int BPGADGIHLPJ = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId EFILDLEHGNL;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LHOENBPGPCA DIBEEIFKJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x86CC0A0", Offset = "0x86CAAA0", VA = "0x1886CC0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FMBBCMKCJOA JICMPHHLNGK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x86D9650", Offset = "0x86D8050", VA = "0x1886D9650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LocalId AFIJGOKAJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x86D9850", Offset = "0x86D8250", VA = "0x1886D9850")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal ABKBPEENBLI OHHNAHEPGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x86D9460", Offset = "0x86D7E60", VA = "0x1886D9460")]
		get
		{
			return default(ABKBPEENBLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool JBKJHIIAKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86D96B0", Offset = "0x86D80B0", VA = "0x1886D96B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private bool KELIMHALHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x86D9600", Offset = "0x86D8000", VA = "0x1886D9600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x86D9B70", Offset = "0x86D8570", VA = "0x1886D9B70")]
	public IJNJMBEMEOM(LHOENBPGPCA PDOBAMKGJFH, LocalId EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x86D9AE0", Offset = "0x86D84E0", VA = "0x1886D9AE0")]
	public IJNJMBEMEOM(ABKBPEENBLI NOJLBGFGHBD, LocalId EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
	public ADKOMDJMHFH IIOJCKKDEAM()
	{
		return default(ADKOMDJMHFH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x86D9810", Offset = "0x86D8210", VA = "0x1886D9810")]
	public static LocalId HDPJNBPLGPE(IJNJMBEMEOM NPIOFDGBDHM)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x86D97D0", Offset = "0x86D81D0", VA = "0x1886D97D0")]
	public static Entity HDPJNBPLGPE(IJNJMBEMEOM NPIOFDGBDHM)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x86D9890", Offset = "0x86D8290", VA = "0x1886D9890")]
	public static bool NOPNAEDOCOI(IJNJMBEMEOM EICJFDNFOCB, IJNJMBEMEOM MIBIEOGGIAP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x86CB4E0", Offset = "0x86C9EE0", VA = "0x1886CB4E0")]
	public static bool DFNINOIAFHB(IJNJMBEMEOM EICJFDNFOCB, IJNJMBEMEOM MIBIEOGGIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x86D99B0", Offset = "0x86D83B0", VA = "0x1886D99B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x86D9470", Offset = "0x86D7E70", VA = "0x1886D9470", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x86D9370", Offset = "0x86D7D70", VA = "0x1886D9370", Slot = "4")]
	public int CompareTo(IJNJMBEMEOM GOCNHGEHNFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "5")]
	public bool Equals(IJNJMBEMEOM GOCNHGEHNFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DCCPHCIFEMK
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x86D0900", Offset = "0x86CF300", VA = "0x1886D0900")]
	public static ECANCCLIJHJ NGACMEKFHEL(this IJNJMBEMEOM PMNHIPACJLN)
	{
		return default(ECANCCLIJHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class MDLOKJDHOKH
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct ABKBPEENBLI : IEquatable<ABKBPEENBLI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte NOJLBGFGHBD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] AEBBDAOLLLI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static LHOENBPGPCA KILKAAEPGCP;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static FMBBCMKCJOA GDHJECNKIDG;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static LHOENBPGPCA[] NBGFMALMCAP;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static FMBBCMKCJOA[] HCHAOHGHPAN;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> AFHBHPLNFKH;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public FMBBCMKCJOA JICMPHHLNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x86CA760", Offset = "0x86C9160", VA = "0x1886CA760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public LHOENBPGPCA DNBIBCMNGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86CAFF0", Offset = "0x86C99F0", VA = "0x1886CAFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x86CB1A0", Offset = "0x86C9BA0", VA = "0x1886CB1A0")]
	static ABKBPEENBLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2DD8640", Offset = "0x2DD7040", VA = "0x182DD8640")]
	internal ABKBPEENBLI(byte KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x74D5F50", Offset = "0x74D4950", VA = "0x1874D5F50", Slot = "4")]
	public bool Equals(ABKBPEENBLI GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x86CA6C0", Offset = "0x86C90C0", VA = "0x1886CA6C0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x10D7B10", Offset = "0x10D6510", VA = "0x1810D7B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x86CB0E0", Offset = "0x86C9AE0", VA = "0x1886CB0E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x86CADD0", Offset = "0x86C97D0", VA = "0x1886CADD0")]
	private static LHOENBPGPCA OECFLOLLCBG(byte NOJLBGFGHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x86CA840", Offset = "0x86C9240", VA = "0x1886CA840")]
	private static FMBBCMKCJOA ILAIAFAANAA(byte NOJLBGFGHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x86CAE80", Offset = "0x86C9880", VA = "0x1886CAE80")]
	private static object OEEPFLKHNMA(byte NOJLBGFGHBD, object[] FDOLNIMJMJM, object KJMOBDOKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x86CA630", Offset = "0x86C9030", VA = "0x1886CA630")]
	private static int BIAMNKJPLHP(byte NOJLBGFGHBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x86CAB00", Offset = "0x86C9500", VA = "0x1886CAB00")]
	private static int LNGHAAJOPOA(byte NOJLBGFGHBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x86CA640", Offset = "0x86C9040", VA = "0x1886CA640")]
	private static (int, int) EMAJBOJCFHC(byte NOJLBGFGHBD)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x86CB0D0", Offset = "0x86C9AD0", VA = "0x1886CB0D0")]
	private static byte POMKODNBHIB(int PKNNCMNKNHL, int KABGMIEBEFC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x86CAB10", Offset = "0x86C9510", VA = "0x1886CAB10")]
	internal static ABKBPEENBLI NFFNLBFBLBL(FMBBCMKCJOA CLDGALIJMAM, LHOENBPGPCA ENEJEIEPCII)
	{
		return default(ABKBPEENBLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x86CA8F0", Offset = "0x86C92F0", VA = "0x1886CA8F0")]
	internal static void JJGBLGDOBGN(ABKBPEENBLI NOJLBGFGHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x86CA2A0", Offset = "0x86C8CA0", VA = "0x1886CA2A0")]
	private static void ANPGPCIJDGG(int JHAGJEMJCCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum EOHNBCNDHKH
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
public interface ICBFLECADFC
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool MMOABMPJOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NFEPKFJOGFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool PJLAMMPOBIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool DGHEHCPJCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool FNMCCGEGFJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KACPOIFJICL
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLGMJDLCHJH(KNHINBCEIIG KLIEGJHNGPK, int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BCBLLAEJIKE(KNHINBCEIIG LLCLIPBEBLK, int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IHCPMBBBFPD(GBBMODPOPBK OFDEKHKBNFG, int KABGMIEBEFC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FIIOLODGFLM : KNHINBCEIIG, ICBFLECADFC
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int NKOPNNOIDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGECNDMNMAO(ALKOPGECDEJ ENDDNPPKCPO, int KABGMIEBEFC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KNHINBCEIIG : ICBFLECADFC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum HNAEFEMABMA
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
	bool FIKAKPJEIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool LCAMIDJBACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool OILGCHGMGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ALKOPGECDEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool BHCJNFNLNME
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	BMLHKENOJFK MHHPGNMENBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	KFCDBCKJJIG JFHBIOCEDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 NGNFCFGNCAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	quaternion OHBEIHCPLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float3 JHKBPPBGAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	IEDBPPJHEGN OCAHEHKLJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	DJHMAEDPFEM JCMKCPCHLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float PCMMDIDGJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float3 FAIDHIOFDKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float CPDINOOBIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	DHMONCPGFAD KHMKEDNINPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BHBLGFCDNKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float3 DMEKCHJJJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float3 EGNLLOCNMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion BKJFNGGDPCK(float3 DBJDIOFCCBJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface KFCDBCKJJIG
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool LBLBPFNEEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool JCJIBOHEMMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool AJIAIJCINPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float AHFJMDBKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int LLFIDMJMMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int PFCBECHAKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EFHJEKENEDP(BHBLGFCDNKJ ENDDNPPKCPO, int KABGMIEBEFC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.OMRoom)]
public class LAPDHAKCEBI
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LAPDHAKCEBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface GNCJLFOMMOP
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Guid MDCOLHDCPMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DOCDBIHHMLJ(Guid OPOIGPPMOMB, Guid DKOKOBIEBLC, Guid AGAFPHAGCPG);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task NFBCNLHIPHE(Guid OPOIGPPMOMB, Guid[] CPJIFHACAMG, Guid AGAFPHAGCPG);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid LJLCOKMBAFB(Guid ABIELIKPOOO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HEPDJNFDDNK(IJNJMBEMEOM IENDKLGJNPN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DEMFFKNLPFF(Guid ABIELIKPOOO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JBLLECENCPM(BMODNEPBPKI KAEOCHDNAMO, Guid NGKIHADHDMG);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KEKCEONAKGK(Guid ABIELIKPOOO, bool LEFHPHFNFDO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GLPJHGGOPMF(Guid ABIELIKPOOO, ECANCCLIJHJ CKBMDKNDCPF);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OMHLJKLFAOC(ECANCCLIJHJ CKBMDKNDCPF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ECBPNAHEIKC(IJNJMBEMEOM EFILDLEHGNL);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface APDCEAFFJDE
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface EKODKJAFGCA
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "0")]
	void CGMDGDMLDLL(bool FCCCGLOCDNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface EKICOJLNLIH
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	EKODKJAFGCA CHKCEKNCLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	OOFGNGHGNBG IGKKLLJDHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	FOCGLCHKEPM DLDDPBMFJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	KHIOKABNGHK GGPBGIEJGBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	FDONBJOCPAM OEPJGGILEIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	KBMHDFGAHLI CPKNFBODLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	HILIPBGMOND JDFAFMFIAOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	JKAJFPJJEIP BEJLOGLLLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface OOFGNGHGNBG
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	string DLAPLENLBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface NOJHNLJAEPO
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBCJOBKLCIJ(Action FCCCPABHDPG, bool PGCBJFFJNON);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPAHDCCNBDH(string IELIBBNCJAC);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int ADKFKLHDKCO(string IELIBBNCJAC, int KJMOBDOKFBF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CFOCEDBBIHD([Out] bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BEOOBIPLGME([Out] bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FJPHFNJIFEC([Out] int KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FKCCGHOELKP([Out] bool KMAFNKGMDCF);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface FOCGLCHKEPM
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "0")]
	void MJDPAIPLOFC(bool LEFHPHFNFDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface KHIOKABNGHK
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid NFIJHPPALLP;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid JCNAHEBODDB;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid HPIIHHMMMMF;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid HHBGIAKGLBA;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool NNCGBAPHAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool MDLIAKNEPPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool ALCEKMCOAKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool KHBONLEHKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x86DE110", Offset = "0x86DCB10", VA = "0x1886DE110", Slot = "4")]
	string[] PPLJGNPCCJM(IFCMBFOMDFH BPJLLEFEPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEJCFHPFDJF();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x86DE0E0", Offset = "0x86DCAE0", VA = "0x1886DE0E0", Slot = "6")]
	Guid DOIBNMLHNMN(Guid FGGCGKCNCFD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int LBENLPAFOAO(IFCMBFOMDFH BPJLLEFEPPF);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DCJJACKFCMD(IFCMBFOMDFH BPJLLEFEPPF, NativeArray<BJFDHICACDP> IFGGNPBPFJP, NativeList<UniformTRS> CBBGHMEAKAF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int JOIAPDILFCB(Guid OCONCDFGCOB);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HPEOCJNICIB(string PKKNHBLDAJM, [Out] Guid OCONCDFGCOB);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string ANALLGGHBJJ(Guid OCONCDFGCOB);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IGHLOFKNCLJ(RRObjectPrefabData JBAMBOALJHP, [Out] LocalId BDOCGCBPBOC);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OCCFPJFFJEE<byte[]> FMGCGOCDBEN(NativeArray<BJFDHICACDP> IOOLPIPJGPL);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CKGMIPHPPIK(byte[] DAEDAAJLNFG);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GameObject KADKGPDDGBE(string PKKNHBLDAJM);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MGPLCIEAPGN(Transform HALOMIKDIAH, RRObjectPrefabData AANEMEOPKOE, DMCPBIKBILF IJNPIDPIBFP);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LOHPOKIBHDB(IFCMBFOMDFH BPJLLEFEPPF, NativeParallelHashMap<Guid, LocalId> HNNGBCNOMGB, [Out] Exception FGDPOGPHENJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KNKGFINMACC(IFCMBFOMDFH BPJLLEFEPPF, NativeParallelHashMap<Guid, LocalId> HNNGBCNOMGB, [Out] NativeArray<LocalId> BKFKEKMLADJ, [Out] NativeArray<LocalId> INPLEBDDOIB, [Out] NativeArray<AuthoredLocalPoseData> OOIECAHAPEJ, Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "19")]
	void FDFIOKJMEML(IFCMBFOMDFH KALMEDGIGPJ, NativeArray<int> KOOPKPLDCDJ, FMJHIDPKFMF<GameObject> MDCLGMCKFMC, OCCFPJFFJEE<GameObject> HCJMNAMPEJF, EOHNBCNDHKH CPLMAGJBLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MMPLELOMOHO();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "21")]
	void AOADBHNJHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "22")]
	void GBKFCHJHGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "23")]
	bool LCCIKGGOGCE(IFCMBFOMDFH BPJLLEFEPPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "24")]
	KACPOIFJICL INPLACPBOIH(IFCMBFOMDFH BPJLLEFEPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "25")]
	void IBGMEANNEIP(Guid IOFOBBIMJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "26")]
	bool DCDJDAPDBMB(Guid IOFOBBIMJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x86DE1A0", Offset = "0x86DCBA0", VA = "0x1886DE1A0")]
	static KHIOKABNGHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface LCKJOIEIDMM
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	long LMCEJCLIJON
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long LBHCKDPDBMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface FDONBJOCPAM
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool DGEAHJMLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool DPMNCDPBCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int HDIHMAKDCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int GMODFLLNLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int MPDLGMADCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool KENOOBEMNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	int KOKBCONHIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "6")]
	void DEABKOFKCFJ(PHHCOHEICGC DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
	void GNLCNCGIKOB(bool MHOIBIIPACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "8")]
	bool AGGPCMGEILN(AFPDBFALGFB MCNJLDELGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "9")]
	void LGCHHECHBMH(object IHHGLEDNONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "10")]
	void GKDIJENIGHJ(object IHHGLEDNONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EDAKNCOLBFJ(Action<object> EMPOBMBMBCB);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HPJOCECHLIF(Action<object> EMPOBMBMBCB);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "13")]
	void IHLNGNJIIJO(NativeArray<ViewId> GCFBCNOCJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "14")]
	void BMOIDGELADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "15")]
	void KLBHFIEBBND(LPMIJHKPLOD DGNODDPLLPC, ReadOnlySpan<byte> BLPDDGCLNPE, AFPDBFALGFB GPHPGLDNHJA, bool ABHOOFNGAGM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "16")]
	void KLBHFIEBBND(LPMIJHKPLOD DGNODDPLLPC, ReadOnlySpan<byte> OGGFHNANJOC, bool ABHOOFNGAGM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "17")]
	void KLBHFIEBBND(LPMIJHKPLOD DGNODDPLLPC, ReadOnlySpan<byte> OGGFHNANJOC, ReadOnlySpan<byte> NIDMNLINMKM, bool ABHOOFNGAGM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "18")]
	void BCFMNGBJPJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "19")]
	void PMLINGNGLCJ(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "20")]
	void GFFEAEDMIEJ(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "21")]
	void GDCPFPNJCCN(Dictionary<object, object> POLEONKNBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "22")]
	void JBCJCOLPHDB(NativeList<ECANCCLIJHJ> EGILEEIBKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "24")]
	void OEGKPBDGPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "25")]
	void BJOANPGEBAO(List<object> LEDABCFBDNN, int MHADOGLMBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "26")]
	void KIDGHHPCADD(int AJDKDOCHCDB, object PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "27")]
	void AELHLFDGEMI(AFPDBFALGFB MCNJLDELGIJ, object CKKGCGIJFBK, bool EEBDOKMMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "28")]
	void FJIMPEDAFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "29")]
	void HOGBFENMOOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class OBEDLBONAHH
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x86E2FD0", Offset = "0x86E19D0", VA = "0x1886E2FD0")]
	public static HEFMEKEHNEE IAOOMFMPDMG(this FDONBJOCPAM FDFGEPPACCC, object MFKHKDDANII)
	{
		return default(HEFMEKEHNEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct HEFMEKEHNEE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private FDONBJOCPAM FDFGEPPACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object MFKHKDDANII;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x86D69B0", Offset = "0x86D53B0", VA = "0x1886D69B0")]
	public HEFMEKEHNEE(FDONBJOCPAM FDFGEPPACCC, object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x86D6960", Offset = "0x86D5360", VA = "0x1886D6960", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NCPBAICODHG
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void NJKHMKFBJAO(ViewId KKGECNGDNCM, OFEHKIPCPMO PPCJDKFDHGK, int FPJMIEGHFGE);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "0")]
	void KBBEAMBLPCO(NJKHMKFBJAO OFBHLJOIIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "1")]
	void DFBBEBHLMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "2")]
	void MCPHLCOPFHF(GKNNEPJOJPO DHNILGMCEHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface EBJOABJJLCP
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface ABMDHNICAJN
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHBJOFIDFKI();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[ServiceLifetime(Lifetime.Application)]
public interface KBMHDFGAHLI
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct OPPHBIPDFBJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private KBMHDFGAHLI MJKBBFBFPLH;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x86E3A40", Offset = "0x86E2440", VA = "0x1886E3A40")]
		public OPPHBIPDFBJ(KBMHDFGAHLI MJKBBFBFPLH, string NICJKPGGLEM, string KEHJDIPABJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x86E39E0", Offset = "0x86E23E0", VA = "0x1886E39E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct NCKOPLHEJGO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private KBMHDFGAHLI MJKBBFBFPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task FLAIIHBKGBI;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x86DFCC0", Offset = "0x86DE6C0", VA = "0x1886DFCC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "0")]
	void EFPCOIEPNBC(string JEBOHIALEMJ, float NDKGEJPCLBH = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "1")]
	void LENJGIMKPHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PKENMMAENAM(bool EELOLFOJBLJ, string NICJKPGGLEM, string KEHJDIPABJO);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "3")]
	void LDDJDDIFMDH(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class MAFDGKPGEMK
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x86DF2B0", Offset = "0x86DDCB0", VA = "0x1886DF2B0")]
	public static KBMHDFGAHLI.OPPHBIPDFBJ KBPDNPMDDMC(this KBMHDFGAHLI FDFGEPPACCC, string NICJKPGGLEM, string KEHJDIPABJO)
	{
		return default(KBMHDFGAHLI.OPPHBIPDFBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface EIJLLEFBIDB
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OJKCHKLLNKI(GameObject FNCBMCHNDJI);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMMFDOPNAOL(GameObject FNCBMCHNDJI);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JCHOKEBGILL(int MCNJLDELGIJ);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object LOEOFMEPOBB(IJNJMBEMEOM EFILDLEHGNL, GameObject FNCBMCHNDJI, Action<IJNJMBEMEOM, int> AEPCPKCINPI);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HLFACLFELMI(GameObject FNCBMCHNDJI, object LNPPCIMNFIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FNJHNINICHC
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	DBODKOKNDFG MCIEGIDALIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LEDGHCAIHHI
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHINFINJMPA(MBMBOKIFJPB FFECJBDKDKI, GBBLNAFMLEP MABBIOOHFDB);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFECBDPLKFP(AFPDBFALGFB BLHNDOLLIDD, OPBIGPJHHKE AHGHLCOEIPK);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface GCMKILIDDDK
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCGCKFHBJPB(object PMNHIPACJLN, NativeList<byte> BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object LEOAOCFGODA(NativeArray<byte> BLPDDGCLNPE);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface EDJPAEIAINK
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool KIDBBPJOEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate MCPOMNANIKD(CBOAJDJACOO HGEIJEOEGCC, Action<CBOAJDJACOO> AEPCPKCINPI);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKDCPMMPPNI(CBOAJDJACOO HGEIJEOEGCC, Delegate AEPCPKCINPI);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate JPMPDFAIJBA(CBOAJDJACOO HGEIJEOEGCC, Action<CBOAJDJACOO> BPMOLEBCJJB);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLAJNFHECJB(CBOAJDJACOO HGEIJEOEGCC, Delegate AEPCPKCINPI);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JCPKGNGOBOI(CBOAJDJACOO HGEIJEOEGCC);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CBOAJDJACOO LKKOOLAIBOK(GameObject FNCBMCHNDJI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface JIGCLHCPMMN
{
	[Cpp2IlInjected.Token(Token = "0x17000080")]
	int EEJJNNJNJMN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	int HBDJCBFLOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool DGEAHJMLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool LJPOOLGIOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool EBDCFMAAJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IJNJMBEMEOM BNCLILGEDKM(int MCNJLDELGIJ);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AKLAAFIIABP(GameObject AOEOPCANCGC, JobHandle MKFPKDEJELL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface DBODKOKNDFG
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AMEDLAEIMHG(OPBIGPJHHKE ANOJKINPPNO, GBBLNAFMLEP KLMIPONNOGO);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface HILIPBGMOND
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool IHHCMOHMPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface PFBPGMHMPKE
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	JOGKHOGLCCH EMKHJAIFEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	ONEMHINNGHH EDDHOCBKPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool OJHJHIHGBKB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ONABNIPLENA(Transform HALOMIKDIAH);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONBBAKBOJLD(Transform HALOMIKDIAH, IKEGDKKKDKI AHJFFEBJFEB);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KIEGFNFLINL(Transform HALOMIKDIAH, KBICEEBHCID NNFDIFDOFPE);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[ServiceLifetime(Lifetime.Application)]
public interface JKAJFPJJEIP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NKBDCIKKBEN;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[ServiceLifetime(Lifetime.Application)]
public interface BIOIGAHPBBM
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLHENILOKJC();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[ServiceLifetime(Lifetime.Application)]
public interface LMBKIFPKDJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBPKJLJKMMK(GameObject FNCBMCHNDJI, BMPIDNBPFBI GCKLHAHICCE, HNJIPPJLGGJ KFEOOCPMIPK);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ANNGIONIKGC(IJNJMBEMEOM EFILDLEHGNL, bool KEJMJMCCJHF, float3 FPNNOCCIEEF, quaternion IFMEFLEGJDF);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PNAJDKIMMIM(BKGDNKOLHBO HMEJDGEGNIN);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OEFCICLNJJF(ADKOMDJMHFH HJCIABFMGKM, ADKOMDJMHFH JFBLIPHGGPK, OCLGKNFAEHE EDFBAIGMJKK);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLCFPPHDCEH(ADKOMDJMHFH HJCIABFMGKM, OCLGKNFAEHE EDFBAIGMJKK);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PBMOPOIBMKD(BKGDNKOLHBO NEIMDELFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EBGKDJAKBEF(IFCMBFOMDFH MKIFOHHALPC, ReadOnlySpan<Guid> MKALGPEPIIO, ReadOnlySpan<int> JBPLLIFMCIH, OCCFPJFFJEE<GameObject> PNFDDLEMEGK);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HDHDCFNAPEK(PFLKBNAMBMN DFHNBMLEMBK);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LLHMIOGNKCN(CBGFMPABMGM DGNAEPECIHL, CBGFMPABMGM DKCIGIFPIIN);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OOCNONKNGCB(CBGFMPABMGM DGNAEPECIHL, CBGFMPABMGM DKCIGIFPIIN);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KLCFMLOCBNA(IJNJMBEMEOM AGNAJHIEMIE);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct JCCCELPJENE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> BLPDDGCLNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle NOJLBGFGHBD;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x86DA2E0", Offset = "0x86D8CE0", VA = "0x1886DA2E0")]
	public JCCCELPJENE(ReadOnlyMemory<byte> FLHOBJPLFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x86DA2A0", Offset = "0x86D8CA0", VA = "0x1886DA2A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum ANBLJKLEJPP
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
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct IFCMBFOMDFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString PHKMHFIEFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object KNKHIMIHGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object FIJEHJPEGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> ALHCKJJAPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool JHMOGCLODNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public LBKPJOGNLIO.DMCPEECGPCL? JODMBLNPEHH;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x86D7980", Offset = "0x86D6380", VA = "0x1886D7980")]
	public IFCMBFOMDFH(ByteString PHKMHFIEFOA, [Optional] object KNKHIMIHGGK, [Optional] object FIJEHJPEGDG, [Optional] IEnumerable<string> ALHCKJJAPFE, bool JHMOGCLODNH = true, [Optional] LBKPJOGNLIO.DMCPEECGPCL? JODMBLNPEHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct EDMJHJKNEFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object IJKBJGKDPAF;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct BJFDHICACDP
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[Flags]
	public enum FLBKPILDOCN
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
	public RRObjectPrefabData EHBNKLJBAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid FJFCHHLHHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid OLLMBOBHBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid IMOPEMEGMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid KJEKNNBPHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public FLBKPILDOCN JHBIAAAGFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 HIHDBCKCCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int JEIEAPPJOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public LJKCMIOFFEL OOCGIPFNDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int LFMKIKJELKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int EFCOPCOCEFM;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Guid HMHMFDJJEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x56EF210", Offset = "0x56EDC10", VA = "0x1856EF210")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool LHGGHEABJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x86CE730", Offset = "0x86CD130", VA = "0x1886CE730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool HPGAPAADGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x86CE700", Offset = "0x86CD100", VA = "0x1886CE700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool AENOLENBODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x86CE720", Offset = "0x86CD120", VA = "0x1886CE720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool NBKELDPBGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x86CE710", Offset = "0x86CD110", VA = "0x1886CE710")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct NOCBNFKCJHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly EGLPPIMDOJN NPCHJIPLCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly EGLPPIMDOJN IEEBKKJDLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly uint BCGHGMNCNIM;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x86E2520", Offset = "0x86E0F20", VA = "0x1886E2520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct LCCOMAOKPAD
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly NOCBNFKCJHM FCCCPABHDPG;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x86D1BF0", Offset = "0x86D05F0", VA = "0x1886D1BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct EOKOONOAPJH
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly NOCBNFKCJHM FCCCPABHDPG;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x86D1BF0", Offset = "0x86D05F0", VA = "0x1886D1BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct KBLOKLHDNKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly uint BCGHGMNCNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly bool NKPHCOGJNEC;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x86DDE00", Offset = "0x86DC800", VA = "0x1886DDE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct EGLPPIMDOJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal int JBCPGNDLJHB;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x86D1A90", Offset = "0x86D0490", VA = "0x1886D1A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[ServiceLifetime(Lifetime.Application)]
public interface FOBPOBEOGNB
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	MCPPKDNKHNF GKCBHFAPEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface BMODNEPBPKI
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface EONJFNJCIOG
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NHGOBJGELPL
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3F08B20", Offset = "0x3F07520", VA = "0x183F08B20")]
	public static ADKOMDJMHFH IIOJCKKDEAM<T>(this T EFILDLEHGNL) where T : BMODNEPBPKI
	{
		return default(ADKOMDJMHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x86E20A0", Offset = "0x86E0AA0", VA = "0x1886E20A0")]
	public static MonoBehaviour OHCKOKGNGJE(this BMODNEPBPKI EFILDLEHGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x86E1FE0", Offset = "0x86E09E0", VA = "0x1886E1FE0")]
	public static GameObject DKIONLOHAIE(this BMODNEPBPKI EFILDLEHGNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface JAFGKDOMKOD : BMODNEPBPKI
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(IJNJMBEMEOM KKGNPJDBLLP);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface IFLJAJNJADJ : BMODNEPBPKI
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IFBNAGHJFPO
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate void LHKBEFFNNFN(MPPNIBENDEG FDNFLJCIBGK);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event LHKBEFFNNFN PGFFJFBDGFI;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface AJANMAHGCAE
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface KNCEOGMDJKB
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface HOJGIOMMAHM
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(IJNJMBEMEOM COPNGNOHPAA);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool AKDLJAOONNN);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IBHHBMNNOMM(IJNJMBEMEOM JGHKDIDNBJI);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface AGPKLEBEEEI
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(ANNBNLPJGPM CNFCPELBNPO);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface ANNBNLPJGPM
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	GameObject FNCBMCHNDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Transform HALOMIKDIAH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	GIFDOEAHBPA BEPHLKLNPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool ENCHKFGGMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFMGKMOOKEG(GIFDOEAHBPA FDMAPEJEBGO);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BMDNLBHNEKE GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class FMIAABJIMGP
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x86D3C10", Offset = "0x86D2610", VA = "0x1886D3C10")]
	public static void FFFDAECAHOO(this ANNBNLPJGPM OPGHIHFJADP, DMCPBIKBILF IJNPIDPIBFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface GIFDOEAHBPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Rigidbody LFNIPFIPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	ANNBNLPJGPM PKDPEMEHBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	GameObject DKIONLOHAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	Transform AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	GIFDOEAHBPA AJFLBGMINPD
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	GIFDOEAHBPA GLKLCNOCKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	int AKHAHMFNAJG
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	bool CDGODCGHBAH
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool JCPKGNGOBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool DCJPCDJNIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	DNNEGEPPCEJ NOHOGNPFBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	CGLIKLHAHPB NDMOFMEBCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	float FNELBDCMICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 OCEPNBECDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 JKJEPGLHIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 OPBKGMDLBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 BEJKHPCMANK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool BNEGLBGNMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool FHNNMHDLDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool JBMANPDAEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool PFPMNLHFNCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Vector3 FIFLACCEFFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 AMHKJCKDPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Vector3 BIBEEELBBND
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Vector3 DMPACHBPOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	float AJAKBBEPOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float CNAKECDMPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Vector3 ICPJGPOABEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Quaternion DNBENHGJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float OBIIGODIOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	float FNGOOOIJEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool EFDEBDPIPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	FMHNBNKGEEA EMHMEMCBIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool DPDLMKLLGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	Transform IPBJAMDPKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	Vector3 AJCPJAHJBDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	float JPGCGFKHDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	float ELCNLMLKKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Quaternion OMKCHIKPOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Vector3 DMEKCHJJJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Quaternion LJJEACHFGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	RigidbodyConstraints KCECLKHHDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	bool BGFNOMAKOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	CollisionDetectionMode PHKMHGCLFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	bool CPCNPNJKJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event PGINMDCPPIJ JKMJOEIKEHG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PGINMDCPPIJ HKKGGLPNLHM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event PGINMDCPPIJ EPHOAKNPHDO;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PGINMDCPPIJ OMIAOHKHACJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event PGINMDCPPIJ FBLJFEAKDPL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event PGINMDCPPIJ DBEEIDAMNHB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event PGINMDCPPIJ JNOGJPGDPEF;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JJNGNENMLJJ GCHNFJIEJPP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<ACOJACDAJIP, ACOJACDAJIP> GNOBOLCEDGK;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	GIFDOEAHBPA HNAFJFOBHHG(int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void LKGGAPCDBAA((Quaternion rot, Vector3 moments) FPHHKNIAPKM);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void JEALAPEIAJO();

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void HCIJLAOPINK();

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void AFEHIMDIEIF();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void CLLGOEBCMJL();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void LACPEDJKBHI();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void IEBALGDGBAK(GIFDOEAHBPA KMAFNKGMDCF, bool NFCKHMKCNGK = false);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void DNMIHIPMFPJ(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void ANJHGHKAODE(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 BOFPKOFOGEF(Vector3 HBCKENKNHBM);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 JLFPAOGPFMO(Vector3 PKCKKEIEJJG);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void BGNNKMEGKCB();

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void JJJJNDBENCB();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void LAJLEHMLEEI();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void KMMDEOGFIOG(Vector3 MCGFEPBEJMH, Vector3 JMHODIHNCOE);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void JDKJPMDJMPC(Vector3 MPEGMNNICAA, Vector3 BGDJKDINADB);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void MMADJBHMKAL(Vector3 ELDEDOKAACG);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void JGCLCKCNNIA(ILIKBONEJOO GPDAHHPDDKG, Vector3 ECAJAFJNDJO, float PLMCHHBJBJF, float LKIAJOBMEOM = 8f, float CKNNLHJFOKK = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void CKDLJGADBGC(MPBOJIIMMCC NIOFENKCHOC, Vector3 DGNINMFNFAK, float ICLMNIBGAOB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void KHIIONODKED(MPBOJIIMMCC NIOFENKCHOC, Vector3 AMHDLJKDJBK, float DIJFDBBAGON = 7f, float JADLGMEJNLI = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 APJANGIKMKO(Vector3 KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 HKJIOEPIHLG(Vector3 KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void FNLMDJNHPCO();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void ICMPLOMBNCI(GIFDOEAHBPA KMIGKJKHCFM, object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void DLHPBEJDCGD(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void PEBJHMLKJCP();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void IAFKMCKDEBI();

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void CMKDBEHLHLC();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool KKFLCFNHKBJ();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void MNDIMBHHAOD();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void AEGKLGLDCBB(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void OEOHIKGOKGN(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void DIHDMBNDKJC(object MFKHKDDANII, bool JMGOCMABGNJ);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void JBFAKNCLACI(Vector3 MJBMEPCOMAJ, Quaternion BPFKODHFGHO);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void DKBIEOOBEHA(Vector3 MLLJOKPHMGD, Quaternion JNEDEPPGFHP);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool PBGJDADAPEN(float NMALOKPPLFM);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void ILEFJILMPAC(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void JCOHEJDLFKL(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void FBKIHFOMNCB(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void BLEKJKOOFIB(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void CIFOEHKDHAD(Vector3 KEJIJALNLAM, ForceMode KJEKHPEBEEH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void ONCJODFGKOD(Vector3 KEJIJALNLAM, Vector3 KFJFDPLEJOD, ForceMode KJEKHPEBEEH);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void BMOOFAOLDJA(Vector3 BOIMOPECEPM, ForceMode KJEKHPEBEEH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void JBMHCGLJDMB(Vector3 BOIMOPECEPM, ForceMode KJEKHPEBEEH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool PPOFEJAAPPP(Vector3 HLNPPHJBENM, [Out] RaycastHit JMACOIIAFBO, float EFLCGLGNONM);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void INHIAHKPLBK();
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface CGLIKLHAHPB
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class FKLIKGLOBBE : CGLIKLHAHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FKLIKGLOBBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "0")]
	void FPLCHIAJPJI(Vector3 PJLCMLCHDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "1")]
	void IPOPJNJFBEH(Vector3 LIDKIKJAOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "2")]
	void BLPEDICGMEC(Vector3 PJLCMLCHDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "3")]
	void CBPKMMFJJDN(Vector3 LIDKIKJAOJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface DNNEGEPPCEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 KJNHGBCILCI();

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 OAACKNNBMOM();

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PCOLIIIMNJN(float IPJDJEBBIGC, float NHJDIAECBGB);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public delegate void PGINMDCPPIJ(ANNBNLPJGPM KOMPLCNKBHI);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum PIFCIBHGMGB
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
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum ILIKBONEJOO
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
[Cpp2IlInjected.Token(Token = "0x200005F")]
public delegate void JJNGNENMLJJ(ANNBNLPJGPM KOMPLCNKBHI, bool NFCKHMKCNGK = false);
[Cpp2IlInjected.Token(Token = "0x2000060")]
public enum MPBOJIIMMCC
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct BMDNLBHNEKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Rigidbody ELBJAFIJOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public object GDCMHMJHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 MFBACALNCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector3 IGMAEHILBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public ILMFIJFBGOM FFDCMGDPJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool ONLJOAKIDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool AEDNOHPNFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool AAAGPJPPLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool EINDGNBFMFJ;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct ADKOMDJMHFH : IEquatable<ADKOMDJMHFH>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly ADKOMDJMHFH LDBDNKHHGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public GameObject FNCBMCHNDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x86CB540", Offset = "0x86C9F40", VA = "0x1886CB540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public ECANCCLIJHJ ABEEHEHPPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x86CB320", Offset = "0x86C9D20", VA = "0x1886CB320")]
		get
		{
			return default(ECANCCLIJHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public MHMFEMEFKPN HACEAANBMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x86CB440", Offset = "0x86C9E40", VA = "0x1886CB440")]
		get
		{
			return default(MHMFEMEFKPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public RRObjectPrefabData LDLLHDKCOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x86CBC40", Offset = "0x86CA640", VA = "0x1886CBC40")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool DNOMDFEEJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x86CB2B0", Offset = "0x86C9CB0", VA = "0x1886CB2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool MGGAOFPBBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x86CB300", Offset = "0x86C9D00", VA = "0x1886CB300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool BHCJNFNLNME
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x86CBFB0", Offset = "0x86CA9B0", VA = "0x1886CBFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool NENCMCPJMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x86CBF90", Offset = "0x86CA990", VA = "0x1886CBF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool HEGBFLNEIIF
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x86CC020", Offset = "0x86CAA20", VA = "0x1886CC020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool JKDIGJIAONA
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x86CB2D0", Offset = "0x86C9CD0", VA = "0x1886CB2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool MGCHNFDIGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x86CC100", Offset = "0x86CAB00", VA = "0x1886CC100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool GPKJJOMOPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x86CB1F0", Offset = "0x86C9BF0", VA = "0x1886CB1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool KFONPKJIMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x86CBB60", Offset = "0x86CA560", VA = "0x1886CBB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool DFFIHPPILOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x86CBC00", Offset = "0x86CA600", VA = "0x1886CBC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool MPHBNIHGMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x86CB1B0", Offset = "0x86C9BB0", VA = "0x1886CB1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool IJKJHDLOMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x86CBB20", Offset = "0x86CA520", VA = "0x1886CBB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool JAAJJABGAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x86CBA00", Offset = "0x86CA400", VA = "0x1886CBA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool OGHHJAGJPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x86CB920", Offset = "0x86CA320", VA = "0x1886CB920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool DFPNJBLOGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x86CC260", Offset = "0x86CAC60", VA = "0x1886CC260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool FPCMAMMCHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x86CB500", Offset = "0x86C9F00", VA = "0x1886CB500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool AALAEFCFKKE
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x86CB270", Offset = "0x86C9C70", VA = "0x1886CB270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public IIACELHKAJK KHNABHEFJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IIACELHKAJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public NPHAOMGMIKC OJANCAFPFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(NPHAOMGMIKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public FMKLLFCKDEP LCGJCININOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(FMKLLFCKDEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public NKINGCICNBI NIKGKHFICOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(NKINGCICNBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public JHJIDMMLHBA LPNEMCDAOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(JHJIDMMLHBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public FFBJLJLPLED PKDFCCMOKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(FFBJLJLPLED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public NCHFNGGBDNJ FIAPGFBJFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(NCHFNGGBDNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public PHMDHCMKBAL LFJCLOMANDK
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(PHMDHCMKBAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public KDEJGMNAJNH FOAJDJJAEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(KDEJGMNAJNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public ALCMNFJJIFA OIIPIHLPJHB
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ALCMNFJJIFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public JLJMANMEMEE GMIFCMBMIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(JLJMANMEMEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public CLMEIFBPEMH HDHCDMFMPED
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(CLMEIFBPEMH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public GLCFABKOION COBAGNGAIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(GLCFABKOION);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public DPHADBCKGEK KNHOJANCNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(DPHADBCKGEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public OHMIMMOKILD HMLODAPGJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(OHMIMMOKILD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public bool FNKPBCPCDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x86CB830", Offset = "0x86CA230", VA = "0x1886CB830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool EECENEENKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x86CB230", Offset = "0x86C9C30", VA = "0x1886CB230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool IGDOOIKPCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x86CC180", Offset = "0x86CAB80", VA = "0x1886CC180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool JBKJHIIAKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x86CBBD0", Offset = "0x86CA5D0", VA = "0x1886CBBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool HIMLIMBNKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x86CC140", Offset = "0x86CAB40", VA = "0x1886CC140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public bool KEBJABIEECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x86CB750", Offset = "0x86CA150", VA = "0x1886CB750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public bool HMGLAGFNEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x86CBA90", Offset = "0x86CA490", VA = "0x1886CBA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public NGMKDFFKHEA AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(NGMKDFFKHEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public FJNCNOIEEPE KNPLINAIFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(FJNCNOIEEPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private LHOENBPGPCA DIBEEIFKJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x86CC0A0", Offset = "0x86CAAA0", VA = "0x1886CC0A0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static ADKOMDJMHFH HDPJNBPLGPE(IJNJMBEMEOM KKGNPJDBLLP)
	{
		return default(ADKOMDJMHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x86CB6D0", Offset = "0x86CA0D0", VA = "0x1886CB6D0")]
	public HGIKBGJJICF DJDNAAFFGCE()
	{
		return default(HGIKBGJJICF);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x86CBE10", Offset = "0x86CA810", VA = "0x1886CBE10")]
	public JAJEEHGAAOE JLIJOIPCPLF()
	{
		return default(JAJEEHGAAOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x86CBF40", Offset = "0x86CA940", VA = "0x1886CBF40")]
	public LLHKKEBFIAA JMNCHEOPHEN()
	{
		return default(LLHKKEBFIAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x86CB3C0", Offset = "0x86C9DC0", VA = "0x1886CB3C0")]
	public LLBBPMHIHOE CHGGIJLANDO()
	{
		return default(LLBBPMHIHOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x86CB3F0", Offset = "0x86C9DF0", VA = "0x1886CB3F0")]
	public ANDFPHJBFND CMHGNNOLLEL()
	{
		return default(ANDFPHJBFND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x86CBAD0", Offset = "0x86CA4D0", VA = "0x1886CBAD0")]
	public MGLLAPHMPPC GGKPMHIBDKG()
	{
		return default(MGLLAPHMPPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x86CBFD0", Offset = "0x86CA9D0", VA = "0x1886CBFD0")]
	public CBGFMPABMGM MHONGLDHOBG()
	{
		return default(CBGFMPABMGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x86CC040", Offset = "0x86CAA40", VA = "0x1886CC040")]
	public FBIDKFOIMGN MMDDDPLPLCE()
	{
		return default(FBIDKFOIMGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x86CBA40", Offset = "0x86CA440", VA = "0x1886CBA40")]
	public DMCEAMEJLAK FPEKILCKHCP()
	{
		return default(DMCEAMEJLAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x86CBE40", Offset = "0x86CA840", VA = "0x1886CBE40")]
	public void JLOFHMIMDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x86CC1C0", Offset = "0x86CABC0", VA = "0x1886CC1C0")]
	public void PIIFCIMJIKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x86CB790", Offset = "0x86CA190", VA = "0x1886CB790")]
	public void ECCEFGLKACH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x86CBD70", Offset = "0x86CA770", VA = "0x1886CBD70")]
	public bool JGMDNFIGLKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x86CC2A0", Offset = "0x86CACA0", VA = "0x1886CC2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public ADKOMDJMHFH(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBE0", Offset = "0x86CA5E0", VA = "0x1886CBBE0")]
	public static bool HDPJNBPLGPE(ADKOMDJMHFH KMAFNKGMDCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static IJNJMBEMEOM HDPJNBPLGPE(ADKOMDJMHFH KMAFNKGMDCF)
	{
		return default(IJNJMBEMEOM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x86CC090", Offset = "0x86CAA90", VA = "0x1886CC090")]
	public static bool NOPNAEDOCOI(ADKOMDJMHFH EICJFDNFOCB, ADKOMDJMHFH MIBIEOGGIAP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x86CB4E0", Offset = "0x86C9EE0", VA = "0x1886CB4E0")]
	public static bool DFNINOIAFHB(ADKOMDJMHFH EICJFDNFOCB, ADKOMDJMHFH MIBIEOGGIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x86CB970", Offset = "0x86CA370", VA = "0x1886CB970", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(ADKOMDJMHFH GOCNHGEHNFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct GLCFABKOION : IEquatable<GLCFABKOION>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private DLINNPGLBOH CDPJBDPJGBI
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x86D6200", Offset = "0x86D4C00", VA = "0x1886D6200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x86D63E0", Offset = "0x86D4DE0", VA = "0x1886D63E0")]
	public void IEHKKOAOGIM(uint NMAIBBDGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x86D64F0", Offset = "0x86D4EF0", VA = "0x1886D64F0")]
	public bool JNMKCAEAPJL([Out] uint NMAIBBDGPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x86D6100", Offset = "0x86D4B00", VA = "0x1886D6100")]
	public bool BNIAEIPCIPK([Out] uint NMAIBBDGPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x86D62F0", Offset = "0x86D4CF0", VA = "0x1886D62F0")]
	public void IBKIDMINGEB(string NMAIBBDGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x86D5FF0", Offset = "0x86D49F0", VA = "0x1886D5FF0")]
	[CanBeNull]
	public string BMAMPEPEEGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x86D65F0", Offset = "0x86D4FF0", VA = "0x1886D65F0")]
	public bool KBBEOMMNNAO([Out] string ADDKCMBENIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x86D6770", Offset = "0x86D5170", VA = "0x1886D6770")]
	public void MMHFLJDOEPC(string ADDKCMBENIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public GLCFABKOION(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x86D6260", Offset = "0x86D4C60", VA = "0x1886D6260", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(GLCFABKOION GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct IIACELHKAJK : IEquatable<IIACELHKAJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private LLFKLOBKKPA FHNHHICCFDL
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x86D8D70", Offset = "0x86D7770", VA = "0x1886D8D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private DLINNPGLBOH AEIGEMPANEA
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x86D8AF0", Offset = "0x86D74F0", VA = "0x1886D8AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool EJGIMGAMCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x86D8750", Offset = "0x86D7150", VA = "0x1886D8750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool CONIJNDMGGO
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x86D8A10", Offset = "0x86D7410", VA = "0x1886D8A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool DHFNEJKNBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x86D8360", Offset = "0x86D6D60", VA = "0x1886D8360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Guid HJPLOIBNLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x86D8870", Offset = "0x86D7270", VA = "0x1886D8870")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Guid KONLFFEGBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x86D8CF0", Offset = "0x86D76F0", VA = "0x1886D8CF0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public Guid MCMGPEJBPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x86D8540", Offset = "0x86D6F40", VA = "0x1886D8540")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public FJNCNOIEEPE KNPLINAIFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(FJNCNOIEEPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x86D8A50", Offset = "0x86D7450", VA = "0x1886D8A50")]
	public bool KBHDMADFANM([Out] Guid ABIELIKPOOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x86D8B50", Offset = "0x86D7550", VA = "0x1886D8B50")]
	public bool KHHNBHNPDKI([Out] Guid DKOKOBIEBLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x86D8420", Offset = "0x86D6E20", VA = "0x1886D8420")]
	public void BNEEHBLCBAI(Guid MKDEBCJNKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x86D8BF0", Offset = "0x86D75F0", VA = "0x1886D8BF0")]
	public void LEOCCDODGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x86D88F0", Offset = "0x86D72F0", VA = "0x1886D88F0")]
	public Guid ICOEOIOPENH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public IIACELHKAJK(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x86D87E0", Offset = "0x86D71E0", VA = "0x1886D87E0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(IIACELHKAJK GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct LLHKKEBFIAA : IEquatable<LLHKKEBFIAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	private LGMIKJJLGHL BFBKCKNDAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x86DEB30", Offset = "0x86DD530", VA = "0x1886DEB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 KBKAIOAEDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x86DEB90", Offset = "0x86DD590", VA = "0x1886DEB90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public Quaternion FCIKGEGHBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x86DECE0", Offset = "0x86DD6E0", VA = "0x1886DECE0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public ADKOMDJMHFH EAOOFMFDCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x86DEE20", Offset = "0x86DD820", VA = "0x1886DEE20")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x86DE770", Offset = "0x86DD170", VA = "0x1886DE770")]
	public BKGDNKOLHBO AEADAMLPCBD(Allocator EIOOMONCLID)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x86DEA90", Offset = "0x86DD490", VA = "0x1886DEA90")]
	public bool FDKCDFKFOIL(ADKOMDJMHFH AEMEEJKFKNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x86DEEB0", Offset = "0x86DD8B0", VA = "0x1886DEEB0")]
	public void NLAAIHDOEOJ(Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x86DF000", Offset = "0x86DDA00", VA = "0x1886DF000")]
	public void OADINBALMAG(float NIAMAMNMMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x86DE840", Offset = "0x86DD240", VA = "0x1886DE840")]
	public void COHKBJBJEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public LLHKKEBFIAA(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBE0", Offset = "0x86CA5E0", VA = "0x1886CBBE0")]
	public static bool HDPJNBPLGPE(LLHKKEBFIAA KMAFNKGMDCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static IJNJMBEMEOM HDPJNBPLGPE(LLHKKEBFIAA KMAFNKGMDCF)
	{
		return default(IJNJMBEMEOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x86DEA00", Offset = "0x86DD400", VA = "0x1886DEA00", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(LLHKKEBFIAA GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct HGIKBGJJICF : IEquatable<HGIKBGJJICF>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly HGIKBGJJICF LDBDNKHHGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private BBKILMFCMED PDCPJAJPJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x86D6BD0", Offset = "0x86D55D0", VA = "0x1886D6BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<ADKOMDJMHFH> CFJCMLOIJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A40", Offset = "0x86D5440", VA = "0x1886D6A40")]
		get
		{
			return default(Span<ADKOMDJMHFH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x86D70D0", Offset = "0x86D5AD0", VA = "0x1886D70D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x86D7150", Offset = "0x86D5B50", VA = "0x1886D7150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public NGMKDFFKHEA AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(NGMKDFFKHEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public FJNCNOIEEPE KNPLINAIFGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(FJNCNOIEEPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x86D6C30", Offset = "0x86D5630", VA = "0x1886D6C30")]
	public void HDIMBBJCCOH(HGIKBGJJICF GOCNHGEHNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public HGIKBGJJICF(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBE0", Offset = "0x86CA5E0", VA = "0x1886CBBE0")]
	public static bool HDPJNBPLGPE(HGIKBGJJICF KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x86D6B40", Offset = "0x86D5540", VA = "0x1886D6B40", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(HGIKBGJJICF GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static ADKOMDJMHFH HDPJNBPLGPE(HGIKBGJJICF DKGBCFDLMOI)
	{
		return default(ADKOMDJMHFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public struct IGHNJFNIPEM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> HJAOHCJPEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private BACKIKPNMDF NENFFHKENFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool KPANGEBBCJL;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		[CompilerGenerated]
		readonly get
		{
			return default(ADKOMDJMHFH);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public IHDFIEJABNE PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x86D7C50", Offset = "0x86D6650", VA = "0x1886D7C50")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x86D7D10", Offset = "0x86D6710", VA = "0x1886D7D10")]
	internal IGHNJFNIPEM(ADKOMDJMHFH PMNHIPACJLN, bool KPANGEBBCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x86D7A70", Offset = "0x86D6470", VA = "0x1886D7A70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x3DEE560", Offset = "0x3DECF60", VA = "0x183DEE560")]
	public void ONMEPOBLMMH<T>(IHDFIEJABNE HPFHOBCPNEF, T KMAFNKGMDCF, [Optional] T KJMOBDOKFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x86D7BA0", Offset = "0x86D65A0", VA = "0x1886D7BA0")]
	public void MCKODPOBNPM(IHDFIEJABNE HPFHOBCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xB51470", Offset = "0xB4FE70", VA = "0x180B51470")]
	public Dictionary<int, object> DFIOIIPKIBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x86D7A00", Offset = "0x86D6400", VA = "0x1886D7A00")]
	private readonly void DFBINMALFPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class NAHLNMKBMGH
{
	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x86DFA50", Offset = "0x86DE450", VA = "0x1886DFA50")]
	public static IGHNJFNIPEM OMIOGLIBLAF(this ADKOMDJMHFH PMNHIPACJLN)
	{
		return default(IGHNJFNIPEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct DPHADBCKGEK : IEquatable<DPHADBCKGEK>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly DPHADBCKGEK LDBDNKHHGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private bool MPHBNIHGMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x86D15A0", Offset = "0x86CFFA0", VA = "0x1886D15A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 EOCMOGONICA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x86D1900", Offset = "0x86D0300", VA = "0x1886D1900")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x86D17A0", Offset = "0x86D01A0", VA = "0x1886D17A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x86D15E0", Offset = "0x86CFFE0", VA = "0x1886D15E0")]
	public Vector3 BHOGACLOHFL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x86D1800", Offset = "0x86D0200", VA = "0x1886D1800")]
	public void JBJIMJAAJJH([In] Vector3 KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x86D1880", Offset = "0x86D0280", VA = "0x1886D1880")]
	public void NHAALBMIJGG([In] Vector3 KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x86D1660", Offset = "0x86D0060", VA = "0x1886D1660")]
	public bool ENGLDCCEEAC([In] Vector3 KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public DPHADBCKGEK(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x86D1710", Offset = "0x86D0110", VA = "0x1886D1710", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(DPHADBCKGEK GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x86D19B0", Offset = "0x86D03B0", VA = "0x1886D19B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct CGAJGJBGMJD : IEquatable<CGAJGJBGMJD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x86CFD60", Offset = "0x86CE760", VA = "0x1886CFD60", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(CGAJGJBGMJD GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct FBIDKFOIMGN : IEquatable<FBIDKFOIMGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private OPILNFDNHMH OFKONPCGJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x86D20A0", Offset = "0x86D0AA0", VA = "0x1886D20A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool IFBPLDKKHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x86D1DC0", Offset = "0x86D07C0", VA = "0x1886D1DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool LCAGBABKMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x86D2100", Offset = "0x86D0B00", VA = "0x1886D2100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public IAKBGJEAJCI MAFMLIBFONI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x86D1C90", Offset = "0x86D0690", VA = "0x1886D1C90")]
		get
		{
			return default(IAKBGJEAJCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool EKFLHABGLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x86D2230", Offset = "0x86D0C30", VA = "0x1886D2230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool CJMBAHCGOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x86D24E0", Offset = "0x86D0EE0", VA = "0x1886D24E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool GCLNJILEPJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x86D2310", Offset = "0x86D0D10", VA = "0x1886D2310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x86D23A0", Offset = "0x86D0DA0", VA = "0x1886D23A0")]
	public bool NJAJLJDLEHK(FBIDKFOIMGN DHDOFGGJDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x86D2270", Offset = "0x86D0C70", VA = "0x1886D2270")]
	public bool KKNADLBJDJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x86D2440", Offset = "0x86D0E40", VA = "0x1886D2440")]
	public bool ODENDGLDFPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x86D1F80", Offset = "0x86D0980", VA = "0x1886D1F80")]
	public ReadOnlySpan<IJNJMBEMEOM> FMIKEBKKIIJ()
	{
		return default(ReadOnlySpan<IJNJMBEMEOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public FBIDKFOIMGN(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x86CC090", Offset = "0x86CAA90", VA = "0x1886CC090")]
	public static bool NOPNAEDOCOI(FBIDKFOIMGN EICJFDNFOCB, FBIDKFOIMGN MIBIEOGGIAP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x86CB4E0", Offset = "0x86C9EE0", VA = "0x1886CB4E0")]
	public static bool DFNINOIAFHB(FBIDKFOIMGN EICJFDNFOCB, FBIDKFOIMGN MIBIEOGGIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x86D1EF0", Offset = "0x86D08F0", VA = "0x1886D1EF0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(FBIDKFOIMGN GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct CBGFMPABMGM : IEquatable<CBGFMPABMGM>
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly CBGFMPABMGM LDBDNKHHGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private OPILNFDNHMH BDBHKDAOGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x86CF780", Offset = "0x86CE180", VA = "0x1886CF780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool GCINBLJNLHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x86CF9C0", Offset = "0x86CE3C0", VA = "0x1886CF9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public NGMKDFFKHEA AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(NGMKDFFKHEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x86CFAC0", Offset = "0x86CE4C0", VA = "0x1886CFAC0")]
	public bool NJAJLJDLEHK(CBGFMPABMGM GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x86CFA20", Offset = "0x86CE420", VA = "0x1886CFA20")]
	public bool MPGHOONMPGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x86CF7E0", Offset = "0x86CE1E0", VA = "0x1886CF7E0")]
	public bool ENJCIJKELCO([Out] CBGFMPABMGM MJFECJFNLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x86CF950", Offset = "0x86CE350", VA = "0x1886CF950")]
	public void HIBJOCCMPMH(POCJFLPCOMA MAFBHNHEGDO, bool FIIODMNDIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public CBGFMPABMGM(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x86CC090", Offset = "0x86CAA90", VA = "0x1886CC090")]
	public static bool NOPNAEDOCOI(CBGFMPABMGM EICJFDNFOCB, CBGFMPABMGM MIBIEOGGIAP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x86CB4E0", Offset = "0x86C9EE0", VA = "0x1886CB4E0")]
	public static bool DFNINOIAFHB(CBGFMPABMGM EICJFDNFOCB, CBGFMPABMGM MIBIEOGGIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x86CF8C0", Offset = "0x86CE2C0", VA = "0x1886CF8C0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(CBGFMPABMGM GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct FJNCNOIEEPE : IEquatable<FJNCNOIEEPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private BBKILMFCMED PDCPJAJPJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x86D3830", Offset = "0x86D2230", VA = "0x1886D3830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public IJNJMBEMEOM APNMMIBGNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x86D3300", Offset = "0x86D1D00", VA = "0x1886D3300")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public ADKOMDJMHFH AJFLBGMINPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x86D3890", Offset = "0x86D2290", VA = "0x1886D3890")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public ADKOMDJMHFH GLKLCNOCKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x86D3AE0", Offset = "0x86D24E0", VA = "0x1886D3AE0")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x86D3730", Offset = "0x86D2130", VA = "0x1886D3730")]
	public Span<ADKOMDJMHFH> FGIGKMMIMKN()
	{
		return default(Span<ADKOMDJMHFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x86D3200", Offset = "0x86D1C00", VA = "0x1886D3200")]
	public Span<ADKOMDJMHFH> AGHKCAFAMPF()
	{
		return default(Span<ADKOMDJMHFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x86D3630", Offset = "0x86D2030", VA = "0x1886D3630")]
	public Span<ADKOMDJMHFH> FGBBJHJKAAP()
	{
		return default(Span<ADKOMDJMHFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x86D3390", Offset = "0x86D1D90", VA = "0x1886D3390")]
	public Span<ADKOMDJMHFH> BGLGFAGFNAO()
	{
		return default(Span<ADKOMDJMHFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x86D39B0", Offset = "0x86D23B0", VA = "0x1886D39B0")]
	public bool IEBALGDGBAK(ADKOMDJMHFH AEMEEJKFKNN, bool BNAMKHAIFEN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x86D3B70", Offset = "0x86D2570", VA = "0x1886D3B70")]
	public bool PBKAKKACIHE(ADKOMDJMHFH DEEBILEDKDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x86D3490", Offset = "0x86D1E90", VA = "0x1886D3490")]
	public ADKOMDJMHFH EMFOCJBBEKO(uint FHAGACEPDLI)
	{
		return default(ADKOMDJMHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x86D3920", Offset = "0x86D2320", VA = "0x1886D3920")]
	public HGIKBGJJICF HAMKBNHEEJF()
	{
		return default(HGIKBGJJICF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public FJNCNOIEEPE(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBE0", Offset = "0x86CA5E0", VA = "0x1886CBBE0")]
	public static bool HDPJNBPLGPE(FJNCNOIEEPE KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x86D35A0", Offset = "0x86D1FA0", VA = "0x1886D35A0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(FJNCNOIEEPE GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct NPHAOMGMIKC : IEquatable<NPHAOMGMIKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string KMGIKAEEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x86E2E90", Offset = "0x86E1890", VA = "0x1886E2E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public string BJKECIJIJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x86E2D60", Offset = "0x86E1760", VA = "0x1886E2D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public string JFEOPFEAEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x86E2F20", Offset = "0x86E1920", VA = "0x1886E2F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public string HEOFDILPAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x86E2A30", Offset = "0x86E1430", VA = "0x1886E2A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x86E2DD0", Offset = "0x86E17D0", VA = "0x1886E2DD0")]
	public bool KBBEOMMNNAO([Out] string ADDKCMBENIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public NPHAOMGMIKC(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x86E2CD0", Offset = "0x86E16D0", VA = "0x1886E2CD0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(NPHAOMGMIKC GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct LBEHMMBIKCO : IEquatable<LBEHMMBIKCO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x86DE2C0", Offset = "0x86DCCC0", VA = "0x1886DE2C0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(LBEHMMBIKCO GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct JJABBLLIJDB : IEquatable<JJABBLLIJDB>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[Flags]
	public enum GBKPLGEMBLO
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
	private static OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly JJABBLLIJDB LDBDNKHHGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private LHOENBPGPCA DIBEEIFKJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x86CC0A0", Offset = "0x86CAAA0", VA = "0x1886CC0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	private EntityManager IKJPKHBBPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x86DB490", Offset = "0x86D9E90", VA = "0x1886DB490")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x86DC880", Offset = "0x86DB280", VA = "0x1886DC880")]
	public float HAOCBOIGPMC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x86DC8D0", Offset = "0x86DB2D0", VA = "0x1886DC8D0")]
	public void JLKNPPCBDPK(float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x86DC000", Offset = "0x86DAA00", VA = "0x1886DC000")]
	public static GBKPLGEMBLO BNMNCFDLGAF(JJABBLLIJDB EICJFDNFOCB, JJABBLLIJDB MIBIEOGGIAP)
	{
		return default(GBKPLGEMBLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x86DC260", Offset = "0x86DAC60", VA = "0x1886DC260")]
	public bool DMBCKLCJANJ([Out] GameObject AEMEEJKFKNN, [Out] GameObject FNCBMCHNDJI, [Out] ADKOMDJMHFH FJJGKEBHEJK, [Out] ADKOMDJMHFH HDMJGGJNPEO, [Out] Vector3 KFJFDPLEJOD, [Out] Vector3 ICDAFAOBABD, [Out] Vector3 GHCCEJLCGIP, [Out] ADKOMDJMHFH MMBHLEKCNGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x86DCA60", Offset = "0x86DB460", VA = "0x1886DCA60")]
	public bool LEKDPLGNLLK([Out] GameObject AEMEEJKFKNN, [Out] GameObject FNCBMCHNDJI, [Out] ADKOMDJMHFH FJJGKEBHEJK, [Out] ADKOMDJMHFH HDMJGGJNPEO, [Out] Vector3 KFJFDPLEJOD, [Out] Vector3 ICDAFAOBABD, [Out] Vector3 GHCCEJLCGIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x86DCC90", Offset = "0x86DB690", VA = "0x1886DCC90")]
	private void MPGAKGHBCDM(Entity BDOCGCBPBOC, EntityManager ABIJIHBALBH, MagneticAnchorData JEGGAABBBID, [Out] GameObject AEMEEJKFKNN, [Out] GameObject FNCBMCHNDJI, [Out] ADKOMDJMHFH FJJGKEBHEJK, [Out] ADKOMDJMHFH HDMJGGJNPEO, [Out] Vector3 KFJFDPLEJOD, [Out] Vector3 ICDAFAOBABD, [Out] Vector3 GHCCEJLCGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public JJABBLLIJDB(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x86DC7F0", Offset = "0x86DB1F0", VA = "0x1886DC7F0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(JJABBLLIJDB GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x86DD050", Offset = "0x86DBA50", VA = "0x1886DD050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct JHNBPAOGDGH : IEquatable<JHNBPAOGDGH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x86DBDC0", Offset = "0x86DA7C0", VA = "0x1886DBDC0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(JHNBPAOGDGH GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct OHMIMMOKILD : IEquatable<OHMIMMOKILD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private LFJPGHPMJEE BDBHKDAOGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x86E33F0", Offset = "0x86E1DF0", VA = "0x1886E33F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public CFDHLOOAFMC ALNCFHODKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x86E3450", Offset = "0x86E1E50", VA = "0x1886E3450")]
		get
		{
			return default(CFDHLOOAFMC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x86E3990", Offset = "0x86E2390", VA = "0x1886E3990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public OCCFPJFFJEE<string> AFFFMBLPFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x86E3640", Offset = "0x86E2040", VA = "0x1886E3640")]
		get
		{
			return default(OCCFPJFFJEE<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x86E3870", Offset = "0x86E2270", VA = "0x1886E3870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public OCCFPJFFJEE<string> GDJHNFPOBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x86E3490", Offset = "0x86E1E90", VA = "0x1886E3490")]
		get
		{
			return default(OCCFPJFFJEE<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x86E3750", Offset = "0x86E2150", VA = "0x1886E3750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public OHMIMMOKILD(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x86E35B0", Offset = "0x86E1FB0", VA = "0x1886E35B0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(OHMIMMOKILD GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct FMKLLFCKDEP : IEquatable<FMKLLFCKDEP>
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly ComponentTypes BHBEPGIMCGG;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly FMKLLFCKDEP LDBDNKHHGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Collider BMFIPOILJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x86D4040", Offset = "0x86D2A40", VA = "0x1886D4040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public IGEICALDFNG AHAMDOGLMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x86D4340", Offset = "0x86D2D40", VA = "0x1886D4340")]
		get
		{
			return default(IGEICALDFNG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x86D46A0", Offset = "0x86D30A0", VA = "0x1886D46A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public AKEEGCAKFGA NFHFIOJFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x86D4300", Offset = "0x86D2D00", VA = "0x1886D4300")]
		get
		{
			return default(AKEEGCAKFGA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x86D47E0", Offset = "0x86D31E0", VA = "0x1886D47E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public AFEOBCPOCDD MOMAGKAMLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x86D4990", Offset = "0x86D3390", VA = "0x1886D4990")]
		get
		{
			return default(AFEOBCPOCDD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x86D4790", Offset = "0x86D3190", VA = "0x1886D4790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public float LACOFBEEHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x86D4380", Offset = "0x86D2D80", VA = "0x1886D4380")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x86D43C0", Offset = "0x86D2DC0", VA = "0x1886D43C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool FIKAKPJEIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x86D4D80", Offset = "0x86D3780", VA = "0x1886D4D80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x86D4DF0", Offset = "0x86D37F0", VA = "0x1886D4DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool BJJFLPACLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x86D4890", Offset = "0x86D3290", VA = "0x1886D4890")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x86D3FA0", Offset = "0x86D29A0", VA = "0x1886D3FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool DFALMFBJGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x86D4910", Offset = "0x86D3310", VA = "0x1886D4910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x86D44A0", Offset = "0x86D2EA0", VA = "0x1886D44A0")]
	public static bool HBNEIDMCMCJ(ADKOMDJMHFH AEADIAMFFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x86D4B30", Offset = "0x86D3530", VA = "0x1886D4B30")]
	public static bool NLKHMGDKJML(ADKOMDJMHFH AEADIAMFFOA, [Out] FMKLLFCKDEP AEGAIAENJDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x86D49D0", Offset = "0x86D33D0", VA = "0x1886D49D0")]
	public bool MOFNPHCNJIF([Out] HOJGIOMMAHM MFGADJMKIKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x86D4210", Offset = "0x86D2C10", VA = "0x1886D4210")]
	public bool CBNAPNLEOPC([Out] IJNJMBEMEOM FAIGKPPBFHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x86D4830", Offset = "0x86D3230", VA = "0x1886D4830")]
	public bool KOHMGABKKEP(FFAGMAGLFPM MAFBHNHEGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x86D4190", Offset = "0x86D2B90", VA = "0x1886D4190")]
	public void BCNAHCADPMP(FFAGMAGLFPM MAFBHNHEGDO, bool FCCCGLOCDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x86D46F0", Offset = "0x86D30F0", VA = "0x1886D46F0")]
	public void KCJDHCFMAOP(FFAGMAGLFPM MAFBHNHEGDO, bool FCCCGLOCDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public FMKLLFCKDEP(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x86D4410", Offset = "0x86D2E10", VA = "0x1886D4410", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(FMKLLFCKDEP GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x86D4E90", Offset = "0x86D3890", VA = "0x1886D4E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct LLBBPMHIHOE : IEquatable<LLBBPMHIHOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool FNELEANOJLH
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x86DE720", Offset = "0x86DD120", VA = "0x1886DE720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public LLBBPMHIHOE(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x86DE690", Offset = "0x86DD090", VA = "0x1886DE690", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(LLBBPMHIHOE GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct NKINGCICNBI : IEquatable<NKINGCICNBI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private KKKDMENDHIF JBJIFJIOEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x86E2270", Offset = "0x86E0C70", VA = "0x1886E2270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x86E2360", Offset = "0x86E0D60", VA = "0x1886E2360")]
	public void KDCDLIHKEHE(bool GKCMMGEKMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public NKINGCICNBI(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x86E22D0", Offset = "0x86E0CD0", VA = "0x1886E22D0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(NKINGCICNBI GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct ANDFPHJBFND : IEquatable<ANDFPHJBFND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private ECNBPBALKNJ BALEPAFMDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x86CDE80", Offset = "0x86CC880", VA = "0x1886CDE80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public CFDHLOOAFMC ADNOBEBBPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x86CD3E0", Offset = "0x86CBDE0", VA = "0x1886CD3E0")]
		get
		{
			return default(CFDHLOOAFMC);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x86CDC50", Offset = "0x86CC650", VA = "0x1886CDC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool DFKHPNOCGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x86CD350", Offset = "0x86CBD50", VA = "0x1886CD350")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x86CD7B0", Offset = "0x86CC1B0", VA = "0x1886CD7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public OCCFPJFFJEE<string> BIOIGJEDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x86CDA10", Offset = "0x86CC410", VA = "0x1886CDA10")]
		get
		{
			return default(OCCFPJFFJEE<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x86CD600", Offset = "0x86CC000", VA = "0x1886CD600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public OCCFPJFFJEE<string> KDKONGIBEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x86CD230", Offset = "0x86CBC30", VA = "0x1886CD230")]
		get
		{
			return default(OCCFPJFFJEE<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x86CD850", Offset = "0x86CC250", VA = "0x1886CD850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public OCCFPJFFJEE<string> AHDPBNCKIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x86CDB30", Offset = "0x86CC530", VA = "0x1886CDB30")]
		get
		{
			return default(OCCFPJFFJEE<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x86CDEE0", Offset = "0x86CC8E0", VA = "0x1886CDEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public OCCFPJFFJEE<string> AFHKALGMLPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x86CDD60", Offset = "0x86CC760", VA = "0x1886CDD60")]
		get
		{
			return default(OCCFPJFFJEE<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x86CD4E0", Offset = "0x86CBEE0", VA = "0x1886CD4E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x86CD970", Offset = "0x86CC370", VA = "0x1886CD970")]
	public bool HJNMJICKLHN(IJNJMBEMEOM BLHNDOLLIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public ANDFPHJBFND(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static IJNJMBEMEOM HDPJNBPLGPE(ANDFPHJBFND KMAFNKGMDCF)
	{
		return default(IJNJMBEMEOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x86CD720", Offset = "0x86CC120", VA = "0x1886CD720", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(ANDFPHJBFND GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct JHJIDMMLHBA : IEquatable<JHJIDMMLHBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool BALGGIFKEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x86DB010", Offset = "0x86D9A10", VA = "0x1886DB010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool MMLINBLJMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x86DB440", Offset = "0x86D9E40", VA = "0x1886DB440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool FOADJMANHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x86DB050", Offset = "0x86D9A50", VA = "0x1886DB050")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x86DBC60", Offset = "0x86DA660", VA = "0x1886DBC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool MIAIGOOJMKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x86DB9C0", Offset = "0x86DA3C0", VA = "0x1886DB9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool POHPDAFFIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x86DBD70", Offset = "0x86DA770", VA = "0x1886DBD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool NDOFFNDNGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x86DB6F0", Offset = "0x86DA0F0", VA = "0x1886DB6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool MBJLLELEDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x86DB8D0", Offset = "0x86DA2D0", VA = "0x1886DB8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool DJCAKKIMPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x86DB740", Offset = "0x86DA140", VA = "0x1886DB740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool FAKHEGMPLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x86DB2E0", Offset = "0x86D9CE0", VA = "0x1886DB2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool GOGFCOKNMII
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x86DBC80", Offset = "0x86DA680", VA = "0x1886DBC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool BIHLEJNEHFP
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x86DBB30", Offset = "0x86DA530", VA = "0x1886DBB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool CJBNPPDAEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x86DBC10", Offset = "0x86DA610", VA = "0x1886DBC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public bool NFEPKFJOGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x86DBD20", Offset = "0x86DA720", VA = "0x1886DBD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public bool PJLAMMPOBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x86DB2A0", Offset = "0x86D9CA0", VA = "0x1886DB2A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x86DB920", Offset = "0x86DA320", VA = "0x1886DB920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool KDILGFCJMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x86DBAE0", Offset = "0x86DA4E0", VA = "0x1886DBAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public FBBDDCEJJGE FODJEDBJMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x86DB140", Offset = "0x86D9B40", VA = "0x1886DB140")]
		get
		{
			return default(FBBDDCEJJGE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x86DBCD0", Offset = "0x86DA6D0", VA = "0x1886DBCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public bool DBGEMJHGEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x86DB180", Offset = "0x86D9B80", VA = "0x1886DB180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public HNJIPPJLGGJ IEHFLEHKMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x86DAF80", Offset = "0x86D9980", VA = "0x1886DAF80")]
		get
		{
			return default(HNJIPPJLGGJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x86DAFC0", Offset = "0x86D99C0", VA = "0x1886DAFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public bool KNGGNHGBPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x86DB100", Offset = "0x86D9B00", VA = "0x1886DB100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public Vector3 FILGCNCHLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x86DB4A0", Offset = "0x86D9EA0", VA = "0x1886DB4A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public Vector3 MELIKJAIOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x86DB3C0", Offset = "0x86D9DC0", VA = "0x1886DB3C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public bool JNDGLOCDCFF
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x86DB520", Offset = "0x86D9F20", VA = "0x1886DB520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool EKCDHOFCAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x86DB790", Offset = "0x86DA190", VA = "0x1886DB790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private EntityManager IKJPKHBBPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x86DB490", Offset = "0x86D9E90", VA = "0x1886DB490")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x86DB0A0", Offset = "0x86D9AA0", VA = "0x1886DB0A0")]
	public bool BIOMJKABOLE(NILGIHDNBLD MAFBHNHEGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x86DBB80", Offset = "0x86DA580", VA = "0x1886DBB80")]
	public void NALFKPNMCFC(NILGIHDNBLD MAFBHNHEGDO, bool FCCCGLOCDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x86DB880", Offset = "0x86DA280", VA = "0x1886DB880")]
	public bool JBMFDEPOCJE(BMPIDNBPFBI MAFBHNHEGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x86DBA10", Offset = "0x86DA410", VA = "0x1886DBA10")]
	public void LNANIOMHNJM(BMPIDNBPFBI MAFBHNHEGDO, bool FCCCGLOCDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x86DB980", Offset = "0x86DA380", VA = "0x1886DB980")]
	public BMPIDNBPFBI LJJGJPMHBCK()
	{
		return default(BMPIDNBPFBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x86DBA90", Offset = "0x86DA490", VA = "0x1886DBA90")]
	public bool MDEDFPFAGMN(BMPIDNBPFBI KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public JHJIDMMLHBA(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x86DB330", Offset = "0x86D9D30", VA = "0x1886DB330", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(JHJIDMMLHBA GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct FFBJLJLPLED : IEquatable<FFBJLJLPLED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private GLFJLMFDIJE HNBBMMLIJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x86D2AB0", Offset = "0x86D14B0", VA = "0x1886D2AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x86D2C40", Offset = "0x86D1640", VA = "0x1886D2C40")]
	public bool GFJCNMLFAOA(OCLGKNFAEHE EDFBAIGMJKK, List<ADKOMDJMHFH> DOFMOFNBENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x86D2D70", Offset = "0x86D1770", VA = "0x1886D2D70")]
	public int KBJCKKAEHCI(OCLGKNFAEHE EDFBAIGMJKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x86D2F30", Offset = "0x86D1930", VA = "0x1886D2F30")]
	public void NCMMLIBLFCO(List<ADKOMDJMHFH> DOFMOFNBENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x86D28F0", Offset = "0x86D12F0", VA = "0x1886D28F0")]
	public int DBABOODDEOL(ADKOMDJMHFH JFBLIPHGGPK, OCLGKNFAEHE EDFBAIGMJKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x86D26B0", Offset = "0x86D10B0", VA = "0x1886D26B0")]
	public ADKOMDJMHFH BGNNMFGCHCD(int KABGMIEBEFC, OCLGKNFAEHE EDFBAIGMJKK)
	{
		return default(ADKOMDJMHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x86D2B10", Offset = "0x86D1510", VA = "0x1886D2B10")]
	public void GEGCBJAGHOO(ADKOMDJMHFH JFBLIPHGGPK, OCLGKNFAEHE EDFBAIGMJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x86D3040", Offset = "0x86D1A40", VA = "0x1886D3040")]
	public bool OAEDJAPKFKC(ADKOMDJMHFH JFBLIPHGGPK, OCLGKNFAEHE EDFBAIGMJKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x86D27E0", Offset = "0x86D11E0", VA = "0x1886D27E0")]
	public void CDBCKJHJFEO(OCLGKNFAEHE EDFBAIGMJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x86D2E80", Offset = "0x86D1880", VA = "0x1886D2E80")]
	public bool MFNHEPEPFAM(ADKOMDJMHFH JFBLIPHGGPK, OCLGKNFAEHE EDFBAIGMJKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x86D30F0", Offset = "0x86D1AF0", VA = "0x1886D30F0")]
	public bool OPCOCODNMGC(OCLGKNFAEHE EDFBAIGMJKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public FFBJLJLPLED(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x86D2A20", Offset = "0x86D1420", VA = "0x1886D2A20", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(FFBJLJLPLED GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct NCHFNGGBDNJ : IEquatable<NCHFNGGBDNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x86DFBA0", Offset = "0x86DE5A0", VA = "0x1886DFBA0")]
	public void FKPPACPIJDL(bool KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x86DFC30", Offset = "0x86DE630", VA = "0x1886DFC30")]
	public void PLBOJLDFKIL(bool KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3F04CC0", Offset = "0x3F036C0", VA = "0x183F04CC0")]
	public T NJMJANGGIBH<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public NCHFNGGBDNJ(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x86DFB10", Offset = "0x86DE510", VA = "0x1886DFB10", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(NCHFNGGBDNJ GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct PHMDHCMKBAL : IEquatable<PHMDHCMKBAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool AJKBHAGDOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x86E3BB0", Offset = "0x86E25B0", VA = "0x1886E3BB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x86E3AD0", Offset = "0x86E24D0", VA = "0x1886E3AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public bool BLHCMDMNKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x86E3CC0", Offset = "0x86E26C0", VA = "0x1886E3CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public int FPCKLHGMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x86E3C80", Offset = "0x86E2680", VA = "0x1886E3C80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x86E3B20", Offset = "0x86E2520", VA = "0x1886E3B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public PHMDHCMKBAL(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x86E3BF0", Offset = "0x86E25F0", VA = "0x1886E3BF0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(PHMDHCMKBAL GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct KDEJGMNAJNH : IEquatable<KDEJGMNAJNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public int JMAJGBOMNOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x86DE0A0", Offset = "0x86DCAA0", VA = "0x1886DE0A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x86DDEF0", Offset = "0x86DC8F0", VA = "0x1886DDEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public int CHEJKCLCDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x86DE060", Offset = "0x86DCA60", VA = "0x1886DE060")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x86DDF40", Offset = "0x86DC940", VA = "0x1886DDF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public uint BFGLHCJIILB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x86DE020", Offset = "0x86DCA20", VA = "0x1886DE020")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x86DDEA0", Offset = "0x86DC8A0", VA = "0x1886DDEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public KDEJGMNAJNH(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x86DDF90", Offset = "0x86DC990", VA = "0x1886DDF90", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(KDEJGMNAJNH GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct ALCMNFJJIFA : IEquatable<ALCMNFJJIFA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	private AFFMFFNAANM NPKPAFBLHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x86CCF60", Offset = "0x86CB960", VA = "0x1886CCF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	private CLNJGFMGDLL EMKPBDOMMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x86CCDD0", Offset = "0x86CB7D0", VA = "0x1886CCDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public bool KCEELBJLPKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x86CCE60", Offset = "0x86CB860", VA = "0x1886CCE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool BAFNGNJGGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x86CC880", Offset = "0x86CB280", VA = "0x1886CC880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool FDJJKFENILD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x86CC6B0", Offset = "0x86CB0B0", VA = "0x1886CC6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public bool KJIACAPLJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x86CD140", Offset = "0x86CBB40", VA = "0x1886CD140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public bool CPPPMHLKIIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x86CCE30", Offset = "0x86CB830", VA = "0x1886CCE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool HIDPCEPPBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x86CC6E0", Offset = "0x86CB0E0", VA = "0x1886CC6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public bool JGMDEDKHKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x86CCAE0", Offset = "0x86CB4E0", VA = "0x1886CCAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public bool EPPJKPBMBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFD0", Offset = "0x86CB9D0", VA = "0x1886CCFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public bool DAIGMNAPJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x86CC920", Offset = "0x86CB320", VA = "0x1886CC920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x86CCEF0", Offset = "0x86CB8F0", VA = "0x1886CCEF0")]
	public bool NPCDDMEPLED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x86CCC80", Offset = "0x86CB680", VA = "0x1886CCC80")]
	public ADKOMDJMHFH GBCKJMFHFIO(ADKOMDJMHFH JFBLIPHGGPK)
	{
		return default(ADKOMDJMHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x86CC770", Offset = "0x86CB170", VA = "0x1886CC770")]
	public IJNJMBEMEOM CJOLHILPLAK()
	{
		return default(IJNJMBEMEOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x86CCD20", Offset = "0x86CB720", VA = "0x1886CCD20")]
	public bool JFDNIIALIFI(IJNJMBEMEOM JFBLIPHGGPK, [Out] IJNJMBEMEOM NKJFOKABLIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public ALCMNFJJIFA(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBE0", Offset = "0x86CA5E0", VA = "0x1886CBBE0")]
	public static bool HDPJNBPLGPE(ALCMNFJJIFA KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x86CCA50", Offset = "0x86CB450", VA = "0x1886CCA50", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(ALCMNFJJIFA GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct JAJEEHGAAOE : IEquatable<JAJEEHGAAOE>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly JAJEEHGAAOE LDBDNKHHGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public IOFPFGMGGDL MHHPGNMENBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x86DA0A0", Offset = "0x86D8AA0", VA = "0x1886DA0A0")]
		get
		{
			return default(IOFPFGMGGDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public DJHMAEDPFEM JCMKCPCHLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x86D9CC0", Offset = "0x86D86C0", VA = "0x1886D9CC0")]
		get
		{
			return default(DJHMAEDPFEM);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x86D9FF0", Offset = "0x86D89F0", VA = "0x1886D9FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public IEDBPPJHEGN OCAHEHKLJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x86D9D80", Offset = "0x86D8780", VA = "0x1886D9D80")]
		get
		{
			return default(IEDBPPJHEGN);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x86DA200", Offset = "0x86D8C00", VA = "0x1886DA200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public float DNBFEMOBMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x86D9E50", Offset = "0x86D8850", VA = "0x1886D9E50")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x86DA160", Offset = "0x86D8B60", VA = "0x1886DA160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public Vector3 HCNFJNGAAME
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x86DA0E0", Offset = "0x86D8AE0", VA = "0x1886DA0E0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x86D9F70", Offset = "0x86D8970", VA = "0x1886D9F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public float CPDINOOBIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x86DA250", Offset = "0x86D8C50", VA = "0x1886DA250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public DHMONCPGFAD KHMKEDNINPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x86D9DC0", Offset = "0x86D87C0", VA = "0x1886D9DC0")]
		get
		{
			return default(DHMONCPGFAD);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x86D9E00", Offset = "0x86D8800", VA = "0x1886D9E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public bool EJJHKJLFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x86D9C30", Offset = "0x86D8630", VA = "0x1886D9C30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x86DA040", Offset = "0x86D8A40", VA = "0x1886DA040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public NGMKDFFKHEA AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(NGMKDFFKHEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public FJNCNOIEEPE KNPLINAIFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(FJNCNOIEEPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x86D9C70", Offset = "0x86D8670", VA = "0x1886D9C70")]
	public LGIFEELIJGE BHKNHNFDMMD()
	{
		return default(LGIFEELIJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x86D9F20", Offset = "0x86D8920", VA = "0x1886D9F20")]
	public GGCKKLHEAHJ FLHANJJFJBK()
	{
		return default(GGCKKLHEAHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x86DA1B0", Offset = "0x86D8BB0", VA = "0x1886DA1B0")]
	private bool NOIOCIMJJAM(DHMONCPGFAD MAFBHNHEGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x86D9D00", Offset = "0x86D8700", VA = "0x1886D9D00")]
	public void CNKDAPDHMFF(DHMONCPGFAD MAFBHNHEGDO, bool FCCCGLOCDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public JAJEEHGAAOE(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBE0", Offset = "0x86CA5E0", VA = "0x1886CBBE0")]
	public static bool HDPJNBPLGPE(JAJEEHGAAOE KMAFNKGMDCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x86CB4E0", Offset = "0x86C9EE0", VA = "0x1886CB4E0")]
	public static bool DFNINOIAFHB(JAJEEHGAAOE EICJFDNFOCB, JAJEEHGAAOE MIBIEOGGIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x86D9E90", Offset = "0x86D8890", VA = "0x1886D9E90", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(JAJEEHGAAOE GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct LGIFEELIJGE : IEquatable<LGIFEELIJGE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public JAJEEHGAAOE IOAOOMLCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(JAJEEHGAAOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public BMLHKENOJFK MPMCKFMCKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x86DE5C0", Offset = "0x86DCFC0", VA = "0x1886DE5C0")]
		get
		{
			return default(BMLHKENOJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public LGIFEELIJGE(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBE0", Offset = "0x86CA5E0", VA = "0x1886CBBE0")]
	public static bool HDPJNBPLGPE(LGIFEELIJGE KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x86DE600", Offset = "0x86DD000", VA = "0x1886DE600", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(LGIFEELIJGE GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DefaultMember("Item")]
public readonly struct GGCKKLHEAHJ : IEquatable<GGCKKLHEAHJ>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly GGCKKLHEAHJ LDBDNKHHGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	private FMNCINIGDKB DGLFEGCOHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x86D5C40", Offset = "0x86D4640", VA = "0x1886D5C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public JAJEEHGAAOE IOAOOMLCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(JAJEEHGAAOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public MGPOLIAHKGI FNALDAOEJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x86D5980", Offset = "0x86D4380", VA = "0x1886D5980")]
		get
		{
			return default(MGPOLIAHKGI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x86D5CA0", Offset = "0x86D46A0", VA = "0x1886D5CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public IEnumerable<OFDIKDELHCL> JLNEGDKKFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x86D5440", Offset = "0x86D3E40", VA = "0x1886D5440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public OFDIKDELHCL PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x86D5AA0", Offset = "0x86D44A0", VA = "0x1886D5AA0")]
		get
		{
			return default(OFDIKDELHCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x86D5BB0", Offset = "0x86D45B0", VA = "0x1886D5BB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public NGMKDFFKHEA AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(NGMKDFFKHEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x86D5640", Offset = "0x86D4040", VA = "0x1886D5640")]
	public OFDIKDELHCL CPDPAOLJONG(float3? KFJFDPLEJOD, [Optional] quaternion? AMHDLJKDJBK, [Optional] Vector3? NIAMAMNMMFM)
	{
		return default(OFDIKDELHCL);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x86D5DC0", Offset = "0x86D47C0", VA = "0x1886D5DC0")]
	public OFDIKDELHCL OGBKPOJEFBN(int KABGMIEBEFC, float3? KFJFDPLEJOD, [Optional] quaternion? AMHDLJKDJBK, [Optional] Vector3? NIAMAMNMMFM)
	{
		return default(OFDIKDELHCL);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x86D53A0", Offset = "0x86D3DA0", VA = "0x1886D53A0")]
	public void AEOLGKCAPHA(int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x86D5860", Offset = "0x86D4260", VA = "0x1886D5860")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public GGCKKLHEAHJ(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBE0", Offset = "0x86CA5E0", VA = "0x1886CBBE0")]
	public static bool HDPJNBPLGPE(GGCKKLHEAHJ KMAFNKGMDCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x86CC090", Offset = "0x86CAA90", VA = "0x1886CC090")]
	public static bool NOPNAEDOCOI(GGCKKLHEAHJ EICJFDNFOCB, GGCKKLHEAHJ MIBIEOGGIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x86D58F0", Offset = "0x86D42F0", VA = "0x1886D58F0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(GGCKKLHEAHJ GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct OFDIKDELHCL : IEquatable<OFDIKDELHCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public GGCKKLHEAHJ JFHBIOCEDJN
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x86E3120", Offset = "0x86E1B20", VA = "0x1886E3120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public float3 DMEKCHJJJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x86E3340", Offset = "0x86E1D40", VA = "0x1886E3340")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x86E3060", Offset = "0x86E1A60", VA = "0x1886E3060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public quaternion LJJEACHFGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x86E31A0", Offset = "0x86E1BA0", VA = "0x1886E31A0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x86E33A0", Offset = "0x86E1DA0", VA = "0x1886E33A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public float3 EGNLLOCNMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x86E30C0", Offset = "0x86E1AC0", VA = "0x1886E30C0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x86E32E0", Offset = "0x86E1CE0", VA = "0x1886E32E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public FFABOFGMJFG ALCDHGPIINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x86E3290", Offset = "0x86E1C90", VA = "0x1886E3290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x86E3280", Offset = "0x86E1C80", VA = "0x1886E3280")]
	public void GOFJPAEBOEC(GGCKKLHEAHJ KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public OFDIKDELHCL(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x86E31F0", Offset = "0x86E1BF0", VA = "0x1886E31F0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(OFDIKDELHCL GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct MGLLAPHMPPC : IEquatable<MGLLAPHMPPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public bool HHBABAMNIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x86DF460", Offset = "0x86DDE60", VA = "0x1886DF460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public MGLLAPHMPPC(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x86DF3D0", Offset = "0x86DDDD0", VA = "0x1886DF3D0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(MGLLAPHMPPC GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct DMCEAMEJLAK : IEquatable<DMCEAMEJLAK>
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public static readonly DMCEAMEJLAK LDBDNKHHGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	private CCFGJOFLFAJ AFODDBHOFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x86D1450", Offset = "0x86CFE50", VA = "0x1886D1450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public uint DKFBMMFDNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x86D0A30", Offset = "0x86CF430", VA = "0x1886D0A30")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x86D12D0", Offset = "0x86CFCD0", VA = "0x1886D12D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public OINMLFJGGEA PHPCMPAPBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x86D0DA0", Offset = "0x86CF7A0", VA = "0x1886D0DA0")]
		get
		{
			return default(OINMLFJGGEA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x86D1280", Offset = "0x86CFC80", VA = "0x1886D1280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public float EIMIFIDNNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x86D0F20", Offset = "0x86CF920", VA = "0x1886D0F20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x86D1400", Offset = "0x86CFE00", VA = "0x1886D1400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public float OJHMBCHALGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x86D09F0", Offset = "0x86CF3F0", VA = "0x1886D09F0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x86D0FF0", Offset = "0x86CF9F0", VA = "0x1886D0FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public JHNOEBLNBMP NLJAPOKPCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x86D0DE0", Offset = "0x86CF7E0", VA = "0x1886D0DE0")]
		get
		{
			return default(JHNOEBLNBMP);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x86D14B0", Offset = "0x86CFEB0", VA = "0x1886D14B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public float PEGNNKIGLFF
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x86D0B00", Offset = "0x86CF500", VA = "0x1886D0B00")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x86D1500", Offset = "0x86CFF00", VA = "0x1886D1500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public float IDHAOMKHODL
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x86D1320", Offset = "0x86CFD20", VA = "0x1886D1320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public float OKDNPOMJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x86D1090", Offset = "0x86CFA90", VA = "0x1886D1090")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public float DANHOBBCCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x86D0A70", Offset = "0x86CF470", VA = "0x1886D0A70")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x86D1120", Offset = "0x86CFB20", VA = "0x1886D1120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public DJHMAEDPFEM MGPPOFKEJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x86D09B0", Offset = "0x86CF3B0", VA = "0x1886D09B0")]
		get
		{
			return default(DJHMAEDPFEM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x86D13B0", Offset = "0x86CFDB0", VA = "0x1886D13B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public DJHMAEDPFEM EAOKAOFLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x86D0EE0", Offset = "0x86CF8E0", VA = "0x1886D0EE0")]
		get
		{
			return default(DJHMAEDPFEM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x86D0AB0", Offset = "0x86CF4B0", VA = "0x1886D0AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public float ADFPPIKAOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x86D0D60", Offset = "0x86CF760", VA = "0x1886D0D60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x86D1550", Offset = "0x86CFF50", VA = "0x1886D1550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public KONGKEIIMBB ECKEMILLHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x86D0D20", Offset = "0x86CF720", VA = "0x1886D0D20")]
		get
		{
			return default(KONGKEIIMBB);
		}
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x86D10D0", Offset = "0x86CFAD0", VA = "0x1886D10D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public FNFAKLPEIOE DHGKAMHMLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x86D1370", Offset = "0x86CFD70", VA = "0x1886D1370")]
		get
		{
			return default(FNFAKLPEIOE);
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x86D1040", Offset = "0x86CFA40", VA = "0x1886D1040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public ReadOnlySpan<TerrainGenerationLayer> KBDPFKKMOME
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x86D0E20", Offset = "0x86CF820", VA = "0x1886D0E20")]
		get
		{
			return default(ReadOnlySpan<TerrainGenerationLayer>);
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x86D1170", Offset = "0x86CFB70", VA = "0x1886D1170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public ReadOnlySpan<DNEPMPBCOPJ> OBKILKODHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x86D0C60", Offset = "0x86CF660", VA = "0x1886D0C60")]
		get
		{
			return default(ReadOnlySpan<DNEPMPBCOPJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF540", VA = "0x1886D0B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public DMCEAMEJLAK(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static IJNJMBEMEOM HDPJNBPLGPE(DMCEAMEJLAK KMAFNKGMDCF)
	{
		return default(IJNJMBEMEOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x86D0F60", Offset = "0x86CF960", VA = "0x1886D0F60", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(DMCEAMEJLAK GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct JLJMANMEMEE : IEquatable<JLJMANMEMEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	private ALCOIKKLOJF OBBJCEKOMII
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x86DD6B0", Offset = "0x86DC0B0", VA = "0x1886DD6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public bool CKPNMOCIIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x86DDC10", Offset = "0x86DC610", VA = "0x1886DDC10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x86DD710", Offset = "0x86DC110", VA = "0x1886DD710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public bool BHCHBOFNGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x86DD520", Offset = "0x86DBF20", VA = "0x1886DD520")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x86DD1A0", Offset = "0x86DBBA0", VA = "0x1886DD1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public float KPJLDDNDHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x86DDCE0", Offset = "0x86DC6E0", VA = "0x1886DDCE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x86DD350", Offset = "0x86DBD50", VA = "0x1886DD350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public bool EKDLHAJLLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x86DD150", Offset = "0x86DBB50", VA = "0x1886DD150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x86DDA40", Offset = "0x86DC440", VA = "0x1886DDA40")]
	public void MBMMKADLOAK(int HJCIABFMGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x86DD800", Offset = "0x86DC200", VA = "0x1886DD800")]
	public bool LCJMDLKIBNO([Out] int HJCIABFMGKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x86DD480", Offset = "0x86DBE80", VA = "0x1886DD480")]
	public void GIEJDNAGEPN(bool CJNMCHOHDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x86DD430", Offset = "0x86DBE30", VA = "0x1886DD430")]
	public bool FJELFBFLPPL(HIEKGLJOIDK MAFBHNHEGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x86DDC60", Offset = "0x86DC660", VA = "0x1886DDC60")]
	public void OGDBBGLAINI(HIEKGLJOIDK MAFBHNHEGDO, bool FCCCGLOCDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x86DD570", Offset = "0x86DBF70", VA = "0x1886DD570")]
	public void IAGAIFOHMEE(float NDHJNIMJBKM, float BAKIKIHCDMK, float LJFMEJOOCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x86DD200", Offset = "0x86DBC00", VA = "0x1886DD200")]
	public void DPJOGCEIKFO(float3 KDFLBGAIMGM, quaternion EDBAKKNMCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x86DD910", Offset = "0x86DC310", VA = "0x1886DD910")]
	public bool LGEJIAPCOEL([Out] float3 KDFLBGAIMGM, [Out] quaternion EDBAKKNMCGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x86DDAE0", Offset = "0x86DC4E0", VA = "0x1886DDAE0")]
	public bool MPBAEPJKLEA([Out] float DECGLJBFCLP, [Out] float OBDIAPLHCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x86DD770", Offset = "0x86DC170", VA = "0x1886DD770")]
	public void LACGGNNMBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public JLJMANMEMEE(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x86DD3A0", Offset = "0x86DBDA0", VA = "0x1886DD3A0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(JLJMANMEMEE GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct NGMKDFFKHEA : IEquatable<NGMKDFFKHEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	private DOOPGKEPAJL MEHGIJCGKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x86E1F20", Offset = "0x86E0920", VA = "0x1886E1F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public Vector3 DMEKCHJJJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x86E17C0", Offset = "0x86E01C0", VA = "0x1886E17C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x86E0260", Offset = "0x86DEC60", VA = "0x1886E0260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public Quaternion LJJEACHFGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x86E06D0", Offset = "0x86DF0D0", VA = "0x1886E06D0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x86E1DA0", Offset = "0x86E07A0", VA = "0x1886E1DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public Vector3 AJCPJAHJBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x86E0D60", Offset = "0x86DF760", VA = "0x1886E0D60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x86E0C50", Offset = "0x86DF650", VA = "0x1886E0C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public Quaternion OMKCHIKPOAF
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x86E1A90", Offset = "0x86E0490", VA = "0x1886E1A90")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x86E1CD0", Offset = "0x86E06D0", VA = "0x1886E1CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public float JPGCGFKHDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x86E0A40", Offset = "0x86DF440", VA = "0x1886E0A40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x86E11F0", Offset = "0x86DFBF0", VA = "0x1886E11F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public float ELCNLMLKKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x86E13C0", Offset = "0x86DFDC0", VA = "0x1886E13C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public Matrix4x4 IAGDJHKAAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x86E0D20", Offset = "0x86DF720", VA = "0x1886E0D20")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public FJNCNOIEEPE KNPLINAIFGD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(FJNCNOIEEPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	private LHOENBPGPCA DIBEEIFKJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x86CC0A0", Offset = "0x86CAAA0", VA = "0x1886CC0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x86E1A40", Offset = "0x86E0440", VA = "0x1886E1A40")]
	public ALEFPCAPAGF OCDAFFMIGHB()
	{
		return default(ALEFPCAPAGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x86E12A0", Offset = "0x86DFCA0", VA = "0x1886E12A0")]
	public void LFEKPIMFMHO([Out] Matrix4x4 GHDIHCHPDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x86E1510", Offset = "0x86DFF10", VA = "0x1886E1510")]
	public void MHAFALDGNPG([In] Vector3 AIOBIOOBAEK, [In] Quaternion ECCDGFAJEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x86E1610", Offset = "0x86E0010", VA = "0x1886E1610")]
	public void MHAFALDGNPG([In] RigidTransform GPBPCBAILAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x86E0620", Offset = "0x86DF020", VA = "0x1886E0620")]
	public void EACEOMIENMP([Out] RigidTransform GPBPCBAILAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x86E00A0", Offset = "0x86DEAA0", VA = "0x1886E00A0")]
	public void BHHCHMEEDFJ([In] Vector3 ALDCNPKOBMN, [In] Quaternion GGJGEEEFLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x86E01A0", Offset = "0x86DEBA0", VA = "0x1886E01A0")]
	public void BHHCHMEEDFJ([In] RigidTransform FPHHDIIPPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x86E0960", Offset = "0x86DF360", VA = "0x1886E0960")]
	public void GCBCJKHBIBN([Out] Vector3 ALDCNPKOBMN, [Out] Quaternion GGJGEEEFLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x86E08B0", Offset = "0x86DF2B0", VA = "0x1886E08B0")]
	public void GCBCJKHBIBN([Out] RigidTransform GPBPCBAILAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x86E1CA0", Offset = "0x86E06A0", VA = "0x1886E1CA0")]
	public UniformTRS OFAEOJLDIKE()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x86E1BE0", Offset = "0x86E05E0", VA = "0x1886E1BE0")]
	public void OFAEOJLDIKE([Out] UniformTRS FPHHDIIPPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x86E1970", Offset = "0x86E0370", VA = "0x1886E1970")]
	public UniformTRS NFGPFDLMMJP()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x86E18B0", Offset = "0x86E02B0", VA = "0x1886E18B0")]
	public void NFGPFDLMMJP([Out] UniformTRS GPBPCBAILAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x86E0FA0", Offset = "0x86DF9A0", VA = "0x1886E0FA0")]
	public Vector3 JOOOPGOOCJK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x86E0480", Offset = "0x86DEE80", VA = "0x1886E0480")]
	public void CCHNPHKKLBP([In] Vector3 KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x86E16D0", Offset = "0x86E00D0", VA = "0x1886E16D0")]
	public Vector3 NADIJAOIOBH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x86E1120", Offset = "0x86DFB20", VA = "0x1886E1120")]
	public void KKNJJMBAHND([In] Vector3 KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x86E0330", Offset = "0x86DED30", VA = "0x1886E0330")]
	public Quaternion BKJFNGGDPCK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x86E0550", Offset = "0x86DEF50", VA = "0x1886E0550")]
	public void CHLJMKPOGNB([In] Quaternion KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x86E0E50", Offset = "0x86DF850", VA = "0x1886E0E50")]
	public Quaternion JOLNJMNAMAF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x86E0AE0", Offset = "0x86DF4E0", VA = "0x1886E0AE0")]
	public void GLNFLONMLPL([In] Quaternion KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x86E0BB0", Offset = "0x86DF5B0", VA = "0x1886E0BB0")]
	public float GPOGFHBGDMD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x86E1E70", Offset = "0x86E0870", VA = "0x1886E1E70")]
	public void OIJCCCMNDCL(float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x86E19A0", Offset = "0x86E03A0", VA = "0x1886E19A0")]
	public float NJHCLAFKCFA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x86E1460", Offset = "0x86DFE60", VA = "0x1886E1460")]
	public void MCKDCGHEHBA(float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x86E1090", Offset = "0x86DFA90", VA = "0x1886E1090")]
	public Vector3 KEOGHALPCJI([In] Vector3 HLNPPHJBENM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public NGMKDFFKHEA(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x86E0820", Offset = "0x86DF220", VA = "0x1886E0820", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(NGMKDFFKHEA GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct CLMEIFBPEMH : IEquatable<CLMEIFBPEMH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	private FHKPKFNPBBM OHJJGOAHGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x86D0060", Offset = "0x86CEA60", VA = "0x1886D0060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	private DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x86CCFC0", Offset = "0x86CB9C0", VA = "0x1886CCFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x86CFE90", Offset = "0x86CE890", VA = "0x1886CFE90")]
	public void EAEKCJCFAPH(string CKJPANLJIKJ, JCPKDLEFKEO BNOBLABHPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public CLMEIFBPEMH(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x86CFFD0", Offset = "0x86CE9D0", VA = "0x1886CFFD0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(CLMEIFBPEMH GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CBC10", VA = "0x1886CD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct HMLLDAOMBPK : IEquatable<HMLLDAOMBPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public MBMBOKIFJPB JANHGLFGHPA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x86D7300", Offset = "0x86D5D00", VA = "0x1886D7300")]
		get
		{
			return default(MBMBOKIFJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public HMLLDAOMBPK(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x86D73F0", Offset = "0x86D5DF0", VA = "0x1886D73F0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(HMLLDAOMBPK GOCNHGEHNFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct BGICDIGHFEF : IEquatable<BGICDIGHFEF>
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public struct HLGKAAOECIC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private IJNJMBEMEOM EFILDLEHGNL;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x86D7260", Offset = "0x86D5C60", VA = "0x1886D7260")]
		public HLGKAAOECIC(IJNJMBEMEOM EFILDLEHGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x86D71D0", Offset = "0x86D5BD0", VA = "0x1886D71D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x86CE2B0", Offset = "0x86CCCB0", VA = "0x1886CE2B0")]
	public HLGKAAOECIC FFNJINDGFGA()
	{
		return default(HLGKAAOECIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x86CE5F0", Offset = "0x86CCFF0", VA = "0x1886CE5F0")]
	public EJCGDCDDCKB PALJDLBHEAM(Allocator EIOOMONCLID = Allocator.Temp)
	{
		return default(EJCGDCDDCKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x86CE4C0", Offset = "0x86CCEC0", VA = "0x1886CE4C0")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> OLKCOGAMNFP(Allocator EIOOMONCLID = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x86CE0C0", Offset = "0x86CCAC0", VA = "0x1886CE0C0")]
	public NativeArray<ECANCCLIJHJ> AOBCFILGKAP(Allocator EIOOMONCLID = Allocator.Temp)
	{
		return default(NativeArray<ECANCCLIJHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x86CE170", Offset = "0x86CCB70", VA = "0x1886CE170")]
	public NativeArray<ECANCCLIJHJ> CCNOPOIOPHL(Allocator EIOOMONCLID = Allocator.Temp)
	{
		return default(NativeArray<ECANCCLIJHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x86CE000", Offset = "0x86CCA00", VA = "0x1886CE000")]
	public BKGDNKOLHBO AJJMADNEALA(Allocator EIOOMONCLID = Allocator.Temp)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x86CE400", Offset = "0x86CCE00", VA = "0x1886CE400")]
	public BKGDNKOLHBO JHINIFOIKKC(Allocator EIOOMONCLID = Allocator.Temp)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x86CE340", Offset = "0x86CCD40", VA = "0x1886CE340")]
	public BKGDNKOLHBO HHJBAKHLFMM(Allocator EIOOMONCLID = Allocator.Temp)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public BGICDIGHFEF(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x86CE220", Offset = "0x86CCC20", VA = "0x1886CE220", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(BGICDIGHFEF GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x86CE6E0", Offset = "0x86CD0E0", VA = "0x1886CE6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct OBCECNGNAHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int EONPGDPEFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public int LELGBJANOPF;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public readonly struct NOIILBLDIEO : IEquatable<NOIILBLDIEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public BGICDIGHFEF NBIGFKGBPCL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(BGICDIGHFEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public COLAIGBICHI ECLPEGKCLEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(COLAIGBICHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public HMLLDAOMBPK PJGBCIJNJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(HMLLDAOMBPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x86E2990", Offset = "0x86E1390", VA = "0x1886E2990")]
	public bool OOJAMJHLECM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x86E2810", Offset = "0x86E1210", VA = "0x1886E2810")]
	public bool JPLBNJAKGMC([Out] Exception ILHCGNGICHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public NOIILBLDIEO(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static IJNJMBEMEOM HDPJNBPLGPE(NOIILBLDIEO KMAFNKGMDCF)
	{
		return default(IJNJMBEMEOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x86E2780", Offset = "0x86E1180", VA = "0x1886E2780", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(NOIILBLDIEO GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x86CE6E0", Offset = "0x86CD0E0", VA = "0x1886CE6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public readonly struct BKCGCMOGPAC : IDisposable, IEquatable<BKCGCMOGPAC>
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static readonly BKCGCMOGPAC LDBDNKHHGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	public NOIILBLDIEO LBLJJNDELGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(NOIILBLDIEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	public BGICDIGHFEF NBIGFKGBPCL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(BGICDIGHFEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x86CE740", Offset = "0x86CD140", VA = "0x1886CE740")]
	public void BEDPIDDHJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x86CE7C0", Offset = "0x86CD1C0", VA = "0x1886CE7C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public BKCGCMOGPAC(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x86CE890", Offset = "0x86CD290", VA = "0x1886CE890", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "5")]
	public bool Equals(BKCGCMOGPAC GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x86CE920", Offset = "0x86CD320", VA = "0x1886CE920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public readonly struct COLAIGBICHI : IEquatable<COLAIGBICHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	public bool OMBMEDIDCGH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x86D0150", Offset = "0x86CEB50", VA = "0x1886D0150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	public COLAIGBICHI(IJNJMBEMEOM EFILDLEHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x86CBBA0", Offset = "0x86CA5A0", VA = "0x1886CBBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x86D00C0", Offset = "0x86CEAC0", VA = "0x1886D00C0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x86CB960", Offset = "0x86CA360", VA = "0x1886CB960", Slot = "4")]
	public bool Equals(COLAIGBICHI GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x86CE6E0", Offset = "0x86CD0E0", VA = "0x1886CE6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class AEAJKMPALFL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct PCDHGLMNPAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Guid OCONCDFGCOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public JNNGDGOOOGI DADBKJOIPCB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct JNNGDGOOOGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int KMAFNKGMDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int HAFACPIKFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int LJDDPIIECNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int BOMPBFPBPEF;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x86DDD20", Offset = "0x86DC720", VA = "0x1886DDD20")]
		public bool BHOINOOKDHH([Out] ECANCCLIJHJ IJEKFHGIEHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x86DDDC0", Offset = "0x86DC7C0", VA = "0x1886DDDC0")]
		public JNNGDGOOOGI(ECANCCLIJHJ IJEKFHGIEHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x86CC410", Offset = "0x86CAE10", VA = "0x1886CC410")]
	public static Guid GGCDBCMLALE(this ECANCCLIJHJ IJEKFHGIEHN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x86CC4B0", Offset = "0x86CAEB0", VA = "0x1886CC4B0")]
	public static bool LNPKKFMKFCH(this Guid OCONCDFGCOB, [Out] ECANCCLIJHJ IJEKFHGIEHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
internal static class GDDEJJJJFED
{
	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x86D5170", Offset = "0x86D3B70", VA = "0x1886D5170")]
	public static DJAJCMGGCAM CLPKKNLDCNL(this IJNJMBEMEOM NMAIBBDGPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x86D5110", Offset = "0x86D3B10", VA = "0x1886D5110")]
	public static CAIBNPNLHFH CFMADAGLPED(this IJNJMBEMEOM NMAIBBDGPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x86D5310", Offset = "0x86D3D10", VA = "0x1886D5310")]
	public static EntityManager IKJPKHBBPHF(this IJNJMBEMEOM NMAIBBDGPCD)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x3DA2130", Offset = "0x3DA0B30", VA = "0x183DA2130")]
	internal static bool CDFCKHMJEMN<T>(this IJNJMBEMEOM NMAIBBDGPCD, bool FCCCGLOCDNB) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x86D5200", Offset = "0x86D3C00", VA = "0x1886D5200")]
	public static bool HDEMCIKBKJG(this IJNJMBEMEOM NMAIBBDGPCD, CEEFNPBAPME ELEBIIGLBPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x3DA5670", Offset = "0x3DA4070", VA = "0x183DA5670")]
	public static bool LMKCPPPHMBL<T>(this IJNJMBEMEOM NMAIBBDGPCD) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x3DA0380", Offset = "0x3D9ED80", VA = "0x183DA0380")]
	public static bool AHMGEHDEHHJ<T>(this IJNJMBEMEOM NMAIBBDGPCD) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x3DA24C0", Offset = "0x3DA0EC0", VA = "0x183DA24C0")]
	[FEHCMMBJLDA]
	internal static NativeArray<T> HCINJDEEPLA<T>(this IJNJMBEMEOM NMAIBBDGPCD, Allocator EIOOMONCLID) where T : struct, IBufferElementData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x3DA0590", Offset = "0x3D9EF90", VA = "0x183DA0590")]
	[FEHCMMBJLDA]
	public static T BHOLFEEIMBE<T>(this IJNJMBEMEOM NMAIBBDGPCD) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x3DA25B0", Offset = "0x3DA0FB0", VA = "0x183DA25B0")]
	[FEHCMMBJLDA]
	public static T JAFNFCINMHA<T>(this IJNJMBEMEOM NMAIBBDGPCD) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x3DA6110", Offset = "0x3DA4B10", VA = "0x183DA6110")]
	public static bool OHABJPGKDFB<T>(this IJNJMBEMEOM NMAIBBDGPCD, [Out] T KMAFNKGMDCF) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x3DA2370", Offset = "0x3DA0D70", VA = "0x183DA2370")]
	public static T FJNOKGHOJFE<T>(this IJNJMBEMEOM NMAIBBDGPCD) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x3DA22F0", Offset = "0x3DA0CF0", VA = "0x183DA22F0")]
	public static T DLELPGHJHOD<T>(this IJNJMBEMEOM NMAIBBDGPCD) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
internal static class LODHFGOIFCP
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DefaultMember("Item")]
public struct EJCGDCDDCKB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private BKGDNKOLHBO KGCMICBGABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> MFCMCGICOGO;

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x62792D0", Offset = "0x6277CD0", VA = "0x1862792D0")]
	public EJCGDCDDCKB(BKGDNKOLHBO KGCMICBGABJ, NativeArray<EntityRemapUtility.EntityRemapInfo> MFCMCGICOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x86D1BB0", Offset = "0x86D05B0", VA = "0x1886D1BB0")]
	public LocalId KNCFKMCINHN(LocalId PMNHIPACJLN)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x86D1B60", Offset = "0x86D0560", VA = "0x1886D1B60")]
	public LocalId KNCFKMCINHN(int KABGMIEBEFC)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x86D1AF0", Offset = "0x86D04F0", VA = "0x1886D1AF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DLINNPGLBOH
{
	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNIAEIPCIPK(IJNJMBEMEOM JGHKDIDNBJI, [Out] uint NMAIBBDGPCD);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JNMKCAEAPJL(IJNJMBEMEOM JGHKDIDNBJI, [Out] uint NMAIBBDGPCD);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEHKKOAOGIM(IJNJMBEMEOM JGHKDIDNBJI, uint NMAIBBDGPCD);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KDGEHECOCGJ(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string BMAMPEPEEGM(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IBKIDMINGEB(IJNJMBEMEOM JGHKDIDNBJI, string NMAIBBDGPCD);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KBBEOMMNNAO(IJNJMBEMEOM JGHKDIDNBJI, [Out] string ADDKCMBENIE);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MMHFLJDOEPC(IJNJMBEMEOM JGHKDIDNBJI, string ADDKCMBENIE);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LLFKLOBKKPA
{
	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	Guid MDCOLHDCPMB
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	Guid BGABGKDHEAD
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EJGIMGAMCJB(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KIDOOAACDFE(ADKOMDJMHFH PMNHIPACJLN);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid ICOEOIOPENH(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNEEHBLCBAI(IJNJMBEMEOM EFILDLEHGNL, Guid DKOKOBIEBLC);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LEOCCDODGEG(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task HNHOBOCIIMB(IJNJMBEMEOM FPJMMEGHFEH, IJNJMBEMEOM AEMEEJKFKNN);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PICEFAPLLAP(IJNJMBEMEOM EFILDLEHGNL, ECANCCLIJHJ CKBMDKNDCPF);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HELLJOGBDEF
{
	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	Guid MDCOLHDCPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHFDJOKADHJ(NativeList<Guid> LKEJHMHJPCE, NativeList<Guid> CPJIFHACAMG, NativeList<FixedString64Bytes> GIMFOOMOIMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KKOGGOEFFFO
{
	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BKGDNKOLHBO DICAKPPAAEH(Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BKGDNKOLHBO NCFPNLMIGHP(Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ALGIGGKPDHE(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BLHCMDMNKHM(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PDEEJNELKPI(IJNJMBEMEOM JGHKDIDNBJI, [Out] IJNJMBEMEOM DFFJIFPCDDK);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AJKBHAGDOOH(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DAEFNJJOHGN(IJNJMBEMEOM JGHKDIDNBJI, int JIHMJMCIFOI);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IJNJMBEMEOM KMNJAJDNPNO(IJNJMBEMEOM DFFJIFPCDDK);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DOAOCACBAPE(BKGDNKOLHBO JAPKGPLEDNP, bool HDACPAPFGGK);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FCLLDBNOIJJ(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LMCPMPMFKGE(IJNJMBEMEOM JGHKDIDNBJI, bool HHIENLGBPAO);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int KLIFPOHIGJB();

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MPJDDLDOLHN(IJNJMBEMEOM EFILDLEHGNL);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LGMIKJJLGHL
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<IJNJMBEMEOM, IJNJMBEMEOM> CJOJNFMGLHP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<IJNJMBEMEOM, IJNJMBEMEOM> FHLKKPKCKJB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<IJNJMBEMEOM, IJNJMBEMEOM, IJNJMBEMEOM> FMJHONKOHHI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<IJNJMBEMEOM> LHNMPNPOBNE;

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FDKCDFKFOIL(IJNJMBEMEOM EFILDLEHGNL, IJNJMBEMEOM DEFMKBBCGEA);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IJNJMBEMEOM FIGKNEBMLLK(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BKGDNKOLHBO AEADAMLPCBD(IJNJMBEMEOM EFILDLEHGNL, Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IJNJMBEMEOM EFCKKJFEOOE(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NLAAIHDOEOJ(IJNJMBEMEOM EFILDLEHGNL, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OADINBALMAG(IJNJMBEMEOM EFILDLEHGNL, float OELEAGMCOIE);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool AJNOJMFFHDF(IJNJMBEMEOM EFILDLEHGNL, [Out] IJNJMBEMEOM AEMEEJKFKNN);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IPBFCBIABIN(IJNJMBEMEOM EFILDLEHGNL, [Out] RigidTransform FKJKBILGDDP);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 OMAGGJEIKGP(LLHKKEBFIAA GJKJHAMHLOA);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion DPMGBJCDOCE(LLHKKEBFIAA GJKJHAMHLOA);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class FIBHHKBAJME
{
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OCLKHLGLJND
{
	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	object EEDECEBKAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JKGNDKAOGNI
{
	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJLIGCPHPBG(IJNJMBEMEOM PMNHIPACJLN, PFLKBNAMBMN DFHNBMLEMBK);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOLDPPFPGLM(PFLKBNAMBMN DFHNBMLEMBK);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LJOONKAJKMB(IJNJMBEMEOM EFILDLEHGNL, [Out] PFLKBNAMBMN KCCJBLMJGKN);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HKNGBJEBBJL
{
	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPAGPCIHHGI(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeArray<IJNJMBEMEOM> OKNIDEIBHKA();
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Flags]
public enum IGHPAKADGPG
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
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OPILNFDNHMH
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public ref struct JABDLCGLABD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ReadOnlySpan<IJNJMBEMEOM> GAMPPDHFFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public ReadOnlySpan<IJNJMBEMEOM> BGEHAILFDMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public IJNJMBEMEOM AMLOFIGPKIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public IJNJMBEMEOM DLGGDMGDIBF;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGAGONFFIGL(IJNJMBEMEOM OGIGJFIOGFN, IJNJMBEMEOM CLPFAIIIODC);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKPEIMBGIGM(IJNJMBEMEOM EBEOMPGDHJA, bool KEJIJALNLAM);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IILHFDCDGOO(IJNJMBEMEOM MOEPMEDDIOO, IJNJMBEMEOM GAOJBILHJIK);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HPJFDFHHHEN(IJNJMBEMEOM EANCNLNFGFP, bool KEJIJALNLAM);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GCLNJILEPJH(IJNJMBEMEOM EANCNLNFGFP);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CJMBAHCGOFC(IJNJMBEMEOM EANCNLNFGFP);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IJNJMBEMEOM PLKKEDOHGKC(IJNJMBEMEOM EBEOMPGDHJA);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ReadOnlySpan<IJNJMBEMEOM> LPKPBNCBPLF(IJNJMBEMEOM EANCNLNFGFP);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ReadOnlySpan<IJNJMBEMEOM> CIAFLDDJDFF(IJNJMBEMEOM EANCNLNFGFP);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JABDLCGLABD EBAPAPLGBJC(IJNJMBEMEOM EANCNLNFGFP, float PBPABALDCDE, float AFHNJHINHLO);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MEOICIOGHLM(IJNJMBEMEOM EANCNLNFGFP, [Out] IAKBGJEAJCI HPOEHMOLEIK);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LFHEGJGOEOJ(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KEKAKNFHBNM(IJNJMBEMEOM EFILDLEHGNL);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public readonly struct JKOABMNEDED<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly string IELIBBNCJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly T KJMOBDOKFBF;

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5547340", Offset = "0x5545D40", VA = "0x185547340")]
	public JKOABMNEDED(T KJMOBDOKFBF, [Optional][CallerMemberName] string IELIBBNCJAC)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly JKOABMNEDED<int> EFHHADKGBOJ;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static readonly JKOABMNEDED<int> JGCJMFJCHDC;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly JKOABMNEDED<int> LADOOAJBGFA;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public enum DOBLKEJLGIB
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class ACHOFACCNJP
{
	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x15609D0", Offset = "0x155F3D0", VA = "0x1815609D0")]
	public static bool ODCGEAIFENO(this DOBLKEJLGIB IMNBLKDCAKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x1976220", Offset = "0x1974C20", VA = "0x181976220")]
	public static bool BPLNGPJLOIF(this DOBLKEJLGIB IMNBLKDCAKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x32764D0", Offset = "0x3274ED0", VA = "0x1832764D0")]
	public static bool HCEJNIDCOGC(this DOBLKEJLGIB IMNBLKDCAKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x15609C0", Offset = "0x155F3C0", VA = "0x1815609C0")]
	public static bool EHFNBLEPHHF(this DOBLKEJLGIB IMNBLKDCAKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LBKPJOGNLIO
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public enum MFBNIKCDBLO
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

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum DMCPEECGPCL
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	MFBNIKCDBLO PLEHJDEDHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	bool EBANNPLEDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	bool MPNKOANDBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	DMCPEECGPCL DLHFGDBNPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.Application)]
public interface LJHJGFCEIBF
{
	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	DOBLKEJLGIB JMKJOCKDPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	DOBLKEJLGIB AFCIIKKNNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	DOBLKEJLGIB AGBAFONLGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	DOBLKEJLGIB GJDBKFJEDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	DOBLKEJLGIB LOMKKEEBHJN
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	DOBLKEJLGIB NONLBKPDOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	DOBLKEJLGIB ELIBICAKPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	DOBLKEJLGIB OLBGKPKOIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	DOBLKEJLGIB PMLHBIBOKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	DOBLKEJLGIB LCGJCININOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	DOBLKEJLGIB BJKMEBAKKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	DOBLKEJLGIB ABEFEIIPKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	DOBLKEJLGIB KGADCEJPNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	DOBLKEJLGIB BGDLEPNKFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	DOBLKEJLGIB FMELBKIFIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	DOBLKEJLGIB OHBBJBLMFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	DOBLKEJLGIB BACDJFDBBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	DOBLKEJLGIB JMODCACNONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000202")]
	DOBLKEJLGIB JINALFOBOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	DOBLKEJLGIB KOLFOAALCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GFFPJLNAMHB(JKOABMNEDED<int> OINEAODAACF);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BBKILMFCMED
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event IFBNAGHJFPO.LHKBEFFNNFN PGFFJFBDGFI;

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IJNJMBEMEOM NCBPFDNEFID(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BKGDNKOLHBO OMGKOMGEFBJ(Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FFABOFGMJFG APKFILBBIIC(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ODEDBHNBMLF(IEnumerable<IJNJMBEMEOM> HOBGALLGGIK);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FFABOFGMJFG PKKCKJMEMEJ(IJNJMBEMEOM AEMEEJKFKNN, IJNJMBEMEOM KGCMICBGABJ, bool NIMIHFDCOFJ, IJNJMBEMEOM JFBLIPHGGPK);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IJNJMBEMEOM GICCPKEANJD(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IEBALGDGBAK(IJNJMBEMEOM EFILDLEHGNL, IJNJMBEMEOM AEMEEJKFKNN, bool BNAMKHAIFEN = false);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LGHNNFACONB(IJNJMBEMEOM EFILDLEHGNL, IJNJMBEMEOM AEMEEJKFKNN);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LOGNEMJNEAL(IJNJMBEMEOM OEOLKAICKGF, IJNJMBEMEOM NFBLCEPECIN);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	BKGDNKOLHBO KENJABIPEJM(IJNJMBEMEOM KKGNPJDBLLP);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MGALKNIIMKJ(IJNJMBEMEOM EFILDLEHGNL, IJNJMBEMEOM LHFBHALFPDB);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BKGDNKOLHBO BFNGHFEHGMN(BKGDNKOLHBO BPLOMNKNONO, IGHPAKADGPG JHBIAAAGFJK, Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool PBKAKKACIHE(IJNJMBEMEOM EFILDLEHGNL, IJNJMBEMEOM DEEBILEDKDG);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IJNJMBEMEOM MNIMLNICLFD(IJNJMBEMEOM JFBLIPHGGPK, IJNJMBEMEOM GEIAIAMNHAJ);

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool MDIFGAFGBDO(IJNJMBEMEOM JFBLIPHGGPK, IJNJMBEMEOM GEIAIAMNHAJ, [Out] IJNJMBEMEOM DKOJMMOJCDO);

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IJNJMBEMEOM GOMHLGEOJPO(IJNJMBEMEOM[] JAPKGPLEDNP);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IJNJMBEMEOM EMFOCJBBEKO(IJNJMBEMEOM EFILDLEHGNL, uint FHAGACEPDLI);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class IIPCFABBDOD
{
	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x86D9120", Offset = "0x86D7B20", VA = "0x1886D9120")]
	public static bool CDGODCGHBAH(this BBKILMFCMED KAJADHIAMML, IJNJMBEMEOM EFILDLEHGNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x86D8E50", Offset = "0x86D7850", VA = "0x1886D8E50")]
	public static BKGDNKOLHBO BFNGHFEHGMN(this BBKILMFCMED DGDHAMECAIH, IJNJMBEMEOM EFILDLEHGNL, IGHPAKADGPG JHBIAAAGFJK, Allocator EIOOMONCLID)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x86D8DD0", Offset = "0x86D77D0", VA = "0x1886D8DD0")]
	public static BKGDNKOLHBO AGHKCAFAMPF(this BBKILMFCMED DGDHAMECAIH, IJNJMBEMEOM EFILDLEHGNL, Allocator EIOOMONCLID)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x86D90E0", Offset = "0x86D7AE0", VA = "0x1886D90E0")]
	public static BKGDNKOLHBO BGLGFAGFNAO(this BBKILMFCMED DGDHAMECAIH, IJNJMBEMEOM EFILDLEHGNL, Allocator EIOOMONCLID)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x86D8E10", Offset = "0x86D7810", VA = "0x1886D8E10")]
	public static BKGDNKOLHBO BFMNAKCGPKL(this BBKILMFCMED DGDHAMECAIH, IJNJMBEMEOM EFILDLEHGNL, Allocator EIOOMONCLID)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x86D9190", Offset = "0x86D7B90", VA = "0x1886D9190")]
	public static BKGDNKOLHBO FGBBJHJKAAP(this BBKILMFCMED DGDHAMECAIH, IJNJMBEMEOM EFILDLEHGNL, Allocator EIOOMONCLID)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x86D91D0", Offset = "0x86D7BD0", VA = "0x1886D91D0")]
	public static BKGDNKOLHBO FGIGKMMIMKN(this BBKILMFCMED DGDHAMECAIH, IJNJMBEMEOM EFILDLEHGNL, Allocator EIOOMONCLID)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x86D9330", Offset = "0x86D7D30", VA = "0x1886D9330")]
	public static BKGDNKOLHBO LDBPEKBABPA(this BBKILMFCMED DGDHAMECAIH, IJNJMBEMEOM EFILDLEHGNL, Allocator EIOOMONCLID)
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x86D9210", Offset = "0x86D7C10", VA = "0x1886D9210")]
	public static BKGDNKOLHBO LDBPEKBABPA(this BBKILMFCMED DGDHAMECAIH, BKGDNKOLHBO EFILDLEHGNL, Allocator EIOOMONCLID)
	{
		return default(BKGDNKOLHBO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GAOFOKCGIKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x86D50B0", Offset = "0x86D3AB0", VA = "0x1886D50B0", Slot = "0")]
	Task<NOIILBLDIEO> MIPBNPJJBKM(IFCMBFOMDFH MKIFOHHALPC, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "1")]
	void JDJCFCGGOMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LGBDMHJCAGD
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event IFBNAGHJFPO.LHKBEFFNNFN PGFFJFBDGFI;

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IJNJMBEMEOM GICCPKEANJD(IJNJMBEMEOM FPJMMEGHFEH);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<IJNJMBEMEOM> FIEMPPDFMOA();

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<IJNJMBEMEOM> PMCDCBJMABC(IJNJMBEMEOM AEMEEJKFKNN);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LBOOMEILHFE(IJNJMBEMEOM BINKLMJMIAP, IJNJMBEMEOM MIMGFMMFBLI, [Out] FFABOFGMJFG KPFDPLBPEPB);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HMKLPDONKJO(IJNJMBEMEOM BINKLMJMIAP, IJNJMBEMEOM JHFFDLCGHOF, [Out] FFABOFGMJFG KPFDPLBPEPB);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IKPPHGJMJLL(IJNJMBEMEOM BINKLMJMIAP);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LGHNNFACONB(IJNJMBEMEOM IDLKFPDGPMG, IJNJMBEMEOM CCBBLDBOMGE);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FFABOFGMJFG HBJDMHDHFPF(IJNJMBEMEOM EFILDLEHGNL);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GOLJMDGEEMK
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	bool NJKIFEFOAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	bool PBDAPDKDIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	bool NCABJHPEOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HEFIFBAKKOG
{
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DENDJBKFBJK
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKEINACCKMJ(IJNJMBEMEOM EFILDLEHGNL, CEEFNPBAPME ELEBIIGLBPL);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGNNPIJKHLJ(IJNJMBEMEOM EFILDLEHGNL, CEEFNPBAPME ELEBIIGLBPL);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LFJPGHPMJEE
{
	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OCCFPJFFJEE<string> ONINPLAFJOJ(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OCCFPJFFJEE<string> EEHLBKFABPB(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMNOMJILCHA(IJNJMBEMEOM EFILDLEHGNL, OCCFPJFFJEE<string> FOBGEFFAIOK);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AIHGKNJADDM(IJNJMBEMEOM EFILDLEHGNL, OCCFPJFFJEE<string> FOBGEFFAIOK);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AOMGENJHHLO(IJNJMBEMEOM EMGPDFMABFC, IJNJMBEMEOM CJJNNLFCDDM);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ECNBPBALKNJ
{
	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CFDHLOOAFMC BIHLOGLBDFB(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICEALBBGEKI(IJNJMBEMEOM JGHKDIDNBJI, CFDHLOOAFMC JICCDONLJBM);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IKOOIKBIMIB(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LGIMOGNLFBG(IJNJMBEMEOM JGHKDIDNBJI, bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OCCFPJFFJEE<string> DMDEOFKLBKA(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ODCPMBLBJDC(IJNJMBEMEOM JGHKDIDNBJI, OCCFPJFFJEE<string> FOBGEFFAIOK);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OCCFPJFFJEE<string> AOHGLILGJHA(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IDDMIMGHHHO(IJNJMBEMEOM JGHKDIDNBJI, OCCFPJFFJEE<string> FOBGEFFAIOK);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OCCFPJFFJEE<string> ONNPKDNBBJG(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CJBMJNCLNCO(IJNJMBEMEOM JGHKDIDNBJI, OCCFPJFFJEE<string> FOBGEFFAIOK);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OCCFPJFFJEE<string> ILOKIPKJHBP(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CABJCCGPOCP(IJNJMBEMEOM JGHKDIDNBJI, OCCFPJFFJEE<string> FOBGEFFAIOK);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HJNMJICKLHN(IJNJMBEMEOM JGHKDIDNBJI, IJNJMBEMEOM BLHNDOLLIDD);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FCAFONNGLMO
{
	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEGENJNOPLO([In] float3 IIBHNKFDNNM, [In] float3 HLNPPHJBENM, float EFLCGLGNONM, [Out] ELPGOECJBGM LGMHMLAMCAI, [Out] IJNJMBEMEOM KIFPCOAPDIF);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JMAGOPNPGHH([In] float3 IIBHNKFDNNM, float JBOIDCJHBGG, List<IJNJMBEMEOM> JAPKGPLEDNP);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HACABEDGLFE(Plane[] AEBLEHEKGHH, float3 IIBHNKFDNNM, float3 HBOJMGIALFO, quaternion AMHDLJKDJBK, List<IJNJMBEMEOM> JAPKGPLEDNP);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JBKEKNCPKLF
{
	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEGENJNOPLO([In] NativeArray<Entity> BKFKEKMLADJ, [In] float3 IIBHNKFDNNM, [In] float3 HLNPPHJBENM, [In] NativeArray<ELPGOECJBGM> NFFMALGCJNH);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> JMAGOPNPGHH([In] NativeArray<Entity> BKFKEKMLADJ, [In] float3 IIBHNKFDNNM, float JBOIDCJHBGG);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> HACABEDGLFE([In] NativeArray<Entity> BKFKEKMLADJ, [In] NativeArray<float4> KLHKDBKDBBF);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct CJDEECKOKNK : BJILBADDCFN, IEquatable<CJDEECKOKNK>
{
	[Cpp2IlInjected.Token(Token = "0x17000207")]
	public int CIDCBGPMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000208")]
	public int OKKDIMNKADE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x30A5290", Offset = "0x30A3C90", VA = "0x1830A5290", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x30A52A0", Offset = "0x30A3CA0", VA = "0x1830A52A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x86CFDF0", Offset = "0x86CE7F0", VA = "0x1886CFDF0", Slot = "8")]
	public bool Equals(CJDEECKOKNK GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x86CFE40", Offset = "0x86CE840", VA = "0x1886CFE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct ELPGOECJBGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float FJBMIFMHGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public float3 BJGHDDIMDNJ;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MHEDEKKKCPN
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LHOENBPGPCA
{
	[Cpp2IlInjected.Token(Token = "0x17000209")]
	DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	ABKBPEENBLI OHHNAHEPGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	int DEEFCLLLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	int HMNHNNJECAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	int IAIJHHJCKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	int ILHHKBPMPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	int OMMFJICKKGH
	{
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BKGDNKOLHBO, NativeArray<RRObjectPrefabData>> HPLMNAKNKDN;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<BKGDNKOLHBO> LPGMELEMJMI;

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BKGDNKOLHBO OHLMAGCJODO();

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MHMFEMEFKPN LDCODGNJPLM(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	RRObjectPrefabData NLKBCLALLDM(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JJJDNMKJPAD(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ADKOMDJMHFH JLOFHMIMDHC(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool FNKPBCPCDIO(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool PKCJLIJJEHG(IJNJMBEMEOM EFILDLEHGNL, [Out] Transform HALOMIKDIAH);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IJNJMBEMEOM KKFOADNNIIP(ECANCCLIJHJ IJEKFHGIEHN);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool DJPLHMIGNPC(ECANCCLIJHJ IJEKFHGIEHN, [Out] IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	ECANCCLIJHJ NGACMEKFHEL(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	BKGDNKOLHBO KKFOADNNIIP(NativeArray<ECANCCLIJHJ> IJEKFHGIEHN, Allocator EIOOMONCLID, bool BFFNGKFHLFF = true);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool DNKEGBMEHFJ(NativeArray<CFKGPMGGIFM> EDLBDNECEEP, NativeArray<ECANCCLIJHJ> BCLFDBNCJHL, NativeArray<Entity> HMJDONDNMBA, OCCFPJFFJEE<BACKIKPNMDF> BCPJEDJGILN);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	ADKOMDJMHFH EGJELAEHIBH();

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	ADKOMDJMHFH FLEIPCMBBLE(RRObjectPrefabData LLPHCEGIIGN, [Optional] HCBPGOEJGIG NKKNHPEMCPC);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HGIKBGJJICF EAMPCKOKEFD();

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	GGCKKLHEAHJ CGENPGKPIGG();

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "27")]
	LGIFEELIJGE BOEDLNHCCNM(BMLHKENOJFK EIPOLKICKHD);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NLNEOOFHKLK(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void ECCEFGLKACH(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool JGMDNFIGLKF(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "31")]
	BKGDNKOLHBO HMLMLIOAOOB(BKGDNKOLHBO DIPMMNKOEAE, Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool JBKJHIIAKGB(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool ECFGAIPOPGH(IJNJMBEMEOM EFILDLEHGNL, ComponentTypes JJHLJPNHIGP);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IJNJMBEMEOM ECOFFJPDFCA(Transform HALOMIKDIAH);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class CPCLMJAFNEE
{
	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x86D0390", Offset = "0x86CED90", VA = "0x1886D0390")]
	internal static IJNJMBEMEOM EMGAOFNKGCD(this Entity BDOCGCBPBOC, LHOENBPGPCA BNOBLABHPIM)
	{
		return default(IJNJMBEMEOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x86D0850", Offset = "0x86CF250", VA = "0x1886D0850")]
	public static ADKOMDJMHFH NADFHEFENBC(this LHOENBPGPCA BNOBLABHPIM, LocalId EFILDLEHGNL)
	{
		return default(ADKOMDJMHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x86D05F0", Offset = "0x86CEFF0", VA = "0x1886D05F0")]
	public static IJNJMBEMEOM KKFOADNNIIP(this LHOENBPGPCA BNOBLABHPIM, LocalId EFILDLEHGNL)
	{
		return default(IJNJMBEMEOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x86D0860", Offset = "0x86CF260", VA = "0x1886D0860")]
	public static ECANCCLIJHJ NGACMEKFHEL(this LHOENBPGPCA BNOBLABHPIM, LocalId EFILDLEHGNL)
	{
		return default(ECANCCLIJHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x86D0440", Offset = "0x86CEE40", VA = "0x1886D0440")]
	public static HGIKBGJJICF ILFOMCJGDNE(this LHOENBPGPCA BNOBLABHPIM, RigidTransform FPHHDIIPPFE)
	{
		return default(HGIKBGJJICF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x86D06A0", Offset = "0x86CF0A0", VA = "0x1886D06A0")]
	public static LGIFEELIJGE KLEEAEADNPM(this LHOENBPGPCA BNOBLABHPIM, BMLHKENOJFK IJCDBPJLAGN, RigidTransform FPHHDIIPPFE)
	{
		return default(LGIFEELIJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x86D01E0", Offset = "0x86CEBE0", VA = "0x1886D01E0")]
	public static GGCKKLHEAHJ BNNICBBNNDL(this LHOENBPGPCA BNOBLABHPIM, RigidTransform FPHHDIIPPFE)
	{
		return default(GGCKKLHEAHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x86D08D0", Offset = "0x86CF2D0", VA = "0x1886D08D0")]
	private static void PMKDPADDKMK(ADKOMDJMHFH AEADIAMFFOA, RigidTransform FPHHDIIPPFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal interface LENGFHNBINH
{
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AFFMFFNAANM
{
	[Cpp2IlInjected.Token(Token = "0x17000210")]
	bool FDMIBBBNHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	IJNJMBEMEOM BMFINBDILOF
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	ADKOMDJMHFH NLBDAKFFCHK
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event EDDAFDDOAMM BFAEEFMHBBD;

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IJNJMBEMEOM MNIMLNICLFD(IJNJMBEMEOM JFBLIPHGGPK, IJNJMBEMEOM GEIAIAMNHAJ);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MDIFGAFGBDO(IJNJMBEMEOM JFBLIPHGGPK, IJNJMBEMEOM GEIAIAMNHAJ, [Out] IJNJMBEMEOM DKOJMMOJCDO);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GCNMKGACGOO();

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IPLLDKKIPLD();

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KCEELBJLPKA(IJNJMBEMEOM JFBLIPHGGPK);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HIDPCEPPBBJ(IJNJMBEMEOM JFBLIPHGGPK);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public delegate void EDDAFDDOAMM(ADKOMDJMHFH MHFECDMEMDM, ADKOMDJMHFH EKLJKALAAOO);
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class JIIBMKGEJCO
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x86DBE50", Offset = "0x86DA850", VA = "0x1886DBE50")]
	public static bool AKGIJKKBEBI(this AFFMFFNAANM OHKHOOOIEII, ADKOMDJMHFH JFBLIPHGGPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x86DBF20", Offset = "0x86DA920", VA = "0x1886DBF20")]
	public static bool OGDCFPFLDHM(this AFFMFFNAANM OHKHOOOIEII, IJNJMBEMEOM JFBLIPHGGPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x86DBEA0", Offset = "0x86DA8A0", VA = "0x1886DBEA0")]
	public static bool KJIACAPLJIG(this AFFMFFNAANM OHKHOOOIEII, IJNJMBEMEOM JFBLIPHGGPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AJOFDPKBOJN
{
	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHLGOHBGPKN(NativeList<RRObjectPrefabData> OBHAAPIALFB);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GLFJLMFDIJE
{
	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFJCNMLFAOA(ADKOMDJMHFH AEADIAMFFOA, OCLGKNFAEHE EDFBAIGMJKK, List<ADKOMDJMHFH> DOFMOFNBENO);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int KBJCKKAEHCI(ADKOMDJMHFH AEADIAMFFOA, OCLGKNFAEHE EDFBAIGMJKK);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NCMMLIBLFCO(ADKOMDJMHFH AEADIAMFFOA, List<ADKOMDJMHFH> DOFMOFNBENO);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DBABOODDEOL(ADKOMDJMHFH HJCIABFMGKM, ADKOMDJMHFH JFBLIPHGGPK, OCLGKNFAEHE EDFBAIGMJKK);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ADKOMDJMHFH BGNNMFGCHCD(ADKOMDJMHFH HJCIABFMGKM, int KABGMIEBEFC, OCLGKNFAEHE EDFBAIGMJKK);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEGCBJAGHOO(ADKOMDJMHFH HJCIABFMGKM, ADKOMDJMHFH JFBLIPHGGPK, OCLGKNFAEHE EDFBAIGMJKK);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OAEDJAPKFKC(ADKOMDJMHFH HJCIABFMGKM, ADKOMDJMHFH JFBLIPHGGPK, OCLGKNFAEHE EDFBAIGMJKK);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CDBCKJHJFEO(ADKOMDJMHFH HJCIABFMGKM, OCLGKNFAEHE EDFBAIGMJKK);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MFNHEPEPFAM(ADKOMDJMHFH HJCIABFMGKM, ADKOMDJMHFH JFBLIPHGGPK, OCLGKNFAEHE EDFBAIGMJKK);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FHJEDHCIJOA(Entity HJCIABFMGKM, Entity JFBLIPHGGPK, OCLGKNFAEHE EDFBAIGMJKK);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NHDAKCJKCKO(Entity HJCIABFMGKM, OCLGKNFAEHE EDFBAIGMJKK);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OPCOCODNMGC(ADKOMDJMHFH JFBLIPHGGPK, OCLGKNFAEHE EDFBAIGMJKK);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GJCCGPANIPI
{
	[Cpp2IlInjected.Token(Token = "0x17000213")]
	HMLLDAOMBPK FNNHEHEIIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBMBOKIFJPB JGMDECLMHBJ(HMLLDAOMBPK LDEJAMJEHAA);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HMLLDAOMBPK FBDGDLNNGIK();

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HMLLDAOMBPK AELKOLEOPOH();
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CLNJGFMGDLL
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JFDNIIALIFI(IJNJMBEMEOM JFBLIPHGGPK, [Out] IJNJMBEMEOM CDNHIBAAIAE);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GKJINKADGCK
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<IJNJMBEMEOM> JBOACLIAPCL;

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKPPACPIJDL(IJNJMBEMEOM KKGNPJDBLLP, bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLBOJLDFKIL(IJNJMBEMEOM KKGNPJDBLLP, bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFCJPCCHNAF(IJNJMBEMEOM KKGNPJDBLLP, int KMAFNKGMDCF);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FMNCINIGDKB
{
	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<IJNJMBEMEOM> EBLJJLAFFFA(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IJNJMBEMEOM PINMOGLMJHB(IJNJMBEMEOM EFILDLEHGNL, int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JFDNGOIMNLF(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MGPOLIAHKGI DKIDDPFJFHM(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDJLJOBCFNA(IJNJMBEMEOM EFILDLEHGNL, MGPOLIAHKGI PDCLAJMPOEB);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IJNJMBEMEOM KMKGDGEIKDB(IJNJMBEMEOM EFILDLEHGNL, [Optional] float3? KFJFDPLEJOD, [Optional] quaternion? AMHDLJKDJBK, [Optional] float3? NIAMAMNMMFM);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IJNJMBEMEOM NHGFGNHHEKM(IJNJMBEMEOM EFILDLEHGNL, int KABGMIEBEFC, [Optional] float3? KFJFDPLEJOD, [Optional] quaternion? AMHDLJKDJBK, [Optional] float3? NIAMAMNMMFM);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MBONPHPBDAA(IJNJMBEMEOM EFILDLEHGNL, int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FOGBBKGOJAC(IJNJMBEMEOM EFILDLEHGNL);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NAOAMLADCIM
{
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CCFGJOFLFAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMOEGILJOEB(IJNJMBEMEOM EFILDLEHGNL, ReadOnlySpan<TerrainGenerationLayer> HLOMMFNDEOF);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCMCFCIEMJL(IJNJMBEMEOM EFILDLEHGNL, ReadOnlySpan<DNEPMPBCOPJ> HLOMMFNDEOF);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MALMDEKCFPP
{
	[Cpp2IlInjected.Token(Token = "0x17000214")]
	bool CGDANHMDBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHMDOPKGKBB();

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGDGBKLOJJP();

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHKCBOHEBLC();

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KOGJPMAKLOD();

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KOJFHDCPDMI();

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NAMAJEFEMPM();

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HODDDECLGGG();

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IFOBACCIHEO();

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CENIILIOJEH();

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FINGOILIEMB();

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void APGNOBGEABB();

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CKIOAOFGHOD();
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ALCOIKKLOJF
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCJMDLKIBNO(IJNJMBEMEOM JFBLIPHGGPK, [Out] int HJCIABFMGKM);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBMMKADLOAK(IJNJMBEMEOM JFBLIPHGGPK, int HJCIABFMGKM);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIEJDNAGEPN(IJNJMBEMEOM JFBLIPHGGPK, bool CJNMCHOHDEL);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IAGAIFOHMEE(IJNJMBEMEOM JFBLIPHGGPK, float NDHJNIMJBKM, float BAKIKIHCDMK, float LJFMEJOOCNA);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MPBAEPJKLEA(IJNJMBEMEOM EFILDLEHGNL, [Out] float BAKIKIHCDMK, [Out] float LJFMEJOOCNA);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DPJOGCEIKFO(IJNJMBEMEOM JFBLIPHGGPK, float3 KFJFDPLEJOD, quaternion AMHDLJKDJBK);

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LGEJIAPCOEL(IJNJMBEMEOM JFBLIPHGGPK, [Out] float3 KFJFDPLEJOD, [Out] quaternion AMHDLJKDJBK);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LACGGNNMBJD(IJNJMBEMEOM JFBLIPHGGPK);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DOOPGKEPAJL
{
	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCHNPHKKLBP(Entity BDOCGCBPBOC, [In] float3 KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 JOOOPGOOCJK(Entity BDOCGCBPBOC);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CHLJMKPOGNB(Entity BDOCGCBPBOC, [In] quaternion KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion BKJFNGGDPCK(Entity BDOCGCBPBOC);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MHAFALDGNPG(Entity BDOCGCBPBOC, [In] float3 KFJFDPLEJOD, [In] quaternion AMHDLJKDJBK);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EACEOMIENMP(Entity BDOCGCBPBOC, [Out] RigidTransform PIPEBBLMJPM);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BHHCHMEEDFJ(Entity BDOCGCBPBOC, [In] float3 KFJFDPLEJOD, [In] quaternion AMHDLJKDJBK);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GCBCJKHBIBN(Entity BDOCGCBPBOC, [Out] float3 KFJFDPLEJOD, [Out] quaternion AMHDLJKDJBK);

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GCBCJKHBIBN(Entity BDOCGCBPBOC, [Out] RigidTransform PIPEBBLMJPM);

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OIJCCCMNDCL(Entity BDOCGCBPBOC, float KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float GPOGFHBGDMD(Entity BDOCGCBPBOC);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KKNJJMBAHND(Entity BDOCGCBPBOC, [In] float3 KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 NADIJAOIOBH(Entity BDOCGCBPBOC);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GLNFLONMLPL(Entity BDOCGCBPBOC, [In] quaternion KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion JOLNJMNAMAF(Entity BDOCGCBPBOC);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MCKDCGHEHBA(Entity BDOCGCBPBOC, float KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float NJHCLAFKCFA(Entity BDOCGCBPBOC);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BPAIOMKLEBI(Entity BDOCGCBPBOC, [Out] float4x4 GHDIHCHPDGJ);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NCKKHAFDJBK(Entity BDOCGCBPBOC, [In] float4x4 GHDIHCHPDGJ);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void AFNHKCPLBIF(Entity BDOCGCBPBOC);

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MGKHIJKEAOO(Entity BDOCGCBPBOC, Entity MMDPHPBLADN, Entity CCBBLDBOMGE);
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public static class BEOLGKGLIMN
{
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IFBEOOBNIFH
{
	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHNOPICJAPN(bool JCIGGBOEPEM);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FHKPKFNPBBM
{
	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFAKPMFFKBJ(IJNJMBEMEOM JGHKDIDNBJI, OCCFPJFFJEE<string> FOBGEFFAIOK);

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMBPCMOIFFN(IJNJMBEMEOM JGHKDIDNBJI, OCCFPJFFJEE<string> FOBGEFFAIOK);

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFLCANBKNAH(IJNJMBEMEOM JGHKDIDNBJI, OCCFPJFFJEE<string> FOBGEFFAIOK);

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CBEKEMPMHOF(IJNJMBEMEOM JGHKDIDNBJI, OCCFPJFFJEE<string> FOBGEFFAIOK);

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ANHFFDPHEJB(IJNJMBEMEOM JGHKDIDNBJI, OCCFPJFFJEE<string> FOBGEFFAIOK);

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OOEHILJFONE(IJNJMBEMEOM JGHKDIDNBJI, OCCFPJFFJEE<string> FOBGEFFAIOK);

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int IODMPPEFDDI(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int GBLCJMPAPEH(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int EPBGANHCJAE(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FMJHIDPKFMF<string> GKICKKBCBIJ(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DHJNGCOIBBC(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FMJHIDPKFMF<string> EOMDFFDDBFC(IJNJMBEMEOM JGHKDIDNBJI);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NGGNGHDLAIN(IJNJMBEMEOM JGHKDIDNBJI, string CKJPANLJIKJ);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LJNPKMNHPEH(string CKJPANLJIKJ, JCPKDLEFKEO FNOHAIBONLP);

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IJNJMBEMEOM LHLOGEBHPGA(string CKJPANLJIKJ);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GEHGKEJDNAE(string CKJPANLJIKJ, JCPKDLEFKEO FNOHAIBONLP);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EAEKCJCFAPH(IJNJMBEMEOM GEJHOOPBOAL, string CKJPANLJIKJ, JCPKDLEFKEO FNOHAIBONLP);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FMJHIDPKFMF<string> MHAEHJJLJGO();
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public static class EADOFIMOAPE
{
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DPNABAPMALC
{
	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World NDBEEIHNLNL(string EDGDGIEABIN = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World CDMHBMGKPGP(string EDGDGIEABIN = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World BKEGADEAPMG(string EDGDGIEABIN = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World OBGEPHHGPAA(string EDGDGIEABIN = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CAIBNPNLHFH
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	World LKLIDFBJBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000216")]
	World NHKLFOPEMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	EntityManager IKJPKHBBPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	bool FHLCJJBHDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase CIPHPKPOGMG(Type DGNODDPLLPC);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public static class MDIHEKMDAIO
{
	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x86DF340", Offset = "0x86DDD40", VA = "0x1886DF340")]
	public static ComponentSystemBase ELKBCOPABEC(this World DFECKIOHELC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x3E961F0", Offset = "0x3E94BF0", VA = "0x183E961F0")]
	public static T CIPHPKPOGMG<T>(this CAIBNPNLHFH OLOFMNLIKLH) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CAMMFPKMKEG
{
	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCAOBPHLFKN(NativeListAsync<Entity> DJOHMONMCHC);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJIIIGECHEB(ADDIOJCFEJA INJNDNDJHGE);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMPCHMCDKBL(NativeListAsync<Entity> DHNCEFDFMFG, bool BDJNEFCCEFH);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNEBIMKILIP();

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PDGGKEPEJDM(Entity FAIGKPPBFHA);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NCLPFAMPBNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOOGNHHKMGO(Collider MFGADJMKIKN, [Out] JDAMEJCJMCM NNDGIBLGFMD);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GMLBIPLEOJF
{
	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider DPJALLOLAHM(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject AEGDCEBLEKP(IJNJMBEMEOM DOAFPPDCCLD, GameObject IGAKMAMDNNB, Vector3 AIOBIOOBAEK, Quaternion ECCDGFAJEON);

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CNLKFPPKNFG(GameObject MFGADJMKIKN);

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider BOBFCICAEOE<TCollider>(GameObject GECHBHIOKEL) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AJAEFEJOKOE(Collider MFGADJMKIKN);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject MODOMCOAPJN<TCollider>(string IELIBBNCJAC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HOJGIOMMAHM JAKDJDLPGEE(IJNJMBEMEOM GANJNFMDAFI, IJNJMBEMEOM JAAPLMMJDIC, BMLHKENOJFK EDFCONHPHHO, float3 LIFNAMLCDLE, quaternion NNFPPBCNODC, float3 MLLKGODGLGG);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MOFNPHCNJIF(IJNJMBEMEOM EFILDLEHGNL, [Out] HOJGIOMMAHM MFGADJMKIKN);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NEKECFFOKGD(IJNJMBEMEOM EFILDLEHGNL, [Out] IJNJMBEMEOM FAIGKPPBFHA);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public enum HFJBGPEOJGN
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
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IFDKOPJOMNB
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public struct JEJDJGFJNPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int EDFCONHPHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GameObject IGAKMAMDNNB;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIGFGMEDEHP(IJNJMBEMEOM EFILDLEHGNL, IGEICALDFNG POEMPKIKMDP, bool IPAOHLPCBBA, FFAGMAGLFPM KKDLPNMBKNA);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJDDBOJGFIE(IJNJMBEMEOM EFILDLEHGNL, IGEICALDFNG POEMPKIKMDP, bool IPAOHLPCBBA, bool APODMLIOINB, bool NJOONCFDIDL);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NOPKDNOJKDO LDPNGMIDLIA(IJNJMBEMEOM FAIGKPPBFHA, List<IJNJMBEMEOM> JKLFEBCDAIA);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HOJGIOMMAHM JOOFHGCLJFB(GameObject ACNJLLLIMAM, GameObject JDJKHIALEDM);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHDIAAHFDIN(GameObject ACNJLLLIMAM, List<GameObject> PMLFOKOJPEE);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JJAJGPJFDOA(GameObject JDJKHIALEDM);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T BOBFCICAEOE<T>(GameObject GECHBHIOKEL) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AJAEFEJOKOE(Collider MFGADJMKIKN);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject EEHNJHCIDJN<T>(string IELIBBNCJAC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IHOGKDMIDPE(Collider MFGADJMKIKN, [Out] IJNJMBEMEOM HJCIABFMGKM);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AFGMFLLMJDE(IJNJMBEMEOM EFILDLEHGNL, [Out] JDAMEJCJMCM NNDGIBLGFMD);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<HFJBGPEOJGN> DOFCOIMKHFB(Allocator EIOOMONCLID = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] GMBKHPHEKLI();
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ANIJHAHLIEC
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBDIIGPKEMJ(IJNJMBEMEOM EFILDLEHGNL, IJNJMBEMEOM KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOHEKDOPJMN(IJNJMBEMEOM EFILDLEHGNL, IJNJMBEMEOM KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CPFIFPCDGBG(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IJNJMBEMEOM HNAFJFOBHHG(IJNJMBEMEOM EFILDLEHGNL, int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BKGDNKOLHBO NGDGHMPDNDC(IJNJMBEMEOM EFILDLEHGNL, Allocator EIOOMONCLID = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMCFJEBPGHB(IJNJMBEMEOM EFILDLEHGNL, object MFKHKDDANII, IJNJMBEMEOM KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DINJGKIGBAP(IJNJMBEMEOM EFILDLEHGNL, object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BOENGOGBENF(IJNJMBEMEOM EFILDLEHGNL, [Out] IJNJMBEMEOM KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GNLBDIEFFLP(IJNJMBEMEOM EFILDLEHGNL, float3 KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IICPGBHNGFA(IJNJMBEMEOM EFILDLEHGNL, [Out] float3 KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void POMMKOOFEHB(IJNJMBEMEOM EFILDLEHGNL, float3 KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PKMFMLNNDCC(IJNJMBEMEOM EFILDLEHGNL, [Out] float3 KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AACFGCEIAAP(IJNJMBEMEOM EFILDLEHGNL, (Quaternion rot, Vector3 moments) FPHHKNIAPKM);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool KCLDNMENMFO(IJNJMBEMEOM EFILDLEHGNL, [Out] quaternion FLGMEAGNLEE, [Out] float3 ECFFOLOMNJO);

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FKFIMGDKKLM(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 EKJMKGCMIDJ(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 OHNLPBFNOIH(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OKIBOOACELH(IJNJMBEMEOM EFILDLEHGNL, float3 KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NDPIHGEFCFM(IJNJMBEMEOM EFILDLEHGNL, float3 KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float EGPNJGKIOAL(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float FNGNHPOEJPO(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IKPHBBNPLFD(IJNJMBEMEOM EFILDLEHGNL, float KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NIEFPLEDGBB(IJNJMBEMEOM EFILDLEHGNL, float KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode DGLOFBGAPAH(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AKGGIMBBOCB(IJNJMBEMEOM EFILDLEHGNL, CollisionDetectionMode KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "25")]
	FMHNBNKGEEA GGBMIHGLGKC(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LMOFCJKGLCP(IJNJMBEMEOM EFILDLEHGNL, FMHNBNKGEEA KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CGGOCABNCPM(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HPPOBEOCNBH(IJNJMBEMEOM EFILDLEHGNL, bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "29")]
	IJNJMBEMEOM NCBPFDNEFID(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MKEMLEHEOCH(IJNJMBEMEOM EFILDLEHGNL, IJNJMBEMEOM KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IJNJMBEMEOM GICCPKEANJD(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void IEBALGDGBAK(IJNJMBEMEOM EFILDLEHGNL, IJNJMBEMEOM KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	ILMFIJFBGOM KPLBGJDNOIK(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void IJBLHAOJFDI(IJNJMBEMEOM EFILDLEHGNL, ILMFIJFBGOM FFDCMGDPJAK);

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool EAJILDBJCMB(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FCBPJOHLPLL(IJNJMBEMEOM EFILDLEHGNL, bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool DNNDKHEAJIE(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void AFBOJHIFNKC(IJNJMBEMEOM EFILDLEHGNL, bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints PCIEPGPCEJO(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void INCDFKIDMNB(IJNJMBEMEOM EFILDLEHGNL, RigidbodyConstraints KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float FCNMJAEOAJH(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void HDNPDGGLJNN(IJNJMBEMEOM EFILDLEHGNL, float KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float KABIFDELIPJ(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void ENJNOMOJGLB(IJNJMBEMEOM EFILDLEHGNL, float KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool GNANKOHKIKO(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void IIHFAEFFICC(IJNJMBEMEOM EFILDLEHGNL, bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool JGNBMGEENLJ(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void PMJEBIPMBAJ(IJNJMBEMEOM EFILDLEHGNL, bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void MCDBGPPACHO(IJNJMBEMEOM EFILDLEHGNL, int KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(Slot = "50")]
	DNNEGEPPCEJ NIGJJJHCFJJ(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void PHMDDLCACFN(IJNJMBEMEOM EFILDLEHGNL, DNNEGEPPCEJ KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(Slot = "52")]
	CGLIKLHAHPB DBGMJFNKNOI(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void FHFILAPPENH(IJNJMBEMEOM EFILDLEHGNL, CGLIKLHAHPB KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float IDMHBPJLPJN(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void LECAHIONNOP(IJNJMBEMEOM EFILDLEHGNL, float KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void GEBKOBJCEON(IJNJMBEMEOM EFILDLEHGNL, object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void NPNAHHIGCHK(IJNJMBEMEOM EFILDLEHGNL, object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool OGPOAAJCNMA(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void GOKLHLEHHIE(IJNJMBEMEOM EFILDLEHGNL, object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void GBEPJGHJPCP(IJNJMBEMEOM EFILDLEHGNL, object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool PDKEFAMLKOA(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool MEHNCLPCLML(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody MDMDNHJDFAK(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void ENFPINCNCHA(IJNJMBEMEOM EFILDLEHGNL, Rigidbody CAOCACBOIHN);

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void FBKIHFOMNCB(IJNJMBEMEOM EFILDLEHGNL, object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void BLEKJKOOFIB(IJNJMBEMEOM EFILDLEHGNL, object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool NBHKIIOPDMH(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void AKLAKODMPMC(IJNJMBEMEOM EFILDLEHGNL, float3 GMOGCJLCJBF);

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void LLLFBBFPBFI(IJNJMBEMEOM EFILDLEHGNL, float3 LIDKIKJAOJJ);

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool BEDPOPLHFDI(IJNJMBEMEOM EFILDLEHGNL, [Out] float3 GMOGCJLCJBF);

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool AOIIOHCKKLL(IJNJMBEMEOM EFILDLEHGNL, [Out] float3 LIDKIKJAOJJ);

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool DPDLMKLLGFF(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void OHDBBFGFAJD(IJNJMBEMEOM EFILDLEHGNL, object MFKHKDDANII, bool JMGOCMABGNJ);

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void BPFCANGLFOH(IJNJMBEMEOM EFILDLEHGNL, bool LOJPPICKKGP);

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void EHGCCGKHCIF(IJNJMBEMEOM EFILDLEHGNL);

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool CICNKJJDLHL(IJNJMBEMEOM EFILDLEHGNL);
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EBNKLAGENKH
{
	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFGJJNLGJNG(Entity LEKFPCJJMID);

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLDCJBALMJJ(Entity LEKFPCJJMID);

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FAFCGCNMOBM(Entity LEKFPCJJMID);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KKKDMENDHIF
{
	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LELNKBNMEAI(IJNJMBEMEOM JFBLIPHGGPK, bool GKCMMGEKMLJ);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public delegate void PFELOACIKGH(NLFPEOFFJNH FOMPNPCNGHF);
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public readonly ref struct NLFPEOFFJNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly BKGDNKOLHBO NEIMDELFEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly NativeArray<byte> IMGODHPFAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly NativeArray<byte> ELKKBFOGLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly CEEFNPBAPME ELEBIIGLBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly int OCCPPGKIDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly Type DMAMNNDEICC;

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public BKGDNKOLHBO OKKABIGCFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x46888F0", Offset = "0x46872F0", VA = "0x1846888F0")]
		get
		{
			return default(BKGDNKOLHBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public int EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x86E24C0", Offset = "0x86E0EC0", VA = "0x1886E24C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public CEEFNPBAPME PPFHHPOBDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
		get
		{
			return default(CEEFNPBAPME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x86E24E0", Offset = "0x86E0EE0", VA = "0x1886E24E0")]
	public NLFPEOFFJNH(BKGDNKOLHBO NEIMDELFEDH, NativeArray<byte> IMGODHPFAEJ, NativeArray<byte> ELKKBFOGLKF, CEEFNPBAPME ELEBIIGLBPL, int OCCPPGKIDDD, Type DMAMNNDEICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F330", Offset = "0x3F0DD30", VA = "0x183F0F330")]
	public NativeArray<T> JACPFIJOMLE<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F370", Offset = "0x3F0DD70", VA = "0x183F0F370")]
	public NativeArray<T> ODGAJKDNIPF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F240", Offset = "0x3F0DC40", VA = "0x183F0F240")]
	public (BKGDNKOLHBO, NativeArray<T>, NativeArray<T>) GFFPJLNAMHB<T>() where T : struct
	{
		return default((BKGDNKOLHBO, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x86E2490", Offset = "0x86E0E90", VA = "0x1886E2490")]
	public MPPNIBENDEG CHKMGABFFDI()
	{
		return default(MPPNIBENDEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface OKJINCIPFLG
{
	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	string FPFPNLFAKOH
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	OKJINCIPFLG KKKFEAGIKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	IEnumerable<OKJINCIPFLG> OJACKCPCPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IAFLONPNJKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	OKJINCIPFLG ECLBHMBMPML
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000220")]
	NativeArray<CEEFNPBAPME> BOMMBDOBFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DJOEFGHBDGA(CEEFNPBAPME ELEBIIGLBPL, [Out] OKJINCIPFLG CAEHNKCPHDD);

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NFFNLBFBLBL(CEEFNPBAPME ELEBIIGLBPL, PFELOACIKGH FCCIGOAGOON);

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JJGBLGDOBGN(CEEFNPBAPME ELEBIIGLBPL, PFELOACIKGH FCCIGOAGOON);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FBINECLMPCK
{
	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFFNLBFBLBL(CEEFNPBAPME ELEBIIGLBPL, PFELOACIKGH FCCIGOAGOON);

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJGBLGDOBGN(CEEFNPBAPME ELEBIIGLBPL, PFELOACIKGH FCCIGOAGOON);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class DPEBBBLICOB
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HDGDPOGCGDG
{
	[Cpp2IlInjected.Token(Token = "0x17000221")]
	bool GCPLIJOKAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	IDJBFONAFGB MKDMPFDCOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FCNGNLPIDKO(MBMBOKIFJPB IJEKFHGIEHN, bool BNDLEJHFJCP);

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GHAPJHGCNIC(ECANCCLIJHJ IJEKFHGIEHN, CEEFNPBAPME ELEBIIGLBPL);

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CLAEGEGELPO(NativeArray<ECANCCLIJHJ> MDDNJEGACAM);
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class EEHJDMIBLFK
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public readonly ref struct MPPNIBENDEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly NLFPEOFFJNH BLPDDGCLNPE;

	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public BKGDNKOLHBO OKKABIGCFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x46888F0", Offset = "0x46872F0", VA = "0x1846888F0")]
		get
		{
			return default(BKGDNKOLHBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x86DFA20", Offset = "0x86DE420", VA = "0x1886DFA20")]
	public MPPNIBENDEG(NLFPEOFFJNH BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x86DF7C0", Offset = "0x86DE1C0", VA = "0x1886DF7C0")]
	public BKGDNKOLHBO JACPFIJOMLE()
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x86DF8F0", Offset = "0x86DE2F0", VA = "0x1886DF8F0")]
	public BKGDNKOLHBO ODGAJKDNIPF()
	{
		return default(BKGDNKOLHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x86DF4D0", Offset = "0x86DDED0", VA = "0x1886DF4D0")]
	public (BKGDNKOLHBO, BKGDNKOLHBO, BKGDNKOLHBO) GFFPJLNAMHB()
	{
		return default((BKGDNKOLHBO, BKGDNKOLHBO, BKGDNKOLHBO));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class ELPCFAPGPPE
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public readonly struct IDJBFONAFGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly NativeBitArray HPPEINJMNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly NativeParallelHashMap<ECANCCLIJHJ, int> HJGPLFPDFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly NativeParallelHashSet<MBMBOKIFJPB> AMNKPILPFNL;

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public bool IIGIJIPCCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x86D7480", Offset = "0x86D5E80", VA = "0x1886D7480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public bool GCPLIJOKAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x86D74A0", Offset = "0x86D5EA0", VA = "0x1886D74A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x62EC380", Offset = "0x62EAD80", VA = "0x1862EC380")]
	public IDJBFONAFGB(NativeBitArray HPPEINJMNGN, NativeParallelHashMap<ECANCCLIJHJ, int> HJGPLFPDFBH, NativeParallelHashSet<MBMBOKIFJPB> AMNKPILPFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x86D74D0", Offset = "0x86D5ED0", VA = "0x1886D74D0")]
	public bool GHAPJHGCNIC(ECANCCLIJHJ IJEKFHGIEHN, CEEFNPBAPME ELEBIIGLBPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KOKFIFDKFHI
{
	[Cpp2IlInjected.Token(Token = "0x17000226")]
	KBICEEBHCID OCMAGODFDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OHFHIMLKNEK
{
	[Cpp2IlInjected.Token(Token = "0x17000227")]
	int NKOPNNOIDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	int KDEJFHLHPBH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLICIHFNBLM(IJNJMBEMEOM EFILDLEHGNL, CFIMNPCFKGP KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CFEOEFPPCFO FGNPGGONDJL();

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CFEOEFPPCFO APBFEKHLMJM();
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IMEHGFJJMAN
{
	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLIBEFPKNFK(World DFECKIOHELC);

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLMPHDBBLDF(World DFECKIOHELC);

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase BABLLINBAPD(World DFECKIOHELC);

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GPNDMPFGHGF(World DFECKIOHELC);

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGPOFPFONOB(World DFECKIOHELC);

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MNHJNOCOGJL(World DFECKIOHELC);

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OLEHHODEHGG(World DFECKIOHELC);

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> KPPPCPFOFFG();
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EHMLGMHGPGO
{
	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOCDODBFMCK(IJNJMBEMEOM KKGNPJDBLLP, bool KMAFNKGMDCF);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public readonly struct DCHPDLKEDFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly IEnumerable<CEPDIOPOHJK> FOEBBIIMICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly IReadOnlyList<GameObject> FOCCMIJOEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly IReadOnlyList<int> CJKJBEBFCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly IReadOnlyList<(ECANCCLIJHJ, ECANCCLIJHJ)> GJGECHHPEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly int FOFMLIIELBH;
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct CBGFCAADJAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public InventionIdData NMAIBBDGPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public InventionInstanceIdData OGFLDFLEODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public bool NFLKNCGGCGG;

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x86CF730", Offset = "0x86CE130", VA = "0x1886CF730")]
	public CBGFCAADJAD(long NMAIBBDGPCD, Guid OGFLDFLEODK, bool NFLKNCGGCGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[ServiceLifetime(Lifetime.Application)]
public interface JNHMOICCOJK
{
	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NOIILBLDIEO JBEINPFPKOE(IFCMBFOMDFH BPJLLEFEPPF, int CPJFOBILFKL = 0, bool MOHDLDJCHCP = false);

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BKCGCMOGPAC ODBDIFNBBEM(IFCMBFOMDFH BPJLLEFEPPF, IJNJMBEMEOM AEMEEJKFKNN, [In] UniformTRS AOHNHIBJALE, ENHNPAODHKP PIPGAOCAIIH, [Optional] CBGFCAADJAD JMJABHJODGD, bool GMKLJFGMIFC = true, bool HGABEHGJPBO = false, bool MOHDLDJCHCP = false, bool EAGAAEGGGBE = false);

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ENONOMOKKCA DNDKIDPJKMC();

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ENONOMOKKCA BIENCOMEPEH(BKGDNKOLHBO JAPKGPLEDNP, [In] UniformTRS JFEKBIMAPPC, [Optional] ENHNPAODHKP IIJCDLJOKLG);

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OOJAMJHLECM(IJNJMBEMEOM CGNHKMFHDPP);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JPLBNJAKGMC(IJNJMBEMEOM CGNHKMFHDPP, [Out] Exception FGDPOGPHENJ);

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<ECANCCLIJHJ> AOBCFILGKAP(IJNJMBEMEOM CGNHKMFHDPP, Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<ECANCCLIJHJ> CCNOPOIOPHL(IJNJMBEMEOM CGNHKMFHDPP, Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BKGDNKOLHBO AJJMADNEALA(IJNJMBEMEOM CGNHKMFHDPP, Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BKGDNKOLHBO JHINIFOIKKC(IJNJMBEMEOM CGNHKMFHDPP, Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BKGDNKOLHBO BGCAPBKIIOJ(IJNJMBEMEOM CGNHKMFHDPP, Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> OLKCOGAMNFP(IJNJMBEMEOM CGNHKMFHDPP, Allocator EIOOMONCLID);

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ENGOBAHFHFA(IJNJMBEMEOM CGNHKMFHDPP);

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int MFMKNAJGKJL(IJNJMBEMEOM CGNHKMFHDPP, int MHMCOJIKNCI);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[ServiceLifetime(Lifetime.Application)]
public interface BFLHFHGIDIE
{
	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0xF99FE0", Offset = "0xF989E0", VA = "0x180F99FE0", Slot = "0")]
	bool AJEKELLDDGL(object PPGGMEFFGDH, GKNNEPJOJPO IEDCIMCKGGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public static class CFHBFDKPPMJ
{
	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x86CFC80", Offset = "0x86CE680", VA = "0x1886CFC80")]
	public static bool AJEKELLDDGL(this BFLHFHGIDIE DGDHAMECAIH, object PPGGMEFFGDH, [Out] GKNNEPJOJPO IEDCIMCKGGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public enum BMENANMCCPD : byte
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
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface GKNNEPJOJPO
{
	[Cpp2IlInjected.Token(Token = "0x17000229")]
	HFHEMOKAFOI EMHLKEMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	AFPDBFALGFB HFGLGEFIHFD
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	bool CPPNOPIMKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	bool CNLNBDJKOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object AKOLJKPKNKL();

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DEEPOPOLIPJ([Out] AFPDBFALGFB MGCNNJFGDGN);

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x1106150", Offset = "0x1104B50", VA = "0x181106150", Slot = "6")]
	(AFPDBFALGFB, object) KAHNOFPGFHH()
	{
		return default((AFPDBFALGFB, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "7")]
	(ECANCCLIJHJ, AFPDBFALGFB) DLLHPPIBJJP()
	{
		return default((ECANCCLIJHJ, AFPDBFALGFB));
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "8")]
	CLBJGHNHEJF<(ECANCCLIJHJ, AFPDBFALGFB)> LMLKFNIOLJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x1106150", Offset = "0x1104B50", VA = "0x181106150", Slot = "9")]
	(LPMIJHKPLOD, byte[]) PFIEMBBBKHB()
	{
		return default((LPMIJHKPLOD, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x1106150", Offset = "0x1104B50", VA = "0x181106150", Slot = "10")]
	(NDMAOCGGLIO, byte[]) LIMJJJOMMGA()
	{
		return default((NDMAOCGGLIO, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x1106150", Offset = "0x1104B50", VA = "0x181106150", Slot = "11")]
	T JDDBDJNKGAN<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public static class FCHLNEHNGHJ
{
	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x86D2570", Offset = "0x86D0F70", VA = "0x1886D2570")]
	public static bool CJCLJCJLENL(this GKNNEPJOJPO DHNILGMCEHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface FNGCNJFHEAI : CLBJGHNHEJF<OFEHKIPCPMO>
{
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[DefaultMember("Item")]
public interface CLBJGHNHEJF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	T PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	int EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public enum HFHEMOKAFOI : byte
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
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public enum LPMIJHKPLOD : uint
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
	SnapshotClear = 1129337683u,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	RequestNetworkTransformInitialization = 1380865097u
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class IGOAHKOMMAC
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x86D7DE0", Offset = "0x86D67E0", VA = "0x1886D7DE0")]
	public static ECANCCLIJHJ FHJCGCPNHJA(this LGMPDHFOEPH BLPDDGCLNPE)
	{
		return default(ECANCCLIJHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x86D8310", Offset = "0x86D6D10", VA = "0x1886D8310")]
	public static ECANCCLIJHJ LALPKHCKDFA([In] this LGMPDHFOEPH BLPDDGCLNPE)
	{
		return default(ECANCCLIJHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x8650760", Offset = "0x864F160", VA = "0x188650760")]
	public static ECANCCLIJHJ ENAANLHAMEN(this LGMPDHFOEPH BLPDDGCLNPE)
	{
		return default(ECANCCLIJHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x8650760", Offset = "0x864F160", VA = "0x188650760")]
	public static ViewId JBFNFFFBKKM(this LGMPDHFOEPH BLPDDGCLNPE)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x86D8140", Offset = "0x86D6B40", VA = "0x1886D8140")]
	public static FixedString64Bytes HFDAAKKMHOO(this MBMBOKIFJPB NMAIBBDGPCD)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x86D7E20", Offset = "0x86D6820", VA = "0x1886D7E20")]
	public static FixedString64Bytes GMKPHEAFJCE(this ECANCCLIJHJ NMAIBBDGPCD)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x86D80B0", Offset = "0x86D6AB0", VA = "0x1886D80B0")]
	public static FixedString32Bytes HFDAAKKMHOO(this Entity BDOCGCBPBOC)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EIFDFPBBAFJ : PHHCOHEICGC
{
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public enum KCDNMMELCEM
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	End,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CODMDJKLCKF
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<object> LCBPDLJHNAK;

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "2")]
	void PLIGPGJHOEO(object PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "3")]
	void PIMOJCAJNJB(NDMAOCGGLIO PBOCDEMNFLD, ReadOnlySpan<byte> IHHGLEDNONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	void KCHMCDAOJNB(LPMIJHKPLOD DGNODDPLLPC, ReadOnlySpan<byte> IHHGLEDNONA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PCBHAENIKLH
{
	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NDMAOCGGLIO JJIIPBCHAGP(ReadOnlySpan<byte> IHHGLEDNONA);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CGKJIOJBFKF
{
	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGCHHECHBMH(NDMAOCGGLIO HPFHOBCPNEF, ReadOnlySpan<byte> IHHGLEDNONA);

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIIPHBHEFIC(ReadOnlySpan<NDMAOCGGLIO> NPBJICOIAOC);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct HPCHMANLOCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public NDMAOCGGLIO PBOCDEMNFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public ReadOnlyMemory<byte> IHHGLEDNONA;
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public struct NDMAOCGGLIO
{
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static NDMAOCGGLIO HKPHCMJMKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public MBMBOKIFJPB FFECJBDKDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public int LFOAPGDJKDB;

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public static MBMBOKIFJPB IBDLLCEAFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x86DFD10", Offset = "0x86DE710", VA = "0x1886DFD10")]
		get
		{
			return default(MBMBOKIFJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x56EEB10", Offset = "0x56ED510", VA = "0x1856EEB10")]
	public NDMAOCGGLIO(MBMBOKIFJPB FFECJBDKDKI, int LFOAPGDJKDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x86DFEC0", Offset = "0x86DE8C0", VA = "0x1886DFEC0")]
	public static bool NOPNAEDOCOI([In] NDMAOCGGLIO CFAKKPGMPGD, [In] NDMAOCGGLIO KMGOFHJBCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x86DFD60", Offset = "0x86DE760", VA = "0x1886DFD60", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x86DFE60", Offset = "0x86DE860", VA = "0x1886DFE60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x86DFF60", Offset = "0x86DE960", VA = "0x1886DFF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x86DFF50", Offset = "0x86DE950", VA = "0x1886DFF50")]
	public void ODNAGOAKDMJ([Out] MBMBOKIFJPB KAJNACGJJJD, [Out] int LFOAPGDJKDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public static class PBOJIKEGGFI
{
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public struct CEPDIOPOHJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public Guid OCONCDFGCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public string PKKNHBLDAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public Vector3 KFJFDPLEJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Quaternion AMHDLJKDJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public Vector3 NIAMAMNMMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public int GJFDOPCHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public HCBPGOEJGIG PDCLAJMPOEB;

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x86CFB60", Offset = "0x86CE560", VA = "0x1886CFB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public enum CGCKLLIKLEE
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public static class NKLCPEFDCKN
{
	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x86E2450", Offset = "0x86E0E50", VA = "0x1886E2450")]
	public static bool EKEDKJAPCOD(this CGCKLLIKLEE DGNODDPLLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x86E2470", Offset = "0x86E0E70", VA = "0x1886E2470")]
	public static bool FDCJLEFCODJ(this CGCKLLIKLEE DGNODDPLLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x86E2480", Offset = "0x86E0E80", VA = "0x1886E2480")]
	public static bool FEAFCLCLFEK(this CGCKLLIKLEE DGNODDPLLPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[Flags]
public enum GOLFMCJOOEB
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public interface ENHNPAODHKP
{
	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GBJMDGGEICG([In] Guid KGCMICBGABJ, [Out] Guid MPGFNEFLINC);
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[Flags]
public enum GDCJGCBCALO
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public interface ENONOMOKKCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000230")]
	KDKGGFBHJIC DALFABFMPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString MELILHJMILK();
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public enum ODDONIIFCIL
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct BNHEHOEHNMF : ISystemStateComponentData, IComponentData, IEquatable<BNHEHOEHNMF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public float3 AFLPBMPBNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public float3 NMILFLHONPE;

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x86CF6B0", Offset = "0x86CE0B0", VA = "0x1886CF6B0", Slot = "4")]
	public bool Equals(BNHEHOEHNMF GOCNHGEHNFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KNLFMFEEKPA
{
	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<IJNJMBEMEOM> NJBPKDMDEAM(IJNJMBEMEOM EANCNLNFGFP);

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BBPNMDODOAO(IJNJMBEMEOM JGDIPICIFDD, [Out] IJNJMBEMEOM DDMGBBCDBJF);
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GKBIAFNBNHB
{
	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOJFBMPAEBL(long ELFJEIAPLLG);

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHJBLLCNJJ(NativeParallelHashSet<long> CFKFDDCJAJG);

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBAALMOJJAH(World DFECKIOHELC, NativeParallelHashMap<Guid, long> LHPBEKCGELI);

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FHFFIPMDCOF(ECANCCLIJHJ IJEKFHGIEHN);

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DOBEEFFBJLM(ECANCCLIJHJ IJEKFHGIEHN, [Out] Guid CAGFJBAKJHG, [Out] long ELFJEIAPLLG);

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GHLHIMINDKB(ECANCCLIJHJ IJEKFHGIEHN, Guid CAGFJBAKJHG, long ELFJEIAPLLG);

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FBDEGDJKGCP(Guid CAGFJBAKJHG);

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LOJMIONIEIL(Guid CAGFJBAKJHG, [Out] int LFPALICJKDA, [Out] int PKPADLAACNL);

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EABBBEJMODF(Guid CAGFJBAKJHG, int LFPALICJKDA, int PKPADLAACNL);

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CBPHHHOHCMG(Guid CAGFJBAKJHG);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000107")]
public class HOMBPOKEPHI
{
	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HOMBPOKEPHI()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
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
