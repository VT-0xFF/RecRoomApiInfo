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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x777C6F0", Offset = "0x777B8F0", VA = "0x18777C6F0", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ODOLEDBJAEI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x77818B0", Offset = "0x7780AB0", VA = "0x1877818B0")]
	public static void IHAMBJCPIOP(this Rigidbody KNCAMCKBICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7781780", Offset = "0x7780980", VA = "0x187781780")]
	public static void IHAMBJCPIOP(this Rigidbody KNCAMCKBICI, Vector3 ILOLANOEDPC, Quaternion LLJKIMDELJD, Vector3 AMPBKGBFLAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct AGCGHKEMDON : IReadOnlyList<EOFNBBMGHCB>, IEnumerable<EOFNBBMGHCB>, IEnumerable, IReadOnlyCollection<EOFNBBMGHCB>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct IIDGHDOMLHC : IEnumerator<EOFNBBMGHCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly NFIPPAIECID BOCHMICIIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator IAHCPHAJMBH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public EOFNBBMGHCB PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x777A320", Offset = "0x7779520", VA = "0x18777A320", Slot = "4")]
			get
			{
				return default(EOFNBBMGHCB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x777A2D0", Offset = "0x77794D0", VA = "0x18777A2D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C2A0", Offset = "0x4B1B4A0", VA = "0x184B1C2A0")]
		public IIDGHDOMLHC(NFIPPAIECID BOCHMICIIMO, NativeArray<LocalId>.Enumerator IAHCPHAJMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x777A210", Offset = "0x7779410", VA = "0x18777A210", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x777A250", Offset = "0x7779450", VA = "0x18777A250", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x777A290", Offset = "0x7779490", VA = "0x18777A290", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly JJFMKOLCMMG PBLKLOBKEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> JBPFPBKHHLE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EOFNBBMGHCB EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x776EDD0", Offset = "0x776DFD0", VA = "0x18776EDD0", Slot = "4")]
		get
		{
			return default(EOFNBBMGHCB);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x776E1C0", Offset = "0x776D3C0", VA = "0x18776E1C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int LDBAKIENMGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x776E490", Offset = "0x776D690", VA = "0x18776E490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NLGAJPMMPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x776E220", Offset = "0x776D420", VA = "0x18776E220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> CNEOAKFFHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BE33E0", Offset = "0x2BE25E0", VA = "0x182BE33E0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> ECBOGDOKJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x776E390", Offset = "0x776D590", VA = "0x18776E390")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x776EB40", Offset = "0x776DD40", VA = "0x18776EB40")]
	public AGCGHKEMDON(int ECPBKIMJCKH, NFIPPAIECID BOCHMICIIMO, Allocator JNKCCGKBKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x776ED50", Offset = "0x776DF50", VA = "0x18776ED50")]
	public AGCGHKEMDON(JJFMKOLCMMG PBLKLOBKEHJ, NativeArray<LocalId> JBPFPBKHHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x776ED60", Offset = "0x776DF60", VA = "0x18776ED60")]
	public AGCGHKEMDON(JJFMKOLCMMG PBLKLOBKEHJ, NativeArray<Entity> JBPFPBKHHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x776EA40", Offset = "0x776DC40", VA = "0x18776EA40")]
	internal AGCGHKEMDON(NFIPPAIECID BOCHMICIIMO, NativeArray<Entity> DNOHLBIMBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x776EAD0", Offset = "0x776DCD0", VA = "0x18776EAD0")]
	internal AGCGHKEMDON(NFIPPAIECID BOCHMICIIMO, NativeArray<LocalId> JBPFPBKHHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x776EBF0", Offset = "0x776DDF0", VA = "0x18776EBF0")]
	public AGCGHKEMDON(NFIPPAIECID BOCHMICIIMO, int EEBDBIBAAFF, Allocator JNKCCGKBKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x776ECA0", Offset = "0x776DEA0", VA = "0x18776ECA0")]
	public AGCGHKEMDON(AGCGHKEMDON OAMCCILJEMK, Allocator JNKCCGKBKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x776E4E0", Offset = "0x776D6E0", VA = "0x18776E4E0")]
	public void MPPBMNJFIOP(List<EOFNBBMGHCB> KBPAKCCMOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x776E300", Offset = "0x776D500", VA = "0x18776E300")]
	public void DKOPADAGEEM(int KOOLKCPAFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x776E3F0", Offset = "0x776D5F0", VA = "0x18776E3F0")]
	public AGCGHKEMDON KFABHKFANJO(Allocator JNKCCGKBKPB)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x776E810", Offset = "0x776DA10", VA = "0x18776E810")]
	public Span<EOFNBBMGHCB> PONEJDICIKE()
	{
		return default(Span<EOFNBBMGHCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x776E260", Offset = "0x776D460", VA = "0x18776E260")]
	public AGCGHKEMDON DJIDEINKKHO(int MGKDKECOLOJ, int EEBDBIBAAFF)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x776E350", Offset = "0x776D550", VA = "0x18776E350", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x776E750", Offset = "0x776D950", VA = "0x18776E750")]
	public IIDGHDOMLHC PACLDABBHPO()
	{
		return default(IIDGHDOMLHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x776E960", Offset = "0x776DB60", VA = "0x18776E960", Slot = "6")]
	private IEnumerator<EOFNBBMGHCB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x776E9D0", Offset = "0x776DBD0", VA = "0x18776E9D0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HINCEMOGJKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x34ABCA0", Offset = "0x34AAEA0", VA = "0x1834ABCA0")]
	public static AIPBCFHHAOO<T> KECFNGIHMCP<T>(this AGCGHKEMDON HDPIMFNJLMN) where T : Component
	{
		return default(AIPBCFHHAOO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct DHPJJEOFEFK : IList<EOFNBBMGHCB>, ICollection<EOFNBBMGHCB>, IEnumerable<EOFNBBMGHCB>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct IOENAKDPNEP : IEnumerator<EOFNBBMGHCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly NFIPPAIECID BOCHMICIIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator IAHCPHAJMBH;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public EOFNBBMGHCB PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x777A500", Offset = "0x7779700", VA = "0x18777A500", Slot = "4")]
			get
			{
				return default(EOFNBBMGHCB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x777A4B0", Offset = "0x77796B0", VA = "0x18777A4B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C2A0", Offset = "0x4B1B4A0", VA = "0x184B1C2A0")]
		public IOENAKDPNEP(NFIPPAIECID BOCHMICIIMO, NativeArray<LocalId>.Enumerator IAHCPHAJMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x777A3F0", Offset = "0x77795F0", VA = "0x18777A3F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x777A430", Offset = "0x7779630", VA = "0x18777A430", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x777A470", Offset = "0x7779670", VA = "0x18777A470", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NFIPPAIECID BOCHMICIIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> JBPFPBKHHLE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EOFNBBMGHCB EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7775A10", Offset = "0x7774C10", VA = "0x187775A10", Slot = "4")]
		get
		{
			return default(EOFNBBMGHCB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7775B00", Offset = "0x7774D00", VA = "0x187775B00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7775550", Offset = "0x7774750", VA = "0x187775550", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7775550", Offset = "0x7774750", VA = "0x187775550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> CNEOAKFFHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE33E0", Offset = "0x2BE25E0", VA = "0x182BE33E0")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KNKMFKKGHON
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7775990", Offset = "0x7774B90", VA = "0x187775990")]
	public DHPJJEOFEFK(NFIPPAIECID BOCHMICIIMO, Allocator JNKCCGKBKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7775900", Offset = "0x7774B00", VA = "0x187775900")]
	public DHPJJEOFEFK(NFIPPAIECID BOCHMICIIMO, int EEBDBIBAAFF, Allocator JNKCCGKBKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7775440", Offset = "0x7774640", VA = "0x187775440")]
	public AGCGHKEMDON JOBDBOBBBNI()
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7775020", Offset = "0x7774220", VA = "0x187775020", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7775060", Offset = "0x7774260", VA = "0x187775060", Slot = "13")]
	public bool Contains(EOFNBBMGHCB LOKFKJLCEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x77750F0", Offset = "0x77742F0", VA = "0x1877750F0", Slot = "14")]
	public void CopyTo(EOFNBBMGHCB[] LGLFHJLCKKH, int BOCNEABHGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7774FA0", Offset = "0x77741A0", VA = "0x187774FA0", Slot = "11")]
	public void Add(EOFNBBMGHCB LOKFKJLCEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7775390", Offset = "0x7774590", VA = "0x187775390", Slot = "7")]
	public void Insert(int KOOLKCPAFBB, EOFNBBMGHCB LOKFKJLCEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7775670", Offset = "0x7774870", VA = "0x187775670", Slot = "15")]
	public bool Remove(EOFNBBMGHCB LOKFKJLCEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7775300", Offset = "0x7774500", VA = "0x187775300", Slot = "6")]
	public int IndexOf(EOFNBBMGHCB LOKFKJLCEOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7775620", Offset = "0x7774820", VA = "0x187775620", Slot = "8")]
	public void RemoveAt(int KOOLKCPAFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x77752C0", Offset = "0x77744C0", VA = "0x1877752C0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7775590", Offset = "0x7774790", VA = "0x187775590")]
	public IOENAKDPNEP PACLDABBHPO()
	{
		return default(IOENAKDPNEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7775740", Offset = "0x7774940", VA = "0x187775740", Slot = "16")]
	private IEnumerator<EOFNBBMGHCB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7775820", Offset = "0x7774A20", VA = "0x187775820", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GGCCIAPKIMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EOFNBBMGHCB IBKDJAFECPK(EOFNBBMGHCB JBPFPBKHHLE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OPHCBPKCMEA : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface CNHPFOLBOCM : EBIIDFLCIEO, OGHLAOPHHHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	BMPHFFKGFOH BJEALMBCGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JJFMKOLCMMG GNFHJMEAINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface OGHLAOPHHHL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool HPINOHLAJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface NLGNCCBENKB
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLLEOEGJCGF(bool OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLADMABHKNO();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface DEBBKJBKAAE
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool GINJLBHBDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool OJDNLBHCPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LIIOKANGOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JPDHEKODHNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool EBAPPCEOINA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BHBFAKOKBPL(bool DOAMCAICJBD);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LEJKOCMOFBM(ByteString DFGEGAADELJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FEKFDBMHPMG();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AOEMFGMFJIA();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LFKAJJFFDNJ();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface DGNODCBEMMF
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	DBCOBCEEMIL BJEALMBCGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	OJOJDFDHPLD BFNJBFHJKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	BGFELIIGDMG OFGBKFICNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	CNHPFOLBOCM JBEGCFKDBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PLPGLNCDHAB KIGMMKIHOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	DEBBKJBKAAE CFGGMPNHECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	KEIMAMLEGJC BFAGKHNIAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	GCDDPENHOMM MDIHOADLEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	JLBPLEBDGLO EGKINMFKMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LNBGIMMJJPA LFHJNLHDEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	OIJCFPMJCJM AJLECFNKEAF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	ANBABHCICPK DLLJJNJODAE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	NEEONPBLMAJ OGDDAJNMOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	FFMNDKHPAGB HHOFAKMGDCP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CEOINOICJCD KOHEKNLPCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	DPNAKDJFGCB BDCFNPEAFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	IFGDIMKMOKB JBMBDLPKPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	ONEJMAJJLDL DNAHMLEEIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	AKIHPMNKOBK DBJPIEDOGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	MIONGIINOJP EGMNLEOJEDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MHIGGGAHMOH FFKNNOJFNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	FBPDLNHKKFN CALCHALMCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BEHFOGDCNMI GDEALOMONEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	CJDLAGOBLMH FNCBGKOGAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	EHHCKAFMNEK KKILFLNMABK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NFGNGPFKAHM IFCIPGFDDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	OOJGFGPONHL FHKJPICOIIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	EEJLBMCPFFF JFNAEEEEMIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FGBJJAHKFHC NHKCPPKOCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	POFEPPKPEEH BIKPPCBIDPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	LDFBPFEFEGF HPHKONGLMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CCPBNMAKFOL BKAOGMBEPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(BNPPGOJLBNE))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct EOFNBBMGHCB : IComparable<EOFNBBMGHCB>, IEquatable<EOFNBBMGHCB>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly EOFNBBMGHCB GCMJBINHBBO;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int JMIIADDCFFD = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int NJFHOCEJCMD = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int EFPJAFMPDLP = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int NIDONMKJAAC = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId DEBNBMMFJPK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public CNHPFOLBOCM JBEGCFKDBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7777050", Offset = "0x7776250", VA = "0x187777050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public LocalId OHDJJOGPJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7777490", Offset = "0x7776690", VA = "0x187777490")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	internal JJFMKOLCMMG GNFHJMEAINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x77774D0", Offset = "0x77766D0", VA = "0x1877774D0")]
		get
		{
			return default(JJFMKOLCMMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool DFFCJNIAGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7777250", Offset = "0x7776450", VA = "0x187777250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private bool HDEECFNGIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7776F10", Offset = "0x7776110", VA = "0x187776F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7777610", Offset = "0x7776810", VA = "0x187777610")]
	public EOFNBBMGHCB(NFIPPAIECID BDADJFOPHBI, LocalId DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x77776D0", Offset = "0x77768D0", VA = "0x1877776D0")]
	public EOFNBBMGHCB(JJFMKOLCMMG PBLKLOBKEHJ, LocalId DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
	public EMAAEODMJFK ENLIFFIGEML()
	{
		return default(EMAAEODMJFK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7776ED0", Offset = "0x77760D0", VA = "0x187776ED0")]
	public static LocalId AJAOLMPMCKD(EOFNBBMGHCB OFMLIMMJLAL)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7776E90", Offset = "0x7776090", VA = "0x187776E90")]
	public static Entity AJAOLMPMCKD(EOFNBBMGHCB OFMLIMMJLAL)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7777370", Offset = "0x7776570", VA = "0x187777370")]
	public static bool GJNOMHNHJKL(EOFNBBMGHCB IHGFIECIOLJ, EOFNBBMGHCB FHOBAJOBBGC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x77702F0", Offset = "0x776F4F0", VA = "0x1877702F0")]
	public static bool GHFFJAPPGNB(EOFNBBMGHCB IHGFIECIOLJ, EOFNBBMGHCB FHOBAJOBBGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x77774E0", Offset = "0x77766E0", VA = "0x1877774E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x77770B0", Offset = "0x77762B0", VA = "0x1877770B0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7776F60", Offset = "0x7776160", VA = "0x187776F60", Slot = "4")]
	public int CompareTo(EOFNBBMGHCB LDKNLBHIGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "5")]
	public bool Equals(EOFNBBMGHCB LDKNLBHIGFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JPIDFGGIHKP
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x777B7D0", Offset = "0x777A9D0", VA = "0x18777B7D0")]
	public static GLJKKHGGAPE OPAOENKEECF(this EOFNBBMGHCB ONELFPFEALD)
	{
		return default(GLJKKHGGAPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class BNPPGOJLBNE
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct JJFMKOLCMMG : IEquatable<JJFMKOLCMMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte PBLKLOBKEHJ;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] OPEHJJPEJMB;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static NFIPPAIECID MCDEGENHNLC;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static CNHPFOLBOCM PNJPPOBEJIN;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static NFIPPAIECID[] AAHIFJDMEEB;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static CNHPFOLBOCM[] JEKKGLFBEJA;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> PCIKAIIPNOB;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public CNHPFOLBOCM JBEGCFKDBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x777AF20", Offset = "0x777A120", VA = "0x18777AF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NFIPPAIECID LMKDKILAGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x777B620", Offset = "0x777A820", VA = "0x18777B620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x777B7C0", Offset = "0x777A9C0", VA = "0x18777B7C0")]
	static JJFMKOLCMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x27C0C30", Offset = "0x27BFE30", VA = "0x1827C0C30")]
	internal JJFMKOLCMMG(byte OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6741F20", Offset = "0x6741120", VA = "0x186741F20", Slot = "4")]
	public bool Equals(JJFMKOLCMMG LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x777B000", Offset = "0x777A200", VA = "0x18777B000", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xDEE980", Offset = "0xDEDB80", VA = "0x180DEE980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x777B700", Offset = "0x777A900", VA = "0x18777B700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x777B560", Offset = "0x777A760", VA = "0x18777B560")]
	private static NFIPPAIECID JMLPGJKAJIH(byte PBLKLOBKEHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x777ABD0", Offset = "0x7779DD0", VA = "0x18777ABD0")]
	private static CNHPFOLBOCM CKJAOPJNCBI(byte PBLKLOBKEHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x777B0A0", Offset = "0x777A2A0", VA = "0x18777B0A0")]
	private static object FOFOJHBKJKI(byte PBLKLOBKEHJ, object[] ALKPNNHBNLO, object OGPHJJMKHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x777B610", Offset = "0x777A810", VA = "0x18777B610")]
	private static int NEKJEIGHKLB(byte PBLKLOBKEHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x777B600", Offset = "0x777A800", VA = "0x18777B600")]
	private static int MJJLMEFENCF(byte PBLKLOBKEHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x777AB50", Offset = "0x7779D50", VA = "0x18777AB50")]
	private static (int, int) CGKJDOADIPH(byte PBLKLOBKEHJ)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x777AF10", Offset = "0x777A110", VA = "0x18777AF10")]
	private static byte EMCGAJNDEAG(int LCLBPLEFKON, int KOOLKCPAFBB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x777AC70", Offset = "0x7779E70", VA = "0x18777AC70")]
	internal static JJFMKOLCMMG COGNOIDNGPM(CNHPFOLBOCM CEIBKNCHMAP, NFIPPAIECID OIEFJGPFPOP)
	{
		return default(JJFMKOLCMMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x777A960", Offset = "0x7779B60", VA = "0x18777A960")]
	internal static void AGGOIHIHDOM(JJFMKOLCMMG PBLKLOBKEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x777B200", Offset = "0x777A400", VA = "0x18777B200")]
	private static void HJMNMIOKEGL(int ECPBKIMJCKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum NGBJCLFHAOF
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
[ServiceLifetime(Lifetime.Application)]
public interface OKPOBMMNGLE
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Guid GGIHJIHNELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AJOEHLLENCI(Guid LCLLCOEBDPG, Guid JACMIDKJGCD, Guid LAJEGFJCKPE);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task KFMPPNNDNAB(Guid LCLLCOEBDPG, Guid[] HOIAJHFKGEC, Guid LAJEGFJCKPE);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid BOAKBKEMCMB(Guid BAELGIBBJFA);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task ANIDBJPLMOL(EOFNBBMGHCB ECGJAGHKDGH);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JDMKLOPKJLK(Guid BAELGIBBJFA);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EEKCEDMEMHI(CNNADDIJKGA DKPPKKPENAM, Guid DFOLMKFOHNM);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GPLMFGNMBOF(Guid BAELGIBBJFA, bool DOAMCAICJBD);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ServiceLifetime(Lifetime.Application)]
public interface FGPKLLDDKFL
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ServiceLifetime(Lifetime.Application)]
public interface IPHLLNLCNGM
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJBFOODCPEN(GameObject EBKNNHMOODP, GameObject JBDJGKBAGMM, int NHENBDOAMOM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[ServiceLifetime(Lifetime.Application)]
public interface KADNIGJDHGI
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "0")]
	void LEGBBJNJJBG(bool ADOLAHFFGEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface OJOJDFDHPLD
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	KADNIGJDHGI KHJNFAKMHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GMJGOAIHKEK AFJLEALOAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	FOCBLHHAMAH GBIFDMBFEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	ADOAIBNIJBH DHCPHDHJCDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	IIANCKHEFNL DHMOKDAOAOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	OJIGMEABOMF EGBHCLKNPMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	ELNHMDHFGBP AMKIHIAKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	ILDADPPEBGK FKJJLFEJMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface GMJGOAIHKEK
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string IHFPIJHILJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ServiceLifetime(Lifetime.Application)]
public interface CAJJIGDAIAA
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECACIDNBLOJ(Action GJDAMJHNAPC, bool FJJJILPAFPD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JDMPLMHKEHE(string MBDFMCIDAOB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int PCJPINLDAIF(string MBDFMCIDAOB, int OGPHJJMKHNA);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GLJIOIIKHFL([Out] bool OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EOIBEPKHDBK([Out] bool OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OGJPPBOFBOG([Out] int OMFJNFBDJCA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[ServiceLifetime(Lifetime.Application)]
public interface FOCBLHHAMAH
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "0")]
	void NLBFGJDCHLJ(bool DOAMCAICJBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface ADOAIBNIJBH
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	protected static readonly Guid IFJHILANKAL;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	static readonly Guid FCLAAHPCFMM;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	static readonly Guid CDKFGNOAFCE;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	static readonly Guid KBAFAMIHGHL;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool LLNMMAAPAND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool AIKMGLLBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool PGJIOFBJIJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x776E010", Offset = "0x776D210", VA = "0x18776E010", Slot = "3")]
	string[] KLGAKABADKO(MLMGHINDMEL EDMHHOPIPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CIEMIEJEMNE();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x776DFE0", Offset = "0x776D1E0", VA = "0x18776DFE0", Slot = "5")]
	Guid IBEDENMKLAK(Guid ONNPGFEBJPH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HMAGOAIJNMN(MLMGHINDMEL EDMHHOPIPNM);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OEDCEEHGJPL(MLMGHINDMEL EDMHHOPIPNM, NativeArray<ONGJKGBMNLC> BBLIJHPGLOC, NativeList<UniformTRS> GIHLNOBBBDP);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int OFHIHMEHBPP(Guid FGPNICIMMFP);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CEGNFEMNOPN(string LHOGCPEJPMP, [Out] Guid FGPNICIMMFP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string KBKGFDMJLFF(Guid FGPNICIMMFP);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CKKPDBFEHGL(RRObjectPrefabData IAPAEDMDNLA, [Out] LocalId JJMNGBLHAJC);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	AIPBCFHHAOO<byte[]> KLMMOFJKMIG(NativeArray<ONGJKGBMNLC> NCNGJIHMJDP);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NFHDIILEEGL(byte[] HJJJDKINAHA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GameObject LDKOMIFFHFJ(string LHOGCPEJPMP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LEPAPHJGBJJ(Transform LBAHEDDLOKA, RRObjectPrefabData IHGNIIENJFA, EMNJGJMKAFD IBLIOEFMDMM);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool MPEACFGOPLH(MLMGHINDMEL EDMHHOPIPNM, NativeParallelHashMap<Guid, LocalId> HJEAGKAHEBC, [Out] Exception MEOLMCJHMNI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JFIHJMJAHAK(MLMGHINDMEL EDMHHOPIPNM, NativeParallelHashMap<Guid, LocalId> HJEAGKAHEBC, [Out] NativeArray<LocalId> DNOHLBIMBBG, [Out] NativeArray<LocalId> LHOCHCKDEAK, [Out] NativeArray<AuthoredLocalPoseData> HLONAGKANPD, Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "18")]
	void OMMEHNKHOJN(MLMGHINDMEL JEICPGHJIDH, NativeArray<int> LICIHJECMHO, HKOOMBBGJCN<GameObject> OGMIPOEADMO, AIPBCFHHAOO<GameObject> HCPOGNCJIBI, NGBJCLFHAOF ONMGADLLCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BFNHFKHCFJL();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "20")]
	void OIGJIBGHMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "21")]
	void PNLGMDLJNCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "22")]
	bool NFPGIEHFEPA(MLMGHINDMEL EDMHHOPIPNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "23")]
	OKAIHAIBEDE OPFIMDCGAMB(MLMGHINDMEL EDMHHOPIPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x776E0A0", Offset = "0x776D2A0", VA = "0x18776E0A0")]
	static ADOAIBNIJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OKAIHAIBEDE
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IBNDEHEOLCF(IKGIGHHOPMD GFOILLNHEFN, int KOOLKCPAFBB);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BNMFJKJGFNN
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool LJHENNHEIMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool OJEJKKPKLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool ELOCBDBHHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool JDPNOPIEEPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool MIGDCCOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IKGIGHHOPMD : BNMFJKJGFNN
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum EGFGPCJJFLA
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Physical_Sticky = 2,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Physical = 4
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool HNNHBMBDHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool CPKABMOILAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool OJIPHDOKBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int HIPGAJKJLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKEOGMGNOEK(FODAGOJOEBG ADJAHFEDDPI, int KOOLKCPAFBB);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FODAGOJOEBG
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool CJCBKFHIKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	PMLONBCCMJA LFFNMOEOGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	CKINBEGNDGI ICAIMJKPOID
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float3 LAHGFMKGHMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	quaternion NEDOKMKIJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float3 KEDFJDMFMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	FEDDFCEHBJI ECAGAIIDDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	PKHDDMBNAMA IAOFMHCNKJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	float NCAEMGGGKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	float3 CDPBEFKEJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	float PCOOOOEGKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	HLJNCAAHCPJ CFHHIFLHCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface CKINBEGNDGI
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool DCPGKGOMFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool FMFLNPBMGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool AKKMIIIBPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	float MBEBBDGPLAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	int CJIGAEKJMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	int ENECIFECBJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AJCJNLCBCDN(BPHGFMLFMLC ADJAHFEDDPI, int KOOLKCPAFBB);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface BPHGFMLFMLC
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	float3 JLOEFHABMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float3 MCFPOCEPGLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion GKFNDEDGBLD(float3 LMDIMFEOKIO);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface GBPAGAFCGDN
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	long BPJPDADFNMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	long IJMAHOEDKNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface IIANCKHEFNL
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool LBBEDEHLLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool GOOJPLKEBAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	int OHPANDMLHNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	int EOEIEBOKLEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int MJEOLJGOLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool GGALIHCDDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	int JHNBIIDGBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "6")]
	void JKFKDOHBGJI(LDLIOIKBNCN JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
	void DDFDOFOLEBL(bool BEFJCLAGAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "8")]
	bool FAGGFNBNAAH(NEPEIILKAIK ADIMAPFNMNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "9")]
	void LHLDKBGECPO(object FKKLLADNDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "10")]
	void EOBJJABIPFP(object FKKLLADNDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "11")]
	void LIDFECOGAMP(object CGKPJBPKLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "12")]
	void PAHPOKCJFDN(object CGKPJBPKLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "13")]
	void PKOOODPBPCF(NativeArray<ViewId> LICDGANDLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "14")]
	void NAPNEGMNJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "15")]
	void DCPGHLAKMPC(PIFIDBIGLCI NNILCBOLNDI, ReadOnlySpan<byte> LJELDKAOCJM, NEPEIILKAIK PBDBCFOFBBI, bool AINMOIECLNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "16")]
	void DCPGHLAKMPC(PIFIDBIGLCI NNILCBOLNDI, ReadOnlySpan<byte> IDMLDMGBMGK, bool AINMOIECLNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "17")]
	void DCPGHLAKMPC(PIFIDBIGLCI NNILCBOLNDI, ReadOnlySpan<byte> IDMLDMGBMGK, ReadOnlySpan<byte> BEJLILDAPGO, bool AINMOIECLNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "18")]
	void LPEMOFIODEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "19")]
	void AGNBCMGNCBK(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "20")]
	void EDDDICKMEFL(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "21")]
	void FJHIODHBHKJ(Dictionary<object, object> MIDFFJMABJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "22")]
	void NJMLCFMBBOE(NativeList<GLJKKHGGAPE> NEDLHJKGMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "24")]
	void KEDMLGHNDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "25")]
	void GJGPPEGFPGD(List<object> CHFDDPBNFEP, int JMHJAFCGEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "26")]
	void MNDBEICEIEP(int IJFDPELMKHC, object ELLEMLBGHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "27")]
	void KPGMLODAEHF(NEPEIILKAIK ADIMAPFNMNK, Dictionary<object, object> PBKGIMHJLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "28")]
	void GAHOAGNCMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "29")]
	void NKMAOJCBOEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class FHLMFBPNMLK
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x77779A0", Offset = "0x7776BA0", VA = "0x1877779A0")]
	public static HAGKECODHJC LBLKBOBMONH(this IIANCKHEFNL OCNNBPCACIL, object GIIKHLJPAKH)
	{
		return default(HAGKECODHJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct HAGKECODHJC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private IIANCKHEFNL OCNNBPCACIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object GIIKHLJPAKH;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7778ED0", Offset = "0x77780D0", VA = "0x187778ED0")]
	public HAGKECODHJC(IIANCKHEFNL OCNNBPCACIL, object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7778E80", Offset = "0x7778080", VA = "0x187778E80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.Application)]
public interface BHFCPMDHHJD
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.Application)]
public interface OJIGMEABOMF
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct IGNGAEPKLDP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private OJIGMEABOMF PGFJMIKAEMM;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x777A180", Offset = "0x7779380", VA = "0x18777A180")]
		public IGNGAEPKLDP(OJIGMEABOMF PGFJMIKAEMM, string AHMEOBJEAJP, string FFEEOHMIOIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x777A0C0", Offset = "0x77792C0", VA = "0x18777A0C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct BNLNPMPFBDM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private OJIGMEABOMF PGFJMIKAEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task JJCLBODJJAC;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7771170", Offset = "0x7770370", VA = "0x187771170", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "0")]
	void KJCGCHAPHDJ(string DCEACFEGBDC, float MBNMMCCMGDC = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "1")]
	void ILCCGEALNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHKNCKDDPOM(bool EPONNDGCKPC, string AHMEOBJEAJP, string FFEEOHMIOIO);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "3")]
	void NKOANABFDEM(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class AMJAHNMNBCK
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x776EEB0", Offset = "0x776E0B0", VA = "0x18776EEB0")]
	public static OJIGMEABOMF.IGNGAEPKLDP GCBBIEBGGEB(this OJIGMEABOMF OCNNBPCACIL, string AHMEOBJEAJP, string FFEEOHMIOIO)
	{
		return default(OJIGMEABOMF.IGNGAEPKLDP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[ServiceLifetime(Lifetime.Application)]
public interface PBANOCACMKK
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JKNLPEHIFCM(GameObject LNIONOAAAEO);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDKDONJOEEA(GameObject LNIONOAAAEO);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KLOONLBIJMD(int ADIMAPFNMNK);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object MOPMBMGMIDN(EOFNBBMGHCB DEBNBMMFJPK, GameObject LNIONOAAAEO, Action<EOFNBBMGHCB, int> GIIPLELNBKP);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBPCEIBAGFA(GameObject LNIONOAAAEO, object MMPBAELGDIL);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[ServiceLifetime(Lifetime.Application)]
public interface CJPHOEHCEKB
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEAAONFOJJH(object ONELFPFEALD, NativeList<byte> LJELDKAOCJM);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object ANADGBKPLNB(NativeArray<byte> LJELDKAOCJM);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ServiceLifetime(Lifetime.Application)]
public interface MIDABFJCPAH
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool FJAGJIAHAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate GBGIHJIFNJE(CLFEIHJGDEO JPINJIPMJOA, Action<CLFEIHJGDEO> GIIPLELNBKP);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJMLKDGJINF(CLFEIHJGDEO JPINJIPMJOA, Delegate GIIPLELNBKP);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate HKHILIFBCKM(CLFEIHJGDEO JPINJIPMJOA, Action<CLFEIHJGDEO> GCMOEEHOKOP);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJJKCGGGPLH(CLFEIHJGDEO JPINJIPMJOA, Delegate GIIPLELNBKP);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BLIMOKGJPKC(CLFEIHJGDEO JPINJIPMJOA);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CLFEIHJGDEO OIKHACPMACE(GameObject LNIONOAAAEO);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface MEBIEDJJDOH
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int MKCCJDALPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	int HNDCLHBAKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool LBBEDEHLLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool DLBNOGPCMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool FDCLCGCLDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EOFNBBMGHCB GOJKHEKMOCC(int ADIMAPFNMNK);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface ELNHMDHFGBP
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool GINJLBHBDGF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface OEMELGDKBOH
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	IGEBAHMFCMN OLFPNNJBBIL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	FDBJDLMKNEH EGCJADFNLLM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool GHPNFJNDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KAKBFGNKACL(Transform LBAHEDDLOKA);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLPGPFNLDPB(Transform LBAHEDDLOKA, MPMHJLBLEOI AGEPOMJEAPE);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDIMOMJGPLG(Transform LBAHEDDLOKA, GIHAKHDNNJF JPGPAIHLKCE);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface ILDADPPEBGK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LCGOACIIKPB;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface NPNHCBECMBA
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGDIJLMDNKM();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface PFABDPLHBAE
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDBPOKEHNAD(GameObject LNIONOAAAEO, DEICFKHPALG ELHFFJIHNGB, EGIKPNEFJGH IOHHODJLLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PGGMKBCFDIE(EOFNBBMGHCB DEBNBMMFJPK, bool KDCDLPEEALJ, float3 JEEFHCLPENL, quaternion KHCEJDELBKA);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FMCKJCIBMDN(AGCGHKEMDON CDKIGPFPDJN);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BMLPJJDLBJG(EMAAEODMJFK CMDONCAECIK, EMAAEODMJFK CGKPJBPKLPJ, LALIAMPJIPE HFOOBLKJDEM);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFJHCDCOLJI(EMAAEODMJFK CMDONCAECIK, LALIAMPJIPE HFOOBLKJDEM);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HAHKFBLBIAB(AGCGHKEMDON MMIFPEOFNOK);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject EDJDAFBEMBG(Guid NPJIEOKAKAO);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OPGFBFJFHGK(JLHFMODMEEH MDCLBIIGDEE);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct ECKDAKIKBIN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> LJELDKAOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle PBLKLOBKEHJ;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7775D50", Offset = "0x7774F50", VA = "0x187775D50")]
	public ECKDAKIKBIN(ReadOnlyMemory<byte> DPJNDOLAGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7775D10", Offset = "0x7774F10", VA = "0x187775D10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum CCJFPNAHEHK
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
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct MLMGHINDMEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString MFAJEFKAEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object MFNCGDIBJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object KBFFDFKOHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> PGKNJENLEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool BDGBLMBJOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public FFKODMBDGIE.HCBIDJCKLHA? HHABKHGPJHK;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x777CD70", Offset = "0x777BF70", VA = "0x18777CD70")]
	public MLMGHINDMEL(ByteString MFAJEFKAEBK, [Optional] object MFNCGDIBJEO, [Optional] object KBFFDFKOHEF, [Optional] IEnumerable<string> PGKNJENLEAA, bool BDGBLMBJOMM = true, [Optional] FFKODMBDGIE.HCBIDJCKLHA? HHABKHGPJHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct NLBAPMEEODC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object CFDBCKAECOJ;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct ONGJKGBMNLC
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[Flags]
	public enum AGCGAFPFEJK
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
	public RRObjectPrefabData EDDGGAMFGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid NDFBNLGMNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid MEILHFHJDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid KMJLABGLJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid MHGGGILNPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public AGCGAFPFEJK BCFKGGKKKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 PMKBMMJPEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int NGKBNOIMNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public GKMEOPGOAAL MMPMLOPEADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int LHLLBPCKPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int BJNIACLFBGP;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Guid FMOPGONMJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C940", Offset = "0x4B1BB40", VA = "0x184B1C940")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool HCJAIKIGIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7782580", Offset = "0x7781780", VA = "0x187782580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public bool BKEAGBEAGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7782590", Offset = "0x7781790", VA = "0x187782590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool AKIFIBFDANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7782570", Offset = "0x7781770", VA = "0x187782570")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct PBALPODBMLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly AKMKGEOIFEH MGKDKECOLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly AKMKGEOIFEH ANMKOMFFHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly uint NMKCEOHAJPN;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7782BC0", Offset = "0x7781DC0", VA = "0x187782BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct DAACPONGKGD
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal readonly PBALPODBMLA GJDAMJHNAPC;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7774E50", Offset = "0x7774050", VA = "0x187774E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct EJHAOKOHIBH
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal readonly PBALPODBMLA GJDAMJHNAPC;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7774E50", Offset = "0x7774050", VA = "0x187774E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct NEKNDGHCKLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly uint NMKCEOHAJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly bool HLOLCNDLOID;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x777CE50", Offset = "0x777C050", VA = "0x18777CE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct AKMKGEOIFEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal int DCNPLBBIONO;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x776EE50", Offset = "0x776E050", VA = "0x18776EE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[ServiceLifetime(Lifetime.Application)]
public interface JFHGJIILLFG
{
	[Cpp2IlInjected.Token(Token = "0x17000084")]
	PCOLIOPNBCO DGNICNNHKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface CNNADDIJKGA
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface MPACJIDAMHK
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NMIMCOFNPPB
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3617AB0", Offset = "0x3616CB0", VA = "0x183617AB0")]
	public static EMAAEODMJFK ENLIFFIGEML<T>(this T DEBNBMMFJPK) where T : CNNADDIJKGA
	{
		return default(EMAAEODMJFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x777FCB0", Offset = "0x777EEB0", VA = "0x18777FCB0")]
	public static MonoBehaviour MIEDDKKENLJ(this CNNADDIJKGA DEBNBMMFJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x777FBF0", Offset = "0x777EDF0", VA = "0x18777FBF0")]
	public static GameObject FOFJJMEPKPD(this CNNADDIJKGA DEBNBMMFJPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GFLOMJJMLAB : CNNADDIJKGA
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(EOFNBBMGHCB BNMNHJKEFGM);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface NMNAIGLKKJD : CNNADDIJKGA
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HCAOGLINDLA
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public delegate void CDGLDEFIDLP(FMDJNBGLJHK NMJIDOBANPO);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event CDGLDEFIDLP KAJIIJKPDEO;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface GJBIEIBEDIF
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface KCAANEGOABE
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface PLFDEIFHCPN
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(EOFNBBMGHCB MHKFDAKEAEI);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool PNPFAKPMEMD);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HIMBCJKAJAK(EOFNBBMGHCB MOEJABALFBA);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface KNJBAOAHOPK
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(KCAMGMHDEDF FDNIEKDHGBB);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface KCAMGMHDEDF
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	GameObject LNIONOAAAEO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Transform LBAHEDDLOKA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	CKJMPDKLOMB FEJINAKGJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	bool CKJMLKFINLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIANEHINLKM(CKJMPDKLOMB PIJKIPKKMLF);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DGPLBFHBGKJ GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class CHIPLOKNCHI
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7773BD0", Offset = "0x7772DD0", VA = "0x187773BD0")]
	public static void JJJIBAOMECD(this KCAMGMHDEDF DNNDAOFODNI, EMNJGJMKAFD IBLIOEFMDMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface CKJMPDKLOMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Rigidbody KEAOKJKIGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	KCAMGMHDEDF EKBAMNCJMKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	GameObject FOFJJMEPKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Transform FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	CKJMPDKLOMB JCHDMDCGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	CKJMPDKLOMB GMOCPPMLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	int AFHKCJNFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool JBNFKMDMFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool BLIMOKGJPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool FNOOOLDGFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	BFHLICCPHMB AOEDIBNPEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	CBFNNFFIFKO AFFAHABPJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float NBJCJLCNJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	Vector3 NNMOGOHKDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Vector3 LNPMAIDJHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 MGLKIJIEAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Vector3 LINIIKOHKID
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	bool LMIFKMAOKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool AOMALKBHLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool AEGJCCDGFDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool HFBNJKFPMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Vector3 NGONCLLCEOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Vector3 HFAAGKLHHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 NEOCHLLLADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 LFCBHFAIPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	float GCKJPMGDNLH
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	float IFIJBNAHOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Vector3 JNJDCEPOOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Quaternion LMFNPKFPCOA
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	float BAOFHKJJLLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	float PJDENCJDHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool NEJMOBEANOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	DFMIAGBKIML FOPOMNMNGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool LKEJANPOONK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Transform AEAEPMOPBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Vector3 IDHLNMPCLLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float GBHEHIAFDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	float PLIBDAPJKME
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Quaternion CGNDLMDBNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	Vector3 JLOEFHABMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	Quaternion DNDIEJBKBAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	RigidbodyConstraints KCNPLOGDIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	bool MFEJOIIBKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	CollisionDetectionMode NODGPJHFHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	bool AAOCALBJHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event ANFIDMOOJCO FDIAOCEAMBE;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ANFIDMOOJCO OOCMNBBKMLH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event ANFIDMOOJCO AIGMAFDIONK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ANFIDMOOJCO HCHGGAOBBCN;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event ANFIDMOOJCO NEFPDKPJOAL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event ANFIDMOOJCO KKJNNGOFBNO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event ANFIDMOOJCO APJENHCGJLH;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FIIDLLPBBKB KPLNNKLAKFG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<OJGJEEMDGCF, OJGJEEMDGCF> DJHFCDIFLGM;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CKJMPDKLOMB NAAJMCGLLKO(int KOOLKCPAFBB);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void FHGDKLHKFOG((Quaternion rot, Vector3 moments) KHCHKJFGKPL);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void FDAGCHPOHKC();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void FCMOOEKHBCA();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void DPIOMIOOGDI();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void PGBMDHJJHBJ();

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void AFFNBFKGAPM();

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void JGMGHHENICE(CKJMPDKLOMB OMFJNFBDJCA, bool IEBFLJEOPJP = false);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void NDJNLJKBPPC(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void HKNNGLNPBFJ(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 JKHBDNCKEGL(Vector3 AAKCIEGFLNF);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 FELFDHGKHDD(Vector3 BFOLNOABHKB);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void ICKLMBKHLNB();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void OLKLJJKHDOH();

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void OHIOFHIMLDG();

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void DEFHNFILHJC(Vector3 GPBKAKMKHHM, Vector3 CJJEMCCDFKF);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void IHODMGNEJAO(Vector3 EHHEGNBIEBF, Vector3 GGKILDCFAHO);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void FNBNJEBEFOJ(Vector3 LGFGPHBEJIO);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void HKCDEAAELIK(HPMAFJLKFHL DLNHIMPFAMK, Vector3 HOBENLNNBJG, float LOFOCKIMDHE, float ECNCFDJFMHJ = 8f, float LLFECLGOEJE = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void LKMPMGIBDNM(GOPIKNGHAGE GAEKIHMGGAN, Vector3 EBGAHGHEICN, float EINHNGGOAIG = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void OIHHHPKKKKF(GOPIKNGHAGE GAEKIHMGGAN, Vector3 GLMEOLPKLCA, float EAFFEBJLAEN = 7f, float GJPEDKJKDLO = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 IMKIACFAHNG(Vector3 OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 PEKLBGGFOLJ(Vector3 OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void MKAELLFKLCE();

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void LAGPKIHKAGH(CKJMPDKLOMB PKEHBJJEGCK, object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void KONHPJAEEEB(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void NGJLEKLJCAB();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void JBKLOLOHMPC();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void LIODDGOFGOM();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool DCDDBIEDDNG();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void EDLHJIOFNMN();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void FMPPAEIAHHO(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void LKIMICFGPLL(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void DLOLCHGHDEA(object GIIKHLJPAKH, bool JLKOFADJBOL);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void NBPBKHBDDND(Vector3 OOFANODCEOI, Quaternion NIBKNBINJBA);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void IILHAAFMECF(Vector3 OEPJNEMPDFD, Quaternion JDICBINFHHJ);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool BAPANEFNDAC(float EDDIMDPGGDG);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void CBMDGODLHHF(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void FAABAHAPIIB(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void DEHNLJMHHPM(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void CAIPKAIMHNB(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void NJGGIBIFFNJ(Vector3 CPGNGBBHKKK, ForceMode FPGHJBHLKCH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void NPDHFCDBCLK(Vector3 CPGNGBBHKKK, Vector3 LBPAIJGCICL, ForceMode FPGHJBHLKCH);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void DHAMHFKOCDP(Vector3 CDGJIJJBKDO, ForceMode FPGHJBHLKCH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void AHGNCJAHBHK(Vector3 CDGJIJJBKDO, ForceMode FPGHJBHLKCH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool NBGPIKGAPJE(Vector3 FOKNLDGGKBN, [Out] RaycastHit AMJOELMPNMA, float DLABDKKOOMK);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void NIDFGLAOFPL();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface CBFNNFFIFKO
{
	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKFJGHKKJKN(Vector3 OHHAFGNBGKE);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFEOHNENEKB(Vector3 KPBNIKDIOKJ);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIJEEDAODLE(Vector3 OHHAFGNBGKE);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLBKGJLAPNG(Vector3 KPBNIKDIOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface BFHLICCPHMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 ADMOKOPLCMI();

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 DJCLAOEEIOL();

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JEAIDBJOIGL(float FFENJGIDLPD, float EAGKBECDIJH);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public delegate void ANFIDMOOJCO(KCAMGMHDEDF POMKJOHENKF);
[Cpp2IlInjected.Token(Token = "0x2000055")]
public enum EAIGAJCJAAO
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
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum HPMAFJLKFHL
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
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate void FIIDLLPBBKB(KCAMGMHDEDF POMKJOHENKF, bool IEBFLJEOPJP = false);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum GOPIKNGHAGE
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct DGPLBFHBGKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Rigidbody BACLJFFEIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public object PLMNOBPOJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector3 KMIDEFGABNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 MENNJEABNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LEFFBPINKCP LJHEANDAHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool BNGCJKJMGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool NJPJJMAPLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool KPKMJAIHGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool FLJHNKOJAAK;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct EMAAEODMJFK : IEquatable<EMAAEODMJFK>
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly EMAAEODMJFK NECABFCFJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public GameObject LNIONOAAAEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7776A60", Offset = "0x7775C60", VA = "0x187776A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public GLJKKHGGAPE CNBBGJKBFML
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x77769C0", Offset = "0x7775BC0", VA = "0x1877769C0")]
		get
		{
			return default(GLJKKHGGAPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public JLPIDFFKDDB CBHBHEEELFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7776C10", Offset = "0x7775E10", VA = "0x187776C10")]
		get
		{
			return default(JLPIDFFKDDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public RRObjectPrefabData DBMJHMLAOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x77761E0", Offset = "0x77753E0", VA = "0x1877761E0")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool PODMOGLBLIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7776BF0", Offset = "0x7775DF0", VA = "0x187776BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool NFIHGKDEGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7776360", Offset = "0x7775560", VA = "0x187776360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool CJCBKFHIKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x77761C0", Offset = "0x77753C0", VA = "0x1877761C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool CCCFJABBKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x77764B0", Offset = "0x77756B0", VA = "0x1877764B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool LANHAHALBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7776850", Offset = "0x7775A50", VA = "0x187776850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool LBDPBOMHMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7776110", Offset = "0x7775310", VA = "0x187776110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool ILPFFJJPJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7776720", Offset = "0x7775920", VA = "0x187776720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool GJEGGOBAJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7776760", Offset = "0x7775960", VA = "0x187776760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool PBHJCPFGEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7776180", Offset = "0x7775380", VA = "0x187776180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool DDJAFHKOGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7776140", Offset = "0x7775340", VA = "0x187776140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public BNNGEGJBBPL FMAFEABMOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(BNNGEGJBBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public NLHJEJFKAND IOIMAJHEEDA
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(NLHJEJFKAND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public KNBHCGEPAKF DBIKGDHAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(KNBHCGEPAKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public FOPCACBFNKC OGDDAJNMOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(FOPCACBFNKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public MELIBLOAKAB JGIHIJNFHIB
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(MELIBLOAKAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public CHCMIFMKEJP NEFNELPMGAB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(CHCMIFMKEJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public BNGKCIMMGAI DINKIOGJNOO
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(BNGKCIMMGAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public GKHAALIBGGI BJKGIBADMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(GKHAALIBGGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public OOAABJDICIL DGMBIFOECNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(OOAABJDICIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public BIGCEBNLAGL HHOFAKMGDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(BIGCEBNLAGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public PPONHJBDJKA AGNJHKPACFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(PPONHJBDJKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public MHNBDDJOKHA ONGJGGLBNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(MHNBDDJOKHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public OEBGLEDIIMG AIOGBEDEMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(OEBGLEDIIMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool PLIONGIMJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7776570", Offset = "0x7775770", VA = "0x187776570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool KJBLLGKJGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7776810", Offset = "0x7775A10", VA = "0x187776810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool PBJANAFIAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7776CE0", Offset = "0x7775EE0", VA = "0x187776CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool HAADBNOLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x77767D0", Offset = "0x77759D0", VA = "0x1877767D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool DGDLOLMECCK
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7776660", Offset = "0x7775860", VA = "0x187776660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool DFLBAEHFFIM
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x77760D0", Offset = "0x77752D0", VA = "0x1877760D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public NFIDOEMCBCJ FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(NFIDOEMCBCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public NPMJNLBAGAE LFHJNLHDEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(NPMJNLBAGAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static EMAAEODMJFK AJAOLMPMCKD(EOFNBBMGHCB BNMNHJKEFGM)
	{
		return default(EMAAEODMJFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x77766A0", Offset = "0x77758A0", VA = "0x1877766A0")]
	public OEJHPIPEIAI HJFJJKDMBOK()
	{
		return default(OEJHPIPEIAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7776CB0", Offset = "0x7775EB0", VA = "0x187776CB0")]
	public BKDHGPECJNF NNAMJGFANIC()
	{
		return default(BKDHGPECJNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7776970", Offset = "0x7775B70", VA = "0x187776970")]
	public CCOFJFAFCIN LHMGBCEAGDD()
	{
		return default(CCOFJFAFCIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x77767A0", Offset = "0x77759A0", VA = "0x1877767A0")]
	public HDPGDGOJOFE JBFEEIEPFLA()
	{
		return default(HDPGDGOJOFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7776310", Offset = "0x7775510", VA = "0x187776310")]
	public NOOOHLAOFKD DMFPNGHMPED()
	{
		return default(NOOOHLAOFKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7776870", Offset = "0x7775A70", VA = "0x187776870")]
	public void LEEDNAPGLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x77764D0", Offset = "0x77756D0", VA = "0x1877764D0")]
	public void FFMIMIFACMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7776380", Offset = "0x7775580", VA = "0x187776380")]
	public bool EMLBJCMLNBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7776D20", Offset = "0x7775F20", VA = "0x187776D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public EMAAEODMJFK(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x776F020", Offset = "0x776E220", VA = "0x18776F020")]
	public static bool AJAOLMPMCKD(EMAAEODMJFK OMFJNFBDJCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static EOFNBBMGHCB AJAOLMPMCKD(EMAAEODMJFK OMFJNFBDJCA)
	{
		return default(EOFNBBMGHCB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7771AD0", Offset = "0x7770CD0", VA = "0x187771AD0")]
	public static bool GJNOMHNHJKL(EMAAEODMJFK IHGFIECIOLJ, EMAAEODMJFK FHOBAJOBBGC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x77702F0", Offset = "0x776F4F0", VA = "0x1877702F0")]
	public static bool GHFFJAPPGNB(EMAAEODMJFK IHGFIECIOLJ, EMAAEODMJFK FHOBAJOBBGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7776420", Offset = "0x7775620", VA = "0x187776420", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(EMAAEODMJFK LDKNLBHIGFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct BNNGEGJBBPL : IEquatable<BNNGEGJBBPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public RigidTransform NOHEJEBJGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7771490", Offset = "0x7770690", VA = "0x187771490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float GBHEHIAFDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x77711C0", Offset = "0x77703C0", VA = "0x1877711C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public NFIDOEMCBCJ FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(NFIDOEMCBCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x77712A0", Offset = "0x77704A0", VA = "0x1877712A0")]
	public void GILFGICFJAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public BNNGEGJBBPL(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7771210", Offset = "0x7770410", VA = "0x187771210", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(BNNGEGJBBPL LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct NLHJEJFKAND : IEquatable<NLHJEJFKAND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private KEIMAMLEGJC OKDKFHDGOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x777FB90", Offset = "0x777ED90", VA = "0x18777FB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool EBAFKDNEOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x777FB00", Offset = "0x777ED00", VA = "0x18777FB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool JPJDKPAGDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x777FAC0", Offset = "0x777ECC0", VA = "0x18777FAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool CDOGGNHAEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x777F6A0", Offset = "0x777E8A0", VA = "0x18777F6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Guid EHBIGDJNCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x777F3D0", Offset = "0x777E5D0", VA = "0x18777F3D0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public Guid NHJCGOFDJND
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x777F9B0", Offset = "0x777EBB0", VA = "0x18777F9B0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Guid IIIEABONHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x777F140", Offset = "0x777E340", VA = "0x18777F140")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public NPMJNLBAGAE LFHJNLHDEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(NPMJNLBAGAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x777F800", Offset = "0x777EA00", VA = "0x18777F800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x777F450", Offset = "0x777E650", VA = "0x18777F450")]
	public bool DMPLIAEPGHG([Out] Guid BAELGIBBJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x777F760", Offset = "0x777E960", VA = "0x18777F760")]
	public bool GFOCODOJINN([Out] Guid JACMIDKJGCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x777F890", Offset = "0x777EA90", VA = "0x18777F890")]
	public void HEJEGLGONOJ(Guid HBMPJOCKNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x777FA30", Offset = "0x777EC30", VA = "0x18777FA30")]
	public void HLOLBKCPOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x777F580", Offset = "0x777E780", VA = "0x18777F580")]
	public Guid FAHGFJIFFLN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public NLHJEJFKAND(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x777F4F0", Offset = "0x777E6F0", VA = "0x18777F4F0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(NLHJEJFKAND LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct CCOFJFAFCIN : IEquatable<CCOFJFAFCIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private JLBPLEBDGLO ALOLKEBDINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x7772F00", Offset = "0x7772100", VA = "0x187772F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 CEAGHAJGCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7772BF0", Offset = "0x7771DF0", VA = "0x187772BF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Quaternion JLONACLNNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x77728C0", Offset = "0x7771AC0", VA = "0x1877728C0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public EMAAEODMJFK ELGBHPFONBK
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7772530", Offset = "0x7771730", VA = "0x187772530")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7772720", Offset = "0x7771920", VA = "0x187772720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x77725C0", Offset = "0x77717C0", VA = "0x1877725C0")]
	public AGCGHKEMDON CNCCIMBGALJ(Allocator JNKCCGKBKPB)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7772A00", Offset = "0x7771C00", VA = "0x187772A00")]
	public bool LOELIPFDKMJ(EMAAEODMJFK JNGEIJHHFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7772AA0", Offset = "0x7771CA0", VA = "0x187772AA0")]
	public void OIIMBIFDBME(Vector3 LBPAIJGCICL, Quaternion GLMEOLPKLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x77727B0", Offset = "0x77719B0", VA = "0x1877727B0")]
	public void JIEDOKECKFB(float DIOKPOCPBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7772D40", Offset = "0x7771F40", VA = "0x187772D40")]
	public void PCCFKOEAAPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public CCOFJFAFCIN(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x776F020", Offset = "0x776E220", VA = "0x18776F020")]
	public static bool AJAOLMPMCKD(CCOFJFAFCIN OMFJNFBDJCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static EOFNBBMGHCB AJAOLMPMCKD(CCOFJFAFCIN OMFJNFBDJCA)
	{
		return default(EOFNBBMGHCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7772690", Offset = "0x7771890", VA = "0x187772690", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(CCOFJFAFCIN LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct OEJHPIPEIAI : IEquatable<OEJHPIPEIAI>
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly OEJHPIPEIAI NECABFCFJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private LNBGIMMJJPA AHCGKOINLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7782360", Offset = "0x7781560", VA = "0x187782360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<EMAAEODMJFK> EALBHAANOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7781C90", Offset = "0x7780E90", VA = "0x187781C90")]
		get
		{
			return default(Span<EMAAEODMJFK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public string FOBFABOAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7782260", Offset = "0x7781460", VA = "0x187782260")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x77822E0", Offset = "0x77814E0", VA = "0x1877822E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public NFIDOEMCBCJ FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(NFIDOEMCBCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public NPMJNLBAGAE LFHJNLHDEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(NPMJNLBAGAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7781E20", Offset = "0x7781020", VA = "0x187781E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7781EB0", Offset = "0x77810B0", VA = "0x187781EB0")]
	public void HBOHKDOHLHB(OEJHPIPEIAI LDKNLBHIGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public OEJHPIPEIAI(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x776F020", Offset = "0x776E220", VA = "0x18776F020")]
	public static bool AJAOLMPMCKD(OEJHPIPEIAI OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x7781D90", Offset = "0x7780F90", VA = "0x187781D90", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(OEJHPIPEIAI LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static EMAAEODMJFK AJAOLMPMCKD(OEJHPIPEIAI NAELBAPCKEH)
	{
		return default(EMAAEODMJFK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[DefaultMember("Item")]
public struct NGFMFFCDFEF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Dictionary<int, object> INMHGMBPIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private JMMKLPHKBHK FKEAKFAJMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool AAEKHNFFBKG;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(EMAAEODMJFK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public KIPIJBOEKFG EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x777ED60", Offset = "0x777DF60", VA = "0x18777ED60")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x777F070", Offset = "0x777E270", VA = "0x18777F070")]
	internal NGFMFFCDFEF(EMAAEODMJFK ONELFPFEALD, bool AAEKHNFFBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x777EE20", Offset = "0x777E020", VA = "0x18777EE20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x360DDD0", Offset = "0x360CFD0", VA = "0x18360DDD0")]
	public void HFCADGGMANM<T>(KIPIJBOEKFG MBDBONINAPC, T OMFJNFBDJCA, [Optional] T OGPHJJMKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x777EF50", Offset = "0x777E150", VA = "0x18777EF50")]
	public void OGPGHNCGHLC(KIPIJBOEKFG MBDBONINAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0xC8DFC0", Offset = "0xC8D1C0", VA = "0x180C8DFC0")]
	public Dictionary<int, object> HJBGILGDMJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x777F000", Offset = "0x777E200", VA = "0x18777F000")]
	private readonly void PEIPBGCOGOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class DHGIOJODKDJ
{
	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7774EE0", Offset = "0x77740E0", VA = "0x187774EE0")]
	public static NGFMFFCDFEF PKJBNGMJBHN(this EMAAEODMJFK ONELFPFEALD)
	{
		return default(NGFMFFCDFEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct OEBGLEDIIMG : IEquatable<OEBGLEDIIMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool BODJEBMAKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7781A30", Offset = "0x7780C30", VA = "0x187781A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 BJNBJFFOAFP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7781A70", Offset = "0x7780C70", VA = "0x187781A70")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7781C70", Offset = "0x7780E70", VA = "0x187781C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x7781A70", Offset = "0x7780C70", VA = "0x187781A70")]
	public Vector3 DGBHEEOKLPD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x7781BF0", Offset = "0x7780DF0", VA = "0x187781BF0")]
	public void IEECGHIPHCH([In] Vector3 OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x7781AF0", Offset = "0x7780CF0", VA = "0x187781AF0")]
	public bool EFIFAJEEJJF([In] Vector3 OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public OEBGLEDIIMG(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7781B60", Offset = "0x7780D60", VA = "0x187781B60", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(OEBGLEDIIMG LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct NPMJNLBAGAE : IEquatable<NPMJNLBAGAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private LNBGIMMJJPA AHCGKOINLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x77815D0", Offset = "0x77807D0", VA = "0x1877815D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public EOFNBBMGHCB EDFJLCKJKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7780C90", Offset = "0x777FE90", VA = "0x187780C90")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public EMAAEODMJFK JCHDMDCGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7781440", Offset = "0x7780640", VA = "0x187781440")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public EMAAEODMJFK GMOCPPMLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7780F20", Offset = "0x7780120", VA = "0x187780F20")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7781150", Offset = "0x7780350", VA = "0x187781150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7780B90", Offset = "0x777FD90", VA = "0x187780B90")]
	public Span<EMAAEODMJFK> COOIMBLBJHL()
	{
		return default(Span<EMAAEODMJFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x77814D0", Offset = "0x77806D0", VA = "0x1877814D0")]
	public Span<EMAAEODMJFK> NKIBGGFELDE()
	{
		return default(Span<EMAAEODMJFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7780E20", Offset = "0x7780020", VA = "0x187780E20")]
	public Span<EMAAEODMJFK> ELLEDFLOODE()
	{
		return default(Span<EMAAEODMJFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7780D20", Offset = "0x777FF20", VA = "0x187780D20")]
	public Span<EMAAEODMJFK> DNCFEOFLFGD()
	{
		return default(Span<EMAAEODMJFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7781630", Offset = "0x7780830", VA = "0x187781630")]
	public Span<EMAAEODMJFK> POICGFCIMCA()
	{
		return default(Span<EMAAEODMJFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7781270", Offset = "0x7780470", VA = "0x187781270")]
	public bool JGMGHHENICE(EMAAEODMJFK JNGEIJHHFEP, bool EMDONHAPMNL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x77813A0", Offset = "0x77805A0", VA = "0x1877813A0")]
	public bool MDPCOMDEDGL(EMAAEODMJFK GBDMMBHHOEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7781040", Offset = "0x7780240", VA = "0x187781040")]
	public EMAAEODMJFK FJGMECHJBLP(uint DKLDNLNNPDM)
	{
		return default(EMAAEODMJFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x77811E0", Offset = "0x77803E0", VA = "0x1877811E0")]
	public OEJHPIPEIAI IMKOJIJJJEN()
	{
		return default(OEJHPIPEIAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public NPMJNLBAGAE(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x776F020", Offset = "0x776E220", VA = "0x18776F020")]
	public static bool AJAOLMPMCKD(NPMJNLBAGAE OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7780FB0", Offset = "0x77801B0", VA = "0x187780FB0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(NPMJNLBAGAE LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct KNBHCGEPAKF : IEquatable<KNBHCGEPAKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public string HEIDAHJIDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x777C670", Offset = "0x777B870", VA = "0x18777C670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public string PCNMIIGFDPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x777C490", Offset = "0x777B690", VA = "0x18777C490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private bool GIJAMCOIGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x777C010", Offset = "0x777B210", VA = "0x18777C010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public string AACHFHLFHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x777C5C0", Offset = "0x777B7C0", VA = "0x18777C5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public string MMJKLAPGLLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x777C240", Offset = "0x777B440", VA = "0x18777C240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public string NHNPKDFEFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x777BF80", Offset = "0x777B180", VA = "0x18777BF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public KNBHCGEPAKF(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x777C1B0", Offset = "0x777B3B0", VA = "0x18777C1B0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(KNBHCGEPAKF LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct NOOOHLAOFKD : IEquatable<NOOOHLAOFKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private OIJCFPMJCJM AJLECFNKEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x77806B0", Offset = "0x777F8B0", VA = "0x1877806B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public EJEHHIGLHHI IBIHBPLDCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x777FF70", Offset = "0x777F170", VA = "0x18777FF70")]
		get
		{
			return default(EJEHHIGLHHI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7780100", Offset = "0x777F300", VA = "0x187780100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool MOICCACENIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7780460", Offset = "0x777F660", VA = "0x187780460")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x77803C0", Offset = "0x777F5C0", VA = "0x1877803C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public AIPBCFHHAOO<string> KBFPCDPDDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7780950", Offset = "0x777FB50", VA = "0x187780950")]
		get
		{
			return default(AIPBCFHHAOO<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x777FD30", Offset = "0x777EF30", VA = "0x18777FD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public AIPBCFHHAOO<string> HPIBNIGNANH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7780830", Offset = "0x777FA30", VA = "0x187780830")]
		get
		{
			return default(AIPBCFHHAOO<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7780A70", Offset = "0x777FC70", VA = "0x187780A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public AIPBCFHHAOO<string> FKBMKFLJHJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7780590", Offset = "0x777F790", VA = "0x187780590")]
		get
		{
			return default(AIPBCFHHAOO<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x777FE50", Offset = "0x777F050", VA = "0x18777FE50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public AIPBCFHHAOO<string> CBJAGKELBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7780710", Offset = "0x777F910", VA = "0x187780710")]
		get
		{
			return default(AIPBCFHHAOO<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7780210", Offset = "0x777F410", VA = "0x187780210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7780330", Offset = "0x777F530", VA = "0x187780330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x77804F0", Offset = "0x777F6F0", VA = "0x1877804F0")]
	public bool HPJMFHFLGGL(EOFNBBMGHCB NCAFEKBCKBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public NOOOHLAOFKD(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static EOFNBBMGHCB AJAOLMPMCKD(NOOOHLAOFKD OMFJNFBDJCA)
	{
		return default(EOFNBBMGHCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7780070", Offset = "0x777F270", VA = "0x187780070", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(NOOOHLAOFKD LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct FHGILCODNPC : IEquatable<FHGILCODNPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7777910", Offset = "0x7776B10", VA = "0x187777910", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(FHGILCODNPC LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct FOPCACBFNKC : IEquatable<FOPCACBFNKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Collider GBPCEGCNKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7778650", Offset = "0x7777850", VA = "0x187778650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public IKBKDAJDEEK PBPLOPFMEKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7778310", Offset = "0x7777510", VA = "0x187778310")]
		get
		{
			return default(IKBKDAJDEEK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x77789D0", Offset = "0x7777BD0", VA = "0x1877789D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public KNIMAJIFOKB HGIPHGOGOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x77783E0", Offset = "0x77775E0", VA = "0x1877783E0")]
		get
		{
			return default(KNIMAJIFOKB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7778210", Offset = "0x7777410", VA = "0x187778210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public BLEJPBLPOHN IOBCGLIAEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7778A20", Offset = "0x7777C20", VA = "0x187778A20")]
		get
		{
			return default(BLEJPBLPOHN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7778570", Offset = "0x7777770", VA = "0x187778570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public float ACOHILJMCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x77785C0", Offset = "0x77777C0", VA = "0x1877785C0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7778600", Offset = "0x7777800", VA = "0x187778600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool HNNHBMBDHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x77782D0", Offset = "0x77774D0", VA = "0x1877782D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x77787F0", Offset = "0x77779F0", VA = "0x1877787F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool EGKOBDKCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x77787A0", Offset = "0x77779A0", VA = "0x1877787A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7778260", Offset = "0x7777460", VA = "0x187778260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7778860", Offset = "0x7777A60", VA = "0x187778860")]
	public bool OKBJFFANBOJ([Out] PLFDEIFHCPN BBPNMCBBJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7778480", Offset = "0x7777680", VA = "0x187778480")]
	public bool HIFMIGOFCAK([Out] EOFNBBMGHCB BFPPPKIAFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7778420", Offset = "0x7777620", VA = "0x187778420")]
	public bool FKPBJKFHOIG(KDCOCJHBCHK GONPIINPMBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7778190", Offset = "0x7777390", VA = "0x187778190")]
	public void AMFDLJBHKBB(KDCOCJHBCHK GONPIINPMBP, bool ADOLAHFFGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public FOPCACBFNKC(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7778350", Offset = "0x7777550", VA = "0x187778350", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(FOPCACBFNKC LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct HDPGDGOJOFE : IEquatable<HDPGDGOJOFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public bool HFPFINKKMMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x77790B0", Offset = "0x77782B0", VA = "0x1877790B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public HDPGDGOJOFE(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7779100", Offset = "0x7778300", VA = "0x187779100", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(HDPGDGOJOFE LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct MELIBLOAKAB : IEquatable<MELIBLOAKAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private CEOINOICJCD KOHEKNLPCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x777C9C0", Offset = "0x777BBC0", VA = "0x18777C9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x777C890", Offset = "0x777BA90", VA = "0x18777C890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x777C920", Offset = "0x777BB20", VA = "0x18777C920")]
	public void HDLMECFFMDO(bool OHIPBLFEBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public MELIBLOAKAB(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x777C800", Offset = "0x777BA00", VA = "0x18777C800", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(MELIBLOAKAB LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct CHCMIFMKEJP : IEquatable<CHCMIFMKEJP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public bool EKDGJAHFGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x77738B0", Offset = "0x7772AB0", VA = "0x1877738B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool KBIBIJMFHCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7772F60", Offset = "0x7772160", VA = "0x187772F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public bool KEKLKMCPFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7773AF0", Offset = "0x7772CF0", VA = "0x187773AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool GLFANHMCBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7773210", Offset = "0x7772410", VA = "0x187773210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool HADCDPCNJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x77739A0", Offset = "0x7772BA0", VA = "0x1877739A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool JNBJBLKMOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7773380", Offset = "0x7772580", VA = "0x187773380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool IOLBCPFAJMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7773720", Offset = "0x7772920", VA = "0x187773720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool KPGCAMNPFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7773580", Offset = "0x7772780", VA = "0x187773580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool NHDJKIMIMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x77732A0", Offset = "0x77724A0", VA = "0x1877732A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool DIJLNAAOFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x77738F0", Offset = "0x7772AF0", VA = "0x1877738F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool GGAOEMLHCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7773860", Offset = "0x7772A60", VA = "0x187773860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool MMKCDIOAAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7773810", Offset = "0x7772A10", VA = "0x187773810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool OJEJKKPKLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x77732F0", Offset = "0x77724F0", VA = "0x1877732F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool ELOCBDBHHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7773260", Offset = "0x7772460", VA = "0x187773260")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7773770", Offset = "0x7772970", VA = "0x187773770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public NBCDJIIJPBF NAJNLGHMFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x7773340", Offset = "0x7772540", VA = "0x187773340")]
		get
		{
			return default(NBCDJIIJPBF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x77734A0", Offset = "0x77726A0", VA = "0x1877734A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool OCIMOLNOHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7772FB0", Offset = "0x77721B0", VA = "0x187772FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public EGIKPNEFJGH GJNPFEBCHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x77735D0", Offset = "0x77727D0", VA = "0x1877735D0")]
		get
		{
			return default(EGIKPNEFJGH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7773B80", Offset = "0x7772D80", VA = "0x187773B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public bool ECPGDPFNPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x77737D0", Offset = "0x77729D0", VA = "0x1877737D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 NPFCNJIJOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x7773420", Offset = "0x7772620", VA = "0x187773420")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Vector3 KBKOAFODEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x7773140", Offset = "0x7772340", VA = "0x187773140")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool FAGKEGIFIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x77739F0", Offset = "0x7772BF0", VA = "0x1877739F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7773690", Offset = "0x7772890", VA = "0x187773690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7773940", Offset = "0x7772B40", VA = "0x187773940")]
	public bool KKOKDHGJODG(NOOAGLMBOBB GONPIINPMBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x77731C0", Offset = "0x77723C0", VA = "0x1877731C0")]
	public bool BLPFMACKKMO(DEICFKHPALG GONPIINPMBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7773610", Offset = "0x7772810", VA = "0x187773610")]
	public void GMFPGHMAIGO(DEICFKHPALG GONPIINPMBP, bool ADOLAHFFGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7773B40", Offset = "0x7772D40", VA = "0x187773B40")]
	public DEICFKHPALG PIFFCEFJJDB()
	{
		return default(DEICFKHPALG);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x77733D0", Offset = "0x77725D0", VA = "0x1877733D0")]
	public bool DFMLJKOPIHC(DEICFKHPALG OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public CHCMIFMKEJP(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x77734F0", Offset = "0x77726F0", VA = "0x1877734F0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(CHCMIFMKEJP LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct BNGKCIMMGAI : IEquatable<BNGKCIMMGAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	private ONEJMAJJLDL DNAHMLEEIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7770F50", Offset = "0x7770150", VA = "0x187770F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x7770BD0", Offset = "0x776FDD0", VA = "0x187770BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7770900", Offset = "0x776FB00", VA = "0x187770900")]
	public bool CMKNNKCLDCH(LALIAMPJIPE HFOOBLKJDEM, List<EMAAEODMJFK> CHPLKOOFBMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7770D90", Offset = "0x776FF90", VA = "0x187770D90")]
	public int JOMIEAEDHLD(LALIAMPJIPE HFOOBLKJDEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x7770590", Offset = "0x776F790", VA = "0x187770590")]
	public void ADNBMNCKENM(List<EMAAEODMJFK> CHPLKOOFBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x77706A0", Offset = "0x776F8A0", VA = "0x1877706A0")]
	public int ANDIFPOIJPH(EMAAEODMJFK CGKPJBPKLPJ, LALIAMPJIPE HFOOBLKJDEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x7770C60", Offset = "0x776FE60", VA = "0x187770C60")]
	public EMAAEODMJFK JIAONKIKHJA(int KOOLKCPAFBB, LALIAMPJIPE HFOOBLKJDEM)
	{
		return default(EMAAEODMJFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x77707D0", Offset = "0x776F9D0", VA = "0x1877707D0")]
	public void CMHNAFEKPEL(EMAAEODMJFK CGKPJBPKLPJ, LALIAMPJIPE HFOOBLKJDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x77710C0", Offset = "0x77702C0", VA = "0x1877710C0")]
	public bool LPAJHFAOEAK(EMAAEODMJFK CGKPJBPKLPJ, LALIAMPJIPE HFOOBLKJDEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x7770AC0", Offset = "0x776FCC0", VA = "0x187770AC0")]
	public void FJHENEDPJFK(LALIAMPJIPE HFOOBLKJDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7770EA0", Offset = "0x77700A0", VA = "0x187770EA0")]
	public bool KGGGBOEPNAK(EMAAEODMJFK CGKPJBPKLPJ, LALIAMPJIPE HFOOBLKJDEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7770FB0", Offset = "0x77701B0", VA = "0x187770FB0")]
	public bool LHDHCIAFKJP(LALIAMPJIPE HFOOBLKJDEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public BNGKCIMMGAI(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7770A30", Offset = "0x776FC30", VA = "0x187770A30", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(BNGKCIMMGAI LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct GKHAALIBGGI : IEquatable<GKHAALIBGGI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7778C20", Offset = "0x7777E20", VA = "0x187778C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7778CB0", Offset = "0x7777EB0", VA = "0x187778CB0")]
	public void OPCCMECNLFJ(bool OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7778B00", Offset = "0x7777D00", VA = "0x187778B00")]
	public void EEFGDLKLFCO(bool OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3494CA0", Offset = "0x3493EA0", VA = "0x183494CA0")]
	public T NCCDFGAONAI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public GKHAALIBGGI(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7778B90", Offset = "0x7777D90", VA = "0x187778B90", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(GKHAALIBGGI LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct OOAABJDICIL : IEquatable<OOAABJDICIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public bool JLIDDIIPHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7782790", Offset = "0x7781990", VA = "0x187782790")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x7782850", Offset = "0x7781A50", VA = "0x187782850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool BDBGNIHAKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x77827D0", Offset = "0x77819D0", VA = "0x1877827D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public int PENDINANMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x77825A0", Offset = "0x77817A0", VA = "0x1877825A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x7782700", Offset = "0x7781900", VA = "0x187782700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7782670", Offset = "0x7781870", VA = "0x187782670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public OOAABJDICIL(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x77825E0", Offset = "0x77817E0", VA = "0x1877825E0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(OOAABJDICIL LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct KGOBNNEOHLN : IEquatable<KGOBNNEOHLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public int MALJMBOELOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x777BF00", Offset = "0x777B100", VA = "0x18777BF00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x777BE60", Offset = "0x777B060", VA = "0x18777BE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public int NCJKCIPMHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x777BF40", Offset = "0x777B140", VA = "0x18777BF40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x777BEB0", Offset = "0x777B0B0", VA = "0x18777BEB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public KGOBNNEOHLN(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x777BDD0", Offset = "0x777AFD0", VA = "0x18777BDD0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(KGOBNNEOHLN LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct BIGCEBNLAGL : IEquatable<BIGCEBNLAGL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private FFMNDKHPAGB NDKCKFLAMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x776F850", Offset = "0x776EA50", VA = "0x18776F850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private MHIGGGAHMOH FFKNNOJFNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x776F430", Offset = "0x776E630", VA = "0x18776F430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool KIGKHGDOCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x776FDB0", Offset = "0x776EFB0", VA = "0x18776FDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool FCMJDLHDCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x776FBF0", Offset = "0x776EDF0", VA = "0x18776FBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool MGOHILPLPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x776FBC0", Offset = "0x776EDC0", VA = "0x18776FBC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool NIIAFECKHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x776F610", Offset = "0x776E810", VA = "0x18776F610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool LIJCGIKEAFH
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x776F5B0", Offset = "0x776E7B0", VA = "0x18776F5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool MDOHNILPMLM
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x776F490", Offset = "0x776E690", VA = "0x18776F490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool HCHLOGJFFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x776F040", Offset = "0x776E240", VA = "0x18776F040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public bool AKPHPJMAIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x776F6E0", Offset = "0x776E8E0", VA = "0x18776F6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public bool EKEHABNBJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x776FA20", Offset = "0x776EC20", VA = "0x18776FA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x776F520", Offset = "0x776E720", VA = "0x18776F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x776FC90", Offset = "0x776EE90", VA = "0x18776FC90")]
	public bool MLNGGHBEECA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x776F250", Offset = "0x776E450", VA = "0x18776F250")]
	public EMAAEODMJFK ANLKOAMMMOD(EMAAEODMJFK CGKPJBPKLPJ)
	{
		return default(EMAAEODMJFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x776F910", Offset = "0x776EB10", VA = "0x18776F910")]
	public EOFNBBMGHCB KJJJCOOEPBJ()
	{
		return default(EOFNBBMGHCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x776F2F0", Offset = "0x776E4F0", VA = "0x18776F2F0")]
	public bool DKPLAHBKOKB(EOFNBBMGHCB OMJMMBDJHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x776FE40", Offset = "0x776F040", VA = "0x18776FE40")]
	public bool OKCMNODBOAD(EOFNBBMGHCB MBPILKEFGMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x776FD00", Offset = "0x776EF00", VA = "0x18776FD00")]
	public bool MNHGFNANJAA(EOFNBBMGHCB CGKPJBPKLPJ, [Out] EOFNBBMGHCB OMJMMBDJHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public BIGCEBNLAGL(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x776F020", Offset = "0x776E220", VA = "0x18776F020")]
	public static bool AJAOLMPMCKD(BIGCEBNLAGL OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x776F3A0", Offset = "0x776E5A0", VA = "0x18776F3A0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(BIGCEBNLAGL LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct BKDHGPECJNF : IEquatable<BKDHGPECJNF>
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly BKDHGPECJNF NECABFCFJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public MLIAAFMGOKL LFFNMOEOGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x77700A0", Offset = "0x776F2A0", VA = "0x1877700A0")]
		get
		{
			return default(MLIAAFMGOKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public PKHDDMBNAMA IAOFMHCNKJM
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x77702B0", Offset = "0x776F4B0", VA = "0x1877702B0")]
		get
		{
			return default(PKHDDMBNAMA);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7770210", Offset = "0x776F410", VA = "0x187770210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public FEDDFCEHBJI ECAGAIIDDPB
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x7770500", Offset = "0x776F700", VA = "0x187770500")]
		get
		{
			return default(FEDDFCEHBJI);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x77703E0", Offset = "0x776F5E0", VA = "0x1877703E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public float EEPIOIFNIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x77703A0", Offset = "0x776F5A0", VA = "0x1877703A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7770540", Offset = "0x776F740", VA = "0x187770540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public Vector3 IIKDLAPLJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x776FF80", Offset = "0x776F180", VA = "0x18776FF80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x776FF00", Offset = "0x776F100", VA = "0x18776FF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public float PCOOOOEGKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7770350", Offset = "0x776F550", VA = "0x187770350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public HLJNCAAHCPJ CFHHIFLHCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x77700E0", Offset = "0x776F2E0", VA = "0x1877700E0")]
		get
		{
			return default(HLJNCAAHCPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7770430", Offset = "0x776F630", VA = "0x187770430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public bool FLAPDCADLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7770310", Offset = "0x776F510", VA = "0x187770310")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7770120", Offset = "0x776F320", VA = "0x187770120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public NFIDOEMCBCJ FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(NFIDOEMCBCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public NPMJNLBAGAE LFHJNLHDEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(NPMJNLBAGAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x7770000", Offset = "0x776F200", VA = "0x187770000")]
	public OGOPALLDJJE BJJNEGNADLC()
	{
		return default(OGOPALLDJJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x7770260", Offset = "0x776F460", VA = "0x187770260")]
	public CAMGGILPPIO GAEKFOPOCBO()
	{
		return default(CAMGGILPPIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7770050", Offset = "0x776F250", VA = "0x187770050")]
	private bool CEIFBFCIPLI(HLJNCAAHCPJ GONPIINPMBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7770480", Offset = "0x776F680", VA = "0x187770480")]
	public void PHMLFCJKHIE(HLJNCAAHCPJ GONPIINPMBP, bool ADOLAHFFGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public BKDHGPECJNF(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x776F020", Offset = "0x776E220", VA = "0x18776F020")]
	public static bool AJAOLMPMCKD(BKDHGPECJNF OMFJNFBDJCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x77702F0", Offset = "0x776F4F0", VA = "0x1877702F0")]
	public static bool GHFFJAPPGNB(BKDHGPECJNF IHGFIECIOLJ, BKDHGPECJNF FHOBAJOBBGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7770180", Offset = "0x776F380", VA = "0x187770180", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(BKDHGPECJNF LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct OGOPALLDJJE : IEquatable<OGOPALLDJJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public BKDHGPECJNF EMBJCFIHBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(BKDHGPECJNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public PMLONBCCMJA NPPOAAKEKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7782530", Offset = "0x7781730", VA = "0x187782530")]
		get
		{
			return default(PMLONBCCMJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public OGOPALLDJJE(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x776F020", Offset = "0x776E220", VA = "0x18776F020")]
	public static bool AJAOLMPMCKD(OGOPALLDJJE OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x77824A0", Offset = "0x77816A0", VA = "0x1877824A0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(OGOPALLDJJE LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DefaultMember("Item")]
public readonly struct CAMGGILPPIO : IEquatable<CAMGGILPPIO>
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly CAMGGILPPIO NECABFCFJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	private CJDLAGOBLMH FNCBGKOGAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x77721F0", Offset = "0x77713F0", VA = "0x1877721F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public BKDHGPECJNF EMBJCFIHBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(BKDHGPECJNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public GOJEDHLHKHB AJEDFMBLPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7771AE0", Offset = "0x7770CE0", VA = "0x187771AE0")]
		get
		{
			return default(GOJEDHLHKHB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7771810", Offset = "0x7770A10", VA = "0x187771810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public IEnumerable<CLMGHJDLADB> KDHBHBKPEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7771ED0", Offset = "0x77710D0", VA = "0x187771ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public CLMGHJDLADB EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x77719C0", Offset = "0x7770BC0", VA = "0x1877719C0")]
		get
		{
			return default(CLMGHJDLADB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x77720D0", Offset = "0x77712D0", VA = "0x1877720D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public NFIDOEMCBCJ FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(NFIDOEMCBCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7771E40", Offset = "0x7771040", VA = "0x187771E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x77715F0", Offset = "0x77707F0", VA = "0x1877715F0")]
	public CLMGHJDLADB CJGOCCAKNMF(float3? LBPAIJGCICL, [Optional] quaternion? GLMEOLPKLCA, [Optional] Vector3? DIOKPOCPBHH)
	{
		return default(CLMGHJDLADB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x7771C10", Offset = "0x7770E10", VA = "0x187771C10")]
	public CLMGHJDLADB GMILALKDDAH(int KOOLKCPAFBB, float3? LBPAIJGCICL, [Optional] quaternion? GLMEOLPKLCA, [Optional] Vector3? DIOKPOCPBHH)
	{
		return default(CLMGHJDLADB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7772250", Offset = "0x7771450", VA = "0x187772250")]
	public void OFIGKBFCILK(int KOOLKCPAFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7772160", Offset = "0x7771360", VA = "0x187772160")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public CAMGGILPPIO(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x776F020", Offset = "0x776E220", VA = "0x18776F020")]
	public static bool AJAOLMPMCKD(CAMGGILPPIO OMFJNFBDJCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7771AD0", Offset = "0x7770CD0", VA = "0x187771AD0")]
	public static bool GJNOMHNHJKL(CAMGGILPPIO IHGFIECIOLJ, CAMGGILPPIO FHOBAJOBBGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7771930", Offset = "0x7770B30", VA = "0x187771930", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(CAMGGILPPIO LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct CLMGHJDLADB : IEquatable<CLMGHJDLADB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public CAMGGILPPIO ICAIMJKPOID
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x77745B0", Offset = "0x77737B0", VA = "0x1877745B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public float3 JLOEFHABMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7774550", Offset = "0x7773750", VA = "0x187774550")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7774690", Offset = "0x7773890", VA = "0x187774690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public quaternion DNDIEJBKBAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x77743C0", Offset = "0x77735C0", VA = "0x1877743C0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7774410", Offset = "0x7773610", VA = "0x187774410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public float3 MCFPOCEPGLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7774630", Offset = "0x7773830", VA = "0x187774630")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7774460", Offset = "0x7773660", VA = "0x187774460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public KCJNGLILOOA JMOKOICOKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7774700", Offset = "0x7773900", VA = "0x187774700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x77746F0", Offset = "0x77738F0", VA = "0x1877746F0")]
	public void KOBAFNLNMPF(CAMGGILPPIO OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public CLMGHJDLADB(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x77744C0", Offset = "0x77736C0", VA = "0x1877744C0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(CLMGHJDLADB LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct PPONHJBDJKA : IEquatable<PPONHJBDJKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	private NFGNGPFKAHM NPJMNPFEGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7783580", Offset = "0x7782780", VA = "0x187783580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public bool ONMPAAGNNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7783780", Offset = "0x7782980", VA = "0x187783780")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7783520", Offset = "0x7782720", VA = "0x187783520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public bool MDKOLAFFCLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7783900", Offset = "0x7782B00", VA = "0x187783900")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7783030", Offset = "0x7782230", VA = "0x187783030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public float CHKCDBBGDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7782E30", Offset = "0x7782030", VA = "0x187782E30")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x77831C0", Offset = "0x77823C0", VA = "0x1877831C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public bool JJNOGDFNKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x77834D0", Offset = "0x77826D0", VA = "0x1877834D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7783090", Offset = "0x7782290", VA = "0x187783090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7783260", Offset = "0x7782460", VA = "0x187783260")]
	public void HKGJOPIAJAB(int CMDONCAECIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x77835E0", Offset = "0x77827E0", VA = "0x1877835E0")]
	public bool MDGLFBGFIDB([Out] int CMDONCAECIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7783120", Offset = "0x7782320", VA = "0x187783120")]
	public void GOKMKEGPIMN(bool OKJOPFAHLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7783210", Offset = "0x7782410", VA = "0x187783210")]
	public bool HFPGLPJAOFH(PLMMPJCBGLA GONPIINPMBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7783300", Offset = "0x7782500", VA = "0x187783300")]
	public void IALPMBFJEAG(PLMMPJCBGLA GONPIINPMBP, bool ADOLAHFFGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7783950", Offset = "0x7782B50", VA = "0x187783950")]
	public void PIBDGIEGJNJ(float PHNPGMOKMJF, float JCIPDOKFDJB, float PHJKFONKGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7783380", Offset = "0x7782580", VA = "0x187783380")]
	public void IOKOEBCKKLB(float3 LEPFGNDFPGC, quaternion KEDAGEIIKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x7782E70", Offset = "0x7782070", VA = "0x187782E70")]
	public bool EKMMPGFLPIM([Out] float3 LEPFGNDFPGC, [Out] quaternion KEDAGEIIKJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x77837D0", Offset = "0x77829D0", VA = "0x1877837D0")]
	public bool OIIHMKIDMIA([Out] float KKLIPDLHLBH, [Out] float LMIICANEIGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x77836F0", Offset = "0x77828F0", VA = "0x1877836F0")]
	public void MOFDCHFLHIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public PPONHJBDJKA(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7782FA0", Offset = "0x77821A0", VA = "0x187782FA0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(PPONHJBDJKA LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct NFIDOEMCBCJ : IEquatable<NFIDOEMCBCJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	private OOJGFGPONHL KADCEHOFPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x777E950", Offset = "0x777DB50", VA = "0x18777E950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public Vector3 JLOEFHABMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x777D790", Offset = "0x777C990", VA = "0x18777D790")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x777DE30", Offset = "0x777D030", VA = "0x18777DE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public Quaternion DNDIEJBKBAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x777CEF0", Offset = "0x777C0F0", VA = "0x18777CEF0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x777D590", Offset = "0x777C790", VA = "0x18777D590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public Vector3 IDHLNMPCLLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x777E5E0", Offset = "0x777D7E0", VA = "0x18777E5E0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x777E1C0", Offset = "0x777D3C0", VA = "0x18777E1C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public Quaternion CGNDLMDBNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x777EC20", Offset = "0x777DE20", VA = "0x18777EC20")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x777DC30", Offset = "0x777CE30", VA = "0x18777DC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public float GBHEHIAFDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x777D660", Offset = "0x777C860", VA = "0x18777D660")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x777D440", Offset = "0x777C640", VA = "0x18777D440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public float PLIBDAPJKME
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x777D4F0", Offset = "0x777C6F0", VA = "0x18777D4F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public Matrix4x4 AKAHEADHBGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x777DD00", Offset = "0x777CF00", VA = "0x18777DD00")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public NPMJNLBAGAE LFHJNLHDEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(NPMJNLBAGAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x777E0D0", Offset = "0x777D2D0", VA = "0x18777E0D0")]
	public MOCOMOJHGBP KHEBKMEBABD()
	{
		return default(MOCOMOJHGBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x777DFB0", Offset = "0x777D1B0", VA = "0x18777DFB0")]
	public void KFKLDJNMBMP([Out] Matrix4x4 DICECBFGCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x777D290", Offset = "0x777C490", VA = "0x18777D290")]
	public void CBHMEPEOPKA([In] Vector3 CHBIEDJMOLB, [In] Quaternion OAJCDGBGAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x777D1D0", Offset = "0x777C3D0", VA = "0x18777D1D0")]
	public void CBHMEPEOPKA([In] RigidTransform PJHMCCPEONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x777D390", Offset = "0x777C590", VA = "0x18777D390")]
	public void CDOAPOCOOPK([Out] RigidTransform PJHMCCPEONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x777E4E0", Offset = "0x777D6E0", VA = "0x18777E4E0")]
	public void NIAACAGMMMD([In] Vector3 NHDKAKBPDDN, [In] Quaternion NPMBEFPDOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x777E420", Offset = "0x777D620", VA = "0x18777E420")]
	public void NIAACAGMMMD([In] RigidTransform PLPKBFIHFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x777E870", Offset = "0x777DA70", VA = "0x18777E870")]
	public void ONNDJGDHGGH([Out] Vector3 NHDKAKBPDDN, [Out] Quaternion NPMBEFPDOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x777E7C0", Offset = "0x777D9C0", VA = "0x18777E7C0")]
	public void ONNDJGDHGGH([Out] RigidTransform PJHMCCPEONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x777E6D0", Offset = "0x777D8D0", VA = "0x18777E6D0")]
	public UniformTRS OHOICMPMIHF()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x777E700", Offset = "0x777D900", VA = "0x18777E700")]
	public void OHOICMPMIHF([Out] UniformTRS PLPKBFIHFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x777D880", Offset = "0x777CA80", VA = "0x18777D880")]
	public UniformTRS GJLJGIBHOBP()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x777D8B0", Offset = "0x777CAB0", VA = "0x18777D8B0")]
	public void GJLJGIBHOBP([Out] UniformTRS PJHMCCPEONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x777DD40", Offset = "0x777CF40", VA = "0x18777DD40")]
	public Vector3 JNBAFFMLLPF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x777DAB0", Offset = "0x777CCB0", VA = "0x18777DAB0")]
	public void GPIMGLLAMIF([In] Vector3 OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x777E290", Offset = "0x777D490", VA = "0x18777E290")]
	public Vector3 NCLMAELNDAK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x777D100", Offset = "0x777C300", VA = "0x18777D100")]
	public void BHDCOPFOIBD([In] Vector3 OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x777D970", Offset = "0x777CB70", VA = "0x18777D970")]
	public Quaternion GKFNDEDGBLD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x777D030", Offset = "0x777C230", VA = "0x18777D030")]
	public void BGJPEEADBAG([In] Quaternion OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x777EAE0", Offset = "0x777DCE0", VA = "0x18777EAE0")]
	public Quaternion PGBOCJJIAOG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x777EA10", Offset = "0x777DC10", VA = "0x18777EA10")]
	public void OOIBNHNHPNJ([In] Quaternion OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x777E380", Offset = "0x777D580", VA = "0x18777E380")]
	public float NHCOJNEFGFG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x777DB80", Offset = "0x777CD80", VA = "0x18777DB80")]
	public void IDBPGCKAGFO(float OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x777E120", Offset = "0x777D320", VA = "0x18777E120")]
	public float MHHCPOECKOC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x777DF00", Offset = "0x777D100", VA = "0x18777DF00")]
	public void JOLHJOBLIMF(float OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public NFIDOEMCBCJ(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x777D700", Offset = "0x777C900", VA = "0x18777D700", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(NFIDOEMCBCJ LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct MHNBDDJOKHA : IEquatable<MHNBDDJOKHA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	private FGBJJAHKFHC NHKCPPKOCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x777CA20", Offset = "0x777BC20", VA = "0x18777CA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	private NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776EAB0", VA = "0x18776F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	private DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x777CB10", Offset = "0x777BD10", VA = "0x18777CB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x777CBA0", Offset = "0x777BDA0", VA = "0x18777CBA0")]
	public void OAMCACILCLP(string DIOGKKBMGFI, DHPJJEOFEFK BOCHMICIIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public MHNBDDJOKHA(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x777CA80", Offset = "0x777BC80", VA = "0x18777CA80", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(MHNBDDJOKHA LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F0E0", VA = "0x18776FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct DIANDMMIKEE : IEquatable<DIANDMMIKEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public NBBHKCNOHOE PDMPPPIAEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x7775C20", Offset = "0x7774E20", VA = "0x187775C20")]
		get
		{
			return default(NBBHKCNOHOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public DIANDMMIKEE(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x7775B90", Offset = "0x7774D90", VA = "0x187775B90", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(DIANDMMIKEE LDKNLBHIGFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct HHJGDCFECAJ : IEquatable<HHJGDCFECAJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public struct IDFHANAMKCA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private EOFNBBMGHCB DEBNBMMFJPK;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x7779FE0", Offset = "0x77791E0", VA = "0x187779FE0")]
		public IDFHANAMKCA(EOFNBBMGHCB DEBNBMMFJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x7779F50", Offset = "0x7779150", VA = "0x187779F50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7779770", Offset = "0x7778970", VA = "0x187779770")]
	public IDFHANAMKCA ABMAOLJACIK()
	{
		return default(IDFHANAMKCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7779A80", Offset = "0x7778C80", VA = "0x187779A80")]
	public BPIPHJNPMGC FOIICFIBNPK(Allocator JNKCCGKBKPB = Allocator.Temp)
	{
		return default(BPIPHJNPMGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7779C30", Offset = "0x7778E30", VA = "0x187779C30")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> JDGOKFNLHFP(Allocator JNKCCGKBKPB = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7779E20", Offset = "0x7779020", VA = "0x187779E20")]
	public NativeArray<GLJKKHGGAPE> PINJIEKKPOD(Allocator JNKCCGKBKPB = Allocator.Temp)
	{
		return default(NativeArray<GLJKKHGGAPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x77798C0", Offset = "0x7778AC0", VA = "0x1877798C0")]
	public NativeArray<GLJKKHGGAPE> DALLDNCBLPD(Allocator JNKCCGKBKPB = Allocator.Temp)
	{
		return default(NativeArray<GLJKKHGGAPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7779800", Offset = "0x7778A00", VA = "0x187779800")]
	public AGCGHKEMDON BHBLMFMOLPA(Allocator JNKCCGKBKPB = Allocator.Temp)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x7779D60", Offset = "0x7778F60", VA = "0x187779D60")]
	public AGCGHKEMDON KDEFDGMJGLI(Allocator JNKCCGKBKPB = Allocator.Temp)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7779B70", Offset = "0x7778D70", VA = "0x187779B70")]
	public AGCGHKEMDON IFHACFKMPLE(Allocator JNKCCGKBKPB = Allocator.Temp)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public HHJGDCFECAJ(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x77799F0", Offset = "0x7778BF0", VA = "0x1877799F0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(HHJGDCFECAJ LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7774200", Offset = "0x7773400", VA = "0x187774200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct GKCHNCGIGDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public int BNNCLPODCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public int KCGLEHNKHPP;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct CIDHBPNLJAH : IEquatable<CIDHBPNLJAH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public HHJGDCFECAJ NJMDAOGGFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(HHJGDCFECAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public FLANIHAAOPH JLJAOJIPCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(FLANIHAAOPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public DIANDMMIKEE EOEOLCLFLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(DIANDMMIKEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7774160", Offset = "0x7773360", VA = "0x187774160")]
	public bool MKEPIANOOEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7773FF0", Offset = "0x77731F0", VA = "0x187773FF0")]
	public bool FENFMLEBMIM([Out] Exception OLLOHIKPLMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public CIDHBPNLJAH(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static EOFNBBMGHCB AJAOLMPMCKD(CIDHBPNLJAH OMFJNFBDJCA)
	{
		return default(EOFNBBMGHCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x7773F60", Offset = "0x7773160", VA = "0x187773F60", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(CIDHBPNLJAH LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x7774200", Offset = "0x7773400", VA = "0x187774200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct EKBJMNKDDBG : IDisposable, IEquatable<EKBJMNKDDBG>
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static readonly EKBJMNKDDBG NECABFCFJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public CIDHBPNLJAH CHLNKEOONOK
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(CIDHBPNLJAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public HHJGDCFECAJ NJMDAOGGFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(HHJGDCFECAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x7775E80", Offset = "0x7775080", VA = "0x187775E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public EKBJMNKDDBG(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7775F50", Offset = "0x7775150", VA = "0x187775F50", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "5")]
	public bool Equals(EKBJMNKDDBG LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7775FE0", Offset = "0x77751E0", VA = "0x187775FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct FLANIHAAOPH : IEquatable<FLANIHAAOPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public bool CFDNIJAHMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x7777B80", Offset = "0x7776D80", VA = "0x187777B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	public FLANIHAAOPH(EOFNBBMGHCB DEBNBMMFJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x776F5E0", Offset = "0x776E7E0", VA = "0x18776F5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7777AF0", Offset = "0x7776CF0", VA = "0x187777AF0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x776F390", Offset = "0x776E590", VA = "0x18776F390", Slot = "4")]
	public bool Equals(FLANIHAAOPH LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7774200", Offset = "0x7773400", VA = "0x187774200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class FIPHJMPHHBM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct LIHGOOABLMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Guid FGPNICIMMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public OEKHBACJAKC JJNFBOJIAAE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private struct OEKHBACJAKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int OMFJNFBDJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int FNENHOOMGMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int LIIKNAGFIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int ICPBLIJGCNL;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x77823C0", Offset = "0x77815C0", VA = "0x1877823C0")]
		public bool FKGLMDCOEEE([Out] GLJKKHGGAPE MEEPADKGNGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7782460", Offset = "0x7781660", VA = "0x187782460")]
		public OEKHBACJAKC(GLJKKHGGAPE MEEPADKGNGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7777A30", Offset = "0x7776C30", VA = "0x187777A30")]
	public static Guid NDKOEEBAFML(this GLJKKHGGAPE MEEPADKGNGG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7777AD0", Offset = "0x7776CD0", VA = "0x187777AD0")]
	public static bool NOJKFGMHFDJ(this Guid FGPNICIMMFP, [Out] GLJKKHGGAPE MEEPADKGNGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal static class OOEKOJPLDFK
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x77829B0", Offset = "0x7781BB0", VA = "0x1877829B0")]
	public static DGNODCBEMMF HBBAEGELGHL(this EOFNBBMGHCB JDNOHHGIHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7782AD0", Offset = "0x7781CD0", VA = "0x187782AD0")]
	public static LDFBPFEFEGF HPHKONGLMKK(this EOFNBBMGHCB JDNOHHGIHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7782A40", Offset = "0x7781C40", VA = "0x187782A40")]
	public static EntityManager HNLDMAKDHHI(this EOFNBBMGHCB JDNOHHGIHEO)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x3665160", Offset = "0x3664360", VA = "0x183665160")]
	internal static bool ENJBHGNOAAG<T>(this EOFNBBMGHCB JDNOHHGIHEO, bool ADOLAHFFGEC) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x77828A0", Offset = "0x7781AA0", VA = "0x1877828A0")]
	public static bool CCLCFMJHDGO(this EOFNBBMGHCB JDNOHHGIHEO, DJNFFIMKOOB AKOEHEOHLAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x3664940", Offset = "0x3663B40", VA = "0x183664940")]
	public static bool DCNHHFELJKM<T>(this EOFNBBMGHCB JDNOHHGIHEO) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x3665300", Offset = "0x3664500", VA = "0x183665300")]
	public static bool LMOPFEDMCMB<T>(this EOFNBBMGHCB JDNOHHGIHEO) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x36604F0", Offset = "0x365F6F0", VA = "0x1836604F0")]
	[DGJBMCAMLMK]
	public static T CEEPKNCKMHD<T>(this EOFNBBMGHCB JDNOHHGIHEO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x3661F10", Offset = "0x3661110", VA = "0x183661F10")]
	[DGJBMCAMLMK]
	public static T CMMDNHMJOHC<T>(this EOFNBBMGHCB JDNOHHGIHEO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x36650C0", Offset = "0x36642C0", VA = "0x1836650C0")]
	public static bool EKGHLEKOJBF<T>(this EOFNBBMGHCB JDNOHHGIHEO, [Out] T OMFJNFBDJCA) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x3665240", Offset = "0x3664440", VA = "0x183665240")]
	public static T HNNGOJCCAOO<T>(this EOFNBBMGHCB JDNOHHGIHEO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x36653B0", Offset = "0x36645B0", VA = "0x1836653B0")]
	public static T MDHLEDNFGGP<T>(this EOFNBBMGHCB JDNOHHGIHEO) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal static class LLBOFKIHLPP
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DefaultMember("Item")]
public struct BPIPHJNPMGC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AGCGHKEMDON HDPIMFNJLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> EIBIICPMANL;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x563CDF0", Offset = "0x563BFF0", VA = "0x18563CDF0")]
	public BPIPHJNPMGC(AGCGHKEMDON HDPIMFNJLMN, NativeArray<EntityRemapUtility.EntityRemapInfo> EIBIICPMANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7771560", Offset = "0x7770760", VA = "0x187771560")]
	public LocalId IBKDJAFECPK(LocalId ONELFPFEALD)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x77715A0", Offset = "0x77707A0", VA = "0x1877715A0")]
	public LocalId IBKDJAFECPK(int KOOLKCPAFBB)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x77714F0", Offset = "0x77706F0", VA = "0x1877714F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KEIMAMLEGJC
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	Guid GGIHJIHNELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	Guid LLHGEBFGJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EBAFKDNEOIC(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task LBMJNONJLIH(EMAAEODMJFK ONELFPFEALD);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid FAHGFJIFFLN(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HEJEGLGONOJ(EOFNBBMGHCB DEBNBMMFJPK, Guid JACMIDKJGCD);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HLOLBKCPOIN(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task DFDKHMODCND(EOFNBBMGHCB OAOLODPFDMA, EOFNBBMGHCB JNGEIJHHFEP);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NLKJLDLBILP
{
	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	Guid GGIHJIHNELN
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDOPDNLHPIP(NativeList<Guid> JMMJBFGIHGI, NativeList<Guid> HOIAJHFKGEC, NativeList<FixedString64Bytes> JNAFOPPEOJE);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AKIHPMNKOBK
{
	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AGCGHKEMDON EFAEFKGCDCK(Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AGCGHKEMDON OACBCBMLLHL(Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLMPAPFGKLG(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BDBGNIHAKOP(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JLIDDIIPHKG(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CHBCNJMMFHI(EOFNBBMGHCB MOEJABALFBA, int MJBKPLCECIO);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EOFNBBMGHCB GEKOFPPHFND(EOFNBBMGHCB KCHFBCNNPGM);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FPILNGBFDLK(AGCGHKEMDON JBPFPBKHHLE, bool HBIJKHFLLOO);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MBLHBKGFMIB(EOFNBBMGHCB BNMNHJKEFGM, bool BJCGPKNDPCL);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GOBFLHKDMBJ(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KBBPPOADCOM(EOFNBBMGHCB MOEJABALFBA, bool MJEOEHNBOBB);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int EJCOJEODFPP();
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JLBPLEBDGLO
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<EOFNBBMGHCB, EOFNBBMGHCB> KHIAGPDKDCN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<EOFNBBMGHCB, EOFNBBMGHCB> GAKLODBJCJO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<EOFNBBMGHCB, EOFNBBMGHCB, EOFNBBMGHCB> NKPKGIMHADH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<EOFNBBMGHCB> MKMJNBBBLDB;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LOELIPFDKMJ(EOFNBBMGHCB DEBNBMMFJPK, EOFNBBMGHCB NHLKLNOMEDA);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EOFNBBMGHCB DBGBKMDPACN(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AGCGHKEMDON CNCCIMBGALJ(EOFNBBMGHCB DEBNBMMFJPK, Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EOFNBBMGHCB LGBACIAAODA(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OIIMBIFDBME(EOFNBBMGHCB DEBNBMMFJPK, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JIEDOKECKFB(EOFNBBMGHCB DEBNBMMFJPK, float IKKLIBHMPKI);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool GKODNLDFBML(EOFNBBMGHCB DEBNBMMFJPK, [Out] EOFNBBMGHCB JNGEIJHHFEP);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool HCNCKAHEHEK(EOFNBBMGHCB DEBNBMMFJPK, [Out] RigidTransform FPPGPGMGHCK);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 LKKNIIBHKFK(CCOFJFAFCIN PGEJNBOCJDO);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion CGFPLDHKKIL(CCOFJFAFCIN PGEJNBOCJDO);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class BKMMFIFFDBN
{
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JOMICHNIGIC
{
	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	object AEFBLOLDHOB
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GCDDPENHOMM
{
	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMLBNFIFEFN(EOFNBBMGHCB ONELFPFEALD, JLHFMODMEEH MDCLBIIGDEE);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHHIAPABGDA(JLHFMODMEEH MDCLBIIGDEE);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ALELOLAPBDO(EOFNBBMGHCB DEBNBMMFJPK, [Out] JLHFMODMEEH FKJEDJGKLGH);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[Flags]
public enum OAGDCEKMCAG
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public readonly struct CAJALIJMEKM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly string MBDFMCIDAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly T OGPHJJMKHNA;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x59DD360", Offset = "0x59DC560", VA = "0x1859DD360")]
	public CAJALIJMEKM(T OGPHJJMKHNA, [Optional][CallerMemberName] string MBDFMCIDAOB)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public static readonly CAJALIJMEKM<int> JGIHMHLDDBN;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public static readonly CAJALIJMEKM<int> JINEGKADOEH;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static readonly CAJALIJMEKM<int> IMFHKPHLJEJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public enum FGHBKHIDGOG
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class HCMEDPCLECC
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x10A29C0", Offset = "0x10A1BC0", VA = "0x1810A29C0")]
	public static bool DLNOFHKMGDF(this FGHBKHIDGOG LEOMHHEDCFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x146AB50", Offset = "0x1469D50", VA = "0x18146AB50")]
	public static bool DBCGOPHJKHH(this FGHBKHIDGOG LEOMHHEDCFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x2BD45B0", Offset = "0x2BD37B0", VA = "0x182BD45B0")]
	public static bool NEENLBGKOJH(this FGHBKHIDGOG LEOMHHEDCFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FFKODMBDGIE
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum JHAEIBPGADH
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public enum HCBIDJCKLHA
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	JHAEIBPGADH IANDKJINLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	bool DGBPNGHIKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	bool JNJINAFOMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	HCBIDJCKLHA DBKLLCDCLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.Application)]
public interface BGFELIIGDMG
{
	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	FGHBKHIDGOG BOCFOJBHHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	FGHBKHIDGOG KFABHKFANJO
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	FGHBKHIDGOG KBAINEKKACE
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	FGHBKHIDGOG ILGAGJANMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	FGHBKHIDGOG CNJOIHOCLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	FGHBKHIDGOG GACHOFAJBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	FGHBKHIDGOG BKNFOFCMFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	FGHBKHIDGOG GHIPKOHDBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	FGHBKHIDGOG PCBNGBIJLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	FGHBKHIDGOG OGDDAJNMOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	FGHBKHIDGOG HDMJOECMKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	FGHBKHIDGOG OFOPOLAGCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	FGHBKHIDGOG FBAABDFHNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	FGHBKHIDGOG HBOCIKFINJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	FGHBKHIDGOG ICKNEGLAKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	FGHBKHIDGOG JCNBAOLMGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	FGHBKHIDGOG HMCOFNBANBP
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NKAAMPBENGI(CAJALIJMEKM<int> PEFAADKBJGB);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LNBGIMMJJPA
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event HCAOGLINDLA.CDGLDEFIDLP KAJIIJKPDEO;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EOFNBBMGHCB ILACEJDGCCK(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AGCGHKEMDON CDLCEIBDHOP(Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KCJNGLILOOA HBJMLOHOOLF(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ENCPBJBJJLM(IEnumerable<EOFNBBMGHCB> MJNPIAGECBO);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KCJNGLILOOA FHHNDKJOELN(EOFNBBMGHCB JNGEIJHHFEP, EOFNBBMGHCB HDPIMFNJLMN, bool ANECNBOEONP, EOFNBBMGHCB CGKPJBPKLPJ);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EOFNBBMGHCB KDDMJMFFAFG(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JGMGHHENICE(EOFNBBMGHCB DEBNBMMFJPK, EOFNBBMGHCB JNGEIJHHFEP, bool EMDONHAPMNL = false);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DJOBFGKALBG(EOFNBBMGHCB DEBNBMMFJPK, EOFNBBMGHCB JNGEIJHHFEP);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PNICEDNNKFF(EOFNBBMGHCB EJINAEPEOBL, EOFNBBMGHCB HCGFHALPPOL);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	AGCGHKEMDON OMPGGKPAMOH(EOFNBBMGHCB BNMNHJKEFGM);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DIBNMJPNFDA(EOFNBBMGHCB DEBNBMMFJPK, EOFNBBMGHCB LHGPEFOENHC);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AGCGHKEMDON DNCFEOFLFGD(AGCGHKEMDON INKKLGKFLFO, OAGDCEKMCAG BCFKGGKKKIL, Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool MDPCOMDEDGL(EOFNBBMGHCB DEBNBMMFJPK, EOFNBBMGHCB GBDMMBHHOEC);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EOFNBBMGHCB BCANMBGGMCI(EOFNBBMGHCB CGKPJBPKLPJ, EOFNBBMGHCB GMDEBLOJNJH);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool ECDKADODHML(EOFNBBMGHCB CGKPJBPKLPJ, EOFNBBMGHCB GMDEBLOJNJH, [Out] EOFNBBMGHCB NNMDOBEOJHM);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	EOFNBBMGHCB IOPNKHPMIFD(EOFNBBMGHCB[] JBPFPBKHHLE);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	EOFNBBMGHCB FJGMECHJBLP(EOFNBBMGHCB DEBNBMMFJPK, uint DKLDNLNNPDM);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class HGAFCBFABLI
{
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x7779520", Offset = "0x7778720", VA = "0x187779520")]
	public static bool JBNFKMDMFCO(this LNBGIMMJJPA PCFNMJHFPCI, EOFNBBMGHCB DEBNBMMFJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x7779210", Offset = "0x7778410", VA = "0x187779210")]
	public static AGCGHKEMDON DNCFEOFLFGD(this LNBGIMMJJPA CIHBAGEHELN, EOFNBBMGHCB DEBNBMMFJPK, OAGDCEKMCAG BCFKGGKKKIL, Allocator JNKCCGKBKPB)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x77796F0", Offset = "0x77788F0", VA = "0x1877796F0")]
	public static AGCGHKEMDON NKIBGGFELDE(this LNBGIMMJJPA CIHBAGEHELN, EOFNBBMGHCB DEBNBMMFJPK, Allocator JNKCCGKBKPB)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7779730", Offset = "0x7778930", VA = "0x187779730")]
	public static AGCGHKEMDON POICGFCIMCA(this LNBGIMMJJPA CIHBAGEHELN, EOFNBBMGHCB DEBNBMMFJPK, Allocator JNKCCGKBKPB)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x7779190", Offset = "0x7778390", VA = "0x187779190")]
	public static AGCGHKEMDON ACKDDHAOFLJ(this LNBGIMMJJPA CIHBAGEHELN, EOFNBBMGHCB DEBNBMMFJPK, Allocator JNKCCGKBKPB)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x77794E0", Offset = "0x77786E0", VA = "0x1877794E0")]
	public static AGCGHKEMDON ELLEDFLOODE(this LNBGIMMJJPA CIHBAGEHELN, EOFNBBMGHCB DEBNBMMFJPK, Allocator JNKCCGKBKPB)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x77791D0", Offset = "0x77783D0", VA = "0x1877791D0")]
	public static AGCGHKEMDON COOIMBLBJHL(this LNBGIMMJJPA CIHBAGEHELN, EOFNBBMGHCB DEBNBMMFJPK, Allocator JNKCCGKBKPB)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x77794A0", Offset = "0x77786A0", VA = "0x1877794A0")]
	public static AGCGHKEMDON DNCFEOFLFGD(this LNBGIMMJJPA CIHBAGEHELN, EOFNBBMGHCB DEBNBMMFJPK, Allocator JNKCCGKBKPB)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x77796B0", Offset = "0x77788B0", VA = "0x1877796B0")]
	public static AGCGHKEMDON MENEBBJFMKJ(this LNBGIMMJJPA CIHBAGEHELN, EOFNBBMGHCB DEBNBMMFJPK, Allocator JNKCCGKBKPB)
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x7779590", Offset = "0x7778790", VA = "0x187779590")]
	public static AGCGHKEMDON MENEBBJFMKJ(this LNBGIMMJJPA CIHBAGEHELN, AGCGHKEMDON DEBNBMMFJPK, Allocator JNKCCGKBKPB)
	{
		return default(AGCGHKEMDON);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OIJCFPMJCJM
{
	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJEHHIGLHHI MIKBGHCIHCM(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKCBBABAOEP(EOFNBBMGHCB MOEJABALFBA, EJEHHIGLHHI EMBMMECBDOM);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BOLBJLPCCED(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEHMKFBMEBB(EOFNBBMGHCB MOEJABALFBA, bool OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AIPBCFHHAOO<string> JAKOGELEBND(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHHBBMCKIIH(EOFNBBMGHCB MOEJABALFBA, AIPBCFHHAOO<string> ANPAKJGAMFF);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AIPBCFHHAOO<string> PLDOKKHJKMD(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DMPAFFKNINJ(EOFNBBMGHCB MOEJABALFBA, AIPBCFHHAOO<string> ANPAKJGAMFF);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AIPBCFHHAOO<string> OKJFLHDAIPI(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EAMMDCOPLPB(EOFNBBMGHCB MOEJABALFBA, AIPBCFHHAOO<string> ANPAKJGAMFF);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AIPBCFHHAOO<string> PMCPIEOCBBN(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EDGIONMBJBA(EOFNBBMGHCB MOEJABALFBA, AIPBCFHHAOO<string> ANPAKJGAMFF);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HPJMFHFLGGL(EOFNBBMGHCB MOEJABALFBA, EOFNBBMGHCB NCAFEKBCKBL);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MPEPKMBGHPK
{
	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x777CDF0", Offset = "0x777BFF0", VA = "0x18777CDF0", Slot = "0")]
	Task<CIDHBPNLJAH> PIKIDBAPHLJ(MLMGHINDMEL KCEGEGHJLLK, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "1")]
	void OLIKMNDPNAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DOAJILOHGAC
{
	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	bool OEKLPCFMPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	bool FLLHEJMPENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	bool ODDCIJLNHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BEHFOGDCNMI
{
	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGMKNNBCGII([In] float3 MEPDDJJJJDK, [In] float3 FOKNLDGGKBN, float DLABDKKOOMK, [Out] HBMEHDPEFHN ODPMDELKGNM, [Out] EOFNBBMGHCB GBAEHOGFOIG);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int COIIMHNMFBJ([In] float3 MEPDDJJJJDK, float LDCGEIMNGOD, List<EOFNBBMGHCB> JBPFPBKHHLE);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int IEOJPIGAEBO(Plane[] JHAHKIKENLL, float3 MEPDDJJJJDK, float3 GMFJFGMGAGG, quaternion GLMEOLPKLCA, List<EOFNBBMGHCB> JBPFPBKHHLE);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KBJGCAILACN
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGMKNNBCGII([In] NativeArray<Entity> DNOHLBIMBBG, [In] float3 MEPDDJJJJDK, [In] float3 FOKNLDGGKBN, [In] NativeArray<HBMEHDPEFHN> FMIMMCBIFLI);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> COIIMHNMFBJ([In] NativeArray<Entity> DNOHLBIMBBG, [In] float3 MEPDDJJJJDK, float LDCGEIMNGOD);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> IEOJPIGAEBO([In] NativeArray<Entity> DNOHLBIMBBG, [In] NativeArray<float4> AKHFFJAHANN);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct GGBNOPAGCFD : FGEPICOCPFA, IEquatable<GGBNOPAGCFD>
{
	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public int PGEMEJBADFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x1123120", Offset = "0x1122320", VA = "0x181123120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public int DAIODIGKFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BF46E0", Offset = "0x2BF38E0", VA = "0x182BF46E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x68B29B0", Offset = "0x68B1BB0", VA = "0x1868B29B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x7778A60", Offset = "0x7777C60", VA = "0x187778A60", Slot = "8")]
	public bool Equals(GGBNOPAGCFD LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x7778AB0", Offset = "0x7777CB0", VA = "0x187778AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct HBMEHDPEFHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float CEJLPIDBNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float3 HFFGEMAKAAC;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FNMDCPLBENO
{
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NFIPPAIECID
{
	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	JJFMKOLCMMG GNFHJMEAINM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<AGCGHKEMDON, NativeArray<RRObjectPrefabData>> EKHBEMNIIOF;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<AGCGHKEMDON> BJACHFKIDHM;

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JLPIDFFKDDB LEMKMBCFGHG(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	RRObjectPrefabData GDHCBLOELCG(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KHAHHJOCEMH(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EMAAEODMJFK LEEDNAPGLJD(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PLIONGIMJOH(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AKEOAPPAENB(EOFNBBMGHCB DEBNBMMFJPK, [Out] Transform LBAHEDDLOKA);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EOFNBBMGHCB OICPICIEGEC(GLJKKHGGAPE MEEPADKGNGG);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool MNBHMNFDKJC(GLJKKHGGAPE MEEPADKGNGG, [Out] EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GLJKKHGGAPE OPAOENKEECF(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AGCGHKEMDON OICPICIEGEC(NativeArray<GLJKKHGGAPE> MEEPADKGNGG, Allocator JNKCCGKBKPB, bool HMBJBFBMMPF = true);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KAFMBBMAJNE(RRObjectPrefabData ACLLIENJBND, NativeArray<Entity> DNOHLBIMBBG);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool OGAPJGEOMIB(NativeArray<OHGNHEIPCDK> EDJBMPGPOFI, NativeArray<GLJKKHGGAPE> BFHONDNFOPM, NativeArray<Entity> FCHGEDKELDK);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	EMAAEODMJFK DDDDABKMBFK();

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	EMAAEODMJFK CCGKEEAILHP(RRObjectPrefabData ACLLIENJBND);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	OEJHPIPEIAI DAOLDLJBEKA();

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	CAMGGILPPIO FCNBHBFKMNG();

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "22")]
	OGOPALLDJJE GBJOPLPEIDP(PMLONBCCMJA OJGHHFOFNML);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void ICCOFOBEEKO();

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IKFHDABMIEN(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool EMLBJCMLNBC(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "26")]
	AGCGHKEMDON AGBEOCBMFIN(AGCGHKEMDON KCBCDBEKAMM, Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DFFCJNIAGEE(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "28")]
	EOFNBBMGHCB JKEIFPDODJF(Transform LBAHEDDLOKA);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class COKHPCAHABG
{
	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x7774760", Offset = "0x7773960", VA = "0x187774760")]
	internal static EOFNBBMGHCB IAJODLPLEAK(this Entity JJMNGBLHAJC, NFIPPAIECID BOCHMICIIMO)
	{
		return default(EOFNBBMGHCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7774750", Offset = "0x7773950", VA = "0x187774750")]
	public static EMAAEODMJFK HOHLNJMGFKA(this NFIPPAIECID BOCHMICIIMO, LocalId DEBNBMMFJPK)
	{
		return default(EMAAEODMJFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7774D30", Offset = "0x7773F30", VA = "0x187774D30")]
	public static EOFNBBMGHCB OICPICIEGEC(this NFIPPAIECID BOCHMICIIMO, LocalId DEBNBMMFJPK)
	{
		return default(EOFNBBMGHCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x7774DE0", Offset = "0x7773FE0", VA = "0x187774DE0")]
	public static GLJKKHGGAPE OPAOENKEECF(this NFIPPAIECID BOCHMICIIMO, LocalId DEBNBMMFJPK)
	{
		return default(GLJKKHGGAPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x7774840", Offset = "0x7773A40", VA = "0x187774840")]
	public static OEJHPIPEIAI IPKKPHKGAGE(this NFIPPAIECID BOCHMICIIMO, RigidTransform PLPKBFIHFIJ)
	{
		return default(OEJHPIPEIAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x7774B80", Offset = "0x7773D80", VA = "0x187774B80")]
	public static OGOPALLDJJE OHDGDNMJBHA(this NFIPPAIECID BOCHMICIIMO, PMLONBCCMJA KFKGNOABOBA, RigidTransform PLPKBFIHFIJ)
	{
		return default(OGOPALLDJJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x77749E0", Offset = "0x7773BE0", VA = "0x1877749E0")]
	public static CAMGGILPPIO OCMPGODOGAB(this NFIPPAIECID BOCHMICIIMO, RigidTransform PLPKBFIHFIJ)
	{
		return default(CAMGGILPPIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x7774810", Offset = "0x7773A10", VA = "0x187774810")]
	private static void IPDBAKBJEGC(EMAAEODMJFK MPHJJFLAGJO, RigidTransform PLPKBFIHFIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal interface DFFHCLFIGPH
{
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FFMNDKHPAGB
{
	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	bool OMOACPPMPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	EOFNBBMGHCB OBMFNIIEAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	EMAAEODMJFK ECDLBPGGCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event JIOFBAKNKAB OCJENCHKJEN;

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EOFNBBMGHCB BCANMBGGMCI(EOFNBBMGHCB CGKPJBPKLPJ, EOFNBBMGHCB GMDEBLOJNJH);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ECDKADODHML(EOFNBBMGHCB CGKPJBPKLPJ, EOFNBBMGHCB GMDEBLOJNJH, [Out] EOFNBBMGHCB NNMDOBEOJHM);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ANCKFHKAEFD();

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IDBCOLPNKDC();

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KIGKHGDOCHO(EOFNBBMGHCB CGKPJBPKLPJ);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MDOHNILPMLM(EOFNBBMGHCB CGKPJBPKLPJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public delegate void JIOFBAKNKAB(EMAAEODMJFK FPGJMGDCDPA, EMAAEODMJFK DNHDKLOHDPD);
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class FGBIDINLFFO
{
	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x7777760", Offset = "0x7776960", VA = "0x187777760")]
	public static bool BDIILBFDHLF(this FFMNDKHPAGB NIBDMEFEABI, EMAAEODMJFK CGKPJBPKLPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x77777B0", Offset = "0x77769B0", VA = "0x1877777B0")]
	public static bool DMDIIKOJNMO(this FFMNDKHPAGB NIBDMEFEABI, EOFNBBMGHCB CGKPJBPKLPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x7777890", Offset = "0x7776A90", VA = "0x187777890")]
	public static bool NIIAFECKHML(this FFMNDKHPAGB NIBDMEFEABI, EOFNBBMGHCB CGKPJBPKLPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CCPBNMAKFOL
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMIBDGCGMEH(NativeList<RRObjectPrefabData> IBPIFHPJKOB);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ONEJMAJJLDL
{
	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CMKNNKCLDCH(EMAAEODMJFK MPHJJFLAGJO, LALIAMPJIPE HFOOBLKJDEM, List<EMAAEODMJFK> CHPLKOOFBMG);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JOMIEAEDHLD(EMAAEODMJFK MPHJJFLAGJO, LALIAMPJIPE HFOOBLKJDEM);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADNBMNCKENM(EMAAEODMJFK MPHJJFLAGJO, List<EMAAEODMJFK> CHPLKOOFBMG);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ANDIFPOIJPH(EMAAEODMJFK CMDONCAECIK, EMAAEODMJFK CGKPJBPKLPJ, LALIAMPJIPE HFOOBLKJDEM);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EMAAEODMJFK JIAONKIKHJA(EMAAEODMJFK CMDONCAECIK, int KOOLKCPAFBB, LALIAMPJIPE HFOOBLKJDEM);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CMHNAFEKPEL(EMAAEODMJFK CMDONCAECIK, EMAAEODMJFK CGKPJBPKLPJ, LALIAMPJIPE HFOOBLKJDEM);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LPAJHFAOEAK(EMAAEODMJFK CMDONCAECIK, EMAAEODMJFK CGKPJBPKLPJ, LALIAMPJIPE HFOOBLKJDEM);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FJHENEDPJFK(EMAAEODMJFK CMDONCAECIK, LALIAMPJIPE HFOOBLKJDEM);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KGGGBOEPNAK(EMAAEODMJFK CMDONCAECIK, EMAAEODMJFK CGKPJBPKLPJ, LALIAMPJIPE HFOOBLKJDEM);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GDBINHFGDGF(Entity CMDONCAECIK, Entity CGKPJBPKLPJ, LALIAMPJIPE HFOOBLKJDEM);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BAKLBKPBJHI(Entity CMDONCAECIK, LALIAMPJIPE HFOOBLKJDEM);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LHDHCIAFKJP(EMAAEODMJFK CGKPJBPKLPJ, LALIAMPJIPE HFOOBLKJDEM);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MIONGIINOJP
{
	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	DIANDMMIKEE OKDOAMOKLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBBHKCNOHOE LMGIJJNANON(DIANDMMIKEE ILIEDPLAPMG);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DIANDMMIKEE JMNLCLAHHIJ();

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DIANDMMIKEE BKKJMEDHIHH();
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MHIGGGAHMOH
{
	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DKPLAHBKOKB(EOFNBBMGHCB CGKPJBPKLPJ, EOFNBBMGHCB OMJMMBDJHIL);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OKCMNODBOAD(EOFNBBMGHCB CGKPJBPKLPJ, EOFNBBMGHCB MBPILKEFGMH);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MNHGFNANJAA(EOFNBBMGHCB CGKPJBPKLPJ, [Out] EOFNBBMGHCB LBBINEAGIMP);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FBPDLNHKKFN
{
	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPCCMECNLFJ(EOFNBBMGHCB BNMNHJKEFGM, bool OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEFGDLKLFCO(EOFNBBMGHCB BNMNHJKEFGM, bool OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KOLHAHCPNJH(EOFNBBMGHCB BNMNHJKEFGM, int OMFJNFBDJCA);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CJDLAGOBLMH
{
	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<EOFNBBMGHCB> EKDBAKBKKIM(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EOFNBBMGHCB NBMMAMAKBLG(EOFNBBMGHCB DEBNBMMFJPK, int KOOLKCPAFBB);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int OKGJLHAJCEE(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GOJEDHLHKHB EIIFHAGPNGG(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPFPJNPGANM(EOFNBBMGHCB DEBNBMMFJPK, GOJEDHLHKHB BNHLGDBCCDH);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EOFNBBMGHCB BAKBHENENDG(EOFNBBMGHCB DEBNBMMFJPK, [Optional] float3? LBPAIJGCICL, [Optional] quaternion? GLMEOLPKLCA, [Optional] float3? DIOKPOCPBHH);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EOFNBBMGHCB NMDDBOBBFLB(EOFNBBMGHCB DEBNBMMFJPK, int KOOLKCPAFBB, [Optional] float3? LBPAIJGCICL, [Optional] quaternion? GLMEOLPKLCA, [Optional] float3? DIOKPOCPBHH);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FDMCEECMKIM(EOFNBBMGHCB DEBNBMMFJPK, int KOOLKCPAFBB);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KEDMNAHOCIK(EOFNBBMGHCB DEBNBMMFJPK);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EHHCKAFMNEK
{
	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	bool OFBLEHEGNNF
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JMCMMMPGPDC();

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPHGCJBLOOP();

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJHLEODGOOB();

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NICNCMPGLBJ();

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BFGICHHJIDM();

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LJGCOOJGEIP();

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IOAHHHOEADK();

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JCJIHNAHLEC();

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NHCCJFMGEDP();

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DGJDDBDEPCJ();

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JGCMHAHKPOL();

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GOAHOPBEIDH();
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NFGNGPFKAHM
{
	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MDGLFBGFIDB(EOFNBBMGHCB CGKPJBPKLPJ, [Out] int CMDONCAECIK);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKGJOPIAJAB(EOFNBBMGHCB CGKPJBPKLPJ, int CMDONCAECIK);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOKMKEGPIMN(EOFNBBMGHCB CGKPJBPKLPJ, bool OKJOPFAHLKO);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PIBDGIEGJNJ(EOFNBBMGHCB CGKPJBPKLPJ, float PHNPGMOKMJF, float JCIPDOKFDJB, float PHJKFONKGFN);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OIIHMKIDMIA(EOFNBBMGHCB DEBNBMMFJPK, [Out] float JCIPDOKFDJB, [Out] float PHJKFONKGFN);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IOKOEBCKKLB(EOFNBBMGHCB CGKPJBPKLPJ, float3 LBPAIJGCICL, quaternion GLMEOLPKLCA);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EKMMPGFLPIM(EOFNBBMGHCB CGKPJBPKLPJ, [Out] float3 LBPAIJGCICL, [Out] quaternion GLMEOLPKLCA);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MOFDCHFLHIB(EOFNBBMGHCB CGKPJBPKLPJ);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OOJGFGPONHL
{
	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPIMGLLAMIF(Entity JJMNGBLHAJC, [In] float3 OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 JNBAFFMLLPF(Entity JJMNGBLHAJC);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGJPEEADBAG(Entity JJMNGBLHAJC, [In] quaternion OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion GKFNDEDGBLD(Entity JJMNGBLHAJC);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CBHMEPEOPKA(Entity JJMNGBLHAJC, [In] float3 LBPAIJGCICL, [In] quaternion GLMEOLPKLCA);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDOAPOCOOPK(Entity JJMNGBLHAJC, [Out] RigidTransform BCKDPBDOEKG);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NIAACAGMMMD(Entity JJMNGBLHAJC, [In] float3 LBPAIJGCICL, [In] quaternion GLMEOLPKLCA);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ONNDJGDHGGH(Entity JJMNGBLHAJC, [Out] float3 LBPAIJGCICL, [Out] quaternion GLMEOLPKLCA);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ONNDJGDHGGH(Entity JJMNGBLHAJC, [Out] RigidTransform BCKDPBDOEKG);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IDBPGCKAGFO(Entity JJMNGBLHAJC, float OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float NHCOJNEFGFG(Entity JJMNGBLHAJC);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BHDCOPFOIBD(Entity JJMNGBLHAJC, [In] float3 OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 NCLMAELNDAK(Entity JJMNGBLHAJC);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OOIBNHNHPNJ(Entity JJMNGBLHAJC, [In] quaternion OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion PGBOCJJIAOG(Entity JJMNGBLHAJC);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JOLHJOBLIMF(Entity JJMNGBLHAJC, float OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float MHHCPOECKOC(Entity JJMNGBLHAJC);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BLABHLPKEHG(Entity JJMNGBLHAJC, [Out] float4x4 DICECBFGCDM);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FFCHMNCEGEM(Entity JJMNGBLHAJC, [In] float4x4 DICECBFGCDM);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FEPBBOFFCCK(Entity JJMNGBLHAJC);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LKKDPDDPMPH(Entity JJMNGBLHAJC, Entity PKMKJKDCFHL, Entity NAAOBFPOHHG);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class NPMEPIOOJIH
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EEJLBMCPFFF
{
	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJCJPOOOFLL(bool BICMOCINKIA);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FGBJJAHKFHC
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKFOFEGMLCL(EOFNBBMGHCB MOEJABALFBA, AIPBCFHHAOO<string> ANPAKJGAMFF);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGKPDCHEDJA(EOFNBBMGHCB MOEJABALFBA, AIPBCFHHAOO<string> ANPAKJGAMFF);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCPGLICHDFG(EOFNBBMGHCB MOEJABALFBA, AIPBCFHHAOO<string> ANPAKJGAMFF);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBBGNBEDADH(EOFNBBMGHCB MOEJABALFBA, AIPBCFHHAOO<string> ANPAKJGAMFF);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMOOPCOHDGG(EOFNBBMGHCB MOEJABALFBA, AIPBCFHHAOO<string> ANPAKJGAMFF);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPGHMEACMMD(EOFNBBMGHCB MOEJABALFBA, AIPBCFHHAOO<string> ANPAKJGAMFF);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PBMOEPCKLIK(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int HAJJJMCJFOL(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int MDMICJPMCJI(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HKOOMBBGJCN<string> HCCHGOKIKMD(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GOIMMAPIKOK(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HKOOMBBGJCN<string> OJEIMPNLCFI(EOFNBBMGHCB MOEJABALFBA);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GOCHBPPBPEI(EOFNBBMGHCB MOEJABALFBA, string DIOGKKBMGFI);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CFILHEOIICK(string DIOGKKBMGFI, DHPJJEOFEFK BKAPPPCEEOA);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EOFNBBMGHCB CNGFEDMJONN(string DIOGKKBMGFI);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KBJBMNHDJIO(string DIOGKKBMGFI, DHPJJEOFEFK BKAPPPCEEOA);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OAMCACILCLP(EOFNBBMGHCB LFBKCOANDHO, string DIOGKKBMGFI, DHPJJEOFEFK BKAPPPCEEOA);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class MOMOJNFHNIL
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PNNLLJMODAP
{
	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World MKOAHFFDPGK(string ANIKJJCOKFB = "Main");

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World INJOLKEODLH(string ANIKJJCOKFB = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World IMGKGKFFBIB(string ANIKJJCOKFB = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World FGECFHHNFCI(string ANIKJJCOKFB = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LDFBPFEFEGF
{
	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	World GKEIIFOAMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	World FFOGIJDAKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	EntityManager HNLDMAKDHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	bool OBBODMNOFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase DNAHHMEBGBL(Type NNILCBOLNDI);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class MIFMKMFNOHB
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x777CCE0", Offset = "0x777BEE0", VA = "0x18777CCE0")]
	public static ComponentSystemBase LFEAJMEHNOL(this World HCDDAGKOEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x35A51E0", Offset = "0x35A43E0", VA = "0x1835A51E0")]
	public static T DNAHHMEBGBL<T>(this LDFBPFEFEGF FGKPPLPILLH) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IAPFLEMEDMN
{
	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMHABCKHEJA(NativeListAsync<Entity> JNPGKKPFPOM);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNHPMGHMEMK(OOPBPCEMIEL PHDCHBJBLOC);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POOBNNFNMDO(NativeListAsync<Entity> IFGDHHCNKPI, bool KIOFDLCOPFF);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LFJBNODGNOA();

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KMLOPKDIEJI(Entity BFPPPKIAFBG);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ANBABHCICPK
{
	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBGLELFGNIC(Collider BBPNMCBBJLE, [Out] BBCOBMNHEBC EOCGFAMJOMO);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NEEONPBLMAJ
{
	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider IIIOEIELDJG(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject IAHCIPIADAL(EOFNBBMGHCB CEOJHDLCEKM, GameObject NMLMOMLHFNF, Vector3 CHBIEDJMOLB, Quaternion OAJCDGBGAPA);

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBOFMLENMDG(GameObject BBPNMCBBJLE);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider FCMPKDJOINH<TCollider>(GameObject HBLHLNHBDCE) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCJKBHLFPCE(Collider BBPNMCBBJLE);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject DBKPLLPAHDI<TCollider>(string MBDFMCIDAOB) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PLFDEIFHCPN DOIIHEGAFLF(EOFNBBMGHCB HIAPCJAHABH, EOFNBBMGHCB AMBOLHNPHBE, PMLONBCCMJA CHBDMGEKACE, float3 DAMBMLNMDIE, quaternion GAJPAINEFMB, float3 ABLGNOAHALN);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OKBJFFANBOJ(EOFNBBMGHCB DEBNBMMFJPK, [Out] PLFDEIFHCPN BBPNMCBBJLE);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HNAPAKOBLJO(EOFNBBMGHCB DEBNBMMFJPK, [Out] EOFNBBMGHCB BFPPPKIAFBG);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum IAKJKMJDPCK
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CBLNDJBNILG
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public struct OOLDBIAPDKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int CHBDMGEKACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public GameObject NMLMOMLHFNF;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONFGGMNIDIK(EOFNBBMGHCB DEBNBMMFJPK, IKBKDAJDEEK JPHODOIHBME, bool FGNMCIICOKF, KDCOCJHBCHK NAGNKJPFOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKALFFCLGEL(EOFNBBMGHCB DEBNBMMFJPK, IKBKDAJDEEK JPHODOIHBME, bool FGNMCIICOKF, bool GPKCBEFBCGM, bool MBBLDJDHHII);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FMMAJMBGCNF HJBKIBKIPKF(EOFNBBMGHCB BFPPPKIAFBG, List<EOFNBBMGHCB> OHEDIDBKLAE);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PLFDEIFHCPN CPDHDFLLFMM(GameObject BDIHONNGEGG, GameObject MKEBPDEPFIF);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMLANHBCKGJ(GameObject BDIHONNGEGG, List<GameObject> BHPKFCIFNGO);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EAGOMHEMDFM(GameObject MKEBPDEPFIF);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T FCMPKDJOINH<T>(GameObject HBLHLNHBDCE) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FCJKBHLFPCE(Collider BBPNMCBBJLE);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject AGGLGAPPPHL<T>(string MBDFMCIDAOB) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EOKLFBNNIIK(Collider BBPNMCBBJLE, [Out] EOFNBBMGHCB CMDONCAECIK);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BEKJLKBFLIK(EOFNBBMGHCB DEBNBMMFJPK, [Out] BBCOBMNHEBC EOCGFAMJOMO);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<IAKJKMJDPCK> HALGBDJDOML(Allocator JNKCCGKBKPB = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] HJKPINIIEGJ();
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IFGDIMKMOKB
{
	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLFMCGODDHH(EOFNBBMGHCB DEBNBMMFJPK, EOFNBBMGHCB OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICNGNHCFCPJ(EOFNBBMGHCB DEBNBMMFJPK, EOFNBBMGHCB OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KFPEFGNAJOC(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EOFNBBMGHCB NAAJMCGLLKO(EOFNBBMGHCB DEBNBMMFJPK, int KOOLKCPAFBB);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AGCGHKEMDON FLODFIKGEOD(EOFNBBMGHCB DEBNBMMFJPK, Allocator JNKCCGKBKPB = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MJEAGMNHJPL(EOFNBBMGHCB DEBNBMMFJPK, object GIIKHLJPAKH, EOFNBBMGHCB OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LCCBCKFCCLH(EOFNBBMGHCB DEBNBMMFJPK, object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ACHIPPIEJDG(EOFNBBMGHCB DEBNBMMFJPK, [Out] EOFNBBMGHCB OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DEDJDLKHOFF(EOFNBBMGHCB DEBNBMMFJPK, float3 OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PKNLCAPIMOO(EOFNBBMGHCB DEBNBMMFJPK, [Out] float3 OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DOCMMOLKMEI(EOFNBBMGHCB DEBNBMMFJPK, float3 OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IFHICEHEPNK(EOFNBBMGHCB DEBNBMMFJPK, [Out] float3 OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DCIBJJIGKCC(EOFNBBMGHCB DEBNBMMFJPK, (Quaternion rot, Vector3 moments) KHCHKJFGKPL);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool DLDJDAFOBMN(EOFNBBMGHCB DEBNBMMFJPK, [Out] quaternion PKJLMNOFIIE, [Out] float3 LJHDIHOGLCJ);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LKNFMFNENEJ(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 MIFPFOFLFHL(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 NDMIEIJDFBM(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EFLKOOLFIII(EOFNBBMGHCB DEBNBMMFJPK, float3 OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MPHPLGEELEP(EOFNBBMGHCB DEBNBMMFJPK, float3 OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float OBGCPMIGDEP(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float ICGGOFHHOON(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GGPMNGPDIMG(EOFNBBMGHCB DEBNBMMFJPK, float OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void AIBCIKPODPC(EOFNBBMGHCB DEBNBMMFJPK, float OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode DIHOOCNPOAL(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DDPCFDNBJEH(EOFNBBMGHCB DEBNBMMFJPK, CollisionDetectionMode OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	DFMIAGBKIML BNGMFMPJOBC(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NNNKILKPILE(EOFNBBMGHCB DEBNBMMFJPK, DFMIAGBKIML OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool FDLFKGGFPMG(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HILHGMFAPNJ(EOFNBBMGHCB DEBNBMMFJPK, bool OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "29")]
	EOFNBBMGHCB ILACEJDGCCK(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void PCJGNBMCLOJ(EOFNBBMGHCB DEBNBMMFJPK, EOFNBBMGHCB OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "31")]
	EOFNBBMGHCB KDDMJMFFAFG(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void JGMGHHENICE(EOFNBBMGHCB DEBNBMMFJPK, EOFNBBMGHCB OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "33")]
	LEFFBPINKCP ICFNBAKIMPH(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void NJBDMPIPNKG(EOFNBBMGHCB DEBNBMMFJPK, LEFFBPINKCP LJHEANDAHHF);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool JHMDBBLGHNA(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void ELDDOBGMHBK(EOFNBBMGHCB DEBNBMMFJPK, bool OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool DPEHCPAJIAB(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void EIOFBJCLHEJ(EOFNBBMGHCB DEBNBMMFJPK, bool OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints BJNPFJDKIHP(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void BEDDBKHHCCG(EOFNBBMGHCB DEBNBMMFJPK, RigidbodyConstraints OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float LFOJHENFOGC(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void IFDHIKJMGBM(EOFNBBMGHCB DEBNBMMFJPK, float OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float FKMJFEDLFFP(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void FMEKBDKJICB(EOFNBBMGHCB DEBNBMMFJPK, float OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool LCALPMAEIPK(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void ACNKEDBIKFE(EOFNBBMGHCB DEBNBMMFJPK, bool OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool DCFFJALJKHN(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void OBHEANAGHKD(EOFNBBMGHCB DEBNBMMFJPK, bool OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void HEEAOEJAODC(EOFNBBMGHCB DEBNBMMFJPK, int OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "50")]
	BFHLICCPHMB BHOCPOAAPMN(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void MFAOMLIBBGG(EOFNBBMGHCB DEBNBMMFJPK, BFHLICCPHMB OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "52")]
	CBFNNFFIFKO COGPCFJAEJJ(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void DGJLBGFEAFL(EOFNBBMGHCB DEBNBMMFJPK, CBFNNFFIFKO OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float OIFPDLMLPHL(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void PIBCFCDGMPG(EOFNBBMGHCB DEBNBMMFJPK, float OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void DEECDLHPMKA(EOFNBBMGHCB DEBNBMMFJPK, object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void NHBELFJBCPI(EOFNBBMGHCB DEBNBMMFJPK, object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool LDDLBGKNMBJ(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void KGBJDFJBEDE(EOFNBBMGHCB DEBNBMMFJPK, object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void KICCECDFGNE(EOFNBBMGHCB DEBNBMMFJPK, object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool AOGJFEIODMD(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool IKPGLHAIDAO(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody NPGEOIBCEDJ(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void HDLEIFHMCNG(EOFNBBMGHCB DEBNBMMFJPK, Rigidbody JOEOLIHHIPL);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void DEHNLJMHHPM(EOFNBBMGHCB DEBNBMMFJPK, object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void CAIPKAIMHNB(EOFNBBMGHCB DEBNBMMFJPK, object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool OKHIBKOJBEI(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void GLDNOBOKEMP(EOFNBBMGHCB DEBNBMMFJPK, float3 DMAMLJEEFCB);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void INGENJFGPBP(EOFNBBMGHCB DEBNBMMFJPK, float3 KPBNIKDIOKJ);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool BDICHIODHDF(EOFNBBMGHCB DEBNBMMFJPK, [Out] float3 DMAMLJEEFCB);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool DIDBBKFCKNI(EOFNBBMGHCB DEBNBMMFJPK, [Out] float3 KPBNIKDIOKJ);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool LKEJANPOONK(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void HPFBJKHLPIG(EOFNBBMGHCB DEBNBMMFJPK, object GIIKHLJPAKH, bool JLKOFADJBOL);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void LFKJGJGGLAL(EOFNBBMGHCB DEBNBMMFJPK, bool GDEHLNFCPON);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void PNFFNPCGLIG(EOFNBBMGHCB DEBNBMMFJPK);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool EKEEFEFJADK(EOFNBBMGHCB DEBNBMMFJPK);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AEDLEDFEEPM
{
	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMDIACILDCP(Entity CCIBCJCMJIK);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAKOJLPGFFF(Entity CCIBCJCMJIK);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CEOINOICJCD
{
	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JACCLHOMOOK(EOFNBBMGHCB CGKPJBPKLPJ, bool OHIPBLFEBBG);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public delegate void BCODOMFOKOD(PAJGPKJACLL BNAINNAJIIH);
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public readonly ref struct PAJGPKJACLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly AGCGHKEMDON MMIFPEOFNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly NativeArray<byte> GNICDIGBMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly NativeArray<byte> AAHFDFLGNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly DJNFFIMKOOB AKOEHEOHLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly int PMHKBFDCICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly Type NFPLDPAPEGD;

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public AGCGHKEMDON KNODOGJEJKN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B2B0", Offset = "0x4A5A4B0", VA = "0x184A5B2B0")]
		get
		{
			return default(AGCGHKEMDON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public int MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7782B60", Offset = "0x7781D60", VA = "0x187782B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x7782B80", Offset = "0x7781D80", VA = "0x187782B80")]
	public PAJGPKJACLL(AGCGHKEMDON MMIFPEOFNOK, NativeArray<byte> GNICDIGBMGK, NativeArray<byte> AAHFDFLGNMF, DJNFFIMKOOB AKOEHEOHLAC, int PMHKBFDCICI, Type NFPLDPAPEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x366B180", Offset = "0x366A380", VA = "0x18366B180")]
	public NativeArray<T> OIEDNMEIKPG<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x366B140", Offset = "0x366A340", VA = "0x18366B140")]
	public NativeArray<T> NKLOBCIPKHJ<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x366B050", Offset = "0x366A250", VA = "0x18366B050")]
	public (AGCGHKEMDON, NativeArray<T>, NativeArray<T>) NKAAMPBENGI<T>() where T : struct
	{
		return default((AGCGHKEMDON, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x7782B30", Offset = "0x7781D30", VA = "0x187782B30")]
	public FMDJNBGLJHK LILBKBAPJAH()
	{
		return default(FMDJNBGLJHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface JCBFMGKKABA
{
	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	string HELFNKFCJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	JCBFMGKKABA CKACCOMIOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	IEnumerable<JCBFMGKKABA> IOOHFLDBIPL
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IGGCDCCAFBF
{
	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	JCBFMGKKABA CDJELDIOCAH
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	NativeArray<DJNFFIMKOOB> MCIEDJGBGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BIKAOIMMIBL(DJNFFIMKOOB AKOEHEOHLAC, [Out] JCBFMGKKABA LBENHLFHFCB);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COGNOIDNGPM(DJNFFIMKOOB AKOEHEOHLAC, BCODOMFOKOD HNAKINMDBNE);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGGOIHIHDOM(DJNFFIMKOOB AKOEHEOHLAC, BCODOMFOKOD HNAKINMDBNE);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DPNAKDJFGCB
{
	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COGNOIDNGPM(DJNFFIMKOOB AKOEHEOHLAC, BCODOMFOKOD HNAKINMDBNE);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGGOIHIHDOM(DJNFFIMKOOB AKOEHEOHLAC, BCODOMFOKOD HNAKINMDBNE);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class LALGIIOCIMJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EDCMKFOBCID
{
	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	bool GAIHPMCHDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	CBHFKDBFPIO IBKPHBANGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BENLOMLBHMG(NBBHKCNOHOE MEEPADKGNGG, bool HMIOALOAJBO);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KPMIDFNCMEC(GLJKKHGGAPE MEEPADKGNGG, DJNFFIMKOOB AKOEHEOHLAC);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HOEKNNPEHCI(NativeArray<GLJKKHGGAPE> BLGFLEFJOHJ);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class APHIAFOEODP
{
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public readonly ref struct FMDJNBGLJHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly PAJGPKJACLL LJELDKAOCJM;

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public AGCGHKEMDON KNODOGJEJKN
	{
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B2B0", Offset = "0x4A5A4B0", VA = "0x184A5B2B0")]
		get
		{
			return default(AGCGHKEMDON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x7778160", Offset = "0x7777360", VA = "0x187778160")]
	public FMDJNBGLJHK(PAJGPKJACLL LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x7778030", Offset = "0x7777230", VA = "0x187778030")]
	public AGCGHKEMDON OIEDNMEIKPG()
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x7777F00", Offset = "0x7777100", VA = "0x187777F00")]
	public AGCGHKEMDON NKLOBCIPKHJ()
	{
		return default(AGCGHKEMDON);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x7777C10", Offset = "0x7776E10", VA = "0x187777C10")]
	public (AGCGHKEMDON, AGCGHKEMDON, AGCGHKEMDON) NKAAMPBENGI()
	{
		return default((AGCGHKEMDON, AGCGHKEMDON, AGCGHKEMDON));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class MKPGOPLEBKH
{
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public readonly struct CBHFKDBFPIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly NativeBitArray HGBBNJKNFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly NativeParallelHashMap<GLJKKHGGAPE, int> MNFINLINFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly NativeParallelHashSet<NBBHKCNOHOE> PDBPBOGEPAM;

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public bool CJDLMHHLJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x7772320", Offset = "0x7771520", VA = "0x187772320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public bool GAIHPMCHDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x77722F0", Offset = "0x77714F0", VA = "0x1877722F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x5691890", Offset = "0x5690A90", VA = "0x185691890")]
	public CBHFKDBFPIO(NativeBitArray HGBBNJKNFBL, NativeParallelHashMap<GLJKKHGGAPE, int> MNFINLINFIL, NativeParallelHashSet<NBBHKCNOHOE> PDBPBOGEPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x7772340", Offset = "0x7771540", VA = "0x187772340")]
	public bool KPMIDFNCMEC(GLJKKHGGAPE MEEPADKGNGG, DJNFFIMKOOB AKOEHEOHLAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BGFIDOBDAGA
{
	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	GIHAKHDNNJF KFAKAGIENPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HJOJPOMBOGB
{
	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JELGOGLJHAH(EOFNBBMGHCB DEBNBMMFJPK, AIPPNDPMCFL OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OMLFPKHBOMD MJHLAGAELAB();
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MMGJDMHNHJM
{
	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEEEGNHCCKA(World HCDDAGKOEBD);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKMJKJDBAOF(World HCDDAGKOEBD);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase DNLMHIEMAHE(World HCDDAGKOEBD);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DAGDDEOLJHL(World HCDDAGKOEBD);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GGFKBGNJLMP(World HCDDAGKOEBD);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKEJKKJIAMC(World HCDDAGKOEBD);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FKHGBIGBEOL(World HCDDAGKOEBD);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> MJFACGMIGOG();
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface POFEPPKPEEH
{
	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKLPBJDKPMI(EOFNBBMGHCB BNMNHJKEFGM, bool OMFJNFBDJCA);
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public readonly struct NPJPCNNJPMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly IEnumerable<CKOBLHJFLHM> AKOIIABFCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly IReadOnlyList<GameObject> JODHLJBLOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly IReadOnlyList<int> OGJMOHONCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly IReadOnlyList<(GLJKKHGGAPE, GLJKKHGGAPE)> DGFKNHCLOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly int AGCEPELAEHF;
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public struct OCMPEHCKAPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public InventionIdData JDNOHHGIHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public InventionInstanceIdData BNDFFODAMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public bool LEDPLIDNHAA;

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x7781730", Offset = "0x7780930", VA = "0x187781730")]
	public OCMPEHCKAPC(long JDNOHHGIHEO, Guid BNDFFODAMBK, bool LEDPLIDNHAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.Application)]
public interface PLPGLNCDHAB
{
	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CIDHBPNLJAH FHNFBHICDOM(MLMGHINDMEL EDMHHOPIPNM, int NKEDFBFBOKP = 0, bool KKHOIFOKOPK = false);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EKBJMNKDDBG BJHHPCBFKCI(MLMGHINDMEL EDMHHOPIPNM, EOFNBBMGHCB JNGEIJHHFEP, [In] UniformTRS PIICAILODIO, PPNHFPGEBDL AKJKKDHFFKP, [Optional] OCMPEHCKAPC HGNPDBMOGIE, bool AOMGFKCGILL = true, bool EKEJIKGGEEJ = false, bool KKHOIFOKOPK = false);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AAKAMAOBJNG MCCPICNGCAI();

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AAKAMAOBJNG HIJNNIIBDFF(AGCGHKEMDON JBPFPBKHHLE, [In] UniformTRS JDMFKPLGPDG, [Optional] PPNHFPGEBDL JGAPEFEIAEE);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MKEPIANOOEC(EOFNBBMGHCB JKDGLAKJAGP);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FENFMLEBMIM(EOFNBBMGHCB JKDGLAKJAGP, [Out] Exception MEOLMCJHMNI);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<GLJKKHGGAPE> PINJIEKKPOD(EOFNBBMGHCB JKDGLAKJAGP, Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<GLJKKHGGAPE> DALLDNCBLPD(EOFNBBMGHCB JKDGLAKJAGP, Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AGCGHKEMDON BHBLMFMOLPA(EOFNBBMGHCB JKDGLAKJAGP, Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AGCGHKEMDON KDEFDGMJGLI(EOFNBBMGHCB JKDGLAKJAGP, Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AGCGHKEMDON GFNOMPPPIOJ(EOFNBBMGHCB JKDGLAKJAGP, Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> JDGOKFNLHFP(EOFNBBMGHCB JKDGLAKJAGP, Allocator JNKCCGKBKPB);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DHIOLALEPJG(EOFNBBMGHCB JKDGLAKJAGP);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int JOONNEHMHLE(EOFNBBMGHCB JKDGLAKJAGP, int IPBKHOJKHLJ);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.Application)]
public interface CADBONHKHDL
{
	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0xCF2740", Offset = "0xCF1940", VA = "0x180CF2740", Slot = "0")]
	bool MMIDNNJDGGE(object ELLEMLBGHOH, IPJBHKAHKNB KAPFMBGNJFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public static class BCMAOHICMMO
{
	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x776EF40", Offset = "0x776E140", VA = "0x18776EF40")]
	public static bool MMIDNNJDGGE(this CADBONHKHDL CIHBAGEHELN, object ELLEMLBGHOH, [Out] IPJBHKAHKNB KAPFMBGNJFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public enum FOGOJKDBJGI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public interface IPJBHKAHKNB
{
	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	CKEAPBMAGIE FCLHHMOEMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	NEPEIILKAIK NBEGENOKFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	bool DCCOPJABDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	bool AKJPLLENPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0xDFF9B0", Offset = "0xDFEBB0", VA = "0x180DFF9B0", Slot = "4")]
	(NEPEIILKAIK, Dictionary<object, object>) JPEFNEMKNEG()
	{
		return default((NEPEIILKAIK, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "5")]
	(GLJKKHGGAPE, NEPEIILKAIK) FLEDMPKHGEK()
	{
		return default((GLJKKHGGAPE, NEPEIILKAIK));
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "6")]
	KJMHJLLAHBO<(GLJKKHGGAPE, NEPEIILKAIK)> BDLBAEMBJBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "7")]
	KJMHJLLAHBO<LKIMPABLPLJ> OPNNJPHBGHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0xDFF9B0", Offset = "0xDFEBB0", VA = "0x180DFF9B0", Slot = "8")]
	(PIFIDBIGLCI, byte[]) BCLNMOJCGMF()
	{
		return default((PIFIDBIGLCI, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0xDFF9B0", Offset = "0xDFEBB0", VA = "0x180DFF9B0", Slot = "9")]
	(JHKAHMFECBN, byte[]) PHMHECICJML()
	{
		return default((JHKAHMFECBN, byte[]));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public static class HBKHHDBOIDG
{
	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x7778F60", Offset = "0x7778160", VA = "0x187778F60")]
	public static bool MJODPECFOKL(this IPJBHKAHKNB APHKADPMCEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public interface LKIMPABLPLJ : KJMHJLLAHBO<OKPLFGOCHNG>
{
	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	GLJKKHGGAPE CNBBGJKBFML
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DefaultMember("Item")]
public interface KJMHJLLAHBO<T>
{
	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	T EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	int MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public enum CKEAPBMAGIE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	EACMessage = 3,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public enum PIFIDBIGLCI : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class JPIPDOPEKHJ
{
	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x777B880", Offset = "0x777AA80", VA = "0x18777B880")]
	public static GLJKKHGGAPE FMFHDBMIKDO(this IEOKEDJKLNN LJELDKAOCJM)
	{
		return default(GLJKKHGGAPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x777BB40", Offset = "0x777AD40", VA = "0x18777BB40")]
	public static GLJKKHGGAPE LCKPJDBMHBJ([In] this IEOKEDJKLNN LJELDKAOCJM)
	{
		return default(GLJKKHGGAPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x77003A0", Offset = "0x76FF5A0", VA = "0x1877003A0")]
	public static GLJKKHGGAPE HMHBHBGCPCO(this IEOKEDJKLNN LJELDKAOCJM)
	{
		return default(GLJKKHGGAPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x77003A0", Offset = "0x76FF5A0", VA = "0x1877003A0")]
	public static ViewId LOIFHCEHCPO(this IEOKEDJKLNN LJELDKAOCJM)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x777BC20", Offset = "0x777AE20", VA = "0x18777BC20")]
	public static FixedString64Bytes LIDADAFGDDC(this NBBHKCNOHOE JDNOHHGIHEO)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x777B8C0", Offset = "0x777AAC0", VA = "0x18777B8C0")]
	public static FixedString64Bytes KOLMIBNMJMI(this GLJKKHGGAPE JDNOHHGIHEO)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x777BB90", Offset = "0x777AD90", VA = "0x18777BB90")]
	public static FixedString32Bytes LIDADAFGDDC(this Entity JJMNGBLHAJC)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GKLEBBGMLLB : LDLIOIKBNCN
{
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public enum JJIFJLKKOIF
{
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	End,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OFECPPMLMIA
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event Action<object> HJFAJHPEKHM;

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "2")]
	void HECFCBKBMLP(object ELLEMLBGHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "3")]
	void BHPFJALDBMP(JHKAHMFECBN DPCGKOGCCDM, ReadOnlySpan<byte> FKKLLADNDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
	void IDMDNJGKBKC(PIFIDBIGLCI NNILCBOLNDI, ReadOnlySpan<byte> FKKLLADNDBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PBPCKDFAJOP
{
	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JHKAHMFECBN CMAOKJGEAFK(ReadOnlySpan<byte> FKKLLADNDBA);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OBAOHPKJKFM
{
	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHLDKBGECPO(JHKAHMFECBN MBDBONINAPC, ReadOnlySpan<byte> FKKLLADNDBA);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOOPHEHKJPJ(ReadOnlySpan<JHKAHMFECBN> DKKOEIKAHDP);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct IPOOOEHGBDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public JHKAHMFECBN DPCGKOGCCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public ReadOnlyMemory<byte> FKKLLADNDBA;
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct JHKAHMFECBN
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static JHKAHMFECBN KPHILHPFKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public NBBHKCNOHOE MDFLFIACCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public int NLCCGLCOKPE;

	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	public static NBBHKCNOHOE JAAEFHKBBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x777A5D0", Offset = "0x77797D0", VA = "0x18777A5D0")]
		get
		{
			return default(NBBHKCNOHOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x4B1BCB0", Offset = "0x4B1AEB0", VA = "0x184B1BCB0")]
	public JHKAHMFECBN(NBBHKCNOHOE MDFLFIACCBK, int NLCCGLCOKPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x777A730", Offset = "0x7779930", VA = "0x18777A730")]
	public static bool GJNOMHNHJKL([In] JHKAHMFECBN DOEPDJPJMCB, [In] JHKAHMFECBN DHHGPPJBNNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x777A620", Offset = "0x7779820", VA = "0x18777A620", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x777A7C0", Offset = "0x77799C0", VA = "0x18777A7C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x777A830", Offset = "0x7779A30", VA = "0x18777A830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x777A820", Offset = "0x7779A20", VA = "0x18777A820")]
	public void LMCCANMANFL([Out] NBBHKCNOHOE LFJBKMEMIJP, [Out] int NLCCGLCOKPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class MIEBPBFGKKL
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public struct CKOBLHJFLHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public Guid FGPNICIMMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public string LHOGCPEJPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public Vector3 LBPAIJGCICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public Quaternion GLMEOLPKLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public Vector3 DIOKPOCPBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public int FONFLPNEGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public BNLAMAEAGEL BNHLGDBCCDH;

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x7774220", Offset = "0x7773420", VA = "0x187774220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public enum LBLMIANFPLD
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class IGKMFAELCIK
{
	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x777A090", Offset = "0x7779290", VA = "0x18777A090")]
	public static bool GNMPOHOMCIA(this LBLMIANFPLD NNILCBOLNDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x777A0B0", Offset = "0x77792B0", VA = "0x18777A0B0")]
	public static bool MOLNLPKLOBK(this LBLMIANFPLD NNILCBOLNDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x777A080", Offset = "0x7779280", VA = "0x18777A080")]
	public static bool BLCBBJNOACD(this LBLMIANFPLD NNILCBOLNDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[Flags]
public enum BDMAADDLJNH
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public interface PPNHFPGEBDL
{
	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MMMBGOMLADP([In] Guid HDPIMFNJLMN, [Out] Guid NHGKIMEFJKJ);
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[Flags]
public enum PKNFIABAIBO
{
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public interface AAKAMAOBJNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	GGCCIAPKIMC BIALOMEJIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString JJKAOFAEBNK();
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public enum JCAEBACDJBA
{
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct CLFMNGLDFOI : ISystemStateComponentData, IComponentData, IEquatable<CLFMNGLDFOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public float3 CIAJFKHDJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public float3 KPPECEAMNMK;

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x7774340", Offset = "0x7773540", VA = "0x187774340", Slot = "4")]
	public bool Equals(CLFMNGLDFOI LDKNLBHIGFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OKHPKGNDPEO
{
	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPDJJBIEDIP(long GBDFEEGIIDF);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAEPDOHINGP(NativeParallelHashSet<long> OPAHGDNADIC);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNPMFIEOICN(World HCDDAGKOEBD, NativeParallelHashMap<Guid, long> KPBMLBICNMP);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BFAHPEIGCCH(GLJKKHGGAPE MEEPADKGNGG);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CHDGCPPBGNL(GLJKKHGGAPE MEEPADKGNGG, [Out] Guid ABJNOFLOIHA, [Out] long GBDFEEGIIDF);

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DFDMBBILECE(GLJKKHGGAPE MEEPADKGNGG, Guid ABJNOFLOIHA, long GBDFEEGIIDF);

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HNOEJDHNIPN(Guid ABJNOFLOIHA);

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OEPKDDDCHKL(Guid ABJNOFLOIHA, [Out] int ODMKHPELJOI, [Out] int KKIHDDCHEHG);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OEIBIACIPFC(Guid ABJNOFLOIHA, int ODMKHPELJOI, int KKIHDDCHEHG);

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KALFOHODIPL(Guid ABJNOFLOIHA);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class DCKHMIAOKJO
{
	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DCKHMIAOKJO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
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
