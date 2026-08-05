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
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84EA210", Offset = "0x84E8C10", VA = "0x1884EA210", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DNBGFKKAHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84DA3B0", Offset = "0x84D8DB0", VA = "0x1884DA3B0")]
	public static void MDPCIHDCDKB(this Rigidbody KIGJMJBHIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84DA280", Offset = "0x84D8C80", VA = "0x1884DA280")]
	public static void MDPCIHDCDKB(this Rigidbody KIGJMJBHIHH, Vector3 HPILJKJDCJJ, Quaternion DGLBECOLDHE, Vector3 FIJBIOKCIPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct LOFEKKDNAJB : IReadOnlyList<DOIIIDJCDGH>, IEnumerable<DOIIIDJCDGH>, IEnumerable, IReadOnlyCollection<DOIIIDJCDGH>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct KEOCKOIDPOK : IEnumerator<DOIIIDJCDGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly DHIIJDNMGLD IMEMANHPBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator MEKDEFIHOEE;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DOIIIDJCDGH CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x84E5C20", Offset = "0x84E4620", VA = "0x1884E5C20", Slot = "4")]
			get
			{
				return default(DOIIIDJCDGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x84E5BD0", Offset = "0x84E45D0", VA = "0x1884E5BD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x557A880", Offset = "0x5579280", VA = "0x18557A880")]
		public KEOCKOIDPOK(DHIIJDNMGLD IMEMANHPBAO, NativeArray<LocalId>.Enumerator MEKDEFIHOEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84E5B10", Offset = "0x84E4510", VA = "0x1884E5B10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84E5B50", Offset = "0x84E4550", VA = "0x1884E5B50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84E5B90", Offset = "0x84E4590", VA = "0x1884E5B90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AOLJNJKJHCN OFBHFOIEGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> PHABLIIPCKL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DOIIIDJCDGH EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84E9EA0", Offset = "0x84E88A0", VA = "0x1884E9EA0", Slot = "4")]
		get
		{
			return default(DOIIIDJCDGH);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84E9730", Offset = "0x84E8130", VA = "0x1884E9730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int IIEMEPILANC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DHIIJDNMGLD CCBLAICOKII
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84E9850", Offset = "0x84E8250", VA = "0x1884E9850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GAMFHFGHFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84E99F0", Offset = "0x84E83F0", VA = "0x1884E99F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> PJAKIDOJEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2C754E0", Offset = "0x2C73EE0", VA = "0x182C754E0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> IELPEJBDBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84E98F0", Offset = "0x84E82F0", VA = "0x1884E98F0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84E9CD0", Offset = "0x84E86D0", VA = "0x1884E9CD0")]
	public LOFEKKDNAJB(int MOCOCCPAPIH, DHIIJDNMGLD IMEMANHPBAO, Allocator POJKLAFAMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84E9C50", Offset = "0x84E8650", VA = "0x1884E9C50")]
	public LOFEKKDNAJB(AOLJNJKJHCN OFBHFOIEGGG, NativeArray<LocalId> PHABLIIPCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84E9E30", Offset = "0x84E8830", VA = "0x1884E9E30")]
	public LOFEKKDNAJB(AOLJNJKJHCN OFBHFOIEGGG, NativeArray<Entity> PHABLIIPCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84E9BC0", Offset = "0x84E85C0", VA = "0x1884E9BC0")]
	internal LOFEKKDNAJB(DHIIJDNMGLD IMEMANHPBAO, NativeArray<Entity> JGINDINMFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84E9C60", Offset = "0x84E8660", VA = "0x1884E9C60")]
	internal LOFEKKDNAJB(DHIIJDNMGLD IMEMANHPBAO, NativeArray<LocalId> PHABLIIPCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84E9D80", Offset = "0x84E8780", VA = "0x1884E9D80")]
	public LOFEKKDNAJB(DHIIJDNMGLD IMEMANHPBAO, int KLLLBPFLPCD, Allocator POJKLAFAMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84E9B10", Offset = "0x84E8510", VA = "0x1884E9B10")]
	public LOFEKKDNAJB(LOFEKKDNAJB GBMLCFKKLMB, Allocator POJKLAFAMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84E9290", Offset = "0x84E7C90", VA = "0x1884E9290")]
	public void ACFCGPIAPCE(List<DOIIIDJCDGH> CKDFPBCCFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84E98A0", Offset = "0x84E82A0", VA = "0x1884E98A0")]
	public void MKCMPOANEHP(int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84E9690", Offset = "0x84E8090", VA = "0x1884E9690")]
	public LOFEKKDNAJB GICKIFLNCPB(Allocator POJKLAFAMOD)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84E9500", Offset = "0x84E7F00", VA = "0x1884E9500")]
	public Span<DOIIIDJCDGH> AHFHAFHIDKO()
	{
		return default(Span<DOIIIDJCDGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84E9950", Offset = "0x84E8350", VA = "0x1884E9950")]
	public LOFEKKDNAJB NNPOPOIGFED(int PAEPPOFDFDK, int KLLLBPFLPCD)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84E9650", Offset = "0x84E8050", VA = "0x1884E9650", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84E9790", Offset = "0x84E8190", VA = "0x1884E9790")]
	public KEOCKOIDPOK IBBMHAHFLHH()
	{
		return default(KEOCKOIDPOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84E9A30", Offset = "0x84E8430", VA = "0x1884E9A30", Slot = "6")]
	private IEnumerator<DOIIIDJCDGH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84E9AA0", Offset = "0x84E84A0", VA = "0x1884E9AA0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PKINAMLIFPN
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3E94E30", Offset = "0x3E93830", VA = "0x183E94E30")]
	public static ANIKCFOIBKJ<T> HOBMLGGOPKA<T>(this LOFEKKDNAJB GJFINIAHPMG) where T : Component
	{
		return default(ANIKCFOIBKJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct EGHJMECPGFA : IList<DOIIIDJCDGH>, ICollection<DOIIIDJCDGH>, IEnumerable<DOIIIDJCDGH>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct PPAHMGDEDLA : IEnumerator<DOIIIDJCDGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly DHIIJDNMGLD IMEMANHPBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator MEKDEFIHOEE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DOIIIDJCDGH CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x84EEAC0", Offset = "0x84ED4C0", VA = "0x1884EEAC0", Slot = "4")]
			get
			{
				return default(DOIIIDJCDGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84EEA70", Offset = "0x84ED470", VA = "0x1884EEA70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x557A880", Offset = "0x5579280", VA = "0x18557A880")]
		public PPAHMGDEDLA(DHIIJDNMGLD IMEMANHPBAO, NativeArray<LocalId>.Enumerator MEKDEFIHOEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84EE9B0", Offset = "0x84ED3B0", VA = "0x1884EE9B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x84EE9F0", Offset = "0x84ED3F0", VA = "0x1884EE9F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA30", Offset = "0x84ED430", VA = "0x1884EEA30", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DHIIJDNMGLD IMEMANHPBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> PHABLIIPCKL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DOIIIDJCDGH EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84DB9B0", Offset = "0x84DA3B0", VA = "0x1884DB9B0", Slot = "4")]
		get
		{
			return default(DOIIIDJCDGH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84DBAA0", Offset = "0x84DA4A0", VA = "0x1884DBAA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84DB580", Offset = "0x84D9F80", VA = "0x1884DB580", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84DB580", Offset = "0x84D9F80", VA = "0x1884DB580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> PJAKIDOJEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2C754E0", Offset = "0x2C73EE0", VA = "0x182C754E0")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CLDNKONDKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84DB8A0", Offset = "0x84DA2A0", VA = "0x1884DB8A0")]
	public EGHJMECPGFA(DHIIJDNMGLD IMEMANHPBAO, Allocator POJKLAFAMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84DB920", Offset = "0x84DA320", VA = "0x1884DB920")]
	public EGHJMECPGFA(DHIIJDNMGLD IMEMANHPBAO, int KLLLBPFLPCD, Allocator POJKLAFAMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84DB2A0", Offset = "0x84D9CA0", VA = "0x1884DB2A0")]
	public LOFEKKDNAJB FAPHEDLOGFD()
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84DAFC0", Offset = "0x84D99C0", VA = "0x1884DAFC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84DB000", Offset = "0x84D9A00", VA = "0x1884DB000", Slot = "13")]
	public bool Contains(DOIIIDJCDGH HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84DB090", Offset = "0x84D9A90", VA = "0x1884DB090", Slot = "14")]
	public void CopyTo(DOIIIDJCDGH[] JCEJMKLBKKB, int MDMGHHNAEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84DAF40", Offset = "0x84D9940", VA = "0x1884DAF40", Slot = "11")]
	public void Add(DOIIIDJCDGH HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84DB4D0", Offset = "0x84D9ED0", VA = "0x1884DB4D0", Slot = "7")]
	public void Insert(int FILGHJLFKAL, DOIIIDJCDGH HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84DB610", Offset = "0x84DA010", VA = "0x1884DB610", Slot = "15")]
	public bool Remove(DOIIIDJCDGH HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84DB440", Offset = "0x84D9E40", VA = "0x1884DB440", Slot = "6")]
	public int IndexOf(DOIIIDJCDGH HNLFGCKBFGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84DB5C0", Offset = "0x84D9FC0", VA = "0x1884DB5C0", Slot = "8")]
	public void RemoveAt(int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84DB260", Offset = "0x84D9C60", VA = "0x1884DB260", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x84DB3B0", Offset = "0x84D9DB0", VA = "0x1884DB3B0")]
	public PPAHMGDEDLA IBBMHAHFLHH()
	{
		return default(PPAHMGDEDLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x84DB6E0", Offset = "0x84DA0E0", VA = "0x1884DB6E0", Slot = "16")]
	private IEnumerator<DOIIIDJCDGH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84DB7C0", Offset = "0x84DA1C0", VA = "0x1884DB7C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ODAIBDJOOLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DOIIIDJCDGH CLAHDAOMABJ(DOIIIDJCDGH PHABLIIPCKL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FKEHHLHEBGI : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface MOPBBABHCFA : PNBGCEHBJNA, CAABBDAJAFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	GAMNBBGFJEO BDBDCMDEOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	AOLJNJKJHCN IDBBFKDDJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface CAABBDAJAFF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool EKOGOLFOEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface JJHJIBOHHKB
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLNMLLFLLBG(bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHLOADNGFGM();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface KFHHIIMCLMF
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool BJILAHOAHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ANEIFEIIGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DKCMJDGAJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KBIBIKCNDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NEMIKFOAKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODDEIDFPBAL(bool DKBBOMHPGKC);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FDNMHABNDJI(ByteString ECOEDMGAMJN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void INOHOPOPAAJ();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HHLENIPDDAI();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GKGMCDLCFNP();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface JDIMFMLOFCB
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	JFKAHIBHGGP BDBDCMDEOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MHDHJMLPIFM DNGNPFGKHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	OGDNDEFAEAO IDEKOGKEALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	MOPBBABHCFA IMINCBCFEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	HDPOMMJLIMJ NHEFBNPEEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	KFHHIIMCLMF BACKBCKLHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	CDAECHDMKKL LFBCMJNMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ECAAEJELJBN ILGINBHEHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DBNPHICECAH KFMJHPKLDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KJEJNICMLBO DMOHGBMKEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	DHNHLNBFFFJ CNIIKIMKBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	OLCAFHLIPPN PLAOHOJCIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	DHIIJDNMGLD CCBLAICOKII
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	KLNBHPPMENI BJGLCAKKJMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GBGLLJHFLJD GLBCNGHDBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	LCGIFCAJNGH LDODIKAELCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NANLLEODKEM MODKJAKGIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	APALFNPPLAA AFGMEICHJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	BKIPHBLJMEF JPCNIHPKNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	DNAJLLPKBBD EGOJICFLMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	EHEECPPDOEJ LEKLGNBFOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BAFDDELEODG JCMJEJEMEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	MHBCKHOHBBG IKBLPPDFBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	JMPPEGFDCII KHFAADMBGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	CKKFMDPFIPM OJCDKJGDAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	NIICIHIPODE LKFLJIKPLDB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	FJANBECNICF GOJGMACAOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	NPHMHJLBEIO IHKBPIHIHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	EMOGDCIALAP KDFFBGBCEGH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OKENDFDGJKP LFNNNBNDEKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OBJBHEGBLJM HAEPFCPLFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KADNMICOHMP MFAGDPIHMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HEJDJAEEDBC HNNJEKGFMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	DGFLGIKCLCK NEOANDIKNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	ODIHIJIOMNL ACHPPGKILCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	HEHCMEDKPKO JDBMPAFCDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	OJMCBNMIBHI MKEJOPGMMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	AFPNKHOEFPK ECGNPACDAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	FOLEDAPAPOL DAOBIOOMEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	DPELLBILFJB IGFNJGDBMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(CMMBEHAFKBM))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct DOIIIDJCDGH : IComparable<DOIIIDJCDGH>, IEquatable<DOIIIDJCDGH>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly DOIIIDJCDGH IFHOCKPABEA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int IFGJOGBGIAP = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int JJFDJKOHCGP = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int KCHLKJIOCFE = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int ADOCGOFNCDA = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId DBDHPICCKFG;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public DHIIJDNMGLD CCBLAICOKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84DAAB0", Offset = "0x84D94B0", VA = "0x1884DAAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public MOPBBABHCFA IMINCBCFEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x84DA540", Offset = "0x84D8F40", VA = "0x1884DA540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LocalId NFFLBMKBJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84DA6C0", Offset = "0x84D90C0", VA = "0x1884DA6C0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal AOLJNJKJHCN IDBBFKDDJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84DA7F0", Offset = "0x84D91F0", VA = "0x1884DA7F0")]
		get
		{
			return default(AOLJNJKJHCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool DBCKAGIKEII
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x84DA5A0", Offset = "0x84D8FA0", VA = "0x1884DA5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private bool IJHKCGPBIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84DAB90", Offset = "0x84D9590", VA = "0x1884DAB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x84DADA0", Offset = "0x84D97A0", VA = "0x1884DADA0")]
	public DOIIIDJCDGH(DHIIJDNMGLD DBHDFHHJLIH, LocalId DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x84DAD10", Offset = "0x84D9710", VA = "0x1884DAD10")]
	public DOIIIDJCDGH(AOLJNJKJHCN OFBHFOIEGGG, LocalId DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
	public PLOIJFHDLGK CCKFEFNFLIC()
	{
		return default(PLOIJFHDLGK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x84DAB10", Offset = "0x84D9510", VA = "0x1884DAB10")]
	public static LocalId LHJBCIIELME(DOIIIDJCDGH APFLGACDFOK)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x84DAB50", Offset = "0x84D9550", VA = "0x1884DAB50")]
	public static Entity LHJBCIIELME(DOIIIDJCDGH APFLGACDFOK)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84DA990", Offset = "0x84D9390", VA = "0x1884DA990")]
	public static bool JJNADAGGMDE(DOIIIDJCDGH MLLJGIHINDJ, DOIIIDJCDGH ABNAHAKPDNC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x84D7840", Offset = "0x84D6240", VA = "0x1884D7840")]
	public static bool CNNLEBNJPBE(DOIIIDJCDGH MLLJGIHINDJ, DOIIIDJCDGH ABNAHAKPDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x84DABE0", Offset = "0x84D95E0", VA = "0x1884DABE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x84DA800", Offset = "0x84D9200", VA = "0x1884DA800", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x84DA700", Offset = "0x84D9100", VA = "0x1884DA700", Slot = "4")]
	public int CompareTo(DOIIIDJCDGH EFNHKCDKOGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "5")]
	public bool Equals(DOIIIDJCDGH EFNHKCDKOGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HPPBPJGNADM
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x84E3C80", Offset = "0x84E2680", VA = "0x1884E3C80")]
	public static GLONLLNEBOJ DJKGLHLBFFB(this DOIIIDJCDGH CEFJEHJNIAP)
	{
		return default(GLONLLNEBOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class CMMBEHAFKBM
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct AOLJNJKJHCN : IEquatable<AOLJNJKJHCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte OFBHFOIEGGG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] LNOBELKHMFL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static DHIIJDNMGLD NKLKMMMDCAC;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static MOPBBABHCFA ENJHFPFDGJI;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static DHIIJDNMGLD[] JJGPGPPNNDD;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static MOPBBABHCFA[] LEHNKDECIHA;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> JCAPDDFJKEI;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public MOPBBABHCFA IMINCBCFEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84D5840", Offset = "0x84D4240", VA = "0x1884D5840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public DHIIJDNMGLD HJFJBBNPPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84D6240", Offset = "0x84D4C40", VA = "0x1884D6240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x84D6740", Offset = "0x84D5140", VA = "0x1884D6740")]
	static AOLJNJKJHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8EC0", Offset = "0x2CC78C0", VA = "0x182CC8EC0")]
	internal AOLJNJKJHCN(byte PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x731A330", Offset = "0x7318D30", VA = "0x18731A330", Slot = "4")]
	public bool Equals(AOLJNJKJHCN EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x84D5D50", Offset = "0x84D4750", VA = "0x1884D5D50", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x10830E0", Offset = "0x1081AE0", VA = "0x1810830E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x84D6680", Offset = "0x84D5080", VA = "0x1884D6680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x84D5920", Offset = "0x84D4320", VA = "0x1884D5920")]
	private static DHIIJDNMGLD CCPLHKNHPDH(byte OFBHFOIEGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x84D5DF0", Offset = "0x84D47F0", VA = "0x1884D5DF0")]
	private static MOPBBABHCFA IGANJDELECD(byte OFBHFOIEGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x84D5BE0", Offset = "0x84D45E0", VA = "0x1884D5BE0")]
	private static object DCFJPIJPMOG(byte OFBHFOIEGGG, object[] EJKNLPOFFNN, object KKCMINIPIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x84D6230", Offset = "0x84D4C30", VA = "0x1884D6230")]
	private static int IKLOLJIBCHD(byte OFBHFOIEGGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x84D6670", Offset = "0x84D5070", VA = "0x1884D6670")]
	private static int PHAFKMIFCNM(byte OFBHFOIEGGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x84D65F0", Offset = "0x84D4FF0", VA = "0x1884D65F0")]
	private static (int, int) OCGIHKOCFNC(byte OFBHFOIEGGG)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x84D6320", Offset = "0x84D4D20", VA = "0x1884D6320")]
	private static byte KEAILDEDCGK(int OHBCMIBMOPM, int FILGHJLFKAL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x84D6330", Offset = "0x84D4D30", VA = "0x1884D6330")]
	internal static AOLJNJKJHCN MAJNBNPDEEJ(MOPBBABHCFA DPLEFEIOEPA, DHIIJDNMGLD GMINBGDJFKC)
	{
		return default(AOLJNJKJHCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x84D59D0", Offset = "0x84D43D0", VA = "0x1884D59D0")]
	internal static void CPOFHABEGHF(AOLJNJKJHCN OFBHFOIEGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x84D5EA0", Offset = "0x84D48A0", VA = "0x1884D5EA0")]
	private static void IHIKGKDOLJE(int MOCOCCPAPIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum CHGIAILELLF
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
public interface DEECEHABKPD
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool EJCINFECLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool JDMGDPLNPDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool IAHOHILNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool DNNMNBBEBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool KIKFKJAMHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NKGAAMPNJEK
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNANACFELPA(KFDKLCEGNDB JBOIKIICKBA, int FILGHJLFKAL);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NAFIAFCCBMC(KFDKLCEGNDB DHFAJFJGHPB, int FILGHJLFKAL);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GIGCEKDPDLJ(GBNPGJDGBIA OLBPMGHMBHI, int FILGHJLFKAL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EONHPHJHBCI : KFDKLCEGNDB, DEECEHABKPD
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int NJJCICLAKJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHKAGDLNJDL(IADJALNDNHJ EBOPBDPOAOK, int FILGHJLFKAL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KFDKLCEGNDB : DEECEHABKPD
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum EJPKKFDJIOM
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
	bool HNBLHMHLCPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool AMHMFAKOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool BEGHDGOKMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface IADJALNDNHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool LBIMEJIICCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	CEHCOOIBKHM AEFEFDJPFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	IIOFMHAKNIE CLLEPBADGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 FLMJNMGJKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	quaternion MBCEPOHNHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float3 FKKBOCKEFLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	NICLJDPJKKF ADBOMPMBHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	HLFHMCNDAGP CALPOELKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float ENNPFLHHJKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float3 HEOGKKCLJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float BMKNFOMGOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	EMGMCNDGCFG HBLIEDAFGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BLFCGIPALNE
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float3 PKNMOJAEEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float3 ODBFHLPCADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion KNEHOHMPBFB(float3 OOOHNFFDCMA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface IIOFMHAKNIE
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool BJBKBGGALFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool JHABFJEIJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool EOAOHNDNFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float MECJDDEGIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int EMAKOKFPECE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int HDBHAABLJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JIFGIKLHANJ(BLFCGIPALNE EBOPBDPOAOK, int FILGHJLFKAL);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.OMRoom)]
public class FKHIKMJGBOB
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public FKHIKMJGBOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface BAFFPNJLAEE
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Guid AEJJANLNGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BJEAKJDLCHP(Guid CAIKMEDBDNE, Guid KALNIGICCJC, Guid LMMIICAMJJA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task HOBIEPBBGKK(Guid CAIKMEDBDNE, Guid[] IJJDCNPBEDN, Guid LMMIICAMJJA);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid BBLPPPBMNCL(Guid IOCOOEFIBIE);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task GMAKPCDFFPL(DOIIIDJCDGH EKMLINCLEGP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EHFEDHPILAP(Guid IOCOOEFIBIE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FBDCNIPNPFA(LEFGJFBEACM LFCELBEDNJG, Guid OMHOIDDOMIE);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EAJACEDKGKO(Guid IOCOOEFIBIE, bool DKBBOMHPGKC);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HBEDDLHJPID(Guid IOCOOEFIBIE, GLONLLNEBOJ BHNDAHFKAMK);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JDIEGCGMLGH(GLONLLNEBOJ BHNDAHFKAMK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FFLOBFMLNLO(DOIIIDJCDGH DBDHPICCKFG);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface MNHBLPDGOEN
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface BBLNMHGPEPO
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "0")]
	void PKNIPEBNLGP(bool JKHDONCCPDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface MHDHJMLPIFM
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	BBLNMHGPEPO DJFCJMCDKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	FIJCFJMLEBK NGNNCNHNKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	OBMIGFNKGKP FDPHPBFBJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	LAABOFLAKDM HMGMKAIGKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	OGANHOKMKGA DNNBCNNCFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	LAKGDHCIPNA HJOADCLDIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	JGCFMIMBFEB PEHGIPOEJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	DGLKLGHKBKD JDDGMHJOGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface FIJCFJMLEBK
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	string BODMIBDGKNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface BDFOLKCKIHA
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJDPIFHJLMI(Action FOAIPBIEILM, bool CFHCLBODLEK);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJHBGAJBABB(string FLBFBHGDBLM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int NJDDPOFMJHK(string FLBFBHGDBLM, int KKCMINIPIBD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MCOKIEEBEBD([Out] bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BLKFNOCHCOP([Out] bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PIFPJPOIFCP([Out] int PDKJBMPOMNC);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface OBMIGFNKGKP
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "0")]
	void LOHDAEIABJM(bool DKBBOMHPGKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface LAABOFLAKDM
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid HFMKHGNPMKN;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid DHHMPCICDKG;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid DCBOCEACKBA;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid IKHJICBEJNI;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool IIJPNPNENPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool PEMHCIKHPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool IOMALIHJCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool KEFMJGLODBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x84E8520", Offset = "0x84E6F20", VA = "0x1884E8520", Slot = "4")]
	string[] IOPLPFPENHP(GJADLJGDNNF NKKFEAKKHEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void APCAJELHNKI();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x84E85B0", Offset = "0x84E6FB0", VA = "0x1884E85B0", Slot = "6")]
	Guid KLBPLJJGOCC(Guid MCBKCOCBFMK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int NJIEKHBCMBA(GJADLJGDNNF NKKFEAKKHEH);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IILHDDABFHO(GJADLJGDNNF NKKFEAKKHEH, NativeArray<BAFMCIAHCPG> MBNIHJAPOJC, NativeList<UniformTRS> JEPKEJILDOA);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int PMFNDCGBIAH(Guid DNLDANFOOJK);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BMKKBLCFMGI(string JOPFFGOACPD, [Out] Guid DNLDANFOOJK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string DLOMOBHOEKF(Guid DNLDANFOOJK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BGNEGCGKJOC(RRObjectPrefabData HMIBOCOHHJF, [Out] LocalId EOGGAEBALGK);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ANIKCFOIBKJ<byte[]> FPNKGEMNBKL(NativeArray<BAFMCIAHCPG> FFNPENKDAPK);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OHGFANNMNEA(byte[] GLOHFMKNGFI);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GameObject FKKFHEGGKDM(string JOPFFGOACPD);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BFILEFIGJLJ(Transform EOBBLENOIHL, RRObjectPrefabData LPGKOHHDELN, BIHHMEGLCGA HCLPHJDKMCA);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool EKEJNJJHEMC(GJADLJGDNNF NKKFEAKKHEH, NativeParallelHashMap<Guid, LocalId> EIECBPLPHLD, [Out] Exception CMHNFFEOOMC);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ELCJAIBJLGL(GJADLJGDNNF NKKFEAKKHEH, NativeParallelHashMap<Guid, LocalId> EIECBPLPHLD, [Out] NativeArray<LocalId> JGINDINMFKO, [Out] NativeArray<LocalId> BLPFFBGHIMB, [Out] NativeArray<AuthoredLocalPoseData> KHJEKHAFKHK, Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "19")]
	void OIIPPIOAOAI(GJADLJGDNNF OBPEHAFILEK, NativeArray<int> BBBILFDJOKE, MFJNMJILDKH<GameObject> IDHCLHPPCIK, ANIKCFOIBKJ<GameObject> CPFEAONIEGA, CHGIAILELLF KMBAGLEFMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LACJPDCDBOK();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "21")]
	void JDKHJIMDMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "22")]
	void LLINGHOJBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "23")]
	bool LJIHHDHEELN(GJADLJGDNNF NKKFEAKKHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "24")]
	NKGAAMPNJEK AIALOBFAKIP(GJADLJGDNNF NKKFEAKKHEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "25")]
	void LFEDOGJFMBM(Guid EPMENFOHPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "26")]
	bool FBGADAIILLL(Guid EPMENFOHPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x84E85E0", Offset = "0x84E6FE0", VA = "0x1884E85E0")]
	static LAABOFLAKDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface NFHIBKJMDJM
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	long DDCCJOLBFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long EONIHMMGJOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface OGANHOKMKGA
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool APCPMJALFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool NFKMLGNELAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int HAGDNBLHJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int EHNJNKCPIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int DJOGOIHHKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool KCDCAKPKCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	int BJOGBHJDFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "6")]
	void PGLCHIDIIEE(IOPBPKHIHNL JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
	void FMGKGLDNBLM(bool EGPLNHNEFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "8")]
	bool IMJJAFIKFGE(IOMKCHPPNFJ PCJBPIKLFBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "9")]
	void MMGJGGCFJBG(object EEMEEFCIEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "10")]
	void NJNDOIFJODN(object EEMEEFCIEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PEKEGFBHEGO(Action<object> GEHHCFCIDCB);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LIDAHNMBBNL(Action<object> GEHHCFCIDCB);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "13")]
	void BPOGDCCFFMF(NativeArray<ViewId> PIEDCMAAJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "14")]
	void BCFGHPDBJBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "15")]
	void FKAMIKINGOD(NHCIMHIBDKO AEOGKDPPBBE, ReadOnlySpan<byte> GPCDCFCPGFK, IOMKCHPPNFJ GPFCEEMMIIK, bool FFAAPDGOFDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "16")]
	void FKAMIKINGOD(NHCIMHIBDKO AEOGKDPPBBE, ReadOnlySpan<byte> LNLDFPIMDEE, bool FFAAPDGOFDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "17")]
	void FKAMIKINGOD(NHCIMHIBDKO AEOGKDPPBBE, ReadOnlySpan<byte> LNLDFPIMDEE, ReadOnlySpan<byte> IMGBDNNBLOB, bool FFAAPDGOFDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "18")]
	void ABONPGBHBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "19")]
	void DFMCHEBHHMN(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "20")]
	void IJEMKEDHLJH(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "21")]
	void LLCLGGDCPJC(Dictionary<object, object> JIFLEJNODGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "22")]
	void DNDJLGAHCLI(NativeList<GLONLLNEBOJ> LDKFEPKJGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "24")]
	void JHEOMLFLKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "25")]
	void FPFOBCACBJL(List<object> LLMHINCMLEH, int EMMDOKDGNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "26")]
	void MEFGCJOBBHD(int IGFMPONHNDC, object EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "27")]
	void NKMPJEIHMAP(IOMKCHPPNFJ PCJBPIKLFBM, Dictionary<object, object> FNPCEKCMMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "28")]
	void FGLGBKHFALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "29")]
	void KFNJNECPEAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GNCNLFPJMIJ
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x84E1DD0", Offset = "0x84E07D0", VA = "0x1884E1DD0")]
	public static HAKMLBJKHHL IONLPBBJNNK(this OGANHOKMKGA KPICELCLOBJ, object DHNMCOFINFM)
	{
		return default(HAKMLBJKHHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct HAKMLBJKHHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private OGANHOKMKGA KPICELCLOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object DHNMCOFINFM;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x84E2300", Offset = "0x84E0D00", VA = "0x1884E2300")]
	public HAKMLBJKHHL(OGANHOKMKGA KPICELCLOBJ, object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x84E22B0", Offset = "0x84E0CB0", VA = "0x1884E22B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KFDKBJHIMLN
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void HGDDALHLNJJ(ViewId JBPOBPLEADM, LINIDGPLNHA FHCIMGPBDNP, int AANOAFILNFN);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "0")]
	void KPNEKIDNMCH(HGDDALHLNJJ OEHCKOCGMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "1")]
	void JCFFDCAAEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "2")]
	void KFPOIEMACNG(FEDJPCMCMDH GFNNIJMCMJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface GCNEIFICFLO
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[ServiceLifetime(Lifetime.Application)]
public interface LAKGDHCIPNA
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct LKHIONMJPNI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private LAKGDHCIPNA BOIENJGICIP;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x84E9200", Offset = "0x84E7C00", VA = "0x1884E9200")]
		public LKHIONMJPNI(LAKGDHCIPNA BOIENJGICIP, string KAGDIKHFOCM, string EOEJOFDFFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x84E9140", Offset = "0x84E7B40", VA = "0x1884E9140", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct JNIBEKPKADJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private LAKGDHCIPNA BOIENJGICIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task AIPCFMDLKCK;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x84E5840", Offset = "0x84E4240", VA = "0x1884E5840", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "0")]
	void HPIIBJELNNK(string ONGDPODJNBL, float KHJNAGFHPGB = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "1")]
	void DPPEONINGCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NACAOIOAEJP(bool DGCLHCFMIGJ, string KAGDIKHFOCM, string EOEJOFDFFNN);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "3")]
	void JOIEIIOFAAE(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NMHOFJECPOF
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x84EB210", Offset = "0x84E9C10", VA = "0x1884EB210")]
	public static LAKGDHCIPNA.LKHIONMJPNI INHAODKEICN(this LAKGDHCIPNA KPICELCLOBJ, string KAGDIKHFOCM, string EOEJOFDFFNN)
	{
		return default(LAKGDHCIPNA.LKHIONMJPNI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface FDOJLLBFCAF
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DIFGHBMCHMK(GameObject CEENMGBCJEJ);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKNEENPHOLE(GameObject CEENMGBCJEJ);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EAKABFNFDEH(int PCJBPIKLFBM);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object NMDHFIKFCAM(DOIIIDJCDGH DBDHPICCKFG, GameObject CEENMGBCJEJ, Action<DOIIIDJCDGH, int> EMBEDGKMMHB);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MIBFHNPDMCP(GameObject CEENMGBCJEJ, object OPPNNLLNOOK);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LMPGGEBDLPO
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGMAOEJJFGD(EFJKAGJCDIF IPENDGIIFGC, COANBILAONK OBHPOGNNDEL);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface KGOONOBDGDK
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGNKEKDJGCC(object CEFJEHJNIAP, NativeList<byte> GPCDCFCPGFK);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object JBBKNKCPLNK(NativeArray<byte> GPCDCFCPGFK);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface HPKJMMJBFBE
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool KOOOIKFOCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate KHJLLIKECEA(BAPEBGBNCLI EABEGGLHHLG, Action<BAPEBGBNCLI> EMBEDGKMMHB);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKAFJJLFEMH(BAPEBGBNCLI EABEGGLHHLG, Delegate EMBEDGKMMHB);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate KCDHEHHFGMG(BAPEBGBNCLI EABEGGLHHLG, Action<BAPEBGBNCLI> OALNJMIJEAN);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLGLDOOBGEP(BAPEBGBNCLI EABEGGLHHLG, Delegate EMBEDGKMMHB);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ADGOFAPFAGI(BAPEBGBNCLI EABEGGLHHLG);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BAPEBGBNCLI GGNINLNHFKD(GameObject CEENMGBCJEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface DGCEFGHFKBF
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int LPGJENEBFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	int COJGBKKNBFB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool APCPMJALFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool IMEJMMOPLBG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool EKBCODDHPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DOIIIDJCDGH IKALNFFGBBL(int PCJBPIKLFBM);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DOEMEDOBHBF(GameObject HGGOAOHHEKJ, JobHandle AADGMIOFKDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface PMOFMPANOGG
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGMAOEJJFGD(int FCNHLPKGBDC, COANBILAONK LKLEJCNLAIG);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface JGCFMIMBFEB
{
	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool BJILAHOAHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface KGIABPDHOHP
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	LMLNMMEOLDH HDKIDBEFKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	JJOBGHILALB DEOKPKFBCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool OFDEAOBGHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BIDDPNPIGCH(Transform EOBBLENOIHL);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADPANIDFHLM(Transform EOBBLENOIHL, DDEBPFHMGEL KKACPBKNLDE);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OAEDNHECKGN(Transform EOBBLENOIHL, BCPAHBIDOOE MDAJNMHNCHC);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface DGLKLGHKBKD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PIGKPMHDBPH;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface OAKDKDGPAJM
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNCBGPFCBIC();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[ServiceLifetime(Lifetime.Application)]
public interface PPOGEFHIINO
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPOPGPJKBNO(GameObject CEENMGBCJEJ, ALMFFOLOPBG JEPNFJMEEAO, CBKMGINFBNJ HOKNEKICGJN);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKEBBNGNBGP(DOIIIDJCDGH DBDHPICCKFG, bool MBHJGMJHODF, float3 AOKMLPKDJII, quaternion MEEPHIDODFN);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JGLOFHOJOIO(LOFEKKDNAJB CJPLELMFHOO);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MOOKLPKBBAH(PLOIJFHDLGK ICBGFNPAHKN, PLOIJFHDLGK IMFCAPGBDGB, MOLGCNIPLLK DOFFGKPAKJD);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBPKFLCKCKO(PLOIJFHDLGK ICBGFNPAHKN, MOLGCNIPLLK DOFFGKPAKJD);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void INDPDIOHKJG(LOFEKKDNAJB FEJGIMFCBLB);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PNJOEIAKEDO(GJADLJGDNNF LJDLHIFMFNN, ReadOnlySpan<Guid> GBKPJBBHAMB, ReadOnlySpan<int> JOCONGAAAGC, ANIKCFOIBKJ<GameObject> CGICAPOFPNF);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GGMJHGKBOBK(MBPJOONFHIE LAHDKLNDKDF);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IIMJILJLJOL(FAFPDFOABOB GLKEKHPBPHE, FAFPDFOABOB GCIAGFKKDAC);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LJIPFHDGHAD(FAFPDFOABOB GLKEKHPBPHE, FAFPDFOABOB GCIAGFKKDAC);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GBJOGGOCDFD(DOIIIDJCDGH FCNPCCDGCMM);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct HMOBAPLBNHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> GPCDCFCPGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle OFBHFOIEGGG;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x84E3BD0", Offset = "0x84E25D0", VA = "0x1884E3BD0")]
	public HMOBAPLBNHF(ReadOnlyMemory<byte> DAHCIIGJBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x84E3B90", Offset = "0x84E2590", VA = "0x1884E3B90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum KIKJPNGMMFP
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
public struct GJADLJGDNNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString CBBGHBIPOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object NOFHNAPNDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object OAMDNOCPKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> JBHDKOLMLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool CDFFNHNHJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public PIJJNDAAJKJ.IHGPAOMCOBG? BKKACHOPHHF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x84E1200", Offset = "0x84DFC00", VA = "0x1884E1200")]
	public GJADLJGDNNF(ByteString CBBGHBIPOMI, [Optional] object NOFHNAPNDGO, [Optional] object OAMDNOCPKEB, [Optional] IEnumerable<string> JBHDKOLMLEA, bool CDFFNHNHJBM = true, [Optional] PIJJNDAAJKJ.IHGPAOMCOBG? BKKACHOPHHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct OCNKOOJBHOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object KGGIDIKOJFG;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct BAFMCIAHCPG
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Flags]
	public enum LJNBEANFLHH
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
	public RRObjectPrefabData GGKEJIBINFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid FPCKBBHLCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid DDPFBHAEELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid ABDFJIDDLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid IJBMCJHAMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public LJNBEANFLHH DHGLMDLACKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 BBIHAKBHCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int BKJIAAHHHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public ADIBJNNKNID CINMDDLLECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int GHKDDBPPPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int OOAMKDKOMIB;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Guid GNDLCDKBHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5576EE0", Offset = "0x55758E0", VA = "0x185576EE0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool HEPCIJOEOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x84D6750", Offset = "0x84D5150", VA = "0x1884D6750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool LMDFDJLFGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x84D6760", Offset = "0x84D5160", VA = "0x1884D6760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool OOGNDNFNAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x84D6770", Offset = "0x84D5170", VA = "0x1884D6770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool PGBBOCCFEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x84D6780", Offset = "0x84D5180", VA = "0x1884D6780")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct CBJNPNKOEDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly LJBIAJHHKDD PAEPPOFDFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly LJBIAJHHKDD GFFPHFAAMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly uint KDHDBAMHHGN;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x84D7F90", Offset = "0x84D6990", VA = "0x1884D7F90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct FHBDBOOEEID
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly CBJNPNKOEDN FOAIPBIEILM;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x84DED20", Offset = "0x84DD720", VA = "0x1884DED20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct MGIFOCHEIJI
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly CBJNPNKOEDN FOAIPBIEILM;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x84DED20", Offset = "0x84DD720", VA = "0x1884DED20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct KAHLHHNOJHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly uint KDHDBAMHHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly bool FIOJPKNHFKL;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x84E5890", Offset = "0x84E4290", VA = "0x1884E5890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct LJBIAJHHKDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal int KIOPHNHDMKE;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x84E8E00", Offset = "0x84E7800", VA = "0x1884E8E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[ServiceLifetime(Lifetime.Application)]
public interface KGCKBPEOHMK
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	IAFOMKMNMBC LAKBJDFEDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface LEFGJFBEACM
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface HMAEOHACOCC
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class CAONDDAICFI
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3A67420", Offset = "0x3A65E20", VA = "0x183A67420")]
	public static PLOIJFHDLGK CCKFEFNFLIC<T>(this T DBDHPICCKFG) where T : LEFGJFBEACM
	{
		return default(PLOIJFHDLGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x84D7E50", Offset = "0x84D6850", VA = "0x1884D7E50")]
	public static MonoBehaviour EHNHDJDABHG(this LEFGJFBEACM DBDHPICCKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x84D7ED0", Offset = "0x84D68D0", VA = "0x1884D7ED0")]
	public static GameObject GNMGDLNMGBK(this LEFGJFBEACM DBDHPICCKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface DKGOBOPAOLL : LEFGJFBEACM
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(DOIIIDJCDGH JGBFCMNOFDB);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface GEHCHACMLKO : LEFGJFBEACM
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DGFNJLEHBPI
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate void JCJNCFBNPCJ(HMNHIPIDOGN KCLBCAOJMFD);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event JCJNCFBNPCJ MNHODMMMFPK;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface KOJAMDGPBHO
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface BLIFCGDMDCH
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface OJDIDKEHKMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(DOIIIDJCDGH DICFDMJCKKP);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool MONPNFACIAJ);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DMHIEKFEIDI(DOIIIDJCDGH IGCJFNAANOD);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface GJACEBJMNKN
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(GAMCEIADCLK ECACCFIAPMM);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface GAMCEIADCLK
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	GameObject CEENMGBCJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Transform EOBBLENOIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	MMLAFIMCODN HEOMJOBJCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool JPKPGHFIBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFMCJDOADEL(MMLAFIMCODN JDFAIEBLNPJ);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GCPMEGPNIPL GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class GCNDINMKGBG
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x84E05E0", Offset = "0x84DEFE0", VA = "0x1884E05E0")]
	public static void AMAPILJBBOM(this GAMCEIADCLK NMIAFFNIHJH, BIHHMEGLCGA HCLPHJDKMCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface MMLAFIMCODN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Rigidbody LJNAKNEMDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	GAMCEIADCLK NJIDBNBABCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	GameObject GNMGDLNMGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	Transform AMPAFLPNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	MMLAFIMCODN KJNLPEJOCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	MMLAFIMCODN BDILIHENIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	int HLBJDIIHOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	bool BPOKPLLNDNE
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	bool ADGOFAPFAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool DOBFHAMEJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	DGLAKMOPOGI LIJEDFPFLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	OHIMHKLKCME KKPKJPAGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	float LDCEPJGJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Vector3 PIPFAEEEJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 JFLCKKDPHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 MHCMKJOJAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 BMGLMJHMMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool LIGIFBDPOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool CHBDDICKFJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool CEFEHAKKFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool ANIFKINJJBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Vector3 MOCDNAMKLNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Vector3 LMFMICLIBEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 DMFLCNMJJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Vector3 NGLOFMOALJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	float OMOMNNFCNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	float NIFJCPJBHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Vector3 CJDFBDMKPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Quaternion IJHMHCACLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	float FENIPLPAEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float CAONAEAGFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool FBNNNDBMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	OGPMHIGIIEC JLPNBOJDJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	bool HPPMJJEPHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	Transform DHCIHHENNMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	Vector3 AIIJAKFFIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	float COPGMFFJDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	float MNLMOEGEBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	Quaternion KCMJHAANMND
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Vector3 PKNMOJAEEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Quaternion NGNBDBJMMAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	RigidbodyConstraints IBMPDFKHEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	bool KNHCPPDKNII
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	CollisionDetectionMode PHIIPJEHMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	bool EIBOJNNMCDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event PMGMHKJLJEM FOBOOLGLKEN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PMGMHKJLJEM NKOBCKDNMNB;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event PMGMHKJLJEM LKMHENLPOKA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PMGMHKJLJEM JPFDLBIHAMB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event PMGMHKJLJEM CFHBNJFKLML;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event PMGMHKJLJEM BOAMOHFIEOG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event PMGMHKJLJEM GEKNPPMHBPN;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event EPALFMCEDOH CFPOIIHIAED;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<CNMJFAPGOOG, CNMJFAPGOOG> JKLCEJHAMJM;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MMLAFIMCODN BODPJDOINLI(int FILGHJLFKAL);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void BKBKDJEMBEH((Quaternion rot, Vector3 moments) PGJAAKEMFIF);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void NNIEBIADIDG();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void FNPJNHJCKAD();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void FDGDCCMGBDL();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void DBLBMHDLGJF();

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void PHDMEMAEOAJ();

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void DLABGJNHMMB(MMLAFIMCODN PDKJBMPOMNC, bool CKECAKCIDFF = false);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void NDPIPFFKCOG(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void JDOLDOPDPAA(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 EOALJNHEOJB(Vector3 PFBBHDKAPNO);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 GPAKIMFLKML(Vector3 EEEABJHHEDN);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void DNEEDJKLNIB();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void EMGPFCKNMKL();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void HGPNMHPKFEN();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void NIOCLKDODIO(Vector3 EEPILHBAMLB, Vector3 KGBOAKKNPDH);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void EGPDAJIPHOF(Vector3 BBHLJFHPKAN, Vector3 KIOBGDPGDBB);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void IBKKKPAMPOH(Vector3 OKFMKEDPMEK);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void MOKKBPHGLAB(EMGABCFDBHM PFPHBPGCIJC, Vector3 MIHCFDPADLM, float AEKMACFDPEA, float KMBMIIIBPKJ = 8f, float NIOPKGJILOE = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void EKDDFJEBKCC(EGBIDPNJAII NEBGCLAOOFM, Vector3 OHKPPKKOGOO, float CMEMBNCINMC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void MAEJPNAMJJB(EGBIDPNJAII NEBGCLAOOFM, Vector3 JCDLBIBEGAF, float CJEJBOIPPOH = 7f, float HEFIEBMJIFJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 EEGNKMABDNP(Vector3 PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 PACGDALLACG(Vector3 PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void IEFJDOPFLEI();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void FDBMOAPMGDA(MMLAFIMCODN MINGOFMFDGO, object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void JONIEBKKLGG(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void AHGJIKACHPE();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void JIKDCKCLMDB();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void DHBEFOGJGEG();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool PLPEPHOKPLL();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void FLHCOPCMOMB();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void DJMLGFKNHEE(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void ALOMKLJEIFO(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void PFKCBJNBECL(object DHNMCOFINFM, bool MMPDJFBCAKB);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void JGDGFIHONPB(Vector3 PJNPHLDNCIO, Quaternion BMJDLPCICGK);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void GINAOIBLIMK(Vector3 JAEJANFNLKM, Quaternion POCCBMCKNOC);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool IMMHAGBIHBL(float OBEKFMJKMIG);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void DLDCOENJKIO(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void CKMPJBOGADD(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void ANLADLKBIOP(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void IFCMEPJHFFK(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void DMBHGCHPGPK(Vector3 FGLPKBNAEFO, ForceMode NOOEBPMMLLP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void OJINILMGELK(Vector3 FGLPKBNAEFO, Vector3 DDIHIBMHCDH, ForceMode NOOEBPMMLLP);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void KBJPHLNFFMK(Vector3 FDCHPHOPBKP, ForceMode NOOEBPMMLLP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void KIJOPLOFMCA(Vector3 FDCHPHOPBKP, ForceMode NOOEBPMMLLP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool PNDFOINNMEN(Vector3 PNELABKCNPL, [Out] RaycastHit MEEEMKCEJJG, float JFEGIFCHDHH);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void PGAIPEOLOGC();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface OHIMHKLKCME
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class BCHADCGOAEH : OHIMHKLKCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BCHADCGOAEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "0")]
	void AKJAEBAAPGD(Vector3 KHHIFNBAJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "1")]
	void CELPANPEAJF(Vector3 JMCMALMHEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "2")]
	void MABBIDHGNIN(Vector3 KHHIFNBAJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "3")]
	void EKHOJOPBAIE(Vector3 JMCMALMHEEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface DGLAKMOPOGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 GCNOMKMEMAK();

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 MBEODNLKAIE();

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMLODNAEAAP(float PPCMLIONOBJ, float MECGKDBKAPP);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate void PMGMHKJLJEM(GAMCEIADCLK PFOFCCLNPBD);
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum GJOGPONOBHC
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
public enum EMGABCFDBHM
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
public delegate void EPALFMCEDOH(GAMCEIADCLK PFOFCCLNPBD, bool CKECAKCIDFF = false);
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum EGBIDPNJAII
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct GCPMEGPNIPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Rigidbody HKGIPJIFHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public object FFIKJGPFGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 LMOJGFOMNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector3 OKPCFNDIFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public EJPCFNJKDCP PNNMBEKNGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool HADECJNBCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool LNOLCAPODPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool MLJOKDPLFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool NKDMLAINAJE;
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct PLOIJFHDLGK : IEquatable<PLOIJFHDLGK>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly PLOIJFHDLGK BHAFCKPMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public GameObject CEENMGBCJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x84EDC10", Offset = "0x84EC610", VA = "0x1884EDC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public GLONLLNEBOJ FCIELONJCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x84EE3D0", Offset = "0x84ECDD0", VA = "0x1884EE3D0")]
		get
		{
			return default(GLONLLNEBOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public OKONFNKJCOK FJFDEHCLBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x84EE180", Offset = "0x84ECB80", VA = "0x1884EE180")]
		get
		{
			return default(OKONFNKJCOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public RRObjectPrefabData MMOPEGPONAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x84EE710", Offset = "0x84ED110", VA = "0x1884EE710")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool NFPHEJHPNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x84EE240", Offset = "0x84ECC40", VA = "0x1884EE240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool HILJLPFKCAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x84EE260", Offset = "0x84ECC60", VA = "0x1884EE260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool LBIMEJIICCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x84EDF80", Offset = "0x84EC980", VA = "0x1884EDF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool DGMHOPEEHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x84EDED0", Offset = "0x84EC8D0", VA = "0x1884EDED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool OFABKJABHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x84EE220", Offset = "0x84ECC20", VA = "0x1884EE220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool GFGAEIMCLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x84EE080", Offset = "0x84ECA80", VA = "0x1884EE080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool GKKBAEKCIJF
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x84EE4B0", Offset = "0x84ECEB0", VA = "0x1884EE4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool AAPEPHFAOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x84EE140", Offset = "0x84ECB40", VA = "0x1884EE140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool IGFNLPMNBBL
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x84EE040", Offset = "0x84ECA40", VA = "0x1884EE040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool GLILPLAEBNG
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x84EE590", Offset = "0x84ECF90", VA = "0x1884EE590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool NLDIECKMNAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x84EDA60", Offset = "0x84EC460", VA = "0x1884EDA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool OOGIDBMFIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x84EE470", Offset = "0x84ECE70", VA = "0x1884EE470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool MOBIOJHHMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x84EDBD0", Offset = "0x84EC5D0", VA = "0x1884EDBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool GNEENBKPPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x84EE100", Offset = "0x84ECB00", VA = "0x1884EE100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool GCKECCEIJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x84EDAB0", Offset = "0x84EC4B0", VA = "0x1884EDAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool OLLKIGJLDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x84EDA20", Offset = "0x84EC420", VA = "0x1884EDA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DIJGOMAOAKF OBBGNBFHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DIJGOMAOAKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public EHNMMDHEMPH HKAFCJOCNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(EHNMMDHEMPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public HEDHINIDKMM BJGLCAKKJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(HEDHINIDKMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public KELCHDHBIHJ KNOMPEGKJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(KELCHDHBIHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public KIFAOOMDKML NIMAEALCCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(KIFAOOMDKML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public NCMKNMGGBII NAEAFOAIGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(NCMKNMGGBII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public ELLNMHNMGOB OIMKCOGGLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(ELLNMHNMGOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public ODMGNCGEAKO LLHGGPBGMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(ODMGNCGEAKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public MAGPEGOIMBI GOHIFOIHDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(MAGPEGOIMBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public GKLHEFJIKAC GLBCNGHDBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(GKLHEFJIKAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public PGBIGEJBGHD DPGHHHAPIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PGBIGEJBGHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public PGEFLCHMMJD HFOOKMJJPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PGEFLCHMMJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public BKIOGOFLLNB PLGCAIAMNHE
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(BKIOGOFLLNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public DHECEEGIDGN BGLBHJMHJAH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DHECEEGIDGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public DAFNJNKFLMD ECEDBOFPJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DAFNJNKFLMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool HCFEBMHFEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x84EE2E0", Offset = "0x84ECCE0", VA = "0x1884EE2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool AGMHMELIILB
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x84EE610", Offset = "0x84ED010", VA = "0x1884EE610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public bool JACNFNBLDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x84EE5D0", Offset = "0x84ECFD0", VA = "0x1884EE5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool DBCKAGIKEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x84EDAA0", Offset = "0x84EC4A0", VA = "0x1884EDAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool DBOMDAKKEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x84EDAF0", Offset = "0x84EC4F0", VA = "0x1884EDAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool MINJKGFGEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x84EE6D0", Offset = "0x84ED0D0", VA = "0x1884EE6D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool JIGOECHMMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x84EDDF0", Offset = "0x84EC7F0", VA = "0x1884EDDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public FAMAPDJAOCI AMPAFLPNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(FAMAPDJAOCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public KHPBHJEBIFJ DMOHGBMKEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(KHPBHJEBIFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private DHIIJDNMGLD CCBLAICOKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x84DAAB0", Offset = "0x84D94B0", VA = "0x1884DAAB0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static PLOIJFHDLGK LHJBCIIELME(DOIIIDJCDGH JGBFCMNOFDB)
	{
		return default(PLOIJFHDLGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x84EE650", Offset = "0x84ED050", VA = "0x1884EE650")]
	public GEHNGAADAJF PEMOMDKAMJO()
	{
		return default(GEHNGAADAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x84EE2B0", Offset = "0x84ECCB0", VA = "0x1884EE2B0")]
	public LGMPNKNEGCB MCNBHNNAMFH()
	{
		return default(LGMPNKNEGCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x84EDE30", Offset = "0x84EC830", VA = "0x1884EDE30")]
	public FOGGMGKJKFM ENJALNGKGAF()
	{
		return default(FOGGMGKJKFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x84EE280", Offset = "0x84ECC80", VA = "0x1884EE280")]
	public IDIKAGDHOPA MADKLLBPDKN()
	{
		return default(IDIKAGDHOPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x84EDE80", Offset = "0x84EC880", VA = "0x1884EDE80")]
	public FJOEAJDBPIP ENPHLFNMMEI()
	{
		return default(FJOEAJDBPIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x84EDDA0", Offset = "0x84EC7A0", VA = "0x1884EDDA0")]
	public GCNOIGCPJAA DJIEBBFENIB()
	{
		return default(GCNOIGCPJAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x84EDB80", Offset = "0x84EC580", VA = "0x1884EDB80")]
	public FAFPDFOABOB CMEJJNMCJCD()
	{
		return default(FAFPDFOABOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x84EE0B0", Offset = "0x84ECAB0", VA = "0x1884EE0B0")]
	public BNHKLBAKMHO JCLMPPPDDIF()
	{
		return default(BNHKLBAKMHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x84EDB30", Offset = "0x84EC530", VA = "0x1884EDB30")]
	public PLBBABNEGJP CKADFHOJOBK()
	{
		return default(PLBBABNEGJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x84ED920", Offset = "0x84EC320", VA = "0x1884ED920")]
	public void ALIHGPKFLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x84EE4F0", Offset = "0x84ECEF0", VA = "0x1884EE4F0")]
	public void NHMIPJFACPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x84EDFA0", Offset = "0x84EC9A0", VA = "0x1884EDFA0")]
	public bool GDMIHNOKPGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x84EE840", Offset = "0x84ED240", VA = "0x1884EE840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public PLOIJFHDLGK(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x84E03F0", Offset = "0x84DEDF0", VA = "0x1884E03F0")]
	public static bool LHJBCIIELME(PLOIJFHDLGK PDKJBMPOMNC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static DOIIIDJCDGH LHJBCIIELME(PLOIJFHDLGK PDKJBMPOMNC)
	{
		return default(DOIIIDJCDGH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x84D7B40", Offset = "0x84D6540", VA = "0x1884D7B40")]
	public static bool JJNADAGGMDE(PLOIJFHDLGK MLLJGIHINDJ, PLOIJFHDLGK ABNAHAKPDNC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x84D7840", Offset = "0x84D6240", VA = "0x1884D7840")]
	public static bool CNNLEBNJPBE(PLOIJFHDLGK MLLJGIHINDJ, PLOIJFHDLGK ABNAHAKPDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x84EDEF0", Offset = "0x84EC8F0", VA = "0x1884EDEF0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(PLOIJFHDLGK EFNHKCDKOGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct BKIOGOFLLNB : IEquatable<BKIOGOFLLNB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private DGFLGIKCLCK NFPDCGFEPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x84D69D0", Offset = "0x84D53D0", VA = "0x1884D69D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x84D6EB0", Offset = "0x84D58B0", VA = "0x1884D6EB0")]
	public void NEHCOBEHJNL(uint EGJGKBPPPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x84D6BB0", Offset = "0x84D55B0", VA = "0x1884D6BB0")]
	public bool HLOCPMOEBNO([Out] uint EGJGKBPPPFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x84D68D0", Offset = "0x84D52D0", VA = "0x1884D68D0")]
	public bool FFIMLCADIDL([Out] uint EGJGKBPPPFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x84D6CB0", Offset = "0x84D56B0", VA = "0x1884D6CB0")]
	public void KAHCBNJPPHH(string EGJGKBPPPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x84D6DA0", Offset = "0x84D57A0", VA = "0x1884D6DA0")]
	[CanBeNull]
	public string KMKCEOJNKPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x84D6A30", Offset = "0x84D5430", VA = "0x1884D6A30")]
	public bool HHDJFCLLEKF([Out] string PNOGPECOFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x84D67A0", Offset = "0x84D51A0", VA = "0x1884D67A0")]
	public void CBDILIIFHMG(string PNOGPECOFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public BKIOGOFLLNB(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x84D6840", Offset = "0x84D5240", VA = "0x1884D6840", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(BKIOGOFLLNB EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct DIJGOMAOAKF : IEquatable<DIJGOMAOAKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private CDAECHDMKKL JCIJHKHLKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x84D9980", Offset = "0x84D8380", VA = "0x1884D9980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private DGFLGIKCLCK NEOANDIKNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x84DA160", Offset = "0x84D8B60", VA = "0x1884DA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public bool EMCCCEPAEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x84D9810", Offset = "0x84D8210", VA = "0x1884D9810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool LFLGKLDCNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x84D98A0", Offset = "0x84D82A0", VA = "0x1884D98A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool EDFAIEJCNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x84DA1C0", Offset = "0x84D8BC0", VA = "0x1884DA1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Guid FFIKCBIBGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x84D9A70", Offset = "0x84D8470", VA = "0x1884D9A70")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Guid NIIKKMPJFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x84D9FC0", Offset = "0x84D89C0", VA = "0x1884D9FC0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Guid CHHNNOLJFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x84D9D10", Offset = "0x84D8710", VA = "0x1884D9D10")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public KHPBHJEBIFJ DMOHGBMKEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(KHPBHJEBIFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x84D9F20", Offset = "0x84D8920", VA = "0x1884D9F20")]
	public bool KIPBKAAEHMN([Out] Guid IOCOOEFIBIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x84D98E0", Offset = "0x84D82E0", VA = "0x1884D98E0")]
	public bool BDOJLDAEJIC([Out] Guid KALNIGICCJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x84DA040", Offset = "0x84D8A40", VA = "0x1884DA040")]
	public void MFPBLFEJKHK(Guid BEAEDIJJJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x84D9C10", Offset = "0x84D8610", VA = "0x1884D9C10")]
	public void GMCKKFKFIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x84D9AF0", Offset = "0x84D84F0", VA = "0x1884D9AF0")]
	public Guid GLCDDCBKKMD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public DIJGOMAOAKF(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x84D99E0", Offset = "0x84D83E0", VA = "0x1884D99E0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(DIJGOMAOAKF EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct FOGGMGKJKFM : IEquatable<FOGGMGKJKFM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private DBNPHICECAH KJGDJBMMNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x84E02C0", Offset = "0x84DECC0", VA = "0x1884E02C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Vector3 LBGKNEGOABN
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x84E0170", Offset = "0x84DEB70", VA = "0x1884E0170")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Quaternion EJIDGIPEGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x84E04A0", Offset = "0x84DEEA0", VA = "0x1884E04A0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public PLOIJFHDLGK EIBDDOLNJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x84E0410", Offset = "0x84DEE10", VA = "0x1884E0410")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x84E0320", Offset = "0x84DED20", VA = "0x1884E0320")]
	public LOFEKKDNAJB JBPKDIOKNNH(Allocator POJKLAFAMOD)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x84DFFC0", Offset = "0x84DE9C0", VA = "0x1884DFFC0")]
	public bool GGCLDMAMKIN(PLOIJFHDLGK DFKFFPKHNCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x84DFDE0", Offset = "0x84DE7E0", VA = "0x1884DFDE0")]
	public void BPPHCNHEPHG(Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x84E0060", Offset = "0x84DEA60", VA = "0x1884E0060")]
	public void HIDPGPGIPIB(float DILGPPEHCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x84DFC20", Offset = "0x84DE620", VA = "0x1884DFC20")]
	public void AFJMDHGGGMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public FOGGMGKJKFM(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x84E03F0", Offset = "0x84DEDF0", VA = "0x1884E03F0")]
	public static bool LHJBCIIELME(FOGGMGKJKFM PDKJBMPOMNC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static DOIIIDJCDGH LHJBCIIELME(FOGGMGKJKFM PDKJBMPOMNC)
	{
		return default(DOIIIDJCDGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x84DFF30", Offset = "0x84DE930", VA = "0x1884DFF30", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(FOGGMGKJKFM EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct GEHNGAADAJF : IEquatable<GEHNGAADAJF>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly GEHNGAADAJF BHAFCKPMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private KJEJNICMLBO FJJKBGIEFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x84E11A0", Offset = "0x84DFBA0", VA = "0x1884E11A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<PLOIJFHDLGK> PGBFILJDFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x84E0A70", Offset = "0x84DF470", VA = "0x1884E0A70")]
		get
		{
			return default(Span<PLOIJFHDLGK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x84E0C00", Offset = "0x84DF600", VA = "0x1884E0C00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x84E1120", Offset = "0x84DFB20", VA = "0x1884E1120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public FAMAPDJAOCI AMPAFLPNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(FAMAPDJAOCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public KHPBHJEBIFJ DMOHGBMKEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(KHPBHJEBIFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x84E0C80", Offset = "0x84DF680", VA = "0x1884E0C80")]
	public void KPFEAIEGAAG(GEHNGAADAJF EFNHKCDKOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public GEHNGAADAJF(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x84E03F0", Offset = "0x84DEDF0", VA = "0x1884E03F0")]
	public static bool LHJBCIIELME(GEHNGAADAJF PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x84E0B70", Offset = "0x84DF570", VA = "0x1884E0B70", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(GEHNGAADAJF EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static PLOIJFHDLGK LHJBCIIELME(GEHNGAADAJF NLDLHIJAJBO)
	{
		return default(PLOIJFHDLGK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DefaultMember("Item")]
public struct FAGNCHNIHPN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> EKGECJENMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private GJDFMGBECEI EJIBOGKFGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool EGONONGDDCE;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(PLOIJFHDLGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public LPODJIFFHKP EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x84DCB10", Offset = "0x84DB510", VA = "0x1884DCB10")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x84DCC40", Offset = "0x84DB640", VA = "0x1884DCC40")]
	internal FAGNCHNIHPN(PLOIJFHDLGK CEFJEHJNIAP, bool EGONONGDDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x84DC9E0", Offset = "0x84DB3E0", VA = "0x1884DC9E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x3C40870", Offset = "0x3C3F270", VA = "0x183C40870")]
	public void KPFMDCIFFHM<T>(LPODJIFFHKP LNBCHJPEENA, T PDKJBMPOMNC, [Optional] T KKCMINIPIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x84DC930", Offset = "0x84DB330", VA = "0x1884DC930")]
	public void BBOPECIHIDA(LPODJIFFHKP LNBCHJPEENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0xB1D6D0", Offset = "0xB1C0D0", VA = "0x180B1D6D0")]
	public Dictionary<int, object> BGJAFFIILFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x84DCBD0", Offset = "0x84DB5D0", VA = "0x1884DCBD0")]
	private readonly void JCLCNCENNJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class GOMODJEPJFM
{
	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x84E20A0", Offset = "0x84E0AA0", VA = "0x1884E20A0")]
	public static FAGNCHNIHPN LIIODIPAOGB(this PLOIJFHDLGK CEFJEHJNIAP)
	{
		return default(FAGNCHNIHPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct DHECEEGIDGN : IEquatable<DHECEEGIDGN>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly DHECEEGIDGN BHAFCKPMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private bool NLDIECKMNAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x84D9320", Offset = "0x84D7D20", VA = "0x1884D9320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 NAMBLLNLLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x84D95D0", Offset = "0x84D7FD0", VA = "0x1884D95D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x84D93E0", Offset = "0x84D7DE0", VA = "0x1884D93E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x84D9550", Offset = "0x84D7F50", VA = "0x1884D9550")]
	public Vector3 JCPBLJDJKKP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x84D9360", Offset = "0x84D7D60", VA = "0x1884D9360")]
	public void DCJBHAECFPK([In] Vector3 PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x84D94D0", Offset = "0x84D7ED0", VA = "0x1884D94D0")]
	public void GLNHLKHODOE([In] Vector3 PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x84D9680", Offset = "0x84D8080", VA = "0x1884D9680")]
	public bool OCKEKNDECNI([In] Vector3 PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public DHECEEGIDGN(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x84D9440", Offset = "0x84D7E40", VA = "0x1884D9440", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(DHECEEGIDGN EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x84D9730", Offset = "0x84D8130", VA = "0x1884D9730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct FJGFPJELOJN : IEquatable<FJGFPJELOJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x84DEDC0", Offset = "0x84DD7C0", VA = "0x1884DEDC0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(FJGFPJELOJN EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct BNHKLBAKMHO : IEquatable<BNHKLBAKMHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private OJMCBNMIBHI MKEJOPGMMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x84D7530", Offset = "0x84D5F30", VA = "0x1884D7530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool DJCBFMFNIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x84D76D0", Offset = "0x84D60D0", VA = "0x1884D76D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool PBGAMBFHEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x84D7860", Offset = "0x84D6260", VA = "0x1884D7860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public OKIFHMCAFKN LJOOHDIJBBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x84D7590", Offset = "0x84D5F90", VA = "0x1884D7590")]
		get
		{
			return default(OKIFHMCAFKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool FEJJIJIKNNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x84D7800", Offset = "0x84D6200", VA = "0x1884D7800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool GAODFFLEPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x84D7AB0", Offset = "0x84D64B0", VA = "0x1884D7AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool EJLCEJGHEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x84D7990", Offset = "0x84D6390", VA = "0x1884D7990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x84D7C90", Offset = "0x84D6690", VA = "0x1884D7C90")]
	public bool OEHNMHLJFEJ(BNHKLBAKMHO GNBACIAKHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x84D7BF0", Offset = "0x84D65F0", VA = "0x1884D7BF0")]
	public bool ODJMCNFIEGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x84D7B50", Offset = "0x84D6550", VA = "0x1884D7B50")]
	public bool NEIFODDLGHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x84D7D30", Offset = "0x84D6730", VA = "0x1884D7D30")]
	public ReadOnlySpan<DOIIIDJCDGH> PDJPCCNDHJG()
	{
		return default(ReadOnlySpan<DOIIIDJCDGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public BNHKLBAKMHO(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x84D7B40", Offset = "0x84D6540", VA = "0x1884D7B40")]
	public static bool JJNADAGGMDE(BNHKLBAKMHO MLLJGIHINDJ, BNHKLBAKMHO ABNAHAKPDNC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x84D7840", Offset = "0x84D6240", VA = "0x1884D7840")]
	public static bool CNNLEBNJPBE(BNHKLBAKMHO MLLJGIHINDJ, BNHKLBAKMHO ABNAHAKPDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x84D7A20", Offset = "0x84D6420", VA = "0x1884D7A20", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(BNHKLBAKMHO EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct FAFPDFOABOB : IEquatable<FAFPDFOABOB>
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly FAFPDFOABOB BHAFCKPMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private OJMCBNMIBHI PNEHFLIEJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x84DC790", Offset = "0x84DB190", VA = "0x1884DC790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool OIDBGLMNFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x84DC550", Offset = "0x84DAF50", VA = "0x1884DC550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public FAMAPDJAOCI AMPAFLPNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(FAMAPDJAOCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x84DC890", Offset = "0x84DB290", VA = "0x1884DC890")]
	public bool OEHNMHLJFEJ(FAFPDFOABOB EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x84DC7F0", Offset = "0x84DB1F0", VA = "0x1884DC7F0")]
	public bool LMJKDPJIPDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x84DC640", Offset = "0x84DB040", VA = "0x1884DC640")]
	public bool FCPKJJPPOMN([Out] FAFPDFOABOB GBMEFMNANKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x84DC720", Offset = "0x84DB120", VA = "0x1884DC720")]
	public void GKGBDBPJHIB(FHOJFJAOCHP BILOCDLBGBK, bool BKBHMBGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public FAFPDFOABOB(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x84D7B40", Offset = "0x84D6540", VA = "0x1884D7B40")]
	public static bool JJNADAGGMDE(FAFPDFOABOB MLLJGIHINDJ, FAFPDFOABOB ABNAHAKPDNC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x84D7840", Offset = "0x84D6240", VA = "0x1884D7840")]
	public static bool CNNLEBNJPBE(FAFPDFOABOB MLLJGIHINDJ, FAFPDFOABOB ABNAHAKPDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x84DC5B0", Offset = "0x84DAFB0", VA = "0x1884DC5B0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(FAFPDFOABOB EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct KHPBHJEBIFJ : IEquatable<KHPBHJEBIFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private KJEJNICMLBO FJJKBGIEFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x84E66A0", Offset = "0x84E50A0", VA = "0x1884E66A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public DOIIIDJCDGH PGAKJMLPMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x84E63E0", Offset = "0x84E4DE0", VA = "0x1884E63E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public PLOIJFHDLGK KJNLPEJOCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x84E6470", Offset = "0x84E4E70", VA = "0x1884E6470")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public PLOIJFHDLGK BDILIHENIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x84E5F80", Offset = "0x84E4980", VA = "0x1884E5F80")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x84E65A0", Offset = "0x84E4FA0", VA = "0x1884E65A0")]
	public Span<PLOIJFHDLGK> ODNPHAJKKNF()
	{
		return default(Span<PLOIJFHDLGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x84E61D0", Offset = "0x84E4BD0", VA = "0x1884E61D0")]
	public Span<PLOIJFHDLGK> FOMEHPGIDEG()
	{
		return default(Span<PLOIJFHDLGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x84E5DF0", Offset = "0x84E47F0", VA = "0x1884E5DF0")]
	public Span<PLOIJFHDLGK> CFMBHDKMBPA()
	{
		return default(Span<PLOIJFHDLGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x84E5CF0", Offset = "0x84E46F0", VA = "0x1884E5CF0")]
	public Span<PLOIJFHDLGK> BHPECOKMCIF()
	{
		return default(Span<PLOIJFHDLGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x84E6010", Offset = "0x84E4A10", VA = "0x1884E6010")]
	public bool DLABGJNHMMB(PLOIJFHDLGK DFKFFPKHNCH, bool MMINMGKEIEA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x84E6500", Offset = "0x84E4F00", VA = "0x1884E6500")]
	public bool MJIHOMBMIHG(PLOIJFHDLGK MPDPLFNEIAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x84E62D0", Offset = "0x84E4CD0", VA = "0x1884E62D0")]
	public PLOIJFHDLGK GLILOAKEJOO(uint ILKIOMMDLOA)
	{
		return default(PLOIJFHDLGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x84E5EF0", Offset = "0x84E48F0", VA = "0x1884E5EF0")]
	public GEHNGAADAJF CGOJGGLFHAP()
	{
		return default(GEHNGAADAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public KHPBHJEBIFJ(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x84E03F0", Offset = "0x84DEDF0", VA = "0x1884E03F0")]
	public static bool LHJBCIIELME(KHPBHJEBIFJ PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x84E6140", Offset = "0x84E4B40", VA = "0x1884E6140", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(KHPBHJEBIFJ EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct EHNMMDHEMPH : IEquatable<EHNMMDHEMPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public string BMEFPAKGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x84DBC30", Offset = "0x84DA630", VA = "0x1884DBC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public string IILIHHAFEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x84DBEC0", Offset = "0x84DA8C0", VA = "0x1884DBEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string DDDKNHNMAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x84DBE10", Offset = "0x84DA810", VA = "0x1884DBE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public string BFNANNHECLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x84DBF30", Offset = "0x84DA930", VA = "0x1884DBF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x84DBD50", Offset = "0x84DA750", VA = "0x1884DBD50")]
	public bool HHDJFCLLEKF([Out] string PNOGPECOFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public EHNMMDHEMPH(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x84DBCC0", Offset = "0x84DA6C0", VA = "0x1884DBCC0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(EHNMMDHEMPH EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct AHFMMIOMKPO : IEquatable<AHFMMIOMKPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x84D5760", Offset = "0x84D4160", VA = "0x1884D5760", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(AHFMMIOMKPO EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct KJFOCCFJPEO : IEquatable<KJFOCCFJPEO>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[Flags]
	public enum CGJIGDINHOB
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
	private static MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly KJFOCCFJPEO BHAFCKPMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private DHIIJDNMGLD CCBLAICOKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x84DAAB0", Offset = "0x84D94B0", VA = "0x1884DAAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x84E80D0", Offset = "0x84E6AD0", VA = "0x1884E80D0")]
	public static CGJIGDINHOB MGGDPJPIELN(KJFOCCFJPEO MLLJGIHINDJ, KJFOCCFJPEO ABNAHAKPDNC)
	{
		return default(CGJIGDINHOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x84E7540", Offset = "0x84E5F40", VA = "0x1884E7540")]
	public bool DGEEFKBKHAP([Out] GameObject DFKFFPKHNCH, [Out] GameObject CEENMGBCJEJ, [Out] PLOIJFHDLGK PJOCONLEPEA, [Out] PLOIJFHDLGK PNFNBLJJBHB, [Out] Vector3 DDIHIBMHCDH, [Out] Vector3 EEOGGGNMLJF, [Out] Vector3 PANKGBKDPKB, [Out] PLOIJFHDLGK EDKJJODPODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x84E7EC0", Offset = "0x84E68C0", VA = "0x1884E7EC0")]
	public bool KLIDEEAPAEP([Out] GameObject DFKFFPKHNCH, [Out] GameObject CEENMGBCJEJ, [Out] PLOIJFHDLGK PJOCONLEPEA, [Out] PLOIJFHDLGK PNFNBLJJBHB, [Out] Vector3 DDIHIBMHCDH, [Out] Vector3 EEOGGGNMLJF, [Out] Vector3 PANKGBKDPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x84E7B00", Offset = "0x84E6500", VA = "0x1884E7B00")]
	private void HEKNEJLDBOO(Entity EOGGAEBALGK, EntityManager BGMHMKCNJMG, MagneticAnchorData LOOAIOFMBLA, [Out] GameObject DFKFFPKHNCH, [Out] GameObject CEENMGBCJEJ, [Out] PLOIJFHDLGK PJOCONLEPEA, [Out] PLOIJFHDLGK PNFNBLJJBHB, [Out] Vector3 DDIHIBMHCDH, [Out] Vector3 EEOGGGNMLJF, [Out] Vector3 PANKGBKDPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public KJFOCCFJPEO(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x84E7A70", Offset = "0x84E6470", VA = "0x1884E7A70", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(KJFOCCFJPEO EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x84E82F0", Offset = "0x84E6CF0", VA = "0x1884E82F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct EOCFIAJLIOC : IEquatable<EOCFIAJLIOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x84DC4C0", Offset = "0x84DAEC0", VA = "0x1884DC4C0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(EOCFIAJLIOC EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct DAFNJNKFLMD : IEquatable<DAFNJNKFLMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private AFPNKHOEFPK PNEHFLIEJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x84D88A0", Offset = "0x84D72A0", VA = "0x1884D88A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public EPFFJMIOIIG NJCNLKCAINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x84D86B0", Offset = "0x84D70B0", VA = "0x1884D86B0")]
		get
		{
			return default(EPFFJMIOIIG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x84D8660", Offset = "0x84D7060", VA = "0x1884D8660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public ANIKCFOIBKJ<string> LPJEHFFGKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x84D8B40", Offset = "0x84D7540", VA = "0x1884D8B40")]
		get
		{
			return default(ANIKCFOIBKJ<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x84D8780", Offset = "0x84D7180", VA = "0x1884D8780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public ANIKCFOIBKJ<string> BAJPHAFGEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x84D8900", Offset = "0x84D7300", VA = "0x1884D8900")]
		get
		{
			return default(ANIKCFOIBKJ<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A20", Offset = "0x84D7420", VA = "0x1884D8A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public DAFNJNKFLMD(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x84D86F0", Offset = "0x84D70F0", VA = "0x1884D86F0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(DAFNJNKFLMD EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct HEDHINIDKMM : IEquatable<HEDHINIDKMM>
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly ComponentTypes OEOAJNLMFLF;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly HEDHINIDKMM BHAFCKPMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Collider FALMJIAHDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x84E2630", Offset = "0x84E1030", VA = "0x1884E2630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public GFOOGNIAEFA KLELHDBFHDC
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x84E3210", Offset = "0x84E1C10", VA = "0x1884E3210")]
		get
		{
			return default(GFOOGNIAEFA);
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x84E2390", Offset = "0x84E0D90", VA = "0x1884E2390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public MLHELHANJLJ FGGLFBHDMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x84E3190", Offset = "0x84E1B90", VA = "0x1884E3190")]
		get
		{
			return default(MLHELHANJLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x84E3250", Offset = "0x84E1C50", VA = "0x1884E3250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public MFBAPKLINAH BHPODNMBONC
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x84E31D0", Offset = "0x84E1BD0", VA = "0x1884E31D0")]
		get
		{
			return default(MFBAPKLINAH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x84E2460", Offset = "0x84E0E60", VA = "0x1884E2460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public float OGOMBNCPJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x84E24B0", Offset = "0x84E0EB0", VA = "0x1884E24B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x84E2800", Offset = "0x84E1200", VA = "0x1884E2800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool HNBLHMHLCPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E50", Offset = "0x84E1850", VA = "0x1884E2E50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x84E24F0", Offset = "0x84E0EF0", VA = "0x1884E24F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool IPLJHKPBHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x84E2780", Offset = "0x84E1180", VA = "0x1884E2780")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x84E2D50", Offset = "0x84E1750", VA = "0x1884E2D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool HELEOPCGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x84E2EC0", Offset = "0x84E18C0", VA = "0x1884E2EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x84E2AB0", Offset = "0x84E14B0", VA = "0x1884E2AB0")]
	public static bool EFNHNIANAEB(PLOIJFHDLGK ICDOLBBKJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x84E2F40", Offset = "0x84E1940", VA = "0x1884E2F40")]
	public static bool KPLGLDIBGLN(PLOIJFHDLGK ICDOLBBKJDH, [Out] HEDHINIDKMM HFJEGNKPMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x84E2940", Offset = "0x84E1340", VA = "0x1884E2940")]
	public bool EEOCCMIALLM([Out] OJDIDKEHKMJ LCNIJABNGPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x84E2850", Offset = "0x84E1250", VA = "0x1884E2850")]
	public bool DOJLPEKIDGA([Out] DOIIIDJCDGH PJFDNMGHMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x84E2DF0", Offset = "0x84E17F0", VA = "0x1884E2DF0")]
	public bool GMFCPHJACGN(GCGINMLPDDC BILOCDLBGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x84E23E0", Offset = "0x84E0DE0", VA = "0x1884E23E0")]
	public void AGPFPHALIBB(GCGINMLPDDC BILOCDLBGBK, bool JKHDONCCPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x84E2590", Offset = "0x84E0F90", VA = "0x1884E2590")]
	public void BOOGKKGGNAI(GCGINMLPDDC BILOCDLBGBK, bool JKHDONCCPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public HEDHINIDKMM(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x84E2CC0", Offset = "0x84E16C0", VA = "0x1884E2CC0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(HEDHINIDKMM EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x84E32A0", Offset = "0x84E1CA0", VA = "0x1884E32A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct IDIKAGDHOPA : IEquatable<IDIKAGDHOPA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool ACHBBMNDDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x84E3DC0", Offset = "0x84E27C0", VA = "0x1884E3DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public IDIKAGDHOPA(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x84E3D30", Offset = "0x84E2730", VA = "0x1884E3D30", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(IDIKAGDHOPA EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct KELCHDHBIHJ : IEquatable<KELCHDHBIHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	private LCGIFCAJNGH LDODIKAELCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x84E5930", Offset = "0x84E4330", VA = "0x1884E5930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x84E5A20", Offset = "0x84E4420", VA = "0x1884E5A20")]
	public void GIIPFOANIDJ(bool HINHBDEIAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public KELCHDHBIHJ(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x84E5990", Offset = "0x84E4390", VA = "0x1884E5990", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(KELCHDHBIHJ EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct FJOEAJDBPIP : IEquatable<FJOEAJDBPIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private DHNHLNBFFFJ CNIIKIMKBNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x84DF460", Offset = "0x84DDE60", VA = "0x1884DF460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public EPFFJMIOIIG OJEOHDJFJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x84DEE50", Offset = "0x84DD850", VA = "0x1884DEE50")]
		get
		{
			return default(EPFFJMIOIIG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x84DEF50", Offset = "0x84DD950", VA = "0x1884DEF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool ODKCJBJDEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x84DF330", Offset = "0x84DDD30", VA = "0x1884DF330")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x84DF3C0", Offset = "0x84DDDC0", VA = "0x1884DF3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public ANIKCFOIBKJ<string> HOGJMGKLCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x84DF060", Offset = "0x84DDA60", VA = "0x1884DF060")]
		get
		{
			return default(ANIKCFOIBKJ<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x84DF8C0", Offset = "0x84DE2C0", VA = "0x1884DF8C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public ANIKCFOIBKJ<string> ALHLAOKIIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x84DF9E0", Offset = "0x84DE3E0", VA = "0x1884DF9E0")]
		get
		{
			return default(ANIKCFOIBKJ<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x84DF680", Offset = "0x84DE080", VA = "0x1884DF680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public ANIKCFOIBKJ<string> GMNLDBFDGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x84DF4C0", Offset = "0x84DDEC0", VA = "0x1884DF4C0")]
		get
		{
			return default(ANIKCFOIBKJ<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x84DF180", Offset = "0x84DDB80", VA = "0x1884DF180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public ANIKCFOIBKJ<string> BBIKCKKJOKA
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x84DFB00", Offset = "0x84DE500", VA = "0x1884DFB00")]
		get
		{
			return default(ANIKCFOIBKJ<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x84DF7A0", Offset = "0x84DE1A0", VA = "0x1884DF7A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x84DF5E0", Offset = "0x84DDFE0", VA = "0x1884DF5E0")]
	public bool JILAHBPPFFG(DOIIIDJCDGH JGGGINODJOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public FJOEAJDBPIP(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static DOIIIDJCDGH LHJBCIIELME(FJOEAJDBPIP PDKJBMPOMNC)
	{
		return default(DOIIIDJCDGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x84DF2A0", Offset = "0x84DDCA0", VA = "0x1884DF2A0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(FJOEAJDBPIP EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct KIFAOOMDKML : IEquatable<KIFAOOMDKML>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool HNMAKGMNKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x84E6880", Offset = "0x84E5280", VA = "0x1884E6880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool JCBEADFCDBA
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x84E6EE0", Offset = "0x84E58E0", VA = "0x1884E6EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool LIIKCOKDMIL
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x84E6C00", Offset = "0x84E5600", VA = "0x1884E6C00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x84E6D60", Offset = "0x84E5760", VA = "0x1884E6D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool ONOCJACFCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x84E6A70", Offset = "0x84E5470", VA = "0x1884E6A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool HLNDAGPKEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x84E7330", Offset = "0x84E5D30", VA = "0x1884E7330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool FIKPBLACAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x84E68C0", Offset = "0x84E52C0", VA = "0x1884E68C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool OHHALFHBHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x84E6E30", Offset = "0x84E5830", VA = "0x1884E6E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool IJFIBLOLHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x84E67F0", Offset = "0x84E51F0", VA = "0x1884E67F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool BCDPPOJJKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x84E71A0", Offset = "0x84E5BA0", VA = "0x1884E71A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool BKLPOCKMPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x84E69A0", Offset = "0x84E53A0", VA = "0x1884E69A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool DMDOHDLLEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x84E73D0", Offset = "0x84E5DD0", VA = "0x1884E73D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool FNPBFGGCHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x84E6D80", Offset = "0x84E5780", VA = "0x1884E6D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool JDMGDPLNPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x84E67A0", Offset = "0x84E51A0", VA = "0x1884E67A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool IAHOHILNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x84E6C90", Offset = "0x84E5690", VA = "0x1884E6C90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x84E6E80", Offset = "0x84E5880", VA = "0x1884E6E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool COJPMBCFGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x84E6F80", Offset = "0x84E5980", VA = "0x1884E6F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public BJFCNOLEJHA NIIKHJMNEFC
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x84E6700", Offset = "0x84E5100", VA = "0x1884E6700")]
		get
		{
			return default(BJFCNOLEJHA);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x84E6F30", Offset = "0x84E5930", VA = "0x1884E6F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public bool BNHAPHPJJIO
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x84E7420", Offset = "0x84E5E20", VA = "0x1884E7420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public CBKMGINFBNJ DFBNFFFEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x84E7270", Offset = "0x84E5C70", VA = "0x1884E7270")]
		get
		{
			return default(CBKMGINFBNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x84E6AC0", Offset = "0x84E54C0", VA = "0x1884E6AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public bool AEMPILPOPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x84E6840", Offset = "0x84E5240", VA = "0x1884E6840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public Vector3 DHGLHFKILME
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x84E72B0", Offset = "0x84E5CB0", VA = "0x1884E72B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public Vector3 MFOOOJLEDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x84E71F0", Offset = "0x84E5BF0", VA = "0x1884E71F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public bool LODANCNEDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x84E6FD0", Offset = "0x84E59D0", VA = "0x1884E6FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public bool BCCBFGHDLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x84E6B10", Offset = "0x84E5510", VA = "0x1884E6B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	private EntityManager HGINAJFEKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x84E6790", Offset = "0x84E5190", VA = "0x1884E6790")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x84E6DD0", Offset = "0x84E57D0", VA = "0x1884E6DD0")]
	public bool KANDBJOBNNE(GJIPGMHFBCO BILOCDLBGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x84E6CD0", Offset = "0x84E56D0", VA = "0x1884E6CD0")]
	public void IOFEFLHEEAF(GJIPGMHFBCO BILOCDLBGBK, bool JKHDONCCPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x84E6740", Offset = "0x84E5140", VA = "0x1884E6740")]
	public bool BEJLGBOLBNG(ALMFFOLOPBG BILOCDLBGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x84E69F0", Offset = "0x84E53F0", VA = "0x1884E69F0")]
	public void FMONCBBLKNG(ALMFFOLOPBG BILOCDLBGBK, bool JKHDONCCPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x84E6C50", Offset = "0x84E5650", VA = "0x1884E6C50")]
	public ALMFFOLOPBG IHFIDDFGNCC()
	{
		return default(ALMFFOLOPBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x84E7380", Offset = "0x84E5D80", VA = "0x1884E7380")]
	public bool OPANAEKCONL(ALMFFOLOPBG PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public KIFAOOMDKML(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x84E6910", Offset = "0x84E5310", VA = "0x1884E6910", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(KIFAOOMDKML EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct NCMKNMGGBII : IEquatable<NCMKNMGGBII>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	private BKIPHBLJMEF JPCNIHPKNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x84EA6C0", Offset = "0x84E90C0", VA = "0x1884EA6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x84EA720", Offset = "0x84E9120", VA = "0x1884EA720")]
	public bool AFALNBHOJIA(MOLGCNIPLLK DOFFGKPAKJD, List<PLOIJFHDLGK> CAIABPFCJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x84EAE30", Offset = "0x84E9830", VA = "0x1884EAE30")]
	public int ILEBDIOJGDF(MOLGCNIPLLK DOFFGKPAKJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x84EAD20", Offset = "0x84E9720", VA = "0x1884EAD20")]
	public void HEJJHHFKFDK(List<PLOIJFHDLGK> CAIABPFCJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x84EABF0", Offset = "0x84E95F0", VA = "0x1884EABF0")]
	public int GLFKDNIBEKK(PLOIJFHDLGK IMFCAPGBDGB, MOLGCNIPLLK DOFFGKPAKJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x84EAA30", Offset = "0x84E9430", VA = "0x1884EAA30")]
	public PLOIJFHDLGK EBHLIPHFHCJ(int FILGHJLFKAL, MOLGCNIPLLK DOFFGKPAKJD)
	{
		return default(PLOIJFHDLGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x84EA900", Offset = "0x84E9300", VA = "0x1884EA900")]
	public void CCGNNJJFFCG(PLOIJFHDLGK IMFCAPGBDGB, MOLGCNIPLLK DOFFGKPAKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x84EAF40", Offset = "0x84E9940", VA = "0x1884EAF40")]
	public bool JBNIFIJHGEI(PLOIJFHDLGK IMFCAPGBDGB, MOLGCNIPLLK DOFFGKPAKJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x84EB100", Offset = "0x84E9B00", VA = "0x1884EB100")]
	public void OOMENIDCFEA(MOLGCNIPLLK DOFFGKPAKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x84EA850", Offset = "0x84E9250", VA = "0x1884EA850")]
	public bool BKPLMNGDKCO(PLOIJFHDLGK IMFCAPGBDGB, MOLGCNIPLLK DOFFGKPAKJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x84EAFF0", Offset = "0x84E99F0", VA = "0x1884EAFF0")]
	public bool MBBFNKBGICE(MOLGCNIPLLK DOFFGKPAKJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public NCMKNMGGBII(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x84EAB60", Offset = "0x84E9560", VA = "0x1884EAB60", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(NCMKNMGGBII EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct ELLNMHNMGOB : IEquatable<ELLNMHNMGOB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x84DC1D0", Offset = "0x84DABD0", VA = "0x1884DC1D0")]
	public void EKFIMGLIBGG(bool PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x84DC2F0", Offset = "0x84DACF0", VA = "0x1884DC2F0")]
	public void JGMMBIOPMCG(bool PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x3AE61C0", Offset = "0x3AE4BC0", VA = "0x183AE61C0")]
	public T OECCJEGLJNK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public ELLNMHNMGOB(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x84DC260", Offset = "0x84DAC60", VA = "0x1884DC260", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(ELLNMHNMGOB EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct ODMGNCGEAKO : IEquatable<ODMGNCGEAKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public bool LPCFGKBMANI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x84EB3F0", Offset = "0x84E9DF0", VA = "0x1884EB3F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x84EB540", Offset = "0x84E9F40", VA = "0x1884EB540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool JIMKFGDOJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x84EB430", Offset = "0x84E9E30", VA = "0x1884EB430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public int AJINHLJLEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x84EB620", Offset = "0x84EA020", VA = "0x1884EB620")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x84EB590", Offset = "0x84E9F90", VA = "0x1884EB590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public ODMGNCGEAKO(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x84EB4B0", Offset = "0x84E9EB0", VA = "0x1884EB4B0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(ODMGNCGEAKO EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct MAGPEGOIMBI : IEquatable<MAGPEGOIMBI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public int OHHFCIJFEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x84EA400", Offset = "0x84E8E00", VA = "0x1884EA400")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x84EA510", Offset = "0x84E8F10", VA = "0x1884EA510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public int FLJPCHFGFEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x84EA5B0", Offset = "0x84E8FB0", VA = "0x1884EA5B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x84EA560", Offset = "0x84E8F60", VA = "0x1884EA560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public uint JHBNFFMMBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x84EA440", Offset = "0x84E8E40", VA = "0x1884EA440")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x84EA3B0", Offset = "0x84E8DB0", VA = "0x1884EA3B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public MAGPEGOIMBI(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x84EA480", Offset = "0x84E8E80", VA = "0x1884EA480", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(MAGPEGOIMBI EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct GKLHEFJIKAC : IEquatable<GKLHEFJIKAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	private GBGLLJHFLJD FOBIPJCHAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x84E1650", Offset = "0x84E0050", VA = "0x1884E1650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	private BAFDDELEODG JCMJEJEMEGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x84E1D70", Offset = "0x84E0770", VA = "0x1884E1D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public bool FHFHAHKHDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x84E12F0", Offset = "0x84DFCF0", VA = "0x1884E12F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public bool JJLNLBKLOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x84E1380", Offset = "0x84DFD80", VA = "0x1884E1380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public bool DDDNNCGKNHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x84E1980", Offset = "0x84E0380", VA = "0x1884E1980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public bool LLLBCBEFLNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x84E16B0", Offset = "0x84E00B0", VA = "0x1884E16B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool LKFFFKOPFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x84E18B0", Offset = "0x84E02B0", VA = "0x1884E18B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool OKLJDIBJKKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x84E1CE0", Offset = "0x84E06E0", VA = "0x1884E1CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public bool HBMGPFGANFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x84E1420", Offset = "0x84DFE20", VA = "0x1884E1420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public bool OJPKCICJHDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x84E1B70", Offset = "0x84E0570", VA = "0x1884E1B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool MAHKCJBDBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x84E1780", Offset = "0x84E0180", VA = "0x1884E1780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x84E1280", Offset = "0x84DFC80", VA = "0x1884E1280")]
	public bool ABHPDANOCJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x84E18E0", Offset = "0x84E02E0", VA = "0x1884E18E0")]
	public PLOIJFHDLGK KAKAFKDBAFA(PLOIJFHDLGK IMFCAPGBDGB)
	{
		return default(PLOIJFHDLGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x84E1A60", Offset = "0x84E0460", VA = "0x1884E1A60")]
	public DOIIIDJCDGH MAPEHOMGIHN()
	{
		return default(DOIIIDJCDGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x84E19B0", Offset = "0x84E03B0", VA = "0x1884E19B0")]
	public bool LGGFCMMPLKN(DOIIIDJCDGH IMFCAPGBDGB, [Out] DOIIIDJCDGH OOPOIGBJFHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public GKLHEFJIKAC(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x84E03F0", Offset = "0x84DEDF0", VA = "0x1884E03F0")]
	public static bool LHJBCIIELME(GKLHEFJIKAC PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x84E15C0", Offset = "0x84DFFC0", VA = "0x1884E15C0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(GKLHEFJIKAC EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct LGMPNKNEGCB : IEquatable<LGMPNKNEGCB>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly LGMPNKNEGCB BHAFCKPMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public HJEFGOJLOAN AEFEFDJPFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x84E8CE0", Offset = "0x84E76E0", VA = "0x1884E8CE0")]
		get
		{
			return default(HJEFGOJLOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public HLFHMCNDAGP CALPOELKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x84E88B0", Offset = "0x84E72B0", VA = "0x1884E88B0")]
		get
		{
			return default(HLFHMCNDAGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x84E8B50", Offset = "0x84E7550", VA = "0x1884E8B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public NICLJDPJKKF ADBOMPMBHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x84E8C40", Offset = "0x84E7640", VA = "0x1884E8C40")]
		get
		{
			return default(NICLJDPJKKF);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x84E8BF0", Offset = "0x84E75F0", VA = "0x1884E8BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public float PDPENGACCBE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x84E8870", Offset = "0x84E7270", VA = "0x1884E8870")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x84E8700", Offset = "0x84E7100", VA = "0x1884E8700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public Vector3 PJBLJBOPGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x84E8A90", Offset = "0x84E7490", VA = "0x1884E8A90")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x84E87A0", Offset = "0x84E71A0", VA = "0x1884E87A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public float BMKNFOMGOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x84E8D20", Offset = "0x84E7720", VA = "0x1884E8D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public EMGMCNDGCFG HBLIEDAFGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x84E8B10", Offset = "0x84E7510", VA = "0x1884E8B10")]
		get
		{
			return default(EMGMCNDGCFG);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x84E8980", Offset = "0x84E7380", VA = "0x1884E8980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public bool NDKFOINLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x84E8A50", Offset = "0x84E7450", VA = "0x1884E8A50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x84E8C80", Offset = "0x84E7680", VA = "0x1884E8C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public FAMAPDJAOCI AMPAFLPNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(FAMAPDJAOCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public KHPBHJEBIFJ DMOHGBMKEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(KHPBHJEBIFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x84E8750", Offset = "0x84E7150", VA = "0x1884E8750")]
	public OKDELMLPAHC AMJNGIANIOJ()
	{
		return default(OKDELMLPAHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x84E8820", Offset = "0x84E7220", VA = "0x1884E8820")]
	public ILLNFBMIGAN DJMBEDOMHID()
	{
		return default(ILLNFBMIGAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x84E8BA0", Offset = "0x84E75A0", VA = "0x1884E8BA0")]
	private bool KCPDLAGIPGP(EMGMCNDGCFG BILOCDLBGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x84E89D0", Offset = "0x84E73D0", VA = "0x1884E89D0")]
	public void GMMKONLHDAI(EMGMCNDGCFG BILOCDLBGBK, bool JKHDONCCPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public LGMPNKNEGCB(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x84E03F0", Offset = "0x84DEDF0", VA = "0x1884E03F0")]
	public static bool LHJBCIIELME(LGMPNKNEGCB PDKJBMPOMNC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x84D7840", Offset = "0x84D6240", VA = "0x1884D7840")]
	public static bool CNNLEBNJPBE(LGMPNKNEGCB MLLJGIHINDJ, LGMPNKNEGCB ABNAHAKPDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x84E88F0", Offset = "0x84E72F0", VA = "0x1884E88F0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(LGMPNKNEGCB EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct OKDELMLPAHC : IEquatable<OKDELMLPAHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public LGMPNKNEGCB DDENKLNMAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(LGMPNKNEGCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public CEHCOOIBKHM JFLNPJPEJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x84EB6F0", Offset = "0x84EA0F0", VA = "0x1884EB6F0")]
		get
		{
			return default(CEHCOOIBKHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public OKDELMLPAHC(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x84E03F0", Offset = "0x84DEDF0", VA = "0x1884E03F0")]
	public static bool LHJBCIIELME(OKDELMLPAHC PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x84EB660", Offset = "0x84EA060", VA = "0x1884EB660", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(OKDELMLPAHC EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DefaultMember("Item")]
public readonly struct ILLNFBMIGAN : IEquatable<ILLNFBMIGAN>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly ILLNFBMIGAN BHAFCKPMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	private CKKFMDPFIPM OJCDKJGDAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x84E5060", Offset = "0x84E3A60", VA = "0x1884E5060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public LGMPNKNEGCB DDENKLNMAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(LGMPNKNEGCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public PGCJEENILJB CKLNPKPJKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x84E52E0", Offset = "0x84E3CE0", VA = "0x1884E52E0")]
		get
		{
			return default(PGCJEENILJB);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x84E4830", Offset = "0x84E3230", VA = "0x1884E4830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public IEnumerable<INBAGDNGNDP> PICPBDNJJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x84E49E0", Offset = "0x84E33E0", VA = "0x1884E49E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public INBAGDNGNDP EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x84E4EB0", Offset = "0x84E38B0", VA = "0x1884E4EB0")]
		get
		{
			return default(INBAGDNGNDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x84E4E20", Offset = "0x84E3820", VA = "0x1884E4E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public FAMAPDJAOCI AMPAFLPNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(FAMAPDJAOCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x84E50C0", Offset = "0x84E3AC0", VA = "0x1884E50C0")]
	public INBAGDNGNDP OHHBGINEBFD(float3? DDIHIBMHCDH, [Optional] quaternion? JCDLBIBEGAF, [Optional] Vector3? DILGPPEHCGK)
	{
		return default(INBAGDNGNDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x84E4BF0", Offset = "0x84E35F0", VA = "0x1884E4BF0")]
	public INBAGDNGNDP IGMDGELPIPM(int FILGHJLFKAL, float3? DDIHIBMHCDH, [Optional] quaternion? JCDLBIBEGAF, [Optional] Vector3? DILGPPEHCGK)
	{
		return default(INBAGDNGNDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x84E4FC0", Offset = "0x84E39C0", VA = "0x1884E4FC0")]
	public void MLIFBPNJBCL(int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x84E47A0", Offset = "0x84E31A0", VA = "0x1884E47A0")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public ILLNFBMIGAN(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x84E03F0", Offset = "0x84DEDF0", VA = "0x1884E03F0")]
	public static bool LHJBCIIELME(ILLNFBMIGAN PDKJBMPOMNC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x84D7B40", Offset = "0x84D6540", VA = "0x1884D7B40")]
	public static bool JJNADAGGMDE(ILLNFBMIGAN MLLJGIHINDJ, ILLNFBMIGAN ABNAHAKPDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x84E4950", Offset = "0x84E3350", VA = "0x1884E4950", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(ILLNFBMIGAN EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct INBAGDNGNDP : IEquatable<INBAGDNGNDP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public ILLNFBMIGAN CLLEPBADGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x84E54F0", Offset = "0x84E3EF0", VA = "0x1884E54F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public float3 PKNMOJAEEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x84E55D0", Offset = "0x84E3FD0", VA = "0x1884E55D0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x84E5570", Offset = "0x84E3F70", VA = "0x1884E5570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public quaternion NGNBDBJMMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x84E56F0", Offset = "0x84E40F0", VA = "0x1884E56F0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x84E5410", Offset = "0x84E3E10", VA = "0x1884E5410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public float3 ODBFHLPCADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x84E5740", Offset = "0x84E4140", VA = "0x1884E5740")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x84E5690", Offset = "0x84E4090", VA = "0x1884E5690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public HJPEFODOPFJ LBOOGLOMMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x84E5630", Offset = "0x84E4030", VA = "0x1884E5630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x84E5680", Offset = "0x84E4080", VA = "0x1884E5680")]
	public void OJGGGKMDOBC(ILLNFBMIGAN PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public INBAGDNGNDP(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x84E5460", Offset = "0x84E3E60", VA = "0x1884E5460", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(INBAGDNGNDP EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct GCNOIGCPJAA : IEquatable<GCNOIGCPJAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public bool DLIMDFPDEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x84E0A00", Offset = "0x84DF400", VA = "0x1884E0A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public GCNOIGCPJAA(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x84E0970", Offset = "0x84DF370", VA = "0x1884E0970", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(GCNOIGCPJAA EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct PLBBABNEGJP : IEquatable<PLBBABNEGJP>
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public static readonly PLBBABNEGJP BHAFCKPMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	private DPELLBILFJB IGFNJGDBMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x84ED6A0", Offset = "0x84EC0A0", VA = "0x1884ED6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public uint FMGNDOAKFID
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x84ED8E0", Offset = "0x84EC2E0", VA = "0x1884ED8E0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x84ED310", Offset = "0x84EBD10", VA = "0x1884ED310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public KLOKHGMABCA JNIGFFONDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x84ED550", Offset = "0x84EBF50", VA = "0x1884ED550")]
		get
		{
			return default(KLOKHGMABCA);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x84ED120", Offset = "0x84EBB20", VA = "0x1884ED120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public float OOHGMOECEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x84ED860", Offset = "0x84EC260", VA = "0x1884ED860")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x84ED650", Offset = "0x84EC050", VA = "0x1884ED650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public float PGHDHKDKJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x84ED2D0", Offset = "0x84EBCD0", VA = "0x1884ED2D0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x84ED170", Offset = "0x84EBB70", VA = "0x1884ED170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public MGJDJHNEGLA DPNGJKMHCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x84ED700", Offset = "0x84EC100", VA = "0x1884ED700")]
		get
		{
			return default(MGJDJHNEGLA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x84ED1C0", Offset = "0x84EBBC0", VA = "0x1884ED1C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public float PIKHEBIIEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x84ED8A0", Offset = "0x84EC2A0", VA = "0x1884ED8A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x84ED3F0", Offset = "0x84EBDF0", VA = "0x1884ED3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public ReadOnlySpan<TerrainGenerationLayer> EDGGKPDIMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x84ED590", Offset = "0x84EBF90", VA = "0x1884ED590")]
		get
		{
			return default(ReadOnlySpan<TerrainGenerationLayer>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x84ED440", Offset = "0x84EBE40", VA = "0x1884ED440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public ReadOnlySpan<ICMIJHNFGBH> LDIFOJAJJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x84ED210", Offset = "0x84EBC10", VA = "0x1884ED210")]
		get
		{
			return default(ReadOnlySpan<ICMIJHNFGBH>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x84ED740", Offset = "0x84EC140", VA = "0x1884ED740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public PLBBABNEGJP(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static DOIIIDJCDGH LHJBCIIELME(PLBBABNEGJP PDKJBMPOMNC)
	{
		return default(DOIIIDJCDGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x84ED360", Offset = "0x84EBD60", VA = "0x1884ED360", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(PLBBABNEGJP EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct PGBIGEJBGHD : IEquatable<PGBIGEJBGHD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	private FJANBECNICF GKHNFFHDLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x84ECE90", Offset = "0x84EB890", VA = "0x1884ECE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public bool DBPHHDHDPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x84ECC10", Offset = "0x84EB610", VA = "0x1884ECC10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x84ECBB0", Offset = "0x84EB5B0", VA = "0x1884ECBB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public bool NLHFEDMHJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x84EC350", Offset = "0x84EAD50", VA = "0x1884EC350")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x84ECD90", Offset = "0x84EB790", VA = "0x1884ECD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public float EENMEKGONBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x84EC310", Offset = "0x84EAD10", VA = "0x1884EC310")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x84ECA30", Offset = "0x84EB430", VA = "0x1884ECA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public bool NFFNENBOCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x84ECCF0", Offset = "0x84EB6F0", VA = "0x1884ECCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x84EC7F0", Offset = "0x84EB1F0", VA = "0x1884EC7F0")]
	public void EHKKLJJOOCD(int ICBGFNPAHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x84EC890", Offset = "0x84EB290", VA = "0x1884EC890")]
	public bool EKLNHLKJMOJ([Out] int ICBGFNPAHKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x84ECDF0", Offset = "0x84EB7F0", VA = "0x1884ECDF0")]
	public void KMOFEBMCCIK(bool PDBDLDHMLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x84ECD40", Offset = "0x84EB740", VA = "0x1884ECD40")]
	public bool KFLJDCHKAGP(PLHAJCJHLOP BILOCDLBGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x84EC3A0", Offset = "0x84EADA0", VA = "0x1884EC3A0")]
	public void BGHDOJPJLNH(PLHAJCJHLOP BILOCDLBGBK, bool JKHDONCCPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x84EC420", Offset = "0x84EAE20", VA = "0x1884EC420")]
	public void CHOAPEPKMMC(float ACIBJMIHJLK, float OHHNBOKBFGD, float PMOPBPMKGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x84EC570", Offset = "0x84EAF70", VA = "0x1884EC570")]
	public void CIEMAHIFDHN(float3 IAPDIBKECPB, quaternion IBDMOGLICHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x84ECA80", Offset = "0x84EB480", VA = "0x1884ECA80")]
	public bool GBAJAPAAOOD([Out] float3 IAPDIBKECPB, [Out] quaternion IBDMOGLICHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x84EC6C0", Offset = "0x84EB0C0", VA = "0x1884EC6C0")]
	public bool DBHLCNILFOB([Out] float MKJGLHNEMJL, [Out] float KPGLNHLMHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x84ECC60", Offset = "0x84EB660", VA = "0x1884ECC60")]
	public void JBOMEBJKEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public PGBIGEJBGHD(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x84EC9A0", Offset = "0x84EB3A0", VA = "0x1884EC9A0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(PGBIGEJBGHD EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct FAMAPDJAOCI : IEquatable<FAMAPDJAOCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	private NPHMHJLBEIO LEOHBEAIDCP
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x84DDA00", Offset = "0x84DC400", VA = "0x1884DDA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public Vector3 PKNMOJAEEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x84DDE70", Offset = "0x84DC870", VA = "0x1884DDE70")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x84DD6D0", Offset = "0x84DC0D0", VA = "0x1884DD6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public Quaternion NGNBDBJMMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x84DE5C0", Offset = "0x84DCFC0", VA = "0x1884DE5C0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x84DD1F0", Offset = "0x84DBBF0", VA = "0x1884DD1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public Vector3 AIIJAKFFIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x84DEA50", Offset = "0x84DD450", VA = "0x1884DEA50")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x84DEB40", Offset = "0x84DD540", VA = "0x1884DEB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public Quaternion KCMJHAANMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x84DD010", Offset = "0x84DBA10", VA = "0x1884DD010")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x84DE100", Offset = "0x84DCB00", VA = "0x1884DE100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public float COPGMFFJDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x84DD7A0", Offset = "0x84DC1A0", VA = "0x1884DD7A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x84DD510", Offset = "0x84DBF10", VA = "0x1884DD510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public float MNLMOEGEBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x84DD150", Offset = "0x84DBB50", VA = "0x1884DD150")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public Matrix4x4 GJJMDEKGDBL
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x84DD5C0", Offset = "0x84DBFC0", VA = "0x1884DD5C0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public KHPBHJEBIFJ DMOHGBMKEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(KHPBHJEBIFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	private DHIIJDNMGLD CCBLAICOKII
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x84DAAB0", Offset = "0x84D94B0", VA = "0x1884DAAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x84DE2C0", Offset = "0x84DCCC0", VA = "0x1884DE2C0")]
	public JFHFHCDHJDD NLCJFOKPDNM()
	{
		return default(JFHFHCDHJDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x84DDD50", Offset = "0x84DC750", VA = "0x1884DDD50")]
	public void MBAANKOFPBP([Out] Matrix4x4 CNNCGMLGFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x84DE7C0", Offset = "0x84DD1C0", VA = "0x1884DE7C0")]
	public void OLKEABCEBHE([In] Vector3 GDEEHHOMKPN, [In] Quaternion IEBOBJIHNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x84DE700", Offset = "0x84DD100", VA = "0x1884DE700")]
	public void OLKEABCEBHE([In] RigidTransform ALMOMHCCOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x84DE3A0", Offset = "0x84DCDA0", VA = "0x1884DE3A0")]
	public void OEIEEEDOBPJ([Out] RigidTransform ALMOMHCCOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x84DCDD0", Offset = "0x84DB7D0", VA = "0x1884DCDD0")]
	public void APDJPIEBNDD([In] Vector3 EFALHCABPMH, [In] Quaternion GDAOMAGJOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x84DCD10", Offset = "0x84DB710", VA = "0x1884DCD10")]
	public void APDJPIEBNDD([In] RigidTransform ABNMGHKPJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x84DE8C0", Offset = "0x84DD2C0", VA = "0x1884DE8C0")]
	public void PAJFBJFALAL([Out] Vector3 EFALHCABPMH, [Out] Quaternion GDAOMAGJOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x84DE9A0", Offset = "0x84DD3A0", VA = "0x1884DE9A0")]
	public void PAJFBJFALAL([Out] RigidTransform ALMOMHCCOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x84DE1D0", Offset = "0x84DCBD0", VA = "0x1884DE1D0")]
	public UniformTRS NCAICFBDMGC()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x84DE200", Offset = "0x84DCC00", VA = "0x1884DE200")]
	public void NCAICFBDMGC([Out] UniformTRS ABNMGHKPJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x84DD450", Offset = "0x84DBE50", VA = "0x1884DD450")]
	public UniformTRS ELPDKFODAKD()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x84DD390", Offset = "0x84DBD90", VA = "0x1884DD390")]
	public void ELPDKFODAKD([Out] UniformTRS ALMOMHCCOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x84DDF60", Offset = "0x84DC960", VA = "0x1884DDF60")]
	public Vector3 MNGFJCJKOMK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x84DE4F0", Offset = "0x84DCEF0", VA = "0x1884DE4F0")]
	public void OGFEMKFBBPA([In] Vector3 PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x84DD840", Offset = "0x84DC240", VA = "0x1884DD840")]
	public Vector3 IHLHAGPJOMJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x84DD930", Offset = "0x84DC330", VA = "0x1884DD930")]
	public void KKNCJDFHPOL([In] Vector3 PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x84DDB60", Offset = "0x84DC560", VA = "0x1884DDB60")]
	public Quaternion KNEHOHMPBFB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x84DD2C0", Offset = "0x84DBCC0", VA = "0x1884DD2C0")]
	public void EBKJPDCJBHI([In] Quaternion PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x84DCED0", Offset = "0x84DB8D0", VA = "0x1884DCED0")]
	public Quaternion CBNIIFHLFJC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x84DD600", Offset = "0x84DC000", VA = "0x1884DD600")]
	public void HJBDHENBKJP([In] Quaternion PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x84DE450", Offset = "0x84DCE50", VA = "0x1884DE450")]
	public float OGBAJPALHHL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x84DE050", Offset = "0x84DCA50", VA = "0x1884DE050")]
	public void MOLECGKNJFG(float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x84DDAC0", Offset = "0x84DC4C0", VA = "0x1884DDAC0")]
	public float KNCMMDIHLMI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x84DDCA0", Offset = "0x84DC6A0", VA = "0x1884DDCA0")]
	public void LBBKHLMOHPI(float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x84DE310", Offset = "0x84DCD10", VA = "0x1884DE310")]
	public Vector3 OAFKCBDCHGF([In] Vector3 PNELABKCNPL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public FAMAPDJAOCI(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x84DD480", Offset = "0x84DBE80", VA = "0x1884DD480", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(FAMAPDJAOCI EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct PGEFLCHMMJD : IEquatable<PGEFLCHMMJD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	private OKENDFDGJKP LFNNNBNDEKN
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x84ECEF0", Offset = "0x84EB8F0", VA = "0x1884ECEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public PLOIJFHDLGK KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(PLOIJFHDLGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	private JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x84D6790", Offset = "0x84D5190", VA = "0x1884D6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x84ECFE0", Offset = "0x84EB9E0", VA = "0x1884ECFE0")]
	public void ICJFAJKDIAP(string FLFLJCMPPBA, EGHJMECPGFA IMEMANHPBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public PGEFLCHMMJD(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x84ECF50", Offset = "0x84EB950", VA = "0x1884ECF50", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(PGEFLCHMMJD EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x84D5820", Offset = "0x84D4220", VA = "0x1884D5820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct OKHKCEABAOI : IEquatable<OKHKCEABAOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public EFJKAGJCDIF OOOINBIGFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x84EBEC0", Offset = "0x84EA8C0", VA = "0x1884EBEC0")]
		get
		{
			return default(EFJKAGJCDIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public OKHKCEABAOI(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x84EBE30", Offset = "0x84EA830", VA = "0x1884EBE30", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(OKHKCEABAOI EFNHKCDKOGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct IEBENBKHNFD : IEquatable<IEBENBKHNFD>
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public struct KLCEICGDJMD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private DOIIIDJCDGH DBDHPICCKFG;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x84E8480", Offset = "0x84E6E80", VA = "0x1884E8480")]
		public KLCEICGDJMD(DOIIIDJCDGH DBDHPICCKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x84E83F0", Offset = "0x84E6DF0", VA = "0x1884E83F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x84E3F00", Offset = "0x84E2900", VA = "0x1884E3F00")]
	public KLCEICGDJMD EOFEAOLJNDG()
	{
		return default(KLCEICGDJMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x84E3E10", Offset = "0x84E2810", VA = "0x1884E3E10")]
	public EGLOHGAPNLB AMFLAJCHCPD(Allocator POJKLAFAMOD = Allocator.Temp)
	{
		return default(EGLOHGAPNLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x84E4020", Offset = "0x84E2A20", VA = "0x1884E4020")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> FOEPCEBIBJO(Allocator POJKLAFAMOD = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x84E44C0", Offset = "0x84E2EC0", VA = "0x1884E44C0")]
	public NativeArray<GLONLLNEBOJ> OLODMIJLINH(Allocator POJKLAFAMOD = Allocator.Temp)
	{
		return default(NativeArray<GLONLLNEBOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x84E42D0", Offset = "0x84E2CD0", VA = "0x1884E42D0")]
	public NativeArray<GLONLLNEBOJ> IGJABLNKGFB(Allocator POJKLAFAMOD = Allocator.Temp)
	{
		return default(NativeArray<GLONLLNEBOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x84E4210", Offset = "0x84E2C10", VA = "0x1884E4210")]
	public LOFEKKDNAJB IDNLMHMABFB(Allocator POJKLAFAMOD = Allocator.Temp)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x84E4400", Offset = "0x84E2E00", VA = "0x1884E4400")]
	public LOFEKKDNAJB OLBIIHPCANG(Allocator POJKLAFAMOD = Allocator.Temp)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x84E4150", Offset = "0x84E2B50", VA = "0x1884E4150")]
	public LOFEKKDNAJB HNDOGCDEEMA(Allocator POJKLAFAMOD = Allocator.Temp)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public IEBENBKHNFD(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x84E3F90", Offset = "0x84E2990", VA = "0x1884E3F90", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(IEBENBKHNFD EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x84DC4A0", Offset = "0x84DAEA0", VA = "0x1884DC4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct AAHPOEHPAKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int FBDGJOBODAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public int GJCKEEOBHEL;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct OMMEAGIPDJH : IEquatable<OMMEAGIPDJH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public IEBENBKHNFD KEPCPLLODLM
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(IEBENBKHNFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public EMNGAOMIEMP CBAAPALEPCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(EMNGAOMIEMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public OKHKCEABAOI LOONCPEBCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(OKHKCEABAOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x84EC1B0", Offset = "0x84EABB0", VA = "0x1884EC1B0")]
	public bool GINOJLAJKMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x84EBFB0", Offset = "0x84EA9B0", VA = "0x1884EBFB0")]
	public bool ALJDCBADOGM([Out] Exception KOFGEHMDLMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public OMMEAGIPDJH(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static DOIIIDJCDGH LHJBCIIELME(OMMEAGIPDJH PDKJBMPOMNC)
	{
		return default(DOIIIDJCDGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x84EC120", Offset = "0x84EAB20", VA = "0x1884EC120", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(OMMEAGIPDJH EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x84DC4A0", Offset = "0x84DAEA0", VA = "0x1884DC4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public readonly struct LJOPGOMDIAG : IDisposable, IEquatable<LJOPGOMDIAG>
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static readonly LJOPGOMDIAG BHAFCKPMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public OMMEAGIPDJH JKEEOHKCKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(OMMEAGIPDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public IEBENBKHNFD KEPCPLLODLM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(IEBENBKHNFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x84E8FC0", Offset = "0x84E79C0", VA = "0x1884E8FC0")]
	public void HAEOLODIAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x84E8E60", Offset = "0x84E7860", VA = "0x1884E8E60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public LJOPGOMDIAG(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x84E8F30", Offset = "0x84E7930", VA = "0x1884E8F30", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "5")]
	public bool Equals(LJOPGOMDIAG EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x84E9040", Offset = "0x84E7A40", VA = "0x1884E9040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public readonly struct EMNGAOMIEMP : IEquatable<EMNGAOMIEMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly DOIIIDJCDGH JGBFCMNOFDB;

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public bool ALNFNMNKDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x84DC410", Offset = "0x84DAE10", VA = "0x1884DC410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	public EMNGAOMIEMP(DOIIIDJCDGH DBDHPICCKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D41F0", VA = "0x1884D57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x84DC380", Offset = "0x84DAD80", VA = "0x1884DC380", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4150", VA = "0x1884D5750", Slot = "4")]
	public bool Equals(EMNGAOMIEMP EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x84DC4A0", Offset = "0x84DAEA0", VA = "0x1884DC4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class PCFEANOOBBM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct GNAAMHDLIMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Guid DNLDANFOOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public ECIFMLNEFBM ICKNCHMHEBM;
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private struct ECIFMLNEFBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int PDKJBMPOMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int CBCHDGOOHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int ANCCLINPLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int JEBGJJADCEK;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x84DAE60", Offset = "0x84D9860", VA = "0x1884DAE60")]
		public bool JLDIIIFHFGM([Out] GLONLLNEBOJ GDPFIJKMJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x84DAF00", Offset = "0x84D9900", VA = "0x1884DAF00")]
		public ECIFMLNEFBM(GLONLLNEBOJ GDPFIJKMJBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x84EC250", Offset = "0x84EAC50", VA = "0x1884EC250")]
	public static Guid HOHPJOLPELD(this GLONLLNEBOJ GDPFIJKMJBC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x84EC2F0", Offset = "0x84EACF0", VA = "0x1884EC2F0")]
	public static bool OPPNNDFIIFH(this Guid DNLDANFOOJK, [Out] GLONLLNEBOJ GDPFIJKMJBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class LPIGHINIGJN
{
	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x84EA180", Offset = "0x84E8B80", VA = "0x1884EA180")]
	public static JDIMFMLOFCB NAAAPINGONF(this DOIIIDJCDGH EGJGKBPPPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x84EA120", Offset = "0x84E8B20", VA = "0x1884EA120")]
	public static KADNMICOHMP MFAGDPIHMMO(this DOIIIDJCDGH EGJGKBPPPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x84E9F80", Offset = "0x84E8980", VA = "0x1884E9F80")]
	public static EntityManager HGINAJFEKHG(this DOIIIDJCDGH EGJGKBPPPFG)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x3D827D0", Offset = "0x3D811D0", VA = "0x183D827D0")]
	internal static bool FBMBGELMNLE<T>(this DOIIIDJCDGH EGJGKBPPPFG, bool JKHDONCCPDC) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x84EA010", Offset = "0x84E8A10", VA = "0x1884EA010")]
	public static bool KFFFLBNPCJG(this DOIIIDJCDGH EGJGKBPPPFG, ACDGIJAKCPP OGFGMDINCKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x3D82990", Offset = "0x3D81390", VA = "0x183D82990")]
	public static bool HMKGFLJDPKJ<T>(this DOIIIDJCDGH EGJGKBPPPFG) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D86350", Offset = "0x3D84D50", VA = "0x183D86350")]
	public static bool LFAHMCIFDJI<T>(this DOIIIDJCDGH EGJGKBPPPFG) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x3D880E0", Offset = "0x3D86AE0", VA = "0x183D880E0")]
	[PGJEOCIKFPA]
	internal static NativeArray<T> OFDDAEMGHCN<T>(this DOIIIDJCDGH EGJGKBPPPFG, Allocator POJKLAFAMOD) where T : struct, IBufferElementData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x3D86650", Offset = "0x3D85050", VA = "0x183D86650")]
	[PGJEOCIKFPA]
	public static T NOEEFIEOKLE<T>(this DOIIIDJCDGH EGJGKBPPPFG) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x3D83430", Offset = "0x3D81E30", VA = "0x183D83430")]
	[PGJEOCIKFPA]
	public static T IGOKGLGGNIH<T>(this DOIIIDJCDGH EGJGKBPPPFG) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x3D864B0", Offset = "0x3D84EB0", VA = "0x183D864B0")]
	public static bool LPDKJOGEEGD<T>(this DOIIIDJCDGH EGJGKBPPPFG, [Out] T PDKJBMPOMNC) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x3D82720", Offset = "0x3D81120", VA = "0x183D82720")]
	public static T BBHJBMAGAJB<T>(this DOIIIDJCDGH EGJGKBPPPFG) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x3D865D0", Offset = "0x3D84FD0", VA = "0x183D865D0")]
	public static T LPNGEMLFEBB<T>(this DOIIIDJCDGH EGJGKBPPPFG) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class MGMEHIDOPEI
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public struct EGLOHGAPNLB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private LOFEKKDNAJB GJFINIAHPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HPFLJPOPBBJ;

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x60F1AD0", Offset = "0x60F04D0", VA = "0x1860F1AD0")]
	public EGLOHGAPNLB(LOFEKKDNAJB GJFINIAHPMG, NativeArray<EntityRemapUtility.EntityRemapInfo> HPFLJPOPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x84DBB80", Offset = "0x84DA580", VA = "0x1884DBB80")]
	public LocalId CLAHDAOMABJ(LocalId CEFJEHJNIAP)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x84DBB30", Offset = "0x84DA530", VA = "0x1884DBB30")]
	public LocalId CLAHDAOMABJ(int FILGHJLFKAL)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x84DBBC0", Offset = "0x84DA5C0", VA = "0x1884DBBC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DGFLGIKCLCK
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFIMLCADIDL(DOIIIDJCDGH IGCJFNAANOD, [Out] uint EGJGKBPPPFG);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HLOCPMOEBNO(DOIIIDJCDGH IGCJFNAANOD, [Out] uint EGJGKBPPPFG);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NEHCOBEHJNL(DOIIIDJCDGH IGCJFNAANOD, uint EGJGKBPPPFG);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AEFHPHKKFKF(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string KMKCEOJNKPP(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KAHCBNJPPHH(DOIIIDJCDGH IGCJFNAANOD, string EGJGKBPPPFG);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HHDJFCLLEKF(DOIIIDJCDGH IGCJFNAANOD, [Out] string PNOGPECOFOH);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CBDILIIFHMG(DOIIIDJCDGH IGCJFNAANOD, string PNOGPECOFOH);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CDAECHDMKKL
{
	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	Guid AEJJANLNGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	Guid OFCHEEBIPJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EMCCCEPAEOI(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DMIBNEDGPGM(PLOIJFHDLGK CEFJEHJNIAP);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid GLCDDCBKKMD(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFPBLFEJKHK(DOIIIDJCDGH DBDHPICCKFG, Guid KALNIGICCJC);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GMCKKFKFIDJ(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task ILHFNNMFDIF(DOIIIDJCDGH KOAIHIGOIMD, DOIIIDJCDGH DFKFFPKHNCH);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AJMHHHFBAAJ(DOIIIDJCDGH DBDHPICCKFG, GLONLLNEBOJ BHNDAHFKAMK);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface INNKOLIBJFE
{
	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	Guid AEJJANLNGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELMKHCGPIDF(NativeList<Guid> JGPNKKKJNGO, NativeList<Guid> IJJDCNPBEDN, NativeList<FixedString64Bytes> IJMKAHBFKFM);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DNAJLLPKBBD
{
	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LOFEKKDNAJB HAGHPDFEHCD(Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LOFEKKDNAJB AGLNIGBILHC(Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KCNHCNFGDGG(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JIMKFGDOJLK(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IILPCAGJPAI(DOIIIDJCDGH IGCJFNAANOD, [Out] DOIIIDJCDGH MACHCHPNAOL);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LPCFGKBMANI(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CHKIFJFDEED(DOIIIDJCDGH IGCJFNAANOD, int FCNHLPKGBDC);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DOIIIDJCDGH GBMCCEKLPIJ(DOIIIDJCDGH MACHCHPNAOL);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AOKCLIIIPOB(LOFEKKDNAJB PHABLIIPCKL, bool HJMKNMJNEEP);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EHCGCIBHPFN(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JFJHDMCPANJ(DOIIIDJCDGH IGCJFNAANOD, bool JAHGGIKHHEB);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int BJDFMILJGFH();

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NMOAHIGCJLC(DOIIIDJCDGH DBDHPICCKFG);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DBNPHICECAH
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<DOIIIDJCDGH, DOIIIDJCDGH> MOOGANIMPBI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<DOIIIDJCDGH, DOIIIDJCDGH> IHBFELLKJEO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<DOIIIDJCDGH, DOIIIDJCDGH, DOIIIDJCDGH> BKDMKJILBBG;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<DOIIIDJCDGH> HJJCFBIKJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GGCLDMAMKIN(DOIIIDJCDGH DBDHPICCKFG, DOIIIDJCDGH BFLLCEBHHOE);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DOIIIDJCDGH OGLJFEHNDBI(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LOFEKKDNAJB JBPKDIOKNNH(DOIIIDJCDGH DBDHPICCKFG, Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DOIIIDJCDGH FMFFHMMDIJL(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BPPHCNHEPHG(DOIIIDJCDGH DBDHPICCKFG, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HIDPGPGIPIB(DOIIIDJCDGH DBDHPICCKFG, float HIEAAJPFMEJ);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool AAFINPPPLID(DOIIIDJCDGH DBDHPICCKFG, [Out] DOIIIDJCDGH DFKFFPKHNCH);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LFGCNEEEHKO(DOIIIDJCDGH DBDHPICCKFG, [Out] RigidTransform MOIMEELLPAK);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 BDBDPCCCOLB(FOGGMGKJKFM KPDCNGDJNGC);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion JFGBCJCCLLE(FOGGMGKJKFM KPDCNGDJNGC);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class AKCCCLCIIBG
{
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EDIKJCFLPOK
{
	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	object LCGPABNJMKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ECAAEJELJBN
{
	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BANMOKIOOMN(DOIIIDJCDGH CEFJEHJNIAP, MBPJOONFHIE LAHDKLNDKDF);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCLPFGNOIHG(MBPJOONFHIE LAHDKLNDKDF);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JDEOBIPKNBM(DOIIIDJCDGH DBDHPICCKFG, [Out] MBPJOONFHIE NBPPKIOLOAK);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FOLEDAPAPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKCGIGHPNKH(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeArray<DOIIIDJCDGH> FECJDLJBPHF();
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Flags]
public enum FGINLJNLOPK
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
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OJMCBNMIBHI
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public ref struct GHBOFBKEMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ReadOnlySpan<DOIIIDJCDGH> JAOONDAKOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public ReadOnlySpan<DOIIIDJCDGH> AECDOGPIKFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public DOIIIDJCDGH BGGGNMBKIBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public DOIIIDJCDGH IODEEDPLDJC;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GLCDLFOMGNM(DOIIIDJCDGH IGLHNPAEOGC, DOIIIDJCDGH CHGNMPPHIDA);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OLMEMPFDGFK(DOIIIDJCDGH HGDJAIPKJFK, bool FGLPKBNAEFO);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JMDPFPMPPOD(DOIIIDJCDGH BAIOIIGAFGL, DOIIIDJCDGH IGKAOAHNMAL);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DAKAGKEBIAG(DOIIIDJCDGH IKAEKOBLDMB, bool FGLPKBNAEFO);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EJLCEJGHEDB(DOIIIDJCDGH IKAEKOBLDMB);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GAODFFLEPCO(DOIIIDJCDGH IKAEKOBLDMB);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DOIIIDJCDGH ADKFJDAPGBG(DOIIIDJCDGH HGDJAIPKJFK);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ReadOnlySpan<DOIIIDJCDGH> HCLLGMPHJGI(DOIIIDJCDGH IKAEKOBLDMB);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ReadOnlySpan<DOIIIDJCDGH> MKPOGDGEAAI(DOIIIDJCDGH IKAEKOBLDMB);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GHBOFBKEMDO AIKFPLEOKKC(DOIIIDJCDGH IKAEKOBLDMB, float NKMNMPLGGBH, float BMNPNAHBPHC);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HIIDFCELKAF(DOIIIDJCDGH IKAEKOBLDMB, [Out] OKIFHMCAFKN PIABFOHDCDB);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CFIOPKAMCGN(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EHCAMBMEIEN(DOIIIDJCDGH DBDHPICCKFG);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public readonly struct KDFHGKIHPHI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly string FLBFBHGDBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly T KKCMINIPIBD;

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x54E3A50", Offset = "0x54E2450", VA = "0x1854E3A50")]
	public KDFHGKIHPHI(T KKCMINIPIBD, [Optional][CallerMemberName] string FLBFBHGDBLM)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly KDFHGKIHPHI<int> BDHAJLLIACK;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static readonly KDFHGKIHPHI<int> JNAKCOELHNI;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly KDFHGKIHPHI<int> MCPFBLOLNLK;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public enum IPAFOCHIBFI
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class JAIJACBOJPA
{
	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x1486E40", Offset = "0x1485840", VA = "0x181486E40")]
	public static bool GGNGAAHOJMG(this IPAFOCHIBFI BLKFHFCBEDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x189F040", Offset = "0x189DA40", VA = "0x18189F040")]
	public static bool IBAJJAFOOLI(this IPAFOCHIBFI BLKFHFCBEDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x315F4E0", Offset = "0x315DEE0", VA = "0x18315F4E0")]
	public static bool NGKAKDKNPNB(this IPAFOCHIBFI BLKFHFCBEDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x1486E30", Offset = "0x1485830", VA = "0x181486E30")]
	public static bool OLEHFCECEOK(this IPAFOCHIBFI BLKFHFCBEDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PIJJNDAAJKJ
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public enum AGEBFEMOOFN
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

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public enum IHGPAOMCOBG
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	AGEBFEMOOFN IMFKAIGHHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	bool KLFILANLIEE
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	bool LBAAGMNJNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	IHGPAOMCOBG EDBFEDNKPEH
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.Application)]
public interface OGDNDEFAEAO
{
	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	IPAFOCHIBFI CPDMJIDHMBP
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	IPAFOCHIBFI GICKIFLNCPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	IPAFOCHIBFI JIPGLKKHDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	IPAFOCHIBFI BCDPIPBINMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	IPAFOCHIBFI BBLEPMBNJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	IPAFOCHIBFI BENFFEPIKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	IPAFOCHIBFI PNBDLJGIOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	IPAFOCHIBFI JNLKEDNJHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	IPAFOCHIBFI AFFBNLGMPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	IPAFOCHIBFI BJGLCAKKJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	IPAFOCHIBFI BNBGLLPPNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	IPAFOCHIBFI CGNNIHGBEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	IPAFOCHIBFI IIEPGGPKAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	IPAFOCHIBFI FHMOIFALKBM
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	IPAFOCHIBFI HPPNPFDMIIH
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	IPAFOCHIBFI LIKGHBILJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	IPAFOCHIBFI NNADKDONCPB
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	IPAFOCHIBFI GBFEBFGDGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	IPAFOCHIBFI AEIBCHAGCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DHBICMHDGKM(KDFHGKIHPHI<int> CJFJFBGGCAJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KJEJNICMLBO
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event DGFNJLEHBPI.JCJNCFBNPCJ MNHODMMMFPK;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DOIIIDJCDGH MDMCGCEAKPB(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LOFEKKDNAJB DFFMKEOLDJK(Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HJPEFODOPFJ FFGLGJKJCPP(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NLFODIEMHKB(IEnumerable<DOIIIDJCDGH> LDCHCMBMFAM);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HJPEFODOPFJ GPHDJIIOPEG(DOIIIDJCDGH DFKFFPKHNCH, DOIIIDJCDGH GJFINIAHPMG, bool FDNLBLKJGJA, DOIIIDJCDGH IMFCAPGBDGB);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DOIIIDJCDGH OOPAOLMCLLD(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DLABGJNHMMB(DOIIIDJCDGH DBDHPICCKFG, DOIIIDJCDGH DFKFFPKHNCH, bool MMINMGKEIEA = false);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JANBHJKJNLA(DOIIIDJCDGH DBDHPICCKFG, DOIIIDJCDGH DFKFFPKHNCH);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JOGEOCEPBNL(DOIIIDJCDGH DLBKBIJHNEA, DOIIIDJCDGH CDNHMKIJKEE);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	LOFEKKDNAJB FIGFFMOLMDM(DOIIIDJCDGH JGBFCMNOFDB);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NFEAHBFEINE(DOIIIDJCDGH DBDHPICCKFG, DOIIIDJCDGH JHKFKOCPFBC);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LOFEKKDNAJB LDBMPBECFOL(LOFEKKDNAJB IGIDBOEHOLL, FGINLJNLOPK DHGLMDLACKG, Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool MJIHOMBMIHG(DOIIIDJCDGH DBDHPICCKFG, DOIIIDJCDGH MPDPLFNEIAK);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DOIIIDJCDGH HAFCAAONADD(DOIIIDJCDGH IMFCAPGBDGB, DOIIIDJCDGH ANCAJCHGMOC);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool BKLHIFGCCFA(DOIIIDJCDGH IMFCAPGBDGB, DOIIIDJCDGH ANCAJCHGMOC, [Out] DOIIIDJCDGH KKFPIKAFPMB);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "17")]
	DOIIIDJCDGH BHPMOMPLDGK(DOIIIDJCDGH[] PHABLIIPCKL);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DOIIIDJCDGH GLILOAKEJOO(DOIIIDJCDGH DBDHPICCKFG, uint ILKIOMMDLOA);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class DCIOBNPAAML
{
	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x84D8CA0", Offset = "0x84D76A0", VA = "0x1884D8CA0")]
	public static bool BPOKPLLNDNE(this KJEJNICMLBO LANNHJEFEIE, DOIIIDJCDGH DBDHPICCKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x84D8D90", Offset = "0x84D7790", VA = "0x1884D8D90")]
	public static LOFEKKDNAJB LDBMPBECFOL(this KJEJNICMLBO LMPCECBHOAI, DOIIIDJCDGH DBDHPICCKFG, FGINLJNLOPK DHGLMDLACKG, Allocator POJKLAFAMOD)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x84D8D50", Offset = "0x84D7750", VA = "0x1884D8D50")]
	public static LOFEKKDNAJB FOMEHPGIDEG(this KJEJNICMLBO LMPCECBHOAI, DOIIIDJCDGH DBDHPICCKFG, Allocator POJKLAFAMOD)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x84D8C60", Offset = "0x84D7660", VA = "0x1884D8C60")]
	public static LOFEKKDNAJB BHPECOKMCIF(this KJEJNICMLBO LMPCECBHOAI, DOIIIDJCDGH DBDHPICCKFG, Allocator POJKLAFAMOD)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x84D9180", Offset = "0x84D7B80", VA = "0x1884D9180")]
	public static LOFEKKDNAJB MMPJDBCIGPB(this KJEJNICMLBO LMPCECBHOAI, DOIIIDJCDGH DBDHPICCKFG, Allocator POJKLAFAMOD)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x84D8D10", Offset = "0x84D7710", VA = "0x1884D8D10")]
	public static LOFEKKDNAJB CFMBHDKMBPA(this KJEJNICMLBO LMPCECBHOAI, DOIIIDJCDGH DBDHPICCKFG, Allocator POJKLAFAMOD)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x84D91C0", Offset = "0x84D7BC0", VA = "0x1884D91C0")]
	public static LOFEKKDNAJB ODNPHAJKKNF(this KJEJNICMLBO LMPCECBHOAI, DOIIIDJCDGH DBDHPICCKFG, Allocator POJKLAFAMOD)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x84D9020", Offset = "0x84D7A20", VA = "0x1884D9020")]
	public static LOFEKKDNAJB LJGNNAIJIGE(this KJEJNICMLBO LMPCECBHOAI, DOIIIDJCDGH DBDHPICCKFG, Allocator POJKLAFAMOD)
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x84D9060", Offset = "0x84D7A60", VA = "0x1884D9060")]
	public static LOFEKKDNAJB LJGNNAIJIGE(this KJEJNICMLBO LMPCECBHOAI, LOFEKKDNAJB DBDHPICCKFG, Allocator POJKLAFAMOD)
	{
		return default(LOFEKKDNAJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LPAMPPONENL
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x84E9F20", Offset = "0x84E8920", VA = "0x1884E9F20", Slot = "0")]
	Task<OMMEAGIPDJH> JNPJLMAENLD(GJADLJGDNNF LJDLHIFMFNN, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "1")]
	void HLBHGKBEMNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ODIHIJIOMNL
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event DGFNJLEHBPI.JCJNCFBNPCJ MNHODMMMFPK;

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DOIIIDJCDGH OOPAOLMCLLD(DOIIIDJCDGH KOAIHIGOIMD);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<DOIIIDJCDGH> KLNJBIIPEJO();

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<DOIIIDJCDGH> JIMKFEOPAKP(DOIIIDJCDGH DFKFFPKHNCH);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FACLICIEKLD(DOIIIDJCDGH NFEBPMJLICI, DOIIIDJCDGH CGNLLLBAMBE, [Out] HJPEFODOPFJ FMNONJFHKKL);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KGOOCFHCPBM(DOIIIDJCDGH NFEBPMJLICI, DOIIIDJCDGH DNEIGLPPLBO, [Out] HJPEFODOPFJ FMNONJFHKKL);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MNKIPFEOJKK(DOIIIDJCDGH NFEBPMJLICI);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JANBHJKJNLA(DOIIIDJCDGH HIPFMLLMMCJ, DOIIIDJCDGH OGINNIAMBHJ);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HJPEFODOPFJ DFKHMINAPBM(DOIIIDJCDGH DBDHPICCKFG);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FBJPBCBGAIO
{
	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	bool NMDFLJEHKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	bool AHABGHABCFC
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	bool HPKJHHPIOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PALPLMHCMCO
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IBKDCIBLKGJ
{
	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLIMGKPNFLF(DOIIIDJCDGH DBDHPICCKFG, ACDGIJAKCPP OGFGMDINCKP);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDDLFOLNHEB(DOIIIDJCDGH DBDHPICCKFG, ACDGIJAKCPP OGFGMDINCKP);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface AFPNKHOEFPK
{
	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ANIKCFOIBKJ<string> DOGKHGBCCLC(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ANIKCFOIBKJ<string> LIPBEKKOHBN(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KDADGDACMMO(DOIIIDJCDGH DBDHPICCKFG, ANIKCFOIBKJ<string> PGEBFDGIMJK);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJNNCOOGNPE(DOIIIDJCDGH DBDHPICCKFG, ANIKCFOIBKJ<string> PGEBFDGIMJK);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LGMHEBGMBIL(DOIIIDJCDGH CFGFGICNNIE, DOIIIDJCDGH OCLNPKHMBLA);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DHNHLNBFFFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPFFJMIOIIG EHGKNAOFNMM(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFPEOGCHBNE(DOIIIDJCDGH IGCJFNAANOD, EPFFJMIOIIG BFBPGKDBBAC);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AOICEFBLNJM(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLBEKPNKDPE(DOIIIDJCDGH IGCJFNAANOD, bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ANIKCFOIBKJ<string> HIPEGNHNFLI(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLKFDDDFEJN(DOIIIDJCDGH IGCJFNAANOD, ANIKCFOIBKJ<string> PGEBFDGIMJK);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ANIKCFOIBKJ<string> ODBKAAOCDJN(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LDGKPGGLEIH(DOIIIDJCDGH IGCJFNAANOD, ANIKCFOIBKJ<string> PGEBFDGIMJK);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ANIKCFOIBKJ<string> BDKEHDKODNA(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IPKDMLLEGKK(DOIIIDJCDGH IGCJFNAANOD, ANIKCFOIBKJ<string> PGEBFDGIMJK);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ANIKCFOIBKJ<string> DOIONJDCEJC(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FEPGDFKKNNF(DOIIIDJCDGH IGCJFNAANOD, ANIKCFOIBKJ<string> PGEBFDGIMJK);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JILAHBPPFFG(DOIIIDJCDGH IGCJFNAANOD, DOIIIDJCDGH JGGGINODJOB);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JMPPEGFDCII
{
	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEJBHPGOJAE([In] float3 ENKAPPCINPK, [In] float3 PNELABKCNPL, float JFEGIFCHDHH, [Out] APKHGCPDOGB IJBDIAOEPEK, [Out] DOIIIDJCDGH JOBEDKBFIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JGIKMCPHIHE([In] float3 ENKAPPCINPK, float DLJDKOFPIMN, List<DOIIIDJCDGH> PHABLIIPCKL);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JDEOFFEDOPF(Plane[] NNDGJMLGBNH, float3 ENKAPPCINPK, float3 GMDBEAKNONI, quaternion JCDLBIBEGAF, List<DOIIIDJCDGH> PHABLIIPCKL);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CMOJKMCEDPP
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEJBHPGOJAE([In] NativeArray<Entity> JGINDINMFKO, [In] float3 ENKAPPCINPK, [In] float3 PNELABKCNPL, [In] NativeArray<APKHGCPDOGB> HPEIJIKNIJC);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> JGIKMCPHIHE([In] NativeArray<Entity> JGINDINMFKO, [In] float3 ENKAPPCINPK, float DLJDKOFPIMN);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> JDEOFFEDOPF([In] NativeArray<Entity> JGINDINMFKO, [In] NativeArray<float4> CJBOCPGNPBI);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct JAHGBHIFOEO : NDJHBLEGILP, IEquatable<JAHGBHIFOEO>
{
	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	public int ODEBCJMJOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	public int LDLHHBCPGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5300", Offset = "0x2FA3D00", VA = "0x182FA5300", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA52F0", Offset = "0x2FA3CF0", VA = "0x182FA52F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x84E57A0", Offset = "0x84E41A0", VA = "0x1884E57A0", Slot = "8")]
	public bool Equals(JAHGBHIFOEO EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x84E57F0", Offset = "0x84E41F0", VA = "0x1884E57F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct APKHGCPDOGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float AEMEPCOOFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public float3 HKIFHFOHPEK;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PKGALPKLLCE
{
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DHIIJDNMGLD
{
	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	JDIMFMLOFCB NAAAPINGONF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	AOLJNJKJHCN IDBBFKDDJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<LOFEKKDNAJB, NativeArray<RRObjectPrefabData>> HKDLBGLMPAO;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<LOFEKKDNAJB> AFNADDMJKHH;

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LOFEKKDNAJB JPBDOANONBA();

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OKONFNKJCOK BCMBGBBLJKG(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData GHANGPIPIOD(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EENGEIKIGOA(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PLOIJFHDLGK ALIHGPKFLEN(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HCFEBMHFEDJ(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MIIJLKBPOAP(DOIIIDJCDGH DBDHPICCKFG, [Out] Transform EOBBLENOIHL);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DOIIIDJCDGH IGOIIBEKOJM(GLONLLNEBOJ GDPFIJKMJBC);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool GFLAGDMPFKF(GLONLLNEBOJ GDPFIJKMJBC, [Out] DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GLONLLNEBOJ DJKGLHLBFFB(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	LOFEKKDNAJB IGOIIBEKOJM(NativeArray<GLONLLNEBOJ> GDPFIJKMJBC, Allocator POJKLAFAMOD, bool CLCDCKJMLCI = true);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool PLHMIAGKNKD(NativeArray<GLDPOBHOAGN> OLDCHGELJOG, NativeArray<GLONLLNEBOJ> BLOGDHEMDKI, NativeArray<Entity> FGHBLBNBAFH, ANIKCFOIBKJ<GJDFMGBECEI> NANCGJHDIII);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	PLOIJFHDLGK FKLCKNDCOEF();

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	PLOIJFHDLGK EFMPOLEFKDC(RRObjectPrefabData NEEBPDGFOPO, [Optional] PJGPPIKLFJC EJGIGJOCBJE);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	GEHNGAADAJF MCILFGDEJCI();

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	ILLNFBMIGAN FEKGCAHLFFB();

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	OKDELMLPAHC OMAPOFEOGBI(CEHCOOIBKHM IGGIEBIGBCF);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void CICOLPKFKGA(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool GDMIHNOKPGC(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LOFEKKDNAJB CDIBAEEFKPO(LOFEKKDNAJB GPPOFMHMFMP, Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool DBCKAGIKEII(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool BNMNANOKAJL(DOIIIDJCDGH DBDHPICCKFG, ComponentTypes PDJGACEBODO);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "28")]
	DOIIIDJCDGH PHPFKAIKEIB(Transform EOBBLENOIHL);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class OKDPHHGLNCP
{
	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x84EB730", Offset = "0x84EA130", VA = "0x1884EB730")]
	internal static DOIIIDJCDGH CCLPHGAALNL(this Entity EOGGAEBALGK, DHIIJDNMGLD IMEMANHPBAO)
	{
		return default(DOIIIDJCDGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x84EBC70", Offset = "0x84EA670", VA = "0x1884EBC70")]
	public static PLOIJFHDLGK MLMDFFMGDBH(this DHIIJDNMGLD IMEMANHPBAO, LocalId DBDHPICCKFG)
	{
		return default(PLOIJFHDLGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x84EBA20", Offset = "0x84EA420", VA = "0x1884EBA20")]
	public static DOIIIDJCDGH IGOIIBEKOJM(this DHIIJDNMGLD IMEMANHPBAO, LocalId DBDHPICCKFG)
	{
		return default(DOIIIDJCDGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x84EB810", Offset = "0x84EA210", VA = "0x1884EB810")]
	public static GLONLLNEBOJ DJKGLHLBFFB(this DHIIJDNMGLD IMEMANHPBAO, LocalId DBDHPICCKFG)
	{
		return default(GLONLLNEBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x84EBAD0", Offset = "0x84EA4D0", VA = "0x1884EBAD0")]
	public static GEHNGAADAJF MLFOBGBKJHN(this DHIIJDNMGLD IMEMANHPBAO, RigidTransform ABNMGHKPJFE)
	{
		return default(GEHNGAADAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x84EBC80", Offset = "0x84EA680", VA = "0x1884EBC80")]
	public static OKDELMLPAHC NEPPEPGIJBB(this DHIIJDNMGLD IMEMANHPBAO, CEHCOOIBKHM ALEHKFEDHLO, RigidTransform ABNMGHKPJFE)
	{
		return default(OKDELMLPAHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x84EB880", Offset = "0x84EA280", VA = "0x1884EB880")]
	public static ILLNFBMIGAN HICPHNHBAIM(this DHIIJDNMGLD IMEMANHPBAO, RigidTransform ABNMGHKPJFE)
	{
		return default(ILLNFBMIGAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x84EB7E0", Offset = "0x84EA1E0", VA = "0x1884EB7E0")]
	private static void DHNBLKEPHEP(PLOIJFHDLGK ICDOLBBKJDH, RigidTransform ABNMGHKPJFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal interface INNFOCFJEDE
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GBGLLJHFLJD
{
	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	bool FGMFBIAHPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	DOIIIDJCDGH OFOAEOINABB
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	PLOIJFHDLGK CMHKMKNEFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event LLABNNFFBHJ EDIDDMCMGDH;

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DOIIIDJCDGH HAFCAAONADD(DOIIIDJCDGH IMFCAPGBDGB, DOIIIDJCDGH ANCAJCHGMOC);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BKLHIFGCCFA(DOIIIDJCDGH IMFCAPGBDGB, DOIIIDJCDGH ANCAJCHGMOC, [Out] DOIIIDJCDGH KKFPIKAFPMB);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DAGABKFPJGF();

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OBKJEAMEEGE();

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FHFHAHKHDOI(DOIIIDJCDGH IMFCAPGBDGB);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OKLJDIBJKKO(DOIIIDJCDGH IMFCAPGBDGB);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public delegate void LLABNNFFBHJ(PLOIJFHDLGK PKEMCMKAMAA, PLOIJFHDLGK AJBNMLDHIPN);
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class IEEHPEHFCCL
{
	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x84E4750", Offset = "0x84E3150", VA = "0x1884E4750")]
	public static bool NEHGBGOJEFO(this GBGLLJHFLJD CNHFAKOCKCL, PLOIJFHDLGK IMFCAPGBDGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x84E45F0", Offset = "0x84E2FF0", VA = "0x1884E45F0")]
	public static bool EABJJNBMEKE(this GBGLLJHFLJD CNHFAKOCKCL, DOIIIDJCDGH IMFCAPGBDGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x84E46D0", Offset = "0x84E30D0", VA = "0x1884E46D0")]
	public static bool LLLBCBEFLNF(this GBGLLJHFLJD CNHFAKOCKCL, DOIIIDJCDGH IMFCAPGBDGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HEJDJAEEDBC
{
	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJJFKALACKO(NativeList<RRObjectPrefabData> BGJJLCMOAME);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BKIPHBLJMEF
{
	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFALNBHOJIA(PLOIJFHDLGK ICDOLBBKJDH, MOLGCNIPLLK DOFFGKPAKJD, List<PLOIJFHDLGK> CAIABPFCJFC);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int ILEBDIOJGDF(PLOIJFHDLGK ICDOLBBKJDH, MOLGCNIPLLK DOFFGKPAKJD);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEJJHHFKFDK(PLOIJFHDLGK ICDOLBBKJDH, List<PLOIJFHDLGK> CAIABPFCJFC);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GLFKDNIBEKK(PLOIJFHDLGK ICBGFNPAHKN, PLOIJFHDLGK IMFCAPGBDGB, MOLGCNIPLLK DOFFGKPAKJD);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PLOIJFHDLGK EBHLIPHFHCJ(PLOIJFHDLGK ICBGFNPAHKN, int FILGHJLFKAL, MOLGCNIPLLK DOFFGKPAKJD);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCGNNJJFFCG(PLOIJFHDLGK ICBGFNPAHKN, PLOIJFHDLGK IMFCAPGBDGB, MOLGCNIPLLK DOFFGKPAKJD);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JBNIFIJHGEI(PLOIJFHDLGK ICBGFNPAHKN, PLOIJFHDLGK IMFCAPGBDGB, MOLGCNIPLLK DOFFGKPAKJD);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OOMENIDCFEA(PLOIJFHDLGK ICBGFNPAHKN, MOLGCNIPLLK DOFFGKPAKJD);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BKPLMNGDKCO(PLOIJFHDLGK ICBGFNPAHKN, PLOIJFHDLGK IMFCAPGBDGB, MOLGCNIPLLK DOFFGKPAKJD);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FIIOADIJPGC(Entity ICBGFNPAHKN, Entity IMFCAPGBDGB, MOLGCNIPLLK DOFFGKPAKJD);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JAKHHIKJAJM(Entity ICBGFNPAHKN, MOLGCNIPLLK DOFFGKPAKJD);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MBBFNKBGICE(PLOIJFHDLGK IMFCAPGBDGB, MOLGCNIPLLK DOFFGKPAKJD);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EHEECPPDOEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000202")]
	OKHKCEABAOI DMEKHIIMHNH
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
	EFJKAGJCDIF JJKNBIMBDNN(OKHKCEABAOI FPJGDNNEOIB);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OKHKCEABAOI IGBJFGIGNDH();

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OKHKCEABAOI PEPOPBAMKKI();
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BAFDDELEODG
{
	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGGFCMMPLKN(DOIIIDJCDGH IMFCAPGBDGB, [Out] DOIIIDJCDGH HMPENPKBEEN);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MHBCKHOHBBG
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<DOIIIDJCDGH> ACHFLFIFGKA;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EKFIMGLIBGG(DOIIIDJCDGH JGBFCMNOFDB, bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGMMBIOPMCG(DOIIIDJCDGH JGBFCMNOFDB, bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MKLOKLMDHKK(DOIIIDJCDGH JGBFCMNOFDB, int PDKJBMPOMNC);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CKKFMDPFIPM
{
	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<DOIIIDJCDGH> CDHOOBEJPKL(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DOIIIDJCDGH IAJMGFAKNEG(DOIIIDJCDGH DBDHPICCKFG, int FILGHJLFKAL);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int OGMHJJMHDDI(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PGCJEENILJB BIPHJMDDHGP(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GMBCFAKPKDG(DOIIIDJCDGH DBDHPICCKFG, PGCJEENILJB HKENEGGNMIM);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DOIIIDJCDGH EOALEBOAOME(DOIIIDJCDGH DBDHPICCKFG, [Optional] float3? DDIHIBMHCDH, [Optional] quaternion? JCDLBIBEGAF, [Optional] float3? DILGPPEHCGK);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DOIIIDJCDGH OGAIGCMDGNK(DOIIIDJCDGH DBDHPICCKFG, int FILGHJLFKAL, [Optional] float3? DDIHIBMHCDH, [Optional] quaternion? JCDLBIBEGAF, [Optional] float3? DILGPPEHCGK);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OMOOEFJLKLC(DOIIIDJCDGH DBDHPICCKFG, int FILGHJLFKAL);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ELJPNPFCGBK(DOIIIDJCDGH DBDHPICCKFG);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface APOOGKMCCNM
{
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DPELLBILFJB
{
	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFNHBPOKEIC(DOIIIDJCDGH DBDHPICCKFG, ReadOnlySpan<TerrainGenerationLayer> AJAEJLMOKOK);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBHFJCMPIIH(DOIIIDJCDGH DBDHPICCKFG, ReadOnlySpan<ICMIJHNFGBH> AJAEJLMOKOK);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NIICIHIPODE
{
	[Cpp2IlInjected.Token(Token = "0x17000203")]
	bool OPPAGCIHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJNKCJKCDNB();

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GJPMLKDEFEN();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LDEPHOGAHNJ();

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CNPKIHPKLMB();

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCOLJFFBJLN();

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPOPPODDDCP();

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IGPIOCEHDEF();

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GBGNHEOCLJD();

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MBHMKJCICPP();

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JGDCOHNKJMO();

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KNDNIJGKOGO();

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OLIGLBJDBEJ();
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FJANBECNICF
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKLNHLKJMOJ(DOIIIDJCDGH IMFCAPGBDGB, [Out] int ICBGFNPAHKN);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHKKLJJOOCD(DOIIIDJCDGH IMFCAPGBDGB, int ICBGFNPAHKN);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMOFEBMCCIK(DOIIIDJCDGH IMFCAPGBDGB, bool PDBDLDHMLJN);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHOAPEPKMMC(DOIIIDJCDGH IMFCAPGBDGB, float ACIBJMIHJLK, float OHHNBOKBFGD, float PMOPBPMKGGK);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DBHLCNILFOB(DOIIIDJCDGH DBDHPICCKFG, [Out] float OHHNBOKBFGD, [Out] float PMOPBPMKGGK);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIEMAHIFDHN(DOIIIDJCDGH IMFCAPGBDGB, float3 DDIHIBMHCDH, quaternion JCDLBIBEGAF);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GBAJAPAAOOD(DOIIIDJCDGH IMFCAPGBDGB, [Out] float3 DDIHIBMHCDH, [Out] quaternion JCDLBIBEGAF);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBOMEBJKEFC(DOIIIDJCDGH IMFCAPGBDGB);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NPHMHJLBEIO
{
	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGFEMKFBBPA(Entity EOGGAEBALGK, [In] float3 PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 MNGFJCJKOMK(Entity EOGGAEBALGK);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBKJPDCJBHI(Entity EOGGAEBALGK, [In] quaternion PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion KNEHOHMPBFB(Entity EOGGAEBALGK);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OLKEABCEBHE(Entity EOGGAEBALGK, [In] float3 DDIHIBMHCDH, [In] quaternion JCDLBIBEGAF);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEIEEEDOBPJ(Entity EOGGAEBALGK, [Out] RigidTransform DBMAHIKFILD);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void APDJPIEBNDD(Entity EOGGAEBALGK, [In] float3 DDIHIBMHCDH, [In] quaternion JCDLBIBEGAF);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PAJFBJFALAL(Entity EOGGAEBALGK, [Out] float3 DDIHIBMHCDH, [Out] quaternion JCDLBIBEGAF);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PAJFBJFALAL(Entity EOGGAEBALGK, [Out] RigidTransform DBMAHIKFILD);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MOLECGKNJFG(Entity EOGGAEBALGK, float PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float OGBAJPALHHL(Entity EOGGAEBALGK);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KKNCJDFHPOL(Entity EOGGAEBALGK, [In] float3 PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 IHLHAGPJOMJ(Entity EOGGAEBALGK);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HJBDHENBKJP(Entity EOGGAEBALGK, [In] quaternion PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion CBNIIFHLFJC(Entity EOGGAEBALGK);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LBBKHLMOHPI(Entity EOGGAEBALGK, float PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float KNCMMDIHLMI(Entity EOGGAEBALGK);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DEJGLNMHKFP(Entity EOGGAEBALGK, [Out] float4x4 CNNCGMLGFMG);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DPMCAPNBFOC(Entity EOGGAEBALGK, [In] float4x4 CNNCGMLGFMG);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KIJLKKLEOOC(Entity EOGGAEBALGK);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PKBKBHBOGKH(Entity EOGGAEBALGK, Entity LKOPHANLFAH, Entity OGINNIAMBHJ);
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class HFCEDMPGJGB
{
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EMOGDCIALAP
{
	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBDCCHKFEDN(bool MJDKKJPHIGA);
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OKENDFDGJKP
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKKGBMCGGHO(DOIIIDJCDGH IGCJFNAANOD, ANIKCFOIBKJ<string> PGEBFDGIMJK);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIFHKEKCPOA(DOIIIDJCDGH IGCJFNAANOD, ANIKCFOIBKJ<string> PGEBFDGIMJK);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNHBLBOHGMI(DOIIIDJCDGH IGCJFNAANOD, ANIKCFOIBKJ<string> PGEBFDGIMJK);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OEGOBLLGEAI(DOIIIDJCDGH IGCJFNAANOD, ANIKCFOIBKJ<string> PGEBFDGIMJK);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KLPJACBHIBH(DOIIIDJCDGH IGCJFNAANOD, ANIKCFOIBKJ<string> PGEBFDGIMJK);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBKJFOGLGHM(DOIIIDJCDGH IGCJFNAANOD, ANIKCFOIBKJ<string> PGEBFDGIMJK);

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KJGPHNBAMHO(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int ADKHICAHIHJ(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int JFIOHHAHOKL(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MFJNMJILDKH<string> JLDGGDMAMBB(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MAGDJCIOHLE(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MFJNMJILDKH<string> CEAPKMLLEDG(DOIIIDJCDGH IGCJFNAANOD);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GOEFOIMIIBI(DOIIIDJCDGH IGCJFNAANOD, string FLFLJCMPPBA);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MEMKNMLOAAM(string FLFLJCMPPBA, EGHJMECPGFA MAPEEFLOPEK);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DOIIIDJCDGH NAIIEPOHKKI(string FLFLJCMPPBA);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GPEMBHAOAGJ(string FLFLJCMPPBA, EGHJMECPGFA MAPEEFLOPEK);

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ICJFAJKDIAP(DOIIIDJCDGH AGCAEJKFGNF, string FLFLJCMPPBA, EGHJMECPGFA MAPEEFLOPEK);

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "17")]
	MFJNMJILDKH<string> CFIEJENGKPE();
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class EFOHKALFIIK
{
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GIGMHDEMIFI
{
	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World EMIBDGDOMLB(string GOOHHHBKPDL = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World ODPLGNPJMLA(string GOOHHHBKPDL = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World MFLKJIBDMAM(string GOOHHHBKPDL = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World JPDMDOIPMEE(string GOOHHHBKPDL = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KADNMICOHMP
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	World FEPKFIIBDBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	World OAKEEOJHDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	EntityManager HGINAJFEKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	bool GHGHOCPHKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase OJFNOKNPLBE(Type AEOGKDPPBBE);
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public static class LJALOFCHAAB
{
	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x84E8D70", Offset = "0x84E7770", VA = "0x1884E8D70")]
	public static ComponentSystemBase CJNCHAANFNE(this World KBIKMMGHBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x3D46C70", Offset = "0x3D45670", VA = "0x183D46C70")]
	public static T OJFNOKNPLBE<T>(this KADNMICOHMP KGGCBLNLLMA) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AEANKJIHPBN
{
	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOHJKPIDCIB(NativeListAsync<Entity> MOOHHHNPLBA);

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKCJEJCFALM(BGAPDFMFJDF OLEGJLJLKCI);

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBDPDCDEMPD(NativeListAsync<Entity> EABMELFHELN, bool HMOLJENJODI);

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEOCABKHADL();

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OEDGOICNPJA(Entity PJFDNMGHMBL);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OLCAFHLIPPN
{
	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEGDHOPCPKE(Collider LCNIJABNGPK, [Out] OKGBIPKBBLK BLLEPPEDALC);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KLNBHPPMENI
{
	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider JGOICPEJOMB(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject IGJIFLPBGNK(DOIIIDJCDGH CCMHCLDDIOL, GameObject IJAFMJKMLAD, Vector3 GDEEHHOMKPN, Quaternion IEBOBJIHNAD);

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDDBINFHFJM(GameObject LCNIJABNGPK);

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider AKBDPKPGICN<TCollider>(GameObject FPIIPJDLGBE) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EMICMMECIHN(Collider LCNIJABNGPK);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject CAOIEEJDDAA<TCollider>(string FLBFBHGDBLM) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OJDIDKEHKMJ OHIBBPGPBEM(DOIIIDJCDGH NBHMDDAOLDE, DOIIIDJCDGH JIPMGLMINBE, CEHCOOIBKHM PFGHCLLGPHJ, float3 LMLHNFFNGFO, quaternion GEIJKBFBBOD, float3 MJPFPFEKNPP);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EEOCCMIALLM(DOIIIDJCDGH DBDHPICCKFG, [Out] OJDIDKEHKMJ LCNIJABNGPK);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EOABOICKFIE(DOIIIDJCDGH DBDHPICCKFG, [Out] DOIIIDJCDGH PJFDNMGHMBL);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public enum JBCJCNIJMBP
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
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IFINCDNNFCN
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public struct FNKIILAJNFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int PFGHCLLGPHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GameObject IJAFMJKMLAD;
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJAMHJJLGPF(DOIIIDJCDGH DBDHPICCKFG, GFOOGNIAEFA BDKCCAKNBAD, bool OIAHPJMFDKK, GCGINMLPDDC IAGCNPKGHDD);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGKKAKMEDKK(DOIIIDJCDGH DBDHPICCKFG, GFOOGNIAEFA BDKCCAKNBAD, bool OIAHPJMFDKK, bool GFCCNFEINML, bool EFIFMBKHOBF);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LAIHCKFDDGH GGDMKOIPHHJ(DOIIIDJCDGH PJFDNMGHMBL, List<DOIIIDJCDGH> CJNCFLACPJC);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OJDIDKEHKMJ ACCILKILCIL(GameObject PPJHOJOFGGN, GameObject IAMBFFGBKGI);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPFLDMBBJHI(GameObject PPJHOJOFGGN, List<GameObject> HDMEFMKKEEL);

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JKFCIFAIHMM(GameObject IAMBFFGBKGI);

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T AKBDPKPGICN<T>(GameObject FPIIPJDLGBE) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EMICMMECIHN(Collider LCNIJABNGPK);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject OLAKCMGIGNO<T>(string FLBFBHGDBLM) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FNJGCIJOLAM(Collider LCNIJABNGPK, [Out] DOIIIDJCDGH ICBGFNPAHKN);

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DPCAJONNNJH(DOIIIDJCDGH DBDHPICCKFG, [Out] OKGBIPKBBLK BLLEPPEDALC);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<JBCJCNIJMBP> MFAKPGOBOPE(Allocator POJKLAFAMOD = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] CPJHAMNNEEG();
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface APALFNPPLAA
{
	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGEKGIEHAKM(DOIIIDJCDGH DBDHPICCKFG, DOIIIDJCDGH PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMMIACLMIFE(DOIIIDJCDGH DBDHPICCKFG, DOIIIDJCDGH PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JHPJJMAMJBO(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DOIIIDJCDGH BODPJDOINLI(DOIIIDJCDGH DBDHPICCKFG, int FILGHJLFKAL);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LOFEKKDNAJB LHJFEJDPEMN(DOIIIDJCDGH DBDHPICCKFG, Allocator POJKLAFAMOD = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GKHAMLBJPBL(DOIIIDJCDGH DBDHPICCKFG, object DHNMCOFINFM, DOIIIDJCDGH PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EJIOBCACDEK(DOIIIDJCDGH DBDHPICCKFG, object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LHJJFGMKLBD(DOIIIDJCDGH DBDHPICCKFG, [Out] DOIIIDJCDGH PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JIKKMGDGFBE(DOIIIDJCDGH DBDHPICCKFG, float3 PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JHBPGFIGAGM(DOIIIDJCDGH DBDHPICCKFG, [Out] float3 PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JCFILPLFICK(DOIIIDJCDGH DBDHPICCKFG, float3 PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BOOHCNDCOJI(DOIIIDJCDGH DBDHPICCKFG, [Out] float3 PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NODAADBGHNG(DOIIIDJCDGH DBDHPICCKFG, (Quaternion rot, Vector3 moments) PGJAAKEMFIF);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool AJFHNOFCMDD(DOIIIDJCDGH DBDHPICCKFG, [Out] quaternion FDGBFBGBCCA, [Out] float3 HGKHGEAPIIB);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GDAHCOBPOKN(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 OAGDCJNHFAH(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 GPECHBEJJIF(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GLIKKDOLFGB(DOIIIDJCDGH DBDHPICCKFG, float3 PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NDLBCNLPFPF(DOIIIDJCDGH DBDHPICCKFG, float3 PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float CBONPCGLPEH(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float DIHBDCDFPHC(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IJIIPCPLNOG(DOIIIDJCDGH DBDHPICCKFG, float PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PNGMILOBEAM(DOIIIDJCDGH DBDHPICCKFG, float PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode OPHAIAOFIKF(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NMCFGDLHPBL(DOIIIDJCDGH DBDHPICCKFG, CollisionDetectionMode PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "25")]
	OGPMHIGIIEC NBIMGKJIPGN(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FCIJECGJLCP(DOIIIDJCDGH DBDHPICCKFG, OGPMHIGIIEC PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool NDKBFAAKKJC(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MBDCCEPBDIM(DOIIIDJCDGH DBDHPICCKFG, bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(Slot = "29")]
	DOIIIDJCDGH MDMCGCEAKPB(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void HLJOHADCEGI(DOIIIDJCDGH DBDHPICCKFG, DOIIIDJCDGH PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DOIIIDJCDGH OOPAOLMCLLD(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void DLABGJNHMMB(DOIIIDJCDGH DBDHPICCKFG, DOIIIDJCDGH PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	EJPCFNJKDCP AEJOFGNEJEL(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void KMBJGEDMMKE(DOIIIDJCDGH DBDHPICCKFG, EJPCFNJKDCP PNNMBEKNGNK);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool NIJPHGCAJNJ(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void LCFHABDOGPK(DOIIIDJCDGH DBDHPICCKFG, bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool HOGKJNPAOPB(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void LIDJDJKAEFH(DOIIIDJCDGH DBDHPICCKFG, bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints BHGKHEKGGBO(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void MAODKNCPBJC(DOIIIDJCDGH DBDHPICCKFG, RigidbodyConstraints PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float OHDGEMGPBKF(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void NICMLOOICKO(DOIIIDJCDGH DBDHPICCKFG, float PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float NOPHACFKHOA(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void BNFEHBLKJNE(DOIIIDJCDGH DBDHPICCKFG, float PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool FAMFAKOLCDM(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void MDLFKILAPNC(DOIIIDJCDGH DBDHPICCKFG, bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool KIILCCIEICC(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void JBDMEJFFEID(DOIIIDJCDGH DBDHPICCKFG, bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void PPDLBMIKKLK(DOIIIDJCDGH DBDHPICCKFG, int PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "50")]
	DGLAKMOPOGI CALPBBONIJG(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void IDHJOAFDDNM(DOIIIDJCDGH DBDHPICCKFG, DGLAKMOPOGI PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	OHIMHKLKCME JHIMDBBBKMI(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void MHDANAMGIPC(DOIIIDJCDGH DBDHPICCKFG, OHIMHKLKCME PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float JHHNBAOKEJM(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void AIFEBKOOBHE(DOIIIDJCDGH DBDHPICCKFG, float PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void NFIBGINDODG(DOIIIDJCDGH DBDHPICCKFG, object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void ENMOOGEPPGP(DOIIIDJCDGH DBDHPICCKFG, object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool LALFPMIJJHO(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void LBOMBJOKPPC(DOIIIDJCDGH DBDHPICCKFG, object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void LEKFMCFBBLO(DOIIIDJCDGH DBDHPICCKFG, object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool EBHFAMLGOAA(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool DFJHOHFFLIG(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody CHJFJAOKDON(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void JLCOIGNNMNC(DOIIIDJCDGH DBDHPICCKFG, Rigidbody HKGICDHJGKC);

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void ANLADLKBIOP(DOIIIDJCDGH DBDHPICCKFG, object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void IFCMEPJHFFK(DOIIIDJCDGH DBDHPICCKFG, object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool DLPMLLPMOBN(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void JHGMAONBJAI(DOIIIDJCDGH DBDHPICCKFG, float3 GINLPEHDJCD);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void HEEFAPKJOON(DOIIIDJCDGH DBDHPICCKFG, float3 JMCMALMHEEL);

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool OKGDOBAKEKP(DOIIIDJCDGH DBDHPICCKFG, [Out] float3 GINLPEHDJCD);

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool DJLHJKDCMAH(DOIIIDJCDGH DBDHPICCKFG, [Out] float3 JMCMALMHEEL);

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool HPPMJJEPHIO(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void PHALPOHFDID(DOIIIDJCDGH DBDHPICCKFG, object DHNMCOFINFM, bool MMPDJFBCAKB);

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void PMCKPFBEOGM(DOIIIDJCDGH DBDHPICCKFG, bool KLMMIELBKEM);

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void GJINOCILDGM(DOIIIDJCDGH DBDHPICCKFG);

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool APOAEFIPLKB(DOIIIDJCDGH DBDHPICCKFG);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface COLLNPPICAB
{
	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DECAGMGJKGJ(Entity CCDHJKAEDOI);

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIMEIPCKLNC(Entity CCDHJKAEDOI);

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADALEGKFCBL(Entity CCDHJKAEDOI);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LCGIFCAJNGH
{
	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNENGCOGGCP(DOIIIDJCDGH IMFCAPGBDGB, bool HINHBDEIAPH);
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public delegate void JKBNHGFOACK(FFEAKFFOGIJ EBJKPBCMCBL);
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly ref struct FFEAKFFOGIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly LOFEKKDNAJB FEJGIMFCBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly NativeArray<byte> PDLJHJDBNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly NativeArray<byte> ACIGMOOOIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly ACDGIJAKCPP OGFGMDINCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly int MHJPKMPFDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly Type LFONINCANLG;

	[Cpp2IlInjected.Token(Token = "0x17000208")]
	public LOFEKKDNAJB LEPFNHKEBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x5576E10", Offset = "0x5575810", VA = "0x185576E10")]
		get
		{
			return default(LOFEKKDNAJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000209")]
	public int NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x84DECC0", Offset = "0x84DD6C0", VA = "0x1884DECC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	public ACDGIJAKCPP GKMJJHFHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xAA3B30", Offset = "0xAA2530", VA = "0x180AA3B30")]
		get
		{
			return default(ACDGIJAKCPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x84DECE0", Offset = "0x84DD6E0", VA = "0x1884DECE0")]
	public FFEAKFFOGIJ(LOFEKKDNAJB FEJGIMFCBLB, NativeArray<byte> PDLJHJDBNHG, NativeArray<byte> ACIGMOOOIGK, ACDGIJAKCPP OGFGMDINCKP, int MHJPKMPFDIN, Type LFONINCANLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C52900", Offset = "0x3C51300", VA = "0x183C52900")]
	public NativeArray<T> GFJPPGJFOCP<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C52940", Offset = "0x3C51340", VA = "0x183C52940")]
	public NativeArray<T> OAHPKHCCGJP<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C52810", Offset = "0x3C51210", VA = "0x183C52810")]
	public (LOFEKKDNAJB, NativeArray<T>, NativeArray<T>) DHBICMHDGKM<T>() where T : struct
	{
		return default((LOFEKKDNAJB, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x84DEC90", Offset = "0x84DD690", VA = "0x1884DEC90")]
	public HMNHIPIDOGN BFGFEJMLNDA()
	{
		return default(HMNHIPIDOGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface DCFKIBBCKEK
{
	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	string IOFMKKPLKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	DCFKIBBCKEK AHCNFCNCLLM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	IEnumerable<DCFKIBBCKEK> NAJPAPPKBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PGPKIMIBBBH
{
	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	DCFKIBBCKEK GOENJHLPJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	NativeArray<ACDGIJAKCPP> FPKIHPELLMD
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MLOBIMLPHGK(ACDGIJAKCPP OGFGMDINCKP, [Out] DCFKIBBCKEK KIJPAPAKCDB);

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MAJNBNPDEEJ(ACDGIJAKCPP OGFGMDINCKP, JKBNHGFOACK LJEMBEMJMEI);

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPOFHABEGHF(ACDGIJAKCPP OGFGMDINCKP, JKBNHGFOACK LJEMBEMJMEI);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NANLLEODKEM
{
	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MAJNBNPDEEJ(ACDGIJAKCPP OGFGMDINCKP, JKBNHGFOACK LJEMBEMJMEI);

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPOFHABEGHF(ACDGIJAKCPP OGFGMDINCKP, JKBNHGFOACK LJEMBEMJMEI);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class MNBGLKIIBHJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NEOOHGFDDDF
{
	[Cpp2IlInjected.Token(Token = "0x17000210")]
	bool KGAKDNDHBLK
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	GNDEOPOHCNN IKNCAHLELJE
	{
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KGIMLKIOEMB(EFJKAGJCDIF GDPFIJKMJBC, bool POAPCHFADIM);

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FOMGFMIJMFH(GLONLLNEBOJ GDPFIJKMJBC, ACDGIJAKCPP OGFGMDINCKP);

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CHJOFHHNAEG(NativeArray<GLONLLNEBOJ> HOEPPEEICBO);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class EMIONEFMOFB
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public readonly ref struct HMNHIPIDOGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly FFEAKFFOGIJ GPCDCFCPGFK;

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public LOFEKKDNAJB LEPFNHKEBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x5576E10", Offset = "0x5575810", VA = "0x185576E10")]
		get
		{
			return default(LOFEKKDNAJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x84E3B60", Offset = "0x84E2560", VA = "0x1884E3B60")]
	public HMNHIPIDOGN(FFEAKFFOGIJ GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x84E3900", Offset = "0x84E2300", VA = "0x1884E3900")]
	public LOFEKKDNAJB GFJPPGJFOCP()
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x84E3A30", Offset = "0x84E2430", VA = "0x1884E3A30")]
	public LOFEKKDNAJB OAHPKHCCGJP()
	{
		return default(LOFEKKDNAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x84E3610", Offset = "0x84E2010", VA = "0x1884E3610")]
	public (LOFEKKDNAJB, LOFEKKDNAJB, LOFEKKDNAJB) DHBICMHDGKM()
	{
		return default((LOFEKKDNAJB, LOFEKKDNAJB, LOFEKKDNAJB));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class BIMDHFCEPGL
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public readonly struct GNDEOPOHCNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly NativeBitArray FCPMCEIMHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly NativeParallelHashMap<GLONLLNEBOJ, int> IBECKCLBJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly NativeParallelHashSet<EFJKAGJCDIF> DINHPFGFHOC;

	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public bool MMLLLFGGMIP
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x84E1E60", Offset = "0x84E0860", VA = "0x1884E1E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public bool KGAKDNDHBLK
	{
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x84E2070", Offset = "0x84E0A70", VA = "0x1884E2070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x6165710", Offset = "0x6164110", VA = "0x186165710")]
	public GNDEOPOHCNN(NativeBitArray FCPMCEIMHKF, NativeParallelHashMap<GLONLLNEBOJ, int> IBECKCLBJNI, NativeParallelHashSet<EFJKAGJCDIF> DINHPFGFHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x84E1E80", Offset = "0x84E0880", VA = "0x1884E1E80")]
	public bool FOMGFMIJMFH(GLONLLNEBOJ GDPFIJKMJBC, ACDGIJAKCPP OGFGMDINCKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GGBAIAFIMNO
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	BCPAHBIDOOE EIBIJGCPJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JMOODFAEOHK
{
	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BBDNJCFFDCI(DOIIIDJCDGH DBDHPICCKFG, ABPGLBAPOBA PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ELNDNCAALDE KBIHNLHIJLP();
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IHKHMFAFANA
{
	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILDBJBAOJBM(World KBIKMMGHBHO);

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHHMKJAPIPJ(World KBIKMMGHBHO);

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase BNEGLDGCILF(World KBIKMMGHBHO);

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LBMJIIAEDHG(World KBIKMMGHBHO);

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDCMMDANGBK(World KBIKMMGHBHO);

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ADEMAGJJIOE(World KBIKMMGHBHO);

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMPFEFPMKAO(World KBIKMMGHBHO);

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> IJDALHCPLMB();
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OBJBHEGBLJM
{
	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCHJPJLMEBN(DOIIIDJCDGH JGBFCMNOFDB, bool PDKJBMPOMNC);
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public readonly struct DKEPLLNOHAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly IEnumerable<DGKKPALGMNJ> AMKMJDEHLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly IReadOnlyList<GameObject> LJCHIKBFBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly IReadOnlyList<int> BJNOGAMKCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly IReadOnlyList<(GLONLLNEBOJ, GLONLLNEBOJ)> ANECEGPJOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly int BLNNFNLEPAN;
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public struct AELEGMMOBKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public InventionIdData EGJGKBPPPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public InventionInstanceIdData BBFCPIAJNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public bool GCKJMLAODIF;

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x84D5700", Offset = "0x84D4100", VA = "0x1884D5700")]
	public AELEGMMOBKD(long EGJGKBPPPFG, Guid BBFCPIAJNKC, bool GCKJMLAODIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[ServiceLifetime(Lifetime.Application)]
public interface HDPOMMJLIMJ
{
	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMMEAGIPDJH DHKNGMBBCFH(GJADLJGDNNF NKKFEAKKHEH, int HKMFODDFBIF = 0, bool BMICIIHDEKC = false);

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LJOPGOMDIAG MJBDGAACGGE(GJADLJGDNNF NKKFEAKKHEH, DOIIIDJCDGH DFKFFPKHNCH, [In] UniformTRS DPAOJPABNCJ, OEGLEFCJPOH LJKIMKGBIEO, [Optional] AELEGMMOBKD FKMCKPMGGDM, bool NCGIDDKKMPP = true, bool CBNNAEOOFMO = false, bool BMICIIHDEKC = false, bool LOEPGKAOEOD = false);

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IOMNDPDPOCC DALGIJKEBBN();

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IOMNDPDPOCC LHNKACBILMO(LOFEKKDNAJB PHABLIIPCKL, [In] UniformTRS OKFNAOJBKNB, [Optional] OEGLEFCJPOH MFFNLDMFHPI);

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GINOJLAJKMA(DOIIIDJCDGH CGBNECCHAOJ);

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ALJDCBADOGM(DOIIIDJCDGH CGBNECCHAOJ, [Out] Exception CMHNFFEOOMC);

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<GLONLLNEBOJ> OLODMIJLINH(DOIIIDJCDGH CGBNECCHAOJ, Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<GLONLLNEBOJ> IGJABLNKGFB(DOIIIDJCDGH CGBNECCHAOJ, Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LOFEKKDNAJB IDNLMHMABFB(DOIIIDJCDGH CGBNECCHAOJ, Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LOFEKKDNAJB OLBIIHPCANG(DOIIIDJCDGH CGBNECCHAOJ, Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LOFEKKDNAJB OMGDEENHLMH(DOIIIDJCDGH CGBNECCHAOJ, Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> FOEPCEBIBJO(DOIIIDJCDGH CGBNECCHAOJ, Allocator POJKLAFAMOD);

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NKMBHDIMNOC(DOIIIDJCDGH CGBNECCHAOJ);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int FNLJNCPHMHF(DOIIIDJCDGH CGBNECCHAOJ, int CDCPIGCEABM);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[ServiceLifetime(Lifetime.Application)]
public interface OOHBKIHOIDE
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0xF3F300", Offset = "0xF3DD00", VA = "0x180F3F300", Slot = "0")]
	bool NGIANNPEOKC(object EOOLELFGEAP, FEDJPCMCMDH IPJMLGAMPFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public static class CFPGLKHHEOE
{
	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x84D8580", Offset = "0x84D6F80", VA = "0x1884D8580")]
	public static bool NGIANNPEOKC(this OOHBKIHOIDE LMPCECBHOAI, object EOOLELFGEAP, [Out] FEDJPCMCMDH IPJMLGAMPFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public enum COGNMOAPOGG : byte
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
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface FEDJPCMCMDH
{
	[Cpp2IlInjected.Token(Token = "0x17000216")]
	KGFDMHCLJEN MMPEDFAPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	IOMKCHPPNFJ GHKKOHGBCJH
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	bool MMBPHEGCEGO
	{
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	bool GFDHDOKBFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object EMLJCHLDAPI();

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x10ADA40", Offset = "0x10AC440", VA = "0x1810ADA40", Slot = "5")]
	(IOMKCHPPNFJ, Dictionary<object, object>) CKNLALMAKGA()
	{
		return default((IOMKCHPPNFJ, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "6")]
	(GLONLLNEBOJ, IOMKCHPPNFJ) CPMBDDGOAOH()
	{
		return default((GLONLLNEBOJ, IOMKCHPPNFJ));
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "7")]
	MPIEEGKHNJN<(GLONLLNEBOJ, IOMKCHPPNFJ)> DOCHNLAHOAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x10ADA40", Offset = "0x10AC440", VA = "0x1810ADA40", Slot = "8")]
	(NHCIMHIBDKO, byte[]) JDLMOCOABAE()
	{
		return default((NHCIMHIBDKO, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x10ADA40", Offset = "0x10AC440", VA = "0x1810ADA40", Slot = "9")]
	(CFBDNFNKFAC, byte[]) HKLDIJDCLAI()
	{
		return default((CFBDNFNKFAC, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x10ADA40", Offset = "0x10AC440", VA = "0x1810ADA40", Slot = "10")]
	T GEBGILCMHBL<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class NOIOOCAPGGA
{
	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x84EB2A0", Offset = "0x84E9CA0", VA = "0x1884EB2A0")]
	public static bool NJGMEDNFJNO(this FEDJPCMCMDH GFNNIJMCMJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface AAOKEGIPODC : MPIEEGKHNJN<LINIDGPLNHA>
{
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[DefaultMember("Item")]
public interface MPIEEGKHNJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	T EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	int NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public enum KGFDMHCLJEN : byte
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
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public enum NHCIMHIBDKO : uint
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
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public static class BLGGJHEPOMP
{
	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x84D7290", Offset = "0x84D5C90", VA = "0x1884D7290")]
	public static GLONLLNEBOJ GFPIAILIFHO(this ADDEEKAABMM GPCDCFCPGFK)
	{
		return default(GLONLLNEBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x84D7240", Offset = "0x84D5C40", VA = "0x1884D7240")]
	public static GLONLLNEBOJ FFKFJGEGKOL([In] this ADDEEKAABMM GPCDCFCPGFK)
	{
		return default(GLONLLNEBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x845B8A0", Offset = "0x845A2A0", VA = "0x18845B8A0")]
	public static GLONLLNEBOJ CNILPLIFPIA(this ADDEEKAABMM GPCDCFCPGFK)
	{
		return default(GLONLLNEBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x845B8A0", Offset = "0x845A2A0", VA = "0x18845B8A0")]
	public static ViewId KNBCPMMFHEL(this ADDEEKAABMM GPCDCFCPGFK)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x84D7360", Offset = "0x84D5D60", VA = "0x1884D7360")]
	public static FixedString64Bytes IJGPKNCMBBP(this EFJKAGJCDIF EGJGKBPPPFG)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x84D6FB0", Offset = "0x84D59B0", VA = "0x1884D6FB0")]
	public static FixedString64Bytes AHGBGLECPFD(this GLONLLNEBOJ EGJGKBPPPFG)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x84D72D0", Offset = "0x84D5CD0", VA = "0x1884D72D0")]
	public static FixedString32Bytes IJGPKNCMBBP(this Entity EOGGAEBALGK)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PGFOBOHGOLO : IOPBPKHIHNL
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public enum KJPBOELJJKF
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
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NFIDLDGKMNC
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<object> HIMCLPBGDFK;

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "2")]
	void JGJOBOLFBMA(object EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "3")]
	void MBNGADLNGKA(CFBDNFNKFAC PEIDNFHKHFH, ReadOnlySpan<byte> EEMEEFCIEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	void AHGOANDAPOA(NHCIMHIBDKO AEOGKDPPBBE, ReadOnlySpan<byte> EEMEEFCIEHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GDOCBOIMJFI
{
	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CFBDNFNKFAC MBJGKODEIHA(ReadOnlySpan<byte> EEMEEFCIEHD);
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KFLEGKIAMCI
{
	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMGJGGCFJBG(CFBDNFNKFAC LNBCHJPEENA, ReadOnlySpan<byte> EEMEEFCIEHD);

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPMNNLPMGFJ(ReadOnlySpan<CFBDNFNKFAC> GPMBNCFHOEM);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public struct OMBDCEEGFNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public CFBDNFNKFAC PEIDNFHKHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public ReadOnlyMemory<byte> EEMEEFCIEHD;
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct CFBDNFNKFAC
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static CFBDNFNKFAC MIPLDCGPOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public EFJKAGJCDIF IPENDGIIFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public int OJLLGMLGEBP;

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public static EFJKAGJCDIF GAHJNKFJHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x84D81F0", Offset = "0x84D6BF0", VA = "0x1884D81F0")]
		get
		{
			return default(EFJKAGJCDIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x55763A0", Offset = "0x5574DA0", VA = "0x1855763A0")]
	public CFBDNFNKFAC(EFJKAGJCDIF IPENDGIIFGC, int OJLLGMLGEBP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x84D83B0", Offset = "0x84D6DB0", VA = "0x1884D83B0")]
	public static bool JJNADAGGMDE([In] CFBDNFNKFAC HEOFBNHHDGF, [In] CFBDNFNKFAC HEGCIIKIHGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x84D8240", Offset = "0x84D6C40", VA = "0x1884D8240", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x84D8350", Offset = "0x84D6D50", VA = "0x1884D8350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x84D8440", Offset = "0x84D6E40", VA = "0x1884D8440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x84D8340", Offset = "0x84D6D40", VA = "0x1884D8340")]
	public void GNAIPCHGPNM([Out] EFJKAGJCDIF CDBGILBOAEE, [Out] int OJLLGMLGEBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public static class LIOCCMEHBOH
{
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public struct DGKKPALGMNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Guid DNLDANFOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public string JOPFFGOACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Vector3 DDIHIBMHCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public Quaternion JCDLBIBEGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Vector3 DILGPPEHCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public int NGOAODNOIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public PJGPPIKLFJC HKENEGGNMIM;

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x84D9200", Offset = "0x84D7C00", VA = "0x1884D9200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public enum GECJFJIOFNK
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
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public static class MFMLNJGOHLM
{
	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x84EA600", Offset = "0x84E9000", VA = "0x1884EA600")]
	public static bool KFIGOONPOBF(this GECJFJIOFNK AEOGKDPPBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x84EA5F0", Offset = "0x84E8FF0", VA = "0x1884EA5F0")]
	public static bool GKCGDCBPFJO(this GECJFJIOFNK AEOGKDPPBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x84EA620", Offset = "0x84E9020", VA = "0x1884EA620")]
	public static bool KGLHGAODKOG(this GECJFJIOFNK AEOGKDPPBBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
[Flags]
public enum EHODCFCEKKL
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
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public interface OEGLEFCJPOH
{
	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MMCNBMPLEJJ([In] Guid GJFINIAHPMG, [Out] Guid ADMLFNMDFNO);
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[Flags]
public enum EGNFDJEKGNF
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
[Cpp2IlInjected.Token(Token = "0x2000100")]
public interface IOMNDPDPOCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	ODAIBDJOOLM GEHGJAKKIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString GNBNNCIHKHM();
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public enum BCPEDKJCFKD
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct FDMLFIJKGNN : ISystemStateComponentData, IComponentData, IEquatable<FDMLFIJKGNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public float3 EKBNCIHBCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public float3 FDAFKECJFBA;

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x84DEC10", Offset = "0x84DD610", VA = "0x1884DEC10", Slot = "4")]
	public bool Equals(FDMLFIJKGNN EFNHKCDKOGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HEHCMEDKPKO
{
	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<DOIIIDJCDGH> NKDEKLDLDPF(DOIIIDJCDGH IKAEKOBLDMB);

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NMJNLAIGGAL(DOIIIDJCDGH AIGBIFOPBPM, [Out] DOIIIDJCDGH PGOEMIMHKDL);
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MKEFDBLBGOG
{
	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFJGGAEJHMO(long AADBLGJCAAH);

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPCPJNJLFEG(NativeParallelHashSet<long> HDAKJGJEKDC);

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJIJEFHPKAF(World KBIKMMGHBHO, NativeParallelHashMap<Guid, long> DIDFJPIPDBI);

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JPAMCFGJNLE(GLONLLNEBOJ GDPFIJKMJBC);

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MOOOLJHDMFK(GLONLLNEBOJ GDPFIJKMJBC, [Out] Guid MMMOCHECPDI, [Out] long AADBLGJCAAH);

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEKAPGILBKF(GLONLLNEBOJ GDPFIJKMJBC, Guid MMMOCHECPDI, long AADBLGJCAAH);

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ADBDDLPDFNL(Guid MMMOCHECPDI);

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BFNPOKAEDJA(Guid MMMOCHECPDI, [Out] int DEEHGACKHNO, [Out] int MNDPOKCJCJH);

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HPHGPLHJMAM(Guid MMMOCHECPDI, int DEEHGACKHNO, int MNDPOKCJCJH);

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PDNCJFLPMKP(Guid MMMOCHECPDI);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000105")]
public class IFNBIANOKDF
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IFNBIANOKDF()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
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
